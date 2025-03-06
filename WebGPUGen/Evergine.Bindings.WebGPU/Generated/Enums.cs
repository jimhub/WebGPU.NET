using System;

namespace Evergine.Bindings.WebGPU
{
	public enum WGPUAdapterType
	{
		DiscreteGPU = 1,
		IntegratedGPU = 2,
		CPU = 3,
		Unknown = 4,
		Force32 = 2147483647,
	}

	public enum WGPUAddressMode
	{
		Undefined = 0,
		ClampToEdge = 1,
		Repeat = 2,
		MirrorRepeat = 3,
		Force32 = 2147483647,
	}

	public enum WGPUBackendType
	{
		Undefined = 0,
		Null = 1,
		WebGPU = 2,
		D3D11 = 3,
		D3D12 = 4,
		Metal = 5,
		Vulkan = 6,
		OpenGL = 7,
		OpenGLES = 8,
		Force32 = 2147483647,
	}

	public enum WGPUBlendFactor
	{
		Undefined = 0,
		Zero = 1,
		One = 2,
		Src = 3,
		OneMinusSrc = 4,
		SrcAlpha = 5,
		OneMinusSrcAlpha = 6,
		Dst = 7,
		OneMinusDst = 8,
		DstAlpha = 9,
		OneMinusDstAlpha = 10,
		SrcAlphaSaturated = 11,
		Constant = 12,
		OneMinusConstant = 13,
		Src1 = 14,
		OneMinusSrc1 = 15,
		Src1Alpha = 16,
		OneMinusSrc1Alpha = 17,
		Force32 = 2147483647,
	}

	public enum WGPUBlendOperation
	{
		Undefined = 0,
		Add = 1,
		Subtract = 2,
		ReverseSubtract = 3,
		Min = 4,
		Max = 5,
		Force32 = 2147483647,
	}

	public enum WGPUBufferBindingType
	{
		BindingNotUsed = 0,
		Undefined = 1,
		Uniform = 2,
		Storage = 3,
		ReadOnlyStorage = 4,
		Force32 = 2147483647,
	}

	public enum WGPUBufferMapState
	{
		Unmapped = 1,
		Pending = 2,
		Mapped = 3,
		Force32 = 2147483647,
	}

	public enum WGPUCallbackMode
	{
		WaitAnyOnly = 1,
		AllowProcessEvents = 2,
		AllowSpontaneous = 3,
		Force32 = 2147483647,
	}

	public enum WGPUCompareFunction
	{
		Undefined = 0,
		Never = 1,
		Less = 2,
		Equal = 3,
		LessEqual = 4,
		Greater = 5,
		NotEqual = 6,
		GreaterEqual = 7,
		Always = 8,
		Force32 = 2147483647,
	}

	public enum WGPUCompilationInfoRequestStatus
	{
		Success = 1,
		InstanceDropped = 2,
		Error = 3,
		Unknown = 4,
		Force32 = 2147483647,
	}

	public enum WGPUCompilationMessageType
	{
		Error = 1,
		Warning = 2,
		Info = 3,
		Force32 = 2147483647,
	}

	public enum WGPUCompositeAlphaMode
	{
		Auto = 0,
		Opaque = 1,
		Premultiplied = 2,
		Unpremultiplied = 3,
		Inherit = 4,
		Force32 = 2147483647,
	}

	public enum WGPUCreatePipelineAsyncStatus
	{
		Success = 1,
		InstanceDropped = 2,
		ValidationError = 3,
		InternalError = 4,
		Unknown = 5,
		Force32 = 2147483647,
	}

	public enum WGPUCullMode
	{
		Undefined = 0,
		None = 1,
		Front = 2,
		Back = 3,
		Force32 = 2147483647,
	}

	public enum WGPUDeviceLostReason
	{
		Unknown = 1,
		Destroyed = 2,
		InstanceDropped = 3,
		FailedCreation = 4,
		Force32 = 2147483647,
	}

