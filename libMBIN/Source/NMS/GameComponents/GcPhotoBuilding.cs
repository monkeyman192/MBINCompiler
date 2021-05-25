using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xFA18C6BA7927319B, NameHash = 0x2535C1B3F76633D)]
    public class GcPhotoBuilding : NMSTemplate
    {
        // size: 0xD
		public enum PhotoBuildingTypeEnum { Shelter, Abandoned, Shop, Outpost, RadioTower, Observatory, Depot, Monolith, Factory, Portal, Ruin, MissionTower, LargeBuilding }
		public PhotoBuildingTypeEnum PhotoBuildingType;
    }
}