using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x994CED33741E97D, NameHash = 0xD929BD1550793EC2)]
    public class GcRagdollComponentData : NMSTemplate
    {
        /* 0x00 */ public List<GcRagdollBone> RagdollBones;
        /* 0x10 */ public float JointDamping;
        /* 0x14 */ public float JointFriction;
        /* 0x18 */ public float JointTau;
        /* 0x1C */ public float ModelScaleAtCreation;
        /* 0x20 */ public NMSString0x40 Name;
        /* 0x60 */ public bool Enabled;
    }
}
