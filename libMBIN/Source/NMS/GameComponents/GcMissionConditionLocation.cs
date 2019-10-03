using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x73C257AB66448B3A, NameHash = 0x64A394B637C25752)]
    public class GcMissionConditionLocation : NMSTemplate
    {
        // 0x12 entries
		public enum MissionPlayerLocationEnum { OnPlanet, OnPlanetInVehicle, InShipLanded, InShipInPlanetOrbit, InShipInSpace, InSpaceStation, InFreighter, Underground,
            InBuilding, Frigate, Underwater, DeepUnderwater, InSubmarine, Frigate_Damaged, FreighterConstructionArea, FriendsPlanetBase, OnPlanetSurface, InNexus }
		public MissionPlayerLocationEnum MissionPlayerLocation;
    }
}
