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
    /// 
    /// </summary>
    public static class CommandBufferExtensions
    {
        /// <summary>
        /// Performs the generation of commands on the device.
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        public static unsafe void ProcessCommands(this SharpVk.CommandBuffer extendedHandle, SharpVk.NVidia.Experimental.CommandProcessCommandsInfo processCommandsInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.Experimental.CommandProcessCommandsInfo* marshalledProcessCommandsInfo = default(SharpVk.Interop.NVidia.Experimental.CommandProcessCommandsInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledProcessCommandsInfo = (SharpVk.Interop.NVidia.Experimental.CommandProcessCommandsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.Experimental.CommandProcessCommandsInfo>());
                processCommandsInfo.MarshalTo(marshalledProcessCommandsInfo);
                SharpVk.Interop.NVidia.Experimental.VkCommandBufferProcessCommandsDelegate commandDelegate = commandCache.Cache.vkCmdProcessCommandsNVX;
                commandDelegate(extendedHandle.handle, marshalledProcessCommandsInfo);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Perform a reservation of command buffer space.
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        public static unsafe void ReserveSpaceForCommands(this SharpVk.CommandBuffer extendedHandle, SharpVk.NVidia.Experimental.CommandReserveSpaceForCommandsInfo reserveSpaceInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.Experimental.CommandReserveSpaceForCommandsInfo* marshalledReserveSpaceInfo = default(SharpVk.Interop.NVidia.Experimental.CommandReserveSpaceForCommandsInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledReserveSpaceInfo = (SharpVk.Interop.NVidia.Experimental.CommandReserveSpaceForCommandsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.Experimental.CommandReserveSpaceForCommandsInfo>());
                reserveSpaceInfo.MarshalTo(marshalledReserveSpaceInfo);
                SharpVk.Interop.NVidia.Experimental.VkCommandBufferReserveSpaceForCommandsDelegate commandDelegate = commandCache.Cache.vkCmdReserveSpaceForCommandsNVX;
                commandDelegate(extendedHandle.handle, marshalledReserveSpaceInfo);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
