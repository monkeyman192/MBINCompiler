using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xEAADE228C92E39EE, NameHash = 0xC45203411E9AFE95)]
    public class GcSpaceshipGlobals : NMSTemplate
    {
        [NMS(Index = 190)]
        /* 0x0000 */ public GcScanEffectData ShieldEffectScanData;
        [NMS(Index = 328)]
        /* 0x0050 */ public Colour AlarmLightColour;
        [NMS(Index = 329)]
        /* 0x0060 */ public Colour AlarmLightColourHostile;
        [NMS(Index = 107)]
        /* 0x0070 */ public Vector3f AtmosphereLightOffset;
        [NMS(Index = 590)]
        /* 0x0080 */ public Vector3f CockpitScale;
        [NMS(Index = 392)]
        /* 0x0090 */ public Colour DamageLightColour;
        [NMS(Index = 391)]
        /* 0x00A0 */ public Colour DamageLightColourShield;
        [NMS(Index = 387)]
        /* 0x00B0 */ public Vector3f DamageLightOffsetLeft;
        [NMS(Index = 388)]
        /* 0x00C0 */ public Vector3f DamageLightOffsetRight;
        [NMS(Index = 386)]
        /* 0x00D0 */ public Vector3f DamageLightOffsetTop;
        [NMS(Index = 236)]
        /* 0x00E0 */ public Vector3f DefaultCentreOffset;
        [NMS(Index = 237)]
        /* 0x00F0 */ public Vector3f DefaultCentreOffsetDropship;
        [NMS(Index = 239)]
        /* 0x0100 */ public Vector3f DefaultCentreOffsetRoyal;
        [NMS(Index = 240)]
        /* 0x0110 */ public Vector3f DefaultCentreOffsetSail;
        [NMS(Index = 238)]
        /* 0x0120 */ public Vector3f DefaultCentreOffsetScientific;
        [NMS(Index = 144)]
        /* 0x0130 */ public Colour DirectionDockingInRangeColour;
        [NMS(Index = 145)]
        /* 0x0140 */ public Colour DirectionDockingOutRangeColour;
        [NMS(Index = 101)]
        /* 0x0150 */ public Colour GroundEffectBuildingColour;
        [NMS(Index = 102)]
        /* 0x0160 */ public Colour GroundEffectWaterColour;
        [NMS(Index = 571)]
        /* 0x0170 */ public Vector3f GunOffset3rdPersonLeft;
        [NMS(Index = 572)]
        /* 0x0180 */ public Vector3f GunOffset3rdPersonRight;
        [NMS(Index = 567)]
        /* 0x0190 */ public Vector3f GunOffsetLeft;
        [NMS(Index = 569)]
        /* 0x01A0 */ public Vector3f GunOffsetLeft2;
        [NMS(Index = 568)]
        /* 0x01B0 */ public Vector3f GunOffsetRight;
        [NMS(Index = 570)]
        /* 0x01C0 */ public Vector3f GunOffsetRight2;
        [NMS(Index = 47)]
        /* 0x01D0 */ public Vector3f HandControllerDeadZone;
        [NMS(Index = 48)]
        /* 0x01E0 */ public Vector3f HandControllerExtents;
        [NMS(Index = 45)]
        /* 0x01F0 */ public Vector3f HandControllerValueMultiplier;
        [NMS(Index = 46)]
        /* 0x0200 */ public Vector3f HandControllerValueMultiplierSpace;
        [NMS(Index = 100)]
        /* 0x0210 */ public Colour LandingEffectSpaceColourOverride;
        [NMS(Index = 385)]
        /* 0x0220 */ public Colour MuzzleLightColour;
        [NMS(Index = 270)]
        /* 0x0230 */ public Vector3f PostCollisionAngularFactor;
        [NMS(Index = 642)]
        /* 0x0240 */ public Vector3f StickAnimationDamping;
        [NMS(Index = 354)]
        /* 0x0250 */ public Colour TargetLockDangerColour;
        [NMS(Index = 353)]
        /* 0x0260 */ public Colour TargetLockPassiveColour;
        [NMS(Index = 330)]
        /* 0x0270 */ public List<Vector3f> AlarmLightOffsets;
        [NMS(Index = 440)]
        /* 0x0280 */ public List<GcPlayerSpaceshipAim> GunAimArray;
        [NMS(Index = 438)]
        /* 0x0290 */ public List<GcPlayerSpaceshipAim> LaserAimArray;
        [NMS(Index = 7)]
        /* 0x02A0 */ public NMSString0x10 SailShipCoreTechID;
        [NMS(Index = 629)]
        /* 0x02B0 */ public List<NMSString0x80> ShipModels;
        [NMS(Index = 309)]
        /* 0x02C0 */ public GcPlayerSpaceshipControlData Control;
        [NMS(Index = 311)]
        /* 0x04D8 */ public GcPlayerSpaceshipControlData ControlHeavy;
        [NMS(Index = 312)]
        /* 0x06F0 */ public GcPlayerSpaceshipControlData ControlHover;
        [NMS(Index = 310)]
        /* 0x0908 */ public GcPlayerSpaceshipControlData ControlLight;
        [NMS(Index = 315)]
        /* 0x0B20 */ public GcPlayerSpaceshipClassBonuses ControlBonusA;
        [NMS(Index = 314)]
        /* 0x0B50 */ public GcPlayerSpaceshipClassBonuses ControlBonusB;
        [NMS(Index = 313)]
        /* 0x0B80 */ public GcPlayerSpaceshipClassBonuses ControlBonusC;
        [NMS(Index = 316)]
        /* 0x0BB0 */ public GcPlayerSpaceshipClassBonuses ControlBonusS;
        [NMS(Index = 168)]
        /* 0x0BE0 */ public GcSpaceshipAvoidanceData Avoidance;
        [NMS(Index = 430)]
        /* 0x0C04 */ public GcPlayerStickData StickData;
        [NMS(Index = 444)]
        /* 0x0C20 */ public GcPlayerSpaceshipAim MissileAim;
        [NMS(Index = 573)]
        /* 0x0C38 */ public GcPlayerSpaceshipWarpData Warp;
        [NMS(Index = 390)]
        /* 0x0C48 */ public TkHitCurveData DamageLightCurve;
        [NMS(Index = 384)]
        /* 0x0C54 */ public TkHitCurveData MuzzleLightCurve;
        [NMS(Index = 421)]
        /* 0x0C60 */ public Vector2f DeathSpinPitch;
        [NMS(Index = 420)]
        /* 0x0C68 */ public Vector2f DeathSpinRoll;
        [NMS(Index = 201)]
        /* 0x0C70 */ public float _3rdPersonAngleMinSpeed;
        [NMS(Index = 202)]
        /* 0x0C74 */ public float _3rdPersonAngleSpeedRangePitch;
        [NMS(Index = 203)]
        /* 0x0C78 */ public float _3rdPersonAngleSpeedRangeYaw;
        [NMS(Index = 200)]
        /* 0x0C7C */ public float _3rdPersonAngleSpringTime;
        [NMS(Index = 209)]
        /* 0x0C80 */ public float _3rdPersonAvoidanceAdjustPitchFactor;
        [NMS(Index = 211)]
        /* 0x0C84 */ public float _3rdPersonAvoidanceAdjustRollFactor;
        [NMS(Index = 212)]
        /* 0x0C88 */ public float _3rdPersonAvoidanceAdjustYawFactor;
        [NMS(Index = 214)]
        /* 0x0C8C */ public float _3rdPersonFlashDuration;
        [NMS(Index = 213)]
        /* 0x0C90 */ public float _3rdPersonFlashIntensity;
        [NMS(Index = 210)]
        /* 0x0C94 */ public float _3rdPersonHeightForceAdjustPitchFactor;
        [NMS(Index = 205)]
        /* 0x0C98 */ public float _3rdPersonLowHeightMax;
        [NMS(Index = 204)]
        /* 0x0C9C */ public float _3rdPersonLowHeightMin;
        [NMS(Index = 206)]
        /* 0x0CA0 */ public float _3rdPersonLowHeightOffsetVertRotationY;
        [NMS(Index = 207)]
        /* 0x0CA4 */ public float _3rdPersonLowHeightOffsetY;
        [NMS(Index = 208)]
        /* 0x0CA8 */ public float _3rdPersonLowHeightSpringTime;
        [NMS(Index = 197)]
        /* 0x0CAC */ public float _3rdPersonPitchAngle;
        [NMS(Index = 193)]
        /* 0x0CB0 */ public float _3rdPersonRollAngle;
        [NMS(Index = 196)]
        /* 0x0CB4 */ public float _3rdPersonRollAngleAlien;
        [NMS(Index = 194)]
        /* 0x0CB8 */ public float _3rdPersonRollAngleDropship;
        [NMS(Index = 195)]
        /* 0x0CBC */ public float _3rdPersonRollAngleScience;
        [NMS(Index = 215)]
        /* 0x0CC0 */ public float _3rdPersonTransitionTime;
        [NMS(Index = 192)]
        /* 0x0CC4 */ public float _3rdPersonUpOffsetRollChangeSpeed;
        [NMS(Index = 220)]
        /* 0x0CC8 */ public float _3rdPersonWarpWanderSpring;
        [NMS(Index = 219)]
        /* 0x0CCC */ public float _3rdPersonWarpWanderStartTime;
        [NMS(Index = 221)]
        /* 0x0CD0 */ public float _3rdPersonWarpWanderTimeX;
        [NMS(Index = 222)]
        /* 0x0CD4 */ public float _3rdPersonWarpWanderTimeY;
        [NMS(Index = 223)]
        /* 0x0CD8 */ public float _3rdPersonWarpWanderTimeZ;
        [NMS(Index = 216)]
        /* 0x0CDC */ public float _3rdPersonWarpXWander;
        [NMS(Index = 217)]
        /* 0x0CE0 */ public float _3rdPersonWarpYWander;
        [NMS(Index = 218)]
        /* 0x0CE4 */ public float _3rdPersonWarpZWander;
        [NMS(Index = 198)]
        /* 0x0CE8 */ public float _3rdPersonYawAngle;
        [NMS(Index = 199)]
        /* 0x0CEC */ public float _3rdPersonYawAngleLateralExtra;
        [NMS(Index = 191)]
        /* 0x0CF0 */ public float AcrobaticLowFlightLevel;
        [NMS(Index = 396)]
        /* 0x0CF4 */ public float AimCritAngle;
        [NMS(Index = 398)]
        /* 0x0CF8 */ public float AimCritBehindAngle;
        [NMS(Index = 397)]
        /* 0x0CFC */ public float AimCritMinFwdAngle;
        [NMS(Index = 408)]
        /* 0x0D00 */ public float AimFoVBoost;
        [NMS(Index = 409)]
        /* 0x0D04 */ public float AimFoVBoostTime;
        [NMS(Index = 410)]
        /* 0x0D08 */ public float AimFoVBoostTimeAuto;
        [NMS(Index = 412)]
        /* 0x0D0C */ public float AimMaxAutoAngle;
        [NMS(Index = 432)]
        /* 0x0D10 */ public float AimSpeedTrackDistance;
        [NMS(Index = 433)]
        /* 0x0D14 */ public float AimSpeedTrackForce;
        [NMS(Index = 411)]
        /* 0x0D18 */ public float AimTurnSlower;
        [NMS(Index = 336)]
        /* 0x0D1C */ public float AlarmLastHitTime;
        [NMS(Index = 331)]
        /* 0x0D20 */ public float AlarmLightIntensity;
        [NMS(Index = 333)]
        /* 0x0D24 */ public float AlarmLightIntensityHostile;
        [NMS(Index = 332)]
        /* 0x0D28 */ public float AlarmRate;
        [NMS(Index = 335)]
        /* 0x0D2C */ public float AlarmRateHostileMax;
        [NMS(Index = 334)]
        /* 0x0D30 */ public float AlarmRateHostileMin;
        [NMS(Index = 558)]
        /* 0x0D34 */ public float AngularDamping;
        [NMS(Index = 514)]
        /* 0x0D38 */ public float AnomalyStationMaxApproachSpeed;
        [NMS(Index = 394)]
        /* 0x0D3C */ public float AsteroidHitAngle;
        [NMS(Index = 395)]
        /* 0x0D40 */ public float AsteroidHitAngleBoosting;
        [NMS(Index = 581)]
        /* 0x0D44 */ public float AtmosphereAngle;
        [NMS(Index = 6)]
        /* 0x0D48 */ public float AtmosphereCombatHeight;
        [NMS(Index = 106)]
        /* 0x0D4C */ public float AtmosphereLightIntensity;
        [NMS(Index = 580)]
        /* 0x0D50 */ public float AtmosphereSpeed;
        [NMS(Index = 344)]
        /* 0x0D54 */ public float AutoLevelMaxAngle;
        [NMS(Index = 342)]
        /* 0x0D58 */ public float AutoLevelMaxPitchAngle;
        [NMS(Index = 343)]
        /* 0x0D5C */ public float AutoLevelMinAngle;
        [NMS(Index = 341)]
        /* 0x0D60 */ public float AutoLevelMinPitchAngle;
        [NMS(Index = 269)]
        /* 0x0D64 */ public float AutoLevelPitchCorrectMargin;
        [NMS(Index = 268)]
        /* 0x0D68 */ public float AutoLevelWaterAngle;
        [NMS(Index = 266)]
        /* 0x0D6C */ public float AutoLevelWaterMargin;
        [NMS(Index = 267)]
        /* 0x0D70 */ public float AutoLevelWaterTorque;
        [NMS(Index = 447)]
        /* 0x0D74 */ public float AutoPilotAlignStrength;
        [NMS(Index = 451)]
        /* 0x0D78 */ public float AutoPilotCallAngle;
        [NMS(Index = 452)]
        /* 0x0D7C */ public float AutoPilotCallAngleVertical;
        [NMS(Index = 449)]
        /* 0x0D80 */ public float AutoPilotCallDistance;
        [NMS(Index = 450)]
        /* 0x0D84 */ public float AutoPilotCallDistanceSpacePOI;
        [NMS(Index = 453)]
        /* 0x0D88 */ public float AutoPilotPositionAlignStrength;
        [NMS(Index = 448)]
        /* 0x0D8C */ public float AutoPilotSmallShipAlignStrength;
        [NMS(Index = 233)]
        /* 0x0D90 */ public float AvoidanceDistancePower;
        [NMS(Index = 232)]
        /* 0x0D94 */ public float AvoidancePower;
        [NMS(Index = 527)]
        /* 0x0D98 */ public float BoostChargeRate;
        [NMS(Index = 494)]
        /* 0x0D9C */ public float BoostNoAsteroidRadius;
        [NMS(Index = 375)]
        /* 0x0DA0 */ public float CameraPostWarpFov;
        [NMS(Index = 374)]
        /* 0x0DA4 */ public float CameraPostWarpFovTime;
        [NMS(Index = 63)]
        /* 0x0DA8 */ public float CockpitDriftAngle;
        [NMS(Index = 60)]
        /* 0x0DAC */ public float CockpitDriftAngleHmd;
        [NMS(Index = 88)]
        /* 0x0DB0 */ public float CockpitExitAnimMul;
        [NMS(Index = 90)]
        /* 0x0DB4 */ public float CockpitExitAnimOffset;
        [NMS(Index = 89)]
        /* 0x0DB8 */ public float CockpitExitAnimTime;
        [NMS(Index = 62)]
        /* 0x0DBC */ public float CockpitPitchCorrectAngle;
        [NMS(Index = 59)]
        /* 0x0DC0 */ public float CockpitPitchCorrectAngleHmd;
        [NMS(Index = 61)]
        /* 0x0DC4 */ public float CockpitRollAngle;
        [NMS(Index = 64)]
        /* 0x0DC8 */ public float CockpitRollAngleExtra;
        [NMS(Index = 58)]
        /* 0x0DCC */ public float CockpitRollAngleHmd;
        [NMS(Index = 66)]
        /* 0x0DD0 */ public float CockpitRollMultiplierCentre;
        [NMS(Index = 67)]
        /* 0x0DD4 */ public float CockpitRollMultiplierOpposite;
        [NMS(Index = 65)]
        /* 0x0DD8 */ public float CockpitRollTime;
        [NMS(Index = 235)]
        /* 0x0DDC */ public float CollisionAlignStrength;
        [NMS(Index = 537)]
        /* 0x0DE0 */ public float CollisionAsteroidDamp;
        [NMS(Index = 535)]
        /* 0x0DE4 */ public float CollisionDeflectDamping;
        [NMS(Index = 234)]
        /* 0x0DE8 */ public float CollisionDeflectForce;
        [NMS(Index = 536)]
        /* 0x0DEC */ public float CollisionDeflectNormalFactor;
        [NMS(Index = 534)]
        /* 0x0DF0 */ public float CollisionDeflectTime;
        [NMS(Index = 539)]
        /* 0x0DF4 */ public float CollisionDistance;
        [NMS(Index = 541)]
        /* 0x0DF8 */ public float CollisionDistanceAsteroid;
        [NMS(Index = 542)]
        /* 0x0DFC */ public float CollisionDistanceAsteroidSide;
        [NMS(Index = 540)]
        /* 0x0E00 */ public float CollisionDistanceGround;
        [NMS(Index = 543)]
        /* 0x0E04 */ public float CollisionDistanceSpaceships;
        [NMS(Index = 538)]
        /* 0x0E08 */ public float CollisionGroundDamp;
        [NMS(Index = 548)]
        /* 0x0E0C */ public float CollisionRadiusMultiplier;
        [NMS(Index = 533)]
        /* 0x0E10 */ public float CollisionSpeedDamageAmount;
        [NMS(Index = 434)]
        /* 0x0E14 */ public float CombatBoostMultiplier;
        [NMS(Index = 435)]
        /* 0x0E18 */ public float CombatBoostTurnDamp;
        [NMS(Index = 184)]
        /* 0x0E1C */ public float ContrailDefaultAlpha;
        [NMS(Index = 173)]
        /* 0x0E20 */ public float ContrailSpeedDamping;
        [NMS(Index = 404)]
        /* 0x0E24 */ public float CruiseForce;
        [NMS(Index = 400)]
        /* 0x0E28 */ public float CruiseHeight;
        [NMS(Index = 401)]
        /* 0x0E2C */ public float CruiseHeightRange;
        [NMS(Index = 402)]
        /* 0x0E30 */ public float CruiseOffAngle;
        [NMS(Index = 403)]
        /* 0x0E34 */ public float CruiseOffAngleRange;
        [NMS(Index = 273)]
        /* 0x0E38 */ public float DamageFlashMin;
        [NMS(Index = 272)]
        /* 0x0E3C */ public float DamageFlashScale;
        [NMS(Index = 389)]
        /* 0x0E40 */ public float DamageLightIntensity;
        [NMS(Index = 529)]
        /* 0x0E44 */ public float DamageMaxHitTime;
        [NMS(Index = 528)]
        /* 0x0E48 */ public float DamageMinHitTime;
        [NMS(Index = 530)]
        /* 0x0E4C */ public float DamageMinWoundTime;
        [NMS(Index = 169)]
        /* 0x0E50 */ public float DefaultTrailInitialSpeed;
        [NMS(Index = 171)]
        /* 0x0E54 */ public float DefaultTrailMinForwardSpeed;
        [NMS(Index = 170)]
        /* 0x0E58 */ public float DefaultTrailSpeedDamping;
        [NMS(Index = 546)]
        /* 0x0E5C */ public float DeflectAlignTimeMax;
        [NMS(Index = 545)]
        /* 0x0E60 */ public float DeflectAlignTimeMin;
        [NMS(Index = 544)]
        /* 0x0E64 */ public float DeflectDistance;
        [NMS(Index = 242)]
        /* 0x0E68 */ public float DirectionBrakeVerticalMultiplier;
        [NMS(Index = 380)]
        /* 0x0E6C */ public float DirectionBrakeVRBoost;
        [NMS(Index = 559)]
        /* 0x0E70 */ public float DirectionDockingAngle;
        [NMS(Index = 146)]
        /* 0x0E74 */ public float DirectionDockingCircleOffset;
        [NMS(Index = 147)]
        /* 0x0E78 */ public float DirectionDockingCircleOffsetExtra;
        [NMS(Index = 149)]
        /* 0x0E7C */ public float DirectionDockingCircleRadius;
        [NMS(Index = 150)]
        /* 0x0E80 */ public float DirectionDockingCircleRadiusExtra;
        [NMS(Index = 148)]
        /* 0x0E84 */ public float DirectionDockingCircleWidth;
        [NMS(Index = 141)]
        /* 0x0E88 */ public float DirectionDockingIndicatorAngleRange;
        [NMS(Index = 140)]
        /* 0x0E8C */ public float DirectionDockingIndicatorClearAngleRange;
        [NMS(Index = 143)]
        /* 0x0E90 */ public float DirectionDockingIndicatorMaxHeight;
        [NMS(Index = 142)]
        /* 0x0E94 */ public float DirectionDockingIndicatorMinHeight;
        [NMS(Index = 139)]
        /* 0x0E98 */ public float DirectionDockingIndicatorRange;
        [NMS(Index = 151)]
        /* 0x0E9C */ public float DirectionDockingIndicatorSpeed;
        [NMS(Index = 561)]
        /* 0x0EA0 */ public float DirectionDockingInfoRange;
        [NMS(Index = 560)]
        /* 0x0EA4 */ public float DirectionDockTime;
        [NMS(Index = 70)]
        /* 0x0EA8 */ public float DistanceFromShipToAllowSpawningOnFreighter;
        [NMS(Index = 13)]
        /* 0x0EAC */ public float DockingApproachBrakeHmdMod;
        [NMS(Index = 11)]
        /* 0x0EB0 */ public float DockingApproachRollHmdMod;
        [NMS(Index = 12)]
        /* 0x0EB4 */ public float DockingApproachSpeedHmdMod;
        [NMS(Index = 98)]
        /* 0x0EB8 */ public float DockingAttractAlign;
        [NMS(Index = 99)]
        /* 0x0EBC */ public float DockingAttractAlignRange;
        [NMS(Index = 574)]
        /* 0x0EC0 */ public float DockingRotateSpeed;
        [NMS(Index = 575)]
        /* 0x0EC4 */ public float DockingRotateSpeedVR;
        [NMS(Index = 271)]
        /* 0x0EC8 */ public float DrawLineLockTargetLineWidth;
        [NMS(Index = 370)]
        /* 0x0ECC */ public float DriftEffectIntensity;
        [NMS(Index = 377)]
        /* 0x0ED0 */ public float DriftSpring;
        [NMS(Index = 379)]
        /* 0x0ED4 */ public float DriftTurnBrakeMultiplier;
        [NMS(Index = 378)]
        /* 0x0ED8 */ public float DriftTurnStrengthMultiplier;
        [NMS(Index = 619)]
        /* 0x0EDC */ public float DroneAlertAngle;
        [NMS(Index = 620)]
        /* 0x0EE0 */ public float DroneAlertRange;
        [NMS(Index = 582)]
        /* 0x0EE4 */ public float DroneAlignUpTime;
        [NMS(Index = 583)]
        /* 0x0EE8 */ public float DroneDustHeight;
        [NMS(Index = 585)]
        /* 0x0EEC */ public float DroneHeightAdjust;
        [NMS(Index = 584)]
        /* 0x0EF0 */ public float DroneMinHeight;
        [NMS(Index = 622)]
        /* 0x0EF4 */ public float DroneMoveArrivedRange;
        [NMS(Index = 621)]
        /* 0x0EF8 */ public float DronePatrolRadius;
        [NMS(Index = 623)]
        /* 0x0EFC */ public float DronePatrolTime;
        [NMS(Index = 617)]
        /* 0x0F00 */ public float DronePlanetAttackMinRange;
        [NMS(Index = 616)]
        /* 0x0F04 */ public float DronePlanetAttackRange;
        [NMS(Index = 618)]
        /* 0x0F08 */ public float DroneShootTime;
        [NMS(Index = 589)]
        /* 0x0F0C */ public float DroneWarpMaxForce;
        [NMS(Index = 588)]
        /* 0x0F10 */ public float DroneWarpMinForce;
        [NMS(Index = 587)]
        /* 0x0F14 */ public float DroneWarpTime;
        [NMS(Index = 577)]
        /* 0x0F18 */ public float EjectAnimSpeedFactor;
        [NMS(Index = 576)]
        /* 0x0F1C */ public float EjectAnimSwitchPoint;
        [NMS(Index = 186)]
        /* 0x0F20 */ public float EngineEffectsThrustContribution;
        [NMS(Index = 185)]
        /* 0x0F24 */ public float EngineJetLightIntensityMultiplier;
        [NMS(Index = 153)]
        /* 0x0F28 */ public float ExhaustSpeed;
        [NMS(Index = 326)]
        /* 0x0F2C */ public float ExplorerTakeOffMod;
        [NMS(Index = 324)]
        /* 0x0F30 */ public float FighterTakeOffMod;
        [NMS(Index = 455)]
        /* 0x0F34 */ public float FreighterApproachCombatDistanceMax;
        [NMS(Index = 454)]
        /* 0x0F38 */ public float FreighterApproachCombatDistanceMin;
        [NMS(Index = 464)]
        /* 0x0F3C */ public float FreighterApproachCombatMinSpeedFactor;
        [NMS(Index = 457)]
        /* 0x0F40 */ public float FreighterApproachDistanceMax;
        [NMS(Index = 456)]
        /* 0x0F44 */ public float FreighterApproachDistanceMin;
        [NMS(Index = 463)]
        /* 0x0F48 */ public float FreighterApproachExtraMargin;
        [NMS(Index = 461)]
        /* 0x0F4C */ public float FreighterApproachExtraMarginCombat;
        [NMS(Index = 462)]
        /* 0x0F50 */ public float FreighterApproachExtraMarginPirate;
        [NMS(Index = 458)]
        /* 0x0F54 */ public float FreighterApproachSpeedDamper;
        [NMS(Index = 71)]
        /* 0x0F58 */ public float FreighterBattleIgnoreFriendlyFireDistance;
        [NMS(Index = 1)]
        /* 0x0F5C */ public float FreighterBattleRangeBoost;
        [NMS(Index = 460)]
        /* 0x0F60 */ public float FreighterCombatBoostMul;
        [NMS(Index = 459)]
        /* 0x0F64 */ public float FreighterCombatSpeedMul;
        [NMS(Index = 586)]
        /* 0x0F68 */ public float FreighterSpeed;
        [NMS(Index = 347)]
        /* 0x0F6C */ public float FrigateTargetLockRange;
        [NMS(Index = 429)]
        /* 0x0F70 */ public float GravityDropForce;
        [NMS(Index = 427)]
        /* 0x0F74 */ public float GravityDropMaxForceHeight;
        [NMS(Index = 428)]
        /* 0x0F78 */ public float GravityDropMaxHeight;
        [NMS(Index = 426)]
        /* 0x0F7C */ public float GravityDropMinHeight;
        [NMS(Index = 286)]
        /* 0x0F80 */ public float GroundHeightBrakeMultiplier;
        [NMS(Index = 285)]
        /* 0x0F84 */ public float GroundHeightDownSpeedMultiplier;
        [NMS(Index = 280)]
        /* 0x0F88 */ public float GroundHeightHard;
        [NMS(Index = 281)]
        /* 0x0F8C */ public float GroundHeightHardHorizontal;
        [NMS(Index = 550)]
        /* 0x0F90 */ public float GroundHeightHardTimeMax;
        [NMS(Index = 549)]
        /* 0x0F94 */ public float GroundHeightHardTimeMin;
        [NMS(Index = 555)]
        /* 0x0F98 */ public int GroundHeightNumRays;
        [NMS(Index = 551)]
        /* 0x0F9C */ public float GroundHeightPostCollisionDamper;
        [NMS(Index = 283)]
        /* 0x0FA0 */ public float GroundHeightPostCollisionMultiplier;
        [NMS(Index = 284)]
        /* 0x0FA4 */ public float GroundHeightPostCollisionMultiplierTime;
        [NMS(Index = 556)]
        /* 0x0FA8 */ public float GroundHeightSmoothTime;
        [NMS(Index = 277)]
        /* 0x0FAC */ public float GroundHeightSoft;
        [NMS(Index = 276)]
        /* 0x0FB0 */ public float GroundHeightSoftForce;
        [NMS(Index = 278)]
        /* 0x0FB4 */ public float GroundHeightSoftHorizontal;
        [NMS(Index = 553)]
        /* 0x0FB8 */ public float GroundHeightSpeedAngle;
        [NMS(Index = 554)]
        /* 0x0FBC */ public float GroundHeightSpeedAngleRange;
        [NMS(Index = 552)]
        /* 0x0FC0 */ public float GroundHeightSpeedLength;
        [NMS(Index = 161)]
        /* 0x0FC4 */ public float GroundNearEffectBuildingFade;
        [NMS(Index = 158)]
        /* 0x0FC8 */ public float GroundNearEffectHeight;
        [NMS(Index = 103)]
        /* 0x0FCC */ public float GroundNearEffectLightFactor;
        [NMS(Index = 160)]
        /* 0x0FD0 */ public float GroundNearEffectNormalOffset;
        [NMS(Index = 159)]
        /* 0x0FD4 */ public float GroundNearEffectRange;
        [NMS(Index = 104)]
        /* 0x0FD8 */ public float GroundNearEffectWaterLightFactor;
        [NMS(Index = 105)]
        /* 0x0FDC */ public float GroundWaterSpeedFactor;
        [NMS(Index = 443)]
        /* 0x0FE0 */ public int GunAimLevel;
        [NMS(Index = 437)]
        /* 0x0FE4 */ public int GunAmmoMultiplier;
        [NMS(Index = 566)]
        /* 0x0FE8 */ public float GunOffset3rdPersonMultiplier;
        [NMS(Index = 43)]
        /* 0x0FEC */ public float HandControllerActiveBlendMinTime;
        [NMS(Index = 44)]
        /* 0x0FF0 */ public float HandControllerActiveBlendTime;
        [NMS(Index = 56)]
        /* 0x0FF4 */ public float HandControllerDirOffsetAngle;
        [NMS(Index = 57)]
        /* 0x0FF8 */ public float HandControllerDirOffsetAngleMove;
        [NMS(Index = 55)]
        /* 0x0FFC */ public float HandControllerThrottleDeadZone;
        [NMS(Index = 53)]
        /* 0x1000 */ public float HandControllerThrottleDistance;
        [NMS(Index = 54)]
        /* 0x1004 */ public float HandControllerThrottleRange;
        [NMS(Index = 51)]
        /* 0x1008 */ public float HandControllerXReorientation;
        [NMS(Index = 49)]
        /* 0x100C */ public float HandControllerXReorientationMove;
        [NMS(Index = 52)]
        /* 0x1010 */ public float HandControllerZReorientation;
        [NMS(Index = 50)]
        /* 0x1014 */ public float HandControllerZReorientationMove;
        [NMS(Index = 323)]
        /* 0x1018 */ public float HaulerTakeOffMod;
        [NMS(Index = 373)]
        /* 0x101C */ public int HitAsteroidDamage;
        [NMS(Index = 250)]
        /* 0x1020 */ public float HoverAlignTime;
        [NMS(Index = 252)]
        /* 0x1024 */ public float HoverAlignTimeAlt;
        [NMS(Index = 413)]
        /* 0x1028 */ public float HoverBrakeStrength;
        [NMS(Index = 254)]
        /* 0x102C */ public float HoverHeightFactor;
        [NMS(Index = 262)]
        /* 0x1030 */ public float HoverLandManeuvreBrake;
        [NMS(Index = 261)]
        /* 0x1034 */ public float HoverLandManeuvreTimeHmdMax;
        [NMS(Index = 260)]
        /* 0x1038 */ public float HoverLandManeuvreTimeHmdMin;
        [NMS(Index = 259)]
        /* 0x103C */ public float HoverLandManeuvreTimeMax;
        [NMS(Index = 258)]
        /* 0x1040 */ public float HoverLandManeuvreTimeMin;
        [NMS(Index = 257)]
        /* 0x1044 */ public float HoverLandReachedDistance;
        [NMS(Index = 256)]
        /* 0x1048 */ public float HoverLandReachedMinTime;
        [NMS(Index = 405)]
        /* 0x104C */ public float HoverMaxSpeed;
        [NMS(Index = 255)]
        /* 0x1050 */ public float HoverMinSpeed;
        [NMS(Index = 253)]
        /* 0x1054 */ public float HoverSpeedFactor;
        [NMS(Index = 406)]
        /* 0x1058 */ public float HoverStopTime;
        [NMS(Index = 248)]
        /* 0x105C */ public float HoverTakeoffHeight;
        [NMS(Index = 249)]
        /* 0x1060 */ public float HoverTime;
        [NMS(Index = 251)]
        /* 0x1064 */ public float HoverTimeAlt;
        [NMS(Index = 630)]
        /* 0x1068 */ public float HUDBoostUpgradeMultiplier;
        [NMS(Index = 247)]
        /* 0x106C */ public float KBThrustSmoothTime;
        [NMS(Index = 517)]
        /* 0x1070 */ public float LandGroundTakeOffTime;
        [NMS(Index = 519)]
        /* 0x1074 */ public float LandHeightThreshold;
        [NMS(Index = 523)]
        /* 0x1078 */ public float LandingAreaFloorOffset;
        [NMS(Index = 522)]
        /* 0x107C */ public float LandingAreaRadius;
        [NMS(Index = 274)]
        /* 0x1080 */ public float LandingButtonMinTime;
        [NMS(Index = 265)]
        /* 0x1084 */ public float LandingCheckBuildingRadiusFactor;
        [NMS(Index = 442)]
        /* 0x1088 */ public int LandingCost;
        [NMS(Index = 14)]
        /* 0x108C */ public float LandingDirectionalSideOffsetFactor;
        [NMS(Index = 511)]
        /* 0x1090 */ public float LandingHelperMinAngle;
        [NMS(Index = 513)]
        /* 0x1094 */ public float LandingHelperRollTime;
        [NMS(Index = 512)]
        /* 0x1098 */ public float LandingHelperTurnTime;
        [NMS(Index = 15)]
        /* 0x109C */ public float LandingHoverOffset;
        [NMS(Index = 18)]
        /* 0x10A0 */ public float LandingMargin;
        [NMS(Index = 17)]
        /* 0x10A4 */ public float LandingMaxAngle;
        [NMS(Index = 16)]
        /* 0x10A8 */ public float LandingMaxSpeed;
        [NMS(Index = 19)]
        /* 0x10AC */ public float LandingObstacleMinHeight;
        [NMS(Index = 263)]
        /* 0x10B0 */ public float LandingOnGroundTip;
        [NMS(Index = 275)]
        /* 0x10B4 */ public float LandingPushNoseUpFactor;
        [NMS(Index = 20)]
        /* 0x10B8 */ public float LandingTooManyLowPointsFraction;
        [NMS(Index = 518)]
        /* 0x10BC */ public float LandLookingForward;
        [NMS(Index = 407)]
        /* 0x10C0 */ public float LandOffset;
        [NMS(Index = 521)]
        /* 0x10C4 */ public float LandSlopeMax;
        [NMS(Index = 520)]
        /* 0x10C8 */ public float LandWidthThreshold;
        [NMS(Index = 439)]
        /* 0x10CC */ public int LaserAimLevel;
        [NMS(Index = 498)]
        /* 0x10D0 */ public float LaserCoolFactor;
        [NMS(Index = 499)]
        /* 0x10D4 */ public float LaserFireTime;
        [NMS(Index = 497)]
        /* 0x10D8 */ public float LaserOverheatDownTime;
        [NMS(Index = 496)]
        /* 0x10DC */ public float LaserOverheatTime;
        [NMS(Index = 500)]
        /* 0x10E0 */ public float LaserWaitTime;
        [NMS(Index = 244)]
        /* 0x10E4 */ public float LateralDriftRange;
        [NMS(Index = 243)]
        /* 0x10E8 */ public float LateralDriftRollAmount;
        [NMS(Index = 632)]
        /* 0x10EC */ public float LaunchThrustersMinimumSummonPercentage;
        [NMS(Index = 631)]
        /* 0x10F0 */ public float LaunchThrustersRegenTimePeriod;
        [NMS(Index = 633)]
        /* 0x10F4 */ public float LaunchThrustersSummonCostMultiplier;
        [NMS(Index = 557)]
        /* 0x10F8 */ public float LinearDamping;
        [NMS(Index = 340)]
        /* 0x10FC */ public float LockTargetMaxScale;
        [NMS(Index = 337)]
        /* 0x1100 */ public float LockTargetMinDistance;
        [NMS(Index = 339)]
        /* 0x1104 */ public float LockTargetMinScale;
        [NMS(Index = 338)]
        /* 0x1108 */ public float LockTargetRange;
        [NMS(Index = 562)]
        /* 0x110C */ public float LootAttractDistance;
        [NMS(Index = 563)]
        /* 0x1110 */ public float LootAttractTime;
        [NMS(Index = 565)]
        /* 0x1114 */ public float LootCollectDistance;
        [NMS(Index = 564)]
        /* 0x1118 */ public float LootDampForce;
        [NMS(Index = 154)]
        /* 0x111C */ public float LowAltitudeAnimationHeight;
        [NMS(Index = 155)]
        /* 0x1120 */ public float LowAltitudeAnimationHysteresisTime;
        [NMS(Index = 156)]
        /* 0x1124 */ public float LowAltitudeAnimationTime;
        [NMS(Index = 157)]
        /* 0x1128 */ public float LowAltitudeContrailFadeAtAnimProgress;
        [NMS(Index = 436)]
        /* 0x112C */ public float MarkerEventTime;
        [NMS(Index = 68)]
        /* 0x1130 */ public float MaximumDistanceFromShipWhenExiting;
        [NMS(Index = 69)]
        /* 0x1134 */ public float MaximumHeightWhenExitingShip;
        [NMS(Index = 174)]
        /* 0x1138 */ public float MaxOverspeedBrake;
        [NMS(Index = 638)]
        /* 0x113C */ public float MaxSpeedUpDistance;
        [NMS(Index = 639)]
        /* 0x1140 */ public float MaxSpeedUpVelocity;
        [NMS(Index = 117)]
        /* 0x1144 */ public float MiniWarpAlignSlerp;
        [NMS(Index = 469)]
        /* 0x1148 */ public float MiniWarpAlignStrength;
        [NMS(Index = 470)]
        /* 0x114C */ public float MiniWarpChargeTime;
        [NMS(Index = 474)]
        /* 0x1150 */ public float MiniWarpCooldownTime;
        [NMS(Index = 480)]
        /* 0x1154 */ public float MiniWarpExitSpeed;
        [NMS(Index = 481)]
        /* 0x1158 */ public float MiniWarpExitSpeedStation;
        [NMS(Index = 482)]
        /* 0x115C */ public float MiniWarpExitTime;
        [NMS(Index = 492)]
        /* 0x1160 */ public float MiniWarpFlashDelay;
        [NMS(Index = 491)]
        /* 0x1164 */ public float MiniWarpFlashDuration;
        [NMS(Index = 490)]
        /* 0x1168 */ public float MiniWarpFlashIntensity;
        [NMS(Index = 468)]
        /* 0x116C */ public float MiniWarpFuelTime;
        [NMS(Index = 483)]
        /* 0x1170 */ public float MiniWarpHUDArrowAttractAngle;
        [NMS(Index = 487)]
        /* 0x1174 */ public float MiniWarpHUDArrowAttractAngleDense;
        [NMS(Index = 485)]
        /* 0x1178 */ public float MiniWarpHUDArrowAttractAngleOtherPlayerStuff;
        [NMS(Index = 486)]
        /* 0x117C */ public float MiniWarpHUDArrowAttractAngleSaveBeacon;
        [NMS(Index = 484)]
        /* 0x1180 */ public float MiniWarpHUDArrowAttractAngleStation;
        [NMS(Index = 488)]
        /* 0x1184 */ public int MiniWarpHUDArrowNumMarkersToBeDense;
        [NMS(Index = 425)]
        /* 0x1188 */ public float MiniWarpLinesHeight;
        [NMS(Index = 422)]
        /* 0x118C */ public int MiniWarpLinesNum;
        [NMS(Index = 424)]
        /* 0x1190 */ public float MiniWarpLinesOffset;
        [NMS(Index = 423)]
        /* 0x1194 */ public float MiniWarpLinesSpacing;
        [NMS(Index = 115)]
        /* 0x1198 */ public float MiniWarpMarkerAlignSlowdown;
        [NMS(Index = 116)]
        /* 0x119C */ public float MiniWarpMarkerAlignSlowdownRange;
        [NMS(Index = 114)]
        /* 0x11A0 */ public float MiniWarpMarkerApproachSlowdown;
        [NMS(Index = 476)]
        /* 0x11A4 */ public float MiniWarpMinPlanetDistance;
        [NMS(Index = 493)]
        /* 0x11A8 */ public float MiniWarpNoAsteroidRadius;
        [NMS(Index = 466)]
        /* 0x11AC */ public float MiniWarpPlanetRadius;
        [NMS(Index = 465)]
        /* 0x11B0 */ public float MiniWarpShakeStrength;
        [NMS(Index = 471)]
        /* 0x11B4 */ public float MiniWarpSpeed;
        [NMS(Index = 467)]
        /* 0x11B8 */ public float MiniWarpStationRadius;
        [NMS(Index = 477)]
        /* 0x11BC */ public float MiniWarpStoppingMarginDefault;
        [NMS(Index = 478)]
        /* 0x11C0 */ public float MiniWarpStoppingMarginLong;
        [NMS(Index = 475)]
        /* 0x11C4 */ public float MiniWarpStoppingMarginPlanet;
        [NMS(Index = 473)]
        /* 0x11C8 */ public float MiniWarpTime;
        [NMS(Index = 472)]
        /* 0x11CC */ public float MiniWarpTopSpeedTime;
        [NMS(Index = 479)]
        /* 0x11D0 */ public float MiniWarpTrackingMargin;
        [NMS(Index = 445)]
        /* 0x11D4 */ public float MissileLockSpeedUp;
        [NMS(Index = 446)]
        /* 0x11D8 */ public float MissileLockTime;
        [NMS(Index = 399)]
        /* 0x11DC */ public float MissileShootTime;
        [NMS(Index = 383)]
        /* 0x11E0 */ public float MuzzleAnimSpeed;
        [NMS(Index = 382)]
        /* 0x11E4 */ public float MuzzleLightIntensity;
        [NMS(Index = 110)]
        /* 0x11E8 */ public float NearGroundPitchCorrectMinHeight;
        [NMS(Index = 112)]
        /* 0x11EC */ public float NearGroundPitchCorrectMinHeightRemote;
        [NMS(Index = 111)]
        /* 0x11F0 */ public float NearGroundPitchCorrectRange;
        [NMS(Index = 113)]
        /* 0x11F4 */ public float NearGroundPitchCorrectRangeRemote;
        [NMS(Index = 138)]
        /* 0x11F8 */ public float NetworkDockSearchRadius;
        [NMS(Index = 358)]
        /* 0x11FC */ public float NoBoostAnomalyDistance;
        [NMS(Index = 365)]
        /* 0x1200 */ public float NoBoostCombatEventMinBattleTime;
        [NMS(Index = 366)]
        /* 0x1204 */ public float NoBoostCombatEventMinFreighterBattleTime;
        [NMS(Index = 367)]
        /* 0x1208 */ public float NoBoostCombatEventTime;
        [NMS(Index = 361)]
        /* 0x120C */ public float NoBoostFreighterAngle;
        [NMS(Index = 360)]
        /* 0x1210 */ public float NoBoostFreighterDistance;
        [NMS(Index = 362)]
        /* 0x1214 */ public float NoBoostShipDistance;
        [NMS(Index = 364)]
        /* 0x1218 */ public float NoBoostShipLastHitTime;
        [NMS(Index = 363)]
        /* 0x121C */ public float NoBoostShipNearMinTime;
        [NMS(Index = 359)]
        /* 0x1220 */ public float NoBoostSpaceAnomalyDistance;
        [NMS(Index = 357)]
        /* 0x1224 */ public float NoBoostStationDistance;
        [NMS(Index = 108)]
        /* 0x1228 */ public float OutpostDockSpeedAlignMinDistance;
        [NMS(Index = 109)]
        /* 0x122C */ public float OutpostDockSpeedAlignRange;
        [NMS(Index = 246)]
        /* 0x1230 */ public float PadThrustSmoothTime;
        [NMS(Index = 245)]
        /* 0x1234 */ public float PadTurnSpeed;
        [NMS(Index = 293)]
        /* 0x1238 */ public float PitchCorrectCockpitSpring;
        [NMS(Index = 292)]
        /* 0x123C */ public float PitchCorrectDownSpeedHeightMax;
        [NMS(Index = 291)]
        /* 0x1240 */ public float PitchCorrectDownSpeedHeightMin;
        [NMS(Index = 290)]
        /* 0x1244 */ public float PitchCorrectDownSpeedMaxDownAngle;
        [NMS(Index = 287)]
        /* 0x1248 */ public float PitchCorrectDownSpeedMinSpeed;
        [NMS(Index = 288)]
        /* 0x124C */ public float PitchCorrectDownSpeedRange;
        [NMS(Index = 289)]
        /* 0x1250 */ public float PitchCorrectDownSpeedSoftAngle;
        [NMS(Index = 305)]
        /* 0x1254 */ public float PitchCorrectHeightMax;
        [NMS(Index = 304)]
        /* 0x1258 */ public float PitchCorrectHeightMin;
        [NMS(Index = 303)]
        /* 0x125C */ public float PitchCorrectHeightSpring;
        [NMS(Index = 295)]
        /* 0x1260 */ public float PitchCorrectMaxDownAngle;
        [NMS(Index = 296)]
        /* 0x1264 */ public float PitchCorrectMaxDownAnglePostCollision;
        [NMS(Index = 298)]
        /* 0x1268 */ public float PitchCorrectMaxDownAngleWater;
        [NMS(Index = 294)]
        /* 0x126C */ public float PitchCorrectSoftDownAngle;
        [NMS(Index = 297)]
        /* 0x1270 */ public float PitchCorrectSoftDownAnglePostCollision;
        [NMS(Index = 299)]
        /* 0x1274 */ public float PitchCorrectSoftDownAngleWater;
        [NMS(Index = 302)]
        /* 0x1278 */ public float PitchCorrectTimeHeight;
        [NMS(Index = 301)]
        /* 0x127C */ public float PitchCorrectTimeMax;
        [NMS(Index = 300)]
        /* 0x1280 */ public float PitchCorrectTimeMin;
        [NMS(Index = 376)]
        /* 0x1284 */ public float PlayerFreighterClearSpaceRadius;
        [NMS(Index = 176)]
        /* 0x1288 */ public float PostFreighterWarpTransitionTime;
        [NMS(Index = 175)]
        /* 0x128C */ public float PostWarpSlowDownTime;
        [NMS(Index = 318)]
        /* 0x1290 */ public float PowerSettingEngineDamper;
        [NMS(Index = 317)]
        /* 0x1294 */ public float PowerSettingEngineMul;
        [NMS(Index = 322)]
        /* 0x1298 */ public float PowerSettingShieldDamper;
        [NMS(Index = 321)]
        /* 0x129C */ public float PowerSettingShieldMul;
        [NMS(Index = 320)]
        /* 0x12A0 */ public float PowerSettingWeaponDamper;
        [NMS(Index = 319)]
        /* 0x12A4 */ public float PowerSettingWeaponMul;
        [NMS(Index = 504)]
        /* 0x12A8 */ public int ProjectileClipSize;
        [NMS(Index = 502)]
        /* 0x12AC */ public float ProjectileFireRate;
        [NMS(Index = 501)]
        /* 0x12B0 */ public float ProjectileOverheatTime;
        [NMS(Index = 503)]
        /* 0x12B4 */ public float ProjectileReloadTime;
        [NMS(Index = 23)]
        /* 0x12B8 */ public float PulseDriveBoostDoubleTapTime;
        [NMS(Index = 179)]
        /* 0x12BC */ public float PulseDrivePlanetApproachHeight;
        [NMS(Index = 178)]
        /* 0x12C0 */ public float PulseDrivePlanetApproachMaxAngle;
        [NMS(Index = 177)]
        /* 0x12C4 */ public float PulseDrivePlanetApproachMinAngle;
        [NMS(Index = 35)]
        /* 0x12C8 */ public float PulseDriveStationApproachAngleMin;
        [NMS(Index = 36)]
        /* 0x12CC */ public float PulseDriveStationApproachAngleRange;
        [NMS(Index = 39)]
        /* 0x12D0 */ public float PulseDriveStationApproachOffset;
        [NMS(Index = 37)]
        /* 0x12D4 */ public float PulseDriveStationApproachPerpAngleMin;
        [NMS(Index = 38)]
        /* 0x12D8 */ public float PulseDriveStationApproachPerpAngleRange;
        [NMS(Index = 40)]
        /* 0x12DC */ public float PulseDriveStationApproachSlowdown;
        [NMS(Index = 42)]
        /* 0x12E0 */ public float PulseDriveStationApproachSlowdownRange;
        [NMS(Index = 41)]
        /* 0x12E4 */ public float PulseDriveStationApproachSlowdownRangeMin;
        [NMS(Index = 352)]
        /* 0x12E8 */ public float RemotePlayerLockTimeAfterShot;
        [NMS(Index = 348)]
        /* 0x12EC */ public float ResetTargetLockAngle;
        [NMS(Index = 431)]
        /* 0x12F0 */ public float ResourceCollectOffset;
        [NMS(Index = 327)]
        /* 0x12F4 */ public float RoyalTakeOffMod;
        [NMS(Index = 34)]
        /* 0x12F8 */ public float RudderToRollAngleDownMax;
        [NMS(Index = 33)]
        /* 0x12FC */ public float RudderToRollAngleDownMin;
        [NMS(Index = 32)]
        /* 0x1300 */ public float RudderToRollAngleUpMax;
        [NMS(Index = 29)]
        /* 0x1304 */ public float RudderToRollCutoffRotation;
        [NMS(Index = 28)]
        /* 0x1308 */ public float RudderToRollMultiplierLow;
        [NMS(Index = 25)]
        /* 0x130C */ public float RudderToRollMultiplierMax;
        [NMS(Index = 24)]
        /* 0x1310 */ public float RudderToRollMultiplierMin;
        [NMS(Index = 26)]
        /* 0x1314 */ public float RudderToRollMultiplierOpposite;
        [NMS(Index = 27)]
        /* 0x1318 */ public float RudderToRollMultiplierSpace;
        [NMS(Index = 30)]
        /* 0x131C */ public float RudderToRollUpsideDownRotation;
        [NMS(Index = 595)]
        /* 0x1320 */ public float ShakeAlignBrake;
        [NMS(Index = 593)]
        /* 0x1324 */ public float ShakeMaxPower;
        [NMS(Index = 594)]
        /* 0x1328 */ public float ShakeMaxSpeed;
        [NMS(Index = 591)]
        /* 0x132C */ public float ShakePowerScaler;
        [NMS(Index = 592)]
        /* 0x1330 */ public float ShakeSpeed;
        [NMS(Index = 188)]
        /* 0x1334 */ public float ShieldEffectHitTime;
        [NMS(Index = 5)]
        /* 0x1338 */ public float ShieldLeechMul;
        [NMS(Index = 355)]
        /* 0x133C */ public float ShieldRechargeMinHitTime;
        [NMS(Index = 356)]
        /* 0x1340 */ public float ShieldRechargeRate;
        [NMS(Index = 579)]
        /* 0x1344 */ public float ShipDifferentRepelAmount;
        [NMS(Index = 578)]
        /* 0x1348 */ public float ShipDifferentRepelRange;
        [NMS(Index = 625)]
        /* 0x134C */ public float ShipEnterAngle;
        [NMS(Index = 628)]
        /* 0x1350 */ public float ShipEnterMinTime;
        [NMS(Index = 624)]
        /* 0x1354 */ public float ShipEnterRange;
        [NMS(Index = 627)]
        /* 0x1358 */ public float ShipEnterSpeed;
        [NMS(Index = 626)]
        /* 0x135C */ public float ShipEnterTransitionTime;
        [NMS(Index = 495)]
        /* 0x1360 */ public float ShipHeatAlertTime;
        [NMS(Index = 419)]
        /* 0x1364 */ public float ShipMotionDeadZone;
        [NMS(Index = 3)]
        /* 0x1368 */ public float ShipThrottleBrakeVibrationStrength;
        [NMS(Index = 2)]
        /* 0x136C */ public float ShipThrottleNotchVibrationStrength;
        [NMS(Index = 4)]
        /* 0x1370 */ public float ShipThrustReverseThreshhold;
        [NMS(Index = 325)]
        /* 0x1374 */ public float ShuttleTakeOffMod;
        [NMS(Index = 532)]
        /* 0x1378 */ public float SpaceBrakeAngularRange;
        [NMS(Index = 531)]
        /* 0x137C */ public float SpaceBrakeMinAngularSpeed;
        [NMS(Index = 644)]
        /* 0x1380 */ public float SpaceCombatFollowModeAimTime;
        [NMS(Index = 648)]
        /* 0x1384 */ public float SpaceCombatFollowModeBrakeBehindAngle;
        [NMS(Index = 646)]
        /* 0x1388 */ public float SpaceCombatFollowModeEvadeRoll;
        [NMS(Index = 651)]
        /* 0x138C */ public float SpaceCombatFollowModeEvadeThrust;
        [NMS(Index = 647)]
        /* 0x1390 */ public float SpaceCombatFollowModeEvadeTime;
        [NMS(Index = 649)]
        /* 0x1394 */ public float SpaceCombatFollowModeMaxBrakeBehind;
        [NMS(Index = 650)]
        /* 0x1398 */ public float SpaceCombatFollowModeMaxBrakeHeadOn;
        [NMS(Index = 643)]
        /* 0x139C */ public float SpaceCombatFollowModeMaxTorque;
        [NMS(Index = 645)]
        /* 0x13A0 */ public float SpaceCombatFollowModeTargetDistance;
        [NMS(Index = 372)]
        /* 0x13A4 */ public float SpeedCoolNormalSpeedAmount;
        [NMS(Index = 371)]
        /* 0x13A8 */ public float SpeedCoolOffset;
        [NMS(Index = 635)]
        /* 0x13AC */ public float SpeedUpDistanceFadeThreshold;
        [NMS(Index = 634)]
        /* 0x13B0 */ public float SpeedUpDistanceThreshold;
        [NMS(Index = 637)]
        /* 0x13B4 */ public float SpeedUpVelocityCoeff;
        [NMS(Index = 636)]
        /* 0x13B8 */ public float SpeedUpVelocityThreshold;
        [NMS(Index = 230)]
        /* 0x13BC */ public float SpringSpeedBoosting;
        [NMS(Index = 231)]
        /* 0x13C0 */ public float SpringSpeedBraking;
        [NMS(Index = 228)]
        /* 0x13C4 */ public float SpringSpeedDefault;
        [NMS(Index = 229)]
        /* 0x13C8 */ public float SpringSpeedRolling;
        [NMS(Index = 227)]
        /* 0x13CC */ public float SpringSpeedSpringSpeedIn;
        [NMS(Index = 226)]
        /* 0x13D0 */ public float SpringSpeedSpringSpeedOut;
        [NMS(Index = 640)]
        /* 0x13D4 */ public float StickLandThreshold;
        [NMS(Index = 641)]
        /* 0x13D8 */ public float StickPulseThreshold;
        [NMS(Index = 418)]
        /* 0x13DC */ public float StickyStickAngle;
        [NMS(Index = 415)]
        /* 0x13E0 */ public float StickyTurnAngleRange;
        [NMS(Index = 417)]
        /* 0x13E4 */ public float StickyTurnHigh;
        [NMS(Index = 416)]
        /* 0x13E8 */ public float StickyTurnLow;
        [NMS(Index = 414)]
        /* 0x13EC */ public float StickyTurnMinAngle;
        [NMS(Index = 506)]
        /* 0x13F0 */ public float SummonShipAnywhereFwdOffset;
        [NMS(Index = 505)]
        /* 0x13F4 */ public float SummonShipAnywhereHeightOffset;
        [NMS(Index = 507)]
        /* 0x13F8 */ public float SummonShipAnywhereRangeMax;
        [NMS(Index = 508)]
        /* 0x13FC */ public float SummonShipAnywhereRangeMin;
        [NMS(Index = 510)]
        /* 0x1400 */ public float SummonShipApproachOffset;
        [NMS(Index = 509)]
        /* 0x1404 */ public float SummonShipHeightOffset;
        [NMS(Index = 441)]
        /* 0x1408 */ public int TakeOffCost;
        [NMS(Index = 515)]
        /* 0x140C */ public float TakeOffSphereCastLength;
        [NMS(Index = 516)]
        /* 0x1410 */ public float TakeOffSphereCastRadiusMul;
        [NMS(Index = 349)]
        /* 0x1414 */ public float TargetLockAngleTorpedo;
        [NMS(Index = 525)]
        /* 0x1418 */ public float TargetLockChangeTime;
        [NMS(Index = 526)]
        /* 0x141C */ public float TargetLockLoseTime;
        [NMS(Index = 351)]
        /* 0x1420 */ public float TargetLockNearestAngle;
        [NMS(Index = 350)]
        /* 0x1424 */ public float TargetLockRange;
        [NMS(Index = 524)]
        /* 0x1428 */ public float TargetLockTime;
        [NMS(Index = 182)]
        /* 0x142C */ public float TestJetsBoost;
        [NMS(Index = 180)]
        /* 0x1430 */ public float TestJetsStage1;
        [NMS(Index = 181)]
        /* 0x1434 */ public float TestJetsStage2;
        [NMS(Index = 187)]
        /* 0x1438 */ public float TestShieldEffect;
        [NMS(Index = 167)]
        /* 0x143C */ public float TestShipAnimLowAltitude;
        [NMS(Index = 165)]
        /* 0x1440 */ public float TestShipAnimPulse;
        [NMS(Index = 163)]
        /* 0x1444 */ public float TestShipAnimRoll;
        [NMS(Index = 166)]
        /* 0x1448 */ public float TestShipAnimSpace;
        [NMS(Index = 164)]
        /* 0x144C */ public float TestShipAnimThrust;
        [NMS(Index = 85)]
        /* 0x1450 */ public float TestTrailRadius;
        [NMS(Index = 84)]
        /* 0x1454 */ public float TestTrailSpeed;
        [NMS(Index = 183)]
        /* 0x1458 */ public float TestTrailThreshold;
        [NMS(Index = 368)]
        /* 0x145C */ public float ThrustDecaySpring;
        [NMS(Index = 369)]
        /* 0x1460 */ public float ThrustDecaySpringCombat;
        [NMS(Index = 83)]
        /* 0x1464 */ public int TrailMaxNumPointsPerFrameOverride;
        [NMS(Index = 172)]
        /* 0x1468 */ public float TrailVelocityFactor;
        [NMS(Index = 381)]
        /* 0x146C */ public float TurnRudderStrength;
        [NMS(Index = 21)]
        /* 0x1470 */ public float VignetteAmountAcceleration;
        [NMS(Index = 22)]
        /* 0x1474 */ public float VignetteAmountTurning;
        [NMS(Index = 87)]
        /* 0x1478 */ public float WarpAnimMaxSpeed;
        [NMS(Index = 86)]
        /* 0x147C */ public float WarpAnimMinSpeed;
        [NMS(Index = 126)]
        /* 0x1480 */ public float WarpFadeInTime;
        [NMS(Index = 119)]
        /* 0x1484 */ public float WarpInFlashTime;
        [NMS(Index = 123)]
        /* 0x1488 */ public float WarpInFlashTimeFreighter;
        [NMS(Index = 132)]
        /* 0x148C */ public float WarpInFlashTimeNexus;
        [NMS(Index = 127)]
        /* 0x1490 */ public float WarpInLineWidth;
        [NMS(Index = 120)]
        /* 0x1494 */ public float WarpInRange;
        [NMS(Index = 124)]
        /* 0x1498 */ public float WarpInRangeFreighter;
        [NMS(Index = 133)]
        /* 0x149C */ public float WarpInRangeNexus;
        [NMS(Index = 118)]
        /* 0x14A0 */ public float WarpInTime;
        [NMS(Index = 122)]
        /* 0x14A4 */ public float WarpInTimeFreighter;
        [NMS(Index = 131)]
        /* 0x14A8 */ public float WarpInTimeNexus;
        [NMS(Index = 137)]
        /* 0x14AC */ public float WarpNexusDistance;
        [NMS(Index = 136)]
        /* 0x14B0 */ public float WarpNexusPitch;
        [NMS(Index = 135)]
        /* 0x14B4 */ public float WarpNexusRotation;
        [NMS(Index = 129)]
        /* 0x14B8 */ public float WarpOutRange;
        [NMS(Index = 130)]
        /* 0x14BC */ public float WarpOutTime;
        [NMS(Index = 121)]
        /* 0x14C0 */ public float WarpScale;
        [NMS(Index = 125)]
        /* 0x14C4 */ public float WarpScaleFreighter;
        [NMS(Index = 134)]
        /* 0x14C8 */ public float WarpScaleNexus;
        [NMS(Index = 241)]
        /* 0x14CC */ public float WeaponDamagePotentialReferenceRange;
        [NMS(Index = 610)]
        /* 0x14D0 */ public float WingmanAlign;
        [NMS(Index = 611)]
        /* 0x14D4 */ public float WingmanAngle;
        [NMS(Index = 612)]
        /* 0x14D8 */ public float WingmanAngle2;
        [NMS(Index = 605)]
        /* 0x14DC */ public float WingmanAttackAimAngle;
        [NMS(Index = 603)]
        /* 0x14E0 */ public float WingmanAttackAngle;
        [NMS(Index = 608)]
        /* 0x14E4 */ public float WingmanAttackCoolTime;
        [NMS(Index = 602)]
        /* 0x14E8 */ public float WingmanAttackMinRange;
        [NMS(Index = 600)]
        /* 0x14EC */ public float WingmanAttackOffset;
        [NMS(Index = 601)]
        /* 0x14F0 */ public float WingmanAttackRange;
        [NMS(Index = 606)]
        /* 0x14F4 */ public float WingmanAttackTime;
        [NMS(Index = 607)]
        /* 0x14F8 */ public float WingmanAttackTimeout;
        [NMS(Index = 597)]
        /* 0x14FC */ public float WingmanAtTime;
        [NMS(Index = 598)]
        /* 0x1500 */ public float WingmanAtTimeBack;
        [NMS(Index = 596)]
        /* 0x1504 */ public float WingmanAtTimeStart;
        [NMS(Index = 614)]
        /* 0x1508 */ public float WingmanFwd1;
        [NMS(Index = 615)]
        /* 0x150C */ public float WingmanFwd2;
        [NMS(Index = 599)]
        /* 0x1510 */ public float WingmanPerpTime;
        [NMS(Index = 613)]
        /* 0x1514 */ public float WingmanRadius;
        [NMS(Index = 609)]
        /* 0x1518 */ public float WingmanSpawnDist;
        [NMS(Index = 96)]
        /* 0x151C */ public float WingmanSpeedApproachSpeed;
        [NMS(Index = 97)]
        /* 0x1520 */ public float WingmanSpeedApproachSpeedSpace;
        [NMS(Index = 94)]
        /* 0x1524 */ public float WingmanSpeedTrackDistance;
        [NMS(Index = 92)]
        /* 0x1528 */ public float WingmanSpeedTrackForceMax;
        [NMS(Index = 93)]
        /* 0x152C */ public float WingmanSpeedTrackForceMin;
        [NMS(Index = 95)]
        /* 0x1530 */ public float WingmanSpeedTrackOffset;
        [NMS(Index = 604)]
        /* 0x1534 */ public float WingmanViewerAngle;
        [NMS(Index = 0)]
        /* 0x1538 */ public NMSString0x20 HoverShipDataName;
        [NMS(Index = 74)]
        /* 0x1558 */ public bool _3rdPersonShipEnabled;
        [NMS(Index = 224)]
        /* 0x1559 */ public TkCurveType _3rdPersonWarpWanderCurve;
        [NMS(Index = 9)]
        /* 0x155A */ public bool AddShipToCollectionOnEnter;
        [NMS(Index = 75)]
        /* 0x155B */ public bool AimZoomAuto;
        [NMS(Index = 8)]
        /* 0x155C */ public bool AllowSideScreenPointing;
        [NMS(Index = 393)]
        /* 0x155D */ public bool AltAtmosphere;
        [NMS(Index = 72)]
        /* 0x155E */ public bool AltControls;
        [NMS(Index = 80)]
        /* 0x155F */ public bool ApplyHeightAlign;
        [NMS(Index = 79)]
        /* 0x1560 */ public bool ApplyHeightForce;
        [NMS(Index = 345)]
        /* 0x1561 */ public bool AutoEjectOnLanding;
        [NMS(Index = 91)]
        /* 0x1562 */ public TkCurveType CockpitExitAnimCurve;
        [NMS(Index = 77)]
        /* 0x1563 */ public bool CritsFromBehind;
        [NMS(Index = 547)]
        /* 0x1564 */ public TkCurveType DeflectCurve;
        [NMS(Index = 152)]
        /* 0x1565 */ public TkCurveType DirectionDockingIndicatorCurve;
        [NMS(Index = 81)]
        /* 0x1566 */ public bool DoPreCollision;
        [NMS(Index = 78)]
        /* 0x1567 */ public bool DrawLineLockTarget;
        [NMS(Index = 76)]
        /* 0x1568 */ public bool EnableDepthTestedCrosshairSections;
        [NMS(Index = 10)]
        /* 0x1569 */ public bool EnablePulseDriveSpaceStationOrient;
        [NMS(Index = 282)]
        /* 0x156A */ public TkCurveType GroundHeightHardCurve;
        [NMS(Index = 279)]
        /* 0x156B */ public TkCurveType GroundHeightSoftCurve;
        [NMS(Index = 346)]
        /* 0x156C */ public bool LandedCockpitFreeLook;
        [NMS(Index = 264)]
        /* 0x156D */ public bool LandingCheckBuildings;
        [NMS(Index = 307)]
        /* 0x156E */ public TkCurveType LandingCurve;
        [NMS(Index = 308)]
        /* 0x156F */ public TkCurveType LandingCurveHeavy;
        [NMS(Index = 489)]
        /* 0x1570 */ public TkCurveType MiniWarpCurve;
        [NMS(Index = 306)]
        /* 0x1571 */ public TkCurveType PitchCorrectHeightCurve;
        [NMS(Index = 31)]
        /* 0x1572 */ public TkCurveType RudderToRollCurve;
        [NMS(Index = 189)]
        /* 0x1573 */ public TkCurveType ShieldEffectHitCurve;
        [NMS(Index = 653)]
        /* 0x1574 */ public bool SpaceCombatFollowModeUseBoost;
        [NMS(Index = 652)]
        /* 0x1575 */ public bool SpaceCombatFollowModeUseEvadeTarget;
        [NMS(Index = 73)]
        /* 0x1576 */ public bool SpaceMapInWorld;
        [NMS(Index = 82)]
        /* 0x1577 */ public bool SpeedTrackModeEnabled;
        [NMS(Index = 225)]
        /* 0x1578 */ public bool SpringSpeedSpringEnabled;
        [NMS(Index = 162)]
        /* 0x1579 */ public bool TestShipAnims;
        [NMS(Index = 128)]
        /* 0x157A */ public TkCurveType WarpInCurve;
    }
}
