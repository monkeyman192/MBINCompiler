using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCC51DBE8F0234DD0, NameHash = 0x2D9EAD5F5CF5EAF6)]
    public class GcCostProcProduct : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x0 */ public int FreighterPasswordIndex;
        [NMS(Index = 2)]
        /* 0x4 */ public GcRarity Rarity;
        [NMS(Index = 0)]
        /* 0x8 */ public GcProceduralProductCategory Type;
        [NMS(Index = 1)]
        /* 0xC */ public bool CareAboutRarity;
    }
}
