using System;

namespace Evergine.Bindings.WebGPU
{
	public unsafe delegate void WGPUProc();

	public unsafe delegate void WGPUBufferMapCallback(
		 WGPUMapAsyncStatus status,
		 WGPUStringView message,
		 void* userdata1,
		 void* userdata2);

	public unsafe delegate void WGPUCompilationInfoCallback(
		 WGPUCompilationInfoRequestStatus status,
		 WGPUCompilationInfo* compilationInfo,
		 void* userdata1,
		 void* userdata2);

	public unsafe delegate void WGPUCreateComputePipelineAsyncCallback(
		 WGPUCreatePipelineAsyncStatus status,
		 WGPUComputePipeline pipeline,
		 WGPUStringView message,
		 void* userdata1,
		 void* userdata2);

	public unsafe delegate void WGPUCreateRenderPipelineAsyncCallback(
		 WGPUCreatePipelineAsyncStatus status,
		 WGPURenderPipeline pipeline,
		 WGPUStringView message,
		 void* userdata1,
		 void* userdata2);

	public unsafe delegate void WGPUDeviceLostCallback(
		 WGPUDevice* device,
		 WGPUDeviceLostReason reason,
		 WGPUStringView message,
		 void* userdata1,
		 void* userdata2);

	public unsafe delegate void WGPUPopErrorScopeCallback(
		 WGPUPopErrorScopeStatus status,
		 WGPUErrorType type,
		 WGPUStringView message,
		 void* userdata1,
		 void* userdata2);

	public unsafe delegate void WGPUQueueWorkDoneCallback(
		 WGPUQueueWorkDoneStatus status,
		 void* userdata1,
		 void* userdata2);

	public unsafe delegate void WGPURequestAdapterCallback(
		 WGPURequestAdapterStatus status,
		 WGPUAdapter adapter,
		 WGPUStringView message,
		 void* userdata1,
		 void* userdata2);

	public unsafe delegate void WGPURequestDeviceCallback(
		 WGPURequestDeviceStatus status,
		 WGPUDevice device,
		 WGPUStringView message,
		 void* userdata1,
		 void* userdata2);

	public unsafe delegate void WGPUUncapturedErrorCallback(
		 WGPUDevice* device,
		 WGPUErrorType type,
		 WGPUStringView message,
		 void* userdata1,
		 void* userdata2);

	public unsafe delegate void WGPULogCallback(
		 WGPULogLevel level,
		 WGPUStringView message,
		 void* userdata);

}
