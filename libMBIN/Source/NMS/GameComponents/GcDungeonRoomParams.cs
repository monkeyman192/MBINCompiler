using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xE17FEA507C8697E1, NameHash = 0xA2ECE651D48EE56D)]
    public class GcDungeonRoomParams : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 RoomId;
        /* 0x10 */ public float BranchProbability;
    }
}
