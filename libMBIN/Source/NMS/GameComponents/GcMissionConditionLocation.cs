using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB1C63BA10A06DF32, NameHash = 0x64A394B637C25752)]
    public class GcMissionConditionLocation : NMSTemplate
    {
        // size: 0x1B
        public enum MissionPlayerLocationEnum { 
            OnPlanet, OnPlanetInVehicle, InShipLanded, InShipInPlanetOrbit, InShipInSpace,
            InShipAnywhere, InSpaceStation, InFreighter, InYourFreighter, InOtherPlayerFreighter,
            Underground, InBuilding, Frigate, Underwater, UnderwaterSwimming,
            DeepUnderwater, InSubmarine, Frigate_Damaged, FreighterConstructionArea,
            FriendsPlanetBase, OnPlanetSurface, InNexus, InNexusOnFoot,
            AbandonedFreighterExterior, AbandonedFreighterInterior, AbandonedFreighterAirlock,
            AtlasStation
        }
        /* 0x0 */ public MissionPlayerLocationEnum MissionPlayerLocation;
    }
}
