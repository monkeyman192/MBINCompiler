using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x5A425D525464C797, NameHash = 0x881C97F393A2FB50)]
    public class GcMissionType : NMSTemplate
    {
        // size: 0xB
		public enum MissionTypeEnum { SpaceCombat, GroundCombat, Research, MissingPerson, Repair, Cargo, Piracy, Photo, Feeding, Planting, Construction }
		public MissionTypeEnum MissionType;
    }
}