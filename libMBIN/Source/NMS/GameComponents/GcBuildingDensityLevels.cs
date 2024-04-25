namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x84AE876DD70E705A, NameHash = 0x43EB5D40DE6AD28E)]
    public class GcBuildingDensityLevels : NMSTemplate
    {
        // size: 0x6
        public enum BuildingDensityEnum : uint {
            Dead,
            Low,
            Mid,
            Full,
            Weird,
            HalfWeird,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BuildingDensityEnum BuildingDensity;
    }
}
