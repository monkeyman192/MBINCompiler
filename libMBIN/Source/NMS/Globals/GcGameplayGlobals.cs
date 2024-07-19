using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xC37F94CFA88CFEAE, NameHash = 0x2524086B)]
    public class GcGameplayGlobals : NMSTemplate
    {
        [NMS(Index = 484)]
        /* 0x0000 */ public GcShipHUDTargetData HUDTarget;
        [NMS(Index = 428)]
        /* 0x0110 */ public GcScanEffectData BaseBuildingDeleteScanEffect;
        [NMS(Index = 436)]
        /* 0x0160 */ public GcScanEffectData BaseBuildingErrorAboveWaterScanEffect;
        [NMS(Index = 437)]
        /* 0x01B0 */ public GcScanEffectData BaseBuildingErrorBelowWaterScanEffect;
        [NMS(Index = 433)]
        /* 0x0200 */ public GcScanEffectData BaseBuildingErrorCollisionScanEffect;
        [NMS(Index = 434)]
        /* 0x0250 */ public GcScanEffectData BaseBuildingErrorImpossibleScanEffect;
        [NMS(Index = 432)]
        /* 0x02A0 */ public GcScanEffectData BaseBuildingErrorInsideScanEffect;
        [NMS(Index = 435)]
        /* 0x02F0 */ public GcScanEffectData BaseBuildingErrorUnaffordableScanEffect;
        [NMS(Index = 429)]
        /* 0x0340 */ public GcScanEffectData BaseBuildingGhostScanEffect;
        [NMS(Index = 426)]
        /* 0x0390 */ public GcScanEffectData BaseBuildingPreviewSelectionScanEffect;
        [NMS(Index = 439)]
        /* 0x03E0 */ public GcScanEffectData BaseBuildingRemotePlayerSelectionScanEffect;
        [NMS(Index = 438)]
        /* 0x0430 */ public GcScanEffectData BaseBuildingRemotePlayerValidScanEffect;
        [NMS(Index = 427)]
        /* 0x0480 */ public GcScanEffectData BaseBuildingSelectionScanEffect;
        [NMS(Index = 430)]
        /* 0x04D0 */ public GcScanEffectData BaseBuildingSpawnStaticEffect;
        [NMS(Index = 425)]
        /* 0x0520 */ public GcScanEffectData BaseBuildingValidScanEffect;
        [NMS(Index = 431)]
        /* 0x0570 */ public GcScanEffectData BaseBuildingVisionScanEffect;
        [NMS(Index = 227)]
        /* 0x05C0 */ public GcScanEffectData BinocularScanEffect;
        [NMS(Index = 116)]
        /* 0x0610 */ public GcScanEffectData BinocularSelectedEffect;
        [NMS(Index = 424)]
        /* 0x0660 */ public GcScanEffectData BlankScanEffect;
        [NMS(Index = 418)]
        /* 0x06B0 */ public GcScanEffectData BuildingScanEffect;
        [NMS(Index = 421)]
        /* 0x0700 */ public GcScanEffectData CreatureScanEffect;
        [NMS(Index = 241)]
        /* 0x0750 */ public GcScanEffectData DeconstructEffect;
        [NMS(Index = 242)]
        /* 0x07A0 */ public GcScanEffectData HitEffect;
        [NMS(Index = 243)]
        /* 0x07F0 */ public GcScanEffectData HitEffectCritical;
        [NMS(Index = 420)]
        /* 0x0840 */ public GcScanEffectData HUDShipScanEffect;
        [NMS(Index = 422)]
        /* 0x0890 */ public GcScanEffectData ObjectsScanEffect;
        [NMS(Index = 417)]
        /* 0x08E0 */ public GcScanEffectData PassiveScanEffect;
        [NMS(Index = 621)]
        /* 0x0930 */ public GcScanEffectData ShipBuilderNullScanEffect;
        [NMS(Index = 620)]
        /* 0x0980 */ public GcScanEffectData ShipBuilderScanEffect;
        [NMS(Index = 619)]
        /* 0x09D0 */ public GcScanEffectData ShipSalvageScanEffect;
        [NMS(Index = 419)]
        /* 0x0A20 */ public GcScanEffectData TargetShipScanEffect;
        [NMS(Index = 423)]
        /* 0x0A70 */ public GcScanEffectData VRGhostScanEffect;
        [NMS(Index = 226)]
        /* 0x0AC0 */ public Colour BinocularScanTargetColour;
        [NMS(Index = 117)]
        /* 0x0AD0 */ public Colour BinocularSelectedColour;
        [NMS(Index = 118)]
        /* 0x0AE0 */ public Colour BinocularSelectedUnknownColour;
        [NMS(Index = 90)]
        /* 0x0AF0 */ public Colour BulletTraceLineColour;
        [NMS(Index = 246)]
        /* 0x0B00 */ public Vector3f CommunicatorShipSpawnOffset;
        [NMS(Index = 480)]
        /* 0x0B10 */ public Colour HUDDamageSplatPainColour;
        [NMS(Index = 479)]
        /* 0x0B20 */ public Colour HUDDamageSplatShieldColour;
        [NMS(Index = 174)]
        /* 0x0B30 */ public Colour OverHeatBarColour;
        [NMS(Index = 173)]
        /* 0x0B40 */ public Colour OverHeatColour;
        [NMS(Index = 517)]
        /* 0x0B50 */ public Colour PainColour;
        [NMS(Index = 565)]
        /* 0x0B60 */ public Colour PlayerAmbientSpotLightColour;
        [NMS(Index = 199)]
        /* 0x0B70 */ public Colour RefinerColour1A;
        [NMS(Index = 200)]
        /* 0x0B80 */ public Colour RefinerColour1B;
        [NMS(Index = 201)]
        /* 0x0B90 */ public Colour RefinerColour1C;
        [NMS(Index = 202)]
        /* 0x0BA0 */ public Colour RefinerColour1D;
        [NMS(Index = 463)]
        /* 0x0BB0 */ public Colour ScannerColour1;
        [NMS(Index = 464)]
        /* 0x0BC0 */ public Colour ScannerColour2;
        [NMS(Index = 563)]
        /* 0x0BD0 */ public Colour TorchColour;
        [NMS(Index = 0)]
        /* 0x0BE0 */ public GcScanToRevealComponentData CaveGraveRevealData;
        [NMS(Index = 104, Size = 0x5)]
        /* 0x0C30 */ public NMSString0x10[] SalvageTechList;
        [NMS(Index = 105, Size = 0x5)]
        /* 0x0C80 */ public NMSString0x10[] SalvageTechListMultiTool;
        [NMS(Index = 101, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x0CD0 */ public NMSString0x10[] SalvageRewardsDropship;
        [NMS(Index = 102, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x0D10 */ public NMSString0x10[] SalvageRewardsFighter;
        [NMS(Index = 103, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x0D50 */ public NMSString0x10[] SalvageRewardsScience;
        [NMS(Index = 100, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x0D90 */ public NMSString0x10[] SalvageRewardsShuttle;
        [NMS(Index = 634)]
        /* 0x0DD0 */ public NMSString0x20A CommunicatorFireteamNexusExitDialog;
        [NMS(Index = 635)]
        /* 0x0DF0 */ public NMSString0x20A CommunicatorNexusExitAbandonWarningDialog;
        [NMS(Index = 649)]
        /* 0x0E10 */ public TkModelResource WeaponSpawnAltObject;
        [NMS(Index = 648)]
        /* 0x0E28 */ public TkModelResource WeaponSpawnObject;
        [NMS(Index = 592)]
        /* 0x0E40 */ public VariableSizeString BaseBuildingTable;
        [NMS(Index = 403)]
        /* 0x0E50 */ public NMSString0x10 BeaconScan;
        [NMS(Index = 392)]
        /* 0x0E60 */ public NMSString0x10 BioShipTerrainResource;
        [NMS(Index = 28)]
        /* 0x0E70 */ public NMSString0x10 BuildersWordReward;
        [NMS(Index = 258)]
        /* 0x0E80 */ public List<GcScanEffectData> CommunicatorEffectTable;
        [NMS(Index = 407)]
        /* 0x0E90 */ public NMSString0x10 DebugScanPlanet;
        [NMS(Index = 408)]
        /* 0x0EA0 */ public NMSString0x10 DebugScanSpace;
        [NMS(Index = 530)]
        /* 0x0EB0 */ public NMSString0x10 DefaultAnim;
        [NMS(Index = 406)]
        /* 0x0EC0 */ public NMSString0x10 DistressSignalScan;
        [NMS(Index = 69)]
        /* 0x0ED0 */ public NMSString0x10 FreeShipSlotID;
        [NMS(Index = 68)]
        /* 0x0EE0 */ public NMSString0x10 FreeSuitSlotID;
        [NMS(Index = 70)]
        /* 0x0EF0 */ public NMSString0x10 FreeWeapSlotID;
        [NMS(Index = 182)]
        /* 0x0F00 */ public List<NMSString0x10> FreighterHyperdriveAccess;
        [NMS(Index = 181)]
        /* 0x0F10 */ public List<NMSString0x10> HyperdriveAccess;
        [NMS(Index = 579)]
        /* 0x0F20 */ public VariableSizeString InitialDebrisScene;
        [NMS(Index = 591)]
        /* 0x0F30 */ public VariableSizeString LegacyBaseBuildingTable;
        [NMS(Index = 128)]
        /* 0x0F40 */ public NMSString0x10 MissionSurveyBugsID;
        [NMS(Index = 127)]
        /* 0x0F50 */ public NMSString0x10 MissionSurveyWormID;
        [NMS(Index = 64)]
        /* 0x0F60 */ public NMSString0x10 NexusRecipeCostType;
        [NMS(Index = 405)]
        /* 0x0F70 */ public NMSString0x10 ObservatoryScan;
        [NMS(Index = 360)]
        /* 0x0F80 */ public List<float> PirateEarlySpawnChances;
        [NMS(Index = 26)]
        /* 0x0F90 */ public NMSString0x10 PirateMissionPrimaryReward;
        [NMS(Index = 27)]
        /* 0x0FA0 */ public NMSString0x10 PirateMissionSecondReward;
        [NMS(Index = 404)]
        /* 0x0FB0 */ public NMSString0x10 RadioTowerScan;
        [NMS(Index = 390)]
        /* 0x0FC0 */ public NMSString0x10 ResourceDirtSubstanceID;
        [NMS(Index = 494)]
        /* 0x0FD0 */ public VariableSizeString ResourceParticleFile;
        [NMS(Index = 106)]
        /* 0x0FE0 */ public List<NMSString0x10> SalvageProdsList;
        [NMS(Index = 107)]
        /* 0x0FF0 */ public List<NMSString0x10> SalvageSubstancesList;
        [NMS(Index = 391)]
        /* 0x1000 */ public NMSString0x10 SandwormTerrainResource;
        [NMS(Index = 409)]
        /* 0x1010 */ public NMSString0x10 ShipScan;
        [NMS(Index = 400)]
        /* 0x1020 */ public NMSString0x10 ToolScan;
        [NMS(Index = 401)]
        /* 0x1030 */ public NMSString0x10 ToolScanHardMode;
        [NMS(Index = 410)]
        /* 0x1040 */ public NMSString0x10 VisualScan;
        [NMS(Index = 402)]
        /* 0x1050 */ public NMSString0x10 WaypointScan;
        [NMS(Index = 416)]
        /* 0x1060 */ public List<GcZoomData> ZoomLevels;
        [NMS(Index = 594)]
        /* 0x1070 */ public ulong NPCWorkerInteractionCooldown;
        [NMS(Index = 398)]
        /* 0x1078 */ public GcResourceCollectEffect AsteroidResourceCollect;
        [NMS(Index = 362)]
        /* 0x10AC */ public GcExperienceTimers FlybyTimers;
        [NMS(Index = 357)]
        /* 0x10CC */ public GcExperienceTimers FreighterTimers;
        [NMS(Index = 358)]
        /* 0x10EC */ public GcExperienceTimers PlanetPirateTimers;
        [NMS(Index = 364)]
        /* 0x110C */ public GcExperienceTimers PoliceTimers;
        [NMS(Index = 354)]
        /* 0x112C */ public GcExperienceTimers SentinelTimersLow;
        [NMS(Index = 355)]
        /* 0x114C */ public GcExperienceTimers SentinelTimersNormal;
        [NMS(Index = 363)]
        /* 0x116C */ public GcExperienceTimers SpaceFlybyTimers;
        [NMS(Index = 359)]
        /* 0x118C */ public GcExperienceTimers SpacePirateTimers;
        [NMS(Index = 646, Size = 0x7)]
        /* 0x11AC */ public int[] AlienShipEvolveCosts;
        [NMS(Index = 365, Size = 0x7, EnumType = typeof(GcProceduralTechnologyData.QualityEnum))]
        /* 0x11C8 */ public int[] FreighterTechQualityWeightings;
        [NMS(Index = 528)]
        /* 0x11E4 */ public GcTracerData BulletTracer;
        [NMS(Index = 529)]
        /* 0x11FC */ public GcTracerData ShipTracer;
        [NMS(Index = 308, Size = 0x4, EnumType = typeof(GcPlayerConflictData.ConflictLevelEnum))]
        /* 0x1214 */ public float[] ChanceOfPirateFreighterBattleOnWarpToSystem;
        [NMS(Index = 29, Size = 0x3, EnumType = typeof(GcMissionDifficulty.MissionDifficultyEnum))]
        /* 0x1224 */ public float[] MissionSubstanceDifficultyMultipliers;
        [NMS(Index = 283, Size = 0x3)]
        /* 0x1230 */ public int[] PirateInterestLevels;
        [NMS(Index = 284, Size = 0x3)]
        /* 0x123C */ public int[] PirateInterestLevelsSurvival;
        [NMS(Index = 288, Size = 0x3)]
        /* 0x1248 */ public int[] PoliceInterestLevels;
        [NMS(Index = 289, Size = 0x3)]
        /* 0x1254 */ public int[] PoliceInterestLevelsSurvival;
        [NMS(Index = 651)]
        /* 0x1260 */ public Vector2f FrigateFlybyTimer;
        [NMS(Index = 477)]
        /* 0x1268 */ public Vector2f HUDDamageSize;
        [NMS(Index = 478)]
        /* 0x1270 */ public Vector2f HUDDamageSplatSize;
        [NMS(Index = 608)]
        /* 0x1278 */ public GcPortalData Portal;
        [NMS(Index = 11)]
        /* 0x1280 */ public Vector2f SaveContextTransferShipCostScaleNanites;
        [NMS(Index = 10)]
        /* 0x1288 */ public Vector2f SaveContextTransferShipCostScaleUnits;
        [NMS(Index = 9)]
        /* 0x1290 */ public Vector2f SaveContextTransferWeaponCostScaleNanites;
        [NMS(Index = 8)]
        /* 0x1298 */ public Vector2f SaveContextTransferWeaponCostScaleUnits;
        [NMS(Index = 343)]
        /* 0x12A0 */ public float AggressiveSentinelProbability;
        [NMS(Index = 344)]
        /* 0x12A4 */ public float AggressiveSentinelProbabilitySurvival;
        [NMS(Index = 596)]
        /* 0x12A8 */ public float AirLockDoorRange;
        [NMS(Index = 89)]
        /* 0x12AC */ public float AlienPodThreshold1;
        [NMS(Index = 88)]
        /* 0x12B0 */ public float AlienPodThreshold2;
        [NMS(Index = 233)]
        /* 0x12B4 */ public float AllRecipesKnownNanitesMax;
        [NMS(Index = 232)]
        /* 0x12B8 */ public float AllRecipesKnownNanitesMin;
        [NMS(Index = 121)]
        /* 0x12BC */ public float AngleFromBaseComputerWhenTeleporting;
        [NMS(Index = 370)]
        /* 0x12C0 */ public float AsteroidCarveRadius;
        [NMS(Index = 368)]
        /* 0x12C4 */ public float AsteroidHitForce;
        [NMS(Index = 378)]
        /* 0x12C8 */ public int AsteroidResourceReducer;
        [NMS(Index = 208)]
        /* 0x12CC */ public int AsteroidScanMaxShown;
        [NMS(Index = 210)]
        /* 0x12D0 */ public float AsteroidScanRange;
        [NMS(Index = 209)]
        /* 0x12D4 */ public float AsteroidScanTime;
        [NMS(Index = 369)]
        /* 0x12D8 */ public float AsteroidTorqueForce;
        [NMS(Index = 664)]
        /* 0x12DC */ public float AtlasGunCurrencyConversion;
        [NMS(Index = 207)]
        /* 0x12E0 */ public float AtmosphereEntryErrorTime;
        [NMS(Index = 204)]
        /* 0x12E4 */ public float AtmosphereEntryFadeTimeFactor;
        [NMS(Index = 205)]
        /* 0x12E8 */ public float AtmosphereEntryOffset;
        [NMS(Index = 203)]
        /* 0x12EC */ public float AtmosphereEntryTime;
        [NMS(Index = 123)]
        /* 0x12F0 */ public float AutoTranslateWordChance;
        [NMS(Index = 636)]
        /* 0x12F4 */ public float BackgroundSpaceEncounterCheckTimer;
        [NMS(Index = 526)]
        /* 0x12F8 */ public float BarrelOffset;
        [NMS(Index = 593)]
        /* 0x12FC */ public float BaseBuildingHoverTimeToKnowPart;
        [NMS(Index = 440)]
        /* 0x1300 */ public float BaseBuildingRemotePlayerErrorAlphaScanEffect;
        [NMS(Index = 163)]
        /* 0x1304 */ public float BaseLaserHeatTime;
        [NMS(Index = 396)]
        /* 0x1308 */ public float BeaconInteractRange;
        [NMS(Index = 220)]
        /* 0x130C */ public float BinocCreatureScanTime;
        [NMS(Index = 218)]
        /* 0x1310 */ public float BinocMinScanTime;
        [NMS(Index = 219)]
        /* 0x1314 */ public float BinocScanTime;
        [NMS(Index = 217)]
        /* 0x1318 */ public float BinocTimeBeforeScan;
        [NMS(Index = 225)]
        /* 0x131C */ public float BinocularScanTargetFadeTime;
        [NMS(Index = 216)]
        /* 0x1320 */ public float BinocularScanTargetHeightRange;
        [NMS(Index = 222)]
        /* 0x1324 */ public float BinocularScanTargetInitialFadeTime;
        [NMS(Index = 224)]
        /* 0x1328 */ public float BinocularScanTargetLineWidth;
        [NMS(Index = 215)]
        /* 0x132C */ public float BinocularScanTargetMinHeight;
        [NMS(Index = 223)]
        /* 0x1330 */ public float BinocularScanTargetScaler;
        [NMS(Index = 586)]
        /* 0x1334 */ public float BlackHoleJumpVoxelDist;
        [NMS(Index = 587)]
        /* 0x1338 */ public float BlackHoleJumpVoxelVariation;
        [NMS(Index = 582)]
        /* 0x133C */ public float BonusChildTypeElementsAdd;
        [NMS(Index = 583)]
        /* 0x1340 */ public float BonusChildTypeElementsMultiply;
        [NMS(Index = 580)]
        /* 0x1344 */ public float BonusSameTypeElementsAdd;
        [NMS(Index = 581)]
        /* 0x1348 */ public float BonusSameTypeElementsMultiply;
        [NMS(Index = 1)]
        /* 0x134C */ public int BugFiendCap;
        [NMS(Index = 373)]
        /* 0x1350 */ public float BuildingBeamDistance;
        [NMS(Index = 235)]
        /* 0x1354 */ public float BuildingPlayerBaseIconOffset;
        [NMS(Index = 91)]
        /* 0x1358 */ public float BulletTraceLineWidth;
        [NMS(Index = 36)]
        /* 0x135C */ public float CargoShieldStrength;
        [NMS(Index = 119)]
        /* 0x1360 */ public float CockpitScale;
        [NMS(Index = 57)]
        /* 0x1364 */ public float CombatLevelBaseValueBoltcaster;
        [NMS(Index = 61)]
        /* 0x1368 */ public float CombatLevelBaseValueCannon;
        [NMS(Index = 62)]
        /* 0x136C */ public float CombatLevelBaseValueGrenade;
        [NMS(Index = 59)]
        /* 0x1370 */ public float CombatLevelBaseValueRailgun;
        [NMS(Index = 58)]
        /* 0x1374 */ public float CombatLevelBaseValueShotgun;
        [NMS(Index = 60)]
        /* 0x1378 */ public float CombatLevelBaseValueSMG;
        [NMS(Index = 56)]
        /* 0x137C */ public float CombatLevelBestWeaponBias;
        [NMS(Index = 63)]
        /* 0x1380 */ public float CombatLevelSClassValue;
        [NMS(Index = 534)]
        /* 0x1384 */ public float CombatSpeedReadoutMultiplier;
        [NMS(Index = 376)]
        /* 0x1388 */ public int CommonProductEffectiveness;
        [NMS(Index = 253)]
        /* 0x138C */ public float CommunicatorCargoScanDroneAtOffsetFallback;
        [NMS(Index = 254)]
        /* 0x1390 */ public float CommunicatorCargoScanDronePitch;
        [NMS(Index = 255)]
        /* 0x1394 */ public float CommunicatorCargoScanDroneRoll;
        [NMS(Index = 249)]
        /* 0x1398 */ public float CommunicatorCargoScanDroneScale;
        [NMS(Index = 250)]
        /* 0x139C */ public float CommunicatorCargoScanDroneScaleFallback;
        [NMS(Index = 251)]
        /* 0x13A0 */ public float CommunicatorCargoScanDroneUpOffset;
        [NMS(Index = 252)]
        /* 0x13A4 */ public float CommunicatorCargoScanDroneUpOffsetFallback;
        [NMS(Index = 256)]
        /* 0x13A8 */ public float CommunicatorCargoScanDroneYaw;
        [NMS(Index = 257)]
        /* 0x13AC */ public float CommunicatorFadeTime;
        [NMS(Index = 245)]
        /* 0x13B0 */ public float CommunicatorSpawnHeightOffset;
        [NMS(Index = 244)]
        /* 0x13B4 */ public float CommunicatorSpawnOffset;
        [NMS(Index = 248)]
        /* 0x13B8 */ public float CommunicatorSpawnRotation;
        [NMS(Index = 247)]
        /* 0x13BC */ public float CommunicatorSpawnScale;
        [NMS(Index = 612)]
        /* 0x13C0 */ public float CorruptSentinelProbability;
        [NMS(Index = 332)]
        /* 0x13C4 */ public float CreatureMinScanTime;
        [NMS(Index = 331)]
        /* 0x13C8 */ public float CreatureScanAngle;
        [NMS(Index = 330)]
        /* 0x13CC */ public float CreatureScanStickyDecay;
        [NMS(Index = 155)]
        /* 0x13D0 */ public int CreaturesToBaitForTutorial;
        [NMS(Index = 156)]
        /* 0x13D4 */ public int CreaturesToFeedForTutorial;
        [NMS(Index = 337)]
        /* 0x13D8 */ public int CritDamage;
        [NMS(Index = 236)]
        /* 0x13DC */ public float CriticalHitMultiplier;
        [NMS(Index = 338)]
        /* 0x13E0 */ public float CritScale;
        [NMS(Index = 618)]
        /* 0x13E4 */ public float DeadPlanetGravityFactor;
        [NMS(Index = 371)]
        /* 0x13E8 */ public int DeathMoneyPenalty;
        [NMS(Index = 443)]
        /* 0x13EC */ public GcBuildingClassification DebugScanForceBuildingType;
        [NMS(Index = 645)]
        /* 0x13F0 */ public float DerelictPulseEncounterAtmosphericEffectChance;
        [NMS(Index = 270)]
        /* 0x13F4 */ public float DestroyEffectHeight;
        [NMS(Index = 271)]
        /* 0x13F8 */ public float DestroyEffectMaxScale;
        [NMS(Index = 122)]
        /* 0x13FC */ public float DistanceFromBaseComputerWhenTeleporting;
        [NMS(Index = 395)]
        /* 0x1400 */ public float DockNodeBuyRadius;
        [NMS(Index = 278)]
        /* 0x1404 */ public int EarlyPiratesToBeKilled;
        [NMS(Index = 340)]
        /* 0x1408 */ public float EmergencyBuildingScanEventDistance;
        [NMS(Index = 341)]
        /* 0x140C */ public float EmergencyBuildingScanEventTime;
        [NMS(Index = 272)]
        /* 0x1410 */ public float EventTargetSpeed;
        [NMS(Index = 468)]
        /* 0x1414 */ public float ExcitingNearRange;
        [NMS(Index = 466)]
        /* 0x1418 */ public float ExcitingViewAngle;
        [NMS(Index = 467)]
        /* 0x141C */ public float ExcitingViewRange;
        [NMS(Index = 574)]
        /* 0x1420 */ public float ExplosionForce;
        [NMS(Index = 575)]
        /* 0x1424 */ public float ExplosionForceMaxForceRadius;
        [NMS(Index = 573)]
        /* 0x1428 */ public float ExplosionRadiusMultiplier;
        [NMS(Index = 609)]
        /* 0x142C */ public int FourthRaceSpawnPercentage;
        [NMS(Index = 295)]
        /* 0x1430 */ public float FreighterBattleRadius;
        [NMS(Index = 307)]
        /* 0x1434 */ public float FreighterCargoPodHealthFraction;
        [NMS(Index = 306)]
        /* 0x1438 */ public float FreighterFuelRodHealthFraction;
        [NMS(Index = 356)]
        /* 0x143C */ public int FreighterStartPecent;
        [NMS(Index = 585)]
        /* 0x1440 */ public float GoalGapVoxelDist;
        [NMS(Index = 97)]
        /* 0x1444 */ public int GPSRandomChangeTimeBuilderCorruption;
        [NMS(Index = 95)]
        /* 0x1448 */ public int GPSRandomChangeTimeMid;
        [NMS(Index = 96)]
        /* 0x144C */ public int GPSRandomChangeTimeNarrow;
        [NMS(Index = 94)]
        /* 0x1450 */ public int GPSRandomChangeTimeWide;
        [NMS(Index = 238)]
        /* 0x1454 */ public float GrabPlayerCooldownTime;
        [NMS(Index = 524)]
        /* 0x1458 */ public float GunDownAngle;
        [NMS(Index = 521)]
        /* 0x145C */ public float GunOffsetAggressiveX;
        [NMS(Index = 522)]
        /* 0x1460 */ public float GunOffsetAggressiveY;
        [NMS(Index = 523)]
        /* 0x1464 */ public float GunOffsetAggressiveZ;
        [NMS(Index = 518)]
        /* 0x1468 */ public float GunOffsetX;
        [NMS(Index = 519)]
        /* 0x146C */ public float GunOffsetY;
        [NMS(Index = 520)]
        /* 0x1470 */ public float GunOffsetZ;
        [NMS(Index = 525)]
        /* 0x1474 */ public float GunUpAngle;
        [NMS(Index = 277)]
        /* 0x1478 */ public int HardModeTechDamageHighPercent;
        [NMS(Index = 275)]
        /* 0x147C */ public int HardModeTechDamageMidNum;
        [NMS(Index = 276)]
        /* 0x1480 */ public int HardModeTechDamageMidPercent;
        [NMS(Index = 164)]
        /* 0x1484 */ public float HeatAlertTime;
        [NMS(Index = 165)]
        /* 0x1488 */ public float HeatDamageBoost;
        [NMS(Index = 169)]
        /* 0x148C */ public float HeatMaxPowerPoint;
        [NMS(Index = 166)]
        /* 0x1490 */ public float HeatWidthBoost;
        [NMS(Index = 167)]
        /* 0x1494 */ public float HeatWidthBoostAlt;
        [NMS(Index = 237)]
        /* 0x1498 */ public float HitEffectMinTime;
        [NMS(Index = 527)]
        /* 0x149C */ public float HitOffset;
        [NMS(Index = 185)]
        /* 0x14A0 */ public float HmdInteractionRangeMinDistance;
        [NMS(Index = 184)]
        /* 0x14A4 */ public float HmdInteractionRangeMinRange;
        [NMS(Index = 186)]
        /* 0x14A8 */ public float HmdInteractionRangeMultiplier;
        [NMS(Index = 292)]
        /* 0x14AC */ public float HoursBetweenBattles;
        [NMS(Index = 590)]
        /* 0x14B0 */ public float HoursBetweenMiniStation;
        [NMS(Index = 413)]
        /* 0x14B4 */ public float HoverTimeToScan;
        [NMS(Index = 414)]
        /* 0x14B8 */ public float HoverTimeToScanCreatures;
        [NMS(Index = 415)]
        /* 0x14BC */ public int HoverVisiblePointsNeeded;
        [NMS(Index = 476)]
        /* 0x14C0 */ public float HUDArrowPrimaryScaler;
        [NMS(Index = 481)]
        /* 0x14C4 */ public float HUDDamageOffset;
        [NMS(Index = 483)]
        /* 0x14C8 */ public float HUDDamageRadius;
        [NMS(Index = 482)]
        /* 0x14CC */ public float HUDDamageScaler;
        [NMS(Index = 486)]
        /* 0x14D0 */ public float HUDLabelAngle;
        [NMS(Index = 487)]
        /* 0x14D4 */ public float HUDLabelAngleOffset;
        [NMS(Index = 488)]
        /* 0x14D8 */ public float HUDLabelOffsetX;
        [NMS(Index = 489)]
        /* 0x14DC */ public float HUDLabelOffsetY;
        [NMS(Index = 490)]
        /* 0x14E0 */ public float HUDLabelOffsetZ;
        [NMS(Index = 491)]
        /* 0x14E4 */ public float HUDLabelScale;
        [NMS(Index = 485)]
        /* 0x14E8 */ public float HUDLabelTime;
        [NMS(Index = 475)]
        /* 0x14EC */ public float HUDLockOnAudioTime;
        [NMS(Index = 511)]
        /* 0x14F0 */ public float HUDReticuleMoveAim;
        [NMS(Index = 510)]
        /* 0x14F4 */ public float HUDReticuleMoveBack;
        [NMS(Index = 504)]
        /* 0x14F8 */ public float HUDScaleAdd;
        [NMS(Index = 509)]
        /* 0x14FC */ public float HUDScaleFarTarget;
        [NMS(Index = 508)]
        /* 0x1500 */ public float HUDScaleMax;
        [NMS(Index = 506)]
        /* 0x1504 */ public float HUDScaleMin;
        [NMS(Index = 507)]
        /* 0x1508 */ public float HUDScaleMinAim;
        [NMS(Index = 505)]
        /* 0x150C */ public float HUDScaleRadius;
        [NMS(Index = 465)]
        /* 0x1510 */ public float HUDStoreFlashTime;
        [NMS(Index = 55)]
        /* 0x1514 */ public float IllegalTechProductTradingMod;
        [NMS(Index = 52)]
        /* 0x1518 */ public float InfestedPlanetDeepSpaceFlybyMultiplier;
        [NMS(Index = 71)]
        /* 0x151C */ public float InitialLocationProtectionRadiusMultiplier;
        [NMS(Index = 264)]
        /* 0x1520 */ public float InteractionAttractTime;
        [NMS(Index = 584)]
        /* 0x1524 */ public float InteractionComponentUpdateDistance;
        [NMS(Index = 265)]
        /* 0x1528 */ public float InteractionDescriptionTextTime;
        [NMS(Index = 263)]
        /* 0x152C */ public float InteractionMessageModuleDisplayTime;
        [NMS(Index = 260)]
        /* 0x1530 */ public float InteractionMinTimeBeforeHighlightedOptionSelection;
        [NMS(Index = 261)]
        /* 0x1534 */ public float InteractionMinTimeBetweenStickOptionHighlights;
        [NMS(Index = 266)]
        /* 0x1538 */ public float InteractionMinTimeForResponseText;
        [NMS(Index = 268)]
        /* 0x153C */ public GcInteractionType InteractionOverrideFrom;
        [NMS(Index = 269)]
        /* 0x1540 */ public GcInteractionType InteractionOverrideTo;
        [NMS(Index = 571)]
        /* 0x1544 */ public float InteractionPickupAngle;
        [NMS(Index = 572)]
        /* 0x1548 */ public float InteractionPickupRadius;
        [NMS(Index = 262)]
        /* 0x154C */ public float InteractionStickOptionStrength;
        [NMS(Index = 541)]
        /* 0x1550 */ public float InteractionTorchFoV;
        [NMS(Index = 542)]
        /* 0x1554 */ public float InteractionTorchStrength;
        [NMS(Index = 588)]
        /* 0x1558 */ public float JumpToCenterFuelCost;
        [NMS(Index = 577)]
        /* 0x155C */ public float LaserExplosionForce;
        [NMS(Index = 578)]
        /* 0x1560 */ public float LaserExplosionForceMaxForceRadius;
        [NMS(Index = 576)]
        /* 0x1564 */ public float LaserExplosionForceRadius;
        [NMS(Index = 12)]
        /* 0x1568 */ public int LaserRechargeHintThresholdEarly;
        [NMS(Index = 13)]
        /* 0x156C */ public int LaserRechargeHintThresholdLate;
        [NMS(Index = 595)]
        /* 0x1570 */ public float LightStrength;
        [NMS(Index = 470)]
        /* 0x1574 */ public float LineWidth;
        [NMS(Index = 471)]
        /* 0x1578 */ public float LockOffFactor;
        [NMS(Index = 345)]
        /* 0x157C */ public float LowSentinelProbability;
        [NMS(Index = 346)]
        /* 0x1580 */ public float LowSentinelProbabilitySurvival;
        [NMS(Index = 502)]
        /* 0x1584 */ public float MapFOV;
        [NMS(Index = 499)]
        /* 0x1588 */ public float MapHeight;
        [NMS(Index = 500)]
        /* 0x158C */ public float MapOffset;
        [NMS(Index = 503)]
        /* 0x1590 */ public float MapRadius;
        [NMS(Index = 501)]
        /* 0x1594 */ public float MapTargetOffset;
        [NMS(Index = 74)]
        /* 0x1598 */ public int MaxActiveWeatherHazardGifts;
        [NMS(Index = 120)]
        /* 0x159C */ public float MaxDistanceForLadderTeleport;
        [NMS(Index = 352)]
        /* 0x15A0 */ public int MaxDronesAggressive;
        [NMS(Index = 353)]
        /* 0x15A4 */ public int MaxDronesAggressiveSurvival;
        [NMS(Index = 348)]
        /* 0x15A8 */ public int MaxDronesLow;
        [NMS(Index = 349)]
        /* 0x15AC */ public int MaxDronesLowSurvival;
        [NMS(Index = 350)]
        /* 0x15B0 */ public int MaxDronesNormal;
        [NMS(Index = 351)]
        /* 0x15B4 */ public int MaxDronesNormalSurvival;
        [NMS(Index = 78)]
        /* 0x15B8 */ public float MaxMeteorSurfaceAngle;
        [NMS(Index = 259)]
        /* 0x15BC */ public int MaxNumMissionsFromMissionGiver;
        [NMS(Index = 195)]
        /* 0x15C0 */ public int MaxNumSameGroupTech;
        [NMS(Index = 234)]
        /* 0x15C4 */ public float MaxPossibleShipDamagePotential;
        [NMS(Index = 372)]
        /* 0x15C8 */ public int MaxResourceCrystalBlobSize;
        [NMS(Index = 617)]
        /* 0x15CC */ public float MaxRespawnOnGroundHeight;
        [NMS(Index = 493)]
        /* 0x15D0 */ public float MaxSpawnTime;
        [NMS(Index = 461)]
        /* 0x15D4 */ public float MaxStandingTechDiscount;
        [NMS(Index = 109)]
        /* 0x15D8 */ public int MaxTorpedoesInFlight;
        [NMS(Index = 14)]
        /* 0x15DC */ public int MeleeHintThresholdEarly;
        [NMS(Index = 15)]
        /* 0x15E0 */ public int MeleeHintThresholdLate;
        [NMS(Index = 324)]
        /* 0x15E4 */ public float MissileApproachTime;
        [NMS(Index = 318)]
        /* 0x15E8 */ public float MissileBrakeForceMax;
        [NMS(Index = 317)]
        /* 0x15EC */ public float MissileBrakeForceMin;
        [NMS(Index = 320)]
        /* 0x15F0 */ public float MissileBrakeTime;
        [NMS(Index = 316)]
        /* 0x15F4 */ public float MissileForceMax;
        [NMS(Index = 315)]
        /* 0x15F8 */ public float MissileForceMin;
        [NMS(Index = 321)]
        /* 0x15FC */ public float MissileHitRadius;
        [NMS(Index = 310)]
        /* 0x1600 */ public float MissileLockTime;
        [NMS(Index = 314)]
        /* 0x1604 */ public float MissileMaxSpeed;
        [NMS(Index = 309)]
        /* 0x1608 */ public float MissileMaxTurnAngle;
        [NMS(Index = 323)]
        /* 0x160C */ public float MissileMinCircleTime;
        [NMS(Index = 322)]
        /* 0x1610 */ public float MissileOffset;
        [NMS(Index = 311)]
        /* 0x1614 */ public float MissileReloadTime;
        [NMS(Index = 313)]
        /* 0x1618 */ public float MissileRotateMax;
        [NMS(Index = 312)]
        /* 0x161C */ public float MissileRotateMin;
        [NMS(Index = 325)]
        /* 0x1620 */ public float MissileRotateSpeed;
        [NMS(Index = 319)]
        /* 0x1624 */ public float MissileThreatTime;
        [NMS(Index = 231)]
        /* 0x1628 */ public float MissionEventAllowResetDistance;
        [NMS(Index = 138)]
        /* 0x162C */ public float MissionSurveyAutoScanDistance;
        [NMS(Index = 139)]
        /* 0x1630 */ public float MissionSurveyAutoScanFlattenRadiusMul;
        [NMS(Index = 134)]
        /* 0x1634 */ public float MissionSurveyBeginScanPercentageEvent;
        [NMS(Index = 133)]
        /* 0x1638 */ public float MissionSurveyBeginScanPercentageScannable;
        [NMS(Index = 145)]
        /* 0x163C */ public float MissionSurveyInShipArrivedDistance;
        [NMS(Index = 129)]
        /* 0x1640 */ public float MissionSurveyMarkerAutoHideTime;
        [NMS(Index = 143)]
        /* 0x1644 */ public float MissionSurveyMaxAngleOffset;
        [NMS(Index = 125)]
        /* 0x1648 */ public float MissionSurveyMaxGuidanceDistance;
        [NMS(Index = 126)]
        /* 0x164C */ public float MissionSurveyMaxGuidanceDistanceWorms;
        [NMS(Index = 131)]
        /* 0x1650 */ public float MissionSurveyMaxScanAngle;
        [NMS(Index = 132)]
        /* 0x1654 */ public float MissionSurveyMaxScanAngleScannableComp;
        [NMS(Index = 144)]
        /* 0x1658 */ public float MissionSurveyMaxSignalConeAngle;
        [NMS(Index = 137)]
        /* 0x165C */ public float MissionSurveyRevealWithoutScanDistance;
        [NMS(Index = 130)]
        /* 0x1660 */ public float MissionSurveyScanRangeMultiplier;
        [NMS(Index = 135)]
        /* 0x1664 */ public float MissionSurveyScanSpeed;
        [NMS(Index = 136)]
        /* 0x1668 */ public float MissionSurveyScanSpeedScannableComp;
        [NMS(Index = 141)]
        /* 0x166C */ public float MissionSurveySonarMaxPulseSpeed;
        [NMS(Index = 140)]
        /* 0x1670 */ public float MissionSurveySonarMinPulseSpeed;
        [NMS(Index = 142)]
        /* 0x1674 */ public float MissionSurveySonarPulseSpeedBandCount;
        [NMS(Index = 512)]
        /* 0x1678 */ public float MouseSensitivity;
        [NMS(Index = 513)]
        /* 0x167C */ public float MouseSensitivityShip;
        [NMS(Index = 514)]
        /* 0x1680 */ public float MouseSensitivityVehicle;
        [NMS(Index = 114)]
        /* 0x1684 */ public float MultidimensionalFadeTime;
        [NMS(Index = 334)]
        /* 0x1688 */ public float NewDiscoveryDisplayTime;
        [NMS(Index = 65)]
        /* 0x168C */ public int NexusRecipeCostNaniteMultiplier;
        [NMS(Index = 347)]
        /* 0x1690 */ public float NonAggressiveLushSurvivalProbabability;
        [NMS(Index = 610)]
        /* 0x1694 */ public int NonDominantRaceSpawnPercentage;
        [NMS(Index = 611)]
        /* 0x1698 */ public int NonDominantRaceSpawnPercentagePirate;
        [NMS(Index = 462)]
        /* 0x169C */ public float NonNaturalCostMul;
        [NMS(Index = 162)]
        /* 0x16A0 */ public float NormalModeHeatBonus;
        [NMS(Index = 6)]
        /* 0x16A4 */ public float NPCNavNodeSearchUpDistScaling;
        [NMS(Index = 24)]
        /* 0x16A8 */ public float NPCWaitWhenRevealedTime;
        [NMS(Index = 339)]
        /* 0x16AC */ public int NumMissionsPerSolarSystem;
        [NMS(Index = 472)]
        /* 0x16B0 */ public float OffscreenFadeDistance;
        [NMS(Index = 473)]
        /* 0x16B4 */ public float OffscreenMinDot;
        [NMS(Index = 170)]
        /* 0x16B8 */ public float OverheatDecay;
        [NMS(Index = 168)]
        /* 0x16BC */ public float OverheatGenerosity;
        [NMS(Index = 515)]
        /* 0x16C0 */ public float PainTime;
        [NMS(Index = 72)]
        /* 0x16C4 */ public float PartyPlanetSearchDistance;
        [NMS(Index = 653)]
        /* 0x16C8 */ public int PersonalInventoryMinHeightMax;
        [NMS(Index = 652)]
        /* 0x16CC */ public int PersonalInventoryMinWidthMax;
        [NMS(Index = 655)]
        /* 0x16D0 */ public int PersonalTechInventoryMinHeightMax;
        [NMS(Index = 654)]
        /* 0x16D4 */ public int PersonalTechInventoryMinWidthMax;
        [NMS(Index = 361)]
        /* 0x16D8 */ public float PirateEarlySpawnTime;
        [NMS(Index = 110)]
        /* 0x16DC */ public float PirateFreighterBattleNoTargetLeaderTime;
        [NMS(Index = 299)]
        /* 0x16E0 */ public float PirateFreighterBeginFleeHealthFraction;
        [NMS(Index = 296)]
        /* 0x16E4 */ public int PirateFreighterFrigateCountForReinforce;
        [NMS(Index = 302)]
        /* 0x16E8 */ public float PirateFreighterRewardDelayTime;
        [NMS(Index = 304)]
        /* 0x16EC */ public float PirateFreighterRewardDelayTimeEscaped;
        [NMS(Index = 303)]
        /* 0x16F0 */ public float PirateFreighterRewardMessageDelayTime;
        [NMS(Index = 305)]
        /* 0x16F4 */ public float PirateFreighterRewardMessageDelayTimeEscaped;
        [NMS(Index = 298)]
        /* 0x16F8 */ public float PirateFreighterWarpChargeTime;
        [NMS(Index = 297)]
        /* 0x16FC */ public float PirateFreighterWarpChargeTimeToAddPerBrokenEngine;
        [NMS(Index = 42)]
        /* 0x1700 */ public float PirateGroundAccelerator;
        [NMS(Index = 43)]
        /* 0x1704 */ public float PirateGroundInventoryAccelerator;
        [NMS(Index = 281)]
        /* 0x1708 */ public float PirateInterestDistance;
        [NMS(Index = 282)]
        /* 0x170C */ public float PirateInterestDistanceMPMission;
        [NMS(Index = 280)]
        /* 0x1710 */ public int PirateInterestOverride;
        [NMS(Index = 41)]
        /* 0x1714 */ public float PirateRaidAccelerator;
        [NMS(Index = 279)]
        /* 0x1718 */ public int PlanetPirateFlybyMaxRepeatCounter;
        [NMS(Index = 564)]
        /* 0x171C */ public float PlayerAmbientSpotLightIntensity;
        [NMS(Index = 566)]
        /* 0x1720 */ public float PlayerAmbientSpotLightOffsetY;
        [NMS(Index = 567)]
        /* 0x1724 */ public float PlayerAmbientSpotLightOffsetZ;
        [NMS(Index = 49)]
        /* 0x1728 */ public float PoliceAcceleratorNoCargoNormal;
        [NMS(Index = 50)]
        /* 0x172C */ public float PoliceAcceleratorNoCargoSkipScanOdds;
        [NMS(Index = 48)]
        /* 0x1730 */ public float PoliceAcceleratorNoCargoWealthy;
        [NMS(Index = 45)]
        /* 0x1734 */ public float PoliceAcceleratorPulseExtra;
        [NMS(Index = 46)]
        /* 0x1738 */ public int PoliceAcceleratorSmugglingItemsMax;
        [NMS(Index = 47)]
        /* 0x173C */ public float PoliceAcceleratorSmugglingMulMax;
        [NMS(Index = 44)]
        /* 0x1740 */ public float PoliceAcceleratorStationLockOn;
        [NMS(Index = 286)]
        /* 0x1744 */ public float PoliceInterestDistance;
        [NMS(Index = 287)]
        /* 0x1748 */ public float PoliceInterestDistanceMPMission;
        [NMS(Index = 285)]
        /* 0x174C */ public int PoliceInterestOverride;
        [NMS(Index = 604)]
        /* 0x1750 */ public int ProductItemStockDecayTime;
        [NMS(Index = 605)]
        /* 0x1754 */ public int ProductItemStockReplenishTime;
        [NMS(Index = 342)]
        /* 0x1758 */ public float ProjectileLightIntensity;
        [NMS(Index = 469)]
        /* 0x175C */ public float ProjectileSpeedBoost;
        [NMS(Index = 638)]
        /* 0x1760 */ public float PulseEncounterChance;
        [NMS(Index = 642)]
        /* 0x1764 */ public float PulseEncounterChanceBlue;
        [NMS(Index = 641)]
        /* 0x1768 */ public float PulseEncounterChanceGreen;
        [NMS(Index = 640)]
        /* 0x176C */ public float PulseEncounterChanceRed;
        [NMS(Index = 639)]
        /* 0x1770 */ public float PulseEncounterChanceStandard;
        [NMS(Index = 637)]
        /* 0x1774 */ public float PulseEncounterCheckTimer;
        [NMS(Index = 643)]
        /* 0x1778 */ public float PulseEncounterStopPower;
        [NMS(Index = 644)]
        /* 0x177C */ public float PulseEncounterStopSpeed;
        [NMS(Index = 377)]
        /* 0x1780 */ public int RareProductEffectiveness;
        [NMS(Index = 375)]
        /* 0x1784 */ public int RareSubstanceEffectiveness;
        [NMS(Index = 177)]
        /* 0x1788 */ public int RefinerProductsMadeInTime;
        [NMS(Index = 179)]
        /* 0x178C */ public int RefinerProductsMadeInTimeSurvival;
        [NMS(Index = 178)]
        /* 0x1790 */ public int RefinerSubsMadeInTime;
        [NMS(Index = 180)]
        /* 0x1794 */ public int RefinerSubsMadeInTimeSurvival;
        [NMS(Index = 386)]
        /* 0x1798 */ public int ResourceCommonMaxAmount;
        [NMS(Index = 385)]
        /* 0x179C */ public int ResourceCommonMinAmount;
        [NMS(Index = 384)]
        /* 0x17A0 */ public int ResourceCommonReducer;
        [NMS(Index = 389)]
        /* 0x17A4 */ public int ResourceDirtMaxAmount;
        [NMS(Index = 388)]
        /* 0x17A8 */ public int ResourceDirtMinAmount;
        [NMS(Index = 387)]
        /* 0x17AC */ public int ResourceDirtReducer;
        [NMS(Index = 383)]
        /* 0x17B0 */ public int ResourceMaxAmount;
        [NMS(Index = 382)]
        /* 0x17B4 */ public int ResourceMinAmount;
        [NMS(Index = 497)]
        /* 0x17B8 */ public int ResourceParticleMaxNum;
        [NMS(Index = 498)]
        /* 0x17BC */ public int ResourceParticleMinNum;
        [NMS(Index = 495)]
        /* 0x17C0 */ public float ResourceParticleSpeed;
        [NMS(Index = 496)]
        /* 0x17C4 */ public float ResourceParticleSpread;
        [NMS(Index = 381)]
        /* 0x17C8 */ public int ResourceReducer;
        [NMS(Index = 34)]
        /* 0x17CC */ public int RocketLockerFuelUse;
        [NMS(Index = 628)]
        /* 0x17D0 */ public float SalvageShipExplodeShipDistance;
        [NMS(Index = 624)]
        /* 0x17D4 */ public float SalvageShipExplodeSpeed;
        [NMS(Index = 623)]
        /* 0x17D8 */ public float SalvageShipHeightOffset;
        [NMS(Index = 629)]
        /* 0x17DC */ public float SalvageShipOneRevolutionTime;
        [NMS(Index = 622)]
        /* 0x17E0 */ public float SalvageShipPitch;
        [NMS(Index = 627)]
        /* 0x17E4 */ public float SalvageShipShowShipDistance;
        [NMS(Index = 625)]
        /* 0x17E8 */ public float SalvageShipShowShipSpeed;
        [NMS(Index = 626)]
        /* 0x17EC */ public float SalvageShipShowShipSpeedSwitching;
        [NMS(Index = 99)]
        /* 0x17F0 */ public int SalvageSubstanceValueThreshold;
        [NMS(Index = 98)]
        /* 0x17F4 */ public float SalvageValueAsProds;
        [NMS(Index = 631)]
        /* 0x17F8 */ public float SalvageWeaponHeightOffset;
        [NMS(Index = 633)]
        /* 0x17FC */ public float SalvageWeaponMaxSize;
        [NMS(Index = 630)]
        /* 0x1800 */ public float SalvageWeaponPitch;
        [NMS(Index = 632)]
        /* 0x1804 */ public float SalvageWeaponScale;
        [NMS(Index = 333)]
        /* 0x1808 */ public float ScanAngle;
        [NMS(Index = 399)]
        /* 0x180C */ public float ScanAngleCutoff;
        [NMS(Index = 229)]
        /* 0x1810 */ public float ScannableComponentMarkerOffset;
        [NMS(Index = 230)]
        /* 0x1814 */ public float ScannableComponentPlaceMarkerOffset;
        [NMS(Index = 450)]
        /* 0x1818 */ public float ScannerAnalyzeFXRate;
        [NMS(Index = 228)]
        /* 0x181C */ public float ScannerIconsClumpRadius;
        [NMS(Index = 447)]
        /* 0x1820 */ public float ScannerMarkerFadeTime;
        [NMS(Index = 449)]
        /* 0x1824 */ public float ScannerPhysicsProbeAABBSize;
        [NMS(Index = 448)]
        /* 0x1828 */ public float ScannerSmallMarkerFadeTime;
        [NMS(Index = 451)]
        /* 0x182C */ public float ScannerSubstanceTimePerTrigger;
        [NMS(Index = 452)]
        /* 0x1830 */ public float ScannerTuningA;
        [NMS(Index = 453)]
        /* 0x1834 */ public float ScannerTuningB;
        [NMS(Index = 454)]
        /* 0x1838 */ public float ScannerTuningC;
        [NMS(Index = 455)]
        /* 0x183C */ public float ScannerTuningD;
        [NMS(Index = 456)]
        /* 0x1840 */ public float ScannerTuningResourceOffset1;
        [NMS(Index = 457)]
        /* 0x1844 */ public float ScannerTuningResourceOffset2;
        [NMS(Index = 458)]
        /* 0x1848 */ public float ScannerTuningSmoothStepAmount;
        [NMS(Index = 459)]
        /* 0x184C */ public float ScannerTuningTrailingEdge;
        [NMS(Index = 326)]
        /* 0x1850 */ public float ScanStartTimeDelayMinDist;
        [NMS(Index = 327)]
        /* 0x1854 */ public float ScanStartTimeDelayRange;
        [NMS(Index = 328)]
        /* 0x1858 */ public float ScanStartTimeDistanceDelayTime;
        [NMS(Index = 329)]
        /* 0x185C */ public float ScanStickyDecay;
        [NMS(Index = 21)]
        /* 0x1860 */ public float ScanToRevealDelayOverride;
        [NMS(Index = 25)]
        /* 0x1864 */ public float ScanToRevealVFXBaseScalingSize;
        [NMS(Index = 616)]
        /* 0x1868 */ public float ScrapDroneProbability;
        [NMS(Index = 183)]
        /* 0x186C */ public float SeasonalMessageModuleAttractDistanceMul;
        [NMS(Index = 366)]
        /* 0x1870 */ public int SentinelsHigh;
        [NMS(Index = 367)]
        /* 0x1874 */ public int SentinelsLow;
        [NMS(Index = 3)]
        /* 0x1878 */ public float ShipBuilderInteractionBuildEffectTime;
        [NMS(Index = 4)]
        /* 0x187C */ public float ShipBuilderInteractionDissolveEffectTime;
        [NMS(Index = 92)]
        /* 0x1880 */ public float ShipBulletTraceLineWidth;
        [NMS(Index = 600)]
        /* 0x1884 */ public float ShipDisplayDamageMultiplier;
        [NMS(Index = 397)]
        /* 0x1888 */ public float ShipInteractRadius;
        [NMS(Index = 51)]
        /* 0x188C */ public float ShipInterestAcceleratorInAsteroidField;
        [NMS(Index = 657)]
        /* 0x1890 */ public int ShipInventoryMinHeightMax;
        [NMS(Index = 656)]
        /* 0x1894 */ public int ShipInventoryMinWidthMax;
        [NMS(Index = 53)]
        /* 0x1898 */ public float ShipMiningMul;
        [NMS(Index = 444)]
        /* 0x189C */ public float ShipScanOffset;
        [NMS(Index = 445)]
        /* 0x18A0 */ public float ShipScanOffsetGap;
        [NMS(Index = 66)]
        /* 0x18A4 */ public float ShipScanPlanetRechargeMultiplier;
        [NMS(Index = 67)]
        /* 0x18A8 */ public float ShipScanSpaceRechargeMultiplier;
        [NMS(Index = 659)]
        /* 0x18AC */ public int ShipTechInventoryMinHeightMax;
        [NMS(Index = 658)]
        /* 0x18B0 */ public int ShipTechInventoryMinWidthMax;
        [NMS(Index = 198)]
        /* 0x18B4 */ public float ShootableAggroForgetTime;
        [NMS(Index = 197)]
        /* 0x18B8 */ public float ShootableAggroMinStartTime;
        [NMS(Index = 196)]
        /* 0x18BC */ public float ShootableArmourHighlightHitTime;
        [NMS(Index = 570)]
        /* 0x18C0 */ public float SimpleInteractionMessageTime;
        [NMS(Index = 568)]
        /* 0x18C4 */ public float SimpleInteractionPickupAngle;
        [NMS(Index = 569)]
        /* 0x18C8 */ public float SimpleInteractionPickupRadius;
        [NMS(Index = 54)]
        /* 0x18CC */ public float SmugglerSellingMarkup;
        [NMS(Index = 294)]
        /* 0x18D0 */ public float SpaceBattleAnyHostileShipsRadius;
        [NMS(Index = 300)]
        /* 0x18D4 */ public int SpaceBattleMaxTorpedosTargetingLeaderShip;
        [NMS(Index = 301)]
        /* 0x18D8 */ public int SpaceBattleMaxTorpedosTargetingNonLeaderShip;
        [NMS(Index = 293)]
        /* 0x18DC */ public float SpaceBattleRadius;
        [NMS(Index = 290)]
        /* 0x18E0 */ public float SpaceCombatRadius;
        [NMS(Index = 533)]
        /* 0x18E4 */ public float SpaceSpeedReadoutMultiplier;
        [NMS(Index = 647)]
        /* 0x18E8 */ public float SpawnerWeaponRange;
        [NMS(Index = 273)]
        /* 0x18EC */ public int SpecialMiningAmount;
        [NMS(Index = 274)]
        /* 0x18F0 */ public float SpecialMiningTime;
        [NMS(Index = 33)]
        /* 0x18F4 */ public float SpecialTechSlotBonus;
        [NMS(Index = 532)]
        /* 0x18F8 */ public float SpeedReadoutMultiplier;
        [NMS(Index = 80)]
        /* 0x18FC */ public float StormBonusJetpackMod;
        [NMS(Index = 84)]
        /* 0x1900 */ public GcPlayerHazardType StormBonusJetpackWeather;
        [NMS(Index = 83)]
        /* 0x1904 */ public float StormBonusMiningAmountMod;
        [NMS(Index = 87)]
        /* 0x1908 */ public GcPlayerHazardType StormBonusMiningAmountWeather;
        [NMS(Index = 82)]
        /* 0x190C */ public float StormBonusMiningHeatMod;
        [NMS(Index = 86)]
        /* 0x1910 */ public GcPlayerHazardType StormBonusMiningHeatWeather;
        [NMS(Index = 81)]
        /* 0x1914 */ public float StormBonusSprintMod;
        [NMS(Index = 85)]
        /* 0x1918 */ public GcPlayerHazardType StormBonusSprintWeather;
        [NMS(Index = 79)]
        /* 0x191C */ public float StormGravityChangeTime;
        [NMS(Index = 606)]
        /* 0x1920 */ public int SubstanceItemStockDecayTime;
        [NMS(Index = 607)]
        /* 0x1924 */ public int SubstanceItemStockReplenishTime;
        [NMS(Index = 146)]
        /* 0x1928 */ public float SurveyBeginScanPercentage;
        [NMS(Index = 154)]
        /* 0x192C */ public float SurveyMaxDistance;
        [NMS(Index = 148)]
        /* 0x1930 */ public float SurveyScanMaxSpeed;
        [NMS(Index = 147)]
        /* 0x1934 */ public float SurveyScanMinSpeed;
        [NMS(Index = 151)]
        /* 0x1938 */ public float SurveySonarMaxPulseSpeed;
        [NMS(Index = 153)]
        /* 0x193C */ public float SurveySonarMiddleRangeMax;
        [NMS(Index = 152)]
        /* 0x1940 */ public float SurveySonarMiddleRangeMin;
        [NMS(Index = 150)]
        /* 0x1944 */ public float SurveySonarMinPulseSpeed;
        [NMS(Index = 149)]
        /* 0x1948 */ public float SurveySonarPulseSpeedBandCount;
        [NMS(Index = 240)]
        /* 0x194C */ public float TapInteractionDecay;
        [NMS(Index = 239)]
        /* 0x1950 */ public float TapInteractionIncreaseAmount;
        [NMS(Index = 37)]
        /* 0x1954 */ public float TechDamageChanceShieldedMax;
        [NMS(Index = 39)]
        /* 0x1958 */ public float TechDamageChanceShieldLevelMax;
        [NMS(Index = 38)]
        /* 0x195C */ public float TechDamageChanceShieldLevelMin;
        [NMS(Index = 40)]
        /* 0x1960 */ public float TechDamageChanceToSelectPrimary;
        [NMS(Index = 77)]
        /* 0x1964 */ public GcTechnologyCategory TechnologyOverrideForSmuggler;
        [NMS(Index = 115)]
        /* 0x1968 */ public float TeleporterDistanceTravelledMultiplier;
        [NMS(Index = 213)]
        /* 0x196C */ public float TerrainResourceCompassRange;
        [NMS(Index = 212)]
        /* 0x1970 */ public float TerrainResourceScanRange;
        [NMS(Index = 211)]
        /* 0x1974 */ public float TerrainResourceScanTime;
        [NMS(Index = 412)]
        /* 0x1978 */ public float TimeToDisplayScanResults;
        [NMS(Index = 535)]
        /* 0x197C */ public int TorchCookieIndex;
        [NMS(Index = 538)]
        /* 0x1980 */ public int TorchDimCookieIndex;
        [NMS(Index = 539)]
        /* 0x1984 */ public float TorchDimFoV;
        [NMS(Index = 540)]
        /* 0x1988 */ public float TorchDimStrength;
        [NMS(Index = 561)]
        /* 0x198C */ public float TorchFollowCameraPitch;
        [NMS(Index = 562)]
        /* 0x1990 */ public float TorchFollowCameraTime;
        [NMS(Index = 536)]
        /* 0x1994 */ public float TorchFoV;
        [NMS(Index = 556)]
        /* 0x1998 */ public float TorchHandOffsetX;
        [NMS(Index = 557)]
        /* 0x199C */ public float TorchHandOffsetY;
        [NMS(Index = 558)]
        /* 0x19A0 */ public float TorchHandOffsetZ;
        [NMS(Index = 547)]
        /* 0x19A4 */ public float TorchOffsetX;
        [NMS(Index = 548)]
        /* 0x19A8 */ public float TorchOffsetY;
        [NMS(Index = 550)]
        /* 0x19AC */ public float TorchOffsetZ;
        [NMS(Index = 549)]
        /* 0x19B0 */ public float TorchOffsetZMin;
        [NMS(Index = 555)]
        /* 0x19B4 */ public float TorchOffsetZMinSpeed;
        [NMS(Index = 554)]
        /* 0x19B8 */ public float TorchOffsetZSpeedRange;
        [NMS(Index = 560)]
        /* 0x19BC */ public float TorchRotation;
        [NMS(Index = 551)]
        /* 0x19C0 */ public float TorchStaffOffsetY;
        [NMS(Index = 553)]
        /* 0x19C4 */ public float TorchStaffOffsetZ;
        [NMS(Index = 552)]
        /* 0x19C8 */ public float TorchStaffOffsetZMin;
        [NMS(Index = 537)]
        /* 0x19CC */ public float TorchStrength;
        [NMS(Index = 108)]
        /* 0x19D0 */ public float TorpedoCooldown;
        [NMS(Index = 112)]
        /* 0x19D4 */ public float TorpedoCooldownRandomExtra;
        [NMS(Index = 111)]
        /* 0x19D8 */ public float TorpedoInitialWait;
        [NMS(Index = 113)]
        /* 0x19DC */ public float TorpedoLaunchWarning;
        [NMS(Index = 379)]
        /* 0x19E0 */ public int TunnelStatReducer;
        [NMS(Index = 16)]
        /* 0x19E4 */ public float TurretAITargetingDistanceFactor;
        [NMS(Index = 20)]
        /* 0x19E8 */ public float TurretAITargetingFocusPlayerFactor;
        [NMS(Index = 19)]
        /* 0x19EC */ public float TurretAITargetingLastHitFactor;
        [NMS(Index = 17)]
        /* 0x19F0 */ public float TurretAITargetingPitchAngleFactor;
        [NMS(Index = 18)]
        /* 0x19F4 */ public float TurretAITargetingYawAngleFactor;
        [NMS(Index = 543)]
        /* 0x19F8 */ public float UndergroundTorchFoV;
        [NMS(Index = 544)]
        /* 0x19FC */ public float UndergroundTorchFoVFar;
        [NMS(Index = 545)]
        /* 0x1A00 */ public float UndergroundTorchStrength;
        [NMS(Index = 546)]
        /* 0x1A04 */ public float UndergroundTorchStrengthFar;
        [NMS(Index = 73)]
        /* 0x1A08 */ public float UnderwaterLightningDamageDistanceMultiplier;
        [NMS(Index = 93)]
        /* 0x1A0C */ public float VehicleAllIconScanTime;
        [NMS(Index = 661)]
        /* 0x1A10 */ public int VehicleInventoryMinHeightMax;
        [NMS(Index = 660)]
        /* 0x1A14 */ public int VehicleInventoryMinWidthMax;
        [NMS(Index = 613)]
        /* 0x1A18 */ public float ViciousSentinelProbability;
        [NMS(Index = 614)]
        /* 0x1A1C */ public float ViciousStormProbability;
        [NMS(Index = 615)]
        /* 0x1A20 */ public float ViciousWeatherProbability;
        [NMS(Index = 380)]
        /* 0x1A24 */ public float VoxelAsteroidResourceChance;
        [NMS(Index = 291)]
        /* 0x1A28 */ public int WarpsBetweenBattles;
        [NMS(Index = 589)]
        /* 0x1A2C */ public int WarpsBetweenMiniStation;
        [NMS(Index = 336)]
        /* 0x1A30 */ public float WaterLandingDamageMultiplier;
        [NMS(Index = 374)]
        /* 0x1A34 */ public float WaypointScanTime;
        [NMS(Index = 663)]
        /* 0x1A38 */ public int WeaponInventoryMinHeightMax;
        [NMS(Index = 662)]
        /* 0x1A3C */ public int WeaponInventoryMinWidthMax;
        [NMS(Index = 76)]
        /* 0x1A40 */ public float WeatherHazardGiftLifeTime;
        [NMS(Index = 75)]
        /* 0x1A44 */ public float WeatherHazardGiftMaxDistance;
        [NMS(Index = 411)]
        /* 0x1A48 */ public float ZoomFindBuildingRange;
        [NMS(Index = 394)]
        /* 0x1A4C */ public NMSString0x20 DepotResource;
        [NMS(Index = 393)]
        /* 0x1A6C */ public NMSString0x20 RobotResource;
        [NMS(Index = 191)]
        /* 0x1A8C */ public bool AllowBinocularMarker;
        [NMS(Index = 190)]
        /* 0x1A8D */ public bool AllowDeconstruct;
        [NMS(Index = 160)]
        /* 0x1A8E */ public bool AllowSpaceScanEvents;
        [NMS(Index = 206)]
        /* 0x1A8F */ public TkCurveType AtmosphereEntryCurve;
        [NMS(Index = 460)]
        /* 0x1A90 */ public bool Autolevel;
        [NMS(Index = 214)]
        /* 0x1A91 */ public bool BinocsDisplayUnknownCreatures;
        [NMS(Index = 221)]
        /* 0x1A92 */ public TkCurveType BinocularScanTargetHeightCurve;
        [NMS(Index = 161)]
        /* 0x1A93 */ public bool CanMoveTechnology;
        [NMS(Index = 602)]
        /* 0x1A94 */ public bool ChangePricesLocally;
        [NMS(Index = 531)]
        /* 0x1A95 */ public bool DebugDrawTriggerBoxes;
        [NMS(Index = 32)]
        /* 0x1A96 */ public bool DebugPrintShootables;
        [NMS(Index = 442)]
        /* 0x1A97 */ public bool DebugScanForceBuilding;
        [NMS(Index = 189)]
        /* 0x1A98 */ public bool DisableAnomalyAmbientSpawn;
        [NMS(Index = 597)]
        /* 0x1A99 */ public bool DisableBasePowerHUDOverlay;
        [NMS(Index = 157)]
        /* 0x1A9A */ public bool DisableGalaxyMapInQuickMenu;
        [NMS(Index = 158)]
        /* 0x1A9B */ public bool DisableNexusInQuickMenu;
        [NMS(Index = 2)]
        /* 0x1A9C */ public bool DoShipBuilderInteractionBuildEffect;
        [NMS(Index = 5)]
        /* 0x1A9D */ public bool DoShipBuilderInteractionBuildEffectOutward;
        [NMS(Index = 194)]
        /* 0x1A9E */ public bool EnableShootHitEffect;
        [NMS(Index = 35)]
        /* 0x1A9F */ public bool EnableTechPackaging;
        [NMS(Index = 159)]
        /* 0x1AA0 */ public bool EnableTeleporters;
        [NMS(Index = 192)]
        /* 0x1AA1 */ public bool EveryMaintenanceIsBroken;
        [NMS(Index = 335)]
        /* 0x1AA2 */ public bool FailToFindBuildings;
        [NMS(Index = 188)]
        /* 0x1AA3 */ public bool FreighterRequiresRGBHyperdriveUpgrades;
        [NMS(Index = 474)]
        /* 0x1AA4 */ public bool HUDUpdateFromData;
        [NMS(Index = 187)]
        /* 0x1AA5 */ public bool InstallTechWithInteraction;
        [NMS(Index = 267)]
        /* 0x1AA6 */ public bool InteractionOverride;
        [NMS(Index = 598)]
        /* 0x1AA7 */ public bool KeepAttackingMaxWantedLevel;
        [NMS(Index = 124)]
        /* 0x1AA8 */ public bool MissionSurveySuggestSurveyForNearScannables;
        [NMS(Index = 176)]
        /* 0x1AA9 */ public TkCurveType OverheatColourCurve;
        [NMS(Index = 175)]
        /* 0x1AAA */ public TkCurveType OverheatColourCurveShip;
        [NMS(Index = 171)]
        /* 0x1AAB */ public TkCurveType OverheatCurve;
        [NMS(Index = 516)]
        /* 0x1AAC */ public TkCurveType PainCurve;
        [NMS(Index = 492)]
        /* 0x1AAD */ public bool PlayHitEffectsOnZeroDamage;
        [NMS(Index = 7)]
        /* 0x1AAE */ public bool RewardInventoryClassItemFromShipSalvage;
        [NMS(Index = 22)]
        /* 0x1AAF */ public bool ScanToRevealIgnoreRequirements;
        [NMS(Index = 23)]
        /* 0x1AB0 */ public bool ScanToRevealNPCsAlwaysTriggersCameraEvent;
        [NMS(Index = 446)]
        /* 0x1AB1 */ public TkCurveType ShipScanCurve;
        [NMS(Index = 603)]
        /* 0x1AB2 */ public bool ShowPriceMarkupsAsPercentages;
        [NMS(Index = 193)]
        /* 0x1AB3 */ public bool SpawnResourceBlobsOnPartDelete;
        [NMS(Index = 31)]
        /* 0x1AB4 */ public bool TechMustBeInTechInventory;
        [NMS(Index = 559)]
        /* 0x1AB5 */ public bool TorchDisabledInTheDay;
        [NMS(Index = 650)]
        /* 0x1AB6 */ public bool UseCustomSaveDirectory;
        [NMS(Index = 441)]
        /* 0x1AB7 */ public bool UseDebugScan;
        [NMS(Index = 599)]
        /* 0x1AB8 */ public bool UseMultiplierBonus;
        [NMS(Index = 172)]
        /* 0x1AB9 */ public bool UseOverheatColour;
        [NMS(Index = 30)]
        /* 0x1ABA */ public bool UseSecondaryBiomeSubstances;
        [NMS(Index = 601)]
        /* 0x1ABB */ public bool UseTradingCostTable;
    }
}
