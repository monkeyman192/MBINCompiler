using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x1F165EB008AD6F87, NameHash = 0x8A4027FC041677F0)]
    public class GcScannerIconTypes : NMSTemplate
    {
        // size: 0x34
		public enum ScanIconTypeEnum {
            None, Health, Shield, Hazard, LifeSupport, Tech, BluePlant, CaveSubstance, LaunchCrystals, Power,
            Carbon, CarbonPlus, Oxygen, Mineral, Sodium, SodiumPlus, Crate, Artifact, Plant, HazardPlant,
            ArtifactCrate, BuriedTech, BuriedRare, Drone, CustomMarker, SignalBooster, Refiner, Grave, Rare1, Rare2,
            Rare3, Pearl, RareEgg, HazardEgg, FishFiend, Clam, CaveStone, StormCrystal, BiomeTrophy, PowerHotspot,
            MineralHotspot, GasHotspot, HarvestPlant, Cooker, CreaturePoop, FreighterTeleporter, FreighterDoor, FreighterTerminal, FreighterHeater, FreighterDataPad,
            LandedPilot, PetEgg
        }
		public ScanIconTypeEnum ScanIconType;
    }
}