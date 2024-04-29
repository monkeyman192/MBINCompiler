using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xFAA44B9D683C2020, NameHash = 0x71CAF682B6986E6E)]
    public class GcGameplayGlobals : NMSTemplate
    {
        [NMS(Index = 480)]
        /* 0x0000 */ public GcShipHUDTargetData HUDTarget;
        [NMS(Index = 424)]
        /* 0x0420 */ public GcScanEffectData BaseBuildingDeleteScanEffect;
        [NMS(Index = 432)]
        /* 0x0470 */ public GcScanEffectData BaseBuildingErrorAboveWaterScanEffect;
        [NMS(Index = 433)]
        /* 0x04C0 */ public GcScanEffectData BaseBuildingErrorBelowWaterScanEffect;
        [NMS(Index = 429)]
        /* 0x0510 */ public GcScanEffectData BaseBuildingErrorCollisionScanEffect;
        [NMS(Index = 430)]
        /* 0x0560 */ public GcScanEffectData BaseBuildingErrorImpossibleScanEffect;
        [NMS(Index = 428)]
        /* 0x05B0 */ public GcScanEffectData BaseBuildingErrorInsideScanEffect;
        [NMS(Index = 431)]
        /* 0x0600 */ public GcScanEffectData BaseBuildingErrorUnaffordableScanEffect;
        [NMS(Index = 425)]
        /* 0x0650 */ public GcScanEffectData BaseBuildingGhostScanEffect;
        [NMS(Index = 422)]
        /* 0x06A0 */ public GcScanEffectData BaseBuildingPreviewSelectionScanEffect;
        [NMS(Index = 435)]
        /* 0x06F0 */ public GcScanEffectData BaseBuildingRemotePlayerSelectionScanEffect;
        [NMS(Index = 434)]
        /* 0x0740 */ public GcScanEffectData BaseBuildingRemotePlayerValidScanEffect;
        [NMS(Index = 423)]
        /* 0x0790 */ public GcScanEffectData BaseBuildingSelectionScanEffect;
        [NMS(Index = 426)]
        /* 0x07E0 */ public GcScanEffectData BaseBuildingSpawnStaticEffect;
        [NMS(Index = 421)]
        /* 0x0830 */ public GcScanEffectData BaseBuildingValidScanEffect;
        [NMS(Index = 427)]
        /* 0x0880 */ public GcScanEffectData BaseBuildingVisionScanEffect;
        [NMS(Index = 223)]
        /* 0x08D0 */ public GcScanEffectData BinocularScanEffect;
        [NMS(Index = 113)]
        /* 0x0920 */ public GcScanEffectData BinocularSelectedEffect;
        [NMS(Index = 420)]
        /* 0x0970 */ public GcScanEffectData BlankScanEffect;
        [NMS(Index = 414)]
        /* 0x09C0 */ public GcScanEffectData BuildingScanEffect;
        [NMS(Index = 417)]
        /* 0x0A10 */ public GcScanEffectData CreatureScanEffect;
        [NMS(Index = 237)]
        /* 0x0A60 */ public GcScanEffectData DeconstructEffect;
        [NMS(Index = 238)]
        /* 0x0AB0 */ public GcScanEffectData HitEffect;
        [NMS(Index = 239)]
        /* 0x0B00 */ public GcScanEffectData HitEffectCritical;
        [NMS(Index = 416)]
        /* 0x0B50 */ public GcScanEffectData HUDShipScanEffect;
        [NMS(Index = 418)]
        /* 0x0BA0 */ public GcScanEffectData ObjectsScanEffect;
        [NMS(Index = 413)]
        /* 0x0BF0 */ public GcScanEffectData PassiveScanEffect;
        [NMS(Index = 617)]
        /* 0x0C40 */ public GcScanEffectData ShipBuilderNullScanEffect;
        [NMS(Index = 616)]
        /* 0x0C90 */ public GcScanEffectData ShipBuilderScanEffect;
        [NMS(Index = 615)]
        /* 0x0CE0 */ public GcScanEffectData ShipSalvageScanEffect;
        [NMS(Index = 415)]
        /* 0x0D30 */ public GcScanEffectData TargetShipScanEffect;
        [NMS(Index = 419)]
        /* 0x0D80 */ public GcScanEffectData VRGhostScanEffect;
        [NMS(Index = 222)]
        /* 0x0DD0 */ public Colour BinocularScanTargetColour;
        [NMS(Index = 114)]
        /* 0x0DE0 */ public Colour BinocularSelectedColour;
        [NMS(Index = 115)]
        /* 0x0DF0 */ public Colour BinocularSelectedUnknownColour;
        [NMS(Index = 88)]
        /* 0x0E00 */ public Colour BulletTraceLineColour;
        [NMS(Index = 242)]
        /* 0x0E10 */ public Vector3f CommunicatorShipSpawnOffset;
        [NMS(Index = 476)]
        /* 0x0E20 */ public Colour HUDDamageSplatPainColour;
        [NMS(Index = 475)]
        /* 0x0E30 */ public Colour HUDDamageSplatShieldColour;
        [NMS(Index = 170)]
        /* 0x0E40 */ public Colour OverHeatBarColour;
        [NMS(Index = 169)]
        /* 0x0E50 */ public Colour OverHeatColour;
        [NMS(Index = 513)]
        /* 0x0E60 */ public Colour PainColour;
        [NMS(Index = 561)]
        /* 0x0E70 */ public Colour PlayerAmbientSpotLightColour;
        [NMS(Index = 195)]
        /* 0x0E80 */ public Colour RefinerColour1A;
        [NMS(Index = 196)]
        /* 0x0E90 */ public Colour RefinerColour1B;
        [NMS(Index = 197)]
        /* 0x0EA0 */ public Colour RefinerColour1C;
        [NMS(Index = 198)]
        /* 0x0EB0 */ public Colour RefinerColour1D;
        [NMS(Index = 459)]
        /* 0x0EC0 */ public Colour ScannerColour1;
        [NMS(Index = 460)]
        /* 0x0ED0 */ public Colour ScannerColour2;
        [NMS(Index = 559)]
        /* 0x0EE0 */ public Colour TorchColour;
        [NMS(Index = 101, Size = 0x5)]
        /* 0x0EF0 */ public NMSString0x10[] SalvageTechList;
        [NMS(Index = 102, Size = 0x5)]
        /* 0x0F40 */ public NMSString0x10[] SalvageTechListMultiTool;
        [NMS(Index = 98, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x0F90 */ public NMSString0x10[] SalvageRewardsDropship;
        [NMS(Index = 99, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x0FD0 */ public NMSString0x10[] SalvageRewardsFighter;
        [NMS(Index = 100, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x1010 */ public NMSString0x10[] SalvageRewardsScience;
        [NMS(Index = 97, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x1050 */ public NMSString0x10[] SalvageRewardsShuttle;
        [NMS(Index = 630)]
        /* 0x1090 */ public NMSString0x20A CommunicatorFireteamNexusExitDialog;
        [NMS(Index = 631)]
        /* 0x10B0 */ public NMSString0x20A CommunicatorNexusExitAbandonWarningDialog;
        [NMS(Index = 399)]
        /* 0x10D0 */ public NMSString0x10 BeaconScan;
        [NMS(Index = 388)]
        /* 0x10E0 */ public NMSString0x10 BioShipTerrainResource;
        [NMS(Index = 26)]
        /* 0x10F0 */ public NMSString0x10 BuildersWordReward;
        [NMS(Index = 254)]
        /* 0x1100 */ public List<GcScanEffectData> CommunicatorEffectTable;
        [NMS(Index = 403)]
        /* 0x1110 */ public NMSString0x10 DebugScanPlanet;
        [NMS(Index = 404)]
        /* 0x1120 */ public NMSString0x10 DebugScanSpace;
        [NMS(Index = 526)]
        /* 0x1130 */ public NMSString0x10 DefaultAnim;
        [NMS(Index = 402)]
        /* 0x1140 */ public NMSString0x10 DistressSignalScan;
        [NMS(Index = 67)]
        /* 0x1150 */ public NMSString0x10 FreeShipSlotID;
        [NMS(Index = 66)]
        /* 0x1160 */ public NMSString0x10 FreeSuitSlotID;
        [NMS(Index = 68)]
        /* 0x1170 */ public NMSString0x10 FreeWeapSlotID;
        [NMS(Index = 178)]
        /* 0x1180 */ public List<NMSString0x10> FreighterHyperdriveAccess;
        [NMS(Index = 177)]
        /* 0x1190 */ public List<NMSString0x10> HyperdriveAccess;
        [NMS(Index = 124)]
        /* 0x11A0 */ public NMSString0x10 MissionSurveyWormID;
        [NMS(Index = 62)]
        /* 0x11B0 */ public NMSString0x10 NexusRecipeCostType;
        [NMS(Index = 401)]
        /* 0x11C0 */ public NMSString0x10 ObservatoryScan;
        [NMS(Index = 356)]
        /* 0x11D0 */ public List<float> PirateEarlySpawnChances;
        [NMS(Index = 24)]
        /* 0x11E0 */ public NMSString0x10 PirateMissionPrimaryReward;
        [NMS(Index = 25)]
        /* 0x11F0 */ public NMSString0x10 PirateMissionSecondReward;
        [NMS(Index = 400)]
        /* 0x1200 */ public NMSString0x10 RadioTowerScan;
        [NMS(Index = 386)]
        /* 0x1210 */ public NMSString0x10 ResourceDirtSubstanceID;
        [NMS(Index = 103)]
        /* 0x1220 */ public List<NMSString0x10> SalvageProdsList;
        [NMS(Index = 104)]
        /* 0x1230 */ public List<NMSString0x10> SalvageSubstancesList;
        [NMS(Index = 387)]
        /* 0x1240 */ public NMSString0x10 SandwormTerrainResource;
        [NMS(Index = 405)]
        /* 0x1250 */ public NMSString0x10 ShipScan;
        [NMS(Index = 396)]
        /* 0x1260 */ public NMSString0x10 ToolScan;
        [NMS(Index = 397)]
        /* 0x1270 */ public NMSString0x10 ToolScanHardMode;
        [NMS(Index = 406)]
        /* 0x1280 */ public NMSString0x10 VisualScan;
        [NMS(Index = 398)]
        /* 0x1290 */ public NMSString0x10 WaypointScan;
        [NMS(Index = 412)]
        /* 0x12A0 */ public List<GcZoomData> ZoomLevels;
        [NMS(Index = 590)]
        /* 0x12B0 */ public ulong NPCWorkerInteractionCooldown;
        [NMS(Index = 645)]
        /* 0x12B8 */ public TkModelResource WeaponSpawnAltObject;
        [NMS(Index = 644)]
        /* 0x133C */ public TkModelResource WeaponSpawnObject;
        [NMS(Index = 394)]
        /* 0x13C0 */ public GcResourceCollectEffect AsteroidResourceCollect;
        [NMS(Index = 358)]
        /* 0x13F4 */ public GcExperienceTimers FlybyTimers;
        [NMS(Index = 353)]
        /* 0x1414 */ public GcExperienceTimers FreighterTimers;
        [NMS(Index = 354)]
        /* 0x1434 */ public GcExperienceTimers PlanetPirateTimers;
        [NMS(Index = 360)]
        /* 0x1454 */ public GcExperienceTimers PoliceTimers;
        [NMS(Index = 350)]
        /* 0x1474 */ public GcExperienceTimers SentinelTimersLow;
        [NMS(Index = 351)]
        /* 0x1494 */ public GcExperienceTimers SentinelTimersNormal;
        [NMS(Index = 359)]
        /* 0x14B4 */ public GcExperienceTimers SpaceFlybyTimers;
        [NMS(Index = 355)]
        /* 0x14D4 */ public GcExperienceTimers SpacePirateTimers;
        [NMS(Index = 642, Size = 0x7)]
        /* 0x14F4 */ public int[] AlienShipEvolveCosts;
        [NMS(Index = 361, Size = 0x7, EnumType = typeof(GcProceduralTechnologyData.QualityEnum))]
        /* 0x1510 */ public int[] FreighterTechQualityWeightings;
        [NMS(Index = 524)]
        /* 0x152C */ public GcTracerData BulletTracer;
        [NMS(Index = 525)]
        /* 0x1544 */ public GcTracerData ShipTracer;
        [NMS(Index = 304, Size = 0x4, EnumType = typeof(GcPlayerConflictData.ConflictLevelEnum))]
        /* 0x155C */ public float[] ChanceOfPirateFreighterBattleOnWarpToSystem;
        [NMS(Index = 27, Size = 0x3, EnumType = typeof(GcMissionDifficulty.MissionDifficultyEnum))]
        /* 0x156C */ public float[] MissionSubstanceDifficultyMultipliers;
        [NMS(Index = 279, Size = 0x3)]
        /* 0x1578 */ public int[] PirateInterestLevels;
        [NMS(Index = 280, Size = 0x3)]
        /* 0x1584 */ public int[] PirateInterestLevelsSurvival;
        [NMS(Index = 284, Size = 0x3)]
        /* 0x1590 */ public int[] PoliceInterestLevels;
        [NMS(Index = 285, Size = 0x3)]
        /* 0x159C */ public int[] PoliceInterestLevelsSurvival;
        [NMS(Index = 647)]
        /* 0x15A8 */ public Vector2f FrigateFlybyTimer;
        [NMS(Index = 473)]
        /* 0x15B0 */ public Vector2f HUDDamageSize;
        [NMS(Index = 474)]
        /* 0x15B8 */ public Vector2f HUDDamageSplatSize;
        [NMS(Index = 604)]
        /* 0x15C0 */ public GcPortalData Portal;
        [NMS(Index = 9)]
        /* 0x15C8 */ public Vector2f SaveContextTransferShipCostScaleNanites;
        [NMS(Index = 8)]
        /* 0x15D0 */ public Vector2f SaveContextTransferShipCostScaleUnits;
        [NMS(Index = 7)]
        /* 0x15D8 */ public Vector2f SaveContextTransferWeaponCostScaleNanites;
        [NMS(Index = 6)]
        /* 0x15E0 */ public Vector2f SaveContextTransferWeaponCostScaleUnits;
        [NMS(Index = 339)]
        /* 0x15E8 */ public float AggressiveSentinelProbability;
        [NMS(Index = 340)]
        /* 0x15EC */ public float AggressiveSentinelProbabilitySurvival;
        [NMS(Index = 592)]
        /* 0x15F0 */ public float AirLockDoorRange;
        [NMS(Index = 87)]
        /* 0x15F4 */ public float AlienPodThreshold1;
        [NMS(Index = 86)]
        /* 0x15F8 */ public float AlienPodThreshold2;
        [NMS(Index = 229)]
        /* 0x15FC */ public float AllRecipesKnownNanitesMax;
        [NMS(Index = 228)]
        /* 0x1600 */ public float AllRecipesKnownNanitesMin;
        [NMS(Index = 118)]
        /* 0x1604 */ public float AngleFromBaseComputerWhenTeleporting;
        [NMS(Index = 366)]
        /* 0x1608 */ public float AsteroidCarveRadius;
        [NMS(Index = 364)]
        /* 0x160C */ public float AsteroidHitForce;
        [NMS(Index = 374)]
        /* 0x1610 */ public int AsteroidResourceReducer;
        [NMS(Index = 204)]
        /* 0x1614 */ public int AsteroidScanMaxShown;
        [NMS(Index = 206)]
        /* 0x1618 */ public float AsteroidScanRange;
        [NMS(Index = 205)]
        /* 0x161C */ public float AsteroidScanTime;
        [NMS(Index = 365)]
        /* 0x1620 */ public float AsteroidTorqueForce;
        [NMS(Index = 660)]
        /* 0x1624 */ public float AtlasGunCurrencyConversion;
        [NMS(Index = 203)]
        /* 0x1628 */ public float AtmosphereEntryErrorTime;
        [NMS(Index = 200)]
        /* 0x162C */ public float AtmosphereEntryFadeTimeFactor;
        [NMS(Index = 201)]
        /* 0x1630 */ public float AtmosphereEntryOffset;
        [NMS(Index = 199)]
        /* 0x1634 */ public float AtmosphereEntryTime;
        [NMS(Index = 120)]
        /* 0x1638 */ public float AutoTranslateWordChance;
        [NMS(Index = 632)]
        /* 0x163C */ public float BackgroundSpaceEncounterCheckTimer;
        [NMS(Index = 522)]
        /* 0x1640 */ public float BarrelOffset;
        [NMS(Index = 589)]
        /* 0x1644 */ public float BaseBuildingHoverTimeToKnowPart;
        [NMS(Index = 436)]
        /* 0x1648 */ public float BaseBuildingRemotePlayerErrorAlphaScanEffect;
        [NMS(Index = 159)]
        /* 0x164C */ public float BaseLaserHeatTime;
        [NMS(Index = 392)]
        /* 0x1650 */ public float BeaconInteractRange;
        [NMS(Index = 216)]
        /* 0x1654 */ public float BinocCreatureScanTime;
        [NMS(Index = 214)]
        /* 0x1658 */ public float BinocMinScanTime;
        [NMS(Index = 215)]
        /* 0x165C */ public float BinocScanTime;
        [NMS(Index = 213)]
        /* 0x1660 */ public float BinocTimeBeforeScan;
        [NMS(Index = 221)]
        /* 0x1664 */ public float BinocularScanTargetFadeTime;
        [NMS(Index = 212)]
        /* 0x1668 */ public float BinocularScanTargetHeightRange;
        [NMS(Index = 218)]
        /* 0x166C */ public float BinocularScanTargetInitialFadeTime;
        [NMS(Index = 220)]
        /* 0x1670 */ public float BinocularScanTargetLineWidth;
        [NMS(Index = 211)]
        /* 0x1674 */ public float BinocularScanTargetMinHeight;
        [NMS(Index = 219)]
        /* 0x1678 */ public float BinocularScanTargetScaler;
        [NMS(Index = 582)]
        /* 0x167C */ public float BlackHoleJumpVoxelDist;
        [NMS(Index = 583)]
        /* 0x1680 */ public float BlackHoleJumpVoxelVariation;
        [NMS(Index = 578)]
        /* 0x1684 */ public float BonusChildTypeElementsAdd;
        [NMS(Index = 579)]
        /* 0x1688 */ public float BonusChildTypeElementsMultiply;
        [NMS(Index = 576)]
        /* 0x168C */ public float BonusSameTypeElementsAdd;
        [NMS(Index = 577)]
        /* 0x1690 */ public float BonusSameTypeElementsMultiply;
        [NMS(Index = 369)]
        /* 0x1694 */ public float BuildingBeamDistance;
        [NMS(Index = 231)]
        /* 0x1698 */ public float BuildingPlayerBaseIconOffset;
        [NMS(Index = 89)]
        /* 0x169C */ public float BulletTraceLineWidth;
        [NMS(Index = 34)]
        /* 0x16A0 */ public float CargoShieldStrength;
        [NMS(Index = 116)]
        /* 0x16A4 */ public float CockpitScale;
        [NMS(Index = 55)]
        /* 0x16A8 */ public float CombatLevelBaseValueBoltcaster;
        [NMS(Index = 59)]
        /* 0x16AC */ public float CombatLevelBaseValueCannon;
        [NMS(Index = 60)]
        /* 0x16B0 */ public float CombatLevelBaseValueGrenade;
        [NMS(Index = 57)]
        /* 0x16B4 */ public float CombatLevelBaseValueRailgun;
        [NMS(Index = 56)]
        /* 0x16B8 */ public float CombatLevelBaseValueShotgun;
        [NMS(Index = 58)]
        /* 0x16BC */ public float CombatLevelBaseValueSMG;
        [NMS(Index = 54)]
        /* 0x16C0 */ public float CombatLevelBestWeaponBias;
        [NMS(Index = 61)]
        /* 0x16C4 */ public float CombatLevelSClassValue;
        [NMS(Index = 530)]
        /* 0x16C8 */ public float CombatSpeedReadoutMultiplier;
        [NMS(Index = 372)]
        /* 0x16CC */ public int CommonProductEffectiveness;
        [NMS(Index = 249)]
        /* 0x16D0 */ public float CommunicatorCargoScanDroneAtOffsetFallback;
        [NMS(Index = 250)]
        /* 0x16D4 */ public float CommunicatorCargoScanDronePitch;
        [NMS(Index = 251)]
        /* 0x16D8 */ public float CommunicatorCargoScanDroneRoll;
        [NMS(Index = 245)]
        /* 0x16DC */ public float CommunicatorCargoScanDroneScale;
        [NMS(Index = 246)]
        /* 0x16E0 */ public float CommunicatorCargoScanDroneScaleFallback;
        [NMS(Index = 247)]
        /* 0x16E4 */ public float CommunicatorCargoScanDroneUpOffset;
        [NMS(Index = 248)]
        /* 0x16E8 */ public float CommunicatorCargoScanDroneUpOffsetFallback;
        [NMS(Index = 252)]
        /* 0x16EC */ public float CommunicatorCargoScanDroneYaw;
        [NMS(Index = 253)]
        /* 0x16F0 */ public float CommunicatorFadeTime;
        [NMS(Index = 241)]
        /* 0x16F4 */ public float CommunicatorSpawnHeightOffset;
        [NMS(Index = 240)]
        /* 0x16F8 */ public float CommunicatorSpawnOffset;
        [NMS(Index = 244)]
        /* 0x16FC */ public float CommunicatorSpawnRotation;
        [NMS(Index = 243)]
        /* 0x1700 */ public float CommunicatorSpawnScale;
        [NMS(Index = 608)]
        /* 0x1704 */ public float CorruptSentinelProbability;
        [NMS(Index = 328)]
        /* 0x1708 */ public float CreatureMinScanTime;
        [NMS(Index = 327)]
        /* 0x170C */ public float CreatureScanAngle;
        [NMS(Index = 326)]
        /* 0x1710 */ public float CreatureScanStickyDecay;
        [NMS(Index = 151)]
        /* 0x1714 */ public int CreaturesToBaitForTutorial;
        [NMS(Index = 152)]
        /* 0x1718 */ public int CreaturesToFeedForTutorial;
        [NMS(Index = 333)]
        /* 0x171C */ public int CritDamage;
        [NMS(Index = 232)]
        /* 0x1720 */ public float CriticalHitMultiplier;
        [NMS(Index = 334)]
        /* 0x1724 */ public float CritScale;
        [NMS(Index = 614)]
        /* 0x1728 */ public float DeadPlanetGravityFactor;
        [NMS(Index = 367)]
        /* 0x172C */ public int DeathMoneyPenalty;
        [NMS(Index = 439)]
        /* 0x1730 */ public GcBuildingClassification DebugScanForceBuildingType;
        [NMS(Index = 641)]
        /* 0x1734 */ public float DerelictPulseEncounterAtmosphericEffectChance;
        [NMS(Index = 266)]
        /* 0x1738 */ public float DestroyEffectHeight;
        [NMS(Index = 267)]
        /* 0x173C */ public float DestroyEffectMaxScale;
        [NMS(Index = 119)]
        /* 0x1740 */ public float DistanceFromBaseComputerWhenTeleporting;
        [NMS(Index = 391)]
        /* 0x1744 */ public float DockNodeBuyRadius;
        [NMS(Index = 274)]
        /* 0x1748 */ public int EarlyPiratesToBeKilled;
        [NMS(Index = 336)]
        /* 0x174C */ public float EmergencyBuildingScanEventDistance;
        [NMS(Index = 337)]
        /* 0x1750 */ public float EmergencyBuildingScanEventTime;
        [NMS(Index = 268)]
        /* 0x1754 */ public float EventTargetSpeed;
        [NMS(Index = 464)]
        /* 0x1758 */ public float ExcitingNearRange;
        [NMS(Index = 462)]
        /* 0x175C */ public float ExcitingViewAngle;
        [NMS(Index = 463)]
        /* 0x1760 */ public float ExcitingViewRange;
        [NMS(Index = 570)]
        /* 0x1764 */ public float ExplosionForce;
        [NMS(Index = 571)]
        /* 0x1768 */ public float ExplosionForceMaxForceRadius;
        [NMS(Index = 569)]
        /* 0x176C */ public float ExplosionRadiusMultiplier;
        [NMS(Index = 605)]
        /* 0x1770 */ public int FourthRaceSpawnPercentage;
        [NMS(Index = 291)]
        /* 0x1774 */ public float FreighterBattleRadius;
        [NMS(Index = 303)]
        /* 0x1778 */ public float FreighterCargoPodHealthFraction;
        [NMS(Index = 302)]
        /* 0x177C */ public float FreighterFuelRodHealthFraction;
        [NMS(Index = 352)]
        /* 0x1780 */ public int FreighterStartPecent;
        [NMS(Index = 581)]
        /* 0x1784 */ public float GoalGapVoxelDist;
        [NMS(Index = 93)]
        /* 0x1788 */ public int GPSRandomChangeTimeMid;
        [NMS(Index = 94)]
        /* 0x178C */ public int GPSRandomChangeTimeNarrow;
        [NMS(Index = 92)]
        /* 0x1790 */ public int GPSRandomChangeTimeWide;
        [NMS(Index = 234)]
        /* 0x1794 */ public float GrabPlayerCooldownTime;
        [NMS(Index = 520)]
        /* 0x1798 */ public float GunDownAngle;
        [NMS(Index = 517)]
        /* 0x179C */ public float GunOffsetAggressiveX;
        [NMS(Index = 518)]
        /* 0x17A0 */ public float GunOffsetAggressiveY;
        [NMS(Index = 519)]
        /* 0x17A4 */ public float GunOffsetAggressiveZ;
        [NMS(Index = 514)]
        /* 0x17A8 */ public float GunOffsetX;
        [NMS(Index = 515)]
        /* 0x17AC */ public float GunOffsetY;
        [NMS(Index = 516)]
        /* 0x17B0 */ public float GunOffsetZ;
        [NMS(Index = 521)]
        /* 0x17B4 */ public float GunUpAngle;
        [NMS(Index = 273)]
        /* 0x17B8 */ public int HardModeTechDamageHighPercent;
        [NMS(Index = 271)]
        /* 0x17BC */ public int HardModeTechDamageMidNum;
        [NMS(Index = 272)]
        /* 0x17C0 */ public int HardModeTechDamageMidPercent;
        [NMS(Index = 160)]
        /* 0x17C4 */ public float HeatAlertTime;
        [NMS(Index = 161)]
        /* 0x17C8 */ public float HeatDamageBoost;
        [NMS(Index = 165)]
        /* 0x17CC */ public float HeatMaxPowerPoint;
        [NMS(Index = 162)]
        /* 0x17D0 */ public float HeatWidthBoost;
        [NMS(Index = 163)]
        /* 0x17D4 */ public float HeatWidthBoostAlt;
        [NMS(Index = 233)]
        /* 0x17D8 */ public float HitEffectMinTime;
        [NMS(Index = 523)]
        /* 0x17DC */ public float HitOffset;
        [NMS(Index = 181)]
        /* 0x17E0 */ public float HmdInteractionRangeMinDistance;
        [NMS(Index = 180)]
        /* 0x17E4 */ public float HmdInteractionRangeMinRange;
        [NMS(Index = 182)]
        /* 0x17E8 */ public float HmdInteractionRangeMultiplier;
        [NMS(Index = 288)]
        /* 0x17EC */ public float HoursBetweenBattles;
        [NMS(Index = 586)]
        /* 0x17F0 */ public float HoursBetweenMiniStation;
        [NMS(Index = 409)]
        /* 0x17F4 */ public float HoverTimeToScan;
        [NMS(Index = 410)]
        /* 0x17F8 */ public float HoverTimeToScanCreatures;
        [NMS(Index = 411)]
        /* 0x17FC */ public int HoverVisiblePointsNeeded;
        [NMS(Index = 472)]
        /* 0x1800 */ public float HUDArrowPrimaryScaler;
        [NMS(Index = 477)]
        /* 0x1804 */ public float HUDDamageOffset;
        [NMS(Index = 479)]
        /* 0x1808 */ public float HUDDamageRadius;
        [NMS(Index = 478)]
        /* 0x180C */ public float HUDDamageScaler;
        [NMS(Index = 482)]
        /* 0x1810 */ public float HUDLabelAngle;
        [NMS(Index = 483)]
        /* 0x1814 */ public float HUDLabelAngleOffset;
        [NMS(Index = 484)]
        /* 0x1818 */ public float HUDLabelOffsetX;
        [NMS(Index = 485)]
        /* 0x181C */ public float HUDLabelOffsetY;
        [NMS(Index = 486)]
        /* 0x1820 */ public float HUDLabelOffsetZ;
        [NMS(Index = 487)]
        /* 0x1824 */ public float HUDLabelScale;
        [NMS(Index = 481)]
        /* 0x1828 */ public float HUDLabelTime;
        [NMS(Index = 471)]
        /* 0x182C */ public float HUDLockOnAudioTime;
        [NMS(Index = 507)]
        /* 0x1830 */ public float HUDReticuleMoveAim;
        [NMS(Index = 506)]
        /* 0x1834 */ public float HUDReticuleMoveBack;
        [NMS(Index = 500)]
        /* 0x1838 */ public float HUDScaleAdd;
        [NMS(Index = 505)]
        /* 0x183C */ public float HUDScaleFarTarget;
        [NMS(Index = 504)]
        /* 0x1840 */ public float HUDScaleMax;
        [NMS(Index = 502)]
        /* 0x1844 */ public float HUDScaleMin;
        [NMS(Index = 503)]
        /* 0x1848 */ public float HUDScaleMinAim;
        [NMS(Index = 501)]
        /* 0x184C */ public float HUDScaleRadius;
        [NMS(Index = 461)]
        /* 0x1850 */ public float HUDStoreFlashTime;
        [NMS(Index = 53)]
        /* 0x1854 */ public float IllegalTechProductTradingMod;
        [NMS(Index = 50)]
        /* 0x1858 */ public float InfestedPlanetDeepSpaceFlybyMultiplier;
        [NMS(Index = 69)]
        /* 0x185C */ public float InitialLocationProtectionRadiusMultiplier;
        [NMS(Index = 260)]
        /* 0x1860 */ public float InteractionAttractTime;
        [NMS(Index = 580)]
        /* 0x1864 */ public float InteractionComponentUpdateDistance;
        [NMS(Index = 261)]
        /* 0x1868 */ public float InteractionDescriptionTextTime;
        [NMS(Index = 259)]
        /* 0x186C */ public float InteractionMessageModuleDisplayTime;
        [NMS(Index = 256)]
        /* 0x1870 */ public float InteractionMinTimeBeforeHighlightedOptionSelection;
        [NMS(Index = 257)]
        /* 0x1874 */ public float InteractionMinTimeBetweenStickOptionHighlights;
        [NMS(Index = 262)]
        /* 0x1878 */ public float InteractionMinTimeForResponseText;
        [NMS(Index = 264)]
        /* 0x187C */ public GcInteractionType InteractionOverrideFrom;
        [NMS(Index = 265)]
        /* 0x1880 */ public GcInteractionType InteractionOverrideTo;
        [NMS(Index = 567)]
        /* 0x1884 */ public float InteractionPickupAngle;
        [NMS(Index = 568)]
        /* 0x1888 */ public float InteractionPickupRadius;
        [NMS(Index = 258)]
        /* 0x188C */ public float InteractionStickOptionStrength;
        [NMS(Index = 537)]
        /* 0x1890 */ public float InteractionTorchFoV;
        [NMS(Index = 538)]
        /* 0x1894 */ public float InteractionTorchStrength;
        [NMS(Index = 584)]
        /* 0x1898 */ public float JumpToCenterFuelCost;
        [NMS(Index = 573)]
        /* 0x189C */ public float LaserExplosionForce;
        [NMS(Index = 574)]
        /* 0x18A0 */ public float LaserExplosionForceMaxForceRadius;
        [NMS(Index = 572)]
        /* 0x18A4 */ public float LaserExplosionForceRadius;
        [NMS(Index = 10)]
        /* 0x18A8 */ public int LaserRechargeHintThresholdEarly;
        [NMS(Index = 11)]
        /* 0x18AC */ public int LaserRechargeHintThresholdLate;
        [NMS(Index = 591)]
        /* 0x18B0 */ public float LightStrength;
        [NMS(Index = 466)]
        /* 0x18B4 */ public float LineWidth;
        [NMS(Index = 467)]
        /* 0x18B8 */ public float LockOffFactor;
        [NMS(Index = 341)]
        /* 0x18BC */ public float LowSentinelProbability;
        [NMS(Index = 342)]
        /* 0x18C0 */ public float LowSentinelProbabilitySurvival;
        [NMS(Index = 498)]
        /* 0x18C4 */ public float MapFOV;
        [NMS(Index = 495)]
        /* 0x18C8 */ public float MapHeight;
        [NMS(Index = 496)]
        /* 0x18CC */ public float MapOffset;
        [NMS(Index = 499)]
        /* 0x18D0 */ public float MapRadius;
        [NMS(Index = 497)]
        /* 0x18D4 */ public float MapTargetOffset;
        [NMS(Index = 72)]
        /* 0x18D8 */ public int MaxActiveWeatherHazardGifts;
        [NMS(Index = 117)]
        /* 0x18DC */ public float MaxDistanceForLadderTeleport;
        [NMS(Index = 348)]
        /* 0x18E0 */ public int MaxDronesAggressive;
        [NMS(Index = 349)]
        /* 0x18E4 */ public int MaxDronesAggressiveSurvival;
        [NMS(Index = 344)]
        /* 0x18E8 */ public int MaxDronesLow;
        [NMS(Index = 345)]
        /* 0x18EC */ public int MaxDronesLowSurvival;
        [NMS(Index = 346)]
        /* 0x18F0 */ public int MaxDronesNormal;
        [NMS(Index = 347)]
        /* 0x18F4 */ public int MaxDronesNormalSurvival;
        [NMS(Index = 76)]
        /* 0x18F8 */ public float MaxMeteorSurfaceAngle;
        [NMS(Index = 255)]
        /* 0x18FC */ public int MaxNumMissionsFromMissionGiver;
        [NMS(Index = 191)]
        /* 0x1900 */ public int MaxNumSameGroupTech;
        [NMS(Index = 230)]
        /* 0x1904 */ public float MaxPossibleShipDamagePotential;
        [NMS(Index = 368)]
        /* 0x1908 */ public int MaxResourceCrystalBlobSize;
        [NMS(Index = 613)]
        /* 0x190C */ public float MaxRespawnOnGroundHeight;
        [NMS(Index = 489)]
        /* 0x1910 */ public float MaxSpawnTime;
        [NMS(Index = 457)]
        /* 0x1914 */ public float MaxStandingTechDiscount;
        [NMS(Index = 106)]
        /* 0x1918 */ public int MaxTorpedoesInFlight;
        [NMS(Index = 12)]
        /* 0x191C */ public int MeleeHintThresholdEarly;
        [NMS(Index = 13)]
        /* 0x1920 */ public int MeleeHintThresholdLate;
        [NMS(Index = 320)]
        /* 0x1924 */ public float MissileApproachTime;
        [NMS(Index = 314)]
        /* 0x1928 */ public float MissileBrakeForceMax;
        [NMS(Index = 313)]
        /* 0x192C */ public float MissileBrakeForceMin;
        [NMS(Index = 316)]
        /* 0x1930 */ public float MissileBrakeTime;
        [NMS(Index = 312)]
        /* 0x1934 */ public float MissileForceMax;
        [NMS(Index = 311)]
        /* 0x1938 */ public float MissileForceMin;
        [NMS(Index = 317)]
        /* 0x193C */ public float MissileHitRadius;
        [NMS(Index = 306)]
        /* 0x1940 */ public float MissileLockTime;
        [NMS(Index = 310)]
        /* 0x1944 */ public float MissileMaxSpeed;
        [NMS(Index = 305)]
        /* 0x1948 */ public float MissileMaxTurnAngle;
        [NMS(Index = 319)]
        /* 0x194C */ public float MissileMinCircleTime;
        [NMS(Index = 318)]
        /* 0x1950 */ public float MissileOffset;
        [NMS(Index = 307)]
        /* 0x1954 */ public float MissileReloadTime;
        [NMS(Index = 309)]
        /* 0x1958 */ public float MissileRotateMax;
        [NMS(Index = 308)]
        /* 0x195C */ public float MissileRotateMin;
        [NMS(Index = 321)]
        /* 0x1960 */ public float MissileRotateSpeed;
        [NMS(Index = 315)]
        /* 0x1964 */ public float MissileThreatTime;
        [NMS(Index = 227)]
        /* 0x1968 */ public float MissionEventAllowResetDistance;
        [NMS(Index = 134)]
        /* 0x196C */ public float MissionSurveyAutoScanDistance;
        [NMS(Index = 135)]
        /* 0x1970 */ public float MissionSurveyAutoScanFlattenRadiusMul;
        [NMS(Index = 130)]
        /* 0x1974 */ public float MissionSurveyBeginScanPercentageEvent;
        [NMS(Index = 129)]
        /* 0x1978 */ public float MissionSurveyBeginScanPercentageScannable;
        [NMS(Index = 141)]
        /* 0x197C */ public float MissionSurveyInShipArrivedDistance;
        [NMS(Index = 125)]
        /* 0x1980 */ public float MissionSurveyMarkerAutoHideTime;
        [NMS(Index = 139)]
        /* 0x1984 */ public float MissionSurveyMaxAngleOffset;
        [NMS(Index = 122)]
        /* 0x1988 */ public float MissionSurveyMaxGuidanceDistance;
        [NMS(Index = 123)]
        /* 0x198C */ public float MissionSurveyMaxGuidanceDistanceWorms;
        [NMS(Index = 127)]
        /* 0x1990 */ public float MissionSurveyMaxScanAngle;
        [NMS(Index = 128)]
        /* 0x1994 */ public float MissionSurveyMaxScanAngleScannableComp;
        [NMS(Index = 140)]
        /* 0x1998 */ public float MissionSurveyMaxSignalConeAngle;
        [NMS(Index = 133)]
        /* 0x199C */ public float MissionSurveyRevealWithoutScanDistance;
        [NMS(Index = 126)]
        /* 0x19A0 */ public float MissionSurveyScanRangeMultiplier;
        [NMS(Index = 131)]
        /* 0x19A4 */ public float MissionSurveyScanSpeed;
        [NMS(Index = 132)]
        /* 0x19A8 */ public float MissionSurveyScanSpeedScannableComp;
        [NMS(Index = 137)]
        /* 0x19AC */ public float MissionSurveySonarMaxPulseSpeed;
        [NMS(Index = 136)]
        /* 0x19B0 */ public float MissionSurveySonarMinPulseSpeed;
        [NMS(Index = 138)]
        /* 0x19B4 */ public float MissionSurveySonarPulseSpeedBandCount;
        [NMS(Index = 508)]
        /* 0x19B8 */ public float MouseSensitivity;
        [NMS(Index = 509)]
        /* 0x19BC */ public float MouseSensitivityShip;
        [NMS(Index = 510)]
        /* 0x19C0 */ public float MouseSensitivityVehicle;
        [NMS(Index = 111)]
        /* 0x19C4 */ public float MultidimensionalFadeTime;
        [NMS(Index = 330)]
        /* 0x19C8 */ public float NewDiscoveryDisplayTime;
        [NMS(Index = 63)]
        /* 0x19CC */ public int NexusRecipeCostNaniteMultiplier;
        [NMS(Index = 343)]
        /* 0x19D0 */ public float NonAggressiveLushSurvivalProbabability;
        [NMS(Index = 606)]
        /* 0x19D4 */ public int NonDominantRaceSpawnPercentage;
        [NMS(Index = 607)]
        /* 0x19D8 */ public int NonDominantRaceSpawnPercentagePirate;
        [NMS(Index = 458)]
        /* 0x19DC */ public float NonNaturalCostMul;
        [NMS(Index = 158)]
        /* 0x19E0 */ public float NormalModeHeatBonus;
        [NMS(Index = 4)]
        /* 0x19E4 */ public float NPCNavNodeSearchUpDistScaling;
        [NMS(Index = 22)]
        /* 0x19E8 */ public float NPCWaitWhenRevealedTime;
        [NMS(Index = 335)]
        /* 0x19EC */ public int NumMissionsPerSolarSystem;
        [NMS(Index = 468)]
        /* 0x19F0 */ public float OffscreenFadeDistance;
        [NMS(Index = 469)]
        /* 0x19F4 */ public float OffscreenMinDot;
        [NMS(Index = 166)]
        /* 0x19F8 */ public float OverheatDecay;
        [NMS(Index = 164)]
        /* 0x19FC */ public float OverheatGenerosity;
        [NMS(Index = 511)]
        /* 0x1A00 */ public float PainTime;
        [NMS(Index = 70)]
        /* 0x1A04 */ public float PartyPlanetSearchDistance;
        [NMS(Index = 649)]
        /* 0x1A08 */ public int PersonalInventoryMinHeightMax;
        [NMS(Index = 648)]
        /* 0x1A0C */ public int PersonalInventoryMinWidthMax;
        [NMS(Index = 651)]
        /* 0x1A10 */ public int PersonalTechInventoryMinHeightMax;
        [NMS(Index = 650)]
        /* 0x1A14 */ public int PersonalTechInventoryMinWidthMax;
        [NMS(Index = 357)]
        /* 0x1A18 */ public float PirateEarlySpawnTime;
        [NMS(Index = 107)]
        /* 0x1A1C */ public float PirateFreighterBattleNoTargetLeaderTime;
        [NMS(Index = 295)]
        /* 0x1A20 */ public float PirateFreighterBeginFleeHealthFraction;
        [NMS(Index = 292)]
        /* 0x1A24 */ public int PirateFreighterFrigateCountForReinforce;
        [NMS(Index = 298)]
        /* 0x1A28 */ public float PirateFreighterRewardDelayTime;
        [NMS(Index = 300)]
        /* 0x1A2C */ public float PirateFreighterRewardDelayTimeEscaped;
        [NMS(Index = 299)]
        /* 0x1A30 */ public float PirateFreighterRewardMessageDelayTime;
        [NMS(Index = 301)]
        /* 0x1A34 */ public float PirateFreighterRewardMessageDelayTimeEscaped;
        [NMS(Index = 294)]
        /* 0x1A38 */ public float PirateFreighterWarpChargeTime;
        [NMS(Index = 293)]
        /* 0x1A3C */ public float PirateFreighterWarpChargeTimeToAddPerBrokenEngine;
        [NMS(Index = 40)]
        /* 0x1A40 */ public float PirateGroundAccelerator;
        [NMS(Index = 41)]
        /* 0x1A44 */ public float PirateGroundInventoryAccelerator;
        [NMS(Index = 277)]
        /* 0x1A48 */ public float PirateInterestDistance;
        [NMS(Index = 278)]
        /* 0x1A4C */ public float PirateInterestDistanceMPMission;
        [NMS(Index = 276)]
        /* 0x1A50 */ public int PirateInterestOverride;
        [NMS(Index = 39)]
        /* 0x1A54 */ public float PirateRaidAccelerator;
        [NMS(Index = 275)]
        /* 0x1A58 */ public int PlanetPirateFlybyMaxRepeatCounter;
        [NMS(Index = 560)]
        /* 0x1A5C */ public float PlayerAmbientSpotLightIntensity;
        [NMS(Index = 562)]
        /* 0x1A60 */ public float PlayerAmbientSpotLightOffsetY;
        [NMS(Index = 563)]
        /* 0x1A64 */ public float PlayerAmbientSpotLightOffsetZ;
        [NMS(Index = 47)]
        /* 0x1A68 */ public float PoliceAcceleratorNoCargoNormal;
        [NMS(Index = 48)]
        /* 0x1A6C */ public float PoliceAcceleratorNoCargoSkipScanOdds;
        [NMS(Index = 46)]
        /* 0x1A70 */ public float PoliceAcceleratorNoCargoWealthy;
        [NMS(Index = 43)]
        /* 0x1A74 */ public float PoliceAcceleratorPulseExtra;
        [NMS(Index = 44)]
        /* 0x1A78 */ public int PoliceAcceleratorSmugglingItemsMax;
        [NMS(Index = 45)]
        /* 0x1A7C */ public float PoliceAcceleratorSmugglingMulMax;
        [NMS(Index = 42)]
        /* 0x1A80 */ public float PoliceAcceleratorStationLockOn;
        [NMS(Index = 282)]
        /* 0x1A84 */ public float PoliceInterestDistance;
        [NMS(Index = 283)]
        /* 0x1A88 */ public float PoliceInterestDistanceMPMission;
        [NMS(Index = 281)]
        /* 0x1A8C */ public int PoliceInterestOverride;
        [NMS(Index = 600)]
        /* 0x1A90 */ public int ProductItemStockDecayTime;
        [NMS(Index = 601)]
        /* 0x1A94 */ public int ProductItemStockReplenishTime;
        [NMS(Index = 338)]
        /* 0x1A98 */ public float ProjectileLightIntensity;
        [NMS(Index = 465)]
        /* 0x1A9C */ public float ProjectileSpeedBoost;
        [NMS(Index = 634)]
        /* 0x1AA0 */ public float PulseEncounterChance;
        [NMS(Index = 638)]
        /* 0x1AA4 */ public float PulseEncounterChanceBlue;
        [NMS(Index = 637)]
        /* 0x1AA8 */ public float PulseEncounterChanceGreen;
        [NMS(Index = 636)]
        /* 0x1AAC */ public float PulseEncounterChanceRed;
        [NMS(Index = 635)]
        /* 0x1AB0 */ public float PulseEncounterChanceStandard;
        [NMS(Index = 633)]
        /* 0x1AB4 */ public float PulseEncounterCheckTimer;
        [NMS(Index = 639)]
        /* 0x1AB8 */ public float PulseEncounterStopPower;
        [NMS(Index = 640)]
        /* 0x1ABC */ public float PulseEncounterStopSpeed;
        [NMS(Index = 373)]
        /* 0x1AC0 */ public int RareProductEffectiveness;
        [NMS(Index = 371)]
        /* 0x1AC4 */ public int RareSubstanceEffectiveness;
        [NMS(Index = 173)]
        /* 0x1AC8 */ public int RefinerProductsMadeInTime;
        [NMS(Index = 175)]
        /* 0x1ACC */ public int RefinerProductsMadeInTimeSurvival;
        [NMS(Index = 174)]
        /* 0x1AD0 */ public int RefinerSubsMadeInTime;
        [NMS(Index = 176)]
        /* 0x1AD4 */ public int RefinerSubsMadeInTimeSurvival;
        [NMS(Index = 382)]
        /* 0x1AD8 */ public int ResourceCommonMaxAmount;
        [NMS(Index = 381)]
        /* 0x1ADC */ public int ResourceCommonMinAmount;
        [NMS(Index = 380)]
        /* 0x1AE0 */ public int ResourceCommonReducer;
        [NMS(Index = 385)]
        /* 0x1AE4 */ public int ResourceDirtMaxAmount;
        [NMS(Index = 384)]
        /* 0x1AE8 */ public int ResourceDirtMinAmount;
        [NMS(Index = 383)]
        /* 0x1AEC */ public int ResourceDirtReducer;
        [NMS(Index = 379)]
        /* 0x1AF0 */ public int ResourceMaxAmount;
        [NMS(Index = 378)]
        /* 0x1AF4 */ public int ResourceMinAmount;
        [NMS(Index = 493)]
        /* 0x1AF8 */ public int ResourceParticleMaxNum;
        [NMS(Index = 494)]
        /* 0x1AFC */ public int ResourceParticleMinNum;
        [NMS(Index = 491)]
        /* 0x1B00 */ public float ResourceParticleSpeed;
        [NMS(Index = 492)]
        /* 0x1B04 */ public float ResourceParticleSpread;
        [NMS(Index = 377)]
        /* 0x1B08 */ public int ResourceReducer;
        [NMS(Index = 32)]
        /* 0x1B0C */ public int RocketLockerFuelUse;
        [NMS(Index = 624)]
        /* 0x1B10 */ public float SalvageShipExplodeShipDistance;
        [NMS(Index = 620)]
        /* 0x1B14 */ public float SalvageShipExplodeSpeed;
        [NMS(Index = 619)]
        /* 0x1B18 */ public float SalvageShipHeightOffset;
        [NMS(Index = 625)]
        /* 0x1B1C */ public float SalvageShipOneRevolutionTime;
        [NMS(Index = 618)]
        /* 0x1B20 */ public float SalvageShipPitch;
        [NMS(Index = 623)]
        /* 0x1B24 */ public float SalvageShipShowShipDistance;
        [NMS(Index = 621)]
        /* 0x1B28 */ public float SalvageShipShowShipSpeed;
        [NMS(Index = 622)]
        /* 0x1B2C */ public float SalvageShipShowShipSpeedSwitching;
        [NMS(Index = 96)]
        /* 0x1B30 */ public int SalvageSubstanceValueThreshold;
        [NMS(Index = 95)]
        /* 0x1B34 */ public float SalvageValueAsProds;
        [NMS(Index = 627)]
        /* 0x1B38 */ public float SalvageWeaponHeightOffset;
        [NMS(Index = 629)]
        /* 0x1B3C */ public float SalvageWeaponMaxSize;
        [NMS(Index = 626)]
        /* 0x1B40 */ public float SalvageWeaponPitch;
        [NMS(Index = 628)]
        /* 0x1B44 */ public float SalvageWeaponScale;
        [NMS(Index = 329)]
        /* 0x1B48 */ public float ScanAngle;
        [NMS(Index = 395)]
        /* 0x1B4C */ public float ScanAngleCutoff;
        [NMS(Index = 225)]
        /* 0x1B50 */ public float ScannableComponentMarkerOffset;
        [NMS(Index = 226)]
        /* 0x1B54 */ public float ScannableComponentPlaceMarkerOffset;
        [NMS(Index = 446)]
        /* 0x1B58 */ public float ScannerAnalyzeFXRate;
        [NMS(Index = 224)]
        /* 0x1B5C */ public float ScannerIconsClumpRadius;
        [NMS(Index = 443)]
        /* 0x1B60 */ public float ScannerMarkerFadeTime;
        [NMS(Index = 445)]
        /* 0x1B64 */ public float ScannerPhysicsProbeAABBSize;
        [NMS(Index = 444)]
        /* 0x1B68 */ public float ScannerSmallMarkerFadeTime;
        [NMS(Index = 447)]
        /* 0x1B6C */ public float ScannerSubstanceTimePerTrigger;
        [NMS(Index = 448)]
        /* 0x1B70 */ public float ScannerTuningA;
        [NMS(Index = 449)]
        /* 0x1B74 */ public float ScannerTuningB;
        [NMS(Index = 450)]
        /* 0x1B78 */ public float ScannerTuningC;
        [NMS(Index = 451)]
        /* 0x1B7C */ public float ScannerTuningD;
        [NMS(Index = 452)]
        /* 0x1B80 */ public float ScannerTuningResourceOffset1;
        [NMS(Index = 453)]
        /* 0x1B84 */ public float ScannerTuningResourceOffset2;
        [NMS(Index = 454)]
        /* 0x1B88 */ public float ScannerTuningSmoothStepAmount;
        [NMS(Index = 455)]
        /* 0x1B8C */ public float ScannerTuningTrailingEdge;
        [NMS(Index = 322)]
        /* 0x1B90 */ public float ScanStartTimeDelayMinDist;
        [NMS(Index = 323)]
        /* 0x1B94 */ public float ScanStartTimeDelayRange;
        [NMS(Index = 324)]
        /* 0x1B98 */ public float ScanStartTimeDistanceDelayTime;
        [NMS(Index = 325)]
        /* 0x1B9C */ public float ScanStickyDecay;
        [NMS(Index = 19)]
        /* 0x1BA0 */ public float ScanToRevealDelayOverride;
        [NMS(Index = 23)]
        /* 0x1BA4 */ public float ScanToRevealVFXBaseScalingSize;
        [NMS(Index = 612)]
        /* 0x1BA8 */ public float ScrapDroneProbability;
        [NMS(Index = 179)]
        /* 0x1BAC */ public float SeasonalMessageModuleAttractDistanceMul;
        [NMS(Index = 362)]
        /* 0x1BB0 */ public int SentinelsHigh;
        [NMS(Index = 363)]
        /* 0x1BB4 */ public int SentinelsLow;
        [NMS(Index = 1)]
        /* 0x1BB8 */ public float ShipBuilderInteractionBuildEffectTime;
        [NMS(Index = 2)]
        /* 0x1BBC */ public float ShipBuilderInteractionDissolveEffectTime;
        [NMS(Index = 90)]
        /* 0x1BC0 */ public float ShipBulletTraceLineWidth;
        [NMS(Index = 596)]
        /* 0x1BC4 */ public float ShipDisplayDamageMultiplier;
        [NMS(Index = 393)]
        /* 0x1BC8 */ public float ShipInteractRadius;
        [NMS(Index = 49)]
        /* 0x1BCC */ public float ShipInterestAcceleratorInAsteroidField;
        [NMS(Index = 653)]
        /* 0x1BD0 */ public int ShipInventoryMinHeightMax;
        [NMS(Index = 652)]
        /* 0x1BD4 */ public int ShipInventoryMinWidthMax;
        [NMS(Index = 51)]
        /* 0x1BD8 */ public float ShipMiningMul;
        [NMS(Index = 440)]
        /* 0x1BDC */ public float ShipScanOffset;
        [NMS(Index = 441)]
        /* 0x1BE0 */ public float ShipScanOffsetGap;
        [NMS(Index = 64)]
        /* 0x1BE4 */ public float ShipScanPlanetRechargeMultiplier;
        [NMS(Index = 65)]
        /* 0x1BE8 */ public float ShipScanSpaceRechargeMultiplier;
        [NMS(Index = 655)]
        /* 0x1BEC */ public int ShipTechInventoryMinHeightMax;
        [NMS(Index = 654)]
        /* 0x1BF0 */ public int ShipTechInventoryMinWidthMax;
        [NMS(Index = 194)]
        /* 0x1BF4 */ public float ShootableAggroForgetTime;
        [NMS(Index = 193)]
        /* 0x1BF8 */ public float ShootableAggroMinStartTime;
        [NMS(Index = 192)]
        /* 0x1BFC */ public float ShootableArmourHighlightHitTime;
        [NMS(Index = 566)]
        /* 0x1C00 */ public float SimpleInteractionMessageTime;
        [NMS(Index = 564)]
        /* 0x1C04 */ public float SimpleInteractionPickupAngle;
        [NMS(Index = 565)]
        /* 0x1C08 */ public float SimpleInteractionPickupRadius;
        [NMS(Index = 52)]
        /* 0x1C0C */ public float SmugglerSellingMarkup;
        [NMS(Index = 290)]
        /* 0x1C10 */ public float SpaceBattleAnyHostileShipsRadius;
        [NMS(Index = 296)]
        /* 0x1C14 */ public int SpaceBattleMaxTorpedosTargetingLeaderShip;
        [NMS(Index = 297)]
        /* 0x1C18 */ public int SpaceBattleMaxTorpedosTargetingNonLeaderShip;
        [NMS(Index = 289)]
        /* 0x1C1C */ public float SpaceBattleRadius;
        [NMS(Index = 286)]
        /* 0x1C20 */ public float SpaceCombatRadius;
        [NMS(Index = 529)]
        /* 0x1C24 */ public float SpaceSpeedReadoutMultiplier;
        [NMS(Index = 643)]
        /* 0x1C28 */ public float SpawnerWeaponRange;
        [NMS(Index = 269)]
        /* 0x1C2C */ public int SpecialMiningAmount;
        [NMS(Index = 270)]
        /* 0x1C30 */ public float SpecialMiningTime;
        [NMS(Index = 31)]
        /* 0x1C34 */ public float SpecialTechSlotBonus;
        [NMS(Index = 528)]
        /* 0x1C38 */ public float SpeedReadoutMultiplier;
        [NMS(Index = 78)]
        /* 0x1C3C */ public float StormBonusJetpackMod;
        [NMS(Index = 82)]
        /* 0x1C40 */ public GcPlayerHazardType StormBonusJetpackWeather;
        [NMS(Index = 81)]
        /* 0x1C44 */ public float StormBonusMiningAmountMod;
        [NMS(Index = 85)]
        /* 0x1C48 */ public GcPlayerHazardType StormBonusMiningAmountWeather;
        [NMS(Index = 80)]
        /* 0x1C4C */ public float StormBonusMiningHeatMod;
        [NMS(Index = 84)]
        /* 0x1C50 */ public GcPlayerHazardType StormBonusMiningHeatWeather;
        [NMS(Index = 79)]
        /* 0x1C54 */ public float StormBonusSprintMod;
        [NMS(Index = 83)]
        /* 0x1C58 */ public GcPlayerHazardType StormBonusSprintWeather;
        [NMS(Index = 77)]
        /* 0x1C5C */ public float StormGravityChangeTime;
        [NMS(Index = 602)]
        /* 0x1C60 */ public int SubstanceItemStockDecayTime;
        [NMS(Index = 603)]
        /* 0x1C64 */ public int SubstanceItemStockReplenishTime;
        [NMS(Index = 142)]
        /* 0x1C68 */ public float SurveyBeginScanPercentage;
        [NMS(Index = 150)]
        /* 0x1C6C */ public float SurveyMaxDistance;
        [NMS(Index = 144)]
        /* 0x1C70 */ public float SurveyScanMaxSpeed;
        [NMS(Index = 143)]
        /* 0x1C74 */ public float SurveyScanMinSpeed;
        [NMS(Index = 147)]
        /* 0x1C78 */ public float SurveySonarMaxPulseSpeed;
        [NMS(Index = 149)]
        /* 0x1C7C */ public float SurveySonarMiddleRangeMax;
        [NMS(Index = 148)]
        /* 0x1C80 */ public float SurveySonarMiddleRangeMin;
        [NMS(Index = 146)]
        /* 0x1C84 */ public float SurveySonarMinPulseSpeed;
        [NMS(Index = 145)]
        /* 0x1C88 */ public float SurveySonarPulseSpeedBandCount;
        [NMS(Index = 236)]
        /* 0x1C8C */ public float TapInteractionDecay;
        [NMS(Index = 235)]
        /* 0x1C90 */ public float TapInteractionIncreaseAmount;
        [NMS(Index = 35)]
        /* 0x1C94 */ public float TechDamageChanceShieldedMax;
        [NMS(Index = 37)]
        /* 0x1C98 */ public float TechDamageChanceShieldLevelMax;
        [NMS(Index = 36)]
        /* 0x1C9C */ public float TechDamageChanceShieldLevelMin;
        [NMS(Index = 38)]
        /* 0x1CA0 */ public float TechDamageChanceToSelectPrimary;
        [NMS(Index = 75)]
        /* 0x1CA4 */ public GcTechnologyCategory TechnologyOverrideForSmuggler;
        [NMS(Index = 112)]
        /* 0x1CA8 */ public float TeleporterDistanceTravelledMultiplier;
        [NMS(Index = 209)]
        /* 0x1CAC */ public float TerrainResourceCompassRange;
        [NMS(Index = 208)]
        /* 0x1CB0 */ public float TerrainResourceScanRange;
        [NMS(Index = 207)]
        /* 0x1CB4 */ public float TerrainResourceScanTime;
        [NMS(Index = 408)]
        /* 0x1CB8 */ public float TimeToDisplayScanResults;
        [NMS(Index = 531)]
        /* 0x1CBC */ public int TorchCookieIndex;
        [NMS(Index = 534)]
        /* 0x1CC0 */ public int TorchDimCookieIndex;
        [NMS(Index = 535)]
        /* 0x1CC4 */ public float TorchDimFoV;
        [NMS(Index = 536)]
        /* 0x1CC8 */ public float TorchDimStrength;
        [NMS(Index = 557)]
        /* 0x1CCC */ public float TorchFollowCameraPitch;
        [NMS(Index = 558)]
        /* 0x1CD0 */ public float TorchFollowCameraTime;
        [NMS(Index = 532)]
        /* 0x1CD4 */ public float TorchFoV;
        [NMS(Index = 552)]
        /* 0x1CD8 */ public float TorchHandOffsetX;
        [NMS(Index = 553)]
        /* 0x1CDC */ public float TorchHandOffsetY;
        [NMS(Index = 554)]
        /* 0x1CE0 */ public float TorchHandOffsetZ;
        [NMS(Index = 543)]
        /* 0x1CE4 */ public float TorchOffsetX;
        [NMS(Index = 544)]
        /* 0x1CE8 */ public float TorchOffsetY;
        [NMS(Index = 546)]
        /* 0x1CEC */ public float TorchOffsetZ;
        [NMS(Index = 545)]
        /* 0x1CF0 */ public float TorchOffsetZMin;
        [NMS(Index = 551)]
        /* 0x1CF4 */ public float TorchOffsetZMinSpeed;
        [NMS(Index = 550)]
        /* 0x1CF8 */ public float TorchOffsetZSpeedRange;
        [NMS(Index = 556)]
        /* 0x1CFC */ public float TorchRotation;
        [NMS(Index = 547)]
        /* 0x1D00 */ public float TorchStaffOffsetY;
        [NMS(Index = 549)]
        /* 0x1D04 */ public float TorchStaffOffsetZ;
        [NMS(Index = 548)]
        /* 0x1D08 */ public float TorchStaffOffsetZMin;
        [NMS(Index = 533)]
        /* 0x1D0C */ public float TorchStrength;
        [NMS(Index = 105)]
        /* 0x1D10 */ public float TorpedoCooldown;
        [NMS(Index = 109)]
        /* 0x1D14 */ public float TorpedoCooldownRandomExtra;
        [NMS(Index = 108)]
        /* 0x1D18 */ public float TorpedoInitialWait;
        [NMS(Index = 110)]
        /* 0x1D1C */ public float TorpedoLaunchWarning;
        [NMS(Index = 375)]
        /* 0x1D20 */ public int TunnelStatReducer;
        [NMS(Index = 14)]
        /* 0x1D24 */ public float TurretAITargetingDistanceFactor;
        [NMS(Index = 18)]
        /* 0x1D28 */ public float TurretAITargetingFocusPlayerFactor;
        [NMS(Index = 17)]
        /* 0x1D2C */ public float TurretAITargetingLastHitFactor;
        [NMS(Index = 15)]
        /* 0x1D30 */ public float TurretAITargetingPitchAngleFactor;
        [NMS(Index = 16)]
        /* 0x1D34 */ public float TurretAITargetingYawAngleFactor;
        [NMS(Index = 539)]
        /* 0x1D38 */ public float UndergroundTorchFoV;
        [NMS(Index = 540)]
        /* 0x1D3C */ public float UndergroundTorchFoVFar;
        [NMS(Index = 541)]
        /* 0x1D40 */ public float UndergroundTorchStrength;
        [NMS(Index = 542)]
        /* 0x1D44 */ public float UndergroundTorchStrengthFar;
        [NMS(Index = 71)]
        /* 0x1D48 */ public float UnderwaterLightningDamageDistanceMultiplier;
        [NMS(Index = 91)]
        /* 0x1D4C */ public float VehicleAllIconScanTime;
        [NMS(Index = 657)]
        /* 0x1D50 */ public int VehicleInventoryMinHeightMax;
        [NMS(Index = 656)]
        /* 0x1D54 */ public int VehicleInventoryMinWidthMax;
        [NMS(Index = 609)]
        /* 0x1D58 */ public float ViciousSentinelProbability;
        [NMS(Index = 610)]
        /* 0x1D5C */ public float ViciousStormProbability;
        [NMS(Index = 611)]
        /* 0x1D60 */ public float ViciousWeatherProbability;
        [NMS(Index = 376)]
        /* 0x1D64 */ public float VoxelAsteroidResourceChance;
        [NMS(Index = 287)]
        /* 0x1D68 */ public int WarpsBetweenBattles;
        [NMS(Index = 585)]
        /* 0x1D6C */ public int WarpsBetweenMiniStation;
        [NMS(Index = 332)]
        /* 0x1D70 */ public float WaterLandingDamageMultiplier;
        [NMS(Index = 370)]
        /* 0x1D74 */ public float WaypointScanTime;
        [NMS(Index = 659)]
        /* 0x1D78 */ public int WeaponInventoryMinHeightMax;
        [NMS(Index = 658)]
        /* 0x1D7C */ public int WeaponInventoryMinWidthMax;
        [NMS(Index = 74)]
        /* 0x1D80 */ public float WeatherHazardGiftLifeTime;
        [NMS(Index = 73)]
        /* 0x1D84 */ public float WeatherHazardGiftMaxDistance;
        [NMS(Index = 407)]
        /* 0x1D88 */ public float ZoomFindBuildingRange;
        [NMS(Index = 588)]
        /* 0x1D8C */ public NMSString0x80 BaseBuildingTable;
        [NMS(Index = 575)]
        /* 0x1E0C */ public NMSString0x80 InitialDebrisScene;
        [NMS(Index = 587)]
        /* 0x1E8C */ public NMSString0x80 LegacyBaseBuildingTable;
        [NMS(Index = 490)]
        /* 0x1F0C */ public NMSString0x80 ResourceParticleFile;
        [NMS(Index = 390)]
        /* 0x1F8C */ public NMSString0x20 DepotResource;
        [NMS(Index = 389)]
        /* 0x1FAC */ public NMSString0x20 RobotResource;
        [NMS(Index = 187)]
        /* 0x1FCC */ public bool AllowBinocularMarker;
        [NMS(Index = 186)]
        /* 0x1FCD */ public bool AllowDeconstruct;
        [NMS(Index = 156)]
        /* 0x1FCE */ public bool AllowSpaceScanEvents;
        [NMS(Index = 202)]
        /* 0x1FCF */ public TkCurveType AtmosphereEntryCurve;
        [NMS(Index = 456)]
        /* 0x1FD0 */ public bool Autolevel;
        [NMS(Index = 210)]
        /* 0x1FD1 */ public bool BinocsDisplayUnknownCreatures;
        [NMS(Index = 217)]
        /* 0x1FD2 */ public TkCurveType BinocularScanTargetHeightCurve;
        [NMS(Index = 157)]
        /* 0x1FD3 */ public bool CanMoveTechnology;
        [NMS(Index = 598)]
        /* 0x1FD4 */ public bool ChangePricesLocally;
        [NMS(Index = 527)]
        /* 0x1FD5 */ public bool DebugDrawTriggerBoxes;
        [NMS(Index = 30)]
        /* 0x1FD6 */ public bool DebugPrintShootables;
        [NMS(Index = 438)]
        /* 0x1FD7 */ public bool DebugScanForceBuilding;
        [NMS(Index = 185)]
        /* 0x1FD8 */ public bool DisableAnomalyAmbientSpawn;
        [NMS(Index = 593)]
        /* 0x1FD9 */ public bool DisableBasePowerHUDOverlay;
        [NMS(Index = 153)]
        /* 0x1FDA */ public bool DisableGalaxyMapInQuickMenu;
        [NMS(Index = 154)]
        /* 0x1FDB */ public bool DisableNexusInQuickMenu;
        [NMS(Index = 0)]
        /* 0x1FDC */ public bool DoShipBuilderInteractionBuildEffect;
        [NMS(Index = 3)]
        /* 0x1FDD */ public bool DoShipBuilderInteractionBuildEffectOutward;
        [NMS(Index = 190)]
        /* 0x1FDE */ public bool EnableShootHitEffect;
        [NMS(Index = 33)]
        /* 0x1FDF */ public bool EnableTechPackaging;
        [NMS(Index = 155)]
        /* 0x1FE0 */ public bool EnableTeleporters;
        [NMS(Index = 188)]
        /* 0x1FE1 */ public bool EveryMaintenanceIsBroken;
        [NMS(Index = 331)]
        /* 0x1FE2 */ public bool FailToFindBuildings;
        [NMS(Index = 184)]
        /* 0x1FE3 */ public bool FreighterRequiresRGBHyperdriveUpgrades;
        [NMS(Index = 470)]
        /* 0x1FE4 */ public bool HUDUpdateFromData;
        [NMS(Index = 183)]
        /* 0x1FE5 */ public bool InstallTechWithInteraction;
        [NMS(Index = 263)]
        /* 0x1FE6 */ public bool InteractionOverride;
        [NMS(Index = 594)]
        /* 0x1FE7 */ public bool KeepAttackingMaxWantedLevel;
        [NMS(Index = 121)]
        /* 0x1FE8 */ public bool MissionSurveySuggestSurveyForNearScannables;
        [NMS(Index = 172)]
        /* 0x1FE9 */ public TkCurveType OverheatColourCurve;
        [NMS(Index = 171)]
        /* 0x1FEA */ public TkCurveType OverheatColourCurveShip;
        [NMS(Index = 167)]
        /* 0x1FEB */ public TkCurveType OverheatCurve;
        [NMS(Index = 512)]
        /* 0x1FEC */ public TkCurveType PainCurve;
        [NMS(Index = 488)]
        /* 0x1FED */ public bool PlayHitEffectsOnZeroDamage;
        [NMS(Index = 5)]
        /* 0x1FEE */ public bool RewardInventoryClassItemFromShipSalvage;
        [NMS(Index = 20)]
        /* 0x1FEF */ public bool ScanToRevealIgnoreRequirements;
        [NMS(Index = 21)]
        /* 0x1FF0 */ public bool ScanToRevealNPCsAlwaysTriggersCameraEvent;
        [NMS(Index = 442)]
        /* 0x1FF1 */ public TkCurveType ShipScanCurve;
        [NMS(Index = 599)]
        /* 0x1FF2 */ public bool ShowPriceMarkupsAsPercentages;
        [NMS(Index = 189)]
        /* 0x1FF3 */ public bool SpawnResourceBlobsOnPartDelete;
        [NMS(Index = 29)]
        /* 0x1FF4 */ public bool TechMustBeInTechInventory;
        [NMS(Index = 555)]
        /* 0x1FF5 */ public bool TorchDisabledInTheDay;
        [NMS(Index = 646)]
        /* 0x1FF6 */ public bool UseCustomSaveDirectory;
        [NMS(Index = 437)]
        /* 0x1FF7 */ public bool UseDebugScan;
        [NMS(Index = 595)]
        /* 0x1FF8 */ public bool UseMultiplierBonus;
        [NMS(Index = 168)]
        /* 0x1FF9 */ public bool UseOverheatColour;
        [NMS(Index = 28)]
        /* 0x1FFA */ public bool UseSecondaryBiomeSubstances;
        [NMS(Index = 597)]
        /* 0x1FFB */ public bool UseTradingCostTable;
    }
}
