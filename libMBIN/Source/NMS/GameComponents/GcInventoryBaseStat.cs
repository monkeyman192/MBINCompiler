using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE4FB8808C5C7E2D5, NameHash = 0x88CEC164B6BD4ACC)]
    public class GcInventoryBaseStat : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 BaseStatID;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 LocID;
        [NMS(Index = 2)]
        /* 0x20 */ public List<GcInventoryBaseStatBonus> StatBonus;
    }
}
