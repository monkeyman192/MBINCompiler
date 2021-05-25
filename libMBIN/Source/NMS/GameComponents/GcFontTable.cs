using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x420, GUID = 0xB9913A609DA490D3, NameHash = 0xD77829A90743F12E)]
    public class GcFontTable : NMSTemplate
    {
        [NMS(Size = 0x8, EnumType = typeof(GcFontTypesEnum.FontEnum))]
        public GcFontData[] Table;
    }
}