using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x1B21EC1CC5B396E2, NameHash = 0xEE25A96466342A98)]
    public class GcBaseBuildingCostsTable : NMSTemplate
    {
        public List<GcBaseBuildingEntryCosts> ObjectCosts;
    }
}