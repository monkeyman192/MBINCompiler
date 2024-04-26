using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB2FA3A7BA33B4B6A, NameHash = 0x345E30DE4D2B5AAC)]
    public class GcRewardMultiSpecificTechRecipes : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A SetName;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 DisplayTechId;
        [NMS(Index = 0)]
        /* 0x30 */ public List<NMSString0x10> TechIds;
        [NMS(Index = 3)]
        /* 0x40 */ public bool Silent;
    }
}
