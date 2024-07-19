namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8651BD546374F982, NameHash = 0xF9224EEE)]
    public class GcTrackedPosition : NMSTemplate
    {
        // size: 0x4
        public enum TrackedPositionEnum : uint {
            GameCamera,
            ActiveCamera,
            DebugCamera,
            Frozen,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public TrackedPositionEnum TrackedPosition;
    }
}
