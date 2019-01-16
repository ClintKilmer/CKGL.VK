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
using System.Runtime.InteropServices;

namespace SharpVk.NVidia
{
    /// <summary>
    /// Structure specifying external image format properties.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ExternalImageFormatProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public ExternalImageFormatProperties(SharpVk.ImageFormatProperties imageFormatProperties, SharpVk.NVidia.ExternalMemoryFeatureFlags externalMemoryFeatures, SharpVk.NVidia.ExternalMemoryHandleTypeFlags exportFromImportedHandleTypes, SharpVk.NVidia.ExternalMemoryHandleTypeFlags compatibleHandleTypes)
        {
            this.ImageFormatProperties = imageFormatProperties;
            this.ExternalMemoryFeatures = externalMemoryFeatures;
            this.ExportFromImportedHandleTypes = exportFromImportedHandleTypes;
            this.CompatibleHandleTypes = compatibleHandleTypes;
        }
        
        /// <summary>
        /// imageFormatProperties will be filled in as when calling
        /// flink:vkGetPhysicalDeviceImageFormatProperties, but the values
        /// returned may vary depending on the external handle type requested.
        /// </summary>
        public SharpVk.ImageFormatProperties ImageFormatProperties; 
        
        /// <summary>
        /// A bitmask of ExternalMemoryFeatureFlagBitsNV indicating properties
        /// of the external memory handle type
        /// (flink:vkGetPhysicalDeviceExternalImageFormatPropertiesNV::externalHandleType) being
        /// queried, or 0 if the external memory handle type is 0.
        /// </summary>
        public SharpVk.NVidia.ExternalMemoryFeatureFlags ExternalMemoryFeatures; 
        
        /// <summary>
        /// A bitmask of ExternalMemoryHandleTypeFlagBitsNV containing a bit
        /// set for every external handle type that may be used to create
        /// memory from which the handles of the type specified in
        /// flink:vkGetPhysicalDeviceExternalImageFormatPropertiesNV::externalHandleType can
        /// be exported, or 0 if the external memory handle type is 0.
        /// </summary>
        public SharpVk.NVidia.ExternalMemoryHandleTypeFlags ExportFromImportedHandleTypes; 
        
        /// <summary>
        /// A bitmask of ExternalMemoryHandleTypeFlagBitsNV containing a bit
        /// set for every external handle type that may be specified
        /// simultaneously with the handle type specified by
        /// flink:vkGetPhysicalDeviceExternalImageFormatPropertiesNV::externalHandleType when
        /// calling flink:vkAllocateMemory, or 0 if the external memory handle
        /// type is 0. compatibleHandleTypes will always contain
        /// flink:vkGetPhysicalDeviceExternalImageFormatPropertiesNV::externalHandleType
        /// </summary>
        public SharpVk.NVidia.ExternalMemoryHandleTypeFlags CompatibleHandleTypes; 
    }
}
