using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCCD44B53AD6E8177, NameHash = 0x87FB8E825C599E66)]
    public class GcDefaultMissionItemsTable : NMSTemplate
    {
        /* 0x00 */ public List<GcDefaultMissionProduct> PrimaryProducts;
        /* 0x10 */ public List<GcDefaultMissionSubstance> PrimarySubstances;
        /* 0x20 */ public List<GcDefaultMissionProduct> SecondaryProducts;
        /* 0x30 */ public List<GcDefaultMissionSubstance> SecondarySubstances;
        /* 0x40 */ public int AmountMax;
        /* 0x44 */ public int AmountMin;
        /* 0x48 */ public bool AmountShouldBeRoundNumber;
    }
}
