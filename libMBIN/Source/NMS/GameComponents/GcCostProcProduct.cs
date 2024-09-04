using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB94233C2608AA4E9, NameHash = 0xA3002A5E)]
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
