using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xE0776C44670BA4AE, NameHash = 0x6C7923EF)]
    public class GcVehicleGlobals : NMSTemplate
    {
        [NMS(Index = 198)]
        /* 0x000 */ public GcScanEffectData VehicleVisibilityScanEffect;
        [NMS(Index = 235)]
        /* 0x050 */ public Colour CheckpointBeamColourActive;
        [NMS(Index = 236)]
        /* 0x060 */ public Colour CheckpointBeamColourNormal;
        [NMS(Index = 34)]
        /* 0x070 */ public Colour DefaultBoosterColour;
        [NMS(Index = 64)]
        /* 0x080 */ public Vector3f MechCrouchOffset;
        [NMS(Index = 65)]
        /* 0x090 */ public Vector3f MechWalkBackwardsCoGOffset;
        [NMS(Index = 155)]
        /* 0x0A0 */ public GcMechMeshPartTable MechMeshPartsTable;
        [NMS(Index = 154, Size = 0x5, EnumType = typeof(GcVehicleWeaponMode.VehicleWeaponModeEnum))]
        /* 0x320 */ public GcExoMechWeaponData[] MechWeaponData;
        [NMS(Index = 289, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x5A0 */ public GcVehicleMuzzleData[] VehicleWeaponMuzzleFlash;
        [NMS(Index = 138)]
        /* 0x7D0 */ public GcMechAudioEventTable MechAudioEventTable;
        [NMS(Index = 137)]
        /* 0x8F0 */ public GcMechEffectTable MechEffectTable;
        [NMS(Index = 10)]
        /* 0x990 */ public NMSString0x20A BugMechRightArmTechNameOverride;
        [NMS(Index = 9)]
        /* 0x9B0 */ public NMSString0x20A SentinelRightArmTechNameOverride;
        [NMS(Index = 8)]
        /* 0x9D0 */ public NMSString0x10 BugMechLeftArmTech;
        [NMS(Index = 7)]
        /* 0x9E0 */ public NMSString0x10 BugMechRightArmTech;
        [NMS(Index = 238)]
        /* 0x9F0 */ public List<NMSString0x10> DefaultBikeLoadout;
        [NMS(Index = 237)]
        /* 0xA00 */ public List<NMSString0x10> DefaultBuggyLoadout;
        [NMS(Index = 239)]
        /* 0xA10 */ public List<NMSString0x10> DefaultTruckLoadout;
        [NMS(Index = 55)]
        /* 0xA20 */ public NMSString0x10 MechArmPitchAnimLeft;
        [NMS(Index = 56)]
        /* 0xA30 */ public NMSString0x10 MechArmPitchAnimRight;
        [NMS(Index = 4)]
        /* 0xA40 */ public NMSString0x10 MechStrongLaser;
        [NMS(Index = 6)]
        /* 0xA50 */ public NMSString0x10 SentinelLeftArmTech;
        [NMS(Index = 5)]
        /* 0xA60 */ public NMSString0x10 SentinelRightArmTech;
        [NMS(Index = 11)]
        /* 0xA70 */ public NMSString0x10 SentinelRightLeftArmLaserData;
        [NMS(Index = 186)]
        /* 0xA80 */ public List<Vector3f> UnderwaterBubbleOffset;
        [NMS(Index = 291)]
        /* 0xA90 */ public List<GcVehicleData> VehicleDataTable;
        [NMS(Index = 288)]
        /* 0xAA0 */ public NMSString0x10 VehicleLocalScan;
        [NMS(Index = 287)]
        /* 0xAB0 */ public NMSString0x10 VehicleScan;
        [NMS(Index = 3)]
        /* 0xAC0 */ public NMSString0x10 VehicleStrongLaser;
        [NMS(Index = 290)]
        /* 0xAD0 */ public List<GcVehicleWeaponMuzzleData> VehicleWeaponMuzzleDataTable;
        [NMS(Index = 185)]
        /* 0xAE0 */ public GcSpaceshipAvoidanceData UnderwaterAvoidance;
        [NMS(Index = 37)]
        /* 0xB04 */ public Vector2f MechLookStickSpeedLimit;
        [NMS(Index = 36)]
        /* 0xB0C */ public Vector2f MechMovementStickSpeedLimit;
        [NMS(Index = 145)]
        /* 0xB14 */ public float AIMechFlamethrowerFireInterval;
        [NMS(Index = 149)]
        /* 0xB18 */ public int AIMechFlamethrowerNumShotsMax;
        [NMS(Index = 148)]
        /* 0xB1C */ public int AIMechFlamethrowerNumShotsMin;
        [NMS(Index = 150)]
        /* 0xB20 */ public float AIMechGunExplosionRadius;
        [NMS(Index = 141)]
        /* 0xB24 */ public float AIMechGunFireInterval;
        [NMS(Index = 151)]
        /* 0xB28 */ public float AIMechGunInheritVelocity;
        [NMS(Index = 143)]
        /* 0xB2C */ public int AIMechGunNumShotsMax;
        [NMS(Index = 142)]
        /* 0xB30 */ public int AIMechGunNumShotsMin;
        [NMS(Index = 140)]
        /* 0xB34 */ public float AIMechLaserFireDurationMax;
        [NMS(Index = 139)]
        /* 0xB38 */ public float AIMechLaserFireDurationMin;
        [NMS(Index = 144)]
        /* 0xB3C */ public float AIMechStunGunFireInterval;
        [NMS(Index = 147)]
        /* 0xB40 */ public int AIMechStunGunNumShotsMax;
        [NMS(Index = 146)]
        /* 0xB44 */ public int AIMechStunGunNumShotsMin;
        [NMS(Index = 222)]
        /* 0xB48 */ public float AttractAlign;
        [NMS(Index = 220)]
        /* 0xB4C */ public float AttractAmount;
        [NMS(Index = 223)]
        /* 0xB50 */ public float AttractDirectionBrakeThresholdSq;
        [NMS(Index = 221)]
        /* 0xB54 */ public float AttractMaxSpeed;
        [NMS(Index = 200)]
        /* 0xB58 */ public float BoostPadStrength;
        [NMS(Index = 199)]
        /* 0xB5C */ public float BoostPadTime;
        [NMS(Index = 168)]
        /* 0xB60 */ public float BuoyancyMaxDownForce;
        [NMS(Index = 169)]
        /* 0xB64 */ public float BuoyancyMaxUpForce;
        [NMS(Index = 171)]
        /* 0xB68 */ public float BuoyancySurfaceFudge;
        [NMS(Index = 170)]
        /* 0xB6C */ public float BuoyancySurfacingTime;
        [NMS(Index = 167)]
        /* 0xB70 */ public float BuoyancyUnderwaterSphereRadius;
        [NMS(Index = 242)]
        /* 0xB74 */ public float CheckpointBeamOffset;
        [NMS(Index = 241)]
        /* 0xB78 */ public float CheckpointBeamSizeActive;
        [NMS(Index = 240)]
        /* 0xB7C */ public float CheckpointBeamSizeNormal;
        [NMS(Index = 197)]
        /* 0xB80 */ public float CheckpointDeleteAngle;
        [NMS(Index = 196)]
        /* 0xB84 */ public float CheckpointDeleteDistance;
        [NMS(Index = 233)]
        /* 0xB88 */ public float CheckpointFlashDuration;
        [NMS(Index = 234)]
        /* 0xB8C */ public float CheckpointFlashIntensity;
        [NMS(Index = 194)]
        /* 0xB90 */ public float CheckpointPlacementOffset;
        [NMS(Index = 195)]
        /* 0xB94 */ public float CheckpointPlacementRayLength;
        [NMS(Index = 228)]
        /* 0xB98 */ public float CheckpointRadius;
        [NMS(Index = 15)]
        /* 0xB9C */ public float ControlStickRecenterSpeedDegPerSec;
        [NMS(Index = 39)]
        /* 0xBA0 */ public float DamageTechMinHitIntervalSeconds;
        [NMS(Index = 38)]
        /* 0xBA4 */ public int DamageTechNumHitsRequired;
        [NMS(Index = 202)]
        /* 0xBA8 */ public float DisablePhysicsMinRangeCheck;
        [NMS(Index = 201)]
        /* 0xBAC */ public float DisablePhysicsRange;
        [NMS(Index = 225)]
        /* 0xBB0 */ public float ExitStopForce;
        [NMS(Index = 224)]
        /* 0xBB4 */ public float ExitStopTime;
        [NMS(Index = 162)]
        /* 0xBB8 */ public float FirstPersonSteeringAdditionalForward;
        [NMS(Index = 163)]
        /* 0xBBC */ public float FirstPersonSteeringAdditionalForwardThreshold;
        [NMS(Index = 164)]
        /* 0xBC0 */ public float FirstPersonSteeringAdditionalReverseThreshold;
        [NMS(Index = 166)]
        /* 0xBC4 */ public float FirstPersonSteeringLowSpeedTurnDamping;
        [NMS(Index = 165)]
        /* 0xBC8 */ public float FirstPersonSteeringMinThrottleHardLeftRight;
        [NMS(Index = 249)]
        /* 0xBCC */ public int GunBaseDamage;
        [NMS(Index = 252)]
        /* 0xBD0 */ public int GunBaseMiningDamage;
        [NMS(Index = 226)]
        /* 0xBD4 */ public float GunFireRate;
        [NMS(Index = 187)]
        /* 0xBD8 */ public float HeadlightIntensitySpringTime;
        [NMS(Index = 218)]
        /* 0xBDC */ public float HornScareFleeRadius;
        [NMS(Index = 217)]
        /* 0xBE0 */ public float HornScareRadius;
        [NMS(Index = 219)]
        /* 0xBE4 */ public float HornScareTime;
        [NMS(Index = 13)]
        /* 0xBE8 */ public float LevelVehicleCameraFactor;
        [NMS(Index = 50)]
        /* 0xBEC */ public float MechAIGroundTurnSpeed;
        [NMS(Index = 42)]
        /* 0xBF0 */ public float MechAIResummonMinSpawnDistance;
        [NMS(Index = 43)]
        /* 0xBF4 */ public float MechAIResummonMinSpeedForVelBasedSpawnPos;
        [NMS(Index = 41)]
        /* 0xBF8 */ public float MechAIResummonTriggerDistance;
        [NMS(Index = 44)]
        /* 0xBFC */ public float MechAIResummonVelBasedSpawnSpeedMultiplier;
        [NMS(Index = 53)]
        /* 0xC00 */ public float MechArmPitchAngleMax;
        [NMS(Index = 52)]
        /* 0xC04 */ public float MechArmPitchAngleMin;
        [NMS(Index = 54)]
        /* 0xC08 */ public float MechArmPitchLerpSpeed;
        [NMS(Index = 75)]
        /* 0xC0C */ public float MechArmSwingAngleFastWalk;
        [NMS(Index = 72)]
        /* 0xC10 */ public float MechArmSwingAngleWalk;
        [NMS(Index = 76)]
        /* 0xC14 */ public float MechArmSwingPhaseFastWalk;
        [NMS(Index = 73)]
        /* 0xC18 */ public float MechArmSwingPhaseWalk;
        [NMS(Index = 93)]
        /* 0xC1C */ public float MechCameraOffsetAmount;
        [NMS(Index = 92)]
        /* 0xC20 */ public float MechCameraOffsetTime;
        [NMS(Index = 123)]
        /* 0xC24 */ public float MechCockPitBobPitch;
        [NMS(Index = 124)]
        /* 0xC28 */ public float MechCockPitBobRoll;
        [NMS(Index = 121)]
        /* 0xC2C */ public float MechCockPitBobX;
        [NMS(Index = 122)]
        /* 0xC30 */ public float MechCockPitBobY;
        [NMS(Index = 125)]
        /* 0xC34 */ public float MechCockPitBobYaw;
        [NMS(Index = 126)]
        /* 0xC38 */ public float MechCockPowerDownY;
        [NMS(Index = 67)]
        /* 0xC3C */ public float MechCoGAdjustTimeAir;
        [NMS(Index = 68)]
        /* 0xC40 */ public float MechCoGAdjustTimeLand;
        [NMS(Index = 66)]
        /* 0xC44 */ public float MechCoGAdjustTimeWindUp;
        [NMS(Index = 47)]
        /* 0xC48 */ public float MechContrailAlpha;
        [NMS(Index = 69)]
        /* 0xC4C */ public float MechCrouchTime;
        [NMS(Index = 96)]
        /* 0xC50 */ public float MechDefaultBlendTime;
        [NMS(Index = 119)]
        /* 0xC54 */ public float MechFirstPersonCrouchAmount;
        [NMS(Index = 115)]
        /* 0xC58 */ public float MechFirstPersonDamping;
        [NMS(Index = 110)]
        /* 0xC5C */ public float MechFirstPersonIgnoreReverseThreshold;
        [NMS(Index = 118)]
        /* 0xC60 */ public float MechFirstPersonMaxLookTurret;
        [NMS(Index = 117)]
        /* 0xC64 */ public float MechFirstPersonMaxTurnTurret;
        [NMS(Index = 116)]
        /* 0xC68 */ public float MechFirstPersonStickXModerator;
        [NMS(Index = 114)]
        /* 0xC6C */ public float MechFirstPersonTurretAngleThrottleStrength;
        [NMS(Index = 113)]
        /* 0xC70 */ public float MechFirstPersonTurretAngleThrottleThreshold;
        [NMS(Index = 109)]
        /* 0xC74 */ public float MechFirstPersonTurretBaseThrottleThreshold;
        [NMS(Index = 112)]
        /* 0xC78 */ public float MechFirstPersonTurretBaseTurnThreshold;
        [NMS(Index = 106)]
        /* 0xC7C */ public float MechFirstPersonTurretPitchModerator;
        [NMS(Index = 108)]
        /* 0xC80 */ public float MechFirstPersonTurretShootTimer;
        [NMS(Index = 111)]
        /* 0xC84 */ public float MechFirstPersonTurretThrottleLookThreshold;
        [NMS(Index = 105)]
        /* 0xC88 */ public float MechFirstPersonTurretTurnModerator;
        [NMS(Index = 136)]
        /* 0xC8C */ public float MechFootprintFadeDist;
        [NMS(Index = 135)]
        /* 0xC90 */ public float MechFootprintFadeTime;
        [NMS(Index = 102)]
        /* 0xC94 */ public float MechIdleLowBlendTime;
        [NMS(Index = 103)]
        /* 0xC98 */ public float MechIdleLowDelay;
        [NMS(Index = 104)]
        /* 0xC9C */ public float MechIdleStopDelay;
        [NMS(Index = 86)]
        /* 0xCA0 */ public float MechJetpackAvoidGroundForce;
        [NMS(Index = 88)]
        /* 0xCA4 */ public float MechJetpackAvoidGroundProbeLength;
        [NMS(Index = 82)]
        /* 0xCA8 */ public float MechJetpackBrake;
        [NMS(Index = 94)]
        /* 0xCAC */ public float MechJetpackDrainRate;
        [NMS(Index = 87)]
        /* 0xCB0 */ public float MechJetpackFallForce;
        [NMS(Index = 95)]
        /* 0xCB4 */ public float MechJetpackFillRate;
        [NMS(Index = 81)]
        /* 0xCB8 */ public float MechJetpackForce;
        [NMS(Index = 89)]
        /* 0xCBC */ public float MechJetpackIgnitionForce;
        [NMS(Index = 90)]
        /* 0xCC0 */ public float MechJetpackIgnitionTime;
        [NMS(Index = 48)]
        /* 0xCC4 */ public float MechJetpackJetScaleTime;
        [NMS(Index = 80)]
        /* 0xCC8 */ public float MechJetpackLandTime;
        [NMS(Index = 91)]
        /* 0xCCC */ public float MechJetpackMaxCoGAdjustX;
        [NMS(Index = 83)]
        /* 0xCD0 */ public float MechJetpackMaxSpeed;
        [NMS(Index = 84)]
        /* 0xCD4 */ public float MechJetpackMaxUpSpeed;
        [NMS(Index = 79)]
        /* 0xCD8 */ public float MechJetpackStrafeStrength;
        [NMS(Index = 51)]
        /* 0xCDC */ public float MechJetpackTurnSpeed;
        [NMS(Index = 85)]
        /* 0xCE0 */ public float MechJetpackUpForce;
        [NMS(Index = 99)]
        /* 0xCE4 */ public float MechJumpBlendTime;
        [NMS(Index = 101)]
        /* 0xCE8 */ public float MechJumpDownBlendTime;
        [NMS(Index = 100)]
        /* 0xCEC */ public float MechJumpFlyBlendTime;
        [NMS(Index = 98)]
        /* 0xCF0 */ public float MechLandBlendTime;
        [NMS(Index = 78)]
        /* 0xCF4 */ public float MechLandBrake;
        [NMS(Index = 134)]
        /* 0xCF8 */ public float MechLandCameraShakeDist;
        [NMS(Index = 57)]
        /* 0xCFC */ public float MechMaxTurnAngleWhileStationary;
        [NMS(Index = 49)]
        /* 0xD00 */ public float MechPlayerGroundTurnSpeed;
        [NMS(Index = 120)]
        /* 0xD04 */ public float MechPowerUpTime;
        [NMS(Index = 244)]
        /* 0xD08 */ public float MechSpawnRotation;
        [NMS(Index = 97)]
        /* 0xD0C */ public float MechSpeedBlendTime;
        [NMS(Index = 133)]
        /* 0xD10 */ public float MechTitanFallCameraShakeDist;
        [NMS(Index = 127)]
        /* 0xD14 */ public float MechTitanFallHeight;
        [NMS(Index = 131)]
        /* 0xD18 */ public float MechTitanFallLandIdleTime;
        [NMS(Index = 132)]
        /* 0xD1C */ public float MechTitanFallLandIntroTime;
        [NMS(Index = 130)]
        /* 0xD20 */ public float MechTitanFallTerrainEditOffset;
        [NMS(Index = 129)]
        /* 0xD24 */ public float MechTitanFallTerrainEditSize;
        [NMS(Index = 62)]
        /* 0xD28 */ public float MechTurretMaxAngleAir;
        [NMS(Index = 59)]
        /* 0xD2C */ public float MechTurretMaxAngleGround;
        [NMS(Index = 63)]
        /* 0xD30 */ public float MechTurretTimeVRModifier;
        [NMS(Index = 61)]
        /* 0xD34 */ public float MechTurretTurnTimeAir;
        [NMS(Index = 58)]
        /* 0xD38 */ public float MechTurretTurnTimeGround;
        [NMS(Index = 60)]
        /* 0xD3C */ public float MechTurretTurnTimeGroundPlayerCombat;
        [NMS(Index = 70)]
        /* 0xD40 */ public float MechWalkToRunTimeIdle;
        [NMS(Index = 71)]
        /* 0xD44 */ public float MechWalkToRunTimeSkid;
        [NMS(Index = 152)]
        /* 0xD48 */ public float MechWeaponInterpSpeed;
        [NMS(Index = 247)]
        /* 0xD4C */ public int MiningLaserDamage;
        [NMS(Index = 205)]
        /* 0xD50 */ public float MiningLaserDrainSpeed;
        [NMS(Index = 246)]
        /* 0xD54 */ public int MiningLaserMiningDamage;
        [NMS(Index = 245)]
        /* 0xD58 */ public float MiningLaserRadius;
        [NMS(Index = 248)]
        /* 0xD5C */ public float MiningLaserSpeed;
        [NMS(Index = 206)]
        /* 0xD60 */ public float ProjectileDrainPerShot;
        [NMS(Index = 229)]
        /* 0xD64 */ public float RaceCooldown;
        [NMS(Index = 208)]
        /* 0xD68 */ public float RaceInteractRespawnOffset;
        [NMS(Index = 209)]
        /* 0xD6C */ public float RaceInteractRespawnUpOffset;
        [NMS(Index = 204)]
        /* 0xD70 */ public float RaceMultipleStartCaptureRange;
        [NMS(Index = 203)]
        /* 0xD74 */ public float RaceMultipleStartOffset;
        [NMS(Index = 231)]
        /* 0xD78 */ public float RaceResetFlashDuration;
        [NMS(Index = 232)]
        /* 0xD7C */ public float RaceResetFlashIntensity;
        [NMS(Index = 207)]
        /* 0xD80 */ public float RaceStartSpawnUpOffset;
        [NMS(Index = 22)]
        /* 0xD84 */ public float RemoteBoostingEffectTimeout;
        [NMS(Index = 253)]
        /* 0xD88 */ public float ResourceCollectOffset;
        [NMS(Index = 243)]
        /* 0xD8C */ public float SpawnRotation;
        [NMS(Index = 20)]
        /* 0xD90 */ public float SteeringWheelCentreOffset;
        [NMS(Index = 17)]
        /* 0xD94 */ public float SteeringWheelPitchAngle;
        [NMS(Index = 16)]
        /* 0xD98 */ public float SteeringWheelPushRange;
        [NMS(Index = 18)]
        /* 0xD9C */ public float SteeringWheelSpringBothHands;
        [NMS(Index = 19)]
        /* 0xDA0 */ public float SteeringWheelSpringOneHand;
        [NMS(Index = 286)]
        /* 0xDA4 */ public float StickReverseTurnStiffness;
        [NMS(Index = 285)]
        /* 0xDA8 */ public float StickReverseTurnThreshold;
        [NMS(Index = 210)]
        /* 0xDAC */ public float StickTurnReducer;
        [NMS(Index = 213)]
        /* 0xDB0 */ public float StickTurnReducerAltNonVR;
        [NMS(Index = 215)]
        /* 0xDB4 */ public float StickTurnReducerAltNonVRTruck;
        [NMS(Index = 212)]
        /* 0xDB8 */ public float StickTurnReducerVR;
        [NMS(Index = 214)]
        /* 0xDBC */ public float StickTurnReducerVRTruck;
        [NMS(Index = 211)]
        /* 0xDC0 */ public float StickTurnReducerWater;
        [NMS(Index = 250)]
        /* 0xDC4 */ public int StunGunBaseDamage;
        [NMS(Index = 251)]
        /* 0xDC8 */ public float StunGunFireRate;
        [NMS(Index = 161)]
        /* 0xDCC */ public float SubmarineBinocsExtraOffset;
        [NMS(Index = 159)]
        /* 0xDD0 */ public float SubmarineEjectDownOffset;
        [NMS(Index = 158)]
        /* 0xDD4 */ public float SubmarineEjectRadius;
        [NMS(Index = 160)]
        /* 0xDD8 */ public float SubmarineFirstPersonSteeringSensitivity;
        [NMS(Index = 157)]
        /* 0xDDC */ public float SubmarineMinSummonDepth;
        [NMS(Index = 227)]
        /* 0xDE0 */ public float SummoningRange;
        [NMS(Index = 257)]
        /* 0xDE4 */ public float SuspensionDamping;
        [NMS(Index = 258)]
        /* 0xDE8 */ public float SuspensionDampingAngularFactor;
        [NMS(Index = 27)]
        /* 0xDEC */ public float TestAnimBoost;
        [NMS(Index = 26)]
        /* 0xDF0 */ public float TestAnimThrust;
        [NMS(Index = 28)]
        /* 0xDF4 */ public float TestAnimTurn;
        [NMS(Index = 23)]
        /* 0xDF8 */ public float TestFrictionStat;
        [NMS(Index = 24)]
        /* 0xDFC */ public float TestSkidFrictionStat;
        [NMS(Index = 216)]
        /* 0xE00 */ public float TravelSpeedReportReducer;
        [NMS(Index = 173)]
        /* 0xE04 */ public float UnderwaterBuoyancyRangeMax;
        [NMS(Index = 172)]
        /* 0xE08 */ public float UnderwaterBuoyancyRangeMin;
        [NMS(Index = 184)]
        /* 0xE0C */ public float UnderwaterDiveForce;
        [NMS(Index = 177)]
        /* 0xE10 */ public float UnderwaterFlattenMinDepth;
        [NMS(Index = 178)]
        /* 0xE14 */ public float UnderwaterFlattenRange;
        [NMS(Index = 183)]
        /* 0xE18 */ public float UnderwaterJumpForce;
        [NMS(Index = 1)]
        /* 0xE1C */ public float UnderwaterScannerIconRangeBoost;
        [NMS(Index = 175)]
        /* 0xE20 */ public float UnderwaterSummonSurfaceOffset;
        [NMS(Index = 179)]
        /* 0xE24 */ public float UnderwaterSurfaceForceFlatteningAngleMin;
        [NMS(Index = 180)]
        /* 0xE28 */ public float UnderwaterSurfaceForceFlatteningAngleRange;
        [NMS(Index = 176)]
        /* 0xE2C */ public float UnderwaterSurfaceOffset;
        [NMS(Index = 181)]
        /* 0xE30 */ public float UnderwaterSurfaceSplashdownForce;
        [NMS(Index = 182)]
        /* 0xE34 */ public float UnderwaterSurfaceSplashdownMinSpeed;
        [NMS(Index = 189)]
        /* 0xE38 */ public float VehicleAltControlStickSmoothInTime;
        [NMS(Index = 190)]
        /* 0xE3C */ public float VehicleAltControlStickSmoothOutTime;
        [NMS(Index = 275)]
        /* 0xE40 */ public float VehicleBoostFuelRate;
        [NMS(Index = 276)]
        /* 0xE44 */ public float VehicleBoostFuelRateSurvival;
        [NMS(Index = 191)]
        /* 0xE48 */ public float VehicleBoostSpeedMultiplierPercent;
        [NMS(Index = 0)]
        /* 0xE4C */ public float VehicleCollisionScaleFactor;
        [NMS(Index = 274)]
        /* 0xE50 */ public float VehicleDeactivateRange;
        [NMS(Index = 270)]
        /* 0xE54 */ public float VehicleFadeTime;
        [NMS(Index = 277)]
        /* 0xE58 */ public float VehicleFuelRate;
        [NMS(Index = 278)]
        /* 0xE5C */ public float VehicleFuelRateTruckMultiplier;
        [NMS(Index = 193)]
        /* 0xE60 */ public float VehicleGarageHologramFadeRange;
        [NMS(Index = 192)]
        /* 0xE64 */ public float VehicleGarageHologramMinFadeRange;
        [NMS(Index = 281)]
        /* 0xE68 */ public float VehicleJumpCooldown;
        [NMS(Index = 280)]
        /* 0xE6C */ public float VehicleJumpTimeMax;
        [NMS(Index = 279)]
        /* 0xE70 */ public float VehicleJumpTimeMin;
        [NMS(Index = 272)]
        /* 0xE74 */ public float VehicleMaxSummonDistance;
        [NMS(Index = 273)]
        /* 0xE78 */ public float VehicleMaxSummonDistanceUnderwater;
        [NMS(Index = 271)]
        /* 0xE7C */ public float VehicleMinSummonDistance;
        [NMS(Index = 282)]
        /* 0xE80 */ public float VehicleMotionDeadZone;
        [NMS(Index = 2)]
        /* 0xE84 */ public float VehicleSolarRegenFactor;
        [NMS(Index = 267)]
        /* 0xE88 */ public float VehicleSuspensionAudioDelay;
        [NMS(Index = 268)]
        /* 0xE8C */ public float VehicleSuspensionAudioScale;
        [NMS(Index = 266)]
        /* 0xE90 */ public float VehicleSuspensionAudioSpacing;
        [NMS(Index = 269)]
        /* 0xE94 */ public float VehicleSuspensionAudioTrigger;
        [NMS(Index = 263)]
        /* 0xE98 */ public float VehicleTextSize;
        [NMS(Index = 254)]
        /* 0xE9C */ public float VehicleWheelNoise;
        [NMS(Index = 255)]
        /* 0xEA0 */ public float VehicleWheelNoiseScale;
        [NMS(Index = 32)]
        /* 0xEA4 */ public float VignetteAmountAcceleration;
        [NMS(Index = 33)]
        /* 0xEA8 */ public float VignetteAmountTurning;
        [NMS(Index = 30)]
        /* 0xEAC */ public float VisualRollUnderwaterSpring;
        [NMS(Index = 31)]
        /* 0xEB0 */ public float VisualTurnSpring;
        [NMS(Index = 29)]
        /* 0xEB4 */ public float VisualTurnUnderwaterSpring;
        [NMS(Index = 156)]
        /* 0xEB8 */ public float WeaponInterpSpeed;
        [NMS(Index = 35)]
        /* 0xEBC */ public float WheelDustColourLightFactor;
        [NMS(Index = 283)]
        /* 0xEC0 */ public float WheelForceHalflife;
        [NMS(Index = 256)]
        /* 0xEC4 */ public float WheelSideVerticalFactor;
        [NMS(Index = 153, Size = 0x5, EnumType = typeof(GcMechWeaponLocation.MechWeaponLocationEnum))]
        /* 0xEC8 */ public NMSString0x20[] MechWeaponLocatorNames;
        [NMS(Index = 46)]
        /* 0xF68 */ public bool MechAltJumpMode;
        [NMS(Index = 77)]
        /* 0xF69 */ public TkCurveType MechArmSwingCurveFastWalk;
        [NMS(Index = 74)]
        /* 0xF6A */ public TkCurveType MechArmSwingCurveWalk;
        [NMS(Index = 40)]
        /* 0xF6B */ public bool MechCanUpdateMeshWhileMaintenanceUIActive;
        [NMS(Index = 107)]
        /* 0xF6C */ public bool MechFirstPersonTurretTweaksEnabled;
        [NMS(Index = 45)]
        /* 0xF6D */ public bool MechStrafeEnabled;
        [NMS(Index = 128)]
        /* 0xF6E */ public bool MechTitanFallTerrainEditEnabled;
        [NMS(Index = 230)]
        /* 0xF6F */ public bool RaceFinishAtStart;
        [NMS(Index = 14)]
        /* 0xF70 */ public bool ShowAllCheckpoints;
        [NMS(Index = 259)]
        /* 0xF71 */ public bool ShowTempVehicleMesh;
        [NMS(Index = 260)]
        /* 0xF72 */ public bool ShowVehicleDebugging;
        [NMS(Index = 264)]
        /* 0xF73 */ public bool ShowVehicleParticleDebug;
        [NMS(Index = 262)]
        /* 0xF74 */ public bool ShowVehicleText;
        [NMS(Index = 261)]
        /* 0xF75 */ public bool ShowVehicleWheelGuards;
        [NMS(Index = 21)]
        /* 0xF76 */ public TkCurveType SteeringWheelOutputCurve;
        [NMS(Index = 25)]
        /* 0xF77 */ public bool TestAnims;
        [NMS(Index = 284)]
        /* 0xF78 */ public bool ThrottleButtonCamRelative;
        [NMS(Index = 174)]
        /* 0xF79 */ public TkCurveType UnderwaterBuoyancyDepthCurve;
        [NMS(Index = 12)]
        /* 0xF7A */ public bool UseFirstPersonCamera;
        [NMS(Index = 188)]
        /* 0xF7B */ public bool VehicleAltControlScheme;
        [NMS(Index = 265)]
        /* 0xF7C */ public bool VehicleDrawAudioDebug;
    }
}
