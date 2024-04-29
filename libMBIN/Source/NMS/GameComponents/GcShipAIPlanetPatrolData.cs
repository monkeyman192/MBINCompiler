namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3F6CADAE53B45555, NameHash = 0xB7FEFB0DFC120BF4)]
    public class GcShipAIPlanetPatrolData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Squad;
        [NMS(Index = 9)]
        /* 0x10 */ public float AlignForce;
        [NMS(Index = 6)]
        /* 0x14 */ public float AlongPathForce;
        [NMS(Index = 8)]
        /* 0x18 */ public float BrakeForce;
        [NMS(Index = 3)]
        /* 0x1C */ public float PathOffset;
        [NMS(Index = 5)]
        /* 0x20 */ public float PathSpeed;
        [NMS(Index = 2)]
        /* 0x24 */ public float PlayerFalloff;
        [NMS(Index = 1)]
        /* 0x28 */ public float PlayerOffset;
        [NMS(Index = 7)]
        /* 0x2C */ public float ToPathForce;
        [NMS(Index = 4)]
        /* 0x30 */ public float WaypointDistance;
    }
}
