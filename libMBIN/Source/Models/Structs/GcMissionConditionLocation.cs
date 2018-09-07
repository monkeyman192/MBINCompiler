namespace libMBIN.Models.Structs
{
    public class GcMissionConditionLocation : NMSTemplate
    {
		public enum MissionPlayerLocationEnum { OnPlanet, OnPlanetInVehicle, InShipLanded, InShipInPlanetOrbit, InShipInSpace, InSpaceStation, InFreighter, Underground, InBuilding, Frigate, Frigate_Damaged, FreighterConstructionArea, FriendsPlanetBase, OnPlanetSurface }
		public MissionPlayerLocationEnum MissionPlayerLocation;
    }
}
