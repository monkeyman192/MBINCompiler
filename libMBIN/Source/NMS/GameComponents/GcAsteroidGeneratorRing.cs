using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE2A0221A65B6E965, NameHash = 0x79403B157D846B70)]
    public class GcAsteroidGeneratorRing : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public Vector3f Rotation;
        [NMS(Index = 0)]
        /* 0x10 */ public GcAsteroidGeneratorAssignment Assignment;
        [NMS(Index = 1)]
        /* 0x58 */ public float LowerRadius;
        [NMS(Index = 4)]
        /* 0x5C */ public int OffBalance;
        [NMS(Index = 7)]
        /* 0x60 */ public float PushAmount;
        [NMS(Index = 3)]
        /* 0x64 */ public float PushRadius;
        [NMS(Index = 2)]
        /* 0x68 */ public float UpperRadius;
        [NMS(Index = 6)]
        /* 0x6C */ public float USpread;
        [NMS(Index = 8)]
        /* 0x70 */ public bool FlipPush;
    }
}
