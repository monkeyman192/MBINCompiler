using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5F2D6F14F07DEB2E, NameHash = 0x2338AA60)]
    public class GcBaseBuildingEntry : NMSTemplate
    {
        [NMS(Index = 61)]
        /* 0x000 */ public GcBaseLinkGridData LinkGridData;
        [NMS(Index = 37)]
        /* 0x058 */ public NMSString0x20A ColourPaletteGroupId;
        [NMS(Index = 39)]
        /* 0x078 */ public NMSString0x20A DefaultColourPaletteId;
        [NMS(Index = 41)]
        /* 0x098 */ public NMSString0x20A DefaultMaterialId;
        [NMS(Index = 70)]
        /* 0x0B8 */ public NMSString0x20A DescriptorID;
        [NMS(Index = 40)]
        /* 0x0D8 */ public NMSString0x20A MaterialGroupId;
        [NMS(Index = 66)]
        /* 0x0F8 */ public TkModelResource NPCInteractionScene;
        [NMS(Index = 4)]
        /* 0x118 */ public TkModelResource PlacementScene;
        [NMS(Index = 5)]
        /* 0x138 */ public NMSString0x20A SinglePartID;
        [NMS(Index = 38)]
        /* 0x158 */ public NMSString0x20A StationColourPaletteGroupId;
        [NMS(Index = 46)]
        /* 0x178 */ public List<NMSString0x10> CompositePartObjectIDs;
        [NMS(Index = 47)]
        /* 0x188 */ public List<NMSString0x10> FamilyIDs;
        [NMS(Index = 71)]
        /* 0x198 */ public NMSString0x10 FossilDisplayID;
        [NMS(Index = 35)]
        /* 0x1A8 */ public List<GcBaseBuildingEntryGroup> Groups;
        [NMS(Index = 49)]
        /* 0x1B8 */ public NMSString0x10 IconOverrideProductID;
        [NMS(Index = 0)]
        /* 0x1C8 */ public NMSString0x10 ID;
        [NMS(Index = 68)]
        /* 0x1D8 */ public NMSString0x10 ModularCustomisationBaseID;
        [NMS(Index = 74)]
        /* 0x1E8 */ public NMSString0x10 OverrideProductID;
        [NMS(Index = 60)]
        /* 0x1F8 */ public NMSString0x10 Tag;
        // size: 0x2
        public enum BaseTerrainEditShapeEnum : uint {
            Cube,
            Cylinder,
        }
        [NMS(Index = 53)]
        /* 0x208 */ public BaseTerrainEditShapeEnum BaseTerrainEditShape;
        [NMS(Index = 10)]
        /* 0x20C */ public GcBiomeType Biome;
        [NMS(Index = 48)]
        /* 0x210 */ public float BuildEffectAccelerator;
        [NMS(Index = 27)]
        /* 0x214 */ public int CorvetteBaseLimit;
        [NMS(Index = 6)]
        /* 0x218 */ public GcBaseBuildingObjectDecorationTypes DecorationType;
        [NMS(Index = 26)]
        /* 0x21C */ public int FreighterBaseLimit;
        [NMS(Index = 62)]
        /* 0x220 */ public int GhostsCountOverride;
        [NMS(Index = 58)]
        /* 0x224 */ public float GravityFalloff;
        [NMS(Index = 57)]
        /* 0x228 */ public float GravityStrength;
        [NMS(Index = 54)]
        /* 0x22C */ public float MinimumDeleteDistance;
        [NMS(Index = 25)]
        /* 0x230 */ public int PlanetBaseLimit;
        [NMS(Index = 23)]
        /* 0x234 */ public int PlanetLimit;
        [NMS(Index = 24)]
        /* 0x238 */ public int RegionLimit;
        [NMS(Index = 65)]
        /* 0x23C */ public int RegionSpawnLOD;
        [NMS(Index = 64)]
        /* 0x240 */ public float SnappingDistanceOverride;
        [NMS(Index = 36)]
        /* 0x244 */ public int StorageContainerIndex;
        [NMS(Index = 3)]
        /* 0x248 */ public GcBaseBuildingPartStyle Style;
        [NMS(Index = 19)]
        /* 0x24C */ public bool BuildableAboveWater;
        [NMS(Index = 15)]
        /* 0x24D */ public bool BuildableInShipDecorative;
        [NMS(Index = 14)]
        /* 0x24E */ public bool BuildableInShipStructural;
        [NMS(Index = 13)]
        /* 0x24F */ public bool BuildableOnFreighter;
        [NMS(Index = 16)]
        /* 0x250 */ public bool BuildableOnPlanet;
        [NMS(Index = 11)]
        /* 0x251 */ public bool BuildableOnPlanetBase;
        [NMS(Index = 17)]
        /* 0x252 */ public bool BuildableOnPlanetWithProduct;
        [NMS(Index = 12)]
        /* 0x253 */ public bool BuildableOnSpaceBase;
        [NMS(Index = 21)]
        /* 0x254 */ public bool BuildableOnSpaceStationBackSection;
        [NMS(Index = 20)]
        /* 0x255 */ public bool BuildableOnSpaceStationBase;
        [NMS(Index = 22)]
        /* 0x256 */ public bool BuildableOnSpaceStationExterior;
        [NMS(Index = 18)]
        /* 0x257 */ public bool BuildableUnderwater;
        [NMS(Index = 42)]
        /* 0x258 */ public bool CanChangeColour;
        [NMS(Index = 43)]
        /* 0x259 */ public bool CanChangeMaterial;
        [NMS(Index = 44)]
        /* 0x25A */ public bool CanPickUp;
        [NMS(Index = 33)]
        /* 0x25B */ public bool CanRotate3D;
        [NMS(Index = 34)]
        /* 0x25C */ public bool CanScale;
        [NMS(Index = 31)]
        /* 0x25D */ public bool CanStack;
        [NMS(Index = 29)]
        /* 0x25E */ public bool CheckPlaceholderCollision;
        [NMS(Index = 30)]
        /* 0x25F */ public bool CheckPlayerCollision;
        [NMS(Index = 59)]
        /* 0x260 */ public bool CloseMenuAfterBuild;
        [NMS(Index = 28)]
        /* 0x261 */ public bool DoesNotCountTowardsComplexity;
        [NMS(Index = 52)]
        /* 0x262 */ public bool EditsTerrain;
        [NMS(Index = 69)]
        /* 0x263 */ public bool HasDescriptor;
        [NMS(Index = 56)]
        /* 0x264 */ public bool HasGravity;
        [NMS(Index = 9)]
        /* 0x265 */ public bool IsDecoration;
        [NMS(Index = 2)]
        /* 0x266 */ public bool IsFromModFolder;
        [NMS(Index = 67)]
        /* 0x267 */ public bool IsModularCustomisation;
        [NMS(Index = 7)]
        /* 0x268 */ public bool IsPlaceable;
        [NMS(Index = 8)]
        /* 0x269 */ public bool IsPlaceableFloatingInSpace;
        [NMS(Index = 55)]
        /* 0x26A */ public bool IsSealed;
        [NMS(Index = 1)]
        /* 0x26B */ public bool IsTemporary;
        [NMS(Index = 50)]
        /* 0x26C */ public bool RemovesAttachedDecoration;
        [NMS(Index = 51)]
        /* 0x26D */ public bool RemovesWhenUnsnapped;
        [NMS(Index = 63)]
        /* 0x26E */ public bool ShowGhosts;
        [NMS(Index = 45)]
        /* 0x26F */ public bool ShowInBuildMenu;
        [NMS(Index = 32)]
        /* 0x270 */ public bool SnapRotateBlocked;
        [NMS(Index = 72)]
        /* 0x271 */ public bool UseProductIDOverride;
        [NMS(Index = 73)]
        /* 0x272 */ public bool UseProductIDOverrideInSpace;
    }
}
