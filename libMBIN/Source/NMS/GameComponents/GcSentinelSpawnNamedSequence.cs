using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x878F5FB0496D8F64, NameHash = 0x77C3FF3D0260D091)]
    public class GcSentinelSpawnNamedSequence : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public List<GcSentinelSpawnSequence> Waves;
    }
}
