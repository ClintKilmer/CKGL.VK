using System;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public interface IProcLookup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        IntPtr GetProcedureAddress(string name);
    }
}
