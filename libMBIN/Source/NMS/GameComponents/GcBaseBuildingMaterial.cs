using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2FF161ED46008665, NameHash = 0x83E238320B2BEE42)]
    public class GcBaseBuildingMaterial : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public NMSString0x20A Id;
        [NMS(Index = 2)]
        /* 0x020 */ public NMSString0x20A LocName;
        [NMS(Index = 0)]
        /* 0x040 */ public TkTextureResource Icon;
        [NMS(Index = 1)]
        /* 0x0C4 */ public TkTextureResource SwatchImage;
        [NMS(Index = 4)]
        /* 0x148 */ public int MaterialIndex;
    }
}
