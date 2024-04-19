namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8879B10CF4B83AE, NameHash = 0x4686D0FAC0A1B9EC)]
    public class GcTerrainEditing : NMSTemplate
    {
        [NMS(Size = 0x8)]
        /* 0x00 */ public float[] EditSizes;
        [NMS(Size = 0x3)]
        /* 0x20 */ public float[] SubtractSizes;
        [NMS(Size = 0x2)]
        /* 0x2C */ public float[] BaseEditSizes;
        [NMS(Size = 0x2)]
        /* 0x34 */ public float[] UndoEditSizes;
        /* 0x3C */ public float DensityBlendDistanceMultiplier;
        /* 0x40 */ public float EditEffectScale;
        /* 0x44 */ public float EditPlaneMaxAdditiveOffsetFactor;
        /* 0x48 */ public float EditPlaneMaxSubtractiveOffsetFactor;
        /* 0x4C */ public float EditPlaneMinAdditiveOffsetFactor;
        /* 0x50 */ public float EditPlaneMinSubtractiveOffsetFactor;
        [NMS(Size = 0x1)]
        /* 0x54 */ public float[] FlatteningSizes;
        /* 0x58 */ public float MinimumSubstancePresence;
        /* 0x5C */ public float RegionEditAreaMultiplier;
        /* 0x60 */ public float RegionMapSearchRadiusMultiplier;
        /* 0x64 */ public float TerrainBlocksSearchRadiusMultiplier;
        /* 0x68 */ public float TerrainEditBaseDistanceTolerance;
        /* 0x6C */ public float TerrainEditBeamAddInterpolationStepFactor;
        /* 0x70 */ public float TerrainEditBeamMaxRange;
        /* 0x74 */ public float TerrainEditBeamSpherecastRadius;
        /* 0x78 */ public float TerrainEditBeamSubtractInterpolationStepFactor;
        /* 0x7C */ public float TerrainEditsNormalCostFactor;
        /* 0x80 */ public float TerrainEditsSurvivalCostFactor;
        /* 0x84 */ public float TerrainUndoBaseDistanceTolerance;
        /* 0x88 */ public float UndoBaseEditEffectiveScale;
        /* 0x8C */ public float UndoEditToleranceFactor;
        /* 0x90 */ public float VoxelsDeletedAffectCostFactor;
        /* 0x94 */ public bool EditGunBeamEnabled;
        /* 0x95 */ public bool EditGunParticlesEnabled;
        /* 0x96 */ public bool SubtractGunBeamEnabled;
        /* 0x97 */ public bool SubtractGunParticlesEnabled;
    }
}
