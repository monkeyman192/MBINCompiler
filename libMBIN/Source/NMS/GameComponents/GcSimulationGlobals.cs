using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcSimulationGlobals : NMSTemplate
    {
        public NMSString0x80 StartScene;
        public NMSString0x80 MultiToolScene;

        public ulong Unknown100; // PlanetSimulationSeed perhaps? used in a function containing string "PlanetRoot", which is called by cGcSimulation::Construct()

        public NMSString0x80 SpaceStationScene;
        [NMS(Size = 1)]
        public NMSString0x80[] BlackHoleScenes; // only one entry but it's treated as an array?
        [NMS(Size = 0xB)]
        public NMSString0x80[] AtlasStationScenes; // item at index 9 is used for something special?
        public NMSString0x80 AnomalyScene;
        public NMSString0x80 Unknown808; // not set
        public NMSString0x80 RobotDroneScene;
        public NMSString0x80 HeavyAirCaveScene;
        public NMSString0x80 HeavyAirUnderwaterScene;
        [NMS(Size = 3)]
        public NMSString0x80[] LaserScenes;
        [NMS(Size = 2)]
        public NMSString0x80[] WaterMaterials;
        public NMSString0x80 PlanetAtmosphereScene;
        public NMSString0x80 PlanetAtmosphereMaterial;
        public NMSString0x80 PlanetMaterial;
        public NMSString0x80 PlanetWaterMaterial;
        [NMS(Size = 4)]
        public NMSString0x80[] TerrainLODMaterials;
        [NMS(Size = 0x10)]
        public NMSString0x80[] BiomeTilemapTextures;
        public NMSString0x80 WarpTunnelScene;
        public NMSString0x80 WarpTunnelBlackHoleScene;
    }
}
