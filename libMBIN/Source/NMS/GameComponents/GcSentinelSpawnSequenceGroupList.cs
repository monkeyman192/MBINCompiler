using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7BDFA844075EE398, NameHash = 0xA4724D07435E3B7C)]
    public class GcSentinelSpawnSequenceGroupList : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> Sequences;
        /* 0x10 */ public List<NMSString0x10> ExtremeSequences;
    }
}
