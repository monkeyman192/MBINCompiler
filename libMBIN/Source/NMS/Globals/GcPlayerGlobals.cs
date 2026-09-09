using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xCC15C91D61EC149C, NameHash = 0xFC6CA276)]
    public class GcPlayerGlobals : NMSTemplate
    {
        [NMS(Index = 30)]
        /* 0x0000 */ public GcProjectorOffsetData LargeWeaponMenuTransforms;
        [NMS(Index = 27)]
        /* 0x0070 */ public GcProjectorOffsetData QuickMenuLauncherTransforms;
        [NMS(Index = 28)]
        /* 0x00E0 */ public GcProjectorOffsetData QuickMenuLauncherTransformsNoBuildMenu;
        [NMS(Index = 29)]
        /* 0x0150 */ public GcProjectorOffsetData WeaponMenuTransforms;
        [NMS(Index = 185)]
        /* 0x01C0 */ public GcScanEffectData ArmourHighlightScanEffect;
        [NMS(Index = 159)]
        /* 0x0210 */ public GcScanEffectData HolsterHighlightEffect;
        [NMS(Index = 158)]
        /* 0x0260 */ public GcScanEffectData InteractHighlightEffect;
        [NMS(Index = 579)]
        /* 0x02B0 */ public GcScanEffectData MeleeHitEffect;
        [NMS(Index = 912)]
        /* 0x0300 */ public GcCameraAnomalySetupData AnomalyAtlasStationSpawnData;
        [NMS(Index = 911)]
        /* 0x0340 */ public GcCameraAnomalySetupData AnomalyBlachHoleSpawnData;
        [NMS(Index = 913)]
        /* 0x0380 */ public GcCameraAnomalySetupData AnomalyMiniStationSpawnData;
        [NMS(Index = 40)]
        /* 0x03C0 */ public GcInWorldUIScreenData BinocularInfoScreenOffset;
        [NMS(Index = 41)]
        /* 0x03F0 */ public GcInWorldUIScreenData BinocularInfoScreenOffsetGun;
        [NMS(Index = 38)]
        /* 0x0420 */ public GcInWorldUIScreenData DefaultLeftHandTransform;
        [NMS(Index = 39)]
        /* 0x0450 */ public GcInWorldUIScreenData DefaultLeftHandTransformVehicle;
        [NMS(Index = 43)]
        /* 0x0480 */ public GcInWorldUIScreenData FrontendBaseScreenshotVROffset;
        [NMS(Index = 37)]
        /* 0x04B0 */ public GcInWorldUIScreenData FrontendMessagesOffset;
        [NMS(Index = 33)]
        /* 0x04E0 */ public GcInWorldUIScreenData FrontendOffset;
        [NMS(Index = 36)]
        /* 0x0510 */ public GcInWorldUIScreenData FrontendOffsetV2;
        [NMS(Index = 42)]
        /* 0x0540 */ public GcInWorldUIScreenData FrontendPhotoModeVROffset;
        [NMS(Index = 32)]
        /* 0x0570 */ public GcInWorldUIScreenData InventoryOffset;
        [NMS(Index = 35)]
        /* 0x05A0 */ public GcInWorldUIScreenData InventoryOffsetV2;
        [NMS(Index = 86)]
        /* 0x05D0 */ public GcInWorldUIScreenData InWorldCompass;
        [NMS(Index = 31)]
        /* 0x0600 */ public GcInWorldUIScreenData QuickMenuOffset;
        [NMS(Index = 34)]
        /* 0x0630 */ public GcInWorldUIScreenData QuickMenuOffsetV2;
        [NMS(Index = 46)]
        /* 0x0660 */ public Vector3f BinocularScopeOffset;
        [NMS(Index = 337)]
        /* 0x0670 */ public Colour DefaultMuzzleColour;
        [NMS(Index = 342)]
        /* 0x0680 */ public Colour DefaultMuzzleLaserColour;
        [NMS(Index = 85)]
        /* 0x0690 */ public Vector3f HandScreenRoboOnScreenOffset;
        [NMS(Index = 107)]
        /* 0x06A0 */ public Vector3f HolsterHeadOffset;
        [NMS(Index = 156)]
        /* 0x06B0 */ public Colour InteractionLineActiveColour;
        [NMS(Index = 157)]
        /* 0x06C0 */ public Colour InteractionLineBaseColour;
        [NMS(Index = 1)]
        /* 0x06D0 */ public Vector3f LeftHandModeFishingRodAttachSocketCorrection;
        [NMS(Index = 0)]
        /* 0x06E0 */ public Vector3f LeftHandModeWeaponAttachSocketCorrection;
        [NMS(Index = 106)]
        /* 0x06F0 */ public Vector3f PointingWristAngles;
        [NMS(Index = 182)]
        /* 0x0700 */ public Colour SearchGroupIconColour;
        [NMS(Index = 581)]
        /* 0x0710 */ public Colour StarFieldColour;
        [NMS(Index = 339)]
        /* 0x0720 */ public Colour TerrainEditorMuzzleColourAdd;
        [NMS(Index = 340)]
        /* 0x0730 */ public Colour TerrainEditorMuzzleColourFlatten;
        [NMS(Index = 338)]
        /* 0x0740 */ public Colour TerrainEditorMuzzleColourSubtract;
        [NMS(Index = 341)]
        /* 0x0750 */ public Colour TerrainEditorMuzzleColourUndo;
        [NMS(Index = 538)]
        /* 0x0760 */ public Vector3f TraderStayCloseLockBaseOffset;
        [NMS(Index = 774)]
        /* 0x0770 */ public Vector3f WeaponBarrelOffset;
        [NMS(Index = 775)]
        /* 0x0780 */ public Vector3f WeaponOffset;
        [NMS(Index = 928)]
        /* 0x0790 */ public GcShipDialogue TraderHailMessages;
        [NMS(Index = 927)]
        /* 0x09F8 */ public GcPlayerCommunicatorMessage PirateHailMessage;
        [NMS(Index = 926)]
        /* 0x0A48 */ public GcPlayerCommunicatorMessage PoliceScanHailMessage;
        [NMS(Index = 522)]
        /* 0x0A98 */ public NMSString0x20A TraderHailReceiveOSDLoc;
        [NMS(Index = 523)]
        /* 0x0AB8 */ public NMSString0x20A TraderHailRefusedOSDLoc;
        [NMS(Index = 744)]
        /* 0x0AD8 */ public List<GcCreatureAlertData> AlertTable;
        [NMS(Index = 181)]
        /* 0x0AE8 */ public NMSString0x10 DebugSearchGroup;
        [NMS(Index = 183)]
        /* 0x0AF8 */ public GcFilename DefaultShipFilename;
        [NMS(Index = 184)]
        /* 0x0B08 */ public GcSeed DefaultShipSeed;
        [NMS(Index = 495)]
        /* 0x0B18 */ public NMSString0x10 ExosuitUpgradeProduct;
        [NMS(Index = 730)]
        /* 0x0B28 */ public NMSString0x10 ExperienceDefeatBugQueenRewardID;
        [NMS(Index = 731)]
        /* 0x0B38 */ public NMSString0x10 ExperienceDefeatBugQueenRewardIDProduct;
        [NMS(Index = 727)]
        /* 0x0B48 */ public NMSString0x10 ExperienceDefeatJellyBossRewardID;
        [NMS(Index = 725)]
        /* 0x0B58 */ public NMSString0x10 ExperienceDefeatLevel5SentinelsCorrupt;
        [NMS(Index = 724)]
        /* 0x0B68 */ public NMSString0x10 ExperienceDefeatLevel5SentinelsNearHiveReward;
        [NMS(Index = 723)]
        /* 0x0B78 */ public NMSString0x10 ExperienceDefeatLevel5SentinelsReward;
        [NMS(Index = 721)]
        /* 0x0B88 */ public NMSString0x10 ExperienceDefeatLevel5SpaceSentinelsReward;
        [NMS(Index = 902)]
        /* 0x0B98 */ public List<GcCameraSpawnSetupData> FirstSpawnDataTable;
        [NMS(Index = 856)]
        /* 0x0BA8 */ public NMSString0x10 FootDustEffect;
        [NMS(Index = 734)]
        /* 0x0BB8 */ public GcFilename Gun;
        [NMS(Index = 176)]
        /* 0x0BC8 */ public GcFilename NoShadowMaterial;
        [NMS(Index = 550)]
        /* 0x0BD8 */ public NMSString0x10 PulseEncounterSpaceEggID;
        [NMS(Index = 907)]
        /* 0x0BE8 */ public List<float> TechLearningProbabilities;
        [NMS(Index = 906)]
        /* 0x0BF8 */ public List<float> TechRarityData;
        [NMS(Index = 624)]
        /* 0x0C08 */ public List<float> WantedEscalateTime;
        [NMS(Index = 625)]
        /* 0x0C18 */ public List<float> WantedExtremeEscalateTime;
        [NMS(Index = 623)]
        /* 0x0C28 */ public List<float> WantedTimeout;
        [NMS(Index = 890)]
        /* 0x0C38 */ public ulong AutoSaveMaxTime;
        [NMS(Index = 891)]
        /* 0x0C40 */ public ulong AutoSaveMinTime;
        [NMS(Index = 105)]
        /* 0x0C48 */ public ulong PointingWristAdjustmentTimeMilliseconds;
        [NMS(Index = 663)]
        /* 0x0C50 */ public GcResourceCollectEffect CrystalResourceCollect;
        [NMS(Index = 665)]
        /* 0x0C84 */ public GcResourceCollectEffect FishingResourceCollect;
        [NMS(Index = 664)]
        /* 0x0CB8 */ public GcResourceCollectEffect ShardResourceCollect;
        [NMS(Index = 660)]
        /* 0x0CEC */ public GcResourceCollectEffect TerrainResourceCollect;
        [NMS(Index = 662)]
        /* 0x0D20 */ public GcResourceCollectEffect TerrainResourceMeleeCollect;
        [NMS(Index = 661)]
        /* 0x0D54 */ public GcResourceCollectEffect TerrainResourceMiniCollect;
        [NMS(Index = 666)]
        /* 0x0D88 */ public GcBoidData MissileSwarm;
        [NMS(Index = 748)]
        /* 0x0DB4 */ public GcProjectileLineData PlayerBullet;
        [NMS(Index = 749)]
        /* 0x0DDC */ public GcProjectileLineData RobotBullet;
        [NMS(Index = 750)]
        /* 0x0E04 */ public GcProjectileLineData ShipBullet;
        [NMS(Index = 896)]
        /* 0x0E2C */ public GcPlayerStickData AmbientModeLookStickData;
        [NMS(Index = 905)]
        /* 0x0E48 */ public GcInventoryValueData FreighterValueData;
        [NMS(Index = 895)]
        /* 0x0E64 */ public GcPlayerStickData LookStickData;
        [NMS(Index = 903)]
        /* 0x0E80 */ public GcInventoryValueData ShipValueData;
        [NMS(Index = 667)]
        /* 0x0E9C */ public GcPlayerStickData StickData;
        [NMS(Index = 904)]
        /* 0x0EB8 */ public GcInventoryValueData WeaponValueData;
        [NMS(Index = 914)]
        /* 0x0ED4 */ public GcJourneyMedalTiers MedalTiers;
        [NMS(Index = 929, Size = 0x4)]
        /* 0x0EE4 */ public GcShipDialogueTreeEnum[] TraderHailReceiveRegular;
        [NMS(Index = 711)]
        /* 0x0EF4 */ public Vector2f ExperienceFlybyStartAngle;
        [NMS(Index = 67)]
        /* 0x0EFC */ public Vector2f FingerButtonQuickMenuButtonSize;
        [NMS(Index = 325)]
        /* 0x0F04 */ public Vector2f MouseSpringStrength;
        [NMS(Index = 327)]
        /* 0x0F0C */ public Vector2f MouseSpringStrengthMaxDelta;
        [NMS(Index = 326)]
        /* 0x0F14 */ public Vector2f MouseSpringStrengthMinDelta;
        [NMS(Index = 930, Size = 0x2)]
        /* 0x0F1C */ public GcShipDialogueTreeEnum[] TraderHailReceiveFight;
        [NMS(Index = 931, Size = 0x2)]
        /* 0x0F24 */ public GcShipDialogueTreeEnum[] TraderHailSend;
        [NMS(Index = 421)]
        /* 0x0F2C */ public float AbandonedFreighterRechargeMod;
        [NMS(Index = 414)]
        /* 0x0F30 */ public float AbandonedFreighterStaminaRate;
        [NMS(Index = 413)]
        /* 0x0F34 */ public float AbandonedFreighterStaminaRecoveryMod;
        [NMS(Index = 684)]
        /* 0x0F38 */ public float AimDecay;
        [NMS(Index = 690)]
        /* 0x0F3C */ public float AimDisperseCooldownFactor;
        [NMS(Index = 689)]
        /* 0x0F40 */ public float AimDisperseCooldownTime;
        [NMS(Index = 688)]
        /* 0x0F44 */ public float AimDisperseMinTime;
        [NMS(Index = 687)]
        /* 0x0F48 */ public float AimDisperseTime;
        [NMS(Index = 680)]
        /* 0x0F4C */ public float AimDistanceShip;
        [NMS(Index = 683)]
        /* 0x0F50 */ public float AimMinWeight;
        [NMS(Index = 685)]
        /* 0x0F54 */ public float AimOffset;
        [NMS(Index = 686)]
        /* 0x0F58 */ public float AimShootableTargetAngle;
        [NMS(Index = 681)]
        /* 0x0F5C */ public float AimSpeed;
        [NMS(Index = 682)]
        /* 0x0F60 */ public float AimWeightAdd;
        [NMS(Index = 4)]
        /* 0x0F64 */ public float AlienPodAggroDecay;
        [NMS(Index = 5)]
        /* 0x0F68 */ public float AlienPodAggroSpring;
        [NMS(Index = 841)]
        /* 0x0F6C */ public float AnimRunBlendPoint;
        [NMS(Index = 838)]
        /* 0x0F70 */ public float AnimRunSpeed;
        [NMS(Index = 840)]
        /* 0x0F74 */ public float AnimWalkBlendPoint;
        [NMS(Index = 837)]
        /* 0x0F78 */ public float AnimWalkSpeed;
        [NMS(Index = 839)]
        /* 0x0F7C */ public float AnimWalkToRunSpeed;
        [NMS(Index = 743)]
        /* 0x0F80 */ public float AtmosphereEffectOffset;
        [NMS(Index = 742)]
        /* 0x0F84 */ public float AtmosphereEffectTime;
        [NMS(Index = 670)]
        /* 0x0F88 */ public float AutoAimFixedInterceptSpeed;
        [NMS(Index = 669)]
        /* 0x0F8C */ public float AutoAimMaxAccelFactor;
        [NMS(Index = 672)]
        /* 0x0F90 */ public float AutoAimMaxAngle;
        [NMS(Index = 673)]
        /* 0x0F94 */ public float AutoAimMinScreenDistance;
        [NMS(Index = 674)]
        /* 0x0F98 */ public float AutoAimRadiusExtra;
        [NMS(Index = 677)]
        /* 0x0F9C */ public float AutoAimStickyMax;
        [NMS(Index = 676)]
        /* 0x0FA0 */ public float AutoAimStickyMin;
        [NMS(Index = 675)]
        /* 0x0FA4 */ public float AutoAimStickyRailgun;
        [NMS(Index = 671)]
        /* 0x0FA8 */ public float AutoAimTimeOut;
        [NMS(Index = 738)]
        /* 0x0FAC */ public float AutoLandRange;
        [NMS(Index = 739)]
        /* 0x0FB0 */ public float AutoLandTime;
        [NMS(Index = 894)]
        /* 0x0FB4 */ public float AutoSaveRangeInSpace;
        [NMS(Index = 893)]
        /* 0x0FB8 */ public float AutoSaveRangeInVehicle;
        [NMS(Index = 892)]
        /* 0x0FBC */ public float AutoSaveRangeOnFoot;
        [NMS(Index = 834)]
        /* 0x0FC0 */ public float BalanceSpeed;
        [NMS(Index = 833)]
        /* 0x0FC4 */ public float BalanceStrength;
        [NMS(Index = 189)]
        /* 0x0FC8 */ public float BaseUnderwaterDepth;
        [NMS(Index = 693)]
        /* 0x0FCC */ public float BeaconActivateRange;
        [NMS(Index = 644)]
        /* 0x0FD0 */ public float BeamRecoil;
        [NMS(Index = 918)]
        /* 0x0FD4 */ public int BestGuildRank;
        [NMS(Index = 45)]
        /* 0x0FD8 */ public float BincoularRayThickness;
        [NMS(Index = 16)]
        /* 0x0FDC */ public float BinocularAimOffset;
        [NMS(Index = 242)]
        /* 0x0FE0 */ public float BinocularCreatureCastSphereSize;
        [NMS(Index = 239)]
        /* 0x0FE4 */ public float BinocularRangePlanet;
        [NMS(Index = 240)]
        /* 0x0FE8 */ public float BinocularRangeSpace;
        [NMS(Index = 44)]
        /* 0x0FEC */ public float BinocularRayThicknessVR;
        [NMS(Index = 19)]
        /* 0x0FF0 */ public float BinocularScopeHandOffset;
        [NMS(Index = 20)]
        /* 0x0FF4 */ public float BinocularScopeHandOffsetUp;
        [NMS(Index = 17)]
        /* 0x0FF8 */ public float BinocularScopeScale;
        [NMS(Index = 18)]
        /* 0x0FFC */ public float BinocularScopeSmoothing;
        [NMS(Index = 47)]
        /* 0x1000 */ public float BinocularsHUDDistanceVR;
        [NMS(Index = 48)]
        /* 0x1004 */ public float BinocularsHUDScaleVR;
        [NMS(Index = 647)]
        /* 0x1008 */ public float BlastRecoilSpring;
        [NMS(Index = 97)]
        /* 0x100C */ public float BodyRealignmentDelay;
        [NMS(Index = 794)]
        /* 0x1010 */ public float BulletBend;
        [NMS(Index = 480)]
        /* 0x1014 */ public int BulletClipMultiplier;
        [NMS(Index = 479)]
        /* 0x1018 */ public int BulletCostReducer;
        [NMS(Index = 650)]
        /* 0x101C */ public float CannonRecoilSpring;
        [NMS(Index = 478)]
        /* 0x1020 */ public int ChanceHighGradeIllegal;
        [NMS(Index = 806)]
        /* 0x1024 */ public float ChargedEnergyBallSpeed;
        [NMS(Index = 565)]
        /* 0x1028 */ public float ChargeMeleeCooldown;
        [NMS(Index = 804)]
        /* 0x102C */ public float ChargeTime;
        [NMS(Index = 233)]
        /* 0x1030 */ public float CheckBeneathPlayerForGroundAfterKickedFromCorvetteDistance;
        [NMS(Index = 861)]
        /* 0x1034 */ public float ClimbableStickinessAngle;
        [NMS(Index = 859)]
        /* 0x1038 */ public float ClingAngleThreshold;
        [NMS(Index = 858)]
        /* 0x103C */ public float ClingBrakeMultiplier;
        [NMS(Index = 860)]
        /* 0x1040 */ public float ClingSpeedThreshold;
        [NMS(Index = 238)]
        /* 0x1044 */ public float CockpitEjectFirstPersonOffset;
        [NMS(Index = 237)]
        /* 0x1048 */ public float CockpitEjectFirstPersonOffsetTime;
        [NMS(Index = 322)]
        /* 0x104C */ public float CockpitEjectSideTestRange;
        [NMS(Index = 236)]
        /* 0x1050 */ public float CockpitEjectTestEndHeightOffset;
        [NMS(Index = 234)]
        /* 0x1054 */ public float CockpitEjectTestRadius;
        [NMS(Index = 320)]
        /* 0x1058 */ public float CockpitEjectTestSphereRadius;
        [NMS(Index = 321)]
        /* 0x105C */ public float CockpitEjectTestSphereRange;
        [NMS(Index = 235)]
        /* 0x1060 */ public float CockpitEjectTestStartHeightOffset;
        [NMS(Index = 491)]
        /* 0x1064 */ public float CombatEscalateTime;
        [NMS(Index = 492)]
        /* 0x1068 */ public float CombatEscapeRadius;
        [NMS(Index = 493)]
        /* 0x106C */ public float CombatEscapeTime;
        [NMS(Index = 311)]
        /* 0x1070 */ public float CombatSpawnMinWantedTime;
        [NMS(Index = 315)]
        /* 0x1074 */ public float CommunicatorSpeed;
        // size: 0x3
        public enum ControlModesEnum : uint {
            Normal,
            FlightStick,
            Inverted,
        }
        [NMS(Index = 626)]
        /* 0x1078 */ public ControlModesEnum ControlModes;
        [NMS(Index = 247)]
        /* 0x107C */ public float CreativeModeDeathFadeInTime;
        [NMS(Index = 248)]
        /* 0x1080 */ public float CreativeModeDeathFadeOutTime;
        [NMS(Index = 250)]
        /* 0x1084 */ public float CreatureRideFadeInTime;
        [NMS(Index = 251)]
        /* 0x1088 */ public float CreatureRideFadeOutTime;
        [NMS(Index = 901)]
        /* 0x108C */ public float CriticalHitDesatFreq;
        [NMS(Index = 900)]
        /* 0x1090 */ public float CriticalHitDesatTime;
        [NMS(Index = 899)]
        /* 0x1094 */ public float CriticalHitTime;
        [NMS(Index = 692)]
        /* 0x1098 */ public float CrosshairTime;
        [NMS(Index = 469)]
        /* 0x109C */ public float CrouchHeightToDisableLegBlendingVR;
        [NMS(Index = 809)]
        /* 0x10A0 */ public float DamageRateWhenUnderNoGravity;
        [NMS(Index = 412)]
        /* 0x10A4 */ public float DamageRepairFactor;
        [NMS(Index = 558)]
        /* 0x10A8 */ public float DeathDamageDrainChargeFactor;
        [NMS(Index = 559)]
        /* 0x10AC */ public int DeathDamageTechBrokenPercent;
        [NMS(Index = 882)]
        /* 0x10B0 */ public float DeathScreenFadeInThirdPerson;
        [NMS(Index = 884)]
        /* 0x10B4 */ public float DeathScreenFadeInTime;
        [NMS(Index = 883)]
        /* 0x10B8 */ public float DeathScreenFadeInUnderwaterThirdPerson;
        [NMS(Index = 889)]
        /* 0x10BC */ public float DeathScreenFadeOutTime;
        [NMS(Index = 887)]
        /* 0x10C0 */ public float DeathScreenMaxRegenWaitTime;
        [NMS(Index = 888)]
        /* 0x10C4 */ public float DeathScreenMinRegenWaitTime;
        [NMS(Index = 886)]
        /* 0x10C8 */ public float DeathScreenPauseTime;
        [NMS(Index = 885)]
        /* 0x10CC */ public float DeathScreenShipFadeInTime;
        [NMS(Index = 232)]
        /* 0x10D0 */ public float DeepWaterDepth;
        [NMS(Index = 260)]
        /* 0x10D4 */ public int DefaultHealthPips;
        [NMS(Index = 259)]
        /* 0x10D8 */ public int DefaultHitPoints;
        [NMS(Index = 261)]
        /* 0x10DC */ public int DefaultShipHealthPips;
        [NMS(Index = 440)]
        /* 0x10E0 */ public float DestroyEffectFinalDelay;
        [NMS(Index = 499)]
        /* 0x10E4 */ public float DroneProbeScanTime;
        [NMS(Index = 278)]
        /* 0x10E8 */ public float DroneScanTimeToForget;
        [NMS(Index = 264)]
        /* 0x10EC */ public float DroneSpawnAccelerator;
        [NMS(Index = 244)]
        /* 0x10F0 */ public float DroneStartLocationRadius;
        [NMS(Index = 417)]
        /* 0x10F4 */ public float EarlyHazardTimeMultiplier;
        [NMS(Index = 805)]
        /* 0x10F8 */ public float EnergyBallSpeed;
        [NMS(Index = 329)]
        /* 0x10FC */ public float EnergyDamageMinTime;
        [NMS(Index = 334)]
        /* 0x1100 */ public float EnergyDischargeRateDeepWater;
        [NMS(Index = 333)]
        /* 0x1104 */ public float EnergyDischargeRateFloatingInSpace;
        [NMS(Index = 332)]
        /* 0x1108 */ public float EnergyDischargeRateHigh;
        [NMS(Index = 330)]
        /* 0x110C */ public float EnergyDischargeRateLow;
        [NMS(Index = 331)]
        /* 0x1110 */ public float EnergyDischargeRateMedium;
        [NMS(Index = 335)]
        /* 0x1114 */ public float EnergyPainRate;
        [NMS(Index = 836)]
        /* 0x1118 */ public float ExertionFromPainTime;
        [NMS(Index = 835)]
        /* 0x111C */ public float ExertionSmoothTime;
        [NMS(Index = 712)]
        /* 0x1120 */ public float ExperienceAlertRange;
        [NMS(Index = 714)]
        /* 0x1124 */ public float ExperienceAlertSightAngle;
        [NMS(Index = 713)]
        /* 0x1128 */ public float ExperienceAlertSightRange;
        [NMS(Index = 729)]
        /* 0x112C */ public float ExperienceDefeatBugQueenFiendSplatDelay;
        [NMS(Index = 732)]
        /* 0x1130 */ public float ExperienceDefeatBugQueenRewardChance;
        [NMS(Index = 728)]
        /* 0x1134 */ public float ExperienceDefeatBugQueenRewardDelay;
        [NMS(Index = 726)]
        /* 0x1138 */ public float ExperienceDefeatLevel5SentinelsDisableWantedTime;
        [NMS(Index = 722)]
        /* 0x113C */ public float ExperienceDefeatLevel5SentinelsRewardDelay;
        [NMS(Index = 719)]
        /* 0x1140 */ public float ExperienceDefeatLevel5SpaceSentinelsMessageDelay;
        [NMS(Index = 720)]
        /* 0x1144 */ public float ExperienceDefeatLevel5SpaceSentinelsRewardDelay;
        [NMS(Index = 718)]
        /* 0x1148 */ public float ExperienceDefeatLevel5SpaceSentinelsWarpDelay;
        [NMS(Index = 716)]
        /* 0x114C */ public float ExperienceDroneSpawnAngle;
        [NMS(Index = 715)]
        /* 0x1150 */ public float ExperienceDroneSpawnOffset;
        [NMS(Index = 708)]
        /* 0x1154 */ public float ExperienceDroneTimeMax;
        [NMS(Index = 707)]
        /* 0x1158 */ public float ExperienceDroneTimeMin;
        [NMS(Index = 709)]
        /* 0x115C */ public float ExperienceFlybyScareRadius;
        [NMS(Index = 710)]
        /* 0x1160 */ public float ExperienceFlybyScareTime;
        [NMS(Index = 313)]
        /* 0x1164 */ public float ExperienceHardPiratesDamageMaxOdds;
        [NMS(Index = 701)]
        /* 0x1168 */ public float ExperienceInterestingDroneDistance;
        [NMS(Index = 700)]
        /* 0x116C */ public float ExperienceInterestingFreighterDistance;
        [NMS(Index = 698)]
        /* 0x1170 */ public float ExperienceInterestingPoliceDistance;
        [NMS(Index = 699)]
        /* 0x1174 */ public float ExperienceInterestingShipDistance;
        [NMS(Index = 695)]
        /* 0x1178 */ public int ExperienceMaxCivilianShipSpawnsInSpace;
        [NMS(Index = 694)]
        /* 0x117C */ public int ExperienceMaxCivilianShipSpawnsOnPlanet;
        [NMS(Index = 314)]
        /* 0x1180 */ public float ExperienceMediumPiratesDamageMaxOdds;
        [NMS(Index = 717)]
        /* 0x1184 */ public float ExperienceMessageBroadcastNearbyDistance;
        [NMS(Index = 704)]
        /* 0x1188 */ public int ExperiencePirateCloseAttackPercentage;
        [NMS(Index = 696)]
        /* 0x118C */ public float ExperiencePirateFreighterAttackRange;
        [NMS(Index = 312)]
        /* 0x1190 */ public float ExperiencePiratesDifficultyVariance;
        [NMS(Index = 706)]
        /* 0x1194 */ public float ExperiencePirateTimeMax;
        [NMS(Index = 705)]
        /* 0x1198 */ public float ExperiencePirateTimeMin;
        [NMS(Index = 703)]
        /* 0x119C */ public float ExperienceShipTimeMax;
        [NMS(Index = 702)]
        /* 0x11A0 */ public float ExperienceShipTimeMin;
        [NMS(Index = 697)]
        /* 0x11A4 */ public float ExperienceWalkerSize;
        [NMS(Index = 751)]
        /* 0x11A8 */ public float ExplodeShakeMaxDist;
        [NMS(Index = 752)]
        /* 0x11AC */ public float ExplodeShakeMaxDistSpace;
        [NMS(Index = 753)]
        /* 0x11B0 */ public float ExplodeShakeStrength;
        [NMS(Index = 438)]
        /* 0x11B4 */ public float ExplosionBoundingInset;
        [NMS(Index = 439)]
        /* 0x11B8 */ public float ExplosionBoundingInsetRange;
        [NMS(Index = 437)]
        /* 0x11BC */ public float ExplosionScaleVariance;
        [NMS(Index = 435)]
        /* 0x11C0 */ public float ExplosionTimePerEffect;
        [NMS(Index = 436)]
        /* 0x11C4 */ public float ExplosionTimeVariance;
        [NMS(Index = 63)]
        /* 0x11C8 */ public float FingerButtonClickSize;
        [NMS(Index = 65)]
        /* 0x11CC */ public float FingerButtonClickTime;
        [NMS(Index = 66)]
        /* 0x11D0 */ public float FingerButtonQuickMenuOffset;
        [NMS(Index = 64)]
        /* 0x11D4 */ public float FingerButtonRadiusOffset;
        [NMS(Index = 62)]
        /* 0x11D8 */ public float FingerTipOffset;
        [NMS(Index = 87)]
        /* 0x11DC */ public float FistClenchBlendInTime;
        [NMS(Index = 88)]
        /* 0x11E0 */ public float FistClenchBlendOutTime;
        [NMS(Index = 658)]
        /* 0x11E4 */ public float FlamethrowerDispersion;
        [NMS(Index = 760)]
        /* 0x11E8 */ public float FlashGrow;
        [NMS(Index = 755)]
        /* 0x11EC */ public float FlashPosX;
        [NMS(Index = 756)]
        /* 0x11F0 */ public float FlashPosY;
        [NMS(Index = 757)]
        /* 0x11F4 */ public float FlashPosZ;
        [NMS(Index = 759)]
        /* 0x11F8 */ public float FlashPulse;
        [NMS(Index = 754)]
        /* 0x11FC */ public float FlashSize;
        [NMS(Index = 758)]
        /* 0x1200 */ public float FlashSpeed;
        [NMS(Index = 8)]
        /* 0x1204 */ public float FoodValueThresholdAverage;
        [NMS(Index = 9)]
        /* 0x1208 */ public float FoodValueThresholdBad;
        [NMS(Index = 6)]
        /* 0x120C */ public float FoodValueThresholdBest;
        [NMS(Index = 7)]
        /* 0x1210 */ public float FoodValueThresholdGood;
        [NMS(Index = 10)]
        /* 0x1214 */ public float FoodValueThresholdWorst;
        [NMS(Index = 857)]
        /* 0x1218 */ public float FootDustScale;
        [NMS(Index = 863)]
        /* 0x121C */ public float FootOffset;
        [NMS(Index = 380)]
        /* 0x1220 */ public float FreeJetpackRange;
        [NMS(Index = 382)]
        /* 0x1224 */ public float FreeJetpackRangeNonTerrain;
        [NMS(Index = 381)]
        /* 0x1228 */ public float FreeJetpackRangePrime;
        [NMS(Index = 852)]
        /* 0x122C */ public float FreeJetpackSlopeAngle;
        [NMS(Index = 853)]
        /* 0x1230 */ public float FreeJetpackSlopeAnglePrime;
        [NMS(Index = 420)]
        /* 0x1234 */ public float FreighterAbandonedHazardTimeMultiplier;
        [NMS(Index = 446)]
        /* 0x1238 */ public float FreighterCoolFactor;
        [NMS(Index = 443)]
        /* 0x123C */ public float FreighterPriceExp2;
        [NMS(Index = 431)]
        /* 0x1240 */ public float FreighterProbeScanTime;
        [NMS(Index = 246)]
        /* 0x1244 */ public float FreighterSpawnedOnYouFadeInTime;
        [NMS(Index = 543)]
        /* 0x1248 */ public float FrigateFlybyMarkerAlwaysHideDistance;
        [NMS(Index = 542)]
        /* 0x124C */ public float FrigateFlybyMarkerAlwaysShowDistance;
        [NMS(Index = 302)]
        /* 0x1250 */ public float FrontShieldOffsetOff;
        [NMS(Index = 308)]
        /* 0x1254 */ public float FrontShieldOffsetOffVR;
        [NMS(Index = 303)]
        /* 0x1258 */ public float FrontShieldOffsetOn;
        [NMS(Index = 309)]
        /* 0x125C */ public float FrontShieldOffsetOnVR;
        [NMS(Index = 306)]
        /* 0x1260 */ public float FrontShieldScaleVR;
        [NMS(Index = 305)]
        /* 0x1264 */ public float FrontShieldSlerpTime;
        [NMS(Index = 310)]
        /* 0x1268 */ public float FrontShieldSlerpTimeVR;
        [NMS(Index = 304)]
        /* 0x126C */ public float FrontShieldSpeedSlowdown;
        [NMS(Index = 307)]
        /* 0x1270 */ public float FrontShieldUpOffsetVR;
        [NMS(Index = 854)]
        /* 0x1274 */ public float FullClipReloadSpeedMultiplier;
        [NMS(Index = 283)]
        /* 0x1278 */ public float GhostbusterAmp1;
        [NMS(Index = 287)]
        /* 0x127C */ public float GhostbusterAmp2;
        [NMS(Index = 291)]
        /* 0x1280 */ public float GhostbusterAmp3;
        [NMS(Index = 282)]
        /* 0x1284 */ public float GhostbusterFreq1;
        [NMS(Index = 286)]
        /* 0x1288 */ public float GhostbusterFreq2;
        [NMS(Index = 290)]
        /* 0x128C */ public float GhostbusterFreq3;
        [NMS(Index = 281)]
        /* 0x1290 */ public float GhostbusterSpeed1;
        [NMS(Index = 285)]
        /* 0x1294 */ public float GhostbusterSpeed2;
        [NMS(Index = 289)]
        /* 0x1298 */ public float GhostbusterSpeed3;
        [NMS(Index = 280)]
        /* 0x129C */ public float GhostbusterStart1;
        [NMS(Index = 284)]
        /* 0x12A0 */ public float GhostbusterStart2;
        [NMS(Index = 288)]
        /* 0x12A4 */ public float GhostbusterStart3;
        [NMS(Index = 279)]
        /* 0x12A8 */ public float GhostbusterStartLength;
        [NMS(Index = 909)]
        /* 0x12AC */ public float GrassPushDistance;
        [NMS(Index = 910)]
        /* 0x12B0 */ public float GrassPushDistanceFeet;
        [NMS(Index = 924)]
        /* 0x12B4 */ public float GravityLaserRange;
        [NMS(Index = 563)]
        /* 0x12B8 */ public int GrenadeBaseClipSize;
        [NMS(Index = 317)]
        /* 0x12BC */ public float GrenadeBounceDamping;
        [NMS(Index = 318)]
        /* 0x12C0 */ public float GrenadeBounceMaxSpeed;
        [NMS(Index = 803)]
        /* 0x12C4 */ public float GrenadeCarveRadius;
        [NMS(Index = 645)]
        /* 0x12C8 */ public float GrenadeRecoil;
        [NMS(Index = 319)]
        /* 0x12CC */ public float GrenadeStopExplodeTime;
        [NMS(Index = 768)]
        /* 0x12D0 */ public float GrenadeTerrainDeformRadius;
        [NMS(Index = 114)]
        /* 0x12D4 */ public float GroundRunSpeed;
        [NMS(Index = 116)]
        /* 0x12D8 */ public float GroundRunSpeedLowG;
        [NMS(Index = 109)]
        /* 0x12DC */ public float GroundWalkBrake;
        [NMS(Index = 110)]
        /* 0x12E0 */ public float GroundWalkBrakeWhileMoving;
        [NMS(Index = 108)]
        /* 0x12E4 */ public float GroundWalkForceMultiplier;
        [NMS(Index = 118)]
        /* 0x12E8 */ public float GroundWalkRecoverySpeedDamper;
        [NMS(Index = 112)]
        /* 0x12EC */ public float GroundWalkSpeed;
        [NMS(Index = 115)]
        /* 0x12F0 */ public float GroundWalkSpeedLowG;
        [NMS(Index = 111)]
        /* 0x12F4 */ public float GroundWalkSpeedSlow;
        [NMS(Index = 113)]
        /* 0x12F8 */ public float GroundWalkSpeedTeleportHmd;
        [NMS(Index = 562)]
        /* 0x12FC */ public int GunBaseClipSize;
        [NMS(Index = 642)]
        /* 0x1300 */ public float GunRecoil;
        [NMS(Index = 654)]
        /* 0x1304 */ public float GunRecoilMax;
        [NMS(Index = 653)]
        /* 0x1308 */ public float GunRecoilMin;
        [NMS(Index = 651)]
        /* 0x130C */ public float GunRecoilSettleSpring;
        [NMS(Index = 646)]
        /* 0x1310 */ public float GunRecoilSpring;
        [NMS(Index = 761)]
        /* 0x1314 */ public float GunRightOffset;
        [NMS(Index = 762)]
        /* 0x1318 */ public float GunUpOffset;
        [NMS(Index = 161)]
        /* 0x131C */ public float HandHoldInteractAngleRate;
        [NMS(Index = 160)]
        /* 0x1320 */ public float HandHoldInteractDistanceRate;
        [NMS(Index = 70)]
        /* 0x1324 */ public float HandInteractionFresnel;
        [NMS(Index = 71)]
        /* 0x1328 */ public float HandInteractionFresnelMax;
        [NMS(Index = 68)]
        /* 0x132C */ public float HandInteractionLightIntensity;
        [NMS(Index = 69)]
        /* 0x1330 */ public float HandInteractionLightIntensityMax;
        [NMS(Index = 72)]
        /* 0x1334 */ public float HandInteractionLightOffset;
        [NMS(Index = 73)]
        /* 0x1338 */ public float HandInteractionLightOffsetAt;
        [NMS(Index = 74)]
        /* 0x133C */ public float HandInteractionLightTime;
        [NMS(Index = 80)]
        /* 0x1340 */ public float HandScreenActivationAngle;
        [NMS(Index = 82)]
        /* 0x1344 */ public float HandScreenActivationAngleDown;
        [NMS(Index = 81)]
        /* 0x1348 */ public float HandScreenActivationAngleOffset;
        [NMS(Index = 79)]
        /* 0x134C */ public float HandScreenActivationRange;
        [NMS(Index = 78)]
        /* 0x1350 */ public float HandScreenAngleRange;
        [NMS(Index = 75)]
        /* 0x1354 */ public float HandScreenLookActiveAngle;
        [NMS(Index = 76)]
        /* 0x1358 */ public float HandScreenMinAngle;
        [NMS(Index = 77)]
        /* 0x135C */ public float HandScreenMinAngleWithPoint;
        [NMS(Index = 83)]
        /* 0x1360 */ public float HandScreenPenetration;
        [NMS(Index = 84)]
        /* 0x1364 */ public float HandScreenRestingTurnAngle;
        [NMS(Index = 120)]
        /* 0x1368 */ public float HandSmoothAngleRange;
        [NMS(Index = 119)]
        /* 0x136C */ public float HandSmoothMinAngle;
        [NMS(Index = 164)]
        /* 0x1370 */ public float HandSwimDecayTime;
        [NMS(Index = 165)]
        /* 0x1374 */ public float HandSwimForce;
        [NMS(Index = 163)]
        /* 0x1378 */ public float HandSwimMax;
        [NMS(Index = 166)]
        /* 0x137C */ public float HandSwimMaxForce;
        [NMS(Index = 162)]
        /* 0x1380 */ public float HandSwimMin;
        [NMS(Index = 813)]
        /* 0x1384 */ public float HardLandMax;
        [NMS(Index = 812)]
        /* 0x1388 */ public float HardLandMin;
        [NMS(Index = 561)]
        /* 0x138C */ public float HardLandPainTime;
        [NMS(Index = 811)]
        /* 0x1390 */ public float HardLandTime;
        [NMS(Index = 427)]
        /* 0x1394 */ public float HardModeHazardDamageRateMultiplier;
        [NMS(Index = 428)]
        /* 0x1398 */ public float HardModeHazardDamageWoundRateMultiplier;
        [NMS(Index = 429)]
        /* 0x139C */ public float HardModeHazardRechargeUnderground;
        [NMS(Index = 426)]
        /* 0x13A0 */ public float HardModeHazardTimeMultiplier;
        [NMS(Index = 328)]
        /* 0x13A4 */ public float HazardDamageMinTime;
        [NMS(Index = 179)]
        /* 0x13A8 */ public float HeadBinocularsOffset;
        [NMS(Index = 180)]
        /* 0x13AC */ public float HeadBinocularsRadius;
        [NMS(Index = 270)]
        /* 0x13B0 */ public float HealthPipRechargeRate;
        [NMS(Index = 269)]
        /* 0x13B4 */ public float HealthRechargeMinTimeSinceDamage;
        [NMS(Index = 639)]
        /* 0x13B8 */ public float HeatShieldTime;
        [NMS(Index = 874)]
        /* 0x13BC */ public float HelmetBob;
        [NMS(Index = 872)]
        /* 0x13C0 */ public float HelmetLag;
        [NMS(Index = 873)]
        /* 0x13C4 */ public float HelmetMaxLag;
        [NMS(Index = 917)]
        /* 0x13C8 */ public int HighGuildRank;
        [NMS(Index = 188)]
        /* 0x13CC */ public float HitReactBlendOutSpeedMax;
        [NMS(Index = 187)]
        /* 0x13D0 */ public float HitReactBlendOutSpeedMin;
        [NMS(Index = 186)]
        /* 0x13D4 */ public float HitReactNoiseAmount;
        [NMS(Index = 121)]
        /* 0x13D8 */ public float HmdResetButtonTime;
        [NMS(Index = 252)]
        /* 0x13DC */ public float HMDResetFlashTime;
        [NMS(Index = 169)]
        /* 0x13E0 */ public float HmdTurnAngle;
        [NMS(Index = 170)]
        /* 0x13E4 */ public float HmdTurnAnglePad;
        [NMS(Index = 103)]
        /* 0x13E8 */ public float HmdTurnSpeed;
        [NMS(Index = 104)]
        /* 0x13EC */ public float HmdTurnSpeedPad;
        [NMS(Index = 168)]
        /* 0x13F0 */ public float HmdTurnThreshold;
        [NMS(Index = 825)]
        /* 0x13F4 */ public float HoldActionDistX;
        [NMS(Index = 826)]
        /* 0x13F8 */ public float HoldActionDistY;
        [NMS(Index = 827)]
        /* 0x13FC */ public float HoldActionDistZ;
        [NMS(Index = 828)]
        /* 0x1400 */ public float HoldDistX;
        [NMS(Index = 829)]
        /* 0x1404 */ public float HoldDistY;
        [NMS(Index = 830)]
        /* 0x1408 */ public float HoldDistZ;
        [NMS(Index = 823)]
        /* 0x140C */ public float HoldForce;
        [NMS(Index = 831)]
        /* 0x1410 */ public float HoldMaxForce;
        [NMS(Index = 832)]
        /* 0x1414 */ public float HoldRotate;
        [NMS(Index = 824)]
        /* 0x1418 */ public float HoldTime;
        [NMS(Index = 178)]
        /* 0x141C */ public float HolsterGrabFrontOffset;
        [NMS(Index = 177)]
        /* 0x1420 */ public float HolsterGrabRadius;
        [NMS(Index = 819)]
        /* 0x1424 */ public int HUDHeightPosX;
        [NMS(Index = 820)]
        /* 0x1428 */ public int HUDHeightPosY;
        [NMS(Index = 26)]
        /* 0x142C */ public float InteractionAimOffset;
        [NMS(Index = 629)]
        /* 0x1430 */ public float InteractionButtonRange;
        [NMS(Index = 630)]
        /* 0x1434 */ public float InteractionButtonRangeVehicle;
        [NMS(Index = 631)]
        /* 0x1438 */ public float InteractionFocusIncrease;
        [NMS(Index = 632)]
        /* 0x143C */ public float InteractionFocusIncreaseCreature;
        [NMS(Index = 633)]
        /* 0x1440 */ public float InteractionFocusIncreasePet;
        [NMS(Index = 635)]
        /* 0x1444 */ public float InteractionFocusTime;
        [NMS(Index = 636)]
        /* 0x1448 */ public float InteractionFocusTimeCreature;
        [NMS(Index = 637)]
        /* 0x144C */ public float InteractionFocusTimePet;
        [NMS(Index = 634)]
        /* 0x1450 */ public float InteractionFocusTimeShootable;
        [NMS(Index = 152)]
        /* 0x1454 */ public float InteractionLineCircleOffsetMax;
        [NMS(Index = 151)]
        /* 0x1458 */ public float InteractionLineCircleOffsetMin;
        [NMS(Index = 148)]
        /* 0x145C */ public float InteractionLineCircleRadius;
        [NMS(Index = 150)]
        /* 0x1460 */ public float InteractionLineCircleSpeed;
        [NMS(Index = 149)]
        /* 0x1464 */ public float InteractionLineCircleThickness;
        [NMS(Index = 153)]
        /* 0x1468 */ public float InteractionLineNumCirclesPerMetre;
        [NMS(Index = 146)]
        /* 0x146C */ public float InteractionLineSplineMinDistance;
        [NMS(Index = 144)]
        /* 0x1470 */ public float InteractionLineSplineOffset;
        [NMS(Index = 145)]
        /* 0x1474 */ public float InteractionLineSplineOffsetMin;
        [NMS(Index = 147)]
        /* 0x1478 */ public float InteractionLineSplineOffsetRange;
        [NMS(Index = 628)]
        /* 0x147C */ public float InteractionScanRange;
        [NMS(Index = 638)]
        /* 0x1480 */ public float InteractionSubstanceRange;
        [NMS(Index = 95)]
        /* 0x1484 */ public float InteractNearbyRadius;
        [NMS(Index = 385)]
        /* 0x1488 */ public float JetpackBrake;
        [NMS(Index = 383)]
        /* 0x148C */ public float JetpackDrainHorizontalFactor;
        [NMS(Index = 393)]
        /* 0x1490 */ public float JetpackFillRate;
        [NMS(Index = 396)]
        /* 0x1494 */ public float JetpackFillRateFleetMultiplier;
        [NMS(Index = 394)]
        /* 0x1498 */ public float JetpackFillRateMidair;
        [NMS(Index = 397)]
        /* 0x149C */ public float JetpackFillRateNexusMultiplier;
        [NMS(Index = 395)]
        /* 0x14A0 */ public float JetpackFillRateSpaceStationMultiplier;
        [NMS(Index = 384)]
        /* 0x14A4 */ public float JetpackForce;
        [NMS(Index = 401)]
        /* 0x14A8 */ public float JetpackForceDeadPlanetExtra;
        [NMS(Index = 875)]
        /* 0x14AC */ public float JetpackHelmetBob;
        [NMS(Index = 390)]
        /* 0x14B0 */ public float JetpackIgnitionForce;
        [NMS(Index = 402)]
        /* 0x14B4 */ public float JetpackIgnitionForceDeadPlanetExtra;
        [NMS(Index = 391)]
        /* 0x14B8 */ public float JetpackIgnitionTime;
        [NMS(Index = 379)]
        /* 0x14BC */ public float JetpackJetAnimateInTime;
        [NMS(Index = 378)]
        /* 0x14C0 */ public float JetpackJetAnimateOutTime;
        [NMS(Index = 387)]
        /* 0x14C4 */ public float JetpackMaxSpeed;
        [NMS(Index = 388)]
        /* 0x14C8 */ public float JetpackMaxUpSpeed;
        [NMS(Index = 392)]
        /* 0x14CC */ public float JetpackMinIgnitionTime;
        [NMS(Index = 386)]
        /* 0x14D0 */ public float JetpackMinLevel;
        [NMS(Index = 398)]
        /* 0x14D4 */ public float JetpackUnderwaterDrainRate;
        [NMS(Index = 399)]
        /* 0x14D8 */ public float JetpackUnderwaterFillRate;
        [NMS(Index = 389)]
        /* 0x14DC */ public float JetpackUpForce;
        [NMS(Index = 400)]
        /* 0x14E0 */ public float JetpackUpForceDeadPlanetExtra;
        [NMS(Index = 403)]
        /* 0x14E4 */ public float JoystickOrientationTrimAltOc;
        [NMS(Index = 404)]
        /* 0x14E8 */ public float JoystickOrientationTrimAltOp;
        [NMS(Index = 741)]
        /* 0x14EC */ public float LabelOffset;
        [NMS(Index = 740)]
        /* 0x14F0 */ public float LabelSpringTime;
        [NMS(Index = 771)]
        /* 0x14F4 */ public float LaserBeamAmmoUseTime;
        [NMS(Index = 764)]
        /* 0x14F8 */ public float LaserBeamCore;
        [NMS(Index = 765)]
        /* 0x14FC */ public float LaserBeamFlickerAmp;
        [NMS(Index = 766)]
        /* 0x1500 */ public float LaserBeamFlickerFreq;
        [NMS(Index = 763)]
        /* 0x1504 */ public float LaserBeamMineRate;
        [NMS(Index = 769)]
        /* 0x1508 */ public float LaserBeamTerrainDeformRadius;
        [NMS(Index = 770)]
        /* 0x150C */ public float LaserBeamTerrainDeformVariance;
        [NMS(Index = 767)]
        /* 0x1510 */ public float LaserEndOffset;
        [NMS(Index = 551)]
        /* 0x1514 */ public float LaserMiningDamageMultiplier;
        [NMS(Index = 487)]
        /* 0x1518 */ public float LaserPlayerOffset;
        [NMS(Index = 643)]
        /* 0x151C */ public float LaserRecoil;
        [NMS(Index = 641)]
        /* 0x1520 */ public float LaserShakeMax;
        [NMS(Index = 640)]
        /* 0x1524 */ public float LaserShakeMin;
        [NMS(Index = 922)]
        /* 0x1528 */ public float LaserShipRange;
        [NMS(Index = 921)]
        /* 0x152C */ public float LaserWeaponRange;
        [NMS(Index = 870)]
        /* 0x1530 */ public float LeanAmount;
        [NMS(Index = 871)]
        /* 0x1534 */ public float LeanAmountFwd;
        [NMS(Index = 867)]
        /* 0x1538 */ public float LeanBackMaxAngle;
        [NMS(Index = 866)]
        /* 0x153C */ public float LeanFwdMaxAngle;
        [NMS(Index = 868)]
        /* 0x1540 */ public float LeanLeftMaxAngle;
        [NMS(Index = 869)]
        /* 0x1544 */ public float LeanRightMaxAngle;
        [NMS(Index = 807)]
        /* 0x1548 */ public float LookRayRadius;
        [NMS(Index = 481)]
        /* 0x154C */ public float LootForceMultiplier;
        [NMS(Index = 915)]
        /* 0x1550 */ public int LowGuildRank;
        [NMS(Index = 897)]
        /* 0x1554 */ public int LowHealthEffectPips;
        [NMS(Index = 898)]
        /* 0x1558 */ public int LowHealthEffectShield;
        [NMS(Index = 21)]
        /* 0x155C */ public float MaxArmExtension;
        [NMS(Index = 791)]
        /* 0x1560 */ public int MaxBuildHeight;
        [NMS(Index = 850)]
        /* 0x1564 */ public float MaxClingableSlopeAngle;
        [NMS(Index = 864)]
        /* 0x1568 */ public float MaxFallSpeed;
        [NMS(Index = 262)]
        /* 0x156C */ public int MaxHealthPips;
        [NMS(Index = 466)]
        /* 0x1570 */ public float MaximumCrouchVR;
        [NMS(Index = 467)]
        /* 0x1574 */ public float MaximumHeadHeightIncreaseVR;
        [NMS(Index = 468)]
        /* 0x1578 */ public float MaximumHorizontalOffsetVR;
        [NMS(Index = 432)]
        /* 0x157C */ public int MaxNumDestroyEffects;
        [NMS(Index = 497)]
        /* 0x1580 */ public int MaxNumShipsAttackingPlayer;
        [NMS(Index = 560)]
        /* 0x1584 */ public float MaxProjectileRadiusMultiplier;
        [NMS(Index = 877)]
        /* 0x1588 */ public float MaxResource;
        [NMS(Index = 842)]
        /* 0x158C */ public float MaxSlopeAngle;
        [NMS(Index = 849)]
        /* 0x1590 */ public float MaxSpidermanSlopeAngle;
        [NMS(Index = 344)]
        /* 0x1594 */ public float MaxTimeAfterMeleeBeforeBoost;
        [NMS(Index = 347)]
        /* 0x1598 */ public float MaxTimeInMeleeBoost;
        [NMS(Index = 846)]
        /* 0x159C */ public float MaxWalkableSlopeAngle;
        [NMS(Index = 155)]
        /* 0x15A0 */ public int MaxWordCategoriesToSayPerNPC;
        [NMS(Index = 916)]
        /* 0x15A4 */ public int MedGuildRank;
        [NMS(Index = 345)]
        /* 0x15A8 */ public float MeleeBoostAirForce;
        [NMS(Index = 564)]
        /* 0x15AC */ public float MeleeCooldown;
        [NMS(Index = 574)]
        /* 0x15B0 */ public float MeleeCooldownAlt;
        [NMS(Index = 576)]
        /* 0x15B4 */ public float MeleeDamageScale;
        [NMS(Index = 566)]
        /* 0x15B8 */ public float MeleeDistance;
        [NMS(Index = 567)]
        /* 0x15BC */ public float MeleeDistance3P;
        [NMS(Index = 578)]
        /* 0x15C0 */ public float MeleeDistanceAlt;
        [NMS(Index = 816)]
        /* 0x15C4 */ public float MeleeForcePush;
        [NMS(Index = 569)]
        /* 0x15C8 */ public float MeleeHitTime;
        [NMS(Index = 817)]
        /* 0x15CC */ public float MeleeOffset;
        [NMS(Index = 575)]
        /* 0x15D0 */ public float MeleePosDelta;
        [NMS(Index = 568)]
        /* 0x15D4 */ public float MeleeRadius;
        [NMS(Index = 577)]
        /* 0x15D8 */ public float MeleeRadiusAlt;
        [NMS(Index = 814)]
        /* 0x15DC */ public float MeleeRange;
        [NMS(Index = 570)]
        /* 0x15E0 */ public float MeleeSpeedBoost;
        [NMS(Index = 572)]
        /* 0x15E4 */ public float MeleeSpeedBoostRangeMultiplier;
        [NMS(Index = 571)]
        /* 0x15E8 */ public float MeleeSpeedDamageBoost;
        [NMS(Index = 573)]
        /* 0x15EC */ public float MeleeStaminaDrain;
        [NMS(Index = 815)]
        /* 0x15F0 */ public float MeleeTime;
        [NMS(Index = 346)]
        /* 0x15F4 */ public float MeleeToAirBoostInitialImpulse;
        [NMS(Index = 22)]
        /* 0x15F8 */ public float MinArmExtension;
        [NMS(Index = 241)]
        /* 0x15FC */ public float MinBinocActiveTime;
        [NMS(Index = 316)]
        /* 0x1600 */ public float MinDistanceToCommunicatorTarget;
        [NMS(Index = 271)]
        /* 0x1604 */ public float MinEnergyPercentOnRespawn;
        [NMS(Index = 851)]
        /* 0x1608 */ public float MinimumPushOffForceToSlide;
        [NMS(Index = 13)]
        /* 0x160C */ public float MiniportalAppearEffectTime;
        [NMS(Index = 14)]
        /* 0x1610 */ public float MiniportalDisappearEffectTime;
        [NMS(Index = 433)]
        /* 0x1614 */ public int MinNumDestroyEffects;
        [NMS(Index = 2)]
        /* 0x1618 */ public float MinRespawnCharge;
        [NMS(Index = 845)]
        /* 0x161C */ public float MinSlideTime;
        [NMS(Index = 847)]
        /* 0x1620 */ public float MinSpidermanSlopeAngle;
        [NMS(Index = 343)]
        /* 0x1624 */ public float MinTimeAfterMeleeBeforeBoost;
        [NMS(Index = 848)]
        /* 0x1628 */ public float MinTimeToHoldSpidermanPose;
        [NMS(Index = 862)]
        /* 0x162C */ public float MinUpAmount;
        [NMS(Index = 454)]
        /* 0x1630 */ public float MouseAimZone;
        [NMS(Index = 456)]
        /* 0x1634 */ public float MouseCrosshairAlphaFade;
        [NMS(Index = 457)]
        /* 0x1638 */ public float MouseCrosshairAlphaFadeSpeed;
        [NMS(Index = 458)]
        /* 0x163C */ public float MouseCrosshairLineAlpha;
        [NMS(Index = 459)]
        /* 0x1640 */ public float MouseCrosshairLineWidth;
        [NMS(Index = 455)]
        /* 0x1644 */ public float MouseCrosshairMaxAlpha;
        [NMS(Index = 461)]
        /* 0x1648 */ public float MouseCrosshairMultiplier;
        [NMS(Index = 460)]
        /* 0x164C */ public float MouseCrosshairShipStrength;
        [NMS(Index = 462)]
        /* 0x1650 */ public float MouseCrosshairShipStrengthOld;
        [NMS(Index = 451)]
        /* 0x1654 */ public float MouseDeadZone;
        [NMS(Index = 449)]
        /* 0x1658 */ public float MouseDeadZoneOld;
        [NMS(Index = 453)]
        /* 0x165C */ public float MouseDeadZoneVehicle;
        [NMS(Index = 464)]
        /* 0x1660 */ public float MouseFlightCorrectionBrakeMultiplier;
        [NMS(Index = 463)]
        /* 0x1664 */ public float MouseFlightCorrectionMultiplier;
        [NMS(Index = 450)]
        /* 0x1668 */ public float MouseMaxLength;
        [NMS(Index = 448)]
        /* 0x166C */ public float MouseMaxLengthOld;
        [NMS(Index = 452)]
        /* 0x1670 */ public float MouseMaxLengthVehicle;
        // size: 0x2
        public enum MouseSmoothModeEnum : uint {
            Off,
            Sprung,
        }
        [NMS(Index = 324)]
        /* 0x1674 */ public MouseSmoothModeEnum MouseSmoothMode;
        [NMS(Index = 554)]
        /* 0x1678 */ public float MoveStickHighRangeLimit;
        [NMS(Index = 555)]
        /* 0x167C */ public float MoveStickRunLimit;
        [NMS(Index = 268)]
        /* 0x1680 */ public float MultiplayerMinWanteEscalationTime;
        [NMS(Index = 659)]
        /* 0x1684 */ public float MuzzleFlashMulThirdPerson;
        [NMS(Index = 423)]
        /* 0x1688 */ public float NormalModeHazardDamageRateMultiplier;
        [NMS(Index = 424)]
        /* 0x168C */ public float NormalModeHazardDamageWoundRateMultiplier;
        [NMS(Index = 425)]
        /* 0x1690 */ public float NormalModeHazardRechargeUnderground;
        [NMS(Index = 422)]
        /* 0x1694 */ public float NormalModeHazardTimeMultiplier;
        [NMS(Index = 126)]
        /* 0x1698 */ public float NoStickTeleportDirectionChangeDeadzoneAngle;
        [NMS(Index = 253)]
        /* 0x169C */ public int NumberOfWarpsRequiredForFreightersToSpawn;
        [NMS(Index = 908)]
        /* 0x16A0 */ public int NumTechShopSlots;
        [NMS(Index = 498)]
        /* 0x16A4 */ public float ObjectScanTime;
        [NMS(Index = 273)]
        /* 0x16A8 */ public float OtherPlayerTrackArrowRange;
        [NMS(Index = 746)]
        /* 0x16AC */ public float PainColourSeperateAmount;
        [NMS(Index = 745)]
        /* 0x16B0 */ public float PainFlickerAmount;
        [NMS(Index = 747)]
        /* 0x16B4 */ public float PainTime;
        [NMS(Index = 296)]
        /* 0x16B8 */ public float PassiveWeaponZoomFOV;
        [NMS(Index = 297)]
        /* 0x16BC */ public float PassiveWeaponZoomFOVThirdPerson;
        [NMS(Index = 808)]
        /* 0x16C0 */ public float PickRange;
        [NMS(Index = 518)]
        /* 0x16C4 */ public float PirateBattleMarkerRange;
        [NMS(Index = 520)]
        /* 0x16C8 */ public float PirateBattleMarkerTime;
        [NMS(Index = 521)]
        /* 0x16CC */ public float PirateBattleMaxTime;
        [NMS(Index = 519)]
        /* 0x16D0 */ public float PirateBattleWarnTime;
        [NMS(Index = 501)]
        /* 0x16D4 */ public float PirateBountyInitTime;
        [NMS(Index = 502)]
        /* 0x16D8 */ public float PirateBountyMaxDistance;
        [NMS(Index = 503)]
        /* 0x16DC */ public float PirateBountyTimeoutTime;
        [NMS(Index = 510)]
        /* 0x16E0 */ public float PirateFlybyAttackDistancePastPlayer;
        [NMS(Index = 514)]
        /* 0x16E4 */ public float PirateFlybyAttackMaxTime;
        [NMS(Index = 513)]
        /* 0x16E8 */ public float PirateFlybyAttackMinTime;
        [NMS(Index = 511)]
        /* 0x16EC */ public float PirateFlybyAttackProbability;
        [NMS(Index = 512)]
        /* 0x16F0 */ public float PirateFlybyAttackProbabilityForced;
        [NMS(Index = 515)]
        /* 0x16F4 */ public float PirateFlybyAttackTimeForced;
        [NMS(Index = 500)]
        /* 0x16F8 */ public int PirateHailPercent;
        [NMS(Index = 505)]
        /* 0x16FC */ public float PirateProbeAttackWaitTime;
        [NMS(Index = 506)]
        /* 0x1700 */ public float PirateProbeAttackWarnTime;
        [NMS(Index = 509)]
        /* 0x1704 */ public float PirateProbeHailPause;
        [NMS(Index = 504)]
        /* 0x1708 */ public float PirateProbeInitTime;
        [NMS(Index = 507)]
        /* 0x170C */ public float PirateProbeScanTime;
        [NMS(Index = 508)]
        /* 0x1710 */ public float PirateProbeScanTotalTime;
        [NMS(Index = 517)]
        /* 0x1714 */ public float PirateRaidMaxTime;
        [NMS(Index = 516)]
        /* 0x1718 */ public float PirateRaidMinTime;
        [NMS(Index = 277)]
        /* 0x171C */ public float PlayerSpaceTransferRange;
        [NMS(Index = 276)]
        /* 0x1720 */ public float PlayerTransferRange;
        [NMS(Index = 627)]
        /* 0x1724 */ public float PlayerViewTargetRange;
        [NMS(Index = 98)]
        /* 0x1728 */ public float PointDownToMoveAngle;
        [NMS(Index = 99)]
        /* 0x172C */ public float PointDownToMoveBackAngle;
        [NMS(Index = 656)]
        /* 0x1730 */ public float ProjectileDamageFalloff;
        [NMS(Index = 434)]
        /* 0x1734 */ public float ProjectileEndTime;
        [NMS(Index = 549)]
        /* 0x1738 */ public float PulseEncounterMarkerAlwaysHideDistance;
        [NMS(Index = 548)]
        /* 0x173C */ public float PulseEncounterMarkerAlwaysShowDistance;
        [NMS(Index = 547)]
        /* 0x1740 */ public float PulseEncounterMarkerShowAngle;
        [NMS(Index = 544)]
        /* 0x1744 */ public float PulseEncounterMinTimeInPulse;
        [NMS(Index = 545)]
        /* 0x1748 */ public float PulseEncounterProbeTime;
        [NMS(Index = 546)]
        /* 0x174C */ public float PulseEncounterProbeTimeRare;
        [NMS(Index = 649)]
        /* 0x1750 */ public float PulseRecoilSpring;
        [NMS(Index = 818)]
        /* 0x1754 */ public float PushForceAirFactor;
        [NMS(Index = 865)]
        /* 0x1758 */ public float PushForceDecay;
        [NMS(Index = 920)]
        /* 0x175C */ public float QuadAutoAimOffset;
        [NMS(Index = 648)]
        /* 0x1760 */ public float RailRecoilSpring;
        [NMS(Index = 772)]
        /* 0x1764 */ public float ReloadButtonHoldTimeToHolster;
        [NMS(Index = 855)]
        /* 0x1768 */ public float ReloadTapButtonSpeedIncrease;
        [NMS(Index = 486)]
        /* 0x176C */ public float ResourceBlobFinalScaleDistance;
        [NMS(Index = 231)]
        /* 0x1770 */ public float RespawnOnCorvettePadRadius;
        [NMS(Index = 230)]
        /* 0x1774 */ public float RespawnOnPadRadius;
        [NMS(Index = 243)]
        /* 0x1778 */ public int RobotMultiplierWithFriends;
        [NMS(Index = 350)]
        /* 0x177C */ public float RocketBootsActivationWindow;
        [NMS(Index = 353)]
        /* 0x1780 */ public float RocketBootsBoostForce;
        [NMS(Index = 366)]
        /* 0x1784 */ public float RocketBootsBoostOffTime;
        [NMS(Index = 365)]
        /* 0x1788 */ public float RocketBootsBoostOnTime;
        [NMS(Index = 363)]
        /* 0x178C */ public float RocketBootsBoostTankDrainSpeed;
        [NMS(Index = 351)]
        /* 0x1790 */ public float RocketBootsDoubleTapTime;
        [NMS(Index = 372)]
        /* 0x1794 */ public float RocketBootsDriftBraking;
        [NMS(Index = 373)]
        /* 0x1798 */ public float RocketBootsDriftDownwardForce;
        [NMS(Index = 370)]
        /* 0x179C */ public float RocketBootsDriftEndTime;
        [NMS(Index = 354)]
        /* 0x17A0 */ public float RocketBootsDriftForce;
        [NMS(Index = 364)]
        /* 0x17A4 */ public float RocketBootsDriftTankDrainSpeed;
        [NMS(Index = 356)]
        /* 0x17A8 */ public float RocketBootsForceDuration;
        [NMS(Index = 355)]
        /* 0x17AC */ public float RocketBootsForceStartTime;
        [NMS(Index = 361)]
        /* 0x17B0 */ public float RocketBootsHeightAdjustDownStrength;
        [NMS(Index = 359)]
        /* 0x17B4 */ public float RocketBootsHeightAdjustTime;
        [NMS(Index = 360)]
        /* 0x17B8 */ public float RocketBootsHeightAdjustUpStrength;
        [NMS(Index = 352)]
        /* 0x17BC */ public float RocketBootsImpulse;
        [NMS(Index = 362)]
        /* 0x17C0 */ public float RocketBootsJetpackMinLevel;
        [NMS(Index = 358)]
        /* 0x17C4 */ public float RocketBootsMaxDesiredHeight;
        [NMS(Index = 369)]
        /* 0x17C8 */ public float RocketBootsMaxSpeed;
        [NMS(Index = 357)]
        /* 0x17CC */ public float RocketBootsMinDesiredHeight;
        [NMS(Index = 371)]
        /* 0x17D0 */ public float RocketBootsWindUpBraking;
        [NMS(Index = 368)]
        /* 0x17D4 */ public float RocketBootsZigZagForceDuration;
        [NMS(Index = 367)]
        /* 0x17D8 */ public float RocketBootsZigZagStrength;
        [NMS(Index = 614)]
        /* 0x17DC */ public float ScanBeamMainWidth;
        [NMS(Index = 612)]
        /* 0x17E0 */ public float ScanBeamWidth;
        [NMS(Index = 610)]
        /* 0x17E4 */ public float ScanFadeInTime;
        [NMS(Index = 611)]
        /* 0x17E8 */ public float ScanFadeOutTime;
        [NMS(Index = 602)]
        /* 0x17EC */ public float ScanLabelTime;
        [NMS(Index = 607)]
        /* 0x17F0 */ public float ScanRotate;
        [NMS(Index = 613)]
        /* 0x17F4 */ public float ScanRotateBeamWdith;
        [NMS(Index = 608)]
        /* 0x17F8 */ public float ScanRotateDist;
        [NMS(Index = 609)]
        /* 0x17FC */ public float ScanRotateWobbleAmp;
        [NMS(Index = 604)]
        /* 0x1800 */ public float ScanWobbleAmp;
        [NMS(Index = 606)]
        /* 0x1804 */ public float ScanWobbleAmp2;
        [NMS(Index = 603)]
        /* 0x1808 */ public float ScanWobbleFreq;
        [NMS(Index = 605)]
        /* 0x180C */ public float ScanWobbleFreq2;
        [NMS(Index = 878)]
        /* 0x1810 */ public int ShieldMaximum;
        [NMS(Index = 552)]
        /* 0x1814 */ public float ShieldRechargeMinTimeSinceDamage;
        [NMS(Index = 553)]
        /* 0x1818 */ public float ShieldRechargeRate;
        [NMS(Index = 880)]
        /* 0x181C */ public float ShieldRestoreDelay;
        [NMS(Index = 879)]
        /* 0x1820 */ public float ShieldRestoreSpeed;
        [NMS(Index = 876)]
        /* 0x1824 */ public float ShipCameraLag;
        [NMS(Index = 444)]
        /* 0x1828 */ public float ShipCoolFactor;
        [NMS(Index = 441)]
        /* 0x182C */ public float ShipPriceExp2;
        [NMS(Index = 245)]
        /* 0x1830 */ public float ShipSummonLastSafeMargin;
        [NMS(Index = 801)]
        /* 0x1834 */ public float ShootOffset;
        [NMS(Index = 802)]
        /* 0x1838 */ public float ShootPrepTime;
        [NMS(Index = 800)]
        /* 0x183C */ public float ShootSizeBase;
        [NMS(Index = 798)]
        /* 0x1840 */ public float ShootSizeMaxXY;
        [NMS(Index = 796)]
        /* 0x1844 */ public float ShootSizeMaxZ;
        [NMS(Index = 797)]
        /* 0x1848 */ public float ShootSizeMinXY;
        [NMS(Index = 795)]
        /* 0x184C */ public float ShootSizeMinZ;
        [NMS(Index = 799)]
        /* 0x1850 */ public float ShootSizeTime;
        [NMS(Index = 657)]
        /* 0x1854 */ public float ShotgunDispersion;
        [NMS(Index = 598)]
        /* 0x1858 */ public float SleepFadeTime;
        [NMS(Index = 844)]
        /* 0x185C */ public float SlopeSlideBrake;
        [NMS(Index = 843)]
        /* 0x1860 */ public float SlopeSlidingSpeed;
        [NMS(Index = 336)]
        /* 0x1864 */ public float SolarRegenFactor;
        [NMS(Index = 409)]
        /* 0x1868 */ public float SpaceJetpackDrainRate;
        [NMS(Index = 405)]
        /* 0x186C */ public float SpaceJetpackForce;
        [NMS(Index = 407)]
        /* 0x1870 */ public float SpaceJetpackIgnitionForce;
        [NMS(Index = 408)]
        /* 0x1874 */ public float SpaceJetpackMaxSpeed;
        [NMS(Index = 406)]
        /* 0x1878 */ public float SpaceJetpackUpForce;
        [NMS(Index = 792)]
        /* 0x187C */ public float SpaceMaxGravityDist;
        [NMS(Index = 793)]
        /* 0x1880 */ public float SpaceMinGravityDist;
        [NMS(Index = 216)]
        /* 0x1884 */ public float SpacewalkBrake;
        [NMS(Index = 215)]
        /* 0x1888 */ public float SpacewalkForce;
        [NMS(Index = 220)]
        /* 0x188C */ public float SpacewalkHitSpinDuration;
        [NMS(Index = 221)]
        /* 0x1890 */ public float SpacewalkHitSpinMaxRevolutions;
        [NMS(Index = 218)]
        /* 0x1894 */ public float SpacewalkJetpackForce;
        [NMS(Index = 219)]
        /* 0x1898 */ public float SpacewalkJetpackUpForce;
        [NMS(Index = 217)]
        /* 0x189C */ public float SpacewalkMaxSpeed;
        [NMS(Index = 223)]
        /* 0x18A0 */ public float SpacewalkRollSpeed;
        [NMS(Index = 224)]
        /* 0x18A4 */ public float SpacewalkRollSpringTime;
        [NMS(Index = 222)]
        /* 0x18A8 */ public float SpacewalkSurfaceHeight;
        [NMS(Index = 254)]
        /* 0x18AC */ public float SpawningDistanceBetweenPlayersAfterWarp;
        [NMS(Index = 255)]
        /* 0x18B0 */ public float SpawningSpaceBattleLookOffset;
        [NMS(Index = 256)]
        /* 0x18B4 */ public float SpawningSpaceBattleLookOffsetUp;
        [NMS(Index = 587)]
        /* 0x18B8 */ public float SpeedLinesLength;
        [NMS(Index = 596)]
        /* 0x18BC */ public float SpeedLinesMaxAlpha;
        [NMS(Index = 595)]
        /* 0x18C0 */ public float SpeedLinesMinAlpha;
        [NMS(Index = 597)]
        /* 0x18C4 */ public float SpeedLinesOffset;
        [NMS(Index = 593)]
        /* 0x18C8 */ public float SpeedLinesRadiusIncrement;
        [NMS(Index = 592)]
        /* 0x18CC */ public float SpeedLinesRadiusStartMax;
        [NMS(Index = 591)]
        /* 0x18D0 */ public float SpeedLinesRadiusStartMin;
        [NMS(Index = 586)]
        /* 0x18D4 */ public float SpeedLinesSpeedMax;
        [NMS(Index = 585)]
        /* 0x18D8 */ public float SpeedLinesSpeedMin;
        [NMS(Index = 594)]
        /* 0x18DC */ public float SpeedLinesStartFade;
        [NMS(Index = 588)]
        /* 0x18E0 */ public float SpeedLinesTotalLength;
        [NMS(Index = 590)]
        /* 0x18E4 */ public float SpeedLinesWidthMax;
        [NMS(Index = 589)]
        /* 0x18E8 */ public float SpeedLinesWidthMin;
        [NMS(Index = 599)]
        /* 0x18EC */ public float StaminaRate;
        [NMS(Index = 601)]
        /* 0x18F0 */ public float StaminaRecoveredFactor;
        [NMS(Index = 600)]
        /* 0x18F4 */ public float StaminaRecoveryRate;
        [NMS(Index = 583)]
        /* 0x18F8 */ public float StarFieldDensity;
        [NMS(Index = 582)]
        /* 0x18FC */ public float StarFieldRadius;
        [NMS(Index = 584)]
        /* 0x1900 */ public float StarFieldStarSize;
        [NMS(Index = 418)]
        /* 0x1904 */ public float StartHazardTimeMultiplier;
        [NMS(Index = 419)]
        /* 0x1908 */ public float StartSpookTimeMultiplier;
        [NMS(Index = 377)]
        /* 0x190C */ public int StealthBaseCharge;
        [NMS(Index = 375)]
        /* 0x1910 */ public float StealthDrainRate;
        [NMS(Index = 374)]
        /* 0x1914 */ public float StealthMinLevel;
        [NMS(Index = 376)]
        /* 0x1918 */ public float StealthRechargeRate;
        [NMS(Index = 736)]
        /* 0x191C */ public float StickDeadZoneMax;
        [NMS(Index = 735)]
        /* 0x1920 */ public float StickDeadZoneMin;
        [NMS(Index = 90)]
        /* 0x1924 */ public float StickYDampingThreshold;
        [NMS(Index = 496)]
        /* 0x1928 */ public int SuitInventoryStartSeed;
        [NMS(Index = 25)]
        /* 0x192C */ public float SummonArcRange;
        [NMS(Index = 122)]
        /* 0x1930 */ public float SummonShipDirectionChangeDeadZoneAngle;
        [NMS(Index = 214)]
        /* 0x1934 */ public float SurfaceSwimForce;
        [NMS(Index = 211)]
        /* 0x1938 */ public float SurfaceSwimMaxSpeed;
        [NMS(Index = 810)]
        /* 0x193C */ public float TakeDamageImpulse;
        [NMS(Index = 821)]
        /* 0x1940 */ public float TargetDistance;
        [NMS(Index = 822)]
        /* 0x1944 */ public float TargetRadius;
        [NMS(Index = 11)]
        /* 0x1948 */ public float TeleportAppearEffectSpeed;
        [NMS(Index = 132)]
        /* 0x194C */ public float TeleportArcLengthMultiplier;
        [NMS(Index = 123)]
        /* 0x1950 */ public float TeleportArcRadius;
        [NMS(Index = 124)]
        /* 0x1954 */ public float TeleportArcRadiusInner;
        [NMS(Index = 61)]
        /* 0x1958 */ public float TeleportBallCompletionFactorFadeout;
        [NMS(Index = 58)]
        /* 0x195C */ public float TeleportBallDistanceFadeAlpha;
        [NMS(Index = 56)]
        /* 0x1960 */ public float TeleportBallFadeMinDistance;
        [NMS(Index = 57)]
        /* 0x1964 */ public float TeleportBallFadeRange;
        [NMS(Index = 59)]
        /* 0x1968 */ public float TeleportBallRadius;
        [NMS(Index = 134)]
        /* 0x196C */ public float TeleportBeamAnimHeight;
        [NMS(Index = 133)]
        /* 0x1970 */ public float TeleportBeamAnimSpeed;
        [NMS(Index = 130)]
        /* 0x1974 */ public float TeleportBeamGravity;
        [NMS(Index = 131)]
        /* 0x1978 */ public float TeleportBeamGravityMax;
        [NMS(Index = 55)]
        /* 0x197C */ public float TeleportChargeFadeInTime;
        [NMS(Index = 52)]
        /* 0x1980 */ public float TeleportChargeMaxDistance;
        [NMS(Index = 51)]
        /* 0x1984 */ public float TeleportChargeMinDistance;
        [NMS(Index = 54)]
        /* 0x1988 */ public float TeleportChargeMinTime;
        [NMS(Index = 53)]
        /* 0x198C */ public float TeleportChargeMoveSpeed;
        [NMS(Index = 172)]
        /* 0x1990 */ public float TeleportDirectionAltHandRange;
        [NMS(Index = 12)]
        /* 0x1994 */ public float TeleportDisappearEffectSpeed;
        [NMS(Index = 128)]
        /* 0x1998 */ public float TeleportHmdMaxFade;
        [NMS(Index = 127)]
        /* 0x199C */ public float TeleportHmdMinFade;
        [NMS(Index = 129)]
        /* 0x19A0 */ public float TeleportHmdOutFactor;
        [NMS(Index = 140)]
        /* 0x19A4 */ public float TeleportInitiateThreshold;
        [NMS(Index = 171)]
        /* 0x19A8 */ public float TeleportInstantTravelDistance;
        [NMS(Index = 135)]
        /* 0x19AC */ public float TeleportLastKnownThreshold;
        [NMS(Index = 143)]
        /* 0x19B0 */ public float TeleportLineBezierDistanceFactor;
        [NMS(Index = 142)]
        /* 0x19B4 */ public float TeleportLineBezierOffset;
        [NMS(Index = 137)]
        /* 0x19B8 */ public float TeleportLineEndFadeEnd;
        [NMS(Index = 136)]
        /* 0x19BC */ public float TeleportLineEndFadeStart;
        [NMS(Index = 139)]
        /* 0x19C0 */ public float TeleportLineFadeRange;
        [NMS(Index = 138)]
        /* 0x19C4 */ public float TeleportLineFadeStart;
        [NMS(Index = 49)]
        /* 0x19C8 */ public float TeleportMaxTravelDistance;
        [NMS(Index = 50)]
        /* 0x19CC */ public float TeleportMaxTravelDistanceVertical;
        [NMS(Index = 173)]
        /* 0x19D0 */ public float TeleportMotionOffsetAmount;
        [NMS(Index = 174)]
        /* 0x19D4 */ public float TeleportMotionOffsetUp;
        [NMS(Index = 125)]
        /* 0x19D8 */ public float TeleportStrafeDistance;
        [NMS(Index = 175)]
        /* 0x19DC */ public float TeleportTotalTime;
        [NMS(Index = 60)]
        /* 0x19E0 */ public float TeleportTravelSurfaceAngle;
        [NMS(Index = 580)]
        /* 0x19E4 */ public float TemperatureDisplaySampleTime;
        [NMS(Index = 923)]
        /* 0x19E8 */ public float TerrainLaserRange;
        [NMS(Index = 652)]
        /* 0x19EC */ public float ThirdPersonRecoilMultiplier;
        [NMS(Index = 23)]
        /* 0x19F0 */ public float ThirdPersonWeaponAttachRotationCorrectionAngle;
        [NMS(Index = 24)]
        /* 0x19F4 */ public float ThirdPersonWeaponXOffset;
        [NMS(Index = 881)]
        /* 0x19F8 */ public float TimeHoldDownAccelerateToLaunchFromOutpost;
        [NMS(Index = 265)]
        /* 0x19FC */ public float TrackArrowStaticTargetOffsetMultiplier;
        [NMS(Index = 527)]
        /* 0x1A00 */ public float TraderApproachDistance;
        [NMS(Index = 525)]
        /* 0x1A04 */ public float TraderApproachTime;
        [NMS(Index = 541)]
        /* 0x1A08 */ public int TraderCommunicationBanMaxTime;
        [NMS(Index = 540)]
        /* 0x1A0C */ public int TraderCommunicationBanMinTime;
        [NMS(Index = 526)]
        /* 0x1A10 */ public float TraderHailDistance;
        [NMS(Index = 524)]
        /* 0x1A14 */ public float TraderHailTime;
        [NMS(Index = 539)]
        /* 0x1A18 */ public float TraderHealthFightThreshold;
        [NMS(Index = 528)]
        /* 0x1A1C */ public float TraderSpamTimeWait;
        [NMS(Index = 529)]
        /* 0x1A20 */ public float TraderStayCloseLockOffset;
        [NMS(Index = 530)]
        /* 0x1A24 */ public float TraderStayCloseLockSin1Coeff;
        [NMS(Index = 531)]
        /* 0x1A28 */ public float TraderStayCloseLockSin1Offset;
        [NMS(Index = 532)]
        /* 0x1A2C */ public float TraderStayCloseLockSin2Coeff;
        [NMS(Index = 533)]
        /* 0x1A30 */ public float TraderStayCloseLockSin2Offset;
        [NMS(Index = 534)]
        /* 0x1A34 */ public float TraderStayCloseLockSinsAdd;
        [NMS(Index = 535)]
        /* 0x1A38 */ public float TraderStayCloseLockSpread;
        [NMS(Index = 536)]
        /* 0x1A3C */ public float TraderStayCloseLockSpreadAdd;
        [NMS(Index = 537)]
        /* 0x1A40 */ public float TraderStayCloseLockSpreadTime;
        [NMS(Index = 229)]
        /* 0x1A44 */ public float UnderwaterBrake;
        [NMS(Index = 204)]
        /* 0x1A48 */ public float UnderwaterCurrentStrengthHorizontalMax;
        [NMS(Index = 203)]
        /* 0x1A4C */ public float UnderwaterCurrentStrengthHorizontalMin;
        [NMS(Index = 205)]
        /* 0x1A50 */ public float UnderwaterCurrentStrengthVertical;
        [NMS(Index = 201)]
        /* 0x1A54 */ public float UnderwaterFloatRange;
        [NMS(Index = 193)]
        /* 0x1A58 */ public float UnderwaterFluidDensity;
        [NMS(Index = 213)]
        /* 0x1A5C */ public float UnderwaterForce;
        [NMS(Index = 210)]
        /* 0x1A60 */ public float UnderwaterImpact;
        [NMS(Index = 228)]
        /* 0x1A64 */ public float UnderwaterJetpackEscapeForce;
        [NMS(Index = 226)]
        /* 0x1A68 */ public float UnderwaterJetpackForce;
        [NMS(Index = 190)]
        /* 0x1A6C */ public float UnderwaterMargin;
        [NMS(Index = 227)]
        /* 0x1A70 */ public float UnderwaterMaxJetpackEscapeSpeed;
        [NMS(Index = 225)]
        /* 0x1A74 */ public float UnderwaterMaxJetpackSpeed;
        [NMS(Index = 207)]
        /* 0x1A78 */ public float UnderwaterMaxSpeedTotal;
        [NMS(Index = 206)]
        /* 0x1A7C */ public float UnderwaterMaxSpeedTotalJetpacking;
        [NMS(Index = 191)]
        /* 0x1A80 */ public float UnderwaterMinDepth;
        [NMS(Index = 192)]
        /* 0x1A84 */ public float UnderwaterPlayerMass;
        [NMS(Index = 197)]
        /* 0x1A88 */ public float UnderwaterPlayerSphereDepthOffsetFirstPerson;
        [NMS(Index = 200)]
        /* 0x1A8C */ public float UnderwaterPlayerSphereDepthOffsetMax;
        [NMS(Index = 199)]
        /* 0x1A90 */ public float UnderwaterPlayerSphereDepthOffsetMin;
        [NMS(Index = 198)]
        /* 0x1A94 */ public float UnderwaterPlayerSphereDepthOffsetPitchedExtra;
        [NMS(Index = 196)]
        /* 0x1A98 */ public float UnderwaterPlayerSphereOffsetMaxPitch;
        [NMS(Index = 195)]
        /* 0x1A9C */ public float UnderwaterPlayerSphereOffsetMinPitch;
        [NMS(Index = 194)]
        /* 0x1AA0 */ public float UnderwaterPlayerSphereRadius;
        [NMS(Index = 208)]
        /* 0x1AA4 */ public float UnderwaterSurfaceForceFlattenAngleMin;
        [NMS(Index = 209)]
        /* 0x1AA8 */ public float UnderwaterSurfaceForceFlattenAngleRange;
        [NMS(Index = 212)]
        /* 0x1AAC */ public float UnderwaterSwimMaxSpeed;
        [NMS(Index = 919)]
        /* 0x1AB0 */ public float UtilityWeaponRange;
        [NMS(Index = 430)]
        /* 0x1AB4 */ public float VehicleHazardDampingModifier;
        [NMS(Index = 925)]
        /* 0x1AB8 */ public float VehicleLaserRange;
        [NMS(Index = 272)]
        /* 0x1ABC */ public float VehicleRaceResultsHintTime;
        [NMS(Index = 415)]
        /* 0x1AC0 */ public float VRModeHazardTimeMultiplier;
        [NMS(Index = 416)]
        /* 0x1AC4 */ public float VRStartHazardTimeMultiplier;
        [NMS(Index = 488)]
        /* 0x1AC8 */ public float WalkerAlertRange;
        [NMS(Index = 490)]
        /* 0x1ACC */ public float WalkerSightAngle;
        [NMS(Index = 489)]
        /* 0x1AD0 */ public float WalkerSightRange;
        [NMS(Index = 615)]
        /* 0x1AD4 */ public float WantedDroneEventRadius;
        [NMS(Index = 733)]
        /* 0x1AD8 */ public float WantedEnemyAttackAmount;
        [NMS(Index = 618)]
        /* 0x1ADC */ public float WantedLevelDelay;
        [NMS(Index = 274)]
        /* 0x1AE0 */ public float WantedLevelPlayerRange;
        [NMS(Index = 275)]
        /* 0x1AE4 */ public float WantedLevelPlayerRangeSpace;
        [NMS(Index = 621)]
        /* 0x1AE8 */ public float WantedMinorCrimeAmount;
        [NMS(Index = 617)]
        /* 0x1AEC */ public float WantedMinPlanetTime;
        [NMS(Index = 616)]
        /* 0x1AF0 */ public float WantedMinSpaceTime;
        [NMS(Index = 622)]
        /* 0x1AF4 */ public float WantedTimeoutAggressive;
        [NMS(Index = 620)]
        /* 0x1AF8 */ public float WantedWitnessFuzzyTime;
        [NMS(Index = 619)]
        /* 0x1AFC */ public float WantedWitnessTimer;
        [NMS(Index = 782)]
        /* 0x1B00 */ public float WeaponBobBlendTime;
        [NMS(Index = 781)]
        /* 0x1B04 */ public float WeaponBobFactorRun;
        [NMS(Index = 780)]
        /* 0x1B08 */ public float WeaponBobFactorWalk;
        [NMS(Index = 779)]
        /* 0x1B0C */ public float WeaponBobFactorWalkDeadZone;
        [NMS(Index = 785)]
        /* 0x1B10 */ public float WeaponCannonMinUnchargedShotThreshold;
        [NMS(Index = 786)]
        /* 0x1B14 */ public float WeaponCannonMinUnchargedShotTime;
        [NMS(Index = 784)]
        /* 0x1B18 */ public float WeaponCannonMinWeaponTimer;
        [NMS(Index = 773)]
        /* 0x1B1C */ public float WeaponChangeModeTime;
        [NMS(Index = 445)]
        /* 0x1B20 */ public float WeaponCoolFactor;
        [NMS(Index = 787)]
        /* 0x1B24 */ public float WeaponGrenadeTime;
        [NMS(Index = 788)]
        /* 0x1B28 */ public float WeaponGunTime;
        [NMS(Index = 777)]
        /* 0x1B2C */ public float WeaponHolsterDelay;
        [NMS(Index = 778)]
        /* 0x1B30 */ public float WeaponLag;
        [NMS(Index = 776)]
        /* 0x1B34 */ public float WeaponLowerDelay;
        [NMS(Index = 442)]
        /* 0x1B38 */ public float WeaponPriceExp2;
        [NMS(Index = 789)]
        /* 0x1B3C */ public float WeaponRailFireTime;
        [NMS(Index = 790)]
        /* 0x1B40 */ public float WeaponRailRechargeTime;
        [NMS(Index = 323)]
        /* 0x1B44 */ public float WeaponShotgunSlowdown;
        [NMS(Index = 295)]
        /* 0x1B48 */ public float WeaponZoomFOV;
        [NMS(Index = 300)]
        /* 0x1B4C */ public float WeaponZoomHorzRotation;
        [NMS(Index = 298)]
        /* 0x1B50 */ public float WeaponZoomRecoilMultiplier;
        [NMS(Index = 299)]
        /* 0x1B54 */ public float WeaponZoomVertRotation;
        [NMS(Index = 557)]
        /* 0x1B58 */ public float WitnessAIDamageAngle;
        [NMS(Index = 556)]
        /* 0x1B5C */ public float WitnessAIDamageDistance;
        [NMS(Index = 267)]
        /* 0x1B60 */ public float WitnessSenseEnhancement;
        [NMS(Index = 266)]
        /* 0x1B64 */ public float WitnessSenseEnhancementTime;
        [NMS(Index = 154)]
        /* 0x1B68 */ public int WordCategoriesRequiredToConverse;
        [NMS(Index = 485)]
        /* 0x1B6C */ public float WoundDamageDecayTime;
        [NMS(Index = 483)]
        /* 0x1B70 */ public float WoundDamageLimit;
        [NMS(Index = 484)]
        /* 0x1B74 */ public float WoundDamageLimitShip;
        [NMS(Index = 482)]
        /* 0x1B78 */ public float WoundTimeMinimum;
        [NMS(Index = 691)]
        /* 0x1B7C */ public TkCurveType AimDisperseCurve;
        [NMS(Index = 668)]
        /* 0x1B7D */ public bool AutoAim;
        [NMS(Index = 679)]
        /* 0x1B7E */ public TkCurveType AutoAimCentreOffsetCurve;
        [NMS(Index = 678)]
        /* 0x1B7F */ public TkCurveType AutoAimDotCurve;
        [NMS(Index = 655)]
        /* 0x1B80 */ public bool BoltcasterHasTracer;
        [NMS(Index = 411)]
        /* 0x1B81 */ public bool ClampPitch;
        [NMS(Index = 249)]
        /* 0x1B82 */ public bool CreatureRideFade;
        [NMS(Index = 89)]
        /* 0x1B83 */ public bool DoPlayerAppearInVehicleEffect;
        [NMS(Index = 410)]
        /* 0x1B84 */ public bool EnableHeadMovements;
        [NMS(Index = 100)]
        /* 0x1B85 */ public bool EnableLeaning;
        [NMS(Index = 101)]
        /* 0x1B86 */ public bool EnablePointDownToSmoothMove;
        [NMS(Index = 292)]
        /* 0x1B87 */ public bool FireButtonReloadsWeapon;
        [NMS(Index = 3)]
        /* 0x1B88 */ public bool ForceFreighterProcTechRandom;
        [NMS(Index = 117)]
        /* 0x1B89 */ public bool ForceWalkOnCorvette;
        [NMS(Index = 301)]
        /* 0x1B8A */ public bool FrontShieldEnabled;
        [NMS(Index = 167)]
        /* 0x1B8B */ public bool HandSwimEnabled;
        [NMS(Index = 472)]
        /* 0x1B8C */ public bool HideHazardPanel;
        [NMS(Index = 102)]
        /* 0x1B8D */ public bool HmdSmoothTurnAlways;
        [NMS(Index = 94)]
        /* 0x1B8E */ public bool InteractNearbyRadiusEnabled;
        [NMS(Index = 473)]
        /* 0x1B8F */ public bool InventoryDamage;
        [NMS(Index = 477)]
        /* 0x1B90 */ public bool LuckyWithTech;
        [NMS(Index = 447)]
        /* 0x1B91 */ public bool MouseCrosshairVisible;
        [NMS(Index = 465)]
        /* 0x1B92 */ public TkCurveType MouseFlightCurve;
        [NMS(Index = 257)]
        /* 0x1B93 */ public bool MultiplayerShareWanted;
        [NMS(Index = 474)]
        /* 0x1B94 */ public bool NeverPreyedOn;
        [NMS(Index = 96)]
        /* 0x1B95 */ public bool PassiveLook;
        [NMS(Index = 476)]
        /* 0x1B96 */ public bool PermanantAltFire;
        [NMS(Index = 475)]
        /* 0x1B97 */ public bool PermanantFire;
        [NMS(Index = 15)]
        /* 0x1B98 */ public bool RecenterViewWhenEnteringShip;
        [NMS(Index = 258)]
        /* 0x1B99 */ public bool ReportAllProjectileDamage;
        [NMS(Index = 91)]
        /* 0x1B9A */ public bool RequireHandsOnShipControls;
        [NMS(Index = 348)]
        /* 0x1B9B */ public bool RocketBootsEnabled;
        [NMS(Index = 349)]
        /* 0x1B9C */ public bool RocketBootsUseCustomCamera;
        [NMS(Index = 92)]
        /* 0x1B9D */ public bool ShowFirstPersonCharacterShadowPCVR;
        [NMS(Index = 93)]
        /* 0x1B9E */ public bool ShowFirstPersonCharacterShadowPSVR;
        [NMS(Index = 293)]
        /* 0x1B9F */ public bool ShowLowAmmoWarning;
        [NMS(Index = 737)]
        /* 0x1BA0 */ public TkCurveType StickCurve;
        [NMS(Index = 141)]
        /* 0x1BA1 */ public bool TeleportRecentre;
        [NMS(Index = 202)]
        /* 0x1BA2 */ public TkCurveType UnderwaterBuoyancyDepthCurve;
        [NMS(Index = 494)]
        /* 0x1BA3 */ public bool UpgradeExosuitWithProduct;
        [NMS(Index = 470)]
        /* 0x1BA4 */ public bool UseEnergy;
        [NMS(Index = 471)]
        /* 0x1BA5 */ public bool UseHazardProtection;
        [NMS(Index = 263)]
        /* 0x1BA6 */ public bool UseLargeHealthBar;
        [NMS(Index = 783)]
        /* 0x1BA7 */ public TkCurveType WeaponBobBlendCurve;
        [NMS(Index = 294)]
        /* 0x1BA8 */ public bool WeaponZoomEnabled;
    }
}
