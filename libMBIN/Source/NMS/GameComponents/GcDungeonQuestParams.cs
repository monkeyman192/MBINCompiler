using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x10C4C790AC87A933, NameHash = 0xCE00C5120C432BB0)]
    public class GcDungeonQuestParams : NMSTemplate
    {
        /* 0x0 */ public float Probability;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x4 */ public byte[] Padding4;
        /* 0x40 */ public List<NMSString0x10> QuestItems;
    }
}
