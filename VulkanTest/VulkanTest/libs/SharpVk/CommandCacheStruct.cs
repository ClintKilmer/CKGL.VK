using System;
using System.Runtime.InteropServices;

namespace SharpVk
{
    internal partial struct CommandCacheStruct
    {
        private static T GetDelegate<T>(IntPtr functionPointer)
            where T : Delegate
        {
            if (functionPointer == IntPtr.Zero)
            {
                return null;
            }
            else
            {
                return Marshal.GetDelegateForFunctionPointer<T>(functionPointer);
            }
        }
    }
}
