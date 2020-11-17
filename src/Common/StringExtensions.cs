using System;

namespace DevToolbox.Common {
    
    public static class StringExtensions {

        public static string ThrowIfNullOrWhiteSpace(this string value, string parameterName) {
            
            if (string.IsNullOrWhiteSpace(value)) {
                throw new ArgumentException($"Argument cannot be null, empty, or white space.", parameterName);
            }

            return value;
        }
    }
}