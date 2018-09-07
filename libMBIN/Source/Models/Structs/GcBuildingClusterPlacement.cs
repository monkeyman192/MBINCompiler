namespace libMBIN.Models.Structs
{
    public class GcBuildingClusterPlacement : NMSTemplate
    {
		public enum BuildingClusterPlacementEnum { Cluster, Large, Small, None }
		public BuildingClusterPlacementEnum BuildingClusterPlacement;
    }
}
