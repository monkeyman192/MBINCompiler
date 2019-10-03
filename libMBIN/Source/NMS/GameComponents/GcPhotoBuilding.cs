using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x9DD8603DDE3E0BDF, NameHash = 0x2535C1B3F76633D)]
    public class GcPhotoBuilding : NMSTemplate
    {
		public enum PhotoBuildingTypeEnum { Shelter, Abandoned, Shop, Outpost, RadioTower, Observatory, Depot, Monolith, Factory, Portal, Ruin, MissionTower }
		public PhotoBuildingTypeEnum PhotoBuildingType;
    }
}
