using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6900D314A3A5E2D6, NameHash = 0xF0A6F41B4CF7E771)]
    public class GcCollisionCapsule : NMSTemplate
    {
        /* 0x00 */ public AxisSpecification CapsuleAxis;
        /* 0x20 */ public Vector3f CapsuleCentre;
        /* 0x30 */ public float CapsuleLength;
        /* 0x34 */ public float CapsuleRadius;
        /* 0x38 */ public NMSString0x40 Name;
        /* 0x78 */ public NMSString0x40 NodeName;
        /* 0xB8 */ public bool Enabled;
        /* 0xB9 */ public bool ImproveCollisionForNarrowCapsule;
    }
}
