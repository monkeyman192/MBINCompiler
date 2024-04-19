namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1359BFE0E49D8680, NameHash = 0xB7FEFB0DFC120BF4)]
    public class GcShipAIPlanetPatrolData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Squad;
        /* 0x10 */ public float AlignForce;
        /* 0x14 */ public float AlongPathForce;
        /* 0x18 */ public float BrakeForce;
        /* 0x1C */ public float PathOffset;
        /* 0x20 */ public float PathSpeed;
        /* 0x24 */ public float PlayerFalloff;
        /* 0x28 */ public float PlayerOffset;
        /* 0x2C */ public float ToPathForce;
        /* 0x30 */ public float WaypointDistance;
    }
}
