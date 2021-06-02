using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x3B0, GUID = 0x143DC5BFD62FF1E9, NameHash = 0x43EBB2E6AFAC5863)]
    public class GcObjectSpawnData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 DebugName;
		public enum TypeEnum { Instanced, Single }
		/* 0x010 */ public TypeEnum Type;
        [NMS(Size = 4, Ignore = true)]
        /* 0x014 */ public byte[] Padding14;
        /* 0x018 */ public GcResourceElement Resource;
        /* 0x2C0 */ public List<GcResourceElement> AltResources;
        /* 0x2D0 */ public List<GcTerrainTileType> ExtraTileTypes;
        /* 0x2E0 */ public NMSString0x10 Placement;
        /* 0x2F0 */ public GcSeed PlacementSeed;
		public enum PlacementPriorityEnum { Low, Normal, High }
		/* 0x300 */ public PlacementPriorityEnum PlacementPriority;
        /* 0x304 */ public float Coverage;
        /* 0x308 */ public float FlatDensity;
        /* 0x30C */ public float SlopeDensity;
        /* 0x310 */ public float SlopeMultiplier;
		public enum LargeObjectCoverageEnum { DoNotPlace, DoNotPlaceClose, OnlyPlaceAround, AlwaysPlace, DoNotPlaceAnywhereNear }
		/* 0x314 */ public LargeObjectCoverageEnum LargeObjectCoverage;
		public enum OverlapStyleEnum { None, SameSeed, All }
		/* 0x318 */ public OverlapStyleEnum OverlapStyle;
        /* 0x31C */ public float MinHeight;
        /* 0x320 */ public float MaxHeight;
        /* 0x324 */ public bool RelativeToSeaLevel;
        /* 0x328 */ public float MinAngle;
        /* 0x32C */ public float MaxAngle;
        /* 0x330 */ public int MinRegionRadius;
        /* 0x334 */ public int MaxRegionRadius;
        /* 0x338 */ public int MaxImposterRadius;
        /* 0x33C */ public float FadeInStartDistance;
        /* 0x340 */ public float FadeInEndDistance;
        /* 0x344 */ public float FadeInOffsetDistance;
        /* 0x348 */ public float FadeOutStartDistance;
        /* 0x34C */ public float FadeOutEndDistance;
        /* 0x350 */ public float FadeOutOffsetDistance;
        [NMS(Size = 5)]
        /* 0x354 */ public float[] LodDistances;
        /* 0x368 */ public bool MatchGroundColour;
		public enum GroundColourIndexEnum { Auto, Main, Patch }
		/* 0x36C */ public GroundColourIndexEnum GroundColourIndex;
        /* 0x370 */ public bool SwapPrimaryForSecondaryColour;
        /* 0x371 */ public bool SwapPrimaryForRandomColour;
        /* 0x372 */ public bool AlignToNormal;
        /* 0x374 */ public float MinScale;
        /* 0x378 */ public float MaxScale;
        /* 0x37C */ public float MinScaleY;
        /* 0x380 */ public float MaxScaleY;
        /* 0x384 */ public float SlopeScaling;
        /* 0x388 */ public float PatchEdgeScaling;
        /* 0x38C */ public float MaxXZRotation;
        /* 0x390 */ public bool AutoCollision;
        /* 0x391 */ public bool CollideWithPlayer;
        /* 0x392 */ public bool CollideWithPlayerVehicle;
        /* 0x393 */ public bool DestroyedByPlayerVehicle;
        /* 0x394 */ public bool DestroyedByPlayerShip;
        /* 0x395 */ public bool DestroyedByTerrainEdit;
        /* 0x396 */ public bool InvisibleToCamera;
        /* 0x397 */ public bool CreaturesCanEat;
        /* 0x398 */ public float ShearWindStrength;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x39C */ public byte[] Padding39C;
        /* 0x3A0 */ public NMSString0x10 DestroyedByVehicleEffect;
    }
}
