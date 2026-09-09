using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA392B0978BBB614, NameHash = 0x9858A3C5)]
    public class GcObjectSpawnData : NMSTemplate
    {
        [NMS(Index = 48)]
        /* 0x000 */ public GcObjectSpawnDataVariant QualityVariantData;
        [NMS(Index = 0)]
        /* 0x048 */ public GcResourceElement Resource;
        [NMS(Index = 46)]
        /* 0x090 */ public List<GcResourceElement> AltResources;
        [NMS(Index = 1)]
        /* 0x0A0 */ public NMSString0x10 DebugName;
        [NMS(Index = 45)]
        /* 0x0B0 */ public NMSString0x10 DestroyedByVehicleEffect;
        [NMS(Index = 47)]
        /* 0x0C0 */ public List<GcTerrainTileType> ExtraTileTypes;
        [NMS(Index = 6)]
        /* 0x0D0 */ public NMSString0x10 Placement;
        [NMS(Index = 5)]
        /* 0x0E0 */ public List<GcObjectSpawnDataVariant> QualityVariants;
        [NMS(Index = 21)]
        /* 0x0F0 */ public GcSeed Seed;
        // size: 0x3
        public enum GroundColourIndexEnum : uint {
            Auto,
            Main,
            Patch,
        }
        [NMS(Index = 30)]
        /* 0x100 */ public GroundColourIndexEnum GroundColourIndex;
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
        [NMS(Index = 22)]
        /* 0x104 */ public LargeObjectCoverageEnum LargeObjectCoverage;
        [NMS(Index = 25)]
        /* 0x108 */ public float MaxAngle;
        [NMS(Index = 27)]
        /* 0x10C */ public float MaxHeight;
        [NMS(Index = 18)]
        /* 0x110 */ public float MaxLower;
        [NMS(Index = 17)]
        /* 0x114 */ public float MaxRaise;
        [NMS(Index = 10)]
        /* 0x118 */ public float MaxScale;
        [NMS(Index = 12)]
        /* 0x11C */ public float MaxScaleY;
        [NMS(Index = 15)]
        /* 0x120 */ public float MaxXZRotation;
        [NMS(Index = 16)]
        /* 0x124 */ public float MaxYRotation;
        [NMS(Index = 24)]
        /* 0x128 */ public float MinAngle;
        [NMS(Index = 26)]
        /* 0x12C */ public float MinHeight;
        [NMS(Index = 9, MxmlName = "MinScale ")]
        /* 0x130 */ public float MinScale;
        [NMS(Index = 11)]
        /* 0x134 */ public float MinScaleY;
        [NMS(Index = 20)]
        /* 0x138 */ public int Order;
        // size: 0x3
        public enum OverlapStyleEnum : uint {
            None,
            SameSeed,
            All,
        }
        [NMS(Index = 23)]
        /* 0x13C */ public OverlapStyleEnum OverlapStyle;
        [NMS(Index = 14)]
        /* 0x140 */ public float PatchEdgeScaling;
        // size: 0x3
        public enum PlacementPriorityEnum : uint {
            Low,
            Normal,
            High,
        }
        [NMS(Index = 7)]
        /* 0x144 */ public PlacementPriorityEnum PlacementPriority;
        [NMS(Index = 41)]
        /* 0x148 */ public float ShearWindStrength;
        [NMS(Index = 13)]
        /* 0x14C */ public float SlopeScaling;
        // size: 0x2
        public enum TypeEnum : uint {
            Instanced,
            Single,
        }
        [NMS(Index = 2)]
        /* 0x150 */ public TypeEnum Type;
        [NMS(Index = 8)]
        /* 0x154 */ public bool AlignToNormal;
        [NMS(Index = 33)]
        /* 0x155 */ public bool AutoCollision;
        [NMS(Index = 34)]
        /* 0x156 */ public bool CollideWithPlayer;
        [NMS(Index = 35)]
        /* 0x157 */ public bool CollideWithPlayerVehicle;
        [NMS(Index = 40)]
        /* 0x158 */ public bool CreaturesCanEat;
        [NMS(Index = 37)]
        /* 0x159 */ public bool DestroyedByPlayerShip;
        [NMS(Index = 36)]
        /* 0x15A */ public bool DestroyedByPlayerVehicle;
        [NMS(Index = 38)]
        /* 0x15B */ public bool DestroyedByTerrainEdit;
        [NMS(Index = 3)]
        /* 0x15C */ public TkImposterActivation ImposterActivation;
        [NMS(Index = 4)]
        /* 0x15D */ public TkImposterType ImposterType;
        [NMS(Index = 39)]
        /* 0x15E */ public bool InvisibleToCamera;
        [NMS(Index = 44)]
        /* 0x15F */ public bool IsFloatingIsland;
        [NMS(Index = 29)]
        /* 0x160 */ public bool MatchGroundColour;
        [NMS(Index = 43)]
        /* 0x161 */ public bool MoveToGroundOnUpgrade;
        [NMS(Index = 28)]
        /* 0x162 */ public bool RelativeToSeaLevel;
        [NMS(Index = 42)]
        /* 0x163 */ public bool SupportsScanToReveal;
        [NMS(Index = 32)]
        /* 0x164 */ public bool SwapPrimaryForRandomColour;
        [NMS(Index = 31)]
        /* 0x165 */ public bool SwapPrimaryForSecondaryColour;
        [NMS(Index = 19)]
        /* 0x166 */ public bool UseMultipleUpgradeRays;
    }
}
