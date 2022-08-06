using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAAD5573638121B5E, NameHash = 0x0A420A86F131CF88)]
    public class GcMissionConditionPercentageChance : NMSTemplate
    {
        /* 0x0 */ public int Percent;
        /* 0x4 */ public bool Seeded;
        /* 0x5 */ public bool OverrideZeroSeed;
        /* 0x6 */ public bool OverrideMissionSeedWithRandomSeed;
    }
}
