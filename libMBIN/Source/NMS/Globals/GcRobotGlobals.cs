using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xDED57E1241DD31B, NameHash = 0xDD7401143C40F868)]
    public class GcRobotGlobals : NMSTemplate
    {
        [NMS(Index = 307)]
        /* 0x0000 */ public GcDroneData DroneControl;
        [NMS(Index = 108)]
        /* 0x03A0 */ public GcScanEffectData DroneScanEffect;
        [NMS(Index = 306)]
        /* 0x03F0 */ public GcRobotLaserData QuadLaser;
        [NMS(Index = 305)]
        /* 0x0440 */ public GcRobotLaserData WalkerLaser;
        [NMS(Index = 76)]
        /* 0x0490 */ public Vector3f DroneCriticalOffset;
        [NMS(Index = 45)]
        /* 0x04A0 */ public Vector3f DroneRepairOffset;
        [NMS(Index = 75)]
        /* 0x04B0 */ public Vector3f QuadCriticalOffset;
        [NMS(Index = 77)]
        /* 0x04C0 */ public Vector3f WalkerGunOffset1;
        [NMS(Index = 78)]
        /* 0x04D0 */ public Vector3f WalkerGunOffset2;
        [NMS(Index = 220)]
        /* 0x04E0 */ public Vector3f WalkerHeadEyeOffset;
        [NMS(Index = 308, Size = 0x4, EnumType = typeof(GcSentinelQuadWeaponMode.SentinelQuadWeaponModeEnum))]
        /* 0x04F0 */ public GcSentinelQuadWeaponData[] QuadWeapons;
        [NMS(Index = 310, Size = 0xB, EnumType = typeof(GcSentinelTypes.SentinelTypeEnum))]
        /* 0x0810 */ public GcSentinelDamagedData[] DamageData;
        [NMS(Index = 181, Size = 0x3, EnumType = typeof(GcSentinelMechWeaponMode.SentinelMechWeaponModeEnum))]
        /* 0x0AD0 */ public GcSentinelMechWeaponData[] SentinelMechWeaponData;
        [NMS(Index = 83)]
        /* 0x0C50 */ public NMSString0x10 AttackScan;
        [NMS(Index = 309)]
        /* 0x0C60 */ public List<GcDroneWeaponData> DroneWeapons;
        [NMS(Index = 2)]
        /* 0x0C70 */ public NMSString0x10 ForceDroneWeapon;
        [NMS(Index = 150)]
        /* 0x0C80 */ public NMSString0x10 RepairEffect;
        [NMS(Index = 292)]
        /* 0x0C90 */ public NMSString0x10 SummonerDroneBuildupEffect;
        [NMS(Index = 293)]
        /* 0x0CA0 */ public NMSString0x10 SummonerDroneSpawnEffect;
        [NMS(Index = 206)]
        /* 0x0CB0 */ public List<NMSString0x20> WalkerLeftLegArmourNodes;
        [NMS(Index = 207)]
        /* 0x0CC0 */ public List<NMSString0x20> WalkerRightLegArmourNodes;
        [NMS(Index = 203)]
        /* 0x0CD0 */ public NMSString0x10 WalkerTitanFallEffect;
        [NMS(Index = 205)]
        /* 0x0CE0 */ public NMSString0x10 WalkerTitanFallShake;
        [NMS(Index = 110, Size = 0xB, EnumType = typeof(GcSentinelTypes.SentinelTypeEnum))]
        /* 0x0CF0 */ public GcSentinelResource[] SentinelResources;
        [NMS(Index = 311, Size = 0xB, EnumType = typeof(GcSentinelTypes.SentinelTypeEnum))]
        /* 0x134C */ public GcSentinelPounceBalance[] PounceData;
        [NMS(Index = 1)]
        /* 0x14AC */ public GcCamouflageData RobotCamoData;
        [NMS(Index = 164)]
        /* 0x1548 */ public GcMechTargetSelectionWeightingSettings MechTargetSelectionWeightingSettings;
        [NMS(Index = 304, Size = 0xB, EnumType = typeof(GcSentinelTypes.SentinelTypeEnum))]
        /* 0x1578 */ public float[] FireRateModifierScores;
        [NMS(Index = 109, Size = 0xB, EnumType = typeof(GcSentinelTypes.SentinelTypeEnum))]
        /* 0x15A4 */ public int[] SentinelSpawnLimits;
        [NMS(Index = 180)]
        /* 0x15D0 */ public Vector2f MechPatrolPauseTime;
        [NMS(Index = 51)]
        /* 0x15D8 */ public Vector2f QuadAttackTurnSpeeds;
        [NMS(Index = 48)]
        /* 0x15E0 */ public Vector2f QuadLookTurnSpeeds;
        [NMS(Index = 267)]
        /* 0x15E8 */ public Vector2f QuadPatrolPauseTime;
        [NMS(Index = 284)]
        /* 0x15F0 */ public float AttackMoveArrivalDistance;
        [NMS(Index = 283)]
        /* 0x15F4 */ public float AttackMoveMaxTime;
        [NMS(Index = 6)]
        /* 0x15F8 */ public int AttackSentinelWantedValue;
        [NMS(Index = 113)]
        /* 0x15FC */ public float CollisionDistance;
        [NMS(Index = 92)]
        /* 0x1600 */ public float CombatSpawnSquadRadiusDrones;
        [NMS(Index = 93)]
        /* 0x1604 */ public float CombatSpawnSquadRadiusRobots;
        [NMS(Index = 53)]
        /* 0x1608 */ public float CombatWaveSpawnTime;
        [NMS(Index = 142)]
        /* 0x160C */ public float CorruptedDroneRepairInteruptCooldownTime;
        [NMS(Index = 66)]
        /* 0x1610 */ public float CriticalHitSizeDrone;
        [NMS(Index = 68)]
        /* 0x1614 */ public float CriticalHitSizeMech;
        [NMS(Index = 67)]
        /* 0x1618 */ public float CriticalHitSizeQuad;
        [NMS(Index = 69)]
        /* 0x161C */ public float CriticalHitSizeWalker;
        [NMS(Index = 100)]
        /* 0x1620 */ public float DroneAggressiveInvestigateAttackTime;
        [NMS(Index = 52)]
        /* 0x1624 */ public int DroneAggroDamage;
        [NMS(Index = 99)]
        /* 0x1628 */ public float DroneAttackGetInRangeBoost;
        [NMS(Index = 29)]
        /* 0x162C */ public float DroneAttackMaxAngleDownFromPlayer;
        [NMS(Index = 28)]
        /* 0x1630 */ public float DroneAttackPlayerHeightOffset;
        [NMS(Index = 91)]
        /* 0x1634 */ public float DroneCombatSpawnAngle;
        [NMS(Index = 126)]
        /* 0x1638 */ public float DroneCrimeCooldown;
        [NMS(Index = 127)]
        /* 0x163C */ public float DroneCrimeCooldownWaitTime;
        [NMS(Index = 128)]
        /* 0x1640 */ public float DroneCrimeCooldownWaitTimeAtMax;
        [NMS(Index = 20)]
        /* 0x1644 */ public float DroneCrimePostInvestigateWaitTime;
        [NMS(Index = 57)]
        /* 0x1648 */ public float DroneCrimeWitnessInvestigateDistance;
        [NMS(Index = 104)]
        /* 0x164C */ public float DroneCriminalScanTime;
        [NMS(Index = 131)]
        /* 0x1650 */ public float DroneDecisionTime;
        [NMS(Index = 98)]
        /* 0x1654 */ public float DroneHeightAngle;
        [NMS(Index = 120)]
        /* 0x1658 */ public float DroneHitImpulseCooldown;
        [NMS(Index = 116)]
        /* 0x165C */ public float DroneHitImpulseFlipForceDownBound;
        [NMS(Index = 119)]
        /* 0x1660 */ public float DroneHitImpulseLaserMultiplier;
        [NMS(Index = 117)]
        /* 0x1664 */ public float DroneHitImpulseMinVerticalComponentScale;
        [NMS(Index = 118)]
        /* 0x1668 */ public float DroneHitImpulseMultiplier;
        [NMS(Index = 133)]
        /* 0x166C */ public float DroneInvestigateMaxPositionAngle;
        [NMS(Index = 15)]
        /* 0x1670 */ public float DroneInvestigateMinChaseRange;
        [NMS(Index = 135)]
        /* 0x1674 */ public float DroneInvestigateMinCrimeInterval;
        [NMS(Index = 132)]
        /* 0x1678 */ public float DroneInvestigateMinPositionAngle;
        [NMS(Index = 106)]
        /* 0x167C */ public float DroneInvestigateMinScanTime;
        [NMS(Index = 13)]
        /* 0x1680 */ public float DroneInvestigateMinWitnessRange;
        [NMS(Index = 14)]
        /* 0x1684 */ public float DroneInvestigateMinWitnessRangeCantSee;
        [NMS(Index = 16)]
        /* 0x1688 */ public float DroneInvestigateMinWitnessTime;
        [NMS(Index = 134)]
        /* 0x168C */ public float DroneInvestigateRepositionTime;
        [NMS(Index = 17)]
        /* 0x1690 */ public float DroneInvestigateSpeedBoost;
        [NMS(Index = 19)]
        /* 0x1694 */ public float DroneInvestigateSpeedBoostRange;
        [NMS(Index = 18)]
        /* 0x1698 */ public float DroneInvestigateSpeedBoostStartDistance;
        [NMS(Index = 137)]
        /* 0x169C */ public float DroneMaxScanAngle;
        [NMS(Index = 130)]
        /* 0x16A0 */ public float DroneMaxScanLength;
        [NMS(Index = 86)]
        /* 0x16A4 */ public float DroneMoveDistancePlayerMechMultiplier;
        [NMS(Index = 122)]
        /* 0x16A8 */ public float DronePatrolAttackSightTime;
        [NMS(Index = 123)]
        /* 0x16AC */ public float DronePatrolInvestigateSpeedBoost;
        [NMS(Index = 124)]
        /* 0x16B0 */ public float DronePatrolSearchTime;
        [NMS(Index = 54)]
        /* 0x16B4 */ public float DronePerceptionMinHearingSpeed;
        [NMS(Index = 277)]
        /* 0x16B8 */ public float DronePerceptionRange;
        [NMS(Index = 278)]
        /* 0x16BC */ public float DronePerceptionRangeHostile;
        [NMS(Index = 281)]
        /* 0x16C0 */ public float DronePerceptionSightAngle;
        [NMS(Index = 279)]
        /* 0x16C4 */ public float DronePerceptionSightRange;
        [NMS(Index = 280)]
        /* 0x16C8 */ public float DronePerceptionSightRangeHostile;
        [NMS(Index = 101)]
        /* 0x16CC */ public float DronePushLaserForce;
        [NMS(Index = 102)]
        /* 0x16D0 */ public float DronePushMaxSpeed;
        [NMS(Index = 103)]
        /* 0x16D4 */ public float DronePushMaxTurn;
        [NMS(Index = 129)]
        /* 0x16D8 */ public float DroneRadius;
        [NMS(Index = 121)]
        /* 0x16DC */ public float DroneReAttackTime;
        [NMS(Index = 89)]
        /* 0x16E0 */ public float DroneScale;
        [NMS(Index = 139)]
        /* 0x16E4 */ public float DroneScanMinPerpSpeed;
        [NMS(Index = 136)]
        /* 0x16E8 */ public float DroneScanRadius;
        [NMS(Index = 138)]
        /* 0x16EC */ public float DroneScanWaitTime;
        [NMS(Index = 56)]
        /* 0x16F0 */ public float DroneSearchLookDistance;
        [NMS(Index = 55)]
        /* 0x16F4 */ public float DroneSearchLookSpeed;
        [NMS(Index = 12)]
        /* 0x16F8 */ public float DroneSearchPickNearbyAngleMax;
        [NMS(Index = 11)]
        /* 0x16FC */ public float DroneSearchPickNearbyAngleMin;
        [NMS(Index = 10)]
        /* 0x1700 */ public float DroneSearchPickNearbyTime;
        [NMS(Index = 31)]
        /* 0x1704 */ public float DroneSpawnFadeTime;
        [NMS(Index = 88)]
        /* 0x1708 */ public float DroneSpawnHeight;
        [NMS(Index = 30)]
        /* 0x170C */ public float DroneSpawnTime;
        [NMS(Index = 87)]
        /* 0x1710 */ public float DroneSquadSpawnRadius;
        [NMS(Index = 26)]
        /* 0x1714 */ public float DroneUpdateDistForMax;
        [NMS(Index = 27)]
        /* 0x1718 */ public float DroneUpdateDistForMin;
        [NMS(Index = 24)]
        /* 0x171C */ public float DroneUpdateFPSMax;
        [NMS(Index = 25)]
        /* 0x1720 */ public float DroneUpdateFPSMin;
        [NMS(Index = 22)]
        /* 0x1724 */ public float EncounterRangeToAllowPulledIntoFight;
        [NMS(Index = 21)]
        /* 0x1728 */ public float EncounterRangeToBlockWantedSpawns;
        [NMS(Index = 140)]
        /* 0x172C */ public float EnergyExplodeTime;
        [NMS(Index = 156)]
        /* 0x1730 */ public float ExoMechJumpCooldownTimeInCombat;
        [NMS(Index = 157)]
        /* 0x1734 */ public float ExoMechJumpCooldownTimeOutOfCombat;
        [NMS(Index = 35)]
        /* 0x1738 */ public float FakeQuadGuard;
        [NMS(Index = 299)]
        /* 0x173C */ public float FireRateLastHitBypassTime;
        [NMS(Index = 301)]
        /* 0x1740 */ public float FireRateModifierMax;
        [NMS(Index = 300)]
        /* 0x1744 */ public float FireRateModifierMin;
        [NMS(Index = 141)]
        /* 0x1748 */ public float FollowRoutineArriveRadius;
        [NMS(Index = 44)]
        /* 0x174C */ public float FriendlyDroneBeepReplaceChatChance;
        [NMS(Index = 41)]
        /* 0x1750 */ public float FriendlyDroneChatChanceBecomeWanted;
        [NMS(Index = 43)]
        /* 0x1754 */ public float FriendlyDroneChatChanceIdle;
        [NMS(Index = 42)]
        /* 0x1758 */ public float FriendlyDroneChatChanceLoseWanted;
        [NMS(Index = 39)]
        /* 0x175C */ public float FriendlyDroneChatChanceSummoned;
        [NMS(Index = 40)]
        /* 0x1760 */ public float FriendlyDroneChatChanceUnsummoned;
        [NMS(Index = 37)]
        /* 0x1764 */ public float FriendlyDroneChatCooldown;
        [NMS(Index = 38)]
        /* 0x1768 */ public float FriendlyDroneDissolveTime;
        [NMS(Index = 5)]
        /* 0x176C */ public float GrenadeLaunchFlightTime;
        [NMS(Index = 111)]
        /* 0x1770 */ public float HeightTestSampleDistance;
        [NMS(Index = 112)]
        /* 0x1774 */ public float HeightTestSampleTime;
        [NMS(Index = 230)]
        /* 0x1778 */ public int HitsToCancelStealth;
        [NMS(Index = 229)]
        /* 0x177C */ public int HitsToCancelStealthSmall;
        [NMS(Index = 70)]
        /* 0x1780 */ public float LabelOffsetDrone;
        [NMS(Index = 73)]
        /* 0x1784 */ public float LabelOffsetMech;
        [NMS(Index = 71)]
        /* 0x1788 */ public float LabelOffsetQuad;
        [NMS(Index = 72)]
        /* 0x178C */ public float LabelOffsetSpiderQuad;
        [NMS(Index = 74)]
        /* 0x1790 */ public float LabelOffsetWalker;
        [NMS(Index = 285)]
        /* 0x1794 */ public float LaserFadeTime;
        [NMS(Index = 286)]
        /* 0x1798 */ public float LaserFadeTime2;
        [NMS(Index = 32)]
        /* 0x179C */ public float LineOfSightReturnCheckMinDistance;
        [NMS(Index = 33)]
        /* 0x17A0 */ public float LineOfSightReturnCheckRadius;
        [NMS(Index = 34)]
        /* 0x17A4 */ public float LineOfSightReturnRange;
        [NMS(Index = 125)]
        /* 0x17A8 */ public int MaxNumInvestigatingDrones;
        [NMS(Index = 7)]
        /* 0x17AC */ public int MaxNumPatrolDrones;
        [NMS(Index = 174)]
        /* 0x17B0 */ public float MechAlertRange;
        [NMS(Index = 172)]
        /* 0x17B4 */ public float MechAttackMoveAngleToleranceDeg;
        [NMS(Index = 173)]
        /* 0x17B8 */ public float MechAttackMoveFacingAngleTolerance;
        [NMS(Index = 171)]
        /* 0x17BC */ public float MechAttackMoveHoldPositionTime;
        [NMS(Index = 170)]
        /* 0x17C0 */ public float MechAttackMoveMaxOffsetRotation;
        [NMS(Index = 169)]
        /* 0x17C4 */ public float MechAttackMoveMinOffsetRotation;
        [NMS(Index = 175)]
        /* 0x17C8 */ public float MechAttackRange;
        [NMS(Index = 167)]
        /* 0x17CC */ public float MechAttackRate;
        [NMS(Index = 161)]
        /* 0x17D0 */ public float MechEndJumpMinDistanceInCombat;
        [NMS(Index = 163)]
        /* 0x17D4 */ public float MechEndJumpMinDistanceOutOfCombat;
        [NMS(Index = 155)]
        /* 0x17D8 */ public float MechFadeInDistance;
        [NMS(Index = 153)]
        /* 0x17DC */ public float MechFadeInTime;
        [NMS(Index = 154)]
        /* 0x17E0 */ public float MechFadeOutTime;
        [NMS(Index = 178)]
        /* 0x17E4 */ public float MechHearingRange;
        [NMS(Index = 166)]
        /* 0x17E8 */ public float MechMinMaintainFireTargetTime;
        [NMS(Index = 165)]
        /* 0x17EC */ public float MechMinMaintainTargetTime;
        [NMS(Index = 168)]
        /* 0x17F0 */ public float MechMinTurretAngle;
        [NMS(Index = 179)]
        /* 0x17F4 */ public float MechPatrolRadius;
        [NMS(Index = 177)]
        /* 0x17F8 */ public float MechSightAngle;
        [NMS(Index = 176)]
        /* 0x17FC */ public float MechSightRange;
        [NMS(Index = 160)]
        /* 0x1800 */ public float MechStartJumpMinDistanceInCombat;
        [NMS(Index = 162)]
        /* 0x1804 */ public float MechStartJumpMinDistanceOutOfCombat;
        [NMS(Index = 107)]
        /* 0x1808 */ public float MedicDroneMinHealTime;
        [NMS(Index = 3)]
        /* 0x180C */ public float MinInvestigateMessageTime;
        [NMS(Index = 4)]
        /* 0x1810 */ public int MinRobotKillsForHint;
        [NMS(Index = 224)]
        /* 0x1814 */ public float QuadAlertRange;
        [NMS(Index = 240)]
        /* 0x1818 */ public float QuadAttackMinMoveTime;
        [NMS(Index = 225)]
        /* 0x181C */ public float QuadAttackMoveMinDist;
        [NMS(Index = 227)]
        /* 0x1820 */ public float QuadAttackMoveMinRange;
        [NMS(Index = 226)]
        /* 0x1824 */ public float QuadAttackMoveRange;
        [NMS(Index = 259)]
        /* 0x1828 */ public float QuadAttackRate;
        [NMS(Index = 50)]
        /* 0x182C */ public float QuadAttackTurnAngleMax;
        [NMS(Index = 49)]
        /* 0x1830 */ public float QuadAttackTurnAngleMin;
        [NMS(Index = 257)]
        /* 0x1834 */ public float QuadCannotSeeTargetRepositionTime;
        [NMS(Index = 258)]
        /* 0x1838 */ public int QuadDamageMoveThreshold;
        [NMS(Index = 256)]
        /* 0x183C */ public float QuadEvadeCooldown;
        [NMS(Index = 253)]
        /* 0x1840 */ public float QuadEvadeFacingAngle;
        [NMS(Index = 268)]
        /* 0x1844 */ public float QuadHearingRange;
        [NMS(Index = 263)]
        /* 0x1848 */ public float QuadHeight;
        [NMS(Index = 244)]
        /* 0x184C */ public float QuadJumpBackCheckRange;
        [NMS(Index = 248)]
        /* 0x1850 */ public float QuadJumpBackDoFlipDistance;
        [NMS(Index = 250)]
        /* 0x1854 */ public float QuadJumpBackFacingAngle;
        [NMS(Index = 245)]
        /* 0x1858 */ public float QuadJumpBackHeightRange;
        [NMS(Index = 246)]
        /* 0x185C */ public float QuadJumpBackJumpDistance;
        [NMS(Index = 247)]
        /* 0x1860 */ public float QuadJumpBackJumpMinLength;
        [NMS(Index = 249)]
        /* 0x1864 */ public float QuadJumpBackMinTime;
        [NMS(Index = 243)]
        /* 0x1868 */ public float QuadJumpBackRange;
        [NMS(Index = 241)]
        /* 0x186C */ public float QuadJumpBackRecoveryTime;
        [NMS(Index = 252)]
        /* 0x1870 */ public float QuadJumpBackTestHeightOffset;
        [NMS(Index = 251)]
        /* 0x1874 */ public float QuadJumpBackTestRadius;
        [NMS(Index = 261)]
        /* 0x1878 */ public float QuadLaserSpringMax;
        [NMS(Index = 260)]
        /* 0x187C */ public float QuadLaserSpringMin;
        [NMS(Index = 47)]
        /* 0x1880 */ public float QuadLookAngleMax;
        [NMS(Index = 46)]
        /* 0x1884 */ public float QuadLookAngleMin;
        [NMS(Index = 242)]
        /* 0x1888 */ public float QuadMinStationaryTime;
        [NMS(Index = 264)]
        /* 0x188C */ public float QuadNavRadius;
        [NMS(Index = 265)]
        /* 0x1890 */ public float QuadObstacleSize;
        [NMS(Index = 266)]
        /* 0x1894 */ public float QuadPatrolRadius;
        [NMS(Index = 255)]
        /* 0x1898 */ public float QuadPounceDamageRadius;
        [NMS(Index = 254)]
        /* 0x189C */ public float QuadPounceOffset;
        [NMS(Index = 233)]
        /* 0x18A0 */ public float QuadRepositionHealthThresholdPercent;
        [NMS(Index = 231)]
        /* 0x18A4 */ public float QuadRepositionMaxTimeSinceHit;
        [NMS(Index = 237)]
        /* 0x18A8 */ public float QuadRepositionMinMoveDist;
        [NMS(Index = 239)]
        /* 0x18AC */ public float QuadRepositionMinTargetDist;
        [NMS(Index = 238)]
        /* 0x18B0 */ public float QuadRepositionTargetDist;
        [NMS(Index = 236)]
        /* 0x18B4 */ public float QuadRepositionTimeout;
        [NMS(Index = 270)]
        /* 0x18B8 */ public float QuadSightAngle;
        [NMS(Index = 269)]
        /* 0x18BC */ public float QuadSightRange;
        [NMS(Index = 228)]
        /* 0x18C0 */ public float QuadStealthCooldown;
        [NMS(Index = 234)]
        /* 0x18C4 */ public float QuadStealthRepositionHealthThresholdPercent;
        [NMS(Index = 235)]
        /* 0x18C8 */ public float QuadStealthRepositionHealthThresholdPercentSmall;
        [NMS(Index = 232)]
        /* 0x18CC */ public float QuadStealthRepositionMaxTimeSinceHit;
        [NMS(Index = 262)]
        /* 0x18D0 */ public float QuadTurnBlendTime;
        [NMS(Index = 149)]
        /* 0x18D4 */ public float RepairChargeTime;
        [NMS(Index = 143)]
        /* 0x18D8 */ public float RepairCheckForTargetCooldownTime;
        [NMS(Index = 151)]
        /* 0x18DC */ public float RepairEffectScaleDrone;
        [NMS(Index = 152)]
        /* 0x18E0 */ public float RepairEffectScaleQuad;
        [NMS(Index = 145)]
        /* 0x18E4 */ public float RepairOffset;
        [NMS(Index = 144)]
        /* 0x18E8 */ public float RepairOffsetChangeTime;
        [NMS(Index = 147)]
        /* 0x18EC */ public float RepairRate;
        [NMS(Index = 146)]
        /* 0x18F0 */ public float RepairScanArriveDistance;
        [NMS(Index = 148)]
        /* 0x18F4 */ public float RepairScanRadius;
        [NMS(Index = 85)]
        /* 0x18F8 */ public float RobotHUDMarkerFalloff;
        [NMS(Index = 84)]
        /* 0x18FC */ public float RobotHUDMarkerRange;
        [NMS(Index = 94)]
        /* 0x1900 */ public float RobotMapScale;
        [NMS(Index = 36)]
        /* 0x1904 */ public float RobotSightAngle;
        [NMS(Index = 114)]
        /* 0x1908 */ public float RobotSightTimer;
        [NMS(Index = 81)]
        /* 0x190C */ public float RobotSteeringAvoidCreaturesWeight;
        [NMS(Index = 82)]
        /* 0x1910 */ public float RobotSteeringAvoidDangerWeight;
        [NMS(Index = 80)]
        /* 0x1914 */ public float RobotSteeringAvoidTurnWeight;
        [NMS(Index = 79)]
        /* 0x1918 */ public float RobotSteeringFollowWeight;
        [NMS(Index = 303)]
        /* 0x191C */ public int ScoreForMaxFireRateModifier;
        [NMS(Index = 302)]
        /* 0x1920 */ public int ScoreForMinFireRateModifier;
        [NMS(Index = 158)]
        /* 0x1924 */ public float SentinelMechJumpCooldownTimeInCombat;
        [NMS(Index = 159)]
        /* 0x1928 */ public float SentinelMechJumpCooldownTimeOutOfCombat;
        [NMS(Index = 221)]
        /* 0x192C */ public float SpiderPounceAngle;
        [NMS(Index = 223)]
        /* 0x1930 */ public float SpiderPounceMinRange;
        [NMS(Index = 222)]
        /* 0x1934 */ public float SpiderPounceRange;
        [NMS(Index = 276)]
        /* 0x1938 */ public float SpiderQuadHeadTrackSmoothTime;
        [NMS(Index = 272)]
        /* 0x193C */ public float SpiderQuadHeight;
        [NMS(Index = 274)]
        /* 0x1940 */ public float SpiderQuadMiniHeight;
        [NMS(Index = 275)]
        /* 0x1944 */ public float SpiderQuadMiniNavRadius;
        [NMS(Index = 271)]
        /* 0x1948 */ public float SpiderQuadMiniObstacleSize;
        [NMS(Index = 273)]
        /* 0x194C */ public float SpiderQuadNavRadius;
        [NMS(Index = 290)]
        /* 0x1950 */ public float SummonerDroneBeginTime;
        [NMS(Index = 291)]
        /* 0x1954 */ public float SummonerDroneBuildupTime;
        [NMS(Index = 289)]
        /* 0x1958 */ public float SummonerDroneCooldown;
        [NMS(Index = 288)]
        /* 0x195C */ public float SummonerDroneCooldownOffset;
        [NMS(Index = 287)]
        /* 0x1960 */ public int SummonerDroneResummonThreshold;
        [NMS(Index = 297)]
        /* 0x1964 */ public float SummonPreviewInterpSpeedMax;
        [NMS(Index = 296)]
        /* 0x1968 */ public float SummonPreviewInterpSpeedMin;
        [NMS(Index = 294)]
        /* 0x196C */ public float SummonRadius;
        [NMS(Index = 295)]
        /* 0x1970 */ public float SummonVerticalOffset;
        [NMS(Index = 90)]
        /* 0x1974 */ public float TrackArrowOffsetMultiplier;
        [NMS(Index = 8)]
        /* 0x1978 */ public float UnderwaterPerceptionMargin;
        [NMS(Index = 187)]
        /* 0x197C */ public float WalkerAttackAngle;
        [NMS(Index = 183)]
        /* 0x1980 */ public float WalkerAttackRange;
        [NMS(Index = 186)]
        /* 0x1984 */ public float WalkerAttackRate;
        [NMS(Index = 185)]
        /* 0x1988 */ public float WalkerClosingRange;
        [NMS(Index = 59)]
        /* 0x198C */ public float WalkerEnergyLength;
        [NMS(Index = 65)]
        /* 0x1990 */ public float WalkerEnergyMaxAlpha;
        [NMS(Index = 64)]
        /* 0x1994 */ public float WalkerEnergyMinAlpha;
        [NMS(Index = 63)]
        /* 0x1998 */ public float WalkerEnergyRadiusStartMax;
        [NMS(Index = 62)]
        /* 0x199C */ public float WalkerEnergyRadiusStartMin;
        [NMS(Index = 61)]
        /* 0x19A0 */ public float WalkerEnergySpeedMax;
        [NMS(Index = 60)]
        /* 0x19A4 */ public float WalkerEnergySpeedMin;
        [NMS(Index = 189)]
        /* 0x19A8 */ public float WalkerFastMoveFactor;
        [NMS(Index = 184)]
        /* 0x19AC */ public float WalkerGuardAlertRange;
        [NMS(Index = 199)]
        /* 0x19B0 */ public float WalkerGunChargeTime;
        [NMS(Index = 200)]
        /* 0x19B4 */ public float WalkerGunRate;
        [NMS(Index = 198)]
        /* 0x19B8 */ public float WalkerGunShootTime;
        [NMS(Index = 219)]
        /* 0x19BC */ public float WalkerHeadMaxPitch;
        [NMS(Index = 218)]
        /* 0x19C0 */ public float WalkerHeadMaxYaw;
        [NMS(Index = 217)]
        /* 0x19C4 */ public float WalkerHeadMoveTimeActive;
        [NMS(Index = 216)]
        /* 0x19C8 */ public float WalkerHeadMoveTimeIdle;
        [NMS(Index = 190)]
        /* 0x19CC */ public float WalkerHeight;
        [NMS(Index = 196)]
        /* 0x19D0 */ public float WalkerLaserBodyOffset;
        [NMS(Index = 195)]
        /* 0x19D4 */ public float WalkerLaserOvershootEnd;
        [NMS(Index = 194)]
        /* 0x19D8 */ public float WalkerLaserOvershootStart;
        [NMS(Index = 95)]
        /* 0x19DC */ public float WalkerLaserOvershootVehicleReducer;
        [NMS(Index = 209)]
        /* 0x19E0 */ public float WalkerLegShotDefendTime;
        [NMS(Index = 211)]
        /* 0x19E4 */ public float WalkerLegShotEnrageShotInterval;
        [NMS(Index = 212)]
        /* 0x19E8 */ public int WalkerLegShotEnrageShotsPerVolley;
        [NMS(Index = 215)]
        /* 0x19EC */ public float WalkerLegShotEnrageShotSpreadMax;
        [NMS(Index = 214)]
        /* 0x19F0 */ public float WalkerLegShotEnrageShotSpreadMin;
        [NMS(Index = 213)]
        /* 0x19F4 */ public float WalkerLegShotEnrageVolleyInterval;
        [NMS(Index = 188)]
        /* 0x19F8 */ public float WalkerMoveSpeed;
        [NMS(Index = 191)]
        /* 0x19FC */ public float WalkerNavRadius;
        [NMS(Index = 197)]
        /* 0x1A00 */ public float WalkerObstacleSize;
        [NMS(Index = 182)]
        /* 0x1A04 */ public float WalkerPauseTime;
        [NMS(Index = 193)]
        /* 0x1A08 */ public float WalkerPushRadius;
        [NMS(Index = 192)]
        /* 0x1A0C */ public float WalkerPushTime;
        [NMS(Index = 204)]
        /* 0x1A10 */ public float WalkerTitanFallEffectScale;
        [NMS(Index = 201)]
        /* 0x1A14 */ public float WalkerTitanFallHeight;
        [NMS(Index = 202)]
        /* 0x1A18 */ public float WalkerTitanFallSpeed;
        [NMS(Index = 97)]
        /* 0x1A1C */ public bool DisableDronePerception;
        [NMS(Index = 58)]
        /* 0x1A1D */ public bool DroneChatter;
        [NMS(Index = 105)]
        /* 0x1A1E */ public bool DroneClickToMove;
        [NMS(Index = 23)]
        /* 0x1A1F */ public bool DroneEnableVariableUpdate;
        [NMS(Index = 115)]
        /* 0x1A20 */ public bool DroneHitImpulseEnabled;
        [NMS(Index = 9)]
        /* 0x1A21 */ public bool DronePatrolScanPlayer;
        [NMS(Index = 96)]
        /* 0x1A22 */ public bool DronesUseEscalationTimer;
        [NMS(Index = 0)]
        /* 0x1A23 */ public bool ForceShowDebugMoveTrail;
        [NMS(Index = 282)]
        /* 0x1A24 */ public bool SpawnFriendlyDrone;
        [NMS(Index = 298)]
        /* 0x1A25 */ public bool SummonerTestSummonEffects;
        [NMS(Index = 208)]
        /* 0x1A26 */ public bool WalkerLegShotDefendEnabled;
        [NMS(Index = 210)]
        /* 0x1A27 */ public bool WalkerLegShotEnrageEnabled;
    }
}
