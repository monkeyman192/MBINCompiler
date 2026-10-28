using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2BEC7DCDAF09CD4E, NameHash = 0x84225C36)]
    public class GcSolarSystemMapObjectData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Colour PopupHeaderColour;
        [NMS(Index = 3)]
        /* 0x10 */ public NMSString0x20A Description;
        [NMS(Index = 2)]
        /* 0x30 */ public NMSString0x20A Subtitle;
        [NMS(Index = 6)]
        /* 0x50 */ public TkTextureResource Icon;
        [NMS(Index = 5)]
        /* 0x68 */ public VariableSizeString DescriptionHelpIDs;
        [NMS(Index = 4)]
        /* 0x78 */ public VariableSizeString DescriptionNameIDs;
        [NMS(Index = 0)]
        /* 0x88 */ public GcFilename Resource;
    }
}
