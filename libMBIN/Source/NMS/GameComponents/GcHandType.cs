namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x334EDF32B8C9D755, NameHash = 0x75D1B9298B017E0)]
    public class GcHandType : NMSTemplate
    {
        // size: 0x2
        public enum HandTypeEnum : uint {
            Offhand,
            Dominant,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public HandTypeEnum HandType;
    }
}
