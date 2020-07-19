using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0xE200822F2E23332F, NameHash = 0x28670AE3B159B8FC)]
    public class GcRewardCrashSiteFly : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x0 */ public string NPCScanEvent;
    }
}