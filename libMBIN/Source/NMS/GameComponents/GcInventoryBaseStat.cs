using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0xCEEB2DE89F19DF1F, NameHash = 0x88CEC164B6BD4ACC)]
    public class GcInventoryBaseStat : NMSTemplate
    {
        public NMSString0x10 BaseStatID;
        public NMSString0x10 LocID;
        public List<GcInventoryBaseStatBonus> StatBonus;
    }
}
