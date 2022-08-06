using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEF41B6F6AD669376, NameHash = 0x9511DDC4A0C718D3)]
    public class GcMissionConditionHasShip : NMSTemplate
    {
        /* 0x0 */ public GcSpaceshipClasses ShipType;
        /* 0x4 */ public GcInventoryClass ShipInventoryClass;
        /* 0x8 */ public bool CheckAllShips;
        /* 0x9 */ public bool BetterClassMatches;
        /* 0xA */ public bool DontCheckType;
        /* 0xB */ public bool TakeValueFromSeasonData;
    }
}
