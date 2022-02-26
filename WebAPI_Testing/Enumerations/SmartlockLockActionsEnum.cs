using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI_Testing.Enumerations
{
    public enum SmartlockLockActionsEnum
    {
        Unlock = 1,
        Lock = 2,
        Unlatch = 3,
        LockAndGo = 4,
        LockAndGoWithUnlatch = 5
    }
}
