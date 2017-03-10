namespace MBINCompiler.Models.Structs
{
    public class TkListedPaletteTexture : NMSTemplate
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
                "Warrior", "Scientific", "Trader", "WarriorAlt", "ScientificAlt", "TraderAlt", "RockSaturated", "RockLight", "RockDark"
            };
        }

        public int ColourAlt;
        public string[] ColourAltValues()
        {
            return new[] { "Primary", "Alternative1", "Alternative2", "Alternative3", "Alternative4", "Unique", "MatchGround", "None" };
        }

        [NMS(Size = 0x4, Ignore = true)]
        public byte[] padding0x8;     // this is needed when it is in a list... but not when it isn't...
    }
}
