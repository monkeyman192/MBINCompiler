using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x77C7A3AB317145B9, NameHash = 0x58C0C35FA839BA96)]
    public class GcMechAudioEvent : NMSTemplate
    {
        /* 0x00 */ public List<GcMechPartAudioEventOverride> MeshPartOverrides;
        /* 0x10 */ public GcAudioWwiseEvents DefaultEvent;
    }
}
