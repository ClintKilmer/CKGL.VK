namespace SharpVk.Spirv
{
    /// <summary>
    /// -
    /// </summary>
    public struct Operand
    {
        /// <summary>
        /// -
        /// </summary>
        public OperandKind Kind
        {
            get;
            internal set;
        }

        /// <summary>
        /// -
        /// </summary>
        public Quantifier Quantifier
        {
            get;
            internal set;
        }

        /// <summary>
        /// -
        /// </summary>
        public string Name
        {
            get;
            internal set;
        }
    }
}
