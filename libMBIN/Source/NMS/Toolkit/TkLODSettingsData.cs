﻿using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x8C, GUID = 0x9F5204A016CF5572, NameHash = 0xA0C253D5A5EF8A51)]
    public class TkLODSettingsData : NMSTemplate
    {
        [NMS(Size = 5)]
        /* 0x00 */ public float[] LODAdjust;
        [NMS(Size = 0x6)]
        /* 0x14 */ public int[] ImposterOverrideRange;
        [NMS(Size = 0x6)]
        /* 0x2C */ public int[] MaxObjectDistanceOverride;
        [NMS(Size = 0x6)]
        /* 0x44 */ public int[] RegionLODHiddenRanges;
        [NMS(Size = 0x6)]
        /* 0x5C */ public int[] RegionLODRadius;
        /* 0x74 */ public int NumberOfImposterViews;
        /* 0x78 */ public int ImposterResolutionMultiplier;
        /* 0x7C */ public int AsteroidCountMultiplier;
        /* 0x80 */ public int AsteroidDividerMultiplier;
        /* 0x84 */ public int MaxAsteroidGenerationPerFrame;
        /* 0x88 */ public int MaxAsteroidGenerationPerFramePulseJump;
    }
}
