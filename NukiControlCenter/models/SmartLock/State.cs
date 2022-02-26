using System;
using Newtonsoft.Json;

namespace NukiControlCenter.models.SmartLock;

public class State
{
    [JsonProperty("mode")] public int Mode { get; set; }

    [JsonProperty("state")] public int StateNum { get; set; }

    [JsonProperty("trigger")] public int Trigger { get; set; }

    [JsonProperty("lastAction")] public int LastAction { get; set; }

    [JsonProperty("batteryCritical")] public bool BatteryCritical { get; set; }

    [JsonProperty("batteryCharging")] public bool BatteryCharging { get; set; }

    [JsonProperty("batteryCharge")] public int BatteryCharge { get; set; }

    [JsonProperty("keypadBatteryCritical")]
    public bool KeypadBatteryCritical { get; set; }

    [JsonProperty("doorsensorBatteryCritical")]
    public bool DoorsensorBatteryCritical { get; set; }

    [JsonProperty("doorState")] public int DoorState { get; set; }

    [JsonProperty("ringToOpenTimer")] public int RingToOpenTimer { get; set; }

    [JsonProperty("ringToOpenEnd")] public DateTime RingToOpenEnd { get; set; }

    [JsonProperty("nightMode")] public bool NightMode { get; set; }

    [JsonProperty("operationId")] public string OperationId { get; set; }
}