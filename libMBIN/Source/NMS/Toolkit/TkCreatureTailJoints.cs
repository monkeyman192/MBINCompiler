namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC6CBA4BB1305622B, NameHash = 0x38D7F8085AD4CE3)]
    public class TkCreatureTailJoints : NMSTemplate
    {
        /* 0x00 */ public float InterpSpeedHead;
        /* 0x04 */ public float InterpSpeedTail;
        /* 0x08 */ public float PullSpeedMax;
        /* 0x0C */ public float PullSpeedMin;
        /* 0x10 */ public float StrengthX;
        /* 0x14 */ public float StrengthY;
        /* 0x18 */ public float StrengthZ;
        /* 0x1C */ public float SwimPhaseOffset;
        /* 0x20 */ public NMSString0x20 EndJoint;
        /* 0x40 */ public NMSString0x20 StartJoint;
    }
}
