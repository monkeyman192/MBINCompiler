namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF475D8148BCB47B8, NameHash = 0xD4250E55)]
    public class GcFonts : NMSTemplate
    {
        // size: 0x4
        public enum FontTypeEnum : uint {
            Body,
            Title,
            Console1,
            Console2,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FontTypeEnum FontType;
    }
}
