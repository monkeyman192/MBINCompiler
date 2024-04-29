using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x38D400BB6444C8F2, NameHash = 0xA6F7B710166F6076)]
    public class GcBaseBuildingEntry : NMSTemplate
    {
        [NMS(Index = 45)]
        /* 0x000 */ public GcBaseLinkGridData LinkGridData;
        [NMS(Index = 27)]
        /* 0x058 */ public NMSString0x20A ColourPaletteGroupId;
        [NMS(Index = 28)]
        /* 0x078 */ public NMSString0x20A DefaultColourPaletteId;
        [NMS(Index = 30)]
        /* 0x098 */ public NMSString0x20A DefaultMaterialId;
        [NMS(Index = 29)]
        /* 0x0B8 */ public NMSString0x20A MaterialGroupId;
        [NMS(Index = 5)]
        /* 0x0D8 */ public NMSString0x20A SinglePartID;
        [NMS(Index = 35)]
        /* 0x0F8 */ public List<NMSString0x10> CompositePartObjectIDs;
        [NMS(Index = 36)]
        /* 0x108 */ public List<NMSString0x10> FamilyIDs;
        [NMS(Index = 25)]
        /* 0x118 */ public List<GcBaseBuildingEntryGroup> Groups;
        [NMS(Index = 0)]
        /* 0x128 */ public NMSString0x10 ID;
        [NMS(Index = 50)]
        /* 0x138 */ public TkModelResource NPCInteractionScene;
        [NMS(Index = 4)]
        /* 0x1BC */ public TkModelResource PlacementScene;
        // size: 0x2
        public enum BaseTerrainEditShapeEnum : uint {
            Cube,
            Cylinder,
        }
        [NMS(Index = 41)]
        /* 0x240 */ public BaseTerrainEditShapeEnum BaseTerrainEditShape;
        [NMS(Index = 9)]
        /* 0x244 */ public GcBiomeType Biome;
        [NMS(Index = 37)]
        /* 0x248 */ public float BuildEffectAccelerator;
        [NMS(Index = 6)]
        /* 0x24C */ public GcBaseBuildingObjectDecorationTypes DecorationType;
        [NMS(Index = 20)]
        /* 0x250 */ public int FreighterBaseLimit;
        [NMS(Index = 46)]
        /* 0x254 */ public int GhostsCountOverride;
        [NMS(Index = 42)]
        /* 0x258 */ public float MinimumDeleteDistance;
        [NMS(Index = 19)]
        /* 0x25C */ public int PlanetBaseLimit;
        [NMS(Index = 17)]
        /* 0x260 */ public int PlanetLimit;
        [NMS(Index = 18)]
        /* 0x264 */ public int RegionLimit;
        [NMS(Index = 49)]
        /* 0x268 */ public int RegionSpawnLOD;
        [NMS(Index = 48)]
        /* 0x26C */ public float SnappingDistanceOverride;
        [NMS(Index = 26)]
        /* 0x270 */ public int StorageContainerIndex;
        [NMS(Index = 3)]
        /* 0x274 */ public GcBaseBuildingPartStyle Style;
        [NMS(Index = 16)]
        /* 0x278 */ public bool BuildableAboveWater;
        [NMS(Index = 12)]
        /* 0x279 */ public bool BuildableOnFreighter;
        [NMS(Index = 13)]
        /* 0x27A */ public bool BuildableOnPlanet;
        [NMS(Index = 10)]
        /* 0x27B */ public bool BuildableOnPlanetBase;
        [NMS(Index = 14)]
        /* 0x27C */ public bool BuildableOnPlanetWithProduct;
        [NMS(Index = 11)]
        /* 0x27D */ public bool BuildableOnSpaceBase;
        [NMS(Index = 15)]
        /* 0x27E */ public bool BuildableUnderwater;
        [NMS(Index = 31)]
        /* 0x27F */ public bool CanChangeColour;
        [NMS(Index = 32)]
        /* 0x280 */ public bool CanChangeMaterial;
        [NMS(Index = 33)]
        /* 0x281 */ public bool CanPickUp;
        [NMS(Index = 23)]
        /* 0x282 */ public bool CanRotate3D;
        [NMS(Index = 24)]
        /* 0x283 */ public bool CanScale;
        [NMS(Index = 21)]
        /* 0x284 */ public bool CheckPlaceholderCollision;
        [NMS(Index = 22)]
        /* 0x285 */ public bool CheckPlayerCollision;
        [NMS(Index = 44)]
        /* 0x286 */ public bool CloseMenuAfterBuild;
        [NMS(Index = 40)]
        /* 0x287 */ public bool EditsTerrain;
        [NMS(Index = 8)]
        /* 0x288 */ public bool IsDecoration;
        [NMS(Index = 2)]
        /* 0x289 */ public bool IsFromModFolder;
        [NMS(Index = 7)]
        /* 0x28A */ public bool IsPlaceable;
        [NMS(Index = 43)]
        /* 0x28B */ public bool IsSealed;
        [NMS(Index = 1)]
        /* 0x28C */ public bool IsTemporary;
        [NMS(Index = 38)]
        /* 0x28D */ public bool RemovesAttachedDecoration;
        [NMS(Index = 39)]
        /* 0x28E */ public bool RemovesWhenUnsnapped;
        [NMS(Index = 47)]
        /* 0x28F */ public bool ShowGhosts;
        [NMS(Index = 34)]
        /* 0x290 */ public bool ShowInBuildMenu;
    }
}
