using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8F9691F4B2D4C5C2, NameHash = 0xBBF73DB3)]
    public class GcVehicleCargoData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public Vector3f DirectionAt;
        [NMS(Index = 2)]
        /* 0x10 */ public Vector3f DirectionRight;
        [NMS(Index = 3)]
        /* 0x20 */ public Vector3f DirectionUp;
        [NMS(Index = 1)]
        /* 0x30 */ public Vector4f Position;
        [NMS(Index = 0)]
        /* 0x40 */ public GcResourceElement Resource;
        [NMS(Index = 5)]
        /* 0x88 */ public NMSString0x10 MissionID;
        [NMS(Index = 7)]
        /* 0x98 */ public ulong DestinationUA;
        [NMS(Index = 6)]
        /* 0xA0 */ public ulong MissionSeed;
    }
}
