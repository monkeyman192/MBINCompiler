using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5104E440BBC7AF54, NameHash = 0xA6F7B710166F6076)]
    public class GcBaseBuildingEntry : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 ID;
        /* 0x010 */ public bool IsTemporary;
        /* 0x011 */ public bool IsFromModFolder;
        /* 0x014 */ public GcBaseBuildingPartStyle Style;
        /* 0x018 */ public TkModelResource PlacementScene;
        /* 0x09C */ public GcBaseBuildingObjectDecorationTypes DecorationType;
        /* 0x0A0 */ public bool IsPlaceable;
        /* 0x0A1 */ public bool IsDecoration;
        /* 0x0A4 */ public GcBiomeType Biome;
        /* 0x0A8 */ public bool BuildableOnPlanetBase;
        /* 0x0A9 */ public bool BuildableOnSpaceBase;
        /* 0x0AA */ public bool BuildableOnFreighter;
        /* 0x0AB */ public bool BuildableOnPlanet;
        /* 0x0AC */ public bool BuildableOnPlanetWithProduct;
        /* 0x0AD */ public bool BuildableUnderwater;
        /* 0x0AE */ public bool BuildableAboveWater;
        /* 0x0B0 */ public int PlanetLimit;
        /* 0x0B4 */ public int RegionLimit;
        /* 0x0B8 */ public int PlanetBaseLimit;
        /* 0x0BC */ public int FreighterBaseLimit;
        /* 0x0C0 */ public bool CheckPlaceholderCollision;
        /* 0x0C1 */ public bool CheckPlayerCollision;
        /* 0x0C2 */ public bool CanRotate3D;
        /* 0x0C3 */ public bool CanScale;
        /* 0x0C8 */ public List<GcBaseBuildingEntryGroup> Groups;
        /* 0x0D8 */ public int StorageContainerIndex;
        /* 0x0E0 */ public NMSString0x20A ColourPaletteGroupId;
        /* 0x100 */ public NMSString0x20A DefaultColourPaletteId;
        /* 0x120 */ public NMSString0x20A MaterialGroupId;
        /* 0x140 */ public NMSString0x20A DefaultMaterialId;
        /* 0x160 */ public bool CanChangeColour;
        /* 0x161 */ public bool CanChangeMaterial;
        /* 0x162 */ public bool CanPickUp;
        /* 0x163 */ public bool ShowInBuildMenu;
        /* 0x168 */ public List<NMSString0x10> CompositePartObjectIDs;
        /* 0x178 */ public List<NMSString0x10> FamilyIDs;
        /* 0x188 */ public float BuildEffectAccelerator;
        /* 0x18C */ public bool RemovesAttachedDecoration;
        /* 0x18D */ public bool RemovesWhenUnsnapped;
        /* 0x18E */ public bool EditsTerrain;
        // size: 0x2
        public enum BaseTerrainEditShapeEnum { Cube, Cylinder }
        /* 0x190 */ public BaseTerrainEditShapeEnum BaseTerrainEditShape;
        /* 0x194 */ public float MinimumDeleteDistance;
        /* 0x198 */ public bool IsSealed;
        /* 0x199 */ public bool CloseMenuAfterBuild;
        /* 0x1A0 */ public GcBaseLinkGridData LinkGridData;
        /* 0x1F8 */ public int GhostsCountOverride;
        /* 0x1FC */ public bool ShowGhosts;
        /* 0x200 */ public float SnappingDistanceOverride;
        /* 0x204 */ public int RegionSpawnLOD;
        /* 0x208 */ public TkModelResource NPCInteractionScene;
    }
}
