// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2018
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

// This file was automatically generated and should not be edited directly.

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public enum StructureType
    {
        /// <summary>
        /// 
        /// </summary>
        ApplicationInfo = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        InstanceCreateInfo = 1, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceQueueCreateInfo = 2, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceCreateInfo = 3, 
        
        /// <summary>
        /// 
        /// </summary>
        SubmitInfo = 4, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryAllocateInfo = 5, 
        
        /// <summary>
        /// 
        /// </summary>
        MappedMemoryRange = 6, 
        
        /// <summary>
        /// 
        /// </summary>
        BindSparseInfo = 7, 
        
        /// <summary>
        /// 
        /// </summary>
        FenceCreateInfo = 8, 
        
        /// <summary>
        /// 
        /// </summary>
        SemaphoreCreateInfo = 9, 
        
        /// <summary>
        /// 
        /// </summary>
        EventCreateInfo = 10, 
        
        /// <summary>
        /// 
        /// </summary>
        QueryPoolCreateInfo = 11, 
        
        /// <summary>
        /// 
        /// </summary>
        BufferCreateInfo = 12, 
        
        /// <summary>
        /// 
        /// </summary>
        BufferViewCreateInfo = 13, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageCreateInfo = 14, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageViewCreateInfo = 15, 
        
        /// <summary>
        /// 
        /// </summary>
        ShaderModuleCreateInfo = 16, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineCacheCreateInfo = 17, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineShaderStageCreateInfo = 18, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineVertexInputStateCreateInfo = 19, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineInputAssemblyStateCreateInfo = 20, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineTessellationStateCreateInfo = 21, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineViewportStateCreateInfo = 22, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineRasterizationStateCreateInfo = 23, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineMultisampleStateCreateInfo = 24, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineDepthStencilStateCreateInfo = 25, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineColorBlendStateCreateInfo = 26, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineDynamicStateCreateInfo = 27, 
        
        /// <summary>
        /// 
        /// </summary>
        GraphicsPipelineCreateInfo = 28, 
        
        /// <summary>
        /// 
        /// </summary>
        ComputePipelineCreateInfo = 29, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineLayoutCreateInfo = 30, 
        
        /// <summary>
        /// 
        /// </summary>
        SamplerCreateInfo = 31, 
        
        /// <summary>
        /// 
        /// </summary>
        DescriptorSetLayoutCreateInfo = 32, 
        
        /// <summary>
        /// 
        /// </summary>
        DescriptorPoolCreateInfo = 33, 
        
        /// <summary>
        /// 
        /// </summary>
        DescriptorSetAllocateInfo = 34, 
        
        /// <summary>
        /// 
        /// </summary>
        WriteDescriptorSet = 35, 
        
        /// <summary>
        /// 
        /// </summary>
        CopyDescriptorSet = 36, 
        
        /// <summary>
        /// 
        /// </summary>
        FramebufferCreateInfo = 37, 
        
        /// <summary>
        /// 
        /// </summary>
        RenderPassCreateInfo = 38, 
        
        /// <summary>
        /// 
        /// </summary>
        CommandPoolCreateInfo = 39, 
        
        /// <summary>
        /// 
        /// </summary>
        CommandBufferAllocateInfo = 40, 
        
        /// <summary>
        /// 
        /// </summary>
        CommandBufferInheritanceInfo = 41, 
        
        /// <summary>
        /// 
        /// </summary>
        CommandBufferBeginInfo = 42, 
        
        /// <summary>
        /// 
        /// </summary>
        RenderPassBeginInfo = 43, 
        
        /// <summary>
        /// 
        /// </summary>
        BufferMemoryBarrier = 44, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageMemoryBarrier = 45, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryBarrier = 46, 
        
        /// <summary>
        /// 
        /// </summary>
        LoaderInstanceCreateInfo = 47, 
        
        /// <summary>
        /// 
        /// </summary>
        LoaderDeviceCreateInfo = 48, 
        
        /// <summary>
        /// 
        /// </summary>
        SwapchainCreateInfo = 1000001000, 
        
        /// <summary>
        /// 
        /// </summary>
        PresentInfo = 1000001001, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceGroupPresentCapabilities = 1000060007, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageSwapchainCreateInfo = 1000060008, 
        
        /// <summary>
        /// 
        /// </summary>
        BindImageMemorySwapchainInfo = 1000060009, 
        
        /// <summary>
        /// 
        /// </summary>
        AcquireNextImageInfo = 1000060010, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceGroupPresentInfo = 1000060011, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceGroupSwapchainCreateInfo = 1000060012, 
        
        /// <summary>
        /// 
        /// </summary>
        DisplayModeCreateInfo = 1000002000, 
        
        /// <summary>
        /// 
        /// </summary>
        DisplaySurfaceCreateInfo = 1000002001, 
        
        /// <summary>
        /// 
        /// </summary>
        DisplayPresentInfo = 1000003000, 
        
        /// <summary>
        /// 
        /// </summary>
        XlibSurfaceCreateInfo = 1000004000, 
        
        /// <summary>
        /// 
        /// </summary>
        XcbSurfaceCreateInfo = 1000005000, 
        
        /// <summary>
        /// 
        /// </summary>
        WaylandSurfaceCreateInfo = 1000006000, 
        
        /// <summary>
        /// 
        /// </summary>
        AndroidSurfaceCreateInfo = 1000008000, 
        
        /// <summary>
        /// 
        /// </summary>
        Win32SurfaceCreateInfo = 1000009000, 
        
        /// <summary>
        /// 
        /// </summary>
        NativeBuffer = 1000010000, 
        
        /// <summary>
        /// 
        /// </summary>
        DebugReportCallbackCreateInfo = 1000011000, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineRasterizationStateRasterizationOrder = 1000018000, 
        
        /// <summary>
        /// 
        /// </summary>
        DebugMarkerObjectNameInfo = 1000022000, 
        
        /// <summary>
        /// 
        /// </summary>
        DebugMarkerObjectTagInfo = 1000022001, 
        
        /// <summary>
        /// 
        /// </summary>
        DebugMarkerMarkerInfo = 1000022002, 
        
        /// <summary>
        /// 
        /// </summary>
        DedicatedAllocationImageCreateInfo = 1000026000, 
        
        /// <summary>
        /// 
        /// </summary>
        DedicatedAllocationBufferCreateInfo = 1000026001, 
        
        /// <summary>
        /// 
        /// </summary>
        DedicatedAllocationMemoryAllocateInfo = 1000026002, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceTransformFeedbackFeatures = 1000028000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceTransformFeedbackProperties = 1000028001, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineRasterizationStateStreamCreateInfo = 1000028002, 
        
        /// <summary>
        /// 
        /// </summary>
        TextureLodGatherFormatProperties = 1000041000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceCornerSampledImageFeatures = 1000050000, 
        
        /// <summary>
        /// 
        /// </summary>
        ExternalMemoryImageCreateInfoNv = 1000056000, 
        
        /// <summary>
        /// 
        /// </summary>
        ExportMemoryAllocateInfoNv = 1000056001, 
        
        /// <summary>
        /// 
        /// </summary>
        ImportMemoryWin32HandleInfoNv = 1000057000, 
        
        /// <summary>
        /// 
        /// </summary>
        ExportMemoryWin32HandleInfoNv = 1000057001, 
        
        /// <summary>
        /// 
        /// </summary>
        Win32KeyedMutexAcquireReleaseInfoNv = 1000058000, 
        
        /// <summary>
        /// 
        /// </summary>
        ValidationFlags = 1000061000, 
        
        /// <summary>
        /// 
        /// </summary>
        ViSurfaceCreateInfo = 1000062000, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageViewAstcDecodeMode = 1000067000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceAstcDecodeFeatures = 1000067001, 
        
        /// <summary>
        /// 
        /// </summary>
        ImportMemoryWin32HandleInfoKhr = 1000073000, 
        
        /// <summary>
        /// 
        /// </summary>
        ExportMemoryWin32HandleInfoKhr = 1000073001, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryWin32HandleProperties = 1000073002, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryGetWin32HandleInfo = 1000073003, 
        
        /// <summary>
        /// 
        /// </summary>
        ImportMemoryFileDescriptorInfo = 1000074000, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryFileDescriptorProperties = 1000074001, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryGetFileDescriptorInfo = 1000074002, 
        
        /// <summary>
        /// 
        /// </summary>
        Win32KeyedMutexAcquireReleaseInfoKhr = 1000075000, 
        
        /// <summary>
        /// 
        /// </summary>
        ImportSemaphoreWin32HandleInfo = 1000078000, 
        
        /// <summary>
        /// 
        /// </summary>
        ExportSemaphoreWin32HandleInfo = 1000078001, 
        
        /// <summary>
        /// 
        /// </summary>
        D3D12FenceSubmitInfo = 1000078002, 
        
        /// <summary>
        /// 
        /// </summary>
        SemaphoreGetWin32HandleInfo = 1000078003, 
        
        /// <summary>
        /// 
        /// </summary>
        ImportSemaphoreFileDescriptorInfo = 1000079000, 
        
        /// <summary>
        /// 
        /// </summary>
        SemaphoreGetFileDescriptorInfo = 1000079001, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDevicePushDescriptorProperties = 1000080000, 
        
        /// <summary>
        /// 
        /// </summary>
        CommandBufferInheritanceConditionalRenderingInfo = 1000081000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceConditionalRenderingFeatures = 1000081001, 
        
        /// <summary>
        /// 
        /// </summary>
        ConditionalRenderingBeginInfo = 1000081002, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceFloat16Int8Features = 1000082000, 
        
        /// <summary>
        /// 
        /// </summary>
        PresentRegions = 1000084000, 
        
        /// <summary>
        /// 
        /// </summary>
        ObjectTableCreateInfo = 1000086000, 
        
        /// <summary>
        /// 
        /// </summary>
        IndirectCommandsLayoutCreateInfo = 1000086001, 
        
        /// <summary>
        /// 
        /// </summary>
        CommandProcessCommandsInfo = 1000086002, 
        
        /// <summary>
        /// 
        /// </summary>
        CommandReserveSpaceForCommandsInfo = 1000086003, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceGeneratedCommandsLimits = 1000086004, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceGeneratedCommandsFeatures = 1000086005, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineViewportWScalingStateCreateInfo = 1000087000, 
        
        /// <summary>
        /// 
        /// </summary>
        SurfaceCapabilities2Ext = 1000090000, 
        
        /// <summary>
        /// 
        /// </summary>
        DisplayPowerInfo = 1000091000, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceEventInfo = 1000091001, 
        
        /// <summary>
        /// 
        /// </summary>
        DisplayEventInfo = 1000091002, 
        
        /// <summary>
        /// 
        /// </summary>
        SwapchainCounterCreateInfo = 1000091003, 
        
        /// <summary>
        /// 
        /// </summary>
        PresentTimesInfo = 1000092000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceMultiviewPerViewAttributesProperties = 1000097000, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineViewportSwizzleStateCreateInfo = 1000098000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceDiscardRectangleProperties = 1000099000, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineDiscardRectangleStateCreateInfo = 1000099001, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceConservativeRasterizationProperties = 1000101000, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineRasterizationConservativeStateCreateInfo = 1000101001, 
        
        /// <summary>
        /// 
        /// </summary>
        HdrMetadata = 1000105000, 
        
        /// <summary>
        /// 
        /// </summary>
        AttachmentDescription2 = 1000109000, 
        
        /// <summary>
        /// 
        /// </summary>
        AttachmentReference2 = 1000109001, 
        
        /// <summary>
        /// 
        /// </summary>
        SubpassDescription2 = 1000109002, 
        
        /// <summary>
        /// 
        /// </summary>
        SubpassDependency2 = 1000109003, 
        
        /// <summary>
        /// 
        /// </summary>
        RenderPassCreateInfo2 = 1000109004, 
        
        /// <summary>
        /// 
        /// </summary>
        SubpassBeginInfo = 1000109005, 
        
        /// <summary>
        /// 
        /// </summary>
        SubpassEndInfo = 1000109006, 
        
        /// <summary>
        /// 
        /// </summary>
        SharedPresentSurfaceCapabilities = 1000111000, 
        
        /// <summary>
        /// 
        /// </summary>
        ImportFenceWin32HandleInfo = 1000114000, 
        
        /// <summary>
        /// 
        /// </summary>
        ExportFenceWin32HandleInfo = 1000114001, 
        
        /// <summary>
        /// 
        /// </summary>
        FenceGetWin32HandleInfo = 1000114002, 
        
        /// <summary>
        /// 
        /// </summary>
        ImportFenceFileDescriptorInfo = 1000115000, 
        
        /// <summary>
        /// 
        /// </summary>
        FenceGetFileDescriptorInfo = 1000115001, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceSurfaceInfo2 = 1000119000, 
        
        /// <summary>
        /// 
        /// </summary>
        SurfaceCapabilities2Khr = 1000119001, 
        
        /// <summary>
        /// 
        /// </summary>
        SurfaceFormat2 = 1000119002, 
        
        /// <summary>
        /// 
        /// </summary>
        DisplayProperties2 = 1000121000, 
        
        /// <summary>
        /// 
        /// </summary>
        DisplayPlaneProperties2 = 1000121001, 
        
        /// <summary>
        /// 
        /// </summary>
        DisplayModeProperties2 = 1000121002, 
        
        /// <summary>
        /// 
        /// </summary>
        DisplayPlaneInfo2 = 1000121003, 
        
        /// <summary>
        /// 
        /// </summary>
        DisplayPlaneCapabilities2 = 1000121004, 
        
        /// <summary>
        /// 
        /// </summary>
        IosSurfaceCreateInfo = 1000122000, 
        
        /// <summary>
        /// 
        /// </summary>
        MacosSurfaceCreateInfo = 1000123000, 
        
        /// <summary>
        /// 
        /// </summary>
        DebugUtilsObjectNameInfo = 1000128000, 
        
        /// <summary>
        /// 
        /// </summary>
        DebugUtilsObjectTagInfo = 1000128001, 
        
        /// <summary>
        /// 
        /// </summary>
        DebugUtilsLabel = 1000128002, 
        
        /// <summary>
        /// 
        /// </summary>
        DebugUtilsMessengerCallbackData = 1000128003, 
        
        /// <summary>
        /// 
        /// </summary>
        DebugUtilsMessengerCreateInfo = 1000128004, 
        
        /// <summary>
        /// 
        /// </summary>
        AndroidHardwareBufferUsage = 1000129000, 
        
        /// <summary>
        /// 
        /// </summary>
        AndroidHardwareBufferProperties = 1000129001, 
        
        /// <summary>
        /// 
        /// </summary>
        AndroidHardwareBufferFormatProperties = 1000129002, 
        
        /// <summary>
        /// 
        /// </summary>
        ImportAndroidHardwareBufferInfo = 1000129003, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryGetAndroidHardwareBufferInfo = 1000129004, 
        
        /// <summary>
        /// 
        /// </summary>
        ExternalFormat = 1000129005, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceSamplerFilterMinmaxProperties = 1000130000, 
        
        /// <summary>
        /// 
        /// </summary>
        SamplerReductionModeCreateInfo = 1000130001, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceInlineUniformBlockFeatures = 1000138000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceInlineUniformBlockProperties = 1000138001, 
        
        /// <summary>
        /// 
        /// </summary>
        WriteDescriptorSetInlineUniformBlock = 1000138002, 
        
        /// <summary>
        /// 
        /// </summary>
        DescriptorPoolInlineUniformBlockCreateInfo = 1000138003, 
        
        /// <summary>
        /// 
        /// </summary>
        SampleLocationsInfo = 1000143000, 
        
        /// <summary>
        /// 
        /// </summary>
        RenderPassSampleLocationsBeginInfo = 1000143001, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineSampleLocationsStateCreateInfo = 1000143002, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceSampleLocationsProperties = 1000143003, 
        
        /// <summary>
        /// 
        /// </summary>
        MultisampleProperties = 1000143004, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageFormatListCreateInfo = 1000147000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceBlendOperationAdvancedFeatures = 1000148000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceBlendOperationAdvancedProperties = 1000148001, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineColorBlendAdvancedStateCreateInfo = 1000148002, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineCoverageToColorStateCreateInfo = 1000149000, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineCoverageModulationStateCreateInfo = 1000152000, 
        
        /// <summary>
        /// 
        /// </summary>
        DrmFormatModifierPropertiesList = 1000158000, 
        
        /// <summary>
        /// 
        /// </summary>
        DrmFormatModifierProperties = 1000158001, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceImageDrmFormatModifierInfo = 1000158002, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageDrmFormatModifierListCreateInfo = 1000158003, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageDrmFormatModifierExplicitCreateInfo = 1000158004, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageDrmFormatModifierProperties = 1000158005, 
        
        /// <summary>
        /// 
        /// </summary>
        ValidationCacheCreateInfo = 1000160000, 
        
        /// <summary>
        /// 
        /// </summary>
        ShaderModuleValidationCacheCreateInfo = 1000160001, 
        
        /// <summary>
        /// 
        /// </summary>
        DescriptorSetLayoutBindingFlagsCreateInfo = 1000161000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceDescriptorIndexingFeatures = 1000161001, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceDescriptorIndexingProperties = 1000161002, 
        
        /// <summary>
        /// 
        /// </summary>
        DescriptorSetVariableDescriptorCountAllocateInfo = 1000161003, 
        
        /// <summary>
        /// 
        /// </summary>
        DescriptorSetVariableDescriptorCountLayoutSupport = 1000161004, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineViewportShadingRateImageStateCreateInfo = 1000164000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceShadingRateImageFeatures = 1000164001, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceShadingRateImageProperties = 1000164002, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineViewportCoarseSampleOrderStateCreateInfo = 1000164005, 
        
        /// <summary>
        /// 
        /// </summary>
        RayTracingPipelineCreateInfo = 1000165000, 
        
        /// <summary>
        /// 
        /// </summary>
        AccelerationStructureCreateInfo = 1000165001, 
        
        /// <summary>
        /// 
        /// </summary>
        Geometry = 1000165003, 
        
        /// <summary>
        /// 
        /// </summary>
        GeometryTriangles = 1000165004, 
        
        /// <summary>
        /// 
        /// </summary>
        GeometryAabb = 1000165005, 
        
        /// <summary>
        /// 
        /// </summary>
        BindAccelerationStructureMemoryInfo = 1000165006, 
        
        /// <summary>
        /// 
        /// </summary>
        WriteDescriptorSetAccelerationStructure = 1000165007, 
        
        /// <summary>
        /// 
        /// </summary>
        AccelerationStructureMemoryRequirementsInfo = 1000165008, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceRayTracingProperties = 1000165009, 
        
        /// <summary>
        /// 
        /// </summary>
        RayTracingShaderGroupCreateInfo = 1000165011, 
        
        /// <summary>
        /// 
        /// </summary>
        AccelerationStructureInfo = 1000165012, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceRepresentativeFragmentTestFeatures = 1000166000, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineRepresentativeFragmentTestStateCreateInfo = 1000166001, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceQueueGlobalPriorityCreateInfo = 1000174000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDevice8bitStorageFeatures = 1000177000, 
        
        /// <summary>
        /// 
        /// </summary>
        ImportMemoryHostPointerInfo = 1000178000, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryHostPointerProperties = 1000178001, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceExternalMemoryHostProperties = 1000178002, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceShaderAtomicInt64Features = 1000180000, 
        
        /// <summary>
        /// 
        /// </summary>
        CalibratedTimestampInfo = 1000184000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceShaderCoreProperties = 1000185000, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceMemoryOverallocationCreateInfo = 1000189000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceVertexAttributeDivisorProperties = 1000190000, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineVertexInputDivisorStateCreateInfo = 1000190001, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceVertexAttributeDivisorFeatures = 1000190002, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceDriverProperties = 1000196000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceFloatControlsProperties = 1000197000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceComputeShaderDerivativesFeatures = 1000201000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceMeshShaderFeatures = 1000202000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceMeshShaderProperties = 1000202001, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceFragmentShaderBarycentricFeatures = 1000203000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceShaderImageFootprintFeatures = 1000204000, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineViewportExclusiveScissorStateCreateInfo = 1000205000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceExclusiveScissorFeatures = 1000205002, 
        
        /// <summary>
        /// 
        /// </summary>
        CheckpointData = 1000206000, 
        
        /// <summary>
        /// 
        /// </summary>
        QueueFamilyCheckpointProperties = 1000206001, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceVulkanMemoryModelFeatures = 1000211000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDevicePciBusInfoProperties = 1000212000, 
        
        /// <summary>
        /// 
        /// </summary>
        ImagepipeSurfaceCreateInfo = 1000214000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceFragmentDensityMapFeatures = 1000218000, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceFragmentDensityMapProperties = 1000218001, 
        
        /// <summary>
        /// 
        /// </summary>
        RenderPassFragmentDensityMapCreateInfo = 1000218002, 
        
        /// <summary>
        /// 
        /// </summary>
        PhysicalDeviceScalarBlockLayoutFeatures = 1000221000, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageStencilUsageCreateInfo = 1000246000, 
    }
}
