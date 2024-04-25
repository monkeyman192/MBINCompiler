using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x87720DEB48C82097, NameHash = 0xDBFECF3462D8A0FB)]
    public class GcRewardDisguisedProduct : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x10 AwardDisplayIDDuringMission;
        [NMS(Index = 2)]
        /* 0x10 */ public NMSString0x10 DisplayAs;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 ID;
        [NMS(Index = 6)]
        /* 0x30 */ public int AmountMax;
        [NMS(Index = 5)]
        /* 0x34 */ public int AmountMin;
        [NMS(Index = 0)]
        /* 0x38 */ public GcDefaultMissionProductEnum Default;
        [NMS(Index = 4)]
        /* 0x3C */ public bool UseDisplayIDWhenInShip;
    }
}
