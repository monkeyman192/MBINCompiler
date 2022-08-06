using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x10692FF958716FAA, NameHash = 0x3E0D2E6A5C1DE7AD)]
    public class GcSentinelSpawnSequenceGroup : NMSTemplate
    {
        /* 0x00 */ public GcSentinelSpawnSequence Sequence;
        /* 0x10 */ public GcSentinelSpawnSequence ExtremeSequence;
    }
}
