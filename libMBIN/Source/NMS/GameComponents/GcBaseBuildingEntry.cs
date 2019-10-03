using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x280, GUID = 0xD42191CFD9C5C461, NameHash = 0xA6F7B710166F6076)]
    public class GcBaseBuildingEntry : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string ID;
        /* 0x010 */ public bool HasProduct;
        /* 0x011 */ public bool IsTemporary;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x012 */ public byte[] Padding12;
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
        /* 0x1B8 */ public int GlobalLimit;
        /* 0x1BC */ public int SystemLimit;
        /* 0x1C0 */ public int PlanetLimit;
        /* 0x1C4 */ public int RegionLimit;
        /* 0x1C8 */ public int PlanetBaseLimit;
        /* 0x1CC */ public int FreighterBaseLimit;
        /* 0x1D0 */ public bool CheckPlaceholderCollision;
        /* 0x1D4 */ public float CollisionScale;
        /* 0x1D8 */ public bool EnableCollision;
        /* 0x1D9 */ public bool CanPlaceOnItself;
        /* 0x1DA */ public bool CanRotate3D;
        /* 0x1DB */ public bool CanScale;
        [NMS(Size = 4, Ignore = true)]
        /* 0x1DC */ public byte[] Padding1DC;
        /* 0x1E0 */ public List<NMSString0x10> Groups;
        /* 0x1F0 */ public int StorageContainerIndex;
        /* 0x1F4 */ public bool CanChangeColour;
        /* 0x1F5 */ public bool CanChangeMaterial;
        /* 0x1F6 */ public bool CanPickUp;
        /* 0x1F8 */ public float ScanRadius;
        /* 0x1FC */ public bool RemovesAttachedDecoration;
        /* 0x1FD */ public bool EditsTerrain;

		public enum BaseTerrainEditShapeEnum { Cube, Cylinder }
		/* 0x200 */ public BaseTerrainEditShapeEnum BaseTerrainEditShape;

        /* 0x204 */ public float TerrainEditBaseYOffset;
        /* 0x208 */ public float TerrainEditTopYOffset;
        /* 0x20C */ public float TerrainEditBoundsScalar;
        /* 0x210 */ public bool IsSealed;
        /* 0x211 */ public bool CloseMenuAfterBuild;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x212 */ public byte[] Padding212;
        /* 0x218 */ public GcBaseLinkGridData LinkGridData;
        /* 0x270 */ public int GhostsCountOverride;
        /* 0x274 */ public float SnappingDistanceOverride;
        /* 0x278 */ public int RegionSpawnLOD;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x27C */ public byte[] EndPadding;
    }
}
