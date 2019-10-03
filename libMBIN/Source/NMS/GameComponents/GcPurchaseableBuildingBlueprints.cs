using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x1D8475D6A5DE0D20, NameHash = 0x7DB6471B493F5A78)]
    public class GcPurchaseableBuildingBlueprints : NMSTemplate
    {
        public List<GcBuildingBlueprint> Table;
        public List<int> GroupMaxItems;
    }
}
