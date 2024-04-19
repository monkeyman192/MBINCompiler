using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEFF0648CC00F8AB8, NameHash = 0x42C648ED396E4B44)]
    public class GcWFCBuilding : NMSTemplate
    {
        /* 0x000 */ public List<long> FallbackSeeds;
        /* 0x010 */ public List<NMSString0x10> GroupsEnabled;
        /* 0x020 */ public List<GcWeightedResource> Layouts;
        /* 0x030 */ public List<GcMinimumUseConstraint> MinimumUseConstraints;
        /* 0x040 */ public List<GcModuleOverride> ModuleOverrides;
        /* 0x050 */ public List<NMSString0x10> NPCs;
        /* 0x060 */ public List<long> PresetFallbackSeeds;
        /* 0x070 */ public List<GcFreighterBaseRoom> Rooms;
        /* 0x080 */ public List<GcWeightedBuildingSize> Sizes;
        /* 0x090 */ public float InitialUnlockProbability;
        /* 0x094 */ public int NumberOfPresetsPerPlanet;
        /* 0x098 */ public GcBaseBuildingPartStyle ReplaceMaterials;
        [NMS(Size = 0x2, EnumType = typeof(GcWFCDecorationTheme.WFCDecorationThemeEnum))]
        /* 0x09C */ public NMSString0x80[] Decoration;
        /* 0x19C */ public NMSString0x80 ModuleSet;
        /* 0x21C */ public NMSString0x20 Name;
        /* 0x23C */ public bool DontSpawnNearPlayerBases;
        /* 0x23D */ public bool ImprovedCoherence;
        /* 0x23E */ public bool RemoveUnreachableBlocks;
        /* 0x23F */ public bool RequireNoUnreachableRooms;
    }
}
