using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x597C6A3681DFFBD, NameHash = 0xA4724D07435E3B7C)]
    public class GcSentinelSpawnSequenceGroupList : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> CorruptSequences;
        /* 0x10 */ public List<NMSString0x10> ExtremeSequences;
        /* 0x20 */ public List<NMSString0x10> Sequences;
    }
}
