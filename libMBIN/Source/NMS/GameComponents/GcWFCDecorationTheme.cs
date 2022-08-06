using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA294FEFB3705BB98, NameHash = 0x9634E2763C4B5D4D)]
    public class GcWFCDecorationTheme : NMSTemplate
    {
        // size: 0x2
        public enum WFCDecorationThemeEnum { Default, Construction }
        public WFCDecorationThemeEnum WFCDecorationTheme;
    }
}
