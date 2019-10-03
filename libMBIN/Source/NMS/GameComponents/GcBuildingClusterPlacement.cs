using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x53A2B5BA5E76D7E, NameHash = 0x64507EE9CB3B4634)]
    public class GcBuildingClusterPlacement : NMSTemplate
    {
		public enum BuildingClusterPlacementEnum { Cluster, Single, None }
		public BuildingClusterPlacementEnum BuildingClusterPlacement;
    }
}
