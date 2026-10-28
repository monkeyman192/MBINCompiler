using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC7B2DD572E127E04, NameHash = 0x2338AA60)]
    public class GcBaseBuildingEntry : NMSTemplate
    {
        [NMS(Index = 63)]
        /* 0x000 */ public GcBaseLinkGridData LinkGridData;
        [NMS(Index = 37)]
        /* 0x058 */ public NMSString0x20A ColourPaletteGroupId;
        [NMS(Index = 48)]
        /* 0x078 */ public NMSString0x20A CompositePartShopAliasL;
        [NMS(Index = 47)]
        /* 0x098 */ public NMSString0x20A CompositePartShopAliasU;
        [NMS(Index = 39)]
        /* 0x0B8 */ public NMSString0x20A DefaultColourPaletteId;
        [NMS(Index = 41)]
        /* 0x0D8 */ public NMSString0x20A DefaultMaterialId;
        [NMS(Index = 72)]
        /* 0x0F8 */ public NMSString0x20A DescriptorID;
        [NMS(Index = 40)]
        /* 0x118 */ public NMSString0x20A MaterialGroupId;
        [NMS(Index = 68)]
        /* 0x138 */ public TkModelResource NPCInteractionScene;
        [NMS(Index = 4)]
        /* 0x158 */ public TkModelResource PlacementScene;
        [NMS(Index = 5)]
        /* 0x178 */ public NMSString0x20A SinglePartID;
        [NMS(Index = 38)]
        /* 0x198 */ public NMSString0x20A StationColourPaletteGroupId;
        [NMS(Index = 46)]
        /* 0x1B8 */ public List<NMSString0x10> CompositePartObjectIDs;
        [NMS(Index = 49)]
        /* 0x1C8 */ public List<NMSString0x10> FamilyIDs;
        [NMS(Index = 73)]
        /* 0x1D8 */ public NMSString0x10 FossilDisplayID;
        [NMS(Index = 35)]
        /* 0x1E8 */ public List<GcBaseBuildingEntryGroup> Groups;
        [NMS(Index = 51)]
        /* 0x1F8 */ public NMSString0x10 IconOverrideProductID;
        [NMS(Index = 0)]
        /* 0x208 */ public NMSString0x10 ID;
        [NMS(Index = 70)]
        /* 0x218 */ public NMSString0x10 ModularCustomisationBaseID;
        [NMS(Index = 76)]
        /* 0x228 */ public NMSString0x10 OverrideProductID;
        [NMS(Index = 62)]
        /* 0x238 */ public NMSString0x10 Tag;
        // size: 0x2
        public enum BaseTerrainEditShapeEnum : uint {
            Cube,
            Cylinder,
        }
        [NMS(Index = 55)]
        /* 0x248 */ public BaseTerrainEditShapeEnum BaseTerrainEditShape;
        [NMS(Index = 10)]
        /* 0x24C */ public GcBiomeType Biome;
        [NMS(Index = 50)]
        /* 0x250 */ public float BuildEffectAccelerator;
        [NMS(Index = 27)]
        /* 0x254 */ public int CorvetteBaseLimit;
        [NMS(Index = 6)]
        /* 0x258 */ public GcBaseBuildingObjectDecorationTypes DecorationType;
        [NMS(Index = 26)]
        /* 0x25C */ public int FreighterBaseLimit;
        [NMS(Index = 64)]
        /* 0x260 */ public int GhostsCountOverride;
        [NMS(Index = 60)]
        /* 0x264 */ public float GravityFalloff;
        [NMS(Index = 59)]
        /* 0x268 */ public float GravityStrength;
        [NMS(Index = 56)]
        /* 0x26C */ public float MinimumDeleteDistance;
        [NMS(Index = 25)]
        /* 0x270 */ public int PlanetBaseLimit;
        [NMS(Index = 23)]
        /* 0x274 */ public int PlanetLimit;
        [NMS(Index = 24)]
        /* 0x278 */ public int RegionLimit;
        [NMS(Index = 67)]
        /* 0x27C */ public int RegionSpawnLOD;
        [NMS(Index = 66)]
        /* 0x280 */ public float SnappingDistanceOverride;
        [NMS(Index = 36)]
        /* 0x284 */ public int StorageContainerIndex;
        [NMS(Index = 3)]
        /* 0x288 */ public GcBaseBuildingPartStyle Style;
        [NMS(Index = 19)]
        /* 0x28C */ public bool BuildableAboveWater;
        [NMS(Index = 15)]
        /* 0x28D */ public bool BuildableInShipDecorative;
        [NMS(Index = 14)]
        /* 0x28E */ public bool BuildableInShipStructural;
        [NMS(Index = 13)]
        /* 0x28F */ public bool BuildableOnFreighter;
        [NMS(Index = 16)]
        /* 0x290 */ public bool BuildableOnPlanet;
        [NMS(Index = 11)]
        /* 0x291 */ public bool BuildableOnPlanetBase;
        [NMS(Index = 17)]
        /* 0x292 */ public bool BuildableOnPlanetWithProduct;
        [NMS(Index = 12)]
        /* 0x293 */ public bool BuildableOnSpaceBase;
        [NMS(Index = 21)]
        /* 0x294 */ public bool BuildableOnSpaceStationBackSection;
        [NMS(Index = 20)]
        /* 0x295 */ public bool BuildableOnSpaceStationBase;
        [NMS(Index = 22)]
        /* 0x296 */ public bool BuildableOnSpaceStationExterior;
        [NMS(Index = 18)]
        /* 0x297 */ public bool BuildableUnderwater;
        [NMS(Index = 42)]
        /* 0x298 */ public bool CanChangeColour;
        [NMS(Index = 43)]
        /* 0x299 */ public bool CanChangeMaterial;
        [NMS(Index = 44)]
        /* 0x29A */ public bool CanPickUp;
        [NMS(Index = 33)]
        /* 0x29B */ public bool CanRotate3D;
        [NMS(Index = 34)]
        /* 0x29C */ public bool CanScale;
        [NMS(Index = 31)]
        /* 0x29D */ public bool CanStack;
        [NMS(Index = 29)]
        /* 0x29E */ public bool CheckPlaceholderCollision;
        [NMS(Index = 30)]
        /* 0x29F */ public bool CheckPlayerCollision;
        [NMS(Index = 61)]
        /* 0x2A0 */ public bool CloseMenuAfterBuild;
        [NMS(Index = 28)]
        /* 0x2A1 */ public bool DoesNotCountTowardsComplexity;
        [NMS(Index = 54)]
        /* 0x2A2 */ public bool EditsTerrain;
        [NMS(Index = 71)]
        /* 0x2A3 */ public bool HasDescriptor;
        [NMS(Index = 58)]
        /* 0x2A4 */ public bool HasGravity;
        [NMS(Index = 9)]
        /* 0x2A5 */ public bool IsDecoration;
        [NMS(Index = 2)]
        /* 0x2A6 */ public bool IsFromModFolder;
        [NMS(Index = 69)]
        /* 0x2A7 */ public bool IsModularCustomisation;
        [NMS(Index = 7)]
        /* 0x2A8 */ public bool IsPlaceable;
        [NMS(Index = 8)]
        /* 0x2A9 */ public bool IsPlaceableFloatingInSpace;
        [NMS(Index = 57)]
        /* 0x2AA */ public bool IsSealed;
        [NMS(Index = 1)]
        /* 0x2AB */ public bool IsTemporary;
        [NMS(Index = 52)]
        /* 0x2AC */ public bool RemovesAttachedDecoration;
        [NMS(Index = 53)]
        /* 0x2AD */ public bool RemovesWhenUnsnapped;
        [NMS(Index = 65)]
        /* 0x2AE */ public bool ShowGhosts;
        [NMS(Index = 45)]
        /* 0x2AF */ public bool ShowInBuildMenu;
        [NMS(Index = 32)]
        /* 0x2B0 */ public bool SnapRotateBlocked;
        [NMS(Index = 74)]
        /* 0x2B1 */ public bool UseProductIDOverride;
        [NMS(Index = 75)]
        /* 0x2B2 */ public bool UseProductIDOverrideInSpace;
    }
}
