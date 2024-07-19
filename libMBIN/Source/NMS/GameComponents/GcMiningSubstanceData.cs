using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBA2D2B57E518C962, NameHash = 0x3AC2A8D7)]
    public class GcMiningSubstanceData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public GcRarity Rarity;
        [NMS(Index = 0)]
        /* 0x4 */ public GcRealitySubstanceCategory SubstanceCategory;
        [NMS(Index = 1)]
        /* 0x8 */ public bool UseRarity;
    }
}
