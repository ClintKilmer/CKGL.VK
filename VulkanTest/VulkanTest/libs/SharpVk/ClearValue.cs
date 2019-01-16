// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2017
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

using System.Runtime.InteropServices;

namespace SharpVk
{
    /// <summary>
    /// <para>
    /// Structure specifying a clear value.
    /// </para>
    /// <para>
    /// This union is used where part of the API requires either color or
    /// depth/stencil clear values, depending on the attachment, and defines
    /// the initial clear values in the slink:VkRenderPassBeginInfo structure.
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct ClearValue
    {
        [FieldOffset(0)]
        private ClearColorValue color;

        [FieldOffset(0)]
        private ClearDepthStencilValue depthStencil;

        /// <summary>
        /// Implicit conversion of ClearColorValue to ClearValue.
        /// </summary>
        /// <param name="color">
        /// Specifies the color image clear values to use when clearing a color
        /// image or attachment.
        /// </param>
        public static implicit operator ClearValue(ClearColorValue color)
        {
            return new ClearValue
            {
                color = color
            };
        }

        /// <summary>
        /// Implicit conversion of ClearDepthStencilValue to ClearValue.
        /// </summary>
        /// <param name="depthStencil">
        /// Specifies the depth and stencil clear values to use when clearing a
        /// depth/stencil image or attachment.
        /// </param>
        public static implicit operator ClearValue(ClearDepthStencilValue depthStencil)
        {
            return new ClearValue
            {
                depthStencil = depthStencil
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator ClearValue((float, float, float, float) value)
        {
            return new ClearColorValue(value.Item1, value.Item2, value.Item3, value.Item4);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator ClearValue((int, int, int, int) value)
        {
            return new ClearColorValue(value.Item1, value.Item2, value.Item3, value.Item4);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator ClearValue((uint, uint, uint, uint) value)
        {
            return new ClearColorValue(value.Item1, value.Item2, value.Item3, value.Item4);
        }
    }
}
