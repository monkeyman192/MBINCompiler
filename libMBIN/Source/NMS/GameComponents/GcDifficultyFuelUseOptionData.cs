using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7FCD2F452A6EFA21, NameHash = 0xAB29B756)]
    public class GcDifficultyFuelUseOptionData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcDifficultyFuelUseTechOverride> TechOverrides;
        [NMS(Index = 0)]
        /* 0x10 */ public float Multiplier;
    }
}
