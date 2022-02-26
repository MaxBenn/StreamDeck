using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI_Testing.Models.Smartlock
{
    public class State
    {
        [JsonProperty("mode")]
        public int Mode { get; set; }
        [JsonProperty("state")]
        public int StateNum { get; set; }
        [JsonProperty("trigger")]
        public int Trigger { get; set; }
        [JsonProperty("lastAction")]
        public int LastAction { get; set; }
        [JsonProperty("batteryCritical")]
        public bool BatteryCritical { get; set; }
        [JsonProperty("batteryCharging")]
        public bool BatteryCharging { get; set; }
        [JsonProperty("batteryCharge")]
        public int BatteryCharge { get; set; }
        [JsonProperty("keypadBatteryCritical")]
        public bool KeypadBatteryCritical { get; set; }
        [JsonProperty("doorsensorBatteryCritical")]
        public bool DoorsensorBatteryCritical { get; set; }
        [JsonProperty("doorState")]
        public int DoorState { get; set; }
        [JsonProperty("ringToOpenTimer")]
        public int RingToOpenTimer { get; set; }
        [JsonProperty("nightMode")]
        public bool NightMode { get; set; }
    }
}
