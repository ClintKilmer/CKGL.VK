using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SharpVk.Spirv
{
    public partial struct OpCode
    {
        /// <summary>
        /// 
        /// </summary>
        public Op Op
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<Operand> Operands
        {
            get;
            private set;
        }

        /// <summary>
        /// -
        /// </summary>
        public static readonly Dictionary<Op, OpCode> Lookup;

        static OpCode()
        {
            Lookup = typeof(OpCode).GetTypeInfo().DeclaredFields
                                    .Where(x => x.IsPublic && x.IsStatic)
									.Where(x => x.FieldType == typeof(OpCode))
									.Select(x => (OpCode)x.GetValue(null))
									.ToDictionary(x => x.Op);
        }
    }
}
