using Newtonsoft.Json;

namespace WebAPI_Testing.Models.Smartlock
{
    public class OpenerAdvancedConfig
    {
        [JsonProperty("intercomId")]
        public int IntercomId { get; set; }
        [JsonProperty("busModeSwitch")]
        public int BusModeSwitch { get; set; }
        [JsonProperty("shortCircuitDuration")]
        public int ShortCircuitDuration { get; set; }
        [JsonProperty("electricStrikeDelay")]
        public int ElectricStrikeDelay { get; set; }
        [JsonProperty("randomElectricStrikeDelay")]
        public bool RandomElectricStrikeDelay { get; set; }
        [JsonProperty("electricStrikeDuration")]
        public int ElectricStrikeDuration { get; set; }
        [JsonProperty("disableRtoAfterRing")]
        public bool DisableRtoAfterRing { get; set; }
        [JsonProperty("rtoTimeout")]
        public int RtoTimeout { get; set; }
        [JsonProperty("doorbellSuppression")]
        public int DoorbellSuppression { get; set; }
        [JsonProperty("doorbellSuppressionDuration")]
        public int DoorbellSuppressionDuration { get; set; }
        [JsonProperty("soundRing")]
        public int SoundRing { get; set; }
        [JsonProperty("soundOpen")]
        public int SoundOpen { get; set; }
        [JsonProperty("soundRto")]
        public int SoundRto { get; set; }
        [JsonProperty("soundCm")]
        public int SoundCm { get; set; }
        [JsonProperty("soundConfirmation")]
        public int SoundConfirmation { get; set; }
        [JsonProperty("soundLevel")]
        public int SoundLevel { get; set; }
        [JsonProperty("singleButtonPressAction")]
        public int SingleButtonPressAction { get; set; }
        [JsonProperty("doubleButtonPressAction")]
        public int DoubleButtonPressAction { get; set; }
        [JsonProperty("batteryType")]
        public int BatteryType { get; set; }
        [JsonProperty("automaticBatteryTypeDetection")]
        public bool AutomaticBatteryTypeDetection { get; set; }
        [JsonProperty("autoUpdateEnabled")]
        public bool AutoUpdateEnabled { get; set; }
        [JsonProperty("operationId")]
        public string OperationId { get; set; }
    }
}
