﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xE99A21CC212AEF47, NameHash = 0x510AB74045DA8CCE)]
    public class GcRewardAction : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Reward;
    }
}
