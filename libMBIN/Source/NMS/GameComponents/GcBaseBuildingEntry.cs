using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x278, GUID = 0x6C1A6FBF4CB71799, NameHash = 0xA6F7B710166F6076)]
    public class GcBaseBuildingEntry : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 ID;
        /* 0x010 */ public bool HasProduct;
        /* 0x011 */ public bool IsTemporary;
        /* 0x012 */ public bool IsFromModFolder;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x013 */ public byte[] Padding13;
        /* 0x014 */ public TkModelResource SnapPoints;
        /* 0x098 */ public TkModelResource Model;
        /* 0x11C */ public TkModelResource InactiveModel;
        /* 0x1A0 */ public GcBaseBuildingObjectDecorationTypes DecorationType;
        /* 0x1A4 */ public bool IsPlaceable;
        /* 0x1A5 */ public bool IsDecoration;
        /* 0x1A6 */ public bool IsConnection;
        /* 0x1A8 */ public float PlacementNormalOffset;
        /* 0x1AC */ public GcBiomeType Biome;
        /* 0x1B0 */ public bool BuildableOnPlanetBase;
        /* 0x1B1 */ public bool BuildableOnSpaceBase;
        /* 0x1B2 */ public bool BuildableOnFreighter;
        /* 0x1B3 */ public bool BuildableOnPlanet;
        /* 0x1B4 */ public bool BuildableOnPlanetWithProduct;
        /* 0x1B5 */ public bool BuildableUnderwater;
        /* 0x1B6 */ public bool BuildableAboveWater;
        /* 0x1B8 */ public int PlanetLimit;
        /* 0x1BC */ public int RegionLimit;
        /* 0x1C0 */ public int PlanetBaseLimit;
        /* 0x1C4 */ public int FreighterBaseLimit;
        /* 0x1C8 */ public bool CheckPlaceholderCollision;
        /* 0x1CC */ public float CollisionScale;
        /* 0x1D0 */ public bool EnableCollision;
        /* 0x1D1 */ public bool CanPlaceOnItself;
        /* 0x1D2 */ public bool CanRotate3D;
        /* 0x1D3 */ public bool CanScale;
        [NMS(Size = 4, Ignore = true)]
        /* 0x1D4 */ public byte[] Padding1D4;
        /* 0x1D8 */ public List<NMSString0x10> Groups;
        /* 0x1E8 */ public int StorageContainerIndex;
        /* 0x1EC */ public bool CanChangeColour;
        /* 0x1ED */ public bool CanChangeMaterial;
        /* 0x1EE */ public bool CanPickUp;
        /* 0x1F0 */ public float ScanRadius;
        /* 0x1F4 */ public bool RemovesAttachedDecoration;
        /* 0x1F5 */ public bool EditsTerrain;
		public enum BaseTerrainEditShapeEnum { Cube, Cylinder }
		/* 0x1F8 */ public BaseTerrainEditShapeEnum BaseTerrainEditShape;
        /* 0x1FC */ public float TerrainEditBaseYOffset;
        /* 0x200 */ public float TerrainEditTopYOffset;
        /* 0x204 */ public float TerrainEditBoundsScalar;
        /* 0x208 */ public bool IsSealed;
        /* 0x209 */ public bool CloseMenuAfterBuild;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x20A */ public byte[] Padding20A;
        /* 0x210 */ public GcBaseLinkGridData LinkGridData;
        /* 0x268 */ public int GhostsCountOverride;
        /* 0x26C */ public float SnappingDistanceOverride;
        /* 0x270 */ public int RegionSpawnLOD;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x274 */ public byte[] EndPadding;
    }
}
