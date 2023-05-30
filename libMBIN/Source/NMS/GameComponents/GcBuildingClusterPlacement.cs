using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcBuildingClusterPlacement : NMSTemplate
    {
        public int BuildingClusterPlacement;
        public string[] BuildingClusterPlacementValues()
        {
            return new[] { "Cluster", "Large", "Small", "None" };
        }
    }
}
