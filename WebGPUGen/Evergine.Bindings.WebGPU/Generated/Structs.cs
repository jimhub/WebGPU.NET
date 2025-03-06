using System;
using System.Runtime.InteropServices;

namespace Evergine.Bindings.WebGPU
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUStringView
	{
		public char* data;
		public ulong length;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUAdapterInfo
	{
		public WGPUChainedStructOut* nextInChain;
		public WGPUStringView vendor;
		public WGPUStringView architecture;
		public WGPUStringView device;
		public WGPUStringView description;
		public WGPUBackendType backendType;
		public WGPUAdapterType adapterType;
		public uint vendorID;
		public uint deviceID;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUBindGroupEntry
	{
		public WGPUChainedStruct* nextInChain;
		public uint binding;
		public WGPUBuffer buffer;
		public ulong offset;
		public ulong size;
		public WGPUSampler sampler;
		public WGPUTextureView textureView;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUBlendComponent
	{
		public WGPUBlendOperation operation;
		public WGPUBlendFactor srcFactor;
		public WGPUBlendFactor dstFactor;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUBufferBindingLayout
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUBufferBindingType type;
		public WGPUBool hasDynamicOffset;
		public ulong minBindingSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUBufferDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUStringView label;
		public WGPUBufferUsage usage;
		public ulong size;
		public WGPUBool mappedAtCreation;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUColor
	{
		public double r;
		public double g;
		public double b;
		public double a;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUCommandBufferDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUStringView label;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUCommandEncoderDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUStringView label;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUCompilationMessage
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUStringView message;
		public WGPUCompilationMessageType type;
		public ulong lineNum;
		public ulong linePos;
		public ulong offset;
		public ulong length;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUComputePassTimestampWrites
	{
		public WGPUQuerySet querySet;
		public uint beginningOfPassWriteIndex;
		public uint endOfPassWriteIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUConstantEntry
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUStringView key;
		public double value;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUExtent3D
	{
		public uint width;
		public uint height;
		public uint depthOrArrayLayers;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUFuture
	{
		public ulong id;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUInstanceCapabilities
	{
		public WGPUChainedStructOut* nextInChain;
		public WGPUBool timedWaitAnyEnable;
		public ulong timedWaitAnyMaxCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPULimits
	{
		public WGPUChainedStructOut* nextInChain;
		public uint maxTextureDimension1D;
		public uint maxTextureDimension2D;
		public uint maxTextureDimension3D;
		public uint maxTextureArrayLayers;
		public uint maxBindGroups;
		public uint maxBindGroupsPlusVertexBuffers;
		public uint maxBindingsPerBindGroup;
		public uint maxDynamicUniformBuffersPerPipelineLayout;
		public uint maxDynamicStorageBuffersPerPipelineLayout;
		public uint maxSampledTexturesPerShaderStage;
		public uint maxSamplersPerShaderStage;
		public uint maxStorageBuffersPerShaderStage;
		public uint maxStorageTexturesPerShaderStage;
		public uint maxUniformBuffersPerShaderStage;
		public ulong maxUniformBufferBindingSize;
		public ulong maxStorageBufferBindingSize;
		public uint minUniformBufferOffsetAlignment;
		public uint minStorageBufferOffsetAlignment;
		public uint maxVertexBuffers;
		public ulong maxBufferSize;
		public uint maxVertexAttributes;
		public uint maxVertexBufferArrayStride;
		public uint maxInterStageShaderVariables;
		public uint maxColorAttachments;
		public uint maxColorAttachmentBytesPerSample;
		public uint maxComputeWorkgroupStorageSize;
		public uint maxComputeInvocationsPerWorkgroup;
		public uint maxComputeWorkgroupSizeX;
		public uint maxComputeWorkgroupSizeY;
		public uint maxComputeWorkgroupSizeZ;
		public uint maxComputeWorkgroupsPerDimension;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUMultisampleState
	{
		public WGPUChainedStruct* nextInChain;
		public uint count;
		public uint mask;
		public WGPUBool alphaToCoverageEnabled;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUOrigin3D
	{
		public uint x;
		public uint y;
		public uint z;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUPipelineLayoutDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUStringView label;
		public ulong bindGroupLayoutCount;
		public WGPUBindGroupLayout* bindGroupLayouts;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUPrimitiveState
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUPrimitiveTopology topology;
		public WGPUIndexFormat stripIndexFormat;
		public WGPUFrontFace frontFace;
		public WGPUCullMode cullMode;
		public WGPUBool unclippedDepth;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUQuerySetDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUStringView label;
		public WGPUQueryType type;
		public uint count;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUQueueDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUStringView label;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPURenderBundleDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUStringView label;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPURenderBundleEncoderDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUStringView label;
		public ulong colorFormatCount;
		public WGPUTextureFormat* colorFormats;
		public WGPUTextureFormat depthStencilFormat;
		public uint sampleCount;
		public WGPUBool depthReadOnly;
		public WGPUBool stencilReadOnly;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPURenderPassDepthStencilAttachment
	{
		public WGPUTextureView view;
		public WGPULoadOp depthLoadOp;
		public WGPUStoreOp depthStoreOp;
		public float depthClearValue;
		public WGPUBool depthReadOnly;
		public WGPULoadOp stencilLoadOp;
		public WGPUStoreOp stencilStoreOp;
		public uint stencilClearValue;
		public WGPUBool stencilReadOnly;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPURenderPassMaxDrawCount
	{
		public WGPUChainedStruct chain;
		public ulong maxDrawCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPURenderPassTimestampWrites
	{
		public WGPUQuerySet querySet;
		public uint beginningOfPassWriteIndex;
		public uint endOfPassWriteIndex;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPURequestAdapterOptions
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUFeatureLevel featureLevel;
		public WGPUPowerPreference powerPreference;
		public WGPUBool forceFallbackAdapter;
		public WGPUBackendType backendType;
		public WGPUSurface compatibleSurface;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUSamplerBindingLayout
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUSamplerBindingType type;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUSamplerDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUStringView label;
		public WGPUAddressMode addressModeU;
		public WGPUAddressMode addressModeV;
		public WGPUAddressMode addressModeW;
		public WGPUFilterMode magFilter;
		public WGPUFilterMode minFilter;
		public WGPUMipmapFilterMode mipmapFilter;
		public float lodMinClamp;
		public float lodMaxClamp;
		public WGPUCompareFunction compare;
		public ushort maxAnisotropy;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUShaderModuleDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUStringView label;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUShaderSourceSPIRV
	{
		public WGPUChainedStruct chain;
		public uint codeSize;
		public uint* code;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUShaderSourceWGSL
	{
		public WGPUChainedStruct chain;
		public WGPUStringView code;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUStencilFaceState
	{
		public WGPUCompareFunction compare;
		public WGPUStencilOperation failOp;
		public WGPUStencilOperation depthFailOp;
		public WGPUStencilOperation passOp;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUStorageTextureBindingLayout
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUStorageTextureAccess access;
		public WGPUTextureFormat format;
		public WGPUTextureViewDimension viewDimension;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUSupportedFeatures
	{
		public ulong featureCount;
		public WGPUFeatureName* features;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUSupportedWGSLLanguageFeatures
	{
		public ulong featureCount;
		public WGPUWGSLLanguageFeatureName* features;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUSurfaceCapabilities
	{
		public WGPUChainedStructOut* nextInChain;
		public WGPUTextureUsage usages;
		public ulong formatCount;
		public WGPUTextureFormat* formats;
		public ulong presentModeCount;
		public WGPUPresentMode* presentModes;
		public ulong alphaModeCount;
		public WGPUCompositeAlphaMode* alphaModes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUSurfaceConfiguration
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUDevice device;
		public WGPUTextureFormat format;
		public WGPUTextureUsage usage;
		public uint width;
		public uint height;
		public ulong viewFormatCount;
		public WGPUTextureFormat* viewFormats;
		public WGPUCompositeAlphaMode alphaMode;
		public WGPUPresentMode presentMode;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUSurfaceDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUStringView label;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUSurfaceSourceAndroidNativeWindow
	{
		public WGPUChainedStruct chain;
		public void* window;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUSurfaceSourceMetalLayer
	{
		public WGPUChainedStruct chain;
		public void* layer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUSurfaceSourceWaylandSurface
	{
		public WGPUChainedStruct chain;
		public void* display;
		public void* surface;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUSurfaceSourceWindowsHWND
	{
		public WGPUChainedStruct chain;
		public void* hinstance;
		public void* hwnd;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUSurfaceSourceXCBWindow
	{
		public WGPUChainedStruct chain;
		public void* connection;
		public uint window;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUSurfaceSourceXlibWindow
	{
		public WGPUChainedStruct chain;
		public void* display;
		public ulong window;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUSurfaceTexture
	{
		public WGPUChainedStructOut* nextInChain;
		public WGPUTexture texture;
		public WGPUSurfaceGetCurrentTextureStatus status;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUTexelCopyBufferLayout
	{
		public ulong offset;
		public uint bytesPerRow;
		public uint rowsPerImage;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUTextureBindingLayout
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUTextureSampleType sampleType;
		public WGPUTextureViewDimension viewDimension;
		public WGPUBool multisampled;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUTextureViewDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUStringView label;
		public WGPUTextureFormat format;
		public WGPUTextureViewDimension dimension;
		public uint baseMipLevel;
		public uint mipLevelCount;
		public uint baseArrayLayer;
		public uint arrayLayerCount;
		public WGPUTextureAspect aspect;
		public WGPUTextureUsage usage;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUVertexAttribute
	{
		public WGPUVertexFormat format;
		public ulong offset;
		public uint shaderLocation;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUBindGroupDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUStringView label;
		public WGPUBindGroupLayout layout;
		public ulong entryCount;
		public WGPUBindGroupEntry* entries;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUBindGroupLayoutEntry
	{
		public WGPUChainedStruct* nextInChain;
		public uint binding;
		public WGPUShaderStage visibility;
		public WGPUBufferBindingLayout buffer;
		public WGPUSamplerBindingLayout sampler;
		public WGPUTextureBindingLayout texture;
		public WGPUStorageTextureBindingLayout storageTexture;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUBlendState
	{
		public WGPUBlendComponent color;
		public WGPUBlendComponent alpha;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUCompilationInfo
	{
		public WGPUChainedStruct* nextInChain;
		public ulong messageCount;
		public WGPUCompilationMessage* messages;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUComputePassDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUStringView label;
		public WGPUComputePassTimestampWrites* timestampWrites;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUDepthStencilState
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUTextureFormat format;
		public WGPUOptionalBool depthWriteEnabled;
		public WGPUCompareFunction depthCompare;
		public WGPUStencilFaceState stencilFront;
		public WGPUStencilFaceState stencilBack;
		public uint stencilReadMask;
		public uint stencilWriteMask;
		public int depthBias;
		public float depthBiasSlopeScale;
		public float depthBiasClamp;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUDeviceDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUStringView label;
		public ulong requiredFeatureCount;
		public WGPUFeatureName* requiredFeatures;
		public WGPULimits* requiredLimits;
		public WGPUQueueDescriptor defaultQueue;
		public WGPUDeviceLostCallbackInfo deviceLostCallbackInfo;
		public WGPUUncapturedErrorCallbackInfo uncapturedErrorCallbackInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUFutureWaitInfo
	{
		public WGPUFuture future;
		public WGPUBool completed;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUInstanceDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUInstanceCapabilities features;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUProgrammableStageDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUShaderModule module;
		public WGPUStringView entryPoint;
		public ulong constantCount;
		public WGPUConstantEntry* constants;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPURenderPassColorAttachment
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUTextureView view;
		public uint depthSlice;
		public WGPUTextureView resolveTarget;
		public WGPULoadOp loadOp;
		public WGPUStoreOp storeOp;
		public WGPUColor clearValue;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUTexelCopyBufferInfo
	{
		public WGPUTexelCopyBufferLayout layout;
		public WGPUBuffer buffer;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUTexelCopyTextureInfo
	{
		public WGPUTexture texture;
		public uint mipLevel;
		public WGPUOrigin3D origin;
		public WGPUTextureAspect aspect;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUTextureDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUStringView label;
		public WGPUTextureUsage usage;
		public WGPUTextureDimension dimension;
		public WGPUExtent3D size;
		public WGPUTextureFormat format;
		public uint mipLevelCount;
		public uint sampleCount;
		public ulong viewFormatCount;
		public WGPUTextureFormat* viewFormats;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUVertexBufferLayout
	{
		public WGPUVertexStepMode stepMode;
		public ulong arrayStride;
		public ulong attributeCount;
		public WGPUVertexAttribute* attributes;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUBindGroupLayoutDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUStringView label;
		public ulong entryCount;
		public WGPUBindGroupLayoutEntry* entries;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUColorTargetState
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUTextureFormat format;
		public WGPUBlendState* blend;
		public WGPUColorWriteMask writeMask;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUComputePipelineDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUStringView label;
		public WGPUPipelineLayout layout;
		public WGPUProgrammableStageDescriptor compute;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPURenderPassDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUStringView label;
		public ulong colorAttachmentCount;
		public WGPURenderPassColorAttachment* colorAttachments;
		public WGPURenderPassDepthStencilAttachment* depthStencilAttachment;
		public WGPUQuerySet occlusionQuerySet;
		public WGPURenderPassTimestampWrites* timestampWrites;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUVertexState
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUShaderModule module;
		public WGPUStringView entryPoint;
		public ulong constantCount;
		public WGPUConstantEntry* constants;
		public ulong bufferCount;
		public WGPUVertexBufferLayout* buffers;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUFragmentState
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUShaderModule module;
		public WGPUStringView entryPoint;
		public ulong constantCount;
		public WGPUConstantEntry* constants;
		public ulong targetCount;
		public WGPUColorTargetState* targets;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPURenderPipelineDescriptor
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUStringView label;
		public WGPUPipelineLayout layout;
		public WGPUVertexState vertex;
		public WGPUPrimitiveState primitive;
		public WGPUDepthStencilState* depthStencil;
		public WGPUMultisampleState multisample;
		public WGPUFragmentState* fragment;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUBufferMapCallbackInfo
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUCallbackMode mode;
		public delegate* unmanaged<WGPUMapAsyncStatus, WGPUStringView, void*, void*, void> callback;
		public void* userdata1;
		public void* userdata2;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUCompilationInfoCallbackInfo
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUCallbackMode mode;
		public delegate* unmanaged<WGPUCompilationInfoRequestStatus, WGPUCompilationInfo*, void*, void*, void> callback;
		public void* userdata1;
		public void* userdata2;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUCreateComputePipelineAsyncCallbackInfo
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUCallbackMode mode;
		public delegate* unmanaged<WGPUCreatePipelineAsyncStatus, WGPUComputePipeline, WGPUStringView, void*, void*, void> callback;
		public void* userdata1;
		public void* userdata2;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUCreateRenderPipelineAsyncCallbackInfo
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUCallbackMode mode;
		public delegate* unmanaged<WGPUCreatePipelineAsyncStatus, WGPURenderPipeline, WGPUStringView, void*, void*, void> callback;
		public void* userdata1;
		public void* userdata2;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUDeviceLostCallbackInfo
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUCallbackMode mode;
		public delegate* unmanaged<WGPUDevice*, WGPUDeviceLostReason, WGPUStringView, void*, void*, void> callback;
		public void* userdata1;
		public void* userdata2;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUPopErrorScopeCallbackInfo
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUCallbackMode mode;
		public delegate* unmanaged<WGPUPopErrorScopeStatus, WGPUErrorType, WGPUStringView, void*, void*, void> callback;
		public void* userdata1;
		public void* userdata2;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUQueueWorkDoneCallbackInfo
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUCallbackMode mode;
		public delegate* unmanaged<WGPUQueueWorkDoneStatus, void*, void*, void> callback;
		public void* userdata1;
		public void* userdata2;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPURequestAdapterCallbackInfo
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUCallbackMode mode;
		public delegate* unmanaged<WGPURequestAdapterStatus, WGPUAdapter, WGPUStringView, void*, void*, void> callback;
		public void* userdata1;
		public void* userdata2;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPURequestDeviceCallbackInfo
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUCallbackMode mode;
		public delegate* unmanaged<WGPURequestDeviceStatus, WGPUDevice, WGPUStringView, void*, void*, void> callback;
		public void* userdata1;
		public void* userdata2;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUUncapturedErrorCallbackInfo
	{
		public WGPUChainedStruct* nextInChain;
		public delegate* unmanaged<WGPUDevice*, WGPUErrorType, WGPUStringView, void*, void*, void> callback;
		public void* userdata1;
		public void* userdata2;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUChainedStruct
	{
		public WGPUChainedStruct* next;
		public WGPUSType sType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUChainedStructOut
	{
		public WGPUChainedStructOut* next;
		public WGPUSType sType;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUInstanceExtras
	{
		public WGPUChainedStruct chain;
		public WGPUInstanceBackend backends;
		public WGPUInstanceFlag flags;
		public WGPUDx12Compiler dx12ShaderCompiler;
		public WGPUGles3MinorVersion gles3MinorVersion;
		public WGPUStringView dxilPath;
		public WGPUStringView dxcPath;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUDeviceExtras
	{
		public WGPUChainedStruct chain;
		public WGPUStringView tracePath;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUNativeLimits
	{
		public WGPUChainedStructOut chain;
		public uint maxPushConstantSize;
		public uint maxNonSamplerBindings;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUPushConstantRange
	{
		public WGPUShaderStage stages;
		public uint start;
		public uint end;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUPipelineLayoutExtras
	{
		public WGPUChainedStruct chain;
		public ulong pushConstantRangeCount;
		public WGPUPushConstantRange* pushConstantRanges;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUShaderDefine
	{
		public WGPUStringView name;
		public WGPUStringView value;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUShaderModuleGLSLDescriptor
	{
		public WGPUChainedStruct chain;
		public WGPUShaderStage stage;
		public WGPUStringView code;
		public uint defineCount;
		public WGPUShaderDefine* defines;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUShaderModuleDescriptorSpirV
	{
		public WGPUStringView label;
		public uint sourceSize;
		public uint* source;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPURegistryReport
	{
		public ulong numAllocated;
		public ulong numKeptFromUser;
		public ulong numReleasedFromUser;
		public ulong elementSize;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUHubReport
	{
		public WGPURegistryReport adapters;
		public WGPURegistryReport devices;
		public WGPURegistryReport queues;
		public WGPURegistryReport pipelineLayouts;
		public WGPURegistryReport shaderModules;
		public WGPURegistryReport bindGroupLayouts;
		public WGPURegistryReport bindGroups;
		public WGPURegistryReport commandBuffers;
		public WGPURegistryReport renderBundles;
		public WGPURegistryReport renderPipelines;
		public WGPURegistryReport computePipelines;
		public WGPURegistryReport pipelineCaches;
		public WGPURegistryReport querySets;
		public WGPURegistryReport buffers;
		public WGPURegistryReport textures;
		public WGPURegistryReport textureViews;
		public WGPURegistryReport samplers;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUGlobalReport
	{
		public WGPURegistryReport surfaces;
		public WGPUHubReport hub;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUInstanceEnumerateAdapterOptions
	{
		public WGPUChainedStruct* nextInChain;
		public WGPUInstanceBackend backends;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUBindGroupEntryExtras
	{
		public WGPUChainedStruct chain;
		public WGPUBuffer* buffers;
		public ulong bufferCount;
		public WGPUSampler* samplers;
		public ulong samplerCount;
		public WGPUTextureView* textureViews;
		public ulong textureViewCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUBindGroupLayoutEntryExtras
	{
		public WGPUChainedStruct chain;
		public uint count;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUQuerySetDescriptorExtras
	{
		public WGPUChainedStruct chain;
		public WGPUPipelineStatisticName* pipelineStatistics;
		public ulong pipelineStatisticCount;
	}

	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct WGPUSurfaceConfigurationExtras
	{
		public WGPUChainedStruct chain;
		public uint desiredMaximumFrameLatency;
	}

}

