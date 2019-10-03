using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x54511EBAE64FC462, NameHash = 0xDA977EF5139B54E5)]
    public class GcPlayerMissionUpgradeMapTable : NMSTemplate
    {
        public List<GcPlayerMissionUpgradeMapEntry> MissionUpgradeTable;
    }
}
