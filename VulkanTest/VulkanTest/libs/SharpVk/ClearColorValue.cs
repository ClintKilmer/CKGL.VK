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
    /// Structure specifying a clear color value.
    /// </para>
    /// <para>
    /// The four array elements of the clear color map to R, G, B, and A
    /// components of image formats, in order.
    /// </para>
    /// <para>
    /// If the image has more than one sample, the same value is written to all
    /// samples for any pixels being cleared.
    /// </para>
    /// </summary>
    public partial struct ClearColorValue
    {
        /// <summary>
        /// 
        /// </summary>
        public unsafe ClearColorValue(float r, float g, float b, float a)
        {
            element_0 = r;
            element_1 = g;
            element_2 = b;
            element_3 = a;
        }

        /// <summary>
        /// 
        /// </summary>
        public unsafe ClearColorValue(int r, int g, int b, int a)
        {
            element_0 = r;
            element_1 = g;
            element_2 = b;
            element_3 = a;
        }

        /// <summary>
        /// 
        /// </summary>
        public unsafe ClearColorValue(uint r, uint g, uint b, uint a)
        {
            element_0 = r;
            element_1 = g;
            element_2 = b;
            element_3 = a;
        }

        private ColorElement element_0;

        private ColorElement element_1;

        private ColorElement element_2;

        private ColorElement element_3;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator ClearColorValue((float, float, float, float) value)
        {
            return new ClearColorValue(value.Item1, value.Item2, value.Item3, value.Item4);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator ClearColorValue((int, int, int, int) value)
        {
            return new ClearColorValue(value.Item1, value.Item2, value.Item3, value.Item4);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator ClearColorValue((uint, uint, uint, uint) value)
        {
            return new ClearColorValue(value.Item1, value.Item2, value.Item3, value.Item4);
        }

        /// <summary>
        /// 
        /// </summary>
        [StructLayout(LayoutKind.Explicit)]
        public struct ColorElement
        {
            /// <summary>
            /// 
            /// </summary>
            [FieldOffset(0)]
            public float Float32;

            /// <summary>
            /// 
            /// </summary>
            [FieldOffset(0)]
            public int Int32;

            /// <summary>
            /// 
            /// </summary>
            [FieldOffset(0)]
            public uint UInt32;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator ColorElement(float value)
            {
                return new ColorElement
                {
                    Float32 = value
                };
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator ColorElement(int value)
            {
                return new ColorElement
                {
                    Int32 = value
                };
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator ColorElement(uint value)
            {
                return new ColorElement
                {
                    UInt32 = value
                };
            }
        }
    }
}
