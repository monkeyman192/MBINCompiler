namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE2EECC3116ACD89D, NameHash = 0x6A57676B42321253)]
    public class TkPaletteTexture : NMSTemplate
    {
        // size: 0x8
        public enum ColourAltEnum : uint {
            Primary,
            Alternative1,
            Alternative2,
            Alternative3,
            Alternative4,
            Unique,
            MatchGround,
            None,
        }
        [NMS(Index = 1)]
        /* 0x0 */ public ColourAltEnum ColourAlt;
        // size: 0x3F
        public enum PaletteEnum : uint {
            Grass,
            Plant,
            Leaf,
            Wood,
            Rock,
            Stone,
            Crystal,
            Sand,
            Dirt,
            Metal,
            Paint,
            Plastic,
            Fur,
            Scale,
            Feather,
            Water,
            Cloud,
            Sky,
            Space,
            Underbelly,
            Undercoat,
            Snow,
            SkyHorizon,
            SkyFog,
            SkyHeightFog,
            SkySunset,
            SkyNight,
            WaterNear,
            SpaceCloud,
            SpaceBottom,
            SpaceSolar,
            SpaceLight,
            Warrior,
            Scientific,
            Trader,
            WarriorAlt,
            ScientificAlt,
            TraderAlt,
            RockSaturated,
            RockLight,
            RockDark,
            PlanetRing,
            Custom_Head,
            Custom_Torso,
            Custom_Chest_Armour,
            Custom_Backpack,
            Custom_Arms,
            Custom_Hands,
            Custom_Legs,
            Custom_Feet,
            Cave,
            GrassAlt,
            BioShip_Body,
            BioShip_Underbelly,
            BioShip_Cockpit,
            SailShip_Sails,
            Freighter,
            FreighterPaint,
            PirateBase,
            PirateAlt,
            SpaceStationBase,
            SpaceStationAlt,
            SpaceStationLights,
        }
        [NMS(Index = 0)]
        /* 0x4 */ public PaletteEnum Palette;
    }
}
