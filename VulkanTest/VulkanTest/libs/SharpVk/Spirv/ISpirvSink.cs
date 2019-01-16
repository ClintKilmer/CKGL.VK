namespace SharpVk.Spirv
{
    /// <summary>
    /// Represents a target for outputing SPIR-V statements
    /// </summary>
    public interface ISpirvSink
    {
        /// <summary>
        /// Output the specified statement with an optional ResultID
        /// </summary>
        /// <param name="resultId">
        /// If not null; the ResultId representing the result of this
        /// statement.
        /// </param>
        /// <param name="statement">
        /// The SPIR-V statement to output to this sink instance.
        /// </param>
        void AddStatement(ResultId? resultId, SpirvStatement statement);
    }

    /// <summary>
    /// Common overloads for ISpirvSink instances.
    /// </summary>
    public static class SpirvSinkExtensions
    {
        /// <summary>
        /// Output the specified statement
        /// </summary>
        /// <param name="sink">
        /// The sink to which to output the statement.
        /// </param>
        /// <param name="statement">
        /// The SPIR-V statement to output to this sink instance.
        /// </param>
        public static void AddStatement(this ISpirvSink sink, SpirvStatement statement)
        {
            sink.AddStatement(null, statement);
        }

        /// <summary>
        /// Output an SPIR-V statement with the specified opcode and operands
        /// arguments.
        /// </summary>
        /// <param name="sink">
        /// The sink to which to output the statement.
        /// </param>
        /// <param name="op">
        /// The opcode of the statement to output.
        /// </param>
        /// <param name="operands">
        /// A list of operand arguments to include in the output statement.
        /// </param>
        public static void AddStatement(this ISpirvSink sink, Op op, params object[] operands)
        {
            sink.AddStatement(null, new SpirvStatement(op, operands));
        }


        /// <summary>
        /// Output an SPIR-V statement with the specified opcode, ResultID and operands
        /// arguments.
        /// </summary>
        /// <param name="sink">
        /// The sink to which to output the statement.
        /// </param>
        /// <param name="resultId">
        /// A ResultId representing the result of this statement.
        /// </param>
        /// <param name="op">
        /// The opcode of the statement to output.
        /// </param>
        /// <param name="operands">
        /// A list of operand arguments to include in the output statement.
        /// </param>
        public static void AddStatement(this ISpirvSink sink, ResultId resultId, Op op, params object[] operands)
        {
            sink.AddStatement(resultId, new SpirvStatement(op, operands));
        }
    }
}
