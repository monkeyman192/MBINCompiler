using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2FF161ED46008665, NameHash = 0x83E238320B2BEE42)]
    public class GcBaseBuildingMaterial : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A Id;
        /* 0x020 */ public NMSString0x20A LocName;
        /* 0x040 */ public TkTextureResource Icon;
        /* 0x0C4 */ public TkTextureResource SwatchImage;
        /* 0x148 */ public int MaterialIndex;
    }
}
