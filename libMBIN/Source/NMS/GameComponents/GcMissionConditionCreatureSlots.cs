using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9741EC430CF1FAD8, NameHash = 0x1BD168A44ADE2D95)]
    public class GcMissionConditionCreatureSlots : NMSTemplate
    {
        /* 0x0 */ public int CreatureSlots;
        /* 0x4 */ public bool OnlyCountFreeSlots;
        /* 0x8 */ public TkEqualityEnum Test;
    }
}
