using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE1254953A02A763, NameHash = 0xD3E3A50)]
    public class GcBaseBuildingMaterial : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x20A Id;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x20A LocName;
        [NMS(Index = 0)]
        /* 0x40 */ public TkTextureResource Icon;
        [NMS(Index = 1)]
        /* 0x58 */ public TkTextureResource SwatchImage;
        [NMS(Index = 4)]
        /* 0x70 */ public int MaterialIndex;
    }
}
