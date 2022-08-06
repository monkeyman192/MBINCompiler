using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA4BE81525C91552D, NameHash = 0x1316C386517581C1)]
    public class GcRewardPlanetSubstance : NMSTemplate
    {
        public int AmountMin;
        public int AmountMax;
        public float HardModeMultiplier;
        public bool DisableMultiplier;
        public bool RewardAsBlobs;
        public bool UseFuelMultiplier;
    }
}
