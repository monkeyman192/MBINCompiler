using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4F06BE19F8C411AF, NameHash = 0xD9CF4DB4)]
    public class GcWFCBuilding : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public GcFilename DecorationSet;
        [NMS(Index = 14, MxmlName = "Fallback Seeds")]
        /* 0x10 */ public List<long> FallbackSeeds;
        [NMS(Index = 8)]
        /* 0x20 */ public List<NMSString0x10> GroupsEnabled;
        [NMS(Index = 12)]
        /* 0x30 */ public List<GcWeightedResource> Layouts;
        [NMS(Index = 10)]
        /* 0x40 */ public List<GcMinimumUseConstraint> MinimumUseConstraints;
        [NMS(Index = 9)]
        /* 0x50 */ public List<GcModuleOverride> ModuleOverrides;
        [NMS(Index = 1)]
        /* 0x60 */ public GcFilename ModuleSet;
        [NMS(Index = 11)]
        /* 0x70 */ public List<NMSString0x10> NPCs;
        [NMS(Index = 15, MxmlName = "Preset Fallback Seeds")]
        /* 0x80 */ public List<long> PresetFallbackSeeds;
        [NMS(Index = 18)]
        /* 0x90 */ public List<GcFreighterBaseRoom> Rooms;
        [NMS(Index = 13)]
        /* 0xA0 */ public List<GcWeightedBuildingSize> Sizes;
        [NMS(Index = 5)]
        /* 0xB0 */ public float InitialUnlockProbability;
        [NMS(Index = 16, MxmlName = "Number Of Presets Per Planet")]
        /* 0xB4 */ public int NumberOfPresetsPerPlanet;
        [NMS(Index = 17, MxmlName = "Replace Materials")]
        /* 0xB8 */ public GcBaseBuildingPartStyle ReplaceMaterials;
        [NMS(Index = 0)]
        /* 0xBC */ public NMSString0x20 Name;
        [NMS(Index = 6)]
        /* 0xDC */ public bool DontSpawnNearPlayerBases;
        [NMS(Index = 3)]
        /* 0xDD */ public bool ImprovedCoherence;
        [NMS(Index = 7)]
        /* 0xDE */ public bool RemoveUnreachableBlocks;
        [NMS(Index = 4, MxmlName = "Require No Unreachable Rooms")]
        /* 0xDF */ public bool RequireNoUnreachableRooms;
    }
}
