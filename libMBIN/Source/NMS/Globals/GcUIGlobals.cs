using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x98B11D1B3D8B87C7, NameHash = 0x95C306B1A90F3E08)]
    public class GcUIGlobals : NMSTemplate
    {
        [NMS(Index = 1044)]
        /* 0x0000 */ public GcModelViewCollection ModelViews;
        [NMS(Index = 279)]
        /* 0x1C30 */ public TkModelRendererData LargeMultitoolThumbnailModelView;
        [NMS(Index = 278)]
        /* 0x1CE0 */ public TkModelRendererData MultitoolThumbnailModelView;
        [NMS(Index = 277)]
        /* 0x1D90 */ public TkModelRendererData PetThumbnailModelView;
        [NMS(Index = 450)]
        /* 0x1E40 */ public TkModelRendererData RepairBackpackCamera;
        [NMS(Index = 448)]
        /* 0x1EF0 */ public TkModelRendererData RepairCamera;
        [NMS(Index = 451)]
        /* 0x1FA0 */ public TkModelRendererData RepairShipCameraInWorld;
        [NMS(Index = 452)]
        /* 0x2050 */ public TkModelRendererData RepairShipCameraModelView;
        [NMS(Index = 453)]
        /* 0x2100 */ public TkModelRendererData RepairShipCameraVR;
        [NMS(Index = 449)]
        /* 0x21B0 */ public TkModelRendererData RepairWeaponCamera;
        [NMS(Index = 276)]
        /* 0x2260 */ public TkModelRendererData ShipThumbnailModelView;
        [NMS(Index = 1373)]
        /* 0x2310 */ public TkNGuiTreeViewTemplate FileBrowserTreeViewTemplate;
        [NMS(Index = 1372)]
        /* 0x2390 */ public TkNGuiTreeViewTemplate SceneInfoTreeViewTemplate;
        [NMS(Index = 1374)]
        /* 0x2410 */ public TkNGuiTreeViewTemplate SkeletonToolsTreeViewTemplate;
        [NMS(Index = 554)]
        /* 0x2490 */ public GcScanEffectData DebugEditorPreviewEffect;
        [NMS(Index = 636)]
        /* 0x24E0 */ public GcScanEffectData FreighterSummonScanEffect;
        [NMS(Index = 318)]
        /* 0x2530 */ public GcHUDEffectRewardData OSDEpicItemRewardEffect;
        [NMS(Index = 317)]
        /* 0x2580 */ public GcHUDEffectRewardData OSDRareItemRewardEffect;
        [NMS(Index = 541)]
        /* 0x25D0 */ public GcScanEffectData TargetDisplayScanEffect;
        [NMS(Index = 847, Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x2620 */ public Colour[] SystemHooverLEDColours;
        [NMS(Index = 848, Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x2660 */ public Colour[] SystemHooverStatusBarColours;
        [NMS(Index = 1231)]
        /* 0x26A0 */ public GcSpaceMapObjectData SpaceMapAtlasData;
        [NMS(Index = 1232)]
        /* 0x26D0 */ public GcSpaceMapObjectData SpaceMapBlackHoleData;
        [NMS(Index = 1234)]
        /* 0x2700 */ public GcSpaceMapObjectData SpaceMapFreighterData;
        [NMS(Index = 1227)]
        /* 0x2730 */ public GcSpaceMapObjectData SpaceMapMarkerData;
        [NMS(Index = 1230)]
        /* 0x2760 */ public GcSpaceMapObjectData SpaceMapNexusData;
        [NMS(Index = 1228)]
        /* 0x2790 */ public GcSpaceMapObjectData SpaceMapPlanetData;
        [NMS(Index = 1235)]
        /* 0x27C0 */ public GcSpaceMapObjectData SpaceMapPulseEncounterData;
        [NMS(Index = 1233)]
        /* 0x27F0 */ public GcSpaceMapObjectData SpaceMapShipData;
        [NMS(Index = 1229)]
        /* 0x2820 */ public GcSpaceMapObjectData SpaceMapStationData;
        [NMS(Index = 1305)]
        /* 0x2850 */ public Colour AltimeterBandColour1;
        [NMS(Index = 1306)]
        /* 0x2860 */ public Colour AltimeterBandColour2;
        [NMS(Index = 1307)]
        /* 0x2870 */ public Colour AltimeterColour1;
        [NMS(Index = 1308)]
        /* 0x2880 */ public Colour AltimeterColour2;
        [NMS(Index = 380)]
        /* 0x2890 */ public Colour BaseComplexityDangerColour;
        [NMS(Index = 378)]
        /* 0x28A0 */ public Colour BaseComplexityDefaultColour;
        [NMS(Index = 379)]
        /* 0x28B0 */ public Colour BaseComplexityWarningColour;
        [NMS(Index = 161)]
        /* 0x28C0 */ public Vector3f BinocularPanelLinePointOffset;
        [NMS(Index = 388)]
        /* 0x28D0 */ public Colour BuildMenuErrorTextColour;
        [NMS(Index = 390)]
        /* 0x28E0 */ public Colour BuildMenuErrorTextFlashColour;
        [NMS(Index = 389)]
        /* 0x28F0 */ public Colour BuildMenuErrorTextOutlineColour;
        [NMS(Index = 391)]
        /* 0x2900 */ public Colour BuildMenuErrorTextOutlineFlashColour;
        [NMS(Index = 392)]
        /* 0x2910 */ public Colour BuildMenuInfoTextColour;
        [NMS(Index = 393)]
        /* 0x2920 */ public Colour BuildMenuInfoTextOutlineColour;
        [NMS(Index = 386)]
        /* 0x2930 */ public Colour BuildMenuPassiveErrorTextColour;
        [NMS(Index = 387)]
        /* 0x2940 */ public Colour BuildMenuPassiveErrorTextOutlineColour;
        [NMS(Index = 1089)]
        /* 0x2950 */ public Colour ByteBeatArpGridActiveColour;
        [NMS(Index = 1088)]
        /* 0x2960 */ public Colour ByteBeatArpGridInactiveColour;
        [NMS(Index = 1091)]
        /* 0x2970 */ public Colour ByteBeatArpPipActiveColour;
        [NMS(Index = 1090)]
        /* 0x2980 */ public Colour ByteBeatArpPipInactiveColour;
        [NMS(Index = 1107)]
        /* 0x2990 */ public Colour ByteBeatRhythmColour0Active;
        [NMS(Index = 1108)]
        /* 0x29A0 */ public Colour ByteBeatRhythmColour0Inactive;
        [NMS(Index = 1109)]
        /* 0x29B0 */ public Colour ByteBeatRhythmColour1Active;
        [NMS(Index = 1110)]
        /* 0x29C0 */ public Colour ByteBeatRhythmColour1Inactive;
        [NMS(Index = 1111)]
        /* 0x29D0 */ public Colour ByteBeatRhythmColour2Active;
        [NMS(Index = 1112)]
        /* 0x29E0 */ public Colour ByteBeatRhythmColour2Inactive;
        [NMS(Index = 1103)]
        /* 0x29F0 */ public Colour ByteBeatSequencerBGColourActive;
        [NMS(Index = 1104)]
        /* 0x2A00 */ public Colour ByteBeatSequencerBGColourInactive;
        [NMS(Index = 1113)]
        /* 0x2A10 */ public Colour ByteBeatSequencerHighlightColour;
        [NMS(Index = 1105)]
        /* 0x2A20 */ public Colour ByteBeatSequencerRimColourActive;
        [NMS(Index = 1106)]
        /* 0x2A30 */ public Colour ByteBeatSequencerRimColourInactive;
        [NMS(Index = 1102)]
        /* 0x2A40 */ public Colour ByteBeatSequencerUnpoweredTint;
        [NMS(Index = 1118)]
        /* 0x2A50 */ public Colour ByteBeatSliderFGColour;
        [NMS(Index = 1119)]
        /* 0x2A60 */ public Colour ByteBeatSliderTextActiveColour;
        [NMS(Index = 1120)]
        /* 0x2A70 */ public Colour ByteBeatSliderTextInactiveColour;
        [NMS(Index = 1079)]
        /* 0x2A80 */ public Colour ByteBeatTreeLineColour;
        [NMS(Index = 1082)]
        /* 0x2A90 */ public Colour ByteBeatVisGridColour;
        [NMS(Index = 1081)]
        /* 0x2AA0 */ public Colour ByteBeatVisLineColour;
        [NMS(Index = 544)]
        /* 0x2AB0 */ public Colour CommunicatorMessageColour;
        [NMS(Index = 693)]
        /* 0x2AC0 */ public Colour CrosshairColour;
        [NMS(Index = 682)]
        /* 0x2AD0 */ public Colour CrosshairLeadPassiveColour;
        [NMS(Index = 681)]
        /* 0x2AE0 */ public Colour CrosshairLeadThreatColour;
        [NMS(Index = 1045)]
        /* 0x2AF0 */ public Colour CursorColour;
        [NMS(Index = 1046)]
        /* 0x2B00 */ public Colour CursorConfirmColour;
        [NMS(Index = 1048)]
        /* 0x2B10 */ public Colour CursorDeleteColour;
        [NMS(Index = 1047)]
        /* 0x2B20 */ public Colour CursorTransferUploadColour;
        [NMS(Index = 608)]
        /* 0x2B30 */ public Colour DamageNumberCriticalColour;
        [NMS(Index = 609)]
        /* 0x2B40 */ public Colour DamageNumberIneffectiveColour;
        [NMS(Index = 610)]
        /* 0x2B50 */ public Colour DamageNumberIneffectiveWarningColour;
        [NMS(Index = 917)]
        /* 0x2B60 */ public Colour DeathMessageColour;
        [NMS(Index = 273)]
        /* 0x2B70 */ public Colour DebugEditorAxisColourAtActive;
        [NMS(Index = 272)]
        /* 0x2B80 */ public Colour DebugEditorAxisColourAtInactive;
        [NMS(Index = 271)]
        /* 0x2B90 */ public Colour DebugEditorAxisColourRightActive;
        [NMS(Index = 270)]
        /* 0x2BA0 */ public Colour DebugEditorAxisColourRightInactive;
        [NMS(Index = 269)]
        /* 0x2BB0 */ public Colour DebugEditorAxisColourUpActive;
        [NMS(Index = 268)]
        /* 0x2BC0 */ public Colour DebugEditorAxisColourUpInactive;
        [NMS(Index = 466)]
        /* 0x2BD0 */ public Vector3f DefaultRefinerOffsetIn;
        [NMS(Index = 467)]
        /* 0x2BE0 */ public Vector3f DefaultRefinerOffsetOut;
        [NMS(Index = 1023)]
        /* 0x2BF0 */ public Colour EnergyBgColour;
        [NMS(Index = 1024)]
        /* 0x2C00 */ public Colour EnergyBgPulseColour;
        [NMS(Index = 192)]
        /* 0x2C10 */ public Vector3f FaceLockedScreenOffset;
        [NMS(Index = 637)]
        /* 0x2C20 */ public Colour FreighterSummonScanEffectColourBlocked;
        [NMS(Index = 638)]
        /* 0x2C30 */ public Colour FreighterSummonScanEffectColourHighlight;
        [NMS(Index = 280)]
        /* 0x2C40 */ public Colour FrontendCursorBackgroundColour;
        [NMS(Index = 613)]
        /* 0x2C50 */ public Colour FuelBgColour;
        [NMS(Index = 484)]
        /* 0x2C60 */ public Colour GridBackgroundNegativeColour;
        [NMS(Index = 482)]
        /* 0x2C70 */ public Colour GridBackgroundNeutralColour;
        [NMS(Index = 483)]
        /* 0x2C80 */ public Colour GridBackgroundPositiveColour;
        [NMS(Index = 479)]
        /* 0x2C90 */ public Colour GridDisconnectedColour;
        [NMS(Index = 481)]
        /* 0x2CA0 */ public Colour GridOfflineColour;
        [NMS(Index = 480)]
        /* 0x2CB0 */ public Colour GridOnlineColour;
        [NMS(Index = 1025)]
        /* 0x2CC0 */ public Colour HazardBgPulseColour;
        [NMS(Index = 1026)]
        /* 0x2CD0 */ public Colour HazardDamagePulseColour;
        [NMS(Index = 283)]
        /* 0x2CE0 */ public Vector3f HmdFramerateScreenOffset;
        [NMS(Index = 1246)]
        /* 0x2CF0 */ public Colour HUDMarkerColour;
        [NMS(Index = 844)]
        /* 0x2D00 */ public Colour HUDNotifyColour;
        [NMS(Index = 1250)]
        /* 0x2D10 */ public Colour HUDOutpostColour;
        [NMS(Index = 808)]
        /* 0x2D20 */ public Colour HUDPlayerTrackArrowDamageGlowHullHitMaxColour;
        [NMS(Index = 809)]
        /* 0x2D30 */ public Colour HUDPlayerTrackArrowDamageGlowHullHitMinColour;
        [NMS(Index = 812)]
        /* 0x2D40 */ public Colour HUDPlayerTrackArrowDamageGlowShieldHitMaxColour;
        [NMS(Index = 813)]
        /* 0x2D50 */ public Colour HUDPlayerTrackArrowDamageGlowShieldHitMinColour;
        [NMS(Index = 839)]
        /* 0x2D60 */ public Colour HUDPlayerTrackArrowDotColour;
        [NMS(Index = 841)]
        /* 0x2D70 */ public Colour HUDPlayerTrackArrowDotColourPirate;
        [NMS(Index = 840)]
        /* 0x2D80 */ public Colour HUDPlayerTrackArrowDotColourPolice;
        [NMS(Index = 842)]
        /* 0x2D90 */ public Colour HUDPlayerTrackArrowDotColourTrader;
        [NMS(Index = 800)]
        /* 0x2DA0 */ public Colour HUDPlayerTrackArrowEnergyShieldColour;
        [NMS(Index = 821)]
        /* 0x2DB0 */ public Colour HUDPlayerTrackArrowEnergyShieldDepletedGlowMaxColour;
        [NMS(Index = 822)]
        /* 0x2DC0 */ public Colour HUDPlayerTrackArrowEnergyShieldDepletedGlowMinColour;
        [NMS(Index = 801)]
        /* 0x2DD0 */ public Colour HUDPlayerTrackArrowEnergyShieldLowColour;
        [NMS(Index = 826)]
        /* 0x2DE0 */ public Colour HUDPlayerTrackArrowEnergyShieldStartChargeGlowMaxColour;
        [NMS(Index = 827)]
        /* 0x2DF0 */ public Colour HUDPlayerTrackArrowEnergyShieldStartChargeGlowMinColour;
        [NMS(Index = 797)]
        /* 0x2E00 */ public Colour HUDPlayerTrackArrowTextColour;
        [NMS(Index = 1248)]
        /* 0x2E10 */ public Colour HUDRelicMarkerColourDiscovered;
        [NMS(Index = 1249)]
        /* 0x2E20 */ public Colour HUDRelicMarkerColourUnknown;
        [NMS(Index = 1247)]
        /* 0x2E30 */ public Colour HUDSpaceshipColour;
        [NMS(Index = 843)]
        /* 0x2E40 */ public Colour HUDWarningColour;
        [NMS(Index = 399)]
        /* 0x2E50 */ public Colour IconGlowColourActive;
        [NMS(Index = 398)]
        /* 0x2E60 */ public Colour IconGlowColourError;
        [NMS(Index = 401)]
        /* 0x2E70 */ public Colour IconGlowColourHighlight;
        [NMS(Index = 400)]
        /* 0x2E80 */ public Colour IconGlowColourNeutral;
        [NMS(Index = 456)]
        /* 0x2E90 */ public Colour InteractionLabelCostColour;
        [NMS(Index = 457)]
        /* 0x2EA0 */ public Colour InteractionLabelPickupColour;
        [NMS(Index = 458)]
        /* 0x2EB0 */ public Colour InteractionLabelPickupFillColour;
        [NMS(Index = 61)]
        /* 0x2EC0 */ public Colour InvSlotGradientBaseColour;
        [NMS(Index = 127)]
        /* 0x2ED0 */ public Vector3f InWorldInteractLabelCentreOffset;
        [NMS(Index = 129)]
        /* 0x2EE0 */ public Vector3f InWorldInteractLabelLineOffset;
        [NMS(Index = 128)]
        /* 0x2EF0 */ public Vector3f InWorldInteractLabelTopOffset;
        [NMS(Index = 185)]
        /* 0x2F00 */ public Vector3f InWorldNGuiScreenRotation;
        [NMS(Index = 130)]
        /* 0x2F10 */ public Vector3f InWorldStaffBinocsScreenOffset;
        [NMS(Index = 951)]
        /* 0x2F20 */ public Colour ItemSlotColourPartiallyInstalled;
        [NMS(Index = 953)]
        /* 0x2F30 */ public Colour ItemSlotColourProduct;
        [NMS(Index = 947)]
        /* 0x2F40 */ public Colour ItemSlotColourSubstance;
        [NMS(Index = 948)]
        /* 0x2F50 */ public Colour ItemSlotColourTech;
        [NMS(Index = 949)]
        /* 0x2F60 */ public Colour ItemSlotColourTechCharge;
        [NMS(Index = 950)]
        /* 0x2F70 */ public Colour ItemSlotColourTechDamage;
        [NMS(Index = 956)]
        /* 0x2F80 */ public Colour ItemSlotTextColourProduct;
        [NMS(Index = 954)]
        /* 0x2F90 */ public Colour ItemSlotTextColourSubstance;
        [NMS(Index = 955)]
        /* 0x2FA0 */ public Colour ItemSlotTextColourTech;
        [NMS(Index = 60)]
        /* 0x2FB0 */ public Colour JoaoBoxCompletedObjectiveColour;
        [NMS(Index = 1311)]
        /* 0x2FC0 */ public Colour LockOnMarkerActiveColour;
        [NMS(Index = 181)]
        /* 0x2FD0 */ public Vector3f LowerHelmetScreenOffset;
        [NMS(Index = 432)]
        /* 0x2FE0 */ public Colour MarkerRingBGColour;
        [NMS(Index = 507)]
        /* 0x2FF0 */ public Colour MissionOSDMessageBarColour;
        [NMS(Index = 329)]
        /* 0x3000 */ public Colour MultiplayerMissionParticipantsColour;
        [NMS(Index = 43)]
        /* 0x3010 */ public Colour NetworkPopupTextDisabledColour;
        [NMS(Index = 42)]
        /* 0x3020 */ public Colour NetworkPopupTextEnabledColour;
        [NMS(Index = 1329)]
        /* 0x3030 */ public Vector3f NGuiModelTranslationFactors;
        [NMS(Index = 1330)]
        /* 0x3040 */ public Vector3f NGuiModelTranslationFactorsInteraction;
        [NMS(Index = 1331)]
        /* 0x3050 */ public Vector3f NGuiThumbnailModelTranslationFactors;
        [NMS(Index = 509)]
        /* 0x3060 */ public Colour NotificationDangerColour;
        [NMS(Index = 508)]
        /* 0x3070 */ public Colour NotificationDefaultColour;
        [NMS(Index = 510)]
        /* 0x3080 */ public Colour NotificationInfoColour;
        [NMS(Index = 511)]
        /* 0x3090 */ public Colour NotificationUrgentColour;
        [NMS(Index = 611)]
        /* 0x30A0 */ public Colour PhotoModeSelectedColour;
        [NMS(Index = 612)]
        /* 0x30B0 */ public Colour PhotoModeUnselectedColour;
        [NMS(Index = 328)]
        /* 0x30C0 */ public Colour PickedItemBorderColour;
        [NMS(Index = 918)]
        /* 0x30D0 */ public Colour PinnedRecipeBorder;
        [NMS(Index = 324)]
        /* 0x30E0 */ public Colour ProcProductColourCommon;
        [NMS(Index = 326)]
        /* 0x30F0 */ public Colour ProcProductColourRare;
        [NMS(Index = 325)]
        /* 0x3100 */ public Colour ProcProductColourUncommon;
        [NMS(Index = 786)]
        /* 0x3110 */ public Colour PulseAlertColour;
        [NMS(Index = 785)]
        /* 0x3120 */ public Colour PulseDamageColour;
        [NMS(Index = 274)]
        /* 0x3130 */ public Colour QuickMenuSelectedItemColour1;
        [NMS(Index = 275)]
        /* 0x3140 */ public Colour QuickMenuSelectedItemColour2;
        [NMS(Index = 1127)]
        /* 0x3150 */ public Colour RadialMenuInnerColourDisabled;
        [NMS(Index = 1123)]
        /* 0x3160 */ public Colour RadialMenuInnerColourSelected;
        [NMS(Index = 1125)]
        /* 0x3170 */ public Colour RadialMenuInnerColourUnselected;
        [NMS(Index = 1128)]
        /* 0x3180 */ public Colour RadialMenuOuterColourDisabled;
        [NMS(Index = 1124)]
        /* 0x3190 */ public Colour RadialMenuOuterColourSelected;
        [NMS(Index = 1126)]
        /* 0x31A0 */ public Colour RadialMenuOuterColourUnselected;
        [NMS(Index = 477)]
        /* 0x31B0 */ public Colour RefinerBackgroundColour;
        [NMS(Index = 478)]
        /* 0x31C0 */ public Colour RefinerErrorBackgroundColour;
        [NMS(Index = 699)]
        /* 0x31D0 */ public Colour RemappedControlColour;
        [NMS(Index = 698)]
        /* 0x31E0 */ public Colour SelectedControlColour;
        [NMS(Index = 1378)]
        /* 0x31F0 */ public Colour SettlementStatBackgroundColour;
        [NMS(Index = 1377)]
        /* 0x3200 */ public Colour SettlementStatColour;
        [NMS(Index = 1029)]
        /* 0x3210 */ public Colour ShieldBgColour;
        [NMS(Index = 1027)]
        /* 0x3220 */ public Colour ShieldColour;
        [NMS(Index = 1030)]
        /* 0x3230 */ public Colour ShieldDamageBgColour;
        [NMS(Index = 1028)]
        /* 0x3240 */ public Colour ShieldDamageColour;
        [NMS(Index = 13)]
        /* 0x3250 */ public Colour ShipBuilderLineColour;
        [NMS(Index = 12)]
        /* 0x3260 */ public Colour ShipBuilderLineColourHologram;
        [NMS(Index = 981)]
        /* 0x3270 */ public Colour ShipHUDAimTargetColour;
        [NMS(Index = 982)]
        /* 0x3280 */ public Colour ShipHUDAimTargetCritColour;
        [NMS(Index = 979)]
        /* 0x3290 */ public Colour ShipHUDTargetArrowsColourLocal;
        [NMS(Index = 977)]
        /* 0x32A0 */ public Colour ShipHUDTargetArrowsColourOutOfRange;
        [NMS(Index = 978)]
        /* 0x32B0 */ public Colour ShipHUDTargetArrowsColourThreat;
        [NMS(Index = 1219)]
        /* 0x32C0 */ public Colour SpaceEnemyShipLineColour;
        [NMS(Index = 1218)]
        /* 0x32D0 */ public Colour SpaceFriendlyShipLineColour;
        [NMS(Index = 1221)]
        /* 0x32E0 */ public Colour SpaceMapAttackColour;
        [NMS(Index = 524)]
        /* 0x32F0 */ public Vector3f SpaceMapCockpitOffset;
        [NMS(Index = 1226)]
        /* 0x3300 */ public Colour SpaceMapDeathPointColour;
        [NMS(Index = 1224)]
        /* 0x3310 */ public Colour SpaceMapNeutralColour;
        [NMS(Index = 1222)]
        /* 0x3320 */ public Colour SpaceMapOtherPlayerColour;
        [NMS(Index = 1220)]
        /* 0x3330 */ public Vector3f SpaceMapPosScaler;
        [NMS(Index = 1225)]
        /* 0x3340 */ public Colour SpaceMapSquadronColour;
        [NMS(Index = 1223)]
        /* 0x3350 */ public Colour SpaceMapThreatColour;
        [NMS(Index = 19)]
        /* 0x3360 */ public Colour StoreDialFillColour;
        [NMS(Index = 66)]
        /* 0x3370 */ public Colour SuperchargeGradientBaseColour;
        [NMS(Index = 67)]
        /* 0x3380 */ public Colour SuperchargeGradientBlendColour;
        [NMS(Index = 68)]
        /* 0x3390 */ public Colour SuperchargeGradientTechColour;
        [NMS(Index = 65)]
        /* 0x33A0 */ public Colour SuperchargePopupColour;
        [NMS(Index = 538)]
        /* 0x33B0 */ public Vector3f TargetDisplayShipOffset;
        [NMS(Index = 539)]
        /* 0x33C0 */ public Vector3f TargetDisplayTorpedoOffset;
        [NMS(Index = 1156)]
        /* 0x33D0 */ public Colour TargetMarkerColour;
        [NMS(Index = 1157)]
        /* 0x33E0 */ public Colour TargetMarkerHighlightColour;
        [NMS(Index = 485)]
        /* 0x33F0 */ public Colour TransferSendPopupColour;
        [NMS(Index = 303)]
        /* 0x3400 */ public Colour TravelLineColour;
        [NMS(Index = 306)]
        /* 0x3410 */ public Colour TravelLineInvalidColour;
        [NMS(Index = 307)]
        /* 0x3420 */ public Colour TravelLineNotAllowedColour;
        [NMS(Index = 304)]
        /* 0x3430 */ public Colour TravelLineTooFarColour;
        [NMS(Index = 305)]
        /* 0x3440 */ public Colour TravelLineTooSteepColour;
        [NMS(Index = 308)]
        /* 0x3450 */ public Colour TravelTargetColour;
        [NMS(Index = 1166)]
        /* 0x3460 */ public Colour UnseenItemColour;
        [NMS(Index = 1165)]
        /* 0x3470 */ public Colour WantedColour;
        [NMS(Index = 34)]
        /* 0x3480 */ public Colour WristMenuDefaultBorderColour;
        [NMS(Index = 35)]
        /* 0x3490 */ public Colour WristMenuRepositionableBorderColour;
        [NMS(Index = 53, Size = 0xF, EnumType = typeof(GcWonderCreatureCategory.WonderCreatureCategoryEnum))]
        /* 0x34A0 */ public GcWonderCategoryConfig[] WonderCreatureCategoryConfig;
        [NMS(Index = 56, Size = 0xD, EnumType = typeof(GcWonderTreasureCategory.WonderTreasureCategoryEnum))]
        /* 0x37E8 */ public GcWonderCategoryConfig[] WonderTreasureCategoryConfig;
        [NMS(Index = 58, Size = 0xC, EnumType = typeof(GcWonderCustomCategory.WonderCustomCategoryEnum))]
        /* 0x3AC0 */ public GcWonderCategoryConfig[] WonderCustomCategoryConfig;
        [NMS(Index = 52, Size = 0xB, EnumType = typeof(GcWonderPlanetCategory.WonderPlanetCategoryEnum))]
        /* 0x3D60 */ public GcWonderCategoryConfig[] WonderPlanetCategoryConfig;
        [NMS(Index = 57, Size = 0xB, EnumType = typeof(GcWonderWeirdBasePartCategory.WonderWeirdBasePartCategoryEnum))]
        /* 0x3FC8 */ public GcWonderCategoryConfig[] WonderWeirdBasePartCategoryConfig;
        [NMS(Index = 383, Size = 0x10, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x4230 */ public NMSString0x20A[] BuildMenuOnActionDisabledLocIDs;
        [NMS(Index = 384, Size = 0x10, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x4430 */ public NMSString0x20A[] BuildMenuOnActionErrorLocIDs;
        [NMS(Index = 382, Size = 0x10, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x4630 */ public NMSString0x20A[] BuildMenuOnActionLocIDs;
        [NMS(Index = 54, Size = 0x8, EnumType = typeof(GcWonderFloraCategory.WonderFloraCategoryEnum))]
        /* 0x4830 */ public GcWonderCategoryConfig[] WonderFloraCategoryConfig;
        [NMS(Index = 55, Size = 0x8, EnumType = typeof(GcWonderMineralCategory.WonderMineralCategoryEnum))]
        /* 0x49F0 */ public GcWonderCategoryConfig[] WonderMineralCategoryConfig;
        [NMS(Index = 1347)]
        /* 0x4BB0 */ public GcHUDStartupTable IntroTiming;
        [NMS(Index = 1348)]
        /* 0x4D00 */ public GcHUDStartupTable IntroTimingFreighter;
        [NMS(Index = 1349)]
        /* 0x4E50 */ public GcHUDStartupTable IntroTimingFreighterRepaired;
        [NMS(Index = 1380, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4FA0 */ public NMSString0x20A[] SettlementStatFormatLoc;
        [NMS(Index = 1379, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x5080 */ public NMSString0x20A[] SettlementStatLoc;
        [NMS(Index = 75)]
        /* 0x5160 */ public NMSString0x10 DebugInventoryHint;
        [NMS(Index = 105)]
        /* 0x5170 */ public NMSString0x10 ExplorationLogMissionID;
        [NMS(Index = 1019)]
        /* 0x5180 */ public List<NMSString0x80> HazardHeightmaps;
        [NMS(Index = 1018)]
        /* 0x5190 */ public List<NMSString0x80> HazardNormalMaps;
        [NMS(Index = 1017)]
        /* 0x51A0 */ public List<NMSString0x80> HazardTextures;
        [NMS(Index = 327)]
        /* 0x51B0 */ public List<Vector2f> InventoryIconPositions;
        [NMS(Index = 331)]
        /* 0x51C0 */ public NMSString0x10 MultiplayerMissionInteractEndTrigger;
        [NMS(Index = 330)]
        /* 0x51D0 */ public NMSString0x10 MultiplayerMissionInteractStartTrigger;
        [NMS(Index = 93)]
        /* 0x51E0 */ public List<GcSeasonalRingArray> SeasonalRingTable;
        [NMS(Index = 980)]
        /* 0x51F0 */ public List<Colour> ShipHUDTargetArrowsColour;
        [NMS(Index = 790)]
        /* 0x5200 */ public NMSString0x10 ShowStatWithDeathQuote;
        [NMS(Index = 858)]
        /* 0x5210 */ public List<NMSString0x80> StatIcons;
        [NMS(Index = 454)]
        /* 0x5220 */ public List<TkModelRendererData> VehicleTypeRepairCamera;
        [NMS(Index = 1381, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x5230 */ public TkTextureResource[] SettlementStatBasicImages;
        [NMS(Index = 1383, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x55CC */ public TkTextureResource[] SettlementStatNegativeImages;
        [NMS(Index = 1382, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x5968 */ public TkTextureResource[] SettlementStatPositiveImages;
        [NMS(Index = 47, Size = 0x7, EnumType = typeof(GcWonderType.WonderTypeEnum))]
        /* 0x5D04 */ public TkTextureResource[] WonderTypeIcons;
        [NMS(Index = 427)]
        /* 0x60A0 */ public TkTextureResource BaseBuildingPartsGridExpandableIcon;
        [NMS(Index = 428)]
        /* 0x6124 */ public TkTextureResource BaseBuildingPartsGridExpandedIcon;
        [NMS(Index = 429)]
        /* 0x61A8 */ public TkTextureResource BaseBuildingPartsGridRetractableIcon;
        [NMS(Index = 461)]
        /* 0x622C */ public TkTextureResource RefinerPopupEmptyOutputIcon;
        [NMS(Index = 940)]
        /* 0x62B0 */ public GcWorldUISettings WorldUISettings;
        [NMS(Index = 690, Size = 0x13, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x6300 */ public float[] CrosshairTargetLockSizeSpecific;
        [NMS(Index = 49, Size = 0xF, EnumType = typeof(GcWonderCreatureCategory.WonderCreatureCategoryEnum))]
        /* 0x634C */ public float[] WonderValueModifiersCreature;
        [NMS(Index = 48, Size = 0xB, EnumType = typeof(GcWonderPlanetCategory.WonderPlanetCategoryEnum))]
        /* 0x6388 */ public float[] WonderValueModifiersPlanet;
        [NMS(Index = 50, Size = 0x8, EnumType = typeof(GcWonderFloraCategory.WonderFloraCategoryEnum))]
        /* 0x63B4 */ public float[] WonderValueModifiersFlora;
        [NMS(Index = 51, Size = 0x8, EnumType = typeof(GcWonderMineralCategory.WonderMineralCategoryEnum))]
        /* 0x63D4 */ public float[] WonderValueModifiersMineral;
        [NMS(Index = 1351)]
        /* 0x63F4 */ public GcInventorySlotActionData BuildProductSlotAction;
        [NMS(Index = 1352)]
        /* 0x6410 */ public GcInventorySlotActionData ChargeSlotAction;
        [NMS(Index = 1350)]
        /* 0x642C */ public GcInventorySlotActionData InstallTechSlotAction;
        [NMS(Index = 1356)]
        /* 0x6448 */ public GcInventorySlotActionData InventoryHintAction;
        [NMS(Index = 1357)]
        /* 0x6464 */ public GcInventorySlotActionData InventoryHintActionNoGlow;
        [NMS(Index = 1355)]
        /* 0x6480 */ public GcInventorySlotActionData NewSlotPulseAction;
        [NMS(Index = 1354)]
        /* 0x649C */ public GcInventorySlotActionData NewSlotRevealAction;
        [NMS(Index = 1353)]
        /* 0x64B8 */ public GcInventorySlotActionData RepairSlotAction;
        [NMS(Index = 783)]
        /* 0x64D4 */ public TkNGuiRectanglePulseEffect PulseBarData;
        [NMS(Index = 784)]
        /* 0x64E4 */ public TkNGuiRectanglePulseEffect PulseIconData;
        [NMS(Index = 694)]
        /* 0x64F4 */ public TkHitCurveData CrosshairLeadHitCurve;
        [NMS(Index = 1346)]
        /* 0x6500 */ public GcDiscoveryHelperTimings DiscoveryHelperTimings;
        [NMS(Index = 695)]
        /* 0x650C */ public TkHitCurveData ShootableHitCurve;
        [NMS(Index = 147)]
        /* 0x6518 */ public Vector2f BinocularEdgeFade;
        [NMS(Index = 455)]
        /* 0x6520 */ public Vector2f BinocularsDiscoveryPos;
        [NMS(Index = 360)]
        /* 0x6528 */ public Vector2f CompassCentre;
        [NMS(Index = 519)]
        /* 0x6530 */ public Vector2f CursorlessDialogPageCursorOffset;
        [NMS(Index = 603)]
        /* 0x6538 */ public Vector2f DamageNumberSideSpeed;
        [NMS(Index = 517)]
        /* 0x6540 */ public Vector2f DialogPageCursorOffset;
        [NMS(Index = 1252)]
        /* 0x6548 */ public Vector2f HUDMarkerCompassPrimaryIndicatorOffset;
        [NMS(Index = 1251)]
        /* 0x6550 */ public Vector2f HUDMarkerPrimaryIndicatorOffset;
        [NMS(Index = 470)]
        /* 0x6558 */ public Vector2f HUDPlayerSentinelPulseFreq;
        [NMS(Index = 471)]
        /* 0x6560 */ public Vector2f HUDPlayerSentinelPulseSize;
        [NMS(Index = 815)]
        /* 0x6568 */ public Vector2f HUDPlayerTrackArrowDamageGlowSize;
        [NMS(Index = 817)]
        /* 0x6570 */ public Vector2f HUDPlayerTrackArrowEnergyShieldGlowSize;
        [NMS(Index = 804)]
        /* 0x6578 */ public Vector2f HUDPlayerTrackArrowEnergyShieldSize;
        [NMS(Index = 799)]
        /* 0x6580 */ public Vector2f HUDPlayerTrackArrowHealthSize;
        [NMS(Index = 756)]
        /* 0x6588 */ public Vector2f HUDPlayerTrackArrowIconPulseSize;
        [NMS(Index = 768)]
        /* 0x6590 */ public Vector2f HUDPlayerTrackIconOffset;
        [NMS(Index = 1238)]
        /* 0x6598 */ public Vector2f HUDTargetHealthIconOffset;
        [NMS(Index = 1236)]
        /* 0x65A0 */ public Vector2f HUDTargetHealthOffset;
        [NMS(Index = 1237)]
        /* 0x65A8 */ public Vector2f HUDTargetHealthSize;
        [NMS(Index = 1035)]
        /* 0x65B0 */ public Vector2f InteractionLabelLineOffset;
        [NMS(Index = 1032)]
        /* 0x65B8 */ public Vector2f InteractionLabelOffset;
        [NMS(Index = 1033)]
        /* 0x65C0 */ public Vector2f InteractionLabelOffset_1;
        [NMS(Index = 1034)]
        /* 0x65C8 */ public Vector2f InteractionLabelSize;
        [NMS(Index = 1340)]
        /* 0x65D0 */ public Vector2f InteractionWorldParallax;
        [NMS(Index = 518)]
        /* 0x65D8 */ public Vector2f IntermediateInteractionPageCursorOffset;
        [NMS(Index = 187)]
        /* 0x65E0 */ public Vector2f InWorldGameGuiAlignment;
        [NMS(Index = 126)]
        /* 0x65E8 */ public Vector2f InWorldInteractLabelAlignment;
        [NMS(Index = 186)]
        /* 0x65F0 */ public Vector2f InWorldNGuiParallax;
        [NMS(Index = 177)]
        /* 0x65F8 */ public Vector2f MarkerDistanceVRAlignment;
        [NMS(Index = 469)]
        /* 0x6600 */ public Vector2f ModelViewWorldParallax;
        [NMS(Index = 1337)]
        /* 0x6608 */ public Vector2f NGuiMax2DParallax;
        [NMS(Index = 1336)]
        /* 0x6610 */ public Vector2f NGuiMin2DParallax;
        [NMS(Index = 1338)]
        /* 0x6618 */ public Vector2f NGuiModelParallax;
        [NMS(Index = 1339)]
        /* 0x6620 */ public Vector2f NGuiShipInteractParallax;
        [NMS(Index = 1155)]
        /* 0x6628 */ public Vector2f NGuiTouchPadSensitivity;
        [NMS(Index = 906)]
        /* 0x6630 */ public Vector2f NotificationMissionHintPauseTime;
        [NMS(Index = 907)]
        /* 0x6638 */ public Vector2f NotificationMissionHintPauseTimeCritical;
        [NMS(Index = 908)]
        /* 0x6640 */ public Vector2f NotificationMissionHintPauseTimeSecondary;
        [NMS(Index = 459)]
        /* 0x6648 */ public Vector2f PersonalRefinerInputPos;
        [NMS(Index = 460)]
        /* 0x6650 */ public Vector2f PersonalRefinerOutputPos;
        [NMS(Index = 942)]
        /* 0x6658 */ public Vector2f PlanetLabelOffset;
        [NMS(Index = 944)]
        /* 0x6660 */ public Vector2f PlanetLineOffset;
        [NMS(Index = 943)]
        /* 0x6668 */ public Vector2f PlanetMeasureOffset;
        [NMS(Index = 468)]
        /* 0x6670 */ public Vector2f RefinerParallax;
        [NMS(Index = 502)]
        /* 0x6678 */ public Vector2f SaveIconPosition;
        [NMS(Index = 1031)]
        /* 0x6680 */ public Vector2f ScanLabelOffset;
        [NMS(Index = 987)]
        /* 0x6688 */ public Vector2f TargetScreenCamOffset;
        [NMS(Index = 746)]
        /* 0x6690 */ public Vector2f TrackCriticalHitOffset;
        [NMS(Index = 710)]
        /* 0x6698 */ public Vector2f TrackTypeIconOffset;
        [NMS(Index = 1371)]
        /* 0x66A0 */ public int AbandonedFreighterAirlockRoomNumber;
        [NMS(Index = 1387)]
        /* 0x66A4 */ public float AccessibleUIHUDPopupScale;
        [NMS(Index = 1386)]
        /* 0x66A8 */ public float AccessibleUIPopupScale;
        [NMS(Index = 160)]
        /* 0x66AC */ public float AlignmentRequiredToDisableFrostedGlass;
        [NMS(Index = 1299)]
        /* 0x66B0 */ public float AltimeterLineSpacing;
        [NMS(Index = 1302)]
        /* 0x66B4 */ public float AltimeterMax;
        [NMS(Index = 1301)]
        /* 0x66B8 */ public float AltimeterMin;
        [NMS(Index = 1304)]
        /* 0x66BC */ public float AltimeterMinValue;
        [NMS(Index = 1298)]
        /* 0x66C0 */ public float AltimeterResolution;
        [NMS(Index = 1303)]
        /* 0x66C4 */ public float AltimeterTextSize;
        [NMS(Index = 1300)]
        /* 0x66C8 */ public float AltimeterWidth;
        [NMS(Index = 1015)]
        /* 0x66CC */ public float AlwaysOnHazardMultiplierCold;
        [NMS(Index = 1013)]
        /* 0x66D0 */ public float AlwaysOnHazardMultiplierHeat;
        [NMS(Index = 1014)]
        /* 0x66D4 */ public float AlwaysOnHazardMultiplierRad;
        [NMS(Index = 1012)]
        /* 0x66D8 */ public float AlwaysOnHazardMultiplierTox;
        [NMS(Index = 1011)]
        /* 0x66DC */ public float AlwaysOnHazardStrengthCold;
        [NMS(Index = 1009)]
        /* 0x66E0 */ public float AlwaysOnHazardStrengthHeat;
        [NMS(Index = 1010)]
        /* 0x66E4 */ public float AlwaysOnHazardStrengthRad;
        [NMS(Index = 1008)]
        /* 0x66E8 */ public float AlwaysOnHazardStrengthTox;
        [NMS(Index = 1007)]
        /* 0x66EC */ public float AlwaysOnHazardThreshold;
        [NMS(Index = 655)]
        /* 0x66F0 */ public float AlwaysShowIconFadeDistance;
        [NMS(Index = 656)]
        /* 0x66F4 */ public float AlwaysShowIconFadeRange;
        [NMS(Index = 1362)]
        /* 0x66F8 */ public float AmbientModeFadeTime;
        [NMS(Index = 650)]
        /* 0x66FC */ public float ArrowBounceLeftRate1;
        [NMS(Index = 651)]
        /* 0x6700 */ public float ArrowBounceLeftRate2;
        [NMS(Index = 652)]
        /* 0x6704 */ public float ArrowBounceLeftRate3;
        [NMS(Index = 645)]
        /* 0x6708 */ public float ArrowBounceLength;
        [NMS(Index = 646)]
        /* 0x670C */ public float ArrowBounceRate;
        [NMS(Index = 647)]
        /* 0x6710 */ public float ArrowBounceRightRate1;
        [NMS(Index = 648)]
        /* 0x6714 */ public float ArrowBounceRightRate2;
        [NMS(Index = 1313)]
        /* 0x6718 */ public float AsteroidMarkerMinDisplayAngleDegrees;
        [NMS(Index = 1312)]
        /* 0x671C */ public float AsteroidMarkerMinDisplayDistance;
        [NMS(Index = 412)]
        /* 0x6720 */ public float BaseBuildingFreeRotateDelayBeforeAudioStops;
        [NMS(Index = 411)]
        /* 0x6724 */ public float BaseBuildingFreeRotateDelayBeforeReset;
        [NMS(Index = 410)]
        /* 0x6728 */ public float BaseBuildingFreeRotateSpeedPadMultiplier;
        [NMS(Index = 404)]
        /* 0x672C */ public float BaseBuildingInputHighlightAlpha;
        [NMS(Index = 403)]
        /* 0x6730 */ public float BaseBuildingInputHighlightDuration;
        [NMS(Index = 407)]
        /* 0x6734 */ public float BaseBuildingMaxFreeRotateSpeed;
        [NMS(Index = 406)]
        /* 0x6738 */ public float BaseBuildingMinFreeRotateSpeed;
        [NMS(Index = 423)]
        /* 0x673C */ public float BaseBuildingPartsGridBreadcrumbFlashDuration;
        [NMS(Index = 422)]
        /* 0x6740 */ public float BaseBuildingPartsGridMaxCursorRestorationTime;
        [NMS(Index = 424)]
        /* 0x6744 */ public float BaseBuildingPartsGridMinVisibilityForActive;
        [NMS(Index = 426)]
        /* 0x6748 */ public float BaseBuildingPartsGridPopupDelay;
        [NMS(Index = 425)]
        /* 0x674C */ public float BaseBuildingPartsGridScrollSpeed;
        [NMS(Index = 402)]
        /* 0x6750 */ public float BaseBuildingPinHighlightDuration;
        [NMS(Index = 409)]
        /* 0x6754 */ public float BaseBuildingRotationResetRate;
        [NMS(Index = 405)]
        /* 0x6758 */ public float BaseBuildingScaleSpeed;
        [NMS(Index = 408)]
        /* 0x675C */ public float BaseBuildingTimeToMaxRotationSpeed;
        [NMS(Index = 421)]
        /* 0x6760 */ public float BaseBuildingUIAdjustTime;
        [NMS(Index = 420)]
        /* 0x6764 */ public float BaseBuildingUIErrorFadeTime;
        [NMS(Index = 414)]
        /* 0x6768 */ public float BaseBuildingUIHorizontalSafeArea;
        [NMS(Index = 417)]
        /* 0x676C */ public float BaseBuildingUIVerticalOffset;
        [NMS(Index = 418)]
        /* 0x6770 */ public float BaseBuildingUIVerticalOffsetEdit;
        [NMS(Index = 419)]
        /* 0x6774 */ public float BaseBuildingUIVerticalOffsetFromBB;
        [NMS(Index = 416)]
        /* 0x6778 */ public float BaseBuildingUIVerticalPosWiring;
        [NMS(Index = 415)]
        /* 0x677C */ public float BaseBuildingUIVerticalSafeArea;
        [NMS(Index = 376)]
        /* 0x6780 */ public float BaseComplexityDangerFactor;
        [NMS(Index = 377)]
        /* 0x6784 */ public float BaseComplexityWarningFactor;
        [NMS(Index = 146)]
        /* 0x6788 */ public float BeaconHUDMarkerOffset;
        [NMS(Index = 150)]
        /* 0x678C */ public float BinocularMarkerSideAngle;
        [NMS(Index = 151)]
        /* 0x6790 */ public float BinocularMarkerUpAngle;
        [NMS(Index = 148)]
        /* 0x6794 */ public float BinocularScreenOffset;
        [NMS(Index = 149)]
        /* 0x6798 */ public float BinocularScreenScale;
        [NMS(Index = 158)]
        /* 0x679C */ public float BinocularsFarIconDist;
        [NMS(Index = 159)]
        /* 0x67A0 */ public float BinocularsFarIconFadeDist;
        [NMS(Index = 157)]
        /* 0x67A4 */ public float BinocularsFarIconOpacity;
        [NMS(Index = 156)]
        /* 0x67A8 */ public float BinocularsMidIconOpacity;
        [NMS(Index = 154)]
        /* 0x67AC */ public float BinocularsNearIconDist;
        [NMS(Index = 155)]
        /* 0x67B0 */ public float BinocularsNearIconFadeDist;
        [NMS(Index = 153)]
        /* 0x67B4 */ public float BinocularsNearIconOpacity;
        [NMS(Index = 486)]
        /* 0x67B8 */ public float BountyMarkerOffset;
        [NMS(Index = 1367)]
        /* 0x67BC */ public int BuildingShopMaxItems;
        [NMS(Index = 381)]
        /* 0x67C0 */ public float BuildMenuActionMessageDuration;
        [NMS(Index = 242)]
        /* 0x67C4 */ public float BuildMenuItemNavAnimTime;
        [NMS(Index = 243)]
        /* 0x67C8 */ public float BuildMenuItemNextNavAnimTime;
        [NMS(Index = 244)]
        /* 0x67CC */ public float BuildMenuItemNextNavAnimWait;
        [NMS(Index = 1085)]
        /* 0x67D0 */ public float ByteBeatArpLineWidth;
        [NMS(Index = 1087)]
        /* 0x67D4 */ public float ByteBeatArpPad;
        [NMS(Index = 1086)]
        /* 0x67D8 */ public float ByteBeatArpRadius;
        [NMS(Index = 1083)]
        /* 0x67DC */ public float ByteBeatIconLineWidth;
        [NMS(Index = 1084)]
        /* 0x67E0 */ public float ByteBeatIconPad;
        [NMS(Index = 1094)]
        /* 0x67E4 */ public float ByteBeatPartSequencerPad;
        [NMS(Index = 1096)]
        /* 0x67E8 */ public float ByteBeatRhythmBeatPad;
        [NMS(Index = 1100)]
        /* 0x67EC */ public float ByteBeatRhythmSequencerActiveSaturation;
        [NMS(Index = 1099)]
        /* 0x67F0 */ public float ByteBeatRhythmSequencerInactiveSaturation;
        [NMS(Index = 1098)]
        /* 0x67F4 */ public float ByteBeatSequencerActiveSaturation;
        [NMS(Index = 1095)]
        /* 0x67F8 */ public float ByteBeatSequencerCornerRadius;
        [NMS(Index = 1114)]
        /* 0x67FC */ public float ByteBeatSequencerHighlightLineWidth;
        [NMS(Index = 1097)]
        /* 0x6800 */ public float ByteBeatSequencerInactiveSaturation;
        [NMS(Index = 1092)]
        /* 0x6804 */ public float ByteBeatSequencerLineWidth;
        [NMS(Index = 1093)]
        /* 0x6808 */ public float ByteBeatSequencerPad;
        [NMS(Index = 1101)]
        /* 0x680C */ public float ByteBeatSequencerUnpoweredTintStrength;
        [NMS(Index = 1117)]
        /* 0x6810 */ public float ByteBeatSliderCornerRadius;
        [NMS(Index = 1115)]
        /* 0x6814 */ public float ByteBeatSliderLineWidth;
        [NMS(Index = 1116)]
        /* 0x6818 */ public float ByteBeatSliderPad;
        [NMS(Index = 1121)]
        /* 0x681C */ public float ByteBeatSwitchPanelAlpha;
        [NMS(Index = 1122)]
        /* 0x6820 */ public float ByteBeatSwitchPanelSplit;
        [NMS(Index = 1078)]
        /* 0x6824 */ public float ByteBeatTreeLineWidth;
        [NMS(Index = 1080)]
        /* 0x6828 */ public float ByteBeatVisLineWidth;
        [NMS(Index = 111)]
        /* 0x682C */ public float ClosestDoorMarkerBuffer;
        [NMS(Index = 172)]
        /* 0x6830 */ public float CockpitGlassDefrostTime;
        [NMS(Index = 171)]
        /* 0x6834 */ public float CockpitGlassFrostTime;
        [NMS(Index = 543)]
        /* 0x6838 */ public float CommunicatorMessageTime;
        [NMS(Index = 372)]
        /* 0x683C */ public float CompassAngleClamp;
        [NMS(Index = 375)]
        /* 0x6840 */ public float CompassAngleClampSpace;
        [NMS(Index = 373)]
        /* 0x6844 */ public float CompassAngleFade;
        [NMS(Index = 369)]
        /* 0x6848 */ public float CompassDistanceMarkerMinScale;
        [NMS(Index = 370)]
        /* 0x684C */ public float CompassDistanceMaxAngle;
        [NMS(Index = 367)]
        /* 0x6850 */ public float CompassDistanceScale;
        [NMS(Index = 363)]
        /* 0x6854 */ public float CompassDistanceScaleMin;
        [NMS(Index = 364)]
        /* 0x6858 */ public float CompassDistanceScaleRange;
        [NMS(Index = 368)]
        /* 0x685C */ public float CompassDistanceShipMinScale;
        [NMS(Index = 365)]
        /* 0x6860 */ public float CompassDistanceSpaceScaleMin;
        [NMS(Index = 366)]
        /* 0x6864 */ public float CompassDistanceSpaceScaleRange;
        [NMS(Index = 371)]
        /* 0x6868 */ public float CompassDistanceYOffset;
        [NMS(Index = 361)]
        /* 0x686C */ public float CompassHeight;
        [NMS(Index = 178)]
        /* 0x6870 */ public float CompassIconOffsetVR;
        [NMS(Index = 199)]
        /* 0x6874 */ public float CompassLineContractionEndAngle;
        [NMS(Index = 198)]
        /* 0x6878 */ public float CompassLineContractionStartAngle;
        [NMS(Index = 200)]
        /* 0x687C */ public float CompassLineContractionTargetAngle;
        [NMS(Index = 204)]
        /* 0x6880 */ public float CompassLineNotchAngleRange;
        [NMS(Index = 206)]
        /* 0x6884 */ public float CompassLineNotchLength;
        [NMS(Index = 205)]
        /* 0x6888 */ public float CompassLineNotchThickness;
        [NMS(Index = 201)]
        /* 0x688C */ public int CompassLineNumNotches;
        [NMS(Index = 203)]
        /* 0x6890 */ public float CompassLineOffset;
        [NMS(Index = 202)]
        /* 0x6894 */ public float CompassLineThickness;
        [NMS(Index = 197)]
        /* 0x6898 */ public int CompassScreenHeight;
        [NMS(Index = 196)]
        /* 0x689C */ public int CompassScreenWidth;
        [NMS(Index = 362)]
        /* 0x68A0 */ public float CompassWidth;
        [NMS(Index = 573)]
        /* 0x68A4 */ public float ConsoleTextSpeed;
        [NMS(Index = 575)]
        /* 0x68A8 */ public float ConsoleTextTimeMax;
        [NMS(Index = 574)]
        /* 0x68AC */ public float ConsoleTextTimeMin;
        [NMS(Index = 697)]
        /* 0x68B0 */ public float ControlScrollDistance;
        [NMS(Index = 696)]
        /* 0x68B4 */ public int ControlScrollSteps;
        [NMS(Index = 585)]
        /* 0x68B8 */ public float CreatureDistanceAlpha;
        [NMS(Index = 583)]
        /* 0x68BC */ public float CreatureDistanceDisplayAngle;
        [NMS(Index = 584)]
        /* 0x68C0 */ public float CreatureDistanceFadeTime;
        [NMS(Index = 581)]
        /* 0x68C4 */ public float CreatureDistanceOffsetY;
        [NMS(Index = 582)]
        /* 0x68C8 */ public float CreatureDistanceShadowOffset;
        [NMS(Index = 580)]
        /* 0x68CC */ public float CreatureDistanceSize;
        [NMS(Index = 353)]
        /* 0x68D0 */ public float CreatureIconMergeAngle;
        [NMS(Index = 617)]
        /* 0x68D4 */ public float CreatureIconOffset;
        [NMS(Index = 618)]
        /* 0x68D8 */ public float CreatureIconOffsetPhysics;
        [NMS(Index = 736)]
        /* 0x68DC */ public float CreatureInteractLabelOffsetY;
        [NMS(Index = 732)]
        /* 0x68E0 */ public float CreatureReticuleScale;
        [NMS(Index = 702)]
        /* 0x68E4 */ public float CreatureRoutineMarkerTime;
        [NMS(Index = 703)]
        /* 0x68E8 */ public int CreatureRoutineRegionsPerFrame;
        [NMS(Index = 788)]
        /* 0x68EC */ public float CriticalMessageTime;
        [NMS(Index = 664)]
        /* 0x68F0 */ public float CrosshairAimOffTime;
        [NMS(Index = 663)]
        /* 0x68F4 */ public float CrosshairAimTime;
        [NMS(Index = 665)]
        /* 0x68F8 */ public float CrosshairInnerMinFade;
        [NMS(Index = 666)]
        /* 0x68FC */ public float CrosshairInnerMinFadeRange;
        [NMS(Index = 687)]
        /* 0x6900 */ public float CrosshairInterceptAlpha;
        [NMS(Index = 684)]
        /* 0x6904 */ public float CrosshairInterceptBaseSize;
        [NMS(Index = 685)]
        /* 0x6908 */ public float CrosshairInterceptCentreBaseSize;
        [NMS(Index = 688)]
        /* 0x690C */ public float CrosshairInterceptLockRange;
        [NMS(Index = 683)]
        /* 0x6910 */ public float CrosshairInterceptSize;
        [NMS(Index = 686)]
        /* 0x6914 */ public float CrosshairInterceptSpringTime;
        [NMS(Index = 670)]
        /* 0x6918 */ public float CrosshairLeadCornerOffset;
        [NMS(Index = 679)]
        /* 0x691C */ public float CrosshairLeadFadeRange;
        [NMS(Index = 680)]
        /* 0x6920 */ public float CrosshairLeadFadeSize;
        [NMS(Index = 668)]
        /* 0x6924 */ public float CrosshairLeadInDelay;
        [NMS(Index = 669)]
        /* 0x6928 */ public float CrosshairLeadInTime;
        [NMS(Index = 673)]
        /* 0x692C */ public float CrosshairLeadPulseSize;
        [NMS(Index = 667)]
        /* 0x6930 */ public float CrosshairLeadScaleIn;
        [NMS(Index = 677)]
        /* 0x6934 */ public float CrosshairLeadSpring;
        [NMS(Index = 678)]
        /* 0x6938 */ public float CrosshairLeadSpringOff;
        [NMS(Index = 672)]
        /* 0x693C */ public float CrosshairLeadTopLock;
        [NMS(Index = 671)]
        /* 0x6940 */ public float CrosshairLeadTopOffset;
        [NMS(Index = 285)]
        /* 0x6944 */ public float CrosshairOffsetHmd;
        [NMS(Index = 286)]
        /* 0x6948 */ public float CrosshairOffsetHmdUp;
        [NMS(Index = 284)]
        /* 0x694C */ public float CrosshairScaleHmd;
        [NMS(Index = 288)]
        /* 0x6950 */ public int CrosshairScreenHeight;
        [NMS(Index = 287)]
        /* 0x6954 */ public int CrosshairScreenWidth;
        [NMS(Index = 676)]
        /* 0x6958 */ public float CrosshairSpringAimTime;
        [NMS(Index = 675)]
        /* 0x695C */ public float CrosshairSpringTime;
        [NMS(Index = 689)]
        /* 0x6960 */ public float CrosshairTargetLockSize;
        [NMS(Index = 1049)]
        /* 0x6964 */ public float CursorHoverSlowFactor;
        [NMS(Index = 1050)]
        /* 0x6968 */ public float CursorHoverSlowFactorMin;
        [NMS(Index = 516)]
        /* 0x696C */ public float DamageDirectionIndicatorOnScreenRadiusMultiplier;
        [NMS(Index = 587)]
        /* 0x6970 */ public float DamageImpactMergeTime;
        [NMS(Index = 589)]
        /* 0x6974 */ public float DamageImpactMinDistance;
        [NMS(Index = 588)]
        /* 0x6978 */ public float DamageImpactTimeBetweenNumbers;
        [NMS(Index = 598)]
        /* 0x697C */ public float DamageNumberBlackAlpha;
        [NMS(Index = 604)]
        /* 0x6980 */ public float DamageNumberFadeIn;
        [NMS(Index = 605)]
        /* 0x6984 */ public float DamageNumberFadeOut;
        [NMS(Index = 597)]
        /* 0x6988 */ public float DamageNumberLaserMaxDamage;
        [NMS(Index = 596)]
        /* 0x698C */ public float DamageNumberLaserMinDamage;
        [NMS(Index = 601)]
        /* 0x6990 */ public float DamageNumberOffsetX;
        [NMS(Index = 602)]
        /* 0x6994 */ public float DamageNumberOffsetY;
        [NMS(Index = 599)]
        /* 0x6998 */ public float DamageNumberOutline;
        [NMS(Index = 600)]
        /* 0x699C */ public float DamageNumberOutline2;
        [NMS(Index = 593)]
        /* 0x69A0 */ public float DamageNumberSize;
        [NMS(Index = 594)]
        /* 0x69A4 */ public float DamageNumberSizeCritMultiplier;
        [NMS(Index = 592)]
        /* 0x69A8 */ public float DamageNumberSizeInShip;
        [NMS(Index = 595)]
        /* 0x69AC */ public float DamageNumberSizeLaserMultiplier;
        [NMS(Index = 591)]
        /* 0x69B0 */ public float DamageNumberTime;
        [NMS(Index = 606)]
        /* 0x69B4 */ public float DamageNumberUpOffset;
        [NMS(Index = 590)]
        /* 0x69B8 */ public float DamagePerSecondSampleTime;
        [NMS(Index = 439)]
        /* 0x69BC */ public float DamageScannableHighlightTime;
        [NMS(Index = 440)]
        /* 0x69C0 */ public float DamageTrackArrowTime;
        [NMS(Index = 915)]
        /* 0x69C4 */ public float DeathMessageSwitchTime;
        [NMS(Index = 916)]
        /* 0x69C8 */ public float DeathMessageTotalTime;
        [NMS(Index = 46)]
        /* 0x69CC */ public int DebugMedalRank;
        [NMS(Index = 619)]
        /* 0x69D0 */ public float DelayBeforeHidingHangarAfterGalaxyMap;
        [NMS(Index = 620)]
        /* 0x69D4 */ public float DelayBeforeShowingHangarIntoGalaxyMap;
        [NMS(Index = 568)]
        /* 0x69D8 */ public float DescriptionTextDelay;
        [NMS(Index = 569)]
        /* 0x69DC */ public float DescriptionTextSpeed;
        [NMS(Index = 570)]
        /* 0x69E0 */ public float DescriptionTextSpeedProgressive;
        [NMS(Index = 572)]
        /* 0x69E4 */ public float DescriptionTextTimeMax;
        [NMS(Index = 571)]
        /* 0x69E8 */ public float DescriptionTextTimeMin;
        [NMS(Index = 1388)]
        /* 0x69EC */ public float DetailMessageDismissTime;
        [NMS(Index = 335)]
        /* 0x69F0 */ public float DroneIndicatorCentreRadiusMax;
        [NMS(Index = 336)]
        /* 0x69F4 */ public float DroneIndicatorCentreRadiusMin;
        [NMS(Index = 337)]
        /* 0x69F8 */ public float DroneIndicatorFadeRange;
        [NMS(Index = 334)]
        /* 0x69FC */ public float DroneIndicatorRadius;
        [NMS(Index = 91)]
        /* 0x6A00 */ public float EggModifiyAnimLoopTime;
        [NMS(Index = 90)]
        /* 0x6A04 */ public float EggModifiyAnimMaxSize;
        [NMS(Index = 101)]
        /* 0x6A08 */ public float EndOfSeasonAlertDelay;
        [NMS(Index = 138)]
        /* 0x6A0C */ public float ExocraftHUDMarkerHideDistance;
        [NMS(Index = 139)]
        /* 0x6A10 */ public float ExocraftHUDMarkerOffset;
        [NMS(Index = 98)]
        /* 0x6A14 */ public float ExpeditionStageChangeTime;
        [NMS(Index = 40)]
        /* 0x6A18 */ public float EyeTrackingCursorBlendRate;
        [NMS(Index = 39)]
        /* 0x6A1C */ public float EyeTrackingCursorBlendRateGameModeSelect;
        [NMS(Index = 38)]
        /* 0x6A20 */ public float EyeTrackingPopupLookAwayTime;
        [NMS(Index = 41)]
        /* 0x6A24 */ public float EyeTrackingStickyHoverTime;
        [NMS(Index = 37)]
        /* 0x6A28 */ public float EyeTrackingTimeBeforePopupsActivate;
        [NMS(Index = 1396)]
        /* 0x6A2C */ public float FeedFrigateAnimAlphaChange;
        [NMS(Index = 1394)]
        /* 0x6A30 */ public int FeedFrigateAnimNumPeriods;
        [NMS(Index = 1393)]
        /* 0x6A34 */ public float FeedFrigateAnimPeriod;
        [NMS(Index = 1395)]
        /* 0x6A38 */ public float FeedFrigateAnimScaleChange;
        [NMS(Index = 106)]
        /* 0x6A3C */ public int ForceOpenHazardProtInventoryThreshold;
        [NMS(Index = 629)]
        /* 0x6A40 */ public float FreighterCommanderMarkerMinDistance;
        [NMS(Index = 660)]
        /* 0x6A44 */ public float FreighterEntranceOffset;
        [NMS(Index = 635)]
        /* 0x6A48 */ public float FreighterHighlightRange;
        [NMS(Index = 659)]
        /* 0x6A4C */ public float FreighterLeaderIconDistance;
        [NMS(Index = 80)]
        /* 0x6A50 */ public float FreighterMegaWarpTransitionTime;
        [NMS(Index = 625)]
        /* 0x6A54 */ public float FreighterSummonDelay;
        [NMS(Index = 628)]
        /* 0x6A58 */ public float FreighterSummonGridSize;
        [NMS(Index = 634)]
        /* 0x6A5C */ public float FreighterSummonLookTime;
        [NMS(Index = 623)]
        /* 0x6A60 */ public float FreighterSummonOffset;
        [NMS(Index = 624)]
        /* 0x6A64 */ public float FreighterSummonOffsetPulse;
        [NMS(Index = 622)]
        /* 0x6A68 */ public float FreighterSummonPitch;
        [NMS(Index = 633)]
        /* 0x6A6C */ public float FreighterSummonPlanetOffset;
        [NMS(Index = 632)]
        /* 0x6A70 */ public float FreighterSummonPulseFadeAmount;
        [NMS(Index = 631)]
        /* 0x6A74 */ public float FreighterSummonPulseRate;
        [NMS(Index = 621)]
        /* 0x6A78 */ public float FreighterSummonTurn;
        [NMS(Index = 627)]
        /* 0x6A7C */ public float FreighterSummonTurnAngleIncrement;
        [NMS(Index = 626)]
        /* 0x6A80 */ public int FreighterSummonTurnNumTries;
        [NMS(Index = 630)]
        /* 0x6A84 */ public float FreighterSurfaceMinAngle;
        [NMS(Index = 658)]
        /* 0x6A88 */ public float FrigateDamageIconVisibilityDistance;
        [NMS(Index = 616)]
        /* 0x6A8C */ public float FrigateIconOffset;
        [NMS(Index = 657)]
        /* 0x6A90 */ public float FrigatePurchaseNotificationResetDistanceMultiplier;
        [NMS(Index = 1067)]
        /* 0x6A94 */ public float FrontendActivateSplit;
        [NMS(Index = 1066)]
        /* 0x6A98 */ public float FrontendActivateTime;
        [NMS(Index = 1051)]
        /* 0x6A9C */ public float FrontendBGAlpha;
        [NMS(Index = 1071)]
        /* 0x6AA0 */ public float FrontendBootBarTime;
        [NMS(Index = 1070)]
        /* 0x6AA4 */ public float FrontendBootTime;
        [NMS(Index = 1055)]
        /* 0x6AA8 */ public float FrontendConfirmTime;
        [NMS(Index = 1053)]
        /* 0x6AAC */ public float FrontendConfirmTimeFast;
        [NMS(Index = 1052)]
        /* 0x6AB0 */ public float FrontendConfirmTimeMouseMultiplier;
        [NMS(Index = 1056)]
        /* 0x6AB4 */ public float FrontendConfirmTimeSlow;
        [NMS(Index = 1059)]
        /* 0x6AB8 */ public float FrontendCursorOffset;
        [NMS(Index = 1058)]
        /* 0x6ABC */ public float FrontendCursorSize;
        [NMS(Index = 1063)]
        /* 0x6AC0 */ public float FrontendCursorWidth;
        [NMS(Index = 1065)]
        /* 0x6AC4 */ public float FrontendDeactivateSplit;
        [NMS(Index = 1064)]
        /* 0x6AC8 */ public float FrontendDeactivateTime;
        [NMS(Index = 1146)]
        /* 0x6ACC */ public float FrontendDoFBlurMultiplier;
        [NMS(Index = 1145)]
        /* 0x6AD0 */ public float FrontendDoFFarPlaneFadeMax;
        [NMS(Index = 1144)]
        /* 0x6AD4 */ public float FrontendDoFFarPlaneFadeMin;
        [NMS(Index = 1143)]
        /* 0x6AD8 */ public float FrontendDoFFarPlaneMax;
        [NMS(Index = 1142)]
        /* 0x6ADC */ public float FrontendDoFFarPlaneMin;
        [NMS(Index = 1141)]
        /* 0x6AE0 */ public float FrontendDoFNearPlaneMax;
        [NMS(Index = 1140)]
        /* 0x6AE4 */ public float FrontendDoFNearPlaneMin;
        [NMS(Index = 163)]
        /* 0x6AE8 */ public float FrontendOffsetVR;
        [NMS(Index = 1149)]
        /* 0x6AEC */ public float FrontendShineSpeed;
        [NMS(Index = 1068)]
        /* 0x6AF0 */ public float FrontendStatCircleWidth;
        [NMS(Index = 1069)]
        /* 0x6AF4 */ public float FrontendStatCircleWidthExtra;
        [NMS(Index = 1152)]
        /* 0x6AF8 */ public float FrontendTitleFontSpacing;
        [NMS(Index = 1150)]
        /* 0x6AFC */ public float FrontendToolbarTextHeight;
        [NMS(Index = 1151)]
        /* 0x6B00 */ public float FrontendToolbarTextHeightSelected;
        [NMS(Index = 1054)]
        /* 0x6B04 */ public float FrontendTouchConfirmTimeFastMultiplier;
        [NMS(Index = 563)]
        /* 0x6B08 */ public float FrontendWaitFadeProgressiveDialogOut;
        [NMS(Index = 562)]
        /* 0x6B0C */ public float FrontendWaitFadeTextFrameOut;
        [NMS(Index = 561)]
        /* 0x6B10 */ public float FrontendWaitFadeTextOut;
        [NMS(Index = 559)]
        /* 0x6B14 */ public float FrontendWaitInitial;
        [NMS(Index = 560)]
        /* 0x6B18 */ public float FrontendWaitInitialTerminal;
        [NMS(Index = 558)]
        /* 0x6B1C */ public float FrontendWaitResponse;
        [NMS(Index = 564)]
        /* 0x6B20 */ public float FrontendWaitResponseOffset;
        [NMS(Index = 849)]
        /* 0x6B24 */ public float GalaxyMapRadialBorder;
        [NMS(Index = 850)]
        /* 0x6B28 */ public float GalaxyMapRadialTargetDist;
        [NMS(Index = 162)]
        /* 0x6B2C */ public float GalmapDiscoveryOffsetVR;
        [NMS(Index = 89)]
        /* 0x6B30 */ public float GameModeSelectColourFadeTime;
        [NMS(Index = 72)]
        /* 0x6B34 */ public float GridDecayRateSwitchValue;
        [NMS(Index = 547)]
        /* 0x6B38 */ public float GridFlickerAmp;
        [NMS(Index = 545)]
        /* 0x6B3C */ public float GridFlickerBaseAlpha;
        [NMS(Index = 546)]
        /* 0x6B40 */ public float GridFlickerFreq;
        [NMS(Index = 225)]
        /* 0x6B44 */ public float HandButtonClickTime;
        [NMS(Index = 221)]
        /* 0x6B48 */ public float HandButtonCursorScale;
        [NMS(Index = 229)]
        /* 0x6B4C */ public float HandButtonDotRadius;
        [NMS(Index = 227)]
        /* 0x6B50 */ public float HandButtonFrontendCursorScale;
        [NMS(Index = 223)]
        /* 0x6B54 */ public float HandButtonNearDistance;
        [NMS(Index = 218)]
        /* 0x6B58 */ public float HandButtonPostClickTime;
        [NMS(Index = 230)]
        /* 0x6B5C */ public float HandButtonPulseRadius;
        [NMS(Index = 231)]
        /* 0x6B60 */ public float HandButtonPulseThickness;
        [NMS(Index = 222)]
        /* 0x6B64 */ public float HandButtonPushDistance;
        [NMS(Index = 214)]
        /* 0x6B68 */ public float HandButtonRadius;
        [NMS(Index = 224)]
        /* 0x6B6C */ public float HandButtonRadiusClick;
        [NMS(Index = 215)]
        /* 0x6B70 */ public float HandButtonRadiusTouch;
        [NMS(Index = 216)]
        /* 0x6B74 */ public float HandButtonRadiusTouchNear;
        [NMS(Index = 217)]
        /* 0x6B78 */ public float HandButtonRadiusTouchNearActive;
        [NMS(Index = 219)]
        /* 0x6B7C */ public float HandButtonReleaseThreshold;
        [NMS(Index = 220)]
        /* 0x6B80 */ public float HandButtonReleaseThresholdInit;
        [NMS(Index = 228)]
        /* 0x6B84 */ public float HandButtonThickness;
        [NMS(Index = 226)]
        /* 0x6B88 */ public float HandButtonTouchReturnTime;
        [NMS(Index = 250)]
        /* 0x6B8C */ public float HandControlButtonSize;
        [NMS(Index = 257)]
        /* 0x6B90 */ public float HandControlMenuAngle;
        [NMS(Index = 208)]
        /* 0x6B94 */ public float HandControlMenuCursorScale;
        [NMS(Index = 263)]
        /* 0x6B98 */ public float HandControlMenuDepth;
        [NMS(Index = 256)]
        /* 0x6B9C */ public float HandControlMenuMoveActionDistance;
        [NMS(Index = 253)]
        /* 0x6BA0 */ public float HandControlMenuMoveDistance;
        [NMS(Index = 254)]
        /* 0x6BA4 */ public float HandControlMenuMoveDistanceScroll;
        [NMS(Index = 255)]
        /* 0x6BA8 */ public float HandControlMenuMoveDistanceVertical;
        [NMS(Index = 259)]
        /* 0x6BAC */ public float HandControlMenuSelectRadius;
        [NMS(Index = 260)]
        /* 0x6BB0 */ public float HandControlMenuSelectRadius1;
        [NMS(Index = 261)]
        /* 0x6BB4 */ public float HandControlMenuSelectRadius2;
        [NMS(Index = 258)]
        /* 0x6BB8 */ public float HandControlMenuSurfaceOffset;
        [NMS(Index = 252)]
        /* 0x6BBC */ public float HandControlPointActiveMargin;
        [NMS(Index = 251)]
        /* 0x6BC0 */ public float HandControlPointMargin;
        [NMS(Index = 262)]
        /* 0x6BC4 */ public float HandControlTopMenuSelectRadius;
        [NMS(Index = 114)]
        /* 0x6BC8 */ public float HandheldZoomFactor;
        [NMS(Index = 212)]
        /* 0x6BCC */ public float HandScreenGraphicsHeight;
        [NMS(Index = 211)]
        /* 0x6BD0 */ public float HandScreenGraphicsWidth;
        [NMS(Index = 267)]
        /* 0x6BD4 */ public int HandScreenHeight;
        [NMS(Index = 213)]
        /* 0x6BD8 */ public float HandScreenNearActivateDistance;
        [NMS(Index = 265)]
        /* 0x6BDC */ public int HandScreenWeaponHeight;
        [NMS(Index = 264)]
        /* 0x6BE0 */ public int HandScreenWeaponWidth;
        [NMS(Index = 266)]
        /* 0x6BE4 */ public int HandScreenWidth;
        [NMS(Index = 1138)]
        /* 0x6BE8 */ public float HatchAlphaBase;
        [NMS(Index = 1139)]
        /* 0x6BEC */ public float HatchAlphaCursor;
        [NMS(Index = 1137)]
        /* 0x6BF0 */ public float HatchAlphaMain;
        [NMS(Index = 1135)]
        /* 0x6BF4 */ public int HatchCount;
        [NMS(Index = 1136)]
        /* 0x6BF8 */ public float HatchCursorRadius;
        [NMS(Index = 1134)]
        /* 0x6BFC */ public float HatchPulsePauseTime;
        [NMS(Index = 1132)]
        /* 0x6C00 */ public float HatchPulseSpeed;
        [NMS(Index = 1133)]
        /* 0x6C04 */ public float HatchPulseWidth;
        [NMS(Index = 643)]
        /* 0x6C08 */ public float HazardArrowsLevel2Threshold;
        [NMS(Index = 644)]
        /* 0x6C0C */ public float HazardArrowsLevel3Threshold;
        [NMS(Index = 996)]
        /* 0x6C10 */ public float HazardBarPulseTime;
        [NMS(Index = 1001)]
        /* 0x6C14 */ public float HazardPainPulseStrength;
        [NMS(Index = 1016)]
        /* 0x6C18 */ public float HazardPulseRate;
        [NMS(Index = 993)]
        /* 0x6C1C */ public float HazardScreenEffectPulseRate;
        [NMS(Index = 997)]
        /* 0x6C20 */ public float HazardScreenEffectPulseTime;
        [NMS(Index = 998)]
        /* 0x6C24 */ public float HazardScreenEffectStrength;
        [NMS(Index = 1000)]
        /* 0x6C28 */ public float HazardWarningPulseStrength;
        [NMS(Index = 999)]
        /* 0x6C2C */ public float HazardWarningPulseTime;
        [NMS(Index = 1162)]
        /* 0x6C30 */ public float HitMarkerPulseSize;
        [NMS(Index = 1163)]
        /* 0x6C34 */ public float HitMarkerPulseSizeStatic;
        [NMS(Index = 1164)]
        /* 0x6C38 */ public float HitMarkerPulseTime;
        [NMS(Index = 282)]
        /* 0x6C3C */ public float HmdFramerateScreenPitch;
        [NMS(Index = 989)]
        /* 0x6C40 */ public float HoldTimerResetTime;
        [NMS(Index = 576)]
        /* 0x6C44 */ public float HoverOffscreenBorder;
        [NMS(Index = 577)]
        /* 0x6C48 */ public float HoverOffscreenBorderVR;
        [NMS(Index = 33)]
        /* 0x6C4C */ public float HoverPopAnimDuration;
        [NMS(Index = 32)]
        /* 0x6C50 */ public float HoverPopScaleModification;
        [NMS(Index = 793)]
        /* 0x6C54 */ public float HUDDisplayTime;
        [NMS(Index = 739)]
        /* 0x6C58 */ public float HUDDroneCombatPulse;
        [NMS(Index = 737)]
        /* 0x6C5C */ public float HUDDroneHealingPulse;
        [NMS(Index = 738)]
        /* 0x6C60 */ public float HUDDroneSummoningPulse;
        [NMS(Index = 927)]
        /* 0x6C64 */ public float HUDElementsOffsetHMDBottom;
        [NMS(Index = 925)]
        /* 0x6C68 */ public float HUDElementsOffsetHMDSide;
        [NMS(Index = 926)]
        /* 0x6C6C */ public float HUDElementsOffsetHMDTop;
        [NMS(Index = 928)]
        /* 0x6C70 */ public float HUDElementsOffsetX_0;
        [NMS(Index = 930)]
        /* 0x6C74 */ public float HUDElementsOffsetX_1;
        [NMS(Index = 932)]
        /* 0x6C78 */ public float HUDElementsOffsetX_2;
        [NMS(Index = 934)]
        /* 0x6C7C */ public float HUDElementsOffsetX_3;
        [NMS(Index = 936)]
        /* 0x6C80 */ public float HUDElementsOffsetX_4;
        [NMS(Index = 938)]
        /* 0x6C84 */ public float HUDElementsOffsetX_5;
        [NMS(Index = 929)]
        /* 0x6C88 */ public float HUDElementsOffsetY_0;
        [NMS(Index = 931)]
        /* 0x6C8C */ public float HUDElementsOffsetY_1;
        [NMS(Index = 933)]
        /* 0x6C90 */ public float HUDElementsOffsetY_2;
        [NMS(Index = 935)]
        /* 0x6C94 */ public float HUDElementsOffsetY_3;
        [NMS(Index = 937)]
        /* 0x6C98 */ public float HUDElementsOffsetY_4;
        [NMS(Index = 939)]
        /* 0x6C9C */ public float HUDElementsOffsetY_5;
        [NMS(Index = 1295)]
        /* 0x6CA0 */ public float HUDMarkerActiveTime;
        [NMS(Index = 1290)]
        /* 0x6CA4 */ public float HUDMarkerAlpha;
        [NMS(Index = 1265)]
        /* 0x6CA8 */ public float HUDMarkerAnimLoopTime;
        [NMS(Index = 1264)]
        /* 0x6CAC */ public float HUDMarkerAnimOffset;
        [NMS(Index = 1263)]
        /* 0x6CB0 */ public float HUDMarkerAnimScale;
        [NMS(Index = 1262)]
        /* 0x6CB4 */ public float HUDMarkerAnimSpeed;
        [NMS(Index = 443)]
        /* 0x6CB8 */ public float HUDMarkerDistanceOrTimeDistance;
        [NMS(Index = 1283)]
        /* 0x6CBC */ public float HUDMarkerFarDistance;
        [NMS(Index = 1284)]
        /* 0x6CC0 */ public float HUDMarkerFarFadeRange;
        [NMS(Index = 1289)]
        /* 0x6CC4 */ public float HUDMarkerHorizonBlendRange;
        [NMS(Index = 1271)]
        /* 0x6CC8 */ public float HUDMarkerHoverAngleTestGround;
        [NMS(Index = 289)]
        /* 0x6CCC */ public float HUDMarkerHoverAngleTestGroundHmd;
        [NMS(Index = 1275)]
        /* 0x6CD0 */ public float HUDMarkerHoverAngleTestShip;
        [NMS(Index = 1276)]
        /* 0x6CD4 */ public float HUDMarkerHoverShowLargeAngleTest;
        [NMS(Index = 1297)]
        /* 0x6CD8 */ public float HUDMarkerIconHoverMinScale;
        [NMS(Index = 550)]
        /* 0x6CDC */ public float HUDMarkerLabelArriveDistance;
        [NMS(Index = 549)]
        /* 0x6CE0 */ public float HUDMarkerLabelBaseWidth;
        [NMS(Index = 551)]
        /* 0x6CE4 */ public float HUDMarkerLabelDisplayDistance;
        [NMS(Index = 548)]
        /* 0x6CE8 */ public float HUDMarkerLabelWidthMultiplier;
        [NMS(Index = 1292)]
        /* 0x6CEC */ public float HUDMarkerModelFadeMinHeight;
        [NMS(Index = 1291)]
        /* 0x6CF0 */ public float HUDMarkerModelFadeRange;
        [NMS(Index = 1281)]
        /* 0x6CF4 */ public float HUDMarkerNearFadeDistance;
        [NMS(Index = 1282)]
        /* 0x6CF8 */ public float HUDMarkerNearFadeRange;
        [NMS(Index = 552)]
        /* 0x6CFC */ public float HUDMarkerNonActiveMissionAlpha;
        [NMS(Index = 442)]
        /* 0x6D00 */ public float HUDMarkerObjectMinScreenDistance;
        [NMS(Index = 1245)]
        /* 0x6D04 */ public float HUDMarkerOffset;
        [NMS(Index = 1268)]
        /* 0x6D08 */ public float HUDMarkerPrimaryIndicatorSize;
        [NMS(Index = 1285)]
        /* 0x6D0C */ public float HUDMarkerScalerMin;
        [NMS(Index = 1286)]
        /* 0x6D10 */ public float HUDMarkerScalerRange;
        [NMS(Index = 1288)]
        /* 0x6D14 */ public float HUDMarkerScalerSizeMax;
        [NMS(Index = 1287)]
        /* 0x6D18 */ public float HUDMarkerScalerSizeMin;
        [NMS(Index = 1279)]
        /* 0x6D1C */ public float HUDMarkerShipOffsetMaxDist;
        [NMS(Index = 1280)]
        /* 0x6D20 */ public float HUDMarkerShipOffsetMinDist;
        [NMS(Index = 1293)]
        /* 0x6D24 */ public float HUDMarkerShowActualIconDistance;
        [NMS(Index = 1294)]
        /* 0x6D28 */ public float HUDMarkerShowActualSpaceIconDistance;
        [NMS(Index = 1274)]
        /* 0x6D2C */ public float HUDMarkerWideHoverAngleTest;
        [NMS(Index = 290)]
        /* 0x6D30 */ public float HUDMarkerWideHoverAngleTestHmd;
        [NMS(Index = 1273)]
        /* 0x6D34 */ public float HUDNetworkMarkerHoverAngleTestGround;
        [NMS(Index = 1278)]
        /* 0x6D38 */ public float HUDNetworkMarkerHoverAngleVRMul;
        [NMS(Index = 1277)]
        /* 0x6D3C */ public float HUDNetworkMarkerHoverShowLargeAngleTest;
        [NMS(Index = 1272)]
        /* 0x6D40 */ public float HUDPetCentreScreenAngle;
        [NMS(Index = 1269)]
        /* 0x6D44 */ public float HUDPetMarkerAngleTest;
        [NMS(Index = 1270)]
        /* 0x6D48 */ public float HUDPetMarkerAngleVRMul;
        [NMS(Index = 475)]
        /* 0x6D4C */ public float HUDPlayerPhonePulseScanFreq;
        [NMS(Index = 474)]
        /* 0x6D50 */ public float HUDPlayerSentinelPulseScanFreq;
        [NMS(Index = 472)]
        /* 0x6D54 */ public float HUDPlayerSentinelPulseWidth;
        [NMS(Index = 473)]
        /* 0x6D58 */ public float HUDPlayerSentinelRangeFactor;
        [NMS(Index = 837)]
        /* 0x6D5C */ public float HUDPlayerTrackArrowArrowSize;
        [NMS(Index = 806)]
        /* 0x6D60 */ public float HUDPlayerTrackArrowDamageGlowHullHitCriticalOpacityScale;
        [NMS(Index = 807)]
        /* 0x6D64 */ public float HUDPlayerTrackArrowDamageGlowHullHitOpacityScale;
        [NMS(Index = 814)]
        /* 0x6D68 */ public float HUDPlayerTrackArrowDamageGlowOffset;
        [NMS(Index = 810)]
        /* 0x6D6C */ public float HUDPlayerTrackArrowDamageGlowShieldHitCriticalOpacityScale;
        [NMS(Index = 811)]
        /* 0x6D70 */ public float HUDPlayerTrackArrowDamageGlowShieldHitOpacityScale;
        [NMS(Index = 838)]
        /* 0x6D74 */ public float HUDPlayerTrackArrowDotSize;
        [NMS(Index = 818)]
        /* 0x6D78 */ public float HUDPlayerTrackArrowEnergyShieldDepletedGlowOpacityScale;
        [NMS(Index = 819)]
        /* 0x6D7C */ public float HUDPlayerTrackArrowEnergyShieldDepletedTime;
        [NMS(Index = 816)]
        /* 0x6D80 */ public float HUDPlayerTrackArrowEnergyShieldGlowOffset;
        [NMS(Index = 802)]
        /* 0x6D84 */ public float HUDPlayerTrackArrowEnergyShieldLowThreshold;
        [NMS(Index = 803)]
        /* 0x6D88 */ public float HUDPlayerTrackArrowEnergyShieldOffset;
        [NMS(Index = 823)]
        /* 0x6D8C */ public float HUDPlayerTrackArrowEnergyShieldStartChargeGlowOpacityScale;
        [NMS(Index = 824)]
        /* 0x6D90 */ public float HUDPlayerTrackArrowEnergyShieldStartChargeTime;
        [NMS(Index = 846)]
        /* 0x6D94 */ public float HUDPlayerTrackArrowFadeRange;
        [NMS(Index = 805)]
        /* 0x6D98 */ public float HUDPlayerTrackArrowGlowBaseOpacity;
        [NMS(Index = 798)]
        /* 0x6D9C */ public float HUDPlayerTrackArrowHealthOffset;
        [NMS(Index = 765)]
        /* 0x6DA0 */ public float HUDPlayerTrackArrowIconBorderReducerShip;
        [NMS(Index = 762)]
        /* 0x6DA4 */ public float HUDPlayerTrackArrowIconFadeDist;
        [NMS(Index = 761)]
        /* 0x6DA8 */ public float HUDPlayerTrackArrowIconFadeDistDrone;
        [NMS(Index = 760)]
        /* 0x6DAC */ public float HUDPlayerTrackArrowIconFadeDistShip;
        [NMS(Index = 763)]
        /* 0x6DB0 */ public float HUDPlayerTrackArrowIconFadeRange;
        [NMS(Index = 764)]
        /* 0x6DB4 */ public float HUDPlayerTrackArrowIconFadeRangeShip;
        [NMS(Index = 755)]
        /* 0x6DB8 */ public float HUDPlayerTrackArrowIconFadeTime;
        [NMS(Index = 759)]
        /* 0x6DBC */ public float HUDPlayerTrackArrowIconPulse2Alpha;
        [NMS(Index = 753)]
        /* 0x6DC0 */ public float HUDPlayerTrackArrowIconPulseTime;
        [NMS(Index = 757)]
        /* 0x6DC4 */ public float HUDPlayerTrackArrowIconPulseWidth1;
        [NMS(Index = 758)]
        /* 0x6DC8 */ public float HUDPlayerTrackArrowIconPulseWidth2;
        [NMS(Index = 754)]
        /* 0x6DCC */ public float HUDPlayerTrackArrowIconShowTime;
        [NMS(Index = 835)]
        /* 0x6DD0 */ public float HUDPlayerTrackArrowIconSize;
        [NMS(Index = 845)]
        /* 0x6DD4 */ public float HUDPlayerTrackArrowMinFadeDist;
        [NMS(Index = 830)]
        /* 0x6DD8 */ public float HUDPlayerTrackArrowOffset;
        [NMS(Index = 766)]
        /* 0x6DDC */ public float HUDPlayerTrackArrowPulseOffset;
        [NMS(Index = 767)]
        /* 0x6DE0 */ public float HUDPlayerTrackArrowPulseRate;
        [NMS(Index = 831)]
        /* 0x6DE4 */ public float HUDPlayerTrackArrowScreenBorder;
        [NMS(Index = 752)]
        /* 0x6DE8 */ public float HUDPlayerTrackArrowShipLabelOffset;
        [NMS(Index = 832)]
        /* 0x6DEC */ public float HUDPlayerTrackArrowSize;
        [NMS(Index = 834)]
        /* 0x6DF0 */ public float HUDPlayerTrackArrowSizeMax;
        [NMS(Index = 833)]
        /* 0x6DF4 */ public float HUDPlayerTrackArrowSizeMin;
        [NMS(Index = 836)]
        /* 0x6DF8 */ public float HUDPlayerTrackArrowSmallIconSize;
        [NMS(Index = 829)]
        /* 0x6DFC */ public float HUDPlayerTrackArrowTargetDist;
        [NMS(Index = 828)]
        /* 0x6E00 */ public float HUDPlayerTrackArrowTargetDistShip;
        [NMS(Index = 796)]
        /* 0x6E04 */ public float HUDPlayerTrackArrowTextHeight;
        [NMS(Index = 795)]
        /* 0x6E08 */ public float HUDPlayerTrackArrowTextOffset;
        [NMS(Index = 794)]
        /* 0x6E0C */ public float HUDPlayerTrackDangerPulse;
        [NMS(Index = 740)]
        /* 0x6E10 */ public float HUDPlayerTrackNoSightPulse;
        [NMS(Index = 743)]
        /* 0x6E14 */ public float HUDPlayerTrackTimerEnd;
        [NMS(Index = 744)]
        /* 0x6E18 */ public float HUDPlayerTrackTimerPulseRate;
        [NMS(Index = 741)]
        /* 0x6E1C */ public float HUDPlayerTrackTimerStart;
        [NMS(Index = 742)]
        /* 0x6E20 */ public float HUDPlayerTrackTimerStartFade;
        [NMS(Index = 1240)]
        /* 0x6E24 */ public float HUDTargetHealthDangerTime;
        [NMS(Index = 1239)]
        /* 0x6E28 */ public float HUDTargetHealthIconSize;
        [NMS(Index = 1243)]
        /* 0x6E2C */ public float HUDTargetIconOffset;
        [NMS(Index = 1244)]
        /* 0x6E30 */ public float HUDTargetIconSize;
        [NMS(Index = 1241)]
        /* 0x6E34 */ public float HUDTargetMarkerOffset;
        [NMS(Index = 1242)]
        /* 0x6E38 */ public float HUDTargetMarkerSize;
        [NMS(Index = 851)]
        /* 0x6E3C */ public float IconBackgroundAlpha;
        [NMS(Index = 395)]
        /* 0x6E40 */ public float IconGlowStrengthActive;
        [NMS(Index = 394)]
        /* 0x6E44 */ public float IconGlowStrengthError;
        [NMS(Index = 397)]
        /* 0x6E48 */ public float IconGlowStrengthHighlight;
        [NMS(Index = 396)]
        /* 0x6E4C */ public float IconGlowStrengthNeutral;
        [NMS(Index = 1022)]
        /* 0x6E50 */ public float IconPulseRate;
        [NMS(Index = 1391)]
        /* 0x6E54 */ public float InfoPortalGuideCycleTime;
        [NMS(Index = 1392)]
        /* 0x6E58 */ public float InfoPortalMilestonesCycleTime;
        [NMS(Index = 1039)]
        /* 0x6E5C */ public float InteractionIconInnerRadius;
        [NMS(Index = 1040)]
        /* 0x6E60 */ public float InteractionIconOuterRadius;
        [NMS(Index = 293)]
        /* 0x6E64 */ public float InteractionInWorldMinScreenDistance;
        [NMS(Index = 294)]
        /* 0x6E68 */ public float InteractionInWorldMinScreenDistanceV2;
        [NMS(Index = 292)]
        /* 0x6E6C */ public float InteractionInWorldPitchDistance;
        [NMS(Index = 295)]
        /* 0x6E70 */ public float InteractionInWorldSeatedNPCHeightAdjust;
        [NMS(Index = 296)]
        /* 0x6E74 */ public float InteractionInWorldSeatedNPCHeightAdjustV2;
        [NMS(Index = 1037)]
        /* 0x6E78 */ public float InteractionLabelHeight;
        [NMS(Index = 1038)]
        /* 0x6E7C */ public float InteractionLabelLineAlpha;
        [NMS(Index = 1042)]
        /* 0x6E80 */ public float InteractionLabelPixelHeightMax;
        [NMS(Index = 1041)]
        /* 0x6E84 */ public float InteractionLabelPixelHeightMin;
        [NMS(Index = 1036)]
        /* 0x6E88 */ public float InteractionLabelRadiusScaler;
        [NMS(Index = 959)]
        /* 0x6E8C */ public float InteractionScanDisplayTime;
        [NMS(Index = 958)]
        /* 0x6E90 */ public float InteractionScanMinTime;
        [NMS(Index = 957)]
        /* 0x6E94 */ public float InteractionScanScanTime;
        [NMS(Index = 962)]
        /* 0x6E98 */ public float InteractionScanSlapOverallTime;
        [NMS(Index = 961)]
        /* 0x6E9C */ public float InteractionScanSlapScale;
        [NMS(Index = 960)]
        /* 0x6EA0 */ public float InteractionScanSlapTime;
        [NMS(Index = 988)]
        /* 0x6EA4 */ public float InventoryFullMessageRepeatTime;
        [NMS(Index = 911)]
        /* 0x6EA8 */ public float InventoryIconTime;
        [NMS(Index = 63)]
        /* 0x6EAC */ public float InvSlotGradientFactor;
        [NMS(Index = 62)]
        /* 0x6EB0 */ public float InvSlotGradientFactorMin;
        [NMS(Index = 64)]
        /* 0x6EB4 */ public float InvSlotGradientTime;
        [NMS(Index = 236)]
        /* 0x6EB8 */ public float InWorldInteractionScreenScale;
        [NMS(Index = 134)]
        /* 0x6EBC */ public float InWorldInteractLabelFarDistance;
        [NMS(Index = 135)]
        /* 0x6EC0 */ public float InWorldInteractLabelFarRange;
        [NMS(Index = 189)]
        /* 0x6EC4 */ public int InWorldInteractLabelHeight;
        [NMS(Index = 131)]
        /* 0x6EC8 */ public float InWorldInteractLabelMinHeadOffset;
        [NMS(Index = 132)]
        /* 0x6ECC */ public float InWorldInteractLabelNearDistance;
        [NMS(Index = 133)]
        /* 0x6ED0 */ public float InWorldInteractLabelNearRange;
        [NMS(Index = 123)]
        /* 0x6ED4 */ public float InWorldInteractLabelScale;
        [NMS(Index = 124)]
        /* 0x6ED8 */ public float InWorldInteractLabelScaleV2;
        [NMS(Index = 188)]
        /* 0x6EDC */ public int InWorldInteractLabelWidth;
        [NMS(Index = 184)]
        /* 0x6EE0 */ public float InWorldNGuiScreenScale;
        [NMS(Index = 237)]
        /* 0x6EE4 */ public float InWorldNPCInteractionScreenScale;
        [NMS(Index = 183)]
        /* 0x6EE8 */ public float InWorldScreenForwardOffset;
        [NMS(Index = 182)]
        /* 0x6EEC */ public float InWorldScreenMinScreenDistance;
        [NMS(Index = 125)]
        /* 0x6EF0 */ public float InWorldScreenScaleDistance;
        [NMS(Index = 36)]
        /* 0x6EF4 */ public float InWorldUIInteractionDistanceWithEyeTrackingEnabled;
        [NMS(Index = 914)]
        /* 0x6EF8 */ public float ItemReceivedMessageTimeToAdd;
        [NMS(Index = 952)]
        /* 0x6EFC */ public float ItemSlotColourTechChargeRate;
        [NMS(Index = 994)]
        /* 0x6F00 */ public float KeepHazardBarActiveTime;
        [NMS(Index = 995)]
        /* 0x6F04 */ public float KeepSecondHazardBarActiveTime;
        [NMS(Index = 889)]
        /* 0x6F08 */ public float LandNotifyHeightThreshold;
        [NMS(Index = 888)]
        /* 0x6F0C */ public float LandNotifySpeedThreshold;
        [NMS(Index = 890)]
        /* 0x6F10 */ public float LandNotifyTimeThreshold;
        [NMS(Index = 706)]
        /* 0x6F14 */ public float LargeSpaceIconSize;
        [NMS(Index = 333)]
        /* 0x6F18 */ public float LoadFadeInDefaultTime;
        [NMS(Index = 118)]
        /* 0x6F1C */ public float LoadingScreenTime;
        [NMS(Index = 117)]
        /* 0x6F20 */ public float LoadingScreenTravelSpeed;
        [NMS(Index = 116)]
        /* 0x6F24 */ public float LoadingTravelDistance;
        [NMS(Index = 1309)]
        /* 0x6F28 */ public float LockOnMarkerSize;
        [NMS(Index = 1310)]
        /* 0x6F2C */ public float LockOnMarkerSizeLock;
        [NMS(Index = 180)]
        /* 0x6F30 */ public float LowerHelmetScreenPitch;
        [NMS(Index = 179)]
        /* 0x6F34 */ public float LowerHelmetScreenScale;
        [NMS(Index = 493)]
        /* 0x6F38 */ public float LowHealthShieldFactor;
        [NMS(Index = 492)]
        /* 0x6F3C */ public float LowHealthShieldMin;
        [NMS(Index = 446)]
        /* 0x6F40 */ public float MaintenanceIconFadeStart;
        [NMS(Index = 447)]
        /* 0x6F44 */ public float MaintenanceIconFadeTime;
        [NMS(Index = 909)]
        /* 0x6F48 */ public float ManualNotificationPauseTime;
        [NMS(Index = 1390)]
        /* 0x6F4C */ public float ManualScrollChangePerInputMax;
        [NMS(Index = 1389)]
        /* 0x6F50 */ public float ManualScrollChangePerInputMin;
        [NMS(Index = 444)]
        /* 0x6F54 */ public float MarkerComponentOffset;
        [NMS(Index = 343)]
        /* 0x6F58 */ public float MarkerHorizonApproachAngle;
        [NMS(Index = 342)]
        /* 0x6F5C */ public float MarkerHorizonMinOffset;
        [NMS(Index = 349)]
        /* 0x6F60 */ public float MarkerHorizonOffPlanetLightBeamAngle;
        [NMS(Index = 341)]
        /* 0x6F64 */ public float MarkerHorizonOffsetAngle;
        [NMS(Index = 350)]
        /* 0x6F68 */ public float MarkerHorizonShipApproachOffset;
        [NMS(Index = 344)]
        /* 0x6F6C */ public float MarkerOffsetTypeAngle;
        [NMS(Index = 348)]
        /* 0x6F70 */ public float MarkerOffsetTypeAngleAsteroid;
        [NMS(Index = 345)]
        /* 0x6F74 */ public float MarkerOffsetTypeAngleBattle;
        [NMS(Index = 346)]
        /* 0x6F78 */ public float MarkerOffsetTypeAngleBounty;
        [NMS(Index = 347)]
        /* 0x6F7C */ public float MarkerOffsetTypeAnglePlayerShip;
        [NMS(Index = 430)]
        /* 0x6F80 */ public float MarkerRingInnerRadius;
        [NMS(Index = 431)]
        /* 0x6F84 */ public float MarkerRingOuterRadius;
        [NMS(Index = 359)]
        /* 0x6F88 */ public float MarkerTagAppearDelay;
        [NMS(Index = 496)]
        /* 0x6F8C */ public int MaxDialogCharSizeIdeographic;
        [NMS(Index = 494)]
        /* 0x6F90 */ public int MaxDialogCharSizeRoman;
        [NMS(Index = 354)]
        /* 0x6F94 */ public int MaxNumMessageBeaconIcons;
        [NMS(Index = 165)]
        /* 0x6F98 */ public float MaxProjectorDistanceFromDefault;
        [NMS(Index = 168)]
        /* 0x6F9C */ public float MaxProjectorGrabDistance;
        [NMS(Index = 76)]
        /* 0x6FA0 */ public int MaxSubstanceMaxAmountForAmountFraction;
        [NMS(Index = 912)]
        /* 0x6FA4 */ public float MessageNotificationTime;
        [NMS(Index = 913)]
        /* 0x6FA8 */ public float MessageTimeQuick;
        [NMS(Index = 99)]
        /* 0x6FAC */ public float MilestoneStingDisplayTime;
        [NMS(Index = 1384)]
        /* 0x6FB0 */ public float MinimumHoldFill;
        [NMS(Index = 97)]
        /* 0x6FB4 */ public float MinSeasonPlayTimeInDays;
        [NMS(Index = 719)]
        /* 0x6FB8 */ public float MissileCentreOffset;
        [NMS(Index = 1315)]
        /* 0x6FBC */ public float MissileIconAttackPulseAmount;
        [NMS(Index = 1314)]
        /* 0x6FC0 */ public float MissileIconAttackPulseTime;
        [NMS(Index = 700)]
        /* 0x6FC4 */ public float MissionCompassIconScaler;
        [NMS(Index = 358)]
        /* 0x6FC8 */ public float MissionDetailsPageBaseHeight;
        [NMS(Index = 521)]
        /* 0x6FCC */ public int MissionLoopCount;
        [NMS(Index = 522)]
        /* 0x6FD0 */ public int MissionLoopCountPirate;
        [NMS(Index = 701)]
        /* 0x6FD4 */ public float MissionMarkerSize;
        [NMS(Index = 355)]
        /* 0x6FD8 */ public float MissionObjectiveBaseHeight;
        [NMS(Index = 356)]
        /* 0x6FDC */ public float MissionObjectiveDoneHeight;
        [NMS(Index = 357)]
        /* 0x6FE0 */ public float MissionObjectiveScrollingExtra;
        [NMS(Index = 523)]
        /* 0x6FE4 */ public int MissionSeedOffset;
        [NMS(Index = 520)]
        /* 0x6FE8 */ public int MissionSpecificMissionPercent;
        [NMS(Index = 504)]
        /* 0x6FEC */ public float MissionStartEndOSDTime;
        [NMS(Index = 505)]
        /* 0x6FF0 */ public float MissionStartEndOSDTimeProcedural;
        [NMS(Index = 503)]
        /* 0x6FF4 */ public float MissionStartEndTime;
        [NMS(Index = 31)]
        /* 0x6FF8 */ public float ModularCustomisationApplyTime;
        [NMS(Index = 1370)]
        /* 0x6FFC */ public float MultiplayerTeleportEffectAppearTime;
        [NMS(Index = 1369)]
        /* 0x7000 */ public float MultiplayerTeleportEffectDisappearTime;
        [NMS(Index = 1335)]
        /* 0x7004 */ public float NGuiActiveAreaOffsetTime;
        [NMS(Index = 1326)]
        /* 0x7008 */ public float NGuiAltPlacementDistanceScrollSpeed;
        [NMS(Index = 1334)]
        /* 0x700C */ public float NGuiCursorOffsetMultiplier;
        [NMS(Index = 281)]
        /* 0x7010 */ public float NGuiHmdOffset;
        [NMS(Index = 1316)]
        /* 0x7014 */ public float NGuiModelRotationDegreesX;
        [NMS(Index = 1317)]
        /* 0x7018 */ public float NGuiModelRotationDegreesY;
        [NMS(Index = 1318)]
        /* 0x701C */ public float NGuiModelRotationDegreesZ;
        [NMS(Index = 1325)]
        /* 0x7020 */ public float NGuiModelViewCdSmoothTime;
        [NMS(Index = 1323)]
        /* 0x7024 */ public float NGuiModelViewDistanceDiscoveryPage;
        [NMS(Index = 1319)]
        /* 0x7028 */ public float NGuiModelViewDistanceGlobal;
        [NMS(Index = 1322)]
        /* 0x702C */ public float NGuiModelViewDistanceShipPage;
        [NMS(Index = 1320)]
        /* 0x7030 */ public float NGuiModelViewDistanceSuitPage;
        [NMS(Index = 1321)]
        /* 0x7034 */ public float NGuiModelViewDistanceWeaponPage;
        [NMS(Index = 1343)]
        /* 0x7038 */ public float NGuiModelViewFadeInAfterRenderTime;
        [NMS(Index = 1324)]
        /* 0x703C */ public float NGuiModelViewFov;
        [NMS(Index = 1328)]
        /* 0x7040 */ public float NGuiModelViewFractionOfBBHeightAboveReflectivePlane;
        [NMS(Index = 1154)]
        /* 0x7044 */ public float NGuiMouseSensitivity;
        [NMS(Index = 1153)]
        /* 0x7048 */ public float NGuiPadSensitivity;
        [NMS(Index = 1327)]
        /* 0x704C */ public float NGuiPlacementAngleScrollSpeed;
        [NMS(Index = 1332)]
        /* 0x7050 */ public float NGuiThumbnailModelRotationDegreesY;
        [NMS(Index = 1333)]
        /* 0x7054 */ public float NGuiThumbnailModelViewDistance;
        [NMS(Index = 864)]
        /* 0x7058 */ public float NotificationBackgroundGradientAlphaInShip;
        [NMS(Index = 863)]
        /* 0x705C */ public float NotificationBackgroundGradientEndOffsetPercentInShip;
        [NMS(Index = 897)]
        /* 0x7060 */ public float NotificationBridgeReachDistance;
        [NMS(Index = 871)]
        /* 0x7064 */ public float NotificationBuildHintStartTime;
        [NMS(Index = 876)]
        /* 0x7068 */ public float NotificationCantFireTime;
        [NMS(Index = 877)]
        /* 0x706C */ public float NotificationDangerTime;
        [NMS(Index = 902)]
        /* 0x7070 */ public float NotificationDeviceIdleTime;
        [NMS(Index = 898)]
        /* 0x7074 */ public float NotificationDiscoveryIdleTime;
        [NMS(Index = 895)]
        /* 0x7078 */ public float NotificationFinalMissionWait;
        [NMS(Index = 893)]
        /* 0x707C */ public float NotificationGoToSpaceStationWait;
        [NMS(Index = 332)]
        /* 0x7080 */ public float NotificationHazardMinTimeAfterRecharge;
        [NMS(Index = 868)]
        /* 0x7084 */ public float NotificationHazardSafeThreshold;
        [NMS(Index = 869)]
        /* 0x7088 */ public float NotificationHazardTimer;
        [NMS(Index = 899)]
        /* 0x708C */ public float NotificationInfoIdleTime;
        [NMS(Index = 870)]
        /* 0x7090 */ public float NotificationInteractHintStartTime;
        [NMS(Index = 872)]
        /* 0x7094 */ public float NotificationJetpackTime;
        [NMS(Index = 881)]
        /* 0x7098 */ public float NotificationMaxPageHintTime;
        [NMS(Index = 880)]
        /* 0x709C */ public float NotificationMessageCycleTime;
        [NMS(Index = 867)]
        /* 0x70A0 */ public float NotificationMinVisibleTime;
        [NMS(Index = 903)]
        /* 0x70A4 */ public float NotificationMissionHintTime;
        [NMS(Index = 904)]
        /* 0x70A8 */ public float NotificationMissionHintTimeCritical;
        [NMS(Index = 905)]
        /* 0x70AC */ public float NotificationMissionHintTimeSecondary;
        [NMS(Index = 894)]
        /* 0x70B0 */ public float NotificationMonolithMissionWait;
        [NMS(Index = 900)]
        /* 0x70B4 */ public float NotificationNewTechIdleTime;
        [NMS(Index = 901)]
        /* 0x70B8 */ public float NotificationScanEventMissionIdleTime;
        [NMS(Index = 878)]
        /* 0x70BC */ public float NotificationScanTime;
        [NMS(Index = 879)]
        /* 0x70C0 */ public float NotificationScanTimeCutoff;
        [NMS(Index = 873)]
        /* 0x70C4 */ public float NotificationShieldTime;
        [NMS(Index = 885)]
        /* 0x70C8 */ public float NotificationShipBoostMinTime;
        [NMS(Index = 886)]
        /* 0x70CC */ public float NotificationShipBoostReminderTime;
        [NMS(Index = 887)]
        /* 0x70D0 */ public float NotificationShipBoostReminderTimeTutorial;
        [NMS(Index = 874)]
        /* 0x70D4 */ public float NotificationShipBoostTime;
        [NMS(Index = 875)]
        /* 0x70D8 */ public float NotificationShipBoostTimeVR;
        [NMS(Index = 882)]
        /* 0x70DC */ public float NotificationShipJumpMinTime;
        [NMS(Index = 883)]
        /* 0x70E0 */ public float NotificationShipJumpReminderTime;
        [NMS(Index = 884)]
        /* 0x70E4 */ public float NotificationShipJumpReminderTutorial;
        [NMS(Index = 865)]
        /* 0x70E8 */ public int NotificationsResourceExtractHintCount;
        [NMS(Index = 866)]
        /* 0x70EC */ public float NotificationStaminaHintDistanceWalked;
        [NMS(Index = 891)]
        /* 0x70F0 */ public float NotificationTimeBeforeHeridiumMarker;
        [NMS(Index = 892)]
        /* 0x70F4 */ public float NotificationUrgentMessageTime;
        [NMS(Index = 896)]
        /* 0x70F8 */ public float NotificationWaypointReachDistance;
        [NMS(Index = 789)]
        /* 0x70FC */ public int NumDeathQuotes;
        [NMS(Index = 515)]
        /* 0x7100 */ public float OnFootDamageDirectionIndicatorFadeRange;
        [NMS(Index = 514)]
        /* 0x7104 */ public float OnFootDamageDirectionIndicatorRadius;
        [NMS(Index = 119)]
        /* 0x7108 */ public float OSDMessagePauseOffscreenAngle;
        [NMS(Index = 321)]
        /* 0x710C */ public int OSDMessageQueueMax;
        [NMS(Index = 320)]
        /* 0x7110 */ public int OSDMessageQueueMin;
        [NMS(Index = 319)]
        /* 0x7114 */ public float OSDMessageQueueSpeedMultiplier;
        [NMS(Index = 73)]
        /* 0x7118 */ public float PadCursorUICurveStrength;
        [NMS(Index = 489)]
        /* 0x711C */ public float PageTurnTime;
        [NMS(Index = 87)]
        /* 0x7120 */ public float ParagraphAutoScrollSpeed;
        [NMS(Index = 941)]
        /* 0x7124 */ public float PauseMenuHoldTime;
        [NMS(Index = 708)]
        /* 0x7128 */ public float PetHoverIconSize;
        [NMS(Index = 141)]
        /* 0x712C */ public float PetHUDMarkerExtraFollowInfoDistance;
        [NMS(Index = 142)]
        /* 0x7130 */ public float PetHUDMarkerHideDistance;
        [NMS(Index = 143)]
        /* 0x7134 */ public float PetHUDMarkerHideDistanceShort;
        [NMS(Index = 144)]
        /* 0x7138 */ public float PetHUDMarkerOffset;
        [NMS(Index = 709)]
        /* 0x713C */ public float PetIconSize;
        [NMS(Index = 145)]
        /* 0x7140 */ public float PetMoodMarkerOffset;
        [NMS(Index = 140)]
        /* 0x7144 */ public float PetSlotUnlockBounceTime;
        [NMS(Index = 615)]
        /* 0x7148 */ public float PhotoModeTimeofDayChange;
        [NMS(Index = 614)]
        /* 0x714C */ public float PhotoModeValueAlpha;
        [NMS(Index = 641)]
        /* 0x7150 */ public float PirateAttackIndicatorRadius;
        [NMS(Index = 640)]
        /* 0x7154 */ public float PirateAttackIndicatorWidth;
        [NMS(Index = 642)]
        /* 0x7158 */ public float PirateAttackProbeDisplayFinishFactor;
        [NMS(Index = 639)]
        /* 0x715C */ public float PirateCountdownTime;
        [NMS(Index = 115)]
        /* 0x7160 */ public float PlacedMarkerFadeTime;
        [NMS(Index = 107)]
        /* 0x7164 */ public float PlanetDataExtraRadius;
        [NMS(Index = 946)]
        /* 0x7168 */ public float PlanetLabelAngle;
        [NMS(Index = 945)]
        /* 0x716C */ public float PlanetLabelTime;
        [NMS(Index = 1167)]
        /* 0x7170 */ public float PlanetPoleMaxDotProduct;
        [NMS(Index = 487)]
        /* 0x7174 */ public float PlanetRaidMarkerOffset;
        [NMS(Index = 654)]
        /* 0x7178 */ public float PlanetScanDelayTime;
        [NMS(Index = 1074)]
        /* 0x717C */ public float PopupActivateTime;
        [NMS(Index = 1075)]
        /* 0x7180 */ public float PopupDeactivateTime;
        [NMS(Index = 1073)]
        /* 0x7184 */ public float PopupDebounceTime;
        [NMS(Index = 1062)]
        /* 0x7188 */ public float PopupSlotWidthOffset;
        [NMS(Index = 322)]
        /* 0x718C */ public float PopupValueSectionBaseHeight;
        [NMS(Index = 323)]
        /* 0x7190 */ public float PopupValueSectionHeight;
        [NMS(Index = 1060)]
        /* 0x7194 */ public float PopupXClampOffset;
        [NMS(Index = 1061)]
        /* 0x7198 */ public float PopupXClampOffsetRightAligned;
        [NMS(Index = 170)]
        /* 0x719C */ public float ProjectorGrabBorderPercent;
        [NMS(Index = 169)]
        /* 0x71A0 */ public float ProjectorGrabDistanceBias;
        [NMS(Index = 166)]
        /* 0x71A4 */ public float ProjectorGrabResetTime;
        [NMS(Index = 164)]
        /* 0x71A8 */ public float ProjectorScale;
        [NMS(Index = 210)]
        /* 0x71AC */ public float QuickMenuAlpha;
        [NMS(Index = 120)]
        /* 0x71B0 */ public float QuickMenuCentrePos;
        [NMS(Index = 122)]
        /* 0x71B4 */ public float QuickMenuCentreSideOffset;
        [NMS(Index = 556)]
        /* 0x71B8 */ public float QuickMenuCloseTime;
        [NMS(Index = 209)]
        /* 0x71BC */ public float QuickMenuCursorScale;
        [NMS(Index = 557)]
        /* 0x71C0 */ public float QuickMenuErrorTime;
        [NMS(Index = 249)]
        /* 0x71C4 */ public float QuickMenuHighlightRate;
        [NMS(Index = 245)]
        /* 0x71C8 */ public float QuickMenuInteractAdjustX;
        [NMS(Index = 246)]
        /* 0x71CC */ public float QuickMenuInteractAdjustY;
        [NMS(Index = 248)]
        /* 0x71D0 */ public int QuickMenuScreenHeight;
        [NMS(Index = 247)]
        /* 0x71D4 */ public int QuickMenuScreenWidth;
        [NMS(Index = 121)]
        /* 0x71D8 */ public float QuickMenuSideOffset;
        [NMS(Index = 241)]
        /* 0x71DC */ public float QuickMenuSwipeHeightMax;
        [NMS(Index = 240)]
        /* 0x71E0 */ public float QuickMenuSwipeHeightMin;
        [NMS(Index = 1129)]
        /* 0x71E4 */ public float RadialMenuInnerRadius;
        [NMS(Index = 1130)]
        /* 0x71E8 */ public float RadialMenuInnerRadiusCursor;
        [NMS(Index = 1131)]
        /* 0x71EC */ public float RadialMenuWedgeOffset;
        [NMS(Index = 476)]
        /* 0x71F0 */ public float RefinerAutoCloseTime;
        [NMS(Index = 464)]
        /* 0x71F4 */ public float RefinerBeginDialInnerRadius;
        [NMS(Index = 463)]
        /* 0x71F8 */ public float RefinerPadStartDecayTime;
        [NMS(Index = 462)]
        /* 0x71FC */ public float RefinerPadStartTime;
        [NMS(Index = 465)]
        /* 0x7200 */ public float RefinerProgressDialInnerRadius;
        [NMS(Index = 445)]
        /* 0x7204 */ public float RepairTechLabelOffset;
        [NMS(Index = 435)]
        /* 0x7208 */ public float RepairTechRepairedMessageTime;
        [NMS(Index = 433)]
        /* 0x720C */ public float RepairTechRepairedWaitTime1;
        [NMS(Index = 434)]
        /* 0x7210 */ public float RepairTechRepairedWaitTime2;
        [NMS(Index = 1360)]
        /* 0x7214 */ public float ReportBaseFlashDelay;
        [NMS(Index = 1359)]
        /* 0x7218 */ public float ReportBaseFlashIntensity;
        [NMS(Index = 1358)]
        /* 0x721C */ public float ReportBaseFlashTime;
        [NMS(Index = 1361)]
        /* 0x7220 */ public float ReportCameraSpeed;
        [NMS(Index = 777)]
        /* 0x7224 */ public float ScanEventArrowOffsetMultiplier;
        [NMS(Index = 779)]
        /* 0x7228 */ public float ScanEventArrowOffsetMultiplierFresh;
        [NMS(Index = 780)]
        /* 0x722C */ public float ScanEventArrowOffsetMultiplierLerpTime;
        [NMS(Index = 778)]
        /* 0x7230 */ public float ScanEventArrowOffsetMultiplierOneEvent;
        [NMS(Index = 776)]
        /* 0x7234 */ public float ScanEventArrowPlayerFadeDistance;
        [NMS(Index = 775)]
        /* 0x7238 */ public float ScanEventArrowPlayerFadeRange;
        [NMS(Index = 781)]
        /* 0x723C */ public float ScanEventArrowSecondaryAlpha;
        [NMS(Index = 774)]
        /* 0x7240 */ public float ScanEventArrowShipFadeDistance;
        [NMS(Index = 773)]
        /* 0x7244 */ public float ScanEventArrowShipFadeRange;
        [NMS(Index = 782)]
        /* 0x7248 */ public GcAudioWwiseEvents ScanEventIconAudio;
        [NMS(Index = 352)]
        /* 0x724C */ public float ScannableIconMergeAngle;
        [NMS(Index = 1043)]
        /* 0x7250 */ public float ScanTime;
        [NMS(Index = 96)]
        /* 0x7254 */ public float SeasonalRingChangeTime;
        [NMS(Index = 94)]
        /* 0x7258 */ public float SeasonalRingMultiplier;
        [NMS(Index = 95)]
        /* 0x725C */ public float SeasonalRingPulseTime;
        [NMS(Index = 29)]
        /* 0x7260 */ public float SeasonEndAutoHighlightDuration;
        [NMS(Index = 30)]
        /* 0x7264 */ public float SeasonEndAutoHighlightDurationMilestone;
        [NMS(Index = 28)]
        /* 0x7268 */ public GcAudioWwiseEvents SeasonEndAutoHighlightSFX;
        [NMS(Index = 27)]
        /* 0x726C */ public float SeasonEndRewardsMaxScrollRate;
        [NMS(Index = 26)]
        /* 0x7270 */ public float SeasonEndRewardsPageOpenDelayTime;
        [NMS(Index = 92)]
        /* 0x7274 */ public int SeasonFinalStageIndex;
        [NMS(Index = 861)]
        /* 0x7278 */ public float SeasonMessageDelayTime;
        [NMS(Index = 85)]
        /* 0x727C */ public float SentinelsDisabledHUDMessageTime;
        [NMS(Index = 1375)]
        /* 0x7280 */ public float SettlementStatInnerRadius;
        [NMS(Index = 1376)]
        /* 0x7284 */ public float SettlementStatOuterRadius;
        [NMS(Index = 1004)]
        /* 0x7288 */ public float ShieldHazardPulseRate;
        [NMS(Index = 1006)]
        /* 0x728C */ public float ShieldHazardPulseThreshold;
        [NMS(Index = 1003)]
        /* 0x7290 */ public float ShieldPulseTime;
        [NMS(Index = 1002)]
        /* 0x7294 */ public float ShieldSpringTime;
        [NMS(Index = 0)]
        /* 0x7298 */ public float ShipBuilderBarTime;
        [NMS(Index = 7)]
        /* 0x729C */ public float ShipBuilderEndCircleRadius;
        [NMS(Index = 11)]
        /* 0x72A0 */ public float ShipBuilderLineLengthFadeMax;
        [NMS(Index = 10)]
        /* 0x72A4 */ public float ShipBuilderLineLengthFadeMin;
        [NMS(Index = 9)]
        /* 0x72A8 */ public float ShipBuilderLineMinFade;
        [NMS(Index = 8)]
        /* 0x72AC */ public float ShipBuilderLineWidth;
        [NMS(Index = 5)]
        /* 0x72B0 */ public float ShipBuilderSlotDropLength;
        [NMS(Index = 1)]
        /* 0x72B4 */ public float ShipBuilderSlotLineDefaultWidthFactor;
        [NMS(Index = 3)]
        /* 0x72B8 */ public float ShipBuilderSlotLineMaxFactor;
        [NMS(Index = 2)]
        /* 0x72BC */ public float ShipBuilderSlotLineMinFactor;
        [NMS(Index = 4)]
        /* 0x72C0 */ public float ShipBuilderSlotStartOffset;
        [NMS(Index = 6)]
        /* 0x72C4 */ public float ShipBuilderStartCircleRadius;
        [NMS(Index = 513)]
        /* 0x72C8 */ public float ShipDamageDirectionIndicatorFadeRange;
        [NMS(Index = 512)]
        /* 0x72CC */ public float ShipDamageDirectionIndicatorRadius;
        [NMS(Index = 771)]
        /* 0x72D0 */ public float ShipDesatDamper;
        [NMS(Index = 770)]
        /* 0x72D4 */ public float ShipFullscreenDamper;
        [NMS(Index = 769)]
        /* 0x72D8 */ public float ShipFullscreenDamperMin;
        [NMS(Index = 661)]
        /* 0x72DC */ public float ShipHeadsUpDisplayDistance;
        [NMS(Index = 662)]
        /* 0x72E0 */ public float ShipHeadsUpLineFadeTime;
        [NMS(Index = 297)]
        /* 0x72E4 */ public float ShipHologramInWorldUIHeightAdjust;
        [NMS(Index = 298)]
        /* 0x72E8 */ public float ShipHologramInWorldUIHeightAdjustV2;
        [NMS(Index = 984)]
        /* 0x72EC */ public float ShipHUDHitPointSize;
        [NMS(Index = 983)]
        /* 0x72F0 */ public float ShipHUDHitPointTime;
        [NMS(Index = 136)]
        /* 0x72F4 */ public float ShipHUDMarkerHideDistance;
        [NMS(Index = 137)]
        /* 0x72F8 */ public float ShipHUDMarkerOffset;
        [NMS(Index = 968)]
        /* 0x72FC */ public float ShipHUDMaxOffscreenTargetDist;
        [NMS(Index = 965)]
        /* 0x7300 */ public float ShipHUDMissileLockSizeMax;
        [NMS(Index = 964)]
        /* 0x7304 */ public float ShipHUDMissileLockSizeMin;
        [NMS(Index = 967)]
        /* 0x7308 */ public float ShipHUDMissileLockSpringFast;
        [NMS(Index = 966)]
        /* 0x730C */ public float ShipHUDMissileLockSpringSlow;
        [NMS(Index = 971)]
        /* 0x7310 */ public float ShipHUDTargetAlpha;
        [NMS(Index = 972)]
        /* 0x7314 */ public float ShipHUDTargetArrowLength;
        [NMS(Index = 976)]
        /* 0x7318 */ public float ShipHUDTargetArrowsRotationRate;
        [NMS(Index = 973)]
        /* 0x731C */ public float ShipHUDTargetMinDist;
        [NMS(Index = 969)]
        /* 0x7320 */ public float ShipHUDTargetRadius;
        [NMS(Index = 974)]
        /* 0x7324 */ public float ShipHUDTargetRange;
        [NMS(Index = 975)]
        /* 0x7328 */ public float ShipHUDTargetScale;
        [NMS(Index = 970)]
        /* 0x732C */ public float ShipHUDTargetTriangleRadius;
        [NMS(Index = 499)]
        /* 0x7330 */ public float ShipOverheatSwitchMessageTime;
        [NMS(Index = 498)]
        /* 0x7334 */ public float ShipOverheatSwitchMessageWait;
        [NMS(Index = 1368)]
        /* 0x7338 */ public float ShipScreenTexScale;
        [NMS(Index = 232)]
        /* 0x733C */ public float ShipSideScreenHeight;
        [NMS(Index = 299)]
        /* 0x7340 */ public float ShopInteractionInWorldForcedOffset;
        [NMS(Index = 300)]
        /* 0x7344 */ public float ShopInteractionInWorldForcedOffsetV2;
        [NMS(Index = 103)]
        /* 0x7348 */ public int ShowDaysIfLessThan;
        [NMS(Index = 102)]
        /* 0x734C */ public int ShowHoursIfLessThan;
        [NMS(Index = 104)]
        /* 0x7350 */ public int ShowWeeksIfLessThan;
        [NMS(Index = 707)]
        /* 0x7354 */ public float SmallSpaceIconSize;
        [NMS(Index = 234)]
        /* 0x7358 */ public float SolidPointerLengthScale;
        [NMS(Index = 235)]
        /* 0x735C */ public float SolidPointerMaxLength;
        [NMS(Index = 233)]
        /* 0x7360 */ public float SolidPointerScale;
        [NMS(Index = 1201)]
        /* 0x7364 */ public float SpaceMapActionScale;
        [NMS(Index = 1197)]
        /* 0x7368 */ public float SpaceMapAnomalyScale;
        [NMS(Index = 1187)]
        /* 0x736C */ public float SpaceMapAspectRatio;
        [NMS(Index = 1213)]
        /* 0x7370 */ public float SpaceMapCamAngle;
        [NMS(Index = 1214)]
        /* 0x7374 */ public float SpaceMapCamDistance;
        [NMS(Index = 1212)]
        /* 0x7378 */ public float SpaceMapCamHeight;
        [NMS(Index = 534)]
        /* 0x737C */ public float SpaceMapCockpitAngle;
        [NMS(Index = 525)]
        /* 0x7380 */ public float SpaceMapCockpitScale;
        [NMS(Index = 532)]
        /* 0x7384 */ public float SpaceMapCockpitScaleAdjustAlien;
        [NMS(Index = 526)]
        /* 0x7388 */ public float SpaceMapCockpitScaleAdjustDropShip;
        [NMS(Index = 527)]
        /* 0x738C */ public float SpaceMapCockpitScaleAdjustFighter;
        [NMS(Index = 533)]
        /* 0x7390 */ public float SpaceMapCockpitScaleAdjustRobot;
        [NMS(Index = 530)]
        /* 0x7394 */ public float SpaceMapCockpitScaleAdjustRoyal;
        [NMS(Index = 531)]
        /* 0x7398 */ public float SpaceMapCockpitScaleAdjustSail;
        [NMS(Index = 528)]
        /* 0x739C */ public float SpaceMapCockpitScaleAdjustScientific;
        [NMS(Index = 529)]
        /* 0x73A0 */ public float SpaceMapCockpitScaleAdjustShuttle;
        [NMS(Index = 1206)]
        /* 0x73A4 */ public float SpaceMapDistance;
        [NMS(Index = 1189)]
        /* 0x73A8 */ public float SpaceMapDistanceLogScaler;
        [NMS(Index = 1208)]
        /* 0x73AC */ public float SpaceMapDistanceMultiplier;
        [NMS(Index = 1188)]
        /* 0x73B0 */ public float SpaceMapDistanceScale;
        [NMS(Index = 1211)]
        /* 0x73B4 */ public float SpaceMapFadeAngleMax;
        [NMS(Index = 1210)]
        /* 0x73B8 */ public float SpaceMapFadeAngleMin;
        [NMS(Index = 1186)]
        /* 0x73BC */ public float SpaceMapFoV;
        [NMS(Index = 1195)]
        /* 0x73C0 */ public float SpaceMapFreighterScale;
        [NMS(Index = 1209)]
        /* 0x73C4 */ public float SpaceMapHorizonThickness;
        [NMS(Index = 1216)]
        /* 0x73C8 */ public float SpaceMapLightPitch;
        [NMS(Index = 1217)]
        /* 0x73CC */ public float SpaceMapLightYaw;
        [NMS(Index = 1170)]
        /* 0x73D0 */ public float SpaceMapLineBaseFade;
        [NMS(Index = 1169)]
        /* 0x73D4 */ public float SpaceMapLineBaseScale;
        [NMS(Index = 1168)]
        /* 0x73D8 */ public float SpaceMapLineWidth;
        [NMS(Index = 1205)]
        /* 0x73DC */ public float SpaceMapMarkerScale;
        [NMS(Index = 1207)]
        /* 0x73E0 */ public float SpaceMapMaxTraderDistance;
        [NMS(Index = 1200)]
        /* 0x73E4 */ public float SpaceMapMoonScale;
        [NMS(Index = 1194)]
        /* 0x73E8 */ public float SpaceMapObjectScale;
        [NMS(Index = 1204)]
        /* 0x73EC */ public float SpaceMapPirateFreighterScale;
        [NMS(Index = 1203)]
        /* 0x73F0 */ public float SpaceMapPirateFrigateScale;
        [NMS(Index = 1199)]
        /* 0x73F4 */ public float SpaceMapPlanetLineOffset;
        [NMS(Index = 1198)]
        /* 0x73F8 */ public float SpaceMapPlanetScale;
        [NMS(Index = 1191)]
        /* 0x73FC */ public float SpaceMapScaleMin;
        [NMS(Index = 1193)]
        /* 0x7400 */ public float SpaceMapScaleRangeMax;
        [NMS(Index = 1192)]
        /* 0x7404 */ public float SpaceMapScaleRangeMin;
        [NMS(Index = 1171)]
        /* 0x7408 */ public float SpaceMapShipCombineDistance;
        [NMS(Index = 1202)]
        /* 0x740C */ public float SpaceMapShipScale;
        [NMS(Index = 1215)]
        /* 0x7410 */ public float SpaceMapShipScaleMin;
        [NMS(Index = 1196)]
        /* 0x7414 */ public float SpaceMapStationScale;
        [NMS(Index = 705)]
        /* 0x7418 */ public float SpaceMarkersBattleOffset;
        [NMS(Index = 704)]
        /* 0x741C */ public float SpaceMarkersOffset;
        [NMS(Index = 110)]
        /* 0x7420 */ public float StackSizeChangeMaxRate;
        [NMS(Index = 109)]
        /* 0x7424 */ public float StackSizeChangeMinRate;
        [NMS(Index = 108)]
        /* 0x7428 */ public float StackSizeRateChangeRate;
        [NMS(Index = 100)]
        /* 0x742C */ public float StageStingDisplayTime;
        [NMS(Index = 506)]
        /* 0x7430 */ public float StandingRewardOSDTime;
        [NMS(Index = 860)]
        /* 0x7434 */ public float StatsMessageDelayTime;
        [NMS(Index = 16)]
        /* 0x7438 */ public float StoreDialDecayTime;
        [NMS(Index = 15)]
        /* 0x743C */ public float StoreDialHoldTime;
        [NMS(Index = 17)]
        /* 0x7440 */ public float StoreDialInnerRadius;
        [NMS(Index = 18)]
        /* 0x7444 */ public float StoreDialOuterRadius;
        [NMS(Index = 70)]
        /* 0x7448 */ public float SuperchargeGradientFactor;
        [NMS(Index = 69)]
        /* 0x744C */ public float SuperchargeGradientFactorMin;
        [NMS(Index = 71)]
        /* 0x7450 */ public float SuperchargeGradientTime;
        [NMS(Index = 772)]
        /* 0x7454 */ public float SurveyObjectArrowOffsetMultiplier;
        [NMS(Index = 340)]
        /* 0x7458 */ public float TakeoffFuelMessageTime;
        [NMS(Index = 565)]
        /* 0x745C */ public float TalkBoxAlienTextSpeed;
        [NMS(Index = 567)]
        /* 0x7460 */ public float TalkBoxAlienTextTimeMax;
        [NMS(Index = 566)]
        /* 0x7464 */ public float TalkBoxAlienTextTimeMin;
        [NMS(Index = 540)]
        /* 0x7468 */ public float TargetDisplayDamageFlashTime;
        [NMS(Index = 535)]
        /* 0x746C */ public float TargetDisplayScale;
        [NMS(Index = 537)]
        /* 0x7470 */ public float TargetDisplayShipScale;
        [NMS(Index = 536)]
        /* 0x7474 */ public float TargetDisplayTorpedoScale;
        [NMS(Index = 1160)]
        /* 0x7478 */ public float TargetMarkerFadeAngleMin;
        [NMS(Index = 1161)]
        /* 0x747C */ public float TargetMarkerFadeAngleRange;
        [NMS(Index = 1159)]
        /* 0x7480 */ public float TargetMarkerScaleEnd;
        [NMS(Index = 1158)]
        /* 0x7484 */ public float TargetMarkerScaleStart;
        [NMS(Index = 1342)]
        /* 0x7488 */ public float TargetParallaxMaintenancePageMultiplier;
        [NMS(Index = 1341)]
        /* 0x748C */ public float TargetParallaxMouseMultiplier;
        [NMS(Index = 986)]
        /* 0x7490 */ public float TargetScreenDistance;
        [NMS(Index = 985)]
        /* 0x7494 */ public float TargetScreenFoV;
        [NMS(Index = 787)]
        /* 0x7498 */ public float TechDisplayDelayTime;
        [NMS(Index = 437)]
        /* 0x749C */ public float TechPopupBuildLayerHeight;
        [NMS(Index = 436)]
        /* 0x74A0 */ public float TechPopupRepairLayerHeight;
        [NMS(Index = 438)]
        /* 0x74A4 */ public float TechPopupRequirementHeight;
        [NMS(Index = 1365)]
        /* 0x74A8 */ public float TextChatMaxDisplayTime;
        [NMS(Index = 1366)]
        /* 0x74AC */ public float TextChatStayBigAfterTextInput;
        [NMS(Index = 173)]
        /* 0x74B0 */ public float TextPrintoutMultiplier;
        [NMS(Index = 174)]
        /* 0x74B4 */ public float TextPrintoutMultiplierAlien;
        [NMS(Index = 1398)]
        /* 0x74B8 */ public float TextTouchScrollCap;
        [NMS(Index = 750)]
        /* 0x74BC */ public float ThirdPersonCrosshairCircle1Distance;
        [NMS(Index = 751)]
        /* 0x74C0 */ public float ThirdPersonCrosshairCircle2Distance;
        [NMS(Index = 749)]
        /* 0x74C4 */ public float ThirdPersonCrosshairDistance;
        [NMS(Index = 579)]
        /* 0x74C8 */ public float TimedEventLookTime;
        [NMS(Index = 910)]
        /* 0x74CC */ public float TooltipTime;
        [NMS(Index = 1399)]
        /* 0x74D0 */ public float TouchScrollChangePageThreshold;
        [NMS(Index = 1397)]
        /* 0x74D4 */ public float TouchScrollMaxDelta;
        [NMS(Index = 747)]
        /* 0x74D8 */ public float TrackCriticalHitSize;
        [NMS(Index = 748)]
        /* 0x74DC */ public float TrackCriticalPulseTime;
        [NMS(Index = 723)]
        /* 0x74E0 */ public float TrackLeadTargetInScale;
        [NMS(Index = 720)]
        /* 0x74E4 */ public float TrackMissileTargetPulseRate;
        [NMS(Index = 713)]
        /* 0x74E8 */ public float TrackPoliceFreighterCentreOffset;
        [NMS(Index = 712)]
        /* 0x74EC */ public float TrackPrimaryCentreOffset;
        [NMS(Index = 725)]
        /* 0x74F0 */ public float TrackReticuleAngle;
        [NMS(Index = 727)]
        /* 0x74F4 */ public float TrackReticuleInactiveTime;
        [NMS(Index = 726)]
        /* 0x74F8 */ public float TrackReticuleInTime;
        [NMS(Index = 729)]
        /* 0x74FC */ public float TrackReticuleRandomDelay;
        [NMS(Index = 728)]
        /* 0x7500 */ public float TrackReticuleRandomTime;
        [NMS(Index = 724)]
        /* 0x7504 */ public float TrackReticuleScale;
        [NMS(Index = 721)]
        /* 0x7508 */ public float TrackScaleCritical;
        [NMS(Index = 722)]
        /* 0x750C */ public float TrackScaleHit;
        [NMS(Index = 714)]
        /* 0x7510 */ public float TrackTimerAlpha;
        [NMS(Index = 718)]
        /* 0x7514 */ public float TrackTimerIconExclaimRadius;
        [NMS(Index = 717)]
        /* 0x7518 */ public float TrackTimerIconInnerRadius;
        [NMS(Index = 716)]
        /* 0x751C */ public float TrackTimerIconOuterRadius;
        [NMS(Index = 715)]
        /* 0x7520 */ public float TrackTimerRadarPulseSize;
        [NMS(Index = 711)]
        /* 0x7524 */ public float TrackTypeIconSize;
        [NMS(Index = 14)]
        /* 0x7528 */ public float TradePageNotifyOffset;
        [NMS(Index = 351)]
        /* 0x752C */ public float TransferPopupCursorOffsetFactor;
        [NMS(Index = 578)]
        /* 0x7530 */ public float TransferSendOffscreenBorder;
        [NMS(Index = 488)]
        /* 0x7534 */ public float TransitionOffset;
        [NMS(Index = 302)]
        /* 0x7538 */ public float TravelLineThickness;
        [NMS(Index = 301)]
        /* 0x753C */ public float TravelTargetRadius;
        [NMS(Index = 21)]
        /* 0x7540 */ public float TrialUpsellDeclineDecayTimeQuick;
        [NMS(Index = 23)]
        /* 0x7544 */ public float TrialUpsellDeclineDecayTimeSlow;
        [NMS(Index = 24)]
        /* 0x7548 */ public float TrialUpsellDeclineDialInnerRadius;
        [NMS(Index = 25)]
        /* 0x754C */ public float TrialUpsellDeclineDialOuterRadius;
        [NMS(Index = 20)]
        /* 0x7550 */ public float TrialUpsellDeclineHoldTimeQuick;
        [NMS(Index = 22)]
        /* 0x7554 */ public float TrialUpsellDeclineHoldTimeSlow;
        [NMS(Index = 83)]
        /* 0x7558 */ public int UnknownWordsToShowInCatalogue;
        [NMS(Index = 86)]
        /* 0x755C */ public float UseZoomedOutBuildCamRadius;
        [NMS(Index = 194)]
        /* 0x7560 */ public int VRFaceLockedScreenHeight;
        [NMS(Index = 193)]
        /* 0x7564 */ public int VRFaceLockedScreenWidth;
        [NMS(Index = 338)]
        /* 0x7568 */ public float WantedDetectMessageTime;
        [NMS(Index = 339)]
        /* 0x756C */ public float WantedDetectMinTimeout;
        [NMS(Index = 856)]
        /* 0x7570 */ public float WantedLevelScanAlpha;
        [NMS(Index = 857)]
        /* 0x7574 */ public float WantedLevelScannedRate;
        [NMS(Index = 854)]
        /* 0x7578 */ public float WantedLevelTimeoutPulseRate;
        [NMS(Index = 855)]
        /* 0x757C */ public float WantedLevelWitnessAlpha;
        [NMS(Index = 853)]
        /* 0x7580 */ public float WantedLevelWitnessOffset;
        [NMS(Index = 852)]
        /* 0x7584 */ public float WantedLevelWitnessPulseRate;
        [NMS(Index = 113)]
        /* 0x7588 */ public float ZoomFactorOverride;
        [NMS(Index = 922)]
        /* 0x758C */ public float ZoomHUDElementsOffsetX;
        [NMS(Index = 923)]
        /* 0x7590 */ public float ZoomHUDElementsOffsetY;
        [NMS(Index = 924)]
        /* 0x7594 */ public float ZoomHUDElementTime;
        [NMS(Index = 1261)]
        /* 0x7598 */ public NMSString0x100 HUDCircleAnimIcon;
        [NMS(Index = 1259)]
        /* 0x7698 */ public NMSString0x100 HUDDeathPointIcon;
        [NMS(Index = 1260)]
        /* 0x7798 */ public NMSString0x100 HUDHexAnimIcon;
        [NMS(Index = 1255)]
        /* 0x7898 */ public NMSString0x100 HUDMarkerColourIcon;
        [NMS(Index = 1253)]
        /* 0x7998 */ public NMSString0x100 HUDMarkerIcon;
        [NMS(Index = 1254)]
        /* 0x7A98 */ public NMSString0x100 HUDMarkerPrimaryIndicatorIcon;
        [NMS(Index = 1256)]
        /* 0x7B98 */ public NMSString0x100 HUDPointIcon;
        [NMS(Index = 1258)]
        /* 0x7C98 */ public NMSString0x100 HUDSaveIcon;
        [NMS(Index = 1257)]
        /* 0x7D98 */ public NMSString0x100 HUDSpaceshipIcon;
        [NMS(Index = 1021)]
        /* 0x7E98 */ public NMSString0x80 CamoNormalTexture;
        [NMS(Index = 1020)]
        /* 0x7F18 */ public NMSString0x80 CamoTexture;
        [NMS(Index = 920)]
        /* 0x7F98 */ public NMSString0x20 DistanceUnitKM;
        [NMS(Index = 919)]
        /* 0x7FB8 */ public NMSString0x20 DistanceUnitM;
        [NMS(Index = 921)]
        /* 0x7FD8 */ public NMSString0x20 DistanceUnitMpS;
        [NMS(Index = 497)]
        /* 0x7FF8 */ public NMSString0x20 MaxDialogCharSizeIdeographicString;
        [NMS(Index = 495)]
        /* 0x8018 */ public NMSString0x20 MaxDialogCharSizeRomanString;
        [NMS(Index = 190)]
        /* 0x8038 */ public NMSString0x20 VRDistanceWarningUIFile;
        [NMS(Index = 385, Size = 0x10, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x8058 */ public bool[] BuildMenuUseSmallIconOnPad;
        [NMS(Index = 176)]
        /* 0x8068 */ public bool AllowInWorldDebugBorders;
        [NMS(Index = 167)]
        /* 0x8069 */ public bool AllowProjectorRepositioning;
        [NMS(Index = 309)]
        /* 0x806A */ public bool AlwaysCloseQuickMenu;
        [NMS(Index = 653)]
        /* 0x806B */ public TkCurveType ArrowBounceLeftCurve;
        [NMS(Index = 649)]
        /* 0x806C */ public TkCurveType ArrowBounceRightCurve;
        [NMS(Index = 88)]
        /* 0x806D */ public bool AutoScrollParagraphs;
        [NMS(Index = 413)]
        /* 0x806E */ public bool BaseBuildingSmoothMenuWhileSnapped;
        [NMS(Index = 78)]
        /* 0x806F */ public bool BigPicking;
        [NMS(Index = 79)]
        /* 0x8070 */ public bool BigPickingUsesNumbers;
        [NMS(Index = 152)]
        /* 0x8071 */ public bool BinocularScanScreen;
        [NMS(Index = 374)]
        /* 0x8072 */ public TkCurveType CompassCurve;
        [NMS(Index = 735)]
        /* 0x8073 */ public bool CreatureInteractLabelUseBB;
        [NMS(Index = 734)]
        /* 0x8074 */ public TkCurveType CreatureReticuleAlphaCurve;
        [NMS(Index = 733)]
        /* 0x8075 */ public TkCurveType CreatureReticuleScaleCurve;
        [NMS(Index = 674)]
        /* 0x8076 */ public TkCurveType CrosshairLeadScaleCurve;
        [NMS(Index = 692)]
        /* 0x8077 */ public TkCurveType CrosshairTargetLockAlphaCurve;
        [NMS(Index = 691)]
        /* 0x8078 */ public TkCurveType CrosshairTargetLockCurve;
        [NMS(Index = 607)]
        /* 0x8079 */ public TkCurveType DamageNumberUpCurve;
        [NMS(Index = 315)]
        /* 0x807A */ public bool DebugInventoryIndices;
        [NMS(Index = 553)]
        /* 0x807B */ public bool DebugMarkerLabels;
        [NMS(Index = 312)]
        /* 0x807C */ public bool DebugMissionLogText;
        [NMS(Index = 314)]
        /* 0x807D */ public bool DebugPopupSizes;
        [NMS(Index = 313)]
        /* 0x807E */ public bool DebugShowMaintenanceScreenCentre;
        [NMS(Index = 1385)]
        /* 0x807F */ public bool EnableAccessibleUIOnSwitch;
        [NMS(Index = 441)]
        /* 0x8080 */ public bool EnableBlackouts;
        [NMS(Index = 791)]
        /* 0x8081 */ public bool EnableBuilderRobotGreekConversion;
        [NMS(Index = 238)]
        /* 0x8082 */ public bool EnableCraftingTree;
        [NMS(Index = 175)]
        /* 0x8083 */ public bool EnableHandMenuButtons;
        [NMS(Index = 207)]
        /* 0x8084 */ public bool EnableHandMenuDebug;
        [NMS(Index = 792)]
        /* 0x8085 */ public bool EnableKanaConversion;
        [NMS(Index = 81)]
        /* 0x8086 */ public bool EnablePopupUses;
        [NMS(Index = 316)]
        /* 0x8087 */ public bool FixedInventoryIconPositions;
        [NMS(Index = 1072)]
        /* 0x8088 */ public TkCurveType FrontendBootBarCurve;
        [NMS(Index = 1057)]
        /* 0x8089 */ public TkCurveType FrontendConfirmCurve;
        [NMS(Index = 1148)]
        /* 0x808A */ public TkCurveType FrontendDoFCurve;
        [NMS(Index = 1147)]
        /* 0x808B */ public bool FrontendDoFEnableBokeh;
        [NMS(Index = 862)]
        /* 0x808C */ public bool HideExtremePlanetNotifications;
        [NMS(Index = 1363)]
        /* 0x808D */ public bool HideQuickMenuControls;
        [NMS(Index = 1296)]
        /* 0x808E */ public TkCurveType HUDMarkerActiveCurve;
        [NMS(Index = 1266)]
        /* 0x808F */ public TkCurveType HUDMarkerAnimAlphaCurve;
        [NMS(Index = 1267)]
        /* 0x8090 */ public TkCurveType HUDMarkerAnimCurve;
        [NMS(Index = 820)]
        /* 0x8091 */ public TkCurveType HUDPlayerTrackArrowEnergyShieldDepletedCurve;
        [NMS(Index = 825)]
        /* 0x8092 */ public TkCurveType HUDPlayerTrackArrowEnergyShieldStartChargeCurve;
        [NMS(Index = 291)]
        /* 0x8093 */ public bool InteractionInWorldPlayerCamAlways;
        [NMS(Index = 963)]
        /* 0x8094 */ public TkCurveType InteractionScanSlapCurve;
        [NMS(Index = 500)]
        /* 0x8095 */ public bool LeadTargetEnabled;
        [NMS(Index = 990)]
        /* 0x8096 */ public bool ModelRendererBGPass;
        [NMS(Index = 991)]
        /* 0x8097 */ public bool ModelRendererPass1;
        [NMS(Index = 992)]
        /* 0x8098 */ public bool ModelRendererPass2;
        [NMS(Index = 1344)]
        /* 0x8099 */ public TkCurveType NGuiModelViewFadeInAfterRenderCurve;
        [NMS(Index = 1345)]
        /* 0x809A */ public bool NGuiUseSeparateLayersForModelAndReflection;
        [NMS(Index = 195)]
        /* 0x809B */ public bool OnlyShowEjectHandlesInVR;
        [NMS(Index = 59)]
        /* 0x809C */ public TkCurveType PadCursorUICurve;
        [NMS(Index = 490)]
        /* 0x809D */ public TkCurveType PageTurnCurve;
        [NMS(Index = 491)]
        /* 0x809E */ public TkCurveType PageTurnFadeCurve;
        [NMS(Index = 1076)]
        /* 0x809F */ public TkCurveType PopupActivateCurve1;
        [NMS(Index = 1077)]
        /* 0x80A0 */ public TkCurveType PopupActivateCurve2;
        [NMS(Index = 542)]
        /* 0x80A1 */ public bool ProgressiveDialogStyle;
        [NMS(Index = 1364)]
        /* 0x80A2 */ public bool QuickMenuAllowCycle;
        [NMS(Index = 239)]
        /* 0x80A3 */ public bool QuickMenuEnableSwipe;
        [NMS(Index = 311)]
        /* 0x80A4 */ public bool RepairTechUseTechIcon;
        [NMS(Index = 74)]
        /* 0x80A5 */ public bool ReplaceItemBarWithNumbers;
        [NMS(Index = 1005)]
        /* 0x80A6 */ public bool ShieldHUDAlwaysOn;
        [NMS(Index = 555)]
        /* 0x80A7 */ public bool ShowDamageNumbers;
        [NMS(Index = 44)]
        /* 0x80A8 */ public bool ShowDifficultyForBases;
        [NMS(Index = 859)]
        /* 0x80A9 */ public bool ShowJetpackNotificationForNonTerrain;
        [NMS(Index = 586)]
        /* 0x80AA */ public bool ShowOnscreenPredatorMarkers;
        [NMS(Index = 45)]
        /* 0x80AB */ public bool ShowPadlockForLockedSettings;
        [NMS(Index = 191)]
        /* 0x80AC */ public bool ShowVRDistanceWarning;
        [NMS(Index = 112)]
        /* 0x80AD */ public bool SkipShopIntro;
        [NMS(Index = 1190)]
        /* 0x80AE */ public TkCurveType SpaceMapDistanceCurve;
        [NMS(Index = 1176)]
        /* 0x80AF */ public bool SpaceMapShowAnomaly;
        [NMS(Index = 1177)]
        /* 0x80B0 */ public bool SpaceMapShowAnomalyLines;
        [NMS(Index = 1183)]
        /* 0x80B1 */ public bool SpaceMapShowFrieghterLines;
        [NMS(Index = 1182)]
        /* 0x80B2 */ public bool SpaceMapShowFrieghters;
        [NMS(Index = 1178)]
        /* 0x80B3 */ public bool SpaceMapShowNexus;
        [NMS(Index = 1179)]
        /* 0x80B4 */ public bool SpaceMapShowNexusLines;
        [NMS(Index = 1173)]
        /* 0x80B5 */ public bool SpaceMapShowPlanetLines;
        [NMS(Index = 1172)]
        /* 0x80B6 */ public bool SpaceMapShowPlanets;
        [NMS(Index = 1185)]
        /* 0x80B7 */ public bool SpaceMapShowPulseEncounterLines;
        [NMS(Index = 1184)]
        /* 0x80B8 */ public bool SpaceMapShowPulseEncounters;
        [NMS(Index = 1181)]
        /* 0x80B9 */ public bool SpaceMapShowShipLines;
        [NMS(Index = 1180)]
        /* 0x80BA */ public bool SpaceMapShowShips;
        [NMS(Index = 1174)]
        /* 0x80BB */ public bool SpaceMapShowStation;
        [NMS(Index = 1175)]
        /* 0x80BC */ public bool SpaceMapShowStationLines;
        [NMS(Index = 501)]
        /* 0x80BD */ public bool SpaceOnlyLeadTargetEnabled;
        [NMS(Index = 82)]
        /* 0x80BE */ public bool TechBoxesCanStack;
        [NMS(Index = 745)]
        /* 0x80BF */ public TkCurveType TrackCritCurve;
        [NMS(Index = 731)]
        /* 0x80C0 */ public TkCurveType TrackReticuleInAngleCurve;
        [NMS(Index = 730)]
        /* 0x80C1 */ public TkCurveType TrackReticuleInCurve;
        [NMS(Index = 84)]
        /* 0x80C2 */ public bool UseIntermediateMissionGiverOptions;
        [NMS(Index = 77)]
        /* 0x80C3 */ public bool UseSquareSlots;
        [NMS(Index = 310)]
        /* 0x80C4 */ public bool UseWorldNodesForRepair;
    }
}
