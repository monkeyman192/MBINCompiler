using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x27E7ADBF545563F1, NameHash = 0x43EBB2E6AFAC5863)]
    public class GcObjectSpawnData : NMSTemplate
    {
        /* 0x000 */ public GcResourceElement Resource;
        /* 0x2A8 */ public GcObjectSpawnDataVariant QualityVariantData;
        /* 0x2F0 */ public List<GcResourceElement> AltResources;
        /* 0x300 */ public NMSString0x10 DebugName;
        /* 0x310 */ public NMSString0x10 DestroyedByVehicleEffect;
        /* 0x320 */ public List<GcTerrainTileType> ExtraTileTypes;
        /* 0x330 */ public NMSString0x10 Placement;
        /* 0x340 */ public List<GcObjectSpawnDataVariant> QualityVariants;
        /* 0x350 */ public GcSeed Seed;
        // size: 0x3
        public enum GroundColourIndexEnum : uint {
            Auto,
            Main,
            Patch,
        }
        /* 0x360 */ public GroundColourIndexEnum GroundColourIndex;
        // size: 0x7
        public enum LargeObjectCoverageEnum : uint {
            DoNotPlace,
            DoNotPlaceIgnoreFootprint,
            DoNotPlaceClose,
            DoNotPlaceAnywhereNear,
            OnlyPlaceAround,
            OnlyPlaceAroundIgnoreFootprint,
            AlwaysPlace,
        }
        /* 0x364 */ public LargeObjectCoverageEnum LargeObjectCoverage;
        /* 0x368 */ public float MaxAngle;
        /* 0x36C */ public float MaxHeight;
        /* 0x370 */ public float MaxScale;
        /* 0x374 */ public float MaxScaleY;
        /* 0x378 */ public float MaxXZRotation;
        /* 0x37C */ public float MinAngle;
        /* 0x380 */ public float MinHeight;
        /* 0x384 */ public float MinScale;
        /* 0x388 */ public float MinScaleY;
        // size: 0x3
        public enum OverlapStyleEnum : uint {
            None,
            SameSeed,
            All,
        }
        /* 0x38C */ public OverlapStyleEnum OverlapStyle;
        /* 0x390 */ public float PatchEdgeScaling;
        // size: 0x3
        public enum PlacementPriorityEnum : uint {
            Low,
            Normal,
            High,
        }
        /* 0x394 */ public PlacementPriorityEnum PlacementPriority;
        /* 0x398 */ public float ShearWindStrength;
        /* 0x39C */ public float SlopeScaling;
        // size: 0x2
        public enum TypeEnum : uint {
            Instanced,
            Single,
        }
        /* 0x3A0 */ public TypeEnum Type;
        /* 0x3A4 */ public bool AlignToNormal;
        /* 0x3A5 */ public bool AutoCollision;
        /* 0x3A6 */ public bool CollideWithPlayer;
        /* 0x3A7 */ public bool CollideWithPlayerVehicle;
        /* 0x3A8 */ public bool CreaturesCanEat;
        /* 0x3A9 */ public bool DestroyedByPlayerShip;
        /* 0x3AA */ public bool DestroyedByPlayerVehicle;
        /* 0x3AB */ public bool DestroyedByTerrainEdit;
        /* 0x3AC */ public bool InvisibleToCamera;
        /* 0x3AD */ public bool MatchGroundColour;
        /* 0x3AE */ public bool RelativeToSeaLevel;
        /* 0x3AF */ public bool SupportsScanToReveal;
        /* 0x3B0 */ public bool SwapPrimaryForRandomColour;
        /* 0x3B1 */ public bool SwapPrimaryForSecondaryColour;
    }
}
