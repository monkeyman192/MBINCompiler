using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xF59630531589EA83, NameHash = 0x6F44BB3A2BA686D8)]
    public class GcRewardOpenUnlockTree : NMSTemplate
    {
        public GcUnlockableItemTreeGroups TreeToOpen;
    }
}
