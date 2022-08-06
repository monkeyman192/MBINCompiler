using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8AE44D0FFA901B0F, NameHash = 0x6A57676B42321253)]
    public class TkPaletteTexture : NMSTemplate
    {
        // size: 0x3A
        public enum PaletteEnum { Grass, Plant, Leaf, Wood, Rock, Stone, Crystal, Sand, Dirt, Metal, 
            Paint, Plastic, Fur, Scale, Feather, Water, Cloud, Sky, Space, Underbelly, 
            Undercoat, Snow, SkyHorizon, SkyFog, SkyHeightFog, SkySunset, SkyNight, WaterNear, SpaceCloud, SpaceBottom, 
            SpaceSolar, SpaceLight, Warrior, Scientific, Trader, WarriorAlt, ScientificAlt, TraderAlt, RockSaturated, RockLight, 
            RockDark, PlanetRing, Custom_Head, Custom_Torso, Custom_Chest_Armour, Custom_Backpack, Custom_Arms, Custom_Hands, Custom_Legs, Custom_Feet, 
            Cave, GrassAlt, BioShip_Body, BioShip_Underbelly, BioShip_Cockpit, SailShip_Sails, Freighter, FreighterPaint
        }
        /* 0x0 */ public PaletteEnum Palette;
        // size: 0x8
        public enum ColourAltEnum { Primary, Alternative1, Alternative2, Alternative3, Alternative4, Unique, MatchGround, None }
        /* 0x4 */ public ColourAltEnum ColourAlt;
    }
}
