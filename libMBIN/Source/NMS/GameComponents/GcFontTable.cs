using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA6374DF7111C29AC, NameHash = 0xD77829A90743F12E)]
    public class GcFontTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x8, EnumType = typeof(GcFontTypesEnum.FontEnum))]
        /* 0x0 */ public GcFontData[] Table;
    }
}
