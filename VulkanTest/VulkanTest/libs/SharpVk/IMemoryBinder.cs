using System;

namespace SharpVk
{
    public interface IMemoryBinder
        : IDisposable
    {
        /// <summary>
        /// Bind device memory to a Vulkan object.
        /// </summary>
        void BindMemory(DeviceMemory memory, DeviceSize memoryOffset);

        /// <summary>
        /// Returns the memory requirements for specified Vulkan object.
        /// </summary>
        MemoryRequirements GetMemoryRequirements();
    }
}
