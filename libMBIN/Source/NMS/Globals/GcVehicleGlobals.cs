using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x6BFF2201BB6E5924, NameHash = 0x9B5DDD6D76FBC918)]
    public class GcVehicleGlobals : NMSTemplate
    {
        [NMS(Index = 219)]
        /* 0x000 */ public Colour CheckpointBeamColourActive;
        [NMS(Index = 220)]
        /* 0x010 */ public Colour CheckpointBeamColourNormal;
        [NMS(Index = 28)]
        /* 0x020 */ public Colour DefaultBoosterColour;
        [NMS(Index = 159)]
        /* 0x030 */ public Vector3f FirstPersonNonVRCameraOffset;
        [NMS(Index = 160)]
        /* 0x040 */ public Vector3f FirstPersonNonVRCameraOffsetMech;
        [NMS(Index = 61)]
        /* 0x050 */ public Vector3f MechCrouchOffset;
        [NMS(Index = 62)]
        /* 0x060 */ public Vector3f MechWalkBackwardsCoGOffset;
        [NMS(Index = 148)]
        /* 0x070 */ public GcMechMeshPartTable MechMeshPartsTable;
        [NMS(Index = 147, Size = 0x4, EnumType = typeof(GcVehicleWeaponMode.VehicleWeaponModeEnum))]
        /* 0x250 */ public GcExoMechWeaponData[] MechWeaponData;
        [NMS(Index = 273, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x410 */ public GcVehicleMuzzleData[] VehicleWeaponMuzzleFlash;
        [NMS(Index = 134)]
        /* 0x5D0 */ public GcMechAudioEventTable MechAudioEventTable;
        [NMS(Index = 7)]
        /* 0x6F0 */ public NMSString0x20A SentinelRightArmTechNameOverride;
        [NMS(Index = 222)]
        /* 0x710 */ public List<NMSString0x10> DefaultBikeLoadout;
        [NMS(Index = 221)]
        /* 0x720 */ public List<NMSString0x10> DefaultBuggyLoadout;
        [NMS(Index = 223)]
        /* 0x730 */ public List<NMSString0x10> DefaultTruckLoadout;
        [NMS(Index = 52)]
        /* 0x740 */ public NMSString0x10 MechArmPitchAnimLeft;
        [NMS(Index = 53)]
        /* 0x750 */ public NMSString0x10 MechArmPitchAnimRight;
        [NMS(Index = 43)]
        /* 0x760 */ public NMSString0x10 MechJetpackEffect;
        [NMS(Index = 44)]
        /* 0x770 */ public NMSString0x10 MechJetpackLaunchEffect;
        [NMS(Index = 45)]
        /* 0x780 */ public NMSString0x10 MechJetpackLaunchGroundEffect;
        [NMS(Index = 42)]
        /* 0x790 */ public NMSString0x10 MechLandingImpactEffect;
        [NMS(Index = 4)]
        /* 0x7A0 */ public NMSString0x10 MechStrongLaser;
        [NMS(Index = 6)]
        /* 0x7B0 */ public NMSString0x10 SentinelLeftArmTech;
        [NMS(Index = 5)]
        /* 0x7C0 */ public NMSString0x10 SentinelRightArmTech;
        [NMS(Index = 8)]
        /* 0x7D0 */ public NMSString0x10 SentinelRightLeftArmLaserData;
        [NMS(Index = 175)]
        /* 0x7E0 */ public List<Vector3f> UnderwaterBubbleOffset;
        [NMS(Index = 275)]
        /* 0x7F0 */ public List<GcVehicleData> VehicleDataTable;
        [NMS(Index = 272)]
        /* 0x800 */ public NMSString0x10 VehicleLocalScan;
        [NMS(Index = 271)]
        /* 0x810 */ public NMSString0x10 VehicleScan;
        [NMS(Index = 3)]
        /* 0x820 */ public NMSString0x10 VehicleStrongLaser;
        [NMS(Index = 274)]
        /* 0x830 */ public List<GcVehicleWeaponMuzzleData> VehicleWeaponMuzzleDataTable;
        [NMS(Index = 174)]
        /* 0x840 */ public GcSpaceshipAvoidanceData UnderwaterAvoidance;
        [NMS(Index = 31)]
        /* 0x864 */ public Vector2f MechLookStickSpeedLimit;
        [NMS(Index = 30)]
        /* 0x86C */ public Vector2f MechMovementStickSpeedLimit;
        [NMS(Index = 143)]
        /* 0x874 */ public float AIMechGunExplosionRadius;
        [NMS(Index = 137)]
        /* 0x878 */ public float AIMechGunFireInterval;
        [NMS(Index = 144)]
        /* 0x87C */ public float AIMechGunInheritVelocity;
        [NMS(Index = 139)]
        /* 0x880 */ public int AIMechGunNumShotsMax;
        [NMS(Index = 138)]
        /* 0x884 */ public int AIMechGunNumShotsMin;
        [NMS(Index = 136)]
        /* 0x888 */ public float AIMechLaserFireDurationMax;
        [NMS(Index = 135)]
        /* 0x88C */ public float AIMechLaserFireDurationMin;
        [NMS(Index = 140)]
        /* 0x890 */ public float AIMechStunGunFireInterval;
        [NMS(Index = 142)]
        /* 0x894 */ public int AIMechStunGunNumShotsMax;
        [NMS(Index = 141)]
        /* 0x898 */ public int AIMechStunGunNumShotsMin;
        [NMS(Index = 206)]
        /* 0x89C */ public float AttractAlign;
        [NMS(Index = 204)]
        /* 0x8A0 */ public float AttractAmount;
        [NMS(Index = 207)]
        /* 0x8A4 */ public float AttractDirectionBrakeThresholdSq;
        [NMS(Index = 205)]
        /* 0x8A8 */ public float AttractMaxSpeed;
        [NMS(Index = 188)]
        /* 0x8AC */ public float BoostPadStrength;
        [NMS(Index = 187)]
        /* 0x8B0 */ public float BoostPadTime;
        [NMS(Index = 226)]
        /* 0x8B4 */ public float CheckpointBeamOffset;
        [NMS(Index = 225)]
        /* 0x8B8 */ public float CheckpointBeamSizeActive;
        [NMS(Index = 224)]
        /* 0x8BC */ public float CheckpointBeamSizeNormal;
        [NMS(Index = 186)]
        /* 0x8C0 */ public float CheckpointDeleteAngle;
        [NMS(Index = 185)]
        /* 0x8C4 */ public float CheckpointDeleteDistance;
        [NMS(Index = 217)]
        /* 0x8C8 */ public float CheckpointFlashDuration;
        [NMS(Index = 218)]
        /* 0x8CC */ public float CheckpointFlashIntensity;
        [NMS(Index = 183)]
        /* 0x8D0 */ public float CheckpointPlacementOffset;
        [NMS(Index = 184)]
        /* 0x8D4 */ public float CheckpointPlacementRayLength;
        [NMS(Index = 212)]
        /* 0x8D8 */ public float CheckpointRadius;
        [NMS(Index = 12)]
        /* 0x8DC */ public float ControlStickRecenterSpeedDegPerSec;
        [NMS(Index = 33)]
        /* 0x8E0 */ public float DamageTechMinHitIntervalSeconds;
        [NMS(Index = 32)]
        /* 0x8E4 */ public int DamageTechNumHitsRequired;
        [NMS(Index = 189)]
        /* 0x8E8 */ public float DisablePhysicsRange;
        [NMS(Index = 209)]
        /* 0x8EC */ public float ExitStopForce;
        [NMS(Index = 208)]
        /* 0x8F0 */ public float ExitStopTime;
        [NMS(Index = 154)]
        /* 0x8F4 */ public float FirstPersonSteeringAdditionalForward;
        [NMS(Index = 155)]
        /* 0x8F8 */ public float FirstPersonSteeringAdditionalForwardThreshold;
        [NMS(Index = 156)]
        /* 0x8FC */ public float FirstPersonSteeringAdditionalReverseThreshold;
        [NMS(Index = 158)]
        /* 0x900 */ public float FirstPersonSteeringLowSpeedTurnDamping;
        [NMS(Index = 157)]
        /* 0x904 */ public float FirstPersonSteeringMinThrottleHardLeftRight;
        [NMS(Index = 233)]
        /* 0x908 */ public int GunBaseDamage;
        [NMS(Index = 236)]
        /* 0x90C */ public int GunBaseMiningDamage;
        [NMS(Index = 210)]
        /* 0x910 */ public float GunFireRate;
        [NMS(Index = 176)]
        /* 0x914 */ public float HeadlightIntensitySpringTime;
        [NMS(Index = 202)]
        /* 0x918 */ public float HornScareFleeRadius;
        [NMS(Index = 201)]
        /* 0x91C */ public float HornScareRadius;
        [NMS(Index = 203)]
        /* 0x920 */ public float HornScareTime;
        [NMS(Index = 10)]
        /* 0x924 */ public float LevelVehicleCameraFactor;
        [NMS(Index = 47)]
        /* 0x928 */ public float MechAIGroundTurnSpeed;
        [NMS(Index = 35)]
        /* 0x92C */ public float MechAIResummonMinSpawnDistance;
        [NMS(Index = 36)]
        /* 0x930 */ public float MechAIResummonMinSpeedForVelBasedSpawnPos;
        [NMS(Index = 34)]
        /* 0x934 */ public float MechAIResummonTriggerDistance;
        [NMS(Index = 37)]
        /* 0x938 */ public float MechAIResummonVelBasedSpawnSpeedMultiplier;
        [NMS(Index = 50)]
        /* 0x93C */ public float MechArmPitchAngleMax;
        [NMS(Index = 49)]
        /* 0x940 */ public float MechArmPitchAngleMin;
        [NMS(Index = 51)]
        /* 0x944 */ public float MechArmPitchLerpSpeed;
        [NMS(Index = 72)]
        /* 0x948 */ public float MechArmSwingAngleFastWalk;
        [NMS(Index = 69)]
        /* 0x94C */ public float MechArmSwingAngleWalk;
        [NMS(Index = 73)]
        /* 0x950 */ public float MechArmSwingPhaseFastWalk;
        [NMS(Index = 70)]
        /* 0x954 */ public float MechArmSwingPhaseWalk;
        [NMS(Index = 90)]
        /* 0x958 */ public float MechCameraOffsetAmount;
        [NMS(Index = 89)]
        /* 0x95C */ public float MechCameraOffsetTime;
        [NMS(Index = 120)]
        /* 0x960 */ public float MechCockPitBobPitch;
        [NMS(Index = 121)]
        /* 0x964 */ public float MechCockPitBobRoll;
        [NMS(Index = 118)]
        /* 0x968 */ public float MechCockPitBobX;
        [NMS(Index = 119)]
        /* 0x96C */ public float MechCockPitBobY;
        [NMS(Index = 122)]
        /* 0x970 */ public float MechCockPitBobYaw;
        [NMS(Index = 123)]
        /* 0x974 */ public float MechCockPowerDownY;
        [NMS(Index = 64)]
        /* 0x978 */ public float MechCoGAdjustTimeAir;
        [NMS(Index = 65)]
        /* 0x97C */ public float MechCoGAdjustTimeLand;
        [NMS(Index = 63)]
        /* 0x980 */ public float MechCoGAdjustTimeWindUp;
        [NMS(Index = 40)]
        /* 0x984 */ public float MechContrailAlpha;
        [NMS(Index = 66)]
        /* 0x988 */ public float MechCrouchTime;
        [NMS(Index = 93)]
        /* 0x98C */ public float MechDefaultBlendTime;
        [NMS(Index = 116)]
        /* 0x990 */ public float MechFirstPersonCrouchAmount;
        [NMS(Index = 112)]
        /* 0x994 */ public float MechFirstPersonDamping;
        [NMS(Index = 107)]
        /* 0x998 */ public float MechFirstPersonIgnoreReverseThreshold;
        [NMS(Index = 115)]
        /* 0x99C */ public float MechFirstPersonMaxLookTurret;
        [NMS(Index = 114)]
        /* 0x9A0 */ public float MechFirstPersonMaxTurnTurret;
        [NMS(Index = 113)]
        /* 0x9A4 */ public float MechFirstPersonStickXModerator;
        [NMS(Index = 111)]
        /* 0x9A8 */ public float MechFirstPersonTurretAngleThrottleStrength;
        [NMS(Index = 110)]
        /* 0x9AC */ public float MechFirstPersonTurretAngleThrottleThreshold;
        [NMS(Index = 106)]
        /* 0x9B0 */ public float MechFirstPersonTurretBaseThrottleThreshold;
        [NMS(Index = 109)]
        /* 0x9B4 */ public float MechFirstPersonTurretBaseTurnThreshold;
        [NMS(Index = 103)]
        /* 0x9B8 */ public float MechFirstPersonTurretPitchModerator;
        [NMS(Index = 105)]
        /* 0x9BC */ public float MechFirstPersonTurretShootTimer;
        [NMS(Index = 108)]
        /* 0x9C0 */ public float MechFirstPersonTurretThrottleLookThreshold;
        [NMS(Index = 102)]
        /* 0x9C4 */ public float MechFirstPersonTurretTurnModerator;
        [NMS(Index = 133)]
        /* 0x9C8 */ public float MechFootprintFadeDist;
        [NMS(Index = 132)]
        /* 0x9CC */ public float MechFootprintFadeTime;
        [NMS(Index = 99)]
        /* 0x9D0 */ public float MechIdleLowBlendTime;
        [NMS(Index = 100)]
        /* 0x9D4 */ public float MechIdleLowDelay;
        [NMS(Index = 101)]
        /* 0x9D8 */ public float MechIdleStopDelay;
        [NMS(Index = 83)]
        /* 0x9DC */ public float MechJetpackAvoidGroundForce;
        [NMS(Index = 85)]
        /* 0x9E0 */ public float MechJetpackAvoidGroundProbeLength;
        [NMS(Index = 79)]
        /* 0x9E4 */ public float MechJetpackBrake;
        [NMS(Index = 91)]
        /* 0x9E8 */ public float MechJetpackDrainRate;
        [NMS(Index = 84)]
        /* 0x9EC */ public float MechJetpackFallForce;
        [NMS(Index = 92)]
        /* 0x9F0 */ public float MechJetpackFillRate;
        [NMS(Index = 78)]
        /* 0x9F4 */ public float MechJetpackForce;
        [NMS(Index = 86)]
        /* 0x9F8 */ public float MechJetpackIgnitionForce;
        [NMS(Index = 87)]
        /* 0x9FC */ public float MechJetpackIgnitionTime;
        [NMS(Index = 41)]
        /* 0xA00 */ public float MechJetpackJetScaleTime;
        [NMS(Index = 77)]
        /* 0xA04 */ public float MechJetpackLandTime;
        [NMS(Index = 88)]
        /* 0xA08 */ public float MechJetpackMaxCoGAdjustX;
        [NMS(Index = 80)]
        /* 0xA0C */ public float MechJetpackMaxSpeed;
        [NMS(Index = 81)]
        /* 0xA10 */ public float MechJetpackMaxUpSpeed;
        [NMS(Index = 76)]
        /* 0xA14 */ public float MechJetpackStrafeStrength;
        [NMS(Index = 48)]
        /* 0xA18 */ public float MechJetpackTurnSpeed;
        [NMS(Index = 82)]
        /* 0xA1C */ public float MechJetpackUpForce;
        [NMS(Index = 96)]
        /* 0xA20 */ public float MechJumpBlendTime;
        [NMS(Index = 98)]
        /* 0xA24 */ public float MechJumpDownBlendTime;
        [NMS(Index = 97)]
        /* 0xA28 */ public float MechJumpFlyBlendTime;
        [NMS(Index = 95)]
        /* 0xA2C */ public float MechLandBlendTime;
        [NMS(Index = 75)]
        /* 0xA30 */ public float MechLandBrake;
        [NMS(Index = 131)]
        /* 0xA34 */ public float MechLandCameraShakeDist;
        [NMS(Index = 54)]
        /* 0xA38 */ public float MechMaxTurnAngleWhileStationary;
        [NMS(Index = 46)]
        /* 0xA3C */ public float MechPlayerGroundTurnSpeed;
        [NMS(Index = 117)]
        /* 0xA40 */ public float MechPowerUpTime;
        [NMS(Index = 228)]
        /* 0xA44 */ public float MechSpawnRotation;
        [NMS(Index = 94)]
        /* 0xA48 */ public float MechSpeedBlendTime;
        [NMS(Index = 130)]
        /* 0xA4C */ public float MechTitanFallCameraShakeDist;
        [NMS(Index = 124)]
        /* 0xA50 */ public float MechTitanFallHeight;
        [NMS(Index = 128)]
        /* 0xA54 */ public float MechTitanFallLandIdleTime;
        [NMS(Index = 129)]
        /* 0xA58 */ public float MechTitanFallLandIntroTime;
        [NMS(Index = 127)]
        /* 0xA5C */ public float MechTitanFallTerrainEditOffset;
        [NMS(Index = 126)]
        /* 0xA60 */ public float MechTitanFallTerrainEditSize;
        [NMS(Index = 59)]
        /* 0xA64 */ public float MechTurretMaxAngleAir;
        [NMS(Index = 56)]
        /* 0xA68 */ public float MechTurretMaxAngleGround;
        [NMS(Index = 60)]
        /* 0xA6C */ public float MechTurretTimeVRModifier;
        [NMS(Index = 58)]
        /* 0xA70 */ public float MechTurretTurnTimeAir;
        [NMS(Index = 55)]
        /* 0xA74 */ public float MechTurretTurnTimeGround;
        [NMS(Index = 57)]
        /* 0xA78 */ public float MechTurretTurnTimeGroundPlayerCombat;
        [NMS(Index = 67)]
        /* 0xA7C */ public float MechWalkToRunTimeIdle;
        [NMS(Index = 68)]
        /* 0xA80 */ public float MechWalkToRunTimeSkid;
        [NMS(Index = 145)]
        /* 0xA84 */ public float MechWeaponInterpSpeed;
        [NMS(Index = 231)]
        /* 0xA88 */ public int MiningLaserDamage;
        [NMS(Index = 192)]
        /* 0xA8C */ public float MiningLaserDrainSpeed;
        [NMS(Index = 230)]
        /* 0xA90 */ public int MiningLaserMiningDamage;
        [NMS(Index = 229)]
        /* 0xA94 */ public float MiningLaserRadius;
        [NMS(Index = 232)]
        /* 0xA98 */ public float MiningLaserSpeed;
        [NMS(Index = 193)]
        /* 0xA9C */ public float ProjectileDrainPerShot;
        [NMS(Index = 213)]
        /* 0xAA0 */ public float RaceCooldown;
        [NMS(Index = 195)]
        /* 0xAA4 */ public float RaceInteractRespawnOffset;
        [NMS(Index = 196)]
        /* 0xAA8 */ public float RaceInteractRespawnUpOffset;
        [NMS(Index = 191)]
        /* 0xAAC */ public float RaceMultipleStartCaptureRange;
        [NMS(Index = 190)]
        /* 0xAB0 */ public float RaceMultipleStartOffset;
        [NMS(Index = 215)]
        /* 0xAB4 */ public float RaceResetFlashDuration;
        [NMS(Index = 216)]
        /* 0xAB8 */ public float RaceResetFlashIntensity;
        [NMS(Index = 194)]
        /* 0xABC */ public float RaceStartSpawnUpOffset;
        [NMS(Index = 19)]
        /* 0xAC0 */ public float RemoteBoostingEffectTimeout;
        [NMS(Index = 237)]
        /* 0xAC4 */ public float ResourceCollectOffset;
        [NMS(Index = 227)]
        /* 0xAC8 */ public float SpawnRotation;
        [NMS(Index = 17)]
        /* 0xACC */ public float SteeringWheelCentreOffset;
        [NMS(Index = 14)]
        /* 0xAD0 */ public float SteeringWheelPitchAngle;
        [NMS(Index = 13)]
        /* 0xAD4 */ public float SteeringWheelPushRange;
        [NMS(Index = 15)]
        /* 0xAD8 */ public float SteeringWheelSpringBothHands;
        [NMS(Index = 16)]
        /* 0xADC */ public float SteeringWheelSpringOneHand;
        [NMS(Index = 270)]
        /* 0xAE0 */ public float StickReverseTurnStiffness;
        [NMS(Index = 269)]
        /* 0xAE4 */ public float StickReverseTurnThreshold;
        [NMS(Index = 197)]
        /* 0xAE8 */ public float StickTurnReducer;
        [NMS(Index = 199)]
        /* 0xAEC */ public float StickTurnReducerAlt;
        [NMS(Index = 198)]
        /* 0xAF0 */ public float StickTurnReducerVR;
        [NMS(Index = 234)]
        /* 0xAF4 */ public int StunGunBaseDamage;
        [NMS(Index = 235)]
        /* 0xAF8 */ public float StunGunFireRate;
        [NMS(Index = 152)]
        /* 0xAFC */ public float SubmarineEjectDownOffset;
        [NMS(Index = 151)]
        /* 0xB00 */ public float SubmarineEjectRadius;
        [NMS(Index = 153)]
        /* 0xB04 */ public float SubmarineFirstPersonSteeringSensitivity;
        [NMS(Index = 150)]
        /* 0xB08 */ public float SubmarineMinSummonDepth;
        [NMS(Index = 211)]
        /* 0xB0C */ public float SummoningRange;
        [NMS(Index = 241)]
        /* 0xB10 */ public float SuspensionDamping;
        [NMS(Index = 242)]
        /* 0xB14 */ public float SuspensionDampingAngularFactor;
        [NMS(Index = 24)]
        /* 0xB18 */ public float TestAnimBoost;
        [NMS(Index = 23)]
        /* 0xB1C */ public float TestAnimThrust;
        [NMS(Index = 25)]
        /* 0xB20 */ public float TestAnimTurn;
        [NMS(Index = 20)]
        /* 0xB24 */ public float TestFrictionStat;
        [NMS(Index = 21)]
        /* 0xB28 */ public float TestSkidFrictionStat;
        [NMS(Index = 200)]
        /* 0xB2C */ public float TravelSpeedReportReducer;
        [NMS(Index = 162)]
        /* 0xB30 */ public float UnderwaterBuoyancyRange;
        [NMS(Index = 161)]
        /* 0xB34 */ public float UnderwaterBuoyancySurfaceOffset;
        [NMS(Index = 167)]
        /* 0xB38 */ public float UnderwaterFlattenMinDepth;
        [NMS(Index = 168)]
        /* 0xB3C */ public float UnderwaterFlattenRange;
        [NMS(Index = 173)]
        /* 0xB40 */ public float UnderwaterJumpForce;
        [NMS(Index = 1)]
        /* 0xB44 */ public float UnderwaterScannerIconRangeBoost;
        [NMS(Index = 163)]
        /* 0xB48 */ public float UnderwaterSummonSurfaceOffset;
        [NMS(Index = 169)]
        /* 0xB4C */ public float UnderwaterSurfaceForceFlatteningAngleMin;
        [NMS(Index = 170)]
        /* 0xB50 */ public float UnderwaterSurfaceForceFlatteningAngleRange;
        [NMS(Index = 166)]
        /* 0xB54 */ public float UnderwaterSurfaceGravity;
        [NMS(Index = 165)]
        /* 0xB58 */ public float UnderwaterSurfaceOffset;
        [NMS(Index = 171)]
        /* 0xB5C */ public float UnderwaterSurfaceSplashdownForce;
        [NMS(Index = 172)]
        /* 0xB60 */ public float UnderwaterSurfaceSplashdownMinSpeed;
        [NMS(Index = 164)]
        /* 0xB64 */ public float UnderwaterSurfaceTension;
        [NMS(Index = 178)]
        /* 0xB68 */ public float VehicleAltControlStickSmoothInTime;
        [NMS(Index = 179)]
        /* 0xB6C */ public float VehicleAltControlStickSmoothOutTime;
        [NMS(Index = 259)]
        /* 0xB70 */ public float VehicleBoostFuelRate;
        [NMS(Index = 260)]
        /* 0xB74 */ public float VehicleBoostFuelRateSurvival;
        [NMS(Index = 180)]
        /* 0xB78 */ public float VehicleBoostSpeedMultiplierPercent;
        [NMS(Index = 0)]
        /* 0xB7C */ public float VehicleCollisionScaleFactor;
        [NMS(Index = 258)]
        /* 0xB80 */ public float VehicleDeactivateRange;
        [NMS(Index = 254)]
        /* 0xB84 */ public float VehicleFadeTime;
        [NMS(Index = 261)]
        /* 0xB88 */ public float VehicleFuelRate;
        [NMS(Index = 262)]
        /* 0xB8C */ public float VehicleFuelRateTruckMultiplier;
        [NMS(Index = 182)]
        /* 0xB90 */ public float VehicleGarageHologramFadeRange;
        [NMS(Index = 181)]
        /* 0xB94 */ public float VehicleGarageHologramMinFadeRange;
        [NMS(Index = 265)]
        /* 0xB98 */ public float VehicleJumpCooldown;
        [NMS(Index = 264)]
        /* 0xB9C */ public float VehicleJumpTimeMax;
        [NMS(Index = 263)]
        /* 0xBA0 */ public float VehicleJumpTimeMin;
        [NMS(Index = 256)]
        /* 0xBA4 */ public float VehicleMaxSummonDistance;
        [NMS(Index = 257)]
        /* 0xBA8 */ public float VehicleMaxSummonDistanceUnderwater;
        [NMS(Index = 255)]
        /* 0xBAC */ public float VehicleMinSummonDistance;
        [NMS(Index = 266)]
        /* 0xBB0 */ public float VehicleMotionDeadZone;
        [NMS(Index = 2)]
        /* 0xBB4 */ public float VehicleSolarRegenFactor;
        [NMS(Index = 251)]
        /* 0xBB8 */ public float VehicleSuspensionAudioDelay;
        [NMS(Index = 252)]
        /* 0xBBC */ public float VehicleSuspensionAudioScale;
        [NMS(Index = 250)]
        /* 0xBC0 */ public float VehicleSuspensionAudioSpacing;
        [NMS(Index = 253)]
        /* 0xBC4 */ public float VehicleSuspensionAudioTrigger;
        [NMS(Index = 247)]
        /* 0xBC8 */ public float VehicleTextSize;
        [NMS(Index = 238)]
        /* 0xBCC */ public float VehicleWheelNoise;
        [NMS(Index = 239)]
        /* 0xBD0 */ public float VehicleWheelNoiseScale;
        [NMS(Index = 27)]
        /* 0xBD4 */ public float VisualTurnSpring;
        [NMS(Index = 26)]
        /* 0xBD8 */ public float VisualTurnUnderwaterSpring;
        [NMS(Index = 149)]
        /* 0xBDC */ public float WeaponInterpSpeed;
        [NMS(Index = 29)]
        /* 0xBE0 */ public float WheelDustColourLightFactor;
        [NMS(Index = 267)]
        /* 0xBE4 */ public float WheelForceHalflife;
        [NMS(Index = 240)]
        /* 0xBE8 */ public float WheelSideVerticalFactor;
        [NMS(Index = 146, Size = 0x4, EnumType = typeof(GcMechWeaponLocation.MechWeaponLocationEnum))]
        /* 0xBEC */ public NMSString0x20[] MechWeaponLocatorNames;
        [NMS(Index = 39)]
        /* 0xC6C */ public bool MechAltJumpMode;
        [NMS(Index = 74)]
        /* 0xC6D */ public TkCurveType MechArmSwingCurveFastWalk;
        [NMS(Index = 71)]
        /* 0xC6E */ public TkCurveType MechArmSwingCurveWalk;
        [NMS(Index = 104)]
        /* 0xC6F */ public bool MechFirstPersonTurretTweaksEnabled;
        [NMS(Index = 38)]
        /* 0xC70 */ public bool MechStrafeEnabled;
        [NMS(Index = 125)]
        /* 0xC71 */ public bool MechTitanFallTerrainEditEnabled;
        [NMS(Index = 214)]
        /* 0xC72 */ public bool RaceFinishAtStart;
        [NMS(Index = 11)]
        /* 0xC73 */ public bool ShowAllCheckpoints;
        [NMS(Index = 243)]
        /* 0xC74 */ public bool ShowTempVehicleMesh;
        [NMS(Index = 244)]
        /* 0xC75 */ public bool ShowVehicleDebugging;
        [NMS(Index = 248)]
        /* 0xC76 */ public bool ShowVehicleParticleDebug;
        [NMS(Index = 246)]
        /* 0xC77 */ public bool ShowVehicleText;
        [NMS(Index = 245)]
        /* 0xC78 */ public bool ShowVehicleWheelGuards;
        [NMS(Index = 18)]
        /* 0xC79 */ public TkCurveType SteeringWheelOutputCurve;
        [NMS(Index = 22)]
        /* 0xC7A */ public bool TestAnims;
        [NMS(Index = 268)]
        /* 0xC7B */ public bool ThrottleButtonCamRelative;
        [NMS(Index = 9)]
        /* 0xC7C */ public bool UseFirstPersonCamera;
        [NMS(Index = 177)]
        /* 0xC7D */ public bool VehicleAltControlScheme;
        [NMS(Index = 249)]
        /* 0xC7E */ public bool VehicleDrawAudioDebug;
    }
}