	public enum WGPUErrorFilter
	{
		Validation = 1,
		OutOfMemory = 2,
		Internal = 3,
		Force32 = 2147483647,
	}

	public enum WGPUErrorType
	{
		NoError = 1,
		Validation = 2,
		OutOfMemory = 3,
		Internal = 4,
		Unknown = 5,
		Force32 = 2147483647,
	}

	public enum WGPUFeatureLevel
	{
		Compatibility = 1,
		Core = 2,
		Force32 = 2147483647,
	}

	public enum WGPUFeatureName
	{
		Undefined = 0,
		DepthClipControl = 1,
		Depth32FloatStencil8 = 2,
		TimestampQuery = 3,
		TextureCompressionBC = 4,
		TextureCompressionBCSliced3D = 5,
		TextureCompressionETC2 = 6,
		TextureCompressionASTC = 7,
		TextureCompressionASTCSliced3D = 8,
		IndirectFirstInstance = 9,
		ShaderF16 = 10,
		RG11B10UfloatRenderable = 11,
		BGRA8UnormStorage = 12,
		Float32Filterable = 13,
		Float32Blendable = 14,
		ClipDistances = 15,
		DualSourceBlending = 16,
		Force32 = 2147483647,
	}

	public enum WGPUFilterMode
	{
		Undefined = 0,
		Nearest = 1,
		Linear = 2,
		Force32 = 2147483647,
	}

	public enum WGPUFrontFace
	{
		Undefined = 0,
		CCW = 1,
		CW = 2,
		Force32 = 2147483647,
	}

	public enum WGPUIndexFormat
	{
		Undefined = 0,
		Uint16 = 1,
		Uint32 = 2,
		Force32 = 2147483647,
	}

	public enum WGPULoadOp
	{
		Undefined = 0,
		Load = 1,
		Clear = 2,
		Force32 = 2147483647,
	}

	public enum WGPUMapAsyncStatus
	{
		Success = 1,
		InstanceDropped = 2,
		Error = 3,
		Aborted = 4,
		Unknown = 5,
		Force32 = 2147483647,
	}

	public enum WGPUMipmapFilterMode
	{
		Undefined = 0,
		Nearest = 1,
		Linear = 2,
		Force32 = 2147483647,
	}

	public enum WGPUOptionalBool
	{
		False = 0,
		True = 1,
		Undefined = 2,
		Force32 = 2147483647,
	}

	public enum WGPUPopErrorScopeStatus
	{
		Success = 1,
		InstanceDropped = 2,
		EmptyStack = 3,
		Force32 = 2147483647,
	}

	public enum WGPUPowerPreference
	{
		Undefined = 0,
		LowPower = 1,
		HighPerformance = 2,
		Force32 = 2147483647,
	}

	public enum WGPUPresentMode
	{
		Undefined = 0,
		Fifo = 1,
		FifoRelaxed = 2,
		Immediate = 3,
		Mailbox = 4,
		Force32 = 2147483647,
	}

	public enum WGPUPrimitiveTopology
	{
		Undefined = 0,
		PointList = 1,
		LineList = 2,
		LineStrip = 3,
		TriangleList = 4,
		TriangleStrip = 5,
		Force32 = 2147483647,
	}

	public enum WGPUQueryType
	{
		Occlusion = 1,
		Timestamp = 2,
		Force32 = 2147483647,
	}

	public enum WGPUQueueWorkDoneStatus
	{
		Success = 1,
		InstanceDropped = 2,
		Error = 3,
		Unknown = 4,
		Force32 = 2147483647,
	}

	public enum WGPURequestAdapterStatus
	{
		Success = 1,
		InstanceDropped = 2,
		Unavailable = 3,
		Error = 4,
		Unknown = 5,
		Force32 = 2147483647,
	}

	public enum WGPURequestDeviceStatus
	{
		Success = 1,
		InstanceDropped = 2,
		Error = 3,
		Unknown = 4,
		Force32 = 2147483647,
	}

