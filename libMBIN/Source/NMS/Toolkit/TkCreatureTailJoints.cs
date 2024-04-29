namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8B173502B2F69CDC, NameHash = 0x38D7F8085AD4CE3)]
    public class TkCreatureTailJoints : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public float InterpSpeedHead;
        [NMS(Index = 3)]
        /* 0x04 */ public float InterpSpeedTail;
        [NMS(Index = 5)]
        /* 0x08 */ public float PullSpeedMax;
        [NMS(Index = 4)]
        /* 0x0C */ public float PullSpeedMin;
        [NMS(Index = 6)]
        /* 0x10 */ public float StrengthX;
        [NMS(Index = 7)]
        /* 0x14 */ public float StrengthY;
        [NMS(Index = 8)]
        /* 0x18 */ public float StrengthZ;
        [NMS(Index = 9)]
        /* 0x1C */ public float SwimPhaseOffset;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x20 EndJoint;
        [NMS(Index = 0)]
        /* 0x40 */ public NMSString0x20 StartJoint;
    }
}
