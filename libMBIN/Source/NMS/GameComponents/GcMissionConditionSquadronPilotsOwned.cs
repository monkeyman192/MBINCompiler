using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5672B4343D867BBE, NameHash = 0x8984A8784D46EE5F)]
    public class GcMissionConditionSquadronPilotsOwned : NMSTemplate
    {
        /* 0x0 */ public int Amount;
        /* 0x4 */ public TkEqualityEnum Test;
        /* 0x8 */ public bool TakeNumberFromSeasonData;
    }
}