	public enum WGPUSType
	{
		ShaderSourceSPIRV = 1,
		ShaderSourceWGSL = 2,
		RenderPassMaxDrawCount = 3,
		SurfaceSourceMetalLayer = 4,
		SurfaceSourceWindowsHWND = 5,
		SurfaceSourceXlibWindow = 6,
		SurfaceSourceWaylandSurface = 7,
		SurfaceSourceAndroidNativeWindow = 8,
		SurfaceSourceXCBWindow = 9,
		Force32 = 2147483647,
	}

	public enum WGPUSamplerBindingType
	{
		BindingNotUsed = 0,
		Undefined = 1,
		Filtering = 2,
		NonFiltering = 3,
		Comparison = 4,
		Force32 = 2147483647,
	}

	public enum WGPUStatus
	{
		Success = 1,
		Error = 2,
		Force32 = 2147483647,
	}

	public enum WGPUStencilOperation
	{
		Undefined = 0,
		Keep = 1,
		Zero = 2,
		Replace = 3,
		Invert = 4,
		IncrementClamp = 5,
		DecrementClamp = 6,
		IncrementWrap = 7,
		DecrementWrap = 8,
		Force32 = 2147483647,
	}

	public enum WGPUStorageTextureAccess
	{
		BindingNotUsed = 0,
		Undefined = 1,
		WriteOnly = 2,
		ReadOnly = 3,
		ReadWrite = 4,
		Force32 = 2147483647,
	}

	public enum WGPUStoreOp
	{
		Undefined = 0,
		Store = 1,
		Discard = 2,
		Force32 = 2147483647,
	}

	public enum WGPUSurfaceGetCurrentTextureStatus
	{
		SuccessOptimal = 1,
		SuccessSuboptimal = 2,
		Timeout = 3,
		Outdated = 4,
		Lost = 5,
		OutOfMemory = 6,
		DeviceLost = 7,
		Error = 8,
		Force32 = 2147483647,
	}

	public enum WGPUTextureAspect
	{
		Undefined = 0,
		All = 1,
		StencilOnly = 2,
		DepthOnly = 3,
		Force32 = 2147483647,
	}

	public enum WGPUTextureDimension
	{
		Undefined = 0,
		_1D = 1,
		_2D = 2,
		_3D = 3,
		Force32 = 2147483647,
	}

