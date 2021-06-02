using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x30, GUID = 0x582FB45B0B3B9CFB, NameHash = 0xE9EC3242091011CC)]
    public class GcUnlockableTwitchReward : NMSTemplate
    {
        public NMSString0x10 TwitchId;
        public NMSString0x10 ProductId;
        public NMSString0x10 LinkedGroupId;
    }
}
