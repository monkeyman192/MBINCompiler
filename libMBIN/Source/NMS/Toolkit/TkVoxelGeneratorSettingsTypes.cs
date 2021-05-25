using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x4, GUID = 0xDB29A0A6B9F50F91, NameHash = 0x60B0A451EF1759F9)]
    public class TkVoxelGeneratorSettingsTypes : NMSTemplate
    {
        // size: 0x15
        public enum TerrainSettingsEnum {
            FloatingIslands, GrandCanyon, MountainRavines, HugeArches, Alien, Craters, Caverns, Alpine, LilyPad, Desert,
            WaterworldPrime, FloatingIslandsPrime, GrandCanyonPrime, MountainRavinesPrime, HugeArchesPrime, AlienPrime,
            CratersPrime, CavernsPrime, AlpinePrime, LilyPadPrime, DesertPrime
        }
        public TerrainSettingsEnum TerrainSettings;
    }
}