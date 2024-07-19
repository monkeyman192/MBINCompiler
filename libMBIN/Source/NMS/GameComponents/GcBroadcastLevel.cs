namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3BCCD8E73F2DF785, NameHash = 0xB21C5F1F)]
    public class GcBroadcastLevel : NMSTemplate
    {
        // size: 0x3
        public enum BroadcastLevelEnum : uint {
            Scene,
            LocalModel,
            Local,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BroadcastLevelEnum BroadcastLevel;
    }
}
