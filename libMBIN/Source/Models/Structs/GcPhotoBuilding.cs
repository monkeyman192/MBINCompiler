namespace libMBIN.Models.Structs
{
    public class GcPhotoBuilding : NMSTemplate
    {
		public enum PhotoBuildingTypeEnum { Shelter, Abandoned, Shop, Outpost, RadioTower, Observatory, Depot, Monolith, Factory, Portal, Ruin, MissionTower }
		public PhotoBuildingTypeEnum PhotoBuildingType;
    }
}
