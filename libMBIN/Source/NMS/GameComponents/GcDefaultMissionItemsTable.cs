using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCCD44B53AD6E8177, NameHash = 0x87FB8E825C599E66)]
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
