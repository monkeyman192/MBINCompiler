namespace libMBIN.Models.Structs
{
    public class GcBuildingDensityLevels : NMSTemplate
    {
        public enum BuildingDensityEnum { Dead, Low, Mid, Full, Weird }
        public BuildingDensityEnum BuildingDensity;
    }
}
