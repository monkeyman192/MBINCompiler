using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0x88450AC51476AB6E, NameHash = 0x8F7E57B730A9C7F8)]
    public class GcMissionConditionNearScanEvent : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string Event;
        /* 0x20 */ public float Distance;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x24 */ public byte[] EndPadding;
    }
}
