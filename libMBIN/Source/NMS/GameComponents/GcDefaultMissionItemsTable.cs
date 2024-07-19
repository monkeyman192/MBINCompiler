using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x58801C3BF4A27E94, NameHash = 0xDD5B7E25)]
    public class GcDefaultMissionItemsTable : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<GcDefaultMissionProduct> PrimaryProducts;
        [NMS(Index = 0)]
        /* 0x10 */ public List<GcDefaultMissionSubstance> PrimarySubstances;
        [NMS(Index = 3)]
        /* 0x20 */ public List<GcDefaultMissionProduct> SecondaryProducts;
        [NMS(Index = 1)]
        /* 0x30 */ public List<GcDefaultMissionSubstance> SecondarySubstances;
        [NMS(Index = 5)]
        /* 0x40 */ public int AmountMax;
        [NMS(Index = 4)]
        /* 0x44 */ public int AmountMin;
        [NMS(Index = 6)]
        /* 0x48 */ public bool AmountShouldBeRoundNumber;
    }
}
