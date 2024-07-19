namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x45C7C9E0AD9B71DD, NameHash = 0xDE0BB566)]
    public class GcWFCDecorationTheme : NMSTemplate
    {
        // size: 0x2
        public enum WFCDecorationThemeEnum : uint {
            Default,
            Construction,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WFCDecorationThemeEnum WFCDecorationTheme;
    }
}
