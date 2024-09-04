using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x40867BBAC9B38EE6, NameHash = 0xD1168B3D)]
    public class GcCreatureGlobals : NMSTemplate
    {
        [NMS(Index = 97)]
        /* 0x0000 */ public GcCameraShakeData PainShake;
        [NMS(Index = 510)]
        /* 0x00C0 */ public GcScanEffectData PetOffPlanetEffect;
        [NMS(Index = 3)]
        /* 0x0110 */ public Colour AllCreaturesDiscoveredColour;
        [NMS(Index = 533)]
        /* 0x0120 */ public Colour PetInteractionLightColour;
        [NMS(Index = 431)]
        /* 0x0130 */ public Colour PetRadialBadColour;
        [NMS(Index = 434)]
        /* 0x0140 */ public Colour PetRadialBoostColour;
        [NMS(Index = 433)]
        /* 0x0150 */ public Colour PetRadialGoodColour;
        [NMS(Index = 432)]
        /* 0x0160 */ public Colour PetRadialNeutralColour;
        [NMS(Index = 525)]
        /* 0x0170 */ public Colour PetThrowArcColour;
        [NMS(Index = 26, Size = 0x1C, EnumType = typeof(GcBiomeSubType.BiomeSubTypeEnum))]
        /* 0x0180 */ public NMSString0x20A[] WeirdBiomeDescriptions;
        [NMS(Index = 25, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x0500 */ public NMSString0x20A[] BiomeAirDescriptions;
        [NMS(Index = 23, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x0700 */ public NMSString0x20A[] BiomeDescriptions;
        [NMS(Index = 24, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x0900 */ public NMSString0x20A[] BiomeWaterDescriptions;
        [NMS(Index = 19, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x0B00 */ public NMSString0x20A[] DietMeat;
        [NMS(Index = 20, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x0D00 */ public NMSString0x20A[] DietVeg;
        [NMS(Index = 27, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x0F00 */ public NMSString0x20A[] PetBiomeClimates;
        [NMS(Index = 582)]
        /* 0x1100 */ public GcWeirdCreatureRewardList WeirdKillingRewards;
        [NMS(Index = 16, Size = 0xB, EnumType = typeof(GcCreatureRoles.CreatureRoleEnum))]
        /* 0x12C0 */ public NMSString0x20A[] TempermentDescriptions;
        [NMS(Index = 15, Size = 0xB, EnumType = typeof(GcCreatureRoles.CreatureRoleEnum))]
        /* 0x1420 */ public NMSString0x20A[] Temperments;
        [NMS(Index = 21, Size = 0x4, EnumType = typeof(GcCreatureDiet.DietEnum))]
        /* 0x1580 */ public NMSString0x20A[] DietDescriptions;
        [NMS(Index = 17, Size = 0x4, EnumType = typeof(GcCreatureDiet.DietEnum))]
        /* 0x1600 */ public NMSString0x20A[] Diets;
        [NMS(Index = 22, Size = 0x4, EnumType = typeof(GcCreatureDiet.DietEnum))]
        /* 0x1680 */ public NMSString0x20A[] WaterDietDescriptions;
        [NMS(Index = 18, Size = 0x4, EnumType = typeof(GcCreatureDiet.DietEnum))]
        /* 0x1700 */ public NMSString0x20A[] WaterDiets;
        [NMS(Index = 56)]
        /* 0x1780 */ public NMSString0x20A CreatureFilter;
        [NMS(Index = 4)]
        /* 0x17A0 */ public NMSString0x20A PetCarePuzzleOverrideID;
        [NMS(Index = 178)]
        /* 0x17C0 */ public List<GcCreatureAlertData> AlertTable;
        [NMS(Index = 560)]
        /* 0x17D0 */ public NMSString0x10 AlienShipQuestCreatureWeapon;
        [NMS(Index = 559)]
        /* 0x17E0 */ public NMSString0x10 AlienShipQuestKillingSubstance;
        [NMS(Index = 575)]
        /* 0x17F0 */ public NMSString0x10 BasicFeedingProduct;
        [NMS(Index = 581)]
        /* 0x1800 */ public List<GcCreatureFoodList> CarnivoreFeedingProducts;
        [NMS(Index = 392)]
        /* 0x1810 */ public NMSString0x10 CreatureDeathEffectBig;
        [NMS(Index = 391)]
        /* 0x1820 */ public NMSString0x10 CreatureDeathEffectMedium;
        [NMS(Index = 390)]
        /* 0x1830 */ public NMSString0x10 CreatureDeathEffectSmall;
        [NMS(Index = 200)]
        /* 0x1840 */ public NMSString0x10 CreatureHugeRunShake;
        [NMS(Index = 198)]
        /* 0x1850 */ public NMSString0x10 CreatureHugeWalkShake;
        [NMS(Index = 196)]
        /* 0x1860 */ public NMSString0x10 CreatureLargeRunShake;
        [NMS(Index = 194)]
        /* 0x1870 */ public NMSString0x10 CreatureLargeWalkShake;
        [NMS(Index = 55)]
        /* 0x1880 */ public GcSeed CreatureSeed;
        [NMS(Index = 558)]
        /* 0x1890 */ public NMSString0x10 DefaultKillingSubstance;
        [NMS(Index = 393)]
        /* 0x18A0 */ public NMSString0x10 FishDeathEffect;
        [NMS(Index = 568)]
        /* 0x18B0 */ public List<GcCreatureHarvestSubstanceList> HarvestingProducts;
        [NMS(Index = 580)]
        /* 0x18C0 */ public List<GcCreatureFoodList> HerbivoreFeedingProducts;
        [NMS(Index = 576)]
        /* 0x18D0 */ public NMSString0x10 HorrorPetFeedingProduct;
        [NMS(Index = 567)]
        /* 0x18E0 */ public List<GcCreatureSubstanceList> KillingProducts;
        [NMS(Index = 561)]
        /* 0x18F0 */ public List<NMSString0x10> KillingSubstances;
        [NMS(Index = 583)]
        /* 0x1900 */ public List<NMSString0x10> LootItems;
        [NMS(Index = 512)]
        /* 0x1910 */ public VariableSizeString PetEggHatchResourceFile;
        [NMS(Index = 478)]
        /* 0x1920 */ public NMSString0x10 PetEggMaxChangeProduct;
        [NMS(Index = 511)]
        /* 0x1930 */ public VariableSizeString PetEggResourceFile;
        [NMS(Index = 519)]
        /* 0x1940 */ public NMSString0x10 PetEggsplosionEffect;
        [NMS(Index = 417)]
        /* 0x1950 */ public NMSString0x10 PetScan;
        [NMS(Index = 577)]
        /* 0x1960 */ public NMSString0x10 RobotFeedingProduct;
        [NMS(Index = 585)]
        /* 0x1970 */ public List<float> RockTransformChanceModifiers;
        [NMS(Index = 177)]
        /* 0x1980 */ public GcFlyingSnakeData FlyingSnakeData;
        [NMS(Index = 211)]
        /* 0x19C0 */ public float AdultBabyKilledNoticeDistance;
        [NMS(Index = 551)]
        /* 0x19C4 */ public float AdultCorrelationValue;
        [NMS(Index = 161)]
        /* 0x19C8 */ public float AlertDistance;
        [NMS(Index = 2)]
        /* 0x19CC */ public int AllCreaturesDiscoveredBonusMul;
        [NMS(Index = 586)]
        /* 0x19D0 */ public float AngryRockProportionNormal;
        [NMS(Index = 587)]
        /* 0x19D4 */ public float AngryRockProportionSurvival;
        [NMS(Index = 176)]
        /* 0x19D8 */ public float AnimationStickToGroundSpeed;
        [NMS(Index = 534)]
        /* 0x19DC */ public float AnimChangeCoolDown;
        [NMS(Index = 305)]
        /* 0x19E0 */ public float AsteroidCreatureRichSystemSpawnPercent;
        [NMS(Index = 304)]
        /* 0x19E4 */ public float AsteroidCreatureSpawnPercentOverride;
        [NMS(Index = 366)]
        /* 0x19E8 */ public float AttackPlayerDistance;
        [NMS(Index = 460)]
        /* 0x19EC */ public float AttractedMaxAvoidCreaturesDist;
        [NMS(Index = 459)]
        /* 0x19F0 */ public float AttractedMaxAvoidCreaturesStrength;
        [NMS(Index = 458)]
        /* 0x19F4 */ public float AttractedMinAvoidCreaturesDist;
        [NMS(Index = 457)]
        /* 0x19F8 */ public float AttractedMinAvoidCreaturesStrength;
        [NMS(Index = 148)]
        /* 0x19FC */ public float AttractMinDistance;
        [NMS(Index = 333)]
        /* 0x1A00 */ public float AvoidCreaturesWeight;
        [NMS(Index = 334)]
        /* 0x1A04 */ public float AvoidImpassableWeight;
        [NMS(Index = 319)]
        /* 0x1A08 */ public float BadTurnPercent;
        [NMS(Index = 320)]
        /* 0x1A0C */ public float BadTurnWeight;
        [NMS(Index = 335)]
        /* 0x1A10 */ public float BaseAndTerrainModImpassableStrength;
        [NMS(Index = 328)]
        /* 0x1A14 */ public float BrakingForce;
        [NMS(Index = 329)]
        /* 0x1A18 */ public float BrakingForceY;
        [NMS(Index = 268)]
        /* 0x1A1C */ public int BugFiendHealth;
        [NMS(Index = 263)]
        /* 0x1A20 */ public int BugQueenHealth;
        [NMS(Index = 267)]
        /* 0x1A24 */ public float BugQueenSpitballExplosionRadius;
        [NMS(Index = 266)]
        /* 0x1A28 */ public float BugQueenSpitballSpeed;
        [NMS(Index = 264)]
        /* 0x1A2C */ public int BugQueenSpitCount;
        [NMS(Index = 265)]
        /* 0x1A30 */ public float BugQueenSpitRadius;
        [NMS(Index = 189)]
        /* 0x1A34 */ public float CreatureBlobRidingHugeMinSize;
        [NMS(Index = 188)]
        /* 0x1A38 */ public float CreatureBlobRidingLargeMinSize;
        [NMS(Index = 187)]
        /* 0x1A3C */ public float CreatureBlobRidingMedMinSize;
        [NMS(Index = 82)]
        /* 0x1A40 */ public float CreatureBrakeForce;
        [NMS(Index = 572)]
        /* 0x1A44 */ public int CreatureHarvestAmountHuge;
        [NMS(Index = 571)]
        /* 0x1A48 */ public int CreatureHarvestAmountLarge;
        [NMS(Index = 570)]
        /* 0x1A4C */ public int CreatureHarvestAmountMed;
        [NMS(Index = 569)]
        /* 0x1A50 */ public int CreatureHarvestAmountSmall;
        [NMS(Index = 77)]
        /* 0x1A54 */ public float CreatureHearingRange;
        [NMS(Index = 193)]
        /* 0x1A58 */ public int CreatureHugeHealth;
        [NMS(Index = 183)]
        /* 0x1A5C */ public float CreatureHugeMinSize;
        [NMS(Index = 201)]
        /* 0x1A60 */ public float CreatureHugeRunMaxShakeDist;
        [NMS(Index = 199)]
        /* 0x1A64 */ public float CreatureHugeWalkMaxShakeDist;
        [NMS(Index = 555)]
        /* 0x1A68 */ public float CreatureIndoorSpeedMultiplier;
        [NMS(Index = 13)]
        /* 0x1A6C */ public float CreatureInteractBaseRange;
        [NMS(Index = 5)]
        /* 0x1A70 */ public float CreatureInteractionRangeBoostHuge;
        [NMS(Index = 6)]
        /* 0x1A74 */ public float CreatureInteractionRangeBoostLarge;
        [NMS(Index = 7)]
        /* 0x1A78 */ public float CreatureInteractionRangeBoostMedium;
        [NMS(Index = 9)]
        /* 0x1A7C */ public float CreatureInteractionRangeBoostRun;
        [NMS(Index = 8)]
        /* 0x1A80 */ public float CreatureInteractionRangeBoostSmall;
        [NMS(Index = 10)]
        /* 0x1A84 */ public float CreatureInteractionRangeBoostSprint;
        [NMS(Index = 11)]
        /* 0x1A88 */ public float CreatureInteractionRangeReducePredator;
        [NMS(Index = 562)]
        /* 0x1A8C */ public int CreatureKillRewardAmountFiend;
        [NMS(Index = 566)]
        /* 0x1A90 */ public int CreatureKillRewardAmountHuge;
        [NMS(Index = 565)]
        /* 0x1A94 */ public int CreatureKillRewardAmountLarge;
        [NMS(Index = 564)]
        /* 0x1A98 */ public int CreatureKillRewardAmountMed;
        [NMS(Index = 563)]
        /* 0x1A9C */ public int CreatureKillRewardAmountSmall;
        [NMS(Index = 192)]
        /* 0x1AA0 */ public int CreatureLargeHealth;
        [NMS(Index = 182)]
        /* 0x1AA4 */ public float CreatureLargeMinSize;
        [NMS(Index = 197)]
        /* 0x1AA8 */ public float CreatureLargeRunMaxShakeDist;
        [NMS(Index = 195)]
        /* 0x1AAC */ public float CreatureLargeWalkMaxShakeDist;
        [NMS(Index = 86)]
        /* 0x1AB0 */ public float CreatureLookBeforeFleeingIfShotTime;
        [NMS(Index = 85)]
        /* 0x1AB4 */ public float CreatureLookBeforeFleeingTime;
        [NMS(Index = 84)]
        /* 0x1AB8 */ public float CreatureLookBeforeGoingTime;
        [NMS(Index = 88)]
        /* 0x1ABC */ public float CreatureLookPlayerForceLookTime;
        [NMS(Index = 87)]
        /* 0x1AC0 */ public float CreatureLookScaryThingTime;
        [NMS(Index = 191)]
        /* 0x1AC4 */ public int CreatureMedHealth;
        [NMS(Index = 181)]
        /* 0x1AC8 */ public float CreatureMedMinSize;
        [NMS(Index = 70)]
        /* 0x1ACC */ public float CreatureMinAlignSpeed;
        [NMS(Index = 83)]
        /* 0x1AD0 */ public float CreatureMinAnimMoveSpeed;
        [NMS(Index = 76)]
        /* 0x1AD4 */ public float CreatureMinRunTime;
        [NMS(Index = 79)]
        /* 0x1AD8 */ public float CreatureMoveIdle;
        [NMS(Index = 186)]
        /* 0x1ADC */ public float CreatureRidingHugeMinSize;
        [NMS(Index = 185)]
        /* 0x1AE0 */ public float CreatureRidingLargeMinSize;
        [NMS(Index = 184)]
        /* 0x1AE4 */ public float CreatureRidingMedMinSize;
        [NMS(Index = 39)]
        /* 0x1AE8 */ public float CreatureScaleMangle;
        [NMS(Index = 78)]
        /* 0x1AEC */ public float CreatureSightRange;
        [NMS(Index = 190)]
        /* 0x1AF0 */ public int CreatureSmallHealth;
        [NMS(Index = 556)]
        /* 0x1AF4 */ public float CreatureSpeedMultiplier;
        [NMS(Index = 81)]
        /* 0x1AF8 */ public float CreatureTurnMax;
        [NMS(Index = 80)]
        /* 0x1AFC */ public float CreatureTurnMin;
        [NMS(Index = 589)]
        /* 0x1B00 */ public float CreatureUpdateRateMultiplier;
        [NMS(Index = 75)]
        /* 0x1B04 */ public float CreatureWaryTime;
        [NMS(Index = 346)]
        /* 0x1B08 */ public float DefaultRunMoveSpeed;
        [NMS(Index = 342)]
        /* 0x1B0C */ public float DefaultSwimSpeed;
        [NMS(Index = 345)]
        /* 0x1B10 */ public float DefaultTrotMoveSpeed;
        [NMS(Index = 344)]
        /* 0x1B14 */ public float DefaultWalkMoveSpeed;
        [NMS(Index = 236)]
        /* 0x1B18 */ public float DelayAfterRespawnBeforeAttackable;
        [NMS(Index = 375)]
        /* 0x1B1C */ public float DespawnDistFactor;
        [NMS(Index = 385)]
        /* 0x1B20 */ public float DetailAnimBlendInTime;
        [NMS(Index = 386)]
        /* 0x1B24 */ public float DetailAnimBlendOutTime;
        [NMS(Index = 388)]
        /* 0x1B28 */ public float DetailAnimMaxPauseTime;
        [NMS(Index = 387)]
        /* 0x1B2C */ public float DetailAnimMinPauseTime;
        [NMS(Index = 150)]
        /* 0x1B30 */ public float DroneExplodeRadius;
        [NMS(Index = 351)]
        /* 0x1B34 */ public float EdgeClosenessPenalty;
        [NMS(Index = 100)]
        /* 0x1B38 */ public float ExtraFollowFreq1;
        [NMS(Index = 101)]
        /* 0x1B3C */ public float ExtraFollowFreq2;
        [NMS(Index = 99)]
        /* 0x1B40 */ public float ExtraFollowStrength;
        [NMS(Index = 372)]
        /* 0x1B44 */ public float FadeDistance;
        [NMS(Index = 370)]
        /* 0x1B48 */ public float FadeScaleMultiplier;
        [NMS(Index = 371)]
        /* 0x1B4C */ public float FadeScalePower;
        [NMS(Index = 343)]
        /* 0x1B50 */ public float FastSwimSpeed;
        [NMS(Index = 454)]
        /* 0x1B54 */ public float FeedingFollowTime;
        [NMS(Index = 456)]
        /* 0x1B58 */ public float FeedingNoticeDistance;
        [NMS(Index = 455)]
        /* 0x1B5C */ public float FeedingNoticeTime;
        [NMS(Index = 453)]
        /* 0x1B60 */ public int FeedingTaskAmount;
        [NMS(Index = 290)]
        /* 0x1B64 */ public float FiendAggroDecreasePerSpawn;
        [NMS(Index = 288)]
        /* 0x1B68 */ public float FiendAggroIncreaseDamageEgg;
        [NMS(Index = 289)]
        /* 0x1B6C */ public float FiendAggroIncreaseDestroyEgg;
        [NMS(Index = 277)]
        /* 0x1B70 */ public float FiendAggroTime;
        [NMS(Index = 294)]
        /* 0x1B74 */ public float FiendBeingShotMemoryTime;
        [NMS(Index = 291)]
        /* 0x1B78 */ public float FiendCritAreaSize;
        [NMS(Index = 274)]
        /* 0x1B7C */ public float FiendDespawnDistance;
        [NMS(Index = 293)]
        /* 0x1B80 */ public float FiendDistReduceForBeingShot;
        [NMS(Index = 292)]
        /* 0x1B84 */ public float FiendDistToConsiderTargetSwtich;
        [NMS(Index = 283)]
        /* 0x1B88 */ public int FiendEggsToUnlockSpit;
        [NMS(Index = 269)]
        /* 0x1B8C */ public int FiendHealth;
        [NMS(Index = 271)]
        /* 0x1B90 */ public float FiendHealthLevelMul;
        [NMS(Index = 279)]
        /* 0x1B94 */ public int FiendMaxAttackers;
        [NMS(Index = 278)]
        /* 0x1B98 */ public int FiendMaxEngaged;
        [NMS(Index = 287)]
        /* 0x1B9C */ public float FiendMaxSpawnTime;
        [NMS(Index = 280)]
        /* 0x1BA0 */ public float FiendMaxVerticalForPounce;
        [NMS(Index = 286)]
        /* 0x1BA4 */ public float FiendMinSpawnTime;
        [NMS(Index = 272)]
        /* 0x1BA8 */ public float FiendPerceptionDistance;
        [NMS(Index = 262)]
        /* 0x1BAC */ public float FiendPounceDistanceModifier;
        [NMS(Index = 276)]
        /* 0x1BB0 */ public float FiendReplicateEndDistance;
        [NMS(Index = 275)]
        /* 0x1BB4 */ public float FiendReplicateStartDistance;
        [NMS(Index = 273)]
        /* 0x1BB8 */ public float FiendSpawnDistance;
        [NMS(Index = 281)]
        /* 0x1BBC */ public float FiendZigZagSpeed;
        [NMS(Index = 282)]
        /* 0x1BC0 */ public float FiendZigZagStrength;
        [NMS(Index = 140)]
        /* 0x1BC4 */ public float FishBobAmplitude;
        [NMS(Index = 139)]
        /* 0x1BC8 */ public float FishBobFrequency;
        [NMS(Index = 357)]
        /* 0x1BCC */ public float FishDesiredDepth;
        [NMS(Index = 301)]
        /* 0x1BD0 */ public float FishFiendBigBoostStrength;
        [NMS(Index = 302)]
        /* 0x1BD4 */ public float FishFiendBigBoostTime;
        [NMS(Index = 297)]
        /* 0x1BD8 */ public int FishFiendBigHealth;
        [NMS(Index = 303)]
        /* 0x1BDC */ public float FishFiendBigScale;
        [NMS(Index = 298)]
        /* 0x1BE0 */ public float FishFiendSmallBoostStrength;
        [NMS(Index = 299)]
        /* 0x1BE4 */ public float FishFiendSmallBoostTime;
        [NMS(Index = 296)]
        /* 0x1BE8 */ public int FishFiendSmallHealth;
        [NMS(Index = 300)]
        /* 0x1BEC */ public float FishFiendSmallScale;
        [NMS(Index = 358)]
        /* 0x1BF0 */ public float FishMinHeightAboveSeaBed;
        [NMS(Index = 360)]
        /* 0x1BF4 */ public float FishObstacleAvoidStrength;
        [NMS(Index = 362)]
        /* 0x1BF8 */ public float FishPlayerAttractionAhead;
        [NMS(Index = 361)]
        /* 0x1BFC */ public float FishPlayerAttractionFrontDist;
        [NMS(Index = 364)]
        /* 0x1C00 */ public float FishPlayerAttractionMaxDist;
        [NMS(Index = 363)]
        /* 0x1C04 */ public float FishPlayerAttractionMinDist;
        [NMS(Index = 365)]
        /* 0x1C08 */ public float FishPlayerAttractionStrength;
        [NMS(Index = 223)]
        /* 0x1C0C */ public float FishPredatorChargeDist;
        [NMS(Index = 224)]
        /* 0x1C10 */ public float FishPredatorChargeDistScale;
        [NMS(Index = 359)]
        /* 0x1C14 */ public float FishSeaBedAvoidStrength;
        [NMS(Index = 159)]
        /* 0x1C18 */ public float FishSpeedMax;
        [NMS(Index = 158)]
        /* 0x1C1C */ public float FishSpeedMin;
        [NMS(Index = 160)]
        /* 0x1C20 */ public float FishSwimMaxAcceleration;
        [NMS(Index = 164)]
        /* 0x1C24 */ public float FishTurn;
        [NMS(Index = 355)]
        /* 0x1C28 */ public float FishWaterSurfaceAnticipate;
        [NMS(Index = 356)]
        /* 0x1C2C */ public float FishWaterSurfaceAvoidStrength;
        [NMS(Index = 330)]
        /* 0x1C30 */ public float FlowFieldWeight;
        [NMS(Index = 336)]
        /* 0x1C34 */ public float FollowLeaderAlignWeight;
        [NMS(Index = 337)]
        /* 0x1C38 */ public float FollowLeaderCohereWeight;
        [NMS(Index = 398)]
        /* 0x1C3C */ public float FollowPlayerDistance;
        [NMS(Index = 400)]
        /* 0x1C40 */ public float FollowRange;
        [NMS(Index = 399)]
        /* 0x1C44 */ public float FollowRunPlayerDistance;
        [NMS(Index = 331)]
        /* 0x1C48 */ public float FollowWeight;
        [NMS(Index = 172)]
        /* 0x1C4C */ public float FootDustGroundTintStrength;
        [NMS(Index = 394)]
        /* 0x1C50 */ public float FootParticleTime;
        [NMS(Index = 95)]
        /* 0x1C54 */ public float FootPlantError;
        [NMS(Index = 243)]
        /* 0x1C58 */ public float FreighterDespawnDist;
        [NMS(Index = 142)]
        /* 0x1C5C */ public float FreighterJellyBobAmplitude;
        [NMS(Index = 141)]
        /* 0x1C60 */ public float FreighterJellyBobFrequency;
        [NMS(Index = 339)]
        /* 0x1C64 */ public float FreighterJellySwimSpeed;
        [NMS(Index = 242)]
        /* 0x1C68 */ public float FreighterSpawnDist;
        [NMS(Index = 452)]
        /* 0x1C6C */ public int FriendlyCreatureLimit;
        [NMS(Index = 553)]
        /* 0x1C70 */ public float GrassPushMaxSize;
        [NMS(Index = 552)]
        /* 0x1C74 */ public float GrassPushRadius;
        [NMS(Index = 127)]
        /* 0x1C78 */ public float GroundWormScaleMax;
        [NMS(Index = 126)]
        /* 0x1C7C */ public float GroundWormScaleMin;
        [NMS(Index = 125)]
        /* 0x1C80 */ public float GroundWormSpawnChance;
        [NMS(Index = 122)]
        /* 0x1C84 */ public float GroundWormSpawnerActivateRadius;
        [NMS(Index = 123)]
        /* 0x1C88 */ public float GroundWormSpawnerDestroyRadiusActive;
        [NMS(Index = 124)]
        /* 0x1C8C */ public float GroundWormSpawnerDestroyRadiusInactive;
        [NMS(Index = 121)]
        /* 0x1C90 */ public int GroundWormSpawnMax;
        [NMS(Index = 120)]
        /* 0x1C94 */ public int GroundWormSpawnMin;
        [NMS(Index = 117)]
        /* 0x1C98 */ public float GroundWormSpawnRadius;
        [NMS(Index = 118)]
        /* 0x1C9C */ public float GroundWormSpawnSpacing;
        [NMS(Index = 119)]
        /* 0x1CA0 */ public float GroundWormSpawnTimeOut;
        [NMS(Index = 546)]
        /* 0x1CA4 */ public float GroupBabyHealthMultiplier;
        [NMS(Index = 544)]
        /* 0x1CA8 */ public float GroupBabyProportion;
        [NMS(Index = 536)]
        /* 0x1CAC */ public float GroupBabyRunProbability;
        [NMS(Index = 545)]
        /* 0x1CB0 */ public float GroupBabyScale;
        [NMS(Index = 543)]
        /* 0x1CB4 */ public float GroupFemaleProportion;
        [NMS(Index = 540)]
        /* 0x1CB8 */ public float GroupLookAtDurationMax;
        [NMS(Index = 539)]
        /* 0x1CBC */ public float GroupLookAtDurationMin;
        [NMS(Index = 538)]
        /* 0x1CC0 */ public float GroupLookAtProbability;
        [NMS(Index = 542)]
        /* 0x1CC4 */ public float GroupRunDurationMax;
        [NMS(Index = 541)]
        /* 0x1CC8 */ public float GroupRunDurationMin;
        [NMS(Index = 535)]
        /* 0x1CCC */ public float GroupRunProbability;
        [NMS(Index = 537)]
        /* 0x1CD0 */ public float GroupRunStormProbability;
        [NMS(Index = 574)]
        /* 0x1CD4 */ public float HarvestCooldownMax;
        [NMS(Index = 573)]
        /* 0x1CD8 */ public float HarvestCooldownMin;
        [NMS(Index = 350)]
        /* 0x1CDC */ public float HeightDiffPenalty;
        [NMS(Index = 155)]
        /* 0x1CE0 */ public float HeightLookAhead;
        [NMS(Index = 548)]
        /* 0x1CE4 */ public float HerdGroupSizeMultiplier;
        [NMS(Index = 322)]
        /* 0x1CE8 */ public float ImpassabilityBrakeTime;
        [NMS(Index = 324)]
        /* 0x1CEC */ public float ImpassabilityTurnSpeedMultiplier;
        [NMS(Index = 323)]
        /* 0x1CF0 */ public float ImpassabilityUnbrakeTime;
        [NMS(Index = 238)]
        /* 0x1CF4 */ public float IndoorObstacleAvoidStrength;
        [NMS(Index = 239)]
        /* 0x1CF8 */ public float IndoorSteeringRayLength;
        [NMS(Index = 240)]
        /* 0x1CFC */ public float IndoorSteeringRaySphereSize;
        [NMS(Index = 241)]
        /* 0x1D00 */ public float IndoorSteeringRaySpread;
        [NMS(Index = 237)]
        /* 0x1D04 */ public float IndoorTurnTime;
        [NMS(Index = 146)]
        /* 0x1D08 */ public float InfluenceDeflect;
        [NMS(Index = 144)]
        /* 0x1D0C */ public float InfluenceForce;
        [NMS(Index = 143)]
        /* 0x1D10 */ public float InfluenceRadius;
        [NMS(Index = 145)]
        /* 0x1D14 */ public float InfluenceThreshold;
        [NMS(Index = 340)]
        /* 0x1D18 */ public float LandJellySwimSpeed;
        [NMS(Index = 207)]
        /* 0x1D1C */ public float LargeCreatureAvoidPlayerDistance;
        [NMS(Index = 205)]
        /* 0x1D20 */ public float LargeCreatureFleePlayerDistance;
        [NMS(Index = 203)]
        /* 0x1D24 */ public float largeCreaturePerceptionDistance;
        [NMS(Index = 92)]
        /* 0x1D28 */ public float LookMaxPitchWhenMoving;
        [NMS(Index = 89)]
        /* 0x1D2C */ public float LookMaxYawMoving;
        [NMS(Index = 90)]
        /* 0x1D30 */ public float LookMaxYawStatic;
        [NMS(Index = 91)]
        /* 0x1D34 */ public float LookPitchAtMaxYaw;
        [NMS(Index = 93)]
        /* 0x1D38 */ public float LookRollAtMaxYaw;
        [NMS(Index = 94)]
        /* 0x1D3C */ public float LookRollWhenMoving;
        [NMS(Index = 60)]
        /* 0x1D40 */ public float LowPerfFlockReduce;
        [NMS(Index = 59)]
        /* 0x1D44 */ public int MaxAdditionalEcosystemCreaturesForDiscovery;
        [NMS(Index = 547)]
        /* 0x1D48 */ public float MaxBirdsProportion;
        [NMS(Index = 49)]
        /* 0x1D4C */ public float MaxCreatureSize;
        [NMS(Index = 58)]
        /* 0x1D50 */ public int MaxEcosystemCreaturesLow;
        [NMS(Index = 57)]
        /* 0x1D54 */ public int MaxEcosystemCreaturesNormal;
        [NMS(Index = 377)]
        /* 0x1D58 */ public float MaxFade;
        [NMS(Index = 284)]
        /* 0x1D5C */ public int MaxFiendsToSpawn;
        [NMS(Index = 285)]
        /* 0x1D60 */ public int MaxFiendsToSpawnCarnage;
        [NMS(Index = 295)]
        /* 0x1D64 */ public int MaxFishFiends;
        [NMS(Index = 167)]
        /* 0x1D68 */ public float MaxForce;
        [NMS(Index = 156)]
        /* 0x1D6C */ public float MaxHeightTime;
        [NMS(Index = 314)]
        /* 0x1D70 */ public int MaxRagdollsBeforeDespawnOffscreen;
        [NMS(Index = 315)]
        /* 0x1D74 */ public int MaxRagdollsBeforeDespawnOnscreen;
        [NMS(Index = 50)]
        /* 0x1D78 */ public float MaxRideLeanCounterRotate;
        [NMS(Index = 166)]
        /* 0x1D7C */ public float MaxSpeed;
        [NMS(Index = 168)]
        /* 0x1D80 */ public float MaxTorque;
        [NMS(Index = 317)]
        /* 0x1D84 */ public float MaxTurnRadius;
        [NMS(Index = 376)]
        /* 0x1D88 */ public float MinFade;
        [NMS(Index = 256)]
        /* 0x1D8C */ public float MiniDroneEnergyRecoverRate;
        [NMS(Index = 257)]
        /* 0x1D90 */ public float MiniDroneEnergyUsePerShot;
        [NMS(Index = 258)]
        /* 0x1D94 */ public float MiniDroneShotDelay;
        [NMS(Index = 259)]
        /* 0x1D98 */ public float MiniDroneShotMaxAngle;
        [NMS(Index = 450)]
        /* 0x1D9C */ public float MiningRandomProbability;
        [NMS(Index = 48)]
        /* 0x1DA0 */ public float MinRideSize;
        [NMS(Index = 321)]
        /* 0x1DA4 */ public float MinScaleForNavMap;
        [NMS(Index = 169)]
        /* 0x1DA8 */ public float MinWaterSpawnDepth;
        [NMS(Index = 325)]
        /* 0x1DAC */ public float NavMapLookAhead;
        [NMS(Index = 0)]
        /* 0x1DB0 */ public int NumCreaturesRequiredForDiscoveryMission;
        [NMS(Index = 1)]
        /* 0x1DB4 */ public int NumWeirdCreaturesRequiredForDiscoveryMission;
        [NMS(Index = 210)]
        /* 0x1DB8 */ public float PassiveFleePlayerDistance;
        [NMS(Index = 354)]
        /* 0x1DBC */ public float PathOverestimate;
        [NMS(Index = 74)]
        /* 0x1DC0 */ public float PatrolGradientFactor;
        [NMS(Index = 73)]
        /* 0x1DC4 */ public float PatrolHeightOffset;
        [NMS(Index = 72)]
        /* 0x1DC8 */ public float PatrolMaxDist;
        [NMS(Index = 71)]
        /* 0x1DCC */ public float PatrolMinDist;
        [NMS(Index = 98)]
        /* 0x1DD0 */ public float PatrolSwitchMinTime;
        [NMS(Index = 588)]
        /* 0x1DD4 */ public int PauseBetweenCreatureSpawnRequests;
        [NMS(Index = 352)]
        /* 0x1DD8 */ public float PelvisIkStrength;
        [NMS(Index = 212)]
        /* 0x1DDC */ public float PercentagePlayerPredators;
        [NMS(Index = 380)]
        /* 0x1DE0 */ public int PerceptionUpdateRate;
        [NMS(Index = 528)]
        /* 0x1DE4 */ public float PetAccessoryMoodDisplayThreshold;
        [NMS(Index = 529)]
        /* 0x1DE8 */ public float PetAccessoryStateInterval;
        [NMS(Index = 501)]
        /* 0x1DEC */ public float PetAnimSpeedBoostSmallerThan;
        [NMS(Index = 502)]
        /* 0x1DF0 */ public float PetAnimSpeedBoostStrength;
        [NMS(Index = 503)]
        /* 0x1DF4 */ public float PetAnimSpeedMax;
        [NMS(Index = 504)]
        /* 0x1DF8 */ public float PetAnimSpeedMin;
        [NMS(Index = 435)]
        /* 0x1DFC */ public float PetChatCooldown;
        [NMS(Index = 436)]
        /* 0x1E00 */ public float PetChatUseTraitTemplateChance;
        [NMS(Index = 440)]
        /* 0x1E04 */ public float PetEffectSpawnOffsetHuge;
        [NMS(Index = 439)]
        /* 0x1E08 */ public float PetEffectSpawnOffsetLarge;
        [NMS(Index = 438)]
        /* 0x1E0C */ public float PetEffectSpawnOffsetMed;
        [NMS(Index = 437)]
        /* 0x1E10 */ public float PetEffectSpawnOffsetSmall;
        [NMS(Index = 489)]
        /* 0x1E14 */ public float PetEggAccessoryChanceModifier;
        [NMS(Index = 491)]
        /* 0x1E18 */ public float PetEggColourChanceModifier;
        [NMS(Index = 475)]
        /* 0x1E1C */ public int PetEggFirstEggDelay;
        [NMS(Index = 495)]
        /* 0x1E20 */ public float PetEggHatchColourChangeChance;
        [NMS(Index = 514)]
        /* 0x1E24 */ public float PetEggHatchOffset;
        [NMS(Index = 513)]
        /* 0x1E28 */ public float PetEggHatchScale;
        [NMS(Index = 493)]
        /* 0x1E2C */ public float PetEggHatchScaleChange;
        [NMS(Index = 494)]
        /* 0x1E30 */ public float PetEggHatchTraitChange;
        [NMS(Index = 473)]
        /* 0x1E34 */ public float PetEggLayingDuration;
        [NMS(Index = 474)]
        /* 0x1E38 */ public int PetEggLayingInterval;
        [NMS(Index = 490)]
        /* 0x1E3C */ public float PetEggMaxAccessoriesChangeChance;
        [NMS(Index = 492)]
        /* 0x1E40 */ public float PetEggMaxColourChangeChance;
        [NMS(Index = 485)]
        /* 0x1E44 */ public float PetEggMaxDistStep;
        [NMS(Index = 516)]
        /* 0x1E48 */ public float PetEggMaxHungry;
        [NMS(Index = 515)]
        /* 0x1E4C */ public float PetEggMaxLonely;
        [NMS(Index = 487)]
        /* 0x1E50 */ public float PetEggMaxOverdosage;
        [NMS(Index = 488)]
        /* 0x1E54 */ public float PetEggMaxTopDescriptorChangeChance;
        [NMS(Index = 484)]
        /* 0x1E58 */ public float PetEggMinDistStep;
        [NMS(Index = 517)]
        /* 0x1E5C */ public float PetEggMinGrowthToLay;
        [NMS(Index = 477)]
        /* 0x1E60 */ public int PetEggModificationItemLimit;
        [NMS(Index = 476)]
        /* 0x1E64 */ public int PetEggModificationTime;
        [NMS(Index = 486)]
        /* 0x1E68 */ public float PetEggOverdosageModifier;
        [NMS(Index = 481)]
        /* 0x1E6C */ public float PetEggScaleRangeMax;
        [NMS(Index = 480)]
        /* 0x1E70 */ public float PetEggScaleRangeModifier;
        [NMS(Index = 479)]
        /* 0x1E74 */ public float PetEggSubstanceModifier;
        [NMS(Index = 483)]
        /* 0x1E78 */ public float PetEggTraitRangeMax;
        [NMS(Index = 482)]
        /* 0x1E7C */ public float PetEggTraitRangeModifier;
        [NMS(Index = 430)]
        /* 0x1E80 */ public float PetFollowRange;
        [NMS(Index = 429)]
        /* 0x1E84 */ public float PetFollowRunPlayerDistance;
        [NMS(Index = 180)]
        /* 0x1E88 */ public float PetFootShakeModifier;
        [NMS(Index = 496)]
        /* 0x1E8C */ public GcPetBehaviours PetForceBehaviour;
        [NMS(Index = 463)]
        /* 0x1E90 */ public int PetGrowthTime;
        [NMS(Index = 424)]
        /* 0x1E94 */ public float PetHeartChangePerLayer;
        [NMS(Index = 423)]
        /* 0x1E98 */ public float PetHeartMaxSize;
        [NMS(Index = 425)]
        /* 0x1E9C */ public float PetHeartResponseLoopTime;
        [NMS(Index = 426)]
        /* 0x1EA0 */ public float PetHeartResponseTotalTime;
        [NMS(Index = 410)]
        /* 0x1EA4 */ public float PetHeelDistSwitchTimeMax;
        [NMS(Index = 409)]
        /* 0x1EA8 */ public float PetHeelDistSwitchTimeMin;
        [NMS(Index = 414)]
        /* 0x1EAC */ public float PetHeelLateralShiftTimeMax;
        [NMS(Index = 413)]
        /* 0x1EB0 */ public float PetHeelLateralShiftTimeMin;
        [NMS(Index = 416)]
        /* 0x1EB4 */ public float PetHeelPosSpringTime;
        [NMS(Index = 464)]
        /* 0x1EB8 */ public int PetIncubationTime;
        [NMS(Index = 14)]
        /* 0x1EBC */ public float PetInteractBaseRange;
        [NMS(Index = 530)]
        /* 0x1EC0 */ public float PetInteractionLightHeight;
        [NMS(Index = 532)]
        /* 0x1EC4 */ public float PetInteractionLightIntensityMax;
        [NMS(Index = 531)]
        /* 0x1EC8 */ public float PetInteractionLightIntensityMin;
        [NMS(Index = 397)]
        /* 0x1ECC */ public float PetInteractTurnToFaceMinAngle;
        [NMS(Index = 427)]
        /* 0x1ED0 */ public float PetLastActionReportTime;
        [NMS(Index = 497)]
        /* 0x1ED4 */ public float PetMaxSizeOffPlanet;
        [NMS(Index = 52)]
        /* 0x1ED8 */ public float PetMaxSummonDistance;
        [NMS(Index = 508)]
        /* 0x1EDC */ public float PetMaxTurnRad;
        [NMS(Index = 51)]
        /* 0x1EE0 */ public float PetMinSummonDistance;
        [NMS(Index = 472)]
        /* 0x1EE4 */ public float PetMinTrust;
        [NMS(Index = 507)]
        /* 0x1EE8 */ public float PetMinTurnRad;
        [NMS(Index = 509)]
        /* 0x1EEC */ public float PetMoodCurvePower;
        [NMS(Index = 428)]
        /* 0x1EF0 */ public float PetMoodSmoothTime;
        [NMS(Index = 506)]
        /* 0x1EF4 */ public float PetNavRadForMaxTurn;
        [NMS(Index = 505)]
        /* 0x1EF8 */ public float PetNavRadForMinTurn;
        [NMS(Index = 527)]
        /* 0x1EFC */ public float PetOrderMaxRange;
        [NMS(Index = 526)]
        /* 0x1F00 */ public float PetOrderMinRange;
        [NMS(Index = 401)]
        /* 0x1F04 */ public float PetPlayerSpeedSmoothTime;
        [NMS(Index = 418)]
        /* 0x1F08 */ public float PetRadialCentre;
        [NMS(Index = 421)]
        /* 0x1F0C */ public float PetRadialPulseMul;
        [NMS(Index = 422)]
        /* 0x1F10 */ public float PetRadialPulseTime;
        [NMS(Index = 419)]
        /* 0x1F14 */ public float PetRadialRadius;
        [NMS(Index = 420)]
        /* 0x1F18 */ public float PetRadialWidth;
        [NMS(Index = 408)]
        /* 0x1F1C */ public float PetRunAtHeelDistMax;
        [NMS(Index = 407)]
        /* 0x1F20 */ public float PetRunAtHeelDistMin;
        [NMS(Index = 412)]
        /* 0x1F24 */ public float PetRunAtHeelLateralShiftMax;
        [NMS(Index = 411)]
        /* 0x1F28 */ public float PetRunAtHeelLateralShiftMin;
        [NMS(Index = 462)]
        /* 0x1F2C */ public int PetSlotsUnlockedByDefault;
        [NMS(Index = 402)]
        /* 0x1F30 */ public float PetStickySideBiasAngle;
        [NMS(Index = 53)]
        /* 0x1F34 */ public float PetSummonRotation;
        [NMS(Index = 498)]
        /* 0x1F38 */ public float PetTeleportDistOffPlanet;
        [NMS(Index = 499)]
        /* 0x1F3C */ public float PetTeleportDistOnPlanet;
        [NMS(Index = 523)]
        /* 0x1F40 */ public float PetTeleportEffectTime;
        [NMS(Index = 524)]
        /* 0x1F44 */ public float PetThrowArcRange;
        [NMS(Index = 441)]
        /* 0x1F48 */ public float PetTickleChatChance;
        [NMS(Index = 442)]
        /* 0x1F4C */ public float PetTreatChatChance;
        [NMS(Index = 465)]
        /* 0x1F50 */ public int PetTrustChangeInterval;
        [NMS(Index = 469)]
        /* 0x1F54 */ public float PetTrustDecreaseStep;
        [NMS(Index = 471)]
        /* 0x1F58 */ public float PetTrustDecreaseThreshold;
        [NMS(Index = 468)]
        /* 0x1F5C */ public float PetTrustIncreaseStep;
        [NMS(Index = 470)]
        /* 0x1F60 */ public float PetTrustIncreaseThreshold;
        [NMS(Index = 466)]
        /* 0x1F64 */ public float PetTrustOnAdoption;
        [NMS(Index = 467)]
        /* 0x1F68 */ public float PetTrustOnHatch;
        [NMS(Index = 403)]
        /* 0x1F6C */ public float PetWalkAtHeelChanceDevoted;
        [NMS(Index = 404)]
        /* 0x1F70 */ public float PetWalkAtHeelChanceIndependent;
        [NMS(Index = 406)]
        /* 0x1F74 */ public float PetWalkAtHeelDistMax;
        [NMS(Index = 405)]
        /* 0x1F78 */ public float PetWalkAtHeelDistMin;
        [NMS(Index = 415)]
        /* 0x1F7C */ public float PetWalkAtHeelLateralShift;
        [NMS(Index = 157)]
        /* 0x1F80 */ public float PlayerBirdDistance;
        [NMS(Index = 54)]
        /* 0x1F84 */ public float PlayerDamageTransferScale;
        [NMS(Index = 226)]
        /* 0x1F88 */ public float PlayerPredatorBoredomDistance;
        [NMS(Index = 217)]
        /* 0x1F8C */ public float PlayerPredatorHealthModifier;
        [NMS(Index = 228)]
        /* 0x1F90 */ public float PlayerPredatorRegainInterestTime;
        [NMS(Index = 46)]
        /* 0x1F94 */ public float PostRideMoveTime;
        [NMS(Index = 218)]
        /* 0x1F98 */ public float PredatorApproachTime;
        [NMS(Index = 225)]
        /* 0x1F9C */ public float PredatorBoredomDistance;
        [NMS(Index = 221)]
        /* 0x1FA0 */ public float PredatorChargeDist;
        [NMS(Index = 222)]
        /* 0x1FA4 */ public float PredatorChargeDistScale;
        [NMS(Index = 233)]
        /* 0x1FA8 */ public float PredatorEnergyRecoverRate;
        [NMS(Index = 234)]
        /* 0x1FAC */ public float PredatorEnergyUseChasing;
        [NMS(Index = 209)]
        /* 0x1FB0 */ public float PredatorFishPerceptionDistance;
        [NMS(Index = 216)]
        /* 0x1FB4 */ public int PredatorHugeHealth;
        [NMS(Index = 215)]
        /* 0x1FB8 */ public int PredatorLargeHealth;
        [NMS(Index = 214)]
        /* 0x1FBC */ public int PredatorMedHealth;
        [NMS(Index = 219)]
        /* 0x1FC0 */ public float PredatorNoticePauseTime;
        [NMS(Index = 208)]
        /* 0x1FC4 */ public float PredatorPerceptionDistance;
        [NMS(Index = 227)]
        /* 0x1FC8 */ public float PredatorRegainInterestTime;
        [NMS(Index = 230)]
        /* 0x1FCC */ public float PredatorRoarProbAfterHit;
        [NMS(Index = 231)]
        /* 0x1FD0 */ public float PredatorRoarProbAfterMiss;
        [NMS(Index = 229)]
        /* 0x1FD4 */ public float PredatorRunAwayDist;
        [NMS(Index = 232)]
        /* 0x1FD8 */ public float PredatorRunAwayHealthPercent;
        [NMS(Index = 349)]
        /* 0x1FDC */ public float PredatorRunMoveSpeed;
        [NMS(Index = 213)]
        /* 0x1FE0 */ public int PredatorSmallHealth;
        [NMS(Index = 557)]
        /* 0x1FE4 */ public float PredatorSpeedMultiplier;
        [NMS(Index = 220)]
        /* 0x1FE8 */ public float PredatorStealthDist;
        [NMS(Index = 348)]
        /* 0x1FEC */ public float PredatorTrotMoveSpeed;
        [NMS(Index = 347)]
        /* 0x1FF0 */ public float PredatorWalkMoveSpeed;
        [NMS(Index = 270)]
        /* 0x1FF4 */ public float QueenHealthLevelMul;
        [NMS(Index = 310)]
        /* 0x1FF8 */ public float RagdollConeLimit;
        [NMS(Index = 309)]
        /* 0x1FFC */ public float RagdollDamping;
        [NMS(Index = 313)]
        /* 0x2000 */ public float RagdollMotorFadeEnd;
        [NMS(Index = 312)]
        /* 0x2004 */ public float RagdollMotorFadeStart;
        [NMS(Index = 308)]
        /* 0x2008 */ public float RagdollTau;
        [NMS(Index = 311)]
        /* 0x200C */ public float RagdollTwistLimit;
        [NMS(Index = 96)]
        /* 0x2010 */ public float RecoverHealthTime;
        [NMS(Index = 163)]
        /* 0x2014 */ public float RepelAmount;
        [NMS(Index = 162)]
        /* 0x2018 */ public float RepelRange;
        [NMS(Index = 63)]
        /* 0x201C */ public float ResourceSpawnTime;
        [NMS(Index = 47)]
        /* 0x2020 */ public float RideIdleTime;
        [NMS(Index = 45)]
        /* 0x2024 */ public float RiderLeanTime;
        [NMS(Index = 44)]
        /* 0x2028 */ public float RideSpeedChangeTime;
        [NMS(Index = 43)]
        /* 0x202C */ public float RideSpeedFast;
        [NMS(Index = 42)]
        /* 0x2030 */ public float RideSpeedSlow;
        [NMS(Index = 37)]
        /* 0x2034 */ public float RidingFirstPersonOffsetFwd;
        [NMS(Index = 38)]
        /* 0x2038 */ public float RidingFirstPersonOffsetUp;
        [NMS(Index = 34)]
        /* 0x203C */ public float RidingReplicationRangeMultiplier;
        [NMS(Index = 35)]
        /* 0x2040 */ public float RidingRollAdjustMaxAngle;
        [NMS(Index = 36)]
        /* 0x2044 */ public float RidingRollMaxAngleAt;
        [NMS(Index = 332)]
        /* 0x2048 */ public float RidingSteerWeight;
        [NMS(Index = 584)]
        /* 0x204C */ public float RockTransformGlobalChance;
        [NMS(Index = 307)]
        /* 0x2050 */ public float RoutineOffset;
        [NMS(Index = 306)]
        /* 0x2054 */ public float RoutineSpeed;
        [NMS(Index = 102)]
        /* 0x2058 */ public float SandWormChangeDirectionTime;
        [NMS(Index = 112)]
        /* 0x205C */ public float SandWormDespawnDist;
        [NMS(Index = 106)]
        /* 0x2060 */ public float SandWormJumpHeight;
        [NMS(Index = 107)]
        /* 0x2064 */ public float SandWormJumpTime;
        [NMS(Index = 105)]
        /* 0x2068 */ public float SandWormMaxHeightAdjust;
        [NMS(Index = 111)]
        /* 0x206C */ public int SandWormMaxJumps;
        [NMS(Index = 104)]
        /* 0x2070 */ public float SandWormMaxSteer;
        [NMS(Index = 116)]
        /* 0x2074 */ public float SandWormSpawnChanceInfested;
        [NMS(Index = 115)]
        /* 0x2078 */ public float SandWormSpawnChanceMax;
        [NMS(Index = 114)]
        /* 0x207C */ public float SandWormSpawnChanceMin;
        [NMS(Index = 113)]
        /* 0x2080 */ public float SandWormSpawnTimer;
        [NMS(Index = 103)]
        /* 0x2084 */ public float SandWormSteerAdjustTime;
        [NMS(Index = 108)]
        /* 0x2088 */ public float SandWormSubmergeDepth;
        [NMS(Index = 109)]
        /* 0x208C */ public float SandWormSubmergeTime;
        [NMS(Index = 110)]
        /* 0x2090 */ public float SandWormSurfaceTime;
        [NMS(Index = 69)]
        /* 0x2094 */ public float SceneTerrainSpawnMinDistance;
        [NMS(Index = 245)]
        /* 0x2098 */ public int ScuttlerHealth;
        [NMS(Index = 250)]
        /* 0x209C */ public float ScuttlerIdleTimeMax;
        [NMS(Index = 249)]
        /* 0x20A0 */ public float ScuttlerIdleTimeMin;
        [NMS(Index = 246)]
        /* 0x20A4 */ public float ScuttlerInitialNoAttackTime;
        [NMS(Index = 248)]
        /* 0x20A8 */ public float ScuttlerMoveTimeMax;
        [NMS(Index = 247)]
        /* 0x20AC */ public float ScuttlerMoveTimeMin;
        [NMS(Index = 255)]
        /* 0x20B0 */ public float ScuttlerSpitChargeTime;
        [NMS(Index = 254)]
        /* 0x20B4 */ public float ScuttlerSpitDelay;
        [NMS(Index = 253)]
        /* 0x20B8 */ public float ScuttlerZigZagStrength;
        [NMS(Index = 252)]
        /* 0x20BC */ public float ScuttlerZigZagTimeMax;
        [NMS(Index = 251)]
        /* 0x20C0 */ public float ScuttlerZigZagTimeMin;
        [NMS(Index = 444)]
        /* 0x20C4 */ public float SearchItemDistance;
        [NMS(Index = 445)]
        /* 0x20C8 */ public float SearchItemFrequency;
        [NMS(Index = 446)]
        /* 0x20CC */ public float SearchItemGiveUpDistance;
        [NMS(Index = 447)]
        /* 0x20D0 */ public float SearchItemGiveUpTime;
        [NMS(Index = 448)]
        /* 0x20D4 */ public float SearchItemNotifyTime;
        [NMS(Index = 449)]
        /* 0x20D8 */ public float SearchSpawnRandomItemProbability;
        [NMS(Index = 138)]
        /* 0x20DC */ public float SharkAlignSpeed;
        [NMS(Index = 129)]
        /* 0x20E0 */ public float SharkAlongPathSpeed;
        [NMS(Index = 133)]
        /* 0x20E4 */ public float SharkAttackAccel;
        [NMS(Index = 132)]
        /* 0x20E8 */ public float SharkAttackSpeed;
        [NMS(Index = 137)]
        /* 0x20EC */ public float SharkGetToPathSpeed;
        [NMS(Index = 136)]
        /* 0x20F0 */ public float SharkPatrolEnd;
        [NMS(Index = 135)]
        /* 0x20F4 */ public float SharkPatrolRadius;
        [NMS(Index = 134)]
        /* 0x20F8 */ public float SharkPatrolSpeed;
        [NMS(Index = 131)]
        /* 0x20FC */ public float SharkToPathYDamp;
        [NMS(Index = 128)]
        /* 0x2100 */ public float ShieldFadeTime;
        [NMS(Index = 206)]
        /* 0x2104 */ public float SmallCreatureAvoidPlayerDistance;
        [NMS(Index = 204)]
        /* 0x2108 */ public float SmallCreatureFleePlayerDistance;
        [NMS(Index = 202)]
        /* 0x210C */ public float SmallCreaturePerceptionDistance;
        [NMS(Index = 338)]
        /* 0x2110 */ public float SoftenAvoidanceRadiusMod;
        [NMS(Index = 341)]
        /* 0x2114 */ public float SpaceJellySwimSpeed;
        [NMS(Index = 367)]
        /* 0x2118 */ public float SpawnCameraAngleCos;
        [NMS(Index = 171)]
        /* 0x211C */ public float SpawnDistanceModifierForUnderwater;
        [NMS(Index = 374)]
        /* 0x2120 */ public float SpawnDistAtMaxSize;
        [NMS(Index = 373)]
        /* 0x2124 */ public float SpawnDistAtMinSize;
        [NMS(Index = 368)]
        /* 0x2128 */ public float SpawnMinDistPercentage;
        [NMS(Index = 369)]
        /* 0x212C */ public float SpawnOnscreenDist;
        [NMS(Index = 379)]
        /* 0x2130 */ public float SpawnsAvoidBaseMultiplier;
        [NMS(Index = 353)]
        /* 0x2134 */ public float SteeringUpdateRate;
        [NMS(Index = 174)]
        /* 0x2138 */ public float StickToGroundCastBegin;
        [NMS(Index = 175)]
        /* 0x213C */ public float StickToGroundCastEnd;
        [NMS(Index = 173)]
        /* 0x2140 */ public float StickToGroundSpeed;
        [NMS(Index = 130)]
        /* 0x2144 */ public float SwarmBrakingForce;
        [NMS(Index = 149)]
        /* 0x2148 */ public float SwarmMoveYFactor;
        [NMS(Index = 165)]
        /* 0x214C */ public float TargetReachedDistance;
        [NMS(Index = 147)]
        /* 0x2150 */ public float TargetSearchTimeout;
        [NMS(Index = 383)]
        /* 0x2154 */ public float TrailHalfLife;
        [NMS(Index = 64)]
        /* 0x2158 */ public float TurnInPlaceIdleTime;
        [NMS(Index = 65)]
        /* 0x215C */ public float TurnInPlaceMaxAngle;
        [NMS(Index = 67)]
        /* 0x2160 */ public float TurnInPlaceMaxSpeed;
        [NMS(Index = 68)]
        /* 0x2164 */ public float TurnInPlaceMaxSpeedIndoor;
        [NMS(Index = 66)]
        /* 0x2168 */ public float TurnInPlaceMinTime;
        [NMS(Index = 316)]
        /* 0x216C */ public float TurnRadiusMultiplier;
        [NMS(Index = 318)]
        /* 0x2170 */ public float TurnSlowAreaCos;
        [NMS(Index = 154)]
        /* 0x2174 */ public float VelocityAlignSpeed;
        [NMS(Index = 153)]
        /* 0x2178 */ public float VelocityAlignStrength;
        [NMS(Index = 327)]
        /* 0x217C */ public float VelocityAlignYFactorMax;
        [NMS(Index = 326)]
        /* 0x2180 */ public float VelocityAlignYFactorMin;
        [NMS(Index = 170)]
        /* 0x2184 */ public float WaterSpawnOffset;
        [NMS(Index = 152)]
        /* 0x2188 */ public float WeaponRepelAmount;
        [NMS(Index = 151)]
        /* 0x218C */ public float WeaponRepelRange;
        [NMS(Index = 235)]
        /* 0x2190 */ public bool AggressiveSharks;
        [NMS(Index = 578)]
        /* 0x2191 */ public bool AllBaitIsBasic;
        [NMS(Index = 381)]
        /* 0x2192 */ public bool AllowSleeping;
        [NMS(Index = 62)]
        /* 0x2193 */ public bool AllowSpawningOnscreen;
        [NMS(Index = 579)]
        /* 0x2194 */ public bool CanAlwaysLayEgg;
        [NMS(Index = 12)]
        /* 0x2195 */ public bool CreatureInteractWithoutRaycasts;
        [NMS(Index = 40)]
        /* 0x2196 */ public bool CreatureRideDirectControl;
        [NMS(Index = 382)]
        /* 0x2197 */ public bool DebugDrawTrails;
        [NMS(Index = 451)]
        /* 0x2198 */ public bool DebugSearch;
        [NMS(Index = 389)]
        /* 0x2199 */ public bool DetailAnimPlayWhileWalking;
        [NMS(Index = 554)]
        /* 0x219A */ public bool DrawGrassPushRadius;
        [NMS(Index = 549)]
        /* 0x219B */ public bool DrawRoutineFollowDebug;
        [NMS(Index = 550)]
        /* 0x219C */ public bool DrawRoutineInfo;
        [NMS(Index = 29)]
        /* 0x219D */ public bool EnableFlyingSnakeTails;
        [NMS(Index = 33)]
        /* 0x219E */ public bool EnableMPCreatureRide;
        [NMS(Index = 30)]
        /* 0x219F */ public bool EnableNewStuff;
        [NMS(Index = 384)]
        /* 0x21A0 */ public bool EnableTrailIk;
        [NMS(Index = 32)]
        /* 0x21A1 */ public bool EnableVRCreatureRide;
        [NMS(Index = 261)]
        /* 0x21A2 */ public bool FiendOnscreenMarkers;
        [NMS(Index = 260)]
        /* 0x21A3 */ public bool FiendsCanAttack;
        [NMS(Index = 396)]
        /* 0x21A4 */ public bool ForceStatic;
        [NMS(Index = 31)]
        /* 0x21A5 */ public bool InstantCreatureRide;
        [NMS(Index = 28)]
        /* 0x21A6 */ public bool IsHurtingCreaturesACrime;
        [NMS(Index = 521)]
        /* 0x21A7 */ public bool PetAnimTest;
        [NMS(Index = 500)]
        /* 0x21A8 */ public bool PetCanSummonOnFreighter;
        [NMS(Index = 518)]
        /* 0x21A9 */ public bool PetForceSummonFromEgg;
        [NMS(Index = 461)]
        /* 0x21AA */ public bool PetsShowTraitClassesAsWords;
        [NMS(Index = 395)]
        /* 0x21AB */ public bool PiedPiper;
        [NMS(Index = 378)]
        /* 0x21AC */ public bool ProcessPendingSpawnRequests;
        [NMS(Index = 520)]
        /* 0x21AD */ public bool RidingPositionTest;
        [NMS(Index = 244)]
        /* 0x21AE */ public bool ScuttlersCanAttack;
        [NMS(Index = 179)]
        /* 0x21AF */ public bool ShowScale;
        [NMS(Index = 41)]
        /* 0x21B0 */ public bool StaticCreatureRide;
        [NMS(Index = 61)]
        /* 0x21B1 */ public bool UncapSpawningforVideo;
        [NMS(Index = 443)]
        /* 0x21B2 */ public bool UseCreatureAdoptOSD;
        [NMS(Index = 522)]
        /* 0x21B3 */ public bool UsePetTeleportEffect;
    }
}
