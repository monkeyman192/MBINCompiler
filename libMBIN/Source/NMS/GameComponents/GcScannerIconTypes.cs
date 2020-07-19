using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xDFEA9D7139A045F3, NameHash = 0x8A4027FC041677F0)]
    public class GcScannerIconTypes : NMSTemplate
    {
        // Size: 0x30
		public enum ScanIconTypeEnum {
            None, Health, Shield, Hazard, Tech, Heridium, Platinum, Chrysonite, Signal, Fuel,
            Carbon, Plutonium, Thamium, Mineral, Iron, Zinc, Titanium, Multi, Artifact, TechRecipe,
            RareProp, Trade, Exotic, Plant, RelicCrate, Buried, BuriedRare, Drone, PlaceMarker, HazardPlant,
            Refiner, Grave, Rare1, Rare2, Rare3, StormCrystal, BiomeTrophy, PowerHotspot, MineralHotspot, GasHotspot,
            HarvestPlant, Cooker, CreaturePoop, FreighterTeleporter, FreighterDoor, FreighterTerminal, FreighterHeater, FreighterDataPad
        }
		public ScanIconTypeEnum ScanIconType;
    }
}