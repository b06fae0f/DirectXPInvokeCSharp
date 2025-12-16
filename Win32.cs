using System;
using System.Runtime.InteropServices;

namespace DirectXPInvoke
{
	[StructLayout(LayoutKind.Sequential)]
	public struct POINT
	{
		public long x;
		public long y;
	}
	
	[StructLayout(LayoutKind.Sequential)]
	public struct MSG
	{
		public IntPtr	hWnd;
		public uint		message;
		public UIntPtr	wParam;
		public UIntPtr	lParam;
		public uint		time;
		public POINT	pt;
	}
	
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct WNDCLASSEX
	{
		[MarshalAs(UnmanagedType.U4)]
		public int		cbSize;
		[MarshalAs(UnmanagedType.U4)]
		public int		style;
		public IntPtr	lpfnWndProc;
		public int		cbClsExtra;
		public int		cbWndExtra;
		public IntPtr	hInstance;
		public IntPtr	hIcon;
		public IntPtr 	hCursor;
		public IntPtr	hbrBackground;
		public string	lpszMenuName;
		public string	lpszClassName;
		public IntPtr	hIconSm;
	}
	
	public static class Win32
	{
		[DllImport("gdi32.dll")]
		public static extern IntPtr GetStockObject(int i);
		
		[DllImport("user32.dll")]  
		public static extern IntPtr LoadIcon(IntPtr hInstance, IntPtr lpIconName); 
		
		[DllImport("user32.dll")]  
		public static extern IntPtr LoadCursor(IntPtr hInstance, int lpCursorName);  
	
		[DllImport("user32.dll")]
		public static extern sbyte GetMessage(out MSG lpMsg, IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax);
		
		[DllImport("user32.dll")]
		public static extern sbyte PeekMessage(out MSG lpMsg, IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);
		
		[DllImport("user32.dll")]
		public static extern bool TranslateMessage(ref MSG lpMsg);
		
		[DllImport("user32.dll")]
		public static extern IntPtr DispatchMessage(ref MSG lpMsg);
		
		[DllImport("user32.dll")]
		public static extern bool DestroyWindow(IntPtr hWnd);
		
		[DllImport("user32.dll")]
		public static extern void PostQuitMessage(int nExitCode);
		
		[DllImport("user32.dll")]
		public static extern IntPtr DefWindowProc(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
		
		[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
		public static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, long uType);
					
		[DllImport("user32.dll")]
		public static extern ushort RegisterClassEx([In] ref WNDCLASSEX lpwcx);
		
		[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
		public static extern IntPtr CreateWindowEx(
			long dwExStyle,
			ushort lpClassName,
			string lpWindowName,
			long dwStyle,
			int x,
			int y,
			int nWidth,
			int nHeight,
			IntPtr hWndParent,
			IntPtr hMenu,
			IntPtr hInstance,
			IntPtr lpParam);
		
		[DllImport("user32.dll")]
		public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
		
		[DllImport("user32.dll")]
		public static extern bool UpdateWindow(IntPtr hWnd);
	}
}
