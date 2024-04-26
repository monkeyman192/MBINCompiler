namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD47702419626C73A, NameHash = 0x3CD82FC9BE1CC713)]
    public class GcOptionsUIHeaderIcons : NMSTemplate
    {
        // size: 0x5
        public enum OptionsUIHeaderIconTypeEnum : uint {
            General,
            Ship,
            Cog,
            Scanner,
            Advanced,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public OptionsUIHeaderIconTypeEnum OptionsUIHeaderIconType;
    }
}
