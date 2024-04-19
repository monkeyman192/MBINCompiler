using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD09167CE1502A484, NameHash = 0x1BAD68301EABDA5C)]
    public class GcEncounterComponentData : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> InteractMissionTable;
        /* 0x10 */ public GcEncounterType EncounterType;
    }
}
