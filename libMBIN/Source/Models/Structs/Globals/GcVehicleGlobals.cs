using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcVehicleGlobals : NMSTemplate
    {
        /* 0x0 */ public bool ShowAllCheckpoints;
        /* 0x4 */ public float BoostPadTime;
        /* 0x8 */ public float BoostPadStrength;
        /* 0xC */ public float DisablePhysicsRange;
        /* 0x10 */ public float RaceMultipleStartOffset;
        /* 0x14 */ public float RaceMultipleStartCaptureRange;
        /* 0x18 */ public float MiningLaserDrainSpeed;
        /* 0x1C */ public float ProjectileDrainPerShot;
        /* 0x20 */ public float RaceStartSpawnUpOffset;
        /* 0x24 */ public float RaceInteractRespawnOffset;
        /* 0x28 */ public float RaceInteractRespawnUpOffset;
        /* 0x2C */ public float StickTurnReducer;
        /* 0x30 */ public float TravelSpeedReportReducer;
        /* 0x34 */ public float HornScareRadius;
        /* 0x38 */ public float HornScareFleeRadius;
        /* 0x3C */ public float HornScareTime;
        /* 0x40 */ public float AttractAmount;
        /* 0x44 */ public float AttractMaxSpeed;
        /* 0x48 */ public float AttractAlign;
        /* 0x4C */ public float AttractDirectionBrakeThresholdSq;
        /* 0x50 */ public float ExitStopTime;
        /* 0x54 */ public float ExitStopForce;
        /* 0x58 */ public float GunFireRate;
        /* 0x5C */ public float MinTurretAngle;
        /* 0x60 */ public float SummoningRange;
        /* 0x64 */ public float CheckpointRadius;
        /* 0x68 */ public float RaceCooldown;
        /* 0x6C */ public float RaceResetFlashDuration;
        /* 0x70 */ public float RaceResetFlashIntensity;
        /* 0x74 */ public float CheckpointFlashDuration;
        /* 0x78 */ public float CheckpointFlashIntensity;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x7C */ public byte[] Padding7C;
        /* 0x80 */ public Colour CheckpointBeamColourActive;
        /* 0x90 */ public Colour CheckpointBeamColourNormal;
        [NMS(Size = 0x10)]
        /* 0xA0 */ public string DefaultBuggyLoadout;
        [NMS(Size = 0x2)]
        /* 0xB0 */ public NMSString0x10[] DefaultBikeLoadout;
        [NMS(Size = 0x2)]
        /* 0xD0 */ public NMSString0x10[] DefaultTruckLoadout;
        /* 0xF0 */ public float CheckpointBeamSizeNormal;
        /* 0xF4 */ public float CheckpointBeamSizeActive;
        /* 0xF8 */ public float CheckpointBeamOffset;
        /* 0xFC */ public float SpawnRotation;
        /* 0x100 */ public float MiningLaserRadius;
        /* 0x104 */ public int MiningLaserMiningDamage;
        /* 0x108 */ public int MiningLaserDamage;
        /* 0x10C */ public float MiningLaserSpeed;
        /* 0x110 */ public int GunBaseDamage;
        /* 0x114 */ public int GunBaseMiningDamage;
        /* 0x118 */ public float ResourceCollectOffset;
        /* 0x11C */ public float VehicleWheelNoise;
        /* 0x120 */ public float VehicleWheelNoiseScale;
        /* 0x124 */ public float WheelSideVerticalFactor;
        /* 0x128 */ public float SuspensionDamping;
        /* 0x12C */ public float SuspensionDampingAngularFactor;
        /* 0x130 */ public bool ShowTempVehicleMesh;
        /* 0x131 */ public bool ShowVehicleDebugging;
        /* 0x132 */ public bool ShowVehicleWheelGuards;
        /* 0x133 */ public bool ShowVehicleText;
        /* 0x134 */ public float VehicleTextSize;
        /* 0x138 */ public bool ShowVehicleParticleDebug;
        /* 0x139 */ public bool VehicleDrawAudioDebug;
        /* 0x13C */ public float VehicleSuspensionAudioSpacing;
        /* 0x140 */ public float VehicleSuspensionAudioDelay;
        /* 0x144 */ public float VehicleSuspensionAudioScale;
        /* 0x148 */ public float VehicleSuspensionAudioTrigger;
        /* 0x14C */ public float VehicleFadeTime;
        /* 0x150 */ public float VehicleMinSummonDistance;
        /* 0x154 */ public float VehicleDeactivateRange;
        /* 0x158 */ public float VehicleBoostFuelRate;
        /* 0x15C */ public float VehicleBoostFuelRateSurvival;
        /* 0x160 */ public float VehicleFuelRate;
        /* 0x164 */ public float VehicleFuelRateSurvival;
        /* 0x168 */ public float VehicleFuelRateTruckMultiplier;
        /* 0x16C */ public float VehicleJumpTimeMin;
        /* 0x170 */ public float VehicleJumpTimeMax;
        /* 0x174 */ public float VehicleJumpCooldown;
        /* 0x178 */ public float WheelForceHalflife;
        /* 0x17C */ public bool ThrottleButtonCamRelative;
        /* 0x180 */ public float StickReverseTurnThreshold;
        /* 0x184 */ public float StickReverseTurnStiffness;
        /* 0x188 */ public GcScanData VehicleScan;
        /* 0x19C */ public GcScanData VehicleLocalScan;
        [NMS(Size = 0x3)]
        /* 0x1B0 */ public GcVehicleData[] VehicleDataTable;

    }
}
