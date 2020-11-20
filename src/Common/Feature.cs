namespace DevToolbox.Common {

    public struct Feature {
        public string DisplayName { get; private set; }
        public string SpecificationName { get; private set; }
        public string Description { get; private set; }
        public string DefaultValue { get; private set; }

        /// <summary>
        /// Describe a permission-policy browser feature.
        /// </summary>
        /// <param name="displayName">The English display name for the browser feature.</param>
        /// <param name="specificationName">The name as outlined in the W3C specification.</param>
        /// <param name="description">A short description of the browser feature.</param>
        public Feature(string displayName, string specificationName, string defaultValue, string description = null) {
            DisplayName = displayName.ThrowIfNullOrWhiteSpace(nameof(displayName));
            SpecificationName = specificationName.ThrowIfNullOrWhiteSpace(nameof(specificationName));
            DefaultValue = defaultValue.ThrowIfNullOrWhiteSpace(nameof(defaultValue));
            Description = description;
        }
    }
}