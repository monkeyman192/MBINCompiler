namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBEA479D78D467F2B, NameHash = 0x71FCE9DED22FE107)]
    public class GcRainbowType : NMSTemplate
    {
        // size: 0x4
        public enum RainbowTypeEnum : uint {
            Always,
            Occasional,
            Storm,
            None,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public RainbowTypeEnum RainbowType;
    }
}
