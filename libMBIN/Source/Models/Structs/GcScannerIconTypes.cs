namespace libMBIN.Models.Structs
{
    public class GcScannerIconTypes : NMSTemplate
    {
        public int ScanIconType;
        public string[] ScanIconTypeValues()
        {
            return new[]
            {
                "None", "Health", "Shield", "Hazard", "Tech", "Heridium", "Platinum", "Chrysonite", "Signal", "Fuel",
				"Carbon", "Plutonium", "Thamium", "Mineral", "Iron", "Zinc", "Titanium", "Multi", "Artifact", "TechRecipe", "RareProp", "Trade", "Exotic",
                "Plant", "RelicCrate", "Buried", "Drone", "PlaceMarker", "HazardPlant", "Refiner", "Grave", "Rare1", "Rare2", "Rare3"
            };
        }
    }
}
