using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x101, Alignment = 0x1, GUID = 0xC5CD3D1BAE9B1920, NameHash = 0xDBB793901A29BBD4)]
    public class GcMissionSequenceExploreAbandonedFreighter : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public bool RequireAllRoomsDone;
        /* 0x81 */ public NMSString0x80 DebugText;
    }
}