using System;
using System.Drawing;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace DirectXPInvoke
{
	public class Program
	{		
		public delegate IntPtr WndProcDelegate(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);
		
		public static IntPtr WndProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam)
		{
			switch (msg)
			{
				case 0x0010: // WM_CLOSE
					Win32.DestroyWindow(hWnd);
					break;
				case 0x0002: // WM_DESTROY
					Win32.PostQuitMessage(0);
					break;				
			}
			
			return Win32.DefWindowProc(hWnd, msg, wParam, lParam);
		}
		
		const uint CUSTOMFVF = (uint)(D3DFVF.D3DFVF_XYZRHW | D3DFVF.D3DFVF_DIFFUSE);
		
		[StructLayout(LayoutKind.Sequential)]
		public struct CUSTOMVERTEX
		{
			public float x, y, z, rhw;
			public uint color;
		}
	
		public static void Main(string[] args)
		{
			string szClassName = "D3D9CSharpDemoWindow";
			IntPtr hInstance = System.Diagnostics.Process.GetCurrentProcess().Handle;
			
			WNDCLASSEX wc = new WNDCLASSEX();
			
			wc.cbSize			= Marshal.SizeOf(typeof(WNDCLASSEX));
			wc.style			= 0;
			wc.lpfnWndProc		= Marshal.GetFunctionPointerForDelegate((Delegate)(WndProcDelegate) WndProc);
			wc.cbClsExtra		= 0;
			wc.cbWndExtra		= 0;
			wc.hInstance		= hInstance;
			wc.hIcon			= Win32.LoadIcon(IntPtr.Zero, new IntPtr(32512)); // IDI_APPLICATION
			wc.hCursor			= Win32.LoadCursor(IntPtr.Zero, 32512); // IDC_ARROW
			wc.hbrBackground	= Win32.GetStockObject(0); // (HBRUSH)(COLOR_WINDOW+1);
			wc.lpszMenuName		= null;
			wc.lpszClassName	= szClassName;
			wc.hIconSm			= Win32.LoadIcon(IntPtr.Zero, new IntPtr(32512)); // IDI_APPLICATION
			
			ushort regClassName = Win32.RegisterClassEx(ref wc);
			
			if (regClassName == 0)
			{
				int lastError = Marshal.GetLastWin32Error();  
				string errorMessage = new Win32Exception(lastError).Message;  
				Win32.MessageBox(IntPtr.Zero, errorMessage, "Class Error", 0x00000030L | 0x00000000L); // MB_ICONINFORMATION | MB_OK
				return;
			}
			
			IntPtr hwnd = Win32.CreateWindowEx(
				0,
				regClassName,
				"DirectX using C#",
				0x00000000L | 0x00C00000L | 0x00080000L | 0x00040000L | 0x00020000L | 0x00010000L | 0x10000000L, // WS_OVERLAPPEDWINDOW | WS_VISIBLE
				320, // CW_USEDEFAULT
				160, // CW_USEDEFAULT
				640,
				480,
				IntPtr.Zero, 
				IntPtr.Zero, 
				hInstance, 
				IntPtr.Zero);

			if (hwnd == IntPtr.Zero)
			{
				int lastError = Marshal.GetLastWin32Error();  
				string errorMessage = new Win32Exception(lastError).Message;  
				Win32.MessageBox(IntPtr.Zero, errorMessage, "Window Error", 0x00000030L | 0x00000000L); // MB_ICONINFORMATION | MB_OK
				return;
			}
			
			int nCmdShow = 1; // SW_NORMAL
			
			Win32.ShowWindow(hwnd, nCmdShow);
			Win32.UpdateWindow(hwnd);
			
			IntPtr d3dPtr = D3D.Direct3DCreate9(D3D.D3D_SDK_VERSION);

			if (d3dPtr == IntPtr.Zero)
			{
				throw new Exception("Failed to create IDirect3D9");
			}
			
			IDirect3D9 d3d = (IDirect3D9)Marshal.GetObjectForIUnknown(d3dPtr);
			
			D3DPRESENT_PARAMETERS d3dpp = new D3DPRESENT_PARAMETERS();
			d3dpp.Windowed			= true;
			d3dpp.SwapEffect		= D3DSWAPEFFECT.D3DSWAPEFFECT_DISCARD;
			d3dpp.hDeviceWindow		= hwnd;
			d3dpp.BackBufferFormat	= D3DFORMAT.D3DFMT_UNKNOWN;
			
			IDirect3DDevice9 d3ddev;
			
			int hr = d3d.CreateDevice(
				D3D.D3DADAPTER_DEFAULT,
				D3DDEVTYPE.D3DDEVTYPE_HAL,
				hwnd,
				D3DCREATE.D3DCREATE_SOFTWARE_VERTEXPROCESSING,
				ref d3dpp,
				out d3ddev);

			if (hr < 0)
			{
				Marshal.ThrowExceptionForHR(hr);
			}
				
			CUSTOMVERTEX[] vertices = new CUSTOMVERTEX[]
			{
				new CUSTOMVERTEX { x = 320.0f, y = 50.0f, z = 1.0f, rhw = 1.0f, color = D3D.D3DCOLOR_XRGB(0, 0, 255) },
				new CUSTOMVERTEX { x = 520.0f, y = 400.0f, z = 1.0f, rhw = 1.0f, color = 0xFF00FF00 },
				new CUSTOMVERTEX { x = 120.0f, y = 400.0f, z = 1.0f, rhw = 1.0f, color = 0xFFFF0000 }
			};
			
			IDirect3DVertexBuffer9 v_buffer;
			
			hr = d3ddev.CreateVertexBuffer(
				(uint)(Marshal.SizeOf(typeof(CUSTOMVERTEX)) * vertices.Length),
				0,
				CUSTOMFVF,
				D3DPOOL.D3DPOOL_MANAGED,
				out v_buffer,
				IntPtr.Zero);
			
			if (hr < 0)
			{
				Marshal.ThrowExceptionForHR(hr);
			}
			
			IntPtr pData;
			
			v_buffer.Lock(0, 0, out pData, 0);
			int stride = Marshal.SizeOf(typeof(CUSTOMVERTEX));
			for (int i = 0; i < vertices.Length; i++)
			{
				IntPtr p = IntPtr.Add(pData, i * stride);
				Marshal.StructureToPtr(vertices[i], p, false);
			}
			v_buffer.Unlock();
			
			MSG msg = new MSG();
				
			while (true)
			{
				while (Win32.PeekMessage(out msg, IntPtr.Zero, 0, 0, 0x0001) > 0) // PM_REMOVE
				{
					Win32.TranslateMessage(ref msg);
					Win32.DispatchMessage(ref msg);
				}

				if(msg.message == 0x0012) // WM_QUIT
					break;
					
				
				d3ddev.Clear(0, IntPtr.Zero, D3DCLEAR.D3DCLEAR_TARGET, D3D.D3DCOLOR_XRGB(0, 40, 100), 1.0f, 0);
					
				d3ddev.BeginScene();
					
					d3ddev.SetFVF(CUSTOMFVF);
					
					d3ddev.SetStreamSource(0, v_buffer, 0, (uint)Marshal.SizeOf(typeof(CUSTOMVERTEX)));
					
					d3ddev.DrawPrimitive(D3DPRIMITIVETYPE.D3DPT_TRIANGLELIST, 0, 1);
					
				d3ddev.EndScene();

				d3ddev.Present(IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
			}
			
			Marshal.ReleaseComObject(v_buffer);
			Marshal.ReleaseComObject(d3ddev);
			Marshal.ReleaseComObject(d3d);
			
			return;
		}
	}
}
