using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xA4048CA4C1B04EDF)]
    public class GcGameplayGlobals : NMSTemplate
    {
        /* 0x000 */ public float Unknown0x0;
        /* 0x004 */ public int UnknownInt0x4;

        [NMS(Size = 0x2D)]
        /* 0x008 */ public NMSString0x10[] SalvageStrings;     // TODO: categorise better...
        /* 0x2D8 */ public bool Unknown0x2D8;
        /* 0x2DC */ public float Unknown0x2DC;
        /* 0x2E0 */ public float Unknown0x2E0;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x2E4 */ public byte[] Padding0x2E4;
        /* 0x2F0 */ public GcScanEffectData Unknown0x2EC;
        /* 0x340 */ public float Unknown0x340;
        /* 0x344 */ public float Unknown0x344;
        /* 0x348 */ public float Unknown0x348;
        /* 0x34C */ public float Unknown0x34C;
        /* 0x350 */ public float Unknown0x350;
        /* 0x354 */ public float Unknown0x354;
        /* 0x358 */ public float Unknown0x358;
        /* 0x35C */ public float Unknown0x35C;
        /* 0x360 */ public float Unknown0x360;
        /* 0x364 */ public float Unknown0x364;
        /* 0x368 */ public float Unknown0x368;
        /* 0x36C */ public float Unknown0x36C;
        /* 0x370 */ public float Unknown0x370;
        /* 0x374 */ public float Unknown0x374;
        /* 0x378 */ public float Unknown0x378;
        /* 0x37C */ public float Unknown0x37C;
        /* 0x380 */ public float Unknown0x380;
        /* 0x384 */ public float Unknown0x384;
        /* 0x388 */ public float Unknown0x388;
        /* 0x38C */ public float Unknown0x38C;
        /* 0x390 */ public float Unknown0x390;
        /* 0x394 */ public float HotspotScanRange;
        /* 0x398 */ public int UnknownInt0x398;
        /* 0x39C */ public int UnknownInt0x39C;
        /* 0x3A0 */ public bool Unknown0x3A0;
        /* 0x3A1 */ public bool Unknown0x3A1;
        /* 0x3A2 */ public bool Unknown0x3A2;
        /* 0x3A3 */ public bool Unknown0x3A3;
        /* 0x3A4 */ public bool Unknown0x3A4;
        /* 0x3A8 */ public float Unknown0x3A8;
        /* 0x3AC */ public float Unknown0x3AC;
        /* 0x3B0 */ public float Unknown0x3B0;
        /* 0x3B4 */ public float Unknown0x3B4;
        /* 0x3B8 */ public float Unknown0x3B8;
        /* 0x3BC */ public float Unknown0x3BC;
        /* 0x3C0 */ public float Unknown0x3C0;
        /* 0x3C4 */ public float Unknown0x3C4;
        /* 0x3C8 */ public float Unknown0x3C8;
        /* 0x3CC */ public float Unknown0x3CC;
        /* 0x3D0 */ public float Unknown0x3D0;
        /* 0x3D4 */ public float Unknown0x3D4;
        /* 0x3D8 */ public int UnknownInt0x3D8;
        /* 0x3DC */ public int UnknownInt0x3DC;
        /* 0x3E0 */ public bool Unknown0x3E0;
        /* 0x3E4 */ public float Unknown0x3E4;
        /* 0x3E8 */ public float Unknown0x3E8;
        /* 0x3EC */ public float Unknown0x3EC;
        /* 0x3F0 */ public float Unknown0x3F0;
        /* 0x3F4 */ public float Unknown0x3F4;
        /* 0x3F8 */ public float Unknown0x3F8;
        /* 0x3FC */ public float Unknown0x3FC;
        /* 0x400 */ public float Unknown0x400;
        /* 0x404 */ public float Unknown0x404;
        /* 0x408 */ public float Unknown0x408;
        /* 0x40C */ public float Unknown0x40C;
        /* 0x410 */ public float Unknown0x410;
        /* 0x414 */ public float Unknown0x414;
        /* 0x418 */ public float Unknown0x418;
        /* 0x41C */ public float Unknown0x41C;
        /* 0x420 */ public int UnknownInt0x420;
        /* 0x424 */ public int UnknownInt0x424;
        /* 0x428 */ public int CookingSpeedMultiplier; // Increase value for faster cooking
        /* 0x42C */ public int RefiningSpeedMultiplier; // Increase value for faster refining
        /* 0x430 */ public int UnknownInt0x430;
        /* 0x434 */ public int UnknownInt0x434;
        [NMS(Size = 0x3)]
        /* 0x0438 */ public NMSString0x10[] HyperdriveAccess;
        [NMS(Size = 0x3)]
        /* 0x0468 */ public NMSString0x10[] FreighterHyperdriveAccess;
        /* 0x0498 */ public float Unknown0x498;
        /* 0x049C */ public float Unknown0x49C;
        /* 0x04A0 */ public float Unknown0x4A0;
        /* 0x04A4 */ public bool AllowPreInstallTechnologies; // Set to False to revert to legacy method of installing technologies and upgrades
        ///* 0x04A5 */ public bool FreighterRequiresRGBHyperdriveUpgrades;      // Not 100% this is the one that was removed...
        /* 0x04A5 */ public bool AllowTeleportItemsToFreighter;
        /* 0x04A6 */ public bool DisableAnomalyAmbientSpawn;
        /* 0x04A7 */ public bool AllowDeconstruct;
        /* 0x04A8 */ public bool AllowBinocularMarker;
        /* 0x04A9 */ public bool EveryMaintenanceIsBroken;
        /* 0x04AA */ public bool SpawnResourceBlobsOnPartDelete;
        /* 0x04AB */ public bool EnableShootHitEffect;
        /* 0x04AC */ public int MaxNumSameGroupTech;
        /* 0x04B0 */ public float ShootableArmourHighlightHitTime;
        /* 0x04B4 */ public float ShootableAggroMinStartTime;
        /* 0x04B8 */ public float ShootableAggroForgetTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04BC */ public byte[] Padding4BC;
        /* 0x04C0 */ public Colour RefinerColour1A;
        /* 0x04D0 */ public Colour RefinerColour1B;
        /* 0x04E0 */ public Colour RefinerColour1C;
        /* 0x04F0 */ public Colour RefinerColour1D;
        /* 0x0500 */ public float AtmosphereEntryTime;
        /* 0x0504 */ public float AtmosphereEntryFadeTimeFactor;
        /* 0x0508 */ public float AtmosphereEntryOffset;
        /* 0x050C */ public TkCurveType AtmosphereEntryCurve;
        /* 0x0510 */ public float TerrainResourceScanTime;
        /* 0x0514 */ public float TerrainResourceScanRange;
        /* 0x0518 */ public float Unknown0x518;
        /* 0x051C */ public bool BinocsDisplayUnknownCreatures;
        /* 0x0520 */ public float BinocularScanTargetMinHeight;
        /* 0x0524 */ public float BinocularScanTargetHeightRange;
        /* 0x0528 */ public float BinocTimeBeforeScan;
        /* 0x052C */ public float BinocMinScanTime;
        /* 0x0530 */ public float BinocScanTime;
        /* 0x0534 */ public float BinocCreatureScanTime;
        /* 0x0538 */ public TkCurveType BinocularScanTargetHeightCurve;
        /* 0x053C */ public float BinocularScanTargetInitialFadeTime;
        /* 0x0540 */ public float BinocularScanTargetScaler;
        /* 0x0544 */ public float BinocularScanTargetLineWidth;
        /* 0x0548 */ public float BinocularScanTargetFadeTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x054C */ public byte[] Padding268;
        /* 0x0550 */ public Colour BinocularScanTargetColour;
        /* 0x0560 */ public GcScanEffectData BinocularScanEffect;
        /* 0x05B0 */ public float ScannerIconsClumpRadius;
        /* 0x05B4 */ public float ScannableComponentMarkerOffset;
        /* 0x05B8 */ public float ScannableComponentPlaceMarkerOffset;
        /* 0x05BC */ public float MissionEventAllowResetDistance;
        /* 0x05C0 */ public float AllRecipesKnownNanitesMin;
        /* 0x05C4 */ public float AllRecipesKnownNanitesMax;
        /* 0x05C8 */ public float MaxPossibleShipDamagePotential;
        /* 0x05CC */ public float BuildingPlayerBaseIconOffset;
        /* 0x05D0 */ public float CriticalHitMultiplier;
        /* 0x05D4 */ public float HitEffectMinTime;
        /* 0x05D8 */ public float GrabPlayerCooldownTime;
        /* 0x05DC */ public float TapInteractionIncreaseAmount;
        /* 0x05E0 */ public float TapInteractionDecay;
        [NMS(Size = 0x0C, Ignore = true)]
        /* 0x05E4 */ public byte[] Padding5E4;
        /* 0x05F0 */ public GcScanEffectData DeconstructEffect;
        /* 0x0640 */ public GcScanEffectData HitEffect;
        /* 0x0690 */ public GcScanEffectData HitEffectCritical;
        /* 0x06E0 */ public float CommunicatorSpawnOffset;
        /* 0x06E4 */ public float CommunicatorSpawnHeightOffset;
        [NMS(Size = 0x08, Ignore = true)]
        /* 0x06E8 */ public byte[] Padding6E8;
        /* 0x06F0 */ public Vector4f CommunicatorShipSpawnOffset;
        /* 0x0700 */ public float CommunicatorSpawnScale;
        /* 0x0704 */ public float CommunicatorSpawnRotation;
        /* 0x0708 */ public float CommunicatorFadeTime;
        [NMS(Size = 0x04, Ignore = true)]
        /* 0x070C */ public byte[] Padding70C;
        [NMS(Size = 0x02)]
        /* 0x0710 */ public GcScanEffectData[] CommunicatorEffectTable;
        /* 0x07B0 */ public int MaxNumMissionsFromMissionGiver;
        /* 0x07B4 */ public float InteractionMessageModuleDisplayTime;
        /* 0x07B8 */ public float InteractionAttractTime;
        /* 0x07BC */ public float InteractionDescriptionTextTime;
        /* 0x07C0 */ public float InteractionMinTimeForResponseText;
        /* 0x07C4 */ public bool InteractionOverride;
        [NMS(Size = 0x03, Ignore = true)]
        /* 0x07C5 */ public byte[] Padding7C5;
        /* 0x07C8 */ public GcInteractionType InteractionOverrideFrom;
        /* 0x07CC */ public GcInteractionType InteractionOverrideTo;
        /* 0x07D0 */ public float DestroyEffectHeight;
        /* 0x07D4 */ public float DestroyEffectMaxScale;
        /* 0x07D8 */ public float EventTargetSpeed;
        /* 0x07DC */ public int SpecialMiningAmount;
        /* 0x07E0 */ public float SpecialMiningTime;
        /* 0x07E4 */ public int HardModeTechDamageMidNum;
        /* 0x07E8 */ public int HardModeTechDamageMidPercent;
        /* 0x07EC */ public int HardModeTechDamageHighPercent;
        /* 0x07F0 */ public int UnknownInt0x7F0;
        /* 0x07F4 */ public int PirateInterestOverride;
        /* 0x07F8 */ public float PirateInterestDistance;
        [NMS(Size = 0x06)]
        /* 0x07FC */ public int[] PirateInterestLevels;     // maybe 2 separate int[0x3]'s?
        /* 0x0814 */ public float SpaceCombatRadius;
        /* 0x0818 */ public int WarpsBetweenBattles;
        /* 0x081C */ public float HoursBetweenBattles;
        /* 0x0820 */ public float SpaceBattleRadius;
        /* 0x0824 */ public float SpaceBattleAnyHostileShipsRadius;
        /* 0x0828 */ public float FreighterBattleRadius;
        /* 0x082C */ public float MissileMaxTurnAngle;
        /* 0x0830 */ public float MissileLockTime;
        /* 0x0834 */ public float MissileReloadTime;
        /* 0x0838 */ public float MissileRotateMin;
        /* 0x083C */ public float MissileRotateMax;
        /* 0x0840 */ public float MissileMaxSpeed;
        /* 0x0844 */ public float MissileForceMin;
        /* 0x0848 */ public float MissileForceMax;
        /* 0x084C */ public float MissileBrakeForceMin;
        /* 0x0850 */ public float MissileBrakeForceMax;
        /* 0x0854 */ public float MissileThreatTime;
        /* 0x0858 */ public float MissileBrakeTime;
        /* 0x085C */ public float MissileHitRadius;
        /* 0x0860 */ public float MissileOffset;
        /* 0x0864 */ public float MissileMinCircleTime;
        /* 0x0868 */ public float MissileApproachTime;
        /* 0x086C */ public float MissileRotateSpeed;
        /* 0x0870 */ public float ScanStartTimeDelayMinDist;
        /* 0x0874 */ public float ScanStartTimeDelayRange;
        /* 0x0878 */ public float ScanStartTimeDistanceDelayTime;
        /* 0x087C */ public float ScanStickyDecay;
        /* 0x0880 */ public float CreatureScanStickyDecay;
        /* 0x0884 */ public float CreatureScanAngle;
        /* 0x0888 */ public float CreatureMinScanTime;
        /* 0x088C */ public float ScanAngle;
        /* 0x0890 */ public float NewDiscoveryDisplayTime;
        /* 0x0894 */ public bool FailToFindBuildings;
        /* 0x0898 */ public int CritDamage;
        /* 0x089C */ public float CritScale;
        /* 0x08A0 */ public int NumMissionsPerSolarSystem;
        /* 0x08A4 */ public float EmergencyBuildingScanEventDistance;
        /* 0x08A8 */ public float EmergencyBuildingScanEventTime;
        /* 0x08AC */ public float ProjectileLightIntensity;
        /* 0x08B0 */ public float AggressiveSentinelProbability;
        /* 0x08B4 */ public float Unknown0x8B4;
        /* 0x08B8 */ public float Unknown0x8B8;
        /* 0x08BC */ public float Unknown0x8BC;
        /* 0x08C0 */ public float Unknown0x8C0;
        /* 0x08C4 */ public int UnknownInt0x8C4;
        /* 0x08C8 */ public int UnknownInt0x8C8;
        /* 0x08CC */ public int UnknownInt0x8CC;
        /* 0x08D0 */ public int UnknownInt0x8D0;
        /* 0x08D4 */ public int UnknownInt0x8D4;
        /* 0x08D8 */ public int UnknownInt0x8D8;
        /* 0x08DC */ public GcExperienceTimers Unknown0x8DC;
        /* 0x08FC */ public GcExperienceTimers Unknown0x8FC;
        /* 0x091C */ public GcExperienceTimers Unknown0x91C;
        /* 0x093C */ public int FreighterStartPecent;
        /* 0x0940 */ public GcExperienceTimers FreighterTimers;
        /* 0x0960 */ public GcExperienceTimers PirateTimers;
        /* 0x0980 */ public GcExperienceTimers HardPirateTimers;
        [NMS(Size = 0x3)]
        /* 0x09A0 */ public float[] PirateEarlySpawnChances;
        /* 0x09AC */ public float PirateEarlySpawnTime;
        /* 0x09B0 */ public GcExperienceTimers FlybyTimers;
        /* 0x09D0 */ public GcExperienceTimers SpaceFlybyTimers;
        /* 0x09F0 */ public int SentinelsHigh;
        /* 0x09F4 */ public int SentinelsLow;
        /* 0x09F8 */ public float AsteroidHitForce;
        /* 0x09FC */ public float AsteroidTorqueForce;
        /* 0x0A00 */ public float AsteroidCarveRadius;
        /* 0x0A04 */ public int DeathMoneyPenalty;
        /* 0x0A08 */ public int DeathMoneyPenaltyHardMode;
        /* 0x0A0C */ public int MaxResourceCrystalBlobSize;
        /* 0x0A10 */ public float BuildingBeamDistance;
        /* 0x0A14 */ public float WaypointScanTime;
        /* 0x0A18 */ public int RareSubstanceEffectiveness;
        /* 0x0A1C */ public int CommonProductEffectiveness;
        /* 0x0A20 */ public int RareProductEffectiveness;
        /* 0x0A24 */ public int AsteroidResourceReducer;
        /* 0x0A28 */ public float VoxelAsteroidResourceChance;
        /* 0x0A2C */ public int ResourceReducer;
        /* 0x0A30 */ public int ResourceMinAmount;
        /* 0x0A34 */ public int ResourceMaxAmount;
        /* 0x0A38 */ public int ResourceCommonReducer;
        /* 0x0A3C */ public int ResourceCommonMinAmount;
        /* 0x0A40 */ public int ResourceCommonMaxAmount;
        // I assume these have something to do with the mining of the ground...
        /* 0x0A44 */ public int UnknownInt0xA44;            // ResourceGroundReducer
        /* 0x0A48 */ public int UnknownInt0xA48;            // ResourceGroundMin
        /* 0x0A4C */ public int UnknownInt0xA4C;            // ResourceGroundMax
        [NMS(Size = 0x10)]
        /* 0x0A50 */ public string GroundResource;      // just guessing from the data
        [NMS(Size = 0x20)]
        /* 0x0A60 */ public string RobotResource;
        [NMS(Size = 0x20)]
        /* 0x0A80 */ public string DepotResource;
        /* 0x0AA0 */ public float DockNodeBuyRadius;
        /* 0x0AA4 */ public float BeaconInteractRange;
        /* 0x0AA8 */ public float ShipInteractRadius;
        /* 0x0AAC */ public GcResourceCollectEffect AsteroidResourceCollect;
        /* 0x0AE0 */ public float ScanAngleCutoff;
        /* 0x0AE4 */ public GcScanData ToolScan;
        /* 0x0AF8 */ public GcScanData ToolScanHardMode;
        /* 0x0B0C */ public GcScanData WaypointScan;
        /* 0x0B20 */ public GcScanData BeaconScan;
        /* 0x0B34 */ public GcScanData RadioTowerScan;
        /* 0x0B48 */ public GcScanData ObservatoryScan;
        /* 0x0B5C */ public GcScanData DistressSignalScan;
        /* 0x0B70 */ public GcScanData DebugScanPlanet;
        /* 0x0B84 */ public GcScanData DebugScanSpace;
        /* 0x0B98 */ public GcScanData ShipScan;
        /* 0x0BAC */ public GcScanData VisualScan;
        /* 0x0BC0 */ public float ZoomFindBuildingRange;
        /* 0x0BC4 */ public float TimeToDisplayScanResults;
        /* 0x0BC8 */ public float HoverTimeToScan;
        /* 0x0BDC */ public float HoverTimeToScanCreatures;
        /* 0x0BD0 */ public int HoverVisiblePointsNeeded;
        [NMS(Size = 0x4)]
        /* 0x0BD4 */ public GcZoomData[] ZoomLevels;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x0C44 */ public byte[] PaddingC44;
        /* 0x0C50 */ public GcScanEffectData PassiveScanEffect;
        /* 0x0CA0 */ public GcScanEffectData BuildingScanEffect;
        /* 0x0CF0 */ public GcScanEffectData TargetShipScanEffect;
        /* 0x0D40 */ public GcScanEffectData HUDShipScanEffect;
        /* 0x0D90 */ public GcScanEffectData CreatureScanEffect;
        /* 0x0DE0 */ public GcScanEffectData ObjectsScanEffect;
        /* 0x0E30 */ public GcScanEffectData BaseBuildingScanEffect;
        /* 0x0E80 */ public GcScanEffectData BaseBuildingBlockedScanEffect;
        /* 0x0ED0 */ public GcScanEffectData BaseBuildingFreighterScanEffect;
        /* 0x0F20 */ public GcScanEffectData BaseBuildingFreighterBlockedScanEffect;
        /* 0x0F70 */ public GcScanEffectData BaseBuildingSelectionScanEffect;
        /* 0x0FC0 */ public GcScanEffectData BaseBuildingRemotePlayerScanEffect;
        /* 0x1010 */ public GcScanEffectData BaseBuildingRemotePlayerBlockedScanEffect;
        /* 0x1060 */ public GcScanEffectData BaseBuildingRemotePlayerFreighterScanEffect;
        /* 0x10B0 */ public GcScanEffectData BaseBuildingRemotePlayerFreighterBlockedScanEffect;
        /* 0x1100 */ public GcScanEffectData BaseBuildingRemotePlayerSelectionScanEffect;
        /* 0x1150 */ public GcScanEffectData Unknown0x1150;              // some of these unknowns *may* be one of the above unknowns but swapped places...
        /* 0x11A0 */ public GcScanEffectData Unknown0x11A0;
        /* 0x11F0 */ public GcScanEffectData Unknown0x11F0;
        /* 0x1240 */ public GcScanEffectData Unknown0x1240;
        /* 0x1290 */ public GcScanEffectData Unknown0x1290;
        /* 0x12E0 */ public float Unknown0x12E0;
        /* 0x12E4 */ public bool UseDebugScan;
        /* 0x12E5 */ public bool DebugScanForceBuilding;
        [NMS(Size = 0x02, Ignore = true)]
        /* 0x12E6 */ public byte[] Padding12E6;
        /* 0x12E8 */ public GcBuildingClassification DebugScanForceBuildingType;
        /* 0x12EC */ public float ShipScanOffset;
        /* 0x12F0 */ public float ShipScanOffsetGap;
        /* 0x12F4 */ public TkCurveType ShipScanCurve;
        /* 0x12F8 */ public float ScannerMarkerFadeTime;
        /* 0x12FC */ public float ScannerSmallMarkerFadeTime;
        /* 0x1300 */ public float ScannerPhysicsProbeAABBSize;
        /* 0x1304 */ public float ScannerAnalyzeFXRate;
        /* 0x1308 */ public float ScannerSubstanceTimePerTrigger;
        /* 0x130C */ public float ScannerTuningA;
        /* 0x1310 */ public float ScannerTuningB;
        /* 0x1314 */ public float ScannerTuningC;
        /* 0x1318 */ public float ScannerTuningD;
        /* 0x131C */ public float ScannerTuningResourceOffset1;
        /* 0x1320 */ public float ScannerTuningResourceOffset2;
        /* 0x1324 */ public float ScannerTuningSmoothStepAmount;
        /* 0x1328 */ public float ScannerTuningTrailingEdge;
        /* 0x132C */ public bool Autolevel;
        [NMS(Size = 0x03, Ignore = true)]
        /* 0x132D */ public byte[] Padding132D;
        /* 0x1330 */ public Colour ScannerColour1;
        /* 0x1340 */ public Colour ScannerColour2;
        /* 0x1350 */ public float HUDStoreFlashTime;
        /* 0x1354 */ public float ExcitingViewAngle;
        /* 0x1358 */ public float ExcitingViewRange;
        /* 0x135C */ public float ExcitingNearRange;
        /* 0x1360 */ public float ProjectileSpeedBoost;
        /* 0x1364 */ public float LineWidth;
        /* 0x1368 */ public float LockOffFactor;
        /* 0x136C */ public float OffscreenFadeDistance;
        /* 0x1370 */ public float OffscreenMinDot;
        /* 0x1374 */ public bool HUDUpdateFromData;
        /* 0x1378 */ public float HUDLockOnAudioTime;
        /* 0x137C */ public float HUDArrowPrimaryScaler;
        /* 0x1380 */ public Vector2f HUDDamageSize;
        /* 0x1388 */ public Vector2f HUDDamageSplatSize;
        /* 0x1390 */ public Colour HUDDamageSplatShieldColour;
        /* 0x13A0 */ public Colour HUDDamageSplatPainColour;
        /* 0x13B0 */ public float HUDDamageOffset;
        /* 0x13B4 */ public float HUDDamageScaler;
        /* 0x13B8 */ public float HUDDamageRadius;
        [NMS(Size = 0x04, Ignore = true)]
        /* 0x13BC */ public byte[] Padding13BC;
        /* 0x13C0 */ public GcShipHUDTargetData HUDTarget;
        /* 0x17F0 */ public float HUDLabelTime;
        /* 0x17F4 */ public float HUDLabelAngle;
        /* 0x17F8 */ public float HUDLabelAngleOffset;
        /* 0x17FC */ public float HUDLabelOffsetX;
        /* 0x1800 */ public float HUDLabelOffsetY;
        /* 0x1804 */ public float HUDLabelOffsetZ;
        /* 0x1808 */ public float HUDLabelScale;
        /* 0x180C */ public float MaxSpawnTime;
        [NMS(Size = 0x80)]
        /* 0x1810 */ public string ResourceParticleFile;
        /* 0x1890 */ public float ResourceParticleSpeed;
        /* 0x1894 */ public float ResourceParticleSpread;
        /* 0x1898 */ public int ResourceParticleMaxNum;
        /* 0x189C */ public int ResourceParticleMinNum;
        /* 0x18A0 */ public float MapHeight;
        /* 0x18A4 */ public float MapOffset;
        /* 0x18A8 */ public float MapTargetOffset;
        /* 0x18AC */ public float MapFOV;
        /* 0x18B0 */ public float MapRadius;
        /* 0x18B4 */ public float HUDScaleAdd;
        /* 0x18B8 */ public float HUDScaleRadius;
        /* 0x18BC */ public float HUDScaleMin;
        /* 0x18C0 */ public float HUDScaleMinAim;
        /* 0x18C4 */ public float HUDScaleMax;
        /* 0x18C8 */ public float HUDScaleFarTarget;
        /* 0x18CC */ public float HUDReticuleMoveBack;
        /* 0x18D0 */ public float HUDReticuleMoveAim;
        /* 0x18D4 */ public float MouseSensitivity;
        /* 0x18D8 */ public float MouseSensitivityShip;
        /* 0x18DC */ public float Unknown0x18DC;        // maybe a VR sensitivity? Or 3rd person mouse sensitivity
        /* 0x18E0 */ public float PainTime;
        /* 0x18E4 */ public TkCurveType PainCurve;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x18E8 */ public byte[] Padding18E4;
        /* 0x18F0 */ public Colour PainColour;
        /* 0x1900 */ public float GunOffsetX;
        /* 0x1904 */ public float GunOffsetY;
        /* 0x1908 */ public float GunOffsetZ;
        /* 0x190C */ public float GunDownAngle;
        /* 0x1910 */ public float GunUpAngle;
        /* 0x1914 */ public float BarrelOffset;
        /* 0x1918 */ public float HitOffset;
        /* 0x191C */ public GcTracerData BulletTracer;
        /* 0x1934 */ public GcTracerData ShipTracer;
         [NMS(Size = 0x04, Ignore = true)]
        /* 0x194C */ public byte[] Padding194C;
        [NMS(Size = 0x10)]
        /* 0x1950 */ public string DefaultAnim;
        /* 0x1960 */ public bool DebugDrawTriggerBoxes;
        /* 0x1964 */ public float SpeedReadoutMultiplier;
        /* 0x1968 */ public float SpaceSpeedReadoutMultiplier;
        /* 0x196C */ public float TorchFoV;
        /* 0x1970 */ public float TorchStrength;
        /* 0x1974 */ public float TorchOffsetX;
        /* 0x1978 */ public float TorchOffsetY;
        /* 0x197C */ public float TorchOffsetZ;
        /* 0x1980 */ public float TorchRotation;
        /* 0x1984 */ public float Unknown0x1984;
        /* 0x1988 */ public float Unknown0x1988;
        /* 0x198C */ public bool Unknown0x198C;
        /* 0x1990 */ public float Unknown0x1990;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x1994 */ public byte[] Padding1994;
        /* 0x19A0 */ public Colour TorchColour;
        /* 0x19B0 */ public float SimpleInteractionPickupAngle;
        /* 0x19B4 */ public float SimpleInteractionPickupRadius;
        /* 0x19B8 */ public float SimpleInteractionMessageTime;
        /* 0x19BC */ public float InteractionPickupAngle;
        /* 0x19C0 */ public float InteractionPickupRadius;
        /* 0x19C4 */ public float ExplosionRadiusMultiplier;
        /* 0x19C8 */ public float ExplosionForce;
        /* 0x19CC */ public float ExplosionForceMaxForceRadius;
        /* 0x19D0 */ public float LaserExplosionForceRadius;
        /* 0x19D4 */ public float LaserExplosionForce;
        /* 0x19D8 */ public float LaserExplosionForceMaxForceRadius;
        [NMS(Size = 0x80)]
        /* 0x19DC */ public string InitialDebrisScene;
        /* 0x1A5C */ public float BonusSameTypeElementsAdd;
        /* 0x1A60 */ public float BonusSameTypeElementsMultiply;
        /* 0x1A64 */ public float BonusChildTypeElementsAdd;
        /* 0x1A68 */ public float BonusChildTypeElementsMultiply;
        /* 0x1A6C */ public float InteractionComponentUpdateDistance;
        /* 0x1A70 */ public float GoalGapVoxelDist;
        /* 0x1A74 */ public float BlackHoleJumpVoxelDist;
        /* 0x1A78 */ public float BlackHoleJumpVoxelVariation;
        /* 0x1A7C */ public float JumpToCenterFuelCost;
        /* 0x1A80 */ public int WarpsBetweenMiniStation;
        /* 0x1A84 */ public float HoursBetweenMiniStation;
        [NMS(Size = 0x80)]
        /* 0x1A88 */ public string LegacyBaseBuildingTable;
        [NMS(Size = 0x80)]
        /* 0x1B08 */ public string BaseBuildingTable;
        /* 0x1B88 */ public ulong NPCWorkerInteractionCooldown;
        /* 0x1B90 */ public float LightStrength;
        /* 0x1B94 */ public float AirLockDoorRange;
        /* 0x1B98 */ public bool Unknown0x1B98;                     // this value may be swapped with next value?
        /* 0x1B99 */ public bool KeepAttackingMaxWantedLevel;
        /* 0x1B9A */ public bool UseMultiplierBonus;
        /* 0x1B9C */ public float ShipDisplayDamageMultiplier;
        /* 0x1BA0 */ public bool UseTradingCostTable;
        /* 0x1BA1 */ public bool ChangePricesLocally;
        /* 0x1BA2 */ public bool ShowPriceMarkupsAsPercentages;
        /* 0x1BA4 */ public int ProductItemStockDecayTime;
        /* 0x1BA8 */ public int ProductItemStockReplenishTime;
        /* 0x1BAC */ public int SubstanceItemStockDecayTime;
        /* 0x1BB0 */ public int SubstanceItemStockReplenishTime;
        /* 0x1BB4 */ public GcPortalData Portal;
        /* 0x1BBC */ public int FourthRaceSpawnPercentage;
        /* 0x1BC0 */ public int UnknownInt0x1BC0;
        /* 0x1BC4 */ public float ViciousSentinelProbability;
        /* 0x1BC8 */ public float ViciousStormProbability;
        /* 0x1BCC */ public float ViciousWeatherProbability;
        /* 0x1BD0 */ public float ScrapDroneProbability;
        /* 0x1BD4 */ public float Unknown0x1BD4;
        /* 0x1BD8 */ public float Unknown0x1BD8;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1BDC */ public byte[] Padding1BDC;
        /* 0x1BE0 */ public GcScanEffectData Unknown0x1BE0;         // Maybe scavenged stuff scan effect data?
        /* 0x1C30 */ public float Unknown0x1C30;
        /* 0x1C34 */ public float Unknown0x1C34;
        /* 0x1C38 */ public float Unknown0x1C38;
        /* 0x1C3C */ public float Unknown0x1C3C;
        /* 0x1C40 */ public float Unknown0x1C40;
        /* 0x1C44 */ public float Unknown0x1C44;
        /* 0x1C48 */ public float Unknown0x1C48;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1C4C */ public byte[] EndPadding;
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
