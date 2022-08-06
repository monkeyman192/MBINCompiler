using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x375F19EC118EDA9F, NameHash = 0x5CF9A5D0C4877494)]
    public class GcSentinelSpawnWave : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public List<GcSentinelSpawnData> Spawns;
        /* 0x20 */ public int ReinforceAt;
    }
}
