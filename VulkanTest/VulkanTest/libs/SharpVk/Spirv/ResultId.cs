namespace SharpVk.Spirv
{
    /// <summary>
    /// Represents the unique ID value representing the result of an SPIR-V
    /// statement.
    /// </summary>
    public struct ResultId
    {
        /// <summary>
        /// The integer value of this ID value.
        /// </summary>
        public int Id
        {
            get;
            private set;
        }

        /// <summary>
        /// Returns a string value representing this ID value.
        /// </summary>
        /// <returns>
        /// A string value.
        /// </returns>
        public override string ToString()
        {
            return "%" + this.Id;
        }

        /// <summary>
        /// Implicit cast of an integer value to a ResultId.
        /// </summary>
        /// <param name="value">
        /// The unique integer value for this ID.
        /// </param>
        public static implicit operator ResultId(int value)
        {
            return new ResultId
            {
                Id = value
            };
        }
    }
}
