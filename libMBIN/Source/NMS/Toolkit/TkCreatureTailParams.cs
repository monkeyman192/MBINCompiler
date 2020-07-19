﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x70, GUID = 0xB1D3E5A18DCDD9C7, NameHash = 0xF5A68FEB65BA7107)]
    public class TkCreatureTailParams : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string PartName;
        /* 0x20 */ public List<TkCreatureTailJoints> Joints;
        /* 0x30 */ public float AnimationMix;
        /* 0x34 */ public float SwimSpeed;
        /* 0x38 */ public float SwimReps;
        /* 0x3C */ public float MaxTurnForSwim;
        /* 0x40 */ public float SwimBlendInTime;
        /* 0x44 */ public float SwimBlendOutTime;
        /* 0x48 */ public float SwimMagnitude;
        /* 0x4C */ public float SwimRollMagnitude;
        /* 0x50 */ public float SwimFallOffBegin;
        /* 0x54 */ public float SwimFallOffEnd;
        /* 0x58 */ public float MinSwimStrength;
        /* 0x5C */ public bool HorizontalStrokes;
        /* 0x60 */ public List<float> PerBoneSwimStrength;
    }
}