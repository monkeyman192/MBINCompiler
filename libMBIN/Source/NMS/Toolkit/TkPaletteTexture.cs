using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x8, GUID = 0x565979C690E12DA2, NameHash = 0x6A57676B42321253)]
    public class TkPaletteTexture : NMSTemplate
    {
        // size: 0x37
		public enum PaletteEnum {
            Grass, Plant, Leaf, Wood, Rock, Stone, Crystal, Sand, Dirt, Metal,
            Paint, Plastic, Fur, Scale, Feather, Water, Cloud, Sky, Space, Underbelly,
            Undercoat, Snow, SkyHorizon, SkyFog, SkyHeightFog, SkySunset, SkyNight, WaterNear, SpaceCloud, SpaceBottom,
            SpaceSolar, SpaceLight, Warrior, Scientific, Trader, WarriorAlt, ScientificAlt, TraderAlt, RockSaturated, RockLight,
            RockDark, PlanetRing, Custom_Head, Custom_Torso, Custom_Chest_Armour, Custom_Backpack, Custom_Arms, Custom_Hands, Custom_Legs, Custom_Feet,
            Cave, GrassAlt, BioShip_Body, BioShip_Underbelly, BioShip_Cockpit
        }
		public PaletteEnum Palette;
        // size: 0x8
		public enum ColourAltEnum { Primary, Alternative1, Alternative2, Alternative3, Alternative4, Unique, MatchGround, None }
		public ColourAltEnum ColourAlt;
    }
}
