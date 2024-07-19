namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x67E7745DA24F94EF, NameHash = 0x7A5AE09C)]
    public class GcMultitoolPoolType : NMSTemplate
    {
        // size: 0x4
        public enum MultiToolPoolTypeEnum : uint {
            Standard,
            Exotic,
            Sentinel,
            Atlas,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MultiToolPoolTypeEnum MultiToolPoolType;
    }
}
