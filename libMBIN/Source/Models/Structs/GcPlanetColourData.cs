namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x16C0)]
    public class GcPlanetColourData : NMSTemplate
    {
        [NMS(Size = 0x34, EnumValue = new[]
            {
                "Grass", "Plant", "Leaf", "Wood", "Rock", "Stone", "Crystal", "Sand",
                "Dirt", "Metal", "Paint", "Plastic", "Fur", "Scale", "Feather", "Water",
                "Cloud", "Sky", "Space", "Underbelly", "Undercoat", "Snow", "SkyHorizon", "SkyFog",
                "SkyHeightFog", "SkySunset", "SkyNight", "WaterNear", "SpaceCloud", "SpaceBottom", "SpaceSolar", "SpaceLight",
                "Warrior", "Scientific", "Trader", "WarriorAlt", "ScientificAlt", "TraderAlt", "RockSaturated", "RockLight",
                "RockDark", "PlantRing", "Custom_Head", "Custom_Torso", "Custom_Chest_Armour", "Custom_Backpack", "Custom_Arms", "Custom_Hands",
                "Custom_Legs", "Custom_Feet", "Cave", "GrassAlt"
            })]
        public GcColourPaletteData[] Palettes;
    }
}
