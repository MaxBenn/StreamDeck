using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI_Testing.Enumerations
{
    public enum SmartlockStatesEnum
    {
        Uncalibrated = 0,
        Locked = 1,
        Unlockning = 2,
        Unlocked = 3,
        Locking = 4,
        Unlatched = 5,
        LockAndGo = 6,
        Unlatching = 7,
        MotorBLocked = 254,
        Undefined = 255
    }
}
