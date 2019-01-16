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

using System;

namespace SharpVk
{
    /// <summary>
    /// Opaque handle to a device object.
    /// </summary>
    public partial class Device
        : IProcLookup, IDisposable
    {
        internal readonly SharpVk.Interop.Device handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly SharpVk.PhysicalDevice parent; 
        
        internal Device(SharpVk.PhysicalDevice parent, SharpVk.Interop.Device handle)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = new CommandCache(this, "device", parent.commandCache);
            this.commandCache.Initialise();
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.Device RawHandle => this.handle;
        
        /// <summary>
        /// Return a function pointer for a command.
        /// </summary>
        public unsafe IntPtr GetProcedureAddress(string name)
        {
            try
            {
                IntPtr result = default(IntPtr);
                SharpVk.Interop.VkDeviceGetProcedureAddressDelegate commandDelegate = commandCache.Cache.vkGetDeviceProcAddr;
                result = commandDelegate(this.handle, Interop.HeapUtil.MarshalTo(name));
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Destroy a logical device.
        /// </summary>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe void Destroy(SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.VkDeviceDestroyDelegate commandDelegate = commandCache.Cache.vkDestroyDevice;
                commandDelegate(this.handle, marshalledAllocator);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Get a queue handle from a device.
        /// </summary>
        public unsafe SharpVk.Queue GetQueue(uint queueFamilyIndex, uint queueIndex)
        {
            try
            {
                SharpVk.Queue result = default(SharpVk.Queue);
                SharpVk.Interop.Queue marshalledQueue = default(SharpVk.Interop.Queue);
                SharpVk.Interop.VkDeviceGetQueueDelegate commandDelegate = commandCache.Cache.vkGetDeviceQueue;
                commandDelegate(this.handle, queueFamilyIndex, queueIndex, &marshalledQueue);
                result = new SharpVk.Queue(this, marshalledQueue);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Wait for a device to become idle.
        /// </summary>
        public unsafe void WaitIdle()
        {
            try
            {
                SharpVk.Interop.VkDeviceWaitIdleDelegate commandDelegate = commandCache.Cache.vkDeviceWaitIdle;
                Result methodResult = commandDelegate(this.handle);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Allocate GPU memory.
        /// </summary>
        /// <param name="allocationSize">
        /// The size of the allocation in bytes
        /// </param>
        /// <param name="memoryTypeIndex">
        /// The memory type index, which selects the properties of the memory
        /// to be allocated, as well as the heap the memory will come from.
        /// </param>
        /// <param name="dedicatedAllocationMemoryAllocateInfoNv">
        /// Extension struct
        /// </param>
        /// <param name="exportMemoryAllocateInfoNv">
        /// Extension struct
        /// </param>
        /// <param name="importMemoryWin32HandleInfoNv">
        /// Extension struct
        /// </param>
        /// <param name="exportMemoryWin32HandleInfoNv">
        /// Extension struct
        /// </param>
        /// <param name="exportMemoryAllocateInfo">
        /// Extension struct
        /// </param>
        /// <param name="importMemoryWin32HandleInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="exportMemoryWin32HandleInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="importMemoryFileDescriptorInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="memoryAllocateFlagsInfo">
        /// Extension struct
        /// </param>
        /// <param name="memoryDedicatedAllocateInfo">
        /// Extension struct
        /// </param>
        /// <param name="importMemoryHostPointerInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="importAndroidHardwareBufferInfoAndroid">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe SharpVk.DeviceMemory AllocateMemory(DeviceSize allocationSize, uint memoryTypeIndex, SharpVk.NVidia.DedicatedAllocationMemoryAllocateInfo? dedicatedAllocationMemoryAllocateInfoNv = null, SharpVk.NVidia.ExportMemoryAllocateInfo? exportMemoryAllocateInfoNv = null, SharpVk.NVidia.ImportMemoryWin32HandleInfo? importMemoryWin32HandleInfoNv = null, SharpVk.NVidia.ExportMemoryWin32HandleInfo? exportMemoryWin32HandleInfoNv = null, SharpVk.ExportMemoryAllocateInfo? exportMemoryAllocateInfo = null, SharpVk.Khronos.ImportMemoryWin32HandleInfo? importMemoryWin32HandleInfoKhr = null, SharpVk.Khronos.ExportMemoryWin32HandleInfo? exportMemoryWin32HandleInfoKhr = null, SharpVk.Khronos.ImportMemoryFileDescriptorInfo? importMemoryFileDescriptorInfoKhr = null, SharpVk.MemoryAllocateFlagsInfo? memoryAllocateFlagsInfo = null, SharpVk.MemoryDedicatedAllocateInfo? memoryDedicatedAllocateInfo = null, SharpVk.Multivendor.ImportMemoryHostPointerInfo? importMemoryHostPointerInfoExt = null, SharpVk.Android.ImportAndroidHardwareBufferInfo? importAndroidHardwareBufferInfoAndroid = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.DeviceMemory result = default(SharpVk.DeviceMemory);
                SharpVk.Interop.MemoryAllocateInfo* marshalledAllocateInfo = default(SharpVk.Interop.MemoryAllocateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.DeviceMemory marshalledMemory = default(SharpVk.Interop.DeviceMemory);
                if (dedicatedAllocationMemoryAllocateInfoNv != null)
                {
                    SharpVk.Interop.NVidia.DedicatedAllocationMemoryAllocateInfo* extensionPointer = default(SharpVk.Interop.NVidia.DedicatedAllocationMemoryAllocateInfo*);
                    extensionPointer = (SharpVk.Interop.NVidia.DedicatedAllocationMemoryAllocateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.DedicatedAllocationMemoryAllocateInfo>());
                    dedicatedAllocationMemoryAllocateInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (exportMemoryAllocateInfoNv != null)
                {
                    SharpVk.Interop.NVidia.ExportMemoryAllocateInfo* extensionPointer = default(SharpVk.Interop.NVidia.ExportMemoryAllocateInfo*);
                    extensionPointer = (SharpVk.Interop.NVidia.ExportMemoryAllocateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.ExportMemoryAllocateInfo>());
                    exportMemoryAllocateInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (importMemoryWin32HandleInfoNv != null)
                {
                    SharpVk.Interop.NVidia.ImportMemoryWin32HandleInfo* extensionPointer = default(SharpVk.Interop.NVidia.ImportMemoryWin32HandleInfo*);
                    extensionPointer = (SharpVk.Interop.NVidia.ImportMemoryWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.ImportMemoryWin32HandleInfo>());
                    importMemoryWin32HandleInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (exportMemoryWin32HandleInfoNv != null)
                {
                    SharpVk.Interop.NVidia.ExportMemoryWin32HandleInfo* extensionPointer = default(SharpVk.Interop.NVidia.ExportMemoryWin32HandleInfo*);
                    extensionPointer = (SharpVk.Interop.NVidia.ExportMemoryWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.ExportMemoryWin32HandleInfo>());
                    exportMemoryWin32HandleInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (exportMemoryAllocateInfo != null)
                {
                    SharpVk.Interop.ExportMemoryAllocateInfo* extensionPointer = default(SharpVk.Interop.ExportMemoryAllocateInfo*);
                    extensionPointer = (SharpVk.Interop.ExportMemoryAllocateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ExportMemoryAllocateInfo>());
                    exportMemoryAllocateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (importMemoryWin32HandleInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.ImportMemoryWin32HandleInfo* extensionPointer = default(SharpVk.Interop.Khronos.ImportMemoryWin32HandleInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.ImportMemoryWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImportMemoryWin32HandleInfo>());
                    importMemoryWin32HandleInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (exportMemoryWin32HandleInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.ExportMemoryWin32HandleInfo* extensionPointer = default(SharpVk.Interop.Khronos.ExportMemoryWin32HandleInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.ExportMemoryWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ExportMemoryWin32HandleInfo>());
                    exportMemoryWin32HandleInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (importMemoryFileDescriptorInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.ImportMemoryFileDescriptorInfo* extensionPointer = default(SharpVk.Interop.Khronos.ImportMemoryFileDescriptorInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.ImportMemoryFileDescriptorInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImportMemoryFileDescriptorInfo>());
                    importMemoryFileDescriptorInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (memoryAllocateFlagsInfo != null)
                {
                    SharpVk.Interop.MemoryAllocateFlagsInfo* extensionPointer = default(SharpVk.Interop.MemoryAllocateFlagsInfo*);
                    extensionPointer = (SharpVk.Interop.MemoryAllocateFlagsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.MemoryAllocateFlagsInfo>());
                    memoryAllocateFlagsInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (memoryDedicatedAllocateInfo != null)
                {
                    SharpVk.Interop.MemoryDedicatedAllocateInfo* extensionPointer = default(SharpVk.Interop.MemoryDedicatedAllocateInfo*);
                    extensionPointer = (SharpVk.Interop.MemoryDedicatedAllocateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.MemoryDedicatedAllocateInfo>());
                    memoryDedicatedAllocateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (importMemoryHostPointerInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.ImportMemoryHostPointerInfo* extensionPointer = default(SharpVk.Interop.Multivendor.ImportMemoryHostPointerInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.ImportMemoryHostPointerInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ImportMemoryHostPointerInfo>());
                    importMemoryHostPointerInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (importAndroidHardwareBufferInfoAndroid != null)
                {
                    SharpVk.Interop.Android.ImportAndroidHardwareBufferInfo* extensionPointer = default(SharpVk.Interop.Android.ImportAndroidHardwareBufferInfo*);
                    extensionPointer = (SharpVk.Interop.Android.ImportAndroidHardwareBufferInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Android.ImportAndroidHardwareBufferInfo>());
                    importAndroidHardwareBufferInfoAndroid.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                marshalledAllocateInfo = (SharpVk.Interop.MemoryAllocateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.MemoryAllocateInfo>());
                marshalledAllocateInfo->SType = StructureType.MemoryAllocateInfo;
                marshalledAllocateInfo->Next = nextPointer;
                marshalledAllocateInfo->AllocationSize = allocationSize;
                marshalledAllocateInfo->MemoryTypeIndex = memoryTypeIndex;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.VkDeviceAllocateMemoryDelegate commandDelegate = commandCache.Cache.vkAllocateMemory;
                Result methodResult = commandDelegate(this.handle, marshalledAllocateInfo, marshalledAllocator, &marshalledMemory);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.DeviceMemory(this, marshalledMemory);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Flush mapped memory ranges.
        /// </summary>
        /// <param name="memoryRanges">
        /// </param>
        public unsafe void FlushMappedMemoryRanges(ArrayProxy<SharpVk.MappedMemoryRange>? memoryRanges)
        {
            try
            {
                SharpVk.Interop.MappedMemoryRange* marshalledMemoryRanges = default(SharpVk.Interop.MappedMemoryRange*);
                if (memoryRanges.IsNull())
                {
                    marshalledMemoryRanges = null;
                }
                else
                {
                    if (memoryRanges.Value.Contents == ProxyContents.Single)
                    {
                        marshalledMemoryRanges = (SharpVk.Interop.MappedMemoryRange*)(Interop.HeapUtil.Allocate<SharpVk.Interop.MappedMemoryRange>());
                        memoryRanges.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.MappedMemoryRange*)(marshalledMemoryRanges));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.MappedMemoryRange*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.MappedMemoryRange>(Interop.HeapUtil.GetLength(memoryRanges.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(memoryRanges.Value)); index++)
                        {
                            memoryRanges.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledMemoryRanges = fieldPointer;
                    }
                }
                SharpVk.Interop.VkDeviceFlushMappedMemoryRangesDelegate commandDelegate = commandCache.Cache.vkFlushMappedMemoryRanges;
                Result methodResult = commandDelegate(this.handle, (uint)(Interop.HeapUtil.GetLength(memoryRanges)), marshalledMemoryRanges);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Invalidate ranges of mapped memory objects.
        /// </summary>
        /// <param name="memoryRanges">
        /// </param>
        public unsafe void InvalidateMappedMemoryRanges(ArrayProxy<SharpVk.MappedMemoryRange>? memoryRanges)
        {
            try
            {
                SharpVk.Interop.MappedMemoryRange* marshalledMemoryRanges = default(SharpVk.Interop.MappedMemoryRange*);
                if (memoryRanges.IsNull())
                {
                    marshalledMemoryRanges = null;
                }
                else
                {
                    if (memoryRanges.Value.Contents == ProxyContents.Single)
                    {
                        marshalledMemoryRanges = (SharpVk.Interop.MappedMemoryRange*)(Interop.HeapUtil.Allocate<SharpVk.Interop.MappedMemoryRange>());
                        memoryRanges.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.MappedMemoryRange*)(marshalledMemoryRanges));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.MappedMemoryRange*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.MappedMemoryRange>(Interop.HeapUtil.GetLength(memoryRanges.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(memoryRanges.Value)); index++)
                        {
                            memoryRanges.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledMemoryRanges = fieldPointer;
                    }
                }
                SharpVk.Interop.VkDeviceInvalidateMappedMemoryRangesDelegate commandDelegate = commandCache.Cache.vkInvalidateMappedMemoryRanges;
                Result methodResult = commandDelegate(this.handle, (uint)(Interop.HeapUtil.GetLength(memoryRanges)), marshalledMemoryRanges);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a new fence object.
        /// </summary>
        /// <param name="flags">
        /// flags defines the initial state and behavior of the fence. Bits
        /// which can be set include: + --
        /// </param>
        /// <param name="exportFenceCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="exportFenceWin32HandleInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe SharpVk.Fence CreateFence(SharpVk.FenceCreateFlags? flags = default(SharpVk.FenceCreateFlags?), SharpVk.ExportFenceCreateInfo? exportFenceCreateInfo = null, SharpVk.Khronos.ExportFenceWin32HandleInfo? exportFenceWin32HandleInfoKhr = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Fence result = default(SharpVk.Fence);
                SharpVk.Interop.FenceCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.FenceCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Fence marshalledFence = default(SharpVk.Interop.Fence);
                if (exportFenceCreateInfo != null)
                {
                    SharpVk.Interop.ExportFenceCreateInfo* extensionPointer = default(SharpVk.Interop.ExportFenceCreateInfo*);
                    extensionPointer = (SharpVk.Interop.ExportFenceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ExportFenceCreateInfo>());
                    exportFenceCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (exportFenceWin32HandleInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.ExportFenceWin32HandleInfo* extensionPointer = default(SharpVk.Interop.Khronos.ExportFenceWin32HandleInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.ExportFenceWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ExportFenceWin32HandleInfo>());
                    exportFenceWin32HandleInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                marshalledCreateInfo = (SharpVk.Interop.FenceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.FenceCreateInfo>());
                marshalledCreateInfo->SType = StructureType.FenceCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.FenceCreateFlags);
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.VkDeviceCreateFenceDelegate commandDelegate = commandCache.Cache.vkCreateFence;
                Result methodResult = commandDelegate(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledFence);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Fence(this, marshalledFence);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Resets one or more fence objects.
        /// </summary>
        /// <param name="fences">
        /// </param>
        public unsafe void ResetFences(ArrayProxy<SharpVk.Fence>? fences)
        {
            try
            {
                SharpVk.Interop.Fence* marshalledFences = default(SharpVk.Interop.Fence*);
                if (fences.IsNull())
                {
                    marshalledFences = null;
                }
                else
                {
                    if (fences.Value.Contents == ProxyContents.Single)
                    {
                        marshalledFences = (SharpVk.Interop.Fence*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Fence>());
                        *(SharpVk.Interop.Fence*)(marshalledFences) = fences.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.Fence);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Fence*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Fence>(Interop.HeapUtil.GetLength(fences.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(fences.Value)); index++)
                        {
                            fieldPointer[index] = fences.Value[index]?.handle ?? default(SharpVk.Interop.Fence);
                        }
                        marshalledFences = fieldPointer;
                    }
                }
                SharpVk.Interop.VkDeviceResetFencesDelegate commandDelegate = commandCache.Cache.vkResetFences;
                Result methodResult = commandDelegate(this.handle, (uint)(Interop.HeapUtil.GetLength(fences)), marshalledFences);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Wait for one or more fences to become signaled.
        /// </summary>
        /// <param name="fences">
        /// </param>
        public unsafe Result WaitForFences(ArrayProxy<SharpVk.Fence>? fences, bool waitAll, ulong timeout)
        {
            try
            {
                Result result = default(Result);
                SharpVk.Interop.Fence* marshalledFences = default(SharpVk.Interop.Fence*);
                if (fences.IsNull())
                {
                    marshalledFences = null;
                }
                else
                {
                    if (fences.Value.Contents == ProxyContents.Single)
                    {
                        marshalledFences = (SharpVk.Interop.Fence*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Fence>());
                        *(SharpVk.Interop.Fence*)(marshalledFences) = fences.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.Fence);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Fence*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Fence>(Interop.HeapUtil.GetLength(fences.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(fences.Value)); index++)
                        {
                            fieldPointer[index] = fences.Value[index]?.handle ?? default(SharpVk.Interop.Fence);
                        }
                        marshalledFences = fieldPointer;
                    }
                }
                SharpVk.Interop.VkDeviceWaitForFencesDelegate commandDelegate = commandCache.Cache.vkWaitForFences;
                result = commandDelegate(this.handle, (uint)(Interop.HeapUtil.GetLength(fences)), marshalledFences, waitAll, timeout);
                if (SharpVkException.IsError(result))
                {
                    throw SharpVkException.Create(result);
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a new queue semaphore object.
        /// </summary>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="exportSemaphoreCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="exportSemaphoreWin32HandleInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe SharpVk.Semaphore CreateSemaphore(SharpVk.SemaphoreCreateFlags? flags = default(SharpVk.SemaphoreCreateFlags?), SharpVk.ExportSemaphoreCreateInfo? exportSemaphoreCreateInfo = null, SharpVk.Khronos.ExportSemaphoreWin32HandleInfo? exportSemaphoreWin32HandleInfoKhr = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Semaphore result = default(SharpVk.Semaphore);
                SharpVk.Interop.SemaphoreCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.SemaphoreCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Semaphore marshalledSemaphore = default(SharpVk.Interop.Semaphore);
                if (exportSemaphoreCreateInfo != null)
                {
                    SharpVk.Interop.ExportSemaphoreCreateInfo* extensionPointer = default(SharpVk.Interop.ExportSemaphoreCreateInfo*);
                    extensionPointer = (SharpVk.Interop.ExportSemaphoreCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ExportSemaphoreCreateInfo>());
                    exportSemaphoreCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (exportSemaphoreWin32HandleInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.ExportSemaphoreWin32HandleInfo* extensionPointer = default(SharpVk.Interop.Khronos.ExportSemaphoreWin32HandleInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.ExportSemaphoreWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ExportSemaphoreWin32HandleInfo>());
                    exportSemaphoreWin32HandleInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                marshalledCreateInfo = (SharpVk.Interop.SemaphoreCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SemaphoreCreateInfo>());
                marshalledCreateInfo->SType = StructureType.SemaphoreCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.SemaphoreCreateFlags);
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.VkDeviceCreateSemaphoreDelegate commandDelegate = commandCache.Cache.vkCreateSemaphore;
                Result methodResult = commandDelegate(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledSemaphore);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Semaphore(this, marshalledSemaphore);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a new event object.
        /// </summary>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe SharpVk.Event CreateEvent(SharpVk.EventCreateFlags? flags = default(SharpVk.EventCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Event result = default(SharpVk.Event);
                SharpVk.Interop.EventCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.EventCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Event marshalledEvent = default(SharpVk.Interop.Event);
                marshalledCreateInfo = (SharpVk.Interop.EventCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.EventCreateInfo>());
                marshalledCreateInfo->SType = StructureType.EventCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.EventCreateFlags);
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.VkDeviceCreateEventDelegate commandDelegate = commandCache.Cache.vkCreateEvent;
                Result methodResult = commandDelegate(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledEvent);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Event(this, marshalledEvent);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a new query pool object.
        /// </summary>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="queryType">
        /// The type of queries managed by the pool.
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe SharpVk.QueryPool CreateQueryPool(SharpVk.QueryType queryType, uint queryCount, SharpVk.QueryPoolCreateFlags? flags = default(SharpVk.QueryPoolCreateFlags?), SharpVk.QueryPipelineStatisticFlags? pipelineStatistics = default(SharpVk.QueryPipelineStatisticFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.QueryPool result = default(SharpVk.QueryPool);
                SharpVk.Interop.QueryPoolCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.QueryPoolCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.QueryPool marshalledQueryPool = default(SharpVk.Interop.QueryPool);
                marshalledCreateInfo = (SharpVk.Interop.QueryPoolCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.QueryPoolCreateInfo>());
                marshalledCreateInfo->SType = StructureType.QueryPoolCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.QueryPoolCreateFlags);
                }
                marshalledCreateInfo->QueryType = queryType;
                marshalledCreateInfo->QueryCount = queryCount;
                if (pipelineStatistics != null)
                {
                    marshalledCreateInfo->PipelineStatistics = pipelineStatistics.Value;
                }
                else
                {
                    marshalledCreateInfo->PipelineStatistics = default(SharpVk.QueryPipelineStatisticFlags);
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.VkDeviceCreateQueryPoolDelegate commandDelegate = commandCache.Cache.vkCreateQueryPool;
                Result methodResult = commandDelegate(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledQueryPool);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.QueryPool(this, marshalledQueryPool);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a new buffer object.
        /// </summary>
        /// <param name="flags">
        /// A bitmask describing additional parameters of the buffer.
        /// </param>
        /// <param name="size">
        /// The size in bytes of the buffer to be created.
        /// </param>
        /// <param name="usage">
        /// A bitmask describing the allowed usages of the buffer.
        /// </param>
        /// <param name="sharingMode">
        /// The sharing mode of the buffer when it will be accessed by multiple
        /// queue families.
        /// </param>
        /// <param name="queueFamilyIndices">
        /// </param>
        /// <param name="dedicatedAllocationBufferCreateInfoNv">
        /// Extension struct
        /// </param>
        /// <param name="externalMemoryBufferCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe SharpVk.Buffer CreateBuffer(DeviceSize size, SharpVk.BufferUsageFlags usage, SharpVk.SharingMode sharingMode, ArrayProxy<uint>? queueFamilyIndices, SharpVk.BufferCreateFlags? flags = default(SharpVk.BufferCreateFlags?), SharpVk.NVidia.DedicatedAllocationBufferCreateInfo? dedicatedAllocationBufferCreateInfoNv = null, SharpVk.ExternalMemoryBufferCreateInfo? externalMemoryBufferCreateInfo = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Buffer result = default(SharpVk.Buffer);
                SharpVk.Interop.BufferCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.BufferCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Buffer marshalledBuffer = default(SharpVk.Interop.Buffer);
                if (dedicatedAllocationBufferCreateInfoNv != null)
                {
                    SharpVk.Interop.NVidia.DedicatedAllocationBufferCreateInfo* extensionPointer = default(SharpVk.Interop.NVidia.DedicatedAllocationBufferCreateInfo*);
                    extensionPointer = (SharpVk.Interop.NVidia.DedicatedAllocationBufferCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.DedicatedAllocationBufferCreateInfo>());
                    dedicatedAllocationBufferCreateInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (externalMemoryBufferCreateInfo != null)
                {
                    SharpVk.Interop.ExternalMemoryBufferCreateInfo* extensionPointer = default(SharpVk.Interop.ExternalMemoryBufferCreateInfo*);
                    extensionPointer = (SharpVk.Interop.ExternalMemoryBufferCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ExternalMemoryBufferCreateInfo>());
                    externalMemoryBufferCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                marshalledCreateInfo = (SharpVk.Interop.BufferCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.BufferCreateInfo>());
                marshalledCreateInfo->SType = StructureType.BufferCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.BufferCreateFlags);
                }
                marshalledCreateInfo->Size = size;
                marshalledCreateInfo->Usage = usage;
                marshalledCreateInfo->SharingMode = sharingMode;
                marshalledCreateInfo->QueueFamilyIndexCount = (uint)(Interop.HeapUtil.GetLength(queueFamilyIndices));
                if (queueFamilyIndices.IsNull())
                {
                    marshalledCreateInfo->QueueFamilyIndices = null;
                }
                else
                {
                    if (queueFamilyIndices.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->QueueFamilyIndices = (uint*)(Interop.HeapUtil.Allocate<uint>());
                        *(uint*)(marshalledCreateInfo->QueueFamilyIndices) = queueFamilyIndices.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(Interop.HeapUtil.GetLength(queueFamilyIndices.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(queueFamilyIndices.Value)); index++)
                        {
                            fieldPointer[index] = queueFamilyIndices.Value[index];
                        }
                        marshalledCreateInfo->QueueFamilyIndices = fieldPointer;
                    }
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.VkDeviceCreateBufferDelegate commandDelegate = commandCache.Cache.vkCreateBuffer;
                Result methodResult = commandDelegate(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledBuffer);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Buffer(this, marshalledBuffer);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a new buffer view object.
        /// </summary>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="buffer">
        /// A Buffer on which the view will be created.
        /// </param>
        /// <param name="format">
        /// A Format describing the format of the data elements in the buffer.
        /// </param>
        /// <param name="offset">
        /// An offset in bytes from the base address of the buffer. Accesses to
        /// the buffer view from shaders use addressing that is relative to
        /// this starting offset.
        /// </param>
        /// <param name="range">
        /// A size in bytes of the buffer view. If range is equal to
        /// Constants.WholeSize, the range from offset to the end of the buffer
        /// is used. If Constants.WholeSize is used and the remaining size of
        /// the buffer is not a multiple of the element size of format, then
        /// the nearest smaller multiple is used.
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe SharpVk.BufferView CreateBufferView(SharpVk.Buffer buffer, SharpVk.Format format, DeviceSize offset, DeviceSize range, SharpVk.BufferViewCreateFlags? flags = default(SharpVk.BufferViewCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.BufferView result = default(SharpVk.BufferView);
                SharpVk.Interop.BufferViewCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.BufferViewCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.BufferView marshalledView = default(SharpVk.Interop.BufferView);
                marshalledCreateInfo = (SharpVk.Interop.BufferViewCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.BufferViewCreateInfo>());
                marshalledCreateInfo->SType = StructureType.BufferViewCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.BufferViewCreateFlags);
                }
                marshalledCreateInfo->Buffer = buffer?.handle ?? default(SharpVk.Interop.Buffer);
                marshalledCreateInfo->Format = format;
                marshalledCreateInfo->Offset = offset;
                marshalledCreateInfo->Range = range;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.VkDeviceCreateBufferViewDelegate commandDelegate = commandCache.Cache.vkCreateBufferView;
                Result methodResult = commandDelegate(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledView);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.BufferView(this, marshalledView);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a new image object.
        /// </summary>
        /// <param name="flags">
        /// A bitmask describing additional parameters of the image. See
        /// ImageCreateFlagBits below for a description of the supported bits.
        /// </param>
        /// <param name="imageType">
        /// An ImageType specifying the basic dimensionality of the image, as
        /// described below. Layers in array textures do not count as a
        /// dimension for the purposes of the image type.
        /// </param>
        /// <param name="format">
        /// A Format describing the format and type of the data elements that
        /// will be contained in the image.
        /// </param>
        /// <param name="extent">
        /// A Extent3D describing the number of data elements in each dimension
        /// of the base level.
        /// </param>
        /// <param name="mipLevels">
        /// mipLevels describes the number of levels of detail available for
        /// minified sampling of the image.
        /// </param>
        /// <param name="arrayLayers">
        /// The number of layers in the image.
        /// </param>
        /// <param name="samples">
        /// The number of sub-data element samples in the image as defined in
        /// SampleCountFlagBits. See Multisampling.
        /// </param>
        /// <param name="tiling">
        /// An ImageTiling specifying the tiling arrangement of the data
        /// elements in memory, as described below.
        /// </param>
        /// <param name="usage">
        /// A bitmask describing the intended usage of the image. See
        /// ImageUsageFlagBits below for a description of the supported bits.
        /// </param>
        /// <param name="sharingMode">
        /// The sharing mode of the image when it will be accessed by multiple
        /// queue families, and must be one of the values described for
        /// SharingMode in the Resource Sharing section below.
        /// </param>
        /// <param name="queueFamilyIndices">
        /// </param>
        /// <param name="initialLayout">
        /// initialLayout selects the initial ImageLayout state of all image
        /// subresources of the image. See Image Layouts. initialLayout must be
        /// VK_IMAGE_LAYOUT_UNDEFINED or VK_IMAGE_LAYOUT_PREINITIALIZED.
        /// </param>
        /// <param name="dedicatedAllocationImageCreateInfoNv">
        /// Extension struct
        /// </param>
        /// <param name="externalMemoryImageCreateInfoNv">
        /// Extension struct
        /// </param>
        /// <param name="externalMemoryImageCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="imageSwapchainCreateInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="imageFormatListCreateInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="externalFormatAndroid">
        /// Extension struct
        /// </param>
        /// <param name="imageDrmFormatModifierListCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="imageDrmFormatModifierExplicitCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="imageStencilUsageCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe SharpVk.Image CreateImage(SharpVk.ImageType imageType, SharpVk.Format format, SharpVk.Extent3D extent, uint mipLevels, uint arrayLayers, SharpVk.SampleCountFlags samples, SharpVk.ImageTiling tiling, SharpVk.ImageUsageFlags usage, SharpVk.SharingMode sharingMode, ArrayProxy<uint>? queueFamilyIndices, SharpVk.ImageLayout initialLayout, SharpVk.ImageCreateFlags? flags = default(SharpVk.ImageCreateFlags?), SharpVk.NVidia.DedicatedAllocationImageCreateInfo? dedicatedAllocationImageCreateInfoNv = null, SharpVk.NVidia.ExternalMemoryImageCreateInfo? externalMemoryImageCreateInfoNv = null, SharpVk.ExternalMemoryImageCreateInfo? externalMemoryImageCreateInfo = null, SharpVk.Khronos.ImageSwapchainCreateInfo? imageSwapchainCreateInfoKhr = null, SharpVk.Khronos.ImageFormatListCreateInfo? imageFormatListCreateInfoKhr = null, SharpVk.Android.ExternalFormat? externalFormatAndroid = null, SharpVk.Multivendor.ImageDrmFormatModifierListCreateInfo? imageDrmFormatModifierListCreateInfoExt = null, SharpVk.Multivendor.ImageDrmFormatModifierExplicitCreateInfo? imageDrmFormatModifierExplicitCreateInfoExt = null, SharpVk.Multivendor.ImageStencilUsageCreateInfo? imageStencilUsageCreateInfoExt = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Image result = default(SharpVk.Image);
                SharpVk.Interop.ImageCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.ImageCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Image marshalledImage = default(SharpVk.Interop.Image);
                if (dedicatedAllocationImageCreateInfoNv != null)
                {
                    SharpVk.Interop.NVidia.DedicatedAllocationImageCreateInfo* extensionPointer = default(SharpVk.Interop.NVidia.DedicatedAllocationImageCreateInfo*);
                    extensionPointer = (SharpVk.Interop.NVidia.DedicatedAllocationImageCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.DedicatedAllocationImageCreateInfo>());
                    dedicatedAllocationImageCreateInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (externalMemoryImageCreateInfoNv != null)
                {
                    SharpVk.Interop.NVidia.ExternalMemoryImageCreateInfo* extensionPointer = default(SharpVk.Interop.NVidia.ExternalMemoryImageCreateInfo*);
                    extensionPointer = (SharpVk.Interop.NVidia.ExternalMemoryImageCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.ExternalMemoryImageCreateInfo>());
                    externalMemoryImageCreateInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (externalMemoryImageCreateInfo != null)
                {
                    SharpVk.Interop.ExternalMemoryImageCreateInfo* extensionPointer = default(SharpVk.Interop.ExternalMemoryImageCreateInfo*);
                    extensionPointer = (SharpVk.Interop.ExternalMemoryImageCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ExternalMemoryImageCreateInfo>());
                    externalMemoryImageCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (imageSwapchainCreateInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.ImageSwapchainCreateInfo* extensionPointer = default(SharpVk.Interop.Khronos.ImageSwapchainCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.ImageSwapchainCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImageSwapchainCreateInfo>());
                    imageSwapchainCreateInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (imageFormatListCreateInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.ImageFormatListCreateInfo* extensionPointer = default(SharpVk.Interop.Khronos.ImageFormatListCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.ImageFormatListCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImageFormatListCreateInfo>());
                    imageFormatListCreateInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (externalFormatAndroid != null)
                {
                    SharpVk.Interop.Android.ExternalFormat* extensionPointer = default(SharpVk.Interop.Android.ExternalFormat*);
                    extensionPointer = (SharpVk.Interop.Android.ExternalFormat*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Android.ExternalFormat>());
                    externalFormatAndroid.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (imageDrmFormatModifierListCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.ImageDrmFormatModifierListCreateInfo* extensionPointer = default(SharpVk.Interop.Multivendor.ImageDrmFormatModifierListCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.ImageDrmFormatModifierListCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ImageDrmFormatModifierListCreateInfo>());
                    imageDrmFormatModifierListCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (imageDrmFormatModifierExplicitCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.ImageDrmFormatModifierExplicitCreateInfo* extensionPointer = default(SharpVk.Interop.Multivendor.ImageDrmFormatModifierExplicitCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.ImageDrmFormatModifierExplicitCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ImageDrmFormatModifierExplicitCreateInfo>());
                    imageDrmFormatModifierExplicitCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (imageStencilUsageCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.ImageStencilUsageCreateInfo* extensionPointer = default(SharpVk.Interop.Multivendor.ImageStencilUsageCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.ImageStencilUsageCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ImageStencilUsageCreateInfo>());
                    imageStencilUsageCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                marshalledCreateInfo = (SharpVk.Interop.ImageCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ImageCreateInfo>());
                marshalledCreateInfo->SType = StructureType.ImageCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.ImageCreateFlags);
                }
                marshalledCreateInfo->ImageType = imageType;
                marshalledCreateInfo->Format = format;
                marshalledCreateInfo->Extent = extent;
                marshalledCreateInfo->MipLevels = mipLevels;
                marshalledCreateInfo->ArrayLayers = arrayLayers;
                marshalledCreateInfo->Samples = samples;
                marshalledCreateInfo->Tiling = tiling;
                marshalledCreateInfo->Usage = usage;
                marshalledCreateInfo->SharingMode = sharingMode;
                marshalledCreateInfo->QueueFamilyIndexCount = (uint)(Interop.HeapUtil.GetLength(queueFamilyIndices));
                if (queueFamilyIndices.IsNull())
                {
                    marshalledCreateInfo->QueueFamilyIndices = null;
                }
                else
                {
                    if (queueFamilyIndices.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->QueueFamilyIndices = (uint*)(Interop.HeapUtil.Allocate<uint>());
                        *(uint*)(marshalledCreateInfo->QueueFamilyIndices) = queueFamilyIndices.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(Interop.HeapUtil.GetLength(queueFamilyIndices.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(queueFamilyIndices.Value)); index++)
                        {
                            fieldPointer[index] = queueFamilyIndices.Value[index];
                        }
                        marshalledCreateInfo->QueueFamilyIndices = fieldPointer;
                    }
                }
                marshalledCreateInfo->InitialLayout = initialLayout;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.VkDeviceCreateImageDelegate commandDelegate = commandCache.Cache.vkCreateImage;
                Result methodResult = commandDelegate(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledImage);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Image(this, marshalledImage);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create an image view from an existing image.
        /// </summary>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="image">
        /// An Image on which the view will be created.
        /// </param>
        /// <param name="viewType">
        /// The type of the image view.
        /// </param>
        /// <param name="format">
        /// A Format describing the format and type used to interpret data
        /// elements in the image.
        /// </param>
        /// <param name="components">
        /// Specifies a remapping of color components (or of depth or stencil
        /// components after they have been converted into color components).
        /// </param>
        /// <param name="subresourceRange">
        /// An ImageSubresourceRange selecting the set of mipmap levels and
        /// array layers to be accessible to the view.
        /// </param>
        /// <param name="imageViewUsageCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="samplerYcbcrConversionInfo">
        /// Extension struct
        /// </param>
        /// <param name="imageViewASTCDecodeModeExt">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe SharpVk.ImageView CreateImageView(SharpVk.Image image, SharpVk.ImageViewType viewType, SharpVk.Format format, SharpVk.ComponentMapping components, SharpVk.ImageSubresourceRange subresourceRange, SharpVk.ImageViewCreateFlags? flags = default(SharpVk.ImageViewCreateFlags?), SharpVk.ImageViewUsageCreateInfo? imageViewUsageCreateInfo = null, SharpVk.SamplerYcbcrConversionInfo? samplerYcbcrConversionInfo = null, SharpVk.Multivendor.ImageViewASTCDecodeMode? imageViewASTCDecodeModeExt = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.ImageView result = default(SharpVk.ImageView);
                SharpVk.Interop.ImageViewCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.ImageViewCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.ImageView marshalledView = default(SharpVk.Interop.ImageView);
                if (imageViewUsageCreateInfo != null)
                {
                    SharpVk.Interop.ImageViewUsageCreateInfo* extensionPointer = default(SharpVk.Interop.ImageViewUsageCreateInfo*);
                    extensionPointer = (SharpVk.Interop.ImageViewUsageCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ImageViewUsageCreateInfo>());
                    imageViewUsageCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (samplerYcbcrConversionInfo != null)
                {
                    SharpVk.Interop.SamplerYcbcrConversionInfo* extensionPointer = default(SharpVk.Interop.SamplerYcbcrConversionInfo*);
                    extensionPointer = (SharpVk.Interop.SamplerYcbcrConversionInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SamplerYcbcrConversionInfo>());
                    samplerYcbcrConversionInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (imageViewASTCDecodeModeExt != null)
                {
                    SharpVk.Interop.Multivendor.ImageViewASTCDecodeMode* extensionPointer = default(SharpVk.Interop.Multivendor.ImageViewASTCDecodeMode*);
                    extensionPointer = (SharpVk.Interop.Multivendor.ImageViewASTCDecodeMode*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ImageViewASTCDecodeMode>());
                    imageViewASTCDecodeModeExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                marshalledCreateInfo = (SharpVk.Interop.ImageViewCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ImageViewCreateInfo>());
                marshalledCreateInfo->SType = StructureType.ImageViewCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.ImageViewCreateFlags);
                }
                marshalledCreateInfo->Image = image?.handle ?? default(SharpVk.Interop.Image);
                marshalledCreateInfo->ViewType = viewType;
                marshalledCreateInfo->Format = format;
                marshalledCreateInfo->Components = components;
                marshalledCreateInfo->SubresourceRange = subresourceRange;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.VkDeviceCreateImageViewDelegate commandDelegate = commandCache.Cache.vkCreateImageView;
                Result methodResult = commandDelegate(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledView);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.ImageView(this, marshalledView);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Creates a new shader module object.
        /// </summary>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="codeSize">
        /// The size, in bytes, of the code.
        /// </param>
        /// <param name="code">
        /// </param>
        /// <param name="shaderModuleValidationCacheCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe SharpVk.ShaderModule CreateShaderModule(HostSize codeSize, ArrayProxy<uint>? code, SharpVk.ShaderModuleCreateFlags? flags = default(SharpVk.ShaderModuleCreateFlags?), SharpVk.Multivendor.ShaderModuleValidationCacheCreateInfo? shaderModuleValidationCacheCreateInfoExt = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.ShaderModule result = default(SharpVk.ShaderModule);
                SharpVk.Interop.ShaderModuleCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.ShaderModuleCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.ShaderModule marshalledShaderModule = default(SharpVk.Interop.ShaderModule);
                if (shaderModuleValidationCacheCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.ShaderModuleValidationCacheCreateInfo* extensionPointer = default(SharpVk.Interop.Multivendor.ShaderModuleValidationCacheCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.ShaderModuleValidationCacheCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ShaderModuleValidationCacheCreateInfo>());
                    shaderModuleValidationCacheCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                marshalledCreateInfo = (SharpVk.Interop.ShaderModuleCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ShaderModuleCreateInfo>());
                marshalledCreateInfo->SType = StructureType.ShaderModuleCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.ShaderModuleCreateFlags);
                }
                marshalledCreateInfo->CodeSize = codeSize;
                if (code.IsNull())
                {
                    marshalledCreateInfo->Code = null;
                }
                else
                {
                    if (code.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->Code = (uint*)(Interop.HeapUtil.Allocate<uint>());
                        *(uint*)(marshalledCreateInfo->Code) = code.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(Interop.HeapUtil.GetLength(code.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(code.Value)); index++)
                        {
                            fieldPointer[index] = code.Value[index];
                        }
                        marshalledCreateInfo->Code = fieldPointer;
                    }
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.VkDeviceCreateShaderModuleDelegate commandDelegate = commandCache.Cache.vkCreateShaderModule;
                Result methodResult = commandDelegate(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledShaderModule);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.ShaderModule(this, marshalledShaderModule);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Creates a new pipeline cache.
        /// </summary>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="initialData">
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe SharpVk.PipelineCache CreatePipelineCache(ArrayProxy<byte>? initialData, SharpVk.PipelineCacheCreateFlags? flags = default(SharpVk.PipelineCacheCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.PipelineCache result = default(SharpVk.PipelineCache);
                SharpVk.Interop.PipelineCacheCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.PipelineCacheCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.PipelineCache marshalledPipelineCache = default(SharpVk.Interop.PipelineCache);
                marshalledCreateInfo = (SharpVk.Interop.PipelineCacheCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineCacheCreateInfo>());
                marshalledCreateInfo->SType = StructureType.PipelineCacheCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.PipelineCacheCreateFlags);
                }
                marshalledCreateInfo->InitialDataSize = (HostSize)(Interop.HeapUtil.GetLength(initialData));
                if (initialData.IsNull())
                {
                    marshalledCreateInfo->InitialData = null;
                }
                else
                {
                    if (initialData.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->InitialData = (byte*)(Interop.HeapUtil.Allocate<byte>());
                        *(byte*)(marshalledCreateInfo->InitialData) = initialData.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (byte*)(Interop.HeapUtil.AllocateAndClear<byte>(Interop.HeapUtil.GetLength(initialData.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(initialData.Value)); index++)
                        {
                            fieldPointer[index] = initialData.Value[index];
                        }
                        marshalledCreateInfo->InitialData = fieldPointer;
                    }
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.VkDeviceCreatePipelineCacheDelegate commandDelegate = commandCache.Cache.vkCreatePipelineCache;
                Result methodResult = commandDelegate(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledPipelineCache);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.PipelineCache(this, marshalledPipelineCache);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create graphics pipelines.
        /// </summary>
        /// <param name="createInfos">
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe SharpVk.Pipeline[] CreateGraphicsPipelines(SharpVk.PipelineCache pipelineCache, ArrayProxy<SharpVk.GraphicsPipelineCreateInfo>? createInfos, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Pipeline[] result = default(SharpVk.Pipeline[]);
                uint createInfoCount = default(uint);
                SharpVk.Interop.GraphicsPipelineCreateInfo* marshalledCreateInfos = default(SharpVk.Interop.GraphicsPipelineCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Pipeline* marshalledPipelines = default(SharpVk.Interop.Pipeline*);
                createInfoCount = (uint)(Interop.HeapUtil.GetLength(createInfos));
                if (createInfos.IsNull())
                {
                    marshalledCreateInfos = null;
                }
                else
                {
                    if (createInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos = (SharpVk.Interop.GraphicsPipelineCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.GraphicsPipelineCreateInfo>());
                        createInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.GraphicsPipelineCreateInfo*)(marshalledCreateInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.GraphicsPipelineCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.GraphicsPipelineCreateInfo>(Interop.HeapUtil.GetLength(createInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(createInfos.Value)); index++)
                        {
                            createInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfos = fieldPointer;
                    }
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                marshalledPipelines = (SharpVk.Interop.Pipeline*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Pipeline>(createInfoCount));
                SharpVk.Interop.VkDeviceCreateGraphicsPipelinesDelegate commandDelegate = commandCache.Cache.vkCreateGraphicsPipelines;
                Result methodResult = commandDelegate(this.handle, pipelineCache?.handle ?? default(SharpVk.Interop.PipelineCache), createInfoCount, marshalledCreateInfos, marshalledAllocator, marshalledPipelines);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                if (marshalledPipelines != null)
                {
                    var fieldPointer = new SharpVk.Pipeline[(uint)(createInfoCount)];
                    for(int index = 0; index < (uint)(createInfoCount); index++)
                    {
                        fieldPointer[index] = new SharpVk.Pipeline(this, marshalledPipelines[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create graphics pipelines.
        /// </summary>
        /// <param name="flags">
        /// A bitmask of PipelineCreateFlagBits controlling how the pipeline
        /// will be generated, as described below.
        /// </param>
        /// <param name="stages">
        /// </param>
        /// <param name="vertexInputState">
        /// An instance of the PipelineVertexInputStateCreateInfo structure.
        /// </param>
        /// <param name="inputAssemblyState">
        /// An instance of the PipelineInputAssemblyStateCreateInfo structure
        /// which determines input assembly behavior.
        /// </param>
        /// <param name="tessellationState">
        /// An instance of the PipelineTessellationStateCreateInfo structure,
        /// or Null if the pipeline does not include a tessellation control
        /// shader stage and tessellation evaluation shader stage.
        /// </param>
        /// <param name="viewportState">
        /// An instance of the PipelineViewportStateCreateInfo structure, or
        /// Null if the pipeline has rasterization disabled.
        /// </param>
        /// <param name="rasterizationState">
        /// An instance of the PipelineRasterizationStateCreateInfo structure.
        /// </param>
        /// <param name="multisampleState">
        /// An instance of the PipelineMultisampleStateCreateInfo, or Null if
        /// the pipeline has rasterization disabled.
        /// </param>
        /// <param name="depthStencilState">
        /// An instance of the PipelineDepthStencilStateCreateInfo structure,
        /// or Null if the pipeline has rasterization disabled or if the
        /// subpass of the render pass the pipeline is created against does not
        /// use a depth/stencil attachment.
        /// </param>
        /// <param name="colorBlendState">
        /// An instance of the PipelineColorBlendStateCreateInfo structure, or
        /// Null if the pipeline has rasterization disabled or if the subpass
        /// of the render pass the pipeline is created against does not use any
        /// color attachments.
        /// </param>
        /// <param name="dynamicState">
        /// A pointer to PipelineDynamicStateCreateInfo and is used to indicate
        /// which properties of the pipeline state object are dynamic and can
        /// be changed independently of the pipeline state. This can be Null,
        /// which means no state in the pipeline is considered dynamic.
        /// </param>
        /// <param name="layout">
        /// The description of binding locations used by both the pipeline and
        /// descriptor sets used with the pipeline.
        /// </param>
        /// <param name="renderPass">
        /// A handle to a render pass object describing the environment in
        /// which the pipeline will be used; the pipeline must only be used
        /// with an instance of any render pass compatible with the one
        /// provided.
        /// </param>
        /// <param name="subpass">
        /// The index of the subpass in the render pass where this pipeline
        /// will be used.
        /// </param>
        /// <param name="basePipelineHandle">
        /// A pipeline to derive from.
        /// </param>
        /// <param name="basePipelineIndex">
        /// An index into the pCreateInfos parameter to use as a pipeline to
        /// derive from.
        /// </param>
        /// <param name="pipelineDiscardRectangleStateCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="pipelineRepresentativeFragmentTestStateCreateInfoNv">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe SharpVk.Pipeline CreateGraphicsPipeline(SharpVk.PipelineCache pipelineCache, ArrayProxy<SharpVk.PipelineShaderStageCreateInfo>? stages, SharpVk.PipelineRasterizationStateCreateInfo rasterizationState, SharpVk.PipelineLayout layout, SharpVk.RenderPass renderPass, uint subpass, SharpVk.Pipeline basePipelineHandle, int basePipelineIndex, SharpVk.PipelineCreateFlags? flags = default(SharpVk.PipelineCreateFlags?), SharpVk.PipelineVertexInputStateCreateInfo? vertexInputState = default(SharpVk.PipelineVertexInputStateCreateInfo?), SharpVk.PipelineInputAssemblyStateCreateInfo? inputAssemblyState = default(SharpVk.PipelineInputAssemblyStateCreateInfo?), SharpVk.PipelineTessellationStateCreateInfo? tessellationState = default(SharpVk.PipelineTessellationStateCreateInfo?), SharpVk.PipelineViewportStateCreateInfo? viewportState = default(SharpVk.PipelineViewportStateCreateInfo?), SharpVk.PipelineMultisampleStateCreateInfo? multisampleState = default(SharpVk.PipelineMultisampleStateCreateInfo?), SharpVk.PipelineDepthStencilStateCreateInfo? depthStencilState = default(SharpVk.PipelineDepthStencilStateCreateInfo?), SharpVk.PipelineColorBlendStateCreateInfo? colorBlendState = default(SharpVk.PipelineColorBlendStateCreateInfo?), SharpVk.PipelineDynamicStateCreateInfo? dynamicState = default(SharpVk.PipelineDynamicStateCreateInfo?), SharpVk.Multivendor.PipelineDiscardRectangleStateCreateInfo? pipelineDiscardRectangleStateCreateInfoExt = null, SharpVk.NVidia.PipelineRepresentativeFragmentTestStateCreateInfo? pipelineRepresentativeFragmentTestStateCreateInfoNv = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Pipeline result = default(SharpVk.Pipeline);
                uint createInfoCount = default(uint);
                SharpVk.Interop.GraphicsPipelineCreateInfo* marshalledCreateInfos = default(SharpVk.Interop.GraphicsPipelineCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Pipeline* marshalledPipelines = default(SharpVk.Interop.Pipeline*);
                if (pipelineDiscardRectangleStateCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.PipelineDiscardRectangleStateCreateInfo* extensionPointer = default(SharpVk.Interop.Multivendor.PipelineDiscardRectangleStateCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PipelineDiscardRectangleStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PipelineDiscardRectangleStateCreateInfo>());
                    pipelineDiscardRectangleStateCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (pipelineRepresentativeFragmentTestStateCreateInfoNv != null)
                {
                    SharpVk.Interop.NVidia.PipelineRepresentativeFragmentTestStateCreateInfo* extensionPointer = default(SharpVk.Interop.NVidia.PipelineRepresentativeFragmentTestStateCreateInfo*);
                    extensionPointer = (SharpVk.Interop.NVidia.PipelineRepresentativeFragmentTestStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.PipelineRepresentativeFragmentTestStateCreateInfo>());
                    pipelineRepresentativeFragmentTestStateCreateInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                createInfoCount = 1;
                marshalledCreateInfos = (SharpVk.Interop.GraphicsPipelineCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.GraphicsPipelineCreateInfo>());
                marshalledCreateInfos->SType = StructureType.GraphicsPipelineCreateInfo;
                marshalledCreateInfos->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfos->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfos->Flags = default(SharpVk.PipelineCreateFlags);
                }
                marshalledCreateInfos->StageCount = (uint)(Interop.HeapUtil.GetLength(stages));
                if (stages.IsNull())
                {
                    marshalledCreateInfos->Stages = null;
                }
                else
                {
                    if (stages.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos->Stages = (SharpVk.Interop.PipelineShaderStageCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineShaderStageCreateInfo>());
                        stages.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.PipelineShaderStageCreateInfo*)(marshalledCreateInfos->Stages));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.PipelineShaderStageCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.PipelineShaderStageCreateInfo>(Interop.HeapUtil.GetLength(stages.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(stages.Value)); index++)
                        {
                            stages.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfos->Stages = fieldPointer;
                    }
                }
                if (vertexInputState != null)
                {
                    marshalledCreateInfos->VertexInputState = (SharpVk.Interop.PipelineVertexInputStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineVertexInputStateCreateInfo>());
                    vertexInputState.Value.MarshalTo(marshalledCreateInfos->VertexInputState);
                }
                else
                {
                    marshalledCreateInfos->VertexInputState = default(SharpVk.Interop.PipelineVertexInputStateCreateInfo*);
                }
                if (inputAssemblyState != null)
                {
                    marshalledCreateInfos->InputAssemblyState = (SharpVk.Interop.PipelineInputAssemblyStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineInputAssemblyStateCreateInfo>());
                    inputAssemblyState.Value.MarshalTo(marshalledCreateInfos->InputAssemblyState);
                }
                else
                {
                    marshalledCreateInfos->InputAssemblyState = default(SharpVk.Interop.PipelineInputAssemblyStateCreateInfo*);
                }
                if (tessellationState != null)
                {
                    marshalledCreateInfos->TessellationState = (SharpVk.Interop.PipelineTessellationStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineTessellationStateCreateInfo>());
                    tessellationState.Value.MarshalTo(marshalledCreateInfos->TessellationState);
                }
                else
                {
                    marshalledCreateInfos->TessellationState = default(SharpVk.Interop.PipelineTessellationStateCreateInfo*);
                }
                if (viewportState != null)
                {
                    marshalledCreateInfos->ViewportState = (SharpVk.Interop.PipelineViewportStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineViewportStateCreateInfo>());
                    viewportState.Value.MarshalTo(marshalledCreateInfos->ViewportState);
                }
                else
                {
                    marshalledCreateInfos->ViewportState = default(SharpVk.Interop.PipelineViewportStateCreateInfo*);
                }
                marshalledCreateInfos->RasterizationState = (SharpVk.Interop.PipelineRasterizationStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineRasterizationStateCreateInfo>());
                rasterizationState.MarshalTo(marshalledCreateInfos->RasterizationState);
                if (multisampleState != null)
                {
                    marshalledCreateInfos->MultisampleState = (SharpVk.Interop.PipelineMultisampleStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineMultisampleStateCreateInfo>());
                    multisampleState.Value.MarshalTo(marshalledCreateInfos->MultisampleState);
                }
                else
                {
                    marshalledCreateInfos->MultisampleState = default(SharpVk.Interop.PipelineMultisampleStateCreateInfo*);
                }
                if (depthStencilState != null)
                {
                    marshalledCreateInfos->DepthStencilState = (SharpVk.Interop.PipelineDepthStencilStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineDepthStencilStateCreateInfo>());
                    depthStencilState.Value.MarshalTo(marshalledCreateInfos->DepthStencilState);
                }
                else
                {
                    marshalledCreateInfos->DepthStencilState = default(SharpVk.Interop.PipelineDepthStencilStateCreateInfo*);
                }
                if (colorBlendState != null)
                {
                    marshalledCreateInfos->ColorBlendState = (SharpVk.Interop.PipelineColorBlendStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineColorBlendStateCreateInfo>());
                    colorBlendState.Value.MarshalTo(marshalledCreateInfos->ColorBlendState);
                }
                else
                {
                    marshalledCreateInfos->ColorBlendState = default(SharpVk.Interop.PipelineColorBlendStateCreateInfo*);
                }
                if (dynamicState != null)
                {
                    marshalledCreateInfos->DynamicState = (SharpVk.Interop.PipelineDynamicStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineDynamicStateCreateInfo>());
                    dynamicState.Value.MarshalTo(marshalledCreateInfos->DynamicState);
                }
                else
                {
                    marshalledCreateInfos->DynamicState = default(SharpVk.Interop.PipelineDynamicStateCreateInfo*);
                }
                marshalledCreateInfos->Layout = layout?.handle ?? default(SharpVk.Interop.PipelineLayout);
                marshalledCreateInfos->RenderPass = renderPass?.handle ?? default(SharpVk.Interop.RenderPass);
                marshalledCreateInfos->Subpass = subpass;
                marshalledCreateInfos->BasePipelineHandle = basePipelineHandle?.handle ?? default(SharpVk.Interop.Pipeline);
                marshalledCreateInfos->BasePipelineIndex = basePipelineIndex;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                marshalledPipelines = (SharpVk.Interop.Pipeline*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Pipeline>(1));
                SharpVk.Interop.VkDeviceCreateGraphicsPipelinesDelegate commandDelegate = commandCache.Cache.vkCreateGraphicsPipelines;
                Result methodResult = commandDelegate(this.handle, pipelineCache?.handle ?? default(SharpVk.Interop.PipelineCache), createInfoCount, marshalledCreateInfos, marshalledAllocator, marshalledPipelines);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Pipeline(this, *marshalledPipelines);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Creates a new compute pipeline object.
        /// </summary>
        /// <param name="createInfos">
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe SharpVk.Pipeline[] CreateComputePipelines(SharpVk.PipelineCache pipelineCache, ArrayProxy<SharpVk.ComputePipelineCreateInfo>? createInfos, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Pipeline[] result = default(SharpVk.Pipeline[]);
                uint createInfoCount = default(uint);
                SharpVk.Interop.ComputePipelineCreateInfo* marshalledCreateInfos = default(SharpVk.Interop.ComputePipelineCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Pipeline* marshalledPipelines = default(SharpVk.Interop.Pipeline*);
                createInfoCount = (uint)(Interop.HeapUtil.GetLength(createInfos));
                if (createInfos.IsNull())
                {
                    marshalledCreateInfos = null;
                }
                else
                {
                    if (createInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos = (SharpVk.Interop.ComputePipelineCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ComputePipelineCreateInfo>());
                        createInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.ComputePipelineCreateInfo*)(marshalledCreateInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.ComputePipelineCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.ComputePipelineCreateInfo>(Interop.HeapUtil.GetLength(createInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(createInfos.Value)); index++)
                        {
                            createInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfos = fieldPointer;
                    }
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                marshalledPipelines = (SharpVk.Interop.Pipeline*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Pipeline>(createInfoCount));
                SharpVk.Interop.VkDeviceCreateComputePipelinesDelegate commandDelegate = commandCache.Cache.vkCreateComputePipelines;
                Result methodResult = commandDelegate(this.handle, pipelineCache?.handle ?? default(SharpVk.Interop.PipelineCache), createInfoCount, marshalledCreateInfos, marshalledAllocator, marshalledPipelines);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                if (marshalledPipelines != null)
                {
                    var fieldPointer = new SharpVk.Pipeline[(uint)(createInfoCount)];
                    for(int index = 0; index < (uint)(createInfoCount); index++)
                    {
                        fieldPointer[index] = new SharpVk.Pipeline(this, marshalledPipelines[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Creates a new compute pipeline object.
        /// </summary>
        /// <param name="flags">
        /// flags provides options for pipeline creation, and is of type
        /// PipelineCreateFlagBits.
        /// </param>
        /// <param name="stage">
        /// A PipelineShaderStageCreateInfo describing the compute shader.
        /// </param>
        /// <param name="layout">
        /// The description of binding locations used by both the pipeline and
        /// descriptor sets used with the pipeline.
        /// </param>
        /// <param name="basePipelineHandle">
        /// A pipeline to derive from
        /// </param>
        /// <param name="basePipelineIndex">
        /// An index into the pCreateInfos parameter to use as a pipeline to
        /// derive from
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe SharpVk.Pipeline CreateComputePipeline(SharpVk.PipelineCache pipelineCache, SharpVk.PipelineShaderStageCreateInfo stage, SharpVk.PipelineLayout layout, SharpVk.Pipeline basePipelineHandle, int basePipelineIndex, SharpVk.PipelineCreateFlags? flags = default(SharpVk.PipelineCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Pipeline result = default(SharpVk.Pipeline);
                uint createInfoCount = default(uint);
                SharpVk.Interop.ComputePipelineCreateInfo* marshalledCreateInfos = default(SharpVk.Interop.ComputePipelineCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Pipeline* marshalledPipelines = default(SharpVk.Interop.Pipeline*);
                createInfoCount = 1;
                marshalledCreateInfos = (SharpVk.Interop.ComputePipelineCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ComputePipelineCreateInfo>());
                marshalledCreateInfos->SType = StructureType.ComputePipelineCreateInfo;
                marshalledCreateInfos->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfos->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfos->Flags = default(SharpVk.PipelineCreateFlags);
                }
                stage.MarshalTo(&marshalledCreateInfos->Stage);
                marshalledCreateInfos->Layout = layout?.handle ?? default(SharpVk.Interop.PipelineLayout);
                marshalledCreateInfos->BasePipelineHandle = basePipelineHandle?.handle ?? default(SharpVk.Interop.Pipeline);
                marshalledCreateInfos->BasePipelineIndex = basePipelineIndex;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                marshalledPipelines = (SharpVk.Interop.Pipeline*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Pipeline>(1));
                SharpVk.Interop.VkDeviceCreateComputePipelinesDelegate commandDelegate = commandCache.Cache.vkCreateComputePipelines;
                Result methodResult = commandDelegate(this.handle, pipelineCache?.handle ?? default(SharpVk.Interop.PipelineCache), createInfoCount, marshalledCreateInfos, marshalledAllocator, marshalledPipelines);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Pipeline(this, *marshalledPipelines);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Creates a new pipeline layout object.
        /// </summary>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="setLayouts">
        /// </param>
        /// <param name="pushConstantRanges">
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe SharpVk.PipelineLayout CreatePipelineLayout(ArrayProxy<SharpVk.DescriptorSetLayout>? setLayouts, ArrayProxy<SharpVk.PushConstantRange>? pushConstantRanges, SharpVk.PipelineLayoutCreateFlags? flags = default(SharpVk.PipelineLayoutCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.PipelineLayout result = default(SharpVk.PipelineLayout);
                SharpVk.Interop.PipelineLayoutCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.PipelineLayoutCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.PipelineLayout marshalledPipelineLayout = default(SharpVk.Interop.PipelineLayout);
                marshalledCreateInfo = (SharpVk.Interop.PipelineLayoutCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineLayoutCreateInfo>());
                marshalledCreateInfo->SType = StructureType.PipelineLayoutCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.PipelineLayoutCreateFlags);
                }
                marshalledCreateInfo->SetLayoutCount = (uint)(Interop.HeapUtil.GetLength(setLayouts));
                if (setLayouts.IsNull())
                {
                    marshalledCreateInfo->SetLayouts = null;
                }
                else
                {
                    if (setLayouts.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->SetLayouts = (SharpVk.Interop.DescriptorSetLayout*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorSetLayout>());
                        *(SharpVk.Interop.DescriptorSetLayout*)(marshalledCreateInfo->SetLayouts) = setLayouts.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.DescriptorSetLayout);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.DescriptorSetLayout*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.DescriptorSetLayout>(Interop.HeapUtil.GetLength(setLayouts.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(setLayouts.Value)); index++)
                        {
                            fieldPointer[index] = setLayouts.Value[index]?.handle ?? default(SharpVk.Interop.DescriptorSetLayout);
                        }
                        marshalledCreateInfo->SetLayouts = fieldPointer;
                    }
                }
                marshalledCreateInfo->PushConstantRangeCount = (uint)(Interop.HeapUtil.GetLength(pushConstantRanges));
                if (pushConstantRanges.IsNull())
                {
                    marshalledCreateInfo->PushConstantRanges = null;
                }
                else
                {
                    if (pushConstantRanges.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->PushConstantRanges = (SharpVk.PushConstantRange*)(Interop.HeapUtil.Allocate<SharpVk.PushConstantRange>());
                        *(SharpVk.PushConstantRange*)(marshalledCreateInfo->PushConstantRanges) = pushConstantRanges.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.PushConstantRange*)(Interop.HeapUtil.AllocateAndClear<SharpVk.PushConstantRange>(Interop.HeapUtil.GetLength(pushConstantRanges.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(pushConstantRanges.Value)); index++)
                        {
                            fieldPointer[index] = pushConstantRanges.Value[index];
                        }
                        marshalledCreateInfo->PushConstantRanges = fieldPointer;
                    }
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.VkDeviceCreatePipelineLayoutDelegate commandDelegate = commandCache.Cache.vkCreatePipelineLayout;
                Result methodResult = commandDelegate(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledPipelineLayout);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.PipelineLayout(this, marshalledPipelineLayout);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a new sampler object.
        /// </summary>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="magFilter">
        /// The magnification filter to apply to lookups.
        /// </param>
        /// <param name="samplerYcbcrConversionInfo">
        /// Extension struct
        /// </param>
        /// <param name="samplerReductionModeCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe SharpVk.Sampler CreateSampler(SharpVk.Filter magFilter, SharpVk.Filter minFilter, SharpVk.SamplerMipmapMode mipmapMode, SharpVk.SamplerAddressMode addressModeU, SharpVk.SamplerAddressMode addressModeV, SharpVk.SamplerAddressMode addressModeW, float mipLodBias, bool anisotropyEnable, float maxAnisotropy, bool compareEnable, SharpVk.CompareOp compareOp, float minLod, float maxLod, SharpVk.BorderColor borderColor, bool unnormalizedCoordinates, SharpVk.SamplerCreateFlags? flags = default(SharpVk.SamplerCreateFlags?), SharpVk.SamplerYcbcrConversionInfo? samplerYcbcrConversionInfo = null, SharpVk.Multivendor.SamplerReductionModeCreateInfo? samplerReductionModeCreateInfoExt = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Sampler result = default(SharpVk.Sampler);
                SharpVk.Interop.SamplerCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.SamplerCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Sampler marshalledSampler = default(SharpVk.Interop.Sampler);
                if (samplerYcbcrConversionInfo != null)
                {
                    SharpVk.Interop.SamplerYcbcrConversionInfo* extensionPointer = default(SharpVk.Interop.SamplerYcbcrConversionInfo*);
                    extensionPointer = (SharpVk.Interop.SamplerYcbcrConversionInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SamplerYcbcrConversionInfo>());
                    samplerYcbcrConversionInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (samplerReductionModeCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.SamplerReductionModeCreateInfo* extensionPointer = default(SharpVk.Interop.Multivendor.SamplerReductionModeCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.SamplerReductionModeCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.SamplerReductionModeCreateInfo>());
                    samplerReductionModeCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                marshalledCreateInfo = (SharpVk.Interop.SamplerCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SamplerCreateInfo>());
                marshalledCreateInfo->SType = StructureType.SamplerCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.SamplerCreateFlags);
                }
                marshalledCreateInfo->MagFilter = magFilter;
                marshalledCreateInfo->MinFilter = minFilter;
                marshalledCreateInfo->MipmapMode = mipmapMode;
                marshalledCreateInfo->AddressModeU = addressModeU;
                marshalledCreateInfo->AddressModeV = addressModeV;
                marshalledCreateInfo->AddressModeW = addressModeW;
                marshalledCreateInfo->MipLodBias = mipLodBias;
                marshalledCreateInfo->AnisotropyEnable = anisotropyEnable;
                marshalledCreateInfo->MaxAnisotropy = maxAnisotropy;
                marshalledCreateInfo->CompareEnable = compareEnable;
                marshalledCreateInfo->CompareOp = compareOp;
                marshalledCreateInfo->MinLod = minLod;
                marshalledCreateInfo->MaxLod = maxLod;
                marshalledCreateInfo->BorderColor = borderColor;
                marshalledCreateInfo->UnnormalizedCoordinates = unnormalizedCoordinates;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.VkDeviceCreateSamplerDelegate commandDelegate = commandCache.Cache.vkCreateSampler;
                Result methodResult = commandDelegate(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledSampler);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Sampler(this, marshalledSampler);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a new descriptor set layout.
        /// </summary>
        /// <param name="flags">
        /// flags provides options for descriptor set layout creation, and is
        /// of type DescriptorSetLayoutCreateFlags. Bits which can be set
        /// include: + --
        /// </param>
        /// <param name="bindings">
        /// </param>
        /// <param name="descriptorSetLayoutBindingFlagsCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe SharpVk.DescriptorSetLayout CreateDescriptorSetLayout(ArrayProxy<SharpVk.DescriptorSetLayoutBinding>? bindings, SharpVk.DescriptorSetLayoutCreateFlags? flags = default(SharpVk.DescriptorSetLayoutCreateFlags?), SharpVk.Multivendor.DescriptorSetLayoutBindingFlagsCreateInfo? descriptorSetLayoutBindingFlagsCreateInfoExt = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.DescriptorSetLayout result = default(SharpVk.DescriptorSetLayout);
                SharpVk.Interop.DescriptorSetLayoutCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.DescriptorSetLayoutCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.DescriptorSetLayout marshalledSetLayout = default(SharpVk.Interop.DescriptorSetLayout);
                if (descriptorSetLayoutBindingFlagsCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.DescriptorSetLayoutBindingFlagsCreateInfo* extensionPointer = default(SharpVk.Interop.Multivendor.DescriptorSetLayoutBindingFlagsCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.DescriptorSetLayoutBindingFlagsCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DescriptorSetLayoutBindingFlagsCreateInfo>());
                    descriptorSetLayoutBindingFlagsCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                marshalledCreateInfo = (SharpVk.Interop.DescriptorSetLayoutCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorSetLayoutCreateInfo>());
                marshalledCreateInfo->SType = StructureType.DescriptorSetLayoutCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.DescriptorSetLayoutCreateFlags);
                }
                marshalledCreateInfo->BindingCount = (uint)(Interop.HeapUtil.GetLength(bindings));
                if (bindings.IsNull())
                {
                    marshalledCreateInfo->Bindings = null;
                }
                else
                {
                    if (bindings.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->Bindings = (SharpVk.Interop.DescriptorSetLayoutBinding*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorSetLayoutBinding>());
                        bindings.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.DescriptorSetLayoutBinding*)(marshalledCreateInfo->Bindings));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.DescriptorSetLayoutBinding*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.DescriptorSetLayoutBinding>(Interop.HeapUtil.GetLength(bindings.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(bindings.Value)); index++)
                        {
                            bindings.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfo->Bindings = fieldPointer;
                    }
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.VkDeviceCreateDescriptorSetLayoutDelegate commandDelegate = commandCache.Cache.vkCreateDescriptorSetLayout;
                Result methodResult = commandDelegate(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledSetLayout);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.DescriptorSetLayout(this, marshalledSetLayout);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Creates a descriptor pool object.
        /// </summary>
        /// <param name="flags">
        /// Specifies certain supported operations on the pool. Bits which can
        /// be set include: + --
        /// </param>
        /// <param name="poolSizes">
        /// </param>
        /// <param name="descriptorPoolInlineUniformBlockCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe SharpVk.DescriptorPool CreateDescriptorPool(uint maxSets, ArrayProxy<SharpVk.DescriptorPoolSize>? poolSizes, SharpVk.DescriptorPoolCreateFlags? flags = default(SharpVk.DescriptorPoolCreateFlags?), SharpVk.Multivendor.DescriptorPoolInlineUniformBlockCreateInfo? descriptorPoolInlineUniformBlockCreateInfoExt = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.DescriptorPool result = default(SharpVk.DescriptorPool);
                SharpVk.Interop.DescriptorPoolCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.DescriptorPoolCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.DescriptorPool marshalledDescriptorPool = default(SharpVk.Interop.DescriptorPool);
                if (descriptorPoolInlineUniformBlockCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.DescriptorPoolInlineUniformBlockCreateInfo* extensionPointer = default(SharpVk.Interop.Multivendor.DescriptorPoolInlineUniformBlockCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.DescriptorPoolInlineUniformBlockCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DescriptorPoolInlineUniformBlockCreateInfo>());
                    descriptorPoolInlineUniformBlockCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                marshalledCreateInfo = (SharpVk.Interop.DescriptorPoolCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorPoolCreateInfo>());
                marshalledCreateInfo->SType = StructureType.DescriptorPoolCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.DescriptorPoolCreateFlags);
                }
                marshalledCreateInfo->MaxSets = maxSets;
                marshalledCreateInfo->PoolSizeCount = (uint)(Interop.HeapUtil.GetLength(poolSizes));
                if (poolSizes.IsNull())
                {
                    marshalledCreateInfo->PoolSizes = null;
                }
                else
                {
                    if (poolSizes.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->PoolSizes = (SharpVk.DescriptorPoolSize*)(Interop.HeapUtil.Allocate<SharpVk.DescriptorPoolSize>());
                        *(SharpVk.DescriptorPoolSize*)(marshalledCreateInfo->PoolSizes) = poolSizes.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.DescriptorPoolSize*)(Interop.HeapUtil.AllocateAndClear<SharpVk.DescriptorPoolSize>(Interop.HeapUtil.GetLength(poolSizes.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(poolSizes.Value)); index++)
                        {
                            fieldPointer[index] = poolSizes.Value[index];
                        }
                        marshalledCreateInfo->PoolSizes = fieldPointer;
                    }
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.VkDeviceCreateDescriptorPoolDelegate commandDelegate = commandCache.Cache.vkCreateDescriptorPool;
                Result methodResult = commandDelegate(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledDescriptorPool);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.DescriptorPool(this, marshalledDescriptorPool);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Allocate one or more descriptor sets.
        /// </summary>
        /// <param name="descriptorPool">
        /// The pool which the sets will be allocated from.
        /// </param>
        /// <param name="setLayouts">
        /// </param>
        /// <param name="descriptorSetVariableDescriptorCountAllocateInfoExt">
        /// Extension struct
        /// </param>
        public unsafe SharpVk.DescriptorSet[] AllocateDescriptorSets(SharpVk.DescriptorPool descriptorPool, ArrayProxy<SharpVk.DescriptorSetLayout>? setLayouts, SharpVk.Multivendor.DescriptorSetVariableDescriptorCountAllocateInfo? descriptorSetVariableDescriptorCountAllocateInfoExt = null)
        {
            try
            {
                SharpVk.DescriptorSet[] result = default(SharpVk.DescriptorSet[]);
                SharpVk.Interop.DescriptorSetAllocateInfo* marshalledAllocateInfo = default(SharpVk.Interop.DescriptorSetAllocateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.DescriptorSet* marshalledDescriptorSets = default(SharpVk.Interop.DescriptorSet*);
                if (descriptorSetVariableDescriptorCountAllocateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.DescriptorSetVariableDescriptorCountAllocateInfo* extensionPointer = default(SharpVk.Interop.Multivendor.DescriptorSetVariableDescriptorCountAllocateInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.DescriptorSetVariableDescriptorCountAllocateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DescriptorSetVariableDescriptorCountAllocateInfo>());
                    descriptorSetVariableDescriptorCountAllocateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                marshalledAllocateInfo = (SharpVk.Interop.DescriptorSetAllocateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorSetAllocateInfo>());
                marshalledAllocateInfo->SType = StructureType.DescriptorSetAllocateInfo;
                marshalledAllocateInfo->Next = nextPointer;
                marshalledAllocateInfo->DescriptorPool = descriptorPool?.handle ?? default(SharpVk.Interop.DescriptorPool);
                marshalledAllocateInfo->DescriptorSetCount = (uint)(Interop.HeapUtil.GetLength(setLayouts));
                if (setLayouts.IsNull())
                {
                    marshalledAllocateInfo->SetLayouts = null;
                }
                else
                {
                    if (setLayouts.Value.Contents == ProxyContents.Single)
                    {
                        marshalledAllocateInfo->SetLayouts = (SharpVk.Interop.DescriptorSetLayout*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorSetLayout>());
                        *(SharpVk.Interop.DescriptorSetLayout*)(marshalledAllocateInfo->SetLayouts) = setLayouts.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.DescriptorSetLayout);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.DescriptorSetLayout*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.DescriptorSetLayout>(Interop.HeapUtil.GetLength(setLayouts.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(setLayouts.Value)); index++)
                        {
                            fieldPointer[index] = setLayouts.Value[index]?.handle ?? default(SharpVk.Interop.DescriptorSetLayout);
                        }
                        marshalledAllocateInfo->SetLayouts = fieldPointer;
                    }
                }
                marshalledDescriptorSets = (SharpVk.Interop.DescriptorSet*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorSet>(Interop.HeapUtil.GetLength(setLayouts)));
                SharpVk.Interop.VkDeviceAllocateDescriptorSetsDelegate commandDelegate = commandCache.Cache.vkAllocateDescriptorSets;
                Result methodResult = commandDelegate(this.handle, marshalledAllocateInfo, marshalledDescriptorSets);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                if (marshalledDescriptorSets != null)
                {
                    var fieldPointer = new SharpVk.DescriptorSet[(uint)(Interop.HeapUtil.GetLength(setLayouts))];
                    for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(setLayouts)); index++)
                    {
                        fieldPointer[index] = new SharpVk.DescriptorSet(descriptorPool, marshalledDescriptorSets[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Allocate one or more descriptor sets.
        /// </summary>
        /// <param name="descriptorPool">
        /// The pool which the sets will be allocated from.
        /// </param>
        /// <param name="setLayouts">
        /// An array of descriptor set layouts, with each member specifying how
        /// the corresponding descriptor set is allocated.
        /// </param>
        /// <param name="descriptorSetVariableDescriptorCountAllocateInfoExt">
        /// Extension struct
        /// </param>
        public unsafe SharpVk.DescriptorSet AllocateDescriptorSet(SharpVk.DescriptorPool descriptorPool, SharpVk.DescriptorSetLayout setLayouts, SharpVk.Multivendor.DescriptorSetVariableDescriptorCountAllocateInfo? descriptorSetVariableDescriptorCountAllocateInfoExt = null)
        {
            try
            {
                SharpVk.DescriptorSet result = default(SharpVk.DescriptorSet);
                SharpVk.Interop.DescriptorSetAllocateInfo* marshalledAllocateInfo = default(SharpVk.Interop.DescriptorSetAllocateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.DescriptorSet* marshalledDescriptorSets = default(SharpVk.Interop.DescriptorSet*);
                if (descriptorSetVariableDescriptorCountAllocateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.DescriptorSetVariableDescriptorCountAllocateInfo* extensionPointer = default(SharpVk.Interop.Multivendor.DescriptorSetVariableDescriptorCountAllocateInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.DescriptorSetVariableDescriptorCountAllocateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DescriptorSetVariableDescriptorCountAllocateInfo>());
                    descriptorSetVariableDescriptorCountAllocateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                marshalledAllocateInfo = (SharpVk.Interop.DescriptorSetAllocateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorSetAllocateInfo>());
                marshalledAllocateInfo->SType = StructureType.DescriptorSetAllocateInfo;
                marshalledAllocateInfo->Next = nextPointer;
                marshalledAllocateInfo->DescriptorPool = descriptorPool?.handle ?? default(SharpVk.Interop.DescriptorPool);
                marshalledAllocateInfo->DescriptorSetCount = 1;
                marshalledAllocateInfo->SetLayouts = (SharpVk.Interop.DescriptorSetLayout*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorSetLayout>());
                *marshalledAllocateInfo->SetLayouts = setLayouts.handle;
                marshalledDescriptorSets = (SharpVk.Interop.DescriptorSet*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorSet>(1));
                SharpVk.Interop.VkDeviceAllocateDescriptorSetsDelegate commandDelegate = commandCache.Cache.vkAllocateDescriptorSets;
                Result methodResult = commandDelegate(this.handle, marshalledAllocateInfo, marshalledDescriptorSets);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.DescriptorSet(descriptorPool, *marshalledDescriptorSets);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Update the contents of a descriptor set object.
        /// </summary>
        /// <param name="descriptorWrites">
        /// </param>
        /// <param name="descriptorCopies">
        /// </param>
        public unsafe void UpdateDescriptorSets(ArrayProxy<SharpVk.WriteDescriptorSet>? descriptorWrites, ArrayProxy<SharpVk.CopyDescriptorSet>? descriptorCopies)
        {
            try
            {
                SharpVk.Interop.WriteDescriptorSet* marshalledDescriptorWrites = default(SharpVk.Interop.WriteDescriptorSet*);
                SharpVk.Interop.CopyDescriptorSet* marshalledDescriptorCopies = default(SharpVk.Interop.CopyDescriptorSet*);
                if (descriptorWrites.IsNull())
                {
                    marshalledDescriptorWrites = null;
                }
                else
                {
                    if (descriptorWrites.Value.Contents == ProxyContents.Single)
                    {
                        marshalledDescriptorWrites = (SharpVk.Interop.WriteDescriptorSet*)(Interop.HeapUtil.Allocate<SharpVk.Interop.WriteDescriptorSet>());
                        descriptorWrites.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.WriteDescriptorSet*)(marshalledDescriptorWrites));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.WriteDescriptorSet*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.WriteDescriptorSet>(Interop.HeapUtil.GetLength(descriptorWrites.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(descriptorWrites.Value)); index++)
                        {
                            descriptorWrites.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledDescriptorWrites = fieldPointer;
                    }
                }
                if (descriptorCopies.IsNull())
                {
                    marshalledDescriptorCopies = null;
                }
                else
                {
                    if (descriptorCopies.Value.Contents == ProxyContents.Single)
                    {
                        marshalledDescriptorCopies = (SharpVk.Interop.CopyDescriptorSet*)(Interop.HeapUtil.Allocate<SharpVk.Interop.CopyDescriptorSet>());
                        descriptorCopies.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.CopyDescriptorSet*)(marshalledDescriptorCopies));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.CopyDescriptorSet*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.CopyDescriptorSet>(Interop.HeapUtil.GetLength(descriptorCopies.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(descriptorCopies.Value)); index++)
                        {
                            descriptorCopies.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledDescriptorCopies = fieldPointer;
                    }
                }
                SharpVk.Interop.VkDeviceUpdateDescriptorSetsDelegate commandDelegate = commandCache.Cache.vkUpdateDescriptorSets;
                commandDelegate(this.handle, (uint)(Interop.HeapUtil.GetLength(descriptorWrites)), marshalledDescriptorWrites, (uint)(Interop.HeapUtil.GetLength(descriptorCopies)), marshalledDescriptorCopies);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a new framebuffer object.
        /// </summary>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="renderPass">
        /// A render pass that defines what render passes the framebuffer will
        /// be compatible with.
        /// </param>
        /// <param name="attachments">
        /// </param>
        /// <param name="width">
        /// width, height and layers define the dimensions of the framebuffer.
        /// If the render pass uses multiview, then layers must be one and each
        /// attachment requires a number of layers that is greater than the
        /// maximum bit index set in the view mask in the subpasses in which it
        /// is used.
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe SharpVk.Framebuffer CreateFramebuffer(SharpVk.RenderPass renderPass, ArrayProxy<SharpVk.ImageView>? attachments, uint width, uint height, uint layers, SharpVk.FramebufferCreateFlags? flags = default(SharpVk.FramebufferCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Framebuffer result = default(SharpVk.Framebuffer);
                SharpVk.Interop.FramebufferCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.FramebufferCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Framebuffer marshalledFramebuffer = default(SharpVk.Interop.Framebuffer);
                marshalledCreateInfo = (SharpVk.Interop.FramebufferCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.FramebufferCreateInfo>());
                marshalledCreateInfo->SType = StructureType.FramebufferCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.FramebufferCreateFlags);
                }
                marshalledCreateInfo->RenderPass = renderPass?.handle ?? default(SharpVk.Interop.RenderPass);
                marshalledCreateInfo->AttachmentCount = (uint)(Interop.HeapUtil.GetLength(attachments));
                if (attachments.IsNull())
                {
                    marshalledCreateInfo->Attachments = null;
                }
                else
                {
                    if (attachments.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->Attachments = (SharpVk.Interop.ImageView*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ImageView>());
                        *(SharpVk.Interop.ImageView*)(marshalledCreateInfo->Attachments) = attachments.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.ImageView);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.ImageView*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.ImageView>(Interop.HeapUtil.GetLength(attachments.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(attachments.Value)); index++)
                        {
                            fieldPointer[index] = attachments.Value[index]?.handle ?? default(SharpVk.Interop.ImageView);
                        }
                        marshalledCreateInfo->Attachments = fieldPointer;
                    }
                }
                marshalledCreateInfo->Width = width;
                marshalledCreateInfo->Height = height;
                marshalledCreateInfo->Layers = layers;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.VkDeviceCreateFramebufferDelegate commandDelegate = commandCache.Cache.vkCreateFramebuffer;
                Result methodResult = commandDelegate(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledFramebuffer);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Framebuffer(this, marshalledFramebuffer);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a new render pass object.
        /// </summary>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="attachments">
        /// </param>
        /// <param name="subpasses">
        /// </param>
        /// <param name="dependencies">
        /// </param>
        /// <param name="renderPassMultiviewCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="renderPassInputAttachmentAspectCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="renderPassFragmentDensityMapCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe SharpVk.RenderPass CreateRenderPass(ArrayProxy<SharpVk.AttachmentDescription>? attachments, ArrayProxy<SharpVk.SubpassDescription>? subpasses, ArrayProxy<SharpVk.SubpassDependency>? dependencies, SharpVk.RenderPassCreateFlags? flags = default(SharpVk.RenderPassCreateFlags?), SharpVk.RenderPassMultiviewCreateInfo? renderPassMultiviewCreateInfo = null, SharpVk.RenderPassInputAttachmentAspectCreateInfo? renderPassInputAttachmentAspectCreateInfo = null, SharpVk.Multivendor.RenderPassFragmentDensityMapCreateInfo? renderPassFragmentDensityMapCreateInfoExt = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.RenderPass result = default(SharpVk.RenderPass);
                SharpVk.Interop.RenderPassCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.RenderPassCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.RenderPass marshalledRenderPass = default(SharpVk.Interop.RenderPass);
                if (renderPassMultiviewCreateInfo != null)
                {
                    SharpVk.Interop.RenderPassMultiviewCreateInfo* extensionPointer = default(SharpVk.Interop.RenderPassMultiviewCreateInfo*);
                    extensionPointer = (SharpVk.Interop.RenderPassMultiviewCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.RenderPassMultiviewCreateInfo>());
                    renderPassMultiviewCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (renderPassInputAttachmentAspectCreateInfo != null)
                {
                    SharpVk.Interop.RenderPassInputAttachmentAspectCreateInfo* extensionPointer = default(SharpVk.Interop.RenderPassInputAttachmentAspectCreateInfo*);
                    extensionPointer = (SharpVk.Interop.RenderPassInputAttachmentAspectCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.RenderPassInputAttachmentAspectCreateInfo>());
                    renderPassInputAttachmentAspectCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                if (renderPassFragmentDensityMapCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.RenderPassFragmentDensityMapCreateInfo* extensionPointer = default(SharpVk.Interop.Multivendor.RenderPassFragmentDensityMapCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.RenderPassFragmentDensityMapCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.RenderPassFragmentDensityMapCreateInfo>());
                    renderPassFragmentDensityMapCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                marshalledCreateInfo = (SharpVk.Interop.RenderPassCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.RenderPassCreateInfo>());
                marshalledCreateInfo->SType = StructureType.RenderPassCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.RenderPassCreateFlags);
                }
                marshalledCreateInfo->AttachmentCount = (uint)(Interop.HeapUtil.GetLength(attachments));
                if (attachments.IsNull())
                {
                    marshalledCreateInfo->Attachments = null;
                }
                else
                {
                    if (attachments.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->Attachments = (SharpVk.AttachmentDescription*)(Interop.HeapUtil.Allocate<SharpVk.AttachmentDescription>());
                        *(SharpVk.AttachmentDescription*)(marshalledCreateInfo->Attachments) = attachments.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.AttachmentDescription*)(Interop.HeapUtil.AllocateAndClear<SharpVk.AttachmentDescription>(Interop.HeapUtil.GetLength(attachments.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(attachments.Value)); index++)
                        {
                            fieldPointer[index] = attachments.Value[index];
                        }
                        marshalledCreateInfo->Attachments = fieldPointer;
                    }
                }
                marshalledCreateInfo->SubpassCount = (uint)(Interop.HeapUtil.GetLength(subpasses));
                if (subpasses.IsNull())
                {
                    marshalledCreateInfo->Subpasses = null;
                }
                else
                {
                    if (subpasses.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->Subpasses = (SharpVk.Interop.SubpassDescription*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SubpassDescription>());
                        subpasses.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.SubpassDescription*)(marshalledCreateInfo->Subpasses));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.SubpassDescription*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.SubpassDescription>(Interop.HeapUtil.GetLength(subpasses.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(subpasses.Value)); index++)
                        {
                            subpasses.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfo->Subpasses = fieldPointer;
                    }
                }
                marshalledCreateInfo->DependencyCount = (uint)(Interop.HeapUtil.GetLength(dependencies));
                if (dependencies.IsNull())
                {
                    marshalledCreateInfo->Dependencies = null;
                }
                else
                {
                    if (dependencies.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->Dependencies = (SharpVk.SubpassDependency*)(Interop.HeapUtil.Allocate<SharpVk.SubpassDependency>());
                        *(SharpVk.SubpassDependency*)(marshalledCreateInfo->Dependencies) = dependencies.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.SubpassDependency*)(Interop.HeapUtil.AllocateAndClear<SharpVk.SubpassDependency>(Interop.HeapUtil.GetLength(dependencies.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(dependencies.Value)); index++)
                        {
                            fieldPointer[index] = dependencies.Value[index];
                        }
                        marshalledCreateInfo->Dependencies = fieldPointer;
                    }
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.VkDeviceCreateRenderPassDelegate commandDelegate = commandCache.Cache.vkCreateRenderPass;
                Result methodResult = commandDelegate(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledRenderPass);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.RenderPass(this, marshalledRenderPass);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Create a new command pool object.
        /// </summary>
        /// <param name="flags">
        /// A bitmask indicating usage behavior for the pool and command
        /// buffers allocated from it. Bits which can be set include: + --
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public unsafe SharpVk.CommandPool CreateCommandPool(uint queueFamilyIndex, SharpVk.CommandPoolCreateFlags? flags = default(SharpVk.CommandPoolCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.CommandPool result = default(SharpVk.CommandPool);
                SharpVk.Interop.CommandPoolCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.CommandPoolCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.CommandPool marshalledCommandPool = default(SharpVk.Interop.CommandPool);
                marshalledCreateInfo = (SharpVk.Interop.CommandPoolCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.CommandPoolCreateInfo>());
                marshalledCreateInfo->SType = StructureType.CommandPoolCreateInfo;
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.CommandPoolCreateFlags);
                }
                marshalledCreateInfo->QueueFamilyIndex = queueFamilyIndex;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.VkDeviceCreateCommandPoolDelegate commandDelegate = commandCache.Cache.vkCreateCommandPool;
                Result methodResult = commandDelegate(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledCommandPool);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.CommandPool(this, marshalledCommandPool);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Allocate command buffers from an existing command pool.
        /// </summary>
        /// <param name="commandPool">
        /// The command pool from which the command buffers are allocated.
        /// </param>
        /// <param name="level">
        /// level determines whether the command buffers are primary or
        /// secondary command buffers. Possible values include: + --
        /// </param>
        public unsafe SharpVk.CommandBuffer[] AllocateCommandBuffers(SharpVk.CommandPool commandPool, SharpVk.CommandBufferLevel level, uint commandBufferCount)
        {
            try
            {
                SharpVk.CommandBuffer[] result = default(SharpVk.CommandBuffer[]);
                SharpVk.Interop.CommandBufferAllocateInfo* marshalledAllocateInfo = default(SharpVk.Interop.CommandBufferAllocateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.CommandBuffer* marshalledCommandBuffers = default(SharpVk.Interop.CommandBuffer*);
                marshalledAllocateInfo = (SharpVk.Interop.CommandBufferAllocateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.CommandBufferAllocateInfo>());
                marshalledAllocateInfo->SType = StructureType.CommandBufferAllocateInfo;
                marshalledAllocateInfo->Next = nextPointer;
                marshalledAllocateInfo->CommandPool = commandPool?.handle ?? default(SharpVk.Interop.CommandPool);
                marshalledAllocateInfo->Level = level;
                marshalledAllocateInfo->CommandBufferCount = commandBufferCount;
                marshalledCommandBuffers = (SharpVk.Interop.CommandBuffer*)(Interop.HeapUtil.Allocate<SharpVk.Interop.CommandBuffer>(commandBufferCount));
                SharpVk.Interop.VkDeviceAllocateCommandBuffersDelegate commandDelegate = commandCache.Cache.vkAllocateCommandBuffers;
                Result methodResult = commandDelegate(this.handle, marshalledAllocateInfo, marshalledCommandBuffers);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                if (marshalledCommandBuffers != null)
                {
                    var fieldPointer = new SharpVk.CommandBuffer[(uint)(commandBufferCount)];
                    for(int index = 0; index < (uint)(commandBufferCount); index++)
                    {
                        fieldPointer[index] = new SharpVk.CommandBuffer(commandPool, marshalledCommandBuffers[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Allocate command buffers from an existing command pool.
        /// </summary>
        /// <param name="commandPool">
        /// The command pool from which the command buffers are allocated.
        /// </param>
        /// <param name="level">
        /// level determines whether the command buffers are primary or
        /// secondary command buffers. Possible values include: + --
        /// </param>
        public unsafe SharpVk.CommandBuffer AllocateCommandBuffer(SharpVk.CommandPool commandPool, SharpVk.CommandBufferLevel level)
        {
            try
            {
                SharpVk.CommandBuffer result = default(SharpVk.CommandBuffer);
                SharpVk.Interop.CommandBufferAllocateInfo* marshalledAllocateInfo = default(SharpVk.Interop.CommandBufferAllocateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.CommandBuffer* marshalledCommandBuffers = default(SharpVk.Interop.CommandBuffer*);
                marshalledAllocateInfo = (SharpVk.Interop.CommandBufferAllocateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.CommandBufferAllocateInfo>());
                marshalledAllocateInfo->SType = StructureType.CommandBufferAllocateInfo;
                marshalledAllocateInfo->Next = nextPointer;
                marshalledAllocateInfo->CommandPool = commandPool?.handle ?? default(SharpVk.Interop.CommandPool);
                marshalledAllocateInfo->Level = level;
                marshalledAllocateInfo->CommandBufferCount = 1;
                marshalledCommandBuffers = (SharpVk.Interop.CommandBuffer*)(Interop.HeapUtil.Allocate<SharpVk.Interop.CommandBuffer>(1));
                SharpVk.Interop.VkDeviceAllocateCommandBuffersDelegate commandDelegate = commandCache.Cache.vkAllocateCommandBuffers;
                Result methodResult = commandDelegate(this.handle, marshalledAllocateInfo, marshalledCommandBuffers);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.CommandBuffer(commandPool, *marshalledCommandBuffers);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bindInfos">
        /// </param>
        public unsafe void BindBufferMemory2(ArrayProxy<SharpVk.BindBufferMemoryInfo>? bindInfos)
        {
            try
            {
                SharpVk.Interop.BindBufferMemoryInfo* marshalledBindInfos = default(SharpVk.Interop.BindBufferMemoryInfo*);
                if (bindInfos.IsNull())
                {
                    marshalledBindInfos = null;
                }
                else
                {
                    if (bindInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBindInfos = (SharpVk.Interop.BindBufferMemoryInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.BindBufferMemoryInfo>());
                        bindInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.BindBufferMemoryInfo*)(marshalledBindInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.BindBufferMemoryInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.BindBufferMemoryInfo>(Interop.HeapUtil.GetLength(bindInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(bindInfos.Value)); index++)
                        {
                            bindInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledBindInfos = fieldPointer;
                    }
                }
                SharpVk.Interop.VkDeviceBindBufferMemory2Delegate commandDelegate = commandCache.Cache.vkBindBufferMemory2;
                Result methodResult = commandDelegate(this.handle, (uint)(Interop.HeapUtil.GetLength(bindInfos)), marshalledBindInfos);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bindInfos">
        /// </param>
        public unsafe void BindImageMemory2(ArrayProxy<SharpVk.BindImageMemoryInfo>? bindInfos)
        {
            try
            {
                SharpVk.Interop.BindImageMemoryInfo* marshalledBindInfos = default(SharpVk.Interop.BindImageMemoryInfo*);
                if (bindInfos.IsNull())
                {
                    marshalledBindInfos = null;
                }
                else
                {
                    if (bindInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBindInfos = (SharpVk.Interop.BindImageMemoryInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.BindImageMemoryInfo>());
                        bindInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.BindImageMemoryInfo*)(marshalledBindInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.BindImageMemoryInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.BindImageMemoryInfo>(Interop.HeapUtil.GetLength(bindInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(bindInfos.Value)); index++)
                        {
                            bindInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledBindInfos = fieldPointer;
                    }
                }
                SharpVk.Interop.VkDeviceBindImageMemory2Delegate commandDelegate = commandCache.Cache.vkBindImageMemory2;
                Result methodResult = commandDelegate(this.handle, (uint)(Interop.HeapUtil.GetLength(bindInfos)), marshalledBindInfos);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe SharpVk.PeerMemoryFeatureFlags GetGroupPeerMemoryFeatures(uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex)
        {
            try
            {
                SharpVk.PeerMemoryFeatureFlags result = default(SharpVk.PeerMemoryFeatureFlags);
                SharpVk.PeerMemoryFeatureFlags marshalledPeerMemoryFeatures = default(SharpVk.PeerMemoryFeatureFlags);
                SharpVk.Interop.VkDeviceGetGroupPeerMemoryFeaturesDelegate commandDelegate = commandCache.Cache.vkGetDeviceGroupPeerMemoryFeatures;
                commandDelegate(this.handle, heapIndex, localDeviceIndex, remoteDeviceIndex, &marshalledPeerMemoryFeatures);
                result = marshalledPeerMemoryFeatures;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe SharpVk.MemoryRequirements2 GetImageMemoryRequirements2(SharpVk.ImageMemoryRequirementsInfo2 info)
        {
            try
            {
                SharpVk.MemoryRequirements2 result = default(SharpVk.MemoryRequirements2);
                SharpVk.Interop.ImageMemoryRequirementsInfo2* marshalledInfo = default(SharpVk.Interop.ImageMemoryRequirementsInfo2*);
                SharpVk.Interop.MemoryRequirements2 marshalledMemoryRequirements = default(SharpVk.Interop.MemoryRequirements2);
                marshalledInfo = (SharpVk.Interop.ImageMemoryRequirementsInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ImageMemoryRequirementsInfo2>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.VkDeviceGetImageMemoryRequirements2Delegate commandDelegate = commandCache.Cache.vkGetImageMemoryRequirements2;
                commandDelegate(this.handle, marshalledInfo, &marshalledMemoryRequirements);
                result = SharpVk.MemoryRequirements2.MarshalFrom(&marshalledMemoryRequirements);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe SharpVk.MemoryRequirements2 GetBufferMemoryRequirements2(SharpVk.BufferMemoryRequirementsInfo2 info)
        {
            try
            {
                SharpVk.MemoryRequirements2 result = default(SharpVk.MemoryRequirements2);
                SharpVk.Interop.BufferMemoryRequirementsInfo2* marshalledInfo = default(SharpVk.Interop.BufferMemoryRequirementsInfo2*);
                SharpVk.Interop.MemoryRequirements2 marshalledMemoryRequirements = default(SharpVk.Interop.MemoryRequirements2);
                marshalledInfo = (SharpVk.Interop.BufferMemoryRequirementsInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.BufferMemoryRequirementsInfo2>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.VkDeviceGetBufferMemoryRequirements2Delegate commandDelegate = commandCache.Cache.vkGetBufferMemoryRequirements2;
                commandDelegate(this.handle, marshalledInfo, &marshalledMemoryRequirements);
                result = SharpVk.MemoryRequirements2.MarshalFrom(&marshalledMemoryRequirements);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe SharpVk.SparseImageMemoryRequirements2[] GetImageSparseMemoryRequirements2(SharpVk.ImageSparseMemoryRequirementsInfo2 info)
        {
            try
            {
                SharpVk.SparseImageMemoryRequirements2[] result = default(SharpVk.SparseImageMemoryRequirements2[]);
                uint sparseMemoryRequirementCount = default(uint);
                SharpVk.Interop.ImageSparseMemoryRequirementsInfo2* marshalledInfo = default(SharpVk.Interop.ImageSparseMemoryRequirementsInfo2*);
                SharpVk.Interop.SparseImageMemoryRequirements2* marshalledSparseMemoryRequirements = default(SharpVk.Interop.SparseImageMemoryRequirements2*);
                marshalledInfo = (SharpVk.Interop.ImageSparseMemoryRequirementsInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ImageSparseMemoryRequirementsInfo2>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.VkDeviceGetImageSparseMemoryRequirements2Delegate commandDelegate = commandCache.Cache.vkGetImageSparseMemoryRequirements2;
                commandDelegate(this.handle, marshalledInfo, &sparseMemoryRequirementCount, marshalledSparseMemoryRequirements);
                marshalledSparseMemoryRequirements = (SharpVk.Interop.SparseImageMemoryRequirements2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SparseImageMemoryRequirements2>((uint)(sparseMemoryRequirementCount)));
                commandDelegate(this.handle, marshalledInfo, &sparseMemoryRequirementCount, marshalledSparseMemoryRequirements);
                if (marshalledSparseMemoryRequirements != null)
                {
                    var fieldPointer = new SharpVk.SparseImageMemoryRequirements2[(uint)(sparseMemoryRequirementCount)];
                    for(int index = 0; index < (uint)(sparseMemoryRequirementCount); index++)
                    {
                        fieldPointer[index] = SharpVk.SparseImageMemoryRequirements2.MarshalFrom(&marshalledSparseMemoryRequirements[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe SharpVk.Queue GetQueue2(SharpVk.DeviceQueueInfo2 queueInfo)
        {
            try
            {
                SharpVk.Queue result = default(SharpVk.Queue);
                SharpVk.Interop.DeviceQueueInfo2* marshalledQueueInfo = default(SharpVk.Interop.DeviceQueueInfo2*);
                SharpVk.Interop.Queue marshalledQueue = default(SharpVk.Interop.Queue);
                marshalledQueueInfo = (SharpVk.Interop.DeviceQueueInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DeviceQueueInfo2>());
                queueInfo.MarshalTo(marshalledQueueInfo);
                SharpVk.Interop.VkDeviceGetQueue2Delegate commandDelegate = commandCache.Cache.vkGetDeviceQueue2;
                commandDelegate(this.handle, marshalledQueueInfo, &marshalledQueue);
                result = new SharpVk.Queue(this, marshalledQueue);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="externalFormatAndroid">
        /// Extension struct
        /// </param>
        public unsafe SharpVk.SamplerYcbcrConversion CreateSamplerYcbcrConversion(SharpVk.Format format, SharpVk.SamplerYcbcrModelConversion ycbcrModel, SharpVk.SamplerYcbcrRange ycbcrRange, SharpVk.ComponentMapping components, SharpVk.ChromaLocation xChromaOffset, SharpVk.ChromaLocation yChromaOffset, SharpVk.Filter chromaFilter, bool forceExplicitReconstruction, SharpVk.Android.ExternalFormat? externalFormatAndroid = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.SamplerYcbcrConversion result = default(SharpVk.SamplerYcbcrConversion);
                SharpVk.Interop.SamplerYcbcrConversionCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.SamplerYcbcrConversionCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.SamplerYcbcrConversion marshalledYcbcrConversion = default(SharpVk.Interop.SamplerYcbcrConversion);
                if (externalFormatAndroid != null)
                {
                    SharpVk.Interop.Android.ExternalFormat* extensionPointer = default(SharpVk.Interop.Android.ExternalFormat*);
                    extensionPointer = (SharpVk.Interop.Android.ExternalFormat*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Android.ExternalFormat>());
                    externalFormatAndroid.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = nextPointer;
                    nextPointer = extensionPointer;
                }
                marshalledCreateInfo = (SharpVk.Interop.SamplerYcbcrConversionCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SamplerYcbcrConversionCreateInfo>());
                marshalledCreateInfo->Next = nextPointer;
                marshalledCreateInfo->Format = format;
                marshalledCreateInfo->YcbcrModel = ycbcrModel;
                marshalledCreateInfo->YcbcrRange = ycbcrRange;
                marshalledCreateInfo->Components = components;
                marshalledCreateInfo->XChromaOffset = xChromaOffset;
                marshalledCreateInfo->YChromaOffset = yChromaOffset;
                marshalledCreateInfo->ChromaFilter = chromaFilter;
                marshalledCreateInfo->ForceExplicitReconstruction = forceExplicitReconstruction;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.VkDeviceCreateSamplerYcbcrConversionDelegate commandDelegate = commandCache.Cache.vkCreateSamplerYcbcrConversion;
                Result methodResult = commandDelegate(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledYcbcrConversion);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.SamplerYcbcrConversion(this, marshalledYcbcrConversion);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="descriptorUpdateEntries">
        /// </param>
        public unsafe SharpVk.DescriptorUpdateTemplate CreateDescriptorUpdateTemplate(ArrayProxy<SharpVk.DescriptorUpdateTemplateEntry>? descriptorUpdateEntries, SharpVk.DescriptorUpdateTemplateType templateType, SharpVk.DescriptorSetLayout descriptorSetLayout, SharpVk.PipelineBindPoint pipelineBindPoint, SharpVk.PipelineLayout pipelineLayout, uint set, SharpVk.DescriptorUpdateTemplateCreateFlags? flags = default(SharpVk.DescriptorUpdateTemplateCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.DescriptorUpdateTemplate result = default(SharpVk.DescriptorUpdateTemplate);
                SharpVk.Interop.DescriptorUpdateTemplateCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.DescriptorUpdateTemplateCreateInfo*);
                void* nextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.DescriptorUpdateTemplate marshalledDescriptorUpdateTemplate = default(SharpVk.Interop.DescriptorUpdateTemplate);
                marshalledCreateInfo = (SharpVk.Interop.DescriptorUpdateTemplateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorUpdateTemplateCreateInfo>());
                marshalledCreateInfo->Next = nextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.DescriptorUpdateTemplateCreateFlags);
                }
                marshalledCreateInfo->DescriptorUpdateEntryCount = (uint)(Interop.HeapUtil.GetLength(descriptorUpdateEntries));
                if (descriptorUpdateEntries.IsNull())
                {
                    marshalledCreateInfo->DescriptorUpdateEntries = null;
                }
                else
                {
                    if (descriptorUpdateEntries.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->DescriptorUpdateEntries = (SharpVk.DescriptorUpdateTemplateEntry*)(Interop.HeapUtil.Allocate<SharpVk.DescriptorUpdateTemplateEntry>());
                        *(SharpVk.DescriptorUpdateTemplateEntry*)(marshalledCreateInfo->DescriptorUpdateEntries) = descriptorUpdateEntries.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.DescriptorUpdateTemplateEntry*)(Interop.HeapUtil.AllocateAndClear<SharpVk.DescriptorUpdateTemplateEntry>(Interop.HeapUtil.GetLength(descriptorUpdateEntries.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(descriptorUpdateEntries.Value)); index++)
                        {
                            fieldPointer[index] = descriptorUpdateEntries.Value[index];
                        }
                        marshalledCreateInfo->DescriptorUpdateEntries = fieldPointer;
                    }
                }
                marshalledCreateInfo->TemplateType = templateType;
                marshalledCreateInfo->DescriptorSetLayout = descriptorSetLayout?.handle ?? default(SharpVk.Interop.DescriptorSetLayout);
                marshalledCreateInfo->PipelineBindPoint = pipelineBindPoint;
                marshalledCreateInfo->PipelineLayout = pipelineLayout?.handle ?? default(SharpVk.Interop.PipelineLayout);
                marshalledCreateInfo->Set = set;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.VkDeviceCreateDescriptorUpdateTemplateDelegate commandDelegate = commandCache.Cache.vkCreateDescriptorUpdateTemplate;
                Result methodResult = commandDelegate(this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledDescriptorUpdateTemplate);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.DescriptorUpdateTemplate(this, marshalledDescriptorUpdateTemplate);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe void UpdateDescriptorSetWithTemplate(SharpVk.DescriptorSet descriptorSet, SharpVk.DescriptorUpdateTemplate descriptorUpdateTemplate, IntPtr data)
        {
            try
            {
                SharpVk.Interop.VkDeviceUpdateDescriptorSetWithTemplateDelegate commandDelegate = commandCache.Cache.vkUpdateDescriptorSetWithTemplate;
                commandDelegate(this.handle, descriptorSet?.handle ?? default(SharpVk.Interop.DescriptorSet), descriptorUpdateTemplate?.handle ?? default(SharpVk.Interop.DescriptorUpdateTemplate), data.ToPointer());
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe SharpVk.DescriptorSetLayoutSupport GetDescriptorSetLayoutSupport(SharpVk.DescriptorSetLayoutCreateInfo createInfo)
        {
            try
            {
                SharpVk.DescriptorSetLayoutSupport result = default(SharpVk.DescriptorSetLayoutSupport);
                SharpVk.Interop.DescriptorSetLayoutCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.DescriptorSetLayoutCreateInfo*);
                SharpVk.Interop.DescriptorSetLayoutSupport marshalledSupport = default(SharpVk.Interop.DescriptorSetLayoutSupport);
                marshalledCreateInfo = (SharpVk.Interop.DescriptorSetLayoutCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DescriptorSetLayoutCreateInfo>());
                createInfo.MarshalTo(marshalledCreateInfo);
                SharpVk.Interop.VkDeviceGetDescriptorSetLayoutSupportDelegate commandDelegate = commandCache.Cache.vkGetDescriptorSetLayoutSupport;
                commandDelegate(this.handle, marshalledCreateInfo, &marshalledSupport);
                result = SharpVk.DescriptorSetLayoutSupport.MarshalFrom(&marshalledSupport);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            this.Destroy();
        }
    }
}
