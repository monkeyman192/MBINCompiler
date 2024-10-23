using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x240C0089607D42B0, NameHash = 0x235B3D6D)]
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
