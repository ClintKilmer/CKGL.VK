namespace SharpVk
{
    public partial class Device
    {
        /// <summary>
        /// Write the contents of a descriptor set object.
        /// </summary>
        /// <param name="destinationSet">
        /// The destination descriptor set to update.
        /// </param>
        /// <param name="destinationBinding">
        /// The descriptor binding within the set.
        /// </param>
        /// <param name="destinationArrayElement">
        /// The starting element in the binding array.
        /// </param>
        /// <param name="descriptorType">
        /// A DescriptorType specifying the type of each descriptor in
        /// bufferInfos.
        /// It must be the same type as that specified in
        /// DescriptorSetLayoutBinding for destinationSet at
        /// destinationBinding. The type of the descriptor also controls which
        /// array the descriptors are taken from.
        /// </param>
        /// <param name="bufferInfos">
        /// An array of DescriptorBufferInfo structures.
        /// </param>
        public unsafe void WriteDescriptorSet(DescriptorSet destinationSet, uint destinationBinding, uint destinationArrayElement, DescriptorType descriptorType, ArrayProxy<DescriptorBufferInfo>? bufferInfos)
        {
            int bufferInfosLength = bufferInfos?.Length ?? 0;
            var marshalledInfos = (Interop.DescriptorBufferInfo*)Interop.HeapUtil.Allocate<Interop.DescriptorBufferInfo>(bufferInfosLength);

            for (int index = 0; index < bufferInfosLength; index++)
            {
                bufferInfos.Value[index].MarshalTo(&marshalledInfos[index]);
            }

            Interop.WriteDescriptorSet info = new Interop.WriteDescriptorSet
            {
                SType = StructureType.WriteDescriptorSet,
                BufferInfo = marshalledInfos,
                DestinationSet = destinationSet.handle,
                DestinationBinding = destinationBinding,
                DestinationArrayElement = destinationArrayElement,
                DescriptorCount = (uint)bufferInfosLength,
                DescriptorType = descriptorType
            };

            var commandDelegate = commandCache.GetCommandDelegate<Interop.VkDeviceUpdateDescriptorSetsDelegate>("vkUpdateDescriptorSets", "");
            commandDelegate(this.handle, 1, &info, 0, null);
        }

        /// <summary>
        /// Write the contents of a descriptor set object.
        /// </summary>
        /// <param name="destinationSet">
        /// The destination descriptor set to update.
        /// </param>
        /// <param name="destinationBinding">
        /// The descriptor binding within the set.
        /// </param>
        /// <param name="destinationArrayElement">
        /// The starting element in the binding array.
        /// </param>
        /// <param name="descriptorType">
        /// A DescriptorType specifying the type of each descriptor in
        /// imageInfos.
        /// It must be the same type as that specified in
        /// DescriptorSetLayoutBinding for destinationSet at
        /// destinationBinding. The type of the descriptor also controls which
        /// array the descriptors are taken from.
        /// </param>
        /// <param name="imageInfos">
        /// An array of DescriptorImageInfo structures.
        /// </param>
        public unsafe void WriteDescriptorSet(DescriptorSet destinationSet, uint destinationBinding, uint destinationArrayElement, DescriptorType descriptorType, ArrayProxy<DescriptorImageInfo>? imageInfos)
        {
            int bufferInfosLength = imageInfos?.Length ?? 0;
            var marshalledInfos = (Interop.DescriptorImageInfo*)Interop.HeapUtil.Allocate<Interop.DescriptorImageInfo>(bufferInfosLength);

            for (int index = 0; index < bufferInfosLength; index++)
            {
                imageInfos.Value[index].MarshalTo(&marshalledInfos[index]);
            }

            Interop.WriteDescriptorSet info = new Interop.WriteDescriptorSet
            {
                SType = StructureType.WriteDescriptorSet,
                ImageInfo = marshalledInfos,
                DestinationSet = destinationSet.handle,
                DestinationBinding = destinationBinding,
                DestinationArrayElement = destinationArrayElement,
                DescriptorCount = (uint)bufferInfosLength,
                DescriptorType = descriptorType
            };

            var commandDelegate = commandCache.GetCommandDelegate<Interop.VkDeviceUpdateDescriptorSetsDelegate>("vkUpdateDescriptorSets", "");
            commandDelegate(this.handle, 1, &info, 0, null);
        }

        /// <summary>
        /// Write the contents of a descriptor set object.
        /// </summary>
        /// <param name="destinationSet">
        /// The destination descriptor set to update.
        /// </param>
        /// <param name="destinationBinding">
        /// The descriptor binding within the set.
        /// </param>
        /// <param name="destinationArrayElement">
        /// The starting element in the binding array.
        /// </param>
        /// <param name="descriptorType">
        /// A DescriptorType specifying the type of each descriptor in
        /// texelBufferViews.
        /// It must be the same type as that specified in
        /// DescriptorSetLayoutBinding for destinationSet at
        /// destinationBinding. The type of the descriptor also controls which
        /// array the descriptors are taken from.
        /// </param>
        /// <param name="texelBufferViews">
        /// An array of BufferViews.
        /// </param>
        public unsafe void WriteDescriptorSet(DescriptorSet destinationSet, uint destinationBinding, uint destinationArrayElement, DescriptorType descriptorType, ArrayProxy<BufferView>? texelBufferViews)
        {
            int bufferInfosLength = texelBufferViews?.Length ?? 0;
            var marshalledViews = (Interop.BufferView*)Interop.HeapUtil.Allocate<Interop.BufferView>(bufferInfosLength);

            for (int index = 0; index < bufferInfosLength; index++)
            {
                marshalledViews[index] = texelBufferViews.Value[index].handle;
            }

            Interop.WriteDescriptorSet info = new Interop.WriteDescriptorSet
            {
                SType = StructureType.WriteDescriptorSet,
                TexelBufferView = marshalledViews,
                DestinationSet = destinationSet.handle,
                DestinationBinding = destinationBinding,
                DestinationArrayElement = destinationArrayElement,
                DescriptorCount = (uint)bufferInfosLength,
                DescriptorType = descriptorType
            };

            var commandDelegate = commandCache.GetCommandDelegate<Interop.VkDeviceUpdateDescriptorSetsDelegate>("vkUpdateDescriptorSets", "");
            commandDelegate(this.handle, 1, &info, 0, null);
        }
    }
}
