namespace DevToolbox.Common {
    
    public static class Features {

        public static Feature Accelerometer { get; } = new Feature("Accelerometer", "accelerometer");
        public static Feature Fullscreen { get; } = new Feature("Fullscreen", "fullscreen");
    }
}