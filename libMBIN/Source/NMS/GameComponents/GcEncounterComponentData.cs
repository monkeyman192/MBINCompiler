using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x374E935BC10E51A6, NameHash = 0x772EC25C)]
    public class GcEncounterComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<NMSString0x10> InteractMissionTable;
        [NMS(Index = 0)]
        /* 0x10 */ public GcEncounterType EncounterType;
    }
}
