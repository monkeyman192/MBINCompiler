namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x10)]
    public class GcBuildingDensity : NMSTemplate
    {
        public float BuildingSpacing;
        [NMS(Size = 0x3, EnumValue = new[] { "Cluster", "Large", "Small"})]     // need to check
        public float[] BuildingClusterChance;
    }
}
