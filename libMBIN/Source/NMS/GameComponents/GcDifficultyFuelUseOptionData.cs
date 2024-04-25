using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDDB5F6B408399220, NameHash = 0x15072D4E11178622)]
    public class GcDifficultyFuelUseOptionData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcDifficultyFuelUseTechOverride> TechOverrides;
        [NMS(Index = 0)]
        /* 0x10 */ public float Multiplier;
    }
}
