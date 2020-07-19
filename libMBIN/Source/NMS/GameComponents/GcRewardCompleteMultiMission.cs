using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xE7C396794036718B, NameHash = 0xEF104FBE8AD4EB68)]
    public class GcRewardCompleteMultiMission : NMSTemplate
    {
        /* 0x0 */ public List<NMSString0x10> Missions;
    }
}
