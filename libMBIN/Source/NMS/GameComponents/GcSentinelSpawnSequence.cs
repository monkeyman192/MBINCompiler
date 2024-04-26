using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x75437857CB76C97E, NameHash = 0xA8EFE022A74D3291)]
    public class GcSentinelSpawnSequence : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcSentinelSpawnSequenceStep> Waves;
    }
}
