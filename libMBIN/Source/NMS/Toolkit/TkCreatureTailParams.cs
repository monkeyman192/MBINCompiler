using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4EBCA4EEA1161646, NameHash = 0xF5A68FEB65BA7107)]
    public class TkCreatureTailParams : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A PartName;
        [NMS(Index = 1)]
        /* 0x20 */ public List<TkCreatureTailJoints> Joints;
        [NMS(Index = 14)]
        /* 0x30 */ public List<float> PerBoneSwimStrength;
        [NMS(Index = 2)]
        /* 0x40 */ public float AnimationMix;
        [NMS(Index = 5)]
        /* 0x44 */ public float MaxTurnForSwim;
        [NMS(Index = 12)]
        /* 0x48 */ public float MinSwimStrength;
        [NMS(Index = 6)]
        /* 0x4C */ public float SwimBlendInTime;
        [NMS(Index = 7)]
        /* 0x50 */ public float SwimBlendOutTime;
        [NMS(Index = 10)]
        /* 0x54 */ public float SwimFallOffBegin;
        [NMS(Index = 11)]
        /* 0x58 */ public float SwimFallOffEnd;
        [NMS(Index = 8)]
        /* 0x5C */ public float SwimMagnitude;
        [NMS(Index = 4)]
        /* 0x60 */ public float SwimReps;
        [NMS(Index = 9)]
        /* 0x64 */ public float SwimRollMagnitude;
        [NMS(Index = 3)]
        /* 0x68 */ public float SwimSpeed;
        [NMS(Index = 13)]
        /* 0x6C */ public bool HorizontalStrokes;
    }
}
