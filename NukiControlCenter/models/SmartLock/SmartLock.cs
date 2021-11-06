using Newtonsoft.Json;
using System;

namespace NukiControlCenter.models.SmartLock
{
    public class SmartLock
    {
        [JsonProperty("smartlockId")]
        public int SmartlockId { get; set; }
        [JsonProperty("accountId")]
        public int AccountId { get; set; }
        [JsonProperty("type")]
        public int Type { get; set; }
        [JsonProperty("lmType")]
        public int LmType { get; set; }
        [JsonProperty("authId")]
        public int AuthId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("favorite")]
        public bool Favorite { get; set; }
        [JsonProperty("config")]
        public Config Config { get; set; }
        [JsonProperty("advancedConfig")]
        public AdvancedConfig AdvancedConfig { get; set; }
        [JsonProperty("openerAdvancedConfig")]
        public OpenerAdvancedConfig OpenerAdvancedConfig { get; set; }
        [JsonProperty("smartdoorAdvancedConfig")]
        public SmartdoorAdvancedConfig SmartdoorAdvancedConfig { get; set; }
        [JsonProperty("webConfig")]
        public WebConfig WebConfig { get; set; }
        [JsonProperty("state")]
        public State State { get; set; }
        [JsonProperty("firmwareVersion")]
        public int FirmwareVersion { get; set; }
        [JsonProperty("hardwareVersion")]
        public int HardwareVersion { get; set; }
        [JsonProperty("operationId")]
        public string OperationId { get; set; }
        [JsonProperty("serverState")]
        public int ServerState { get; set; }
        [JsonProperty("adminPinState")]
        public int AdminPinState { get; set; }
        [JsonProperty("virtualDevice")]
        public bool VirtualDevice { get; set; }
        [JsonProperty("creationDate")]
        public DateTime CreationDate { get; set; }
        [JsonProperty("updateDate")]
        public DateTime UpdateDate { get; set; }
        [JsonProperty("opener")]
        public bool Opener { get; set; }
        [JsonProperty("box")]
        public bool Box { get; set; }
        [JsonProperty("smartDoor")]
        public bool SmartDoor { get; set; }
        [JsonProperty("keyturner")]
        public bool Keyturner { get; set; }
        [JsonProperty("smartlock3")]
        public bool Smartlock3 { get; set; }
    }
}
