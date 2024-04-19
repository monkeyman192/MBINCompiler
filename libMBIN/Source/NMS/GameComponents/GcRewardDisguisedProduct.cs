using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x87720DEB48C82097, NameHash = 0xDBFECF3462D8A0FB)]
    public class GcRewardDisguisedProduct : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 AwardDisplayIDDuringMission;
        /* 0x10 */ public NMSString0x10 DisplayAs;
        /* 0x20 */ public NMSString0x10 ID;
        /* 0x30 */ public int AmountMax;
        /* 0x34 */ public int AmountMin;
        /* 0x38 */ public GcDefaultMissionProductEnum Default;
        /* 0x3C */ public bool UseDisplayIDWhenInShip;
    }
}
