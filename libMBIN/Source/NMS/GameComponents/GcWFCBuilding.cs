using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2DFFDA7D2829661D, NameHash = 0x42C648ED396E4B44)]
    public class GcWFCBuilding : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20 Name;
        /* 0x020 */ public NMSString0x80 ModuleSet;
        [NMS(Size = 0x2, EnumType = typeof(GcWFCDecorationTheme.WFCDecorationThemeEnum))]
        /* 0x0A0 */ public NMSString0x80[] Decoration;
        /* 0x1A0 */ public bool ImprovedCoherence;
        /* 0x1A1 */ public bool RequireNoUnreachableRooms;
        /* 0x1A4 */ public float InitialUnlockProbability;
        /* 0x1A8 */ public bool DontSpawnNearPlayerBases;
        /* 0x1A9 */ public bool RemoveUnreachableBlocks;
        /* 0x1B0 */ public List<NMSString0x10> GroupsEnabled;
        /* 0x1C0 */ public List<GcModuleOverride> ModuleOverrides;
        /* 0x1D0 */ public List<GcMinimumUseConstraint> MinimumUseConstraints;
        /* 0x1E0 */ public List<NMSString0x10> NPCs;
        /* 0x1F0 */ public List<GcWeightedResource> Layouts;
        /* 0x200 */ public List<GcWeightedBuildingSize> Sizes;
        /* 0x210 */ public List<long> FallbackSeeds;        // Not 100% about this datatype, but it's definitelty a list, and the objects look to be 8 bytes and it's not a ulong...
        /* 0x220 */ public List<long> PresetFallbackSeeds;
        /* 0x230 */ public int NumberOfPresetsPerPlanet;
        /* 0x234 */ public GcBaseBuildingPartStyle ReplaceMaterials;
        /* 0x238 */ public List<GcFreighterBaseRoom> Rooms;
    }
}
