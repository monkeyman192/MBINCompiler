using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x3FB7925A5726DFD9, NameHash = 0x56A47F95DD76DC72)]
    public class TkEmitFromParticleInfo : NMSTemplate
    {
        /* 0x0 */ public int OtherEmitterIndex;
        // size: 0x2
        public enum EmissionRateTypeEnum { PerParticle, Distance }
        /* 0x4 */ public EmissionRateTypeEnum EmissionRateType;
    }
}