	public enum WGPUTextureFormat
	{
		Undefined = 0,
		R8Unorm = 1,
		R8Snorm = 2,
		R8Uint = 3,
		R8Sint = 4,
		R16Uint = 5,
		R16Sint = 6,
		R16Float = 7,
		RG8Unorm = 8,
		RG8Snorm = 9,
		RG8Uint = 10,
		RG8Sint = 11,
		R32Float = 12,
		R32Uint = 13,
		R32Sint = 14,
		RG16Uint = 15,
		RG16Sint = 16,
		RG16Float = 17,
		RGBA8Unorm = 18,
		RGBA8UnormSrgb = 19,
		RGBA8Snorm = 20,
		RGBA8Uint = 21,
		RGBA8Sint = 22,
		BGRA8Unorm = 23,
		BGRA8UnormSrgb = 24,
		RGB10A2Uint = 25,
		RGB10A2Unorm = 26,
		RG11B10Ufloat = 27,
		RGB9E5Ufloat = 28,
		RG32Float = 29,
		RG32Uint = 30,
		RG32Sint = 31,
		RGBA16Uint = 32,
		RGBA16Sint = 33,
		RGBA16Float = 34,
		RGBA32Float = 35,
		RGBA32Uint = 36,
		RGBA32Sint = 37,
		Stencil8 = 38,
		Depth16Unorm = 39,
		Depth24Plus = 40,
		Depth24PlusStencil8 = 41,
		Depth32Float = 42,
		Depth32FloatStencil8 = 43,
		BC1RGBAUnorm = 44,
		BC1RGBAUnormSrgb = 45,
		BC2RGBAUnorm = 46,
		BC2RGBAUnormSrgb = 47,
		BC3RGBAUnorm = 48,
		BC3RGBAUnormSrgb = 49,
		BC4RUnorm = 50,
		BC4RSnorm = 51,
		BC5RGUnorm = 52,
		BC5RGSnorm = 53,
		BC6HRGBUfloat = 54,
		BC6HRGBFloat = 55,
		BC7RGBAUnorm = 56,
		BC7RGBAUnormSrgb = 57,
		ETC2RGB8Unorm = 58,
		ETC2RGB8UnormSrgb = 59,
		ETC2RGB8A1Unorm = 60,
		ETC2RGB8A1UnormSrgb = 61,
		ETC2RGBA8Unorm = 62,
		ETC2RGBA8UnormSrgb = 63,
		EACR11Unorm = 64,
		EACR11Snorm = 65,
		EACRG11Unorm = 66,
		EACRG11Snorm = 67,
		ASTC4x4Unorm = 68,
		ASTC4x4UnormSrgb = 69,
		ASTC5x4Unorm = 70,
		ASTC5x4UnormSrgb = 71,
		ASTC5x5Unorm = 72,
		ASTC5x5UnormSrgb = 73,
		ASTC6x5Unorm = 74,
		ASTC6x5UnormSrgb = 75,
		ASTC6x6Unorm = 76,
		ASTC6x6UnormSrgb = 77,
		ASTC8x5Unorm = 78,
		ASTC8x5UnormSrgb = 79,
		ASTC8x6Unorm = 80,
		ASTC8x6UnormSrgb = 81,
		ASTC8x8Unorm = 82,
		ASTC8x8UnormSrgb = 83,
		ASTC10x5Unorm = 84,
		ASTC10x5UnormSrgb = 85,
		ASTC10x6Unorm = 86,
		ASTC10x6UnormSrgb = 87,
		ASTC10x8Unorm = 88,
		ASTC10x8UnormSrgb = 89,
		ASTC10x10Unorm = 90,
		ASTC10x10UnormSrgb = 91,
		ASTC12x10Unorm = 92,
		ASTC12x10UnormSrgb = 93,
		ASTC12x12Unorm = 94,
		ASTC12x12UnormSrgb = 95,
		Force32 = 2147483647,
	}

	public enum WGPUTextureSampleType
	{
		BindingNotUsed = 0,
		Undefined = 1,
		Float = 2,
		UnfilterableFloat = 3,
		Depth = 4,
		Sint = 5,
		Uint = 6,
		Force32 = 2147483647,
	}

	public enum WGPUTextureViewDimension
	{
		Undefined = 0,
		_1D = 1,
		_2D = 2,
		_2DArray = 3,
		Cube = 4,
		CubeArray = 5,
		_3D = 6,
		Force32 = 2147483647,
	}

	public enum WGPUVertexFormat
	{
		Uint8 = 1,
		Uint8x2 = 2,
		Uint8x4 = 3,
		Sint8 = 4,
		Sint8x2 = 5,
		Sint8x4 = 6,
		Unorm8 = 7,
		Unorm8x2 = 8,
		Unorm8x4 = 9,
		Snorm8 = 10,
		Snorm8x2 = 11,
		Snorm8x4 = 12,
		Uint16 = 13,
		Uint16x2 = 14,
		Uint16x4 = 15,
		Sint16 = 16,
		Sint16x2 = 17,
		Sint16x4 = 18,
		Unorm16 = 19,
		Unorm16x2 = 20,
		Unorm16x4 = 21,
		Snorm16 = 22,
		Snorm16x2 = 23,
		Snorm16x4 = 24,
		Float16 = 25,
		Float16x2 = 26,
		Float16x4 = 27,
		Float32 = 28,
		Float32x2 = 29,
		Float32x3 = 30,
		Float32x4 = 31,
		Uint32 = 32,
		Uint32x2 = 33,
		Uint32x3 = 34,
		Uint32x4 = 35,
		Sint32 = 36,
		Sint32x2 = 37,
		Sint32x3 = 38,
		Sint32x4 = 39,
		Unorm10 = 40,
		Unorm8x4BGRA = 41,
		Force32 = 2147483647,
	}

