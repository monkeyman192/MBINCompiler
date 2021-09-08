using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x3C0, GUID = 0x10FD007D83D28D50, NameHash = 0x43EBB2E6AFAC5863)]
    public class GcObjectSpawnData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 DebugName;
        // size: 0x2
        public enum TypeEnum { Instanced, Single }
        /* 0x010 */ public TypeEnum Type;
        /* 0x018 */ public GcResourceElement Resource;
        /* 0x2C0 */ public List<GcResourceElement> AltResources;
        /* 0x2D0 */ public List<GcTerrainTileType> ExtraTileTypes;
        /* 0x2E0 */ public NMSString0x10 Placement;
        /* 0x2F0 */ public GcSeed Seed;
        public enum PlacementPriorityEnum { Low, Normal, High }
        /* 0x300 */ public PlacementPriorityEnum PlacementPriority;
        public enum LargeObjectCoverageEnum { DoNotPlace, DoNotPlaceIgnoreFootprint, DoNotPlaceClose, DoNotPlaceAnywhereNear, OnlyPlaceAround, OnlyPlaceAroundIgnoreFootprint, AlwaysPlace }
        /* 0x304 */ public LargeObjectCoverageEnum LargeObjectCoverage;
        public enum OverlapStyleEnum { None, SameSeed, All }
        /* 0x308 */ public OverlapStyleEnum OverlapStyle;
        /* 0x30C */ public float MinHeight;
        /* 0x310 */ public float MaxHeight;
        /* 0x314 */ public bool RelativeToSeaLevel;
        /* 0x318 */ public float MinAngle;
        /* 0x31C */ public float MaxAngle;
        /* 0x320 */ public bool MatchGroundColour;
        public enum GroundColourIndexEnum { Auto, Main, Patch }
        /* 0x324 */ public GroundColourIndexEnum GroundColourIndex;
        /* 0x328 */ public bool SwapPrimaryForSecondaryColour;
        /* 0x329 */ public bool SwapPrimaryForRandomColour;
        /* 0x32A */ public bool AlignToNormal;
        /* 0x32C */ public float MinScale;
        /* 0x330 */ public float MaxScale;
        /* 0x334 */ public float MinScaleY;
        /* 0x338 */ public float MaxScaleY;
        /* 0x33C */ public float SlopeScaling;
        /* 0x340 */ public float PatchEdgeScaling;
        /* 0x344 */ public float MaxXZRotation;
        /* 0x348 */ public bool AutoCollision;
        /* 0x349 */ public bool CollideWithPlayer;
        /* 0x34A */ public bool CollideWithPlayerVehicle;
        /* 0x34B */ public bool DestroyedByPlayerVehicle;
        /* 0x34C */ public bool DestroyedByPlayerShip;
        /* 0x34D */ public bool DestroyedByTerrainEdit;
        /* 0x34E */ public bool InvisibleToCamera;
        /* 0x34F */ public bool CreaturesCanEat;
        /* 0x350 */ public float ShearWindStrength;
        /* 0x358 */ public NMSString0x10 DestroyedByVehicleEffect;
        /* 0x368 */ public GcObjectSpawnDataVariant QualityVariantData;
        /* 0x3B0 */ public List<GcObjectSpawnDataVariant> QualityVariants;
    }
}
