using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1A750EA95D028925, NameHash = 0x0D3C0DCB43542B48)]
    public class GcPlayerSquadronConfig : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20 SquadName;
        [NMS(Size = 0x4)]
        /* 0x020 */ public Vector2f[] PilotRankTraitRanges;
        [NMS(Size = 0x4)]
        /* 0x040 */ public NMSString0x10[] PilotRankAttackDefinitions;
        /* 0x080 */ public float SummonArriveTime;
        /* 0x084 */ public float SummonArriveTimeIntervalMin;
        /* 0x088 */ public float SummonArriveTimeIntervalMax;
        /* 0x08C */ public float SummonStartSpeed;
        /* 0x090 */ public float SummonLimitTurningTime;
        /* 0x094 */ public float MinSpeedForSummonInMoveDir;
        /* 0x098 */ public float SummonSpaceSpawnRangeMin;
        /* 0x09C */ public float SummonSpaceSpawnRangeMax;
        /* 0x0A0 */ public float SummonSpaceSpawnAngleMin;
        /* 0x0A4 */ public float SummonSpaceSpawnAngleMax;
        /* 0x0A8 */ public float SummonPlanetPitchMin;
        /* 0x0AC */ public float SummonPlanetPitchMax;
        /* 0x0B0 */ public float SummonPlanetYawMin;
        /* 0x0B4 */ public float SummonPlanetYawMax;
        /* 0x0B8 */ public float SummonPlanetDistance;
        /* 0x0BC */ public bool SummonInFormation;
        /* 0x0C0 */ public float SummonInFormationFwdOffset;
        /* 0x0C4 */ public float LeavingForceScaleDistMin;
        /* 0x0C8 */ public float LeavingForceScaleDistMax;
        /* 0x0CC */ public float LeavingMaxForceMultiplier;
        /* 0x0D0 */ public float LeavingFromPlanetOrbitWarpDist;
        /* 0x0D4 */ public float LeavingFromPlanetOrbitMinIncline;
        /* 0x0D8 */ public float LeavingFromPlanetOrbitMaxSpeed;
        /* 0x0DC */ public float LeavingFromSpaceWarpDist;
        /* 0x0E0 */ public float LeavingFromSpaceAngleFromFwdMin;
        /* 0x0E4 */ public float LeavingFromSpaceAngleFromFwdMax;
        /* 0x0E8 */ public float FormationOffsetRotationPeriod;
        /* 0x0EC */ public float FormationOffsetRotationMaxSpeed;
        /* 0x0F0 */ public float FormationOffsetZOffsetVarianceMinSpeedScale;
        /* 0x0F4 */ public float FormationOffsetZOffsetVarianceMaxSpeedScale;
        /* 0x0F8 */ public float FormationOffsetZOffsetVariancePeriod;
        /* 0x0FC */ public float FormationOffsetZOffsetVarianceMin;
        /* 0x100 */ public float FormationOffsetZOffsetVarianceMax;
        /* 0x110 */ public Vector3f FormationOffset;
        /* 0x120 */ public float FormationOffsetCylinderWidth;
        /* 0x124 */ public float FormationOffsetCylinderHeight;
        /* 0x128 */ public float FormationOffsetCylinderLength;
        /* 0x130 */ public Vector3f FormationOffsetThirdPerson;
        /* 0x140 */ public float FormationOffsetCylinderWidthThirdPerson;
        /* 0x144 */ public float FormationOffsetCylinderHeightThirdPerson;
        /* 0x148 */ public float FormationOffsetCylinderLengthThirdPerson;
        /* 0x150 */ public Vector3f CombatFormationOffset;
        /* 0x160 */ public float CombatFormationOffsetCylinderWidth;
        /* 0x164 */ public float CombatFormationOffsetCylinderHeight;
        /* 0x168 */ public float CombatFormationOffsetCylinderLength;
        /* 0x170 */ public Vector3f CombatFormationOffsetThirdPerson;
        /* 0x180 */ public float CombatFormationOffsetCylinderWidthThirdPerson;
        /* 0x184 */ public float CombatFormationOffsetCylinderHeightThirdPerson;
        /* 0x188 */ public float CombatFormationOffsetCylinderLengthThirdPerson;
        /* 0x18C */ public float MaintainFormationStrengthVariance;
        /* 0x190 */ public float MaintainFormationInCombatMinTime;
        /* 0x194 */ public float MaintainFormationInCombatMaxTime;
        /* 0x198 */ public float MaintainFormationStartSmoothTime;
        /* 0x19C */ public float MaintainFormationMaxForce;
        /* 0x1A0 */ public float MaintainFormationLockStrength;
        /* 0x1A4 */ public float MaintainFormationLockStrengthCombat;
        /* 0x1A8 */ public float MaintainFormationLockStrengthBoosting;
        /* 0x1AC */ public float MaintainFormationPostBoostSmoothTime;
        /* 0x1B0 */ public float MaintainFormationLockAlignStrength;
        /* 0x1B4 */ public float MaintainFormationLockRollAlignStrength;
        /* 0x1B8 */ public float MaintainFormationAlignMinDist;
        /* 0x1BC */ public float MaintainFormationAlignMaxDist;
        /* 0x1C0 */ public float MaintainFormationAlignMinSpeed;
        /* 0x1C4 */ public float MaintainFormationAlignMaxSpeed;
        /* 0x1C8 */ public float MaintainFormationSharpTurnMinSpeed;
        /* 0x1CC */ public float MaintainFormationSharpTurnMinSpeedForce;
        /* 0x1D0 */ public float JoinFormationMaxForce;
        /* 0x1D4 */ public float JoinFormationOffset;
        /* 0x1D8 */ public float JoinFormationArrivalTolerance;
        /* 0x1DC */ public float JoinFormationBoostMaxSpeed;
        /* 0x1E0 */ public float JoinFormationBoostMinDist;
        /* 0x1E4 */ public float JoinFormationBoostMaxDist;
        /* 0x1E8 */ public float JoinFormationBoostAlignStrength;
        /* 0x1EC */ public float JoinFormationBrakeAlignStrength;
        /* 0x1F0 */ public float JoinFormationBrakeDist;
        /* 0x1F4 */ public float JoinFormationMinSpeed;
        /* 0x1F8 */ public float JoinFormationMaxSpeedBrake;
        /* 0x1FC */ public float BreakFormationTime;
        /* 0x200 */ public float BreakFormationMaxForce;
        /* 0x204 */ public float BreakFormationMinTurnAngle;
        /* 0x208 */ public float BreakFormationMaxTurnAngle;
        /* 0x20C */ public float MinTimeBetweenFormationBreaks;
        /* 0x210 */ public int MinShipsInFormationDuringCombat;
        /* 0x214 */ public int MaxShipsInFormationDuringCombat;
        /* 0x218 */ public float OutOfFormationMinTime;
        /* 0x21C */ public float OutOfFormationMaxTime;
        /* 0x220 */ public List<GcAISpaceshipModelData> RandomSpaceshipResources;
        /* 0x230 */ public List<NMSString0x80> RandomPilotNPCResources;
    }
}
