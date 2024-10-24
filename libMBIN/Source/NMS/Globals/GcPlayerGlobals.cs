using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xC48C298CDCBD4AD6, NameHash = 0xFC6CA276)]
    public class GcPlayerGlobals : NMSTemplate
    {
        [NMS(Index = 28)]
        /* 0x0000 */ public GcProjectorOffsetData LargeWeaponMenuTransforms;
        [NMS(Index = 25)]
        /* 0x0070 */ public GcProjectorOffsetData QuickMenuLauncherTransforms;
        [NMS(Index = 26)]
        /* 0x00E0 */ public GcProjectorOffsetData QuickMenuLauncherTransformsNoBuildMenu;
        [NMS(Index = 27)]
        /* 0x0150 */ public GcProjectorOffsetData WeaponMenuTransforms;
        [NMS(Index = 181)]
        /* 0x01C0 */ public GcScanEffectData ArmourHighlightScanEffect;
        [NMS(Index = 155)]
        /* 0x0210 */ public GcScanEffectData HolsterHighlightEffect;
        [NMS(Index = 154)]
        /* 0x0260 */ public GcScanEffectData InteractHighlightEffect;
        [NMS(Index = 550)]
        /* 0x02B0 */ public GcScanEffectData MeleeHitEffect;
        [NMS(Index = 880)]
        /* 0x0300 */ public GcCameraAnomalySetupData AnomalyAtlasStationSpawnData;
        [NMS(Index = 879)]
        /* 0x0340 */ public GcCameraAnomalySetupData AnomalyBlachHoleSpawnData;
        [NMS(Index = 881)]
        /* 0x0380 */ public GcCameraAnomalySetupData AnomalyMiniStationSpawnData;
        [NMS(Index = 38)]
        /* 0x03C0 */ public GcInWorldUIScreenData BinocularInfoScreenOffset;
        [NMS(Index = 39)]
        /* 0x03F0 */ public GcInWorldUIScreenData BinocularInfoScreenOffsetGun;
        [NMS(Index = 36)]
        /* 0x0420 */ public GcInWorldUIScreenData DefaultLeftHandTransform;
        [NMS(Index = 37)]
        /* 0x0450 */ public GcInWorldUIScreenData DefaultLeftHandTransformVehicle;
        [NMS(Index = 41)]
        /* 0x0480 */ public GcInWorldUIScreenData FrontendBaseScreenshotVROffset;
        [NMS(Index = 35)]
        /* 0x04B0 */ public GcInWorldUIScreenData FrontendMessagesOffset;
        [NMS(Index = 31)]
        /* 0x04E0 */ public GcInWorldUIScreenData FrontendOffset;
        [NMS(Index = 34)]
        /* 0x0510 */ public GcInWorldUIScreenData FrontendOffsetV2;
        [NMS(Index = 40)]
        /* 0x0540 */ public GcInWorldUIScreenData FrontendPhotoModeVROffset;
        [NMS(Index = 30)]
        /* 0x0570 */ public GcInWorldUIScreenData InventoryOffset;
        [NMS(Index = 33)]
        /* 0x05A0 */ public GcInWorldUIScreenData InventoryOffsetV2;
        [NMS(Index = 84)]
        /* 0x05D0 */ public GcInWorldUIScreenData InWorldCompass;
        [NMS(Index = 29)]
        /* 0x0600 */ public GcInWorldUIScreenData QuickMenuOffset;
        [NMS(Index = 32)]
        /* 0x0630 */ public GcInWorldUIScreenData QuickMenuOffsetV2;
        [NMS(Index = 44)]
        /* 0x0660 */ public Vector3f BinocularScopeOffset;
        [NMS(Index = 309)]
        /* 0x0670 */ public Colour DefaultMuzzleColour;
        [NMS(Index = 314)]
        /* 0x0680 */ public Colour DefaultMuzzleLaserColour;
        [NMS(Index = 83)]
        /* 0x0690 */ public Vector3f HandScreenRoboOnScreenOffset;
        [NMS(Index = 105)]
        /* 0x06A0 */ public Vector3f HolsterHeadOffset;
        [NMS(Index = 152)]
        /* 0x06B0 */ public Colour InteractionLineActiveColour;
        [NMS(Index = 153)]
        /* 0x06C0 */ public Colour InteractionLineBaseColour;
        [NMS(Index = 1)]
        /* 0x06D0 */ public Vector3f LeftHandModeFishingRodAttachSocketCorrection;
        [NMS(Index = 0)]
        /* 0x06E0 */ public Vector3f LeftHandModeWeaponAttachSocketCorrection;
        [NMS(Index = 104)]
        /* 0x06F0 */ public Vector3f PointingWristAngles;
        [NMS(Index = 178)]
        /* 0x0700 */ public Colour SearchGroupIconColour;
        [NMS(Index = 552)]
        /* 0x0710 */ public Colour StarFieldColour;
        [NMS(Index = 311)]
        /* 0x0720 */ public Colour TerrainEditorMuzzleColourAdd;
        [NMS(Index = 312)]
        /* 0x0730 */ public Colour TerrainEditorMuzzleColourFlatten;
        [NMS(Index = 310)]
        /* 0x0740 */ public Colour TerrainEditorMuzzleColourSubtract;
        [NMS(Index = 313)]
        /* 0x0750 */ public Colour TerrainEditorMuzzleColourUndo;
        [NMS(Index = 507)]
        /* 0x0760 */ public Vector3f TraderStayCloseLockBaseOffset;
        [NMS(Index = 742)]
        /* 0x0770 */ public Vector3f WeaponBarrelOffset;
        [NMS(Index = 743)]
        /* 0x0780 */ public Vector3f WeaponOffset;
        [NMS(Index = 894)]
        /* 0x0790 */ public GcShipDialogue TraderHailMessages;
        [NMS(Index = 893)]
        /* 0x09F8 */ public GcPlayerCommunicatorMessage PirateHailMessage;
        [NMS(Index = 892)]
        /* 0x0A48 */ public GcPlayerCommunicatorMessage PoliceScanHailMessage;
        [NMS(Index = 491)]
        /* 0x0A98 */ public NMSString0x20A TraderHailReceiveOSDLoc;
        [NMS(Index = 492)]
        /* 0x0AB8 */ public NMSString0x20A TraderHailRefusedOSDLoc;
        [NMS(Index = 712)]
        /* 0x0AD8 */ public List<GcCreatureAlertData> AlertTable;
        [NMS(Index = 177)]
        /* 0x0AE8 */ public NMSString0x10 DebugSearchGroup;
        [NMS(Index = 179)]
        /* 0x0AF8 */ public VariableSizeString DefaultShipFilename;
        [NMS(Index = 180)]
        /* 0x0B08 */ public GcSeed DefaultShipSeed;
        [NMS(Index = 466)]
        /* 0x0B18 */ public NMSString0x10 ExosuitUpgradeProduct;
        [NMS(Index = 699)]
        /* 0x0B28 */ public NMSString0x10 ExperienceDefeatBugQueenRewardID;
        [NMS(Index = 695)]
        /* 0x0B38 */ public NMSString0x10 ExperienceDefeatLevel5SentinelsCorrupt;
        [NMS(Index = 694)]
        /* 0x0B48 */ public NMSString0x10 ExperienceDefeatLevel5SentinelsNearHiveReward;
        [NMS(Index = 693)]
        /* 0x0B58 */ public NMSString0x10 ExperienceDefeatLevel5SentinelsReward;
        [NMS(Index = 691)]
        /* 0x0B68 */ public NMSString0x10 ExperienceDefeatLevel5SpaceSentinelsReward;
        [NMS(Index = 870)]
        /* 0x0B78 */ public List<GcCameraSpawnSetupData> FirstSpawnDataTable;
        [NMS(Index = 824)]
        /* 0x0B88 */ public NMSString0x10 FootDustEffect;
        [NMS(Index = 702)]
        /* 0x0B98 */ public VariableSizeString Gun;
        [NMS(Index = 365)]
        /* 0x0BA8 */ public List<float> JetpackTankTimes;
        [NMS(Index = 172)]
        /* 0x0BB8 */ public VariableSizeString NoShadowMaterial;
        [NMS(Index = 521)]
        /* 0x0BC8 */ public NMSString0x10 PulseEncounterSpaceEggID;
        [NMS(Index = 875)]
        /* 0x0BD8 */ public List<float> TechLearningProbabilities;
        [NMS(Index = 874)]
        /* 0x0BE8 */ public List<float> TechRarityData;
        [NMS(Index = 595)]
        /* 0x0BF8 */ public List<float> WantedEscalateTime;
        [NMS(Index = 596)]
        /* 0x0C08 */ public List<float> WantedExtremeEscalateTime;
        [NMS(Index = 594)]
        /* 0x0C18 */ public List<float> WantedTimeout;
        [NMS(Index = 858)]
        /* 0x0C28 */ public ulong AutoSaveMaxTime;
        [NMS(Index = 859)]
        /* 0x0C30 */ public ulong AutoSaveMinTime;
        [NMS(Index = 103)]
        /* 0x0C38 */ public ulong PointingWristAdjustmentTimeMilliseconds;
        [NMS(Index = 633)]
        /* 0x0C40 */ public GcResourceCollectEffect CrystalResourceCollect;
        [NMS(Index = 635)]
        /* 0x0C74 */ public GcResourceCollectEffect FishingResourceCollect;
        [NMS(Index = 634)]
        /* 0x0CA8 */ public GcResourceCollectEffect ShardResourceCollect;
        [NMS(Index = 630)]
        /* 0x0CDC */ public GcResourceCollectEffect TerrainResourceCollect;
        [NMS(Index = 632)]
        /* 0x0D10 */ public GcResourceCollectEffect TerrainResourceMeleeCollect;
        [NMS(Index = 631)]
        /* 0x0D44 */ public GcResourceCollectEffect TerrainResourceMiniCollect;
        [NMS(Index = 636)]
        /* 0x0D78 */ public GcBoidData MissileSwarm;
        [NMS(Index = 716)]
        /* 0x0DA4 */ public GcProjectileLineData PlayerBullet;
        [NMS(Index = 717)]
        /* 0x0DCC */ public GcProjectileLineData RobotBullet;
        [NMS(Index = 718)]
        /* 0x0DF4 */ public GcProjectileLineData ShipBullet;
        [NMS(Index = 864)]
        /* 0x0E1C */ public GcPlayerStickData AmbientModeLookStickData;
        [NMS(Index = 873)]
        /* 0x0E38 */ public GcInventoryValueData FreighterValueData;
        [NMS(Index = 863)]
        /* 0x0E54 */ public GcPlayerStickData LookStickData;
        [NMS(Index = 871)]
        /* 0x0E70 */ public GcInventoryValueData ShipValueData;
        [NMS(Index = 637)]
        /* 0x0E8C */ public GcPlayerStickData StickData;
        [NMS(Index = 872)]
        /* 0x0EA8 */ public GcInventoryValueData WeaponValueData;
        [NMS(Index = 882)]
        /* 0x0EC4 */ public GcJourneyMedalTiers MedalTiers;
        [NMS(Index = 895, Size = 0x4)]
        /* 0x0ED4 */ public GcShipDialogueTreeEnum[] TraderHailReceiveRegular;
        [NMS(Index = 681)]
        /* 0x0EE4 */ public Vector2f ExperienceFlybyStartAngle;
        [NMS(Index = 65)]
        /* 0x0EEC */ public Vector2f FingerButtonQuickMenuButtonSize;
        [NMS(Index = 298)]
        /* 0x0EF4 */ public Vector2f MouseSpringStrength;
        [NMS(Index = 300)]
        /* 0x0EFC */ public Vector2f MouseSpringStrengthMaxDelta;
        [NMS(Index = 299)]
        /* 0x0F04 */ public Vector2f MouseSpringStrengthMinDelta;
        [NMS(Index = 896, Size = 0x2)]
        /* 0x0F0C */ public GcShipDialogueTreeEnum[] TraderHailReceiveFight;
        [NMS(Index = 897, Size = 0x2)]
        /* 0x0F14 */ public GcShipDialogueTreeEnum[] TraderHailSend;
        [NMS(Index = 392)]
        /* 0x0F1C */ public float AbandonedFreighterRechargeMod;
        [NMS(Index = 385)]
        /* 0x0F20 */ public float AbandonedFreighterStaminaRate;
        [NMS(Index = 384)]
        /* 0x0F24 */ public float AbandonedFreighterStaminaRecoveryMod;
        [NMS(Index = 654)]
        /* 0x0F28 */ public float AimDecay;
        [NMS(Index = 660)]
        /* 0x0F2C */ public float AimDisperseCooldownFactor;
        [NMS(Index = 659)]
        /* 0x0F30 */ public float AimDisperseCooldownTime;
        [NMS(Index = 658)]
        /* 0x0F34 */ public float AimDisperseMinTime;
        [NMS(Index = 657)]
        /* 0x0F38 */ public float AimDisperseTime;
        [NMS(Index = 650)]
        /* 0x0F3C */ public float AimDistanceShip;
        [NMS(Index = 653)]
        /* 0x0F40 */ public float AimMinWeight;
        [NMS(Index = 655)]
        /* 0x0F44 */ public float AimOffset;
        [NMS(Index = 656)]
        /* 0x0F48 */ public float AimShootableTargetAngle;
        [NMS(Index = 651)]
        /* 0x0F4C */ public float AimSpeed;
        [NMS(Index = 652)]
        /* 0x0F50 */ public float AimWeightAdd;
        [NMS(Index = 4)]
        /* 0x0F54 */ public float AlienPodAggroDecay;
        [NMS(Index = 5)]
        /* 0x0F58 */ public float AlienPodAggroSpring;
        [NMS(Index = 809)]
        /* 0x0F5C */ public float AnimRunBlendPoint;
        [NMS(Index = 806)]
        /* 0x0F60 */ public float AnimRunSpeed;
        [NMS(Index = 808)]
        /* 0x0F64 */ public float AnimWalkBlendPoint;
        [NMS(Index = 805)]
        /* 0x0F68 */ public float AnimWalkSpeed;
        [NMS(Index = 807)]
        /* 0x0F6C */ public float AnimWalkToRunSpeed;
        [NMS(Index = 711)]
        /* 0x0F70 */ public float AtmosphereEffectOffset;
        [NMS(Index = 710)]
        /* 0x0F74 */ public float AtmosphereEffectTime;
        [NMS(Index = 640)]
        /* 0x0F78 */ public float AutoAimFixedInterceptSpeed;
        [NMS(Index = 639)]
        /* 0x0F7C */ public float AutoAimMaxAccelFactor;
        [NMS(Index = 642)]
        /* 0x0F80 */ public float AutoAimMaxAngle;
        [NMS(Index = 643)]
        /* 0x0F84 */ public float AutoAimMinScreenDistance;
        [NMS(Index = 644)]
        /* 0x0F88 */ public float AutoAimRadiusExtra;
        [NMS(Index = 647)]
        /* 0x0F8C */ public float AutoAimStickyMax;
        [NMS(Index = 646)]
        /* 0x0F90 */ public float AutoAimStickyMin;
        [NMS(Index = 645)]
        /* 0x0F94 */ public float AutoAimStickyRailgun;
        [NMS(Index = 641)]
        /* 0x0F98 */ public float AutoAimTimeOut;
        [NMS(Index = 706)]
        /* 0x0F9C */ public float AutoLandRange;
        [NMS(Index = 707)]
        /* 0x0FA0 */ public float AutoLandTime;
        [NMS(Index = 862)]
        /* 0x0FA4 */ public float AutoSaveRangeInSpace;
        [NMS(Index = 861)]
        /* 0x0FA8 */ public float AutoSaveRangeInVehicle;
        [NMS(Index = 860)]
        /* 0x0FAC */ public float AutoSaveRangeOnFoot;
        [NMS(Index = 802)]
        /* 0x0FB0 */ public float BalanceSpeed;
        [NMS(Index = 801)]
        /* 0x0FB4 */ public float BalanceStrength;
        [NMS(Index = 663)]
        /* 0x0FB8 */ public float BeaconActivateRange;
        [NMS(Index = 614)]
        /* 0x0FBC */ public float BeamRecoil;
        [NMS(Index = 886)]
        /* 0x0FC0 */ public int BestGuildRank;
        [NMS(Index = 43)]
        /* 0x0FC4 */ public float BincoularRayThickness;
        [NMS(Index = 16)]
        /* 0x0FC8 */ public float BinocularAimOffset;
        [NMS(Index = 215)]
        /* 0x0FCC */ public float BinocularCreatureCastSphereSize;
        [NMS(Index = 212)]
        /* 0x0FD0 */ public float BinocularRangePlanet;
        [NMS(Index = 213)]
        /* 0x0FD4 */ public float BinocularRangeSpace;
        [NMS(Index = 42)]
        /* 0x0FD8 */ public float BinocularRayThicknessVR;
        [NMS(Index = 17)]
        /* 0x0FDC */ public float BinocularScopeScale;
        [NMS(Index = 18)]
        /* 0x0FE0 */ public float BinocularScopeSmoothing;
        [NMS(Index = 45)]
        /* 0x0FE4 */ public float BinocularsHUDDistanceVR;
        [NMS(Index = 46)]
        /* 0x0FE8 */ public float BinocularsHUDScaleVR;
        [NMS(Index = 617)]
        /* 0x0FEC */ public float BlastRecoilSpring;
        [NMS(Index = 95)]
        /* 0x0FF0 */ public float BodyRealignmentDelay;
        [NMS(Index = 762)]
        /* 0x0FF4 */ public float BulletBend;
        [NMS(Index = 451)]
        /* 0x0FF8 */ public int BulletClipMultiplier;
        [NMS(Index = 450)]
        /* 0x0FFC */ public int BulletCostReducer;
        [NMS(Index = 620)]
        /* 0x1000 */ public float CannonRecoilSpring;
        [NMS(Index = 449)]
        /* 0x1004 */ public int ChanceHighGradeIllegal;
        [NMS(Index = 774)]
        /* 0x1008 */ public float ChargedEnergyBallSpeed;
        [NMS(Index = 536)]
        /* 0x100C */ public float ChargeMeleeCooldown;
        [NMS(Index = 772)]
        /* 0x1010 */ public float ChargeTime;
        [NMS(Index = 829)]
        /* 0x1014 */ public float ClimbableStickinessAngle;
        [NMS(Index = 827)]
        /* 0x1018 */ public float ClingAngleThreshold;
        [NMS(Index = 826)]
        /* 0x101C */ public float ClingBrakeMultiplier;
        [NMS(Index = 828)]
        /* 0x1020 */ public float ClingSpeedThreshold;
        [NMS(Index = 211)]
        /* 0x1024 */ public float CockpitEjectFirstPersonOffset;
        [NMS(Index = 210)]
        /* 0x1028 */ public float CockpitEjectFirstPersonOffsetTime;
        [NMS(Index = 295)]
        /* 0x102C */ public float CockpitEjectSideTestRange;
        [NMS(Index = 209)]
        /* 0x1030 */ public float CockpitEjectTestEndHeightOffset;
        [NMS(Index = 207)]
        /* 0x1034 */ public float CockpitEjectTestRadius;
        [NMS(Index = 293)]
        /* 0x1038 */ public float CockpitEjectTestSphereRadius;
        [NMS(Index = 294)]
        /* 0x103C */ public float CockpitEjectTestSphereRange;
        [NMS(Index = 208)]
        /* 0x1040 */ public float CockpitEjectTestStartHeightOffset;
        [NMS(Index = 462)]
        /* 0x1044 */ public float CombatEscalateTime;
        [NMS(Index = 463)]
        /* 0x1048 */ public float CombatEscapeRadius;
        [NMS(Index = 464)]
        /* 0x104C */ public float CombatEscapeTime;
        [NMS(Index = 284)]
        /* 0x1050 */ public float CombatSpawnMinWantedTime;
        [NMS(Index = 288)]
        /* 0x1054 */ public float CommunicatorSpeed;
        // size: 0x3
        public enum ControlModesEnum : uint {
            Normal,
            FlightStick,
            Inverted,
        }
        [NMS(Index = 597)]
        /* 0x1058 */ public ControlModesEnum ControlModes;
        [NMS(Index = 220)]
        /* 0x105C */ public float CreativeModeDeathFadeInTime;
        [NMS(Index = 221)]
        /* 0x1060 */ public float CreativeModeDeathFadeOutTime;
        [NMS(Index = 223)]
        /* 0x1064 */ public float CreatureRideFadeInTime;
        [NMS(Index = 224)]
        /* 0x1068 */ public float CreatureRideFadeOutTime;
        [NMS(Index = 869)]
        /* 0x106C */ public float CriticalHitDesatFreq;
        [NMS(Index = 868)]
        /* 0x1070 */ public float CriticalHitDesatTime;
        [NMS(Index = 867)]
        /* 0x1074 */ public float CriticalHitTime;
        [NMS(Index = 662)]
        /* 0x1078 */ public float CrosshairTime;
        [NMS(Index = 440)]
        /* 0x107C */ public float CrouchHeightToDisableLegBlendingVR;
        [NMS(Index = 777)]
        /* 0x1080 */ public float DamageRateWhenUnderNoGravity;
        [NMS(Index = 383)]
        /* 0x1084 */ public float DamageRepairFactor;
        [NMS(Index = 529)]
        /* 0x1088 */ public float DeathDamageDrainChargeFactor;
        [NMS(Index = 530)]
        /* 0x108C */ public int DeathDamageTechBrokenPercent;
        [NMS(Index = 850)]
        /* 0x1090 */ public float DeathScreenFadeInThirdPerson;
        [NMS(Index = 852)]
        /* 0x1094 */ public float DeathScreenFadeInTime;
        [NMS(Index = 851)]
        /* 0x1098 */ public float DeathScreenFadeInUnderwaterThirdPerson;
        [NMS(Index = 857)]
        /* 0x109C */ public float DeathScreenFadeOutTime;
        [NMS(Index = 855)]
        /* 0x10A0 */ public float DeathScreenMaxRegenWaitTime;
        [NMS(Index = 856)]
        /* 0x10A4 */ public float DeathScreenMinRegenWaitTime;
        [NMS(Index = 854)]
        /* 0x10A8 */ public float DeathScreenPauseTime;
        [NMS(Index = 853)]
        /* 0x10AC */ public float DeathScreenShipFadeInTime;
        [NMS(Index = 206)]
        /* 0x10B0 */ public float DeepWaterDepth;
        [NMS(Index = 233)]
        /* 0x10B4 */ public int DefaultHealthPips;
        [NMS(Index = 232)]
        /* 0x10B8 */ public int DefaultHitPoints;
        [NMS(Index = 234)]
        /* 0x10BC */ public int DefaultShipHealthPips;
        [NMS(Index = 411)]
        /* 0x10C0 */ public float DestroyEffectFinalDelay;
        [NMS(Index = 470)]
        /* 0x10C4 */ public float DroneProbeScanTime;
        [NMS(Index = 251)]
        /* 0x10C8 */ public float DroneScanTimeToForget;
        [NMS(Index = 237)]
        /* 0x10CC */ public float DroneSpawnAccelerator;
        [NMS(Index = 217)]
        /* 0x10D0 */ public float DroneStartLocationRadius;
        [NMS(Index = 388)]
        /* 0x10D4 */ public float EarlyHazardTimeMultiplier;
        [NMS(Index = 773)]
        /* 0x10D8 */ public float EnergyBallSpeed;
        [NMS(Index = 302)]
        /* 0x10DC */ public float EnergyDamageMinTime;
        [NMS(Index = 306)]
        /* 0x10E0 */ public float EnergyDischargeRateFloatingInSpace;
        [NMS(Index = 305)]
        /* 0x10E4 */ public float EnergyDischargeRateHigh;
        [NMS(Index = 303)]
        /* 0x10E8 */ public float EnergyDischargeRateLow;
        [NMS(Index = 304)]
        /* 0x10EC */ public float EnergyDischargeRateMedium;
        [NMS(Index = 307)]
        /* 0x10F0 */ public float EnergyPainRate;
        [NMS(Index = 804)]
        /* 0x10F4 */ public float ExertionFromPainTime;
        [NMS(Index = 803)]
        /* 0x10F8 */ public float ExertionSmoothTime;
        [NMS(Index = 682)]
        /* 0x10FC */ public float ExperienceAlertRange;
        [NMS(Index = 684)]
        /* 0x1100 */ public float ExperienceAlertSightAngle;
        [NMS(Index = 683)]
        /* 0x1104 */ public float ExperienceAlertSightRange;
        [NMS(Index = 698)]
        /* 0x1108 */ public float ExperienceDefeatBugQueenFiendSplatDelay;
        [NMS(Index = 700)]
        /* 0x110C */ public float ExperienceDefeatBugQueenRewardChance;
        [NMS(Index = 697)]
        /* 0x1110 */ public float ExperienceDefeatBugQueenRewardDelay;
        [NMS(Index = 696)]
        /* 0x1114 */ public float ExperienceDefeatLevel5SentinelsDisableWantedTime;
        [NMS(Index = 692)]
        /* 0x1118 */ public float ExperienceDefeatLevel5SentinelsRewardDelay;
        [NMS(Index = 689)]
        /* 0x111C */ public float ExperienceDefeatLevel5SpaceSentinelsMessageDelay;
        [NMS(Index = 690)]
        /* 0x1120 */ public float ExperienceDefeatLevel5SpaceSentinelsRewardDelay;
        [NMS(Index = 688)]
        /* 0x1124 */ public float ExperienceDefeatLevel5SpaceSentinelsWarpDelay;
        [NMS(Index = 686)]
        /* 0x1128 */ public float ExperienceDroneSpawnAngle;
        [NMS(Index = 685)]
        /* 0x112C */ public float ExperienceDroneSpawnOffset;
        [NMS(Index = 678)]
        /* 0x1130 */ public float ExperienceDroneTimeMax;
        [NMS(Index = 677)]
        /* 0x1134 */ public float ExperienceDroneTimeMin;
        [NMS(Index = 679)]
        /* 0x1138 */ public float ExperienceFlybyScareRadius;
        [NMS(Index = 680)]
        /* 0x113C */ public float ExperienceFlybyScareTime;
        [NMS(Index = 286)]
        /* 0x1140 */ public float ExperienceHardPiratesDamageMaxOdds;
        [NMS(Index = 671)]
        /* 0x1144 */ public float ExperienceInterestingDroneDistance;
        [NMS(Index = 670)]
        /* 0x1148 */ public float ExperienceInterestingFreighterDistance;
        [NMS(Index = 668)]
        /* 0x114C */ public float ExperienceInterestingPoliceDistance;
        [NMS(Index = 669)]
        /* 0x1150 */ public float ExperienceInterestingShipDistance;
        [NMS(Index = 665)]
        /* 0x1154 */ public int ExperienceMaxCivilianShipSpawnsInSpace;
        [NMS(Index = 664)]
        /* 0x1158 */ public int ExperienceMaxCivilianShipSpawnsOnPlanet;
        [NMS(Index = 287)]
        /* 0x115C */ public float ExperienceMediumPiratesDamageMaxOdds;
        [NMS(Index = 687)]
        /* 0x1160 */ public float ExperienceMessageBroadcastNearbyDistance;
        [NMS(Index = 674)]
        /* 0x1164 */ public int ExperiencePirateCloseAttackPercentage;
        [NMS(Index = 666)]
        /* 0x1168 */ public float ExperiencePirateFreighterAttackRange;
        [NMS(Index = 285)]
        /* 0x116C */ public float ExperiencePiratesDifficultyVariance;
        [NMS(Index = 676)]
        /* 0x1170 */ public float ExperiencePirateTimeMax;
        [NMS(Index = 675)]
        /* 0x1174 */ public float ExperiencePirateTimeMin;
        [NMS(Index = 673)]
        /* 0x1178 */ public float ExperienceShipTimeMax;
        [NMS(Index = 672)]
        /* 0x117C */ public float ExperienceShipTimeMin;
        [NMS(Index = 667)]
        /* 0x1180 */ public float ExperienceWalkerSize;
        [NMS(Index = 719)]
        /* 0x1184 */ public float ExplodeShakeMaxDist;
        [NMS(Index = 720)]
        /* 0x1188 */ public float ExplodeShakeMaxDistSpace;
        [NMS(Index = 721)]
        /* 0x118C */ public float ExplodeShakeStrength;
        [NMS(Index = 409)]
        /* 0x1190 */ public float ExplosionBoundingInset;
        [NMS(Index = 410)]
        /* 0x1194 */ public float ExplosionBoundingInsetRange;
        [NMS(Index = 408)]
        /* 0x1198 */ public float ExplosionScaleVariance;
        [NMS(Index = 406)]
        /* 0x119C */ public float ExplosionTimePerEffect;
        [NMS(Index = 407)]
        /* 0x11A0 */ public float ExplosionTimeVariance;
        [NMS(Index = 61)]
        /* 0x11A4 */ public float FingerButtonClickSize;
        [NMS(Index = 63)]
        /* 0x11A8 */ public float FingerButtonClickTime;
        [NMS(Index = 64)]
        /* 0x11AC */ public float FingerButtonQuickMenuOffset;
        [NMS(Index = 62)]
        /* 0x11B0 */ public float FingerButtonRadiusOffset;
        [NMS(Index = 60)]
        /* 0x11B4 */ public float FingerTipOffset;
        [NMS(Index = 85)]
        /* 0x11B8 */ public float FistClenchBlendInTime;
        [NMS(Index = 86)]
        /* 0x11BC */ public float FistClenchBlendOutTime;
        [NMS(Index = 628)]
        /* 0x11C0 */ public float FlamethrowerDispersion;
        [NMS(Index = 728)]
        /* 0x11C4 */ public float FlashGrow;
        [NMS(Index = 723)]
        /* 0x11C8 */ public float FlashPosX;
        [NMS(Index = 724)]
        /* 0x11CC */ public float FlashPosY;
        [NMS(Index = 725)]
        /* 0x11D0 */ public float FlashPosZ;
        [NMS(Index = 727)]
        /* 0x11D4 */ public float FlashPulse;
        [NMS(Index = 722)]
        /* 0x11D8 */ public float FlashSize;
        [NMS(Index = 726)]
        /* 0x11DC */ public float FlashSpeed;
        [NMS(Index = 8)]
        /* 0x11E0 */ public float FoodValueThresholdAverage;
        [NMS(Index = 9)]
        /* 0x11E4 */ public float FoodValueThresholdBad;
        [NMS(Index = 6)]
        /* 0x11E8 */ public float FoodValueThresholdBest;
        [NMS(Index = 7)]
        /* 0x11EC */ public float FoodValueThresholdGood;
        [NMS(Index = 10)]
        /* 0x11F0 */ public float FoodValueThresholdWorst;
        [NMS(Index = 825)]
        /* 0x11F4 */ public float FootDustScale;
        [NMS(Index = 831)]
        /* 0x11F8 */ public float FootOffset;
        [NMS(Index = 317)]
        /* 0x11FC */ public float FreeJetpackRange;
        [NMS(Index = 319)]
        /* 0x1200 */ public float FreeJetpackRangeNonTerrain;
        [NMS(Index = 318)]
        /* 0x1204 */ public float FreeJetpackRangePrime;
        [NMS(Index = 820)]
        /* 0x1208 */ public float FreeJetpackSlopeAngle;
        [NMS(Index = 821)]
        /* 0x120C */ public float FreeJetpackSlopeAnglePrime;
        [NMS(Index = 391)]
        /* 0x1210 */ public float FreighterAbandonedHazardTimeMultiplier;
        [NMS(Index = 417)]
        /* 0x1214 */ public float FreighterCoolFactor;
        [NMS(Index = 414)]
        /* 0x1218 */ public float FreighterPriceExp2;
        [NMS(Index = 402)]
        /* 0x121C */ public float FreighterProbeScanTime;
        [NMS(Index = 219)]
        /* 0x1220 */ public float FreighterSpawnedOnYouFadeInTime;
        [NMS(Index = 512)]
        /* 0x1224 */ public float FrigateFlybyMarkerAlwaysHideDistance;
        [NMS(Index = 511)]
        /* 0x1228 */ public float FrigateFlybyMarkerAlwaysShowDistance;
        [NMS(Index = 275)]
        /* 0x122C */ public float FrontShieldOffsetOff;
        [NMS(Index = 281)]
        /* 0x1230 */ public float FrontShieldOffsetOffVR;
        [NMS(Index = 276)]
        /* 0x1234 */ public float FrontShieldOffsetOn;
        [NMS(Index = 282)]
        /* 0x1238 */ public float FrontShieldOffsetOnVR;
        [NMS(Index = 279)]
        /* 0x123C */ public float FrontShieldScaleVR;
        [NMS(Index = 278)]
        /* 0x1240 */ public float FrontShieldSlerpTime;
        [NMS(Index = 283)]
        /* 0x1244 */ public float FrontShieldSlerpTimeVR;
        [NMS(Index = 277)]
        /* 0x1248 */ public float FrontShieldSpeedSlowdown;
        [NMS(Index = 280)]
        /* 0x124C */ public float FrontShieldUpOffsetVR;
        [NMS(Index = 822)]
        /* 0x1250 */ public float FullClipReloadSpeedMultiplier;
        [NMS(Index = 256)]
        /* 0x1254 */ public float GhostbusterAmp1;
        [NMS(Index = 260)]
        /* 0x1258 */ public float GhostbusterAmp2;
        [NMS(Index = 264)]
        /* 0x125C */ public float GhostbusterAmp3;
        [NMS(Index = 255)]
        /* 0x1260 */ public float GhostbusterFreq1;
        [NMS(Index = 259)]
        /* 0x1264 */ public float GhostbusterFreq2;
        [NMS(Index = 263)]
        /* 0x1268 */ public float GhostbusterFreq3;
        [NMS(Index = 254)]
        /* 0x126C */ public float GhostbusterSpeed1;
        [NMS(Index = 258)]
        /* 0x1270 */ public float GhostbusterSpeed2;
        [NMS(Index = 262)]
        /* 0x1274 */ public float GhostbusterSpeed3;
        [NMS(Index = 253)]
        /* 0x1278 */ public float GhostbusterStart1;
        [NMS(Index = 257)]
        /* 0x127C */ public float GhostbusterStart2;
        [NMS(Index = 261)]
        /* 0x1280 */ public float GhostbusterStart3;
        [NMS(Index = 252)]
        /* 0x1284 */ public float GhostbusterStartLength;
        [NMS(Index = 877)]
        /* 0x1288 */ public float GrassPushDistance;
        [NMS(Index = 878)]
        /* 0x128C */ public float GrassPushDistanceFeet;
        [NMS(Index = 534)]
        /* 0x1290 */ public int GrenadeBaseClipSize;
        [NMS(Index = 290)]
        /* 0x1294 */ public float GrenadeBounceDamping;
        [NMS(Index = 291)]
        /* 0x1298 */ public float GrenadeBounceMaxSpeed;
        [NMS(Index = 771)]
        /* 0x129C */ public float GrenadeCarveRadius;
        [NMS(Index = 615)]
        /* 0x12A0 */ public float GrenadeRecoil;
        [NMS(Index = 292)]
        /* 0x12A4 */ public float GrenadeStopExplodeTime;
        [NMS(Index = 736)]
        /* 0x12A8 */ public float GrenadeTerrainDeformRadius;
        [NMS(Index = 111)]
        /* 0x12AC */ public float GroundRunSpeed;
        [NMS(Index = 113)]
        /* 0x12B0 */ public float GroundRunSpeedLowG;
        [NMS(Index = 107)]
        /* 0x12B4 */ public float GroundWalkBrake;
        [NMS(Index = 108)]
        /* 0x12B8 */ public float GroundWalkBrakeWhileMoving;
        [NMS(Index = 106)]
        /* 0x12BC */ public float GroundWalkForceMultiplier;
        [NMS(Index = 114)]
        /* 0x12C0 */ public float GroundWalkRecoverySpeedDamper;
        [NMS(Index = 109)]
        /* 0x12C4 */ public float GroundWalkSpeed;
        [NMS(Index = 112)]
        /* 0x12C8 */ public float GroundWalkSpeedLowG;
        [NMS(Index = 110)]
        /* 0x12CC */ public float GroundWalkSpeedTeleportHmd;
        [NMS(Index = 533)]
        /* 0x12D0 */ public int GunBaseClipSize;
        [NMS(Index = 612)]
        /* 0x12D4 */ public float GunRecoil;
        [NMS(Index = 624)]
        /* 0x12D8 */ public float GunRecoilMax;
        [NMS(Index = 623)]
        /* 0x12DC */ public float GunRecoilMin;
        [NMS(Index = 621)]
        /* 0x12E0 */ public float GunRecoilSettleSpring;
        [NMS(Index = 616)]
        /* 0x12E4 */ public float GunRecoilSpring;
        [NMS(Index = 729)]
        /* 0x12E8 */ public float GunRightOffset;
        [NMS(Index = 730)]
        /* 0x12EC */ public float GunUpOffset;
        [NMS(Index = 157)]
        /* 0x12F0 */ public float HandHoldInteractAngleRate;
        [NMS(Index = 156)]
        /* 0x12F4 */ public float HandHoldInteractDistanceRate;
        [NMS(Index = 68)]
        /* 0x12F8 */ public float HandInteractionFresnel;
        [NMS(Index = 69)]
        /* 0x12FC */ public float HandInteractionFresnelMax;
        [NMS(Index = 66)]
        /* 0x1300 */ public float HandInteractionLightIntensity;
        [NMS(Index = 67)]
        /* 0x1304 */ public float HandInteractionLightIntensityMax;
        [NMS(Index = 70)]
        /* 0x1308 */ public float HandInteractionLightOffset;
        [NMS(Index = 71)]
        /* 0x130C */ public float HandInteractionLightOffsetAt;
        [NMS(Index = 72)]
        /* 0x1310 */ public float HandInteractionLightTime;
        [NMS(Index = 78)]
        /* 0x1314 */ public float HandScreenActivationAngle;
        [NMS(Index = 80)]
        /* 0x1318 */ public float HandScreenActivationAngleDown;
        [NMS(Index = 79)]
        /* 0x131C */ public float HandScreenActivationAngleOffset;
        [NMS(Index = 77)]
        /* 0x1320 */ public float HandScreenActivationRange;
        [NMS(Index = 76)]
        /* 0x1324 */ public float HandScreenAngleRange;
        [NMS(Index = 73)]
        /* 0x1328 */ public float HandScreenLookActiveAngle;
        [NMS(Index = 74)]
        /* 0x132C */ public float HandScreenMinAngle;
        [NMS(Index = 75)]
        /* 0x1330 */ public float HandScreenMinAngleWithPoint;
        [NMS(Index = 81)]
        /* 0x1334 */ public float HandScreenPenetration;
        [NMS(Index = 82)]
        /* 0x1338 */ public float HandScreenRestingTurnAngle;
        [NMS(Index = 116)]
        /* 0x133C */ public float HandSmoothAngleRange;
        [NMS(Index = 115)]
        /* 0x1340 */ public float HandSmoothMinAngle;
        [NMS(Index = 160)]
        /* 0x1344 */ public float HandSwimDecayTime;
        [NMS(Index = 161)]
        /* 0x1348 */ public float HandSwimForce;
        [NMS(Index = 159)]
        /* 0x134C */ public float HandSwimMax;
        [NMS(Index = 162)]
        /* 0x1350 */ public float HandSwimMaxForce;
        [NMS(Index = 158)]
        /* 0x1354 */ public float HandSwimMin;
        [NMS(Index = 781)]
        /* 0x1358 */ public float HardLandMax;
        [NMS(Index = 780)]
        /* 0x135C */ public float HardLandMin;
        [NMS(Index = 532)]
        /* 0x1360 */ public float HardLandPainTime;
        [NMS(Index = 779)]
        /* 0x1364 */ public float HardLandTime;
        [NMS(Index = 398)]
        /* 0x1368 */ public float HardModeHazardDamageRateMultiplier;
        [NMS(Index = 399)]
        /* 0x136C */ public float HardModeHazardDamageWoundRateMultiplier;
        [NMS(Index = 400)]
        /* 0x1370 */ public float HardModeHazardRechargeUnderground;
        [NMS(Index = 397)]
        /* 0x1374 */ public float HardModeHazardTimeMultiplier;
        [NMS(Index = 301)]
        /* 0x1378 */ public float HazardDamageMinTime;
        [NMS(Index = 175)]
        /* 0x137C */ public float HeadBinocularsOffset;
        [NMS(Index = 176)]
        /* 0x1380 */ public float HeadBinocularsRadius;
        [NMS(Index = 243)]
        /* 0x1384 */ public float HealthPipRechargeRate;
        [NMS(Index = 242)]
        /* 0x1388 */ public float HealthRechargeMinTimeSinceDamage;
        [NMS(Index = 609)]
        /* 0x138C */ public float HeatShieldTime;
        [NMS(Index = 842)]
        /* 0x1390 */ public float HelmetBob;
        [NMS(Index = 840)]
        /* 0x1394 */ public float HelmetLag;
        [NMS(Index = 841)]
        /* 0x1398 */ public float HelmetMaxLag;
        [NMS(Index = 885)]
        /* 0x139C */ public int HighGuildRank;
        [NMS(Index = 184)]
        /* 0x13A0 */ public float HitReactBlendOutSpeedMax;
        [NMS(Index = 183)]
        /* 0x13A4 */ public float HitReactBlendOutSpeedMin;
        [NMS(Index = 182)]
        /* 0x13A8 */ public float HitReactNoiseAmount;
        [NMS(Index = 117)]
        /* 0x13AC */ public float HmdResetButtonTime;
        [NMS(Index = 225)]
        /* 0x13B0 */ public float HMDResetFlashTime;
        [NMS(Index = 165)]
        /* 0x13B4 */ public float HmdTurnAngle;
        [NMS(Index = 166)]
        /* 0x13B8 */ public float HmdTurnAnglePad;
        [NMS(Index = 101)]
        /* 0x13BC */ public float HmdTurnSpeed;
        [NMS(Index = 102)]
        /* 0x13C0 */ public float HmdTurnSpeedPad;
        [NMS(Index = 164)]
        /* 0x13C4 */ public float HmdTurnThreshold;
        [NMS(Index = 793)]
        /* 0x13C8 */ public float HoldActionDistX;
        [NMS(Index = 794)]
        /* 0x13CC */ public float HoldActionDistY;
        [NMS(Index = 795)]
        /* 0x13D0 */ public float HoldActionDistZ;
        [NMS(Index = 796)]
        /* 0x13D4 */ public float HoldDistX;
        [NMS(Index = 797)]
        /* 0x13D8 */ public float HoldDistY;
        [NMS(Index = 798)]
        /* 0x13DC */ public float HoldDistZ;
        [NMS(Index = 791)]
        /* 0x13E0 */ public float HoldForce;
        [NMS(Index = 799)]
        /* 0x13E4 */ public float HoldMaxForce;
        [NMS(Index = 800)]
        /* 0x13E8 */ public float HoldRotate;
        [NMS(Index = 792)]
        /* 0x13EC */ public float HoldTime;
        [NMS(Index = 174)]
        /* 0x13F0 */ public float HolsterGrabFrontOffset;
        [NMS(Index = 173)]
        /* 0x13F4 */ public float HolsterGrabRadius;
        [NMS(Index = 787)]
        /* 0x13F8 */ public int HUDHeightPosX;
        [NMS(Index = 788)]
        /* 0x13FC */ public int HUDHeightPosY;
        [NMS(Index = 24)]
        /* 0x1400 */ public float InteractionAimOffset;
        [NMS(Index = 600)]
        /* 0x1404 */ public float InteractionButtonRange;
        [NMS(Index = 601)]
        /* 0x1408 */ public float InteractionButtonRangeVehicle;
        [NMS(Index = 602)]
        /* 0x140C */ public float InteractionFocusIncrease;
        [NMS(Index = 603)]
        /* 0x1410 */ public float InteractionFocusIncreaseCreature;
        [NMS(Index = 604)]
        /* 0x1414 */ public float InteractionFocusIncreasePet;
        [NMS(Index = 605)]
        /* 0x1418 */ public float InteractionFocusTime;
        [NMS(Index = 606)]
        /* 0x141C */ public float InteractionFocusTimeCreature;
        [NMS(Index = 607)]
        /* 0x1420 */ public float InteractionFocusTimePet;
        [NMS(Index = 148)]
        /* 0x1424 */ public float InteractionLineCircleOffsetMax;
        [NMS(Index = 147)]
        /* 0x1428 */ public float InteractionLineCircleOffsetMin;
        [NMS(Index = 144)]
        /* 0x142C */ public float InteractionLineCircleRadius;
        [NMS(Index = 146)]
        /* 0x1430 */ public float InteractionLineCircleSpeed;
        [NMS(Index = 145)]
        /* 0x1434 */ public float InteractionLineCircleThickness;
        [NMS(Index = 149)]
        /* 0x1438 */ public float InteractionLineNumCirclesPerMetre;
        [NMS(Index = 142)]
        /* 0x143C */ public float InteractionLineSplineMinDistance;
        [NMS(Index = 140)]
        /* 0x1440 */ public float InteractionLineSplineOffset;
        [NMS(Index = 141)]
        /* 0x1444 */ public float InteractionLineSplineOffsetMin;
        [NMS(Index = 143)]
        /* 0x1448 */ public float InteractionLineSplineOffsetRange;
        [NMS(Index = 599)]
        /* 0x144C */ public float InteractionScanRange;
        [NMS(Index = 608)]
        /* 0x1450 */ public float InteractionSubstanceRange;
        [NMS(Index = 93)]
        /* 0x1454 */ public float InteractNearbyRadius;
        [NMS(Index = 357)]
        /* 0x1458 */ public float JetpackBrake;
        [NMS(Index = 320)]
        /* 0x145C */ public float JetpackDrainHorizontalFactor;
        [NMS(Index = 366)]
        /* 0x1460 */ public float JetpackFillRate;
        [NMS(Index = 369)]
        /* 0x1464 */ public float JetpackFillRateFleetMultiplier;
        [NMS(Index = 367)]
        /* 0x1468 */ public float JetpackFillRateMidair;
        [NMS(Index = 370)]
        /* 0x146C */ public float JetpackFillRateNexusMultiplier;
        [NMS(Index = 368)]
        /* 0x1470 */ public float JetpackFillRateSpaceStationMultiplier;
        [NMS(Index = 356)]
        /* 0x1474 */ public float JetpackForce;
        [NMS(Index = 372)]
        /* 0x1478 */ public float JetpackForceDeadPlanetExtra;
        [NMS(Index = 843)]
        /* 0x147C */ public float JetpackHelmetBob;
        [NMS(Index = 362)]
        /* 0x1480 */ public float JetpackIgnitionForce;
        [NMS(Index = 373)]
        /* 0x1484 */ public float JetpackIgnitionForceDeadPlanetExtra;
        [NMS(Index = 363)]
        /* 0x1488 */ public float JetpackIgnitionTime;
        [NMS(Index = 316)]
        /* 0x148C */ public float JetpackJetAnimateInTime;
        [NMS(Index = 315)]
        /* 0x1490 */ public float JetpackJetAnimateOutTime;
        [NMS(Index = 359)]
        /* 0x1494 */ public float JetpackMaxSpeed;
        [NMS(Index = 360)]
        /* 0x1498 */ public float JetpackMaxUpSpeed;
        [NMS(Index = 364)]
        /* 0x149C */ public float JetpackMinIgnitionTime;
        [NMS(Index = 358)]
        /* 0x14A0 */ public float JetpackMinLevel;
        [NMS(Index = 185)]
        /* 0x14A4 */ public float JetpackUnderwaterDrainRate;
        [NMS(Index = 186)]
        /* 0x14A8 */ public float JetpackUnderwaterFillRate;
        [NMS(Index = 361)]
        /* 0x14AC */ public float JetpackUpForce;
        [NMS(Index = 371)]
        /* 0x14B0 */ public float JetpackUpForceDeadPlanetExtra;
        [NMS(Index = 374)]
        /* 0x14B4 */ public float JoystickOrientationTrimAltOc;
        [NMS(Index = 375)]
        /* 0x14B8 */ public float JoystickOrientationTrimAltOp;
        [NMS(Index = 709)]
        /* 0x14BC */ public float LabelOffset;
        [NMS(Index = 708)]
        /* 0x14C0 */ public float LabelSpringTime;
        [NMS(Index = 739)]
        /* 0x14C4 */ public float LaserBeamAmmoUseTime;
        [NMS(Index = 732)]
        /* 0x14C8 */ public float LaserBeamCore;
        [NMS(Index = 733)]
        /* 0x14CC */ public float LaserBeamFlickerAmp;
        [NMS(Index = 734)]
        /* 0x14D0 */ public float LaserBeamFlickerFreq;
        [NMS(Index = 731)]
        /* 0x14D4 */ public float LaserBeamMineRate;
        [NMS(Index = 737)]
        /* 0x14D8 */ public float LaserBeamTerrainDeformRadius;
        [NMS(Index = 738)]
        /* 0x14DC */ public float LaserBeamTerrainDeformVariance;
        [NMS(Index = 735)]
        /* 0x14E0 */ public float LaserEndOffset;
        [NMS(Index = 522)]
        /* 0x14E4 */ public float LaserMiningDamageMultiplier;
        [NMS(Index = 458)]
        /* 0x14E8 */ public float LaserPlayerOffset;
        [NMS(Index = 613)]
        /* 0x14EC */ public float LaserRecoil;
        [NMS(Index = 611)]
        /* 0x14F0 */ public float LaserShakeMax;
        [NMS(Index = 610)]
        /* 0x14F4 */ public float LaserShakeMin;
        [NMS(Index = 889)]
        /* 0x14F8 */ public float LaserShipRange;
        [NMS(Index = 888)]
        /* 0x14FC */ public float LaserWeaponRange;
        [NMS(Index = 838)]
        /* 0x1500 */ public float LeanAmount;
        [NMS(Index = 839)]
        /* 0x1504 */ public float LeanAmountFwd;
        [NMS(Index = 835)]
        /* 0x1508 */ public float LeanBackMaxAngle;
        [NMS(Index = 834)]
        /* 0x150C */ public float LeanFwdMaxAngle;
        [NMS(Index = 836)]
        /* 0x1510 */ public float LeanLeftMaxAngle;
        [NMS(Index = 837)]
        /* 0x1514 */ public float LeanRightMaxAngle;
        [NMS(Index = 775)]
        /* 0x1518 */ public float LookRayRadius;
        [NMS(Index = 452)]
        /* 0x151C */ public float LootForceMultiplier;
        [NMS(Index = 883)]
        /* 0x1520 */ public int LowGuildRank;
        [NMS(Index = 865)]
        /* 0x1524 */ public int LowHealthEffectPips;
        [NMS(Index = 866)]
        /* 0x1528 */ public int LowHealthEffectShield;
        [NMS(Index = 19)]
        /* 0x152C */ public float MaxArmExtension;
        [NMS(Index = 759)]
        /* 0x1530 */ public int MaxBuildHeight;
        [NMS(Index = 818)]
        /* 0x1534 */ public float MaxClingableSlopeAngle;
        [NMS(Index = 832)]
        /* 0x1538 */ public float MaxFallSpeed;
        [NMS(Index = 235)]
        /* 0x153C */ public int MaxHealthPips;
        [NMS(Index = 437)]
        /* 0x1540 */ public float MaximumCrouchVR;
        [NMS(Index = 438)]
        /* 0x1544 */ public float MaximumHeadHeightIncreaseVR;
        [NMS(Index = 439)]
        /* 0x1548 */ public float MaximumHorizontalOffsetVR;
        [NMS(Index = 403)]
        /* 0x154C */ public int MaxNumDestroyEffects;
        [NMS(Index = 468)]
        /* 0x1550 */ public int MaxNumShipsAttackingPlayer;
        [NMS(Index = 531)]
        /* 0x1554 */ public float MaxProjectileRadiusMultiplier;
        [NMS(Index = 845)]
        /* 0x1558 */ public float MaxResource;
        [NMS(Index = 810)]
        /* 0x155C */ public float MaxSlopeAngle;
        [NMS(Index = 817)]
        /* 0x1560 */ public float MaxSpidermanSlopeAngle;
        [NMS(Index = 322)]
        /* 0x1564 */ public float MaxTimeAfterMeleeBeforeBoost;
        [NMS(Index = 325)]
        /* 0x1568 */ public float MaxTimeInMeleeBoost;
        [NMS(Index = 814)]
        /* 0x156C */ public float MaxWalkableSlopeAngle;
        [NMS(Index = 151)]
        /* 0x1570 */ public int MaxWordCategoriesToSayPerNPC;
        [NMS(Index = 884)]
        /* 0x1574 */ public int MedGuildRank;
        [NMS(Index = 323)]
        /* 0x1578 */ public float MeleeBoostAirForce;
        [NMS(Index = 535)]
        /* 0x157C */ public float MeleeCooldown;
        [NMS(Index = 545)]
        /* 0x1580 */ public float MeleeCooldownAlt;
        [NMS(Index = 547)]
        /* 0x1584 */ public float MeleeDamageScale;
        [NMS(Index = 537)]
        /* 0x1588 */ public float MeleeDistance;
        [NMS(Index = 538)]
        /* 0x158C */ public float MeleeDistance3P;
        [NMS(Index = 549)]
        /* 0x1590 */ public float MeleeDistanceAlt;
        [NMS(Index = 784)]
        /* 0x1594 */ public float MeleeForcePush;
        [NMS(Index = 540)]
        /* 0x1598 */ public float MeleeHitTime;
        [NMS(Index = 785)]
        /* 0x159C */ public float MeleeOffset;
        [NMS(Index = 546)]
        /* 0x15A0 */ public float MeleePosDelta;
        [NMS(Index = 539)]
        /* 0x15A4 */ public float MeleeRadius;
        [NMS(Index = 548)]
        /* 0x15A8 */ public float MeleeRadiusAlt;
        [NMS(Index = 782)]
        /* 0x15AC */ public float MeleeRange;
        [NMS(Index = 541)]
        /* 0x15B0 */ public float MeleeSpeedBoost;
        [NMS(Index = 543)]
        /* 0x15B4 */ public float MeleeSpeedBoostRangeMultiplier;
        [NMS(Index = 542)]
        /* 0x15B8 */ public float MeleeSpeedDamageBoost;
        [NMS(Index = 544)]
        /* 0x15BC */ public float MeleeStaminaDrain;
        [NMS(Index = 783)]
        /* 0x15C0 */ public float MeleeTime;
        [NMS(Index = 324)]
        /* 0x15C4 */ public float MeleeToAirBoostInitialImpulse;
        [NMS(Index = 20)]
        /* 0x15C8 */ public float MinArmExtension;
        [NMS(Index = 214)]
        /* 0x15CC */ public float MinBinocActiveTime;
        [NMS(Index = 289)]
        /* 0x15D0 */ public float MinDistanceToCommunicatorTarget;
        [NMS(Index = 244)]
        /* 0x15D4 */ public float MinEnergyPercentOnRespawn;
        [NMS(Index = 819)]
        /* 0x15D8 */ public float MinimumPushOffForceToSlide;
        [NMS(Index = 13)]
        /* 0x15DC */ public float MiniportalAppearEffectTime;
        [NMS(Index = 14)]
        /* 0x15E0 */ public float MiniportalDisappearEffectTime;
        [NMS(Index = 404)]
        /* 0x15E4 */ public int MinNumDestroyEffects;
        [NMS(Index = 2)]
        /* 0x15E8 */ public float MinRespawnCharge;
        [NMS(Index = 813)]
        /* 0x15EC */ public float MinSlideTime;
        [NMS(Index = 815)]
        /* 0x15F0 */ public float MinSpidermanSlopeAngle;
        [NMS(Index = 321)]
        /* 0x15F4 */ public float MinTimeAfterMeleeBeforeBoost;
        [NMS(Index = 816)]
        /* 0x15F8 */ public float MinTimeToHoldSpidermanPose;
        [NMS(Index = 830)]
        /* 0x15FC */ public float MinUpAmount;
        [NMS(Index = 425)]
        /* 0x1600 */ public float MouseAimZone;
        [NMS(Index = 427)]
        /* 0x1604 */ public float MouseCrosshairAlphaFade;
        [NMS(Index = 428)]
        /* 0x1608 */ public float MouseCrosshairAlphaFadeSpeed;
        [NMS(Index = 429)]
        /* 0x160C */ public float MouseCrosshairLineAlpha;
        [NMS(Index = 430)]
        /* 0x1610 */ public float MouseCrosshairLineWidth;
        [NMS(Index = 426)]
        /* 0x1614 */ public float MouseCrosshairMaxAlpha;
        [NMS(Index = 432)]
        /* 0x1618 */ public float MouseCrosshairMultiplier;
        [NMS(Index = 431)]
        /* 0x161C */ public float MouseCrosshairShipStrength;
        [NMS(Index = 433)]
        /* 0x1620 */ public float MouseCrosshairShipStrengthOld;
        [NMS(Index = 422)]
        /* 0x1624 */ public float MouseDeadZone;
        [NMS(Index = 420)]
        /* 0x1628 */ public float MouseDeadZoneOld;
        [NMS(Index = 424)]
        /* 0x162C */ public float MouseDeadZoneVehicle;
        [NMS(Index = 435)]
        /* 0x1630 */ public float MouseFlightCorrectionBrakeMultiplier;
        [NMS(Index = 434)]
        /* 0x1634 */ public float MouseFlightCorrectionMultiplier;
        [NMS(Index = 421)]
        /* 0x1638 */ public float MouseMaxLength;
        [NMS(Index = 419)]
        /* 0x163C */ public float MouseMaxLengthOld;
        [NMS(Index = 423)]
        /* 0x1640 */ public float MouseMaxLengthVehicle;
        // size: 0x2
        public enum MouseSmoothModeEnum : uint {
            Off,
            Sprung,
        }
        [NMS(Index = 297)]
        /* 0x1644 */ public MouseSmoothModeEnum MouseSmoothMode;
        [NMS(Index = 525)]
        /* 0x1648 */ public float MoveStickHighRangeLimit;
        [NMS(Index = 526)]
        /* 0x164C */ public float MoveStickRunLimit;
        [NMS(Index = 241)]
        /* 0x1650 */ public float MultiplayerMinWanteEscalationTime;
        [NMS(Index = 629)]
        /* 0x1654 */ public float MuzzleFlashMulThirdPerson;
        [NMS(Index = 394)]
        /* 0x1658 */ public float NormalModeHazardDamageRateMultiplier;
        [NMS(Index = 395)]
        /* 0x165C */ public float NormalModeHazardDamageWoundRateMultiplier;
        [NMS(Index = 396)]
        /* 0x1660 */ public float NormalModeHazardRechargeUnderground;
        [NMS(Index = 393)]
        /* 0x1664 */ public float NormalModeHazardTimeMultiplier;
        [NMS(Index = 122)]
        /* 0x1668 */ public float NoStickTeleportDirectionChangeDeadzoneAngle;
        [NMS(Index = 226)]
        /* 0x166C */ public int NumberOfWarpsRequiredForFreightersToSpawn;
        [NMS(Index = 876)]
        /* 0x1670 */ public int NumTechShopSlots;
        [NMS(Index = 469)]
        /* 0x1674 */ public float ObjectScanTime;
        [NMS(Index = 246)]
        /* 0x1678 */ public float OtherPlayerTrackArrowRange;
        [NMS(Index = 714)]
        /* 0x167C */ public float PainColourSeperateAmount;
        [NMS(Index = 713)]
        /* 0x1680 */ public float PainFlickerAmount;
        [NMS(Index = 715)]
        /* 0x1684 */ public float PainTime;
        [NMS(Index = 269)]
        /* 0x1688 */ public float PassiveWeaponZoomFOV;
        [NMS(Index = 270)]
        /* 0x168C */ public float PassiveWeaponZoomFOVThirdPerson;
        [NMS(Index = 776)]
        /* 0x1690 */ public float PickRange;
        [NMS(Index = 487)]
        /* 0x1694 */ public float PirateBattleMarkerRange;
        [NMS(Index = 489)]
        /* 0x1698 */ public float PirateBattleMarkerTime;
        [NMS(Index = 490)]
        /* 0x169C */ public float PirateBattleMaxTime;
        [NMS(Index = 488)]
        /* 0x16A0 */ public float PirateBattleWarnTime;
        [NMS(Index = 472)]
        /* 0x16A4 */ public float PirateBountyInitTime;
        [NMS(Index = 473)]
        /* 0x16A8 */ public float PirateBountyMaxDistance;
        [NMS(Index = 474)]
        /* 0x16AC */ public float PirateBountyTimeoutTime;
        [NMS(Index = 481)]
        /* 0x16B0 */ public float PirateFlybyAttackDistancePastPlayer;
        [NMS(Index = 484)]
        /* 0x16B4 */ public float PirateFlybyAttackMaxTime;
        [NMS(Index = 483)]
        /* 0x16B8 */ public float PirateFlybyAttackMinTime;
        [NMS(Index = 482)]
        /* 0x16BC */ public float PirateFlybyAttackProbability;
        [NMS(Index = 471)]
        /* 0x16C0 */ public int PirateHailPercent;
        [NMS(Index = 476)]
        /* 0x16C4 */ public float PirateProbeAttackWaitTime;
        [NMS(Index = 477)]
        /* 0x16C8 */ public float PirateProbeAttackWarnTime;
        [NMS(Index = 480)]
        /* 0x16CC */ public float PirateProbeHailPause;
        [NMS(Index = 475)]
        /* 0x16D0 */ public float PirateProbeInitTime;
        [NMS(Index = 478)]
        /* 0x16D4 */ public float PirateProbeScanTime;
        [NMS(Index = 479)]
        /* 0x16D8 */ public float PirateProbeScanTotalTime;
        [NMS(Index = 486)]
        /* 0x16DC */ public float PirateRaidMaxTime;
        [NMS(Index = 485)]
        /* 0x16E0 */ public float PirateRaidMinTime;
        [NMS(Index = 250)]
        /* 0x16E4 */ public float PlayerSpaceTransferRange;
        [NMS(Index = 249)]
        /* 0x16E8 */ public float PlayerTransferRange;
        [NMS(Index = 598)]
        /* 0x16EC */ public float PlayerViewTargetRange;
        [NMS(Index = 96)]
        /* 0x16F0 */ public float PointDownToMoveAngle;
        [NMS(Index = 97)]
        /* 0x16F4 */ public float PointDownToMoveBackAngle;
        [NMS(Index = 626)]
        /* 0x16F8 */ public float ProjectileDamageFalloff;
        [NMS(Index = 405)]
        /* 0x16FC */ public float ProjectileEndTime;
        [NMS(Index = 518)]
        /* 0x1700 */ public float PulseEncounterMarkerAlwaysHideDistance;
        [NMS(Index = 517)]
        /* 0x1704 */ public float PulseEncounterMarkerAlwaysShowDistance;
        [NMS(Index = 516)]
        /* 0x1708 */ public float PulseEncounterMarkerShowAngle;
        [NMS(Index = 513)]
        /* 0x170C */ public float PulseEncounterMinTimeInPulse;
        [NMS(Index = 514)]
        /* 0x1710 */ public float PulseEncounterProbeTime;
        [NMS(Index = 515)]
        /* 0x1714 */ public float PulseEncounterProbeTimeRare;
        [NMS(Index = 519)]
        /* 0x1718 */ public float PulseEncounterSpawnEffectDistance;
        [NMS(Index = 520)]
        /* 0x171C */ public float PulseEncounterSpawnEffectTime;
        [NMS(Index = 619)]
        /* 0x1720 */ public float PulseRecoilSpring;
        [NMS(Index = 786)]
        /* 0x1724 */ public float PushForceAirFactor;
        [NMS(Index = 833)]
        /* 0x1728 */ public float PushForceDecay;
        [NMS(Index = 887)]
        /* 0x172C */ public float QuadAutoAimOffset;
        [NMS(Index = 618)]
        /* 0x1730 */ public float RailRecoilSpring;
        [NMS(Index = 740)]
        /* 0x1734 */ public float ReloadButtonHoldTimeToHolster;
        [NMS(Index = 823)]
        /* 0x1738 */ public float ReloadTapButtonSpeedIncrease;
        [NMS(Index = 457)]
        /* 0x173C */ public float ResourceBlobFinalScaleDistance;
        [NMS(Index = 205)]
        /* 0x1740 */ public float RespawnOnPadRadius;
        [NMS(Index = 216)]
        /* 0x1744 */ public int RobotMultiplierWithFriends;
        [NMS(Index = 328)]
        /* 0x1748 */ public float RocketBootsActivationWindow;
        [NMS(Index = 331)]
        /* 0x174C */ public float RocketBootsBoostForce;
        [NMS(Index = 344)]
        /* 0x1750 */ public float RocketBootsBoostOffTime;
        [NMS(Index = 343)]
        /* 0x1754 */ public float RocketBootsBoostOnTime;
        [NMS(Index = 341)]
        /* 0x1758 */ public float RocketBootsBoostTankDrainSpeed;
        [NMS(Index = 329)]
        /* 0x175C */ public float RocketBootsDoubleTapTime;
        [NMS(Index = 350)]
        /* 0x1760 */ public float RocketBootsDriftBraking;
        [NMS(Index = 351)]
        /* 0x1764 */ public float RocketBootsDriftDownwardForce;
        [NMS(Index = 348)]
        /* 0x1768 */ public float RocketBootsDriftEndTime;
        [NMS(Index = 332)]
        /* 0x176C */ public float RocketBootsDriftForce;
        [NMS(Index = 342)]
        /* 0x1770 */ public float RocketBootsDriftTankDrainSpeed;
        [NMS(Index = 334)]
        /* 0x1774 */ public float RocketBootsForceDuration;
        [NMS(Index = 333)]
        /* 0x1778 */ public float RocketBootsForceStartTime;
        [NMS(Index = 339)]
        /* 0x177C */ public float RocketBootsHeightAdjustDownStrength;
        [NMS(Index = 337)]
        /* 0x1780 */ public float RocketBootsHeightAdjustTime;
        [NMS(Index = 338)]
        /* 0x1784 */ public float RocketBootsHeightAdjustUpStrength;
        [NMS(Index = 330)]
        /* 0x1788 */ public float RocketBootsImpulse;
        [NMS(Index = 340)]
        /* 0x178C */ public float RocketBootsJetpackMinLevel;
        [NMS(Index = 336)]
        /* 0x1790 */ public float RocketBootsMaxDesiredHeight;
        [NMS(Index = 347)]
        /* 0x1794 */ public float RocketBootsMaxSpeed;
        [NMS(Index = 335)]
        /* 0x1798 */ public float RocketBootsMinDesiredHeight;
        [NMS(Index = 349)]
        /* 0x179C */ public float RocketBootsWindUpBraking;
        [NMS(Index = 346)]
        /* 0x17A0 */ public float RocketBootsZigZagForceDuration;
        [NMS(Index = 345)]
        /* 0x17A4 */ public float RocketBootsZigZagStrength;
        [NMS(Index = 585)]
        /* 0x17A8 */ public float ScanBeamMainWidth;
        [NMS(Index = 583)]
        /* 0x17AC */ public float ScanBeamWidth;
        [NMS(Index = 581)]
        /* 0x17B0 */ public float ScanFadeInTime;
        [NMS(Index = 582)]
        /* 0x17B4 */ public float ScanFadeOutTime;
        [NMS(Index = 573)]
        /* 0x17B8 */ public float ScanLabelTime;
        [NMS(Index = 578)]
        /* 0x17BC */ public float ScanRotate;
        [NMS(Index = 584)]
        /* 0x17C0 */ public float ScanRotateBeamWdith;
        [NMS(Index = 579)]
        /* 0x17C4 */ public float ScanRotateDist;
        [NMS(Index = 580)]
        /* 0x17C8 */ public float ScanRotateWobbleAmp;
        [NMS(Index = 575)]
        /* 0x17CC */ public float ScanWobbleAmp;
        [NMS(Index = 577)]
        /* 0x17D0 */ public float ScanWobbleAmp2;
        [NMS(Index = 574)]
        /* 0x17D4 */ public float ScanWobbleFreq;
        [NMS(Index = 576)]
        /* 0x17D8 */ public float ScanWobbleFreq2;
        [NMS(Index = 846)]
        /* 0x17DC */ public int ShieldMaximum;
        [NMS(Index = 523)]
        /* 0x17E0 */ public float ShieldRechargeMinTimeSinceDamage;
        [NMS(Index = 524)]
        /* 0x17E4 */ public float ShieldRechargeRate;
        [NMS(Index = 848)]
        /* 0x17E8 */ public float ShieldRestoreDelay;
        [NMS(Index = 847)]
        /* 0x17EC */ public float ShieldRestoreSpeed;
        [NMS(Index = 844)]
        /* 0x17F0 */ public float ShipCameraLag;
        [NMS(Index = 415)]
        /* 0x17F4 */ public float ShipCoolFactor;
        [NMS(Index = 412)]
        /* 0x17F8 */ public float ShipPriceExp2;
        [NMS(Index = 218)]
        /* 0x17FC */ public float ShipSummonLastSafeMargin;
        [NMS(Index = 769)]
        /* 0x1800 */ public float ShootOffset;
        [NMS(Index = 770)]
        /* 0x1804 */ public float ShootPrepTime;
        [NMS(Index = 768)]
        /* 0x1808 */ public float ShootSizeBase;
        [NMS(Index = 766)]
        /* 0x180C */ public float ShootSizeMaxXY;
        [NMS(Index = 764)]
        /* 0x1810 */ public float ShootSizeMaxZ;
        [NMS(Index = 765)]
        /* 0x1814 */ public float ShootSizeMinXY;
        [NMS(Index = 763)]
        /* 0x1818 */ public float ShootSizeMinZ;
        [NMS(Index = 767)]
        /* 0x181C */ public float ShootSizeTime;
        [NMS(Index = 627)]
        /* 0x1820 */ public float ShotgunDispersion;
        [NMS(Index = 569)]
        /* 0x1824 */ public float SleepFadeTime;
        [NMS(Index = 812)]
        /* 0x1828 */ public float SlopeSlideBrake;
        [NMS(Index = 811)]
        /* 0x182C */ public float SlopeSlidingSpeed;
        [NMS(Index = 308)]
        /* 0x1830 */ public float SolarRegenFactor;
        [NMS(Index = 380)]
        /* 0x1834 */ public float SpaceJetpackDrainRate;
        [NMS(Index = 376)]
        /* 0x1838 */ public float SpaceJetpackForce;
        [NMS(Index = 378)]
        /* 0x183C */ public float SpaceJetpackIgnitionForce;
        [NMS(Index = 379)]
        /* 0x1840 */ public float SpaceJetpackMaxSpeed;
        [NMS(Index = 377)]
        /* 0x1844 */ public float SpaceJetpackUpForce;
        [NMS(Index = 760)]
        /* 0x1848 */ public float SpaceMaxGravityDist;
        [NMS(Index = 761)]
        /* 0x184C */ public float SpaceMinGravityDist;
        [NMS(Index = 227)]
        /* 0x1850 */ public float SpawningDistanceBetweenPlayersAfterWarp;
        [NMS(Index = 228)]
        /* 0x1854 */ public float SpawningSpaceBattleLookOffset;
        [NMS(Index = 229)]
        /* 0x1858 */ public float SpawningSpaceBattleLookOffsetUp;
        [NMS(Index = 558)]
        /* 0x185C */ public float SpeedLinesLength;
        [NMS(Index = 567)]
        /* 0x1860 */ public float SpeedLinesMaxAlpha;
        [NMS(Index = 566)]
        /* 0x1864 */ public float SpeedLinesMinAlpha;
        [NMS(Index = 568)]
        /* 0x1868 */ public float SpeedLinesOffset;
        [NMS(Index = 564)]
        /* 0x186C */ public float SpeedLinesRadiusIncrement;
        [NMS(Index = 563)]
        /* 0x1870 */ public float SpeedLinesRadiusStartMax;
        [NMS(Index = 562)]
        /* 0x1874 */ public float SpeedLinesRadiusStartMin;
        [NMS(Index = 557)]
        /* 0x1878 */ public float SpeedLinesSpeedMax;
        [NMS(Index = 556)]
        /* 0x187C */ public float SpeedLinesSpeedMin;
        [NMS(Index = 565)]
        /* 0x1880 */ public float SpeedLinesStartFade;
        [NMS(Index = 559)]
        /* 0x1884 */ public float SpeedLinesTotalLength;
        [NMS(Index = 561)]
        /* 0x1888 */ public float SpeedLinesWidthMax;
        [NMS(Index = 560)]
        /* 0x188C */ public float SpeedLinesWidthMin;
        [NMS(Index = 570)]
        /* 0x1890 */ public float StaminaRate;
        [NMS(Index = 572)]
        /* 0x1894 */ public float StaminaRecoveredFactor;
        [NMS(Index = 571)]
        /* 0x1898 */ public float StaminaRecoveryRate;
        [NMS(Index = 554)]
        /* 0x189C */ public float StarFieldDensity;
        [NMS(Index = 553)]
        /* 0x18A0 */ public float StarFieldRadius;
        [NMS(Index = 555)]
        /* 0x18A4 */ public float StarFieldStarSize;
        [NMS(Index = 389)]
        /* 0x18A8 */ public float StartHazardTimeMultiplier;
        [NMS(Index = 390)]
        /* 0x18AC */ public float StartSpookTimeMultiplier;
        [NMS(Index = 355)]
        /* 0x18B0 */ public int StealthBaseCharge;
        [NMS(Index = 353)]
        /* 0x18B4 */ public float StealthDrainRate;
        [NMS(Index = 352)]
        /* 0x18B8 */ public float StealthMinLevel;
        [NMS(Index = 354)]
        /* 0x18BC */ public float StealthRechargeRate;
        [NMS(Index = 704)]
        /* 0x18C0 */ public float StickDeadZoneMax;
        [NMS(Index = 703)]
        /* 0x18C4 */ public float StickDeadZoneMin;
        [NMS(Index = 88)]
        /* 0x18C8 */ public float StickYDampingThreshold;
        [NMS(Index = 467)]
        /* 0x18CC */ public int SuitInventoryStartSeed;
        [NMS(Index = 23)]
        /* 0x18D0 */ public float SummonArcRange;
        [NMS(Index = 118)]
        /* 0x18D4 */ public float SummonShipDirectionChangeDeadZoneAngle;
        [NMS(Index = 778)]
        /* 0x18D8 */ public float TakeDamageImpulse;
        [NMS(Index = 789)]
        /* 0x18DC */ public float TargetDistance;
        [NMS(Index = 790)]
        /* 0x18E0 */ public float TargetRadius;
        [NMS(Index = 11)]
        /* 0x18E4 */ public float TeleportAppearEffectSpeed;
        [NMS(Index = 128)]
        /* 0x18E8 */ public float TeleportArcLengthMultiplier;
        [NMS(Index = 119)]
        /* 0x18EC */ public float TeleportArcRadius;
        [NMS(Index = 120)]
        /* 0x18F0 */ public float TeleportArcRadiusInner;
        [NMS(Index = 59)]
        /* 0x18F4 */ public float TeleportBallCompletionFactorFadeout;
        [NMS(Index = 56)]
        /* 0x18F8 */ public float TeleportBallDistanceFadeAlpha;
        [NMS(Index = 54)]
        /* 0x18FC */ public float TeleportBallFadeMinDistance;
        [NMS(Index = 55)]
        /* 0x1900 */ public float TeleportBallFadeRange;
        [NMS(Index = 57)]
        /* 0x1904 */ public float TeleportBallRadius;
        [NMS(Index = 130)]
        /* 0x1908 */ public float TeleportBeamAnimHeight;
        [NMS(Index = 129)]
        /* 0x190C */ public float TeleportBeamAnimSpeed;
        [NMS(Index = 126)]
        /* 0x1910 */ public float TeleportBeamGravity;
        [NMS(Index = 127)]
        /* 0x1914 */ public float TeleportBeamGravityMax;
        [NMS(Index = 53)]
        /* 0x1918 */ public float TeleportChargeFadeInTime;
        [NMS(Index = 50)]
        /* 0x191C */ public float TeleportChargeMaxDistance;
        [NMS(Index = 49)]
        /* 0x1920 */ public float TeleportChargeMinDistance;
        [NMS(Index = 52)]
        /* 0x1924 */ public float TeleportChargeMinTime;
        [NMS(Index = 51)]
        /* 0x1928 */ public float TeleportChargeMoveSpeed;
        [NMS(Index = 168)]
        /* 0x192C */ public float TeleportDirectionAltHandRange;
        [NMS(Index = 12)]
        /* 0x1930 */ public float TeleportDisappearEffectSpeed;
        [NMS(Index = 124)]
        /* 0x1934 */ public float TeleportHmdMaxFade;
        [NMS(Index = 123)]
        /* 0x1938 */ public float TeleportHmdMinFade;
        [NMS(Index = 125)]
        /* 0x193C */ public float TeleportHmdOutFactor;
        [NMS(Index = 136)]
        /* 0x1940 */ public float TeleportInitiateThreshold;
        [NMS(Index = 167)]
        /* 0x1944 */ public float TeleportInstantTravelDistance;
        [NMS(Index = 131)]
        /* 0x1948 */ public float TeleportLastKnownThreshold;
        [NMS(Index = 139)]
        /* 0x194C */ public float TeleportLineBezierDistanceFactor;
        [NMS(Index = 138)]
        /* 0x1950 */ public float TeleportLineBezierOffset;
        [NMS(Index = 133)]
        /* 0x1954 */ public float TeleportLineEndFadeEnd;
        [NMS(Index = 132)]
        /* 0x1958 */ public float TeleportLineEndFadeStart;
        [NMS(Index = 135)]
        /* 0x195C */ public float TeleportLineFadeRange;
        [NMS(Index = 134)]
        /* 0x1960 */ public float TeleportLineFadeStart;
        [NMS(Index = 47)]
        /* 0x1964 */ public float TeleportMaxTravelDistance;
        [NMS(Index = 48)]
        /* 0x1968 */ public float TeleportMaxTravelDistanceVertical;
        [NMS(Index = 169)]
        /* 0x196C */ public float TeleportMotionOffsetAmount;
        [NMS(Index = 170)]
        /* 0x1970 */ public float TeleportMotionOffsetUp;
        [NMS(Index = 121)]
        /* 0x1974 */ public float TeleportStrafeDistance;
        [NMS(Index = 171)]
        /* 0x1978 */ public float TeleportTotalTime;
        [NMS(Index = 58)]
        /* 0x197C */ public float TeleportTravelSurfaceAngle;
        [NMS(Index = 551)]
        /* 0x1980 */ public float TemperatureDisplaySampleTime;
        [NMS(Index = 890)]
        /* 0x1984 */ public float TerrainLaserRange;
        [NMS(Index = 622)]
        /* 0x1988 */ public float ThirdPersonRecoilMultiplier;
        [NMS(Index = 21)]
        /* 0x198C */ public float ThirdPersonWeaponAttachRotationCorrectionAngle;
        [NMS(Index = 22)]
        /* 0x1990 */ public float ThirdPersonWeaponXOffset;
        [NMS(Index = 849)]
        /* 0x1994 */ public float TimeHoldDownAccelerateToLaunchFromOutpost;
        [NMS(Index = 238)]
        /* 0x1998 */ public float TrackArrowStaticTargetOffsetMultiplier;
        [NMS(Index = 496)]
        /* 0x199C */ public float TraderApproachDistance;
        [NMS(Index = 494)]
        /* 0x19A0 */ public float TraderApproachTime;
        [NMS(Index = 510)]
        /* 0x19A4 */ public int TraderCommunicationBanMaxTime;
        [NMS(Index = 509)]
        /* 0x19A8 */ public int TraderCommunicationBanMinTime;
        [NMS(Index = 495)]
        /* 0x19AC */ public float TraderHailDistance;
        [NMS(Index = 493)]
        /* 0x19B0 */ public float TraderHailTime;
        [NMS(Index = 508)]
        /* 0x19B4 */ public float TraderHealthFightThreshold;
        [NMS(Index = 497)]
        /* 0x19B8 */ public float TraderSpamTimeWait;
        [NMS(Index = 498)]
        /* 0x19BC */ public float TraderStayCloseLockOffset;
        [NMS(Index = 499)]
        /* 0x19C0 */ public float TraderStayCloseLockSin1Coeff;
        [NMS(Index = 500)]
        /* 0x19C4 */ public float TraderStayCloseLockSin1Offset;
        [NMS(Index = 501)]
        /* 0x19C8 */ public float TraderStayCloseLockSin2Coeff;
        [NMS(Index = 502)]
        /* 0x19CC */ public float TraderStayCloseLockSin2Offset;
        [NMS(Index = 503)]
        /* 0x19D0 */ public float TraderStayCloseLockSinsAdd;
        [NMS(Index = 504)]
        /* 0x19D4 */ public float TraderStayCloseLockSpread;
        [NMS(Index = 505)]
        /* 0x19D8 */ public float TraderStayCloseLockSpreadAdd;
        [NMS(Index = 506)]
        /* 0x19DC */ public float TraderStayCloseLockSpreadTime;
        [NMS(Index = 200)]
        /* 0x19E0 */ public float UnderwaterBrake;
        [NMS(Index = 201)]
        /* 0x19E4 */ public float UnderwaterFloat;
        [NMS(Index = 202)]
        /* 0x19E8 */ public float UnderwaterFloatForce;
        [NMS(Index = 204)]
        /* 0x19EC */ public float UnderwaterFloatFreq;
        [NMS(Index = 203)]
        /* 0x19F0 */ public float UnderwaterFloatRange;
        [NMS(Index = 195)]
        /* 0x19F4 */ public float UnderwaterForce;
        [NMS(Index = 193)]
        /* 0x19F8 */ public float UnderwaterImpact;
        [NMS(Index = 199)]
        /* 0x19FC */ public float UnderwaterJetpackEscapeForce;
        [NMS(Index = 197)]
        /* 0x1A00 */ public float UnderwaterJetpackForce;
        [NMS(Index = 187)]
        /* 0x1A04 */ public float UnderwaterMargin;
        [NMS(Index = 198)]
        /* 0x1A08 */ public float UnderwaterMaxJetpackEscapeSpeed;
        [NMS(Index = 196)]
        /* 0x1A0C */ public float UnderwaterMaxJetpackSpeed;
        [NMS(Index = 194)]
        /* 0x1A10 */ public float UnderwaterMaxSpeed;
        [NMS(Index = 188)]
        /* 0x1A14 */ public float UnderwaterMinDepth;
        [NMS(Index = 191)]
        /* 0x1A18 */ public float UnderwaterSurfaceForceFlattenAngleMin;
        [NMS(Index = 192)]
        /* 0x1A1C */ public float UnderwaterSurfaceForceFlattenAngleRange;
        [NMS(Index = 189)]
        /* 0x1A20 */ public float UnderwaterSurfaceTension;
        [NMS(Index = 190)]
        /* 0x1A24 */ public float UnderwaterSurfaceTensionOffset;
        [NMS(Index = 401)]
        /* 0x1A28 */ public float VehicleHazardDampingModifier;
        [NMS(Index = 891)]
        /* 0x1A2C */ public float VehicleLaserRange;
        [NMS(Index = 245)]
        /* 0x1A30 */ public float VehicleRaceResultsHintTime;
        [NMS(Index = 386)]
        /* 0x1A34 */ public float VRModeHazardTimeMultiplier;
        [NMS(Index = 387)]
        /* 0x1A38 */ public float VRStartHazardTimeMultiplier;
        [NMS(Index = 459)]
        /* 0x1A3C */ public float WalkerAlertRange;
        [NMS(Index = 461)]
        /* 0x1A40 */ public float WalkerSightAngle;
        [NMS(Index = 460)]
        /* 0x1A44 */ public float WalkerSightRange;
        [NMS(Index = 586)]
        /* 0x1A48 */ public float WantedDroneEventRadius;
        [NMS(Index = 701)]
        /* 0x1A4C */ public float WantedEnemyAttackAmount;
        [NMS(Index = 589)]
        /* 0x1A50 */ public float WantedLevelDelay;
        [NMS(Index = 247)]
        /* 0x1A54 */ public float WantedLevelPlayerRange;
        [NMS(Index = 248)]
        /* 0x1A58 */ public float WantedLevelPlayerRangeSpace;
        [NMS(Index = 592)]
        /* 0x1A5C */ public float WantedMinorCrimeAmount;
        [NMS(Index = 588)]
        /* 0x1A60 */ public float WantedMinPlanetTime;
        [NMS(Index = 587)]
        /* 0x1A64 */ public float WantedMinSpaceTime;
        [NMS(Index = 593)]
        /* 0x1A68 */ public float WantedTimeoutAggressive;
        [NMS(Index = 591)]
        /* 0x1A6C */ public float WantedWitnessFuzzyTime;
        [NMS(Index = 590)]
        /* 0x1A70 */ public float WantedWitnessTimer;
        [NMS(Index = 750)]
        /* 0x1A74 */ public float WeaponBobBlendTime;
        [NMS(Index = 749)]
        /* 0x1A78 */ public float WeaponBobFactorRun;
        [NMS(Index = 748)]
        /* 0x1A7C */ public float WeaponBobFactorWalk;
        [NMS(Index = 747)]
        /* 0x1A80 */ public float WeaponBobFactorWalkDeadZone;
        [NMS(Index = 753)]
        /* 0x1A84 */ public float WeaponCannonMinUnchargedShotThreshold;
        [NMS(Index = 754)]
        /* 0x1A88 */ public float WeaponCannonMinUnchargedShotTime;
        [NMS(Index = 752)]
        /* 0x1A8C */ public float WeaponCannonMinWeaponTimer;
        [NMS(Index = 741)]
        /* 0x1A90 */ public float WeaponChangeModeTime;
        [NMS(Index = 416)]
        /* 0x1A94 */ public float WeaponCoolFactor;
        [NMS(Index = 755)]
        /* 0x1A98 */ public float WeaponGrenadeTime;
        [NMS(Index = 756)]
        /* 0x1A9C */ public float WeaponGunTime;
        [NMS(Index = 745)]
        /* 0x1AA0 */ public float WeaponHolsterDelay;
        [NMS(Index = 746)]
        /* 0x1AA4 */ public float WeaponLag;
        [NMS(Index = 744)]
        /* 0x1AA8 */ public float WeaponLowerDelay;
        [NMS(Index = 413)]
        /* 0x1AAC */ public float WeaponPriceExp2;
        [NMS(Index = 757)]
        /* 0x1AB0 */ public float WeaponRailFireTime;
        [NMS(Index = 758)]
        /* 0x1AB4 */ public float WeaponRailRechargeTime;
        [NMS(Index = 296)]
        /* 0x1AB8 */ public float WeaponShotgunSlowdown;
        [NMS(Index = 268)]
        /* 0x1ABC */ public float WeaponZoomFOV;
        [NMS(Index = 273)]
        /* 0x1AC0 */ public float WeaponZoomHorzRotation;
        [NMS(Index = 271)]
        /* 0x1AC4 */ public float WeaponZoomRecoilMultiplier;
        [NMS(Index = 272)]
        /* 0x1AC8 */ public float WeaponZoomVertRotation;
        [NMS(Index = 528)]
        /* 0x1ACC */ public float WitnessAIDamageAngle;
        [NMS(Index = 527)]
        /* 0x1AD0 */ public float WitnessAIDamageDistance;
        [NMS(Index = 240)]
        /* 0x1AD4 */ public float WitnessSenseEnhancement;
        [NMS(Index = 239)]
        /* 0x1AD8 */ public float WitnessSenseEnhancementTime;
        [NMS(Index = 150)]
        /* 0x1ADC */ public int WordCategoriesRequiredToConverse;
        [NMS(Index = 456)]
        /* 0x1AE0 */ public float WoundDamageDecayTime;
        [NMS(Index = 454)]
        /* 0x1AE4 */ public float WoundDamageLimit;
        [NMS(Index = 455)]
        /* 0x1AE8 */ public float WoundDamageLimitShip;
        [NMS(Index = 453)]
        /* 0x1AEC */ public float WoundTimeMinimum;
        [NMS(Index = 661)]
        /* 0x1AF0 */ public TkCurveType AimDisperseCurve;
        [NMS(Index = 638)]
        /* 0x1AF1 */ public bool AutoAim;
        [NMS(Index = 649)]
        /* 0x1AF2 */ public TkCurveType AutoAimCentreOffsetCurve;
        [NMS(Index = 648)]
        /* 0x1AF3 */ public TkCurveType AutoAimDotCurve;
        [NMS(Index = 625)]
        /* 0x1AF4 */ public bool BoltcasterHasTracer;
        [NMS(Index = 382)]
        /* 0x1AF5 */ public bool ClampPitch;
        [NMS(Index = 222)]
        /* 0x1AF6 */ public bool CreatureRideFade;
        [NMS(Index = 87)]
        /* 0x1AF7 */ public bool DoPlayerAppearInVehicleEffect;
        [NMS(Index = 381)]
        /* 0x1AF8 */ public bool EnableHeadMovements;
        [NMS(Index = 98)]
        /* 0x1AF9 */ public bool EnableLeaning;
        [NMS(Index = 99)]
        /* 0x1AFA */ public bool EnablePointDownToSmoothMove;
        [NMS(Index = 265)]
        /* 0x1AFB */ public bool FireButtonReloadsWeapon;
        [NMS(Index = 3)]
        /* 0x1AFC */ public bool ForceFreighterProcTechRandom;
        [NMS(Index = 274)]
        /* 0x1AFD */ public bool FrontShieldEnabled;
        [NMS(Index = 163)]
        /* 0x1AFE */ public bool HandSwimEnabled;
        [NMS(Index = 443)]
        /* 0x1AFF */ public bool HideHazardPanel;
        [NMS(Index = 100)]
        /* 0x1B00 */ public bool HmdSmoothTurnAlways;
        [NMS(Index = 92)]
        /* 0x1B01 */ public bool InteractNearbyRadiusEnabled;
        [NMS(Index = 444)]
        /* 0x1B02 */ public bool InventoryDamage;
        [NMS(Index = 448)]
        /* 0x1B03 */ public bool LuckyWithTech;
        [NMS(Index = 418)]
        /* 0x1B04 */ public bool MouseCrosshairVisible;
        [NMS(Index = 436)]
        /* 0x1B05 */ public TkCurveType MouseFlightCurve;
        [NMS(Index = 230)]
        /* 0x1B06 */ public bool MultiplayerShareWanted;
        [NMS(Index = 445)]
        /* 0x1B07 */ public bool NeverPreyedOn;
        [NMS(Index = 94)]
        /* 0x1B08 */ public bool PassiveLook;
        [NMS(Index = 447)]
        /* 0x1B09 */ public bool PermanantAltFire;
        [NMS(Index = 446)]
        /* 0x1B0A */ public bool PermanantFire;
        [NMS(Index = 15)]
        /* 0x1B0B */ public bool RecenterViewWhenEnteringShip;
        [NMS(Index = 231)]
        /* 0x1B0C */ public bool ReportAllProjectileDamage;
        [NMS(Index = 89)]
        /* 0x1B0D */ public bool RequireHandsOnShipControls;
        [NMS(Index = 326)]
        /* 0x1B0E */ public bool RocketBootsEnabled;
        [NMS(Index = 327)]
        /* 0x1B0F */ public bool RocketBootsUseCustomCamera;
        [NMS(Index = 90)]
        /* 0x1B10 */ public bool ShowFirstPersonCharacterShadowPCVR;
        [NMS(Index = 91)]
        /* 0x1B11 */ public bool ShowFirstPersonCharacterShadowPSVR;
        [NMS(Index = 266)]
        /* 0x1B12 */ public bool ShowLowAmmoWarning;
        [NMS(Index = 705)]
        /* 0x1B13 */ public TkCurveType StickCurve;
        [NMS(Index = 137)]
        /* 0x1B14 */ public bool TeleportRecentre;
        [NMS(Index = 465)]
        /* 0x1B15 */ public bool UpgradeExosuitWithProduct;
        [NMS(Index = 441)]
        /* 0x1B16 */ public bool UseEnergy;
        [NMS(Index = 442)]
        /* 0x1B17 */ public bool UseHazardProtection;
        [NMS(Index = 236)]
        /* 0x1B18 */ public bool UseLargeHealthBar;
        [NMS(Index = 751)]
        /* 0x1B19 */ public TkCurveType WeaponBobBlendCurve;
        [NMS(Index = 267)]
        /* 0x1B1A */ public bool WeaponZoomEnabled;
    }
}
