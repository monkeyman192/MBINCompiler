using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6F119B72C955A78B, NameHash = 0x8A4027FC041677F0)]
    public class GcScannerIconTypes : NMSTemplate
    {
        // size: 0x36
        public enum ScanIconTypeEnum { None, Health, Shield, Hazard, LifeSupport, Tech, BluePlant, CaveSubstance,
            LaunchCrystals, Power, Carbon, CarbonPlus, Oxygen, Mineral, Sodium,
            SodiumPlus, Crate, Artifact, Plant, HazardPlant, ArtifactCrate, BuriedTech,
            BuriedRare, Drone, CustomMarker, SignalBooster, Refiner, Grave,
            Rare1, Rare2, Rare3, Pearl, RareEgg, HazardEgg, FishFiend, Clam, CaveStone,
            StormCrystal, BiomeTrophy, PowerHotspot, MineralHotspot, GasHotspot,
            HarvestPlant, Cooker, CreaturePoop, FreighterTeleporter, FreighterDoor,
            FreighterTerminal, FreighterHeater, FreighterDataPad, LandedPilot,
            PetEgg, Sandworm, FriendlyDrone
        }
        /* 0x0 */ public ScanIconTypeEnum ScanIconType;
    }
}
