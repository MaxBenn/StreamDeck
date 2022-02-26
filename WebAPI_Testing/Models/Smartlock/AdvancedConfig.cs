using Newtonsoft.Json;

namespace WebAPI_Testing.Models.Smartlock
{
    public class AdvancedConfig
    {
        [JsonProperty("totalDegrees")]
        public int TotalDegrees { get; set; }
        [JsonProperty("singleLockedPositionOffsetDegrees")]
        public int SingleLockedPositionOffsetDegrees { get; set; }
        [JsonProperty("unlockedToLockedTransitionOffsetDegrees")]
        public int UnlockedToLockedTransitionOffsetDegrees { get; set; }
        [JsonProperty("unlockedPositionOffsetDegrees")]
        public int UnlockedPositionOffsetDegrees { get; set; }
        [JsonProperty("lockedPositionOffsetDegrees")]
        public int LockedPositionOffsetDegrees { get; set; }
        [JsonProperty("detachedCylinder")]
        public bool DetachedCylinder { get; set; }
        [JsonProperty("batteryType")]
        public int BatteryType { get; set; }
        [JsonProperty("autoLock")]
        public bool AutoLock { get; set; }
        [JsonProperty("autoLockTimeout")]
        public int AutoLockTimeout { get; set; }
        [JsonProperty("autoUpdateEnabled")]
        public bool AutoUpdateEnabled { get; set; }
        [JsonProperty("lngTimeout")]
        public int LngTimeout { get; set; }
        [JsonProperty("singleButtonPressAction")]
        public int SingleButtonPressAction { get; set; }
        [JsonProperty("doubleButtonPressAction")]
        public int DoubleButtonPressAction { get; set; }
        [JsonProperty("automaticBatteryTypeDetection")]
        public bool AutomaticBatteryTypeDetection { get; set; }
        [JsonProperty("unlatchDuration")]
        public int UnlatchDuration { get; set; }
    }
}
