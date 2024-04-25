using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1E87AC9A0334BF13, NameHash = 0xD3C0DCB43542B48)]
    public class GcPlayerSquadronConfig : NMSTemplate
    {
        [NMS(Index = 44)]
        /* 0x000 */ public Vector3f CombatFormationOffset;
        [NMS(Index = 48)]
        /* 0x010 */ public Vector3f CombatFormationOffsetThirdPerson;
        [NMS(Index = 36)]
        /* 0x020 */ public Vector3f FormationOffset;
        [NMS(Index = 40)]
        /* 0x030 */ public Vector3f FormationOffsetThirdPerson;
        [NMS(Index = 2, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x040 */ public NMSString0x10[] PilotRankAttackDefinitions;
        [NMS(Index = 90)]
        /* 0x080 */ public List<NMSString0x80> RandomPilotNPCResources;
        [NMS(Index = 89)]
        /* 0x090 */ public List<GcAISpaceshipModelData> RandomSpaceshipResources;
        [NMS(Index = 1, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x0A0 */ public Vector2f[] PilotRankTraitRanges;
        [NMS(Index = 81)]
        /* 0x0C0 */ public float BreakFormationMaxForce;
        [NMS(Index = 83)]
        /* 0x0C4 */ public float BreakFormationMaxTurnAngle;
        [NMS(Index = 82)]
        /* 0x0C8 */ public float BreakFormationMinTurnAngle;
        [NMS(Index = 80)]
        /* 0x0CC */ public float BreakFormationTime;
        [NMS(Index = 46)]
        /* 0x0D0 */ public float CombatFormationOffsetCylinderHeight;
        [NMS(Index = 50)]
        /* 0x0D4 */ public float CombatFormationOffsetCylinderHeightThirdPerson;
        [NMS(Index = 47)]
        /* 0x0D8 */ public float CombatFormationOffsetCylinderLength;
        [NMS(Index = 51)]
        /* 0x0DC */ public float CombatFormationOffsetCylinderLengthThirdPerson;
        [NMS(Index = 45)]
        /* 0x0E0 */ public float CombatFormationOffsetCylinderWidth;
        [NMS(Index = 49)]
        /* 0x0E4 */ public float CombatFormationOffsetCylinderWidthThirdPerson;
        [NMS(Index = 38)]
        /* 0x0E8 */ public float FormationOffsetCylinderHeight;
        [NMS(Index = 42)]
        /* 0x0EC */ public float FormationOffsetCylinderHeightThirdPerson;
        [NMS(Index = 39)]
        /* 0x0F0 */ public float FormationOffsetCylinderLength;
        [NMS(Index = 43)]
        /* 0x0F4 */ public float FormationOffsetCylinderLengthThirdPerson;
        [NMS(Index = 37)]
        /* 0x0F8 */ public float FormationOffsetCylinderWidth;
        [NMS(Index = 41)]
        /* 0x0FC */ public float FormationOffsetCylinderWidthThirdPerson;
        [NMS(Index = 30)]
        /* 0x100 */ public float FormationOffsetRotationMaxSpeed;
        [NMS(Index = 29)]
        /* 0x104 */ public float FormationOffsetRotationPeriod;
        [NMS(Index = 35)]
        /* 0x108 */ public float FormationOffsetZOffsetVarianceMax;
        [NMS(Index = 32)]
        /* 0x10C */ public float FormationOffsetZOffsetVarianceMaxSpeedScale;
        [NMS(Index = 34)]
        /* 0x110 */ public float FormationOffsetZOffsetVarianceMin;
        [NMS(Index = 31)]
        /* 0x114 */ public float FormationOffsetZOffsetVarianceMinSpeedScale;
        [NMS(Index = 33)]
        /* 0x118 */ public float FormationOffsetZOffsetVariancePeriod;
        [NMS(Index = 71)]
        /* 0x11C */ public float JoinFormationArrivalTolerance;
        [NMS(Index = 75)]
        /* 0x120 */ public float JoinFormationBoostAlignStrength;
        [NMS(Index = 74)]
        /* 0x124 */ public float JoinFormationBoostMaxDist;
        [NMS(Index = 72)]
        /* 0x128 */ public float JoinFormationBoostMaxSpeed;
        [NMS(Index = 73)]
        /* 0x12C */ public float JoinFormationBoostMinDist;
        [NMS(Index = 76)]
        /* 0x130 */ public float JoinFormationBrakeAlignStrength;
        [NMS(Index = 77)]
        /* 0x134 */ public float JoinFormationBrakeDist;
        [NMS(Index = 69)]
        /* 0x138 */ public float JoinFormationMaxForce;
        [NMS(Index = 79)]
        /* 0x13C */ public float JoinFormationMaxSpeedBrake;
        [NMS(Index = 78)]
        /* 0x140 */ public float JoinFormationMinSpeed;
        [NMS(Index = 70)]
        /* 0x144 */ public float JoinFormationOffset;
        [NMS(Index = 21)]
        /* 0x148 */ public float LeavingForceScaleDistMax;
        [NMS(Index = 20)]
        /* 0x14C */ public float LeavingForceScaleDistMin;
        [NMS(Index = 25)]
        /* 0x150 */ public float LeavingFromPlanetOrbitMaxSpeed;
        [NMS(Index = 24)]
        /* 0x154 */ public float LeavingFromPlanetOrbitMinIncline;
        [NMS(Index = 23)]
        /* 0x158 */ public float LeavingFromPlanetOrbitWarpDist;
        [NMS(Index = 28)]
        /* 0x15C */ public float LeavingFromSpaceAngleFromFwdMax;
        [NMS(Index = 27)]
        /* 0x160 */ public float LeavingFromSpaceAngleFromFwdMin;
        [NMS(Index = 26)]
        /* 0x164 */ public float LeavingFromSpaceWarpDist;
        [NMS(Index = 22)]
        /* 0x168 */ public float LeavingMaxForceMultiplier;
        [NMS(Index = 64)]
        /* 0x16C */ public float MaintainFormationAlignMaxDist;
        [NMS(Index = 66)]
        /* 0x170 */ public float MaintainFormationAlignMaxSpeed;
        [NMS(Index = 63)]
        /* 0x174 */ public float MaintainFormationAlignMinDist;
        [NMS(Index = 65)]
        /* 0x178 */ public float MaintainFormationAlignMinSpeed;
        [NMS(Index = 54)]
        /* 0x17C */ public float MaintainFormationInCombatMaxTime;
        [NMS(Index = 53)]
        /* 0x180 */ public float MaintainFormationInCombatMinTime;
        [NMS(Index = 61)]
        /* 0x184 */ public float MaintainFormationLockAlignStrength;
        [NMS(Index = 62)]
        /* 0x188 */ public float MaintainFormationLockRollAlignStrength;
        [NMS(Index = 57)]
        /* 0x18C */ public float MaintainFormationLockStrength;
        [NMS(Index = 59)]
        /* 0x190 */ public float MaintainFormationLockStrengthBoosting;
        [NMS(Index = 58)]
        /* 0x194 */ public float MaintainFormationLockStrengthCombat;
        [NMS(Index = 56)]
        /* 0x198 */ public float MaintainFormationMaxForce;
        [NMS(Index = 60)]
        /* 0x19C */ public float MaintainFormationPostBoostSmoothTime;
        [NMS(Index = 67)]
        /* 0x1A0 */ public float MaintainFormationSharpTurnMinSpeed;
        [NMS(Index = 68)]
        /* 0x1A4 */ public float MaintainFormationSharpTurnMinSpeedForce;
        [NMS(Index = 55)]
        /* 0x1A8 */ public float MaintainFormationStartSmoothTime;
        [NMS(Index = 52)]
        /* 0x1AC */ public float MaintainFormationStrengthVariance;
        [NMS(Index = 86)]
        /* 0x1B0 */ public int MaxShipsInFormationDuringCombat;
        [NMS(Index = 85)]
        /* 0x1B4 */ public int MinShipsInFormationDuringCombat;
        [NMS(Index = 8)]
        /* 0x1B8 */ public float MinSpeedForSummonInMoveDir;
        [NMS(Index = 84)]
        /* 0x1BC */ public float MinTimeBetweenFormationBreaks;
        [NMS(Index = 88)]
        /* 0x1C0 */ public float OutOfFormationMaxTime;
        [NMS(Index = 87)]
        /* 0x1C4 */ public float OutOfFormationMinTime;
        [NMS(Index = 3)]
        /* 0x1C8 */ public float SummonArriveTime;
        [NMS(Index = 5)]
        /* 0x1CC */ public float SummonArriveTimeIntervalMax;
        [NMS(Index = 4)]
        /* 0x1D0 */ public float SummonArriveTimeIntervalMin;
        [NMS(Index = 19)]
        /* 0x1D4 */ public float SummonInFormationFwdOffset;
        [NMS(Index = 7)]
        /* 0x1D8 */ public float SummonLimitTurningTime;
        [NMS(Index = 17)]
        /* 0x1DC */ public float SummonPlanetDistance;
        [NMS(Index = 14)]
        /* 0x1E0 */ public float SummonPlanetPitchMax;
        [NMS(Index = 13)]
        /* 0x1E4 */ public float SummonPlanetPitchMin;
        [NMS(Index = 16)]
        /* 0x1E8 */ public float SummonPlanetYawMax;
        [NMS(Index = 15)]
        /* 0x1EC */ public float SummonPlanetYawMin;
        [NMS(Index = 12)]
        /* 0x1F0 */ public float SummonSpaceSpawnAngleMax;
        [NMS(Index = 11)]
        /* 0x1F4 */ public float SummonSpaceSpawnAngleMin;
        [NMS(Index = 10)]
        /* 0x1F8 */ public float SummonSpaceSpawnRangeMax;
        [NMS(Index = 9)]
        /* 0x1FC */ public float SummonSpaceSpawnRangeMin;
        [NMS(Index = 6)]
        /* 0x200 */ public float SummonStartSpeed;
        [NMS(Index = 0)]
        /* 0x204 */ public NMSString0x20 SquadName;
        [NMS(Index = 18)]
        /* 0x224 */ public bool SummonInFormation;
    }
}
