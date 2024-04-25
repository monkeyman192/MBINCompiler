using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2788A7B4909B43C0, NameHash = 0x6110D9A6BE68E9B8)]
    public class GcPetEggSpeciesOverrideTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcPetEggSpeciesOverrideData> SpeciesOverrides;
    }
}
