using Newtonsoft.Json;

namespace WebAPI_Testing.Models.Smartlock
{
    public class Config
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("latitude")]
        public float Latitude { get; set; }
        [JsonProperty("longitude")]
        public float Longitude { get; set; }
        [JsonProperty("autoUnlatch")]
        public bool AutoUnlatch { get; set; }
        [JsonProperty("liftUpHandle")]
        public bool LiftUpHandle { get; set; }
        [JsonProperty("pairingEnabled")]
        public bool PairingEnabled { get; set; }
        [JsonProperty("buttonEnabled")]
        public bool ButtonEnabled { get; set; }
        [JsonProperty("ledEnabled")]
        public bool LedEnabled { get; set; }
        [JsonProperty("ledBrightness")]
        public int LedBrightness { get; set; }
        [JsonProperty("timezoneOffset")]
        public int TimezoneOffset { get; set; }
        [JsonProperty("daylightSavingMode")]
        public int DaylightSavingMode { get; set; }
        [JsonProperty("fobPaired")]
        public bool FobPaired { get; set; }
        [JsonProperty("fobAction1")]
        public int FobAction1 { get; set; }
        [JsonProperty("fobAction2")]
        public int FobAction2 { get; set; }
        [JsonProperty("fobAction3")]
        public int FobAction3 { get; set; }
        [JsonProperty("singleLock")]
        public bool SingleLock { get; set; }
        [JsonProperty("advertisingMode")]
        public int AdvertisingMode { get; set; }
        [JsonProperty("keypadPaired")]
        public bool KeypadPaired { get; set; }
        [JsonProperty("homekitState")]
        public int HomekitState { get; set; }
        [JsonProperty("timezoneId")]
        public int TimezoneId { get; set; }
    }
}
