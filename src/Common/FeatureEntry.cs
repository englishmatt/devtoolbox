using System.Collections.Generic;

namespace DevToolbox.Common {

    public class FeatureEntry {
        public Feature? Feature { get; set; }
        public List<string> AllowList { get; set; }

        public FeatureEntry() : this(null, new List<string>()) {}
        public FeatureEntry(List<string> allowList) : this(null, allowList) {}
        public FeatureEntry(Feature? feature, List<string> allowList) {
            Feature = feature;
            AllowList = allowList;
        }
    }
}