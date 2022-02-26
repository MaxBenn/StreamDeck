using Newtonsoft.Json;
using System.Collections.Generic;


namespace WebAPI_Testing.Models.Smartlock
{
    public class WebConfig
    {
        [JsonProperty("batteryWarningPerMailEnabled")]
        public bool BatteryWarningPerMailEnabled { get; set; }
    }
}
