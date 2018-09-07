namespace libMBIN.Models.Structs
{
    public class GcScannerIconTypes : NMSTemplate
    {
		public enum ScanIconTypeEnum { None, Health, Shield, Hazard, Tech, Heridium, Platinum, Chrysonite, Signal, Fuel, Carbon, Plutonium, Thamium, Mineral, Iron, Zinc, Titanium, Multi, Artifact, TechRecipe, RareProp, Trade, Exotic, Plant, RelicCrate, Buried, Drone, PlaceMarker, HazardPlant, Refiner, Grave, Rare1, Rare2, Rare3 }
		public ScanIconTypeEnum ScanIconType;
    }
}
