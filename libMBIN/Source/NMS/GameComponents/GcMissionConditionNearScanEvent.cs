using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4E25FE0EFD798303, NameHash = 0x8F7E57B730A9C7F8)]
    public class GcMissionConditionNearScanEvent : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Event;
        /* 0x20 */ public float Distance;
        /* 0x24 */ public bool AllowInShip;
        /* 0x25 */ public bool RequiresFullFireteam;
        /* 0x26 */ public bool ReturnTrueIfMarkerGone;
    }
}
