namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x220)]
    public class GcBaseBuildingEntry : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string ID;
        /* 0x010 */ public bool HasProduct;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x011 */ public byte[] Padding11;
        /* 0x014 */ public TkModelResource SnapPoints;
        /* 0x098 */ public TkModelResource Model;
        /* 0x11C */ public TkModelResource InactiveModel;
        /* 0x1A0 */ public GcBaseBuildingObjectTypes Type;
        /* 0x1A4 */ public GcBaseBuildingObjectDecorationTypes DecorationType;
        /* 0x1A8 */ public GcBiomeType Biome;
        /* 0x1AC */ public int RegionSpawnLOD;

        /* 0x1B0 */ public bool BuildableOnBase;
        /* 0x1B1 */ public bool BuildableOnFreighter;
        /* 0x1B2 */ public bool BuildableOnPlanet;
        /* 0x1B2 */ public bool BuildableUnderwater;

        /* 0x1B4 */ public int GlobalLimit;
        /* 0x1B8 */ public int SystemLimit;
        /* 0x1BC */ public int PlanetLimit;
        /* 0x1C0 */ public int RegionLimit;
        /* 0x1C4 */ public int PlanetBaseLimit;
        /* 0x1C8 */ public int FreighterBaseLimit;
        /* 0x1CC */ public float BaseLayoutRadius;
        /* 0x1D0 */ public bool CheckCollision;
        /* 0x1D4 */ public float CollisionScale;
        /* 0x1D8 */ public bool CollidesWithPlayer;
        /* 0x1D9 */ public bool CanPlaceOnItself;
        [NMS(Size = 6, Ignore = true)]
        /* 0x1DA */ public byte[] Padding1DA;

        [NMS(Size = 0x10)]
        /* 0x1E0 */ public string Group;

        /* 0x1F0 */ public bool DontStore;
        /* 0x1F4 */ public int ComplexityCost;
        /* 0x1F8 */ public int InactiveComplexityCost;
        /* 0x1FC */ public int ForceExtraIdx;
        /* 0x200 */ public int GroupSnappingLimit;
        /* 0x204 */ public bool CanChangeColour;
        /* 0x205 */ public bool CanChangeMaterial;
        /* 0x206 */ public bool CanPickUp;
        /* 0x208 */ public float ScanRadius;
        /* 0x20C */ public bool RemovesAttachedDecoration;
        /* 0x20D */ public bool EditsTerrain;

		public enum BaseTerrainEditShapeEnum { Cube, Cylinder }
		public BaseTerrainEditShapeEnum BaseTerrainEditShape;

        /* 0x214 */ public float TerrainEditBaseYOffset;
        /* 0x218 */ public float TerrainEditTopYOffset;
        /* 0x21C */ public float TerrainEditBoundsScalar;
    }
}
