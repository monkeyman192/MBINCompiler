namespace libMBIN.Models.Structs
{
    public class GcGameplayGlobals : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x0 */ public string HyperdriveAccess1;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string HyperdriveAccess2;
        [NMS(Size = 0x10)]
        /* 0x20 */ public string HyperdriveAccess3;
        /* 0x30 */ public bool AllowDeconstruct;
        /* 0x31 */ public bool AllowBinocularMarker;
        /* 0x32 */ public bool EveryMaintenanceIsBroken;
        /* 0x33 */ public bool SpawnResourceBlobsOnPartDelete;
        /* 0x34 */ public bool EnableShootHitEffect;
        /* 0x38 */ public int MaxNumSameGroupTech;
        /* 0x3C */ public float ShootableAggroMinStartTime;
        /* 0x40 */ public float ShootableAggroForgetTime;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x44 */ public byte[] Padding44;
        /* 0x50 */ public Colour RefinerColour1A;
        /* 0x60 */ public Colour RefinerColour1B;
        /* 0x70 */ public Colour RefinerColour1C;
        /* 0x80 */ public Colour RefinerColour1D;
        /* 0x90 */ public float AtmosphereEntryTime;
        /* 0x94 */ public float AtmosphereEntryFadeTimeFactor;
        /* 0x98 */ public float AtmosphereEntryOffset;
        /* 0x9C */ public TkCurveType AtmosphereEntryCurve;
        /* 0xA0 */ public float TerrainResourceScanTime;
        /* 0xA4 */ public float TerrainResourceScanRange;
        /* 0xA8 */ public bool BinocsDisplayUnknownCreatures;
        /* 0xAC */ public float BinocularScanTargetMinHeight;
        /* 0xB0 */ public float BinocularScanTargetHeightRange;
        /* 0xB4 */ public float BinocTimeBeforeScan;
        /* 0xB8 */ public float BinocMinScanTime;
        /* 0xBC */ public float BinocScanTime;
        /* 0xC0 */ public float BinocCreatureScanTime;
        /* 0xC4 */ public TkCurveType BinocularScanTargetHeightCurve;
        /* 0xC8 */ public float BinocularScanTargetInitialFadeTime;
        /* 0xCC */ public float BinocularScanTargetScaler;
        /* 0xD0 */ public float BinocularScanTargetLineWidth;
        /* 0xD4 */ public float BinocularScanTargetFadeTime;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0xD8 */ public byte[] PaddingD8;
        /* 0xE0 */ public Colour BinocularScanTargetColour;
        /* 0xF0 */ public GcScanEffectData BinocularScanEffect;
        /* 0x140 */ public float ScannerIconsClumpRadius;
        /* 0x144 */ public float ScannableComponentMarkerOffset;
        /* 0x148 */ public float ScannableComponentPlaceMarkerOffset;
        /* 0x14C */ public float MissionEventAllowResetDistance;
        /* 0x150 */ public float AllRecipesKnownNanitesMin;
        /* 0x154 */ public float AllRecipesKnownNanitesMax;
        /* 0x158 */ public float MaxPossibleShipDamagePotential;
        /* 0x15C */ public float BuildingPlayerBaseIconOffset;
        /* 0x160 */ public float CriticalHitMultiplier;
        /* 0x164 */ public float HitEffectMinTime;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x168 */ public byte[] Padding168;
        /* 0x170 */ public GcScanEffectData DeconstructEffect;
        /* 0x1C0 */ public GcScanEffectData HitEffect;
        /* 0x210 */ public GcScanEffectData HitEffectCritical;
        /* 0x260 */ public float CommunicatorSpawnOffset;
        /* 0x264 */ public float CommunicatorSpawnHeightOffset;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x268 */ public byte[] Padding268;
        /* 0x270 */ public Vector4f CommunicatorShipSpawnOffset;
        /* 0x280 */ public float CommunicatorSpawnScale;
        /* 0x284 */ public float CommunicatorSpawnRotation;
        /* 0x288 */ public float CommunicatorFadeTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x28C */ public byte[] Padding28C;
        [NMS(Size = 0x2)]
        /* 0x290 */ public GcScanEffectData[] CommunicatorEffectTable;
        /* 0x330 */ public int MaxNumMissionsFromMissionGiver;
        /* 0x334 */ public float InteractionMessageModuleDisplayTime;
        /* 0x338 */ public float InteractionAttractTime;
        /* 0x33C */ public float InteractionDescriptionTextTime;
        /* 0x340 */ public float InteractionMinTimeForResponseText;
        /* 0x344 */ public bool InteractionOverride;
        /* 0x348 */ public int InteractionOverrideFrom;
        /* 0x34C */ public int InteractionOverrideTo;
        /* 0x350 */ public float DestroyEffectHeight;
        /* 0x354 */ public float DestroyEffectMaxScale;
        /* 0x358 */ public float EventTargetSpeed;
        /* 0x35C */ public int SpecialMiningAmount;
        /* 0x360 */ public float SpecialMiningTime;
        /* 0x364 */ public int HardModeTechDamageMidNum;
        /* 0x368 */ public int HardModeTechDamageMidPercent;
        /* 0x36C */ public int HardModeTechDamageHighPercent;
        /* 0x370 */ public float PirateInterestOverride;
        /* 0x374 */ public float PirateInterestDistance;
        [NMS(Size = 0x3)]
        /* 0x378 */ public int[] PirateInterestLevels;
        /* 0x384 */ public float SpaceCombatRadius;
        /* 0x388 */ public int WarpsBetweenBattles;
        /* 0x38C */ public float HoursBetweenBattles;
        /* 0x390 */ public float SpaceBattleRadius;
        /* 0x394 */ public float SpaceBattleAnyHostileShipsRadius;
        /* 0x398 */ public float FreighterBattleRadius;
        /* 0x39C */ public float MissileMaxTurnAngle;
        /* 0x3A0 */ public float MissileLockTime;
        /* 0x3A4 */ public float MissileReloadTime;
        /* 0x3A8 */ public float MissileRotateMin;
        /* 0x3AC */ public float MissileRotateMax;
        /* 0x3B0 */ public float MissileMaxSpeed;
        /* 0x3B4 */ public float MissileForceMin;
        /* 0x3B8 */ public float MissileForceMax;
        /* 0x3BC */ public float MissileBrakeForceMin;
        /* 0x3C0 */ public float MissileBrakeForceMax;
        /* 0x3C4 */ public float MissileThreatTime;
        /* 0x3C8 */ public float MissileBrakeTime;
        /* 0x3CC */ public float MissileHitRadius;
        /* 0x3D0 */ public float MissileOffset;
        /* 0x3D4 */ public float MissileMinCircleTime;
        /* 0x3D8 */ public float MissileApproachTime;
        /* 0x3DC */ public float MissileRotateSpeed;
        /* 0x3E0 */ public float ScanStartTimeDelayMinDist;
        /* 0x3E4 */ public float ScanStartTimeDelayRange;
        /* 0x3E8 */ public float ScanStartTimeDistanceDelayTime;
        /* 0x3EC */ public float ScanStickyDecay;
        /* 0x3F0 */ public float CreatureScanStickyDecay;
        /* 0x3F4 */ public float CreatureScanAngle;
        /* 0x3F8 */ public float CreatureMinScanTime;
        /* 0x3FC */ public float ScanAngle;
        /* 0x400 */ public float NewDiscoveryDisplayTime;
        /* 0x404 */ public bool FailToFindBuildings;
        /* 0x408 */ public int CritDamage;
        /* 0x40C */ public float CritScale;
        /* 0x410 */ public int NumMissionsPerSolarSystem;
        /* 0x414 */ public float EmergencyBuildingScanEventDistance;
        /* 0x418 */ public float EmergencyBuildingScanEventTime;
        /* 0x41C */ public float ProjectileLightIntensity;
        /* 0x420 */ public float AggressiveSentinelProbability;
        /* 0x424 */ public GcExperienceTimers SentinelTimers;
        /* 0x444 */ public int FreighterStartPecent;
        /* 0x448 */ public GcExperienceTimers FreighterTimers;
        /* 0x468 */ public GcExperienceTimers PirateTimers;
        /* 0x488 */ public GcExperienceTimers HardPirateTimers;
        [NMS(Size = 0x3)]
        /* 0x4A8 */ public float[] PirateEarlySpawnChances;
        /* 0x4B4 */ public float PirateEarlySpawnTime;
        /* 0x4B8 */ public GcExperienceTimers FlybyTimers;
        /* 0x4D8 */ public GcExperienceTimers SpaceFlybyTimers;
        /* 0x4F8 */ public int SentinelsHigh;
        /* 0x4FC */ public int SentinelsLow;
        /* 0x500 */ public float AsteroidHitForce;
        /* 0x504 */ public float AsteroidTorqueForce;
        /* 0x508 */ public float AsteroidCarveRadius;
        /* 0x50C */ public int DeathMoneyPenalty;
        /* 0x510 */ public int DeathMoneyPenaltyHardMode;
        /* 0x514 */ public int MaxResourceCrystalBlobSize;
        /* 0x518 */ public float BuildingBeamDistance;
        /* 0x51C */ public float WaypointScanTime;
        /* 0x520 */ public int RareSubstanceEffectiveness;
        /* 0x524 */ public int CommonProductEffectiveness;
        /* 0x528 */ public int RareProductEffectiveness;
        /* 0x52C */ public int AsteroidResourceReducer;
        /* 0x530 */ public float VoxelAsteroidResourceChance;
        /* 0x534 */ public int ResourceReducer;
        /* 0x538 */ public int ResourceMinAmount;
        /* 0x53C */ public int ResourceMaxAmount;
        /* 0x540 */ public int ResourceCommonReducer;
        /* 0x544 */ public int ResourceCommonMinAmount;
        /* 0x548 */ public int ResourceCommonMaxAmount;
        [NMS(Size = 0x20)]
        /* 0x54C */ public string RobotResource;
        [NMS(Size = 0x20)]
        /* 0x56C */ public string DepotResource;
        /* 0x58C */ public float DockNodeBuyRadius;
        /* 0x590 */ public float BeaconInteractRange;
        /* 0x594 */ public float ShipInteractRadius;
        /* 0x598 */ public GcResourceCollectEffect AsteroidResourceCollect;
        /* 0x5CC */ public float ScanAngleCutoff;
        /* 0x5D0 */ public GcScanData ToolScan;
        /* 0x5E4 */ public GcScanData ToolScanHardMode;
        /* 0x5F8 */ public GcScanData WaypointScan;
        /* 0x60C */ public GcScanData BeaconScan;
        /* 0x620 */ public GcScanData RadioTowerScan;
        /* 0x634 */ public GcScanData ObservatoryScan;
        /* 0x648 */ public GcScanData DistressSignalScan;
        /* 0x65C */ public GcScanData DebugScanPlanet;
        /* 0x670 */ public GcScanData DebugScanSpace;
        /* 0x684 */ public GcScanData ShipScan;
        /* 0x698 */ public GcScanData VisualScan;
        /* 0x6AC */ public float ZoomFindBuildingRange;
        /* 0x6B0 */ public float TimeToDisplayScanResults;
        /* 0x6B4 */ public float HoverTimeToScan;
        /* 0x6B8 */ public float HoverTimeToScanCreatures;
        /* 0x6BC */ public int HoverVisiblePointsNeeded;
        [NMS(Size = 0x4)]
        /* 0x6C0 */ public GcZoomData[] ZoomLevels;
        /* 0x730 */ public GcScanEffectData PassiveScanEffect;
        /* 0x780 */ public GcScanEffectData BuildingScanEffect;
        /* 0x7D0 */ public GcScanEffectData TargetShipScanEffect;
        /* 0x820 */ public GcScanEffectData HUDShipScanEffect;
        /* 0x870 */ public GcScanEffectData CreatureScanEffect;
        /* 0x8C0 */ public GcScanEffectData ObjectsScanEffect;
        /* 0x910 */ public GcScanEffectData BaseBuildingScanEffect;
        /* 0x960 */ public GcScanEffectData BaseBuildingBlockedScanEffect;
        /* 0x9B0 */ public GcScanEffectData BaseBuildingFreighterScanEffect;
        /* 0xA00 */ public GcScanEffectData BaseBuildingFreighterBlockedScanEffect;
        /* 0xA50 */ public GcScanEffectData BaseBuildingSelectionScanEffect;
        /* 0xAA0 */ public GcScanEffectData BaseBuildingRemotePlayerScanEffect;
        /* 0xAF0 */ public GcScanEffectData BaseBuildingRemotePlayerBlockedScanEffect;
        /* 0xB40 */ public GcScanEffectData BaseBuildingRemotePlayerFreighterScanEffect;
        /* 0xB90 */ public GcScanEffectData BaseBuildingRemotePlayerFreighterBlockedScanEffect;
        /* 0xBE0 */ public GcScanEffectData BaseBuildingRemotePlayerSelectionScanEffect;
        /* 0xC30 */ public bool UseDebugScan;
        /* 0xC31 */ public bool DebugScanForceBuilding;
        /* 0xC34 */ public float DebugScanForceBuildingType;
        /* 0xC38 */ public float ShipScanOffset;
        /* 0xC3C */ public float ShipScanOffsetGap;
        /* 0xC40 */ public TkCurveType ShipScanCurve;
        /* 0xC44 */ public float ScannerMarkerFadeTime;
        /* 0xC48 */ public float ScannerSmallMarkerFadeTime;
        /* 0xC4C */ public float ScannerPhysicsProbeAABBSize;
        /* 0xC50 */ public float ScannerAnalyzeFXRate;
        /* 0xC54 */ public float ScannerSubstanceTimePerTrigger;
        /* 0xC58 */ public float ScannerTuningA;
        /* 0xC5C */ public float ScannerTuningB;
        /* 0xC60 */ public float ScannerTuningC;
        /* 0xC64 */ public float ScannerTuningD;
        /* 0xC68 */ public float ScannerTuningResourceOffset1;
        /* 0xC6C */ public float ScannerTuningResourceOffset2;
        /* 0xC70 */ public float ScannerTuningSmoothStepAmount;
        /* 0xC74 */ public float ScannerTuningTrailingEdge;
        /* 0xC78 */ public bool Autolevel;
        /* 0xC80 */ public Colour ScannerColour1;
        /* 0xC90 */ public Colour ScannerColour2;
        /* 0xCA0 */ public float HUDStoreFlashTime;
        /* 0xCA4 */ public float ExcitingViewAngle;
        /* 0xCA8 */ public float ExcitingViewRange;
        /* 0xCAC */ public float ExcitingNearRange;
        /* 0xCB0 */ public float ProjectileSpeedBoost;
        /* 0xCB4 */ public float LineWidth;
        /* 0xCB8 */ public float LockOffFactor;
        /* 0xCBC */ public float OffscreenFadeDistance;
        /* 0xCC0 */ public float OffscreenMinDot;
        /* 0xCC4 */ public bool HUDUpdateFromData;
        /* 0xCC8 */ public float HUDLockOnAudioTime;
        /* 0xCCC */ public float HUDArrowPrimaryScaler;
        /* 0xCD0 */ public Vector2f HUDDamageSize;
        /* 0xCD8 */ public Vector2f HUDDamageSplatSize;
        /* 0xCE0 */ public Colour HUDDamageSplatShieldColour;
        /* 0xCF0 */ public Colour HUDDamageSplatPainColour;
        /* 0xD00 */ public float HUDDamageOffset;
        /* 0xD04 */ public float HUDDamageScaler;
        /* 0xD08 */ public float HUDDamageRadius;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xD0C */ public byte[] PaddingD0C;
        /* 0xD10 */ public GcShipHUDTargetData HUDTarget;
        /* 0x1140 */ public float HUDLabelTime;
        /* 0x1144 */ public float HUDLabelAngle;
        /* 0x1148 */ public float HUDLabelAngleOffset;
        /* 0x114C */ public float HUDLabelOffsetX;
        /* 0x1150 */ public float HUDLabelOffsetY;
        /* 0x1154 */ public float HUDLabelOffsetZ;
        /* 0x1158 */ public float HUDLabelScale;
        /* 0x115C */ public float MaxSpawnTime;
        [NMS(Size = 0x80)]
        /* 0x1160 */ public string ResourceParticleFile;
        /* 0x11E0 */ public float ResourceParticleSpeed;
        /* 0x11E4 */ public float ResourceParticleSpread;
        /* 0x11E8 */ public int ResourceParticleMaxNum;
        /* 0x11EC */ public int ResourceParticleMinNum;
        /* 0x11F0 */ public float MapHeight;
        /* 0x11F4 */ public float MapOffset;
        /* 0x11F8 */ public float MapTargetOffset;
        /* 0x11FC */ public float MapFOV;
        /* 0x1200 */ public float MapRadius;
        /* 0x1204 */ public float HUDScaleAdd;
        /* 0x1208 */ public float HUDScaleRadius;
        /* 0x120C */ public float HUDScaleMin;
        /* 0x1210 */ public float HUDScaleMinAim;
        /* 0x1214 */ public float HUDScaleMax;
        /* 0x1218 */ public float HUDScaleFarTarget;
        /* 0x121C */ public float HUDReticuleMoveBack;
        /* 0x1220 */ public float HUDReticuleMoveAim;
        /* 0x1224 */ public float MouseSensitivity;
        /* 0x1228 */ public float MouseSensitivityShip;
        /* 0x122C */ public float PainTime;
        /* 0x1230 */ public TkCurveType PainCurve;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x1234 */ public byte[] Padding1234;
        /* 0x1240 */ public Colour PainColour;
        /* 0x1250 */ public float GunOffsetX;
        /* 0x1254 */ public float GunOffsetY;
        /* 0x1258 */ public float GunOffsetZ;
        /* 0x125C */ public float GunDownAngle;
        /* 0x1260 */ public float GunUpAngle;
        /* 0x1264 */ public float BarrelOffset;
        /* 0x1268 */ public float HitOffset;
        /* 0x126C */ public GcTracerData BulletTracer;
        /* 0x1284 */ public GcTracerData ShipTracer;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x129C */ public byte[] Padding129C;
        [NMS(Size = 0x10)]
        /* 0x12A0 */ public string DefaultAnim;
        /* 0x12B0 */ public bool DebugDrawTriggerBoxes;
        /* 0x12B4 */ public float SpeedReadoutMultiplier;
        /* 0x12B8 */ public float SpaceSpeedReadoutMultiplier;
        /* 0x12BC */ public float TorchFoV;
        /* 0x12C0 */ public float TorchStrength;
        /* 0x12C4 */ public float TorchOffsetX;
        /* 0x12C8 */ public float TorchOffsetY;
        /* 0x12CC */ public float TorchOffsetZ;
        /* 0x12D0 */ public float TorchRotation;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x12D4 */ public byte[] Padding12D4;
        /* 0x12E0 */ public Colour TorchColour;
        /* 0x12F0 */ public float SimpleInteractionPickupAngle;
        /* 0x12F4 */ public float SimpleInteractionPickupRadius;
        /* 0x12F8 */ public float SimpleInteractionMessageTime;
        /* 0x12FC */ public float InteractionPickupAngle;
        /* 0x1300 */ public float InteractionPickupRadius;
        /* 0x1304 */ public float ExplosionRadiusMultiplier;
        /* 0x1308 */ public float ExplosionForce;
        /* 0x130C */ public float ExplosionForceMaxForceRadius;
        /* 0x1310 */ public float LaserExplosionForceRadius;
        /* 0x1314 */ public float LaserExplosionForce;
        /* 0x1318 */ public float LaserExplosionForceMaxForceRadius;
        [NMS(Size = 0x80)]
        /* 0x131C */ public string InitialDebrisScene;
        /* 0x139C */ public float BonusSameTypeElementsAdd;
        /* 0x13A0 */ public float BonusSameTypeElementsMultiply;
        /* 0x13A4 */ public float BonusChildTypeElementsAdd;
        /* 0x13A8 */ public float BonusChildTypeElementsMultiply;
        /* 0x13AC */ public float InteractionComponentUpdateDistance;
        /* 0x13B0 */ public float GoalGapVoxelDist;
        /* 0x13B4 */ public float BlackHoleJumpVoxelDist;
        /* 0x13B8 */ public float BlackHoleJumpVoxelVariation;
        /* 0x13BC */ public float JumpToCenterFuelCost;
        /* 0x13C0 */ public int WarpsBetweenMiniStation;
        /* 0x13C4 */ public float HoursBetweenMiniStation;
        [NMS(Size = 0x80)]
        /* 0x13C8 */ public string LegacyBaseBuildingTable;
        [NMS(Size = 0x80)]
        /* 0x1448 */ public string BaseBuildingTable;
        /* 0x14C8 */ public int NPCWorkerInteractionCooldownA;      // don't know... 8 bytes...
        /* 0x14CC */ public int NPCWorkerInteractionCooldownB;
        /* 0x14D0 */ public float LightStrength;
        /* 0x14D4 */ public float AirLockDoorRange;
        /* 0x14D8 */ public bool KeepAttackingMaxWantedLevel;
        /* 0x14D9 */ public bool UseMultiplierBonus;
        /* 0x14DC */ public float ShipDisplayDamageMultiplier;
        /* 0x14E0 */ public bool UseTradingCostTable;
        /* 0x14E1 */ public bool ChangePricesLocally;
        /* 0x14E2 */ public bool ShowPriceMarkupsAsPercentages;
        /* 0x14E4 */ public int ProductItemStockDecayTime;
        /* 0x14E8 */ public int ProductItemStockReplenishTime;
        /* 0x14EC */ public int SubstanceItemStockDecayTime;
        /* 0x14F0 */ public int SubstanceItemStockReplenishTime;
        /* 0x14F4 */ public GcPortalData Portal;
        /* 0x14FC */ public int FourthRaceSpawnPercentage;
        /* 0x1500 */ public float ViciousSentinelProbability;
        /* 0x1504 */ public float ViciousStormProbability;
        /* 0x1508 */ public float ViciousWeatherProbability;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x150C */ public byte[] Endpadding;
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