namespace SharpVk
{
    public partial struct ComponentMapping
    {
        /// <summary>
        /// A mapping with all components set to the identity swizzle.
        /// </summary>
        public static ComponentMapping Identity = new ComponentMapping(ComponentSwizzle.Identity, ComponentSwizzle.Identity, ComponentSwizzle.Identity, ComponentSwizzle.Identity);
    }
}
