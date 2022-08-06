using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x72AB02DDFF433465, NameHash = 0x1BAD68301EABDA5C)]
    public class GcEncounterComponentData : NMSTemplate
    {
        /* 0x0 */ public GcEncounterType EncounterType;
        /* 0x8 */ public List<NMSString0x10> InteractMissionTable;
    }
}
