using System.Collections.Generic;
using Newtonsoft.Json;

namespace NukiControlCenter.models.SmartLock;

public class SmartdoorAdvancedConfig
{
    [JsonProperty("lngTimeout")] public int LngTimeout { get; set; }

    [JsonProperty("singleButtonPressAction")]
    public int SingleButtonPressAction { get; set; }

    [JsonProperty("doubleButtonPressAction")]
    public int DoubleButtonPressAction { get; set; }

    [JsonProperty("automaticBatteryTypeDetection")]
    public bool AutomaticBatteryTypeDetection { get; set; }

    [JsonProperty("unlatchDuration")] public int UnlatchDuration { get; set; }

    [JsonProperty("operationId")] public string OperationId { get; set; }

    [JsonProperty("buzzerVolume")] public int BuzzerVolume { get; set; }

    [JsonProperty("supportedBatteryTypes")]
    public IList<int> SupportedBatteryTypes { get; set; }

    [JsonProperty("batteryType")] public int BatteryType { get; set; }

    [JsonProperty("autoLockTimeout")] public int AutoLockTimeout { get; set; }

    [JsonProperty("autoLock")] public bool AutoLock { get; set; }
}