using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF51F2B3B7EA6080C, NameHash = 0x6E17046D2670AB02)]
    public class GcBaseBuildingPartAudioLocationTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcBaseBuildingPartAudioLocationEntry> AudioLocations;
    }
}
