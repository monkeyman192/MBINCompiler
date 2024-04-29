using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x36D1073B58311D08, NameHash = 0x4CF465C68C10EBB4)]
    public class GcTextPreset : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public Colour Colour;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSTemplate Style;
        [NMS(Index = 0)]
        /* 0x60 */ public GcFontTypesEnum Font;
        [NMS(Index = 2)]
        /* 0x64 */ public float Height;
    }
}
