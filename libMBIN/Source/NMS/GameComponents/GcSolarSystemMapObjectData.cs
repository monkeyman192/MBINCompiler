using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x45A634CFFF9547B5, NameHash = 0x84225C36)]
    public class GcSolarSystemMapObjectData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Colour PopupHeaderColour;
        [NMS(Index = 3)]
        /* 0x10 */ public NMSString0x20A Description;
        [NMS(Index = 2)]
        /* 0x30 */ public NMSString0x20A Subtitle;
        [NMS(Index = 4)]
        /* 0x50 */ public TkTextureResource Icon;
        [NMS(Index = 0)]
        /* 0x68 */ public GcFilename Resource;
    }
}
