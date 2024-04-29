using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x54B41083BEBB858D, NameHash = 0xF0A6F41B4CF7E771)]
    public class GcCollisionCapsule : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public AxisSpecification CapsuleAxis;
        [NMS(Index = 3)]
        /* 0x20 */ public Vector3f CapsuleCentre;
        [NMS(Index = 6)]
        /* 0x30 */ public float CapsuleLength;
        [NMS(Index = 5)]
        /* 0x34 */ public float CapsuleRadius;
        [NMS(Index = 1)]
        /* 0x38 */ public NMSString0x40 Name;
        [NMS(Index = 2)]
        /* 0x78 */ public NMSString0x40 NodeName;
        [NMS(Index = 0)]
        /* 0xB8 */ public bool Enabled;
        [NMS(Index = 7)]
        /* 0xB9 */ public bool ImproveCollisionForNarrowCapsule;
    }
}
