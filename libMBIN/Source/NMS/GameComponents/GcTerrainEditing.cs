using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE0D6A6545E3C505E, NameHash = 0x4686D0FAC0A1B9EC)]
    public class GcTerrainEditing : NMSTemplate
    {
        /* 0x00 */ public float EditPlaneMaxAdditiveOffsetFactor;
        /* 0x04 */ public float EditPlaneMinAdditiveOffsetFactor;
        /* 0x08 */ public float EditPlaneMaxSubtractiveOffsetFactor;
        /* 0x0C */ public float EditPlaneMinSubtractiveOffsetFactor;
        /* 0x10 */ public float TerrainEditBeamMaxRange;
        /* 0x14 */ public float TerrainEditBeamSpherecastRadius;
        /* 0x18 */ public float TerrainEditBeamAddInterpolationStepFactor;
        /* 0x1C */ public float TerrainEditBeamSubtractInterpolationStepFactor;
        /* 0x20 */ public float TerrainBlocksSearchRadiusMultiplier;
        /* 0x24 */ public float RegionMapSearchRadiusMultiplier;
        /* 0x28 */ public float MinimumSubstancePresence;
        /* 0x2C */ public float RegionEditAreaMultiplier;
        /* 0x30 */ public float DensityBlendDistanceMultiplier;
        /* 0x34 */ public float TerrainEditBaseDistanceTolerance;
        /* 0x38 */ public float TerrainUndoBaseDistanceTolerance;
        /* 0x3C */ public float UndoEditToleranceFactor;
        /* 0x40 */ public float UndoBaseEditEffectiveScale;
        /* 0x44 */ public float TerrainEditsNormalCostFactor;
        /* 0x48 */ public float TerrainEditsSurvivalCostFactor;
        /* 0x4C */ public float VoxelsDeletedAffectCostFactor;
        /* 0x50 */ public bool EditGunBeamEnabled;
        /* 0x51 */ public bool EditGunParticlesEnabled;
        /* 0x52 */ public bool SubtractGunBeamEnabled;
        /* 0x53 */ public bool SubtractGunParticlesEnabled;
        [NMS(Size = 0x8)]
        /* 0x54 */ public float[] EditSizes;
        [NMS(Size = 0x3)]
        /* 0x74 */ public float[] SubtractSizes;
        [NMS(Size = 0x2)]
        /* 0x80 */ public float[] BaseEditSizes;
        [NMS(Size = 0x2)]
        /* 0x88 */ public float[] UndoEditSizes;
        [NMS(Size = 0x1)]
        /* 0x90 */ public float[] FlatteningSizes;
        /* 0x94 */ public float EditEffectScale;
    }
}
