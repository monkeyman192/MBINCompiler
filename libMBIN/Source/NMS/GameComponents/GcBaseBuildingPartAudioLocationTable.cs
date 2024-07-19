using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4984DB68189018, NameHash = 0x1A88D4A0)]
    public class GcBaseBuildingPartAudioLocationTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcBaseBuildingPartAudioLocationEntry> AudioLocations;
    }
}
