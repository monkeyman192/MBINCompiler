using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x275FA15C37AF4B89, NameHash = 0x26335C55292A7766)]
    public class GcMissionTable : NMSTemplate
    {
        public List<GcGenericMissionSequence> Missions;
    }
}
