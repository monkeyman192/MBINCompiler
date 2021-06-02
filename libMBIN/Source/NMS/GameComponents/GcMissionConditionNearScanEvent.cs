using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0xE31955C81647FC37, NameHash = 0x8F7E57B730A9C7F8)]
    public class GcMissionConditionNearScanEvent : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 Event;
        /* 0x20 */ public float Distance;
        /* 0x24 */ public bool AllowInShip;
        /* 0x25 */ public bool RequiresFullFireteam;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x26 */ public byte[] EndPadding;
    }
}
