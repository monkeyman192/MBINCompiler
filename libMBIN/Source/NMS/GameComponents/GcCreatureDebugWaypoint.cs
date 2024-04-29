namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAAD25B219A153186, NameHash = 0x4C03886F1A1C1DF7)]
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
