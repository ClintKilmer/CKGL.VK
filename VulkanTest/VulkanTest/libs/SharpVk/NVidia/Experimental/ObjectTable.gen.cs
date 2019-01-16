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

namespace SharpVk.NVidia.Experimental
{
    /// <summary>
    /// Opaque handle to an object table.
    /// </summary>
    public partial class ObjectTable
        : IDisposable
    {
        internal readonly SharpVk.Interop.NVidia.Experimental.ObjectTable handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly SharpVk.Device parent; 
        
        internal ObjectTable(SharpVk.Device parent, SharpVk.Interop.NVidia.Experimental.ObjectTable handle)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.NVidia.Experimental.ObjectTable RawHandle => this.handle;
        
        /// <summary>
        /// Destroy a object table.
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
                SharpVk.Interop.NVidia.Experimental.VkObjectTableNVXDestroyDelegate commandDelegate = commandCache.Cache.vkDestroyObjectTableNVX;
                commandDelegate(this.parent.handle, this.handle, marshalledAllocator);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objectTableEntries">
        /// </param>
        /// <param name="objectIndices">
        /// </param>
        public unsafe void RegisterObjects(ArrayProxy<SharpVk.NVidia.Experimental.ObjectTableEntry>? objectTableEntries, ArrayProxy<uint>? objectIndices)
        {
            try
            {
                SharpVk.NVidia.Experimental.ObjectTableEntry** marshalledObjectTableEntries = default(SharpVk.NVidia.Experimental.ObjectTableEntry**);
                SharpVk.NVidia.Experimental.ObjectTableEntry* semiMarshalledObjectTableEntries = default(SharpVk.NVidia.Experimental.ObjectTableEntry*);
                uint* marshalledObjectIndices = default(uint*);
                if (objectTableEntries.IsNull())
                {
                    marshalledObjectTableEntries = null;
                }
                else
                {
                    if (objectTableEntries.Value.Contents == ProxyContents.Single)
                    {
                        semiMarshalledObjectTableEntries = (SharpVk.NVidia.Experimental.ObjectTableEntry*)(Interop.HeapUtil.Allocate<SharpVk.NVidia.Experimental.ObjectTableEntry>());
                        *(SharpVk.NVidia.Experimental.ObjectTableEntry*)(semiMarshalledObjectTableEntries) = objectTableEntries.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.NVidia.Experimental.ObjectTableEntry*)(Interop.HeapUtil.AllocateAndClear<SharpVk.NVidia.Experimental.ObjectTableEntry>(Interop.HeapUtil.GetLength(objectTableEntries.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(objectTableEntries.Value)); index++)
                        {
                            fieldPointer[index] = objectTableEntries.Value[index];
                        }
                        semiMarshalledObjectTableEntries = fieldPointer;
                        var marshalledFieldPointer = (SharpVk.NVidia.Experimental.ObjectTableEntry**)(Interop.HeapUtil.AllocateAndClear<IntPtr>(Interop.HeapUtil.GetLength(objectTableEntries.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(objectTableEntries.Value)); index++)
                        {
                            marshalledFieldPointer[index] = &semiMarshalledObjectTableEntries[index];
                        }
                        marshalledObjectTableEntries = marshalledFieldPointer;
                    }
                }
                if (objectIndices.IsNull())
                {
                    marshalledObjectIndices = null;
                }
                else
                {
                    if (objectIndices.Value.Contents == ProxyContents.Single)
                    {
                        marshalledObjectIndices = (uint*)(Interop.HeapUtil.Allocate<uint>());
                        *(uint*)(marshalledObjectIndices) = objectIndices.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(Interop.HeapUtil.GetLength(objectIndices.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(objectIndices.Value)); index++)
                        {
                            fieldPointer[index] = objectIndices.Value[index];
                        }
                        marshalledObjectIndices = fieldPointer;
                    }
                }
                SharpVk.Interop.NVidia.Experimental.VkObjectTableNVXRegisterObjectsDelegate commandDelegate = commandCache.Cache.vkRegisterObjectsNVX;
                Result methodResult = commandDelegate(this.parent.handle, this.handle, (uint)(Interop.HeapUtil.GetLength(objectTableEntries)), marshalledObjectTableEntries, marshalledObjectIndices);
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
        /// <param name="objectEntryTypes">
        /// </param>
        /// <param name="objectIndices">
        /// </param>
        public unsafe void UnregisterObjects(ArrayProxy<SharpVk.NVidia.Experimental.ObjectEntryType>? objectEntryTypes, ArrayProxy<uint>? objectIndices)
        {
            try
            {
                SharpVk.NVidia.Experimental.ObjectEntryType* marshalledObjectEntryTypes = default(SharpVk.NVidia.Experimental.ObjectEntryType*);
                uint* marshalledObjectIndices = default(uint*);
                if (objectEntryTypes.IsNull())
                {
                    marshalledObjectEntryTypes = null;
                }
                else
                {
                    if (objectEntryTypes.Value.Contents == ProxyContents.Single)
                    {
                        marshalledObjectEntryTypes = (SharpVk.NVidia.Experimental.ObjectEntryType*)(Interop.HeapUtil.Allocate<SharpVk.NVidia.Experimental.ObjectEntryType>());
                        *(SharpVk.NVidia.Experimental.ObjectEntryType*)(marshalledObjectEntryTypes) = objectEntryTypes.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.NVidia.Experimental.ObjectEntryType*)(Interop.HeapUtil.AllocateAndClear<SharpVk.NVidia.Experimental.ObjectEntryType>(Interop.HeapUtil.GetLength(objectEntryTypes.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(objectEntryTypes.Value)); index++)
                        {
                            fieldPointer[index] = objectEntryTypes.Value[index];
                        }
                        marshalledObjectEntryTypes = fieldPointer;
                    }
                }
                if (objectIndices.IsNull())
                {
                    marshalledObjectIndices = null;
                }
                else
                {
                    if (objectIndices.Value.Contents == ProxyContents.Single)
                    {
                        marshalledObjectIndices = (uint*)(Interop.HeapUtil.Allocate<uint>());
                        *(uint*)(marshalledObjectIndices) = objectIndices.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(Interop.HeapUtil.GetLength(objectIndices.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(objectIndices.Value)); index++)
                        {
                            fieldPointer[index] = objectIndices.Value[index];
                        }
                        marshalledObjectIndices = fieldPointer;
                    }
                }
                SharpVk.Interop.NVidia.Experimental.VkObjectTableNVXUnregisterObjectsDelegate commandDelegate = commandCache.Cache.vkUnregisterObjectsNVX;
                Result methodResult = commandDelegate(this.parent.handle, this.handle, (uint)(Interop.HeapUtil.GetLength(objectEntryTypes)), marshalledObjectEntryTypes, marshalledObjectIndices);
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
        public void Dispose()
        {
            this.Destroy();
        }
    }
}
