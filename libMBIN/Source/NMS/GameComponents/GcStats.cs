using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x5877D8DB1C457F66, NameHash = 0x9C20970E839B65D9)]
    public class GcStats : NMSTemplate
    {
        public List<GcStatsGroup> Stats;
    }
}
