using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x761975B03BE884C4, NameHash = 0x42902548)]
    public class GcSpaceshipGlobals : NMSTemplate
    {
        [NMS(Index = 197)]
        /* 0x0000 */ public GcScanEffectData ShieldEffectScanData;
        [NMS(Index = 339)]
        /* 0x0050 */ public Colour AlarmLightColour;
        [NMS(Index = 340)]
        /* 0x0060 */ public Colour AlarmLightColourHostile;
        [NMS(Index = 113)]
        /* 0x0070 */ public Vector3f AtmosphereLightOffset;
        [NMS(Index = 605)]
        /* 0x0080 */ public Vector3f CockpitScale;
        [NMS(Index = 403)]
        /* 0x0090 */ public Colour DamageLightColour;
        [NMS(Index = 402)]
        /* 0x00A0 */ public Colour DamageLightColourShield;
        [NMS(Index = 398)]
        /* 0x00B0 */ public Vector3f DamageLightOffsetLeft;
        [NMS(Index = 399)]
        /* 0x00C0 */ public Vector3f DamageLightOffsetRight;
        [NMS(Index = 397)]
        /* 0x00D0 */ public Vector3f DamageLightOffsetTop;
        [NMS(Index = 243)]
        /* 0x00E0 */ public Vector3f DefaultCentreOffset;
        [NMS(Index = 244)]
        /* 0x00F0 */ public Vector3f DefaultCentreOffsetDropship;
        [NMS(Index = 246)]
        /* 0x0100 */ public Vector3f DefaultCentreOffsetRoyal;
        [NMS(Index = 247)]
        /* 0x0110 */ public Vector3f DefaultCentreOffsetSail;
        [NMS(Index = 245)]
        /* 0x0120 */ public Vector3f DefaultCentreOffsetScientific;
        [NMS(Index = 150)]
        /* 0x0130 */ public Colour DirectionDockingInRangeColour;
        [NMS(Index = 151)]
        /* 0x0140 */ public Colour DirectionDockingOutRangeColour;
        [NMS(Index = 102)]
        /* 0x0150 */ public Colour GroundEffectBuildingColour;
        [NMS(Index = 103)]
        /* 0x0160 */ public Colour GroundEffectWaterColour;
        [NMS(Index = 586)]
        /* 0x0170 */ public Vector3f GunOffset3rdPersonLeft;
        [NMS(Index = 587)]
        /* 0x0180 */ public Vector3f GunOffset3rdPersonRight;
        [NMS(Index = 582)]
        /* 0x0190 */ public Vector3f GunOffsetLeft;
        [NMS(Index = 584)]
        /* 0x01A0 */ public Vector3f GunOffsetLeft2;
        [NMS(Index = 583)]
        /* 0x01B0 */ public Vector3f GunOffsetRight;
        [NMS(Index = 585)]
        /* 0x01C0 */ public Vector3f GunOffsetRight2;
        [NMS(Index = 49)]
        /* 0x01D0 */ public Vector3f HandControllerDeadZone;
        [NMS(Index = 50)]
        /* 0x01E0 */ public Vector3f HandControllerExtents;
        [NMS(Index = 47)]
        /* 0x01F0 */ public Vector3f HandControllerValueMultiplier;
        [NMS(Index = 48)]
        /* 0x0200 */ public Vector3f HandControllerValueMultiplierSpace;
        [NMS(Index = 101)]
        /* 0x0210 */ public Colour LandingEffectSpaceColourOverride;
        [NMS(Index = 396)]
        /* 0x0220 */ public Colour MuzzleLightColour;
        [NMS(Index = 278)]
        /* 0x0230 */ public Vector3f PostCollisionAngularFactor;
        [NMS(Index = 657)]
        /* 0x0240 */ public Vector3f StickAnimationDamping;
        [NMS(Index = 365)]
        /* 0x0250 */ public Colour TargetLockDangerColour;
        [NMS(Index = 364)]
        /* 0x0260 */ public Colour TargetLockPassiveColour;
        [NMS(Index = 341)]
        /* 0x0270 */ public List<Vector3f> AlarmLightOffsets;
        [NMS(Index = 451)]
        /* 0x0280 */ public List<GcPlayerSpaceshipAim> GunAimArray;
        [NMS(Index = 449)]
        /* 0x0290 */ public List<GcPlayerSpaceshipAim> LaserAimArray;
        [NMS(Index = 7)]
        /* 0x02A0 */ public NMSString0x10 SailShipCoreTechID;
        [NMS(Index = 644)]
        /* 0x02B0 */ public List<VariableSizeString> ShipModels;
        [NMS(Index = 104)]
        /* 0x02C0 */ public NMSString0x10 WaterEffectID;
        [NMS(Index = 108)]
        /* 0x02D0 */ public NMSString0x10 WaterJetHoverEffectID;
        [NMS(Index = 106)]
        /* 0x02E0 */ public NMSString0x10 WaterJetLandingEffectID;
        [NMS(Index = 107)]
        /* 0x02F0 */ public NMSString0x10 WaterJetTakeoffEffectID;
        [NMS(Index = 319)]
        /* 0x0300 */ public GcPlayerSpaceshipControlData Control;
        [NMS(Index = 321)]
        /* 0x0518 */ public GcPlayerSpaceshipControlData ControlHeavy;
        [NMS(Index = 322)]
        /* 0x0730 */ public GcPlayerSpaceshipControlData ControlHeavyHover;
        [NMS(Index = 323)]
        /* 0x0948 */ public GcPlayerSpaceshipControlData ControlHover;
        [NMS(Index = 320)]
        /* 0x0B60 */ public GcPlayerSpaceshipControlData ControlLight;
        [NMS(Index = 326)]
        /* 0x0D78 */ public GcPlayerSpaceshipClassBonuses ControlBonusA;
        [NMS(Index = 325)]
        /* 0x0DA8 */ public GcPlayerSpaceshipClassBonuses ControlBonusB;
        [NMS(Index = 324)]
        /* 0x0DD8 */ public GcPlayerSpaceshipClassBonuses ControlBonusC;
        [NMS(Index = 327)]
        /* 0x0E08 */ public GcPlayerSpaceshipClassBonuses ControlBonusS;
        [NMS(Index = 174)]
        /* 0x0E38 */ public GcSpaceshipAvoidanceData Avoidance;
        [NMS(Index = 175)]
        /* 0x0E5C */ public GcSpaceshipAvoidanceData AvoidanceLowAltitude;
        [NMS(Index = 441)]
        /* 0x0E80 */ public GcPlayerStickData StickData;
        [NMS(Index = 455)]
        /* 0x0E9C */ public GcPlayerSpaceshipAim MissileAim;
        [NMS(Index = 588)]
        /* 0x0EB4 */ public GcPlayerSpaceshipWarpData Warp;
        [NMS(Index = 401)]
        /* 0x0EC4 */ public TkHitCurveData DamageLightCurve;
        [NMS(Index = 395)]
        /* 0x0ED0 */ public TkHitCurveData MuzzleLightCurve;
        [NMS(Index = 432)]
        /* 0x0EDC */ public Vector2f DeathSpinPitch;
        [NMS(Index = 431)]
        /* 0x0EE4 */ public Vector2f DeathSpinRoll;
        [NMS(Index = 208)]
        /* 0x0EEC */ public float _3rdPersonAngleMinSpeed;
        [NMS(Index = 209)]
        /* 0x0EF0 */ public float _3rdPersonAngleSpeedRangePitch;
        [NMS(Index = 210)]
        /* 0x0EF4 */ public float _3rdPersonAngleSpeedRangeYaw;
        [NMS(Index = 207)]
        /* 0x0EF8 */ public float _3rdPersonAngleSpringTime;
        [NMS(Index = 216)]
        /* 0x0EFC */ public float _3rdPersonAvoidanceAdjustPitchFactor;
        [NMS(Index = 218)]
        /* 0x0F00 */ public float _3rdPersonAvoidanceAdjustRollFactor;
        [NMS(Index = 219)]
        /* 0x0F04 */ public float _3rdPersonAvoidanceAdjustYawFactor;
        [NMS(Index = 221)]
        /* 0x0F08 */ public float _3rdPersonFlashDuration;
        [NMS(Index = 220)]
        /* 0x0F0C */ public float _3rdPersonFlashIntensity;
        [NMS(Index = 217)]
        /* 0x0F10 */ public float _3rdPersonHeightForceAdjustPitchFactor;
        [NMS(Index = 212)]
        /* 0x0F14 */ public float _3rdPersonLowHeightMax;
        [NMS(Index = 211)]
        /* 0x0F18 */ public float _3rdPersonLowHeightMin;
        [NMS(Index = 213)]
        /* 0x0F1C */ public float _3rdPersonLowHeightOffsetVertRotationY;
        [NMS(Index = 214)]
        /* 0x0F20 */ public float _3rdPersonLowHeightOffsetY;
        [NMS(Index = 215)]
        /* 0x0F24 */ public float _3rdPersonLowHeightSpringTime;
        [NMS(Index = 204)]
        /* 0x0F28 */ public float _3rdPersonPitchAngle;
        [NMS(Index = 200)]
        /* 0x0F2C */ public float _3rdPersonRollAngle;
        [NMS(Index = 203)]
        /* 0x0F30 */ public float _3rdPersonRollAngleAlien;
        [NMS(Index = 201)]
        /* 0x0F34 */ public float _3rdPersonRollAngleDropship;
        [NMS(Index = 202)]
        /* 0x0F38 */ public float _3rdPersonRollAngleScience;
        [NMS(Index = 222)]
        /* 0x0F3C */ public float _3rdPersonTransitionTime;
        [NMS(Index = 199)]
        /* 0x0F40 */ public float _3rdPersonUpOffsetRollChangeSpeed;
        [NMS(Index = 227)]
        /* 0x0F44 */ public float _3rdPersonWarpWanderSpring;
        [NMS(Index = 226)]
        /* 0x0F48 */ public float _3rdPersonWarpWanderStartTime;
        [NMS(Index = 228)]
        /* 0x0F4C */ public float _3rdPersonWarpWanderTimeX;
        [NMS(Index = 229)]
        /* 0x0F50 */ public float _3rdPersonWarpWanderTimeY;
        [NMS(Index = 230)]
        /* 0x0F54 */ public float _3rdPersonWarpWanderTimeZ;
        [NMS(Index = 223)]
        /* 0x0F58 */ public float _3rdPersonWarpXWander;
        [NMS(Index = 224)]
        /* 0x0F5C */ public float _3rdPersonWarpYWander;
        [NMS(Index = 225)]
        /* 0x0F60 */ public float _3rdPersonWarpZWander;
        [NMS(Index = 205)]
        /* 0x0F64 */ public float _3rdPersonYawAngle;
        [NMS(Index = 206)]
        /* 0x0F68 */ public float _3rdPersonYawAngleLateralExtra;
        [NMS(Index = 198)]
        /* 0x0F6C */ public float AcrobaticLowFlightLevel;
        [NMS(Index = 407)]
        /* 0x0F70 */ public float AimCritAngle;
        [NMS(Index = 409)]
        /* 0x0F74 */ public float AimCritBehindAngle;
        [NMS(Index = 408)]
        /* 0x0F78 */ public float AimCritMinFwdAngle;
        [NMS(Index = 419)]
        /* 0x0F7C */ public float AimFoVBoost;
        [NMS(Index = 420)]
        /* 0x0F80 */ public float AimFoVBoostTime;
        [NMS(Index = 421)]
        /* 0x0F84 */ public float AimFoVBoostTimeAuto;
        [NMS(Index = 423)]
        /* 0x0F88 */ public float AimMaxAutoAngle;
        [NMS(Index = 443)]
        /* 0x0F8C */ public float AimSpeedTrackDistance;
        [NMS(Index = 444)]
        /* 0x0F90 */ public float AimSpeedTrackForce;
        [NMS(Index = 422)]
        /* 0x0F94 */ public float AimTurnSlower;
        [NMS(Index = 347)]
        /* 0x0F98 */ public float AlarmLastHitTime;
        [NMS(Index = 342)]
        /* 0x0F9C */ public float AlarmLightIntensity;
        [NMS(Index = 344)]
        /* 0x0FA0 */ public float AlarmLightIntensityHostile;
        [NMS(Index = 343)]
        /* 0x0FA4 */ public float AlarmRate;
        [NMS(Index = 346)]
        /* 0x0FA8 */ public float AlarmRateHostileMax;
        [NMS(Index = 345)]
        /* 0x0FAC */ public float AlarmRateHostileMin;
        [NMS(Index = 572)]
        /* 0x0FB0 */ public float AngularDamping;
        [NMS(Index = 528)]
        /* 0x0FB4 */ public float AnomalyStationMaxApproachSpeed;
        [NMS(Index = 405)]
        /* 0x0FB8 */ public float AsteroidHitAngle;
        [NMS(Index = 406)]
        /* 0x0FBC */ public float AsteroidHitAngleBoosting;
        [NMS(Index = 596)]
        /* 0x0FC0 */ public float AtmosphereAngle;
        [NMS(Index = 6)]
        /* 0x0FC4 */ public float AtmosphereCombatHeight;
        [NMS(Index = 112)]
        /* 0x0FC8 */ public float AtmosphereLightIntensity;
        [NMS(Index = 595)]
        /* 0x0FCC */ public float AtmosphereSpeed;
        [NMS(Index = 355)]
        /* 0x0FD0 */ public float AutoLevelMaxAngle;
        [NMS(Index = 353)]
        /* 0x0FD4 */ public float AutoLevelMaxPitchAngle;
        [NMS(Index = 354)]
        /* 0x0FD8 */ public float AutoLevelMinAngle;
        [NMS(Index = 352)]
        /* 0x0FDC */ public float AutoLevelMinPitchAngle;
        [NMS(Index = 277)]
        /* 0x0FE0 */ public float AutoLevelPitchCorrectMargin;
        [NMS(Index = 276)]
        /* 0x0FE4 */ public float AutoLevelWaterAngle;
        [NMS(Index = 274)]
        /* 0x0FE8 */ public float AutoLevelWaterMargin;
        [NMS(Index = 275)]
        /* 0x0FEC */ public float AutoLevelWaterTorque;
        [NMS(Index = 458)]
        /* 0x0FF0 */ public float AutoPilotAlignStrength;
        [NMS(Index = 462)]
        /* 0x0FF4 */ public float AutoPilotCallAngle;
        [NMS(Index = 465)]
        /* 0x0FF8 */ public float AutoPilotCallAngleGhost;
        [NMS(Index = 463)]
        /* 0x0FFC */ public float AutoPilotCallAngleVertical;
        [NMS(Index = 466)]
        /* 0x1000 */ public float AutoPilotCallAngleVerticalGhost;
        [NMS(Index = 460)]
        /* 0x1004 */ public float AutoPilotCallDistance;
        [NMS(Index = 464)]
        /* 0x1008 */ public float AutoPilotCallDistanceGhost;
        [NMS(Index = 461)]
        /* 0x100C */ public float AutoPilotCallDistanceSpacePOI;
        [NMS(Index = 467)]
        /* 0x1010 */ public float AutoPilotPositionAlignStrength;
        [NMS(Index = 459)]
        /* 0x1014 */ public float AutoPilotSmallShipAlignStrength;
        [NMS(Index = 240)]
        /* 0x1018 */ public float AvoidanceDistancePower;
        [NMS(Index = 239)]
        /* 0x101C */ public float AvoidancePower;
        [NMS(Index = 541)]
        /* 0x1020 */ public float BoostChargeRate;
        [NMS(Index = 508)]
        /* 0x1024 */ public float BoostNoAsteroidRadius;
        [NMS(Index = 386)]
        /* 0x1028 */ public float CameraPostWarpFov;
        [NMS(Index = 385)]
        /* 0x102C */ public float CameraPostWarpFovTime;
        [NMS(Index = 65)]
        /* 0x1030 */ public float CockpitDriftAngle;
        [NMS(Index = 62)]
        /* 0x1034 */ public float CockpitDriftAngleHmd;
        [NMS(Index = 90)]
        /* 0x1038 */ public float CockpitExitAnimMul;
        [NMS(Index = 92)]
        /* 0x103C */ public float CockpitExitAnimOffset;
        [NMS(Index = 91)]
        /* 0x1040 */ public float CockpitExitAnimTime;
        [NMS(Index = 64)]
        /* 0x1044 */ public float CockpitPitchCorrectAngle;
        [NMS(Index = 61)]
        /* 0x1048 */ public float CockpitPitchCorrectAngleHmd;
        [NMS(Index = 63)]
        /* 0x104C */ public float CockpitRollAngle;
        [NMS(Index = 66)]
        /* 0x1050 */ public float CockpitRollAngleExtra;
        [NMS(Index = 60)]
        /* 0x1054 */ public float CockpitRollAngleHmd;
        [NMS(Index = 68)]
        /* 0x1058 */ public float CockpitRollMultiplierCentre;
        [NMS(Index = 69)]
        /* 0x105C */ public float CockpitRollMultiplierOpposite;
        [NMS(Index = 67)]
        /* 0x1060 */ public float CockpitRollTime;
        [NMS(Index = 242)]
        /* 0x1064 */ public float CollisionAlignStrength;
        [NMS(Index = 551)]
        /* 0x1068 */ public float CollisionAsteroidDamp;
        [NMS(Index = 549)]
        /* 0x106C */ public float CollisionDeflectDamping;
        [NMS(Index = 241)]
        /* 0x1070 */ public float CollisionDeflectForce;
        [NMS(Index = 550)]
        /* 0x1074 */ public float CollisionDeflectNormalFactor;
        [NMS(Index = 548)]
        /* 0x1078 */ public float CollisionDeflectTime;
        [NMS(Index = 553)]
        /* 0x107C */ public float CollisionDistance;
        [NMS(Index = 555)]
        /* 0x1080 */ public float CollisionDistanceAsteroid;
        [NMS(Index = 556)]
        /* 0x1084 */ public float CollisionDistanceAsteroidSide;
        [NMS(Index = 554)]
        /* 0x1088 */ public float CollisionDistanceGround;
        [NMS(Index = 557)]
        /* 0x108C */ public float CollisionDistanceSpaceships;
        [NMS(Index = 552)]
        /* 0x1090 */ public float CollisionGroundDamp;
        [NMS(Index = 562)]
        /* 0x1094 */ public float CollisionRadiusMultiplier;
        [NMS(Index = 547)]
        /* 0x1098 */ public float CollisionSpeedDamageAmount;
        [NMS(Index = 445)]
        /* 0x109C */ public float CombatBoostMultiplier;
        [NMS(Index = 446)]
        /* 0x10A0 */ public float CombatBoostTurnDamp;
        [NMS(Index = 191)]
        /* 0x10A4 */ public float ContrailDefaultAlpha;
        [NMS(Index = 180)]
        /* 0x10A8 */ public float ContrailSpeedDamping;
        [NMS(Index = 415)]
        /* 0x10AC */ public float CruiseForce;
        [NMS(Index = 411)]
        /* 0x10B0 */ public float CruiseHeight;
        [NMS(Index = 412)]
        /* 0x10B4 */ public float CruiseHeightRange;
        [NMS(Index = 413)]
        /* 0x10B8 */ public float CruiseOffAngle;
        [NMS(Index = 414)]
        /* 0x10BC */ public float CruiseOffAngleRange;
        [NMS(Index = 281)]
        /* 0x10C0 */ public float DamageFlashMin;
        [NMS(Index = 280)]
        /* 0x10C4 */ public float DamageFlashScale;
        [NMS(Index = 400)]
        /* 0x10C8 */ public float DamageLightIntensity;
        [NMS(Index = 543)]
        /* 0x10CC */ public float DamageMaxHitTime;
        [NMS(Index = 542)]
        /* 0x10D0 */ public float DamageMinHitTime;
        [NMS(Index = 544)]
        /* 0x10D4 */ public float DamageMinWoundTime;
        [NMS(Index = 176)]
        /* 0x10D8 */ public float DefaultTrailInitialSpeed;
        [NMS(Index = 178)]
        /* 0x10DC */ public float DefaultTrailMinForwardSpeed;
        [NMS(Index = 177)]
        /* 0x10E0 */ public float DefaultTrailSpeedDamping;
        [NMS(Index = 560)]
        /* 0x10E4 */ public float DeflectAlignTimeMax;
        [NMS(Index = 559)]
        /* 0x10E8 */ public float DeflectAlignTimeMin;
        [NMS(Index = 558)]
        /* 0x10EC */ public float DeflectDistance;
        [NMS(Index = 249)]
        /* 0x10F0 */ public float DirectionBrakeVerticalMultiplier;
        [NMS(Index = 391)]
        /* 0x10F4 */ public float DirectionBrakeVRBoost;
        [NMS(Index = 574)]
        /* 0x10F8 */ public float DirectionDockingAlignmentAngle;
        [NMS(Index = 573)]
        /* 0x10FC */ public float DirectionDockingAngle;
        [NMS(Index = 152)]
        /* 0x1100 */ public float DirectionDockingCircleOffset;
        [NMS(Index = 153)]
        /* 0x1104 */ public float DirectionDockingCircleOffsetExtra;
        [NMS(Index = 155)]
        /* 0x1108 */ public float DirectionDockingCircleRadius;
        [NMS(Index = 156)]
        /* 0x110C */ public float DirectionDockingCircleRadiusExtra;
        [NMS(Index = 154)]
        /* 0x1110 */ public float DirectionDockingCircleWidth;
        [NMS(Index = 147)]
        /* 0x1114 */ public float DirectionDockingIndicatorAngleRange;
        [NMS(Index = 146)]
        /* 0x1118 */ public float DirectionDockingIndicatorClearAngleRange;
        [NMS(Index = 149)]
        /* 0x111C */ public float DirectionDockingIndicatorMaxHeight;
        [NMS(Index = 148)]
        /* 0x1120 */ public float DirectionDockingIndicatorMinHeight;
        [NMS(Index = 145)]
        /* 0x1124 */ public float DirectionDockingIndicatorRange;
        [NMS(Index = 157)]
        /* 0x1128 */ public float DirectionDockingIndicatorSpeed;
        [NMS(Index = 576)]
        /* 0x112C */ public float DirectionDockingInfoRange;
        [NMS(Index = 575)]
        /* 0x1130 */ public float DirectionDockTime;
        [NMS(Index = 72)]
        /* 0x1134 */ public float DistanceFromShipToAllowSpawningOnFreighter;
        [NMS(Index = 100)]
        /* 0x1138 */ public float DockingApproachActiveRange;
        [NMS(Index = 13)]
        /* 0x113C */ public float DockingApproachBrakeHmdMod;
        [NMS(Index = 11)]
        /* 0x1140 */ public float DockingApproachRollHmdMod;
        [NMS(Index = 12)]
        /* 0x1144 */ public float DockingApproachSpeedHmdMod;
        [NMS(Index = 589)]
        /* 0x1148 */ public float DockingRotateSpeed;
        [NMS(Index = 590)]
        /* 0x114C */ public float DockingRotateSpeedVR;
        [NMS(Index = 279)]
        /* 0x1150 */ public float DrawLineLockTargetLineWidth;
        [NMS(Index = 381)]
        /* 0x1154 */ public float DriftEffectIntensity;
        [NMS(Index = 388)]
        /* 0x1158 */ public float DriftSpring;
        [NMS(Index = 390)]
        /* 0x115C */ public float DriftTurnBrakeMultiplier;
        [NMS(Index = 389)]
        /* 0x1160 */ public float DriftTurnStrengthMultiplier;
        [NMS(Index = 634)]
        /* 0x1164 */ public float DroneAlertAngle;
        [NMS(Index = 635)]
        /* 0x1168 */ public float DroneAlertRange;
        [NMS(Index = 597)]
        /* 0x116C */ public float DroneAlignUpTime;
        [NMS(Index = 598)]
        /* 0x1170 */ public float DroneDustHeight;
        [NMS(Index = 600)]
        /* 0x1174 */ public float DroneHeightAdjust;
        [NMS(Index = 599)]
        /* 0x1178 */ public float DroneMinHeight;
        [NMS(Index = 637)]
        /* 0x117C */ public float DroneMoveArrivedRange;
        [NMS(Index = 636)]
        /* 0x1180 */ public float DronePatrolRadius;
        [NMS(Index = 638)]
        /* 0x1184 */ public float DronePatrolTime;
        [NMS(Index = 632)]
        /* 0x1188 */ public float DronePlanetAttackMinRange;
        [NMS(Index = 631)]
        /* 0x118C */ public float DronePlanetAttackRange;
        [NMS(Index = 633)]
        /* 0x1190 */ public float DroneShootTime;
        [NMS(Index = 604)]
        /* 0x1194 */ public float DroneWarpMaxForce;
        [NMS(Index = 603)]
        /* 0x1198 */ public float DroneWarpMinForce;
        [NMS(Index = 602)]
        /* 0x119C */ public float DroneWarpTime;
        [NMS(Index = 592)]
        /* 0x11A0 */ public float EjectAnimSpeedFactor;
        [NMS(Index = 591)]
        /* 0x11A4 */ public float EjectAnimSwitchPoint;
        [NMS(Index = 193)]
        /* 0x11A8 */ public float EngineEffectsThrustContribution;
        [NMS(Index = 192)]
        /* 0x11AC */ public float EngineJetLightIntensityMultiplier;
        [NMS(Index = 159)]
        /* 0x11B0 */ public float ExhaustSpeed;
        [NMS(Index = 337)]
        /* 0x11B4 */ public float ExplorerTakeOffMod;
        [NMS(Index = 335)]
        /* 0x11B8 */ public float FighterTakeOffMod;
        [NMS(Index = 469)]
        /* 0x11BC */ public float FreighterApproachCombatDistanceMax;
        [NMS(Index = 468)]
        /* 0x11C0 */ public float FreighterApproachCombatDistanceMin;
        [NMS(Index = 478)]
        /* 0x11C4 */ public float FreighterApproachCombatMinSpeedFactor;
        [NMS(Index = 471)]
        /* 0x11C8 */ public float FreighterApproachDistanceMax;
        [NMS(Index = 470)]
        /* 0x11CC */ public float FreighterApproachDistanceMin;
        [NMS(Index = 477)]
        /* 0x11D0 */ public float FreighterApproachExtraMargin;
        [NMS(Index = 475)]
        /* 0x11D4 */ public float FreighterApproachExtraMarginCombat;
        [NMS(Index = 476)]
        /* 0x11D8 */ public float FreighterApproachExtraMarginPirate;
        [NMS(Index = 472)]
        /* 0x11DC */ public float FreighterApproachSpeedDamper;
        [NMS(Index = 73)]
        /* 0x11E0 */ public float FreighterBattleIgnoreFriendlyFireDistance;
        [NMS(Index = 1)]
        /* 0x11E4 */ public float FreighterBattleRangeBoost;
        [NMS(Index = 474)]
        /* 0x11E8 */ public float FreighterCombatBoostMul;
        [NMS(Index = 473)]
        /* 0x11EC */ public float FreighterCombatSpeedMul;
        [NMS(Index = 601)]
        /* 0x11F0 */ public float FreighterSpeed;
        [NMS(Index = 358)]
        /* 0x11F4 */ public float FrigateTargetLockRange;
        [NMS(Index = 440)]
        /* 0x11F8 */ public float GravityDropForce;
        [NMS(Index = 438)]
        /* 0x11FC */ public float GravityDropMaxForceHeight;
        [NMS(Index = 439)]
        /* 0x1200 */ public float GravityDropMaxHeight;
        [NMS(Index = 437)]
        /* 0x1204 */ public float GravityDropMinHeight;
        [NMS(Index = 295)]
        /* 0x1208 */ public float GroundHeightBrakeMultiplier;
        [NMS(Index = 294)]
        /* 0x120C */ public float GroundHeightDownSpeedMultiplier;
        [NMS(Index = 289)]
        /* 0x1210 */ public float GroundHeightHard;
        [NMS(Index = 290)]
        /* 0x1214 */ public float GroundHeightHardHorizontal;
        [NMS(Index = 288)]
        /* 0x1218 */ public float GroundHeightHardOverWater;
        [NMS(Index = 564)]
        /* 0x121C */ public float GroundHeightHardTimeMax;
        [NMS(Index = 563)]
        /* 0x1220 */ public float GroundHeightHardTimeMin;
        [NMS(Index = 569)]
        /* 0x1224 */ public int GroundHeightNumRays;
        [NMS(Index = 565)]
        /* 0x1228 */ public float GroundHeightPostCollisionDamper;
        [NMS(Index = 292)]
        /* 0x122C */ public float GroundHeightPostCollisionMultiplier;
        [NMS(Index = 293)]
        /* 0x1230 */ public float GroundHeightPostCollisionMultiplierTime;
        [NMS(Index = 570)]
        /* 0x1234 */ public float GroundHeightSmoothTime;
        [NMS(Index = 285)]
        /* 0x1238 */ public float GroundHeightSoft;
        [NMS(Index = 284)]
        /* 0x123C */ public float GroundHeightSoftForce;
        [NMS(Index = 286)]
        /* 0x1240 */ public float GroundHeightSoftHorizontal;
        [NMS(Index = 567)]
        /* 0x1244 */ public float GroundHeightSpeedAngle;
        [NMS(Index = 568)]
        /* 0x1248 */ public float GroundHeightSpeedAngleRange;
        [NMS(Index = 566)]
        /* 0x124C */ public float GroundHeightSpeedLength;
        [NMS(Index = 167)]
        /* 0x1250 */ public float GroundNearEffectBuildingFade;
        [NMS(Index = 164)]
        /* 0x1254 */ public float GroundNearEffectHeight;
        [NMS(Index = 109)]
        /* 0x1258 */ public float GroundNearEffectLightFactor;
        [NMS(Index = 166)]
        /* 0x125C */ public float GroundNearEffectNormalOffset;
        [NMS(Index = 165)]
        /* 0x1260 */ public float GroundNearEffectRange;
        [NMS(Index = 110)]
        /* 0x1264 */ public float GroundNearEffectWaterLightFactor;
        [NMS(Index = 111)]
        /* 0x1268 */ public float GroundWaterSpeedFactor;
        [NMS(Index = 454)]
        /* 0x126C */ public int GunAimLevel;
        [NMS(Index = 448)]
        /* 0x1270 */ public int GunAmmoMultiplier;
        [NMS(Index = 581)]
        /* 0x1274 */ public float GunOffset3rdPersonMultiplier;
        [NMS(Index = 45)]
        /* 0x1278 */ public float HandControllerActiveBlendMinTime;
        [NMS(Index = 46)]
        /* 0x127C */ public float HandControllerActiveBlendTime;
        [NMS(Index = 58)]
        /* 0x1280 */ public float HandControllerDirOffsetAngle;
        [NMS(Index = 59)]
        /* 0x1284 */ public float HandControllerDirOffsetAngleMove;
        [NMS(Index = 57)]
        /* 0x1288 */ public float HandControllerThrottleDeadZone;
        [NMS(Index = 55)]
        /* 0x128C */ public float HandControllerThrottleDistance;
        [NMS(Index = 56)]
        /* 0x1290 */ public float HandControllerThrottleRange;
        [NMS(Index = 53)]
        /* 0x1294 */ public float HandControllerXReorientation;
        [NMS(Index = 51)]
        /* 0x1298 */ public float HandControllerXReorientationMove;
        [NMS(Index = 54)]
        /* 0x129C */ public float HandControllerZReorientation;
        [NMS(Index = 52)]
        /* 0x12A0 */ public float HandControllerZReorientationMove;
        [NMS(Index = 334)]
        /* 0x12A4 */ public float HaulerTakeOffMod;
        [NMS(Index = 384)]
        /* 0x12A8 */ public int HitAsteroidDamage;
        [NMS(Index = 257)]
        /* 0x12AC */ public float HoverAlignTime;
        [NMS(Index = 259)]
        /* 0x12B0 */ public float HoverAlignTimeAlt;
        [NMS(Index = 424)]
        /* 0x12B4 */ public float HoverBrakeStrength;
        [NMS(Index = 261)]
        /* 0x12B8 */ public float HoverHeightFactor;
        [NMS(Index = 269)]
        /* 0x12BC */ public float HoverLandManeuvreBrake;
        [NMS(Index = 268)]
        /* 0x12C0 */ public float HoverLandManeuvreTimeHmdMax;
        [NMS(Index = 267)]
        /* 0x12C4 */ public float HoverLandManeuvreTimeHmdMin;
        [NMS(Index = 266)]
        /* 0x12C8 */ public float HoverLandManeuvreTimeMax;
        [NMS(Index = 265)]
        /* 0x12CC */ public float HoverLandManeuvreTimeMin;
        [NMS(Index = 270)]
        /* 0x12D0 */ public float HoverLandManeuvreTimeWaterMultiplier;
        [NMS(Index = 264)]
        /* 0x12D4 */ public float HoverLandReachedDistance;
        [NMS(Index = 263)]
        /* 0x12D8 */ public float HoverLandReachedMinTime;
        [NMS(Index = 416)]
        /* 0x12DC */ public float HoverMaxSpeed;
        [NMS(Index = 262)]
        /* 0x12E0 */ public float HoverMinSpeed;
        [NMS(Index = 260)]
        /* 0x12E4 */ public float HoverSpeedFactor;
        [NMS(Index = 417)]
        /* 0x12E8 */ public float HoverStopTime;
        [NMS(Index = 255)]
        /* 0x12EC */ public float HoverTakeoffHeight;
        [NMS(Index = 256)]
        /* 0x12F0 */ public float HoverTime;
        [NMS(Index = 258)]
        /* 0x12F4 */ public float HoverTimeAlt;
        [NMS(Index = 645)]
        /* 0x12F8 */ public float HUDBoostUpgradeMultiplier;
        [NMS(Index = 254)]
        /* 0x12FC */ public float KBThrustSmoothTime;
        [NMS(Index = 531)]
        /* 0x1300 */ public float LandGroundTakeOffTime;
        [NMS(Index = 533)]
        /* 0x1304 */ public float LandHeightThreshold;
        [NMS(Index = 537)]
        /* 0x1308 */ public float LandingAreaFloorOffset;
        [NMS(Index = 536)]
        /* 0x130C */ public float LandingAreaRadius;
        [NMS(Index = 282)]
        /* 0x1310 */ public float LandingButtonMinTime;
        [NMS(Index = 273)]
        /* 0x1314 */ public float LandingCheckBuildingRadiusFactor;
        [NMS(Index = 453)]
        /* 0x1318 */ public int LandingCost;
        [NMS(Index = 14)]
        /* 0x131C */ public float LandingDirectionalSideOffsetFactor;
        [NMS(Index = 525)]
        /* 0x1320 */ public float LandingHelperMinAngle;
        [NMS(Index = 527)]
        /* 0x1324 */ public float LandingHelperRollTime;
        [NMS(Index = 526)]
        /* 0x1328 */ public float LandingHelperTurnTime;
        [NMS(Index = 15)]
        /* 0x132C */ public float LandingHoverOffset;
        [NMS(Index = 20)]
        /* 0x1330 */ public float LandingMargin;
        [NMS(Index = 19)]
        /* 0x1334 */ public float LandingMaxAngle;
        [NMS(Index = 18)]
        /* 0x1338 */ public float LandingMaxSpeed;
        [NMS(Index = 21)]
        /* 0x133C */ public float LandingObstacleMinHeight;
        [NMS(Index = 271)]
        /* 0x1340 */ public float LandingOnGroundTip;
        [NMS(Index = 283)]
        /* 0x1344 */ public float LandingPushNoseUpFactor;
        [NMS(Index = 22)]
        /* 0x1348 */ public float LandingTooManyLowPointsFraction;
        [NMS(Index = 17)]
        /* 0x134C */ public float LandingWaterHoverHeight;
        [NMS(Index = 16)]
        /* 0x1350 */ public float LandingWaterHoverOffset;
        [NMS(Index = 532)]
        /* 0x1354 */ public float LandLookingForward;
        [NMS(Index = 418)]
        /* 0x1358 */ public float LandOffset;
        [NMS(Index = 535)]
        /* 0x135C */ public float LandSlopeMax;
        [NMS(Index = 534)]
        /* 0x1360 */ public float LandWidthThreshold;
        [NMS(Index = 450)]
        /* 0x1364 */ public int LaserAimLevel;
        [NMS(Index = 512)]
        /* 0x1368 */ public float LaserCoolFactor;
        [NMS(Index = 513)]
        /* 0x136C */ public float LaserFireTime;
        [NMS(Index = 511)]
        /* 0x1370 */ public float LaserOverheatDownTime;
        [NMS(Index = 510)]
        /* 0x1374 */ public float LaserOverheatTime;
        [NMS(Index = 514)]
        /* 0x1378 */ public float LaserWaitTime;
        [NMS(Index = 251)]
        /* 0x137C */ public float LateralDriftRange;
        [NMS(Index = 250)]
        /* 0x1380 */ public float LateralDriftRollAmount;
        [NMS(Index = 647)]
        /* 0x1384 */ public float LaunchThrustersMinimumSummonPercentage;
        [NMS(Index = 646)]
        /* 0x1388 */ public float LaunchThrustersRegenTimePeriod;
        [NMS(Index = 648)]
        /* 0x138C */ public float LaunchThrustersSummonCostMultiplier;
        [NMS(Index = 571)]
        /* 0x1390 */ public float LinearDamping;
        [NMS(Index = 351)]
        /* 0x1394 */ public float LockTargetMaxScale;
        [NMS(Index = 348)]
        /* 0x1398 */ public float LockTargetMinDistance;
        [NMS(Index = 350)]
        /* 0x139C */ public float LockTargetMinScale;
        [NMS(Index = 349)]
        /* 0x13A0 */ public float LockTargetRange;
        [NMS(Index = 577)]
        /* 0x13A4 */ public float LootAttractDistance;
        [NMS(Index = 578)]
        /* 0x13A8 */ public float LootAttractTime;
        [NMS(Index = 580)]
        /* 0x13AC */ public float LootCollectDistance;
        [NMS(Index = 579)]
        /* 0x13B0 */ public float LootDampForce;
        [NMS(Index = 160)]
        /* 0x13B4 */ public float LowAltitudeAnimationHeight;
        [NMS(Index = 161)]
        /* 0x13B8 */ public float LowAltitudeAnimationHysteresisTime;
        [NMS(Index = 162)]
        /* 0x13BC */ public float LowAltitudeAnimationTime;
        [NMS(Index = 163)]
        /* 0x13C0 */ public float LowAltitudeContrailFadeAtAnimProgress;
        [NMS(Index = 447)]
        /* 0x13C4 */ public float MarkerEventTime;
        [NMS(Index = 70)]
        /* 0x13C8 */ public float MaximumDistanceFromShipWhenExiting;
        [NMS(Index = 71)]
        /* 0x13CC */ public float MaximumHeightWhenExitingShip;
        [NMS(Index = 181)]
        /* 0x13D0 */ public float MaxOverspeedBrake;
        [NMS(Index = 653)]
        /* 0x13D4 */ public float MaxSpeedUpDistance;
        [NMS(Index = 654)]
        /* 0x13D8 */ public float MaxSpeedUpVelocity;
        [NMS(Index = 123)]
        /* 0x13DC */ public float MiniWarpAlignSlerp;
        [NMS(Index = 483)]
        /* 0x13E0 */ public float MiniWarpAlignStrength;
        [NMS(Index = 484)]
        /* 0x13E4 */ public float MiniWarpChargeTime;
        [NMS(Index = 488)]
        /* 0x13E8 */ public float MiniWarpCooldownTime;
        [NMS(Index = 494)]
        /* 0x13EC */ public float MiniWarpExitSpeed;
        [NMS(Index = 495)]
        /* 0x13F0 */ public float MiniWarpExitSpeedStation;
        [NMS(Index = 496)]
        /* 0x13F4 */ public float MiniWarpExitTime;
        [NMS(Index = 506)]
        /* 0x13F8 */ public float MiniWarpFlashDelay;
        [NMS(Index = 505)]
        /* 0x13FC */ public float MiniWarpFlashDuration;
        [NMS(Index = 504)]
        /* 0x1400 */ public float MiniWarpFlashIntensity;
        [NMS(Index = 482)]
        /* 0x1404 */ public float MiniWarpFuelTime;
        [NMS(Index = 497)]
        /* 0x1408 */ public float MiniWarpHUDArrowAttractAngle;
        [NMS(Index = 501)]
        /* 0x140C */ public float MiniWarpHUDArrowAttractAngleDense;
        [NMS(Index = 499)]
        /* 0x1410 */ public float MiniWarpHUDArrowAttractAngleOtherPlayerStuff;
        [NMS(Index = 500)]
        /* 0x1414 */ public float MiniWarpHUDArrowAttractAngleSaveBeacon;
        [NMS(Index = 498)]
        /* 0x1418 */ public float MiniWarpHUDArrowAttractAngleStation;
        [NMS(Index = 502)]
        /* 0x141C */ public int MiniWarpHUDArrowNumMarkersToBeDense;
        [NMS(Index = 436)]
        /* 0x1420 */ public float MiniWarpLinesHeight;
        [NMS(Index = 433)]
        /* 0x1424 */ public int MiniWarpLinesNum;
        [NMS(Index = 435)]
        /* 0x1428 */ public float MiniWarpLinesOffset;
        [NMS(Index = 434)]
        /* 0x142C */ public float MiniWarpLinesSpacing;
        [NMS(Index = 121)]
        /* 0x1430 */ public float MiniWarpMarkerAlignSlowdown;
        [NMS(Index = 122)]
        /* 0x1434 */ public float MiniWarpMarkerAlignSlowdownRange;
        [NMS(Index = 120)]
        /* 0x1438 */ public float MiniWarpMarkerApproachSlowdown;
        [NMS(Index = 490)]
        /* 0x143C */ public float MiniWarpMinPlanetDistance;
        [NMS(Index = 507)]
        /* 0x1440 */ public float MiniWarpNoAsteroidRadius;
        [NMS(Index = 480)]
        /* 0x1444 */ public float MiniWarpPlanetRadius;
        [NMS(Index = 479)]
        /* 0x1448 */ public float MiniWarpShakeStrength;
        [NMS(Index = 485)]
        /* 0x144C */ public float MiniWarpSpeed;
        [NMS(Index = 481)]
        /* 0x1450 */ public float MiniWarpStationRadius;
        [NMS(Index = 491)]
        /* 0x1454 */ public float MiniWarpStoppingMarginDefault;
        [NMS(Index = 492)]
        /* 0x1458 */ public float MiniWarpStoppingMarginLong;
        [NMS(Index = 489)]
        /* 0x145C */ public float MiniWarpStoppingMarginPlanet;
        [NMS(Index = 487)]
        /* 0x1460 */ public float MiniWarpTime;
        [NMS(Index = 486)]
        /* 0x1464 */ public float MiniWarpTopSpeedTime;
        [NMS(Index = 493)]
        /* 0x1468 */ public float MiniWarpTrackingMargin;
        [NMS(Index = 456)]
        /* 0x146C */ public float MissileLockSpeedUp;
        [NMS(Index = 457)]
        /* 0x1470 */ public float MissileLockTime;
        [NMS(Index = 410)]
        /* 0x1474 */ public float MissileShootTime;
        [NMS(Index = 394)]
        /* 0x1478 */ public float MuzzleAnimSpeed;
        [NMS(Index = 393)]
        /* 0x147C */ public float MuzzleLightIntensity;
        [NMS(Index = 116)]
        /* 0x1480 */ public float NearGroundPitchCorrectMinHeight;
        [NMS(Index = 118)]
        /* 0x1484 */ public float NearGroundPitchCorrectMinHeightRemote;
        [NMS(Index = 117)]
        /* 0x1488 */ public float NearGroundPitchCorrectRange;
        [NMS(Index = 119)]
        /* 0x148C */ public float NearGroundPitchCorrectRangeRemote;
        [NMS(Index = 144)]
        /* 0x1490 */ public float NetworkDockSearchRadius;
        [NMS(Index = 369)]
        /* 0x1494 */ public float NoBoostAnomalyDistance;
        [NMS(Index = 376)]
        /* 0x1498 */ public float NoBoostCombatEventMinBattleTime;
        [NMS(Index = 377)]
        /* 0x149C */ public float NoBoostCombatEventMinFreighterBattleTime;
        [NMS(Index = 378)]
        /* 0x14A0 */ public float NoBoostCombatEventTime;
        [NMS(Index = 372)]
        /* 0x14A4 */ public float NoBoostFreighterAngle;
        [NMS(Index = 371)]
        /* 0x14A8 */ public float NoBoostFreighterDistance;
        [NMS(Index = 373)]
        /* 0x14AC */ public float NoBoostShipDistance;
        [NMS(Index = 375)]
        /* 0x14B0 */ public float NoBoostShipLastHitTime;
        [NMS(Index = 374)]
        /* 0x14B4 */ public float NoBoostShipNearMinTime;
        [NMS(Index = 370)]
        /* 0x14B8 */ public float NoBoostSpaceAnomalyDistance;
        [NMS(Index = 368)]
        /* 0x14BC */ public float NoBoostStationDistance;
        [NMS(Index = 114)]
        /* 0x14C0 */ public float OutpostDockSpeedAlignMinDistance;
        [NMS(Index = 115)]
        /* 0x14C4 */ public float OutpostDockSpeedAlignRange;
        [NMS(Index = 253)]
        /* 0x14C8 */ public float PadThrustSmoothTime;
        [NMS(Index = 252)]
        /* 0x14CC */ public float PadTurnSpeed;
        [NMS(Index = 302)]
        /* 0x14D0 */ public float PitchCorrectCockpitSpring;
        [NMS(Index = 301)]
        /* 0x14D4 */ public float PitchCorrectDownSpeedHeightMax;
        [NMS(Index = 300)]
        /* 0x14D8 */ public float PitchCorrectDownSpeedHeightMin;
        [NMS(Index = 299)]
        /* 0x14DC */ public float PitchCorrectDownSpeedMaxDownAngle;
        [NMS(Index = 296)]
        /* 0x14E0 */ public float PitchCorrectDownSpeedMinSpeed;
        [NMS(Index = 297)]
        /* 0x14E4 */ public float PitchCorrectDownSpeedRange;
        [NMS(Index = 298)]
        /* 0x14E8 */ public float PitchCorrectDownSpeedSoftAngle;
        [NMS(Index = 314)]
        /* 0x14EC */ public float PitchCorrectHeightMax;
        [NMS(Index = 313)]
        /* 0x14F0 */ public float PitchCorrectHeightMin;
        [NMS(Index = 312)]
        /* 0x14F4 */ public float PitchCorrectHeightSpring;
        [NMS(Index = 304)]
        /* 0x14F8 */ public float PitchCorrectMaxDownAngle;
        [NMS(Index = 305)]
        /* 0x14FC */ public float PitchCorrectMaxDownAnglePostCollision;
        [NMS(Index = 307)]
        /* 0x1500 */ public float PitchCorrectMaxDownAngleWater;
        [NMS(Index = 303)]
        /* 0x1504 */ public float PitchCorrectSoftDownAngle;
        [NMS(Index = 306)]
        /* 0x1508 */ public float PitchCorrectSoftDownAnglePostCollision;
        [NMS(Index = 308)]
        /* 0x150C */ public float PitchCorrectSoftDownAngleWater;
        [NMS(Index = 311)]
        /* 0x1510 */ public float PitchCorrectTimeHeight;
        [NMS(Index = 310)]
        /* 0x1514 */ public float PitchCorrectTimeMax;
        [NMS(Index = 309)]
        /* 0x1518 */ public float PitchCorrectTimeMin;
        [NMS(Index = 387)]
        /* 0x151C */ public float PlayerFreighterClearSpaceRadius;
        [NMS(Index = 183)]
        /* 0x1520 */ public float PostFreighterWarpTransitionTime;
        [NMS(Index = 182)]
        /* 0x1524 */ public float PostWarpSlowDownTime;
        [NMS(Index = 329)]
        /* 0x1528 */ public float PowerSettingEngineDamper;
        [NMS(Index = 328)]
        /* 0x152C */ public float PowerSettingEngineMul;
        [NMS(Index = 333)]
        /* 0x1530 */ public float PowerSettingShieldDamper;
        [NMS(Index = 332)]
        /* 0x1534 */ public float PowerSettingShieldMul;
        [NMS(Index = 331)]
        /* 0x1538 */ public float PowerSettingWeaponDamper;
        [NMS(Index = 330)]
        /* 0x153C */ public float PowerSettingWeaponMul;
        [NMS(Index = 518)]
        /* 0x1540 */ public int ProjectileClipSize;
        [NMS(Index = 516)]
        /* 0x1544 */ public float ProjectileFireRate;
        [NMS(Index = 515)]
        /* 0x1548 */ public float ProjectileOverheatTime;
        [NMS(Index = 517)]
        /* 0x154C */ public float ProjectileReloadTime;
        [NMS(Index = 25)]
        /* 0x1550 */ public float PulseDriveBoostDoubleTapTime;
        [NMS(Index = 186)]
        /* 0x1554 */ public float PulseDrivePlanetApproachHeight;
        [NMS(Index = 185)]
        /* 0x1558 */ public float PulseDrivePlanetApproachMaxAngle;
        [NMS(Index = 184)]
        /* 0x155C */ public float PulseDrivePlanetApproachMinAngle;
        [NMS(Index = 37)]
        /* 0x1560 */ public float PulseDriveStationApproachAngleMin;
        [NMS(Index = 38)]
        /* 0x1564 */ public float PulseDriveStationApproachAngleRange;
        [NMS(Index = 41)]
        /* 0x1568 */ public float PulseDriveStationApproachOffset;
        [NMS(Index = 39)]
        /* 0x156C */ public float PulseDriveStationApproachPerpAngleMin;
        [NMS(Index = 40)]
        /* 0x1570 */ public float PulseDriveStationApproachPerpAngleRange;
        [NMS(Index = 42)]
        /* 0x1574 */ public float PulseDriveStationApproachSlowdown;
        [NMS(Index = 44)]
        /* 0x1578 */ public float PulseDriveStationApproachSlowdownRange;
        [NMS(Index = 43)]
        /* 0x157C */ public float PulseDriveStationApproachSlowdownRangeMin;
        [NMS(Index = 363)]
        /* 0x1580 */ public float RemotePlayerLockTimeAfterShot;
        [NMS(Index = 359)]
        /* 0x1584 */ public float ResetTargetLockAngle;
        [NMS(Index = 442)]
        /* 0x1588 */ public float ResourceCollectOffset;
        [NMS(Index = 338)]
        /* 0x158C */ public float RoyalTakeOffMod;
        [NMS(Index = 36)]
        /* 0x1590 */ public float RudderToRollAngleDownMax;
        [NMS(Index = 35)]
        /* 0x1594 */ public float RudderToRollAngleDownMin;
        [NMS(Index = 34)]
        /* 0x1598 */ public float RudderToRollAngleUpMax;
        [NMS(Index = 31)]
        /* 0x159C */ public float RudderToRollCutoffRotation;
        [NMS(Index = 30)]
        /* 0x15A0 */ public float RudderToRollMultiplierLow;
        [NMS(Index = 27)]
        /* 0x15A4 */ public float RudderToRollMultiplierMax;
        [NMS(Index = 26)]
        /* 0x15A8 */ public float RudderToRollMultiplierMin;
        [NMS(Index = 28)]
        /* 0x15AC */ public float RudderToRollMultiplierOpposite;
        [NMS(Index = 29)]
        /* 0x15B0 */ public float RudderToRollMultiplierSpace;
        [NMS(Index = 32)]
        /* 0x15B4 */ public float RudderToRollUpsideDownRotation;
        [NMS(Index = 610)]
        /* 0x15B8 */ public float ShakeAlignBrake;
        [NMS(Index = 608)]
        /* 0x15BC */ public float ShakeMaxPower;
        [NMS(Index = 609)]
        /* 0x15C0 */ public float ShakeMaxSpeed;
        [NMS(Index = 606)]
        /* 0x15C4 */ public float ShakePowerScaler;
        [NMS(Index = 607)]
        /* 0x15C8 */ public float ShakeSpeed;
        [NMS(Index = 195)]
        /* 0x15CC */ public float ShieldEffectHitTime;
        [NMS(Index = 5)]
        /* 0x15D0 */ public float ShieldLeechMul;
        [NMS(Index = 366)]
        /* 0x15D4 */ public float ShieldRechargeMinHitTime;
        [NMS(Index = 367)]
        /* 0x15D8 */ public float ShieldRechargeRate;
        [NMS(Index = 594)]
        /* 0x15DC */ public float ShipDifferentRepelAmount;
        [NMS(Index = 593)]
        /* 0x15E0 */ public float ShipDifferentRepelRange;
        [NMS(Index = 640)]
        /* 0x15E4 */ public float ShipEnterAngle;
        [NMS(Index = 643)]
        /* 0x15E8 */ public float ShipEnterMinTime;
        [NMS(Index = 639)]
        /* 0x15EC */ public float ShipEnterRange;
        [NMS(Index = 642)]
        /* 0x15F0 */ public float ShipEnterSpeed;
        [NMS(Index = 641)]
        /* 0x15F4 */ public float ShipEnterTransitionTime;
        [NMS(Index = 509)]
        /* 0x15F8 */ public float ShipHeatAlertTime;
        [NMS(Index = 430)]
        /* 0x15FC */ public float ShipMotionDeadZone;
        [NMS(Index = 3)]
        /* 0x1600 */ public float ShipThrottleBrakeVibrationStrength;
        [NMS(Index = 2)]
        /* 0x1604 */ public float ShipThrottleNotchVibrationStrength;
        [NMS(Index = 4)]
        /* 0x1608 */ public float ShipThrustReverseThreshhold;
        [NMS(Index = 336)]
        /* 0x160C */ public float ShuttleTakeOffMod;
        [NMS(Index = 546)]
        /* 0x1610 */ public float SpaceBrakeAngularRange;
        [NMS(Index = 545)]
        /* 0x1614 */ public float SpaceBrakeMinAngularSpeed;
        [NMS(Index = 659)]
        /* 0x1618 */ public float SpaceCombatFollowModeAimTime;
        [NMS(Index = 663)]
        /* 0x161C */ public float SpaceCombatFollowModeBrakeBehindAngle;
        [NMS(Index = 661)]
        /* 0x1620 */ public float SpaceCombatFollowModeEvadeRoll;
        [NMS(Index = 666)]
        /* 0x1624 */ public float SpaceCombatFollowModeEvadeThrust;
        [NMS(Index = 662)]
        /* 0x1628 */ public float SpaceCombatFollowModeEvadeTime;
        [NMS(Index = 664)]
        /* 0x162C */ public float SpaceCombatFollowModeMaxBrakeBehind;
        [NMS(Index = 665)]
        /* 0x1630 */ public float SpaceCombatFollowModeMaxBrakeHeadOn;
        [NMS(Index = 658)]
        /* 0x1634 */ public float SpaceCombatFollowModeMaxTorque;
        [NMS(Index = 660)]
        /* 0x1638 */ public float SpaceCombatFollowModeTargetDistance;
        [NMS(Index = 383)]
        /* 0x163C */ public float SpeedCoolNormalSpeedAmount;
        [NMS(Index = 382)]
        /* 0x1640 */ public float SpeedCoolOffset;
        [NMS(Index = 650)]
        /* 0x1644 */ public float SpeedUpDistanceFadeThreshold;
        [NMS(Index = 649)]
        /* 0x1648 */ public float SpeedUpDistanceThreshold;
        [NMS(Index = 652)]
        /* 0x164C */ public float SpeedUpVelocityCoeff;
        [NMS(Index = 651)]
        /* 0x1650 */ public float SpeedUpVelocityThreshold;
        [NMS(Index = 237)]
        /* 0x1654 */ public float SpringSpeedBoosting;
        [NMS(Index = 238)]
        /* 0x1658 */ public float SpringSpeedBraking;
        [NMS(Index = 235)]
        /* 0x165C */ public float SpringSpeedDefault;
        [NMS(Index = 236)]
        /* 0x1660 */ public float SpringSpeedRolling;
        [NMS(Index = 234)]
        /* 0x1664 */ public float SpringSpeedSpringSpeedIn;
        [NMS(Index = 233)]
        /* 0x1668 */ public float SpringSpeedSpringSpeedOut;
        [NMS(Index = 655)]
        /* 0x166C */ public float StickLandThreshold;
        [NMS(Index = 656)]
        /* 0x1670 */ public float StickPulseThreshold;
        [NMS(Index = 429)]
        /* 0x1674 */ public float StickyStickAngle;
        [NMS(Index = 426)]
        /* 0x1678 */ public float StickyTurnAngleRange;
        [NMS(Index = 428)]
        /* 0x167C */ public float StickyTurnHigh;
        [NMS(Index = 427)]
        /* 0x1680 */ public float StickyTurnLow;
        [NMS(Index = 425)]
        /* 0x1684 */ public float StickyTurnMinAngle;
        [NMS(Index = 520)]
        /* 0x1688 */ public float SummonShipAnywhereFwdOffset;
        [NMS(Index = 519)]
        /* 0x168C */ public float SummonShipAnywhereHeightOffset;
        [NMS(Index = 521)]
        /* 0x1690 */ public float SummonShipAnywhereRangeMax;
        [NMS(Index = 522)]
        /* 0x1694 */ public float SummonShipAnywhereRangeMin;
        [NMS(Index = 524)]
        /* 0x1698 */ public float SummonShipApproachOffset;
        [NMS(Index = 523)]
        /* 0x169C */ public float SummonShipHeightOffset;
        [NMS(Index = 452)]
        /* 0x16A0 */ public int TakeOffCost;
        [NMS(Index = 529)]
        /* 0x16A4 */ public float TakeOffSphereCastLength;
        [NMS(Index = 530)]
        /* 0x16A8 */ public float TakeOffSphereCastRadiusMul;
        [NMS(Index = 360)]
        /* 0x16AC */ public float TargetLockAngleTorpedo;
        [NMS(Index = 539)]
        /* 0x16B0 */ public float TargetLockChangeTime;
        [NMS(Index = 540)]
        /* 0x16B4 */ public float TargetLockLoseTime;
        [NMS(Index = 362)]
        /* 0x16B8 */ public float TargetLockNearestAngle;
        [NMS(Index = 361)]
        /* 0x16BC */ public float TargetLockRange;
        [NMS(Index = 538)]
        /* 0x16C0 */ public float TargetLockTime;
        [NMS(Index = 189)]
        /* 0x16C4 */ public float TestJetsBoost;
        [NMS(Index = 187)]
        /* 0x16C8 */ public float TestJetsStage1;
        [NMS(Index = 188)]
        /* 0x16CC */ public float TestJetsStage2;
        [NMS(Index = 194)]
        /* 0x16D0 */ public float TestShieldEffect;
        [NMS(Index = 173)]
        /* 0x16D4 */ public float TestShipAnimLowAltitude;
        [NMS(Index = 171)]
        /* 0x16D8 */ public float TestShipAnimPulse;
        [NMS(Index = 169)]
        /* 0x16DC */ public float TestShipAnimRoll;
        [NMS(Index = 172)]
        /* 0x16E0 */ public float TestShipAnimSpace;
        [NMS(Index = 170)]
        /* 0x16E4 */ public float TestShipAnimThrust;
        [NMS(Index = 87)]
        /* 0x16E8 */ public float TestTrailRadius;
        [NMS(Index = 86)]
        /* 0x16EC */ public float TestTrailSpeed;
        [NMS(Index = 190)]
        /* 0x16F0 */ public float TestTrailThreshold;
        [NMS(Index = 379)]
        /* 0x16F4 */ public float ThrustDecaySpring;
        [NMS(Index = 380)]
        /* 0x16F8 */ public float ThrustDecaySpringCombat;
        [NMS(Index = 85)]
        /* 0x16FC */ public int TrailMaxNumPointsPerFrameOverride;
        [NMS(Index = 179)]
        /* 0x1700 */ public float TrailVelocityFactor;
        [NMS(Index = 392)]
        /* 0x1704 */ public float TurnRudderStrength;
        [NMS(Index = 23)]
        /* 0x1708 */ public float VignetteAmountAcceleration;
        [NMS(Index = 24)]
        /* 0x170C */ public float VignetteAmountTurning;
        [NMS(Index = 89)]
        /* 0x1710 */ public float WarpAnimMaxSpeed;
        [NMS(Index = 88)]
        /* 0x1714 */ public float WarpAnimMinSpeed;
        [NMS(Index = 132)]
        /* 0x1718 */ public float WarpFadeInTime;
        [NMS(Index = 125)]
        /* 0x171C */ public float WarpInFlashTime;
        [NMS(Index = 129)]
        /* 0x1720 */ public float WarpInFlashTimeFreighter;
        [NMS(Index = 138)]
        /* 0x1724 */ public float WarpInFlashTimeNexus;
        [NMS(Index = 133)]
        /* 0x1728 */ public float WarpInLineWidth;
        [NMS(Index = 126)]
        /* 0x172C */ public float WarpInRange;
        [NMS(Index = 130)]
        /* 0x1730 */ public float WarpInRangeFreighter;
        [NMS(Index = 139)]
        /* 0x1734 */ public float WarpInRangeNexus;
        [NMS(Index = 124)]
        /* 0x1738 */ public float WarpInTime;
        [NMS(Index = 128)]
        /* 0x173C */ public float WarpInTimeFreighter;
        [NMS(Index = 137)]
        /* 0x1740 */ public float WarpInTimeNexus;
        [NMS(Index = 143)]
        /* 0x1744 */ public float WarpNexusDistance;
        [NMS(Index = 142)]
        /* 0x1748 */ public float WarpNexusPitch;
        [NMS(Index = 141)]
        /* 0x174C */ public float WarpNexusRotation;
        [NMS(Index = 135)]
        /* 0x1750 */ public float WarpOutRange;
        [NMS(Index = 136)]
        /* 0x1754 */ public float WarpOutTime;
        [NMS(Index = 127)]
        /* 0x1758 */ public float WarpScale;
        [NMS(Index = 131)]
        /* 0x175C */ public float WarpScaleFreighter;
        [NMS(Index = 140)]
        /* 0x1760 */ public float WarpScaleNexus;
        [NMS(Index = 105)]
        /* 0x1764 */ public float WaterEffectScaler;
        [NMS(Index = 248)]
        /* 0x1768 */ public float WeaponDamagePotentialReferenceRange;
        [NMS(Index = 625)]
        /* 0x176C */ public float WingmanAlign;
        [NMS(Index = 626)]
        /* 0x1770 */ public float WingmanAngle;
        [NMS(Index = 627)]
        /* 0x1774 */ public float WingmanAngle2;
        [NMS(Index = 620)]
        /* 0x1778 */ public float WingmanAttackAimAngle;
        [NMS(Index = 618)]
        /* 0x177C */ public float WingmanAttackAngle;
        [NMS(Index = 623)]
        /* 0x1780 */ public float WingmanAttackCoolTime;
        [NMS(Index = 617)]
        /* 0x1784 */ public float WingmanAttackMinRange;
        [NMS(Index = 615)]
        /* 0x1788 */ public float WingmanAttackOffset;
        [NMS(Index = 616)]
        /* 0x178C */ public float WingmanAttackRange;
        [NMS(Index = 621)]
        /* 0x1790 */ public float WingmanAttackTime;
        [NMS(Index = 622)]
        /* 0x1794 */ public float WingmanAttackTimeout;
        [NMS(Index = 612)]
        /* 0x1798 */ public float WingmanAtTime;
        [NMS(Index = 613)]
        /* 0x179C */ public float WingmanAtTimeBack;
        [NMS(Index = 611)]
        /* 0x17A0 */ public float WingmanAtTimeStart;
        [NMS(Index = 629)]
        /* 0x17A4 */ public float WingmanFwd1;
        [NMS(Index = 630)]
        /* 0x17A8 */ public float WingmanFwd2;
        [NMS(Index = 614)]
        /* 0x17AC */ public float WingmanPerpTime;
        [NMS(Index = 628)]
        /* 0x17B0 */ public float WingmanRadius;
        [NMS(Index = 624)]
        /* 0x17B4 */ public float WingmanSpawnDist;
        [NMS(Index = 98)]
        /* 0x17B8 */ public float WingmanSpeedApproachSpeed;
        [NMS(Index = 99)]
        /* 0x17BC */ public float WingmanSpeedApproachSpeedSpace;
        [NMS(Index = 96)]
        /* 0x17C0 */ public float WingmanSpeedTrackDistance;
        [NMS(Index = 94)]
        /* 0x17C4 */ public float WingmanSpeedTrackForceMax;
        [NMS(Index = 95)]
        /* 0x17C8 */ public float WingmanSpeedTrackForceMin;
        [NMS(Index = 97)]
        /* 0x17CC */ public float WingmanSpeedTrackOffset;
        [NMS(Index = 619)]
        /* 0x17D0 */ public float WingmanViewerAngle;
        [NMS(Index = 0)]
        /* 0x17D4 */ public NMSString0x20 HoverShipDataName;
        [NMS(Index = 76)]
        /* 0x17F4 */ public bool _3rdPersonShipEnabled;
        [NMS(Index = 231)]
        /* 0x17F5 */ public TkCurveType _3rdPersonWarpWanderCurve;
        [NMS(Index = 9)]
        /* 0x17F6 */ public bool AddShipToCollectionOnEnter;
        [NMS(Index = 77)]
        /* 0x17F7 */ public bool AimZoomAuto;
        [NMS(Index = 8)]
        /* 0x17F8 */ public bool AllowSideScreenPointing;
        [NMS(Index = 404)]
        /* 0x17F9 */ public bool AltAtmosphere;
        [NMS(Index = 74)]
        /* 0x17FA */ public bool AltControls;
        [NMS(Index = 82)]
        /* 0x17FB */ public bool ApplyHeightAlign;
        [NMS(Index = 81)]
        /* 0x17FC */ public bool ApplyHeightForce;
        [NMS(Index = 356)]
        /* 0x17FD */ public bool AutoEjectOnLanding;
        [NMS(Index = 93)]
        /* 0x17FE */ public TkCurveType CockpitExitAnimCurve;
        [NMS(Index = 79)]
        /* 0x17FF */ public bool CritsFromBehind;
        [NMS(Index = 561)]
        /* 0x1800 */ public TkCurveType DeflectCurve;
        [NMS(Index = 158)]
        /* 0x1801 */ public TkCurveType DirectionDockingIndicatorCurve;
        [NMS(Index = 83)]
        /* 0x1802 */ public bool DoPreCollision;
        [NMS(Index = 80)]
        /* 0x1803 */ public bool DrawLineLockTarget;
        [NMS(Index = 78)]
        /* 0x1804 */ public bool EnableDepthTestedCrosshairSections;
        [NMS(Index = 10)]
        /* 0x1805 */ public bool EnablePulseDriveSpaceStationOrient;
        [NMS(Index = 291)]
        /* 0x1806 */ public TkCurveType GroundHeightHardCurve;
        [NMS(Index = 287)]
        /* 0x1807 */ public TkCurveType GroundHeightSoftCurve;
        [NMS(Index = 357)]
        /* 0x1808 */ public bool LandedCockpitFreeLook;
        [NMS(Index = 272)]
        /* 0x1809 */ public bool LandingCheckBuildings;
        [NMS(Index = 316)]
        /* 0x180A */ public TkCurveType LandingCurve;
        [NMS(Index = 317)]
        /* 0x180B */ public TkCurveType LandingCurveHeavy;
        [NMS(Index = 318)]
        /* 0x180C */ public TkCurveType LandingCurveWater;
        [NMS(Index = 503)]
        /* 0x180D */ public TkCurveType MiniWarpCurve;
        [NMS(Index = 315)]
        /* 0x180E */ public TkCurveType PitchCorrectHeightCurve;
        [NMS(Index = 33)]
        /* 0x180F */ public TkCurveType RudderToRollCurve;
        [NMS(Index = 196)]
        /* 0x1810 */ public TkCurveType ShieldEffectHitCurve;
        [NMS(Index = 668)]
        /* 0x1811 */ public bool SpaceCombatFollowModeUseBoost;
        [NMS(Index = 667)]
        /* 0x1812 */ public bool SpaceCombatFollowModeUseEvadeTarget;
        [NMS(Index = 75)]
        /* 0x1813 */ public bool SpaceMapInWorld;
        [NMS(Index = 84)]
        /* 0x1814 */ public bool SpeedTrackModeEnabled;
        [NMS(Index = 232)]
        /* 0x1815 */ public bool SpringSpeedSpringEnabled;
        [NMS(Index = 168)]
        /* 0x1816 */ public bool TestShipAnims;
        [NMS(Index = 134)]
        /* 0x1817 */ public TkCurveType WarpInCurve;
    }
}
