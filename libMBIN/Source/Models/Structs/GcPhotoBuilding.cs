namespace libMBIN.Models.Structs
{
    public class GcPhotoBuilding : NMSTemplate
    {
        public int PhotoBuildingType;
        public string[] PhotoBuildingTypeValues()
        {
            return new[] { "Shelter", "Abandoned", "Shop", "Outpost", "RadioTower", "Observatory", "Depot", "Monolith", "Factory",
                           "Portal", "Ruin", "MissionTower"};
        }
    }
}
