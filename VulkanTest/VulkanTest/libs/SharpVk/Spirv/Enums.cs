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

// This file was automatically generated and should not be edited directly.

namespace SharpVk.Spirv
{
    /// <summary>
    /// 
    /// </summary>
    public enum SourceLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        Unknown = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        ESSL = 1, 
        
        /// <summary>
        /// 
        /// </summary>
        GLSL = 2, 
        
        /// <summary>
        /// 
        /// </summary>
        OpenCL_C = 3, 
        
        /// <summary>
        /// 
        /// </summary>
        OpenCL_CPP = 4, 
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum ExecutionModel
    {
        /// <summary>
        /// 
        /// </summary>
        Vertex = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        TessellationControl = 1, 
        
        /// <summary>
        /// 
        /// </summary>
        TessellationEvaluation = 2, 
        
        /// <summary>
        /// 
        /// </summary>
        Geometry = 3, 
        
        /// <summary>
        /// 
        /// </summary>
        Fragment = 4, 
        
        /// <summary>
        /// 
        /// </summary>
        GLCompute = 5, 
        
        /// <summary>
        /// 
        /// </summary>
        Kernel = 6, 
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum AddressingModel
    {
        /// <summary>
        /// 
        /// </summary>
        Logical = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Physical32 = 1, 
        
        /// <summary>
        /// 
        /// </summary>
        Physical64 = 2, 
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum MemoryModel
    {
        /// <summary>
        /// 
        /// </summary>
        Simple = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        GLSL450 = 1, 
        
        /// <summary>
        /// 
        /// </summary>
        OpenCL = 2, 
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum ExecutionMode
    {
        /// <summary>
        /// 
        /// </summary>
        Invocations = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        SpacingEqual = 1, 
        
        /// <summary>
        /// 
        /// </summary>
        SpacingFractionalEven = 2, 
        
        /// <summary>
        /// 
        /// </summary>
        SpacingFractionalOdd = 3, 
        
        /// <summary>
        /// 
        /// </summary>
        VertexOrderCw = 4, 
        
        /// <summary>
        /// 
        /// </summary>
        VertexOrderCcw = 5, 
        
        /// <summary>
        /// 
        /// </summary>
        PixelCenterInteger = 6, 
        
        /// <summary>
        /// 
        /// </summary>
        OriginUpperLeft = 7, 
        
        /// <summary>
        /// 
        /// </summary>
        OriginLowerLeft = 8, 
        
        /// <summary>
        /// 
        /// </summary>
        EarlyFragmentTests = 9, 
        
        /// <summary>
        /// 
        /// </summary>
        PointMode = 10, 
        
        /// <summary>
        /// 
        /// </summary>
        Xfb = 11, 
        
        /// <summary>
        /// 
        /// </summary>
        DepthReplacing = 12, 
        
        /// <summary>
        /// 
        /// </summary>
        DepthGreater = 14, 
        
        /// <summary>
        /// 
        /// </summary>
        DepthLess = 15, 
        
        /// <summary>
        /// 
        /// </summary>
        DepthUnchanged = 16, 
        
        /// <summary>
        /// 
        /// </summary>
        LocalSize = 17, 
        
        /// <summary>
        /// 
        /// </summary>
        LocalSizeHint = 18, 
        
        /// <summary>
        /// 
        /// </summary>
        InputPoints = 19, 
        
        /// <summary>
        /// 
        /// </summary>
        InputLines = 20, 
        
        /// <summary>
        /// 
        /// </summary>
        InputLinesAdjacency = 21, 
        
        /// <summary>
        /// 
        /// </summary>
        Triangles = 22, 
        
        /// <summary>
        /// 
        /// </summary>
        InputTrianglesAdjacency = 23, 
        
        /// <summary>
        /// 
        /// </summary>
        Quads = 24, 
        
        /// <summary>
        /// 
        /// </summary>
        Isolines = 25, 
        
        /// <summary>
        /// 
        /// </summary>
        OutputVertices = 26, 
        
        /// <summary>
        /// 
        /// </summary>
        OutputPoints = 27, 
        
        /// <summary>
        /// 
        /// </summary>
        OutputLineStrip = 28, 
        
        /// <summary>
        /// 
        /// </summary>
        OutputTriangleStrip = 29, 
        
        /// <summary>
        /// 
        /// </summary>
        VecTypeHint = 30, 
        
        /// <summary>
        /// 
        /// </summary>
        ContractionOff = 31, 
        
        /// <summary>
        /// 
        /// </summary>
        Initializer = 33, 
        
        /// <summary>
        /// 
        /// </summary>
        Finalizer = 34, 
        
        /// <summary>
        /// 
        /// </summary>
        SubgroupSize = 35, 
        
        /// <summary>
        /// 
        /// </summary>
        SubgroupsPerWorkgroup = 36, 
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum StorageClass
    {
        /// <summary>
        /// 
        /// </summary>
        UniformConstant = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Input = 1, 
        
        /// <summary>
        /// 
        /// </summary>
        Uniform = 2, 
        
        /// <summary>
        /// 
        /// </summary>
        Output = 3, 
        
        /// <summary>
        /// 
        /// </summary>
        Workgroup = 4, 
        
        /// <summary>
        /// 
        /// </summary>
        CrossWorkgroup = 5, 
        
        /// <summary>
        /// 
        /// </summary>
        Private = 6, 
        
        /// <summary>
        /// 
        /// </summary>
        Function = 7, 
        
        /// <summary>
        /// 
        /// </summary>
        Generic = 8, 
        
        /// <summary>
        /// 
        /// </summary>
        PushConstant = 9, 
        
        /// <summary>
        /// 
        /// </summary>
        AtomicCounter = 10, 
        
        /// <summary>
        /// 
        /// </summary>
        Image = 11, 
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum Dim
    {
        /// <summary>
        /// 
        /// </summary>
        Dim1D = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Dim2D = 1, 
        
        /// <summary>
        /// 
        /// </summary>
        Dim3D = 2, 
        
        /// <summary>
        /// 
        /// </summary>
        Cube = 3, 
        
        /// <summary>
        /// 
        /// </summary>
        Rect = 4, 
        
        /// <summary>
        /// 
        /// </summary>
        Buffer = 5, 
        
        /// <summary>
        /// 
        /// </summary>
        SubpassData = 6, 
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum SamplerAddressingMode
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        ClampToEdge = 1, 
        
        /// <summary>
        /// 
        /// </summary>
        Clamp = 2, 
        
        /// <summary>
        /// 
        /// </summary>
        Repeat = 3, 
        
        /// <summary>
        /// 
        /// </summary>
        RepeatMirrored = 4, 
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum SamplerFilterMode
    {
        /// <summary>
        /// 
        /// </summary>
        Nearest = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Linear = 1, 
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum ImageFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Unknown = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Rgba32f = 1, 
        
        /// <summary>
        /// 
        /// </summary>
        Rgba16f = 2, 
        
        /// <summary>
        /// 
        /// </summary>
        R32f = 3, 
        
        /// <summary>
        /// 
        /// </summary>
        Rgba8 = 4, 
        
        /// <summary>
        /// 
        /// </summary>
        Rgba8Snorm = 5, 
        
        /// <summary>
        /// 
        /// </summary>
        Rg32f = 6, 
        
        /// <summary>
        /// 
        /// </summary>
        Rg16f = 7, 
        
        /// <summary>
        /// 
        /// </summary>
        R11fG11fB10f = 8, 
        
        /// <summary>
        /// 
        /// </summary>
        R16f = 9, 
        
        /// <summary>
        /// 
        /// </summary>
        Rgba16 = 10, 
        
        /// <summary>
        /// 
        /// </summary>
        Rgb10A2 = 11, 
        
        /// <summary>
        /// 
        /// </summary>
        Rg16 = 12, 
        
        /// <summary>
        /// 
        /// </summary>
        Rg8 = 13, 
        
        /// <summary>
        /// 
        /// </summary>
        R16 = 14, 
        
        /// <summary>
        /// 
        /// </summary>
        R8 = 15, 
        
        /// <summary>
        /// 
        /// </summary>
        Rgba16Snorm = 16, 
        
        /// <summary>
        /// 
        /// </summary>
        Rg16Snorm = 17, 
        
        /// <summary>
        /// 
        /// </summary>
        Rg8Snorm = 18, 
        
        /// <summary>
        /// 
        /// </summary>
        R16Snorm = 19, 
        
        /// <summary>
        /// 
        /// </summary>
        R8Snorm = 20, 
        
        /// <summary>
        /// 
        /// </summary>
        Rgba32i = 21, 
        
        /// <summary>
        /// 
        /// </summary>
        Rgba16i = 22, 
        
        /// <summary>
        /// 
        /// </summary>
        Rgba8i = 23, 
        
        /// <summary>
        /// 
        /// </summary>
        R32i = 24, 
        
        /// <summary>
        /// 
        /// </summary>
        Rg32i = 25, 
        
        /// <summary>
        /// 
        /// </summary>
        Rg16i = 26, 
        
        /// <summary>
        /// 
        /// </summary>
        Rg8i = 27, 
        
        /// <summary>
        /// 
        /// </summary>
        R16i = 28, 
        
        /// <summary>
        /// 
        /// </summary>
        R8i = 29, 
        
        /// <summary>
        /// 
        /// </summary>
        Rgba32ui = 30, 
        
        /// <summary>
        /// 
        /// </summary>
        Rgba16ui = 31, 
        
        /// <summary>
        /// 
        /// </summary>
        Rgba8ui = 32, 
        
        /// <summary>
        /// 
        /// </summary>
        R32ui = 33, 
        
        /// <summary>
        /// 
        /// </summary>
        Rgb10a2ui = 34, 
        
        /// <summary>
        /// 
        /// </summary>
        Rg32ui = 35, 
        
        /// <summary>
        /// 
        /// </summary>
        Rg16ui = 36, 
        
        /// <summary>
        /// 
        /// </summary>
        Rg8ui = 37, 
        
        /// <summary>
        /// 
        /// </summary>
        R16ui = 38, 
        
        /// <summary>
        /// 
        /// </summary>
        R8ui = 39, 
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum ImageChannelOrder
    {
        /// <summary>
        /// 
        /// </summary>
        R = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        A = 1, 
        
        /// <summary>
        /// 
        /// </summary>
        RG = 2, 
        
        /// <summary>
        /// 
        /// </summary>
        RA = 3, 
        
        /// <summary>
        /// 
        /// </summary>
        RGB = 4, 
        
        /// <summary>
        /// 
        /// </summary>
        RGBA = 5, 
        
        /// <summary>
        /// 
        /// </summary>
        BGRA = 6, 
        
        /// <summary>
        /// 
        /// </summary>
        ARGB = 7, 
        
        /// <summary>
        /// 
        /// </summary>
        Intensity = 8, 
        
        /// <summary>
        /// 
        /// </summary>
        Luminance = 9, 
        
        /// <summary>
        /// 
        /// </summary>
        Rx = 10, 
        
        /// <summary>
        /// 
        /// </summary>
        RGx = 11, 
        
        /// <summary>
        /// 
        /// </summary>
        RGBx = 12, 
        
        /// <summary>
        /// 
        /// </summary>
        Depth = 13, 
        
        /// <summary>
        /// 
        /// </summary>
        DepthStencil = 14, 
        
        /// <summary>
        /// 
        /// </summary>
        sRGB = 15, 
        
        /// <summary>
        /// 
        /// </summary>
        sRGBx = 16, 
        
        /// <summary>
        /// 
        /// </summary>
        sRGBA = 17, 
        
        /// <summary>
        /// 
        /// </summary>
        sBGRA = 18, 
        
        /// <summary>
        /// 
        /// </summary>
        ABGR = 19, 
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum ImageChannelDataType
    {
        /// <summary>
        /// 
        /// </summary>
        SnormInt8 = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        SnormInt16 = 1, 
        
        /// <summary>
        /// 
        /// </summary>
        UnormInt8 = 2, 
        
        /// <summary>
        /// 
        /// </summary>
        UnormInt16 = 3, 
        
        /// <summary>
        /// 
        /// </summary>
        UnormShort565 = 4, 
        
        /// <summary>
        /// 
        /// </summary>
        UnormShort555 = 5, 
        
        /// <summary>
        /// 
        /// </summary>
        UnormInt101010 = 6, 
        
        /// <summary>
        /// 
        /// </summary>
        SignedInt8 = 7, 
        
        /// <summary>
        /// 
        /// </summary>
        SignedInt16 = 8, 
        
        /// <summary>
        /// 
        /// </summary>
        SignedInt32 = 9, 
        
        /// <summary>
        /// 
        /// </summary>
        UnsignedInt8 = 10, 
        
        /// <summary>
        /// 
        /// </summary>
        UnsignedInt16 = 11, 
        
        /// <summary>
        /// 
        /// </summary>
        UnsignedInt32 = 12, 
        
        /// <summary>
        /// 
        /// </summary>
        HalfFloat = 13, 
        
        /// <summary>
        /// 
        /// </summary>
        Float = 14, 
        
        /// <summary>
        /// 
        /// </summary>
        UnormInt24 = 15, 
        
        /// <summary>
        /// 
        /// </summary>
        UnormInt101010_2 = 16, 
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum ImageOperands
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Bias = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Lod = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        Grad = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        ConstOffset = 1 << 3, 
        
        /// <summary>
        /// 
        /// </summary>
        Offset = 1 << 4, 
        
        /// <summary>
        /// 
        /// </summary>
        ConstOffsets = 1 << 5, 
        
        /// <summary>
        /// 
        /// </summary>
        Sample = 1 << 6, 
        
        /// <summary>
        /// 
        /// </summary>
        MinLod = 1 << 7, 
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum FPFastMathMode
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        NotNaN = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        NotInf = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        NSZ = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        AllowRecip = 1 << 3, 
        
        /// <summary>
        /// 
        /// </summary>
        Fast = 1 << 4, 
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum FPRoundingMode
    {
        /// <summary>
        /// 
        /// </summary>
        RTE = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        RTZ = 1, 
        
        /// <summary>
        /// 
        /// </summary>
        RTP = 2, 
        
        /// <summary>
        /// 
        /// </summary>
        RTN = 3, 
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum LinkageType
    {
        /// <summary>
        /// 
        /// </summary>
        Export = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Import = 1, 
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum AccessQualifier
    {
        /// <summary>
        /// 
        /// </summary>
        ReadOnly = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        WriteOnly = 1, 
        
        /// <summary>
        /// 
        /// </summary>
        ReadWrite = 2, 
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionParameterAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        Zext = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Sext = 1, 
        
        /// <summary>
        /// 
        /// </summary>
        ByVal = 2, 
        
        /// <summary>
        /// 
        /// </summary>
        Sret = 3, 
        
        /// <summary>
        /// 
        /// </summary>
        NoAlias = 4, 
        
        /// <summary>
        /// 
        /// </summary>
        NoCapture = 5, 
        
        /// <summary>
        /// 
        /// </summary>
        NoWrite = 6, 
        
        /// <summary>
        /// 
        /// </summary>
        NoReadWrite = 7, 
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum Decoration
    {
        /// <summary>
        /// 
        /// </summary>
        RelaxedPrecision = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        SpecId = 1, 
        
        /// <summary>
        /// 
        /// </summary>
        Block = 2, 
        
        /// <summary>
        /// 
        /// </summary>
        BufferBlock = 3, 
        
        /// <summary>
        /// 
        /// </summary>
        RowMajor = 4, 
        
        /// <summary>
        /// 
        /// </summary>
        ColMajor = 5, 
        
        /// <summary>
        /// 
        /// </summary>
        ArrayStride = 6, 
        
        /// <summary>
        /// 
        /// </summary>
        MatrixStride = 7, 
        
        /// <summary>
        /// 
        /// </summary>
        GLSLShared = 8, 
        
        /// <summary>
        /// 
        /// </summary>
        GLSLPacked = 9, 
        
        /// <summary>
        /// 
        /// </summary>
        CPacked = 10, 
        
        /// <summary>
        /// 
        /// </summary>
        BuiltIn = 11, 
        
        /// <summary>
        /// 
        /// </summary>
        NoPerspective = 13, 
        
        /// <summary>
        /// 
        /// </summary>
        Flat = 14, 
        
        /// <summary>
        /// 
        /// </summary>
        Patch = 15, 
        
        /// <summary>
        /// 
        /// </summary>
        Centroid = 16, 
        
        /// <summary>
        /// 
        /// </summary>
        Sample = 17, 
        
        /// <summary>
        /// 
        /// </summary>
        Invariant = 18, 
        
        /// <summary>
        /// 
        /// </summary>
        Restrict = 19, 
        
        /// <summary>
        /// 
        /// </summary>
        Aliased = 20, 
        
        /// <summary>
        /// 
        /// </summary>
        Volatile = 21, 
        
        /// <summary>
        /// 
        /// </summary>
        Constant = 22, 
        
        /// <summary>
        /// 
        /// </summary>
        Coherent = 23, 
        
        /// <summary>
        /// 
        /// </summary>
        NonWritable = 24, 
        
        /// <summary>
        /// 
        /// </summary>
        NonReadable = 25, 
        
        /// <summary>
        /// 
        /// </summary>
        Uniform = 26, 
        
        /// <summary>
        /// 
        /// </summary>
        SaturatedConversion = 28, 
        
        /// <summary>
        /// 
        /// </summary>
        Stream = 29, 
        
        /// <summary>
        /// 
        /// </summary>
        Location = 30, 
        
        /// <summary>
        /// 
        /// </summary>
        Component = 31, 
        
        /// <summary>
        /// 
        /// </summary>
        Index = 32, 
        
        /// <summary>
        /// 
        /// </summary>
        Binding = 33, 
        
        /// <summary>
        /// 
        /// </summary>
        DescriptorSet = 34, 
        
        /// <summary>
        /// 
        /// </summary>
        Offset = 35, 
        
        /// <summary>
        /// 
        /// </summary>
        XfbBuffer = 36, 
        
        /// <summary>
        /// 
        /// </summary>
        XfbStride = 37, 
        
        /// <summary>
        /// 
        /// </summary>
        FuncParamAttr = 38, 
        
        /// <summary>
        /// 
        /// </summary>
        FPRoundingMode = 39, 
        
        /// <summary>
        /// 
        /// </summary>
        FPFastMathMode = 40, 
        
        /// <summary>
        /// 
        /// </summary>
        LinkageAttributes = 41, 
        
        /// <summary>
        /// 
        /// </summary>
        NoContraction = 42, 
        
        /// <summary>
        /// 
        /// </summary>
        InputAttachmentIndex = 43, 
        
        /// <summary>
        /// 
        /// </summary>
        Alignment = 44, 
        
        /// <summary>
        /// 
        /// </summary>
        MaxByteOffset = 45, 
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum BuiltIn
    {
        /// <summary>
        /// 
        /// </summary>
        Position = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        PointSize = 1, 
        
        /// <summary>
        /// 
        /// </summary>
        ClipDistance = 3, 
        
        /// <summary>
        /// 
        /// </summary>
        CullDistance = 4, 
        
        /// <summary>
        /// 
        /// </summary>
        VertexId = 5, 
        
        /// <summary>
        /// 
        /// </summary>
        InstanceId = 6, 
        
        /// <summary>
        /// 
        /// </summary>
        PrimitiveId = 7, 
        
        /// <summary>
        /// 
        /// </summary>
        InvocationId = 8, 
        
        /// <summary>
        /// 
        /// </summary>
        Layer = 9, 
        
        /// <summary>
        /// 
        /// </summary>
        ViewportIndex = 10, 
        
        /// <summary>
        /// 
        /// </summary>
        TessLevelOuter = 11, 
        
        /// <summary>
        /// 
        /// </summary>
        TessLevelInner = 12, 
        
        /// <summary>
        /// 
        /// </summary>
        TessCoord = 13, 
        
        /// <summary>
        /// 
        /// </summary>
        PatchVertices = 14, 
        
        /// <summary>
        /// 
        /// </summary>
        FragCoord = 15, 
        
        /// <summary>
        /// 
        /// </summary>
        PointCoord = 16, 
        
        /// <summary>
        /// 
        /// </summary>
        FrontFacing = 17, 
        
        /// <summary>
        /// 
        /// </summary>
        SampleId = 18, 
        
        /// <summary>
        /// 
        /// </summary>
        SamplePosition = 19, 
        
        /// <summary>
        /// 
        /// </summary>
        SampleMask = 20, 
        
        /// <summary>
        /// 
        /// </summary>
        FragDepth = 22, 
        
        /// <summary>
        /// 
        /// </summary>
        HelperInvocation = 23, 
        
        /// <summary>
        /// 
        /// </summary>
        NumWorkgroups = 24, 
        
        /// <summary>
        /// 
        /// </summary>
        WorkgroupSize = 25, 
        
        /// <summary>
        /// 
        /// </summary>
        WorkgroupId = 26, 
        
        /// <summary>
        /// 
        /// </summary>
        LocalInvocationId = 27, 
        
        /// <summary>
        /// 
        /// </summary>
        GlobalInvocationId = 28, 
        
        /// <summary>
        /// 
        /// </summary>
        LocalInvocationIndex = 29, 
        
        /// <summary>
        /// 
        /// </summary>
        WorkDim = 30, 
        
        /// <summary>
        /// 
        /// </summary>
        GlobalSize = 31, 
        
        /// <summary>
        /// 
        /// </summary>
        EnqueuedWorkgroupSize = 32, 
        
        /// <summary>
        /// 
        /// </summary>
        GlobalOffset = 33, 
        
        /// <summary>
        /// 
        /// </summary>
        GlobalLinearId = 34, 
        
        /// <summary>
        /// 
        /// </summary>
        SubgroupSize = 36, 
        
        /// <summary>
        /// 
        /// </summary>
        SubgroupMaxSize = 37, 
        
        /// <summary>
        /// 
        /// </summary>
        NumSubgroups = 38, 
        
        /// <summary>
        /// 
        /// </summary>
        NumEnqueuedSubgroups = 39, 
        
        /// <summary>
        /// 
        /// </summary>
        SubgroupId = 40, 
        
        /// <summary>
        /// 
        /// </summary>
        SubgroupLocalInvocationId = 41, 
        
        /// <summary>
        /// 
        /// </summary>
        VertexIndex = 42, 
        
        /// <summary>
        /// 
        /// </summary>
        InstanceIndex = 43, 
        
        /// <summary>
        /// 
        /// </summary>
        SubgroupEqMaskKHR = 4416, 
        
        /// <summary>
        /// 
        /// </summary>
        SubgroupGeMaskKHR = 4417, 
        
        /// <summary>
        /// 
        /// </summary>
        SubgroupGtMaskKHR = 4418, 
        
        /// <summary>
        /// 
        /// </summary>
        SubgroupLeMaskKHR = 4419, 
        
        /// <summary>
        /// 
        /// </summary>
        SubgroupLtMaskKHR = 4420, 
        
        /// <summary>
        /// 
        /// </summary>
        BaseVertex = 4424, 
        
        /// <summary>
        /// 
        /// </summary>
        BaseInstance = 4425, 
        
        /// <summary>
        /// 
        /// </summary>
        DrawIndex = 4426, 
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum SelectionControl
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Flatten = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        DontFlatten = 1 << 1, 
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum LoopControl
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Unroll = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        DontUnroll = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        DependencyInfinite = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        DependencyLength = 1 << 3, 
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionControl
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Inline = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        DontInline = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        Pure = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        Const = 1 << 3, 
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum MemorySemantics
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Acquire = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        Release = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        AcquireRelease = 1 << 3, 
        
        /// <summary>
        /// 
        /// </summary>
        SequentiallyConsistent = 1 << 4, 
        
        /// <summary>
        /// 
        /// </summary>
        UniformMemory = 1 << 6, 
        
        /// <summary>
        /// 
        /// </summary>
        SubgroupMemory = 1 << 7, 
        
        /// <summary>
        /// 
        /// </summary>
        WorkgroupMemory = 1 << 8, 
        
        /// <summary>
        /// 
        /// </summary>
        CrossWorkgroupMemory = 1 << 9, 
        
        /// <summary>
        /// 
        /// </summary>
        AtomicCounterMemory = 1 << 10, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageMemory = 1 << 11, 
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum MemoryAccess
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Volatile = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Aligned = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        Nontemporal = 1 << 2, 
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum Scope
    {
        /// <summary>
        /// 
        /// </summary>
        CrossDevice = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Device = 1, 
        
        /// <summary>
        /// 
        /// </summary>
        Workgroup = 2, 
        
        /// <summary>
        /// 
        /// </summary>
        Subgroup = 3, 
        
        /// <summary>
        /// 
        /// </summary>
        Invocation = 4, 
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum GroupOperation
    {
        /// <summary>
        /// 
        /// </summary>
        Reduce = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        InclusiveScan = 1, 
        
        /// <summary>
        /// 
        /// </summary>
        ExclusiveScan = 2, 
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum KernelEnqueueFlags
    {
        /// <summary>
        /// 
        /// </summary>
        NoWait = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        WaitKernel = 1, 
        
        /// <summary>
        /// 
        /// </summary>
        WaitWorkGroup = 2, 
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum KernelProfilingInfo
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        CmdExecTime = 1 << 0, 
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum Capability
    {
        /// <summary>
        /// 
        /// </summary>
        Matrix = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        Shader = 1, 
        
        /// <summary>
        /// 
        /// </summary>
        Geometry = 2, 
        
        /// <summary>
        /// 
        /// </summary>
        Tessellation = 3, 
        
        /// <summary>
        /// 
        /// </summary>
        Addresses = 4, 
        
        /// <summary>
        /// 
        /// </summary>
        Linkage = 5, 
        
        /// <summary>
        /// 
        /// </summary>
        Kernel = 6, 
        
        /// <summary>
        /// 
        /// </summary>
        Vector16 = 7, 
        
        /// <summary>
        /// 
        /// </summary>
        Float16Buffer = 8, 
        
        /// <summary>
        /// 
        /// </summary>
        Float16 = 9, 
        
        /// <summary>
        /// 
        /// </summary>
        Float64 = 10, 
        
        /// <summary>
        /// 
        /// </summary>
        Int64 = 11, 
        
        /// <summary>
        /// 
        /// </summary>
        Int64Atomics = 12, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageBasic = 13, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageReadWrite = 14, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageMipmap = 15, 
        
        /// <summary>
        /// 
        /// </summary>
        Pipes = 17, 
        
        /// <summary>
        /// 
        /// </summary>
        Groups = 18, 
        
        /// <summary>
        /// 
        /// </summary>
        DeviceEnqueue = 19, 
        
        /// <summary>
        /// 
        /// </summary>
        LiteralSampler = 20, 
        
        /// <summary>
        /// 
        /// </summary>
        AtomicStorage = 21, 
        
        /// <summary>
        /// 
        /// </summary>
        Int16 = 22, 
        
        /// <summary>
        /// 
        /// </summary>
        TessellationPointSize = 23, 
        
        /// <summary>
        /// 
        /// </summary>
        GeometryPointSize = 24, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageGatherExtended = 25, 
        
        /// <summary>
        /// 
        /// </summary>
        StorageImageMultisample = 27, 
        
        /// <summary>
        /// 
        /// </summary>
        UniformBufferArrayDynamicIndexing = 28, 
        
        /// <summary>
        /// 
        /// </summary>
        SampledImageArrayDynamicIndexing = 29, 
        
        /// <summary>
        /// 
        /// </summary>
        StorageBufferArrayDynamicIndexing = 30, 
        
        /// <summary>
        /// 
        /// </summary>
        StorageImageArrayDynamicIndexing = 31, 
        
        /// <summary>
        /// 
        /// </summary>
        ClipDistance = 32, 
        
        /// <summary>
        /// 
        /// </summary>
        CullDistance = 33, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageCubeArray = 34, 
        
        /// <summary>
        /// 
        /// </summary>
        SampleRateShading = 35, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageRect = 36, 
        
        /// <summary>
        /// 
        /// </summary>
        SampledRect = 37, 
        
        /// <summary>
        /// 
        /// </summary>
        GenericPointer = 38, 
        
        /// <summary>
        /// 
        /// </summary>
        Int8 = 39, 
        
        /// <summary>
        /// 
        /// </summary>
        InputAttachment = 40, 
        
        /// <summary>
        /// 
        /// </summary>
        SparseResidency = 41, 
        
        /// <summary>
        /// 
        /// </summary>
        MinLod = 42, 
        
        /// <summary>
        /// 
        /// </summary>
        Sampled1D = 43, 
        
        /// <summary>
        /// 
        /// </summary>
        Image1D = 44, 
        
        /// <summary>
        /// 
        /// </summary>
        SampledCubeArray = 45, 
        
        /// <summary>
        /// 
        /// </summary>
        SampledBuffer = 46, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageBuffer = 47, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageMSArray = 48, 
        
        /// <summary>
        /// 
        /// </summary>
        StorageImageExtendedFormats = 49, 
        
        /// <summary>
        /// 
        /// </summary>
        ImageQuery = 50, 
        
        /// <summary>
        /// 
        /// </summary>
        DerivativeControl = 51, 
        
        /// <summary>
        /// 
        /// </summary>
        InterpolationFunction = 52, 
        
        /// <summary>
        /// 
        /// </summary>
        TransformFeedback = 53, 
        
        /// <summary>
        /// 
        /// </summary>
        GeometryStreams = 54, 
        
        /// <summary>
        /// 
        /// </summary>
        StorageImageReadWithoutFormat = 55, 
        
        /// <summary>
        /// 
        /// </summary>
        StorageImageWriteWithoutFormat = 56, 
        
        /// <summary>
        /// 
        /// </summary>
        MultiViewport = 57, 
        
        /// <summary>
        /// 
        /// </summary>
        SubgroupDispatch = 58, 
        
        /// <summary>
        /// 
        /// </summary>
        NamedBarrier = 59, 
        
        /// <summary>
        /// 
        /// </summary>
        PipeStorage = 60, 
        
        /// <summary>
        /// 
        /// </summary>
        SubgroupBallotKHR = 4423, 
        
        /// <summary>
        /// 
        /// </summary>
        DrawParameters = 4427, 
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum Op
    {
        /// <summary>
        /// 
        /// </summary>
        OpNop = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        OpUndef = 1, 
        
        /// <summary>
        /// 
        /// </summary>
        OpSourceContinued = 2, 
        
        /// <summary>
        /// 
        /// </summary>
        OpSource = 3, 
        
        /// <summary>
        /// 
        /// </summary>
        OpSourceExtension = 4, 
        
        /// <summary>
        /// 
        /// </summary>
        OpName = 5, 
        
        /// <summary>
        /// 
        /// </summary>
        OpMemberName = 6, 
        
        /// <summary>
        /// 
        /// </summary>
        OpString = 7, 
        
        /// <summary>
        /// 
        /// </summary>
        OpLine = 8, 
        
        /// <summary>
        /// 
        /// </summary>
        OpExtension = 10, 
        
        /// <summary>
        /// 
        /// </summary>
        OpExtInstImport = 11, 
        
        /// <summary>
        /// 
        /// </summary>
        OpExtInst = 12, 
        
        /// <summary>
        /// 
        /// </summary>
        OpMemoryModel = 14, 
        
        /// <summary>
        /// 
        /// </summary>
        OpEntryPoint = 15, 
        
        /// <summary>
        /// 
        /// </summary>
        OpExecutionMode = 16, 
        
        /// <summary>
        /// 
        /// </summary>
        OpCapability = 17, 
        
        /// <summary>
        /// 
        /// </summary>
        OpTypeVoid = 19, 
        
        /// <summary>
        /// 
        /// </summary>
        OpTypeBool = 20, 
        
        /// <summary>
        /// 
        /// </summary>
        OpTypeInt = 21, 
        
        /// <summary>
        /// 
        /// </summary>
        OpTypeFloat = 22, 
        
        /// <summary>
        /// 
        /// </summary>
        OpTypeVector = 23, 
        
        /// <summary>
        /// 
        /// </summary>
        OpTypeMatrix = 24, 
        
        /// <summary>
        /// 
        /// </summary>
        OpTypeImage = 25, 
        
        /// <summary>
        /// 
        /// </summary>
        OpTypeSampler = 26, 
        
        /// <summary>
        /// 
        /// </summary>
        OpTypeSampledImage = 27, 
        
        /// <summary>
        /// 
        /// </summary>
        OpTypeArray = 28, 
        
        /// <summary>
        /// 
        /// </summary>
        OpTypeRuntimeArray = 29, 
        
        /// <summary>
        /// 
        /// </summary>
        OpTypeStruct = 30, 
        
        /// <summary>
        /// 
        /// </summary>
        OpTypeOpaque = 31, 
        
        /// <summary>
        /// 
        /// </summary>
        OpTypePointer = 32, 
        
        /// <summary>
        /// 
        /// </summary>
        OpTypeFunction = 33, 
        
        /// <summary>
        /// 
        /// </summary>
        OpTypeEvent = 34, 
        
        /// <summary>
        /// 
        /// </summary>
        OpTypeDeviceEvent = 35, 
        
        /// <summary>
        /// 
        /// </summary>
        OpTypeReserveId = 36, 
        
        /// <summary>
        /// 
        /// </summary>
        OpTypeQueue = 37, 
        
        /// <summary>
        /// 
        /// </summary>
        OpTypePipe = 38, 
        
        /// <summary>
        /// 
        /// </summary>
        OpTypeForwardPointer = 39, 
        
        /// <summary>
        /// 
        /// </summary>
        OpConstantTrue = 41, 
        
        /// <summary>
        /// 
        /// </summary>
        OpConstantFalse = 42, 
        
        /// <summary>
        /// 
        /// </summary>
        OpConstant = 43, 
        
        /// <summary>
        /// 
        /// </summary>
        OpConstantComposite = 44, 
        
        /// <summary>
        /// 
        /// </summary>
        OpConstantSampler = 45, 
        
        /// <summary>
        /// 
        /// </summary>
        OpConstantNull = 46, 
        
        /// <summary>
        /// 
        /// </summary>
        OpSpecConstantTrue = 48, 
        
        /// <summary>
        /// 
        /// </summary>
        OpSpecConstantFalse = 49, 
        
        /// <summary>
        /// 
        /// </summary>
        OpSpecConstant = 50, 
        
        /// <summary>
        /// 
        /// </summary>
        OpSpecConstantComposite = 51, 
        
        /// <summary>
        /// 
        /// </summary>
        OpSpecConstantOp = 52, 
        
        /// <summary>
        /// 
        /// </summary>
        OpFunction = 54, 
        
        /// <summary>
        /// 
        /// </summary>
        OpFunctionParameter = 55, 
        
        /// <summary>
        /// 
        /// </summary>
        OpFunctionEnd = 56, 
        
        /// <summary>
        /// 
        /// </summary>
        OpFunctionCall = 57, 
        
        /// <summary>
        /// 
        /// </summary>
        OpVariable = 59, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageTexelPointer = 60, 
        
        /// <summary>
        /// 
        /// </summary>
        OpLoad = 61, 
        
        /// <summary>
        /// 
        /// </summary>
        OpStore = 62, 
        
        /// <summary>
        /// 
        /// </summary>
        OpCopyMemory = 63, 
        
        /// <summary>
        /// 
        /// </summary>
        OpCopyMemorySized = 64, 
        
        /// <summary>
        /// 
        /// </summary>
        OpAccessChain = 65, 
        
        /// <summary>
        /// 
        /// </summary>
        OpInBoundsAccessChain = 66, 
        
        /// <summary>
        /// 
        /// </summary>
        OpPtrAccessChain = 67, 
        
        /// <summary>
        /// 
        /// </summary>
        OpArrayLength = 68, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGenericPtrMemSemantics = 69, 
        
        /// <summary>
        /// 
        /// </summary>
        OpInBoundsPtrAccessChain = 70, 
        
        /// <summary>
        /// 
        /// </summary>
        OpDecorate = 71, 
        
        /// <summary>
        /// 
        /// </summary>
        OpMemberDecorate = 72, 
        
        /// <summary>
        /// 
        /// </summary>
        OpDecorationGroup = 73, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGroupDecorate = 74, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGroupMemberDecorate = 75, 
        
        /// <summary>
        /// 
        /// </summary>
        OpVectorExtractDynamic = 77, 
        
        /// <summary>
        /// 
        /// </summary>
        OpVectorInsertDynamic = 78, 
        
        /// <summary>
        /// 
        /// </summary>
        OpVectorShuffle = 79, 
        
        /// <summary>
        /// 
        /// </summary>
        OpCompositeConstruct = 80, 
        
        /// <summary>
        /// 
        /// </summary>
        OpCompositeExtract = 81, 
        
        /// <summary>
        /// 
        /// </summary>
        OpCompositeInsert = 82, 
        
        /// <summary>
        /// 
        /// </summary>
        OpCopyObject = 83, 
        
        /// <summary>
        /// 
        /// </summary>
        OpTranspose = 84, 
        
        /// <summary>
        /// 
        /// </summary>
        OpSampledImage = 86, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageSampleImplicitLod = 87, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageSampleExplicitLod = 88, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageSampleDrefImplicitLod = 89, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageSampleDrefExplicitLod = 90, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageSampleProjImplicitLod = 91, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageSampleProjExplicitLod = 92, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageSampleProjDrefImplicitLod = 93, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageSampleProjDrefExplicitLod = 94, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageFetch = 95, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageGather = 96, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageDrefGather = 97, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageRead = 98, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageWrite = 99, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImage = 100, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageQueryFormat = 101, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageQueryOrder = 102, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageQuerySizeLod = 103, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageQuerySize = 104, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageQueryLod = 105, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageQueryLevels = 106, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageQuerySamples = 107, 
        
        /// <summary>
        /// 
        /// </summary>
        OpConvertFToU = 109, 
        
        /// <summary>
        /// 
        /// </summary>
        OpConvertFToS = 110, 
        
        /// <summary>
        /// 
        /// </summary>
        OpConvertSToF = 111, 
        
        /// <summary>
        /// 
        /// </summary>
        OpConvertUToF = 112, 
        
        /// <summary>
        /// 
        /// </summary>
        OpUConvert = 113, 
        
        /// <summary>
        /// 
        /// </summary>
        OpSConvert = 114, 
        
        /// <summary>
        /// 
        /// </summary>
        OpFConvert = 115, 
        
        /// <summary>
        /// 
        /// </summary>
        OpQuantizeToF16 = 116, 
        
        /// <summary>
        /// 
        /// </summary>
        OpConvertPtrToU = 117, 
        
        /// <summary>
        /// 
        /// </summary>
        OpSatConvertSToU = 118, 
        
        /// <summary>
        /// 
        /// </summary>
        OpSatConvertUToS = 119, 
        
        /// <summary>
        /// 
        /// </summary>
        OpConvertUToPtr = 120, 
        
        /// <summary>
        /// 
        /// </summary>
        OpPtrCastToGeneric = 121, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGenericCastToPtr = 122, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGenericCastToPtrExplicit = 123, 
        
        /// <summary>
        /// 
        /// </summary>
        OpBitcast = 124, 
        
        /// <summary>
        /// 
        /// </summary>
        OpSNegate = 126, 
        
        /// <summary>
        /// 
        /// </summary>
        OpFNegate = 127, 
        
        /// <summary>
        /// 
        /// </summary>
        OpIAdd = 128, 
        
        /// <summary>
        /// 
        /// </summary>
        OpFAdd = 129, 
        
        /// <summary>
        /// 
        /// </summary>
        OpISub = 130, 
        
        /// <summary>
        /// 
        /// </summary>
        OpFSub = 131, 
        
        /// <summary>
        /// 
        /// </summary>
        OpIMul = 132, 
        
        /// <summary>
        /// 
        /// </summary>
        OpFMul = 133, 
        
        /// <summary>
        /// 
        /// </summary>
        OpUDiv = 134, 
        
        /// <summary>
        /// 
        /// </summary>
        OpSDiv = 135, 
        
        /// <summary>
        /// 
        /// </summary>
        OpFDiv = 136, 
        
        /// <summary>
        /// 
        /// </summary>
        OpUMod = 137, 
        
        /// <summary>
        /// 
        /// </summary>
        OpSRem = 138, 
        
        /// <summary>
        /// 
        /// </summary>
        OpSMod = 139, 
        
        /// <summary>
        /// 
        /// </summary>
        OpFRem = 140, 
        
        /// <summary>
        /// 
        /// </summary>
        OpFMod = 141, 
        
        /// <summary>
        /// 
        /// </summary>
        OpVectorTimesScalar = 142, 
        
        /// <summary>
        /// 
        /// </summary>
        OpMatrixTimesScalar = 143, 
        
        /// <summary>
        /// 
        /// </summary>
        OpVectorTimesMatrix = 144, 
        
        /// <summary>
        /// 
        /// </summary>
        OpMatrixTimesVector = 145, 
        
        /// <summary>
        /// 
        /// </summary>
        OpMatrixTimesMatrix = 146, 
        
        /// <summary>
        /// 
        /// </summary>
        OpOuterProduct = 147, 
        
        /// <summary>
        /// 
        /// </summary>
        OpDot = 148, 
        
        /// <summary>
        /// 
        /// </summary>
        OpIAddCarry = 149, 
        
        /// <summary>
        /// 
        /// </summary>
        OpISubBorrow = 150, 
        
        /// <summary>
        /// 
        /// </summary>
        OpUMulExtended = 151, 
        
        /// <summary>
        /// 
        /// </summary>
        OpSMulExtended = 152, 
        
        /// <summary>
        /// 
        /// </summary>
        OpAny = 154, 
        
        /// <summary>
        /// 
        /// </summary>
        OpAll = 155, 
        
        /// <summary>
        /// 
        /// </summary>
        OpIsNan = 156, 
        
        /// <summary>
        /// 
        /// </summary>
        OpIsInf = 157, 
        
        /// <summary>
        /// 
        /// </summary>
        OpIsFinite = 158, 
        
        /// <summary>
        /// 
        /// </summary>
        OpIsNormal = 159, 
        
        /// <summary>
        /// 
        /// </summary>
        OpSignBitSet = 160, 
        
        /// <summary>
        /// 
        /// </summary>
        OpLessOrGreater = 161, 
        
        /// <summary>
        /// 
        /// </summary>
        OpOrdered = 162, 
        
        /// <summary>
        /// 
        /// </summary>
        OpUnordered = 163, 
        
        /// <summary>
        /// 
        /// </summary>
        OpLogicalEqual = 164, 
        
        /// <summary>
        /// 
        /// </summary>
        OpLogicalNotEqual = 165, 
        
        /// <summary>
        /// 
        /// </summary>
        OpLogicalOr = 166, 
        
        /// <summary>
        /// 
        /// </summary>
        OpLogicalAnd = 167, 
        
        /// <summary>
        /// 
        /// </summary>
        OpLogicalNot = 168, 
        
        /// <summary>
        /// 
        /// </summary>
        OpSelect = 169, 
        
        /// <summary>
        /// 
        /// </summary>
        OpIEqual = 170, 
        
        /// <summary>
        /// 
        /// </summary>
        OpINotEqual = 171, 
        
        /// <summary>
        /// 
        /// </summary>
        OpUGreaterThan = 172, 
        
        /// <summary>
        /// 
        /// </summary>
        OpSGreaterThan = 173, 
        
        /// <summary>
        /// 
        /// </summary>
        OpUGreaterThanEqual = 174, 
        
        /// <summary>
        /// 
        /// </summary>
        OpSGreaterThanEqual = 175, 
        
        /// <summary>
        /// 
        /// </summary>
        OpULessThan = 176, 
        
        /// <summary>
        /// 
        /// </summary>
        OpSLessThan = 177, 
        
        /// <summary>
        /// 
        /// </summary>
        OpULessThanEqual = 178, 
        
        /// <summary>
        /// 
        /// </summary>
        OpSLessThanEqual = 179, 
        
        /// <summary>
        /// 
        /// </summary>
        OpFOrdEqual = 180, 
        
        /// <summary>
        /// 
        /// </summary>
        OpFUnordEqual = 181, 
        
        /// <summary>
        /// 
        /// </summary>
        OpFOrdNotEqual = 182, 
        
        /// <summary>
        /// 
        /// </summary>
        OpFUnordNotEqual = 183, 
        
        /// <summary>
        /// 
        /// </summary>
        OpFOrdLessThan = 184, 
        
        /// <summary>
        /// 
        /// </summary>
        OpFUnordLessThan = 185, 
        
        /// <summary>
        /// 
        /// </summary>
        OpFOrdGreaterThan = 186, 
        
        /// <summary>
        /// 
        /// </summary>
        OpFUnordGreaterThan = 187, 
        
        /// <summary>
        /// 
        /// </summary>
        OpFOrdLessThanEqual = 188, 
        
        /// <summary>
        /// 
        /// </summary>
        OpFUnordLessThanEqual = 189, 
        
        /// <summary>
        /// 
        /// </summary>
        OpFOrdGreaterThanEqual = 190, 
        
        /// <summary>
        /// 
        /// </summary>
        OpFUnordGreaterThanEqual = 191, 
        
        /// <summary>
        /// 
        /// </summary>
        OpShiftRightLogical = 194, 
        
        /// <summary>
        /// 
        /// </summary>
        OpShiftRightArithmetic = 195, 
        
        /// <summary>
        /// 
        /// </summary>
        OpShiftLeftLogical = 196, 
        
        /// <summary>
        /// 
        /// </summary>
        OpBitwiseOr = 197, 
        
        /// <summary>
        /// 
        /// </summary>
        OpBitwiseXor = 198, 
        
        /// <summary>
        /// 
        /// </summary>
        OpBitwiseAnd = 199, 
        
        /// <summary>
        /// 
        /// </summary>
        OpNot = 200, 
        
        /// <summary>
        /// 
        /// </summary>
        OpBitFieldInsert = 201, 
        
        /// <summary>
        /// 
        /// </summary>
        OpBitFieldSExtract = 202, 
        
        /// <summary>
        /// 
        /// </summary>
        OpBitFieldUExtract = 203, 
        
        /// <summary>
        /// 
        /// </summary>
        OpBitReverse = 204, 
        
        /// <summary>
        /// 
        /// </summary>
        OpBitCount = 205, 
        
        /// <summary>
        /// 
        /// </summary>
        OpDPdx = 207, 
        
        /// <summary>
        /// 
        /// </summary>
        OpDPdy = 208, 
        
        /// <summary>
        /// 
        /// </summary>
        OpFwidth = 209, 
        
        /// <summary>
        /// 
        /// </summary>
        OpDPdxFine = 210, 
        
        /// <summary>
        /// 
        /// </summary>
        OpDPdyFine = 211, 
        
        /// <summary>
        /// 
        /// </summary>
        OpFwidthFine = 212, 
        
        /// <summary>
        /// 
        /// </summary>
        OpDPdxCoarse = 213, 
        
        /// <summary>
        /// 
        /// </summary>
        OpDPdyCoarse = 214, 
        
        /// <summary>
        /// 
        /// </summary>
        OpFwidthCoarse = 215, 
        
        /// <summary>
        /// 
        /// </summary>
        OpEmitVertex = 218, 
        
        /// <summary>
        /// 
        /// </summary>
        OpEndPrimitive = 219, 
        
        /// <summary>
        /// 
        /// </summary>
        OpEmitStreamVertex = 220, 
        
        /// <summary>
        /// 
        /// </summary>
        OpEndStreamPrimitive = 221, 
        
        /// <summary>
        /// 
        /// </summary>
        OpControlBarrier = 224, 
        
        /// <summary>
        /// 
        /// </summary>
        OpMemoryBarrier = 225, 
        
        /// <summary>
        /// 
        /// </summary>
        OpAtomicLoad = 227, 
        
        /// <summary>
        /// 
        /// </summary>
        OpAtomicStore = 228, 
        
        /// <summary>
        /// 
        /// </summary>
        OpAtomicExchange = 229, 
        
        /// <summary>
        /// 
        /// </summary>
        OpAtomicCompareExchange = 230, 
        
        /// <summary>
        /// 
        /// </summary>
        OpAtomicCompareExchangeWeak = 231, 
        
        /// <summary>
        /// 
        /// </summary>
        OpAtomicIIncrement = 232, 
        
        /// <summary>
        /// 
        /// </summary>
        OpAtomicIDecrement = 233, 
        
        /// <summary>
        /// 
        /// </summary>
        OpAtomicIAdd = 234, 
        
        /// <summary>
        /// 
        /// </summary>
        OpAtomicISub = 235, 
        
        /// <summary>
        /// 
        /// </summary>
        OpAtomicSMin = 236, 
        
        /// <summary>
        /// 
        /// </summary>
        OpAtomicUMin = 237, 
        
        /// <summary>
        /// 
        /// </summary>
        OpAtomicSMax = 238, 
        
        /// <summary>
        /// 
        /// </summary>
        OpAtomicUMax = 239, 
        
        /// <summary>
        /// 
        /// </summary>
        OpAtomicAnd = 240, 
        
        /// <summary>
        /// 
        /// </summary>
        OpAtomicOr = 241, 
        
        /// <summary>
        /// 
        /// </summary>
        OpAtomicXor = 242, 
        
        /// <summary>
        /// 
        /// </summary>
        OpPhi = 245, 
        
        /// <summary>
        /// 
        /// </summary>
        OpLoopMerge = 246, 
        
        /// <summary>
        /// 
        /// </summary>
        OpSelectionMerge = 247, 
        
        /// <summary>
        /// 
        /// </summary>
        OpLabel = 248, 
        
        /// <summary>
        /// 
        /// </summary>
        OpBranch = 249, 
        
        /// <summary>
        /// 
        /// </summary>
        OpBranchConditional = 250, 
        
        /// <summary>
        /// 
        /// </summary>
        OpSwitch = 251, 
        
        /// <summary>
        /// 
        /// </summary>
        OpKill = 252, 
        
        /// <summary>
        /// 
        /// </summary>
        OpReturn = 253, 
        
        /// <summary>
        /// 
        /// </summary>
        OpReturnValue = 254, 
        
        /// <summary>
        /// 
        /// </summary>
        OpUnreachable = 255, 
        
        /// <summary>
        /// 
        /// </summary>
        OpLifetimeStart = 256, 
        
        /// <summary>
        /// 
        /// </summary>
        OpLifetimeStop = 257, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGroupAsyncCopy = 259, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGroupWaitEvents = 260, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGroupAll = 261, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGroupAny = 262, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGroupBroadcast = 263, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGroupIAdd = 264, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGroupFAdd = 265, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGroupFMin = 266, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGroupUMin = 267, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGroupSMin = 268, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGroupFMax = 269, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGroupUMax = 270, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGroupSMax = 271, 
        
        /// <summary>
        /// 
        /// </summary>
        OpReadPipe = 274, 
        
        /// <summary>
        /// 
        /// </summary>
        OpWritePipe = 275, 
        
        /// <summary>
        /// 
        /// </summary>
        OpReservedReadPipe = 276, 
        
        /// <summary>
        /// 
        /// </summary>
        OpReservedWritePipe = 277, 
        
        /// <summary>
        /// 
        /// </summary>
        OpReserveReadPipePackets = 278, 
        
        /// <summary>
        /// 
        /// </summary>
        OpReserveWritePipePackets = 279, 
        
        /// <summary>
        /// 
        /// </summary>
        OpCommitReadPipe = 280, 
        
        /// <summary>
        /// 
        /// </summary>
        OpCommitWritePipe = 281, 
        
        /// <summary>
        /// 
        /// </summary>
        OpIsValidReserveId = 282, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGetNumPipePackets = 283, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGetMaxPipePackets = 284, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGroupReserveReadPipePackets = 285, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGroupReserveWritePipePackets = 286, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGroupCommitReadPipe = 287, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGroupCommitWritePipe = 288, 
        
        /// <summary>
        /// 
        /// </summary>
        OpEnqueueMarker = 291, 
        
        /// <summary>
        /// 
        /// </summary>
        OpEnqueueKernel = 292, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGetKernelNDrangeSubGroupCount = 293, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGetKernelNDrangeMaxSubGroupSize = 294, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGetKernelWorkGroupSize = 295, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGetKernelPreferredWorkGroupSizeMultiple = 296, 
        
        /// <summary>
        /// 
        /// </summary>
        OpRetainEvent = 297, 
        
        /// <summary>
        /// 
        /// </summary>
        OpReleaseEvent = 298, 
        
        /// <summary>
        /// 
        /// </summary>
        OpCreateUserEvent = 299, 
        
        /// <summary>
        /// 
        /// </summary>
        OpIsValidEvent = 300, 
        
        /// <summary>
        /// 
        /// </summary>
        OpSetUserEventStatus = 301, 
        
        /// <summary>
        /// 
        /// </summary>
        OpCaptureEventProfilingInfo = 302, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGetDefaultQueue = 303, 
        
        /// <summary>
        /// 
        /// </summary>
        OpBuildNDRange = 304, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageSparseSampleImplicitLod = 305, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageSparseSampleExplicitLod = 306, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageSparseSampleDrefImplicitLod = 307, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageSparseSampleDrefExplicitLod = 308, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageSparseSampleProjImplicitLod = 309, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageSparseSampleProjExplicitLod = 310, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageSparseSampleProjDrefImplicitLod = 311, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageSparseSampleProjDrefExplicitLod = 312, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageSparseFetch = 313, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageSparseGather = 314, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageSparseDrefGather = 315, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageSparseTexelsResident = 316, 
        
        /// <summary>
        /// 
        /// </summary>
        OpNoLine = 317, 
        
        /// <summary>
        /// 
        /// </summary>
        OpAtomicFlagTestAndSet = 318, 
        
        /// <summary>
        /// 
        /// </summary>
        OpAtomicFlagClear = 319, 
        
        /// <summary>
        /// 
        /// </summary>
        OpImageSparseRead = 320, 
        
        /// <summary>
        /// 
        /// </summary>
        OpSizeOf = 321, 
        
        /// <summary>
        /// 
        /// </summary>
        OpTypePipeStorage = 322, 
        
        /// <summary>
        /// 
        /// </summary>
        OpConstantPipeStorage = 323, 
        
        /// <summary>
        /// 
        /// </summary>
        OpCreatePipeFromPipeStorage = 324, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGetKernelLocalSizeForSubgroupCount = 325, 
        
        /// <summary>
        /// 
        /// </summary>
        OpGetKernelMaxNumSubgroups = 326, 
        
        /// <summary>
        /// 
        /// </summary>
        OpTypeNamedBarrier = 327, 
        
        /// <summary>
        /// 
        /// </summary>
        OpNamedBarrierInitialize = 328, 
        
        /// <summary>
        /// 
        /// </summary>
        OpMemoryNamedBarrier = 329, 
        
        /// <summary>
        /// 
        /// </summary>
        OpModuleProcessed = 330, 
        
        /// <summary>
        /// 
        /// </summary>
        OpSubgroupBallotKHR = 4421, 
        
        /// <summary>
        /// 
        /// </summary>
        OpSubgroupFirstInvocationKHR = 4422, 
    }
}
