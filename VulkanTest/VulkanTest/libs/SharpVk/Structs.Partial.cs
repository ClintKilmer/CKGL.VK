
using System;
using System.Runtime.InteropServices;

namespace SharpVk
{
    /// <summary>
    /// -
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct SecurityAttributes
    {
        /// <summary>
        /// -
        /// </summary>
        public int Length;

        /// <summary>
        /// -
        /// </summary>
        public IntPtr SecurityDescriptor;

        /// <summary>
        /// -
        /// </summary>
        [MarshalAs(UnmanagedType.I4)]
        public bool InheritHandle;
    }

    /// <summary>
    /// -
    /// </summary>
    public struct SampleMask
    {
        private uint value;

        /// <summary>
        /// -
        /// </summary>
        public static implicit operator SampleMask(uint value)
        {
            return new SampleMask { value = value };
        }

        /// <summary>
        /// -
        /// </summary>
        public static implicit operator uint(SampleMask size)
        {
            return size.value;
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