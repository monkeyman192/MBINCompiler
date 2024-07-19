namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x85CFB36DD9D7B295, NameHash = 0x4265CC8)]
    public class GcCreatureDebugWaypoint : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Vector3f Position;
        [NMS(Index = 2)]
        /* 0x10 */ public NMSString0x10 Anim;
        [NMS(Index = 3)]
        /* 0x20 */ public float Time;
        // size: 0x3
        public enum WaypointTypeEnum : uint {
            Move,
            MoveAlt,
            Idle,
        }
        [NMS(Index = 1)]
        /* 0x24 */ public WaypointTypeEnum WaypointType;
    }
}
