using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x73BBAC671634F9F7, NameHash = 0xA6F7B710166F6076)]
    public class GcBaseBuildingEntry : NMSTemplate
    {
        /* 0x000 */ public GcBaseLinkGridData LinkGridData;
        /* 0x058 */ public NMSString0x20A ColourPaletteGroupId;
        /* 0x078 */ public NMSString0x20A DefaultColourPaletteId;
        /* 0x098 */ public NMSString0x20A DefaultMaterialId;
        /* 0x0B8 */ public NMSString0x20A MaterialGroupId;
        /* 0x0D8 */ public NMSString0x20A SinglePartID;
        /* 0x0F8 */ public List<NMSString0x10> CompositePartObjectIDs;
        /* 0x108 */ public List<NMSString0x10> FamilyIDs;
        /* 0x118 */ public List<GcBaseBuildingEntryGroup> Groups;
        /* 0x128 */ public NMSString0x10 ID;
        /* 0x138 */ public TkModelResource NPCInteractionScene;
        /* 0x1BC */ public TkModelResource PlacementScene;
        // size: 0x2
        public enum BaseTerrainEditShapeEnum : uint {
            Cube,
            Cylinder,
        }
        /* 0x240 */ public BaseTerrainEditShapeEnum BaseTerrainEditShape;
        /* 0x244 */ public GcBiomeType Biome;
        /* 0x248 */ public float BuildEffectAccelerator;
        /* 0x24C */ public GcBaseBuildingObjectDecorationTypes DecorationType;
        /* 0x250 */ public int FreighterBaseLimit;
        /* 0x254 */ public int GhostsCountOverride;
        /* 0x258 */ public float MinimumDeleteDistance;
        /* 0x25C */ public int PlanetBaseLimit;
        /* 0x260 */ public int PlanetLimit;
        /* 0x264 */ public int RegionLimit;
        /* 0x268 */ public int RegionSpawnLOD;
        /* 0x26C */ public float SnappingDistanceOverride;
        /* 0x270 */ public int StorageContainerIndex;
        /* 0x274 */ public GcBaseBuildingPartStyle Style;
        /* 0x278 */ public bool BuildableAboveWater;
        /* 0x279 */ public bool BuildableOnFreighter;
        /* 0x27A */ public bool BuildableOnPlanet;
        /* 0x27B */ public bool BuildableOnPlanetBase;
        /* 0x27C */ public bool BuildableOnPlanetWithProduct;
        /* 0x27D */ public bool BuildableOnSpaceBase;
        /* 0x27E */ public bool BuildableUnderwater;
        /* 0x27F */ public bool CanChangeColour;
        /* 0x280 */ public bool CanChangeMaterial;
        /* 0x281 */ public bool CanPickUp;
        /* 0x282 */ public bool CanRotate3D;
        /* 0x283 */ public bool CanScale;
        /* 0x284 */ public bool CheckPlaceholderCollision;
        /* 0x285 */ public bool CheckPlayerCollision;
        /* 0x286 */ public bool CloseMenuAfterBuild;
        /* 0x287 */ public bool EditsTerrain;
        /* 0x288 */ public bool IsDecoration;
        /* 0x289 */ public bool IsFromModFolder;
        /* 0x28A */ public bool IsPlaceable;
        /* 0x28B */ public bool IsSealed;
        /* 0x28C */ public bool IsTemporary;
        /* 0x28D */ public bool RemovesAttachedDecoration;
        /* 0x28E */ public bool RemovesWhenUnsnapped;
        /* 0x28F */ public bool ShowGhosts;
        /* 0x290 */ public bool ShowInBuildMenu;
    }
}
