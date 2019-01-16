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

namespace SharpVk.NVidia.Experimental
{
    /// <summary>
    /// Bitmask specifying allowed usage of a indirect commands layout.
    /// </summary>
    [System.Flags]
    public enum IndirectCommandsLayoutUsageFlags
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// Indicates that the processing of sequences can happen at an
        /// implementation-dependent order, which is not guaranteed to be
        /// coherent across multiple invocations.
        /// </summary>
        UnorderedSequences = 1 << 0, 
        
        /// <summary>
        /// Indicates that there is likely a high difference between allocated
        /// number of sequences and actually used.
        /// </summary>
        SparseSequences = 1 << 1, 
        
        /// <summary>
        /// Indicates that there is likely many draw or dispatch calls that are
        /// zero-sized (zero grid dimension, no primitives to render).
        /// </summary>
        EmptyExecutions = 1 << 2, 
        
        /// <summary>
        /// Indicates that the input data for the sequences is not implicitly
        /// indexed from 0..sequencesUsed but a user provided Buffer encoding
        /// the index is provided.
        /// </summary>
        IndexedSequences = 1 << 3, 
    }
}
