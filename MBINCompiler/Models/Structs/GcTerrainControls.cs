namespace MBINCompiler.Models.Structs
{
    public class GcTerrainControls : NMSTemplate
    {
        [NMS(Size = 7, EnumValue = new[] { "Base", "Hill", "Mountain", "Rock", "UnderWater", "Texture", "Elevation" })]
        public float[] NoiseLayers;
        [NMS(Size = 9, EnumValue = new[] { "Small", "Large", "Resources_Heridium", "Resources_Iridium", "Resources_Copper", "Resources_Nickel", "Resources_Aluminium", "Resources_Gold", "Resources_Emeril" })]
        public float[] GridLayers;
        [NMS(Size = 7, EnumValue = new[] { "River", "Crater", "Arches", "ArchesSmall", "Blobs", "BlobsSmall", "Substance" })]
        public float[] Features;

        // Caves should be an Enum like the ones above but just with one value...
        public float UndergroundCaves;
        public float WaterActiveFrequency;
        public float HighWaterActiveFrequency;
        public float RockTileFrequency;
        public float SubstanceTileFrequency;
    }
}
