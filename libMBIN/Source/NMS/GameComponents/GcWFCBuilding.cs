using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEFF0648CC00F8AB8, NameHash = 0x42C648ED396E4B44)]
    public class GcWFCBuilding : NMSTemplate
    {
        [NMS(Index = 14)]
        /* 0x000 */ public List<long> FallbackSeeds;
        [NMS(Index = 8)]
        /* 0x010 */ public List<NMSString0x10> GroupsEnabled;
        [NMS(Index = 12)]
        /* 0x020 */ public List<GcWeightedResource> Layouts;
        [NMS(Index = 10)]
        /* 0x030 */ public List<GcMinimumUseConstraint> MinimumUseConstraints;
        [NMS(Index = 9)]
        /* 0x040 */ public List<GcModuleOverride> ModuleOverrides;
        [NMS(Index = 11)]
        /* 0x050 */ public List<NMSString0x10> NPCs;
        [NMS(Index = 15)]
        /* 0x060 */ public List<long> PresetFallbackSeeds;
        [NMS(Index = 18)]
        /* 0x070 */ public List<GcFreighterBaseRoom> Rooms;
        [NMS(Index = 13)]
        /* 0x080 */ public List<GcWeightedBuildingSize> Sizes;
        [NMS(Index = 5)]
        /* 0x090 */ public float InitialUnlockProbability;
        [NMS(Index = 16)]
        /* 0x094 */ public int NumberOfPresetsPerPlanet;
        [NMS(Index = 17)]
        /* 0x098 */ public GcBaseBuildingPartStyle ReplaceMaterials;
        [NMS(Index = 2, Size = 0x2, EnumType = typeof(GcWFCDecorationTheme.WFCDecorationThemeEnum))]
        /* 0x09C */ public NMSString0x80[] Decoration;
        [NMS(Index = 1)]
        /* 0x19C */ public NMSString0x80 ModuleSet;
        [NMS(Index = 0)]
        /* 0x21C */ public NMSString0x20 Name;
        [NMS(Index = 6)]
        /* 0x23C */ public bool DontSpawnNearPlayerBases;
        [NMS(Index = 3)]
        /* 0x23D */ public bool ImprovedCoherence;
        [NMS(Index = 7)]
        /* 0x23E */ public bool RemoveUnreachableBlocks;
        [NMS(Index = 4)]
        /* 0x23F */ public bool RequireNoUnreachableRooms;
    }
}
