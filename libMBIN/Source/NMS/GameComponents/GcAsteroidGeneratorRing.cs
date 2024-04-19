using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFEAAE4F2806F9584, NameHash = 0x79403B157D846B70)]
    public class GcAsteroidGeneratorRing : NMSTemplate
    {
        /* 0x00 */ public Vector3f Rotation;
        /* 0x10 */ public GcAsteroidGeneratorAssignment Assignment;
        /* 0x58 */ public float LowerRadius;
        /* 0x5C */ public int OffBalance;
        /* 0x60 */ public float PushAmount;
        /* 0x64 */ public float PushRadius;
        /* 0x68 */ public float UpperRadius;
        /* 0x6C */ public float USpread;
        /* 0x70 */ public bool FlipPush;
    }
}
