namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x422DB53CD492B6BF, NameHash = 0xF47FD4328A49A000)]
    public class GcPlayerConflictData : NMSTemplate
    {
        // size: 0x4
        public enum ConflictLevelEnum : uint {
            Low,
            Default,
            High,
            Pirate,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ConflictLevelEnum ConflictLevel;
    }
}
