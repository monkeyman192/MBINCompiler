namespace MBINCompiler.Models.Structs
{
    public class GcGalaxyGlobals : NMSTemplate
    {
        public float Unknown0;
        public float Unknown4;
        public float Unknown8;              // something to do with the UI?
        public float UnknownC;              // somehting to do with the UI?
        public float Unknown10;
        public float Unknown14;
        public float Unknown18;
        public float Unknown1C;
        public float Unknown20;
        public float Unknown24;
        public float Unknown28;
        public float Unknown2C;
        public int Unknown30;
        public int Unknown34;
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] Padding38;
        [NMS(Size = 0x5, EnumValue = new[] { "Core", "FreeRoam", "Waypoint", "Blackhole", "Atlas" })]
        public Colour[] PathIconColours;
        [NMS(Size = 0x6, EnumValue = new[] { "Home", "Waypoint", "Contact", "Blackhole", "AtlasStation", "Selection" })]
        public GcGalaxyMarkerSettings[] GalaxyMarkers;

        public float Unknown330;
        public float Unknown334;
        public float Unknown338;
        public float Unknown33C;
        public float Unknown340;
        public float Unknown344;
        public float Unknown348;
        public float Unknown34C;
        public float Unknown350;
        public float Unknown354;
        public float Unknown358;
        public float Unknown35C;
        public float Unknown360;
        public float Unknown364;
        public float Unknown368;
        public float Unknown36C;
        public float Unknown370;
        public float Unknown374;
        public float Unknown378;
        public float Unknown37C;
        public float Unknown380;
        public int Unknown384;
        public float Unknown388;
        public float Unknown38C;
        public float Unknown390;
        public float Unknown394;
        public float Unknown398;
        public float Unknown39C;
        public float Unknown3A0;
        public float Unknown3A4;
        public float Unknown3A8;
        public float Unknown3AC;
        public int Unknown3B0;
        public int Unknown3B4;
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] Padding3B8;
        public GcGalaxyRenderAnostreakData AnoStreakConfig1;
        public GcGalaxyRenderAnostreakData AnoStreakConfig2;
        public GcGalaxyRenderAnostreakData AnoStreakConfig3;
        public Colour Unknown450;
        public float Unknown460;
        public float Unknown464;
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] Padding468;
        public GcGalaxyStarColours StarColours1;
        public GcGalaxyStarColours StarColours2;
        public GcGalaxyCameraData Unknown4F0;
        public GcGalaxyAudioSetupData Unknown548;
        public float Unknown58C;
        public float Unknown590;
        public float Unknown594;
        public float Unknown598;
        public float Unknown59C;

        public GcGalaxyRenderSetupData Unknown5A0;
        public GcGalaxyGenerationSetupData Unknown790;
        public GcGalaxyRenderSetupData Unknown900;
        public GcGalaxyGenerationSetupData UnknownAF0;
    }
}
