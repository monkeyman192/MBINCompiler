using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAA6F1A313DE9CAEF, NameHash = 0x2D9EAD5F5CF5EAF6)]
    public class GcCostProcProduct : NMSTemplate
    {
        /* 0x0 */ public GcProceduralProductCategory Type;
        /* 0x4 */ public bool CareAboutRarity;
        /* 0x8 */ public GcRarity Rarity;
        /* 0xC */ public int FreighterPasswordIndex;
    }
}
