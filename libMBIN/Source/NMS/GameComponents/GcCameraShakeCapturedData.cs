using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1B2372A3A018B4AD, NameHash = 0x472B5C1A8B3B1505)]
    public class GcCameraShakeCapturedData : NMSTemplate
    {
        /* 0x00 */ public bool Active;
        /* 0x04 */ public float ShakeStrength;
        /* 0x08 */ public float ShakeFrequency;
        /* 0x0C */ public float VibrateStrength;
        /* 0x10 */ public float VibrateFrequency;
    }
}
