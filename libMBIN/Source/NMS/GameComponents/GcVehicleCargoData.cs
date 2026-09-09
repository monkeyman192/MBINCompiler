using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEA7D6786BC1707F5, NameHash = 0xBBF73DB3)]
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
    }
}
