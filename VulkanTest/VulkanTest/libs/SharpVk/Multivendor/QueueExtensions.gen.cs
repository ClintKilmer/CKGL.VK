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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// 
    /// </summary>
    public static class QueueExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The Queue handle to extend.
        /// </param>
        public static unsafe void BeginDebugUtilsLabel(this SharpVk.Queue extendedHandle, SharpVk.Multivendor.DebugUtilsLabel labelInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.DebugUtilsLabel* marshalledLabelInfo = default(SharpVk.Interop.Multivendor.DebugUtilsLabel*);
                commandCache = extendedHandle.commandCache;
                marshalledLabelInfo = (SharpVk.Interop.Multivendor.DebugUtilsLabel*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DebugUtilsLabel>());
                labelInfo.MarshalTo(marshalledLabelInfo);
                SharpVk.Interop.Multivendor.VkQueueBeginDebugUtilsLabelDelegate commandDelegate = commandCache.Cache.vkQueueBeginDebugUtilsLabelEXT;
                commandDelegate(extendedHandle.handle, marshalledLabelInfo);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The Queue handle to extend.
        /// </param>
        public static unsafe void EndDebugUtilsLabel(this SharpVk.Queue extendedHandle)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkQueueEndDebugUtilsLabelDelegate commandDelegate = commandCache.Cache.vkQueueEndDebugUtilsLabelEXT;
                commandDelegate(extendedHandle.handle);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The Queue handle to extend.
        /// </param>
        public static unsafe void InsertDebugUtilsLabel(this SharpVk.Queue extendedHandle, SharpVk.Multivendor.DebugUtilsLabel labelInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Multivendor.DebugUtilsLabel* marshalledLabelInfo = default(SharpVk.Interop.Multivendor.DebugUtilsLabel*);
                commandCache = extendedHandle.commandCache;
                marshalledLabelInfo = (SharpVk.Interop.Multivendor.DebugUtilsLabel*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DebugUtilsLabel>());
                labelInfo.MarshalTo(marshalledLabelInfo);
                SharpVk.Interop.Multivendor.VkQueueInsertDebugUtilsLabelDelegate commandDelegate = commandCache.Cache.vkQueueInsertDebugUtilsLabelEXT;
                commandDelegate(extendedHandle.handle, marshalledLabelInfo);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
