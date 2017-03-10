namespace MBINCompiler.Models.Structs
{
    public class GcSimulationGlobals : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string StartScene;
        [NMS(Size = 0x80)]
        public string MultiToolScene;

        public ulong Unknown100; // PlanetSimulationSeed perhaps? used in a function containing string "PlanetRoot", which is called by cGcSimulation::Construct()

        [NMS(Size = 0x80)]
        public string SpaceStationScene;
        [NMS(Size = 1)]
        public NMSString0x80[] BlackHoleScenes; // only one entry but it's treated as an array?
        [NMS(Size = 0xB)]
        public NMSString0x80[] AtlasStationScenes; // item at index 9 is used for something special?
        [NMS(Size = 0x80)]
        public string AnomalyScene;
        [NMS(Size = 0x80)]
        public string Unknown808; // not set
        [NMS(Size = 0x80)]
        public string RobotDroneScene;
        [NMS(Size = 0x80)]
        public string HeavyAirCaveScene;
        [NMS(Size = 0x80)]
        public string HeavyAirUnderwaterScene;
        [NMS(Size = 3)]
        public NMSString0x80[] LaserScenes;
        [NMS(Size = 2)]
        public NMSString0x80[] WaterMaterials;
        [NMS(Size = 0x80)]
        public string PlanetAtmosphereScene;
        [NMS(Size = 0x80)]
        public string PlanetAtmosphereMaterial;
        [NMS(Size = 0x80)]
        public string PlanetMaterial;
        [NMS(Size = 0x80)]
        public string PlanetWaterMaterial;
        [NMS(Size = 6)]
        public NMSString0x80[] TerrainLODMaterials;
        [NMS(Size = 0x10)]
        public NMSString0x80[] BiomeTilemapTextures;
        [NMS(Size = 0x80)]
        public string WarpTunnelScene;
        [NMS(Size = 0x80)]
        public string WarpTunnelBlackHoleScene;
        [NMS(Size = 0x80)]
        public string WarpPortalScene;
    }
}
