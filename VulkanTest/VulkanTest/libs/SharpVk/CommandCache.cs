using System;
using System.Runtime.InteropServices;

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    public class CommandCache
    {
        private readonly IProcLookup host;
        private readonly string type;
        private readonly CommandCache parent;

        private CommandCacheStruct cache;

        internal CommandCache(IProcLookup host, string type, CommandCache parent)
        {
            this.host = host;
            this.type = type;
            this.parent = parent;
            this.cache = parent?.cache ?? default;
        }

        /// <summary>
        /// Build cache of function pointers from IProcLookup host.
        /// </summary>
        public void Initialise()
        {
            this.cache = new CommandCacheStruct(this);
        }

        internal CommandCacheStruct Cache => this.cache;

        /// <summary>
        /// Creates a new instance of CommandCache using the given IProcLookup
        /// instance to load unmanaged Vulkan function pointers.
        /// </summary>
        /// <param name="procLookup">
        /// An implementation of IProcLookup that can load the core Vulkan
        /// commands.
        /// </param>
        public CommandCache(IProcLookup procLookup)
            : this(procLookup, "", null)
        {
        }

        public bool IsCommandAvailable(string name, string type)
        {
            if (type != this.type)
            {
                if (this.parent != null)
                {
                    return this.parent.IsCommandAvailable(name, type);
                }
                else
                {
                    return false;
                }
            }

            return this.host.GetProcedureAddress(name) != System.IntPtr.Zero;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public T GetCommandDelegate<T>(string name, string type)
        {
            if (type != this.type)
            {
                if (this.parent != null)
                {
                    return this.parent.GetCommandDelegate<T>(name, type);
                }
                else
                {
                    return default;
                }
            }

            var functionPointer = this.host.GetProcedureAddress(name);

            if (functionPointer == IntPtr.Zero)
            {
                return default;
            }
            else
            {
                return Marshal.GetDelegateForFunctionPointer<T>(functionPointer);
            }
        }
    }
}
