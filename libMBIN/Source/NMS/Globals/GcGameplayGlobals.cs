using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x59DC9EE67363EB4, NameHash = 0x71CAF682B6986E6E)]
    public class GcGameplayGlobals : NMSTemplate
    {
        [NMS(Index = 482)]
        /* 0x0000 */ public GcShipHUDTargetData HUDTarget;
        [NMS(Index = 426)]
        /* 0x0420 */ public GcScanEffectData BaseBuildingDeleteScanEffect;
        [NMS(Index = 434)]
        /* 0x0470 */ public GcScanEffectData BaseBuildingErrorAboveWaterScanEffect;
        [NMS(Index = 435)]
        /* 0x04C0 */ public GcScanEffectData BaseBuildingErrorBelowWaterScanEffect;
        [NMS(Index = 431)]
        /* 0x0510 */ public GcScanEffectData BaseBuildingErrorCollisionScanEffect;
        [NMS(Index = 432)]
        /* 0x0560 */ public GcScanEffectData BaseBuildingErrorImpossibleScanEffect;
        [NMS(Index = 430)]
        /* 0x05B0 */ public GcScanEffectData BaseBuildingErrorInsideScanEffect;
        [NMS(Index = 433)]
        /* 0x0600 */ public GcScanEffectData BaseBuildingErrorUnaffordableScanEffect;
        [NMS(Index = 427)]
        /* 0x0650 */ public GcScanEffectData BaseBuildingGhostScanEffect;
        [NMS(Index = 424)]
        /* 0x06A0 */ public GcScanEffectData BaseBuildingPreviewSelectionScanEffect;
        [NMS(Index = 437)]
        /* 0x06F0 */ public GcScanEffectData BaseBuildingRemotePlayerSelectionScanEffect;
        [NMS(Index = 436)]
        /* 0x0740 */ public GcScanEffectData BaseBuildingRemotePlayerValidScanEffect;
        [NMS(Index = 425)]
        /* 0x0790 */ public GcScanEffectData BaseBuildingSelectionScanEffect;
        [NMS(Index = 428)]
        /* 0x07E0 */ public GcScanEffectData BaseBuildingSpawnStaticEffect;
        [NMS(Index = 423)]
        /* 0x0830 */ public GcScanEffectData BaseBuildingValidScanEffect;
        [NMS(Index = 429)]
        /* 0x0880 */ public GcScanEffectData BaseBuildingVisionScanEffect;
        [NMS(Index = 225)]
        /* 0x08D0 */ public GcScanEffectData BinocularScanEffect;
        [NMS(Index = 115)]
        /* 0x0920 */ public GcScanEffectData BinocularSelectedEffect;
        [NMS(Index = 422)]
        /* 0x0970 */ public GcScanEffectData BlankScanEffect;
        [NMS(Index = 416)]
        /* 0x09C0 */ public GcScanEffectData BuildingScanEffect;
        [NMS(Index = 419)]
        /* 0x0A10 */ public GcScanEffectData CreatureScanEffect;
        [NMS(Index = 239)]
        /* 0x0A60 */ public GcScanEffectData DeconstructEffect;
        [NMS(Index = 240)]
        /* 0x0AB0 */ public GcScanEffectData HitEffect;
        [NMS(Index = 241)]
        /* 0x0B00 */ public GcScanEffectData HitEffectCritical;
        [NMS(Index = 418)]
        /* 0x0B50 */ public GcScanEffectData HUDShipScanEffect;
        [NMS(Index = 420)]
        /* 0x0BA0 */ public GcScanEffectData ObjectsScanEffect;
        [NMS(Index = 415)]
        /* 0x0BF0 */ public GcScanEffectData PassiveScanEffect;
        [NMS(Index = 619)]
        /* 0x0C40 */ public GcScanEffectData ShipBuilderNullScanEffect;
        [NMS(Index = 618)]
        /* 0x0C90 */ public GcScanEffectData ShipBuilderScanEffect;
        [NMS(Index = 617)]
        /* 0x0CE0 */ public GcScanEffectData ShipSalvageScanEffect;
        [NMS(Index = 417)]
        /* 0x0D30 */ public GcScanEffectData TargetShipScanEffect;
        [NMS(Index = 421)]
        /* 0x0D80 */ public GcScanEffectData VRGhostScanEffect;
        [NMS(Index = 224)]
        /* 0x0DD0 */ public Colour BinocularScanTargetColour;
        [NMS(Index = 116)]
        /* 0x0DE0 */ public Colour BinocularSelectedColour;
        [NMS(Index = 117)]
        /* 0x0DF0 */ public Colour BinocularSelectedUnknownColour;
        [NMS(Index = 89)]
        /* 0x0E00 */ public Colour BulletTraceLineColour;
        [NMS(Index = 244)]
        /* 0x0E10 */ public Vector3f CommunicatorShipSpawnOffset;
        [NMS(Index = 478)]
        /* 0x0E20 */ public Colour HUDDamageSplatPainColour;
        [NMS(Index = 477)]
        /* 0x0E30 */ public Colour HUDDamageSplatShieldColour;
        [NMS(Index = 172)]
        /* 0x0E40 */ public Colour OverHeatBarColour;
        [NMS(Index = 171)]
        /* 0x0E50 */ public Colour OverHeatColour;
        [NMS(Index = 515)]
        /* 0x0E60 */ public Colour PainColour;
        [NMS(Index = 563)]
        /* 0x0E70 */ public Colour PlayerAmbientSpotLightColour;
        [NMS(Index = 197)]
        /* 0x0E80 */ public Colour RefinerColour1A;
        [NMS(Index = 198)]
        /* 0x0E90 */ public Colour RefinerColour1B;
        [NMS(Index = 199)]
        /* 0x0EA0 */ public Colour RefinerColour1C;
        [NMS(Index = 200)]
        /* 0x0EB0 */ public Colour RefinerColour1D;
        [NMS(Index = 461)]
        /* 0x0EC0 */ public Colour ScannerColour1;
        [NMS(Index = 462)]
        /* 0x0ED0 */ public Colour ScannerColour2;
        [NMS(Index = 561)]
        /* 0x0EE0 */ public Colour TorchColour;
        [NMS(Index = 0)]
        /* 0x0EF0 */ public GcScanToRevealComponentData CaveGraveRevealData;
        [NMS(Index = 103, Size = 0x5)]
        /* 0x0F40 */ public NMSString0x10[] SalvageTechList;
        [NMS(Index = 104, Size = 0x5)]
        /* 0x0F90 */ public NMSString0x10[] SalvageTechListMultiTool;
        [NMS(Index = 100, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x0FE0 */ public NMSString0x10[] SalvageRewardsDropship;
        [NMS(Index = 101, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x1020 */ public NMSString0x10[] SalvageRewardsFighter;
        [NMS(Index = 102, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x1060 */ public NMSString0x10[] SalvageRewardsScience;
        [NMS(Index = 99, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x10A0 */ public NMSString0x10[] SalvageRewardsShuttle;
        [NMS(Index = 632)]
        /* 0x10E0 */ public NMSString0x20A CommunicatorFireteamNexusExitDialog;
        [NMS(Index = 633)]
        /* 0x1100 */ public NMSString0x20A CommunicatorNexusExitAbandonWarningDialog;
        [NMS(Index = 401)]
        /* 0x1120 */ public NMSString0x10 BeaconScan;
        [NMS(Index = 390)]
        /* 0x1130 */ public NMSString0x10 BioShipTerrainResource;
        [NMS(Index = 27)]
        /* 0x1140 */ public NMSString0x10 BuildersWordReward;
        [NMS(Index = 256)]
        /* 0x1150 */ public List<GcScanEffectData> CommunicatorEffectTable;
        [NMS(Index = 405)]
        /* 0x1160 */ public NMSString0x10 DebugScanPlanet;
        [NMS(Index = 406)]
        /* 0x1170 */ public NMSString0x10 DebugScanSpace;
        [NMS(Index = 528)]
        /* 0x1180 */ public NMSString0x10 DefaultAnim;
        [NMS(Index = 404)]
        /* 0x1190 */ public NMSString0x10 DistressSignalScan;
        [NMS(Index = 68)]
        /* 0x11A0 */ public NMSString0x10 FreeShipSlotID;
        [NMS(Index = 67)]
        /* 0x11B0 */ public NMSString0x10 FreeSuitSlotID;
        [NMS(Index = 69)]
        /* 0x11C0 */ public NMSString0x10 FreeWeapSlotID;
        [NMS(Index = 180)]
        /* 0x11D0 */ public List<NMSString0x10> FreighterHyperdriveAccess;
        [NMS(Index = 179)]
        /* 0x11E0 */ public List<NMSString0x10> HyperdriveAccess;
        [NMS(Index = 126)]
        /* 0x11F0 */ public NMSString0x10 MissionSurveyWormID;
        [NMS(Index = 63)]
        /* 0x1200 */ public NMSString0x10 NexusRecipeCostType;
        [NMS(Index = 403)]
        /* 0x1210 */ public NMSString0x10 ObservatoryScan;
        [NMS(Index = 358)]
        /* 0x1220 */ public List<float> PirateEarlySpawnChances;
        [NMS(Index = 25)]
        /* 0x1230 */ public NMSString0x10 PirateMissionPrimaryReward;
        [NMS(Index = 26)]
        /* 0x1240 */ public NMSString0x10 PirateMissionSecondReward;
        [NMS(Index = 402)]
        /* 0x1250 */ public NMSString0x10 RadioTowerScan;
        [NMS(Index = 388)]
        /* 0x1260 */ public NMSString0x10 ResourceDirtSubstanceID;
        [NMS(Index = 105)]
        /* 0x1270 */ public List<NMSString0x10> SalvageProdsList;
        [NMS(Index = 106)]
        /* 0x1280 */ public List<NMSString0x10> SalvageSubstancesList;
        [NMS(Index = 389)]
        /* 0x1290 */ public NMSString0x10 SandwormTerrainResource;
        [NMS(Index = 407)]
        /* 0x12A0 */ public NMSString0x10 ShipScan;
        [NMS(Index = 398)]
        /* 0x12B0 */ public NMSString0x10 ToolScan;
        [NMS(Index = 399)]
        /* 0x12C0 */ public NMSString0x10 ToolScanHardMode;
        [NMS(Index = 408)]
        /* 0x12D0 */ public NMSString0x10 VisualScan;
        [NMS(Index = 400)]
        /* 0x12E0 */ public NMSString0x10 WaypointScan;
        [NMS(Index = 414)]
        /* 0x12F0 */ public List<GcZoomData> ZoomLevels;
        [NMS(Index = 592)]
        /* 0x1300 */ public ulong NPCWorkerInteractionCooldown;
        [NMS(Index = 647)]
        /* 0x1308 */ public TkModelResource WeaponSpawnAltObject;
        [NMS(Index = 646)]
        /* 0x138C */ public TkModelResource WeaponSpawnObject;
        [NMS(Index = 396)]
        /* 0x1410 */ public GcResourceCollectEffect AsteroidResourceCollect;
        [NMS(Index = 360)]
        /* 0x1444 */ public GcExperienceTimers FlybyTimers;
        [NMS(Index = 355)]
        /* 0x1464 */ public GcExperienceTimers FreighterTimers;
        [NMS(Index = 356)]
        /* 0x1484 */ public GcExperienceTimers PlanetPirateTimers;
        [NMS(Index = 362)]
        /* 0x14A4 */ public GcExperienceTimers PoliceTimers;
        [NMS(Index = 352)]
        /* 0x14C4 */ public GcExperienceTimers SentinelTimersLow;
        [NMS(Index = 353)]
        /* 0x14E4 */ public GcExperienceTimers SentinelTimersNormal;
        [NMS(Index = 361)]
        /* 0x1504 */ public GcExperienceTimers SpaceFlybyTimers;
        [NMS(Index = 357)]
        /* 0x1524 */ public GcExperienceTimers SpacePirateTimers;
        [NMS(Index = 644, Size = 0x7)]
        /* 0x1544 */ public int[] AlienShipEvolveCosts;
        [NMS(Index = 363, Size = 0x7, EnumType = typeof(GcProceduralTechnologyData.QualityEnum))]
        /* 0x1560 */ public int[] FreighterTechQualityWeightings;
        [NMS(Index = 526)]
        /* 0x157C */ public GcTracerData BulletTracer;
        [NMS(Index = 527)]
        /* 0x1594 */ public GcTracerData ShipTracer;
        [NMS(Index = 306, Size = 0x4, EnumType = typeof(GcPlayerConflictData.ConflictLevelEnum))]
        /* 0x15AC */ public float[] ChanceOfPirateFreighterBattleOnWarpToSystem;
        [NMS(Index = 28, Size = 0x3, EnumType = typeof(GcMissionDifficulty.MissionDifficultyEnum))]
        /* 0x15BC */ public float[] MissionSubstanceDifficultyMultipliers;
        [NMS(Index = 281, Size = 0x3)]
        /* 0x15C8 */ public int[] PirateInterestLevels;
        [NMS(Index = 282, Size = 0x3)]
        /* 0x15D4 */ public int[] PirateInterestLevelsSurvival;
        [NMS(Index = 286, Size = 0x3)]
        /* 0x15E0 */ public int[] PoliceInterestLevels;
        [NMS(Index = 287, Size = 0x3)]
        /* 0x15EC */ public int[] PoliceInterestLevelsSurvival;
        [NMS(Index = 649)]
        /* 0x15F8 */ public Vector2f FrigateFlybyTimer;
        [NMS(Index = 475)]
        /* 0x1600 */ public Vector2f HUDDamageSize;
        [NMS(Index = 476)]
        /* 0x1608 */ public Vector2f HUDDamageSplatSize;
        [NMS(Index = 606)]
        /* 0x1610 */ public GcPortalData Portal;
        [NMS(Index = 10)]
        /* 0x1618 */ public Vector2f SaveContextTransferShipCostScaleNanites;
        [NMS(Index = 9)]
        /* 0x1620 */ public Vector2f SaveContextTransferShipCostScaleUnits;
        [NMS(Index = 8)]
        /* 0x1628 */ public Vector2f SaveContextTransferWeaponCostScaleNanites;
        [NMS(Index = 7)]
        /* 0x1630 */ public Vector2f SaveContextTransferWeaponCostScaleUnits;
        [NMS(Index = 341)]
        /* 0x1638 */ public float AggressiveSentinelProbability;
        [NMS(Index = 342)]
        /* 0x163C */ public float AggressiveSentinelProbabilitySurvival;
        [NMS(Index = 594)]
        /* 0x1640 */ public float AirLockDoorRange;
        [NMS(Index = 88)]
        /* 0x1644 */ public float AlienPodThreshold1;
        [NMS(Index = 87)]
        /* 0x1648 */ public float AlienPodThreshold2;
        [NMS(Index = 231)]
        /* 0x164C */ public float AllRecipesKnownNanitesMax;
        [NMS(Index = 230)]
        /* 0x1650 */ public float AllRecipesKnownNanitesMin;
        [NMS(Index = 120)]
        /* 0x1654 */ public float AngleFromBaseComputerWhenTeleporting;
        [NMS(Index = 368)]
        /* 0x1658 */ public float AsteroidCarveRadius;
        [NMS(Index = 366)]
        /* 0x165C */ public float AsteroidHitForce;
        [NMS(Index = 376)]
        /* 0x1660 */ public int AsteroidResourceReducer;
        [NMS(Index = 206)]
        /* 0x1664 */ public int AsteroidScanMaxShown;
        [NMS(Index = 208)]
        /* 0x1668 */ public float AsteroidScanRange;
        [NMS(Index = 207)]
        /* 0x166C */ public float AsteroidScanTime;
        [NMS(Index = 367)]
        /* 0x1670 */ public float AsteroidTorqueForce;
        [NMS(Index = 662)]
        /* 0x1674 */ public float AtlasGunCurrencyConversion;
        [NMS(Index = 205)]
        /* 0x1678 */ public float AtmosphereEntryErrorTime;
        [NMS(Index = 202)]
        /* 0x167C */ public float AtmosphereEntryFadeTimeFactor;
        [NMS(Index = 203)]
        /* 0x1680 */ public float AtmosphereEntryOffset;
        [NMS(Index = 201)]
        /* 0x1684 */ public float AtmosphereEntryTime;
        [NMS(Index = 122)]
        /* 0x1688 */ public float AutoTranslateWordChance;
        [NMS(Index = 634)]
        /* 0x168C */ public float BackgroundSpaceEncounterCheckTimer;
        [NMS(Index = 524)]
        /* 0x1690 */ public float BarrelOffset;
        [NMS(Index = 591)]
        /* 0x1694 */ public float BaseBuildingHoverTimeToKnowPart;
        [NMS(Index = 438)]
        /* 0x1698 */ public float BaseBuildingRemotePlayerErrorAlphaScanEffect;
        [NMS(Index = 161)]
        /* 0x169C */ public float BaseLaserHeatTime;
        [NMS(Index = 394)]
        /* 0x16A0 */ public float BeaconInteractRange;
        [NMS(Index = 218)]
        /* 0x16A4 */ public float BinocCreatureScanTime;
        [NMS(Index = 216)]
        /* 0x16A8 */ public float BinocMinScanTime;
        [NMS(Index = 217)]
        /* 0x16AC */ public float BinocScanTime;
        [NMS(Index = 215)]
        /* 0x16B0 */ public float BinocTimeBeforeScan;
        [NMS(Index = 223)]
        /* 0x16B4 */ public float BinocularScanTargetFadeTime;
        [NMS(Index = 214)]
        /* 0x16B8 */ public float BinocularScanTargetHeightRange;
        [NMS(Index = 220)]
        /* 0x16BC */ public float BinocularScanTargetInitialFadeTime;
        [NMS(Index = 222)]
        /* 0x16C0 */ public float BinocularScanTargetLineWidth;
        [NMS(Index = 213)]
        /* 0x16C4 */ public float BinocularScanTargetMinHeight;
        [NMS(Index = 221)]
        /* 0x16C8 */ public float BinocularScanTargetScaler;
        [NMS(Index = 584)]
        /* 0x16CC */ public float BlackHoleJumpVoxelDist;
        [NMS(Index = 585)]
        /* 0x16D0 */ public float BlackHoleJumpVoxelVariation;
        [NMS(Index = 580)]
        /* 0x16D4 */ public float BonusChildTypeElementsAdd;
        [NMS(Index = 581)]
        /* 0x16D8 */ public float BonusChildTypeElementsMultiply;
        [NMS(Index = 578)]
        /* 0x16DC */ public float BonusSameTypeElementsAdd;
        [NMS(Index = 579)]
        /* 0x16E0 */ public float BonusSameTypeElementsMultiply;
        [NMS(Index = 371)]
        /* 0x16E4 */ public float BuildingBeamDistance;
        [NMS(Index = 233)]
        /* 0x16E8 */ public float BuildingPlayerBaseIconOffset;
        [NMS(Index = 90)]
        /* 0x16EC */ public float BulletTraceLineWidth;
        [NMS(Index = 35)]
        /* 0x16F0 */ public float CargoShieldStrength;
        [NMS(Index = 118)]
        /* 0x16F4 */ public float CockpitScale;
        [NMS(Index = 56)]
        /* 0x16F8 */ public float CombatLevelBaseValueBoltcaster;
        [NMS(Index = 60)]
        /* 0x16FC */ public float CombatLevelBaseValueCannon;
        [NMS(Index = 61)]
        /* 0x1700 */ public float CombatLevelBaseValueGrenade;
        [NMS(Index = 58)]
        /* 0x1704 */ public float CombatLevelBaseValueRailgun;
        [NMS(Index = 57)]
        /* 0x1708 */ public float CombatLevelBaseValueShotgun;
        [NMS(Index = 59)]
        /* 0x170C */ public float CombatLevelBaseValueSMG;
        [NMS(Index = 55)]
        /* 0x1710 */ public float CombatLevelBestWeaponBias;
        [NMS(Index = 62)]
        /* 0x1714 */ public float CombatLevelSClassValue;
        [NMS(Index = 532)]
        /* 0x1718 */ public float CombatSpeedReadoutMultiplier;
        [NMS(Index = 374)]
        /* 0x171C */ public int CommonProductEffectiveness;
        [NMS(Index = 251)]
        /* 0x1720 */ public float CommunicatorCargoScanDroneAtOffsetFallback;
        [NMS(Index = 252)]
        /* 0x1724 */ public float CommunicatorCargoScanDronePitch;
        [NMS(Index = 253)]
        /* 0x1728 */ public float CommunicatorCargoScanDroneRoll;
        [NMS(Index = 247)]
        /* 0x172C */ public float CommunicatorCargoScanDroneScale;
        [NMS(Index = 248)]
        /* 0x1730 */ public float CommunicatorCargoScanDroneScaleFallback;
        [NMS(Index = 249)]
        /* 0x1734 */ public float CommunicatorCargoScanDroneUpOffset;
        [NMS(Index = 250)]
        /* 0x1738 */ public float CommunicatorCargoScanDroneUpOffsetFallback;
        [NMS(Index = 254)]
        /* 0x173C */ public float CommunicatorCargoScanDroneYaw;
        [NMS(Index = 255)]
        /* 0x1740 */ public float CommunicatorFadeTime;
        [NMS(Index = 243)]
        /* 0x1744 */ public float CommunicatorSpawnHeightOffset;
        [NMS(Index = 242)]
        /* 0x1748 */ public float CommunicatorSpawnOffset;
        [NMS(Index = 246)]
        /* 0x174C */ public float CommunicatorSpawnRotation;
        [NMS(Index = 245)]
        /* 0x1750 */ public float CommunicatorSpawnScale;
        [NMS(Index = 610)]
        /* 0x1754 */ public float CorruptSentinelProbability;
        [NMS(Index = 330)]
        /* 0x1758 */ public float CreatureMinScanTime;
        [NMS(Index = 329)]
        /* 0x175C */ public float CreatureScanAngle;
        [NMS(Index = 328)]
        /* 0x1760 */ public float CreatureScanStickyDecay;
        [NMS(Index = 153)]
        /* 0x1764 */ public int CreaturesToBaitForTutorial;
        [NMS(Index = 154)]
        /* 0x1768 */ public int CreaturesToFeedForTutorial;
        [NMS(Index = 335)]
        /* 0x176C */ public int CritDamage;
        [NMS(Index = 234)]
        /* 0x1770 */ public float CriticalHitMultiplier;
        [NMS(Index = 336)]
        /* 0x1774 */ public float CritScale;
        [NMS(Index = 616)]
        /* 0x1778 */ public float DeadPlanetGravityFactor;
        [NMS(Index = 369)]
        /* 0x177C */ public int DeathMoneyPenalty;
        [NMS(Index = 441)]
        /* 0x1780 */ public GcBuildingClassification DebugScanForceBuildingType;
        [NMS(Index = 643)]
        /* 0x1784 */ public float DerelictPulseEncounterAtmosphericEffectChance;
        [NMS(Index = 268)]
        /* 0x1788 */ public float DestroyEffectHeight;
        [NMS(Index = 269)]
        /* 0x178C */ public float DestroyEffectMaxScale;
        [NMS(Index = 121)]
        /* 0x1790 */ public float DistanceFromBaseComputerWhenTeleporting;
        [NMS(Index = 393)]
        /* 0x1794 */ public float DockNodeBuyRadius;
        [NMS(Index = 276)]
        /* 0x1798 */ public int EarlyPiratesToBeKilled;
        [NMS(Index = 338)]
        /* 0x179C */ public float EmergencyBuildingScanEventDistance;
        [NMS(Index = 339)]
        /* 0x17A0 */ public float EmergencyBuildingScanEventTime;
        [NMS(Index = 270)]
        /* 0x17A4 */ public float EventTargetSpeed;
        [NMS(Index = 466)]
        /* 0x17A8 */ public float ExcitingNearRange;
        [NMS(Index = 464)]
        /* 0x17AC */ public float ExcitingViewAngle;
        [NMS(Index = 465)]
        /* 0x17B0 */ public float ExcitingViewRange;
        [NMS(Index = 572)]
        /* 0x17B4 */ public float ExplosionForce;
        [NMS(Index = 573)]
        /* 0x17B8 */ public float ExplosionForceMaxForceRadius;
        [NMS(Index = 571)]
        /* 0x17BC */ public float ExplosionRadiusMultiplier;
        [NMS(Index = 607)]
        /* 0x17C0 */ public int FourthRaceSpawnPercentage;
        [NMS(Index = 293)]
        /* 0x17C4 */ public float FreighterBattleRadius;
        [NMS(Index = 305)]
        /* 0x17C8 */ public float FreighterCargoPodHealthFraction;
        [NMS(Index = 304)]
        /* 0x17CC */ public float FreighterFuelRodHealthFraction;
        [NMS(Index = 354)]
        /* 0x17D0 */ public int FreighterStartPecent;
        [NMS(Index = 583)]
        /* 0x17D4 */ public float GoalGapVoxelDist;
        [NMS(Index = 96)]
        /* 0x17D8 */ public int GPSRandomChangeTimeBuilderCorruption;
        [NMS(Index = 94)]
        /* 0x17DC */ public int GPSRandomChangeTimeMid;
        [NMS(Index = 95)]
        /* 0x17E0 */ public int GPSRandomChangeTimeNarrow;
        [NMS(Index = 93)]
        /* 0x17E4 */ public int GPSRandomChangeTimeWide;
        [NMS(Index = 236)]
        /* 0x17E8 */ public float GrabPlayerCooldownTime;
        [NMS(Index = 522)]
        /* 0x17EC */ public float GunDownAngle;
        [NMS(Index = 519)]
        /* 0x17F0 */ public float GunOffsetAggressiveX;
        [NMS(Index = 520)]
        /* 0x17F4 */ public float GunOffsetAggressiveY;
        [NMS(Index = 521)]
        /* 0x17F8 */ public float GunOffsetAggressiveZ;
        [NMS(Index = 516)]
        /* 0x17FC */ public float GunOffsetX;
        [NMS(Index = 517)]
        /* 0x1800 */ public float GunOffsetY;
        [NMS(Index = 518)]
        /* 0x1804 */ public float GunOffsetZ;
        [NMS(Index = 523)]
        /* 0x1808 */ public float GunUpAngle;
        [NMS(Index = 275)]
        /* 0x180C */ public int HardModeTechDamageHighPercent;
        [NMS(Index = 273)]
        /* 0x1810 */ public int HardModeTechDamageMidNum;
        [NMS(Index = 274)]
        /* 0x1814 */ public int HardModeTechDamageMidPercent;
        [NMS(Index = 162)]
        /* 0x1818 */ public float HeatAlertTime;
        [NMS(Index = 163)]
        /* 0x181C */ public float HeatDamageBoost;
        [NMS(Index = 167)]
        /* 0x1820 */ public float HeatMaxPowerPoint;
        [NMS(Index = 164)]
        /* 0x1824 */ public float HeatWidthBoost;
        [NMS(Index = 165)]
        /* 0x1828 */ public float HeatWidthBoostAlt;
        [NMS(Index = 235)]
        /* 0x182C */ public float HitEffectMinTime;
        [NMS(Index = 525)]
        /* 0x1830 */ public float HitOffset;
        [NMS(Index = 183)]
        /* 0x1834 */ public float HmdInteractionRangeMinDistance;
        [NMS(Index = 182)]
        /* 0x1838 */ public float HmdInteractionRangeMinRange;
        [NMS(Index = 184)]
        /* 0x183C */ public float HmdInteractionRangeMultiplier;
        [NMS(Index = 290)]
        /* 0x1840 */ public float HoursBetweenBattles;
        [NMS(Index = 588)]
        /* 0x1844 */ public float HoursBetweenMiniStation;
        [NMS(Index = 411)]
        /* 0x1848 */ public float HoverTimeToScan;
        [NMS(Index = 412)]
        /* 0x184C */ public float HoverTimeToScanCreatures;
        [NMS(Index = 413)]
        /* 0x1850 */ public int HoverVisiblePointsNeeded;
        [NMS(Index = 474)]
        /* 0x1854 */ public float HUDArrowPrimaryScaler;
        [NMS(Index = 479)]
        /* 0x1858 */ public float HUDDamageOffset;
        [NMS(Index = 481)]
        /* 0x185C */ public float HUDDamageRadius;
        [NMS(Index = 480)]
        /* 0x1860 */ public float HUDDamageScaler;
        [NMS(Index = 484)]
        /* 0x1864 */ public float HUDLabelAngle;
        [NMS(Index = 485)]
        /* 0x1868 */ public float HUDLabelAngleOffset;
        [NMS(Index = 486)]
        /* 0x186C */ public float HUDLabelOffsetX;
        [NMS(Index = 487)]
        /* 0x1870 */ public float HUDLabelOffsetY;
        [NMS(Index = 488)]
        /* 0x1874 */ public float HUDLabelOffsetZ;
        [NMS(Index = 489)]
        /* 0x1878 */ public float HUDLabelScale;
        [NMS(Index = 483)]
        /* 0x187C */ public float HUDLabelTime;
        [NMS(Index = 473)]
        /* 0x1880 */ public float HUDLockOnAudioTime;
        [NMS(Index = 509)]
        /* 0x1884 */ public float HUDReticuleMoveAim;
        [NMS(Index = 508)]
        /* 0x1888 */ public float HUDReticuleMoveBack;
        [NMS(Index = 502)]
        /* 0x188C */ public float HUDScaleAdd;
        [NMS(Index = 507)]
        /* 0x1890 */ public float HUDScaleFarTarget;
        [NMS(Index = 506)]
        /* 0x1894 */ public float HUDScaleMax;
        [NMS(Index = 504)]
        /* 0x1898 */ public float HUDScaleMin;
        [NMS(Index = 505)]
        /* 0x189C */ public float HUDScaleMinAim;
        [NMS(Index = 503)]
        /* 0x18A0 */ public float HUDScaleRadius;
        [NMS(Index = 463)]
        /* 0x18A4 */ public float HUDStoreFlashTime;
        [NMS(Index = 54)]
        /* 0x18A8 */ public float IllegalTechProductTradingMod;
        [NMS(Index = 51)]
        /* 0x18AC */ public float InfestedPlanetDeepSpaceFlybyMultiplier;
        [NMS(Index = 70)]
        /* 0x18B0 */ public float InitialLocationProtectionRadiusMultiplier;
        [NMS(Index = 262)]
        /* 0x18B4 */ public float InteractionAttractTime;
        [NMS(Index = 582)]
        /* 0x18B8 */ public float InteractionComponentUpdateDistance;
        [NMS(Index = 263)]
        /* 0x18BC */ public float InteractionDescriptionTextTime;
        [NMS(Index = 261)]
        /* 0x18C0 */ public float InteractionMessageModuleDisplayTime;
        [NMS(Index = 258)]
        /* 0x18C4 */ public float InteractionMinTimeBeforeHighlightedOptionSelection;
        [NMS(Index = 259)]
        /* 0x18C8 */ public float InteractionMinTimeBetweenStickOptionHighlights;
        [NMS(Index = 264)]
        /* 0x18CC */ public float InteractionMinTimeForResponseText;
        [NMS(Index = 266)]
        /* 0x18D0 */ public GcInteractionType InteractionOverrideFrom;
        [NMS(Index = 267)]
        /* 0x18D4 */ public GcInteractionType InteractionOverrideTo;
        [NMS(Index = 569)]
        /* 0x18D8 */ public float InteractionPickupAngle;
        [NMS(Index = 570)]
        /* 0x18DC */ public float InteractionPickupRadius;
        [NMS(Index = 260)]
        /* 0x18E0 */ public float InteractionStickOptionStrength;
        [NMS(Index = 539)]
        /* 0x18E4 */ public float InteractionTorchFoV;
        [NMS(Index = 540)]
        /* 0x18E8 */ public float InteractionTorchStrength;
        [NMS(Index = 586)]
        /* 0x18EC */ public float JumpToCenterFuelCost;
        [NMS(Index = 575)]
        /* 0x18F0 */ public float LaserExplosionForce;
        [NMS(Index = 576)]
        /* 0x18F4 */ public float LaserExplosionForceMaxForceRadius;
        [NMS(Index = 574)]
        /* 0x18F8 */ public float LaserExplosionForceRadius;
        [NMS(Index = 11)]
        /* 0x18FC */ public int LaserRechargeHintThresholdEarly;
        [NMS(Index = 12)]
        /* 0x1900 */ public int LaserRechargeHintThresholdLate;
        [NMS(Index = 593)]
        /* 0x1904 */ public float LightStrength;
        [NMS(Index = 468)]
        /* 0x1908 */ public float LineWidth;
        [NMS(Index = 469)]
        /* 0x190C */ public float LockOffFactor;
        [NMS(Index = 343)]
        /* 0x1910 */ public float LowSentinelProbability;
        [NMS(Index = 344)]
        /* 0x1914 */ public float LowSentinelProbabilitySurvival;
        [NMS(Index = 500)]
        /* 0x1918 */ public float MapFOV;
        [NMS(Index = 497)]
        /* 0x191C */ public float MapHeight;
        [NMS(Index = 498)]
        /* 0x1920 */ public float MapOffset;
        [NMS(Index = 501)]
        /* 0x1924 */ public float MapRadius;
        [NMS(Index = 499)]
        /* 0x1928 */ public float MapTargetOffset;
        [NMS(Index = 73)]
        /* 0x192C */ public int MaxActiveWeatherHazardGifts;
        [NMS(Index = 119)]
        /* 0x1930 */ public float MaxDistanceForLadderTeleport;
        [NMS(Index = 350)]
        /* 0x1934 */ public int MaxDronesAggressive;
        [NMS(Index = 351)]
        /* 0x1938 */ public int MaxDronesAggressiveSurvival;
        [NMS(Index = 346)]
        /* 0x193C */ public int MaxDronesLow;
        [NMS(Index = 347)]
        /* 0x1940 */ public int MaxDronesLowSurvival;
        [NMS(Index = 348)]
        /* 0x1944 */ public int MaxDronesNormal;
        [NMS(Index = 349)]
        /* 0x1948 */ public int MaxDronesNormalSurvival;
        [NMS(Index = 77)]
        /* 0x194C */ public float MaxMeteorSurfaceAngle;
        [NMS(Index = 257)]
        /* 0x1950 */ public int MaxNumMissionsFromMissionGiver;
        [NMS(Index = 193)]
        /* 0x1954 */ public int MaxNumSameGroupTech;
        [NMS(Index = 232)]
        /* 0x1958 */ public float MaxPossibleShipDamagePotential;
        [NMS(Index = 370)]
        /* 0x195C */ public int MaxResourceCrystalBlobSize;
        [NMS(Index = 615)]
        /* 0x1960 */ public float MaxRespawnOnGroundHeight;
        [NMS(Index = 491)]
        /* 0x1964 */ public float MaxSpawnTime;
        [NMS(Index = 459)]
        /* 0x1968 */ public float MaxStandingTechDiscount;
        [NMS(Index = 108)]
        /* 0x196C */ public int MaxTorpedoesInFlight;
        [NMS(Index = 13)]
        /* 0x1970 */ public int MeleeHintThresholdEarly;
        [NMS(Index = 14)]
        /* 0x1974 */ public int MeleeHintThresholdLate;
        [NMS(Index = 322)]
        /* 0x1978 */ public float MissileApproachTime;
        [NMS(Index = 316)]
        /* 0x197C */ public float MissileBrakeForceMax;
        [NMS(Index = 315)]
        /* 0x1980 */ public float MissileBrakeForceMin;
        [NMS(Index = 318)]
        /* 0x1984 */ public float MissileBrakeTime;
        [NMS(Index = 314)]
        /* 0x1988 */ public float MissileForceMax;
        [NMS(Index = 313)]
        /* 0x198C */ public float MissileForceMin;
        [NMS(Index = 319)]
        /* 0x1990 */ public float MissileHitRadius;
        [NMS(Index = 308)]
        /* 0x1994 */ public float MissileLockTime;
        [NMS(Index = 312)]
        /* 0x1998 */ public float MissileMaxSpeed;
        [NMS(Index = 307)]
        /* 0x199C */ public float MissileMaxTurnAngle;
        [NMS(Index = 321)]
        /* 0x19A0 */ public float MissileMinCircleTime;
        [NMS(Index = 320)]
        /* 0x19A4 */ public float MissileOffset;
        [NMS(Index = 309)]
        /* 0x19A8 */ public float MissileReloadTime;
        [NMS(Index = 311)]
        /* 0x19AC */ public float MissileRotateMax;
        [NMS(Index = 310)]
        /* 0x19B0 */ public float MissileRotateMin;
        [NMS(Index = 323)]
        /* 0x19B4 */ public float MissileRotateSpeed;
        [NMS(Index = 317)]
        /* 0x19B8 */ public float MissileThreatTime;
        [NMS(Index = 229)]
        /* 0x19BC */ public float MissionEventAllowResetDistance;
        [NMS(Index = 136)]
        /* 0x19C0 */ public float MissionSurveyAutoScanDistance;
        [NMS(Index = 137)]
        /* 0x19C4 */ public float MissionSurveyAutoScanFlattenRadiusMul;
        [NMS(Index = 132)]
        /* 0x19C8 */ public float MissionSurveyBeginScanPercentageEvent;
        [NMS(Index = 131)]
        /* 0x19CC */ public float MissionSurveyBeginScanPercentageScannable;
        [NMS(Index = 143)]
        /* 0x19D0 */ public float MissionSurveyInShipArrivedDistance;
        [NMS(Index = 127)]
        /* 0x19D4 */ public float MissionSurveyMarkerAutoHideTime;
        [NMS(Index = 141)]
        /* 0x19D8 */ public float MissionSurveyMaxAngleOffset;
        [NMS(Index = 124)]
        /* 0x19DC */ public float MissionSurveyMaxGuidanceDistance;
        [NMS(Index = 125)]
        /* 0x19E0 */ public float MissionSurveyMaxGuidanceDistanceWorms;
        [NMS(Index = 129)]
        /* 0x19E4 */ public float MissionSurveyMaxScanAngle;
        [NMS(Index = 130)]
        /* 0x19E8 */ public float MissionSurveyMaxScanAngleScannableComp;
        [NMS(Index = 142)]
        /* 0x19EC */ public float MissionSurveyMaxSignalConeAngle;
        [NMS(Index = 135)]
        /* 0x19F0 */ public float MissionSurveyRevealWithoutScanDistance;
        [NMS(Index = 128)]
        /* 0x19F4 */ public float MissionSurveyScanRangeMultiplier;
        [NMS(Index = 133)]
        /* 0x19F8 */ public float MissionSurveyScanSpeed;
        [NMS(Index = 134)]
        /* 0x19FC */ public float MissionSurveyScanSpeedScannableComp;
        [NMS(Index = 139)]
        /* 0x1A00 */ public float MissionSurveySonarMaxPulseSpeed;
        [NMS(Index = 138)]
        /* 0x1A04 */ public float MissionSurveySonarMinPulseSpeed;
        [NMS(Index = 140)]
        /* 0x1A08 */ public float MissionSurveySonarPulseSpeedBandCount;
        [NMS(Index = 510)]
        /* 0x1A0C */ public float MouseSensitivity;
        [NMS(Index = 511)]
        /* 0x1A10 */ public float MouseSensitivityShip;
        [NMS(Index = 512)]
        /* 0x1A14 */ public float MouseSensitivityVehicle;
        [NMS(Index = 113)]
        /* 0x1A18 */ public float MultidimensionalFadeTime;
        [NMS(Index = 332)]
        /* 0x1A1C */ public float NewDiscoveryDisplayTime;
        [NMS(Index = 64)]
        /* 0x1A20 */ public int NexusRecipeCostNaniteMultiplier;
        [NMS(Index = 345)]
        /* 0x1A24 */ public float NonAggressiveLushSurvivalProbabability;
        [NMS(Index = 608)]
        /* 0x1A28 */ public int NonDominantRaceSpawnPercentage;
        [NMS(Index = 609)]
        /* 0x1A2C */ public int NonDominantRaceSpawnPercentagePirate;
        [NMS(Index = 460)]
        /* 0x1A30 */ public float NonNaturalCostMul;
        [NMS(Index = 160)]
        /* 0x1A34 */ public float NormalModeHeatBonus;
        [NMS(Index = 5)]
        /* 0x1A38 */ public float NPCNavNodeSearchUpDistScaling;
        [NMS(Index = 23)]
        /* 0x1A3C */ public float NPCWaitWhenRevealedTime;
        [NMS(Index = 337)]
        /* 0x1A40 */ public int NumMissionsPerSolarSystem;
        [NMS(Index = 470)]
        /* 0x1A44 */ public float OffscreenFadeDistance;
        [NMS(Index = 471)]
        /* 0x1A48 */ public float OffscreenMinDot;
        [NMS(Index = 168)]
        /* 0x1A4C */ public float OverheatDecay;
        [NMS(Index = 166)]
        /* 0x1A50 */ public float OverheatGenerosity;
        [NMS(Index = 513)]
        /* 0x1A54 */ public float PainTime;
        [NMS(Index = 71)]
        /* 0x1A58 */ public float PartyPlanetSearchDistance;
        [NMS(Index = 651)]
        /* 0x1A5C */ public int PersonalInventoryMinHeightMax;
        [NMS(Index = 650)]
        /* 0x1A60 */ public int PersonalInventoryMinWidthMax;
        [NMS(Index = 653)]
        /* 0x1A64 */ public int PersonalTechInventoryMinHeightMax;
        [NMS(Index = 652)]
        /* 0x1A68 */ public int PersonalTechInventoryMinWidthMax;
        [NMS(Index = 359)]
        /* 0x1A6C */ public float PirateEarlySpawnTime;
        [NMS(Index = 109)]
        /* 0x1A70 */ public float PirateFreighterBattleNoTargetLeaderTime;
        [NMS(Index = 297)]
        /* 0x1A74 */ public float PirateFreighterBeginFleeHealthFraction;
        [NMS(Index = 294)]
        /* 0x1A78 */ public int PirateFreighterFrigateCountForReinforce;
        [NMS(Index = 300)]
        /* 0x1A7C */ public float PirateFreighterRewardDelayTime;
        [NMS(Index = 302)]
        /* 0x1A80 */ public float PirateFreighterRewardDelayTimeEscaped;
        [NMS(Index = 301)]
        /* 0x1A84 */ public float PirateFreighterRewardMessageDelayTime;
        [NMS(Index = 303)]
        /* 0x1A88 */ public float PirateFreighterRewardMessageDelayTimeEscaped;
        [NMS(Index = 296)]
        /* 0x1A8C */ public float PirateFreighterWarpChargeTime;
        [NMS(Index = 295)]
        /* 0x1A90 */ public float PirateFreighterWarpChargeTimeToAddPerBrokenEngine;
        [NMS(Index = 41)]
        /* 0x1A94 */ public float PirateGroundAccelerator;
        [NMS(Index = 42)]
        /* 0x1A98 */ public float PirateGroundInventoryAccelerator;
        [NMS(Index = 279)]
        /* 0x1A9C */ public float PirateInterestDistance;
        [NMS(Index = 280)]
        /* 0x1AA0 */ public float PirateInterestDistanceMPMission;
        [NMS(Index = 278)]
        /* 0x1AA4 */ public int PirateInterestOverride;
        [NMS(Index = 40)]
        /* 0x1AA8 */ public float PirateRaidAccelerator;
        [NMS(Index = 277)]
        /* 0x1AAC */ public int PlanetPirateFlybyMaxRepeatCounter;
        [NMS(Index = 562)]
        /* 0x1AB0 */ public float PlayerAmbientSpotLightIntensity;
        [NMS(Index = 564)]
        /* 0x1AB4 */ public float PlayerAmbientSpotLightOffsetY;
        [NMS(Index = 565)]
        /* 0x1AB8 */ public float PlayerAmbientSpotLightOffsetZ;
        [NMS(Index = 48)]
        /* 0x1ABC */ public float PoliceAcceleratorNoCargoNormal;
        [NMS(Index = 49)]
        /* 0x1AC0 */ public float PoliceAcceleratorNoCargoSkipScanOdds;
        [NMS(Index = 47)]
        /* 0x1AC4 */ public float PoliceAcceleratorNoCargoWealthy;
        [NMS(Index = 44)]
        /* 0x1AC8 */ public float PoliceAcceleratorPulseExtra;
        [NMS(Index = 45)]
        /* 0x1ACC */ public int PoliceAcceleratorSmugglingItemsMax;
        [NMS(Index = 46)]
        /* 0x1AD0 */ public float PoliceAcceleratorSmugglingMulMax;
        [NMS(Index = 43)]
        /* 0x1AD4 */ public float PoliceAcceleratorStationLockOn;
        [NMS(Index = 284)]
        /* 0x1AD8 */ public float PoliceInterestDistance;
        [NMS(Index = 285)]
        /* 0x1ADC */ public float PoliceInterestDistanceMPMission;
        [NMS(Index = 283)]
        /* 0x1AE0 */ public int PoliceInterestOverride;
        [NMS(Index = 602)]
        /* 0x1AE4 */ public int ProductItemStockDecayTime;
        [NMS(Index = 603)]
        /* 0x1AE8 */ public int ProductItemStockReplenishTime;
        [NMS(Index = 340)]
        /* 0x1AEC */ public float ProjectileLightIntensity;
        [NMS(Index = 467)]
        /* 0x1AF0 */ public float ProjectileSpeedBoost;
        [NMS(Index = 636)]
        /* 0x1AF4 */ public float PulseEncounterChance;
        [NMS(Index = 640)]
        /* 0x1AF8 */ public float PulseEncounterChanceBlue;
        [NMS(Index = 639)]
        /* 0x1AFC */ public float PulseEncounterChanceGreen;
        [NMS(Index = 638)]
        /* 0x1B00 */ public float PulseEncounterChanceRed;
        [NMS(Index = 637)]
        /* 0x1B04 */ public float PulseEncounterChanceStandard;
        [NMS(Index = 635)]
        /* 0x1B08 */ public float PulseEncounterCheckTimer;
        [NMS(Index = 641)]
        /* 0x1B0C */ public float PulseEncounterStopPower;
        [NMS(Index = 642)]
        /* 0x1B10 */ public float PulseEncounterStopSpeed;
        [NMS(Index = 375)]
        /* 0x1B14 */ public int RareProductEffectiveness;
        [NMS(Index = 373)]
        /* 0x1B18 */ public int RareSubstanceEffectiveness;
        [NMS(Index = 175)]
        /* 0x1B1C */ public int RefinerProductsMadeInTime;
        [NMS(Index = 177)]
        /* 0x1B20 */ public int RefinerProductsMadeInTimeSurvival;
        [NMS(Index = 176)]
        /* 0x1B24 */ public int RefinerSubsMadeInTime;
        [NMS(Index = 178)]
        /* 0x1B28 */ public int RefinerSubsMadeInTimeSurvival;
        [NMS(Index = 384)]
        /* 0x1B2C */ public int ResourceCommonMaxAmount;
        [NMS(Index = 383)]
        /* 0x1B30 */ public int ResourceCommonMinAmount;
        [NMS(Index = 382)]
        /* 0x1B34 */ public int ResourceCommonReducer;
        [NMS(Index = 387)]
        /* 0x1B38 */ public int ResourceDirtMaxAmount;
        [NMS(Index = 386)]
        /* 0x1B3C */ public int ResourceDirtMinAmount;
        [NMS(Index = 385)]
        /* 0x1B40 */ public int ResourceDirtReducer;
        [NMS(Index = 381)]
        /* 0x1B44 */ public int ResourceMaxAmount;
        [NMS(Index = 380)]
        /* 0x1B48 */ public int ResourceMinAmount;
        [NMS(Index = 495)]
        /* 0x1B4C */ public int ResourceParticleMaxNum;
        [NMS(Index = 496)]
        /* 0x1B50 */ public int ResourceParticleMinNum;
        [NMS(Index = 493)]
        /* 0x1B54 */ public float ResourceParticleSpeed;
        [NMS(Index = 494)]
        /* 0x1B58 */ public float ResourceParticleSpread;
        [NMS(Index = 379)]
        /* 0x1B5C */ public int ResourceReducer;
        [NMS(Index = 33)]
        /* 0x1B60 */ public int RocketLockerFuelUse;
        [NMS(Index = 626)]
        /* 0x1B64 */ public float SalvageShipExplodeShipDistance;
        [NMS(Index = 622)]
        /* 0x1B68 */ public float SalvageShipExplodeSpeed;
        [NMS(Index = 621)]
        /* 0x1B6C */ public float SalvageShipHeightOffset;
        [NMS(Index = 627)]
        /* 0x1B70 */ public float SalvageShipOneRevolutionTime;
        [NMS(Index = 620)]
        /* 0x1B74 */ public float SalvageShipPitch;
        [NMS(Index = 625)]
        /* 0x1B78 */ public float SalvageShipShowShipDistance;
        [NMS(Index = 623)]
        /* 0x1B7C */ public float SalvageShipShowShipSpeed;
        [NMS(Index = 624)]
        /* 0x1B80 */ public float SalvageShipShowShipSpeedSwitching;
        [NMS(Index = 98)]
        /* 0x1B84 */ public int SalvageSubstanceValueThreshold;
        [NMS(Index = 97)]
        /* 0x1B88 */ public float SalvageValueAsProds;
        [NMS(Index = 629)]
        /* 0x1B8C */ public float SalvageWeaponHeightOffset;
        [NMS(Index = 631)]
        /* 0x1B90 */ public float SalvageWeaponMaxSize;
        [NMS(Index = 628)]
        /* 0x1B94 */ public float SalvageWeaponPitch;
        [NMS(Index = 630)]
        /* 0x1B98 */ public float SalvageWeaponScale;
        [NMS(Index = 331)]
        /* 0x1B9C */ public float ScanAngle;
        [NMS(Index = 397)]
        /* 0x1BA0 */ public float ScanAngleCutoff;
        [NMS(Index = 227)]
        /* 0x1BA4 */ public float ScannableComponentMarkerOffset;
        [NMS(Index = 228)]
        /* 0x1BA8 */ public float ScannableComponentPlaceMarkerOffset;
        [NMS(Index = 448)]
        /* 0x1BAC */ public float ScannerAnalyzeFXRate;
        [NMS(Index = 226)]
        /* 0x1BB0 */ public float ScannerIconsClumpRadius;
        [NMS(Index = 445)]
        /* 0x1BB4 */ public float ScannerMarkerFadeTime;
        [NMS(Index = 447)]
        /* 0x1BB8 */ public float ScannerPhysicsProbeAABBSize;
        [NMS(Index = 446)]
        /* 0x1BBC */ public float ScannerSmallMarkerFadeTime;
        [NMS(Index = 449)]
        /* 0x1BC0 */ public float ScannerSubstanceTimePerTrigger;
        [NMS(Index = 450)]
        /* 0x1BC4 */ public float ScannerTuningA;
        [NMS(Index = 451)]
        /* 0x1BC8 */ public float ScannerTuningB;
        [NMS(Index = 452)]
        /* 0x1BCC */ public float ScannerTuningC;
        [NMS(Index = 453)]
        /* 0x1BD0 */ public float ScannerTuningD;
        [NMS(Index = 454)]
        /* 0x1BD4 */ public float ScannerTuningResourceOffset1;
        [NMS(Index = 455)]
        /* 0x1BD8 */ public float ScannerTuningResourceOffset2;
        [NMS(Index = 456)]
        /* 0x1BDC */ public float ScannerTuningSmoothStepAmount;
        [NMS(Index = 457)]
        /* 0x1BE0 */ public float ScannerTuningTrailingEdge;
        [NMS(Index = 324)]
        /* 0x1BE4 */ public float ScanStartTimeDelayMinDist;
        [NMS(Index = 325)]
        /* 0x1BE8 */ public float ScanStartTimeDelayRange;
        [NMS(Index = 326)]
        /* 0x1BEC */ public float ScanStartTimeDistanceDelayTime;
        [NMS(Index = 327)]
        /* 0x1BF0 */ public float ScanStickyDecay;
        [NMS(Index = 20)]
        /* 0x1BF4 */ public float ScanToRevealDelayOverride;
        [NMS(Index = 24)]
        /* 0x1BF8 */ public float ScanToRevealVFXBaseScalingSize;
        [NMS(Index = 614)]
        /* 0x1BFC */ public float ScrapDroneProbability;
        [NMS(Index = 181)]
        /* 0x1C00 */ public float SeasonalMessageModuleAttractDistanceMul;
        [NMS(Index = 364)]
        /* 0x1C04 */ public int SentinelsHigh;
        [NMS(Index = 365)]
        /* 0x1C08 */ public int SentinelsLow;
        [NMS(Index = 2)]
        /* 0x1C0C */ public float ShipBuilderInteractionBuildEffectTime;
        [NMS(Index = 3)]
        /* 0x1C10 */ public float ShipBuilderInteractionDissolveEffectTime;
        [NMS(Index = 91)]
        /* 0x1C14 */ public float ShipBulletTraceLineWidth;
        [NMS(Index = 598)]
        /* 0x1C18 */ public float ShipDisplayDamageMultiplier;
        [NMS(Index = 395)]
        /* 0x1C1C */ public float ShipInteractRadius;
        [NMS(Index = 50)]
        /* 0x1C20 */ public float ShipInterestAcceleratorInAsteroidField;
        [NMS(Index = 655)]
        /* 0x1C24 */ public int ShipInventoryMinHeightMax;
        [NMS(Index = 654)]
        /* 0x1C28 */ public int ShipInventoryMinWidthMax;
        [NMS(Index = 52)]
        /* 0x1C2C */ public float ShipMiningMul;
        [NMS(Index = 442)]
        /* 0x1C30 */ public float ShipScanOffset;
        [NMS(Index = 443)]
        /* 0x1C34 */ public float ShipScanOffsetGap;
        [NMS(Index = 65)]
        /* 0x1C38 */ public float ShipScanPlanetRechargeMultiplier;
        [NMS(Index = 66)]
        /* 0x1C3C */ public float ShipScanSpaceRechargeMultiplier;
        [NMS(Index = 657)]
        /* 0x1C40 */ public int ShipTechInventoryMinHeightMax;
        [NMS(Index = 656)]
        /* 0x1C44 */ public int ShipTechInventoryMinWidthMax;
        [NMS(Index = 196)]
        /* 0x1C48 */ public float ShootableAggroForgetTime;
        [NMS(Index = 195)]
        /* 0x1C4C */ public float ShootableAggroMinStartTime;
        [NMS(Index = 194)]
        /* 0x1C50 */ public float ShootableArmourHighlightHitTime;
        [NMS(Index = 568)]
        /* 0x1C54 */ public float SimpleInteractionMessageTime;
        [NMS(Index = 566)]
        /* 0x1C58 */ public float SimpleInteractionPickupAngle;
        [NMS(Index = 567)]
        /* 0x1C5C */ public float SimpleInteractionPickupRadius;
        [NMS(Index = 53)]
        /* 0x1C60 */ public float SmugglerSellingMarkup;
        [NMS(Index = 292)]
        /* 0x1C64 */ public float SpaceBattleAnyHostileShipsRadius;
        [NMS(Index = 298)]
        /* 0x1C68 */ public int SpaceBattleMaxTorpedosTargetingLeaderShip;
        [NMS(Index = 299)]
        /* 0x1C6C */ public int SpaceBattleMaxTorpedosTargetingNonLeaderShip;
        [NMS(Index = 291)]
        /* 0x1C70 */ public float SpaceBattleRadius;
        [NMS(Index = 288)]
        /* 0x1C74 */ public float SpaceCombatRadius;
        [NMS(Index = 531)]
        /* 0x1C78 */ public float SpaceSpeedReadoutMultiplier;
        [NMS(Index = 645)]
        /* 0x1C7C */ public float SpawnerWeaponRange;
        [NMS(Index = 271)]
        /* 0x1C80 */ public int SpecialMiningAmount;
        [NMS(Index = 272)]
        /* 0x1C84 */ public float SpecialMiningTime;
        [NMS(Index = 32)]
        /* 0x1C88 */ public float SpecialTechSlotBonus;
        [NMS(Index = 530)]
        /* 0x1C8C */ public float SpeedReadoutMultiplier;
        [NMS(Index = 79)]
        /* 0x1C90 */ public float StormBonusJetpackMod;
        [NMS(Index = 83)]
        /* 0x1C94 */ public GcPlayerHazardType StormBonusJetpackWeather;
        [NMS(Index = 82)]
        /* 0x1C98 */ public float StormBonusMiningAmountMod;
        [NMS(Index = 86)]
        /* 0x1C9C */ public GcPlayerHazardType StormBonusMiningAmountWeather;
        [NMS(Index = 81)]
        /* 0x1CA0 */ public float StormBonusMiningHeatMod;
        [NMS(Index = 85)]
        /* 0x1CA4 */ public GcPlayerHazardType StormBonusMiningHeatWeather;
        [NMS(Index = 80)]
        /* 0x1CA8 */ public float StormBonusSprintMod;
        [NMS(Index = 84)]
        /* 0x1CAC */ public GcPlayerHazardType StormBonusSprintWeather;
        [NMS(Index = 78)]
        /* 0x1CB0 */ public float StormGravityChangeTime;
        [NMS(Index = 604)]
        /* 0x1CB4 */ public int SubstanceItemStockDecayTime;
        [NMS(Index = 605)]
        /* 0x1CB8 */ public int SubstanceItemStockReplenishTime;
        [NMS(Index = 144)]
        /* 0x1CBC */ public float SurveyBeginScanPercentage;
        [NMS(Index = 152)]
        /* 0x1CC0 */ public float SurveyMaxDistance;
        [NMS(Index = 146)]
        /* 0x1CC4 */ public float SurveyScanMaxSpeed;
        [NMS(Index = 145)]
        /* 0x1CC8 */ public float SurveyScanMinSpeed;
        [NMS(Index = 149)]
        /* 0x1CCC */ public float SurveySonarMaxPulseSpeed;
        [NMS(Index = 151)]
        /* 0x1CD0 */ public float SurveySonarMiddleRangeMax;
        [NMS(Index = 150)]
        /* 0x1CD4 */ public float SurveySonarMiddleRangeMin;
        [NMS(Index = 148)]
        /* 0x1CD8 */ public float SurveySonarMinPulseSpeed;
        [NMS(Index = 147)]
        /* 0x1CDC */ public float SurveySonarPulseSpeedBandCount;
        [NMS(Index = 238)]
        /* 0x1CE0 */ public float TapInteractionDecay;
        [NMS(Index = 237)]
        /* 0x1CE4 */ public float TapInteractionIncreaseAmount;
        [NMS(Index = 36)]
        /* 0x1CE8 */ public float TechDamageChanceShieldedMax;
        [NMS(Index = 38)]
        /* 0x1CEC */ public float TechDamageChanceShieldLevelMax;
        [NMS(Index = 37)]
        /* 0x1CF0 */ public float TechDamageChanceShieldLevelMin;
        [NMS(Index = 39)]
        /* 0x1CF4 */ public float TechDamageChanceToSelectPrimary;
        [NMS(Index = 76)]
        /* 0x1CF8 */ public GcTechnologyCategory TechnologyOverrideForSmuggler;
        [NMS(Index = 114)]
        /* 0x1CFC */ public float TeleporterDistanceTravelledMultiplier;
        [NMS(Index = 211)]
        /* 0x1D00 */ public float TerrainResourceCompassRange;
        [NMS(Index = 210)]
        /* 0x1D04 */ public float TerrainResourceScanRange;
        [NMS(Index = 209)]
        /* 0x1D08 */ public float TerrainResourceScanTime;
        [NMS(Index = 410)]
        /* 0x1D0C */ public float TimeToDisplayScanResults;
        [NMS(Index = 533)]
        /* 0x1D10 */ public int TorchCookieIndex;
        [NMS(Index = 536)]
        /* 0x1D14 */ public int TorchDimCookieIndex;
        [NMS(Index = 537)]
        /* 0x1D18 */ public float TorchDimFoV;
        [NMS(Index = 538)]
        /* 0x1D1C */ public float TorchDimStrength;
        [NMS(Index = 559)]
        /* 0x1D20 */ public float TorchFollowCameraPitch;
        [NMS(Index = 560)]
        /* 0x1D24 */ public float TorchFollowCameraTime;
        [NMS(Index = 534)]
        /* 0x1D28 */ public float TorchFoV;
        [NMS(Index = 554)]
        /* 0x1D2C */ public float TorchHandOffsetX;
        [NMS(Index = 555)]
        /* 0x1D30 */ public float TorchHandOffsetY;
        [NMS(Index = 556)]
        /* 0x1D34 */ public float TorchHandOffsetZ;
        [NMS(Index = 545)]
        /* 0x1D38 */ public float TorchOffsetX;
        [NMS(Index = 546)]
        /* 0x1D3C */ public float TorchOffsetY;
        [NMS(Index = 548)]
        /* 0x1D40 */ public float TorchOffsetZ;
        [NMS(Index = 547)]
        /* 0x1D44 */ public float TorchOffsetZMin;
        [NMS(Index = 553)]
        /* 0x1D48 */ public float TorchOffsetZMinSpeed;
        [NMS(Index = 552)]
        /* 0x1D4C */ public float TorchOffsetZSpeedRange;
        [NMS(Index = 558)]
        /* 0x1D50 */ public float TorchRotation;
        [NMS(Index = 549)]
        /* 0x1D54 */ public float TorchStaffOffsetY;
        [NMS(Index = 551)]
        /* 0x1D58 */ public float TorchStaffOffsetZ;
        [NMS(Index = 550)]
        /* 0x1D5C */ public float TorchStaffOffsetZMin;
        [NMS(Index = 535)]
        /* 0x1D60 */ public float TorchStrength;
        [NMS(Index = 107)]
        /* 0x1D64 */ public float TorpedoCooldown;
        [NMS(Index = 111)]
        /* 0x1D68 */ public float TorpedoCooldownRandomExtra;
        [NMS(Index = 110)]
        /* 0x1D6C */ public float TorpedoInitialWait;
        [NMS(Index = 112)]
        /* 0x1D70 */ public float TorpedoLaunchWarning;
        [NMS(Index = 377)]
        /* 0x1D74 */ public int TunnelStatReducer;
        [NMS(Index = 15)]
        /* 0x1D78 */ public float TurretAITargetingDistanceFactor;
        [NMS(Index = 19)]
        /* 0x1D7C */ public float TurretAITargetingFocusPlayerFactor;
        [NMS(Index = 18)]
        /* 0x1D80 */ public float TurretAITargetingLastHitFactor;
        [NMS(Index = 16)]
        /* 0x1D84 */ public float TurretAITargetingPitchAngleFactor;
        [NMS(Index = 17)]
        /* 0x1D88 */ public float TurretAITargetingYawAngleFactor;
        [NMS(Index = 541)]
        /* 0x1D8C */ public float UndergroundTorchFoV;
        [NMS(Index = 542)]
        /* 0x1D90 */ public float UndergroundTorchFoVFar;
        [NMS(Index = 543)]
        /* 0x1D94 */ public float UndergroundTorchStrength;
        [NMS(Index = 544)]
        /* 0x1D98 */ public float UndergroundTorchStrengthFar;
        [NMS(Index = 72)]
        /* 0x1D9C */ public float UnderwaterLightningDamageDistanceMultiplier;
        [NMS(Index = 92)]
        /* 0x1DA0 */ public float VehicleAllIconScanTime;
        [NMS(Index = 659)]
        /* 0x1DA4 */ public int VehicleInventoryMinHeightMax;
        [NMS(Index = 658)]
        /* 0x1DA8 */ public int VehicleInventoryMinWidthMax;
        [NMS(Index = 611)]
        /* 0x1DAC */ public float ViciousSentinelProbability;
        [NMS(Index = 612)]
        /* 0x1DB0 */ public float ViciousStormProbability;
        [NMS(Index = 613)]
        /* 0x1DB4 */ public float ViciousWeatherProbability;
        [NMS(Index = 378)]
        /* 0x1DB8 */ public float VoxelAsteroidResourceChance;
        [NMS(Index = 289)]
        /* 0x1DBC */ public int WarpsBetweenBattles;
        [NMS(Index = 587)]
        /* 0x1DC0 */ public int WarpsBetweenMiniStation;
        [NMS(Index = 334)]
        /* 0x1DC4 */ public float WaterLandingDamageMultiplier;
        [NMS(Index = 372)]
        /* 0x1DC8 */ public float WaypointScanTime;
        [NMS(Index = 661)]
        /* 0x1DCC */ public int WeaponInventoryMinHeightMax;
        [NMS(Index = 660)]
        /* 0x1DD0 */ public int WeaponInventoryMinWidthMax;
        [NMS(Index = 75)]
        /* 0x1DD4 */ public float WeatherHazardGiftLifeTime;
        [NMS(Index = 74)]
        /* 0x1DD8 */ public float WeatherHazardGiftMaxDistance;
        [NMS(Index = 409)]
        /* 0x1DDC */ public float ZoomFindBuildingRange;
        [NMS(Index = 590)]
        /* 0x1DE0 */ public NMSString0x80 BaseBuildingTable;
        [NMS(Index = 577)]
        /* 0x1E60 */ public NMSString0x80 InitialDebrisScene;
        [NMS(Index = 589)]
        /* 0x1EE0 */ public NMSString0x80 LegacyBaseBuildingTable;
        [NMS(Index = 492)]
        /* 0x1F60 */ public NMSString0x80 ResourceParticleFile;
        [NMS(Index = 392)]
        /* 0x1FE0 */ public NMSString0x20 DepotResource;
        [NMS(Index = 391)]
        /* 0x2000 */ public NMSString0x20 RobotResource;
        [NMS(Index = 189)]
        /* 0x2020 */ public bool AllowBinocularMarker;
        [NMS(Index = 188)]
        /* 0x2021 */ public bool AllowDeconstruct;
        [NMS(Index = 158)]
        /* 0x2022 */ public bool AllowSpaceScanEvents;
        [NMS(Index = 204)]
        /* 0x2023 */ public TkCurveType AtmosphereEntryCurve;
        [NMS(Index = 458)]
        /* 0x2024 */ public bool Autolevel;
        [NMS(Index = 212)]
        /* 0x2025 */ public bool BinocsDisplayUnknownCreatures;
        [NMS(Index = 219)]
        /* 0x2026 */ public TkCurveType BinocularScanTargetHeightCurve;
        [NMS(Index = 159)]
        /* 0x2027 */ public bool CanMoveTechnology;
        [NMS(Index = 600)]
        /* 0x2028 */ public bool ChangePricesLocally;
        [NMS(Index = 529)]
        /* 0x2029 */ public bool DebugDrawTriggerBoxes;
        [NMS(Index = 31)]
        /* 0x202A */ public bool DebugPrintShootables;
        [NMS(Index = 440)]
        /* 0x202B */ public bool DebugScanForceBuilding;
        [NMS(Index = 187)]
        /* 0x202C */ public bool DisableAnomalyAmbientSpawn;
        [NMS(Index = 595)]
        /* 0x202D */ public bool DisableBasePowerHUDOverlay;
        [NMS(Index = 155)]
        /* 0x202E */ public bool DisableGalaxyMapInQuickMenu;
        [NMS(Index = 156)]
        /* 0x202F */ public bool DisableNexusInQuickMenu;
        [NMS(Index = 1)]
        /* 0x2030 */ public bool DoShipBuilderInteractionBuildEffect;
        [NMS(Index = 4)]
        /* 0x2031 */ public bool DoShipBuilderInteractionBuildEffectOutward;
        [NMS(Index = 192)]
        /* 0x2032 */ public bool EnableShootHitEffect;
        [NMS(Index = 34)]
        /* 0x2033 */ public bool EnableTechPackaging;
        [NMS(Index = 157)]
        /* 0x2034 */ public bool EnableTeleporters;
        [NMS(Index = 190)]
        /* 0x2035 */ public bool EveryMaintenanceIsBroken;
        [NMS(Index = 333)]
        /* 0x2036 */ public bool FailToFindBuildings;
        [NMS(Index = 186)]
        /* 0x2037 */ public bool FreighterRequiresRGBHyperdriveUpgrades;
        [NMS(Index = 472)]
        /* 0x2038 */ public bool HUDUpdateFromData;
        [NMS(Index = 185)]
        /* 0x2039 */ public bool InstallTechWithInteraction;
        [NMS(Index = 265)]
        /* 0x203A */ public bool InteractionOverride;
        [NMS(Index = 596)]
        /* 0x203B */ public bool KeepAttackingMaxWantedLevel;
        [NMS(Index = 123)]
        /* 0x203C */ public bool MissionSurveySuggestSurveyForNearScannables;
        [NMS(Index = 174)]
        /* 0x203D */ public TkCurveType OverheatColourCurve;
        [NMS(Index = 173)]
        /* 0x203E */ public TkCurveType OverheatColourCurveShip;
        [NMS(Index = 169)]
        /* 0x203F */ public TkCurveType OverheatCurve;
        [NMS(Index = 514)]
        /* 0x2040 */ public TkCurveType PainCurve;
        [NMS(Index = 490)]
        /* 0x2041 */ public bool PlayHitEffectsOnZeroDamage;
        [NMS(Index = 6)]
        /* 0x2042 */ public bool RewardInventoryClassItemFromShipSalvage;
        [NMS(Index = 21)]
        /* 0x2043 */ public bool ScanToRevealIgnoreRequirements;
        [NMS(Index = 22)]
        /* 0x2044 */ public bool ScanToRevealNPCsAlwaysTriggersCameraEvent;
        [NMS(Index = 444)]
        /* 0x2045 */ public TkCurveType ShipScanCurve;
        [NMS(Index = 601)]
        /* 0x2046 */ public bool ShowPriceMarkupsAsPercentages;
        [NMS(Index = 191)]
        /* 0x2047 */ public bool SpawnResourceBlobsOnPartDelete;
        [NMS(Index = 30)]
        /* 0x2048 */ public bool TechMustBeInTechInventory;
        [NMS(Index = 557)]
        /* 0x2049 */ public bool TorchDisabledInTheDay;
        [NMS(Index = 648)]
        /* 0x204A */ public bool UseCustomSaveDirectory;
        [NMS(Index = 439)]
        /* 0x204B */ public bool UseDebugScan;
        [NMS(Index = 597)]
        /* 0x204C */ public bool UseMultiplierBonus;
        [NMS(Index = 170)]
        /* 0x204D */ public bool UseOverheatColour;
        [NMS(Index = 29)]
        /* 0x204E */ public bool UseSecondaryBiomeSubstances;
        [NMS(Index = 599)]
        /* 0x204F */ public bool UseTradingCostTable;
    }
}
