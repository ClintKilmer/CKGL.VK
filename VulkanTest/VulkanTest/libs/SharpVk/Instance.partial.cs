namespace SharpVk
{
    partial class Instance
    {
        /// <summary>
        /// Create a new Vulkan instance.
        /// </summary>
        /// <param name="flags">
        /// Reserved for future use.
        /// </param>
        /// <param name="applicationInfo">
        /// Null or an instance of ApplicationInfo. If not Null, this
        /// information helps implementations recognize behavior inherent to
        /// classes of applications. ApplicationInfo is defined in detail
        /// below.
        /// </param>
        /// <param name="enabledLayerNames">
        /// An array of enabledLayerCount strings containing the names of
        /// layers to enable for the created instance. See the Layers section
        /// for further details.
        /// </param>
        /// <param name="enabledExtensionNames">
        /// An array of enabledExtensionCount strings containing the names of
        /// extensions to enable.
        /// </param>
        /// <param name="debugReportCallbackCreateInfoExt">
        /// </param>
        /// <param name="validationFlagsExt">
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe SharpVk.Instance Create(ArrayProxy<string>? enabledLayerNames, ArrayProxy<string>? enabledExtensionNames, SharpVk.InstanceCreateFlags? flags = null, SharpVk.ApplicationInfo? applicationInfo = null, SharpVk.Multivendor.DebugReportCallbackCreateInfo? debugReportCallbackCreateInfoExt = null, SharpVk.Multivendor.ValidationFlags? validationFlagsExt = null, AllocationCallbacks? allocator = null)
        {
            var cache = new CommandCache(new SharpVk.Interop.NativeLibrary());
            cache.Initialise();

            return Instance.Create(cache, enabledLayerNames, enabledExtensionNames, flags, applicationInfo, debugReportCallbackCreateInfoExt, validationFlagsExt, allocator: allocator);
        }

        /// <summary>
        /// Returns up to requested number of global extension properties.
        /// </summary>
        public static unsafe SharpVk.ExtensionProperties[] EnumerateExtensionProperties(string layerName)
        {
            var cache = new CommandCache(new SharpVk.Interop.NativeLibrary());
            cache.Initialise();

            return Instance.EnumerateExtensionProperties(cache, layerName);
        }

        /// <summary>
        /// Returns up to requested number of global extension properties.
        /// </summary>
        public static unsafe Version EnumerateVersion()
        {
            var commandCache = new CommandCache(new SharpVk.Interop.NativeLibrary());

            commandCache.Initialise();

            if (commandCache.IsCommandAvailable("vkEnumerateInstanceVersion", ""))
            {
                return Instance.EnumerateVersion(commandCache);
            }
            else
            {
                // API v1.0 does not support EnumerateVersion command
                return new Version(1, 0, 0);
            }
        }

        /// <summary>
        /// Returns up to requested number of global layer properties.
        /// </summary>
        public static unsafe SharpVk.LayerProperties[] EnumerateLayerProperties()
        {
            var cache = new CommandCache(new SharpVk.Interop.NativeLibrary());
            cache.Initialise();

            return Instance.EnumerateLayerProperties(cache);
        }
    }
}
