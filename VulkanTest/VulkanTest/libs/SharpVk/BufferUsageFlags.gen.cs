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
    /// Bitmask specifying allowed usage of a buffer.
    /// </summary>
    [System.Flags]
    public enum BufferUsageFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// Indicates that the buffer can be used as the source of a _transfer
        /// command_ (see the definition of PipelineStage.Transfer).
        /// </summary>
        TransferSource = 1 << 0, 
        
        /// <summary>
        /// Indicates that the buffer can be used as the destination of a
        /// transfer command.
        /// </summary>
        TransferDestination = 1 << 1, 
        
        /// <summary>
        /// Indicates that the buffer can be used to create a BufferView
        /// suitable for occupying a DescriptorSet slot of type
        /// DescriptorType.UniformTexelBuffer.
        /// </summary>
        UniformTexelBuffer = 1 << 2, 
        
        /// <summary>
        /// Indicates that the buffer can be used to create a BufferView
        /// suitable for occupying a DescriptorSet slot of type
        /// StorageTexelBuffer.
        /// </summary>
        StorageTexelBuffer = 1 << 3, 
        
        /// <summary>
        /// Indicates that the buffer can be used in a DescriptorBufferInfo
        /// suitable for occupying a DescriptorSet slot either of type
        /// DescriptorType.UniformBuffer or
        /// DescriptorType.UniformBufferDynamic.
        /// </summary>
        UniformBuffer = 1 << 4, 
        
        /// <summary>
        /// Indicates that the buffer can be used in a DescriptorBufferInfo
        /// suitable for occupying a DescriptorSet slot either of type
        /// StorageBuffer or StorageBufferDynamic.
        /// </summary>
        StorageBuffer = 1 << 5, 
        
        /// <summary>
        /// Indicates that the buffer is suitable for passing as the buffer
        /// parameter to CommandBuffer.BindIndexBuffer.
        /// </summary>
        IndexBuffer = 1 << 6, 
        
        /// <summary>
        /// Indicates that the buffer is suitable for passing as an element of
        /// the pBuffers array to CommandBuffer.BindVertexBuffers.
        /// </summary>
        VertexBuffer = 1 << 7, 
        
        /// <summary>
        /// Indicates that the buffer is suitable for passing as the buffer
        /// parameter to CommandBuffer.DrawIndirect,
        /// CommandBuffer.DrawIndexedIndirect, or
        /// CommandBuffer.DispatchIndirect. It is also suitable for passing as
        /// the buffer member of IndirectCommandsTokenNVX, or
        /// sequencesCountBuffer or sequencesIndexBuffer member of
        /// CmdProcessCommandsInfoNVX
        /// </summary>
        IndirectBuffer = 1 << 8, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved14 = 1 << 14, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved13 = 1 << 13, 
        
        /// <summary>
        /// 
        /// </summary>
        TransformFeedbackBuffer = 1 << 11, 
        
        /// <summary>
        /// 
        /// </summary>
        TransformFeedbackCounterBuffer = 1 << 12, 
        
        /// <summary>
        /// 
        /// </summary>
        ConditionalRendering = 1 << 9, 
        
        /// <summary>
        /// 
        /// </summary>
        RayTracing = 1 << 10, 
    }
}
