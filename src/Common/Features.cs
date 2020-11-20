namespace DevToolbox.Common {
    
    public static class Features {
        // See the follow list for details: https://github.com/w3c/webappsec-permissions-policy/blob/master/features.md
        public static Feature Accelerometer { get; } = new Feature("Accelerometer", "accelerometer", "self");
        public static Feature AmbientLightSensor { get; } = new Feature("Ambient light sensor", "ambient-light-sensor", "self");
        public static Feature Autoplay { get; } = new Feature("Autoplay", "autoplay", "self");
        public static Feature Battery { get; } = new Feature("Battery", "battery", "self");
        public static Feature Camera { get; } = new Feature("Camera", "camera", "self");
        public static Feature CrossOriginIsolated { get; } =
            new Feature("Cross-origin isolated", "cross-origin-isolated", "self");
        public static Feature DisplayCapture { get; } = new Feature("Display capture", "display-capture", "self");
        public static Feature DocumentDomain { get; } = new Feature("Document domain", "document-domain", "*");
        public static Feature EncryptedMedia { get; } = new Feature("Encrypted media", "encrypted-media", "self");
        public static Feature ExecutionWhileNotRendered { get; } =
            new Feature("Execution while not rendered", "execution-while-not-rendered", "*");
        public static Feature ExecutionWhileOutOfViewport { get; } =
            new Feature("Execution while out of viewport", "execution-while-out-of-viewport", "*");
        public static Feature Fullscreen { get; } = new Feature("Fullscreen", "fullscreen", "self");
        public static Feature Geolocation { get; } = new Feature("Geolocation", "geolocation", "self");
        public static Feature Gyroscope { get; } = new Feature("Gyroscope", "gyroscope", "self");
        public static Feature Magnetometer { get; } = new Feature("Magnetometer", "magnetometer", "self");
        public static Feature Microphone { get; } = new Feature("Microphone", "microphone", "self");
        public static Feature Midi { get; } = new Feature("Midi", "midi", "self");
        public static Feature NavigationOverride { get; } = new Feature("Navigation override", "navigation-override", "self");
        public static Feature Payment { get; } = new Feature("Payment", "payment", "self");
        public static Feature PictureInPicture { get; } = new Feature("Picture-in-picture", "picture-in-picture", "*");
        public static Feature PublickeyCredentialsGet { get; } =
            new Feature("Publickey credentials get", "publickey-credentials-get", "self");
        public static Feature ScreenWakeLock { get; } = new Feature("Screen wake lock", "screen-wake-lock", "self");
        public static Feature SyncXhr { get; } = new Feature("Sync XHR", "sync-xhr", "*");
        public static Feature Usb { get; } = new Feature("USB", "usb", "self");
        public static Feature WebShare { get; } = new Feature("Web share", "web-share", "self");
        public static Feature XrSpatialTracking { get; } = new Feature("XR spatial tracking", "xr-spatial-tracking", "self");
    }
}