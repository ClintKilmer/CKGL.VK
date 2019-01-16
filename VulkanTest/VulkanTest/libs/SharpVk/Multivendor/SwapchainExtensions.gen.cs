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
    public static class SwapchainExtensions
    {
        /// <summary>
        /// Query the current value of a surface counter.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Swapchain handle to extend.
        /// </param>
        public static unsafe ulong GetCounter(this SharpVk.Khronos.Swapchain extendedHandle, SharpVk.Multivendor.SurfaceCounterFlags counter)
        {
            try
            {
                ulong result = default(ulong);
                CommandCache commandCache = default(CommandCache);
                ulong marshalledCounterValue = default(ulong);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Multivendor.VkSwapchainKHRGetCounterDelegate commandDelegate = commandCache.Cache.vkGetSwapchainCounterEXT;
                Result methodResult = commandDelegate(extendedHandle.parent.handle, extendedHandle.handle, counter, &marshalledCounterValue);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledCounterValue;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
