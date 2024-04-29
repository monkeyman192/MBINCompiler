using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD1FAA76740505985, NameHash = 0x58C0C35FA839BA96)]
    public class GcMechAudioEvent : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcMechPartAudioEventOverride> MeshPartOverrides;
        [NMS(Index = 0)]
        /* 0x10 */ public GcAudioWwiseEvents DefaultEvent;
    }
}
