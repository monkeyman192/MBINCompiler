namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xACAF195392879AE9, NameHash = 0x4C03886F1A1C1DF7)]
    public class GcCreatureDebugWaypoint : NMSTemplate
    {
        /* 0x00 */ public Vector3f Position;
        /* 0x10 */ public NMSString0x10 Anim;
        /* 0x20 */ public float Time;
        // size: 0x3
        public enum WaypointTypeEnum : uint {
            Move,
            MoveAlt,
            Idle,
        }
        /* 0x24 */ public WaypointTypeEnum WaypointType;
    }
}
