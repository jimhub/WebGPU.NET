using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Evergine.Bindings.WebGPU
{
	public static unsafe partial class WebGPUNative
	{

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCreateInstance")]
		public static extern WGPUInstance wgpuCreateInstance(WGPUInstanceDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuGetInstanceCapabilities")]
		public static extern WGPUStatus wgpuGetInstanceCapabilities(WGPUInstanceCapabilities* capabilities);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuGetProcAddress")]
		public static extern delegate* unmanaged<void> wgpuGetProcAddress(WGPUStringView procName);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuAdapterGetFeatures")]
		public static extern void wgpuAdapterGetFeatures(WGPUAdapter adapter, WGPUSupportedFeatures* features);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuAdapterGetInfo")]
		public static extern WGPUStatus wgpuAdapterGetInfo(WGPUAdapter adapter, WGPUAdapterInfo* info);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuAdapterGetLimits")]
		public static extern WGPUStatus wgpuAdapterGetLimits(WGPUAdapter adapter, WGPULimits* limits);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuAdapterHasFeature")]
		public static extern WGPUBool wgpuAdapterHasFeature(WGPUAdapter adapter, WGPUFeatureName feature);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuAdapterRequestDevice")]
		public static extern WGPUFuture wgpuAdapterRequestDevice(WGPUAdapter adapter, WGPUDeviceDescriptor* descriptor, WGPURequestDeviceCallbackInfo callbackInfo);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuAdapterAddRef")]
		public static extern void wgpuAdapterAddRef(WGPUAdapter adapter);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuAdapterRelease")]
		public static extern void wgpuAdapterRelease(WGPUAdapter adapter);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuAdapterInfoFreeMembers")]
		public static extern void wgpuAdapterInfoFreeMembers(WGPUAdapterInfo adapterInfo);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBindGroupSetLabel")]
		public static extern void wgpuBindGroupSetLabel(WGPUBindGroup bindGroup, WGPUStringView label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBindGroupAddRef")]
		public static extern void wgpuBindGroupAddRef(WGPUBindGroup bindGroup);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBindGroupRelease")]
		public static extern void wgpuBindGroupRelease(WGPUBindGroup bindGroup);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBindGroupLayoutSetLabel")]
		public static extern void wgpuBindGroupLayoutSetLabel(WGPUBindGroupLayout bindGroupLayout, WGPUStringView label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBindGroupLayoutAddRef")]
		public static extern void wgpuBindGroupLayoutAddRef(WGPUBindGroupLayout bindGroupLayout);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBindGroupLayoutRelease")]
		public static extern void wgpuBindGroupLayoutRelease(WGPUBindGroupLayout bindGroupLayout);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBufferDestroy")]
		public static extern void wgpuBufferDestroy(WGPUBuffer buffer);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBufferGetConstMappedRange")]
		public static extern void* wgpuBufferGetConstMappedRange(WGPUBuffer buffer, ulong offset, ulong size);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBufferGetMapState")]
		public static extern WGPUBufferMapState wgpuBufferGetMapState(WGPUBuffer buffer);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBufferGetMappedRange")]
		public static extern void* wgpuBufferGetMappedRange(WGPUBuffer buffer, ulong offset, ulong size);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBufferGetSize")]
		public static extern ulong wgpuBufferGetSize(WGPUBuffer buffer);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBufferGetUsage")]
		public static extern WGPUBufferUsage wgpuBufferGetUsage(WGPUBuffer buffer);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBufferMapAsync")]
		public static extern WGPUFuture wgpuBufferMapAsync(WGPUBuffer buffer, WGPUMapMode mode, ulong offset, ulong size, WGPUBufferMapCallbackInfo callbackInfo);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBufferSetLabel")]
		public static extern void wgpuBufferSetLabel(WGPUBuffer buffer, WGPUStringView label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBufferUnmap")]
		public static extern void wgpuBufferUnmap(WGPUBuffer buffer);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBufferAddRef")]
		public static extern void wgpuBufferAddRef(WGPUBuffer buffer);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuBufferRelease")]
		public static extern void wgpuBufferRelease(WGPUBuffer buffer);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandBufferSetLabel")]
		public static extern void wgpuCommandBufferSetLabel(WGPUCommandBuffer commandBuffer, WGPUStringView label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandBufferAddRef")]
		public static extern void wgpuCommandBufferAddRef(WGPUCommandBuffer commandBuffer);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandBufferRelease")]
		public static extern void wgpuCommandBufferRelease(WGPUCommandBuffer commandBuffer);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderBeginComputePass")]
		public static extern WGPUComputePassEncoder wgpuCommandEncoderBeginComputePass(WGPUCommandEncoder commandEncoder, WGPUComputePassDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderBeginRenderPass")]
		public static extern WGPURenderPassEncoder wgpuCommandEncoderBeginRenderPass(WGPUCommandEncoder commandEncoder, WGPURenderPassDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderClearBuffer")]
		public static extern void wgpuCommandEncoderClearBuffer(WGPUCommandEncoder commandEncoder, WGPUBuffer buffer, ulong offset, ulong size);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderCopyBufferToBuffer")]
		public static extern void wgpuCommandEncoderCopyBufferToBuffer(WGPUCommandEncoder commandEncoder, WGPUBuffer source, ulong sourceOffset, WGPUBuffer destination, ulong destinationOffset, ulong size);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
		public static extern void wgpuCommandEncoderCopyBufferToTexture(WGPUCommandEncoder commandEncoder, WGPUTexelCopyBufferInfo* source, WGPUTexelCopyTextureInfo* destination, WGPUExtent3D* copySize);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
		public static extern void wgpuCommandEncoderCopyTextureToBuffer(WGPUCommandEncoder commandEncoder, WGPUTexelCopyTextureInfo* source, WGPUTexelCopyBufferInfo* destination, WGPUExtent3D* copySize);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
		public static extern void wgpuCommandEncoderCopyTextureToTexture(WGPUCommandEncoder commandEncoder, WGPUTexelCopyTextureInfo* source, WGPUTexelCopyTextureInfo* destination, WGPUExtent3D* copySize);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderFinish")]
		public static extern WGPUCommandBuffer wgpuCommandEncoderFinish(WGPUCommandEncoder commandEncoder, WGPUCommandBufferDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderInsertDebugMarker")]
		public static extern void wgpuCommandEncoderInsertDebugMarker(WGPUCommandEncoder commandEncoder, WGPUStringView markerLabel);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderPopDebugGroup")]
		public static extern void wgpuCommandEncoderPopDebugGroup(WGPUCommandEncoder commandEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderPushDebugGroup")]
		public static extern void wgpuCommandEncoderPushDebugGroup(WGPUCommandEncoder commandEncoder, WGPUStringView groupLabel);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderResolveQuerySet")]
		public static extern void wgpuCommandEncoderResolveQuerySet(WGPUCommandEncoder commandEncoder, WGPUQuerySet querySet, uint firstQuery, uint queryCount, WGPUBuffer destination, ulong destinationOffset);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderSetLabel")]
		public static extern void wgpuCommandEncoderSetLabel(WGPUCommandEncoder commandEncoder, WGPUStringView label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderWriteTimestamp")]
		public static extern void wgpuCommandEncoderWriteTimestamp(WGPUCommandEncoder commandEncoder, WGPUQuerySet querySet, uint queryIndex);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderAddRef")]
		public static extern void wgpuCommandEncoderAddRef(WGPUCommandEncoder commandEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuCommandEncoderRelease")]
		public static extern void wgpuCommandEncoderRelease(WGPUCommandEncoder commandEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePassEncoderDispatchWorkgroups")]
		public static extern void wgpuComputePassEncoderDispatchWorkgroups(WGPUComputePassEncoder computePassEncoder, uint workgroupCountX, uint workgroupCountY, uint workgroupCountZ);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePassEncoderDispatchWorkgroupsIndirect")]
		public static extern void wgpuComputePassEncoderDispatchWorkgroupsIndirect(WGPUComputePassEncoder computePassEncoder, WGPUBuffer indirectBuffer, ulong indirectOffset);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePassEncoderEnd")]
		public static extern void wgpuComputePassEncoderEnd(WGPUComputePassEncoder computePassEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePassEncoderInsertDebugMarker")]
		public static extern void wgpuComputePassEncoderInsertDebugMarker(WGPUComputePassEncoder computePassEncoder, WGPUStringView markerLabel);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePassEncoderPopDebugGroup")]
		public static extern void wgpuComputePassEncoderPopDebugGroup(WGPUComputePassEncoder computePassEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePassEncoderPushDebugGroup")]
		public static extern void wgpuComputePassEncoderPushDebugGroup(WGPUComputePassEncoder computePassEncoder, WGPUStringView groupLabel);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePassEncoderSetBindGroup")]
		public static extern void wgpuComputePassEncoderSetBindGroup(WGPUComputePassEncoder computePassEncoder, uint groupIndex, WGPUBindGroup group, ulong dynamicOffsetCount, uint* dynamicOffsets);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePassEncoderSetLabel")]
		public static extern void wgpuComputePassEncoderSetLabel(WGPUComputePassEncoder computePassEncoder, WGPUStringView label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePassEncoderSetPipeline")]
		public static extern void wgpuComputePassEncoderSetPipeline(WGPUComputePassEncoder computePassEncoder, WGPUComputePipeline pipeline);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePassEncoderAddRef")]
		public static extern void wgpuComputePassEncoderAddRef(WGPUComputePassEncoder computePassEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePassEncoderRelease")]
		public static extern void wgpuComputePassEncoderRelease(WGPUComputePassEncoder computePassEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePipelineGetBindGroupLayout")]
		public static extern WGPUBindGroupLayout wgpuComputePipelineGetBindGroupLayout(WGPUComputePipeline computePipeline, uint groupIndex);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePipelineSetLabel")]
		public static extern void wgpuComputePipelineSetLabel(WGPUComputePipeline computePipeline, WGPUStringView label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePipelineAddRef")]
		public static extern void wgpuComputePipelineAddRef(WGPUComputePipeline computePipeline);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePipelineRelease")]
		public static extern void wgpuComputePipelineRelease(WGPUComputePipeline computePipeline);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceCreateBindGroup")]
		public static extern WGPUBindGroup wgpuDeviceCreateBindGroup(WGPUDevice device, WGPUBindGroupDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceCreateBindGroupLayout")]
		public static extern WGPUBindGroupLayout wgpuDeviceCreateBindGroupLayout(WGPUDevice device, WGPUBindGroupLayoutDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceCreateBuffer")]
		public static extern WGPUBuffer wgpuDeviceCreateBuffer(WGPUDevice device, WGPUBufferDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceCreateCommandEncoder")]
		public static extern WGPUCommandEncoder wgpuDeviceCreateCommandEncoder(WGPUDevice device, WGPUCommandEncoderDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceCreateComputePipeline")]
		public static extern WGPUComputePipeline wgpuDeviceCreateComputePipeline(WGPUDevice device, WGPUComputePipelineDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
		public static extern WGPUFuture wgpuDeviceCreateComputePipelineAsync(WGPUDevice device, WGPUComputePipelineDescriptor* descriptor, WGPUCreateComputePipelineAsyncCallbackInfo callbackInfo);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceCreatePipelineLayout")]
		public static extern WGPUPipelineLayout wgpuDeviceCreatePipelineLayout(WGPUDevice device, WGPUPipelineLayoutDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceCreateQuerySet")]
		public static extern WGPUQuerySet wgpuDeviceCreateQuerySet(WGPUDevice device, WGPUQuerySetDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceCreateRenderBundleEncoder")]
		public static extern WGPURenderBundleEncoder wgpuDeviceCreateRenderBundleEncoder(WGPUDevice device, WGPURenderBundleEncoderDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceCreateRenderPipeline")]
		public static extern WGPURenderPipeline wgpuDeviceCreateRenderPipeline(WGPUDevice device, WGPURenderPipelineDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
		public static extern WGPUFuture wgpuDeviceCreateRenderPipelineAsync(WGPUDevice device, WGPURenderPipelineDescriptor* descriptor, WGPUCreateRenderPipelineAsyncCallbackInfo callbackInfo);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceCreateSampler")]
		public static extern WGPUSampler wgpuDeviceCreateSampler(WGPUDevice device, WGPUSamplerDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceCreateShaderModule")]
		public static extern WGPUShaderModule wgpuDeviceCreateShaderModule(WGPUDevice device, WGPUShaderModuleDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceCreateTexture")]
		public static extern WGPUTexture wgpuDeviceCreateTexture(WGPUDevice device, WGPUTextureDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceDestroy")]
		public static extern void wgpuDeviceDestroy(WGPUDevice device);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceGetAdapterInfo")]
		public static extern WGPUAdapterInfo wgpuDeviceGetAdapterInfo(WGPUDevice device);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceGetFeatures")]
		public static extern void wgpuDeviceGetFeatures(WGPUDevice device, WGPUSupportedFeatures* features);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceGetLimits")]
		public static extern WGPUStatus wgpuDeviceGetLimits(WGPUDevice device, WGPULimits* limits);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceGetLostFuture")]
		public static extern WGPUFuture wgpuDeviceGetLostFuture(WGPUDevice device);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceGetQueue")]
		public static extern WGPUQueue wgpuDeviceGetQueue(WGPUDevice device);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceHasFeature")]
		public static extern WGPUBool wgpuDeviceHasFeature(WGPUDevice device, WGPUFeatureName feature);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceSetLabel")]
		public static extern void wgpuDeviceSetLabel(WGPUDevice device, WGPUStringView label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceAddRef")]
		public static extern void wgpuDeviceAddRef(WGPUDevice device);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceRelease")]
		public static extern void wgpuDeviceRelease(WGPUDevice device);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuInstanceCreateSurface")]
		public static extern WGPUSurface wgpuInstanceCreateSurface(WGPUInstance instance, WGPUSurfaceDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuInstanceGetWGSLLanguageFeatures")]
		public static extern WGPUStatus wgpuInstanceGetWGSLLanguageFeatures(WGPUInstance instance, WGPUSupportedWGSLLanguageFeatures* features);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuInstanceHasWGSLLanguageFeature")]
		public static extern WGPUBool wgpuInstanceHasWGSLLanguageFeature(WGPUInstance instance, WGPUWGSLLanguageFeatureName feature);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuInstanceProcessEvents")]
		public static extern void wgpuInstanceProcessEvents(WGPUInstance instance);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuInstanceRequestAdapter")]
		public static extern WGPUFuture wgpuInstanceRequestAdapter(WGPUInstance instance, WGPURequestAdapterOptions* options, WGPURequestAdapterCallbackInfo callbackInfo);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuInstanceWaitAny")]
		public static extern WGPUWaitStatus wgpuInstanceWaitAny(WGPUInstance instance, ulong futureCount, WGPUFutureWaitInfo* futures, ulong timeoutNS);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuInstanceAddRef")]
		public static extern void wgpuInstanceAddRef(WGPUInstance instance);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuInstanceRelease")]
		public static extern void wgpuInstanceRelease(WGPUInstance instance);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuPipelineLayoutSetLabel")]
		public static extern void wgpuPipelineLayoutSetLabel(WGPUPipelineLayout pipelineLayout, WGPUStringView label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuPipelineLayoutAddRef")]
		public static extern void wgpuPipelineLayoutAddRef(WGPUPipelineLayout pipelineLayout);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuPipelineLayoutRelease")]
		public static extern void wgpuPipelineLayoutRelease(WGPUPipelineLayout pipelineLayout);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuQuerySetDestroy")]
		public static extern void wgpuQuerySetDestroy(WGPUQuerySet querySet);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuQuerySetGetCount")]
		public static extern uint wgpuQuerySetGetCount(WGPUQuerySet querySet);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuQuerySetGetType")]
		public static extern WGPUQueryType wgpuQuerySetGetType(WGPUQuerySet querySet);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuQuerySetSetLabel")]
		public static extern void wgpuQuerySetSetLabel(WGPUQuerySet querySet, WGPUStringView label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuQuerySetAddRef")]
		public static extern void wgpuQuerySetAddRef(WGPUQuerySet querySet);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuQuerySetRelease")]
		public static extern void wgpuQuerySetRelease(WGPUQuerySet querySet);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuQueueOnSubmittedWorkDone")]
		public static extern WGPUFuture wgpuQueueOnSubmittedWorkDone(WGPUQueue queue, WGPUQueueWorkDoneCallbackInfo callbackInfo);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuQueueSetLabel")]
		public static extern void wgpuQueueSetLabel(WGPUQueue queue, WGPUStringView label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuQueueSubmit")]
		public static extern void wgpuQueueSubmit(WGPUQueue queue, ulong commandCount, WGPUCommandBuffer* commands);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuQueueWriteBuffer")]
		public static extern void wgpuQueueWriteBuffer(WGPUQueue queue, WGPUBuffer buffer, ulong bufferOffset, void* data, ulong size);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuQueueWriteTexture")]
		public static extern void wgpuQueueWriteTexture(WGPUQueue queue, WGPUTexelCopyTextureInfo* destination, void* data, ulong dataSize, WGPUTexelCopyBufferLayout* dataLayout, WGPUExtent3D* writeSize);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuQueueAddRef")]
		public static extern void wgpuQueueAddRef(WGPUQueue queue);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuQueueRelease")]
		public static extern void wgpuQueueRelease(WGPUQueue queue);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleSetLabel")]
		public static extern void wgpuRenderBundleSetLabel(WGPURenderBundle renderBundle, WGPUStringView label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleAddRef")]
		public static extern void wgpuRenderBundleAddRef(WGPURenderBundle renderBundle);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleRelease")]
		public static extern void wgpuRenderBundleRelease(WGPURenderBundle renderBundle);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleEncoderDraw")]
		public static extern void wgpuRenderBundleEncoderDraw(WGPURenderBundleEncoder renderBundleEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleEncoderDrawIndexed")]
		public static extern void wgpuRenderBundleEncoderDrawIndexed(WGPURenderBundleEncoder renderBundleEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleEncoderFinish")]
		public static extern WGPURenderBundle wgpuRenderBundleEncoderFinish(WGPURenderBundleEncoder renderBundleEncoder, WGPURenderBundleDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleEncoderInsertDebugMarker")]
		public static extern void wgpuRenderBundleEncoderInsertDebugMarker(WGPURenderBundleEncoder renderBundleEncoder, WGPUStringView markerLabel);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleEncoderPopDebugGroup")]
		public static extern void wgpuRenderBundleEncoderPopDebugGroup(WGPURenderBundleEncoder renderBundleEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleEncoderPushDebugGroup")]
		public static extern void wgpuRenderBundleEncoderPushDebugGroup(WGPURenderBundleEncoder renderBundleEncoder, WGPUStringView groupLabel);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleEncoderSetBindGroup")]
		public static extern void wgpuRenderBundleEncoderSetBindGroup(WGPURenderBundleEncoder renderBundleEncoder, uint groupIndex, WGPUBindGroup group, ulong dynamicOffsetCount, uint* dynamicOffsets);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleEncoderSetIndexBuffer")]
		public static extern void wgpuRenderBundleEncoderSetIndexBuffer(WGPURenderBundleEncoder renderBundleEncoder, WGPUBuffer buffer, WGPUIndexFormat format, ulong offset, ulong size);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleEncoderSetLabel")]
		public static extern void wgpuRenderBundleEncoderSetLabel(WGPURenderBundleEncoder renderBundleEncoder, WGPUStringView label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleEncoderSetPipeline")]
		public static extern void wgpuRenderBundleEncoderSetPipeline(WGPURenderBundleEncoder renderBundleEncoder, WGPURenderPipeline pipeline);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleEncoderSetVertexBuffer")]
		public static extern void wgpuRenderBundleEncoderSetVertexBuffer(WGPURenderBundleEncoder renderBundleEncoder, uint slot, WGPUBuffer buffer, ulong offset, ulong size);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleEncoderAddRef")]
		public static extern void wgpuRenderBundleEncoderAddRef(WGPURenderBundleEncoder renderBundleEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleEncoderRelease")]
		public static extern void wgpuRenderBundleEncoderRelease(WGPURenderBundleEncoder renderBundleEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderBeginOcclusionQuery")]
		public static extern void wgpuRenderPassEncoderBeginOcclusionQuery(WGPURenderPassEncoder renderPassEncoder, uint queryIndex);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderDraw")]
		public static extern void wgpuRenderPassEncoderDraw(WGPURenderPassEncoder renderPassEncoder, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderDrawIndexed")]
		public static extern void wgpuRenderPassEncoderDrawIndexed(WGPURenderPassEncoder renderPassEncoder, uint indexCount, uint instanceCount, uint firstIndex, int baseVertex, uint firstInstance);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderDrawIndexedIndirect")]
		public static extern void wgpuRenderPassEncoderDrawIndexedIndirect(WGPURenderPassEncoder renderPassEncoder, WGPUBuffer indirectBuffer, ulong indirectOffset);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderDrawIndirect")]
		public static extern void wgpuRenderPassEncoderDrawIndirect(WGPURenderPassEncoder renderPassEncoder, WGPUBuffer indirectBuffer, ulong indirectOffset);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderEnd")]
		public static extern void wgpuRenderPassEncoderEnd(WGPURenderPassEncoder renderPassEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderEndOcclusionQuery")]
		public static extern void wgpuRenderPassEncoderEndOcclusionQuery(WGPURenderPassEncoder renderPassEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderExecuteBundles")]
		public static extern void wgpuRenderPassEncoderExecuteBundles(WGPURenderPassEncoder renderPassEncoder, ulong bundleCount, WGPURenderBundle* bundles);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderInsertDebugMarker")]
		public static extern void wgpuRenderPassEncoderInsertDebugMarker(WGPURenderPassEncoder renderPassEncoder, WGPUStringView markerLabel);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderPopDebugGroup")]
		public static extern void wgpuRenderPassEncoderPopDebugGroup(WGPURenderPassEncoder renderPassEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderPushDebugGroup")]
		public static extern void wgpuRenderPassEncoderPushDebugGroup(WGPURenderPassEncoder renderPassEncoder, WGPUStringView groupLabel);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderSetBindGroup")]
		public static extern void wgpuRenderPassEncoderSetBindGroup(WGPURenderPassEncoder renderPassEncoder, uint groupIndex, WGPUBindGroup group, ulong dynamicOffsetCount, uint* dynamicOffsets);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderSetBlendConstant")]
		public static extern void wgpuRenderPassEncoderSetBlendConstant(WGPURenderPassEncoder renderPassEncoder, WGPUColor* color);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderSetIndexBuffer")]
		public static extern void wgpuRenderPassEncoderSetIndexBuffer(WGPURenderPassEncoder renderPassEncoder, WGPUBuffer buffer, WGPUIndexFormat format, ulong offset, ulong size);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderSetLabel")]
		public static extern void wgpuRenderPassEncoderSetLabel(WGPURenderPassEncoder renderPassEncoder, WGPUStringView label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderSetPipeline")]
		public static extern void wgpuRenderPassEncoderSetPipeline(WGPURenderPassEncoder renderPassEncoder, WGPURenderPipeline pipeline);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderSetScissorRect")]
		public static extern void wgpuRenderPassEncoderSetScissorRect(WGPURenderPassEncoder renderPassEncoder, uint x, uint y, uint width, uint height);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderSetStencilReference")]
		public static extern void wgpuRenderPassEncoderSetStencilReference(WGPURenderPassEncoder renderPassEncoder, uint reference);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderSetVertexBuffer")]
		public static extern void wgpuRenderPassEncoderSetVertexBuffer(WGPURenderPassEncoder renderPassEncoder, uint slot, WGPUBuffer buffer, ulong offset, ulong size);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderSetViewport")]
		public static extern void wgpuRenderPassEncoderSetViewport(WGPURenderPassEncoder renderPassEncoder, float x, float y, float width, float height, float minDepth, float maxDepth);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderAddRef")]
		public static extern void wgpuRenderPassEncoderAddRef(WGPURenderPassEncoder renderPassEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderRelease")]
		public static extern void wgpuRenderPassEncoderRelease(WGPURenderPassEncoder renderPassEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPipelineGetBindGroupLayout")]
		public static extern WGPUBindGroupLayout wgpuRenderPipelineGetBindGroupLayout(WGPURenderPipeline renderPipeline, uint groupIndex);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPipelineSetLabel")]
		public static extern void wgpuRenderPipelineSetLabel(WGPURenderPipeline renderPipeline, WGPUStringView label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPipelineAddRef")]
		public static extern void wgpuRenderPipelineAddRef(WGPURenderPipeline renderPipeline);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPipelineRelease")]
		public static extern void wgpuRenderPipelineRelease(WGPURenderPipeline renderPipeline);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuSamplerSetLabel")]
		public static extern void wgpuSamplerSetLabel(WGPUSampler sampler, WGPUStringView label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuSamplerAddRef")]
		public static extern void wgpuSamplerAddRef(WGPUSampler sampler);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuSamplerRelease")]
		public static extern void wgpuSamplerRelease(WGPUSampler sampler);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuShaderModuleGetCompilationInfo")]
		public static extern WGPUFuture wgpuShaderModuleGetCompilationInfo(WGPUShaderModule shaderModule, WGPUCompilationInfoCallbackInfo callbackInfo);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuShaderModuleSetLabel")]
		public static extern void wgpuShaderModuleSetLabel(WGPUShaderModule shaderModule, WGPUStringView label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuShaderModuleAddRef")]
		public static extern void wgpuShaderModuleAddRef(WGPUShaderModule shaderModule);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuShaderModuleRelease")]
		public static extern void wgpuShaderModuleRelease(WGPUShaderModule shaderModule);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuSupportedFeaturesFreeMembers")]
		public static extern void wgpuSupportedFeaturesFreeMembers(WGPUSupportedFeatures supportedFeatures);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuSupportedWGSLLanguageFeaturesFreeMembers")]
		public static extern void wgpuSupportedWGSLLanguageFeaturesFreeMembers(WGPUSupportedWGSLLanguageFeatures supportedWGSLLanguageFeatures);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuSurfaceConfigure")]
		public static extern void wgpuSurfaceConfigure(WGPUSurface surface, WGPUSurfaceConfiguration* config);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuSurfaceGetCapabilities")]
		public static extern WGPUStatus wgpuSurfaceGetCapabilities(WGPUSurface surface, WGPUAdapter adapter, WGPUSurfaceCapabilities* capabilities);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuSurfaceGetCurrentTexture")]
		public static extern void wgpuSurfaceGetCurrentTexture(WGPUSurface surface, WGPUSurfaceTexture* surfaceTexture);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuSurfacePresent")]
		public static extern WGPUStatus wgpuSurfacePresent(WGPUSurface surface);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuSurfaceSetLabel")]
		public static extern void wgpuSurfaceSetLabel(WGPUSurface surface, WGPUStringView label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuSurfaceUnconfigure")]
		public static extern void wgpuSurfaceUnconfigure(WGPUSurface surface);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuSurfaceAddRef")]
		public static extern void wgpuSurfaceAddRef(WGPUSurface surface);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuSurfaceRelease")]
		public static extern void wgpuSurfaceRelease(WGPUSurface surface);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuSurfaceCapabilitiesFreeMembers")]
		public static extern void wgpuSurfaceCapabilitiesFreeMembers(WGPUSurfaceCapabilities surfaceCapabilities);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureCreateView")]
		public static extern WGPUTextureView wgpuTextureCreateView(WGPUTexture texture, WGPUTextureViewDescriptor* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureDestroy")]
		public static extern void wgpuTextureDestroy(WGPUTexture texture);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureGetDepthOrArrayLayers")]
		public static extern uint wgpuTextureGetDepthOrArrayLayers(WGPUTexture texture);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureGetDimension")]
		public static extern WGPUTextureDimension wgpuTextureGetDimension(WGPUTexture texture);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureGetFormat")]
		public static extern WGPUTextureFormat wgpuTextureGetFormat(WGPUTexture texture);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureGetHeight")]
		public static extern uint wgpuTextureGetHeight(WGPUTexture texture);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureGetMipLevelCount")]
		public static extern uint wgpuTextureGetMipLevelCount(WGPUTexture texture);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureGetSampleCount")]
		public static extern uint wgpuTextureGetSampleCount(WGPUTexture texture);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureGetUsage")]
		public static extern WGPUTextureUsage wgpuTextureGetUsage(WGPUTexture texture);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureGetWidth")]
		public static extern uint wgpuTextureGetWidth(WGPUTexture texture);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureSetLabel")]
		public static extern void wgpuTextureSetLabel(WGPUTexture texture, WGPUStringView label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureAddRef")]
		public static extern void wgpuTextureAddRef(WGPUTexture texture);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureRelease")]
		public static extern void wgpuTextureRelease(WGPUTexture texture);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureViewSetLabel")]
		public static extern void wgpuTextureViewSetLabel(WGPUTextureView textureView, WGPUStringView label);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureViewAddRef")]
		public static extern void wgpuTextureViewAddRef(WGPUTextureView textureView);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuTextureViewRelease")]
		public static extern void wgpuTextureViewRelease(WGPUTextureView textureView);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuGenerateReport")]
		public static extern void wgpuGenerateReport(WGPUInstance instance, WGPUGlobalReport* report);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuInstanceEnumerateAdapters")]
		public static extern ulong wgpuInstanceEnumerateAdapters(WGPUInstance instance, WGPUInstanceEnumerateAdapterOptions* options, WGPUAdapter* adapters);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuQueueSubmitForIndex")]
		public static extern ulong wgpuQueueSubmitForIndex(WGPUQueue queue, ulong commandCount, WGPUCommandBuffer* commands);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDevicePoll")]
		public static extern WGPUBool wgpuDevicePoll(WGPUDevice device, WGPUBool wait, ulong* wrappedSubmissionIndex);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuDeviceCreateShaderModuleSpirV")]
		public static extern WGPUShaderModule wgpuDeviceCreateShaderModuleSpirV(WGPUDevice device, WGPUShaderModuleDescriptorSpirV* descriptor);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuSetLogCallback")]
		public static extern void wgpuSetLogCallback(delegate* unmanaged<WGPULogLevel, WGPUStringView, void*, void> callback, void* userdata);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuSetLogLevel")]
		public static extern void wgpuSetLogLevel(WGPULogLevel level);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuGetVersion")]
		public static extern uint wgpuGetVersion();

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderSetPushConstants")]
		public static extern void wgpuRenderPassEncoderSetPushConstants(WGPURenderPassEncoder encoder, WGPUShaderStage stages, uint offset, uint sizeBytes, void* data);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePassEncoderSetPushConstants")]
		public static extern void wgpuComputePassEncoderSetPushConstants(WGPUComputePassEncoder encoder, uint offset, uint sizeBytes, void* data);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderBundleEncoderSetPushConstants")]
		public static extern void wgpuRenderBundleEncoderSetPushConstants(WGPURenderBundleEncoder encoder, WGPUShaderStage stages, uint offset, uint sizeBytes, void* data);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderMultiDrawIndirect")]
		public static extern void wgpuRenderPassEncoderMultiDrawIndirect(WGPURenderPassEncoder encoder, WGPUBuffer buffer, ulong offset, uint count);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderMultiDrawIndexedIndirect")]
		public static extern void wgpuRenderPassEncoderMultiDrawIndexedIndirect(WGPURenderPassEncoder encoder, WGPUBuffer buffer, ulong offset, uint count);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderMultiDrawIndirectCount")]
		public static extern void wgpuRenderPassEncoderMultiDrawIndirectCount(WGPURenderPassEncoder encoder, WGPUBuffer buffer, ulong offset, WGPUBuffer count_buffer, ulong count_buffer_offset, uint max_count);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderMultiDrawIndexedIndirectCount")]
		public static extern void wgpuRenderPassEncoderMultiDrawIndexedIndirectCount(WGPURenderPassEncoder encoder, WGPUBuffer buffer, ulong offset, WGPUBuffer count_buffer, ulong count_buffer_offset, uint max_count);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePassEncoderBeginPipelineStatisticsQuery")]
		public static extern void wgpuComputePassEncoderBeginPipelineStatisticsQuery(WGPUComputePassEncoder computePassEncoder, WGPUQuerySet querySet, uint queryIndex);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePassEncoderEndPipelineStatisticsQuery")]
		public static extern void wgpuComputePassEncoderEndPipelineStatisticsQuery(WGPUComputePassEncoder computePassEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderBeginPipelineStatisticsQuery")]
		public static extern void wgpuRenderPassEncoderBeginPipelineStatisticsQuery(WGPURenderPassEncoder renderPassEncoder, WGPUQuerySet querySet, uint queryIndex);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderEndPipelineStatisticsQuery")]
		public static extern void wgpuRenderPassEncoderEndPipelineStatisticsQuery(WGPURenderPassEncoder renderPassEncoder);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuComputePassEncoderWriteTimestamp")]
		public static extern void wgpuComputePassEncoderWriteTimestamp(WGPUComputePassEncoder computePassEncoder, WGPUQuerySet querySet, uint queryIndex);

		[DllImport("wgpu_native", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wgpuRenderPassEncoderWriteTimestamp")]
		public static extern void wgpuRenderPassEncoderWriteTimestamp(WGPURenderPassEncoder renderPassEncoder, WGPUQuerySet querySet, uint queryIndex);
	}
}
