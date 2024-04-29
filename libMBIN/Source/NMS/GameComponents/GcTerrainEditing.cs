namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCE5D203D496E5DD2, NameHash = 0x4686D0FAC0A1B9EC)]
    public class GcTerrainEditing : NMSTemplate
    {
        [NMS(Index = 24, Size = 0x8)]
        /* 0x00 */ public float[] EditSizes;
        [NMS(Index = 25, Size = 0x3)]
        /* 0x20 */ public float[] SubtractSizes;
        [NMS(Index = 26, Size = 0x2)]
        /* 0x2C */ public float[] BaseEditSizes;
        [NMS(Index = 27, Size = 0x2)]
        /* 0x34 */ public float[] UndoEditSizes;
        [NMS(Index = 12)]
        /* 0x3C */ public float DensityBlendDistanceMultiplier;
        [NMS(Index = 29)]
        /* 0x40 */ public float EditEffectScale;
        [NMS(Index = 0)]
        /* 0x44 */ public float EditPlaneMaxAdditiveOffsetFactor;
        [NMS(Index = 2)]
        /* 0x48 */ public float EditPlaneMaxSubtractiveOffsetFactor;
        [NMS(Index = 1)]
        /* 0x4C */ public float EditPlaneMinAdditiveOffsetFactor;
        [NMS(Index = 3)]
        /* 0x50 */ public float EditPlaneMinSubtractiveOffsetFactor;
        [NMS(Index = 28, Size = 0x1)]
        /* 0x54 */ public float[] FlatteningSizes;
        [NMS(Index = 10)]
        /* 0x58 */ public float MinimumSubstancePresence;
        [NMS(Index = 11)]
        /* 0x5C */ public float RegionEditAreaMultiplier;
        [NMS(Index = 9)]
        /* 0x60 */ public float RegionMapSearchRadiusMultiplier;
        [NMS(Index = 8)]
        /* 0x64 */ public float TerrainBlocksSearchRadiusMultiplier;
        [NMS(Index = 13)]
        /* 0x68 */ public float TerrainEditBaseDistanceTolerance;
        [NMS(Index = 6)]
        /* 0x6C */ public float TerrainEditBeamAddInterpolationStepFactor;
        [NMS(Index = 4)]
        /* 0x70 */ public float TerrainEditBeamMaxRange;
        [NMS(Index = 5)]
        /* 0x74 */ public float TerrainEditBeamSpherecastRadius;
        [NMS(Index = 7)]
        /* 0x78 */ public float TerrainEditBeamSubtractInterpolationStepFactor;
        [NMS(Index = 17)]
        /* 0x7C */ public float TerrainEditsNormalCostFactor;
        [NMS(Index = 18)]
        /* 0x80 */ public float TerrainEditsSurvivalCostFactor;
        [NMS(Index = 14)]
        /* 0x84 */ public float TerrainUndoBaseDistanceTolerance;
        [NMS(Index = 16)]
        /* 0x88 */ public float UndoBaseEditEffectiveScale;
        [NMS(Index = 15)]
        /* 0x8C */ public float UndoEditToleranceFactor;
        [NMS(Index = 19)]
        /* 0x90 */ public float VoxelsDeletedAffectCostFactor;
        [NMS(Index = 20)]
        /* 0x94 */ public bool EditGunBeamEnabled;
        [NMS(Index = 21)]
        /* 0x95 */ public bool EditGunParticlesEnabled;
        [NMS(Index = 22)]
        /* 0x96 */ public bool SubtractGunBeamEnabled;
        [NMS(Index = 23)]
        /* 0x97 */ public bool SubtractGunParticlesEnabled;
    }
}
