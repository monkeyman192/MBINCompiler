namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEE5EE3466EF236CB, NameHash = 0x64A394B637C25752)]
    public class GcMissionConditionLocation : NMSTemplate
    {
        // size: 0x1D
        public enum MissionPlayerLocationEnum : uint {
            OnPlanet,
            OnPlanetInVehicle,
            AnywhereInPlanetAtmos,
            InShipLanded,
            InShipInPlanetOrbit,
            InShipInSpace,
            InShipAnywhere,
            InSpaceStation,
            InFreighter,
            InYourFreighter,
            InOtherPlayerFreighter,
            Underground,
            InBuilding,
            Frigate,
            Underwater,
            UnderwaterSwimming,
            DeepUnderwater,
            InSubmarine,
            Frigate_Damaged,
            FreighterConstructionArea,
            FriendsPlanetBase,
            OnPlanetSurface,
            InNexus,
            InNexusOnFoot,
            AbandonedFreighterExterior,
            AbandonedFreighterInterior,
            AbandonedFreighterAirlock,
            AtlasStation,
            AtlasStationFinal,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MissionPlayerLocationEnum MissionPlayerLocation;
    }
}
