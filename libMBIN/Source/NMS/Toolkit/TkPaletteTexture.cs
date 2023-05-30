using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkPaletteTexture : NMSTemplate
    {
        public int Palette;
        public string[] PaletteValues()
        {
            return new[]
            {
                "Grass", "Plant", "Leaf", "Wood", "Rock", "Stone", "Crystal", "Sand",
                "Dirt", "Metal", "Paint", "Plastic", "Fur", "Scale", "Feather", "Water",
                "Cloud", "Sky", "Space", "Underbelly", "Undercoat", "Snow", "SkyHorizon", "SkyFog",
                "SkyHeightFog", "SkySunset", "SkyNight", "WaterNear", "SpaceCloud", "SpaceBottom", "SpaceSolar", "SpaceLight",
                "Warrior", "Scientific", "Trader", "WarriorAlt", "ScientificAlt", "TraderAlt"
            };
        }

        public int ColourAlt;
        public string[] ColourAltValues()
        {
            return new[] { "Primary", "Alternative1", "Alternative2", "Alternative3", "Alternative4", "Unique", "MatchGround", "None" };
        }
    }
}
