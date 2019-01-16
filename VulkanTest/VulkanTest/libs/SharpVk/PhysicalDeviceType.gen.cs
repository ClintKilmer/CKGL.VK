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
    /// Supported physical device types.
    /// </summary>
    public enum PhysicalDeviceType
    {
        /// <summary>
        /// The device does not match any other available types.
        /// </summary>
        Other = 0, 
        
        /// <summary>
        /// The device is typically one embedded in or tightly coupled with the
        /// host.
        /// </summary>
        IntegratedGpu = 1, 
        
        /// <summary>
        /// The device is typically a separate processor connected to the host
        /// via an interlink.
        /// </summary>
        DiscreteGpu = 2, 
        
        /// <summary>
        /// The device is typically a virtual node in a virtualization
        /// environment.
        /// </summary>
        VirtualGpu = 3, 
        
        /// <summary>
        /// The device is typically running on the same processors as the host.
        /// </summary>
        Cpu = 4, 
    }
}
