using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCB65338D464D99DD, NameHash = 0x4FA3A2D9F8D4A156)]
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
