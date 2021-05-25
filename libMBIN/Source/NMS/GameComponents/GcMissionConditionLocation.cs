using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0xDBD0CB8155C933E, NameHash = 0x64A394B637C25752)]
    public class GcMissionConditionLocation : NMSTemplate
    {
        // size: 0x17
        public enum MissionPlayerLocationEnum {
            OnPlanet, OnPlanetInVehicle, InShipLanded, InShipInPlanetOrbit, InShipInSpace, InSpaceStation, InFreighter, Underground, InBuilding, Frigate,
            Underwater, DeepUnderwater, InSubmarine, Frigate_Damaged, FreighterConstructionArea, FriendsPlanetBase, OnPlanetSurface, InNexus, InNexusOnFoot, AbandonedFreighterExterior,
            AbandonedFreighterInterior, AbandonedFreighterAirlock, AtlasStation
        }
        public MissionPlayerLocationEnum MissionPlayerLocation;
    }
}
