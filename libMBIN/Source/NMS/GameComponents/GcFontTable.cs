using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF2D00947D92DFB8A, NameHash = 0xD77829A90743F12E)]
    public class GcFontTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x8, EnumType = typeof(GcFontTypesEnum.FontEnum))]
        /* 0x0 */ public GcFontData[] Table;
    }
}
