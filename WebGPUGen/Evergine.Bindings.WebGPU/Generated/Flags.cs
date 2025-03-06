using System;

namespace Evergine.Bindings.WebGPU
{
	[Flags]
	public enum WGPUBufferUsage : ulong
	{
		None = 0,
		MapRead = 1,
		MapWrite = 2,
		CopySrc = 4,
		CopyDst = 8,
		Index = 16,
		Vertex = 32,
		Uniform = 64,
		Storage = 128,
		Indirect = 256,
		QueryResolve = 512,
	}

	[Flags]
	public enum WGPUColorWriteMask : ulong
	{
		None = 0,
		Red = 1,
		Green = 2,
		Blue = 4,
		Alpha = 8,
		All = 15,
	}

	[Flags]
	public enum WGPUMapMode : ulong
	{
		None = 0,
		Read = 1,
		Write = 2,
	}

	[Flags]
	public enum WGPUShaderStage : ulong
	{
		None = 0,
		Vertex = 1,
		Fragment = 2,
		Compute = 4,
	}

	[Flags]
	public enum WGPUTextureUsage : ulong
	{
		None = 0,
		CopySrc = 1,
		CopyDst = 2,
		TextureBinding = 4,
		StorageBinding = 8,
		RenderAttachment = 16,
	}

	[Flags]
	public enum WGPUInstanceBackend : ulong
	{
		All = 0,
		Vulkan = 1,
		GL = 2,
		Metal = 4,
		DX12 = 8,
		DX11 = 16,
		BrowserWebGPU = 32,
		Primary = 45,
		Secondary = 18,
		Force32 = 2147483647,
	}

	[Flags]
	public enum WGPUInstanceFlag : ulong
	{
		Default = 0,
		Debug = 1,
		Validation = 2,
		DiscardHalLabels = 4,
		Force32 = 2147483647,
	}

}
