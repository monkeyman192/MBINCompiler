using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD9FDA70F3C50E5DB, NameHash = 0x3B68FA54)]
    public class GcMechAudioEvent : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcMechPartAudioEventOverride> MeshPartOverrides;
        [NMS(Index = 0)]
        /* 0x10 */ public GcAudioWwiseEvents DefaultEvent;
    }
}
