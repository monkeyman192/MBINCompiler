using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF1ECDCBC7D8C66F9, NameHash = 0xD9CF4DB4)]
    public class GcWFCBuilding : NMSTemplate
    {
        [NMS(Index = 2, Size = 0x2, EnumType = typeof(GcWFCDecorationTheme.WFCDecorationThemeEnum))]
        /* 0x00 */ public VariableSizeString[] Decoration;
        [NMS(Index = 14)]
        /* 0x20 */ public List<long> FallbackSeeds;
        [NMS(Index = 8)]
        /* 0x30 */ public List<NMSString0x10> GroupsEnabled;
        [NMS(Index = 12)]
        /* 0x40 */ public List<GcWeightedResource> Layouts;
        [NMS(Index = 10)]
        /* 0x50 */ public List<GcMinimumUseConstraint> MinimumUseConstraints;
        [NMS(Index = 9)]
        /* 0x60 */ public List<GcModuleOverride> ModuleOverrides;
        [NMS(Index = 1)]
        /* 0x70 */ public VariableSizeString ModuleSet;
        [NMS(Index = 11)]
        /* 0x80 */ public List<NMSString0x10> NPCs;
        [NMS(Index = 15)]
        /* 0x90 */ public List<long> PresetFallbackSeeds;
        [NMS(Index = 18)]
        /* 0xA0 */ public List<GcFreighterBaseRoom> Rooms;
        [NMS(Index = 13)]
        /* 0xB0 */ public List<GcWeightedBuildingSize> Sizes;
        [NMS(Index = 5)]
        /* 0xC0 */ public float InitialUnlockProbability;
        [NMS(Index = 16)]
        /* 0xC4 */ public int NumberOfPresetsPerPlanet;
        [NMS(Index = 17)]
        /* 0xC8 */ public GcBaseBuildingPartStyle ReplaceMaterials;
        [NMS(Index = 0)]
        /* 0xCC */ public NMSString0x20 Name;
        [NMS(Index = 6)]
        /* 0xEC */ public bool DontSpawnNearPlayerBases;
        [NMS(Index = 3)]
        /* 0xED */ public bool ImprovedCoherence;
        [NMS(Index = 7)]
        /* 0xEE */ public bool RemoveUnreachableBlocks;
        [NMS(Index = 4)]
        /* 0xEF */ public bool RequireNoUnreachableRooms;
    }
}
