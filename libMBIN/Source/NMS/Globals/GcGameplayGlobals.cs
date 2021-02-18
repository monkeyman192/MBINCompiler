using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x1DF0, GUID = 0x085A5211674820B3)]
    public class GcGameplayGlobals : NMSTemplate
    {
        /* 0x0000 */ public GcTechnologyCategory TechnologyOverrideForSmuggler;
        /* 0x0004 */ public float MaxMeteorSurfaceAngle;
        /* 0x0008 */ public float StormGravityChangeTime;
        /* 0x000C */ public float StormBonusJetpackMod;
        /* 0x0010 */ public float StormBonusSprintMod;
        /* 0x0014 */ public float StormBonusMiningHeatMod;
        /* 0x0018 */ public float StormBonusMiningAmountMod;
        /* 0x001C */ public GcPlayerHazardType StormBonusJetpackWeather;
        /* 0x0020 */ public GcPlayerHazardType StormBonusSprintWeather;
        /* 0x0024 */ public GcPlayerHazardType StormBonusMiningHeatWeather;
        /* 0x0028 */ public GcPlayerHazardType StormBonusMiningAmountWeather;
        /* 0x002C */ public float AlienPodThreshold2;
        /* 0x0030 */ public float AlienPodThreshold1;  // Yes... these are the order in the exe...
        /* 0x0040 */ public Colour BulletTraceLineColour;
        /* 0x0050 */ public float BulletTraceLineWidth;
        /* 0x0054 */ public float TracerBeamStart;
        /* 0x0058 */ public float TracerBeamEnd;
        /* 0x005C */ public float VehicleAllIconScanTime;
        /* 0x0060 */ public int GPSRandomChangeTimeWide;
        /* 0x0064 */ public int GPSRandomChangeTimeMid;
        /* 0x0068 */ public int GPSRandomChangeTimeNarrow;
        /* 0x006C */ public float SalvageValueAsProds;
        /* 0x0070 */ public int SalvageSubstanceValueThreshold;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0074 */ public byte[] Padding74;
        [NMS(Size = 0x4)]
        /* 0x0078 */ public NMSString0x10[] SalvageRewardsShuttle;
        [NMS(Size = 0x4)]
        /* 0x00B8 */ public NMSString0x10[] SalvageRewardsDropship;
        [NMS(Size = 0x4)]
        /* 0x00F8 */ public NMSString0x10[] SalvageRewardsFighter;
        [NMS(Size = 0x4)]
        /* 0x0138 */ public NMSString0x10[] SalvageRewardsScience;
        [NMS(Size = 0xA)]
        /* 0x0178 */ public NMSString0x10[] SalvageTechList;
        [NMS(Size = 0xC)]
        /* 0x0218 */ public NMSString0x10[] SalvageProdsList;
        [NMS(Size = 0x7)]
        /* 0x02D8 */ public NMSString0x10[] SalvageSubstancesList;
        /* 0x0348 */ public bool AlwaysSpaceBattle;
        /* 0x034C */ public float MultidimensionalFadeTime;
        /* 0x0350 */ public float TeleporterDistanceTravelledMultiplier;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x0354 */ public byte[] Padding354;
        /* 0x0360 */ public GcScanEffectData BinocularSelectedEffect;
        /* 0x03B0 */ public Colour BinocularSelectedColour;
        /* 0x03C0 */ public Colour BinocularSelectedUnknownColour;
        /* 0x03D0 */ public float CockpitScale;
        /* 0x03D4 */ public float MaxDistanceForLadderTeleport;
        /* 0x03D8 */ public float AngleFromBaseComputerWhenTeleporting;
        /* 0x03DC */ public float DistanceFromBaseComputerWhenTeleporting;
        /* 0x03E0 */ public float AutoTranslateWordChance;
        /* 0x03E4 */ public float MissionSurveryDistanceToHideDistanceLabel;
        /* 0x03E8 */ public float MissionSurveyMarkerAutoHideTime;
        /* 0x03EC */ public float MissionSurveyScanRangeMultiplier;
        /* 0x03F0 */ public float MissionSurveyMaxScanAngle;
        /* 0x03F4 */ public float MissionSurveyBeginScanPercentageScannable;
        /* 0x03F8 */ public float MissionSurveyBeginScanPercentageEvent;
        /* 0x03FC */ public float MissionSurveyScanSpeed;
        /* 0x0400 */ public float MissionSurveyAutoScanDistance;
        /* 0x0404 */ public float MissionSurveySonarMinPulseSpeed;
        /* 0x0408 */ public float MissionSurveySonarMaxPulseSpeed;
        /* 0x040C */ public float MissionSurveySonarPulseSpeedBandCount;
        /* 0x0410 */ public float MissionSurveyMaxAngleOffset;
        /* 0x0414 */ public float MissionSurveyMaxSignalConeAngle;
        /* 0x0418 */ public float SurveyBeginScanPercentage;
        /* 0x041C */ public float SurveyScanMinSpeed;
        /* 0x0420 */ public float SurveyScanMaxSpeed;
        /* 0x0424 */ public float SurveySonarPulseSpeedBandCount;
        /* 0x0428 */ public float SurveySonarMinPulseSpeed;
        /* 0x042C */ public float SurveySonarMaxPulseSpeed;
        /* 0x0430 */ public float SurveySonarMiddleRangeMin;
        /* 0x0434 */ public float SurveySonarMiddleRangeMax;
        /* 0x0438 */ public float SurveyMaxDistance;
        /* 0x043C */ public int CreaturesToBaitForTutorial;
        /* 0x0440 */ public int CreaturesToFeedForTutorial;
        /* 0x0444 */ public bool DisableGalaxyMapInQuickMenu;
        /* 0x0445 */ public bool DisableNexusInQuickMenu;
        /* 0x0446 */ public bool EnableTeleporters;
        /* 0x0447 */ public bool AllowSpaceScanEvents;
        /* 0x0448 */ public bool CanMoveTechnology;
        /* 0x044C */ public float NormalModeHeatBonus;
        /* 0x0450 */ public float BaseLaserHeatTime;
        /* 0x0454 */ public float HeatAlertTime;
        /* 0x0458 */ public float HeatAlertTimeSurvival;
        /* 0x045C */ public float HeatDamageBoost;
        /* 0x0460 */ public float HeatWidthBoost;
        /* 0x0464 */ public float HeatWidthBoostAlt;
        /* 0x0468 */ public float OverheatGenerosity;
        /* 0x046C */ public float HeatMaxPowerPoint;
        /* 0x0470 */ public float HeatMaxPowerPointSurvival;
        /* 0x0474 */ public float OverheatDecay;
        /* 0x0478 */ public float OverheatDecaySurvival;
        /* 0x047C */ public TkCurveType OverheatCurve;
        /* 0x0480 */ public TkCurveType OverheatCurveSurvival;
        /* 0x0484 */ public bool UseOverheatColour;
        /* 0x0490 */ public Colour OverHeatColour;
        /* 0x04A0 */ public Colour OverHeatBarColour;
        /* 0x04B0 */ public Colour OverHeatColourSurvival;
        /* 0x04C0 */ public TkCurveType OverheatColourCurve;
        /* 0x04C4 */ public TkCurveType OverheatColourCurveSurvival;
        /* 0x04C8 */ public int RefinerProductsMadeInTime;
        /* 0x04CC */ public int RefinerSubsMadeInTime;
        /* 0x04D0 */ public int RefinerProductsMadeInTimeSurvival;
        /* 0x04D4 */ public int RefinerSubsMadeInTimeSurvival;
        [NMS(Size = 0x3)]
        /* 0x04D8 */ public NMSString0x10[] HyperdriveAccess;
        [NMS(Size = 0x3)]
        /* 0x0508 */ public NMSString0x10[] FreighterHyperdriveAccess;
        /* 0x0538 */ public float HmdInteractionRangeMinRange;
        /* 0x053C */ public float HmdInteractionRangeMinDistance;
        /* 0x0540 */ public float HmdInteractionRangeMultiplier;
        [NMSDescription("Set to False to revert to legacy method of installing technologies and upgrades")]
        /* 0x0544 */ public bool InstallTechWithInteraction;
        /* 0x0545 */ public bool FreighterRequiresRGBHyperdriveUpgrades;
        /* 0x0546 */ public bool DisableAnomalyAmbientSpawn;
        /* 0x0547 */ public bool AllowDeconstruct;
        /* 0x0548 */ public bool AllowBinocularMarker;
        /* 0x0549 */ public bool EveryMaintenanceIsBroken;
        /* 0x054A */ public bool SpawnResourceBlobsOnPartDelete;
        /* 0x054B */ public bool EnableShootHitEffect;
        /* 0x054C */ public int MaxNumSameGroupTech;
        /* 0x0550 */ public float ShootableArmourHighlightHitTime;
        /* 0x0554 */ public float ShootableAggroMinStartTime;
        /* 0x0558 */ public float ShootableAggroForgetTime;
        /* 0x0560 */ public Colour RefinerColour1A;
        /* 0x0570 */ public Colour RefinerColour1B;
        /* 0x0580 */ public Colour RefinerColour1C;
        /* 0x0590 */ public Colour RefinerColour1D;
        /* 0x05A0 */ public float AtmosphereEntryTime;
        /* 0x05A4 */ public float AtmosphereEntryFadeTimeFactor;
        /* 0x05A8 */ public float AtmosphereEntryOffset;
        /* 0x05AC */ public TkCurveType AtmosphereEntryCurve;
        /* 0x05B0 */ public float TerrainResourceScanTime;
        /* 0x05B4 */ public float TerrainResourceScanRange;
        /* 0x05B8 */ public float TerrainResourceCompassRange;
        /* 0x05BC */ public bool BinocsDisplayUnknownCreatures;
        /* 0x05C0 */ public float BinocularScanTargetMinHeight;
        /* 0x05C4 */ public float BinocularScanTargetHeightRange;
        /* 0x05C8 */ public float BinocTimeBeforeScan;
        /* 0x05CC */ public float BinocMinScanTime;
        /* 0x05D0 */ public float BinocScanTime;
        /* 0x05D4 */ public float BinocCreatureScanTime;
        /* 0x05D8 */ public TkCurveType BinocularScanTargetHeightCurve;
        /* 0x05DC */ public float BinocularScanTargetInitialFadeTime;
        /* 0x05E0 */ public float BinocularScanTargetScaler;
        /* 0x05E4 */ public float BinocularScanTargetLineWidth;
        /* 0x05E8 */ public float BinocularScanTargetFadeTime;
        /* 0x05F0 */ public Colour BinocularScanTargetColour;
        /* 0x0600 */ public GcScanEffectData BinocularScanEffect;
        /* 0x0650 */ public float ScannerIconsClumpRadius;
        /* 0x0654 */ public float ScannableComponentMarkerOffset;
        /* 0x0658 */ public float ScannableComponentPlaceMarkerOffset;
        /* 0x065C */ public float MissionEventAllowResetDistance;
        /* 0x0660 */ public float AllRecipesKnownNanitesMin;
        /* 0x0664 */ public float AllRecipesKnownNanitesMax;
        /* 0x0668 */ public float MaxPossibleShipDamagePotential;
        /* 0x066C */ public float BuildingPlayerBaseIconOffset;
        /* 0x0670 */ public float CriticalHitMultiplier;
        /* 0x0674 */ public float HitEffectMinTime;
        /* 0x0678 */ public float GrabPlayerCooldownTime;
        /* 0x067C */ public float TapInteractionIncreaseAmount;
        /* 0x0680 */ public float TapInteractionDecay;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x0684 */ public byte[] Padding684;
        /* 0x0690 */ public GcScanEffectData DeconstructEffect;
        /* 0x06E0 */ public GcScanEffectData HitEffect;
        /* 0x0730 */ public GcScanEffectData HitEffectCritical;
        /* 0x0780 */ public float CommunicatorSpawnOffset;
        /* 0x0784 */ public float CommunicatorSpawnHeightOffset;
        /* 0x0790 */ public Vector3f CommunicatorShipSpawnOffset;
        /* 0x07A0 */ public float CommunicatorSpawnScale;
        /* 0x07A4 */ public float CommunicatorSpawnRotation;
        /* 0x07A8 */ public float CommunicatorFadeTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x07AC */ public byte[] Padding7AC;
        [NMS(Size = 0x2)]
        /* 0x07B0 */ public GcScanEffectData[] CommunicatorEffectTable;
        /* 0x0850 */ public int MaxNumMissionsFromMissionGiver;
        /* 0x0854 */ public float InteractionMinTimeBeforeHighlightedOptionSelection;
        /* 0x0858 */ public float InteractionMinTimeBetweenStickOptionHighlights;
        /* 0x085C */ public float InteractionStickOptionStrength;
        /* 0x0860 */ public float InteractionMessageModuleDisplayTime;
        /* 0x0864 */ public float InteractionAttractTime;
        /* 0x0868 */ public float InteractionDescriptionTextTime;
        /* 0x086C */ public float InteractionMinTimeForResponseText;
        /* 0x0870 */ public bool InteractionOverride;
        /* 0x0874 */ public GcInteractionType InteractionOverrideFrom;
        /* 0x0878 */ public GcInteractionType InteractionOverrideTo;
        /* 0x087C */ public float DestroyEffectHeight;
        /* 0x0880 */ public float DestroyEffectMaxScale;
        /* 0x0884 */ public float EventTargetSpeed;
        /* 0x0888 */ public int SpecialMiningAmount;
        /* 0x088C */ public float SpecialMiningTime;
        /* 0x0890 */ public int HardModeTechDamageMidNum;
        /* 0x0894 */ public int HardModeTechDamageMidPercent;
        /* 0x0898 */ public int HardModeTechDamageHighPercent;
        /* 0x089C */ public int EarlyPiratesToBeKilled;
        /* 0x08A0 */ public int PirateInterestOverride;
        /* 0x08A4 */ public float PirateInterestDistance;
        [NMS(Size = 0x3)]
        /* 0x08A8 */ public int[] PirateInterestLevels;
        [NMS(Size = 0x3)]
        /* 0x08B4 */ public int[] PirateInterestLevelsSurvival;
        /* 0x08C0 */ public float SpaceCombatRadius;
        /* 0x08C4 */ public int WarpsBetweenBattles;
        /* 0x08C8 */ public float HoursBetweenBattles;
        /* 0x08CC */ public float SpaceBattleRadius;
        /* 0x08D0 */ public float SpaceBattleAnyHostileShipsRadius;
        /* 0x08D4 */ public float FreighterBattleRadius;
        /* 0x08D8 */ public float MissileMaxTurnAngle;
        /* 0x08DC */ public float MissileLockTime;
        /* 0x08E0 */ public float MissileReloadTime;
        /* 0x08E4 */ public float MissileRotateMin;
        /* 0x08E8 */ public float MissileRotateMax;
        /* 0x08EC */ public float MissileMaxSpeed;
        /* 0x08F0 */ public float MissileForceMin;
        /* 0x08F4 */ public float MissileForceMax;
        /* 0x08F8 */ public float MissileBrakeForceMin;
        /* 0x08FC */ public float MissileBrakeForceMax;
        /* 0x0900 */ public float MissileThreatTime;
        /* 0x0904 */ public float MissileBrakeTime;
        /* 0x0908 */ public float MissileHitRadius;
        /* 0x090C */ public float MissileOffset;
        /* 0x0910 */ public float MissileMinCircleTime;
        /* 0x0914 */ public float MissileApproachTime;
        /* 0x0918 */ public float MissileRotateSpeed;
        /* 0x091C */ public float ScanStartTimeDelayMinDist;
        /* 0x0920 */ public float ScanStartTimeDelayRange;
        /* 0x0924 */ public float ScanStartTimeDistanceDelayTime;
        /* 0x0928 */ public float ScanStickyDecay;
        /* 0x092C */ public float CreatureScanStickyDecay;
        /* 0x0930 */ public float CreatureScanAngle;
        /* 0x0934 */ public float CreatureMinScanTime;
        /* 0x0938 */ public float ScanAngle;
        /* 0x093C */ public float NewDiscoveryDisplayTime;
        /* 0x0940 */ public bool FailToFindBuildings;
        /* 0x0944 */ public float WaterLandingDamageMultiplier;
        /* 0x0948 */ public int CritDamage;
        /* 0x094C */ public float CritScale;
        /* 0x0950 */ public int NumMissionsPerSolarSystem;
        /* 0x0954 */ public float EmergencyBuildingScanEventDistance;
        /* 0x0958 */ public float EmergencyBuildingScanEventTime;
        /* 0x095C */ public float ProjectileLightIntensity;
        /* 0x0960 */ public float AggressiveSentinelProbability;
        /* 0x0964 */ public float AggressiveSentinelProbabilitySurvival;
        /* 0x0968 */ public float LowSentinelProbability;
        /* 0x096C */ public float LowSentinelProbabilitySurvival;
        /* 0x0970 */ public float NonAggressiveLushSurvivalProbabability;
        /* 0x0974 */ public int MaxDronesLow;
        /* 0x0978 */ public int MaxDronesLowSurvival;
        /* 0x097C */ public int MaxDronesNormal;
        /* 0x0980 */ public int MaxDronesNormalSurvival;
        /* 0x0984 */ public int MaxDronesAggressive;
        /* 0x0988 */ public int MaxDronesAggressiveSurvival;
        /* 0x098C */ public GcExperienceTimers SentinelTimersLow;
        /* 0x09AC */ public GcExperienceTimers SentinelTimersNormal;
        /* 0x09CC */ public GcExperienceTimers SentinelTimersSurvival;
        /* 0x09EC */ public int FreighterStartPecent;
        /* 0x09F0 */ public GcExperienceTimers FreighterTimers;
        /* 0x0A10 */ public GcExperienceTimers PirateTimers;
        /* 0x0A30 */ public GcExperienceTimers HardPirateTimers;
        [NMS(Size = 0x3)]
        /* 0x0A50 */ public float[] PirateEarlySpawnChances;
        /* 0x0A5C */ public float PirateEarlySpawnTime;
        /* 0x0A60 */ public GcExperienceTimers FlybyTimers;
        /* 0x0A80 */ public GcExperienceTimers SpaceFlybyTimers;
        [NMS(Size = 0x5)]
        /* 0x0AA0 */ public int[] FreighterTechQualityWeightings;
        /* 0x0AB4 */ public int SentinelsHigh;
        /* 0x0AB8 */ public int SentinelsLow;
        /* 0x0ABC */ public float AsteroidHitForce;
        /* 0x0AC0 */ public float AsteroidTorqueForce;
        /* 0x0AC4 */ public float AsteroidCarveRadius;
        /* 0x0AC8 */ public int DeathMoneyPenalty;
        /* 0x0ACC */ public int DeathMoneyPenaltyHardMode;
        /* 0x0AD0 */ public int MaxResourceCrystalBlobSize;
        /* 0x0AD4 */ public float BuildingBeamDistance;
        /* 0x0AD8 */ public float WaypointScanTime;
        /* 0x0ADC */ public int RareSubstanceEffectiveness;
        /* 0x0AE0 */ public int CommonProductEffectiveness;
        /* 0x0AE4 */ public int RareProductEffectiveness;
        /* 0x0AE8 */ public int AsteroidResourceReducer;
        /* 0x0AEC */ public float VoxelAsteroidResourceChance;
        /* 0x0AF0 */ public int ResourceReducer;
        /* 0x0AF4 */ public int ResourceMinAmount;
        /* 0x0AF8 */ public int ResourceMaxAmount;
        /* 0x0AFC */ public int ResourceCommonReducer;
        /* 0x0B00 */ public int ResourceCommonMinAmount;
        /* 0x0B04 */ public int ResourceCommonMaxAmount;
        /* 0x0B08 */ public int ResourceDirtReducer;            // Do not set to 0
        /* 0x0B0C */ public int ResourceDirtMinAmount;
        /* 0x0B10 */ public int ResourceDirtMaxAmount;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0B14 */ public byte[] PaddingB14;
        [NMS(Size = 0x10)]
        /* 0x0B18 */ public string ResourceDirtSubstanceID;
        [NMS(Size = 0x10)]
        /* 0x0B28 */ public string BioShipTerrainResource;        // "SUNGOLD" -> Liquid Sun substance
        [NMS(Size = 0x20)]
        /* 0x0B38 */ public string RobotResource;
        [NMS(Size = 0x20)]
        /* 0x0B58 */ public string DepotResource;
        /* 0x0B78 */ public float DockNodeBuyRadius;
        /* 0x0B7C */ public float BeaconInteractRange;
        /* 0x0B80 */ public float ShipInteractRadius;
        /* 0x0B84 */ public GcResourceCollectEffect AsteroidResourceCollect;
        /* 0x0BB8 */ public float ScanAngleCutoff;
        /* 0x0BBC */ public GcScanData ToolScan;
        /* 0x0BD0 */ public GcScanData ToolScanHardMode;
        /* 0x0BE4 */ public GcScanData WaypointScan;
        /* 0x0BF8 */ public GcScanData BeaconScan;
        /* 0x0C0C */ public GcScanData RadioTowerScan;
        /* 0x0C20 */ public GcScanData ObservatoryScan;
        /* 0x0C34 */ public GcScanData DistressSignalScan;
        /* 0x0C48 */ public GcScanData DebugScanPlanet;
        /* 0x0C5C */ public GcScanData DebugScanSpace;
        /* 0x0C70 */ public GcScanData ShipScan;
        /* 0x0C84 */ public GcScanData VisualScan;
        /* 0x0C98 */ public float ZoomFindBuildingRange;
        /* 0x0C9C */ public float TimeToDisplayScanResults;
        /* 0x0CA0 */ public float HoverTimeToScan;
        /* 0x0CA4 */ public float HoverTimeToScanCreatures;
        /* 0x0CA8 */ public int HoverVisiblePointsNeeded;
        [NMS(Size = 0x4)]
        /* 0x0CAC */ public GcZoomData[] ZoomLevels;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0D1C */ public byte[] PaddingD1C;
        /* 0x0D20 */ public GcScanEffectData PassiveScanEffect;
        /* 0x0D70 */ public GcScanEffectData BuildingScanEffect;
        /* 0x0DC0 */ public GcScanEffectData TargetShipScanEffect;
        /* 0x0E10 */ public GcScanEffectData HUDShipScanEffect;
        /* 0x0E60 */ public GcScanEffectData CreatureScanEffect;
        /* 0x0EB0 */ public GcScanEffectData ObjectsScanEffect;
        /* 0x0F00 */ public GcScanEffectData VRGhostScanEffect;
        /* 0x0F50 */ public GcScanEffectData BaseBuildingValidScanEffect;
        /* 0x0FA0 */ public GcScanEffectData BaseBuildingPreviewSelectionScanEffect;
        /* 0x0FF0 */ public GcScanEffectData BaseBuildingSelectionScanEffect;
        /* 0x1040 */ public GcScanEffectData BaseBuildingDeleteScanEffect;
        /* 0x1090 */ public GcScanEffectData BaseBuildingGhostScanEffect;
        /* 0x10E0 */ public GcScanEffectData BaseBuildingSpawnStaticEffect;
        /* 0x1130 */ public GcScanEffectData BaseBuildingErrorInsideScanEffect;
        /* 0x1180 */ public GcScanEffectData BaseBuildingErrorCollisionScanEffect;
        /* 0x11D0 */ public GcScanEffectData BaseBuildingErrorImpossibleScanEffect;
        /* 0x1220 */ public GcScanEffectData BaseBuildingErrorUnaffordableScanEffect;
        /* 0x1270 */ public GcScanEffectData BaseBuildingErrorAboveWaterScanEffect;
        /* 0x12C0 */ public GcScanEffectData BaseBuildingErrorBelowWaterScanEffect;
        /* 0x1310 */ public GcScanEffectData BaseBuildingRemotePlayerValidScanEffect;
        /* 0x1360 */ public GcScanEffectData BaseBuildingRemotePlayerSelectionScanEffect;
        /* 0x13B0 */ public float BaseBuildingRemotePlayerErrorAlphaScanEffect;
        /* 0x13B4 */ public bool UseDebugScan;
        /* 0x13B5 */ public bool DebugScanForceBuilding;
        /* 0x13B8 */ public GcBuildingClassification DebugScanForceBuildingType;
        /* 0x13BC */ public float ShipScanOffset;
        /* 0x13C0 */ public float ShipScanOffsetGap;
        /* 0x13C4 */ public TkCurveType ShipScanCurve;
        /* 0x13C8 */ public float ScannerMarkerFadeTime;
        /* 0x13CC */ public float ScannerSmallMarkerFadeTime;
        /* 0x13D0 */ public float ScannerPhysicsProbeAABBSize;
        /* 0x13D4 */ public float ScannerAnalyzeFXRate;
        /* 0x13D8 */ public float ScannerSubstanceTimePerTrigger;
        /* 0x13DC */ public float ScannerTuningA;
        /* 0x13E0 */ public float ScannerTuningB;
        /* 0x13E4 */ public float ScannerTuningC;
        /* 0x13E8 */ public float ScannerTuningD;
        /* 0x13EC */ public float ScannerTuningResourceOffset1;
        /* 0x13F0 */ public float ScannerTuningResourceOffset2;
        /* 0x13F4 */ public float ScannerTuningSmoothStepAmount;
        /* 0x13F8 */ public float ScannerTuningTrailingEdge;
        /* 0x13FC */ public bool Autolevel;
        /* 0x1400 */ public Colour ScannerColour1;
        /* 0x1410 */ public Colour ScannerColour2;
        /* 0x1420 */ public float HUDStoreFlashTime;
        /* 0x1424 */ public float ExcitingViewAngle;
        /* 0x1428 */ public float ExcitingViewRange;
        /* 0x142C */ public float ExcitingNearRange;
        /* 0x1430 */ public float ProjectileSpeedBoost;
        /* 0x1434 */ public float LineWidth;
        /* 0x1438 */ public float LockOffFactor;
        /* 0x143C */ public float OffscreenFadeDistance;
        /* 0x1440 */ public float OffscreenMinDot;
        /* 0x1444 */ public bool HUDUpdateFromData;
        /* 0x1448 */ public float HUDLockOnAudioTime;
        /* 0x144C */ public float HUDArrowPrimaryScaler;
        /* 0x1450 */ public Vector2f HUDDamageSize;
        /* 0x1458 */ public Vector2f HUDDamageSplatSize;
        /* 0x1460 */ public Colour HUDDamageSplatShieldColour;
        /* 0x1470 */ public Colour HUDDamageSplatPainColour;
        /* 0x1480 */ public float HUDDamageOffset;
        /* 0x1484 */ public float HUDDamageScaler;
        /* 0x1488 */ public float HUDDamageRadius;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x148C */ public byte[] Padding148C;
        /* 0x1490 */ public GcShipHUDTargetData HUDTarget;
        /* 0x18C0 */ public float HUDLabelTime;
        /* 0x18C4 */ public float HUDLabelAngle;
        /* 0x18C8 */ public float HUDLabelAngleOffset;
        /* 0x18CC */ public float HUDLabelOffsetX;
        /* 0x18D0 */ public float HUDLabelOffsetY;
        /* 0x18D4 */ public float HUDLabelOffsetZ;
        /* 0x18D8 */ public float HUDLabelScale;
        /* 0x18DC */ public float MaxSpawnTime;
        [NMS(Size = 0x80)]
        /* 0x18E0 */ public string ResourceParticleFile;
        /* 0x1960 */ public float ResourceParticleSpeed;
        /* 0x1964 */ public float ResourceParticleSpread;
        /* 0x1968 */ public int ResourceParticleMaxNum;
        /* 0x196C */ public int ResourceParticleMinNum;
        /* 0x1970 */ public float MapHeight;
        /* 0x1974 */ public float MapOffset;
        /* 0x1978 */ public float MapTargetOffset;
        /* 0x197C */ public float MapFOV;
        /* 0x1980 */ public float MapRadius;
        /* 0x1984 */ public float HUDScaleAdd;
        /* 0x1988 */ public float HUDScaleRadius;
        /* 0x198C */ public float HUDScaleMin;
        /* 0x1990 */ public float HUDScaleMinAim;
        /* 0x1994 */ public float HUDScaleMax;
        /* 0x1998 */ public float HUDScaleFarTarget;
        /* 0x199C */ public float HUDReticuleMoveBack;
        /* 0x19A0 */ public float HUDReticuleMoveAim;
        /* 0x19A4 */ public float MouseSensitivity;
        /* 0x19A8 */ public float MouseSensitivityShip;
        /* 0x19AC */ public float MouseSensitivityVehicle;
        /* 0x19B0 */ public float PainTime;
        /* 0x19B4 */ public TkCurveType PainCurve;
        /* 0x19C0 */ public Colour PainColour;
        /* 0x19D0 */ public float GunOffsetX;
        /* 0x19D4 */ public float GunOffsetY;
        /* 0x19D8 */ public float GunOffsetZ;
        /* 0x19DC */ public float GunDownAngle;
        /* 0x19E0 */ public float GunUpAngle;
        /* 0x19E4 */ public float BarrelOffset;
        /* 0x19E8 */ public float HitOffset;
        /* 0x19EC */ public GcTracerData BulletTracer;
        /* 0x1A04 */ public GcTracerData ShipTracer;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1A1C */ public byte[] Padding1A1C;
        [NMS(Size = 0x10)]
        /* 0x1A20 */ public string DefaultAnim;
        /* 0x1A30 */ public bool DebugDrawTriggerBoxes;
        /* 0x1A34 */ public float SpeedReadoutMultiplier;
        /* 0x1A38 */ public float SpaceSpeedReadoutMultiplier;
        /* 0x1A3C */ public int TorchCookieIndex;
        /* 0x1A40 */ public float TorchFoV;
        /* 0x1A44 */ public float TorchStrength;
        /* 0x1A48 */ public int TorchDimCookieIndex;
        /* 0x1A4C */ public float TorchDimFoV;
        /* 0x1A50 */ public float TorchDimStrength;
        /* 0x1A54 */ public float InteractionTorchFoV;
        /* 0x1A58 */ public float InteractionTorchStrength;
        /* 0x1A5C */ public float TorchOffsetX;
        /* 0x1A60 */ public float TorchOffsetY;
        /* 0x1A64 */ public float TorchOffsetZ;
        /* 0x1A68 */ public float TorchHandOffsetX;
        /* 0x1A6C */ public float TorchHandOffsetY;
        /* 0x1A70 */ public float TorchHandOffsetZ;
        /* 0x1A74 */ public bool TorchDisabledInTheDay;
        /* 0x1A78 */ public float TorchRotation;
        /* 0x1A7C */ public float TorchFollowCameraPitch;
        /* 0x1A80 */ public float TorchFollowCameraTime;
        /* 0x1A90 */ public Colour TorchColour;
        /* 0x1AA0 */ public float PlayerAmbientSpotLightIntensity;
        /* 0x1AB0 */ public Colour PlayerAmbientSpotLightColour;
        /* 0x1AC0 */ public float PlayerAmbientSpotLightOffsetY;
        /* 0x1AC4 */ public float PlayerAmbientSpotLightOffsetZ;
        /* 0x1AC8 */ public float SimpleInteractionPickupAngle;
        /* 0x1ACC */ public float SimpleInteractionPickupRadius;
        /* 0x1AD0 */ public float SimpleInteractionMessageTime;
        /* 0x1AD4 */ public float InteractionPickupAngle;
        /* 0x1AD8 */ public float InteractionPickupRadius;
        /* 0x1ADC */ public float ExplosionRadiusMultiplier;
        /* 0x1AE0 */ public float ExplosionForce;
        /* 0x1AE4 */ public float ExplosionForceMaxForceRadius;
        /* 0x1AE8 */ public float LaserExplosionForceRadius;
        /* 0x1AEC */ public float LaserExplosionForce;
        /* 0x1AF0 */ public float LaserExplosionForceMaxForceRadius;
        [NMS(Size = 0x80)]
        /* 0x1AF4 */ public string InitialDebrisScene;
        /* 0x1B74 */ public float BonusSameTypeElementsAdd;
        /* 0x1B78 */ public float BonusSameTypeElementsMultiply;
        /* 0x1B7C */ public float BonusChildTypeElementsAdd;
        /* 0x1B80 */ public float BonusChildTypeElementsMultiply;
        /* 0x1B84 */ public float InteractionComponentUpdateDistance;
        /* 0x1B88 */ public float GoalGapVoxelDist;
        /* 0x1B8C */ public float BlackHoleJumpVoxelDist;
        /* 0x1B90 */ public float BlackHoleJumpVoxelVariation;
        /* 0x1B94 */ public float JumpToCenterFuelCost;
        /* 0x1B98 */ public int WarpsBetweenMiniStation;
        /* 0x1B9C */ public float HoursBetweenMiniStation;
        [NMS(Size = 0x80)]
        /* 0x1BA0 */ public string LegacyBaseBuildingTable;
        [NMS(Size = 0x80)]
        /* 0x1C20 */ public string BaseBuildingTable;
        /* 0x1CA0 */ public ulong NPCWorkerInteractionCooldown;
        /* 0x1CA8 */ public float LightStrength;
        /* 0x1CAC */ public float AirLockDoorRange;
        /* 0x1CB0 */ public bool DisableBasePowerHUDOverlay;
        /* 0x1CB1 */ public bool KeepAttackingMaxWantedLevel;
        /* 0x1CB2 */ public bool UseMultiplierBonus;
        /* 0x1CB4 */ public float ShipDisplayDamageMultiplier;
        /* 0x1CB8 */ public float IllegalProductTradingMod;
        /* 0x1CBC */ public bool UseTradingCostTable;
        /* 0x1CBD */ public bool ChangePricesLocally;
        /* 0x1CBE */ public bool ShowPriceMarkupsAsPercentages;
        /* 0x1CC0 */ public int ProductItemStockDecayTime;
        /* 0x1CC4 */ public int ProductItemStockReplenishTime;
        /* 0x1CC8 */ public int SubstanceItemStockDecayTime;
        /* 0x1CCC */ public int SubstanceItemStockReplenishTime;
        /* 0x1CD0 */ public GcPortalData Portal;
        /* 0x1CD8 */ public int FourthRaceSpawnPercentage;
        /* 0x1CDC */ public int NonDominantRaceSpawnPercentage;
        /* 0x1CE0 */ public float ViciousSentinelProbability;
        /* 0x1CE4 */ public float ViciousStormProbability;
        /* 0x1CE8 */ public float ViciousWeatherProbability;
        /* 0x1CEC */ public float ScrapDroneProbability;
        /* 0x1CF0 */ public float MaxRespawnOnGroundHeight;
        /* 0x1CF4 */ public float DeadPlanetGravityFactor;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x1CF8 */ public byte[] Padding1CF8;
        /* 0x1D00 */ public GcScanEffectData ShipSalvageScanEffect;
        /* 0x1D50 */ public float SalvageShipPitch;
        /* 0x1D54 */ public float SalvageShipHeightOffset;
        /* 0x1D58 */ public float SalvageShipExplodeSpeed;
        /* 0x1D5C */ public float SalvageShipShowShipSpeed;
        /* 0x1D60 */ public float SalvageShipShowShipDistance;
        /* 0x1D64 */ public float SalvageShipExplodeShipDistance;
        /* 0x1D68 */ public float SalvageShipOneRevolutionTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1D6C */ public byte[] Padding1D6C;
        [NMS(Size = 0x20)]
        /* 0x1D70 */ public string CommunicatorFireteamNexusExitDialog;
        [NMS(Size = 0x20)]
        /* 0x1D90 */ public string CommunicatorNexusExitAbandonWarningDialog;
        /* 0x1DB0 */ public float PulseEncounterCheckTimer;
        /* 0x1DB4 */ public float PulseEncounterChance;
        /* 0x1DB8 */ public float PulseEncounterChanceStandard;
        /* 0x1DBC */ public float PulseEncounterChanceRed;
        /* 0x1DC0 */ public float PulseEncounterChanceGreen;
        /* 0x1DC4 */ public float PulseEncounterChanceBlue;
        /* 0x1DC8 */ public float PulseEncounterStopPower;
        /* 0x1DCC */ public float PulseEncounterStopSpeed;
        [NMS(Size = 0x5)]
        /* 0x1DD0 */ public int[] AlienShipEvolveCosts;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x1DE4 */ public byte[] EndPadding;
    }
}

/* Notes and algorithms:

Since the names for the sentinal timer and flyby timers are a bit hard to understand,
this is the algorithm that shows how the game uses them:

if SentinelLevel == Agressive:
	MaxActiveDrones = 1
	SentinelTimer = SentinelTimer_Default_or_Aggressive
	FlybyTimer = FlybyTimer_B_or_Aggressive
else:
	MaxActiveDrones = 2
	if RNG(0,100) >= SentinelTimer_Default_Chance_percent:
		SentinelTimer = SentinelTimer_A
		if RNG(0,100) < SentinelTimer_B_Chance_percent:
			SentinelTimer = SentinelTimer_B
	else:
		SentinelTimer = SentinelTimer_Default_or_Aggressive
	
	if RNG(0,100) >= FlybyTimer_Default_Chance_percent:
		FlybyTimer = FlybyTimer_A
		if RNG(0,100) < FlybyTimer_B_Chance_percent:
			FlybyTimer = FlybyTimer_B_or_Aggressive
	else:
		FlybyTimer = FlybyTimer_Default
*/