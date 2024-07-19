namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6932E051A4A23022, NameHash = 0xEBF66E98)]
    public class GcHand : NMSTemplate
    {
        // size: 0x2
        public enum HandEnum : uint {
            Right,
            Left,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public HandEnum Hand;
    }
}
