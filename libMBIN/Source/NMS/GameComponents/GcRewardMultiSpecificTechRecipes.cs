using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB2FA3A7BA33B4B6A, NameHash = 0x345E30DE4D2B5AAC)]
    public class GcRewardMultiSpecificTechRecipes : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A SetName;
        /* 0x20 */ public NMSString0x10 DisplayTechId;
        /* 0x30 */ public List<NMSString0x10> TechIds;
        /* 0x40 */ public bool Silent;
    }
}
