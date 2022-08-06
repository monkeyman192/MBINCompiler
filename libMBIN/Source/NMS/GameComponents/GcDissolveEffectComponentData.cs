using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x260CA4DBC9210432, NameHash = 0x7BBDF0D5167BC705)]
    public class GcDissolveEffectComponentData : NMSTemplate
    {
        /* 0x0 */ public float DissolveBeginHeight;
        /* 0x4 */ public float DissolveEndHeight;
    }
}
