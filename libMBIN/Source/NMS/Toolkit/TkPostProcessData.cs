using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x07629102C1581415, NameHash = 0xF95FF845E00A143C)]
    public class TkPostProcessData : NMSTemplate
    {
        /* 0x00 */ public float DOFNearPlane;
        /* 0x04 */ public float DOFFarPlane;
        /* 0x08 */ public float DOFNearAmount;
        /* 0x0C */ public float DOFFarAmount;
        /* 0x10 */ public float SaturationDepth;
        /* 0x14 */ public float BrightnessDepth;
        /* 0x18 */ public float ContrastDepth;
        /* 0x1C */ public float SaturationFinal;
        /* 0x20 */ public float BrightnessFinal;
        /* 0x24 */ public float ContrastFinal;
    }
}
