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

namespace SharpVk.Khronos
{
    /// <summary>
    /// Presentation mode supported for a surface.
    /// </summary>
    public enum PresentMode
    {
        /// <summary>
        /// The presentation engine does not wait for a vertical blanking
        /// period to update the current image, meaning this mode may result in
        /// visible tearing. No internal queuing of presentation requests is
        /// needed, as the requests are applied immediately.
        /// </summary>
        Immediate = 0, 
        
        /// <summary>
        /// The presentation engine waits for the next vertical blanking period
        /// to update the current image. Tearing cannot: be observed. An
        /// internal single-entry queue is used to hold pending presentation
        /// requests. If the queue is full when a new presentation request is
        /// received, the new request replaces the existing entry, and any
        /// images associated with the prior entry become available for re-use
        /// by the application. One request is removed from the queue and
        /// processed during each vertical blanking period in which the queue
        /// is non-empty.
        /// </summary>
        Mailbox = 1, 
        
        /// <summary>
        /// The presentation engine waits for the next vertical blanking period
        /// to update the current image. Tearing cannot: be observed. An
        /// internal queue is used to hold pending presentation requests. New
        /// requests are appended to the end of the queue, and one request is
        /// removed from the beginning of the queue and processed during each
        /// vertical blanking period in which the queue is non-empty. This is
        /// the only value of presentMode that is required: to be supported.
        /// </summary>
        Fifo = 2, 
        
        /// <summary>
        /// The presentation engine generally waits for the next vertical
        /// blanking period to update the current image. If a vertical blanking
        /// period has already passed since the last update of the current
        /// image then the presentation engine does not wait for another
        /// vertical blanking period for the update, meaning this mode may
        /// result in visible tearing in this case. This mode is useful for
        /// reducing visual stutter with an application that will mostly
        /// present a new image before the next vertical blanking period, but
        /// may occasionally be late, and present a new image just after the
        /// next vertical blanking period. An internal queue is used to hold
        /// pending presentation requests. New requests are appended to the end
        /// of the queue, and one request is removed from the beginning of the
        /// queue and processed during or after each vertical blanking period
        /// in which the queue is non-empty.
        /// </summary>
        FifoRelaxed = 3, 
        
        /// <summary>
        /// 
        /// </summary>
        SharedDemandRefresh = 1000111000, 
        
        /// <summary>
        /// 
        /// </summary>
        SharedContinuousRefresh = 1000111001, 
    }
}
