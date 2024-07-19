namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF3CE45267031CFFA, NameHash = 0x53BA0F12)]
    public class GcStatTrackType : NMSTemplate
    {
        // size: 0x4
        public enum StatTrackTypeEnum : uint {
            Set,
            Add,
            Max,
            Min,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public StatTrackTypeEnum StatTrackType;
    }
}
