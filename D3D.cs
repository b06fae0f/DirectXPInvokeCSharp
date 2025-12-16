using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DirectXPInvoke
{
	public enum D3DFORMAT : uint
	{
		D3DFMT_UNKNOWN			=  0,

		D3DFMT_R8G8B8			= 20,
		D3DFMT_A8R8G8B8			= 21,
		D3DFMT_X8R8G8B8			= 22,
		D3DFMT_R5G6B5			= 23,
		D3DFMT_X1R5G5B5			= 24,
		D3DFMT_A1R5G5B5			= 25,
		D3DFMT_A4R4G4B4			= 26,
		D3DFMT_R3G3B2			= 27,
		D3DFMT_A8				= 28,
		D3DFMT_A8R3G3B2			= 29,
		D3DFMT_X4R4G4B4			= 30,
		D3DFMT_A2B10G10R10		= 31,
		D3DFMT_A8B8G8R8			= 32,
		D3DFMT_X8B8G8R8			= 33,
		D3DFMT_G16R16			= 34,
		D3DFMT_A2R10G10B10		= 35,
		D3DFMT_A16B16G16R16		= 36,
		
		D3DFMT_A8P8				= 40,
		D3DFMT_P8				= 41,
		
		D3DFMT_L8				= 50,
		D3DFMT_A8L8				= 51,
		D3DFMT_A4L4				= 52,
		
		D3DFMT_V8U8				= 60,
		D3DFMT_L6V5U5			= 61,
		D3DFMT_X8L8V8U8			= 62,
		D3DFMT_Q8W8V8U8			= 63,
		D3DFMT_V16U16			= 64,
		D3DFMT_A2W10V10U10		= 67,
		
		//D3DFMT_UYVY			= MAKEFOURCC('U', 'Y', 'V', 'Y'),
		//D3DFMT_R8G8_B8G8		= MAKEFOURCC('R', 'G', 'B', 'G'),
		//D3DFMT_YUY2			= MAKEFOURCC('Y', 'U', 'Y', '2'),
		//D3DFMT_G8R8_G8B8		= MAKEFOURCC('G', 'R', 'G', 'B'),
		//D3DFMT_DXT1			= MAKEFOURCC('D', 'X', 'T', '1'),
		//D3DFMT_DXT2			= MAKEFOURCC('D', 'X', 'T', '2'),
		//D3DFMT_DXT3			= MAKEFOURCC('D', 'X', 'T', '3'),
		//D3DFMT_DXT4			= MAKEFOURCC('D', 'X', 'T', '4'),
		//D3DFMT_DXT5			= MAKEFOURCC('D', 'X', 'T', '5'),
		
		D3DFMT_D16_LOCKABLE		= 70,
		D3DFMT_D32				= 71,
		D3DFMT_D15S1			= 73,
		D3DFMT_D24S8			= 75,
		D3DFMT_D24X8			= 77,
		D3DFMT_D24X4S4			= 79,
		D3DFMT_D16				= 80,
		
		D3DFMT_D32F_LOCKABLE	= 82,
		D3DFMT_D24FS8			= 83,
		
		D3DFMT_L16				= 81,
		
		D3DFMT_VERTEXDATA		= 100,
		D3DFMT_INDEX16			= 101,
		D3DFMT_INDEX32			= 102,
		
		D3DFMT_Q16W16V16U16		= 110,
		
		//D3DFMT_MULTI2_ARGB8	= MAKEFOURCC('M','E','T','1'),
		
		D3DFMT_R16F				= 111,
		D3DFMT_G16R16F			= 112,
		D3DFMT_A16B16G16R16F	= 113,
		
		D3DFMT_R32F				= 114,
		D3DFMT_G32R32F			= 115,
		D3DFMT_A32B32G32R32F	= 116,
		
		D3DFMT_CxV8U8			= 117,
		
		D3DFMT_FORCE_DWORD		= 0x7fffffff
	}
	
	public enum D3DMULTISAMPLE_TYPE : uint
	{ 
		D3DMULTISAMPLE_NONE			= 0,
		D3DMULTISAMPLE_NONMASKABLE	= 1,
		D3DMULTISAMPLE_2_SAMPLES	= 2,
		D3DMULTISAMPLE_3_SAMPLES	= 3,
		D3DMULTISAMPLE_4_SAMPLES	= 4,
		D3DMULTISAMPLE_5_SAMPLES	= 5,
		D3DMULTISAMPLE_6_SAMPLES	= 6,
		D3DMULTISAMPLE_7_SAMPLES	= 7,
		D3DMULTISAMPLE_8_SAMPLES	= 8,
		D3DMULTISAMPLE_9_SAMPLES	= 9,
		D3DMULTISAMPLE_10_SAMPLES	= 10,
		D3DMULTISAMPLE_11_SAMPLES	= 11,
		D3DMULTISAMPLE_12_SAMPLES	= 12,
		D3DMULTISAMPLE_13_SAMPLES	= 13,
		D3DMULTISAMPLE_14_SAMPLES	= 14,
		D3DMULTISAMPLE_15_SAMPLES	= 15,
		D3DMULTISAMPLE_16_SAMPLES	= 16,
		D3DMULTISAMPLE_FORCE_DWORD	= 0xffffffff
	}
	
	public enum D3DSWAPEFFECT : uint
	{ 
		D3DSWAPEFFECT_DISCARD		= 1,
		D3DSWAPEFFECT_FLIP			= 2,
		D3DSWAPEFFECT_COPY			= 3,
		D3DSWAPEFFECT_OVERLAY		= 4,
		D3DSWAPEFFECT_FLIPEX		= 5,
		D3DSWAPEFFECT_FORCE_DWORD	= 0xFFFFFFFF
	}
	
	public enum D3DDEVTYPE
	{ 
		D3DDEVTYPE_HAL				= 1,
		D3DDEVTYPE_NULLREF			= 4,
		D3DDEVTYPE_REF				= 2,
		D3DDEVTYPE_SW				= 3,
		D3DDEVTYPE_FORCE_DWORD		= 0x7fffffff
	}
	
	public enum D3DCREATE : uint
	{
		D3DCREATE_FPU_PRESERVE				= 0x00000002,
		D3DCREATE_MULTITHREADED				= 0x00000004,
		D3DCREATE_PUREDEVICE				= 0x00000010,
		D3DCREATE_SOFTWARE_VERTEXPROCESSING	= 0x00000020,
		D3DCREATE_HARDWARE_VERTEXPROCESSING	= 0x00000040,
		D3DCREATE_MIXED_VERTEXPROCESSING	= 0x00000080,
	}
	
	public enum D3DCLEAR : uint
	{
		D3DCLEAR_TARGET		= 0x1,
		D3DCLEAR_ZBUFFER	= 0x2,
		D3DCLEAR_STENCIL	= 0x4
	}
	
	public enum D3DFVF : uint
	{
		D3DFVF_RESERVED0		= 0x001,
		D3DFVF_POSITION_MASK	= 0x400E,
		D3DFVF_XYZ				= 0x002,
		D3DFVF_XYZRHW			= 0x004,
		D3DFVF_XYZB1			= 0x006,
		D3DFVF_XYZB2			= 0x008,
		D3DFVF_XYZB3			= 0x00a,
		D3DFVF_XYZB4			= 0x00c,
		D3DFVF_XYZB5			= 0x00e,
		D3DFVF_XYZW				= 0x4002,
		
		D3DFVF_NORMAL			= 0x010,
		D3DFVF_PSIZE			= 0x020,
		D3DFVF_DIFFUSE			= 0x040,
		D3DFVF_SPECULAR			= 0x080,
		
		D3DFVF_TEXCOUNT_MASK	= 0xf00,
		D3DFVF_TEXCOUNT_SHIFT	= 8,
		D3DFVF_TEX0				= 0x000,
		D3DFVF_TEX1				= 0x100,
		D3DFVF_TEX2				= 0x200,
		D3DFVF_TEX3				= 0x300,
		D3DFVF_TEX4				= 0x400,
		D3DFVF_TEX5				= 0x500,
		D3DFVF_TEX6				= 0x600,
		D3DFVF_TEX7				= 0x700,
		D3DFVF_TEX8				= 0x800,
		
		D3DFVF_LASTBETA_UBYTE4		= 0x1000,
		D3DFVF_LASTBETA_D3DCOLOR 	= 0x8000,
		
		D3DFVF_RESERVED2		= 0x6000,  // 2 reserved bits
	}
	
	public enum D3DPOOL : uint
	{
		D3DPOOL_DEFAULT		= 0,
		D3DPOOL_MANAGED		= 1,
		D3DPOOL_SYSTEMMEM	= 2,
		D3DPOOL_SCRATCH		= 3,
		D3DPOOL_FORCE_DWORD	= 0x7fffffff
	}
	
	public enum D3DRESOURCETYPE 
	{ 
		D3DRTYPE_SURFACE		= 1,
		D3DRTYPE_VOLUME			= 2,
		D3DRTYPE_TEXTURE		= 3,
		D3DRTYPE_VOLUMETEXTURE	= 4,
		D3DRTYPE_CUBETEXTURE	= 5,
		D3DRTYPE_VERTEXBUFFER	= 6,
		D3DRTYPE_INDEXBUFFER	= 7,
		D3DRTYPE_FORCE_DWORD	= 0x7fffffff
	}
	
	public enum D3DTRANSFORMSTATETYPE 
	{ 
		D3DTS_VIEW			= 2,
		D3DTS_PROJECTION	= 3,
		D3DTS_TEXTURE0		= 16,
		D3DTS_TEXTURE1		= 17,
		D3DTS_TEXTURE2		= 18,
		D3DTS_TEXTURE3		= 19,
		D3DTS_TEXTURE4		= 20,
		D3DTS_TEXTURE5		= 21,
		D3DTS_TEXTURE6		= 22,
		D3DTS_TEXTURE7		= 23,
		D3DTS_FORCE_DWORD	= 0x7fffffff
	}
	
	public enum D3DPRIMITIVETYPE 
	{ 
		D3DPT_POINTLIST		= 1,
		D3DPT_LINELIST		= 2,
		D3DPT_LINESTRIP		= 3,
		D3DPT_TRIANGLELIST	= 4,
		D3DPT_TRIANGLESTRIP	= 5,
		D3DPT_TRIANGLEFAN	= 6,
		D3DPT_FORCE_DWORD	= 0x7fffffff
	}
	
	[StructLayout(LayoutKind.Sequential)]
	public struct D3DVERTEXBUFFER_DESC 
	{
		D3DFORMAT		Format;
		D3DRESOURCETYPE	Type;
		uint			Usage;
		D3DPOOL			Pool;
		uint			Size;
		uint			FVF;
	}
	
	[StructLayout(LayoutKind.Sequential)]
	public struct D3DDISPLAYMODE 
	{
		public uint	Width;
		public uint	Height;
		public uint	RefreshRate;
		public uint	Format;
	}
	
	[StructLayout(LayoutKind.Sequential)]
	public struct D3DRECT 
	{
		public int x1, y1, x2, y2;
	}
	
	[StructLayout(LayoutKind.Sequential)]
	public struct D3DMATRIX 
	{
		public float[,] m;
	}
	
	[StructLayout(LayoutKind.Sequential)]
	public struct D3DVIEWPORT9 
	{
		uint X;
		uint Y;
		uint Width;
		uint Height;
		float MinZ;
		float MaxZ;
	}
	
	[StructLayout(LayoutKind.Sequential)]
	public struct D3DCOLORVALUE
	{
		float r;
		float g;
		float b;
		float a;
	}
	
	[StructLayout(LayoutKind.Sequential)]
	public struct D3DMATERIAL9 
	{
		D3DCOLORVALUE Diffuse;
		D3DCOLORVALUE Ambient;
		D3DCOLORVALUE Specular;
		D3DCOLORVALUE Emissive;
		float         Power;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct D3DPRESENT_PARAMETERS
	{
		public uint					BackBufferWidth;
		public uint					BackBufferHeight;
		public D3DFORMAT			BackBufferFormat;
		public uint					BackBufferCount;
		public D3DMULTISAMPLE_TYPE	MultiSampleType;
		public uint					MultiSampleQuality;
		public D3DSWAPEFFECT		SwapEffect;
		public IntPtr				hDeviceWindow;
		[MarshalAs(UnmanagedType.Bool)]
		public bool					Windowed;
		[MarshalAs(UnmanagedType.Bool)]
		public bool					EnableAutoDepthStencil;
		public D3DFORMAT			AutoDepthStencilFormat;
		public uint					Flags;
		public uint					FullScreen_RefreshRateInHz;
		public uint					PresentationInterval;
	}
	
	[ComImport]
	[Guid("05EEC05D-8F7D-4362-B999-D1BAF357C704")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface IDirect3DResource9
	{
		int GetDevice(out IDirect3DDevice9 ppDevice);
		int SetPrivateData(ref Guid refguid, IntPtr pData, uint SizeOfData, uint Flags);
		int GetPrivateData(ref Guid refguid, IntPtr pData, out uint pSizeOfData);
		int FreePrivateData(ref Guid refguid);
		uint SetPriority(uint PriorityNew);
		uint GetPriority();
		void PreLoad();
		D3DRESOURCETYPE GetType();
	}
	
	[ComImport]
	[Guid("B64BB1B5-FD70-4df6-BF91-19D0A12455E3")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface IDirect3DVertexBuffer9
	{
		// IDirect3DResource9
		int GetDevice(out IDirect3DDevice9 ppDevice);
		int SetPrivateData(ref Guid refguid, IntPtr pData, uint SizeOfData, uint Flags);
		int GetPrivateData(ref Guid refguid, IntPtr pData, out uint pSizeOfData);
		int FreePrivateData(ref Guid refguid);
		uint SetPriority(uint PriorityNew);
		uint GetPriority();
		void PreLoad();
		D3DRESOURCETYPE GetType();
		
		// IDirect3DVertexBuffer9
		int Lock(uint OffsetToLock, uint SizeToLock, out IntPtr ppbData, uint Flags);
    	int Unlock();
    	int GetDesc(out D3DVERTEXBUFFER_DESC pDesc);
	}

	[ComImport]
	[Guid("81BDCBCA-64D4-426d-AE8D-AD0147F4275C")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface IDirect3D9
	{
		int RegisterSoftwareDevice(IntPtr pInitializeFunction);
		uint GetAdapterCount();
		int GetAdapterIdentifier(uint Adapter, uint Flags, IntPtr pIdentifier);
		uint GetAdapterModeCount(uint Adapter, int Format);
		int EnumAdapterModes(uint Adapter, int Format, uint Mode, IntPtr pMode);
		int GetAdapterDisplayMode(uint Adapter, out D3DDISPLAYMODE pMode);
		int CheckDeviceType(uint Adapter, int DevType, int DisplayFormat, int BackBufferFormat, bool Windowed);
		int CheckDeviceFormat(uint Adapter, int DeviceType, int AdapterFormat, int Usage, int RType, int CheckFormat);
		int CheckDeviceMultiSampleType(uint Adapter, int DeviceType, int SurfaceFormat, bool Windowed, int MultiSampleType, IntPtr pQualityLevels);
		int CheckDepthStencilMatch(uint Adapter, int DeviceType, int AdapterFormat, int RenderTargetFormat, int DepthStencilFormat);
		int CheckDeviceFormatConversion(uint Adapter, int DeviceType, int SourceFormat, int TargetFormat);
		int GetDeviceCaps(uint Adapter, int DeviceType, IntPtr pCaps);
		IntPtr GetAdapterMonitor(uint Adapter);
		int CreateDevice(uint Adapter, D3DDEVTYPE DeviceType, IntPtr hFocusWindow, D3DCREATE BehaviorFlags, ref D3DPRESENT_PARAMETERS pPresentationParameters, out IDirect3DDevice9 ppReturnedDeviceInterface);
	}
	
	[ComImport]
	[Guid("D0223B96-BF7A-43FD-92BD-A43B0D82B9EB")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface IDirect3DDevice9
	{
		int TestCooperativeLevel();
		uint GetAvailableTextureMem();
		int EvictManagedResources();
		int GetDirect3D(out IDirect3D9 ppD3D9);
		int GetDeviceCaps(IntPtr pCaps);
		int GetDisplayMode(uint iSwapChain, IntPtr pMode);
		int GetCreationParameters(IntPtr pParameters);
		int SetCursorProperties(uint XHotSpot, uint YHotSpot, IntPtr pCursorBitmap);
		void SetCursorPosition(int X, int Y, uint Flags);
		int ShowCursor(bool bShow);
		int CreateAdditionalSwapChain(IntPtr pPresentationParameters, out IntPtr pSwapChain);
		int GetSwapChain(uint iSwapChain, out IntPtr pSwapChain);
		uint GetNumberOfSwapChains();
		int Reset(ref D3DPRESENT_PARAMETERS pPresentationParameters);
		int Present(IntPtr pSourceRect, IntPtr pDestRect, IntPtr hDestWindowOverride, IntPtr pDirtyRegion);
		int GetBackBuffer(uint iSwapChain, uint iBackBuffer, uint Type, out IntPtr ppBackBuffer);
		int GetRasterStatus(uint iSwapChain, IntPtr pRasterStatus);
		int SetDialogBoxMode(bool bEnableDialogs);
		void SetGammaRamp(uint iSwapChain, uint Flags, IntPtr pRamp);
		void GetGammaRamp(uint iSwapChain, IntPtr pRamp);
		int CreateTexture();
		int CreateVolumeTexture();
		int CreateCubeTexture();
		int CreateVertexBuffer(uint Length, uint Usage, uint FVF, D3DPOOL Pool, out IDirect3DVertexBuffer9 ppVertexBuffer, IntPtr pSharedHandle);
		int CreateIndexBuffer();
		int CreateRenderTarget();
		int CreateDepthStencilSurface();
		int UpdateSurface();
		int UpdateTexture();
		int GetRenderTargetData();
		int GetFrontBufferData();
		int StretchRect();
		int ColorFill();
		int CreateOffscreenPlainSurface();
		int SetRenderTarget();
		int GetRenderTarget(uint RenderTargetIndex, out IntPtr ppRenderTarget);
		int SetDepthStencilSurface();
		int GetDepthStencilSurface();
		int BeginScene();
		int EndScene();
		int Clear(uint Count, IntPtr pRects, D3DCLEAR Flags, uint Color, float Z, uint Stencil);
		int SetTransform(D3DTRANSFORMSTATETYPE State, ref D3DMATRIX pMatrix);
		int GetTransform(D3DTRANSFORMSTATETYPE State, out D3DMATRIX pMatrix);
    	int MultiplyTransform(D3DTRANSFORMSTATETYPE unnamedParam1, ref D3DMATRIX unnamedParam2);
		int SetViewport(ref D3DVIEWPORT9 pViewport);
		int GetViewport(out D3DVIEWPORT9 pViewport);
		int SetMaterial(ref D3DMATERIAL9 pMaterial);
		int GetMaterial(out D3DMATERIAL9 pMaterial);
		int SetLight();
		int GetLight();
		int LightEnable();
		int GetLightEnable();
		int SetClipPlane();
		int GetClipPlane();
		int SetRenderState();
		int GetRenderState();
		int CreateStateBlock();
		int BeginStateBlock();
		int EndStateBlock();
		int SetClipStatus();
		int GetClipStatus();
		int GetTexture();
		int SetTexture();
		int GetTextureStageState();
		int SetTextureStageState();
		int GetSamplerState();
		int SetSamplerState();
		int ValidateDevice();
		int SetPaletteEntries();
		int GetPaletteEntries();
		int SetCurrentTexturePalette();
		int GetCurrentTexturePalette();
		int SetScissorRect();
		int GetScissorRect();
		int SetSoftwareVertexProcessing();
		bool GetSoftwareVertexProcessing();
		int SetNPatchMode();
		float GetNPatchMode();
		int DrawPrimitive(D3DPRIMITIVETYPE PrimitiveType, uint StartVertex, uint PrimitiveCount);
		int DrawIndexedPrimitive();
		int DrawPrimitiveUP(D3DPRIMITIVETYPE PrimitiveType, uint PrimitiveCount, IntPtr pVertexStreamZeroData, uint VertexStreamZeroStride);
		int DrawIndexedPrimitiveUP();
		int ProcessVertices();
		int CreateVertexDeclaration();
		int SetVertexDeclaration();
		int GetVertexDeclaration();
		int SetFVF(uint FVF);
		int GetFVF(out uint pFVF);
		int CreateVertexShader();
		int SetVertexShader();
		int GetVertexShader();
		int SetVertexShaderConstantF();
		int GetVertexShaderConstantF();
		int SetVertexShaderConstantI();
		int GetVertexShaderConstantI();
		int SetVertexShaderConstantB();
		int GetVertexShaderConstantB();
		int SetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9 pStreamData, uint OffsetInBytes, uint Stride);
		int GetStreamSource();
		int SetStreamSourceFreq();
		int GetStreamSourceFreq();
		int SetIndices();
		int GetIndices();
		int CreatePixelShader();
		int SetPixelShader();
		int GetPixelShader();
		int SetPixelShaderConstantF();
		int GetPixelShaderConstantF();
		int SetPixelShaderConstantI();
		int GetPixelShaderConstantI();
		int SetPixelShaderConstantB();
		int GetPixelShaderConstantB();
		int DrawRectPatch();
		int DrawTriPatch();
		int DeletePatch();
		int CreateQuery();
	}
	
	public class D3D
	{
		public const uint D3D_SDK_VERSION = 32;
		public const uint D3DADAPTER_DEFAULT = 0;
		
		[DllImport("d3d9.dll", CallingConvention = CallingConvention.StdCall)]
		public static extern IntPtr Direct3DCreate9(uint SDKVersion);
		
		public static uint D3DCOLOR_ARGB(byte a, byte r, byte g, byte b)
		{
			return ((uint)a << 24) | ((uint)r << 16) | ((uint)g << 8) | b;
		}
		
		public static uint D3DCOLOR_XRGB(byte r, byte g, byte b)
		{
			return ((uint)255 << 24) | ((uint)r << 16) | ((uint)g << 8) | b;
		}
	}
}
