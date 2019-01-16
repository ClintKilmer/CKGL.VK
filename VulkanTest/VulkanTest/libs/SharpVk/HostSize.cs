
using System;

namespace SharpVk
{
    /// <summary>
    /// Represents the size of a block in host memory.
    /// </summary>
    public struct HostSize
    {
        private UIntPtr value;

        /// <summary>
        /// -
        /// </summary>
        public static implicit operator HostSize(int value)
        {
            return new HostSize { value = (UIntPtr)value };
        }

        /// <summary>
        /// -
        /// </summary>
        public static implicit operator HostSize(uint value)
        {
            return new HostSize { value = (UIntPtr)value };
        }

        /// <summary>
        /// -
        /// </summary>
        public static implicit operator HostSize(ulong value)
        {
            return new HostSize { value = (UIntPtr)value };
        }

        /// <summary>
        /// -
        /// </summary>
        public static explicit operator uint(HostSize size)
        {
            return size.value.ToUInt32();
        }

        /// <summary>
        /// -
        /// </summary>
        public static explicit operator ulong(HostSize size)
        {
            return size.value.ToUInt64();
        }

        /// <summary>
        /// -
        /// </summary>
        public override string ToString()
        {
            return this.value.ToString();
        }
    }
}