using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7311F1B4C666160C, NameHash = 0x77C3FF3D0260D091)]
    public class GcSentinelSpawnNamedSequence : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x10 */ public List<GcSentinelSpawnSequenceStep> Waves;
    }
}
