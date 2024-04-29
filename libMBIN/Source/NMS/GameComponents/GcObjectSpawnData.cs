using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD1E81B5BF2CECF41, NameHash = 0x43EBB2E6AFAC5863)]
    public class GcObjectSpawnData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public GcResourceElement Resource;
        [NMS(Index = 38)]
        /* 0x2A8 */ public GcObjectSpawnDataVariant QualityVariantData;
        [NMS(Index = 3)]
        /* 0x2F0 */ public List<GcResourceElement> AltResources;
        [NMS(Index = 0)]
        /* 0x300 */ public NMSString0x10 DebugName;
        [NMS(Index = 37)]
        /* 0x310 */ public NMSString0x10 DestroyedByVehicleEffect;
        [NMS(Index = 4)]
        /* 0x320 */ public List<GcTerrainTileType> ExtraTileTypes;
        [NMS(Index = 5)]
        /* 0x330 */ public NMSString0x10 Placement;
        [NMS(Index = 39)]
        /* 0x340 */ public List<GcObjectSpawnDataVariant> QualityVariants;
        [NMS(Index = 6)]
        /* 0x350 */ public GcSeed Seed;
        // size: 0x3
        public enum GroundColourIndexEnum : uint {
            Auto,
            Main,
            Patch,
        }
        [NMS(Index = 16)]
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
        [NMS(Index = 8)]
        /* 0x364 */ public LargeObjectCoverageEnum LargeObjectCoverage;
        [NMS(Index = 14)]
        /* 0x368 */ public float MaxAngle;
        [NMS(Index = 11)]
        /* 0x36C */ public float MaxHeight;
        [NMS(Index = 21)]
        /* 0x370 */ public float MaxScale;
        [NMS(Index = 23)]
        /* 0x374 */ public float MaxScaleY;
        [NMS(Index = 26)]
        /* 0x378 */ public float MaxXZRotation;
        [NMS(Index = 13)]
        /* 0x37C */ public float MinAngle;
        [NMS(Index = 10)]
        /* 0x380 */ public float MinHeight;
        [NMS(Index = 20)]
        /* 0x384 */ public float MinScale;
        [NMS(Index = 22)]
        /* 0x388 */ public float MinScaleY;
        // size: 0x3
        public enum OverlapStyleEnum : uint {
            None,
            SameSeed,
            All,
        }
        [NMS(Index = 9)]
        /* 0x38C */ public OverlapStyleEnum OverlapStyle;
        [NMS(Index = 25)]
        /* 0x390 */ public float PatchEdgeScaling;
        // size: 0x3
        public enum PlacementPriorityEnum : uint {
            Low,
            Normal,
            High,
        }
        [NMS(Index = 7)]
        /* 0x394 */ public PlacementPriorityEnum PlacementPriority;
        [NMS(Index = 35)]
        /* 0x398 */ public float ShearWindStrength;
        [NMS(Index = 24)]
        /* 0x39C */ public float SlopeScaling;
        // size: 0x2
        public enum TypeEnum : uint {
            Instanced,
            Single,
        }
        [NMS(Index = 1)]
        /* 0x3A0 */ public TypeEnum Type;
        [NMS(Index = 19)]
        /* 0x3A4 */ public bool AlignToNormal;
        [NMS(Index = 27)]
        /* 0x3A5 */ public bool AutoCollision;
        [NMS(Index = 28)]
        /* 0x3A6 */ public bool CollideWithPlayer;
        [NMS(Index = 29)]
        /* 0x3A7 */ public bool CollideWithPlayerVehicle;
        [NMS(Index = 34)]
        /* 0x3A8 */ public bool CreaturesCanEat;
        [NMS(Index = 31)]
        /* 0x3A9 */ public bool DestroyedByPlayerShip;
        [NMS(Index = 30)]
        /* 0x3AA */ public bool DestroyedByPlayerVehicle;
        [NMS(Index = 32)]
        /* 0x3AB */ public bool DestroyedByTerrainEdit;
        [NMS(Index = 33)]
        /* 0x3AC */ public bool InvisibleToCamera;
        [NMS(Index = 15)]
        /* 0x3AD */ public bool MatchGroundColour;
        [NMS(Index = 12)]
        /* 0x3AE */ public bool RelativeToSeaLevel;
        [NMS(Index = 36)]
        /* 0x3AF */ public bool SupportsScanToReveal;
        [NMS(Index = 18)]
        /* 0x3B0 */ public bool SwapPrimaryForRandomColour;
        [NMS(Index = 17)]
        /* 0x3B1 */ public bool SwapPrimaryForSecondaryColour;
    }
}
