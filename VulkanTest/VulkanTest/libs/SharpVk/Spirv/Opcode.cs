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
    public partial struct OpCode
    {
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpNop = new OpCode
        {
            Op = Op.OpNop
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpUndef = new OpCode
        {
            Op = Op.OpUndef,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpSourceContinued = new OpCode
        {
            Op = Op.OpSourceContinued,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.LiteralString,
                    Quantifier = Quantifier.None,
                    Name = "'Continued Source'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpSource = new OpCode
        {
            Op = Op.OpSource,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.SourceLanguage,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Version'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Optional,
                    Name = "'File'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralString,
                    Quantifier = Quantifier.Optional,
                    Name = "'Source'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpSourceExtension = new OpCode
        {
            Op = Op.OpSourceExtension,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.LiteralString,
                    Quantifier = Quantifier.None,
                    Name = "'Extension'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpName = new OpCode
        {
            Op = Op.OpName,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Target'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralString,
                    Quantifier = Quantifier.None,
                    Name = "'Name'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpMemberName = new OpCode
        {
            Op = Op.OpMemberName,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Type'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Member'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralString,
                    Quantifier = Quantifier.None,
                    Name = "'Name'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpString = new OpCode
        {
            Op = Op.OpString,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.LiteralString,
                    Quantifier = Quantifier.None,
                    Name = "'String'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpLine = new OpCode
        {
            Op = Op.OpLine,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'File'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Line'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Column'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpExtension = new OpCode
        {
            Op = Op.OpExtension,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.LiteralString,
                    Quantifier = Quantifier.None,
                    Name = "'Name'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpExtInstImport = new OpCode
        {
            Op = Op.OpExtInstImport,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.LiteralString,
                    Quantifier = Quantifier.None,
                    Name = "'Name'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpExtInst = new OpCode
        {
            Op = Op.OpExtInst,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Set'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralExtInstInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Instruction'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Operand 1', +'Operand 2', +..."
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpMemoryModel = new OpCode
        {
            Op = Op.OpMemoryModel,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.AddressingModel,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.MemoryModel,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpEntryPoint = new OpCode
        {
            Op = Op.OpEntryPoint,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.ExecutionModel,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Entry Point'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralString,
                    Quantifier = Quantifier.None,
                    Name = "'Name'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Interface'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpExecutionMode = new OpCode
        {
            Op = Op.OpExecutionMode,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Entry Point'"
                },
                new Operand
                {
                    Kind = OperandKind.ExecutionMode,
                    Quantifier = Quantifier.None,
                    Name = "'Mode'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpCapability = new OpCode
        {
            Op = Op.OpCapability,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.Capability,
                    Quantifier = Quantifier.None,
                    Name = "'Capability'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpTypeVoid = new OpCode
        {
            Op = Op.OpTypeVoid,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpTypeBool = new OpCode
        {
            Op = Op.OpTypeBool,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpTypeInt = new OpCode
        {
            Op = Op.OpTypeInt,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Width'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Signedness'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpTypeFloat = new OpCode
        {
            Op = Op.OpTypeFloat,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Width'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpTypeVector = new OpCode
        {
            Op = Op.OpTypeVector,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Component Type'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Component Count'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpTypeMatrix = new OpCode
        {
            Op = Op.OpTypeMatrix,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Column Type'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Column Count'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpTypeImage = new OpCode
        {
            Op = Op.OpTypeImage,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Type'"
                },
                new Operand
                {
                    Kind = OperandKind.Dim,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Depth'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Arrayed'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'MS'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageFormat,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.AccessQualifier,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpTypeSampler = new OpCode
        {
            Op = Op.OpTypeSampler,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpTypeSampledImage = new OpCode
        {
            Op = Op.OpTypeSampledImage,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Image Type'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpTypeArray = new OpCode
        {
            Op = Op.OpTypeArray,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Element Type'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Length'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpTypeRuntimeArray = new OpCode
        {
            Op = Op.OpTypeRuntimeArray,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Element Type'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpTypeStruct = new OpCode
        {
            Op = Op.OpTypeStruct,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Member 0 type', +'member 1 type', +..."
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpTypeOpaque = new OpCode
        {
            Op = Op.OpTypeOpaque,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.LiteralString,
                    Quantifier = Quantifier.None,
                    Name = "The name of the opaque type."
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpTypePointer = new OpCode
        {
            Op = Op.OpTypePointer,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.StorageClass,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Type'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpTypeFunction = new OpCode
        {
            Op = Op.OpTypeFunction,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Return Type'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Parameter 0 Type', +'Parameter 1 Type', +..."
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpTypeEvent = new OpCode
        {
            Op = Op.OpTypeEvent,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpTypeDeviceEvent = new OpCode
        {
            Op = Op.OpTypeDeviceEvent,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpTypeReserveId = new OpCode
        {
            Op = Op.OpTypeReserveId,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpTypeQueue = new OpCode
        {
            Op = Op.OpTypeQueue,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpTypePipe = new OpCode
        {
            Op = Op.OpTypePipe,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.AccessQualifier,
                    Quantifier = Quantifier.None,
                    Name = "'Qualifier'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpTypeForwardPointer = new OpCode
        {
            Op = Op.OpTypeForwardPointer,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer Type'"
                },
                new Operand
                {
                    Kind = OperandKind.StorageClass,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpConstantTrue = new OpCode
        {
            Op = Op.OpConstantTrue,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpConstantFalse = new OpCode
        {
            Op = Op.OpConstantFalse,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpConstant = new OpCode
        {
            Op = Op.OpConstant,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.LiteralContextDependentNumber,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpConstantComposite = new OpCode
        {
            Op = Op.OpConstantComposite,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Constituents'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpConstantSampler = new OpCode
        {
            Op = Op.OpConstantSampler,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.SamplerAddressingMode,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Param'"
                },
                new Operand
                {
                    Kind = OperandKind.SamplerFilterMode,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpConstantNull = new OpCode
        {
            Op = Op.OpConstantNull,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpSpecConstantTrue = new OpCode
        {
            Op = Op.OpSpecConstantTrue,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpSpecConstantFalse = new OpCode
        {
            Op = Op.OpSpecConstantFalse,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpSpecConstant = new OpCode
        {
            Op = Op.OpSpecConstant,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.LiteralContextDependentNumber,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpSpecConstantComposite = new OpCode
        {
            Op = Op.OpSpecConstantComposite,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Constituents'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpSpecConstantOp = new OpCode
        {
            Op = Op.OpSpecConstantOp,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.LiteralSpecConstantOpInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Opcode'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpFunction = new OpCode
        {
            Op = Op.OpFunction,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.FunctionControl,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Function Type'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpFunctionParameter = new OpCode
        {
            Op = Op.OpFunctionParameter,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpFunctionEnd = new OpCode
        {
            Op = Op.OpFunctionEnd
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpFunctionCall = new OpCode
        {
            Op = Op.OpFunctionCall,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Function'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Argument 0', +'Argument 1', +..."
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpVariable = new OpCode
        {
            Op = Op.OpVariable,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.StorageClass,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Optional,
                    Name = "'Initializer'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageTexelPointer = new OpCode
        {
            Op = Op.OpImageTexelPointer,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sample'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpLoad = new OpCode
        {
            Op = Op.OpLoad,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.MemoryAccess,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpStore = new OpCode
        {
            Op = Op.OpStore,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Object'"
                },
                new Operand
                {
                    Kind = OperandKind.MemoryAccess,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpCopyMemory = new OpCode
        {
            Op = Op.OpCopyMemory,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Target'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Source'"
                },
                new Operand
                {
                    Kind = OperandKind.MemoryAccess,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpCopyMemorySized = new OpCode
        {
            Op = Op.OpCopyMemorySized,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Target'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Source'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Size'"
                },
                new Operand
                {
                    Kind = OperandKind.MemoryAccess,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpAccessChain = new OpCode
        {
            Op = Op.OpAccessChain,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Base'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Indexes'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpInBoundsAccessChain = new OpCode
        {
            Op = Op.OpInBoundsAccessChain,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Base'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Indexes'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpPtrAccessChain = new OpCode
        {
            Op = Op.OpPtrAccessChain,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Base'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Element'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Indexes'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpArrayLength = new OpCode
        {
            Op = Op.OpArrayLength,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Structure'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Array member'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGenericPtrMemSemantics = new OpCode
        {
            Op = Op.OpGenericPtrMemSemantics,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpInBoundsPtrAccessChain = new OpCode
        {
            Op = Op.OpInBoundsPtrAccessChain,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Base'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Element'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Indexes'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpDecorate = new OpCode
        {
            Op = Op.OpDecorate,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Target'"
                },
                new Operand
                {
                    Kind = OperandKind.Decoration,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpMemberDecorate = new OpCode
        {
            Op = Op.OpMemberDecorate,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Structure Type'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Member'"
                },
                new Operand
                {
                    Kind = OperandKind.Decoration,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpDecorationGroup = new OpCode
        {
            Op = Op.OpDecorationGroup,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGroupDecorate = new OpCode
        {
            Op = Op.OpGroupDecorate,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Decoration Group'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Targets'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGroupMemberDecorate = new OpCode
        {
            Op = Op.OpGroupMemberDecorate,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Decoration Group'"
                },
                new Operand
                {
                    Kind = OperandKind.PairIdRefLiteralInteger,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Targets'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpVectorExtractDynamic = new OpCode
        {
            Op = Op.OpVectorExtractDynamic,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Vector'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Index'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpVectorInsertDynamic = new OpCode
        {
            Op = Op.OpVectorInsertDynamic,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Vector'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Component'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Index'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpVectorShuffle = new OpCode
        {
            Op = Op.OpVectorShuffle,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Vector 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Vector 2'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Components'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpCompositeConstruct = new OpCode
        {
            Op = Op.OpCompositeConstruct,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Constituents'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpCompositeExtract = new OpCode
        {
            Op = Op.OpCompositeExtract,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Composite'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Indexes'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpCompositeInsert = new OpCode
        {
            Op = Op.OpCompositeInsert,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Object'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Composite'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Indexes'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpCopyObject = new OpCode
        {
            Op = Op.OpCopyObject,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpTranspose = new OpCode
        {
            Op = Op.OpTranspose,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Matrix'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpSampledImage = new OpCode
        {
            Op = Op.OpSampledImage,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampler'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageSampleImplicitLod = new OpCode
        {
            Op = Op.OpImageSampleImplicitLod,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageSampleExplicitLod = new OpCode
        {
            Op = Op.OpImageSampleExplicitLod,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageSampleDrefImplicitLod = new OpCode
        {
            Op = Op.OpImageSampleDrefImplicitLod,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'D~ref~'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageSampleDrefExplicitLod = new OpCode
        {
            Op = Op.OpImageSampleDrefExplicitLod,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'D~ref~'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageSampleProjImplicitLod = new OpCode
        {
            Op = Op.OpImageSampleProjImplicitLod,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageSampleProjExplicitLod = new OpCode
        {
            Op = Op.OpImageSampleProjExplicitLod,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageSampleProjDrefImplicitLod = new OpCode
        {
            Op = Op.OpImageSampleProjDrefImplicitLod,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'D~ref~'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageSampleProjDrefExplicitLod = new OpCode
        {
            Op = Op.OpImageSampleProjDrefExplicitLod,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'D~ref~'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageFetch = new OpCode
        {
            Op = Op.OpImageFetch,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageGather = new OpCode
        {
            Op = Op.OpImageGather,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Component'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageDrefGather = new OpCode
        {
            Op = Op.OpImageDrefGather,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'D~ref~'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageRead = new OpCode
        {
            Op = Op.OpImageRead,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageWrite = new OpCode
        {
            Op = Op.OpImageWrite,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Texel'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImage = new OpCode
        {
            Op = Op.OpImage,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageQueryFormat = new OpCode
        {
            Op = Op.OpImageQueryFormat,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Image'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageQueryOrder = new OpCode
        {
            Op = Op.OpImageQueryOrder,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Image'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageQuerySizeLod = new OpCode
        {
            Op = Op.OpImageQuerySizeLod,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Level of Detail'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageQuerySize = new OpCode
        {
            Op = Op.OpImageQuerySize,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Image'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageQueryLod = new OpCode
        {
            Op = Op.OpImageQueryLod,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageQueryLevels = new OpCode
        {
            Op = Op.OpImageQueryLevels,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Image'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageQuerySamples = new OpCode
        {
            Op = Op.OpImageQuerySamples,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Image'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpConvertFToU = new OpCode
        {
            Op = Op.OpConvertFToU,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Float Value'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpConvertFToS = new OpCode
        {
            Op = Op.OpConvertFToS,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Float Value'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpConvertSToF = new OpCode
        {
            Op = Op.OpConvertSToF,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Signed Value'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpConvertUToF = new OpCode
        {
            Op = Op.OpConvertUToF,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Unsigned Value'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpUConvert = new OpCode
        {
            Op = Op.OpUConvert,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Unsigned Value'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpSConvert = new OpCode
        {
            Op = Op.OpSConvert,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Signed Value'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpFConvert = new OpCode
        {
            Op = Op.OpFConvert,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Float Value'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpQuantizeToF16 = new OpCode
        {
            Op = Op.OpQuantizeToF16,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpConvertPtrToU = new OpCode
        {
            Op = Op.OpConvertPtrToU,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpSatConvertSToU = new OpCode
        {
            Op = Op.OpSatConvertSToU,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Signed Value'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpSatConvertUToS = new OpCode
        {
            Op = Op.OpSatConvertUToS,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Unsigned Value'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpConvertUToPtr = new OpCode
        {
            Op = Op.OpConvertUToPtr,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Integer Value'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpPtrCastToGeneric = new OpCode
        {
            Op = Op.OpPtrCastToGeneric,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGenericCastToPtr = new OpCode
        {
            Op = Op.OpGenericCastToPtr,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGenericCastToPtrExplicit = new OpCode
        {
            Op = Op.OpGenericCastToPtrExplicit,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.StorageClass,
                    Quantifier = Quantifier.None,
                    Name = "'Storage'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpBitcast = new OpCode
        {
            Op = Op.OpBitcast,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpSNegate = new OpCode
        {
            Op = Op.OpSNegate,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpFNegate = new OpCode
        {
            Op = Op.OpFNegate,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpIAdd = new OpCode
        {
            Op = Op.OpIAdd,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpFAdd = new OpCode
        {
            Op = Op.OpFAdd,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpISub = new OpCode
        {
            Op = Op.OpISub,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpFSub = new OpCode
        {
            Op = Op.OpFSub,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpIMul = new OpCode
        {
            Op = Op.OpIMul,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpFMul = new OpCode
        {
            Op = Op.OpFMul,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpUDiv = new OpCode
        {
            Op = Op.OpUDiv,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpSDiv = new OpCode
        {
            Op = Op.OpSDiv,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpFDiv = new OpCode
        {
            Op = Op.OpFDiv,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpUMod = new OpCode
        {
            Op = Op.OpUMod,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpSRem = new OpCode
        {
            Op = Op.OpSRem,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpSMod = new OpCode
        {
            Op = Op.OpSMod,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpFRem = new OpCode
        {
            Op = Op.OpFRem,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpFMod = new OpCode
        {
            Op = Op.OpFMod,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpVectorTimesScalar = new OpCode
        {
            Op = Op.OpVectorTimesScalar,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Vector'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Scalar'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpMatrixTimesScalar = new OpCode
        {
            Op = Op.OpMatrixTimesScalar,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Matrix'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Scalar'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpVectorTimesMatrix = new OpCode
        {
            Op = Op.OpVectorTimesMatrix,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Vector'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Matrix'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpMatrixTimesVector = new OpCode
        {
            Op = Op.OpMatrixTimesVector,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Matrix'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Vector'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpMatrixTimesMatrix = new OpCode
        {
            Op = Op.OpMatrixTimesMatrix,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'LeftMatrix'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'RightMatrix'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpOuterProduct = new OpCode
        {
            Op = Op.OpOuterProduct,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Vector 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Vector 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpDot = new OpCode
        {
            Op = Op.OpDot,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Vector 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Vector 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpIAddCarry = new OpCode
        {
            Op = Op.OpIAddCarry,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpISubBorrow = new OpCode
        {
            Op = Op.OpISubBorrow,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpUMulExtended = new OpCode
        {
            Op = Op.OpUMulExtended,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpSMulExtended = new OpCode
        {
            Op = Op.OpSMulExtended,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpAny = new OpCode
        {
            Op = Op.OpAny,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Vector'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpAll = new OpCode
        {
            Op = Op.OpAll,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Vector'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpIsNan = new OpCode
        {
            Op = Op.OpIsNan,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'x'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpIsInf = new OpCode
        {
            Op = Op.OpIsInf,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'x'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpIsFinite = new OpCode
        {
            Op = Op.OpIsFinite,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'x'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpIsNormal = new OpCode
        {
            Op = Op.OpIsNormal,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'x'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpSignBitSet = new OpCode
        {
            Op = Op.OpSignBitSet,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'x'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpLessOrGreater = new OpCode
        {
            Op = Op.OpLessOrGreater,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'x'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'y'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpOrdered = new OpCode
        {
            Op = Op.OpOrdered,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'x'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'y'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpUnordered = new OpCode
        {
            Op = Op.OpUnordered,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'x'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'y'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpLogicalEqual = new OpCode
        {
            Op = Op.OpLogicalEqual,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpLogicalNotEqual = new OpCode
        {
            Op = Op.OpLogicalNotEqual,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpLogicalOr = new OpCode
        {
            Op = Op.OpLogicalOr,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpLogicalAnd = new OpCode
        {
            Op = Op.OpLogicalAnd,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpLogicalNot = new OpCode
        {
            Op = Op.OpLogicalNot,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpSelect = new OpCode
        {
            Op = Op.OpSelect,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Condition'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Object 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Object 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpIEqual = new OpCode
        {
            Op = Op.OpIEqual,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpINotEqual = new OpCode
        {
            Op = Op.OpINotEqual,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpUGreaterThan = new OpCode
        {
            Op = Op.OpUGreaterThan,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpSGreaterThan = new OpCode
        {
            Op = Op.OpSGreaterThan,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpUGreaterThanEqual = new OpCode
        {
            Op = Op.OpUGreaterThanEqual,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpSGreaterThanEqual = new OpCode
        {
            Op = Op.OpSGreaterThanEqual,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpULessThan = new OpCode
        {
            Op = Op.OpULessThan,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpSLessThan = new OpCode
        {
            Op = Op.OpSLessThan,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpULessThanEqual = new OpCode
        {
            Op = Op.OpULessThanEqual,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpSLessThanEqual = new OpCode
        {
            Op = Op.OpSLessThanEqual,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpFOrdEqual = new OpCode
        {
            Op = Op.OpFOrdEqual,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpFUnordEqual = new OpCode
        {
            Op = Op.OpFUnordEqual,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpFOrdNotEqual = new OpCode
        {
            Op = Op.OpFOrdNotEqual,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpFUnordNotEqual = new OpCode
        {
            Op = Op.OpFUnordNotEqual,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpFOrdLessThan = new OpCode
        {
            Op = Op.OpFOrdLessThan,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpFUnordLessThan = new OpCode
        {
            Op = Op.OpFUnordLessThan,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpFOrdGreaterThan = new OpCode
        {
            Op = Op.OpFOrdGreaterThan,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpFUnordGreaterThan = new OpCode
        {
            Op = Op.OpFUnordGreaterThan,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpFOrdLessThanEqual = new OpCode
        {
            Op = Op.OpFOrdLessThanEqual,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpFUnordLessThanEqual = new OpCode
        {
            Op = Op.OpFUnordLessThanEqual,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpFOrdGreaterThanEqual = new OpCode
        {
            Op = Op.OpFOrdGreaterThanEqual,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpFUnordGreaterThanEqual = new OpCode
        {
            Op = Op.OpFUnordGreaterThanEqual,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpShiftRightLogical = new OpCode
        {
            Op = Op.OpShiftRightLogical,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Base'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Shift'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpShiftRightArithmetic = new OpCode
        {
            Op = Op.OpShiftRightArithmetic,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Base'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Shift'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpShiftLeftLogical = new OpCode
        {
            Op = Op.OpShiftLeftLogical,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Base'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Shift'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpBitwiseOr = new OpCode
        {
            Op = Op.OpBitwiseOr,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpBitwiseXor = new OpCode
        {
            Op = Op.OpBitwiseXor,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpBitwiseAnd = new OpCode
        {
            Op = Op.OpBitwiseAnd,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 1'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand 2'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpNot = new OpCode
        {
            Op = Op.OpNot,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Operand'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpBitFieldInsert = new OpCode
        {
            Op = Op.OpBitFieldInsert,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Base'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Insert'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Offset'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Count'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpBitFieldSExtract = new OpCode
        {
            Op = Op.OpBitFieldSExtract,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Base'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Offset'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Count'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpBitFieldUExtract = new OpCode
        {
            Op = Op.OpBitFieldUExtract,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Base'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Offset'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Count'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpBitReverse = new OpCode
        {
            Op = Op.OpBitReverse,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Base'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpBitCount = new OpCode
        {
            Op = Op.OpBitCount,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Base'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpDPdx = new OpCode
        {
            Op = Op.OpDPdx,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'P'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpDPdy = new OpCode
        {
            Op = Op.OpDPdy,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'P'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpFwidth = new OpCode
        {
            Op = Op.OpFwidth,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'P'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpDPdxFine = new OpCode
        {
            Op = Op.OpDPdxFine,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'P'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpDPdyFine = new OpCode
        {
            Op = Op.OpDPdyFine,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'P'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpFwidthFine = new OpCode
        {
            Op = Op.OpFwidthFine,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'P'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpDPdxCoarse = new OpCode
        {
            Op = Op.OpDPdxCoarse,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'P'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpDPdyCoarse = new OpCode
        {
            Op = Op.OpDPdyCoarse,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'P'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpFwidthCoarse = new OpCode
        {
            Op = Op.OpFwidthCoarse,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'P'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpEmitVertex = new OpCode
        {
            Op = Op.OpEmitVertex
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpEndPrimitive = new OpCode
        {
            Op = Op.OpEndPrimitive
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpEmitStreamVertex = new OpCode
        {
            Op = Op.OpEmitStreamVertex,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Stream'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpEndStreamPrimitive = new OpCode
        {
            Op = Op.OpEndStreamPrimitive,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Stream'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpControlBarrier = new OpCode
        {
            Op = Op.OpControlBarrier,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Memory'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpMemoryBarrier = new OpCode
        {
            Op = Op.OpMemoryBarrier,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Memory'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpAtomicLoad = new OpCode
        {
            Op = Op.OpAtomicLoad,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpAtomicStore = new OpCode
        {
            Op = Op.OpAtomicStore,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpAtomicExchange = new OpCode
        {
            Op = Op.OpAtomicExchange,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpAtomicCompareExchange = new OpCode
        {
            Op = Op.OpAtomicCompareExchange,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Equal'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Unequal'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Comparator'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpAtomicCompareExchangeWeak = new OpCode
        {
            Op = Op.OpAtomicCompareExchangeWeak,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Equal'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Unequal'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Comparator'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpAtomicIIncrement = new OpCode
        {
            Op = Op.OpAtomicIIncrement,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpAtomicIDecrement = new OpCode
        {
            Op = Op.OpAtomicIDecrement,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpAtomicIAdd = new OpCode
        {
            Op = Op.OpAtomicIAdd,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpAtomicISub = new OpCode
        {
            Op = Op.OpAtomicISub,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpAtomicSMin = new OpCode
        {
            Op = Op.OpAtomicSMin,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpAtomicUMin = new OpCode
        {
            Op = Op.OpAtomicUMin,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpAtomicSMax = new OpCode
        {
            Op = Op.OpAtomicSMax,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpAtomicUMax = new OpCode
        {
            Op = Op.OpAtomicUMax,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpAtomicAnd = new OpCode
        {
            Op = Op.OpAtomicAnd,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpAtomicOr = new OpCode
        {
            Op = Op.OpAtomicOr,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpAtomicXor = new OpCode
        {
            Op = Op.OpAtomicXor,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpPhi = new OpCode
        {
            Op = Op.OpPhi,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.PairIdRefIdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Variable, Parent, ...'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpLoopMerge = new OpCode
        {
            Op = Op.OpLoopMerge,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Merge Block'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Continue Target'"
                },
                new Operand
                {
                    Kind = OperandKind.LoopControl,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpSelectionMerge = new OpCode
        {
            Op = Op.OpSelectionMerge,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Merge Block'"
                },
                new Operand
                {
                    Kind = OperandKind.SelectionControl,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpLabel = new OpCode
        {
            Op = Op.OpLabel,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpBranch = new OpCode
        {
            Op = Op.OpBranch,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Target Label'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpBranchConditional = new OpCode
        {
            Op = Op.OpBranchConditional,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Condition'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'True Label'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'False Label'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Branch weights'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpSwitch = new OpCode
        {
            Op = Op.OpSwitch,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Selector'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Default'"
                },
                new Operand
                {
                    Kind = OperandKind.PairLiteralIntegerIdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Target'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpKill = new OpCode
        {
            Op = Op.OpKill
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpReturn = new OpCode
        {
            Op = Op.OpReturn
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpReturnValue = new OpCode
        {
            Op = Op.OpReturnValue,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpUnreachable = new OpCode
        {
            Op = Op.OpUnreachable
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpLifetimeStart = new OpCode
        {
            Op = Op.OpLifetimeStart,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Size'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpLifetimeStop = new OpCode
        {
            Op = Op.OpLifetimeStop,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Size'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGroupAsyncCopy = new OpCode
        {
            Op = Op.OpGroupAsyncCopy,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Destination'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Source'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Num Elements'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Stride'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Event'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGroupWaitEvents = new OpCode
        {
            Op = Op.OpGroupWaitEvents,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Num Events'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Events List'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGroupAll = new OpCode
        {
            Op = Op.OpGroupAll,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Predicate'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGroupAny = new OpCode
        {
            Op = Op.OpGroupAny,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Predicate'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGroupBroadcast = new OpCode
        {
            Op = Op.OpGroupBroadcast,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'LocalId'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGroupIAdd = new OpCode
        {
            Op = Op.OpGroupIAdd,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.GroupOperation,
                    Quantifier = Quantifier.None,
                    Name = "'Operation'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'X'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGroupFAdd = new OpCode
        {
            Op = Op.OpGroupFAdd,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.GroupOperation,
                    Quantifier = Quantifier.None,
                    Name = "'Operation'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'X'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGroupFMin = new OpCode
        {
            Op = Op.OpGroupFMin,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.GroupOperation,
                    Quantifier = Quantifier.None,
                    Name = "'Operation'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "X"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGroupUMin = new OpCode
        {
            Op = Op.OpGroupUMin,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.GroupOperation,
                    Quantifier = Quantifier.None,
                    Name = "'Operation'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'X'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGroupSMin = new OpCode
        {
            Op = Op.OpGroupSMin,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.GroupOperation,
                    Quantifier = Quantifier.None,
                    Name = "'Operation'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "X"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGroupFMax = new OpCode
        {
            Op = Op.OpGroupFMax,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.GroupOperation,
                    Quantifier = Quantifier.None,
                    Name = "'Operation'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "X"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGroupUMax = new OpCode
        {
            Op = Op.OpGroupUMax,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.GroupOperation,
                    Quantifier = Quantifier.None,
                    Name = "'Operation'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "X"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGroupSMax = new OpCode
        {
            Op = Op.OpGroupSMax,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.GroupOperation,
                    Quantifier = Quantifier.None,
                    Name = "'Operation'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "X"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpReadPipe = new OpCode
        {
            Op = Op.OpReadPipe,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pipe'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Alignment'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpWritePipe = new OpCode
        {
            Op = Op.OpWritePipe,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pipe'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Alignment'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpReservedReadPipe = new OpCode
        {
            Op = Op.OpReservedReadPipe,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pipe'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Reserve Id'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Index'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Alignment'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpReservedWritePipe = new OpCode
        {
            Op = Op.OpReservedWritePipe,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pipe'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Reserve Id'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Index'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Alignment'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpReserveReadPipePackets = new OpCode
        {
            Op = Op.OpReserveReadPipePackets,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pipe'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Num Packets'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Alignment'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpReserveWritePipePackets = new OpCode
        {
            Op = Op.OpReserveWritePipePackets,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pipe'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Num Packets'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Alignment'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpCommitReadPipe = new OpCode
        {
            Op = Op.OpCommitReadPipe,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pipe'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Reserve Id'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Alignment'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpCommitWritePipe = new OpCode
        {
            Op = Op.OpCommitWritePipe,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pipe'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Reserve Id'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Alignment'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpIsValidReserveId = new OpCode
        {
            Op = Op.OpIsValidReserveId,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Reserve Id'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGetNumPipePackets = new OpCode
        {
            Op = Op.OpGetNumPipePackets,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pipe'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Alignment'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGetMaxPipePackets = new OpCode
        {
            Op = Op.OpGetMaxPipePackets,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pipe'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Alignment'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGroupReserveReadPipePackets = new OpCode
        {
            Op = Op.OpGroupReserveReadPipePackets,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pipe'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Num Packets'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Alignment'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGroupReserveWritePipePackets = new OpCode
        {
            Op = Op.OpGroupReserveWritePipePackets,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pipe'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Num Packets'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Alignment'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGroupCommitReadPipe = new OpCode
        {
            Op = Op.OpGroupCommitReadPipe,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pipe'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Reserve Id'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Alignment'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGroupCommitWritePipe = new OpCode
        {
            Op = Op.OpGroupCommitWritePipe,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Execution'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pipe'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Reserve Id'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Alignment'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpEnqueueMarker = new OpCode
        {
            Op = Op.OpEnqueueMarker,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Queue'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Num Events'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Wait Events'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Ret Event'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpEnqueueKernel = new OpCode
        {
            Op = Op.OpEnqueueKernel,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Queue'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Flags'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'ND Range'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Num Events'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Wait Events'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Ret Event'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Invoke'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param Align'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.Multiple,
                    Name = "'Local Size'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGetKernelNDrangeSubGroupCount = new OpCode
        {
            Op = Op.OpGetKernelNDrangeSubGroupCount,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'ND Range'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Invoke'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param Align'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGetKernelNDrangeMaxSubGroupSize = new OpCode
        {
            Op = Op.OpGetKernelNDrangeMaxSubGroupSize,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'ND Range'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Invoke'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param Align'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGetKernelWorkGroupSize = new OpCode
        {
            Op = Op.OpGetKernelWorkGroupSize,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Invoke'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param Align'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGetKernelPreferredWorkGroupSizeMultiple = new OpCode
        {
            Op = Op.OpGetKernelPreferredWorkGroupSizeMultiple,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Invoke'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param Align'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpRetainEvent = new OpCode
        {
            Op = Op.OpRetainEvent,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Event'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpReleaseEvent = new OpCode
        {
            Op = Op.OpReleaseEvent,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Event'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpCreateUserEvent = new OpCode
        {
            Op = Op.OpCreateUserEvent,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpIsValidEvent = new OpCode
        {
            Op = Op.OpIsValidEvent,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Event'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpSetUserEventStatus = new OpCode
        {
            Op = Op.OpSetUserEventStatus,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Event'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Status'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpCaptureEventProfilingInfo = new OpCode
        {
            Op = Op.OpCaptureEventProfilingInfo,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Event'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Profiling Info'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGetDefaultQueue = new OpCode
        {
            Op = Op.OpGetDefaultQueue,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpBuildNDRange = new OpCode
        {
            Op = Op.OpBuildNDRange,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'GlobalWorkSize'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'LocalWorkSize'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'GlobalWorkOffset'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageSparseSampleImplicitLod = new OpCode
        {
            Op = Op.OpImageSparseSampleImplicitLod,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageSparseSampleExplicitLod = new OpCode
        {
            Op = Op.OpImageSparseSampleExplicitLod,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageSparseSampleDrefImplicitLod = new OpCode
        {
            Op = Op.OpImageSparseSampleDrefImplicitLod,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'D~ref~'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageSparseSampleDrefExplicitLod = new OpCode
        {
            Op = Op.OpImageSparseSampleDrefExplicitLod,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'D~ref~'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageSparseSampleProjImplicitLod = new OpCode
        {
            Op = Op.OpImageSparseSampleProjImplicitLod,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageSparseSampleProjExplicitLod = new OpCode
        {
            Op = Op.OpImageSparseSampleProjExplicitLod,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageSparseSampleProjDrefImplicitLod = new OpCode
        {
            Op = Op.OpImageSparseSampleProjDrefImplicitLod,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'D~ref~'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageSparseSampleProjDrefExplicitLod = new OpCode
        {
            Op = Op.OpImageSparseSampleProjDrefExplicitLod,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'D~ref~'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageSparseFetch = new OpCode
        {
            Op = Op.OpImageSparseFetch,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageSparseGather = new OpCode
        {
            Op = Op.OpImageSparseGather,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Component'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageSparseDrefGather = new OpCode
        {
            Op = Op.OpImageSparseDrefGather,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Sampled Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'D~ref~'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageSparseTexelsResident = new OpCode
        {
            Op = Op.OpImageSparseTexelsResident,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Resident Code'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpNoLine = new OpCode
        {
            Op = Op.OpNoLine
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpAtomicFlagTestAndSet = new OpCode
        {
            Op = Op.OpAtomicFlagTestAndSet,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpAtomicFlagClear = new OpCode
        {
            Op = Op.OpAtomicFlagClear,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Scope'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpImageSparseRead = new OpCode
        {
            Op = Op.OpImageSparseRead,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Image'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Coordinate'"
                },
                new Operand
                {
                    Kind = OperandKind.ImageOperands,
                    Quantifier = Quantifier.Optional,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpSizeOf = new OpCode
        {
            Op = Op.OpSizeOf,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pointer'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpTypePipeStorage = new OpCode
        {
            Op = Op.OpTypePipeStorage,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpConstantPipeStorage = new OpCode
        {
            Op = Op.OpConstantPipeStorage,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Size'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Packet Alignment'"
                },
                new Operand
                {
                    Kind = OperandKind.LiteralInteger,
                    Quantifier = Quantifier.None,
                    Name = "'Capacity'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpCreatePipeFromPipeStorage = new OpCode
        {
            Op = Op.OpCreatePipeFromPipeStorage,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Pipe Storage'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGetKernelLocalSizeForSubgroupCount = new OpCode
        {
            Op = Op.OpGetKernelLocalSizeForSubgroupCount,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Subgroup Count'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Invoke'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param Align'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpGetKernelMaxNumSubgroups = new OpCode
        {
            Op = Op.OpGetKernelMaxNumSubgroups,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Invoke'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param Size'"
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Param Align'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpTypeNamedBarrier = new OpCode
        {
            Op = Op.OpTypeNamedBarrier,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpNamedBarrierInitialize = new OpCode
        {
            Op = Op.OpNamedBarrierInitialize,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Subgroup Count'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpMemoryNamedBarrier = new OpCode
        {
            Op = Op.OpMemoryNamedBarrier,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Named Barrier'"
                },
                new Operand
                {
                    Kind = OperandKind.IdScope,
                    Quantifier = Quantifier.None,
                    Name = "'Memory'"
                },
                new Operand
                {
                    Kind = OperandKind.IdMemorySemantics,
                    Quantifier = Quantifier.None,
                    Name = "'Semantics'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpModuleProcessed = new OpCode
        {
            Op = Op.OpModuleProcessed,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.LiteralString,
                    Quantifier = Quantifier.None,
                    Name = "'Process'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpSubgroupBallotKHR = new OpCode
        {
            Op = Op.OpSubgroupBallotKHR,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Predicate'"
                }
            }
        }; 
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly OpCode OpSubgroupFirstInvocationKHR = new OpCode
        {
            Op = Op.OpSubgroupFirstInvocationKHR,
            Operands = new Operand[]
            {new Operand
                {
                    Kind = OperandKind.IdResultType,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdResult,
                    Quantifier = Quantifier.None,
                    Name = ""
                },
                new Operand
                {
                    Kind = OperandKind.IdRef,
                    Quantifier = Quantifier.None,
                    Name = "'Value'"
                }
            }
        }; 
    }
}
