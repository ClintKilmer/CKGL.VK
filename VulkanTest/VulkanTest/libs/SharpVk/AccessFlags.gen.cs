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
    /// Bitmask specifying memory access types that will participate in a
    /// memory dependency.
    /// </summary>
    [System.Flags]
    public enum AccessFlags
    {
        /// <summary>
        /// No access type specified.
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// Read access to an indirect command structure read as part of an
        /// indirect drawing or dispatch command.
        /// </summary>
        IndirectCommandRead = 1 << 0, 
        
        /// <summary>
        /// Read access to an index buffer as part of an indexed drawing
        /// command, bound by CommandBuffer.BindIndexBuffer.
        /// </summary>
        IndexRead = 1 << 1, 
        
        /// <summary>
        /// Read access to a vertex buffer as part of a drawing command, bound
        /// by CommandBuffer.BindVertexBuffers.
        /// </summary>
        VertexAttributeRead = 1 << 2, 
        
        /// <summary>
        /// Read access to a uniform buffer.
        /// </summary>
        UniformRead = 1 << 3, 
        
        /// <summary>
        /// Read access to an input attachment within a renderpass during
        /// fragment shading.
        /// </summary>
        InputAttachmentRead = 1 << 4, 
        
        /// <summary>
        /// Read access to a storage buffer, uniform texel buffer, storage
        /// texel buffer, sampled image, or storage image.
        /// </summary>
        ShaderRead = 1 << 5, 
        
        /// <summary>
        /// Write access to a storage buffer, storage texel buffer, or storage
        /// image.
        /// </summary>
        ShaderWrite = 1 << 6, 
        
        /// <summary>
        /// Read access to a color attachment, such as via blending, logic
        /// operations, or via certain subpass load operations.
        /// </summary>
        ColorAttachmentRead = 1 << 7, 
        
        /// <summary>
        /// Write access to a color or resolve attachment during a render pass
        /// or via certain subpass load and store operations.
        /// </summary>
        ColorAttachmentWrite = 1 << 8, 
        
        /// <summary>
        /// Read access to a depth/stencil attachment, via depth or stencil
        /// operations or via certain subpass load operations.
        /// </summary>
        DepthStencilAttachmentRead = 1 << 9, 
        
        /// <summary>
        /// Write access to a depth/stencil attachment, via depth or stencil
        /// operations or via certain subpass load and store operations.
        /// </summary>
        DepthStencilAttachmentWrite = 1 << 10, 
        
        /// <summary>
        /// Read access to an image or buffer in a copy operation.
        /// </summary>
        TransferRead = 1 << 11, 
        
        /// <summary>
        /// Write access to an image or buffer in a clear or copy operation.
        /// </summary>
        TransferWrite = 1 << 12, 
        
        /// <summary>
        /// Read access by a host operation. Accesses of this type are not
        /// performed through a resource, but directly on memory.
        /// </summary>
        HostRead = 1 << 13, 
        
        /// <summary>
        /// Write access by a host operation. Accesses of this type are not
        /// performed through a resource, but directly on memory.
        /// </summary>
        HostWrite = 1 << 14, 
        
        /// <summary>
        /// Read access via non-specific entities. These entities include the
        /// Vulkan device and host, but may also include entities external to
        /// the Vulkan device or otherwise not part of the core Vulkan
        /// pipeline. When included in a destination access mask, makes all
        /// available writes visible to all future read accesses on entities
        /// known to the Vulkan device.
        /// </summary>
        MemoryRead = 1 << 15, 
        
        /// <summary>
        /// Write access via non-specific entities. These entities include the
        /// Vulkan device and host, but may also include entities external to
        /// the Vulkan device or otherwise not part of the core Vulkan
        /// pipeline. When included in a source access mask, all writes that
        /// are performed by entities known to the Vulkan device are made
        /// available. When included in a destination access mask, makes all
        /// available writes visible to all future write accesses on entities
        /// known to the Vulkan device.
        /// </summary>
        MemoryWrite = 1 << 16, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved30 = 1 << 30, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved31 = 1 << 31, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved28 = 1 << 28, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved29 = 1 << 29, 
        
        /// <summary>
        /// 
        /// </summary>
        TransformFeedbackWrite = 1 << 25, 
        
        /// <summary>
        /// 
        /// </summary>
        TransformFeedbackCounterRead = 1 << 26, 
        
        /// <summary>
        /// 
        /// </summary>
        TransformFeedbackCounterWrite = 1 << 27, 
        
        /// <summary>
        /// 
        /// </summary>
        ConditionalRenderingRead = 1 << 20, 
        
        /// <summary>
        /// Reads from Buffer inputs to CommandBuffer.ProcessCommands.
        /// </summary>
        CommandProcessRead = 1 << 17, 
        
        /// <summary>
        /// Writes to the target command buffer in
        /// CommandBuffer.ProcessCommands.
        /// </summary>
        CommandProcessWrite = 1 << 18, 
        
        /// <summary>
        /// 
        /// </summary>
        ColorAttachmentReadNoncoherent = 1 << 19, 
        
        /// <summary>
        /// 
        /// </summary>
        ShadingRateImageRead = 1 << 23, 
        
        /// <summary>
        /// 
        /// </summary>
        AccelerationStructureRead = 1 << 21, 
        
        /// <summary>
        /// 
        /// </summary>
        AccelerationStructureWrite = 1 << 22, 
        
        /// <summary>
        /// Specifies read access to a fragment density map attachment during
        /// dynamic fragment density map operations.
        /// </summary>
        FragmentDensityMapRead = 1 << 24, 
    }
}
