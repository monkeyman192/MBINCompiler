using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x872EB643CE0EB05F, NameHash = 0x2338AA60)]
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
        [NMS(Index = 50)]
        /* 0x0F8 */ public TkModelResource NPCInteractionScene;
        [NMS(Index = 4)]
        /* 0x110 */ public TkModelResource PlacementScene;
        [NMS(Index = 35)]
        /* 0x128 */ public List<NMSString0x10> CompositePartObjectIDs;
        [NMS(Index = 36)]
        /* 0x138 */ public List<NMSString0x10> FamilyIDs;
        [NMS(Index = 25)]
        /* 0x148 */ public List<GcBaseBuildingEntryGroup> Groups;
        [NMS(Index = 0)]
        /* 0x158 */ public NMSString0x10 ID;
        // size: 0x2
        public enum BaseTerrainEditShapeEnum : uint {
            Cube,
            Cylinder,
        }
        [NMS(Index = 41)]
        /* 0x168 */ public BaseTerrainEditShapeEnum BaseTerrainEditShape;
        [NMS(Index = 9)]
        /* 0x16C */ public GcBiomeType Biome;
        [NMS(Index = 37)]
        /* 0x170 */ public float BuildEffectAccelerator;
        [NMS(Index = 6)]
        /* 0x174 */ public GcBaseBuildingObjectDecorationTypes DecorationType;
        [NMS(Index = 20)]
        /* 0x178 */ public int FreighterBaseLimit;
        [NMS(Index = 46)]
        /* 0x17C */ public int GhostsCountOverride;
        [NMS(Index = 42)]
        /* 0x180 */ public float MinimumDeleteDistance;
        [NMS(Index = 19)]
        /* 0x184 */ public int PlanetBaseLimit;
        [NMS(Index = 17)]
        /* 0x188 */ public int PlanetLimit;
        [NMS(Index = 18)]
        /* 0x18C */ public int RegionLimit;
        [NMS(Index = 49)]
        /* 0x190 */ public int RegionSpawnLOD;
        [NMS(Index = 48)]
        /* 0x194 */ public float SnappingDistanceOverride;
        [NMS(Index = 26)]
        /* 0x198 */ public int StorageContainerIndex;
        [NMS(Index = 3)]
        /* 0x19C */ public GcBaseBuildingPartStyle Style;
        [NMS(Index = 16)]
        /* 0x1A0 */ public bool BuildableAboveWater;
        [NMS(Index = 12)]
        /* 0x1A1 */ public bool BuildableOnFreighter;
        [NMS(Index = 13)]
        /* 0x1A2 */ public bool BuildableOnPlanet;
        [NMS(Index = 10)]
        /* 0x1A3 */ public bool BuildableOnPlanetBase;
        [NMS(Index = 14)]
        /* 0x1A4 */ public bool BuildableOnPlanetWithProduct;
        [NMS(Index = 11)]
        /* 0x1A5 */ public bool BuildableOnSpaceBase;
        [NMS(Index = 15)]
        /* 0x1A6 */ public bool BuildableUnderwater;
        [NMS(Index = 31)]
        /* 0x1A7 */ public bool CanChangeColour;
        [NMS(Index = 32)]
        /* 0x1A8 */ public bool CanChangeMaterial;
        [NMS(Index = 33)]
        /* 0x1A9 */ public bool CanPickUp;
        [NMS(Index = 23)]
        /* 0x1AA */ public bool CanRotate3D;
        [NMS(Index = 24)]
        /* 0x1AB */ public bool CanScale;
        [NMS(Index = 21)]
        /* 0x1AC */ public bool CheckPlaceholderCollision;
        [NMS(Index = 22)]
        /* 0x1AD */ public bool CheckPlayerCollision;
        [NMS(Index = 44)]
        /* 0x1AE */ public bool CloseMenuAfterBuild;
        [NMS(Index = 40)]
        /* 0x1AF */ public bool EditsTerrain;
        [NMS(Index = 8)]
        /* 0x1B0 */ public bool IsDecoration;
        [NMS(Index = 2)]
        /* 0x1B1 */ public bool IsFromModFolder;
        [NMS(Index = 7)]
        /* 0x1B2 */ public bool IsPlaceable;
        [NMS(Index = 43)]
        /* 0x1B3 */ public bool IsSealed;
        [NMS(Index = 1)]
        /* 0x1B4 */ public bool IsTemporary;
        [NMS(Index = 38)]
        /* 0x1B5 */ public bool RemovesAttachedDecoration;
        [NMS(Index = 39)]
        /* 0x1B6 */ public bool RemovesWhenUnsnapped;
        [NMS(Index = 47)]
        /* 0x1B7 */ public bool ShowGhosts;
        [NMS(Index = 34)]
        /* 0x1B8 */ public bool ShowInBuildMenu;
    }
}
