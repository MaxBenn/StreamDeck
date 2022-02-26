using System.Collections.Generic;
using Newtonsoft.Json;

namespace NukiControlCenter.models.SmartLock;

public class WebConfig
{
    [JsonProperty("batteryWarningPerMailEnabled")]
    public bool BatteryWarningPerMailEnabled { get; set; }

    [JsonProperty("dismissedLiftUpHandleWarning")]
    public IList<int> DismissedLiftUpHandleWarnings { get; set; }
}