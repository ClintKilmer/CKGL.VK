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
    /// Layout of image and image subresources.
    /// </summary>
    public enum ImageLayout
    {
        /// <summary>
        /// Supports no device access. This layout must only be used as the
        /// initialLayout member of ImageCreateInfo or AttachmentDescription,
        /// or as the oldLayout in an image transition. When transitioning out
        /// of this layout, the contents of the memory are not guaranteed to be
        /// preserved.
        /// </summary>
        Undefined = 0, 
        
        /// <summary>
        /// Supports all types of device access.
        /// </summary>
        General = 1, 
        
        /// <summary>
        /// Must only be used as a color or resolve attachment in a
        /// Framebuffer. This layout is valid only for image subresources of
        /// images created with the VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT usage
        /// bit enabled.
        /// </summary>
        ColorAttachmentOptimal = 2, 
        
        /// <summary>
        /// Must only be used as a depth/stencil attachment in a Framebuffer.
        /// This layout is valid only for image subresources of images created
        /// with the VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT usage bit
        /// enabled.
        /// </summary>
        DepthStencilAttachmentOptimal = 3, 
        
        /// <summary>
        /// Must only be used as a read-only depth/stencil attachment in a
        /// Framebuffer and/or as a read-only image in a shader (which can be
        /// read as a sampled image, combined image/sampler and/or input
        /// attachment). This layout is valid only for image subresources of
        /// images created with the VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT
        /// usage bit enabled. Only image subresources of images created with
        /// VK_IMAGE_USAGE_SAMPLED_BIT can be used as sampled image or combined
        /// image/sampler in a shader. Similarly, only image subresources of
        /// images created with VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT can be used
        /// as input attachments.
        /// </summary>
        DepthStencilReadOnlyOptimal = 4, 
        
        /// <summary>
        /// Must only be used as a read-only image in a shader (which can be
        /// read as a sampled image, combined image/sampler and/or input
        /// attachment). This layout is valid only for image subresources of
        /// images created with the VK_IMAGE_USAGE_SAMPLED_BIT or
        /// VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT usage bit enabled.
        /// </summary>
        ShaderReadOnlyOptimal = 5, 
        
        /// <summary>
        /// Must only be used as a source image of a transfer command (see the
        /// definition of VK_PIPELINE_STAGE_TRANSFER_BIT). This layout is valid
        /// only for image subresources of images created with the
        /// VK_IMAGE_USAGE_TRANSFER_SRC_BIT usage bit enabled.
        /// </summary>
        TransferSourceOptimal = 6, 
        
        /// <summary>
        /// Must only be used as a destination image of a transfer command.
        /// This layout is valid only for image subresources of images created
        /// with the VK_IMAGE_USAGE_TRANSFER_DST_BIT usage bit enabled.
        /// </summary>
        TransferDestinationOptimal = 7, 
        
        /// <summary>
        /// Supports no device access. This layout must only be used as the
        /// initialLayout member of ImageCreateInfo or AttachmentDescription,
        /// or as the oldLayout in an image transition. When transitioning out
        /// of this layout, the contents of the memory are preserved. This
        /// layout is intended to be used as the initial layout for an image
        /// whose contents are written by the host, and hence the data can be
        /// written to memory immediately, without first executing a layout
        /// transition. Currently, VK_IMAGE_LAYOUT_PREINITIALIZED is only
        /// useful with ImageTiling.Linear images because there is not a
        /// standard layout defined for ImageTiling.Optimal images.
        /// </summary>
        Preinitialized = 8, 
        
        /// <summary>
        /// Must only be used for presenting a presentable image for display. A
        /// swapchain's image must be transitioned to this layout before
        /// calling flink:vkQueuePresentKHR, and must be transitioned away from
        /// this layout after calling flink:vkAcquireNextImageKHR.
        /// </summary>
        PresentSource = 1000001002, 
        
        /// <summary>
        /// 
        /// </summary>
        SharedPresent = 1000111000, 
        
        /// <summary>
        /// 
        /// </summary>
        ShadingRateOptimal = 1000164003, 
        
        /// <summary>
        /// 
        /// </summary>
        FragmentDensityMapOptimal = 1000218000, 
    }
}
