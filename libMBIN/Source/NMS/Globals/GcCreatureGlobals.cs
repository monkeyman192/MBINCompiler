using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x20D4071A22ADC9A8, NameHash = 0xD1168B3D)]
    public class GcCreatureGlobals : NMSTemplate
    {
        [NMS(Index = 97)]
        /* 0x0000 */ public GcCameraShakeData PainShake;
        [NMS(Index = 535)]
        /* 0x00C0 */ public GcScanEffectData PetOffPlanetEffect;
        [NMS(Index = 3)]
        /* 0x0110 */ public Colour AllCreaturesDiscoveredColour;
        [NMS(Index = 269)]
        /* 0x0120 */ public Colour JellyBossBroodIdleColour;
        [NMS(Index = 270)]
        /* 0x0130 */ public Colour JellyBossBroodProximityWarningColour;
        [NMS(Index = 266)]
        /* 0x0140 */ public Colour JellyBossIdleColour;
        [NMS(Index = 268)]
        /* 0x0150 */ public Colour JellyBossProjectileAttackWarningColour;
        [NMS(Index = 267)]
        /* 0x0160 */ public Colour JellyBossSpawnBroodWarningColour;
        [NMS(Index = 558)]
        /* 0x0170 */ public Colour PetInteractionLightColour;
        [NMS(Index = 456)]
        /* 0x0180 */ public Colour PetRadialBadColour;
        [NMS(Index = 459)]
        /* 0x0190 */ public Colour PetRadialBoostColour;
        [NMS(Index = 458)]
        /* 0x01A0 */ public Colour PetRadialGoodColour;
        [NMS(Index = 457)]
        /* 0x01B0 */ public Colour PetRadialNeutralColour;
        [NMS(Index = 550)]
        /* 0x01C0 */ public Colour PetThrowArcColour;
        [NMS(Index = 272)]
        /* 0x01D0 */ public Colour SpookFiendAggressiveColour;
        [NMS(Index = 274)]
        /* 0x01E0 */ public Colour SpookFiendKamikazeColour;
        [NMS(Index = 271)]
        /* 0x01F0 */ public Colour SpookFiendPassiveColour;
        [NMS(Index = 273)]
        /* 0x0200 */ public Colour SpookFiendSpitColour;
        [NMS(Index = 26, Size = 0x1C, EnumType = typeof(GcBiomeSubType.BiomeSubTypeEnum))]
        /* 0x0210 */ public NMSString0x20A[] WeirdBiomeDescriptions;
        [NMS(Index = 25, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x0590 */ public NMSString0x20A[] BiomeAirDescriptions;
        [NMS(Index = 23, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x0790 */ public NMSString0x20A[] BiomeDescriptions;
        [NMS(Index = 24, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x0990 */ public NMSString0x20A[] BiomeWaterDescriptions;
        [NMS(Index = 19, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x0B90 */ public NMSString0x20A[] DietMeat;
        [NMS(Index = 20, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x0D90 */ public NMSString0x20A[] DietVeg;
        [NMS(Index = 27, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x0F90 */ public NMSString0x20A[] PetBiomeClimates;
        [NMS(Index = 607)]
        /* 0x1190 */ public GcWeirdCreatureRewardList WeirdKillingRewards;
        [NMS(Index = 15, Size = 0xB, EnumType = typeof(GcCreatureRoles.CreatureRoleEnum))]
        /* 0x1350 */ public NMSString0x20A[] Temperments;
        [NMS(Index = 17, Size = 0x4, EnumType = typeof(GcCreatureDiet.DietEnum))]
        /* 0x14B0 */ public NMSString0x20A[] Diets;
        [NMS(Index = 18, Size = 0x4, EnumType = typeof(GcCreatureDiet.DietEnum))]
        /* 0x1530 */ public NMSString0x20A[] WaterDiets;
        [NMS(Index = 56)]
        /* 0x15B0 */ public NMSString0x20A CreatureFilter;
        [NMS(Index = 4)]
        /* 0x15D0 */ public NMSString0x20A PetCarePuzzleOverrideID;
        [NMS(Index = 178)]
        /* 0x15F0 */ public List<GcCreatureAlertData> AlertTable;
        [NMS(Index = 585)]
        /* 0x1600 */ public NMSString0x10 AlienShipQuestCreatureWeapon;
        [NMS(Index = 584)]
        /* 0x1610 */ public NMSString0x10 AlienShipQuestKillingSubstance;
        [NMS(Index = 600)]
        /* 0x1620 */ public NMSString0x10 BasicFeedingProduct;
        [NMS(Index = 606)]
        /* 0x1630 */ public List<GcCreatureFoodList> CarnivoreFeedingProducts;
        [NMS(Index = 417)]
        /* 0x1640 */ public NMSString0x10 CreatureDeathEffectBig;
        [NMS(Index = 416)]
        /* 0x1650 */ public NMSString0x10 CreatureDeathEffectMedium;
        [NMS(Index = 415)]
        /* 0x1660 */ public NMSString0x10 CreatureDeathEffectSmall;
        [NMS(Index = 200)]
        /* 0x1670 */ public NMSString0x10 CreatureHugeRunShake;
        [NMS(Index = 198)]
        /* 0x1680 */ public NMSString0x10 CreatureHugeWalkShake;
        [NMS(Index = 196)]
        /* 0x1690 */ public NMSString0x10 CreatureLargeRunShake;
        [NMS(Index = 194)]
        /* 0x16A0 */ public NMSString0x10 CreatureLargeWalkShake;
        [NMS(Index = 55)]
        /* 0x16B0 */ public GcSeed CreatureSeed;
        [NMS(Index = 583)]
        /* 0x16C0 */ public NMSString0x10 DefaultKillingSubstance;
        [NMS(Index = 418)]
        /* 0x16D0 */ public NMSString0x10 FishDeathEffect;
        [NMS(Index = 593)]
        /* 0x16E0 */ public List<GcCreatureHarvestSubstanceList> HarvestingProducts;
        [NMS(Index = 605)]
        /* 0x16F0 */ public List<GcCreatureFoodList> HerbivoreFeedingProducts;
        [NMS(Index = 601)]
        /* 0x1700 */ public NMSString0x10 HorrorPetFeedingProduct;
        [NMS(Index = 592)]
        /* 0x1710 */ public List<GcCreatureSubstanceList> KillingProducts;
        [NMS(Index = 586)]
        /* 0x1720 */ public List<NMSString0x10> KillingSubstances;
        [NMS(Index = 608)]
        /* 0x1730 */ public List<NMSString0x10> LootItems;
        [NMS(Index = 537)]
        /* 0x1740 */ public VariableSizeString PetEggHatchResourceFile;
        [NMS(Index = 503)]
        /* 0x1750 */ public NMSString0x10 PetEggMaxChangeProduct;
        [NMS(Index = 536)]
        /* 0x1760 */ public VariableSizeString PetEggResourceFile;
        [NMS(Index = 544)]
        /* 0x1770 */ public NMSString0x10 PetEggsplosionEffect;
        [NMS(Index = 442)]
        /* 0x1780 */ public NMSString0x10 PetScan;
        [NMS(Index = 602)]
        /* 0x1790 */ public NMSString0x10 RobotFeedingProduct;
        [NMS(Index = 610)]
        /* 0x17A0 */ public List<float> RockTransformChanceModifiers;
        [NMS(Index = 276)]
        /* 0x17B0 */ public List<GcSpookFiendSpawnData> SpookFiendsSpawnData;
        [NMS(Index = 177)]
        /* 0x17C0 */ public GcFlyingSnakeData FlyingSnakeData;
        [NMS(Index = 262)]
        /* 0x1800 */ public Vector2f JellyBossBroodMaxChaseTime;
        [NMS(Index = 275)]
        /* 0x1808 */ public Vector2f SpookFiendsSpawnTimer;
        [NMS(Index = 211)]
        /* 0x1810 */ public float AdultBabyKilledNoticeDistance;
        [NMS(Index = 576)]
        /* 0x1814 */ public float AdultCorrelationValue;
        [NMS(Index = 161)]
        /* 0x1818 */ public float AlertDistance;
        [NMS(Index = 2)]
        /* 0x181C */ public int AllCreaturesDiscoveredBonusMul;
        [NMS(Index = 611)]
        /* 0x1820 */ public float AngryRockProportionNormal;
        [NMS(Index = 612)]
        /* 0x1824 */ public float AngryRockProportionSurvival;
        [NMS(Index = 176)]
        /* 0x1828 */ public float AnimationStickToGroundSpeed;
        [NMS(Index = 559)]
        /* 0x182C */ public float AnimChangeCoolDown;
        [NMS(Index = 324)]
        /* 0x1830 */ public float AsteroidCreatureRichSystemSpawnPercent;
        [NMS(Index = 323)]
        /* 0x1834 */ public float AsteroidCreatureSpawnPercentOverride;
        [NMS(Index = 391)]
        /* 0x1838 */ public float AttackPlayerDistance;
        [NMS(Index = 485)]
        /* 0x183C */ public float AttractedMaxAvoidCreaturesDist;
        [NMS(Index = 484)]
        /* 0x1840 */ public float AttractedMaxAvoidCreaturesStrength;
        [NMS(Index = 483)]
        /* 0x1844 */ public float AttractedMinAvoidCreaturesDist;
        [NMS(Index = 482)]
        /* 0x1848 */ public float AttractedMinAvoidCreaturesStrength;
        [NMS(Index = 148)]
        /* 0x184C */ public float AttractMinDistance;
        [NMS(Index = 352)]
        /* 0x1850 */ public float AvoidCreaturesWeight;
        [NMS(Index = 353)]
        /* 0x1854 */ public float AvoidImpassableWeight;
        [NMS(Index = 338)]
        /* 0x1858 */ public float BadTurnPercent;
        [NMS(Index = 339)]
        /* 0x185C */ public float BadTurnWeight;
        [NMS(Index = 354)]
        /* 0x1860 */ public float BaseAndTerrainModImpassableStrength;
        [NMS(Index = 347)]
        /* 0x1864 */ public float BrakingForce;
        [NMS(Index = 348)]
        /* 0x1868 */ public float BrakingForceY;
        [NMS(Index = 285)]
        /* 0x186C */ public int BugFiendHealth;
        [NMS(Index = 280)]
        /* 0x1870 */ public int BugQueenHealth;
        [NMS(Index = 284)]
        /* 0x1874 */ public float BugQueenSpitballExplosionRadius;
        [NMS(Index = 283)]
        /* 0x1878 */ public float BugQueenSpitballSpeed;
        [NMS(Index = 281)]
        /* 0x187C */ public int BugQueenSpitCount;
        [NMS(Index = 282)]
        /* 0x1880 */ public float BugQueenSpitRadius;
        [NMS(Index = 189)]
        /* 0x1884 */ public float CreatureBlobRidingHugeMinSize;
        [NMS(Index = 188)]
        /* 0x1888 */ public float CreatureBlobRidingLargeMinSize;
        [NMS(Index = 187)]
        /* 0x188C */ public float CreatureBlobRidingMedMinSize;
        [NMS(Index = 82)]
        /* 0x1890 */ public float CreatureBrakeForce;
        [NMS(Index = 597)]
        /* 0x1894 */ public int CreatureHarvestAmountHuge;
        [NMS(Index = 596)]
        /* 0x1898 */ public int CreatureHarvestAmountLarge;
        [NMS(Index = 595)]
        /* 0x189C */ public int CreatureHarvestAmountMed;
        [NMS(Index = 594)]
        /* 0x18A0 */ public int CreatureHarvestAmountSmall;
        [NMS(Index = 77)]
        /* 0x18A4 */ public float CreatureHearingRange;
        [NMS(Index = 193)]
        /* 0x18A8 */ public int CreatureHugeHealth;
        [NMS(Index = 183)]
        /* 0x18AC */ public float CreatureHugeMinSize;
        [NMS(Index = 201)]
        /* 0x18B0 */ public float CreatureHugeRunMaxShakeDist;
        [NMS(Index = 199)]
        /* 0x18B4 */ public float CreatureHugeWalkMaxShakeDist;
        [NMS(Index = 580)]
        /* 0x18B8 */ public float CreatureIndoorSpeedMultiplier;
        [NMS(Index = 13)]
        /* 0x18BC */ public float CreatureInteractBaseRange;
        [NMS(Index = 5)]
        /* 0x18C0 */ public float CreatureInteractionRangeBoostHuge;
        [NMS(Index = 6)]
        /* 0x18C4 */ public float CreatureInteractionRangeBoostLarge;
        [NMS(Index = 7)]
        /* 0x18C8 */ public float CreatureInteractionRangeBoostMedium;
        [NMS(Index = 9)]
        /* 0x18CC */ public float CreatureInteractionRangeBoostRun;
        [NMS(Index = 8)]
        /* 0x18D0 */ public float CreatureInteractionRangeBoostSmall;
        [NMS(Index = 10)]
        /* 0x18D4 */ public float CreatureInteractionRangeBoostSprint;
        [NMS(Index = 11)]
        /* 0x18D8 */ public float CreatureInteractionRangeReducePredator;
        [NMS(Index = 587)]
        /* 0x18DC */ public int CreatureKillRewardAmountFiend;
        [NMS(Index = 591)]
        /* 0x18E0 */ public int CreatureKillRewardAmountHuge;
        [NMS(Index = 590)]
        /* 0x18E4 */ public int CreatureKillRewardAmountLarge;
        [NMS(Index = 589)]
        /* 0x18E8 */ public int CreatureKillRewardAmountMed;
        [NMS(Index = 588)]
        /* 0x18EC */ public int CreatureKillRewardAmountSmall;
        [NMS(Index = 192)]
        /* 0x18F0 */ public int CreatureLargeHealth;
        [NMS(Index = 182)]
        /* 0x18F4 */ public float CreatureLargeMinSize;
        [NMS(Index = 197)]
        /* 0x18F8 */ public float CreatureLargeRunMaxShakeDist;
        [NMS(Index = 195)]
        /* 0x18FC */ public float CreatureLargeWalkMaxShakeDist;
        [NMS(Index = 86)]
        /* 0x1900 */ public float CreatureLookBeforeFleeingIfShotTime;
        [NMS(Index = 85)]
        /* 0x1904 */ public float CreatureLookBeforeFleeingTime;
        [NMS(Index = 84)]
        /* 0x1908 */ public float CreatureLookBeforeGoingTime;
        [NMS(Index = 88)]
        /* 0x190C */ public float CreatureLookPlayerForceLookTime;
        [NMS(Index = 87)]
        /* 0x1910 */ public float CreatureLookScaryThingTime;
        [NMS(Index = 191)]
        /* 0x1914 */ public int CreatureMedHealth;
        [NMS(Index = 181)]
        /* 0x1918 */ public float CreatureMedMinSize;
        [NMS(Index = 70)]
        /* 0x191C */ public float CreatureMinAlignSpeed;
        [NMS(Index = 83)]
        /* 0x1920 */ public float CreatureMinAnimMoveSpeed;
        [NMS(Index = 76)]
        /* 0x1924 */ public float CreatureMinRunTime;
        [NMS(Index = 79)]
        /* 0x1928 */ public float CreatureMoveIdle;
        [NMS(Index = 186)]
        /* 0x192C */ public float CreatureRidingHugeMinSize;
        [NMS(Index = 185)]
        /* 0x1930 */ public float CreatureRidingLargeMinSize;
        [NMS(Index = 184)]
        /* 0x1934 */ public float CreatureRidingMedMinSize;
        [NMS(Index = 39)]
        /* 0x1938 */ public float CreatureScaleMangle;
        [NMS(Index = 78)]
        /* 0x193C */ public float CreatureSightRange;
        [NMS(Index = 190)]
        /* 0x1940 */ public int CreatureSmallHealth;
        [NMS(Index = 581)]
        /* 0x1944 */ public float CreatureSpeedMultiplier;
        [NMS(Index = 81)]
        /* 0x1948 */ public float CreatureTurnMax;
        [NMS(Index = 80)]
        /* 0x194C */ public float CreatureTurnMin;
        [NMS(Index = 614)]
        /* 0x1950 */ public float CreatureUpdateRateMultiplier;
        [NMS(Index = 75)]
        /* 0x1954 */ public float CreatureWaryTime;
        [NMS(Index = 363)]
        /* 0x1958 */ public float DefaultRunMoveSpeed;
        [NMS(Index = 362)]
        /* 0x195C */ public float DefaultTrotMoveSpeed;
        [NMS(Index = 361)]
        /* 0x1960 */ public float DefaultWalkMoveSpeed;
        [NMS(Index = 236)]
        /* 0x1964 */ public float DelayAfterRespawnBeforeAttackable;
        [NMS(Index = 400)]
        /* 0x1968 */ public float DespawnDistFactor;
        [NMS(Index = 410)]
        /* 0x196C */ public float DetailAnimBlendInTime;
        [NMS(Index = 411)]
        /* 0x1970 */ public float DetailAnimBlendOutTime;
        [NMS(Index = 413)]
        /* 0x1974 */ public float DetailAnimMaxPauseTime;
        [NMS(Index = 412)]
        /* 0x1978 */ public float DetailAnimMinPauseTime;
        [NMS(Index = 150)]
        /* 0x197C */ public float DroneExplodeRadius;
        [NMS(Index = 368)]
        /* 0x1980 */ public float EdgeClosenessPenalty;
        [NMS(Index = 100)]
        /* 0x1984 */ public float ExtraFollowFreq1;
        [NMS(Index = 101)]
        /* 0x1988 */ public float ExtraFollowFreq2;
        [NMS(Index = 99)]
        /* 0x198C */ public float ExtraFollowStrength;
        [NMS(Index = 397)]
        /* 0x1990 */ public float FadeDistance;
        [NMS(Index = 395)]
        /* 0x1994 */ public float FadeScaleMultiplier;
        [NMS(Index = 396)]
        /* 0x1998 */ public float FadeScalePower;
        [NMS(Index = 358)]
        /* 0x199C */ public float FastSwimSpeed;
        [NMS(Index = 479)]
        /* 0x19A0 */ public float FeedingFollowTime;
        [NMS(Index = 481)]
        /* 0x19A4 */ public float FeedingNoticeDistance;
        [NMS(Index = 480)]
        /* 0x19A8 */ public float FeedingNoticeTime;
        [NMS(Index = 478)]
        /* 0x19AC */ public int FeedingTaskAmount;
        [NMS(Index = 309)]
        /* 0x19B0 */ public float FiendAggroDecreasePerSpawn;
        [NMS(Index = 307)]
        /* 0x19B4 */ public float FiendAggroIncreaseDamageEgg;
        [NMS(Index = 308)]
        /* 0x19B8 */ public float FiendAggroIncreaseDestroyEgg;
        [NMS(Index = 296)]
        /* 0x19BC */ public float FiendAggroTime;
        [NMS(Index = 313)]
        /* 0x19C0 */ public float FiendBeingShotMemoryTime;
        [NMS(Index = 310)]
        /* 0x19C4 */ public float FiendCritAreaSize;
        [NMS(Index = 293)]
        /* 0x19C8 */ public float FiendDespawnDistance;
        [NMS(Index = 312)]
        /* 0x19CC */ public float FiendDistReduceForBeingShot;
        [NMS(Index = 311)]
        /* 0x19D0 */ public float FiendDistToConsiderTargetSwtich;
        [NMS(Index = 302)]
        /* 0x19D4 */ public int FiendEggsToUnlockSpit;
        [NMS(Index = 286)]
        /* 0x19D8 */ public int FiendHealth;
        [NMS(Index = 290)]
        /* 0x19DC */ public float FiendHealthLevelMul;
        [NMS(Index = 298)]
        /* 0x19E0 */ public int FiendMaxAttackers;
        [NMS(Index = 297)]
        /* 0x19E4 */ public int FiendMaxEngaged;
        [NMS(Index = 306)]
        /* 0x19E8 */ public float FiendMaxSpawnTime;
        [NMS(Index = 299)]
        /* 0x19EC */ public float FiendMaxVerticalForPounce;
        [NMS(Index = 305)]
        /* 0x19F0 */ public float FiendMinSpawnTime;
        [NMS(Index = 291)]
        /* 0x19F4 */ public float FiendPerceptionDistance;
        [NMS(Index = 279)]
        /* 0x19F8 */ public float FiendPounceDistanceModifier;
        [NMS(Index = 295)]
        /* 0x19FC */ public float FiendReplicateEndDistance;
        [NMS(Index = 294)]
        /* 0x1A00 */ public float FiendReplicateStartDistance;
        [NMS(Index = 292)]
        /* 0x1A04 */ public float FiendSpawnDistance;
        [NMS(Index = 300)]
        /* 0x1A08 */ public float FiendZigZagSpeed;
        [NMS(Index = 301)]
        /* 0x1A0C */ public float FiendZigZagStrength;
        [NMS(Index = 140)]
        /* 0x1A10 */ public float FishBobAmplitude;
        [NMS(Index = 139)]
        /* 0x1A14 */ public float FishBobFrequency;
        [NMS(Index = 378)]
        /* 0x1A18 */ public float FishDesiredDepth;
        [NMS(Index = 320)]
        /* 0x1A1C */ public float FishFiendBigBoostStrength;
        [NMS(Index = 321)]
        /* 0x1A20 */ public float FishFiendBigBoostTime;
        [NMS(Index = 316)]
        /* 0x1A24 */ public int FishFiendBigHealth;
        [NMS(Index = 322)]
        /* 0x1A28 */ public float FishFiendBigScale;
        [NMS(Index = 317)]
        /* 0x1A2C */ public float FishFiendSmallBoostStrength;
        [NMS(Index = 318)]
        /* 0x1A30 */ public float FishFiendSmallBoostTime;
        [NMS(Index = 315)]
        /* 0x1A34 */ public int FishFiendSmallHealth;
        [NMS(Index = 319)]
        /* 0x1A38 */ public float FishFiendSmallScale;
        [NMS(Index = 379)]
        /* 0x1A3C */ public float FishMinHeightAboveSeaBed;
        [NMS(Index = 381)]
        /* 0x1A40 */ public float FishObstacleAvoidStrength;
        [NMS(Index = 383)]
        /* 0x1A44 */ public float FishPlayerAttractionAhead;
        [NMS(Index = 382)]
        /* 0x1A48 */ public float FishPlayerAttractionFrontDist;
        [NMS(Index = 385)]
        /* 0x1A4C */ public float FishPlayerAttractionMaxDist;
        [NMS(Index = 384)]
        /* 0x1A50 */ public float FishPlayerAttractionMinDist;
        [NMS(Index = 386)]
        /* 0x1A54 */ public float FishPlayerAttractionStrength;
        [NMS(Index = 223)]
        /* 0x1A58 */ public float FishPredatorChargeDist;
        [NMS(Index = 224)]
        /* 0x1A5C */ public float FishPredatorChargeDistScale;
        [NMS(Index = 380)]
        /* 0x1A60 */ public float FishSeaBedAvoidStrength;
        [NMS(Index = 159)]
        /* 0x1A64 */ public float FishSpeedMax;
        [NMS(Index = 158)]
        /* 0x1A68 */ public float FishSpeedMin;
        [NMS(Index = 160)]
        /* 0x1A6C */ public float FishSwimMaxAcceleration;
        [NMS(Index = 164)]
        /* 0x1A70 */ public float FishTurn;
        [NMS(Index = 376)]
        /* 0x1A74 */ public float FishWaterSurfaceAnticipate;
        [NMS(Index = 377)]
        /* 0x1A78 */ public float FishWaterSurfaceAvoidStrength;
        [NMS(Index = 387)]
        /* 0x1A7C */ public float FloaterObstacleAvoidStrength;
        [NMS(Index = 388)]
        /* 0x1A80 */ public float FloaterSteeringRayLength;
        [NMS(Index = 389)]
        /* 0x1A84 */ public float FloaterSteeringRaySphereSize;
        [NMS(Index = 390)]
        /* 0x1A88 */ public float FloaterSteeringRaySpread;
        [NMS(Index = 374)]
        /* 0x1A8C */ public float FloaterSurfaceAnticipate;
        [NMS(Index = 375)]
        /* 0x1A90 */ public float FloaterSurfaceAvoidStrength;
        [NMS(Index = 349)]
        /* 0x1A94 */ public float FlowFieldWeight;
        [NMS(Index = 355)]
        /* 0x1A98 */ public float FollowLeaderAlignWeight;
        [NMS(Index = 356)]
        /* 0x1A9C */ public float FollowLeaderCohereWeight;
        [NMS(Index = 423)]
        /* 0x1AA0 */ public float FollowPlayerDistance;
        [NMS(Index = 425)]
        /* 0x1AA4 */ public float FollowRange;
        [NMS(Index = 424)]
        /* 0x1AA8 */ public float FollowRunPlayerDistance;
        [NMS(Index = 350)]
        /* 0x1AAC */ public float FollowWeight;
        [NMS(Index = 172)]
        /* 0x1AB0 */ public float FootDustGroundTintStrength;
        [NMS(Index = 419)]
        /* 0x1AB4 */ public float FootParticleTime;
        [NMS(Index = 95)]
        /* 0x1AB8 */ public float FootPlantError;
        [NMS(Index = 243)]
        /* 0x1ABC */ public float FreighterDespawnDist;
        [NMS(Index = 142)]
        /* 0x1AC0 */ public float FreighterJellyBobAmplitude;
        [NMS(Index = 141)]
        /* 0x1AC4 */ public float FreighterJellyBobFrequency;
        [NMS(Index = 242)]
        /* 0x1AC8 */ public float FreighterSpawnDist;
        [NMS(Index = 477)]
        /* 0x1ACC */ public int FriendlyCreatureLimit;
        [NMS(Index = 578)]
        /* 0x1AD0 */ public float GrassPushMaxSize;
        [NMS(Index = 577)]
        /* 0x1AD4 */ public float GrassPushRadius;
        [NMS(Index = 127)]
        /* 0x1AD8 */ public float GroundWormScaleMax;
        [NMS(Index = 126)]
        /* 0x1ADC */ public float GroundWormScaleMin;
        [NMS(Index = 125)]
        /* 0x1AE0 */ public float GroundWormSpawnChance;
        [NMS(Index = 122)]
        /* 0x1AE4 */ public float GroundWormSpawnerActivateRadius;
        [NMS(Index = 123)]
        /* 0x1AE8 */ public float GroundWormSpawnerDestroyRadiusActive;
        [NMS(Index = 124)]
        /* 0x1AEC */ public float GroundWormSpawnerDestroyRadiusInactive;
        [NMS(Index = 121)]
        /* 0x1AF0 */ public int GroundWormSpawnMax;
        [NMS(Index = 120)]
        /* 0x1AF4 */ public int GroundWormSpawnMin;
        [NMS(Index = 117)]
        /* 0x1AF8 */ public float GroundWormSpawnRadius;
        [NMS(Index = 118)]
        /* 0x1AFC */ public float GroundWormSpawnSpacing;
        [NMS(Index = 119)]
        /* 0x1B00 */ public float GroundWormSpawnTimeOut;
        [NMS(Index = 571)]
        /* 0x1B04 */ public float GroupBabyHealthMultiplier;
        [NMS(Index = 569)]
        /* 0x1B08 */ public float GroupBabyProportion;
        [NMS(Index = 561)]
        /* 0x1B0C */ public float GroupBabyRunProbability;
        [NMS(Index = 570)]
        /* 0x1B10 */ public float GroupBabyScale;
        [NMS(Index = 568)]
        /* 0x1B14 */ public float GroupFemaleProportion;
        [NMS(Index = 565)]
        /* 0x1B18 */ public float GroupLookAtDurationMax;
        [NMS(Index = 564)]
        /* 0x1B1C */ public float GroupLookAtDurationMin;
        [NMS(Index = 563)]
        /* 0x1B20 */ public float GroupLookAtProbability;
        [NMS(Index = 567)]
        /* 0x1B24 */ public float GroupRunDurationMax;
        [NMS(Index = 566)]
        /* 0x1B28 */ public float GroupRunDurationMin;
        [NMS(Index = 560)]
        /* 0x1B2C */ public float GroupRunProbability;
        [NMS(Index = 562)]
        /* 0x1B30 */ public float GroupRunStormProbability;
        [NMS(Index = 599)]
        /* 0x1B34 */ public float HarvestCooldownMax;
        [NMS(Index = 598)]
        /* 0x1B38 */ public float HarvestCooldownMin;
        [NMS(Index = 367)]
        /* 0x1B3C */ public float HeightDiffPenalty;
        [NMS(Index = 155)]
        /* 0x1B40 */ public float HeightLookAhead;
        [NMS(Index = 573)]
        /* 0x1B44 */ public float HerdGroupSizeMultiplier;
        [NMS(Index = 341)]
        /* 0x1B48 */ public float ImpassabilityBrakeTime;
        [NMS(Index = 343)]
        /* 0x1B4C */ public float ImpassabilityTurnSpeedMultiplier;
        [NMS(Index = 342)]
        /* 0x1B50 */ public float ImpassabilityUnbrakeTime;
        [NMS(Index = 238)]
        /* 0x1B54 */ public float IndoorObstacleAvoidStrength;
        [NMS(Index = 239)]
        /* 0x1B58 */ public float IndoorSteeringRayLength;
        [NMS(Index = 240)]
        /* 0x1B5C */ public float IndoorSteeringRaySphereSize;
        [NMS(Index = 241)]
        /* 0x1B60 */ public float IndoorSteeringRaySpread;
        [NMS(Index = 237)]
        /* 0x1B64 */ public float IndoorTurnTime;
        [NMS(Index = 146)]
        /* 0x1B68 */ public float InfluenceDeflect;
        [NMS(Index = 144)]
        /* 0x1B6C */ public float InfluenceForce;
        [NMS(Index = 143)]
        /* 0x1B70 */ public float InfluenceRadius;
        [NMS(Index = 145)]
        /* 0x1B74 */ public float InfluenceThreshold;
        [NMS(Index = 264)]
        /* 0x1B78 */ public float JellyBossBroodColourInterpTime;
        [NMS(Index = 261)]
        /* 0x1B7C */ public float JellyBossBroodSeparateTime;
        [NMS(Index = 260)]
        /* 0x1B80 */ public float JellyBossBroodWarningRadius;
        [NMS(Index = 263)]
        /* 0x1B84 */ public float JellyBossColourInterpTime;
        [NMS(Index = 360)]
        /* 0x1B88 */ public float JellyBossFastSwimSpeed;
        [NMS(Index = 372)]
        /* 0x1B8C */ public float JellyBossLandAnticipate;
        [NMS(Index = 373)]
        /* 0x1B90 */ public float JellyBossLandAvoidStrength;
        [NMS(Index = 207)]
        /* 0x1B94 */ public float LargeCreatureAvoidPlayerDistance;
        [NMS(Index = 205)]
        /* 0x1B98 */ public float LargeCreatureFleePlayerDistance;
        [NMS(Index = 203)]
        /* 0x1B9C */ public float largeCreaturePerceptionDistance;
        [NMS(Index = 92)]
        /* 0x1BA0 */ public float LookMaxPitchWhenMoving;
        [NMS(Index = 89)]
        /* 0x1BA4 */ public float LookMaxYawMoving;
        [NMS(Index = 90)]
        /* 0x1BA8 */ public float LookMaxYawStatic;
        [NMS(Index = 91)]
        /* 0x1BAC */ public float LookPitchAtMaxYaw;
        [NMS(Index = 93)]
        /* 0x1BB0 */ public float LookRollAtMaxYaw;
        [NMS(Index = 94)]
        /* 0x1BB4 */ public float LookRollWhenMoving;
        [NMS(Index = 60)]
        /* 0x1BB8 */ public float LowPerfFlockReduce;
        [NMS(Index = 59)]
        /* 0x1BBC */ public int MaxAdditionalEcosystemCreaturesForDiscovery;
        [NMS(Index = 572)]
        /* 0x1BC0 */ public float MaxBirdsProportion;
        [NMS(Index = 49)]
        /* 0x1BC4 */ public float MaxCreatureSize;
        [NMS(Index = 58)]
        /* 0x1BC8 */ public int MaxEcosystemCreaturesLow;
        [NMS(Index = 57)]
        /* 0x1BCC */ public int MaxEcosystemCreaturesNormal;
        [NMS(Index = 402)]
        /* 0x1BD0 */ public float MaxFade;
        [NMS(Index = 303)]
        /* 0x1BD4 */ public int MaxFiendsToSpawn;
        [NMS(Index = 304)]
        /* 0x1BD8 */ public int MaxFiendsToSpawnCarnage;
        [NMS(Index = 314)]
        /* 0x1BDC */ public int MaxFishFiends;
        [NMS(Index = 167)]
        /* 0x1BE0 */ public float MaxForce;
        [NMS(Index = 156)]
        /* 0x1BE4 */ public float MaxHeightTime;
        [NMS(Index = 333)]
        /* 0x1BE8 */ public int MaxRagdollsBeforeDespawnOffscreen;
        [NMS(Index = 334)]
        /* 0x1BEC */ public int MaxRagdollsBeforeDespawnOnscreen;
        [NMS(Index = 50)]
        /* 0x1BF0 */ public float MaxRideLeanCounterRotate;
        [NMS(Index = 166)]
        /* 0x1BF4 */ public float MaxSpeed;
        [NMS(Index = 168)]
        /* 0x1BF8 */ public float MaxTorque;
        [NMS(Index = 336)]
        /* 0x1BFC */ public float MaxTurnRadius;
        [NMS(Index = 401)]
        /* 0x1C00 */ public float MinFade;
        [NMS(Index = 256)]
        /* 0x1C04 */ public float MiniDroneEnergyRecoverRate;
        [NMS(Index = 257)]
        /* 0x1C08 */ public float MiniDroneEnergyUsePerShot;
        [NMS(Index = 258)]
        /* 0x1C0C */ public float MiniDroneShotDelay;
        [NMS(Index = 259)]
        /* 0x1C10 */ public float MiniDroneShotMaxAngle;
        [NMS(Index = 475)]
        /* 0x1C14 */ public float MiningRandomProbability;
        [NMS(Index = 48)]
        /* 0x1C18 */ public float MinRideSize;
        [NMS(Index = 340)]
        /* 0x1C1C */ public float MinScaleForNavMap;
        [NMS(Index = 169)]
        /* 0x1C20 */ public float MinWaterSpawnDepth;
        [NMS(Index = 344)]
        /* 0x1C24 */ public float NavMapLookAhead;
        [NMS(Index = 0)]
        /* 0x1C28 */ public int NumCreaturesRequiredForDiscoveryMission;
        [NMS(Index = 1)]
        /* 0x1C2C */ public int NumWeirdCreaturesRequiredForDiscoveryMission;
        [NMS(Index = 210)]
        /* 0x1C30 */ public float PassiveFleePlayerDistance;
        [NMS(Index = 371)]
        /* 0x1C34 */ public float PathOverestimate;
        [NMS(Index = 74)]
        /* 0x1C38 */ public float PatrolGradientFactor;
        [NMS(Index = 73)]
        /* 0x1C3C */ public float PatrolHeightOffset;
        [NMS(Index = 72)]
        /* 0x1C40 */ public float PatrolMaxDist;
        [NMS(Index = 71)]
        /* 0x1C44 */ public float PatrolMinDist;
        [NMS(Index = 98)]
        /* 0x1C48 */ public float PatrolSwitchMinTime;
        [NMS(Index = 613)]
        /* 0x1C4C */ public int PauseBetweenCreatureSpawnRequests;
        [NMS(Index = 369)]
        /* 0x1C50 */ public float PelvisIkStrength;
        [NMS(Index = 212)]
        /* 0x1C54 */ public float PercentagePlayerPredators;
        [NMS(Index = 405)]
        /* 0x1C58 */ public int PerceptionUpdateRate;
        [NMS(Index = 553)]
        /* 0x1C5C */ public float PetAccessoryMoodDisplayThreshold;
        [NMS(Index = 554)]
        /* 0x1C60 */ public float PetAccessoryStateInterval;
        [NMS(Index = 526)]
        /* 0x1C64 */ public float PetAnimSpeedBoostSmallerThan;
        [NMS(Index = 527)]
        /* 0x1C68 */ public float PetAnimSpeedBoostStrength;
        [NMS(Index = 528)]
        /* 0x1C6C */ public float PetAnimSpeedMax;
        [NMS(Index = 529)]
        /* 0x1C70 */ public float PetAnimSpeedMin;
        [NMS(Index = 460)]
        /* 0x1C74 */ public float PetChatCooldown;
        [NMS(Index = 461)]
        /* 0x1C78 */ public float PetChatUseTraitTemplateChance;
        [NMS(Index = 465)]
        /* 0x1C7C */ public float PetEffectSpawnOffsetHuge;
        [NMS(Index = 464)]
        /* 0x1C80 */ public float PetEffectSpawnOffsetLarge;
        [NMS(Index = 463)]
        /* 0x1C84 */ public float PetEffectSpawnOffsetMed;
        [NMS(Index = 462)]
        /* 0x1C88 */ public float PetEffectSpawnOffsetSmall;
        [NMS(Index = 514)]
        /* 0x1C8C */ public float PetEggAccessoryChanceModifier;
        [NMS(Index = 516)]
        /* 0x1C90 */ public float PetEggColourChanceModifier;
        [NMS(Index = 500)]
        /* 0x1C94 */ public int PetEggFirstEggDelay;
        [NMS(Index = 520)]
        /* 0x1C98 */ public float PetEggHatchColourChangeChance;
        [NMS(Index = 539)]
        /* 0x1C9C */ public float PetEggHatchOffset;
        [NMS(Index = 538)]
        /* 0x1CA0 */ public float PetEggHatchScale;
        [NMS(Index = 518)]
        /* 0x1CA4 */ public float PetEggHatchScaleChange;
        [NMS(Index = 519)]
        /* 0x1CA8 */ public float PetEggHatchTraitChange;
        [NMS(Index = 498)]
        /* 0x1CAC */ public float PetEggLayingDuration;
        [NMS(Index = 499)]
        /* 0x1CB0 */ public int PetEggLayingInterval;
        [NMS(Index = 515)]
        /* 0x1CB4 */ public float PetEggMaxAccessoriesChangeChance;
        [NMS(Index = 517)]
        /* 0x1CB8 */ public float PetEggMaxColourChangeChance;
        [NMS(Index = 510)]
        /* 0x1CBC */ public float PetEggMaxDistStep;
        [NMS(Index = 541)]
        /* 0x1CC0 */ public float PetEggMaxHungry;
        [NMS(Index = 540)]
        /* 0x1CC4 */ public float PetEggMaxLonely;
        [NMS(Index = 512)]
        /* 0x1CC8 */ public float PetEggMaxOverdosage;
        [NMS(Index = 513)]
        /* 0x1CCC */ public float PetEggMaxTopDescriptorChangeChance;
        [NMS(Index = 509)]
        /* 0x1CD0 */ public float PetEggMinDistStep;
        [NMS(Index = 542)]
        /* 0x1CD4 */ public float PetEggMinGrowthToLay;
        [NMS(Index = 502)]
        /* 0x1CD8 */ public int PetEggModificationItemLimit;
        [NMS(Index = 501)]
        /* 0x1CDC */ public int PetEggModificationTime;
        [NMS(Index = 511)]
        /* 0x1CE0 */ public float PetEggOverdosageModifier;
        [NMS(Index = 506)]
        /* 0x1CE4 */ public float PetEggScaleRangeMax;
        [NMS(Index = 505)]
        /* 0x1CE8 */ public float PetEggScaleRangeModifier;
        [NMS(Index = 504)]
        /* 0x1CEC */ public float PetEggSubstanceModifier;
        [NMS(Index = 508)]
        /* 0x1CF0 */ public float PetEggTraitRangeMax;
        [NMS(Index = 507)]
        /* 0x1CF4 */ public float PetEggTraitRangeModifier;
        [NMS(Index = 455)]
        /* 0x1CF8 */ public float PetFollowRange;
        [NMS(Index = 454)]
        /* 0x1CFC */ public float PetFollowRunPlayerDistance;
        [NMS(Index = 180)]
        /* 0x1D00 */ public float PetFootShakeModifier;
        [NMS(Index = 521)]
        /* 0x1D04 */ public GcPetBehaviours PetForceBehaviour;
        [NMS(Index = 488)]
        /* 0x1D08 */ public int PetGrowthTime;
        [NMS(Index = 449)]
        /* 0x1D0C */ public float PetHeartChangePerLayer;
        [NMS(Index = 448)]
        /* 0x1D10 */ public float PetHeartMaxSize;
        [NMS(Index = 450)]
        /* 0x1D14 */ public float PetHeartResponseLoopTime;
        [NMS(Index = 451)]
        /* 0x1D18 */ public float PetHeartResponseTotalTime;
        [NMS(Index = 435)]
        /* 0x1D1C */ public float PetHeelDistSwitchTimeMax;
        [NMS(Index = 434)]
        /* 0x1D20 */ public float PetHeelDistSwitchTimeMin;
        [NMS(Index = 439)]
        /* 0x1D24 */ public float PetHeelLateralShiftTimeMax;
        [NMS(Index = 438)]
        /* 0x1D28 */ public float PetHeelLateralShiftTimeMin;
        [NMS(Index = 441)]
        /* 0x1D2C */ public float PetHeelPosSpringTime;
        [NMS(Index = 489)]
        /* 0x1D30 */ public int PetIncubationTime;
        [NMS(Index = 14)]
        /* 0x1D34 */ public float PetInteractBaseRange;
        [NMS(Index = 555)]
        /* 0x1D38 */ public float PetInteractionLightHeight;
        [NMS(Index = 557)]
        /* 0x1D3C */ public float PetInteractionLightIntensityMax;
        [NMS(Index = 556)]
        /* 0x1D40 */ public float PetInteractionLightIntensityMin;
        [NMS(Index = 422)]
        /* 0x1D44 */ public float PetInteractTurnToFaceMinAngle;
        [NMS(Index = 452)]
        /* 0x1D48 */ public float PetLastActionReportTime;
        [NMS(Index = 522)]
        /* 0x1D4C */ public float PetMaxSizeOffPlanet;
        [NMS(Index = 52)]
        /* 0x1D50 */ public float PetMaxSummonDistance;
        [NMS(Index = 533)]
        /* 0x1D54 */ public float PetMaxTurnRad;
        [NMS(Index = 51)]
        /* 0x1D58 */ public float PetMinSummonDistance;
        [NMS(Index = 497)]
        /* 0x1D5C */ public float PetMinTrust;
        [NMS(Index = 532)]
        /* 0x1D60 */ public float PetMinTurnRad;
        [NMS(Index = 534)]
        /* 0x1D64 */ public float PetMoodCurvePower;
        [NMS(Index = 453)]
        /* 0x1D68 */ public float PetMoodSmoothTime;
        [NMS(Index = 531)]
        /* 0x1D6C */ public float PetNavRadForMaxTurn;
        [NMS(Index = 530)]
        /* 0x1D70 */ public float PetNavRadForMinTurn;
        [NMS(Index = 552)]
        /* 0x1D74 */ public float PetOrderMaxRange;
        [NMS(Index = 551)]
        /* 0x1D78 */ public float PetOrderMinRange;
        [NMS(Index = 426)]
        /* 0x1D7C */ public float PetPlayerSpeedSmoothTime;
        [NMS(Index = 443)]
        /* 0x1D80 */ public float PetRadialCentre;
        [NMS(Index = 446)]
        /* 0x1D84 */ public float PetRadialPulseMul;
        [NMS(Index = 447)]
        /* 0x1D88 */ public float PetRadialPulseTime;
        [NMS(Index = 444)]
        /* 0x1D8C */ public float PetRadialRadius;
        [NMS(Index = 445)]
        /* 0x1D90 */ public float PetRadialWidth;
        [NMS(Index = 433)]
        /* 0x1D94 */ public float PetRunAtHeelDistMax;
        [NMS(Index = 432)]
        /* 0x1D98 */ public float PetRunAtHeelDistMin;
        [NMS(Index = 437)]
        /* 0x1D9C */ public float PetRunAtHeelLateralShiftMax;
        [NMS(Index = 436)]
        /* 0x1DA0 */ public float PetRunAtHeelLateralShiftMin;
        [NMS(Index = 487)]
        /* 0x1DA4 */ public int PetSlotsUnlockedByDefault;
        [NMS(Index = 427)]
        /* 0x1DA8 */ public float PetStickySideBiasAngle;
        [NMS(Index = 53)]
        /* 0x1DAC */ public float PetSummonRotation;
        [NMS(Index = 523)]
        /* 0x1DB0 */ public float PetTeleportDistOffPlanet;
        [NMS(Index = 524)]
        /* 0x1DB4 */ public float PetTeleportDistOnPlanet;
        [NMS(Index = 548)]
        /* 0x1DB8 */ public float PetTeleportEffectTime;
        [NMS(Index = 549)]
        /* 0x1DBC */ public float PetThrowArcRange;
        [NMS(Index = 466)]
        /* 0x1DC0 */ public float PetTickleChatChance;
        [NMS(Index = 467)]
        /* 0x1DC4 */ public float PetTreatChatChance;
        [NMS(Index = 490)]
        /* 0x1DC8 */ public int PetTrustChangeInterval;
        [NMS(Index = 494)]
        /* 0x1DCC */ public float PetTrustDecreaseStep;
        [NMS(Index = 496)]
        /* 0x1DD0 */ public float PetTrustDecreaseThreshold;
        [NMS(Index = 493)]
        /* 0x1DD4 */ public float PetTrustIncreaseStep;
        [NMS(Index = 495)]
        /* 0x1DD8 */ public float PetTrustIncreaseThreshold;
        [NMS(Index = 491)]
        /* 0x1DDC */ public float PetTrustOnAdoption;
        [NMS(Index = 492)]
        /* 0x1DE0 */ public float PetTrustOnHatch;
        [NMS(Index = 428)]
        /* 0x1DE4 */ public float PetWalkAtHeelChanceDevoted;
        [NMS(Index = 429)]
        /* 0x1DE8 */ public float PetWalkAtHeelChanceIndependent;
        [NMS(Index = 431)]
        /* 0x1DEC */ public float PetWalkAtHeelDistMax;
        [NMS(Index = 430)]
        /* 0x1DF0 */ public float PetWalkAtHeelDistMin;
        [NMS(Index = 440)]
        /* 0x1DF4 */ public float PetWalkAtHeelLateralShift;
        [NMS(Index = 157)]
        /* 0x1DF8 */ public float PlayerBirdDistance;
        [NMS(Index = 54)]
        /* 0x1DFC */ public float PlayerDamageTransferScale;
        [NMS(Index = 226)]
        /* 0x1E00 */ public float PlayerPredatorBoredomDistance;
        [NMS(Index = 217)]
        /* 0x1E04 */ public float PlayerPredatorHealthModifier;
        [NMS(Index = 228)]
        /* 0x1E08 */ public float PlayerPredatorRegainInterestTime;
        [NMS(Index = 46)]
        /* 0x1E0C */ public float PostRideMoveTime;
        [NMS(Index = 218)]
        /* 0x1E10 */ public float PredatorApproachTime;
        [NMS(Index = 225)]
        /* 0x1E14 */ public float PredatorBoredomDistance;
        [NMS(Index = 221)]
        /* 0x1E18 */ public float PredatorChargeDist;
        [NMS(Index = 222)]
        /* 0x1E1C */ public float PredatorChargeDistScale;
        [NMS(Index = 233)]
        /* 0x1E20 */ public float PredatorEnergyRecoverRate;
        [NMS(Index = 234)]
        /* 0x1E24 */ public float PredatorEnergyUseChasing;
        [NMS(Index = 209)]
        /* 0x1E28 */ public float PredatorFishPerceptionDistance;
        [NMS(Index = 216)]
        /* 0x1E2C */ public int PredatorHugeHealth;
        [NMS(Index = 215)]
        /* 0x1E30 */ public int PredatorLargeHealth;
        [NMS(Index = 214)]
        /* 0x1E34 */ public int PredatorMedHealth;
        [NMS(Index = 219)]
        /* 0x1E38 */ public float PredatorNoticePauseTime;
        [NMS(Index = 208)]
        /* 0x1E3C */ public float PredatorPerceptionDistance;
        [NMS(Index = 227)]
        /* 0x1E40 */ public float PredatorRegainInterestTime;
        [NMS(Index = 230)]
        /* 0x1E44 */ public float PredatorRoarProbAfterHit;
        [NMS(Index = 231)]
        /* 0x1E48 */ public float PredatorRoarProbAfterMiss;
        [NMS(Index = 229)]
        /* 0x1E4C */ public float PredatorRunAwayDist;
        [NMS(Index = 232)]
        /* 0x1E50 */ public float PredatorRunAwayHealthPercent;
        [NMS(Index = 366)]
        /* 0x1E54 */ public float PredatorRunMoveSpeed;
        [NMS(Index = 213)]
        /* 0x1E58 */ public int PredatorSmallHealth;
        [NMS(Index = 582)]
        /* 0x1E5C */ public float PredatorSpeedMultiplier;
        [NMS(Index = 220)]
        /* 0x1E60 */ public float PredatorStealthDist;
        [NMS(Index = 365)]
        /* 0x1E64 */ public float PredatorTrotMoveSpeed;
        [NMS(Index = 364)]
        /* 0x1E68 */ public float PredatorWalkMoveSpeed;
        [NMS(Index = 289)]
        /* 0x1E6C */ public float QueenHealthLevelMul;
        [NMS(Index = 329)]
        /* 0x1E70 */ public float RagdollConeLimit;
        [NMS(Index = 328)]
        /* 0x1E74 */ public float RagdollDamping;
        [NMS(Index = 332)]
        /* 0x1E78 */ public float RagdollMotorFadeEnd;
        [NMS(Index = 331)]
        /* 0x1E7C */ public float RagdollMotorFadeStart;
        [NMS(Index = 327)]
        /* 0x1E80 */ public float RagdollTau;
        [NMS(Index = 330)]
        /* 0x1E84 */ public float RagdollTwistLimit;
        [NMS(Index = 96)]
        /* 0x1E88 */ public float RecoverHealthTime;
        [NMS(Index = 163)]
        /* 0x1E8C */ public float RepelAmount;
        [NMS(Index = 162)]
        /* 0x1E90 */ public float RepelRange;
        [NMS(Index = 63)]
        /* 0x1E94 */ public float ResourceSpawnTime;
        [NMS(Index = 47)]
        /* 0x1E98 */ public float RideIdleTime;
        [NMS(Index = 45)]
        /* 0x1E9C */ public float RiderLeanTime;
        [NMS(Index = 44)]
        /* 0x1EA0 */ public float RideSpeedChangeTime;
        [NMS(Index = 43)]
        /* 0x1EA4 */ public float RideSpeedFast;
        [NMS(Index = 42)]
        /* 0x1EA8 */ public float RideSpeedSlow;
        [NMS(Index = 37)]
        /* 0x1EAC */ public float RidingFirstPersonOffsetFwd;
        [NMS(Index = 38)]
        /* 0x1EB0 */ public float RidingFirstPersonOffsetUp;
        [NMS(Index = 34)]
        /* 0x1EB4 */ public float RidingReplicationRangeMultiplier;
        [NMS(Index = 35)]
        /* 0x1EB8 */ public float RidingRollAdjustMaxAngle;
        [NMS(Index = 36)]
        /* 0x1EBC */ public float RidingRollMaxAngleAt;
        [NMS(Index = 351)]
        /* 0x1EC0 */ public float RidingSteerWeight;
        [NMS(Index = 609)]
        /* 0x1EC4 */ public float RockTransformGlobalChance;
        [NMS(Index = 326)]
        /* 0x1EC8 */ public float RoutineOffset;
        [NMS(Index = 325)]
        /* 0x1ECC */ public float RoutineSpeed;
        [NMS(Index = 102)]
        /* 0x1ED0 */ public float SandWormChangeDirectionTime;
        [NMS(Index = 112)]
        /* 0x1ED4 */ public float SandWormDespawnDist;
        [NMS(Index = 106)]
        /* 0x1ED8 */ public float SandWormJumpHeight;
        [NMS(Index = 107)]
        /* 0x1EDC */ public float SandWormJumpTime;
        [NMS(Index = 105)]
        /* 0x1EE0 */ public float SandWormMaxHeightAdjust;
        [NMS(Index = 111)]
        /* 0x1EE4 */ public int SandWormMaxJumps;
        [NMS(Index = 104)]
        /* 0x1EE8 */ public float SandWormMaxSteer;
        [NMS(Index = 116)]
        /* 0x1EEC */ public float SandWormSpawnChanceInfested;
        [NMS(Index = 115)]
        /* 0x1EF0 */ public float SandWormSpawnChanceMax;
        [NMS(Index = 114)]
        /* 0x1EF4 */ public float SandWormSpawnChanceMin;
        [NMS(Index = 113)]
        /* 0x1EF8 */ public float SandWormSpawnTimer;
        [NMS(Index = 103)]
        /* 0x1EFC */ public float SandWormSteerAdjustTime;
        [NMS(Index = 108)]
        /* 0x1F00 */ public float SandWormSubmergeDepth;
        [NMS(Index = 109)]
        /* 0x1F04 */ public float SandWormSubmergeTime;
        [NMS(Index = 110)]
        /* 0x1F08 */ public float SandWormSurfaceTime;
        [NMS(Index = 69)]
        /* 0x1F0C */ public float SceneTerrainSpawnMinDistance;
        [NMS(Index = 245)]
        /* 0x1F10 */ public int ScuttlerHealth;
        [NMS(Index = 250)]
        /* 0x1F14 */ public float ScuttlerIdleTimeMax;
        [NMS(Index = 249)]
        /* 0x1F18 */ public float ScuttlerIdleTimeMin;
        [NMS(Index = 246)]
        /* 0x1F1C */ public float ScuttlerInitialNoAttackTime;
        [NMS(Index = 248)]
        /* 0x1F20 */ public float ScuttlerMoveTimeMax;
        [NMS(Index = 247)]
        /* 0x1F24 */ public float ScuttlerMoveTimeMin;
        [NMS(Index = 255)]
        /* 0x1F28 */ public float ScuttlerSpitChargeTime;
        [NMS(Index = 254)]
        /* 0x1F2C */ public float ScuttlerSpitDelay;
        [NMS(Index = 253)]
        /* 0x1F30 */ public float ScuttlerZigZagStrength;
        [NMS(Index = 252)]
        /* 0x1F34 */ public float ScuttlerZigZagTimeMax;
        [NMS(Index = 251)]
        /* 0x1F38 */ public float ScuttlerZigZagTimeMin;
        [NMS(Index = 469)]
        /* 0x1F3C */ public float SearchItemDistance;
        [NMS(Index = 470)]
        /* 0x1F40 */ public float SearchItemFrequency;
        [NMS(Index = 471)]
        /* 0x1F44 */ public float SearchItemGiveUpDistance;
        [NMS(Index = 472)]
        /* 0x1F48 */ public float SearchItemGiveUpTime;
        [NMS(Index = 473)]
        /* 0x1F4C */ public float SearchItemNotifyTime;
        [NMS(Index = 474)]
        /* 0x1F50 */ public float SearchSpawnRandomItemProbability;
        [NMS(Index = 138)]
        /* 0x1F54 */ public float SharkAlignSpeed;
        [NMS(Index = 129)]
        /* 0x1F58 */ public float SharkAlongPathSpeed;
        [NMS(Index = 133)]
        /* 0x1F5C */ public float SharkAttackAccel;
        [NMS(Index = 132)]
        /* 0x1F60 */ public float SharkAttackSpeed;
        [NMS(Index = 137)]
        /* 0x1F64 */ public float SharkGetToPathSpeed;
        [NMS(Index = 136)]
        /* 0x1F68 */ public float SharkPatrolEnd;
        [NMS(Index = 135)]
        /* 0x1F6C */ public float SharkPatrolRadius;
        [NMS(Index = 134)]
        /* 0x1F70 */ public float SharkPatrolSpeed;
        [NMS(Index = 131)]
        /* 0x1F74 */ public float SharkToPathYDamp;
        [NMS(Index = 128)]
        /* 0x1F78 */ public float ShieldFadeTime;
        [NMS(Index = 206)]
        /* 0x1F7C */ public float SmallCreatureAvoidPlayerDistance;
        [NMS(Index = 204)]
        /* 0x1F80 */ public float SmallCreatureFleePlayerDistance;
        [NMS(Index = 202)]
        /* 0x1F84 */ public float SmallCreaturePerceptionDistance;
        [NMS(Index = 357)]
        /* 0x1F88 */ public float SoftenAvoidanceRadiusMod;
        [NMS(Index = 392)]
        /* 0x1F8C */ public float SpawnCameraAngleCos;
        [NMS(Index = 171)]
        /* 0x1F90 */ public float SpawnDistanceModifierForUnderwater;
        [NMS(Index = 399)]
        /* 0x1F94 */ public float SpawnDistAtMaxSize;
        [NMS(Index = 398)]
        /* 0x1F98 */ public float SpawnDistAtMinSize;
        [NMS(Index = 393)]
        /* 0x1F9C */ public float SpawnMinDistPercentage;
        [NMS(Index = 394)]
        /* 0x1FA0 */ public float SpawnOnscreenDist;
        [NMS(Index = 404)]
        /* 0x1FA4 */ public float SpawnsAvoidBaseMultiplier;
        [NMS(Index = 287)]
        /* 0x1FA8 */ public int SpookBossHealth;
        [NMS(Index = 265)]
        /* 0x1FAC */ public float SpookFiendColourInterpTime;
        [NMS(Index = 359)]
        /* 0x1FB0 */ public float SpookFiendFastSwimSpeed;
        [NMS(Index = 288)]
        /* 0x1FB4 */ public int SpookSquidHealth;
        [NMS(Index = 370)]
        /* 0x1FB8 */ public float SteeringUpdateRate;
        [NMS(Index = 174)]
        /* 0x1FBC */ public float StickToGroundCastBegin;
        [NMS(Index = 175)]
        /* 0x1FC0 */ public float StickToGroundCastEnd;
        [NMS(Index = 173)]
        /* 0x1FC4 */ public float StickToGroundSpeed;
        [NMS(Index = 130)]
        /* 0x1FC8 */ public float SwarmBrakingForce;
        [NMS(Index = 149)]
        /* 0x1FCC */ public float SwarmMoveYFactor;
        [NMS(Index = 165)]
        /* 0x1FD0 */ public float TargetReachedDistance;
        [NMS(Index = 147)]
        /* 0x1FD4 */ public float TargetSearchTimeout;
        [NMS(Index = 408)]
        /* 0x1FD8 */ public float TrailHalfLife;
        [NMS(Index = 64)]
        /* 0x1FDC */ public float TurnInPlaceIdleTime;
        [NMS(Index = 65)]
        /* 0x1FE0 */ public float TurnInPlaceMaxAngle;
        [NMS(Index = 67)]
        /* 0x1FE4 */ public float TurnInPlaceMaxSpeed;
        [NMS(Index = 68)]
        /* 0x1FE8 */ public float TurnInPlaceMaxSpeedIndoor;
        [NMS(Index = 66)]
        /* 0x1FEC */ public float TurnInPlaceMinTime;
        [NMS(Index = 335)]
        /* 0x1FF0 */ public float TurnRadiusMultiplier;
        [NMS(Index = 337)]
        /* 0x1FF4 */ public float TurnSlowAreaCos;
        [NMS(Index = 154)]
        /* 0x1FF8 */ public float VelocityAlignSpeed;
        [NMS(Index = 153)]
        /* 0x1FFC */ public float VelocityAlignStrength;
        [NMS(Index = 346)]
        /* 0x2000 */ public float VelocityAlignYFactorMax;
        [NMS(Index = 345)]
        /* 0x2004 */ public float VelocityAlignYFactorMin;
        [NMS(Index = 170)]
        /* 0x2008 */ public float WaterSpawnOffset;
        [NMS(Index = 152)]
        /* 0x200C */ public float WeaponRepelAmount;
        [NMS(Index = 151)]
        /* 0x2010 */ public float WeaponRepelRange;
        [NMS(Index = 16, Size = 0xB, EnumType = typeof(GcCreatureRoles.CreatureRoleEnum))]
        /* 0x2014 */ public NMSString0x20[] TempermentDescriptions;
        [NMS(Index = 21, Size = 0x4, EnumType = typeof(GcCreatureDiet.DietEnum))]
        /* 0x2174 */ public NMSString0x20[] DietDescriptions;
        [NMS(Index = 22, Size = 0x4, EnumType = typeof(GcCreatureDiet.DietEnum))]
        /* 0x21F4 */ public NMSString0x20[] WaterDietDescriptions;
        [NMS(Index = 235)]
        /* 0x2274 */ public bool AggressiveSharks;
        [NMS(Index = 603)]
        /* 0x2275 */ public bool AllBaitIsBasic;
        [NMS(Index = 406)]
        /* 0x2276 */ public bool AllowSleeping;
        [NMS(Index = 62)]
        /* 0x2277 */ public bool AllowSpawningOnscreen;
        [NMS(Index = 604)]
        /* 0x2278 */ public bool CanAlwaysLayEgg;
        [NMS(Index = 12)]
        /* 0x2279 */ public bool CreatureInteractWithoutRaycasts;
        [NMS(Index = 40)]
        /* 0x227A */ public bool CreatureRideDirectControl;
        [NMS(Index = 407)]
        /* 0x227B */ public bool DebugDrawTrails;
        [NMS(Index = 476)]
        /* 0x227C */ public bool DebugSearch;
        [NMS(Index = 414)]
        /* 0x227D */ public bool DetailAnimPlayWhileWalking;
        [NMS(Index = 579)]
        /* 0x227E */ public bool DrawGrassPushRadius;
        [NMS(Index = 574)]
        /* 0x227F */ public bool DrawRoutineFollowDebug;
        [NMS(Index = 575)]
        /* 0x2280 */ public bool DrawRoutineInfo;
        [NMS(Index = 29)]
        /* 0x2281 */ public bool EnableFlyingSnakeTails;
        [NMS(Index = 33)]
        /* 0x2282 */ public bool EnableMPCreatureRide;
        [NMS(Index = 30)]
        /* 0x2283 */ public bool EnableNewStuff;
        [NMS(Index = 409)]
        /* 0x2284 */ public bool EnableTrailIk;
        [NMS(Index = 32)]
        /* 0x2285 */ public bool EnableVRCreatureRide;
        [NMS(Index = 278)]
        /* 0x2286 */ public bool FiendOnscreenMarkers;
        [NMS(Index = 277)]
        /* 0x2287 */ public bool FiendsCanAttack;
        [NMS(Index = 421)]
        /* 0x2288 */ public bool ForceStatic;
        [NMS(Index = 31)]
        /* 0x2289 */ public bool InstantCreatureRide;
        [NMS(Index = 28)]
        /* 0x228A */ public bool IsHurtingCreaturesACrime;
        [NMS(Index = 546)]
        /* 0x228B */ public bool PetAnimTest;
        [NMS(Index = 525)]
        /* 0x228C */ public bool PetCanSummonOnFreighter;
        [NMS(Index = 543)]
        /* 0x228D */ public bool PetForceSummonFromEgg;
        [NMS(Index = 486)]
        /* 0x228E */ public bool PetsShowTraitClassesAsWords;
        [NMS(Index = 420)]
        /* 0x228F */ public bool PiedPiper;
        [NMS(Index = 403)]
        /* 0x2290 */ public bool ProcessPendingSpawnRequests;
        [NMS(Index = 545)]
        /* 0x2291 */ public bool RidingPositionTest;
        [NMS(Index = 244)]
        /* 0x2292 */ public bool ScuttlersCanAttack;
        [NMS(Index = 179)]
        /* 0x2293 */ public bool ShowScale;
        [NMS(Index = 41)]
        /* 0x2294 */ public bool StaticCreatureRide;
        [NMS(Index = 61)]
        /* 0x2295 */ public bool UncapSpawningforVideo;
        [NMS(Index = 468)]
        /* 0x2296 */ public bool UseCreatureAdoptOSD;
        [NMS(Index = 547)]
        /* 0x2297 */ public bool UsePetTeleportEffect;
    }
}
