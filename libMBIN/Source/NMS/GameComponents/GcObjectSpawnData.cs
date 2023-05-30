using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcObjectSpawnData : NMSTemplate // 0x378 bytes
    {
        /* 0x000 */ public int Type;
        public string[] TypeValues()
        {
            return new[] { "Instanced", "Single" };
        }
        [NMS(Size = 4, Ignore = true)]
        /* 0x004 */ public byte[] Padding4;

        /* 0x008 */ public GcResourceElement Resource;
        /* 0x2B0 */ public List<GcResourceElement> AltResources;

        /* 0x2C0 */ public GcTerrainTileType PlacementTileType;
        [NMS(Size = 4, Ignore = true)]
        /* 0x2C4 */ public byte[] Padding2C4;

        [NMS(Size = 0x10)]
        /* 0x2C8 */ public string Placement;
        /* 0x2D8 */ public GcSeed PlacementSeed;
        /* 0x2E8 */ public int PlacementPriority;
        public string[] PlacementPriorityValues()
        {
            return new[] { "Low", "Normal", "High" };
        }

        /* 0x2EC */ public float PlacementCoverage;
        /* 0x2F0 */ public float PlacementFlatDensity;
        /* 0x2F4 */ public float PlacementSlopeDensity;
        /* 0x2F8 */ public float PlacementSlopeMultiplier;

        /* 0x2FC */ public int RestrictionsLargeObjectCoverage;
        public string[] RestrictionsLargeObjectCoverageValues()
        {
            return new[] { "DoNotPlace", "DoNotPlaceClose", "OnlyPlaceAround", "AlwaysPlace" };
        }
        /* 0x300 */ public int RestrictionsOverlapStyle;
        public string[] RestrictionsOverlapStyleValues()
        {
            return new[] { "None", "SameSeed", "All" };
        }
        /* 0x304 */ public float RestrictionsMinHeight;
        /* 0x308 */ public float RestrictionsMaxHeight;
        /* 0x30C */ public bool RestrictionsRelativeToSeaLevel;
        /* 0x310 */ public float RestrictionsMinAngle;
        /* 0x314 */ public float RestrictionsMaxAngle;

        /* 0x318 */ public int FadeMinRegionRadius; // might be float
        /* 0x31C */ public int FadeMaxRegionRadius; // might be float
        /* 0x320 */ public int FadeMaxImposterRadius; // might be float

        /* 0x324 */ public float FadeInStartDistance;
        /* 0x328 */ public float FadeInEndDistance;
        /* 0x32C */ public float FadeInOffsetDistance;
        /* 0x330 */ public float FadeOutStartDistance;
        /* 0x334 */ public float FadeOutEndDistance;
        /* 0x338 */ public float FadeOutOffsetDistance;

        /* 0x33C */ public bool MatchGroundColour;
        /* 0x340 */ public int GroundColourIndex;
        public string[] GroundColourIndexValues()
        {
            return new[] { "Auto", "Main", "Patch" };
        }

        /* 0x344 */ public bool SwapPrimaryForSecondaryColour;
        /* 0x345 */ public bool SwapPrimaryForRandomColour;

        /* 0x346 */ public bool PositioningAlignToNormal;
        /* 0x348 */ public float PositioningMinScale;
        /* 0x34C */ public float PositioningMaxScale;
        /* 0x350 */ public float PositioningMinYScale;
        /* 0x354 */ public float PositioningMaxYScale;
        /* 0x358 */ public float PositioningSlopeScaling;
        /* 0x35C */ public float PositioningPatchEdgeScaling;
        /* 0x360 */ public float PositioningMaxXZRotation;

        /* 0x364 */ public bool ObjectAutoCollision;
        /* 0x365 */ public bool ObjectCollideWithPlayer;
        /* 0x366 */ public bool ObjectCreaturesCanEat;
        /* 0x368 */ public float ObjectShearWindStrength;

        /* 0x36C */ public int RuntimeCacheCachedCollisionNodeCount; // might be float
        /* 0x370 */ public bool RuntimeCacheAllowLimiting;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x371 */ public byte[] Padding371;
    }
}
