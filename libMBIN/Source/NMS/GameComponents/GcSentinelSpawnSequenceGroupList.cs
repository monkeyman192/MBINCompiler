using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x357843AD9058F957, NameHash = 0xA4724D07435E3B7C)]
    public class GcSentinelSpawnSequenceGroupList : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<NMSString0x10> CorruptSequences;
        [NMS(Index = 1)]
        /* 0x10 */ public List<NMSString0x10> ExtremeSequences;
        [NMS(Index = 0)]
        /* 0x20 */ public List<NMSString0x10> Sequences;
    }
}
