namespace SharpVk
{
    public partial class CommandBuffer
    {
        /// <summary>
        /// Insert a memory dependency.
        /// </summary>
        /// <param name="sourceStageMask">
        /// </param>
        /// <param name="destinationStageMask">
        /// </param>
        /// <param name="sourceAccessMask">
        /// </param>
        /// <param name="destinationAccessMask">
        /// </param>
        /// <param name="oldLayout">
        /// </param>
        /// <param name="newLayout">
        /// </param>
        /// <param name="sourceQueueFamilyIndex">
        /// </param>
        /// <param name="destinationQueueFamilyIndex">
        /// </param>
        /// <param name="image">
        /// </param>
        /// <param name="subresourceRange">
        /// </param>
        /// <param name="dependencyFlags">
        /// </param>
        public unsafe void PipelineBarrier(PipelineStageFlags sourceStageMask,
                                                PipelineStageFlags destinationStageMask,
                                                AccessFlags sourceAccessMask,
                                                AccessFlags destinationAccessMask,
                                                ImageLayout oldLayout,
                                                ImageLayout newLayout,
                                                uint sourceQueueFamilyIndex,
                                                uint destinationQueueFamilyIndex,
                                                Image image,
                                                ImageSubresourceRange subresourceRange,
                                                DependencyFlags dependencyFlags = DependencyFlags.None)
        {
            try
            {
                Interop.ImageMemoryBarrier marshalledImageMemoryBarrier = default;

                marshalledImageMemoryBarrier.SType = StructureType.ImageMemoryBarrier;
                marshalledImageMemoryBarrier.Next = null;
                marshalledImageMemoryBarrier.SourceAccessMask = sourceAccessMask;
                marshalledImageMemoryBarrier.DestinationAccessMask = destinationAccessMask;
                marshalledImageMemoryBarrier.OldLayout = oldLayout;
                marshalledImageMemoryBarrier.NewLayout = newLayout;
                marshalledImageMemoryBarrier.SourceQueueFamilyIndex = sourceQueueFamilyIndex;
                marshalledImageMemoryBarrier.DestinationQueueFamilyIndex = destinationQueueFamilyIndex;
                marshalledImageMemoryBarrier.Image = image.handle;
                marshalledImageMemoryBarrier.SubresourceRange = subresourceRange;
                Interop.VkCommandBufferPipelineBarrierDelegate commandDelegate = commandCache.GetCommandDelegate<Interop.VkCommandBufferPipelineBarrierDelegate>("vkCmdPipelineBarrier", "");
                commandDelegate(this.handle, sourceStageMask, destinationStageMask, dependencyFlags, 0, null, 0, null, 1, &marshalledImageMemoryBarrier);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }

    }
}
