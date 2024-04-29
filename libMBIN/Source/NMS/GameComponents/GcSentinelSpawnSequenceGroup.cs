using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB3B6CFD8670F95D1, NameHash = 0x3E0D2E6A5C1DE7AD)]
    public class GcSentinelSpawnSequenceGroup : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcSentinelSpawnSequence ExtremeSequence;
        [NMS(Index = 0)]
        /* 0x10 */ public GcSentinelSpawnSequence Sequence;
    }
}
