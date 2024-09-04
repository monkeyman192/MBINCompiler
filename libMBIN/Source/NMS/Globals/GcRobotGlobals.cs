using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x59F9E1BF1D6F8CD0, NameHash = 0x29022DE4)]
    public class GcRobotGlobals : NMSTemplate
    {
        [NMS(Index = 307)]
        /* 0x0000 */ public GcDroneData DroneControl;
        [NMS(Index = 108)]
        /* 0x0330 */ public GcScanEffectData DroneScanEffect;
        [NMS(Index = 306)]
        /* 0x0380 */ public GcRobotLaserData QuadLaser;
        [NMS(Index = 305)]
        /* 0x03D0 */ public GcRobotLaserData WalkerLaser;
        [NMS(Index = 76)]
        /* 0x0420 */ public Vector3f DroneCriticalOffset;
        [NMS(Index = 45)]
        /* 0x0430 */ public Vector3f DroneRepairOffset;
        [NMS(Index = 75)]
        /* 0x0440 */ public Vector3f QuadCriticalOffset;
        [NMS(Index = 77)]
        /* 0x0450 */ public Vector3f WalkerGunOffset1;
        [NMS(Index = 78)]
        /* 0x0460 */ public Vector3f WalkerGunOffset2;
        [NMS(Index = 220)]
        /* 0x0470 */ public Vector3f WalkerHeadEyeOffset;
        [NMS(Index = 308, Size = 0x4, EnumType = typeof(GcSentinelQuadWeaponMode.SentinelQuadWeaponModeEnum))]
        /* 0x0480 */ public GcSentinelQuadWeaponData[] QuadWeapons;
        [NMS(Index = 310, Size = 0xB, EnumType = typeof(GcSentinelTypes.SentinelTypeEnum))]
        /* 0x07A0 */ public GcSentinelDamagedData[] DamageData;
        [NMS(Index = 110, Size = 0xB, EnumType = typeof(GcSentinelTypes.SentinelTypeEnum))]
        /* 0x0A60 */ public GcSentinelResource[] SentinelResources;
        [NMS(Index = 181, Size = 0x3, EnumType = typeof(GcSentinelMechWeaponMode.SentinelMechWeaponModeEnum))]
        /* 0x0C18 */ public GcSentinelMechWeaponData[] SentinelMechWeaponData;
        [NMS(Index = 1)]
        /* 0x0D98 */ public GcCamouflageData RobotCamoData;
        [NMS(Index = 83)]
        /* 0x0DC8 */ public NMSString0x10 AttackScan;
        [NMS(Index = 309)]
        /* 0x0DD8 */ public List<GcDroneWeaponData> DroneWeapons;
        [NMS(Index = 2)]
        /* 0x0DE8 */ public NMSString0x10 ForceDroneWeapon;
        [NMS(Index = 150)]
        /* 0x0DF8 */ public NMSString0x10 RepairEffect;
        [NMS(Index = 292)]
        /* 0x0E08 */ public NMSString0x10 SummonerDroneBuildupEffect;
        [NMS(Index = 293)]
        /* 0x0E18 */ public NMSString0x10 SummonerDroneSpawnEffect;
        [NMS(Index = 206)]
        /* 0x0E28 */ public List<NMSString0x20> WalkerLeftLegArmourNodes;
        [NMS(Index = 207)]
        /* 0x0E38 */ public List<NMSString0x20> WalkerRightLegArmourNodes;
        [NMS(Index = 203)]
        /* 0x0E48 */ public NMSString0x10 WalkerTitanFallEffect;
        [NMS(Index = 205)]
        /* 0x0E58 */ public NMSString0x10 WalkerTitanFallShake;
        [NMS(Index = 311, Size = 0xB, EnumType = typeof(GcSentinelTypes.SentinelTypeEnum))]
        /* 0x0E68 */ public GcSentinelPounceBalance[] PounceData;
        [NMS(Index = 164)]
        /* 0x0FC8 */ public GcMechTargetSelectionWeightingSettings MechTargetSelectionWeightingSettings;
        [NMS(Index = 304, Size = 0xB, EnumType = typeof(GcSentinelTypes.SentinelTypeEnum))]
        /* 0x0FF8 */ public float[] FireRateModifierScores;
        [NMS(Index = 109, Size = 0xB, EnumType = typeof(GcSentinelTypes.SentinelTypeEnum))]
        /* 0x1024 */ public int[] SentinelSpawnLimits;
        [NMS(Index = 180)]
        /* 0x1050 */ public Vector2f MechPatrolPauseTime;
        [NMS(Index = 51)]
        /* 0x1058 */ public Vector2f QuadAttackTurnSpeeds;
        [NMS(Index = 48)]
        /* 0x1060 */ public Vector2f QuadLookTurnSpeeds;
        [NMS(Index = 267)]
        /* 0x1068 */ public Vector2f QuadPatrolPauseTime;
        [NMS(Index = 284)]
        /* 0x1070 */ public float AttackMoveArrivalDistance;
        [NMS(Index = 283)]
        /* 0x1074 */ public float AttackMoveMaxTime;
        [NMS(Index = 6)]
        /* 0x1078 */ public int AttackSentinelWantedValue;
        [NMS(Index = 113)]
        /* 0x107C */ public float CollisionDistance;
        [NMS(Index = 92)]
        /* 0x1080 */ public float CombatSpawnSquadRadiusDrones;
        [NMS(Index = 93)]
        /* 0x1084 */ public float CombatSpawnSquadRadiusRobots;
        [NMS(Index = 53)]
        /* 0x1088 */ public float CombatWaveSpawnTime;
        [NMS(Index = 142)]
        /* 0x108C */ public float CorruptedDroneRepairInteruptCooldownTime;
        [NMS(Index = 66)]
        /* 0x1090 */ public float CriticalHitSizeDrone;
        [NMS(Index = 68)]
        /* 0x1094 */ public float CriticalHitSizeMech;
        [NMS(Index = 67)]
        /* 0x1098 */ public float CriticalHitSizeQuad;
        [NMS(Index = 69)]
        /* 0x109C */ public float CriticalHitSizeWalker;
        [NMS(Index = 100)]
        /* 0x10A0 */ public float DroneAggressiveInvestigateAttackTime;
        [NMS(Index = 52)]
        /* 0x10A4 */ public int DroneAggroDamage;
        [NMS(Index = 99)]
        /* 0x10A8 */ public float DroneAttackGetInRangeBoost;
        [NMS(Index = 29)]
        /* 0x10AC */ public float DroneAttackMaxAngleDownFromPlayer;
        [NMS(Index = 28)]
        /* 0x10B0 */ public float DroneAttackPlayerHeightOffset;
        [NMS(Index = 91)]
        /* 0x10B4 */ public float DroneCombatSpawnAngle;
        [NMS(Index = 126)]
        /* 0x10B8 */ public float DroneCrimeCooldown;
        [NMS(Index = 127)]
        /* 0x10BC */ public float DroneCrimeCooldownWaitTime;
        [NMS(Index = 128)]
        /* 0x10C0 */ public float DroneCrimeCooldownWaitTimeAtMax;
        [NMS(Index = 20)]
        /* 0x10C4 */ public float DroneCrimePostInvestigateWaitTime;
        [NMS(Index = 57)]
        /* 0x10C8 */ public float DroneCrimeWitnessInvestigateDistance;
        [NMS(Index = 104)]
        /* 0x10CC */ public float DroneCriminalScanTime;
        [NMS(Index = 131)]
        /* 0x10D0 */ public float DroneDecisionTime;
        [NMS(Index = 98)]
        /* 0x10D4 */ public float DroneHeightAngle;
        [NMS(Index = 120)]
        /* 0x10D8 */ public float DroneHitImpulseCooldown;
        [NMS(Index = 116)]
        /* 0x10DC */ public float DroneHitImpulseFlipForceDownBound;
        [NMS(Index = 119)]
        /* 0x10E0 */ public float DroneHitImpulseLaserMultiplier;
        [NMS(Index = 117)]
        /* 0x10E4 */ public float DroneHitImpulseMinVerticalComponentScale;
        [NMS(Index = 118)]
        /* 0x10E8 */ public float DroneHitImpulseMultiplier;
        [NMS(Index = 133)]
        /* 0x10EC */ public float DroneInvestigateMaxPositionAngle;
        [NMS(Index = 15)]
        /* 0x10F0 */ public float DroneInvestigateMinChaseRange;
        [NMS(Index = 135)]
        /* 0x10F4 */ public float DroneInvestigateMinCrimeInterval;
        [NMS(Index = 132)]
        /* 0x10F8 */ public float DroneInvestigateMinPositionAngle;
        [NMS(Index = 106)]
        /* 0x10FC */ public float DroneInvestigateMinScanTime;
        [NMS(Index = 13)]
        /* 0x1100 */ public float DroneInvestigateMinWitnessRange;
        [NMS(Index = 14)]
        /* 0x1104 */ public float DroneInvestigateMinWitnessRangeCantSee;
        [NMS(Index = 16)]
        /* 0x1108 */ public float DroneInvestigateMinWitnessTime;
        [NMS(Index = 134)]
        /* 0x110C */ public float DroneInvestigateRepositionTime;
        [NMS(Index = 17)]
        /* 0x1110 */ public float DroneInvestigateSpeedBoost;
        [NMS(Index = 19)]
        /* 0x1114 */ public float DroneInvestigateSpeedBoostRange;
        [NMS(Index = 18)]
        /* 0x1118 */ public float DroneInvestigateSpeedBoostStartDistance;
        [NMS(Index = 137)]
        /* 0x111C */ public float DroneMaxScanAngle;
        [NMS(Index = 130)]
        /* 0x1120 */ public float DroneMaxScanLength;
        [NMS(Index = 86)]
        /* 0x1124 */ public float DroneMoveDistancePlayerMechMultiplier;
        [NMS(Index = 122)]
        /* 0x1128 */ public float DronePatrolAttackSightTime;
        [NMS(Index = 123)]
        /* 0x112C */ public float DronePatrolInvestigateSpeedBoost;
        [NMS(Index = 124)]
        /* 0x1130 */ public float DronePatrolSearchTime;
        [NMS(Index = 54)]
        /* 0x1134 */ public float DronePerceptionMinHearingSpeed;
        [NMS(Index = 277)]
        /* 0x1138 */ public float DronePerceptionRange;
        [NMS(Index = 278)]
        /* 0x113C */ public float DronePerceptionRangeHostile;
        [NMS(Index = 281)]
        /* 0x1140 */ public float DronePerceptionSightAngle;
        [NMS(Index = 279)]
        /* 0x1144 */ public float DronePerceptionSightRange;
        [NMS(Index = 280)]
        /* 0x1148 */ public float DronePerceptionSightRangeHostile;
        [NMS(Index = 101)]
        /* 0x114C */ public float DronePushLaserForce;
        [NMS(Index = 102)]
        /* 0x1150 */ public float DronePushMaxSpeed;
        [NMS(Index = 103)]
        /* 0x1154 */ public float DronePushMaxTurn;
        [NMS(Index = 129)]
        /* 0x1158 */ public float DroneRadius;
        [NMS(Index = 121)]
        /* 0x115C */ public float DroneReAttackTime;
        [NMS(Index = 89)]
        /* 0x1160 */ public float DroneScale;
        [NMS(Index = 139)]
        /* 0x1164 */ public float DroneScanMinPerpSpeed;
        [NMS(Index = 136)]
        /* 0x1168 */ public float DroneScanRadius;
        [NMS(Index = 138)]
        /* 0x116C */ public float DroneScanWaitTime;
        [NMS(Index = 56)]
        /* 0x1170 */ public float DroneSearchLookDistance;
        [NMS(Index = 55)]
        /* 0x1174 */ public float DroneSearchLookSpeed;
        [NMS(Index = 12)]
        /* 0x1178 */ public float DroneSearchPickNearbyAngleMax;
        [NMS(Index = 11)]
        /* 0x117C */ public float DroneSearchPickNearbyAngleMin;
        [NMS(Index = 10)]
        /* 0x1180 */ public float DroneSearchPickNearbyTime;
        [NMS(Index = 31)]
        /* 0x1184 */ public float DroneSpawnFadeTime;
        [NMS(Index = 88)]
        /* 0x1188 */ public float DroneSpawnHeight;
        [NMS(Index = 30)]
        /* 0x118C */ public float DroneSpawnTime;
        [NMS(Index = 87)]
        /* 0x1190 */ public float DroneSquadSpawnRadius;
        [NMS(Index = 26)]
        /* 0x1194 */ public float DroneUpdateDistForMax;
        [NMS(Index = 27)]
        /* 0x1198 */ public float DroneUpdateDistForMin;
        [NMS(Index = 24)]
        /* 0x119C */ public float DroneUpdateFPSMax;
        [NMS(Index = 25)]
        /* 0x11A0 */ public float DroneUpdateFPSMin;
        [NMS(Index = 22)]
        /* 0x11A4 */ public float EncounterRangeToAllowPulledIntoFight;
        [NMS(Index = 21)]
        /* 0x11A8 */ public float EncounterRangeToBlockWantedSpawns;
        [NMS(Index = 140)]
        /* 0x11AC */ public float EnergyExplodeTime;
        [NMS(Index = 156)]
        /* 0x11B0 */ public float ExoMechJumpCooldownTimeInCombat;
        [NMS(Index = 157)]
        /* 0x11B4 */ public float ExoMechJumpCooldownTimeOutOfCombat;
        [NMS(Index = 35)]
        /* 0x11B8 */ public float FakeQuadGuard;
        [NMS(Index = 299)]
        /* 0x11BC */ public float FireRateLastHitBypassTime;
        [NMS(Index = 301)]
        /* 0x11C0 */ public float FireRateModifierMax;
        [NMS(Index = 300)]
        /* 0x11C4 */ public float FireRateModifierMin;
        [NMS(Index = 141)]
        /* 0x11C8 */ public float FollowRoutineArriveRadius;
        [NMS(Index = 44)]
        /* 0x11CC */ public float FriendlyDroneBeepReplaceChatChance;
        [NMS(Index = 41)]
        /* 0x11D0 */ public float FriendlyDroneChatChanceBecomeWanted;
        [NMS(Index = 43)]
        /* 0x11D4 */ public float FriendlyDroneChatChanceIdle;
        [NMS(Index = 42)]
        /* 0x11D8 */ public float FriendlyDroneChatChanceLoseWanted;
        [NMS(Index = 39)]
        /* 0x11DC */ public float FriendlyDroneChatChanceSummoned;
        [NMS(Index = 40)]
        /* 0x11E0 */ public float FriendlyDroneChatChanceUnsummoned;
        [NMS(Index = 37)]
        /* 0x11E4 */ public float FriendlyDroneChatCooldown;
        [NMS(Index = 38)]
        /* 0x11E8 */ public float FriendlyDroneDissolveTime;
        [NMS(Index = 5)]
        /* 0x11EC */ public float GrenadeLaunchFlightTime;
        [NMS(Index = 111)]
        /* 0x11F0 */ public float HeightTestSampleDistance;
        [NMS(Index = 112)]
        /* 0x11F4 */ public float HeightTestSampleTime;
        [NMS(Index = 230)]
        /* 0x11F8 */ public int HitsToCancelStealth;
        [NMS(Index = 229)]
        /* 0x11FC */ public int HitsToCancelStealthSmall;
        [NMS(Index = 70)]
        /* 0x1200 */ public float LabelOffsetDrone;
        [NMS(Index = 73)]
        /* 0x1204 */ public float LabelOffsetMech;
        [NMS(Index = 71)]
        /* 0x1208 */ public float LabelOffsetQuad;
        [NMS(Index = 72)]
        /* 0x120C */ public float LabelOffsetSpiderQuad;
        [NMS(Index = 74)]
        /* 0x1210 */ public float LabelOffsetWalker;
        [NMS(Index = 285)]
        /* 0x1214 */ public float LaserFadeTime;
        [NMS(Index = 286)]
        /* 0x1218 */ public float LaserFadeTime2;
        [NMS(Index = 32)]
        /* 0x121C */ public float LineOfSightReturnCheckMinDistance;
        [NMS(Index = 33)]
        /* 0x1220 */ public float LineOfSightReturnCheckRadius;
        [NMS(Index = 34)]
        /* 0x1224 */ public float LineOfSightReturnRange;
        [NMS(Index = 125)]
        /* 0x1228 */ public int MaxNumInvestigatingDrones;
        [NMS(Index = 7)]
        /* 0x122C */ public int MaxNumPatrolDrones;
        [NMS(Index = 174)]
        /* 0x1230 */ public float MechAlertRange;
        [NMS(Index = 172)]
        /* 0x1234 */ public float MechAttackMoveAngleToleranceDeg;
        [NMS(Index = 173)]
        /* 0x1238 */ public float MechAttackMoveFacingAngleTolerance;
        [NMS(Index = 171)]
        /* 0x123C */ public float MechAttackMoveHoldPositionTime;
        [NMS(Index = 170)]
        /* 0x1240 */ public float MechAttackMoveMaxOffsetRotation;
        [NMS(Index = 169)]
        /* 0x1244 */ public float MechAttackMoveMinOffsetRotation;
        [NMS(Index = 175)]
        /* 0x1248 */ public float MechAttackRange;
        [NMS(Index = 167)]
        /* 0x124C */ public float MechAttackRate;
        [NMS(Index = 161)]
        /* 0x1250 */ public float MechEndJumpMinDistanceInCombat;
        [NMS(Index = 163)]
        /* 0x1254 */ public float MechEndJumpMinDistanceOutOfCombat;
        [NMS(Index = 155)]
        /* 0x1258 */ public float MechFadeInDistance;
        [NMS(Index = 153)]
        /* 0x125C */ public float MechFadeInTime;
        [NMS(Index = 154)]
        /* 0x1260 */ public float MechFadeOutTime;
        [NMS(Index = 178)]
        /* 0x1264 */ public float MechHearingRange;
        [NMS(Index = 166)]
        /* 0x1268 */ public float MechMinMaintainFireTargetTime;
        [NMS(Index = 165)]
        /* 0x126C */ public float MechMinMaintainTargetTime;
        [NMS(Index = 168)]
        /* 0x1270 */ public float MechMinTurretAngle;
        [NMS(Index = 179)]
        /* 0x1274 */ public float MechPatrolRadius;
        [NMS(Index = 177)]
        /* 0x1278 */ public float MechSightAngle;
        [NMS(Index = 176)]
        /* 0x127C */ public float MechSightRange;
        [NMS(Index = 160)]
        /* 0x1280 */ public float MechStartJumpMinDistanceInCombat;
        [NMS(Index = 162)]
        /* 0x1284 */ public float MechStartJumpMinDistanceOutOfCombat;
        [NMS(Index = 107)]
        /* 0x1288 */ public float MedicDroneMinHealTime;
        [NMS(Index = 3)]
        /* 0x128C */ public float MinInvestigateMessageTime;
        [NMS(Index = 4)]
        /* 0x1290 */ public int MinRobotKillsForHint;
        [NMS(Index = 224)]
        /* 0x1294 */ public float QuadAlertRange;
        [NMS(Index = 240)]
        /* 0x1298 */ public float QuadAttackMinMoveTime;
        [NMS(Index = 225)]
        /* 0x129C */ public float QuadAttackMoveMinDist;
        [NMS(Index = 227)]
        /* 0x12A0 */ public float QuadAttackMoveMinRange;
        [NMS(Index = 226)]
        /* 0x12A4 */ public float QuadAttackMoveRange;
        [NMS(Index = 259)]
        /* 0x12A8 */ public float QuadAttackRate;
        [NMS(Index = 50)]
        /* 0x12AC */ public float QuadAttackTurnAngleMax;
        [NMS(Index = 49)]
        /* 0x12B0 */ public float QuadAttackTurnAngleMin;
        [NMS(Index = 257)]
        /* 0x12B4 */ public float QuadCannotSeeTargetRepositionTime;
        [NMS(Index = 258)]
        /* 0x12B8 */ public int QuadDamageMoveThreshold;
        [NMS(Index = 256)]
        /* 0x12BC */ public float QuadEvadeCooldown;
        [NMS(Index = 253)]
        /* 0x12C0 */ public float QuadEvadeFacingAngle;
        [NMS(Index = 268)]
        /* 0x12C4 */ public float QuadHearingRange;
        [NMS(Index = 263)]
        /* 0x12C8 */ public float QuadHeight;
        [NMS(Index = 244)]
        /* 0x12CC */ public float QuadJumpBackCheckRange;
        [NMS(Index = 248)]
        /* 0x12D0 */ public float QuadJumpBackDoFlipDistance;
        [NMS(Index = 250)]
        /* 0x12D4 */ public float QuadJumpBackFacingAngle;
        [NMS(Index = 245)]
        /* 0x12D8 */ public float QuadJumpBackHeightRange;
        [NMS(Index = 246)]
        /* 0x12DC */ public float QuadJumpBackJumpDistance;
        [NMS(Index = 247)]
        /* 0x12E0 */ public float QuadJumpBackJumpMinLength;
        [NMS(Index = 249)]
        /* 0x12E4 */ public float QuadJumpBackMinTime;
        [NMS(Index = 243)]
        /* 0x12E8 */ public float QuadJumpBackRange;
        [NMS(Index = 241)]
        /* 0x12EC */ public float QuadJumpBackRecoveryTime;
        [NMS(Index = 252)]
        /* 0x12F0 */ public float QuadJumpBackTestHeightOffset;
        [NMS(Index = 251)]
        /* 0x12F4 */ public float QuadJumpBackTestRadius;
        [NMS(Index = 261)]
        /* 0x12F8 */ public float QuadLaserSpringMax;
        [NMS(Index = 260)]
        /* 0x12FC */ public float QuadLaserSpringMin;
        [NMS(Index = 47)]
        /* 0x1300 */ public float QuadLookAngleMax;
        [NMS(Index = 46)]
        /* 0x1304 */ public float QuadLookAngleMin;
        [NMS(Index = 242)]
        /* 0x1308 */ public float QuadMinStationaryTime;
        [NMS(Index = 264)]
        /* 0x130C */ public float QuadNavRadius;
        [NMS(Index = 265)]
        /* 0x1310 */ public float QuadObstacleSize;
        [NMS(Index = 266)]
        /* 0x1314 */ public float QuadPatrolRadius;
        [NMS(Index = 255)]
        /* 0x1318 */ public float QuadPounceDamageRadius;
        [NMS(Index = 254)]
        /* 0x131C */ public float QuadPounceOffset;
        [NMS(Index = 233)]
        /* 0x1320 */ public float QuadRepositionHealthThresholdPercent;
        [NMS(Index = 231)]
        /* 0x1324 */ public float QuadRepositionMaxTimeSinceHit;
        [NMS(Index = 237)]
        /* 0x1328 */ public float QuadRepositionMinMoveDist;
        [NMS(Index = 239)]
        /* 0x132C */ public float QuadRepositionMinTargetDist;
        [NMS(Index = 238)]
        /* 0x1330 */ public float QuadRepositionTargetDist;
        [NMS(Index = 236)]
        /* 0x1334 */ public float QuadRepositionTimeout;
        [NMS(Index = 270)]
        /* 0x1338 */ public float QuadSightAngle;
        [NMS(Index = 269)]
        /* 0x133C */ public float QuadSightRange;
        [NMS(Index = 228)]
        /* 0x1340 */ public float QuadStealthCooldown;
        [NMS(Index = 234)]
        /* 0x1344 */ public float QuadStealthRepositionHealthThresholdPercent;
        [NMS(Index = 235)]
        /* 0x1348 */ public float QuadStealthRepositionHealthThresholdPercentSmall;
        [NMS(Index = 232)]
        /* 0x134C */ public float QuadStealthRepositionMaxTimeSinceHit;
        [NMS(Index = 262)]
        /* 0x1350 */ public float QuadTurnBlendTime;
        [NMS(Index = 149)]
        /* 0x1354 */ public float RepairChargeTime;
        [NMS(Index = 143)]
        /* 0x1358 */ public float RepairCheckForTargetCooldownTime;
        [NMS(Index = 151)]
        /* 0x135C */ public float RepairEffectScaleDrone;
        [NMS(Index = 152)]
        /* 0x1360 */ public float RepairEffectScaleQuad;
        [NMS(Index = 145)]
        /* 0x1364 */ public float RepairOffset;
        [NMS(Index = 144)]
        /* 0x1368 */ public float RepairOffsetChangeTime;
        [NMS(Index = 147)]
        /* 0x136C */ public float RepairRate;
        [NMS(Index = 146)]
        /* 0x1370 */ public float RepairScanArriveDistance;
        [NMS(Index = 148)]
        /* 0x1374 */ public float RepairScanRadius;
        [NMS(Index = 85)]
        /* 0x1378 */ public float RobotHUDMarkerFalloff;
        [NMS(Index = 84)]
        /* 0x137C */ public float RobotHUDMarkerRange;
        [NMS(Index = 94)]
        /* 0x1380 */ public float RobotMapScale;
        [NMS(Index = 36)]
        /* 0x1384 */ public float RobotSightAngle;
        [NMS(Index = 114)]
        /* 0x1388 */ public float RobotSightTimer;
        [NMS(Index = 81)]
        /* 0x138C */ public float RobotSteeringAvoidCreaturesWeight;
        [NMS(Index = 82)]
        /* 0x1390 */ public float RobotSteeringAvoidDangerWeight;
        [NMS(Index = 80)]
        /* 0x1394 */ public float RobotSteeringAvoidTurnWeight;
        [NMS(Index = 79)]
        /* 0x1398 */ public float RobotSteeringFollowWeight;
        [NMS(Index = 303)]
        /* 0x139C */ public int ScoreForMaxFireRateModifier;
        [NMS(Index = 302)]
        /* 0x13A0 */ public int ScoreForMinFireRateModifier;
        [NMS(Index = 158)]
        /* 0x13A4 */ public float SentinelMechJumpCooldownTimeInCombat;
        [NMS(Index = 159)]
        /* 0x13A8 */ public float SentinelMechJumpCooldownTimeOutOfCombat;
        [NMS(Index = 221)]
        /* 0x13AC */ public float SpiderPounceAngle;
        [NMS(Index = 223)]
        /* 0x13B0 */ public float SpiderPounceMinRange;
        [NMS(Index = 222)]
        /* 0x13B4 */ public float SpiderPounceRange;
        [NMS(Index = 276)]
        /* 0x13B8 */ public float SpiderQuadHeadTrackSmoothTime;
        [NMS(Index = 272)]
        /* 0x13BC */ public float SpiderQuadHeight;
        [NMS(Index = 274)]
        /* 0x13C0 */ public float SpiderQuadMiniHeight;
        [NMS(Index = 275)]
        /* 0x13C4 */ public float SpiderQuadMiniNavRadius;
        [NMS(Index = 271)]
        /* 0x13C8 */ public float SpiderQuadMiniObstacleSize;
        [NMS(Index = 273)]
        /* 0x13CC */ public float SpiderQuadNavRadius;
        [NMS(Index = 290)]
        /* 0x13D0 */ public float SummonerDroneBeginTime;
        [NMS(Index = 291)]
        /* 0x13D4 */ public float SummonerDroneBuildupTime;
        [NMS(Index = 289)]
        /* 0x13D8 */ public float SummonerDroneCooldown;
        [NMS(Index = 288)]
        /* 0x13DC */ public float SummonerDroneCooldownOffset;
        [NMS(Index = 287)]
        /* 0x13E0 */ public int SummonerDroneResummonThreshold;
        [NMS(Index = 297)]
        /* 0x13E4 */ public float SummonPreviewInterpSpeedMax;
        [NMS(Index = 296)]
        /* 0x13E8 */ public float SummonPreviewInterpSpeedMin;
        [NMS(Index = 294)]
        /* 0x13EC */ public float SummonRadius;
        [NMS(Index = 295)]
        /* 0x13F0 */ public float SummonVerticalOffset;
        [NMS(Index = 90)]
        /* 0x13F4 */ public float TrackArrowOffsetMultiplier;
        [NMS(Index = 8)]
        /* 0x13F8 */ public float UnderwaterPerceptionMargin;
        [NMS(Index = 187)]
        /* 0x13FC */ public float WalkerAttackAngle;
        [NMS(Index = 183)]
        /* 0x1400 */ public float WalkerAttackRange;
        [NMS(Index = 186)]
        /* 0x1404 */ public float WalkerAttackRate;
        [NMS(Index = 185)]
        /* 0x1408 */ public float WalkerClosingRange;
        [NMS(Index = 59)]
        /* 0x140C */ public float WalkerEnergyLength;
        [NMS(Index = 65)]
        /* 0x1410 */ public float WalkerEnergyMaxAlpha;
        [NMS(Index = 64)]
        /* 0x1414 */ public float WalkerEnergyMinAlpha;
        [NMS(Index = 63)]
        /* 0x1418 */ public float WalkerEnergyRadiusStartMax;
        [NMS(Index = 62)]
        /* 0x141C */ public float WalkerEnergyRadiusStartMin;
        [NMS(Index = 61)]
        /* 0x1420 */ public float WalkerEnergySpeedMax;
        [NMS(Index = 60)]
        /* 0x1424 */ public float WalkerEnergySpeedMin;
        [NMS(Index = 189)]
        /* 0x1428 */ public float WalkerFastMoveFactor;
        [NMS(Index = 184)]
        /* 0x142C */ public float WalkerGuardAlertRange;
        [NMS(Index = 199)]
        /* 0x1430 */ public float WalkerGunChargeTime;
        [NMS(Index = 200)]
        /* 0x1434 */ public float WalkerGunRate;
        [NMS(Index = 198)]
        /* 0x1438 */ public float WalkerGunShootTime;
        [NMS(Index = 219)]
        /* 0x143C */ public float WalkerHeadMaxPitch;
        [NMS(Index = 218)]
        /* 0x1440 */ public float WalkerHeadMaxYaw;
        [NMS(Index = 217)]
        /* 0x1444 */ public float WalkerHeadMoveTimeActive;
        [NMS(Index = 216)]
        /* 0x1448 */ public float WalkerHeadMoveTimeIdle;
        [NMS(Index = 190)]
        /* 0x144C */ public float WalkerHeight;
        [NMS(Index = 196)]
        /* 0x1450 */ public float WalkerLaserBodyOffset;
        [NMS(Index = 195)]
        /* 0x1454 */ public float WalkerLaserOvershootEnd;
        [NMS(Index = 194)]
        /* 0x1458 */ public float WalkerLaserOvershootStart;
        [NMS(Index = 95)]
        /* 0x145C */ public float WalkerLaserOvershootVehicleReducer;
        [NMS(Index = 209)]
        /* 0x1460 */ public float WalkerLegShotDefendTime;
        [NMS(Index = 211)]
        /* 0x1464 */ public float WalkerLegShotEnrageShotInterval;
        [NMS(Index = 212)]
        /* 0x1468 */ public int WalkerLegShotEnrageShotsPerVolley;
        [NMS(Index = 215)]
        /* 0x146C */ public float WalkerLegShotEnrageShotSpreadMax;
        [NMS(Index = 214)]
        /* 0x1470 */ public float WalkerLegShotEnrageShotSpreadMin;
        [NMS(Index = 213)]
        /* 0x1474 */ public float WalkerLegShotEnrageVolleyInterval;
        [NMS(Index = 188)]
        /* 0x1478 */ public float WalkerMoveSpeed;
        [NMS(Index = 191)]
        /* 0x147C */ public float WalkerNavRadius;
        [NMS(Index = 197)]
        /* 0x1480 */ public float WalkerObstacleSize;
        [NMS(Index = 182)]
        /* 0x1484 */ public float WalkerPauseTime;
        [NMS(Index = 193)]
        /* 0x1488 */ public float WalkerPushRadius;
        [NMS(Index = 192)]
        /* 0x148C */ public float WalkerPushTime;
        [NMS(Index = 204)]
        /* 0x1490 */ public float WalkerTitanFallEffectScale;
        [NMS(Index = 201)]
        /* 0x1494 */ public float WalkerTitanFallHeight;
        [NMS(Index = 202)]
        /* 0x1498 */ public float WalkerTitanFallSpeed;
        [NMS(Index = 97)]
        /* 0x149C */ public bool DisableDronePerception;
        [NMS(Index = 58)]
        /* 0x149D */ public bool DroneChatter;
        [NMS(Index = 105)]
        /* 0x149E */ public bool DroneClickToMove;
        [NMS(Index = 23)]
        /* 0x149F */ public bool DroneEnableVariableUpdate;
        [NMS(Index = 115)]
        /* 0x14A0 */ public bool DroneHitImpulseEnabled;
        [NMS(Index = 9)]
        /* 0x14A1 */ public bool DronePatrolScanPlayer;
        [NMS(Index = 96)]
        /* 0x14A2 */ public bool DronesUseEscalationTimer;
        [NMS(Index = 0)]
        /* 0x14A3 */ public bool ForceShowDebugMoveTrail;
        [NMS(Index = 282)]
        /* 0x14A4 */ public bool SpawnFriendlyDrone;
        [NMS(Index = 298)]
        /* 0x14A5 */ public bool SummonerTestSummonEffects;
        [NMS(Index = 208)]
        /* 0x14A6 */ public bool WalkerLegShotDefendEnabled;
        [NMS(Index = 210)]
        /* 0x14A7 */ public bool WalkerLegShotEnrageEnabled;
    }
}
