namespace libMBIN.Models.Structs
{
    public class TkPaletteTexture : NMSTemplate
    {
        public int Palette;     // elements: 0x34
        public string[] PaletteValues()
        {
            return new[]
            {
                "Grass", "Plant", "Leaf", "Wood", "Rock", "Stone", "Crystal", "Sand",
                "Dirt", "Metal", "Paint", "Plastic", "Fur", "Scale", "Feather", "Water",
                "Cloud", "Sky", "Space", "Underbelly", "Undercoat", "Snow", "SkyHorizon", "SkyFog",
                "SkyHeightFog", "SkySunset", "SkyNight", "WaterNear", "SpaceCloud", "SpaceBottom", "SpaceSolar", "SpaceLight",
                "Warrior", "Scientific", "Trader", "WarriorAlt", "ScientificAlt", "TraderAlt", "RockSaturated", "RockLight", "RockDark",
                "PlanetRing", "Custom_Head", "Custom_Torso", "Custom_Chest_Armour", "Custom_Backpack", "Custom_Arms", "Custom_Hands",
                "Custom_Legs", "Custom_Feet", "Cave", "GrassAlt"
            };
        }

        public int ColourAlt;
        public string[] ColourAltValues()
        {
            return new[] { "Primary", "Alternative1", "Alternative2", "Alternative3", "Alternative4", "Unique", "MatchGround", "None" };
        }
    }
}
