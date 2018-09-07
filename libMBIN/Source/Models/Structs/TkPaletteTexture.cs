namespace libMBIN.Models.Structs
{
    public class TkPaletteTexture : NMSTemplate
    {
		public enum PaletteEnum { Grass, Plant, Leaf, Wood, Rock, Stone, Crystal, Sand, Dirt, Metal, Paint, Plastic, Fur, Scale, Feather, Water, Cloud,
                                  Sky, Space, Underbelly, Undercoat, Snow, SkyHorizon, SkyFog, SkyHeightFog, SkySunset, SkyNight, WaterNear, SpaceCloud,
                                  SpaceBottom, SpaceSolar, SpaceLight, Warrior, Scientific, Trader, WarriorAlt, ScientificAlt, TraderAlt, RockSaturated,
                                  RockLight, RockDark, PlanetRing, Custom_Head, Custom_Torso, Custom_Chest_Armour, Custom_Backpack, Custom_Arms, Custom_Hands,
                                  Custom_Legs, Custom_Feet, Cave, GrassAlt }
		public PaletteEnum Palette;

		public enum ColourAltEnum { Primary, Alternative1, Alternative2, Alternative3, Alternative4, Unique, MatchGround, None }
		public ColourAltEnum ColourAlt;
    }
}
