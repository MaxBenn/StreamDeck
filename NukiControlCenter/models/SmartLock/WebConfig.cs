using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NukiControlCenter.models.SmartLock
{
    public class WebConfig
    {
        [JsonProperty("batteryWarningPerMailEnabled")]
        public bool BatteryWarningPerMailEnabled { get; set; }
        [JsonProperty("dismissedLiftUpHandleWarning")]
        public IList<int> DismissedLiftUpHandleWarnings { get; set; }
    }
}
