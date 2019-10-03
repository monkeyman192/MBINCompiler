using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x28CFE261850CB1F5, NameHash = 0x7D347F979E52A1C1)]
    public class GcActionSets : NMSTemplate
    {
        public List<GcActionSet> ActionSets;
    }
}
