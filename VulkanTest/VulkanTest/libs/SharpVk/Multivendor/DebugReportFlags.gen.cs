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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// Bitmask specifying events which cause a debug report callback.
    /// </summary>
    [System.Flags]
    public enum DebugReportFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// Indicates an informational message such as resource details that
        /// may be handy when debugging an application.
        /// </summary>
        Information = 1 << 0, 
        
        /// <summary>
        /// Indicates use of Vulkan that may expose an app bug. Such cases may
        /// not be immediately harmful, such as a fragment shader outputting to
        /// a location with no attachment. Other cases may point to behavior
        /// that is almost certainly bad when unintended such as using an image
        /// whose memory has not been filled. In general if you see a warning
        /// but you know that the behavior is intended/desired, then simply
        /// ignore the warning.
        /// </summary>
        Warning = 1 << 1, 
        
        /// <summary>
        /// Indicates a potentially non-optimal use of Vulkan. E.g. using
        /// flink:vkCmdClearColorImage when a RenderPass load_op would have
        /// worked.
        /// </summary>
        PerformanceWarning = 1 << 2, 
        
        /// <summary>
        /// Indicates an error that may cause undefined results, including an
        /// application crash.
        /// </summary>
        Error = 1 << 3, 
        
        /// <summary>
        /// Indicates diagnostic information from the loader and layers. -- +
        /// </summary>
        Debug = 1 << 4, 
    }
}
