using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x994CED33741E97D, NameHash = 0xD929BD1550793EC2)]
    public class GcRagdollComponentData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<GcRagdollBone> RagdollBones;
        [NMS(Index = 4)]
        /* 0x10 */ public float JointDamping;
        [NMS(Index = 5)]
        /* 0x14 */ public float JointFriction;
        [NMS(Index = 3)]
        /* 0x18 */ public float JointTau;
        [NMS(Index = 6)]
        /* 0x1C */ public float ModelScaleAtCreation;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x40 Name;
        [NMS(Index = 0)]
        /* 0x60 */ public bool Enabled;
    }
}
