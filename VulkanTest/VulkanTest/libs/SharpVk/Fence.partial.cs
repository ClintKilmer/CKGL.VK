namespace SharpVk
{
    partial class Fence
    {
        /// <summary>
        /// Wait for a fence object to become signaled.
        /// </summary>
        /// <param name="timeout">
        /// The timeout period in units of nanoseconds.
        /// <paramref name="timeout"/> is adjusted to the closest value allowed
        /// by the implementation-dependent timeout accuracy, which may be
        /// substantially longer than one nanosecond, and may be longer than
        /// the requested period.
        /// </param>
        public bool Wait(ulong timeout) => this.parent.WaitForFences(this, true, timeout) == Result.Success;

        /// <summary>
        /// Reset a fence object.
        /// </summary>
        public void Reset() => this.parent.ResetFences(this);
    }
}