	public enum WGPUVertexStepMode
	{
		VertexBufferNotUsed = 0,
		Undefined = 1,
		Vertex = 2,
		Instance = 3,
		Force32 = 2147483647,
	}

	public enum WGPUWGSLLanguageFeatureName
	{
		ReadonlyAndReadwriteStorageTextures = 1,
		Packed4x8IntegerDotProduct = 2,
		UnrestrictedPointerParameters = 3,
		PointerCompositeAccess = 4,
		Force32 = 2147483647,
	}

	public enum WGPUWaitStatus
	{
		Success = 1,
		TimedOut = 2,
		UnsupportedTimeout = 3,
		UnsupportedCount = 4,
		UnsupportedMixedSources = 5,
		Force32 = 2147483647,
	}

	public enum WGPUNativeSType
	{
		DeviceExtras = 196609,
		NativeLimits = 196610,
		PipelineLayoutExtras = 196611,
		ShaderModuleGLSLDescriptor = 196612,
		InstanceExtras = 196614,
		BindGroupEntryExtras = 196615,
		BindGroupLayoutEntryExtras = 196616,
		QuerySetDescriptorExtras = 196617,
		SurfaceConfigurationExtras = 196618,
		Force32 = 2147483647,
	}

	public enum WGPUNativeFeature
	{
		PushConstants = 196609,
		TextureAdapterSpecificFormatFeatures = 196610,
		MultiDrawIndirect = 196611,
		MultiDrawIndirectCount = 196612,
		VertexWritableStorage = 196613,
		TextureBindingArray = 196614,
		SampledTextureAndStorageBufferArrayNonUniformIndexing = 196615,
		PipelineStatisticsQuery = 196616,
		StorageResourceBindingArray = 196617,
		PartiallyBoundBindingArray = 196618,
		TextureFormat16bitNorm = 196619,
		TextureCompressionAstcHdr = 196620,
		MappablePrimaryBuffers = 196622,
		BufferBindingArray = 196623,
		UniformBufferAndStorageTextureArrayNonUniformIndexing = 196624,
		SpirvShaderPassthrough = 196631,
		VertexAttribute64bit = 196633,
		TextureFormatNv12 = 196634,
		RayTracingAccelerationStructure = 196635,
		RayQuery = 196636,
		ShaderF64 = 196637,
		ShaderI16 = 196638,
		ShaderPrimitiveIndex = 196639,
		ShaderEarlyDepthTest = 196640,
		Subgroup = 196641,
		SubgroupVertex = 196642,
		SubgroupBarrier = 196643,
		TimestampQueryInsideEncoders = 196644,
		TimestampQueryInsidePasses = 196645,
		Force32 = 2147483647,
	}

	public enum WGPULogLevel
	{
		Off = 0,
		Error = 1,
		Warn = 2,
		Info = 3,
		Debug = 4,
		Trace = 5,
		Force32 = 2147483647,
	}

	public enum WGPUDx12Compiler
	{
		Undefined = 0,
		Fxc = 1,
		Dxc = 2,
		Force32 = 2147483647,
	}

	public enum WGPUGles3MinorVersion
	{
		Automatic = 0,
		Version0 = 1,
		Version1 = 2,
		Version2 = 3,
		Force32 = 2147483647,
	}

	public enum WGPUPipelineStatisticName
	{
		VertexShaderInvocations = 0,
		ClipperInvocations = 1,
		ClipperPrimitivesOut = 2,
		FragmentShaderInvocations = 3,
		ComputeShaderInvocations = 4,
		Force32 = 2147483647,
	}

	public enum WGPUNativeQueryType
	{
		PipelineStatistics = 196608,
		Force32 = 2147483647,
	}

	public enum WGPUNativeTextureFormat
	{
		R16Unorm = 196609,
		R16Snorm = 196610,
		Rg16Unorm = 196611,
		Rg16Snorm = 196612,
		Rgba16Unorm = 196613,
		Rgba16Snorm = 196614,
		NV12 = 196615,
	}

}
