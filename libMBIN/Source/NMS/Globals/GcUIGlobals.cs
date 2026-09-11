using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x66B41AC501D7D82D, NameHash = 0xD1FA1B1C)]
    public class GcUIGlobals : NMSTemplate
    {
        [NMS(Index = 1109)]
        /* 0x0000 */ public GcModelViewCollection ModelViews;
        [NMS(Index = 0)]
        /* 0x27C0 */ public GcSolarSystemMapSettings SolarSystemMapSettings;
        [NMS(Index = 1108, Size = 0xC, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x3990 */ public TkModelRendererData[] ShipThumbnailRenderSettings;
        [NMS(Index = 1107)]
        /* 0x4290 */ public TkModelRendererData HoverShipThumbnailModelView;
        [NMS(Index = 1105)]
        /* 0x4350 */ public TkModelRendererData LargeMultitoolThumbnailModelView;
        [NMS(Index = 1104)]
        /* 0x4410 */ public TkModelRendererData MultitoolThumbnailModelView;
        [NMS(Index = 1103)]
        /* 0x44D0 */ public TkModelRendererData PetThumbnailModelView;
        [NMS(Index = 477)]
        /* 0x4590 */ public TkModelRendererData RepairBackpackCamera;
        [NMS(Index = 475)]
        /* 0x4650 */ public TkModelRendererData RepairCamera;
        [NMS(Index = 478)]
        /* 0x4710 */ public TkModelRendererData RepairShipCameraInWorld;
        [NMS(Index = 479)]
        /* 0x47D0 */ public TkModelRendererData RepairShipCameraModelView;
        [NMS(Index = 480)]
        /* 0x4890 */ public TkModelRendererData RepairShipCameraVR;
        [NMS(Index = 476)]
        /* 0x4950 */ public TkModelRendererData RepairWeaponCamera;
        [NMS(Index = 1106)]
        /* 0x4A10 */ public TkModelRendererData SpookShipThumbnailModelView;
        [NMS(Index = 1439)]
        /* 0x4AD0 */ public TkNGuiTreeViewTemplate FileBrowserTreeViewTemplate;
        [NMS(Index = 1438)]
        /* 0x4B50 */ public TkNGuiTreeViewTemplate SceneInfoTreeViewTemplate;
        [NMS(Index = 1440)]
        /* 0x4BD0 */ public TkNGuiTreeViewTemplate SkeletonToolsTreeViewTemplate;
        [NMS(Index = 584)]
        /* 0x4C50 */ public GcScanEffectData DebugEditorPreviewEffect;
        [NMS(Index = 670)]
        /* 0x4CA0 */ public GcScanEffectData FreighterSummonScanEffect;
        [NMS(Index = 343)]
        /* 0x4CF0 */ public GcHUDEffectRewardData OSDEpicItemRewardEffect;
        [NMS(Index = 342)]
        /* 0x4D40 */ public GcHUDEffectRewardData OSDRareItemRewardEffect;
        [NMS(Index = 888, Size = 0x5, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x4D90 */ public Colour[] SystemHooverLEDColours;
        [NMS(Index = 889, Size = 0x5, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x4DE0 */ public Colour[] SystemHooverStatusBarColours;
        [NMS(Index = 571)]
        /* 0x4E30 */ public GcScanEffectData TargetDisplayScanEffect;
        [NMS(Index = 1297)]
        /* 0x4E80 */ public GcSpaceMapObjectData SpaceMapAtlasData;
        [NMS(Index = 1298)]
        /* 0x4EB0 */ public GcSpaceMapObjectData SpaceMapBlackHoleData;
        [NMS(Index = 1300)]
        /* 0x4EE0 */ public GcSpaceMapObjectData SpaceMapFreighterData;
        [NMS(Index = 1293)]
        /* 0x4F10 */ public GcSpaceMapObjectData SpaceMapMarkerData;
        [NMS(Index = 1296)]
        /* 0x4F40 */ public GcSpaceMapObjectData SpaceMapNexusData;
        [NMS(Index = 1294)]
        /* 0x4F70 */ public GcSpaceMapObjectData SpaceMapPlanetData;
        [NMS(Index = 1301)]
        /* 0x4FA0 */ public GcSpaceMapObjectData SpaceMapPulseEncounterData;
        [NMS(Index = 1299)]
        /* 0x4FD0 */ public GcSpaceMapObjectData SpaceMapShipData;
        [NMS(Index = 1295)]
        /* 0x5000 */ public GcSpaceMapObjectData SpaceMapStationData;
        [NMS(Index = 1371)]
        /* 0x5030 */ public Colour AltimeterBandColour1;
        [NMS(Index = 1372)]
        /* 0x5040 */ public Colour AltimeterBandColour2;
        [NMS(Index = 1373)]
        /* 0x5050 */ public Colour AltimeterColour1;
        [NMS(Index = 1374)]
        /* 0x5060 */ public Colour AltimeterColour2;
        [NMS(Index = 405)]
        /* 0x5070 */ public Colour BaseComplexityDangerColour;
        [NMS(Index = 403)]
        /* 0x5080 */ public Colour BaseComplexityDefaultColour;
        [NMS(Index = 404)]
        /* 0x5090 */ public Colour BaseComplexityWarningColour;
        [NMS(Index = 189)]
        /* 0x50A0 */ public Vector3f BinocularPanelLinePointOffset;
        [NMS(Index = 413)]
        /* 0x50B0 */ public Colour BuildMenuErrorTextColour;
        [NMS(Index = 415)]
        /* 0x50C0 */ public Colour BuildMenuErrorTextFlashColour;
        [NMS(Index = 414)]
        /* 0x50D0 */ public Colour BuildMenuErrorTextOutlineColour;
        [NMS(Index = 416)]
        /* 0x50E0 */ public Colour BuildMenuErrorTextOutlineFlashColour;
        [NMS(Index = 417)]
        /* 0x50F0 */ public Colour BuildMenuInfoTextColour;
        [NMS(Index = 418)]
        /* 0x5100 */ public Colour BuildMenuInfoTextOutlineColour;
        [NMS(Index = 411)]
        /* 0x5110 */ public Colour BuildMenuPassiveErrorTextColour;
        [NMS(Index = 412)]
        /* 0x5120 */ public Colour BuildMenuPassiveErrorTextOutlineColour;
        [NMS(Index = 1158)]
        /* 0x5130 */ public Colour ByteBeatArpGridActiveColour;
        [NMS(Index = 1157)]
        /* 0x5140 */ public Colour ByteBeatArpGridInactiveColour;
        [NMS(Index = 1160)]
        /* 0x5150 */ public Colour ByteBeatArpPipActiveColour;
        [NMS(Index = 1159)]
        /* 0x5160 */ public Colour ByteBeatArpPipInactiveColour;
        [NMS(Index = 1176)]
        /* 0x5170 */ public Colour ByteBeatRhythmColour0Active;
        [NMS(Index = 1177)]
        /* 0x5180 */ public Colour ByteBeatRhythmColour0Inactive;
        [NMS(Index = 1178)]
        /* 0x5190 */ public Colour ByteBeatRhythmColour1Active;
        [NMS(Index = 1179)]
        /* 0x51A0 */ public Colour ByteBeatRhythmColour1Inactive;
        [NMS(Index = 1180)]
        /* 0x51B0 */ public Colour ByteBeatRhythmColour2Active;
        [NMS(Index = 1181)]
        /* 0x51C0 */ public Colour ByteBeatRhythmColour2Inactive;
        [NMS(Index = 1172)]
        /* 0x51D0 */ public Colour ByteBeatSequencerBGColourActive;
        [NMS(Index = 1173)]
        /* 0x51E0 */ public Colour ByteBeatSequencerBGColourInactive;
        [NMS(Index = 1182)]
        /* 0x51F0 */ public Colour ByteBeatSequencerHighlightColour;
        [NMS(Index = 1174)]
        /* 0x5200 */ public Colour ByteBeatSequencerRimColourActive;
        [NMS(Index = 1175)]
        /* 0x5210 */ public Colour ByteBeatSequencerRimColourInactive;
        [NMS(Index = 1171)]
        /* 0x5220 */ public Colour ByteBeatSequencerUnpoweredTint;
        [NMS(Index = 1187)]
        /* 0x5230 */ public Colour ByteBeatSliderFGColour;
        [NMS(Index = 1188)]
        /* 0x5240 */ public Colour ByteBeatSliderTextActiveColour;
        [NMS(Index = 1189)]
        /* 0x5250 */ public Colour ByteBeatSliderTextInactiveColour;
        [NMS(Index = 1148)]
        /* 0x5260 */ public Colour ByteBeatTreeLineColour;
        [NMS(Index = 1151)]
        /* 0x5270 */ public Colour ByteBeatVisGridColour;
        [NMS(Index = 1150)]
        /* 0x5280 */ public Colour ByteBeatVisLineColour;
        [NMS(Index = 574)]
        /* 0x5290 */ public Colour CommunicatorMessageColour;
        [NMS(Index = 730)]
        /* 0x52A0 */ public Colour CrosshairColour;
        [NMS(Index = 719)]
        /* 0x52B0 */ public Colour CrosshairLeadPassiveColour;
        [NMS(Index = 718)]
        /* 0x52C0 */ public Colour CrosshairLeadThreatColour;
        [NMS(Index = 1110)]
        /* 0x52D0 */ public Colour CursorColour;
        [NMS(Index = 1111)]
        /* 0x52E0 */ public Colour CursorConfirmColour;
        [NMS(Index = 1113)]
        /* 0x52F0 */ public Colour CursorDeleteColour;
        [NMS(Index = 1112)]
        /* 0x5300 */ public Colour CursorTransferUploadColour;
        [NMS(Index = 639)]
        /* 0x5310 */ public Colour DamageNumberCriticalColour;
        [NMS(Index = 640)]
        /* 0x5320 */ public Colour DamageNumberIneffectiveColour;
        [NMS(Index = 641)]
        /* 0x5330 */ public Colour DamageNumberIneffectiveWarningColour;
        [NMS(Index = 958)]
        /* 0x5340 */ public Colour DeathMessageColour;
        [NMS(Index = 302)]
        /* 0x5350 */ public Colour DebugEditorAxisColourAtActive;
        [NMS(Index = 301)]
        /* 0x5360 */ public Colour DebugEditorAxisColourAtInactive;
        [NMS(Index = 300)]
        /* 0x5370 */ public Colour DebugEditorAxisColourRightActive;
        [NMS(Index = 299)]
        /* 0x5380 */ public Colour DebugEditorAxisColourRightInactive;
        [NMS(Index = 298)]
        /* 0x5390 */ public Colour DebugEditorAxisColourUpActive;
        [NMS(Index = 297)]
        /* 0x53A0 */ public Colour DebugEditorAxisColourUpInactive;
        [NMS(Index = 493)]
        /* 0x53B0 */ public Vector3f DefaultRefinerOffsetIn;
        [NMS(Index = 494)]
        /* 0x53C0 */ public Vector3f DefaultRefinerOffsetOut;
        [NMS(Index = 1076)]
        /* 0x53D0 */ public Colour EnergyBgColour;
        [NMS(Index = 1077)]
        /* 0x53E0 */ public Colour EnergyBgPulseColour;
        [NMS(Index = 220)]
        /* 0x53F0 */ public Vector3f FaceLockedScreenOffset;
        [NMS(Index = 671)]
        /* 0x5400 */ public Colour FreighterSummonScanEffectColourBlocked;
        [NMS(Index = 672)]
        /* 0x5410 */ public Colour FreighterSummonScanEffectColourHighlight;
        [NMS(Index = 305)]
        /* 0x5420 */ public Colour FrontendCursorBackgroundColour;
        [NMS(Index = 644)]
        /* 0x5430 */ public Colour FuelBgColour;
        [NMS(Index = 511)]
        /* 0x5440 */ public Colour GridBackgroundNegativeColour;
        [NMS(Index = 509)]
        /* 0x5450 */ public Colour GridBackgroundNeutralColour;
        [NMS(Index = 510)]
        /* 0x5460 */ public Colour GridBackgroundPositiveColour;
        [NMS(Index = 506)]
        /* 0x5470 */ public Colour GridDisconnectedColour;
        [NMS(Index = 508)]
        /* 0x5480 */ public Colour GridOfflineColour;
        [NMS(Index = 507)]
        /* 0x5490 */ public Colour GridOnlineColour;
        [NMS(Index = 1078)]
        /* 0x54A0 */ public Colour HazardBgPulseColour;
        [NMS(Index = 1079)]
        /* 0x54B0 */ public Colour HazardDamagePulseColour;
        [NMS(Index = 308)]
        /* 0x54C0 */ public Vector3f HmdFramerateScreenOffset;
        [NMS(Index = 1312)]
        /* 0x54D0 */ public Colour HUDMarkerColour;
        [NMS(Index = 885)]
        /* 0x54E0 */ public Colour HUDNotifyColour;
        [NMS(Index = 1316)]
        /* 0x54F0 */ public Colour HUDOutpostColour;
        [NMS(Index = 849)]
        /* 0x5500 */ public Colour HUDPlayerTrackArrowDamageGlowHullHitMaxColour;
        [NMS(Index = 850)]
        /* 0x5510 */ public Colour HUDPlayerTrackArrowDamageGlowHullHitMinColour;
        [NMS(Index = 853)]
        /* 0x5520 */ public Colour HUDPlayerTrackArrowDamageGlowShieldHitMaxColour;
        [NMS(Index = 854)]
        /* 0x5530 */ public Colour HUDPlayerTrackArrowDamageGlowShieldHitMinColour;
        [NMS(Index = 880)]
        /* 0x5540 */ public Colour HUDPlayerTrackArrowDotColour;
        [NMS(Index = 882)]
        /* 0x5550 */ public Colour HUDPlayerTrackArrowDotColourPirate;
        [NMS(Index = 881)]
        /* 0x5560 */ public Colour HUDPlayerTrackArrowDotColourPolice;
        [NMS(Index = 883)]
        /* 0x5570 */ public Colour HUDPlayerTrackArrowDotColourTrader;
        [NMS(Index = 841)]
        /* 0x5580 */ public Colour HUDPlayerTrackArrowEnergyShieldColour;
        [NMS(Index = 862)]
        /* 0x5590 */ public Colour HUDPlayerTrackArrowEnergyShieldDepletedGlowMaxColour;
        [NMS(Index = 863)]
        /* 0x55A0 */ public Colour HUDPlayerTrackArrowEnergyShieldDepletedGlowMinColour;
        [NMS(Index = 842)]
        /* 0x55B0 */ public Colour HUDPlayerTrackArrowEnergyShieldLowColour;
        [NMS(Index = 867)]
        /* 0x55C0 */ public Colour HUDPlayerTrackArrowEnergyShieldStartChargeGlowMaxColour;
        [NMS(Index = 868)]
        /* 0x55D0 */ public Colour HUDPlayerTrackArrowEnergyShieldStartChargeGlowMinColour;
        [NMS(Index = 838)]
        /* 0x55E0 */ public Colour HUDPlayerTrackArrowTextColour;
        [NMS(Index = 1314)]
        /* 0x55F0 */ public Colour HUDRelicMarkerColourDiscovered;
        [NMS(Index = 1315)]
        /* 0x5600 */ public Colour HUDRelicMarkerColourUnknown;
        [NMS(Index = 1313)]
        /* 0x5610 */ public Colour HUDSpaceshipColour;
        [NMS(Index = 884)]
        /* 0x5620 */ public Colour HUDWarningColour;
        [NMS(Index = 424)]
        /* 0x5630 */ public Colour IconGlowColourActive;
        [NMS(Index = 423)]
        /* 0x5640 */ public Colour IconGlowColourError;
        [NMS(Index = 426)]
        /* 0x5650 */ public Colour IconGlowColourHighlight;
        [NMS(Index = 425)]
        /* 0x5660 */ public Colour IconGlowColourNeutral;
        [NMS(Index = 483)]
        /* 0x5670 */ public Colour InteractionLabelCostColour;
        [NMS(Index = 484)]
        /* 0x5680 */ public Colour InteractionLabelPickupColour;
        [NMS(Index = 485)]
        /* 0x5690 */ public Colour InteractionLabelPickupFillColour;
        [NMS(Index = 81)]
        /* 0x56A0 */ public Colour InvSlotGradientBaseColour;
        [NMS(Index = 151)]
        /* 0x56B0 */ public Vector3f InWorldInteractLabelCentreOffset;
        [NMS(Index = 153)]
        /* 0x56C0 */ public Vector3f InWorldInteractLabelLineOffset;
        [NMS(Index = 152)]
        /* 0x56D0 */ public Vector3f InWorldInteractLabelTopOffset;
        [NMS(Index = 213)]
        /* 0x56E0 */ public Vector3f InWorldNGuiScreenRotation;
        [NMS(Index = 154)]
        /* 0x56F0 */ public Vector3f InWorldStaffBinocsScreenOffset;
        [NMS(Index = 994)]
        /* 0x5700 */ public Colour ItemSlotColourPartiallyInstalled;
        [NMS(Index = 996)]
        /* 0x5710 */ public Colour ItemSlotColourProduct;
        [NMS(Index = 990)]
        /* 0x5720 */ public Colour ItemSlotColourSubstance;
        [NMS(Index = 991)]
        /* 0x5730 */ public Colour ItemSlotColourTech;
        [NMS(Index = 992)]
        /* 0x5740 */ public Colour ItemSlotColourTechCharge;
        [NMS(Index = 993)]
        /* 0x5750 */ public Colour ItemSlotColourTechDamage;
        [NMS(Index = 999)]
        /* 0x5760 */ public Colour ItemSlotTextColourProduct;
        [NMS(Index = 997)]
        /* 0x5770 */ public Colour ItemSlotTextColourSubstance;
        [NMS(Index = 998)]
        /* 0x5780 */ public Colour ItemSlotTextColourTech;
        [NMS(Index = 80)]
        /* 0x5790 */ public Colour JoaoBoxCompletedObjectiveColour;
        [NMS(Index = 1377)]
        /* 0x57A0 */ public Colour LockOnMarkerActiveColour;
        [NMS(Index = 209)]
        /* 0x57B0 */ public Vector3f LowerHelmetScreenOffset;
        [NMS(Index = 458)]
        /* 0x57C0 */ public Colour MarkerRingBGColour;
        [NMS(Index = 535)]
        /* 0x57D0 */ public Colour MissionOSDMessageBarColour;
        [NMS(Index = 354)]
        /* 0x57E0 */ public Colour MultiplayerMissionParticipantsColour;
        [NMS(Index = 63)]
        /* 0x57F0 */ public Colour NetworkPopupTextDisabledColour;
        [NMS(Index = 62)]
        /* 0x5800 */ public Colour NetworkPopupTextEnabledColour;
        [NMS(Index = 1395)]
        /* 0x5810 */ public Vector3f NGuiModelTranslationFactors;
        [NMS(Index = 1396)]
        /* 0x5820 */ public Vector3f NGuiModelTranslationFactorsInteraction;
        [NMS(Index = 1397)]
        /* 0x5830 */ public Vector3f NGuiThumbnailModelTranslationFactors;
        [NMS(Index = 537)]
        /* 0x5840 */ public Colour NotificationDangerColour;
        [NMS(Index = 536)]
        /* 0x5850 */ public Colour NotificationDefaultColour;
        [NMS(Index = 538)]
        /* 0x5860 */ public Colour NotificationInfoColour;
        [NMS(Index = 539)]
        /* 0x5870 */ public Colour NotificationUrgentColour;
        [NMS(Index = 13)]
        /* 0x5880 */ public Vector3f OutpostReturnMarkerOffset;
        [NMS(Index = 5)]
        /* 0x5890 */ public Colour PetGeneIconGlowColourDefault;
        [NMS(Index = 6)]
        /* 0x58A0 */ public Colour PetGeneIconGlowColourHighlight;
        [NMS(Index = 3)]
        /* 0x58B0 */ public Colour PetLevelProgressColour;
        [NMS(Index = 4)]
        /* 0x58C0 */ public Colour PetPointProgresColour;
        [NMS(Index = 642)]
        /* 0x58D0 */ public Colour PhotoModeSelectedColour;
        [NMS(Index = 643)]
        /* 0x58E0 */ public Colour PhotoModeUnselectedColour;
        [NMS(Index = 353)]
        /* 0x58F0 */ public Colour PickedItemBorderColour;
        [NMS(Index = 959)]
        /* 0x5900 */ public Colour PinnedRecipeBorder;
        [NMS(Index = 349)]
        /* 0x5910 */ public Colour ProcProductColourCommon;
        [NMS(Index = 351)]
        /* 0x5920 */ public Colour ProcProductColourRare;
        [NMS(Index = 350)]
        /* 0x5930 */ public Colour ProcProductColourUncommon;
        [NMS(Index = 823)]
        /* 0x5940 */ public Colour PulseAlertColour;
        [NMS(Index = 822)]
        /* 0x5950 */ public Colour PulseDamageColour;
        [NMS(Index = 303)]
        /* 0x5960 */ public Colour QuickMenuSelectedItemColour1;
        [NMS(Index = 304)]
        /* 0x5970 */ public Colour QuickMenuSelectedItemColour2;
        [NMS(Index = 1196)]
        /* 0x5980 */ public Colour RadialMenuInnerColourDisabled;
        [NMS(Index = 1192)]
        /* 0x5990 */ public Colour RadialMenuInnerColourSelected;
        [NMS(Index = 1194)]
        /* 0x59A0 */ public Colour RadialMenuInnerColourUnselected;
        [NMS(Index = 1197)]
        /* 0x59B0 */ public Colour RadialMenuOuterColourDisabled;
        [NMS(Index = 1193)]
        /* 0x59C0 */ public Colour RadialMenuOuterColourSelected;
        [NMS(Index = 1195)]
        /* 0x59D0 */ public Colour RadialMenuOuterColourUnselected;
        [NMS(Index = 504)]
        /* 0x59E0 */ public Colour RefinerBackgroundColour;
        [NMS(Index = 505)]
        /* 0x59F0 */ public Colour RefinerErrorBackgroundColour;
        [NMS(Index = 736)]
        /* 0x5A00 */ public Colour RemappedControlColour;
        [NMS(Index = 735)]
        /* 0x5A10 */ public Colour SelectedControlColour;
        [NMS(Index = 1445)]
        /* 0x5A20 */ public Colour SettlementStatBackgroundColour;
        [NMS(Index = 1444)]
        /* 0x5A30 */ public Colour SettlementStatColour;
        [NMS(Index = 1082)]
        /* 0x5A40 */ public Colour ShieldBgColour;
        [NMS(Index = 1080)]
        /* 0x5A50 */ public Colour ShieldColour;
        [NMS(Index = 1083)]
        /* 0x5A60 */ public Colour ShieldDamageBgColour;
        [NMS(Index = 1081)]
        /* 0x5A70 */ public Colour ShieldDamageColour;
        [NMS(Index = 28)]
        /* 0x5A80 */ public Colour ShipBuilderLineColour;
        [NMS(Index = 27)]
        /* 0x5A90 */ public Colour ShipBuilderLineColourHologram;
        [NMS(Index = 1024)]
        /* 0x5AA0 */ public Colour ShipHUDAimTargetColour;
        [NMS(Index = 1025)]
        /* 0x5AB0 */ public Colour ShipHUDAimTargetCritColour;
        [NMS(Index = 1022)]
        /* 0x5AC0 */ public Colour ShipHUDTargetArrowsColourLocal;
        [NMS(Index = 1020)]
        /* 0x5AD0 */ public Colour ShipHUDTargetArrowsColourOutOfRange;
        [NMS(Index = 1021)]
        /* 0x5AE0 */ public Colour ShipHUDTargetArrowsColourThreat;
        [NMS(Index = 12)]
        /* 0x5AF0 */ public Vector3f ShipTeleportPadMarkerOffset;
        [NMS(Index = 1285)]
        /* 0x5B00 */ public Colour SpaceEnemyShipLineColour;
        [NMS(Index = 1284)]
        /* 0x5B10 */ public Colour SpaceFriendlyShipLineColour;
        [NMS(Index = 1287)]
        /* 0x5B20 */ public Colour SpaceMapAttackColour;
        [NMS(Index = 552)]
        /* 0x5B30 */ public Vector3f SpaceMapCockpitOffset;
        [NMS(Index = 1292)]
        /* 0x5B40 */ public Colour SpaceMapDeathPointColour;
        [NMS(Index = 1290)]
        /* 0x5B50 */ public Colour SpaceMapNeutralColour;
        [NMS(Index = 1288)]
        /* 0x5B60 */ public Colour SpaceMapOtherPlayerColour;
        [NMS(Index = 1286)]
        /* 0x5B70 */ public Vector3f SpaceMapPosScaler;
        [NMS(Index = 1291)]
        /* 0x5B80 */ public Colour SpaceMapSquadronColour;
        [NMS(Index = 1289)]
        /* 0x5B90 */ public Colour SpaceMapThreatColour;
        [NMS(Index = 1468)]
        /* 0x5BA0 */ public Colour SpookMeterColour;
        [NMS(Index = 39)]
        /* 0x5BB0 */ public Colour StoreDialFillColour;
        [NMS(Index = 87)]
        /* 0x5BC0 */ public Colour SuperchargeGradientBaseColour;
        [NMS(Index = 88)]
        /* 0x5BD0 */ public Colour SuperchargeGradientBlendColour;
        [NMS(Index = 89)]
        /* 0x5BE0 */ public Colour SuperchargeGradientTechColour;
        [NMS(Index = 86)]
        /* 0x5BF0 */ public Colour SuperchargePopupColour;
        [NMS(Index = 568)]
        /* 0x5C00 */ public Vector3f TargetDisplayShipOffset;
        [NMS(Index = 569)]
        /* 0x5C10 */ public Vector3f TargetDisplayTorpedoOffset;
        [NMS(Index = 1221)]
        /* 0x5C20 */ public Colour TargetMarkerColour;
        [NMS(Index = 1222)]
        /* 0x5C30 */ public Colour TargetMarkerHighlightColour;
        [NMS(Index = 33)]
        /* 0x5C40 */ public Colour TouchButtonChargeIndicatorColour;
        [NMS(Index = 512)]
        /* 0x5C50 */ public Colour TransferSendPopupColour;
        [NMS(Index = 328)]
        /* 0x5C60 */ public Colour TravelLineColour;
        [NMS(Index = 331)]
        /* 0x5C70 */ public Colour TravelLineInvalidColour;
        [NMS(Index = 332)]
        /* 0x5C80 */ public Colour TravelLineNotAllowedColour;
        [NMS(Index = 329)]
        /* 0x5C90 */ public Colour TravelLineTooFarColour;
        [NMS(Index = 330)]
        /* 0x5CA0 */ public Colour TravelLineTooSteepColour;
        [NMS(Index = 333)]
        /* 0x5CB0 */ public Colour TravelTargetColour;
        [NMS(Index = 1231)]
        /* 0x5CC0 */ public Colour UnseenItemColour;
        [NMS(Index = 1230)]
        /* 0x5CD0 */ public Colour WantedColour;
        [NMS(Index = 54)]
        /* 0x5CE0 */ public Colour WristMenuDefaultBorderColour;
        [NMS(Index = 55)]
        /* 0x5CF0 */ public Colour WristMenuRepositionableBorderColour;
        [NMS(Index = 73, Size = 0xF, EnumType = typeof(GcWonderCreatureCategory.WonderCreatureCategoryEnum))]
        /* 0x5D00 */ public GcWonderCategoryConfig[] WonderCreatureCategoryConfig;
        [NMS(Index = 76, Size = 0xD, EnumType = typeof(GcWonderTreasureCategory.WonderTreasureCategoryEnum))]
        /* 0x6048 */ public GcWonderCategoryConfig[] WonderTreasureCategoryConfig;
        [NMS(Index = 408, Size = 0x15, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x6320 */ public NMSString0x20A[] BuildMenuOnActionDisabledLocIDs;
        [NMS(Index = 409, Size = 0x15, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x65C0 */ public NMSString0x20A[] BuildMenuOnActionErrorLocIDs;
        [NMS(Index = 407, Size = 0x15, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x6860 */ public NMSString0x20A[] BuildMenuOnActionLocIDs;
        [NMS(Index = 78, Size = 0xC, EnumType = typeof(GcWonderCustomCategory.WonderCustomCategoryEnum))]
        /* 0x6B00 */ public GcWonderCategoryConfig[] WonderCustomCategoryConfig;
        [NMS(Index = 72, Size = 0xB, EnumType = typeof(GcWonderPlanetCategory.WonderPlanetCategoryEnum))]
        /* 0x6DA0 */ public GcWonderCategoryConfig[] WonderPlanetCategoryConfig;
        [NMS(Index = 77, Size = 0xB, EnumType = typeof(GcWonderWeirdBasePartCategory.WonderWeirdBasePartCategoryEnum))]
        /* 0x7008 */ public GcWonderCategoryConfig[] WonderWeirdBasePartCategoryConfig;
        [NMS(Index = 74, Size = 0x8, EnumType = typeof(GcWonderFloraCategory.WonderFloraCategoryEnum))]
        /* 0x7270 */ public GcWonderCategoryConfig[] WonderFloraCategoryConfig;
        [NMS(Index = 75, Size = 0x8, EnumType = typeof(GcWonderMineralCategory.WonderMineralCategoryEnum))]
        /* 0x7430 */ public GcWonderCategoryConfig[] WonderMineralCategoryConfig;
        [NMS(Index = 1413)]
        /* 0x75F0 */ public GcHUDStartupTable IntroTiming;
        [NMS(Index = 1414)]
        /* 0x7740 */ public GcHUDStartupTable IntroTimingFreighter;
        [NMS(Index = 1415)]
        /* 0x7890 */ public GcHUDStartupTable IntroTimingFreighterRepaired;
        [NMS(Index = 1447, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x79E0 */ public NMSString0x20A[] SettlementStatFormatLoc;
        [NMS(Index = 1446, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x7AE0 */ public NMSString0x20A[] SettlementStatLoc;
        [NMS(Index = 1448, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x7BE0 */ public TkTextureResource[] SettlementStatBasicImages;
        [NMS(Index = 1450, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x7CA0 */ public TkTextureResource[] SettlementStatNegativeImages;
        [NMS(Index = 1449, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x7D60 */ public TkTextureResource[] SettlementStatPositiveImages;
        [NMS(Index = 67, Size = 0x7, EnumType = typeof(GcWonderType.WonderTypeEnum))]
        /* 0x7E20 */ public TkTextureResource[] WonderTypeIcons;
        [NMS(Index = 453)]
        /* 0x7EC8 */ public TkTextureResource BaseBuildingPartsGridExpandableIcon;
        [NMS(Index = 454)]
        /* 0x7EE0 */ public TkTextureResource BaseBuildingPartsGridExpandedIcon;
        [NMS(Index = 455)]
        /* 0x7EF8 */ public TkTextureResource BaseBuildingPartsGridRetractableIcon;
        [NMS(Index = 488)]
        /* 0x7F10 */ public TkTextureResource RefinerPopupEmptyOutputIcon;
        [NMS(Index = 1074)]
        /* 0x7F28 */ public GcFilename CamoNormalTexture;
        [NMS(Index = 1073)]
        /* 0x7F38 */ public GcFilename CamoTexture;
        [NMS(Index = 96)]
        /* 0x7F48 */ public NMSString0x10 DebugInventoryHint;
        [NMS(Index = 127)]
        /* 0x7F58 */ public NMSString0x10 ExplorationLogMissionID;
        [NMS(Index = 1072)]
        /* 0x7F68 */ public List<Vector4f> HazardDistortionParams;
        [NMS(Index = 1068)]
        /* 0x7F78 */ public List<GcFilename> HazardHeightmaps;
        [NMS(Index = 1071)]
        /* 0x7F88 */ public List<GcFilename> HazardHeightmapsVR;
        [NMS(Index = 1067)]
        /* 0x7F98 */ public List<GcFilename> HazardNormalMaps;
        [NMS(Index = 1070)]
        /* 0x7FA8 */ public List<GcFilename> HazardNormalMapsVR;
        [NMS(Index = 1066)]
        /* 0x7FB8 */ public List<GcFilename> HazardTextures;
        [NMS(Index = 1069)]
        /* 0x7FC8 */ public List<GcFilename> HazardTexturesVR;
        [NMS(Index = 352)]
        /* 0x7FD8 */ public List<Vector2f> InventoryIconPositions;
        [NMS(Index = 356)]
        /* 0x7FE8 */ public NMSString0x10 MultiplayerMissionInteractEndTrigger;
        [NMS(Index = 355)]
        /* 0x7FF8 */ public NMSString0x10 MultiplayerMissionInteractStartTrigger;
        [NMS(Index = 115)]
        /* 0x8008 */ public List<GcSeasonalRingArray> SeasonalRingTable;
        [NMS(Index = 1023)]
        /* 0x8018 */ public List<Colour> ShipHUDTargetArrowsColour;
        [NMS(Index = 827)]
        /* 0x8028 */ public NMSString0x10 ShowStatWithDeathQuote;
        [NMS(Index = 899)]
        /* 0x8038 */ public List<GcFilename> StatIcons;
        [NMS(Index = 481)]
        /* 0x8048 */ public List<TkModelRendererData> VehicleTypeRepairCamera;
        [NMS(Index = 727, Size = 0x15, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x8058 */ public float[] CrosshairTargetLockSizeSpecific;
        [NMS(Index = 981)]
        /* 0x80AC */ public GcWorldUISettings WorldUISettings;
        [NMS(Index = 69, Size = 0xF, EnumType = typeof(GcWonderCreatureCategory.WonderCreatureCategoryEnum))]
        /* 0x8100 */ public float[] WonderValueModifiersCreature;
        [NMS(Index = 68, Size = 0xB, EnumType = typeof(GcWonderPlanetCategory.WonderPlanetCategoryEnum))]
        /* 0x813C */ public float[] WonderValueModifiersPlanet;
        [NMS(Index = 70, Size = 0x8, EnumType = typeof(GcWonderFloraCategory.WonderFloraCategoryEnum))]
        /* 0x8168 */ public float[] WonderValueModifiersFlora;
        [NMS(Index = 71, Size = 0x8, EnumType = typeof(GcWonderMineralCategory.WonderMineralCategoryEnum))]
        /* 0x8188 */ public float[] WonderValueModifiersMineral;
        [NMS(Index = 1417)]
        /* 0x81A8 */ public GcInventorySlotActionData BuildProductSlotAction;
        [NMS(Index = 1418)]
        /* 0x81C4 */ public GcInventorySlotActionData ChargeSlotAction;
        [NMS(Index = 1416)]
        /* 0x81E0 */ public GcInventorySlotActionData InstallTechSlotAction;
        [NMS(Index = 1422)]
        /* 0x81FC */ public GcInventorySlotActionData InventoryHintAction;
        [NMS(Index = 1423)]
        /* 0x8218 */ public GcInventorySlotActionData InventoryHintActionNoGlow;
        [NMS(Index = 1421)]
        /* 0x8234 */ public GcInventorySlotActionData NewSlotPulseAction;
        [NMS(Index = 1420)]
        /* 0x8250 */ public GcInventorySlotActionData NewSlotRevealAction;
        [NMS(Index = 1419)]
        /* 0x826C */ public GcInventorySlotActionData RepairSlotAction;
        [NMS(Index = 1)]
        /* 0x8288 */ public GcInteractionDof InteractionDOFDisabled;
        [NMS(Index = 820)]
        /* 0x829C */ public TkNGuiRectanglePulseEffect PulseBarData;
        [NMS(Index = 821)]
        /* 0x82AC */ public TkNGuiRectanglePulseEffect PulseIconData;
        [NMS(Index = 731)]
        /* 0x82BC */ public TkHitCurveData CrosshairLeadHitCurve;
        [NMS(Index = 1412)]
        /* 0x82C8 */ public GcDiscoveryHelperTimings DiscoveryHelperTimings;
        [NMS(Index = 732)]
        /* 0x82D4 */ public TkHitCurveData ShootableHitCurve;
        [NMS(Index = 174)]
        /* 0x82E0 */ public Vector2f BinocularEdgeFade;
        [NMS(Index = 482)]
        /* 0x82E8 */ public Vector2f BinocularsDiscoveryPos;
        [NMS(Index = 385)]
        /* 0x82F0 */ public Vector2f CompassCentre;
        [NMS(Index = 102)]
        /* 0x82F8 */ public Vector2f ControlsPageParallax;
        [NMS(Index = 547)]
        /* 0x8300 */ public Vector2f CursorlessDialogPageCursorOffset;
        [NMS(Index = 634)]
        /* 0x8308 */ public Vector2f DamageNumberSideSpeed;
        [NMS(Index = 545)]
        /* 0x8310 */ public Vector2f DialogPageCursorOffset;
        [NMS(Index = 1318)]
        /* 0x8318 */ public Vector2f HUDMarkerCompassPrimaryIndicatorOffset;
        [NMS(Index = 1317)]
        /* 0x8320 */ public Vector2f HUDMarkerPrimaryIndicatorOffset;
        [NMS(Index = 497)]
        /* 0x8328 */ public Vector2f HUDPlayerSentinelPulseFreq;
        [NMS(Index = 498)]
        /* 0x8330 */ public Vector2f HUDPlayerSentinelPulseSize;
        [NMS(Index = 856)]
        /* 0x8338 */ public Vector2f HUDPlayerTrackArrowDamageGlowSize;
        [NMS(Index = 858)]
        /* 0x8340 */ public Vector2f HUDPlayerTrackArrowEnergyShieldGlowSize;
        [NMS(Index = 845)]
        /* 0x8348 */ public Vector2f HUDPlayerTrackArrowEnergyShieldSize;
        [NMS(Index = 840)]
        /* 0x8350 */ public Vector2f HUDPlayerTrackArrowHealthSize;
        [NMS(Index = 793)]
        /* 0x8358 */ public Vector2f HUDPlayerTrackArrowIconPulseSize;
        [NMS(Index = 805)]
        /* 0x8360 */ public Vector2f HUDPlayerTrackIconOffset;
        [NMS(Index = 1304)]
        /* 0x8368 */ public Vector2f HUDTargetHealthIconOffset;
        [NMS(Index = 1302)]
        /* 0x8370 */ public Vector2f HUDTargetHealthOffset;
        [NMS(Index = 1303)]
        /* 0x8378 */ public Vector2f HUDTargetHealthSize;
        [NMS(Index = 1085)]
        /* 0x8380 */ public Vector2f InteractionLabelOffset;
        [NMS(Index = 1086)]
        /* 0x8388 */ public Vector2f InteractionLabelOffset_1;
        [NMS(Index = 1089)]
        /* 0x8390 */ public Vector2f InteractionLabelScreenMax;
        [NMS(Index = 1088)]
        /* 0x8398 */ public Vector2f InteractionLabelScreenMin;
        [NMS(Index = 1090)]
        /* 0x83A0 */ public Vector2f InteractionLabelSize;
        [NMS(Index = 1092)]
        /* 0x83A8 */ public Vector2f InteractionLabelTouchAreaMax;
        [NMS(Index = 1091)]
        /* 0x83B0 */ public Vector2f InteractionLabelTouchAreaMin;
        [NMS(Index = 1406)]
        /* 0x83B8 */ public Vector2f InteractionWorldParallax;
        [NMS(Index = 546)]
        /* 0x83C0 */ public Vector2f IntermediateInteractionPageCursorOffset;
        [NMS(Index = 215)]
        /* 0x83C8 */ public Vector2f InWorldGameGuiAlignment;
        [NMS(Index = 150)]
        /* 0x83D0 */ public Vector2f InWorldInteractLabelAlignment;
        [NMS(Index = 214)]
        /* 0x83D8 */ public Vector2f InWorldNGuiParallax;
        [NMS(Index = 530)]
        /* 0x83E0 */ public Vector2f MainMenuSaveIconPosition;
        [NMS(Index = 205)]
        /* 0x83E8 */ public Vector2f MarkerDistanceVRAlignment;
        [NMS(Index = 496)]
        /* 0x83F0 */ public Vector2f ModelViewWorldParallax;
        [NMS(Index = 1403)]
        /* 0x83F8 */ public Vector2f NGuiMax2DParallax;
        [NMS(Index = 1402)]
        /* 0x8400 */ public Vector2f NGuiMin2DParallax;
        [NMS(Index = 1404)]
        /* 0x8408 */ public Vector2f NGuiModelParallax;
        [NMS(Index = 1405)]
        /* 0x8410 */ public Vector2f NGuiShipInteractParallax;
        [NMS(Index = 1220)]
        /* 0x8418 */ public Vector2f NGuiTouchPadSensitivity;
        [NMS(Index = 947)]
        /* 0x8420 */ public Vector2f NotificationMissionHintPauseTime;
        [NMS(Index = 948)]
        /* 0x8428 */ public Vector2f NotificationMissionHintPauseTimeCritical;
        [NMS(Index = 949)]
        /* 0x8430 */ public Vector2f NotificationMissionHintPauseTimeSecondary;
        [NMS(Index = 486)]
        /* 0x8438 */ public Vector2f PersonalRefinerInputPos;
        [NMS(Index = 487)]
        /* 0x8440 */ public Vector2f PersonalRefinerOutputPos;
        [NMS(Index = 101)]
        /* 0x8448 */ public Vector2f PickingCursorOffset;
        [NMS(Index = 983)]
        /* 0x8450 */ public Vector2f PlanetLabelOffset;
        [NMS(Index = 987)]
        /* 0x8458 */ public Vector2f PlanetLineOffset;
        [NMS(Index = 984)]
        /* 0x8460 */ public Vector2f PlanetMeasureOffset;
        [NMS(Index = 985)]
        /* 0x8468 */ public Vector2f PlanetMeasureOffsetBigText;
        [NMS(Index = 986)]
        /* 0x8470 */ public Vector2f PlanetMeasureOffsetMoonExtra;
        [NMS(Index = 495)]
        /* 0x8478 */ public Vector2f RefinerParallax;
        [NMS(Index = 529)]
        /* 0x8480 */ public Vector2f SaveIconPosition;
        [NMS(Index = 1084)]
        /* 0x8488 */ public Vector2f ScanLabelOffset;
        [NMS(Index = 1030)]
        /* 0x8490 */ public Vector2f TargetScreenCamOffset;
        [NMS(Index = 783)]
        /* 0x8498 */ public Vector2f TrackCriticalHitOffset;
        [NMS(Index = 747)]
        /* 0x84A0 */ public Vector2f TrackTypeIconOffset;
        [NMS(Index = 1437)]
        /* 0x84A8 */ public int AbandonedFreighterAirlockRoomNumber;
        [NMS(Index = 1455)]
        /* 0x84AC */ public float AccessibleUIHUDPopupScale;
        [NMS(Index = 1453)]
        /* 0x84B0 */ public float AccessibleUIPopupScale;
        [NMS(Index = 188)]
        /* 0x84B4 */ public float AlignmentRequiredToDisableFrostedGlass;
        [NMS(Index = 1365)]
        /* 0x84B8 */ public float AltimeterLineSpacing;
        [NMS(Index = 1368)]
        /* 0x84BC */ public float AltimeterMax;
        [NMS(Index = 1367)]
        /* 0x84C0 */ public float AltimeterMin;
        [NMS(Index = 1370)]
        /* 0x84C4 */ public float AltimeterMinValue;
        [NMS(Index = 1364)]
        /* 0x84C8 */ public float AltimeterResolution;
        [NMS(Index = 1369)]
        /* 0x84CC */ public float AltimeterTextSize;
        [NMS(Index = 1366)]
        /* 0x84D0 */ public float AltimeterWidth;
        [NMS(Index = 1059)]
        /* 0x84D4 */ public float AlwaysOnHazardMultiplierCold;
        [NMS(Index = 1057)]
        /* 0x84D8 */ public float AlwaysOnHazardMultiplierHeat;
        [NMS(Index = 1058)]
        /* 0x84DC */ public float AlwaysOnHazardMultiplierRad;
        [NMS(Index = 1064)]
        /* 0x84E0 */ public float AlwaysOnHazardMultiplierSpook;
        [NMS(Index = 1056)]
        /* 0x84E4 */ public float AlwaysOnHazardMultiplierTox;
        [NMS(Index = 1054)]
        /* 0x84E8 */ public float AlwaysOnHazardStrengthCold;
        [NMS(Index = 1052)]
        /* 0x84EC */ public float AlwaysOnHazardStrengthHeat;
        [NMS(Index = 1053)]
        /* 0x84F0 */ public float AlwaysOnHazardStrengthRad;
        [NMS(Index = 1055)]
        /* 0x84F4 */ public float AlwaysOnHazardStrengthSpook;
        [NMS(Index = 1051)]
        /* 0x84F8 */ public float AlwaysOnHazardStrengthTox;
        [NMS(Index = 1050)]
        /* 0x84FC */ public float AlwaysOnHazardThreshold;
        [NMS(Index = 689)]
        /* 0x8500 */ public float AlwaysShowIconFadeDistance;
        [NMS(Index = 691)]
        /* 0x8504 */ public float AlwaysShowIconFadeDistanceSpacePOI;
        [NMS(Index = 690)]
        /* 0x8508 */ public float AlwaysShowIconFadeRange;
        [NMS(Index = 692)]
        /* 0x850C */ public float AlwaysShowIconFadeRangeSpacePOI;
        [NMS(Index = 1428)]
        /* 0x8510 */ public float AmbientModeFadeTime;
        [NMS(Index = 684)]
        /* 0x8514 */ public float ArrowBounceLeftRate1;
        [NMS(Index = 685)]
        /* 0x8518 */ public float ArrowBounceLeftRate2;
        [NMS(Index = 686)]
        /* 0x851C */ public float ArrowBounceLeftRate3;
        [NMS(Index = 679)]
        /* 0x8520 */ public float ArrowBounceLength;
        [NMS(Index = 680)]
        /* 0x8524 */ public float ArrowBounceRate;
        [NMS(Index = 681)]
        /* 0x8528 */ public float ArrowBounceRightRate1;
        [NMS(Index = 682)]
        /* 0x852C */ public float ArrowBounceRightRate2;
        [NMS(Index = 1379)]
        /* 0x8530 */ public float AsteroidMarkerMinDisplayAngleDegrees;
        [NMS(Index = 1378)]
        /* 0x8534 */ public float AsteroidMarkerMinDisplayDistance;
        [NMS(Index = 437)]
        /* 0x8538 */ public float BaseBuildingFreeRotateDelayBeforeAudioStops;
        [NMS(Index = 436)]
        /* 0x853C */ public float BaseBuildingFreeRotateDelayBeforeReset;
        [NMS(Index = 435)]
        /* 0x8540 */ public float BaseBuildingFreeRotateSpeedPadMultiplier;
        [NMS(Index = 429)]
        /* 0x8544 */ public float BaseBuildingInputHighlightAlpha;
        [NMS(Index = 428)]
        /* 0x8548 */ public float BaseBuildingInputHighlightDuration;
        [NMS(Index = 432)]
        /* 0x854C */ public float BaseBuildingMaxFreeRotateSpeed;
        [NMS(Index = 431)]
        /* 0x8550 */ public float BaseBuildingMinFreeRotateSpeed;
        [NMS(Index = 448)]
        /* 0x8554 */ public float BaseBuildingPartsGridBreadcrumbFlashDuration;
        [NMS(Index = 447)]
        /* 0x8558 */ public float BaseBuildingPartsGridMaxCursorRestorationTime;
        [NMS(Index = 449)]
        /* 0x855C */ public float BaseBuildingPartsGridMinVisibilityForActive;
        [NMS(Index = 452)]
        /* 0x8560 */ public float BaseBuildingPartsGridPopupDelay;
        [NMS(Index = 450)]
        /* 0x8564 */ public float BaseBuildingPartsGridScrollSpeed;
        [NMS(Index = 451)]
        /* 0x8568 */ public float BaseBuildingPartsGridScrollSpeedPad;
        [NMS(Index = 427)]
        /* 0x856C */ public float BaseBuildingPinHighlightDuration;
        [NMS(Index = 434)]
        /* 0x8570 */ public float BaseBuildingRotationResetRate;
        [NMS(Index = 430)]
        /* 0x8574 */ public float BaseBuildingScaleSpeed;
        [NMS(Index = 433)]
        /* 0x8578 */ public float BaseBuildingTimeToMaxRotationSpeed;
        [NMS(Index = 446)]
        /* 0x857C */ public float BaseBuildingUIAdjustTime;
        [NMS(Index = 445)]
        /* 0x8580 */ public float BaseBuildingUIErrorFadeTime;
        [NMS(Index = 439)]
        /* 0x8584 */ public float BaseBuildingUIHorizontalSafeArea;
        [NMS(Index = 442)]
        /* 0x8588 */ public float BaseBuildingUIVerticalOffset;
        [NMS(Index = 443)]
        /* 0x858C */ public float BaseBuildingUIVerticalOffsetEdit;
        [NMS(Index = 444)]
        /* 0x8590 */ public float BaseBuildingUIVerticalOffsetFromBB;
        [NMS(Index = 441)]
        /* 0x8594 */ public float BaseBuildingUIVerticalPosWiring;
        [NMS(Index = 440)]
        /* 0x8598 */ public float BaseBuildingUIVerticalSafeArea;
        [NMS(Index = 401)]
        /* 0x859C */ public float BaseComplexityDangerFactor;
        [NMS(Index = 402)]
        /* 0x85A0 */ public float BaseComplexityWarningFactor;
        [NMS(Index = 14)]
        /* 0x85A4 */ public float BattleHUDBarInterpTime;
        [NMS(Index = 173)]
        /* 0x85A8 */ public float BeaconHUDMarkerOffset;
        [NMS(Index = 177)]
        /* 0x85AC */ public float BinocularMarkerSideAngle;
        [NMS(Index = 178)]
        /* 0x85B0 */ public float BinocularMarkerUpAngle;
        [NMS(Index = 187)]
        /* 0x85B4 */ public float BinocularsAltUIRescaleFactor;
        [NMS(Index = 175)]
        /* 0x85B8 */ public float BinocularScreenOffset;
        [NMS(Index = 176)]
        /* 0x85BC */ public float BinocularScreenScale;
        [NMS(Index = 185)]
        /* 0x85C0 */ public float BinocularsFarIconDist;
        [NMS(Index = 186)]
        /* 0x85C4 */ public float BinocularsFarIconFadeDist;
        [NMS(Index = 184)]
        /* 0x85C8 */ public float BinocularsFarIconOpacity;
        [NMS(Index = 183)]
        /* 0x85CC */ public float BinocularsMidIconOpacity;
        [NMS(Index = 181)]
        /* 0x85D0 */ public float BinocularsNearIconDist;
        [NMS(Index = 182)]
        /* 0x85D4 */ public float BinocularsNearIconFadeDist;
        [NMS(Index = 180)]
        /* 0x85D8 */ public float BinocularsNearIconOpacity;
        [NMS(Index = 513)]
        /* 0x85DC */ public float BountyMarkerOffset;
        [NMS(Index = 1433)]
        /* 0x85E0 */ public int BuildingShopMaxItems;
        [NMS(Index = 406)]
        /* 0x85E4 */ public float BuildMenuActionMessageDuration;
        [NMS(Index = 270)]
        /* 0x85E8 */ public float BuildMenuItemNavAnimTime;
        [NMS(Index = 271)]
        /* 0x85EC */ public float BuildMenuItemNextNavAnimTime;
        [NMS(Index = 272)]
        /* 0x85F0 */ public float BuildMenuItemNextNavAnimWait;
        [NMS(Index = 1154)]
        /* 0x85F4 */ public float ByteBeatArpLineWidth;
        [NMS(Index = 1156)]
        /* 0x85F8 */ public float ByteBeatArpPad;
        [NMS(Index = 1155)]
        /* 0x85FC */ public float ByteBeatArpRadius;
        [NMS(Index = 1152)]
        /* 0x8600 */ public float ByteBeatIconLineWidth;
        [NMS(Index = 1153)]
        /* 0x8604 */ public float ByteBeatIconPad;
        [NMS(Index = 1163)]
        /* 0x8608 */ public float ByteBeatPartSequencerPad;
        [NMS(Index = 1165)]
        /* 0x860C */ public float ByteBeatRhythmBeatPad;
        [NMS(Index = 1169)]
        /* 0x8610 */ public float ByteBeatRhythmSequencerActiveSaturation;
        [NMS(Index = 1168)]
        /* 0x8614 */ public float ByteBeatRhythmSequencerInactiveSaturation;
        [NMS(Index = 1167)]
        /* 0x8618 */ public float ByteBeatSequencerActiveSaturation;
        [NMS(Index = 1164)]
        /* 0x861C */ public float ByteBeatSequencerCornerRadius;
        [NMS(Index = 1183)]
        /* 0x8620 */ public float ByteBeatSequencerHighlightLineWidth;
        [NMS(Index = 1166)]
        /* 0x8624 */ public float ByteBeatSequencerInactiveSaturation;
        [NMS(Index = 1161)]
        /* 0x8628 */ public float ByteBeatSequencerLineWidth;
        [NMS(Index = 1162)]
        /* 0x862C */ public float ByteBeatSequencerPad;
        [NMS(Index = 1170)]
        /* 0x8630 */ public float ByteBeatSequencerUnpoweredTintStrength;
        [NMS(Index = 1186)]
        /* 0x8634 */ public float ByteBeatSliderCornerRadius;
        [NMS(Index = 1184)]
        /* 0x8638 */ public float ByteBeatSliderLineWidth;
        [NMS(Index = 1185)]
        /* 0x863C */ public float ByteBeatSliderPad;
        [NMS(Index = 1190)]
        /* 0x8640 */ public float ByteBeatSwitchPanelAlpha;
        [NMS(Index = 1191)]
        /* 0x8644 */ public float ByteBeatSwitchPanelSplit;
        [NMS(Index = 1147)]
        /* 0x8648 */ public float ByteBeatTreeLineWidth;
        [NMS(Index = 1149)]
        /* 0x864C */ public float ByteBeatVisLineWidth;
        [NMS(Index = 133)]
        /* 0x8650 */ public float ClosestDoorMarkerBuffer;
        [NMS(Index = 200)]
        /* 0x8654 */ public float CockpitGlassDefrostTime;
        [NMS(Index = 199)]
        /* 0x8658 */ public float CockpitGlassFrostTime;
        [NMS(Index = 573)]
        /* 0x865C */ public float CommunicatorMessageTime;
        [NMS(Index = 397)]
        /* 0x8660 */ public float CompassAngleClamp;
        [NMS(Index = 400)]
        /* 0x8664 */ public float CompassAngleClampSpace;
        [NMS(Index = 398)]
        /* 0x8668 */ public float CompassAngleFade;
        [NMS(Index = 394)]
        /* 0x866C */ public float CompassDistanceMarkerMinScale;
        [NMS(Index = 395)]
        /* 0x8670 */ public float CompassDistanceMaxAngle;
        [NMS(Index = 392)]
        /* 0x8674 */ public float CompassDistanceScale;
        [NMS(Index = 388)]
        /* 0x8678 */ public float CompassDistanceScaleMin;
        [NMS(Index = 389)]
        /* 0x867C */ public float CompassDistanceScaleRange;
        [NMS(Index = 393)]
        /* 0x8680 */ public float CompassDistanceShipMinScale;
        [NMS(Index = 390)]
        /* 0x8684 */ public float CompassDistanceSpaceScaleMin;
        [NMS(Index = 391)]
        /* 0x8688 */ public float CompassDistanceSpaceScaleRange;
        [NMS(Index = 396)]
        /* 0x868C */ public float CompassDistanceYOffset;
        [NMS(Index = 386)]
        /* 0x8690 */ public float CompassHeight;
        [NMS(Index = 206)]
        /* 0x8694 */ public float CompassIconOffsetVR;
        [NMS(Index = 227)]
        /* 0x8698 */ public float CompassLineContractionEndAngle;
        [NMS(Index = 226)]
        /* 0x869C */ public float CompassLineContractionStartAngle;
        [NMS(Index = 228)]
        /* 0x86A0 */ public float CompassLineContractionTargetAngle;
        [NMS(Index = 232)]
        /* 0x86A4 */ public float CompassLineNotchAngleRange;
        [NMS(Index = 234)]
        /* 0x86A8 */ public float CompassLineNotchLength;
        [NMS(Index = 233)]
        /* 0x86AC */ public float CompassLineNotchThickness;
        [NMS(Index = 229)]
        /* 0x86B0 */ public int CompassLineNumNotches;
        [NMS(Index = 231)]
        /* 0x86B4 */ public float CompassLineOffset;
        [NMS(Index = 230)]
        /* 0x86B8 */ public float CompassLineThickness;
        [NMS(Index = 225)]
        /* 0x86BC */ public int CompassScreenHeight;
        [NMS(Index = 224)]
        /* 0x86C0 */ public int CompassScreenWidth;
        [NMS(Index = 387)]
        /* 0x86C4 */ public float CompassWidth;
        [NMS(Index = 603)]
        /* 0x86C8 */ public float ConsoleTextSpeed;
        [NMS(Index = 605)]
        /* 0x86CC */ public float ConsoleTextTimeMax;
        [NMS(Index = 604)]
        /* 0x86D0 */ public float ConsoleTextTimeMin;
        [NMS(Index = 734)]
        /* 0x86D4 */ public float ControlScrollDistance;
        [NMS(Index = 733)]
        /* 0x86D8 */ public int ControlScrollSteps;
        [NMS(Index = 616)]
        /* 0x86DC */ public float CreatureDistanceAlpha;
        [NMS(Index = 614)]
        /* 0x86E0 */ public float CreatureDistanceDisplayAngle;
        [NMS(Index = 615)]
        /* 0x86E4 */ public float CreatureDistanceFadeTime;
        [NMS(Index = 612)]
        /* 0x86E8 */ public float CreatureDistanceOffsetY;
        [NMS(Index = 613)]
        /* 0x86EC */ public float CreatureDistanceShadowOffset;
        [NMS(Index = 611)]
        /* 0x86F0 */ public float CreatureDistanceSize;
        [NMS(Index = 378)]
        /* 0x86F4 */ public float CreatureIconMergeAngle;
        [NMS(Index = 648)]
        /* 0x86F8 */ public float CreatureIconOffset;
        [NMS(Index = 649)]
        /* 0x86FC */ public float CreatureIconOffsetPhysics;
        [NMS(Index = 773)]
        /* 0x8700 */ public float CreatureInteractLabelOffsetY;
        [NMS(Index = 769)]
        /* 0x8704 */ public float CreatureReticuleScale;
        [NMS(Index = 739)]
        /* 0x8708 */ public float CreatureRoutineMarkerTime;
        [NMS(Index = 740)]
        /* 0x870C */ public int CreatureRoutineRegionsPerFrame;
        [NMS(Index = 825)]
        /* 0x8710 */ public float CriticalMessageTime;
        [NMS(Index = 701)]
        /* 0x8714 */ public float CrosshairAimOffTime;
        [NMS(Index = 700)]
        /* 0x8718 */ public float CrosshairAimTime;
        [NMS(Index = 702)]
        /* 0x871C */ public float CrosshairInnerMinFade;
        [NMS(Index = 703)]
        /* 0x8720 */ public float CrosshairInnerMinFadeRange;
        [NMS(Index = 724)]
        /* 0x8724 */ public float CrosshairInterceptAlpha;
        [NMS(Index = 721)]
        /* 0x8728 */ public float CrosshairInterceptBaseSize;
        [NMS(Index = 722)]
        /* 0x872C */ public float CrosshairInterceptCentreBaseSize;
        [NMS(Index = 725)]
        /* 0x8730 */ public float CrosshairInterceptLockRange;
        [NMS(Index = 720)]
        /* 0x8734 */ public float CrosshairInterceptSize;
        [NMS(Index = 723)]
        /* 0x8738 */ public float CrosshairInterceptSpringTime;
        [NMS(Index = 707)]
        /* 0x873C */ public float CrosshairLeadCornerOffset;
        [NMS(Index = 716)]
        /* 0x8740 */ public float CrosshairLeadFadeRange;
        [NMS(Index = 717)]
        /* 0x8744 */ public float CrosshairLeadFadeSize;
        [NMS(Index = 705)]
        /* 0x8748 */ public float CrosshairLeadInDelay;
        [NMS(Index = 706)]
        /* 0x874C */ public float CrosshairLeadInTime;
        [NMS(Index = 710)]
        /* 0x8750 */ public float CrosshairLeadPulseSize;
        [NMS(Index = 704)]
        /* 0x8754 */ public float CrosshairLeadScaleIn;
        [NMS(Index = 714)]
        /* 0x8758 */ public float CrosshairLeadSpring;
        [NMS(Index = 715)]
        /* 0x875C */ public float CrosshairLeadSpringOff;
        [NMS(Index = 709)]
        /* 0x8760 */ public float CrosshairLeadTopLock;
        [NMS(Index = 708)]
        /* 0x8764 */ public float CrosshairLeadTopOffset;
        [NMS(Index = 310)]
        /* 0x8768 */ public float CrosshairOffsetHmd;
        [NMS(Index = 311)]
        /* 0x876C */ public float CrosshairOffsetHmdUp;
        [NMS(Index = 309)]
        /* 0x8770 */ public float CrosshairScaleHmd;
        [NMS(Index = 313)]
        /* 0x8774 */ public int CrosshairScreenHeight;
        [NMS(Index = 312)]
        /* 0x8778 */ public int CrosshairScreenWidth;
        [NMS(Index = 713)]
        /* 0x877C */ public float CrosshairSpringAimTime;
        [NMS(Index = 712)]
        /* 0x8780 */ public float CrosshairSpringTime;
        [NMS(Index = 726)]
        /* 0x8784 */ public float CrosshairTargetLockSize;
        [NMS(Index = 1116)]
        /* 0x8788 */ public float CursorHoverSlowFactor;
        [NMS(Index = 1117)]
        /* 0x878C */ public float CursorHoverSlowFactorMin;
        [NMS(Index = 1114)]
        /* 0x8790 */ public float CursorHoverSlowFixedValue;
        [NMS(Index = 544)]
        /* 0x8794 */ public float DamageDirectionIndicatorOnScreenRadiusMultiplier;
        [NMS(Index = 618)]
        /* 0x8798 */ public float DamageImpactMergeTime;
        [NMS(Index = 620)]
        /* 0x879C */ public float DamageImpactMinDistance;
        [NMS(Index = 619)]
        /* 0x87A0 */ public float DamageImpactTimeBetweenNumbers;
        [NMS(Index = 629)]
        /* 0x87A4 */ public float DamageNumberBlackAlpha;
        [NMS(Index = 635)]
        /* 0x87A8 */ public float DamageNumberFadeIn;
        [NMS(Index = 636)]
        /* 0x87AC */ public float DamageNumberFadeOut;
        [NMS(Index = 628)]
        /* 0x87B0 */ public float DamageNumberLaserMaxDamage;
        [NMS(Index = 627)]
        /* 0x87B4 */ public float DamageNumberLaserMinDamage;
        [NMS(Index = 632)]
        /* 0x87B8 */ public float DamageNumberOffsetX;
        [NMS(Index = 633)]
        /* 0x87BC */ public float DamageNumberOffsetY;
        [NMS(Index = 630)]
        /* 0x87C0 */ public float DamageNumberOutline;
        [NMS(Index = 631)]
        /* 0x87C4 */ public float DamageNumberOutline2;
        [NMS(Index = 624)]
        /* 0x87C8 */ public float DamageNumberSize;
        [NMS(Index = 625)]
        /* 0x87CC */ public float DamageNumberSizeCritMultiplier;
        [NMS(Index = 623)]
        /* 0x87D0 */ public float DamageNumberSizeInShip;
        [NMS(Index = 626)]
        /* 0x87D4 */ public float DamageNumberSizeLaserMultiplier;
        [NMS(Index = 622)]
        /* 0x87D8 */ public float DamageNumberTime;
        [NMS(Index = 637)]
        /* 0x87DC */ public float DamageNumberUpOffset;
        [NMS(Index = 621)]
        /* 0x87E0 */ public float DamagePerSecondSampleTime;
        [NMS(Index = 466)]
        /* 0x87E4 */ public float DamageScannableHighlightTime;
        [NMS(Index = 467)]
        /* 0x87E8 */ public float DamageTrackArrowTime;
        [NMS(Index = 956)]
        /* 0x87EC */ public float DeathMessageSwitchTime;
        [NMS(Index = 957)]
        /* 0x87F0 */ public float DeathMessageTotalTime;
        [NMS(Index = 66)]
        /* 0x87F4 */ public int DebugMedalRank;
        [NMS(Index = 1063)]
        /* 0x87F8 */ public float DeepSeaHazardMultiplierCold;
        [NMS(Index = 1061)]
        /* 0x87FC */ public float DeepSeaHazardMultiplierHeat;
        [NMS(Index = 1062)]
        /* 0x8800 */ public float DeepSeaHazardMultiplierRad;
        [NMS(Index = 1060)]
        /* 0x8804 */ public float DeepSeaHazardMultiplierTox;
        [NMS(Index = 650)]
        /* 0x8808 */ public float DelayBeforeHidingHangarAfterGalaxyMap;
        [NMS(Index = 651)]
        /* 0x880C */ public float DelayBeforeShowingHangarIntoGalaxyMap;
        [NMS(Index = 598)]
        /* 0x8810 */ public float DescriptionTextDelay;
        [NMS(Index = 599)]
        /* 0x8814 */ public float DescriptionTextSpeed;
        [NMS(Index = 600)]
        /* 0x8818 */ public float DescriptionTextSpeedProgressive;
        [NMS(Index = 602)]
        /* 0x881C */ public float DescriptionTextTimeMax;
        [NMS(Index = 601)]
        /* 0x8820 */ public float DescriptionTextTimeMin;
        [NMS(Index = 1456)]
        /* 0x8824 */ public float DetailMessageDismissTime;
        [NMS(Index = 360)]
        /* 0x8828 */ public float DroneIndicatorCentreRadiusMax;
        [NMS(Index = 361)]
        /* 0x882C */ public float DroneIndicatorCentreRadiusMin;
        [NMS(Index = 362)]
        /* 0x8830 */ public float DroneIndicatorFadeRange;
        [NMS(Index = 359)]
        /* 0x8834 */ public float DroneIndicatorRadius;
        [NMS(Index = 114)]
        /* 0x8838 */ public float EggModifiyAnimLoopTime;
        [NMS(Index = 113)]
        /* 0x883C */ public float EggModifiyAnimMaxSize;
        [NMS(Index = 123)]
        /* 0x8840 */ public float EndOfSeasonAlertDelay;
        [NMS(Index = 162)]
        /* 0x8844 */ public float ExocraftHUDMarkerHideDistance;
        [NMS(Index = 163)]
        /* 0x8848 */ public float ExocraftHUDMarkerOffset;
        [NMS(Index = 120)]
        /* 0x884C */ public float ExpeditionStageChangeTime;
        [NMS(Index = 60)]
        /* 0x8850 */ public float EyeTrackingCursorBlendRate;
        [NMS(Index = 59)]
        /* 0x8854 */ public float EyeTrackingCursorBlendRateGameModeSelect;
        [NMS(Index = 58)]
        /* 0x8858 */ public float EyeTrackingPopupLookAwayTime;
        [NMS(Index = 61)]
        /* 0x885C */ public float EyeTrackingStickyHoverTime;
        [NMS(Index = 57)]
        /* 0x8860 */ public float EyeTrackingTimeBeforePopupsActivate;
        [NMS(Index = 1464)]
        /* 0x8864 */ public float FeedFrigateAnimAlphaChange;
        [NMS(Index = 1462)]
        /* 0x8868 */ public int FeedFrigateAnimNumPeriods;
        [NMS(Index = 1461)]
        /* 0x886C */ public float FeedFrigateAnimPeriod;
        [NMS(Index = 1463)]
        /* 0x8870 */ public float FeedFrigateAnimScaleChange;
        [NMS(Index = 128)]
        /* 0x8874 */ public int ForceOpenHazardProtInventoryThreshold;
        [NMS(Index = 663)]
        /* 0x8878 */ public float FreighterCommanderMarkerMinDistance;
        [NMS(Index = 697)]
        /* 0x887C */ public float FreighterEntranceOffset;
        [NMS(Index = 669)]
        /* 0x8880 */ public float FreighterHighlightRange;
        [NMS(Index = 696)]
        /* 0x8884 */ public float FreighterLeaderIconDistance;
        [NMS(Index = 103)]
        /* 0x8888 */ public float FreighterMegaWarpTransitionTime;
        [NMS(Index = 659)]
        /* 0x888C */ public float FreighterSummonDelay;
        [NMS(Index = 662)]
        /* 0x8890 */ public float FreighterSummonGridSize;
        [NMS(Index = 668)]
        /* 0x8894 */ public float FreighterSummonLookTime;
        [NMS(Index = 654)]
        /* 0x8898 */ public float FreighterSummonOffset;
        [NMS(Index = 655)]
        /* 0x889C */ public float FreighterSummonOffsetPulse;
        [NMS(Index = 653)]
        /* 0x88A0 */ public float FreighterSummonPitch;
        [NMS(Index = 667)]
        /* 0x88A4 */ public float FreighterSummonPlanetOffset;
        [NMS(Index = 666)]
        /* 0x88A8 */ public float FreighterSummonPulseFadeAmount;
        [NMS(Index = 665)]
        /* 0x88AC */ public float FreighterSummonPulseRate;
        [NMS(Index = 652)]
        /* 0x88B0 */ public float FreighterSummonTurn;
        [NMS(Index = 661)]
        /* 0x88B4 */ public float FreighterSummonTurnAngleIncrement;
        [NMS(Index = 660)]
        /* 0x88B8 */ public int FreighterSummonTurnNumTries;
        [NMS(Index = 664)]
        /* 0x88BC */ public float FreighterSurfaceMinAngle;
        [NMS(Index = 695)]
        /* 0x88C0 */ public float FrigateDamageIconVisibilityDistance;
        [NMS(Index = 647)]
        /* 0x88C4 */ public float FrigateIconOffset;
        [NMS(Index = 694)]
        /* 0x88C8 */ public float FrigatePurchaseNotificationResetDistanceMultiplier;
        [NMS(Index = 1136)]
        /* 0x88CC */ public float FrontendActivateSplit;
        [NMS(Index = 1135)]
        /* 0x88D0 */ public float FrontendActivateTime;
        [NMS(Index = 1120)]
        /* 0x88D4 */ public float FrontendBGAlpha;
        [NMS(Index = 1140)]
        /* 0x88D8 */ public float FrontendBootBarTime;
        [NMS(Index = 1139)]
        /* 0x88DC */ public float FrontendBootTime;
        [NMS(Index = 1124)]
        /* 0x88E0 */ public float FrontendConfirmTime;
        [NMS(Index = 1122)]
        /* 0x88E4 */ public float FrontendConfirmTimeFast;
        [NMS(Index = 1121)]
        /* 0x88E8 */ public float FrontendConfirmTimeMouseMultiplier;
        [NMS(Index = 1125)]
        /* 0x88EC */ public float FrontendConfirmTimeSlow;
        [NMS(Index = 1128)]
        /* 0x88F0 */ public float FrontendCursorOffset;
        [NMS(Index = 1127)]
        /* 0x88F4 */ public float FrontendCursorSize;
        [NMS(Index = 1132)]
        /* 0x88F8 */ public float FrontendCursorWidth;
        [NMS(Index = 1134)]
        /* 0x88FC */ public float FrontendDeactivateSplit;
        [NMS(Index = 1133)]
        /* 0x8900 */ public float FrontendDeactivateTime;
        [NMS(Index = 1212)]
        /* 0x8904 */ public float FrontendDoFBlurMultiplier;
        [NMS(Index = 1210)]
        /* 0x8908 */ public float FrontendDoFFarPlane;
        [NMS(Index = 1211)]
        /* 0x890C */ public float FrontendDoFFarPlaneFade;
        [NMS(Index = 1209)]
        /* 0x8910 */ public float FrontendDoFNearPlane;
        [NMS(Index = 191)]
        /* 0x8914 */ public float FrontendOffsetVR;
        [NMS(Index = 1214)]
        /* 0x8918 */ public float FrontendShineSpeed;
        [NMS(Index = 1137)]
        /* 0x891C */ public float FrontendStatCircleWidth;
        [NMS(Index = 1138)]
        /* 0x8920 */ public float FrontendStatCircleWidthExtra;
        [NMS(Index = 1217)]
        /* 0x8924 */ public float FrontendTitleFontSpacing;
        [NMS(Index = 1215)]
        /* 0x8928 */ public float FrontendToolbarTextHeight;
        [NMS(Index = 1216)]
        /* 0x892C */ public float FrontendToolbarTextHeightSelected;
        [NMS(Index = 1123)]
        /* 0x8930 */ public float FrontendTouchConfirmTimeFastMultiplier;
        [NMS(Index = 593)]
        /* 0x8934 */ public float FrontendWaitFadeProgressiveDialogOut;
        [NMS(Index = 592)]
        /* 0x8938 */ public float FrontendWaitFadeTextFrameOut;
        [NMS(Index = 591)]
        /* 0x893C */ public float FrontendWaitFadeTextOut;
        [NMS(Index = 589)]
        /* 0x8940 */ public float FrontendWaitInitial;
        [NMS(Index = 590)]
        /* 0x8944 */ public float FrontendWaitInitialTerminal;
        [NMS(Index = 588)]
        /* 0x8948 */ public float FrontendWaitResponse;
        [NMS(Index = 594)]
        /* 0x894C */ public float FrontendWaitResponseOffset;
        [NMS(Index = 890)]
        /* 0x8950 */ public float GalaxyMapRadialBorder;
        [NMS(Index = 891)]
        /* 0x8954 */ public float GalaxyMapRadialTargetDist;
        [NMS(Index = 190)]
        /* 0x8958 */ public float GalmapDiscoveryOffsetVR;
        [NMS(Index = 112)]
        /* 0x895C */ public float GameModeSelectColourFadeTime;
        [NMS(Index = 1470)]
        /* 0x8960 */ public float GDKHandheldMinFontHeight;
        [NMS(Index = 93)]
        /* 0x8964 */ public float GridDecayRateSwitchValue;
        [NMS(Index = 577)]
        /* 0x8968 */ public float GridFlickerAmp;
        [NMS(Index = 575)]
        /* 0x896C */ public float GridFlickerBaseAlpha;
        [NMS(Index = 576)]
        /* 0x8970 */ public float GridFlickerFreq;
        [NMS(Index = 253)]
        /* 0x8974 */ public float HandButtonClickTime;
        [NMS(Index = 249)]
        /* 0x8978 */ public float HandButtonCursorScale;
        [NMS(Index = 257)]
        /* 0x897C */ public float HandButtonDotRadius;
        [NMS(Index = 255)]
        /* 0x8980 */ public float HandButtonFrontendCursorScale;
        [NMS(Index = 251)]
        /* 0x8984 */ public float HandButtonNearDistance;
        [NMS(Index = 246)]
        /* 0x8988 */ public float HandButtonPostClickTime;
        [NMS(Index = 258)]
        /* 0x898C */ public float HandButtonPulseRadius;
        [NMS(Index = 259)]
        /* 0x8990 */ public float HandButtonPulseThickness;
        [NMS(Index = 250)]
        /* 0x8994 */ public float HandButtonPushDistance;
        [NMS(Index = 242)]
        /* 0x8998 */ public float HandButtonRadius;
        [NMS(Index = 252)]
        /* 0x899C */ public float HandButtonRadiusClick;
        [NMS(Index = 243)]
        /* 0x89A0 */ public float HandButtonRadiusTouch;
        [NMS(Index = 244)]
        /* 0x89A4 */ public float HandButtonRadiusTouchNear;
        [NMS(Index = 245)]
        /* 0x89A8 */ public float HandButtonRadiusTouchNearActive;
        [NMS(Index = 247)]
        /* 0x89AC */ public float HandButtonReleaseThreshold;
        [NMS(Index = 248)]
        /* 0x89B0 */ public float HandButtonReleaseThresholdInit;
        [NMS(Index = 256)]
        /* 0x89B4 */ public float HandButtonThickness;
        [NMS(Index = 254)]
        /* 0x89B8 */ public float HandButtonTouchReturnTime;
        [NMS(Index = 279)]
        /* 0x89BC */ public float HandControlButtonSize;
        [NMS(Index = 286)]
        /* 0x89C0 */ public float HandControlMenuAngle;
        [NMS(Index = 236)]
        /* 0x89C4 */ public float HandControlMenuCursorScale;
        [NMS(Index = 292)]
        /* 0x89C8 */ public float HandControlMenuDepth;
        [NMS(Index = 285)]
        /* 0x89CC */ public float HandControlMenuMoveActionDistance;
        [NMS(Index = 282)]
        /* 0x89D0 */ public float HandControlMenuMoveDistance;
        [NMS(Index = 283)]
        /* 0x89D4 */ public float HandControlMenuMoveDistanceScroll;
        [NMS(Index = 284)]
        /* 0x89D8 */ public float HandControlMenuMoveDistanceVertical;
        [NMS(Index = 288)]
        /* 0x89DC */ public float HandControlMenuSelectRadius;
        [NMS(Index = 289)]
        /* 0x89E0 */ public float HandControlMenuSelectRadius1;
        [NMS(Index = 290)]
        /* 0x89E4 */ public float HandControlMenuSelectRadius2;
        [NMS(Index = 287)]
        /* 0x89E8 */ public float HandControlMenuSurfaceOffset;
        [NMS(Index = 281)]
        /* 0x89EC */ public float HandControlPointActiveMargin;
        [NMS(Index = 280)]
        /* 0x89F0 */ public float HandControlPointMargin;
        [NMS(Index = 291)]
        /* 0x89F4 */ public float HandControlTopMenuSelectRadius;
        [NMS(Index = 136)]
        /* 0x89F8 */ public float HandheldHUDZoomFactor;
        [NMS(Index = 240)]
        /* 0x89FC */ public float HandScreenGraphicsHeight;
        [NMS(Index = 239)]
        /* 0x8A00 */ public float HandScreenGraphicsWidth;
        [NMS(Index = 296)]
        /* 0x8A04 */ public int HandScreenHeight;
        [NMS(Index = 241)]
        /* 0x8A08 */ public float HandScreenNearActivateDistance;
        [NMS(Index = 294)]
        /* 0x8A0C */ public int HandScreenWeaponHeight;
        [NMS(Index = 293)]
        /* 0x8A10 */ public int HandScreenWeaponWidth;
        [NMS(Index = 295)]
        /* 0x8A14 */ public int HandScreenWidth;
        [NMS(Index = 1207)]
        /* 0x8A18 */ public float HatchAlphaBase;
        [NMS(Index = 1208)]
        /* 0x8A1C */ public float HatchAlphaCursor;
        [NMS(Index = 1206)]
        /* 0x8A20 */ public float HatchAlphaMain;
        [NMS(Index = 1204)]
        /* 0x8A24 */ public int HatchCount;
        [NMS(Index = 1205)]
        /* 0x8A28 */ public float HatchCursorRadius;
        [NMS(Index = 1203)]
        /* 0x8A2C */ public float HatchPulsePauseTime;
        [NMS(Index = 1201)]
        /* 0x8A30 */ public float HatchPulseSpeed;
        [NMS(Index = 1202)]
        /* 0x8A34 */ public float HatchPulseWidth;
        [NMS(Index = 677)]
        /* 0x8A38 */ public float HazardArrowsLevel2Threshold;
        [NMS(Index = 678)]
        /* 0x8A3C */ public float HazardArrowsLevel3Threshold;
        [NMS(Index = 1039)]
        /* 0x8A40 */ public float HazardBarPulseTime;
        [NMS(Index = 1044)]
        /* 0x8A44 */ public float HazardPainPulseStrength;
        [NMS(Index = 1065)]
        /* 0x8A48 */ public float HazardPulseRate;
        [NMS(Index = 1036)]
        /* 0x8A4C */ public float HazardScreenEffectPulseRate;
        [NMS(Index = 1040)]
        /* 0x8A50 */ public float HazardScreenEffectPulseTime;
        [NMS(Index = 1041)]
        /* 0x8A54 */ public float HazardScreenEffectStrength;
        [NMS(Index = 1043)]
        /* 0x8A58 */ public float HazardWarningPulseStrength;
        [NMS(Index = 1042)]
        /* 0x8A5C */ public float HazardWarningPulseTime;
        [NMS(Index = 1227)]
        /* 0x8A60 */ public float HitMarkerPulseSize;
        [NMS(Index = 1228)]
        /* 0x8A64 */ public float HitMarkerPulseSizeStatic;
        [NMS(Index = 1229)]
        /* 0x8A68 */ public float HitMarkerPulseTime;
        [NMS(Index = 307)]
        /* 0x8A6C */ public float HmdFramerateScreenPitch;
        [NMS(Index = 1032)]
        /* 0x8A70 */ public float HoldTimerResetTime;
        [NMS(Index = 606)]
        /* 0x8A74 */ public float HoverOffscreenBorder;
        [NMS(Index = 607)]
        /* 0x8A78 */ public float HoverOffscreenBorderXVR;
        [NMS(Index = 608)]
        /* 0x8A7C */ public float HoverOffscreenBorderYAltUI;
        [NMS(Index = 53)]
        /* 0x8A80 */ public float HoverPopAnimDuration;
        [NMS(Index = 52)]
        /* 0x8A84 */ public float HoverPopScaleModification;
        [NMS(Index = 830)]
        /* 0x8A88 */ public float HUDDisplayTime;
        [NMS(Index = 776)]
        /* 0x8A8C */ public float HUDDroneCombatPulse;
        [NMS(Index = 774)]
        /* 0x8A90 */ public float HUDDroneHealingPulse;
        [NMS(Index = 775)]
        /* 0x8A94 */ public float HUDDroneSummoningPulse;
        [NMS(Index = 968)]
        /* 0x8A98 */ public float HUDElementsOffsetHMDBottom;
        [NMS(Index = 966)]
        /* 0x8A9C */ public float HUDElementsOffsetHMDSide;
        [NMS(Index = 967)]
        /* 0x8AA0 */ public float HUDElementsOffsetHMDTop;
        [NMS(Index = 969)]
        /* 0x8AA4 */ public float HUDElementsOffsetX_0;
        [NMS(Index = 971)]
        /* 0x8AA8 */ public float HUDElementsOffsetX_1;
        [NMS(Index = 973)]
        /* 0x8AAC */ public float HUDElementsOffsetX_2;
        [NMS(Index = 975)]
        /* 0x8AB0 */ public float HUDElementsOffsetX_3;
        [NMS(Index = 977)]
        /* 0x8AB4 */ public float HUDElementsOffsetX_4;
        [NMS(Index = 979)]
        /* 0x8AB8 */ public float HUDElementsOffsetX_5;
        [NMS(Index = 970)]
        /* 0x8ABC */ public float HUDElementsOffsetY_0;
        [NMS(Index = 972)]
        /* 0x8AC0 */ public float HUDElementsOffsetY_1;
        [NMS(Index = 974)]
        /* 0x8AC4 */ public float HUDElementsOffsetY_2;
        [NMS(Index = 976)]
        /* 0x8AC8 */ public float HUDElementsOffsetY_3;
        [NMS(Index = 978)]
        /* 0x8ACC */ public float HUDElementsOffsetY_4;
        [NMS(Index = 980)]
        /* 0x8AD0 */ public float HUDElementsOffsetY_5;
        [NMS(Index = 1361)]
        /* 0x8AD4 */ public float HUDMarkerActiveTime;
        [NMS(Index = 1356)]
        /* 0x8AD8 */ public float HUDMarkerAlpha;
        [NMS(Index = 1331)]
        /* 0x8ADC */ public float HUDMarkerAnimLoopTime;
        [NMS(Index = 1330)]
        /* 0x8AE0 */ public float HUDMarkerAnimOffset;
        [NMS(Index = 1329)]
        /* 0x8AE4 */ public float HUDMarkerAnimScale;
        [NMS(Index = 1328)]
        /* 0x8AE8 */ public float HUDMarkerAnimSpeed;
        [NMS(Index = 470)]
        /* 0x8AEC */ public float HUDMarkerDistanceOrTimeDistance;
        [NMS(Index = 1349)]
        /* 0x8AF0 */ public float HUDMarkerFarDistance;
        [NMS(Index = 1350)]
        /* 0x8AF4 */ public float HUDMarkerFarFadeRange;
        [NMS(Index = 1355)]
        /* 0x8AF8 */ public float HUDMarkerHorizonBlendRange;
        [NMS(Index = 1337)]
        /* 0x8AFC */ public float HUDMarkerHoverAngleTestGround;
        [NMS(Index = 314)]
        /* 0x8B00 */ public float HUDMarkerHoverAngleTestGroundHmd;
        [NMS(Index = 1341)]
        /* 0x8B04 */ public float HUDMarkerHoverAngleTestShip;
        [NMS(Index = 1342)]
        /* 0x8B08 */ public float HUDMarkerHoverShowLargeAngleTest;
        [NMS(Index = 1363)]
        /* 0x8B0C */ public float HUDMarkerIconHoverMinScale;
        [NMS(Index = 580)]
        /* 0x8B10 */ public float HUDMarkerLabelArriveDistance;
        [NMS(Index = 579)]
        /* 0x8B14 */ public float HUDMarkerLabelBaseWidth;
        [NMS(Index = 581)]
        /* 0x8B18 */ public float HUDMarkerLabelDisplayDistance;
        [NMS(Index = 578)]
        /* 0x8B1C */ public float HUDMarkerLabelWidthMultiplier;
        [NMS(Index = 1358)]
        /* 0x8B20 */ public float HUDMarkerModelFadeMinHeight;
        [NMS(Index = 1357)]
        /* 0x8B24 */ public float HUDMarkerModelFadeRange;
        [NMS(Index = 1347)]
        /* 0x8B28 */ public float HUDMarkerNearFadeDistance;
        [NMS(Index = 1348)]
        /* 0x8B2C */ public float HUDMarkerNearFadeRange;
        [NMS(Index = 582)]
        /* 0x8B30 */ public float HUDMarkerNonActiveMissionAlpha;
        [NMS(Index = 469)]
        /* 0x8B34 */ public float HUDMarkerObjectMinScreenDistance;
        [NMS(Index = 1311)]
        /* 0x8B38 */ public float HUDMarkerOffset;
        [NMS(Index = 1334)]
        /* 0x8B3C */ public float HUDMarkerPrimaryIndicatorSize;
        [NMS(Index = 1351)]
        /* 0x8B40 */ public float HUDMarkerScalerMin;
        [NMS(Index = 1352)]
        /* 0x8B44 */ public float HUDMarkerScalerRange;
        [NMS(Index = 1354)]
        /* 0x8B48 */ public float HUDMarkerScalerSizeMax;
        [NMS(Index = 1353)]
        /* 0x8B4C */ public float HUDMarkerScalerSizeMin;
        [NMS(Index = 1345)]
        /* 0x8B50 */ public float HUDMarkerShipOffsetMaxDist;
        [NMS(Index = 1346)]
        /* 0x8B54 */ public float HUDMarkerShipOffsetMinDist;
        [NMS(Index = 1359)]
        /* 0x8B58 */ public float HUDMarkerShowActualIconDistance;
        [NMS(Index = 1360)]
        /* 0x8B5C */ public float HUDMarkerShowActualSpaceIconDistance;
        [NMS(Index = 1340)]
        /* 0x8B60 */ public float HUDMarkerWideHoverAngleTest;
        [NMS(Index = 315)]
        /* 0x8B64 */ public float HUDMarkerWideHoverAngleTestHmd;
        [NMS(Index = 1339)]
        /* 0x8B68 */ public float HUDNetworkMarkerHoverAngleTestGround;
        [NMS(Index = 1344)]
        /* 0x8B6C */ public float HUDNetworkMarkerHoverAngleVRMul;
        [NMS(Index = 1343)]
        /* 0x8B70 */ public float HUDNetworkMarkerHoverShowLargeAngleTest;
        [NMS(Index = 1338)]
        /* 0x8B74 */ public float HUDPetCentreScreenAngle;
        [NMS(Index = 1335)]
        /* 0x8B78 */ public float HUDPetMarkerAngleTest;
        [NMS(Index = 1336)]
        /* 0x8B7C */ public float HUDPetMarkerAngleVRMul;
        [NMS(Index = 502)]
        /* 0x8B80 */ public float HUDPlayerPhonePulseScanFreq;
        [NMS(Index = 501)]
        /* 0x8B84 */ public float HUDPlayerSentinelPulseScanFreq;
        [NMS(Index = 499)]
        /* 0x8B88 */ public float HUDPlayerSentinelPulseWidth;
        [NMS(Index = 500)]
        /* 0x8B8C */ public float HUDPlayerSentinelRangeFactor;
        [NMS(Index = 878)]
        /* 0x8B90 */ public float HUDPlayerTrackArrowArrowSize;
        [NMS(Index = 847)]
        /* 0x8B94 */ public float HUDPlayerTrackArrowDamageGlowHullHitCriticalOpacityScale;
        [NMS(Index = 848)]
        /* 0x8B98 */ public float HUDPlayerTrackArrowDamageGlowHullHitOpacityScale;
        [NMS(Index = 855)]
        /* 0x8B9C */ public float HUDPlayerTrackArrowDamageGlowOffset;
        [NMS(Index = 851)]
        /* 0x8BA0 */ public float HUDPlayerTrackArrowDamageGlowShieldHitCriticalOpacityScale;
        [NMS(Index = 852)]
        /* 0x8BA4 */ public float HUDPlayerTrackArrowDamageGlowShieldHitOpacityScale;
        [NMS(Index = 879)]
        /* 0x8BA8 */ public float HUDPlayerTrackArrowDotSize;
        [NMS(Index = 859)]
        /* 0x8BAC */ public float HUDPlayerTrackArrowEnergyShieldDepletedGlowOpacityScale;
        [NMS(Index = 860)]
        /* 0x8BB0 */ public float HUDPlayerTrackArrowEnergyShieldDepletedTime;
        [NMS(Index = 857)]
        /* 0x8BB4 */ public float HUDPlayerTrackArrowEnergyShieldGlowOffset;
        [NMS(Index = 843)]
        /* 0x8BB8 */ public float HUDPlayerTrackArrowEnergyShieldLowThreshold;
        [NMS(Index = 844)]
        /* 0x8BBC */ public float HUDPlayerTrackArrowEnergyShieldOffset;
        [NMS(Index = 864)]
        /* 0x8BC0 */ public float HUDPlayerTrackArrowEnergyShieldStartChargeGlowOpacityScale;
        [NMS(Index = 865)]
        /* 0x8BC4 */ public float HUDPlayerTrackArrowEnergyShieldStartChargeTime;
        [NMS(Index = 887)]
        /* 0x8BC8 */ public float HUDPlayerTrackArrowFadeRange;
        [NMS(Index = 846)]
        /* 0x8BCC */ public float HUDPlayerTrackArrowGlowBaseOpacity;
        [NMS(Index = 839)]
        /* 0x8BD0 */ public float HUDPlayerTrackArrowHealthOffset;
        [NMS(Index = 802)]
        /* 0x8BD4 */ public float HUDPlayerTrackArrowIconBorderReducerShip;
        [NMS(Index = 799)]
        /* 0x8BD8 */ public float HUDPlayerTrackArrowIconFadeDist;
        [NMS(Index = 798)]
        /* 0x8BDC */ public float HUDPlayerTrackArrowIconFadeDistDrone;
        [NMS(Index = 797)]
        /* 0x8BE0 */ public float HUDPlayerTrackArrowIconFadeDistShip;
        [NMS(Index = 800)]
        /* 0x8BE4 */ public float HUDPlayerTrackArrowIconFadeRange;
        [NMS(Index = 801)]
        /* 0x8BE8 */ public float HUDPlayerTrackArrowIconFadeRangeShip;
        [NMS(Index = 792)]
        /* 0x8BEC */ public float HUDPlayerTrackArrowIconFadeTime;
        [NMS(Index = 796)]
        /* 0x8BF0 */ public float HUDPlayerTrackArrowIconPulse2Alpha;
        [NMS(Index = 790)]
        /* 0x8BF4 */ public float HUDPlayerTrackArrowIconPulseTime;
        [NMS(Index = 794)]
        /* 0x8BF8 */ public float HUDPlayerTrackArrowIconPulseWidth1;
        [NMS(Index = 795)]
        /* 0x8BFC */ public float HUDPlayerTrackArrowIconPulseWidth2;
        [NMS(Index = 791)]
        /* 0x8C00 */ public float HUDPlayerTrackArrowIconShowTime;
        [NMS(Index = 876)]
        /* 0x8C04 */ public float HUDPlayerTrackArrowIconSize;
        [NMS(Index = 886)]
        /* 0x8C08 */ public float HUDPlayerTrackArrowMinFadeDist;
        [NMS(Index = 871)]
        /* 0x8C0C */ public float HUDPlayerTrackArrowOffset;
        [NMS(Index = 803)]
        /* 0x8C10 */ public float HUDPlayerTrackArrowPulseOffset;
        [NMS(Index = 804)]
        /* 0x8C14 */ public float HUDPlayerTrackArrowPulseRate;
        [NMS(Index = 872)]
        /* 0x8C18 */ public float HUDPlayerTrackArrowScreenBorder;
        [NMS(Index = 789)]
        /* 0x8C1C */ public float HUDPlayerTrackArrowShipLabelOffset;
        [NMS(Index = 873)]
        /* 0x8C20 */ public float HUDPlayerTrackArrowSize;
        [NMS(Index = 875)]
        /* 0x8C24 */ public float HUDPlayerTrackArrowSizeMax;
        [NMS(Index = 874)]
        /* 0x8C28 */ public float HUDPlayerTrackArrowSizeMin;
        [NMS(Index = 877)]
        /* 0x8C2C */ public float HUDPlayerTrackArrowSmallIconSize;
        [NMS(Index = 870)]
        /* 0x8C30 */ public float HUDPlayerTrackArrowTargetDist;
        [NMS(Index = 869)]
        /* 0x8C34 */ public float HUDPlayerTrackArrowTargetDistShip;
        [NMS(Index = 835)]
        /* 0x8C38 */ public float HUDPlayerTrackArrowTextExtraHeight;
        [NMS(Index = 836)]
        /* 0x8C3C */ public float HUDPlayerTrackArrowTextExtraOffsetX;
        [NMS(Index = 837)]
        /* 0x8C40 */ public float HUDPlayerTrackArrowTextExtraOffsetY;
        [NMS(Index = 833)]
        /* 0x8C44 */ public float HUDPlayerTrackArrowTextHeight;
        [NMS(Index = 832)]
        /* 0x8C48 */ public float HUDPlayerTrackArrowTextOffset;
        [NMS(Index = 831)]
        /* 0x8C4C */ public float HUDPlayerTrackDangerPulse;
        [NMS(Index = 777)]
        /* 0x8C50 */ public float HUDPlayerTrackNoSightPulse;
        [NMS(Index = 780)]
        /* 0x8C54 */ public float HUDPlayerTrackTimerEnd;
        [NMS(Index = 781)]
        /* 0x8C58 */ public float HUDPlayerTrackTimerPulseRate;
        [NMS(Index = 778)]
        /* 0x8C5C */ public float HUDPlayerTrackTimerStart;
        [NMS(Index = 779)]
        /* 0x8C60 */ public float HUDPlayerTrackTimerStartFade;
        [NMS(Index = 1306)]
        /* 0x8C64 */ public float HUDTargetHealthDangerTime;
        [NMS(Index = 1305)]
        /* 0x8C68 */ public float HUDTargetHealthIconSize;
        [NMS(Index = 1309)]
        /* 0x8C6C */ public float HUDTargetIconOffset;
        [NMS(Index = 1310)]
        /* 0x8C70 */ public float HUDTargetIconSize;
        [NMS(Index = 1307)]
        /* 0x8C74 */ public float HUDTargetMarkerOffset;
        [NMS(Index = 1308)]
        /* 0x8C78 */ public float HUDTargetMarkerSize;
        [NMS(Index = 892)]
        /* 0x8C7C */ public float IconBackgroundAlpha;
        [NMS(Index = 420)]
        /* 0x8C80 */ public float IconGlowStrengthActive;
        [NMS(Index = 419)]
        /* 0x8C84 */ public float IconGlowStrengthError;
        [NMS(Index = 422)]
        /* 0x8C88 */ public float IconGlowStrengthHighlight;
        [NMS(Index = 421)]
        /* 0x8C8C */ public float IconGlowStrengthNeutral;
        [NMS(Index = 1075)]
        /* 0x8C90 */ public float IconPulseRate;
        [NMS(Index = 1459)]
        /* 0x8C94 */ public float InfoPortalGuideCycleTime;
        [NMS(Index = 1460)]
        /* 0x8C98 */ public float InfoPortalMilestonesCycleTime;
        [NMS(Index = 1096)]
        /* 0x8C9C */ public float InteractionIconInnerRadius;
        [NMS(Index = 1097)]
        /* 0x8CA0 */ public float InteractionIconOuterRadius;
        [NMS(Index = 318)]
        /* 0x8CA4 */ public float InteractionInWorldMinScreenDistance;
        [NMS(Index = 319)]
        /* 0x8CA8 */ public float InteractionInWorldMinScreenDistanceV2;
        [NMS(Index = 317)]
        /* 0x8CAC */ public float InteractionInWorldPitchDistance;
        [NMS(Index = 320)]
        /* 0x8CB0 */ public float InteractionInWorldSeatedNPCHeightAdjust;
        [NMS(Index = 321)]
        /* 0x8CB4 */ public float InteractionInWorldSeatedNPCHeightAdjustV2;
        [NMS(Index = 1094)]
        /* 0x8CB8 */ public float InteractionLabelHeight;
        [NMS(Index = 1087)]
        /* 0x8CBC */ public float InteractionLabelHorizontalLineLength;
        [NMS(Index = 1095)]
        /* 0x8CC0 */ public float InteractionLabelLineAlpha;
        [NMS(Index = 1099)]
        /* 0x8CC4 */ public float InteractionLabelPixelHeightMax;
        [NMS(Index = 1098)]
        /* 0x8CC8 */ public float InteractionLabelPixelHeightMin;
        [NMS(Index = 1093)]
        /* 0x8CCC */ public float InteractionLabelRadiusScaler;
        [NMS(Index = 1101)]
        /* 0x8CD0 */ public float InteractionLabelSpeedClose;
        [NMS(Index = 1100)]
        /* 0x8CD4 */ public float InteractionLabelSpeedOpen;
        [NMS(Index = 1002)]
        /* 0x8CD8 */ public float InteractionScanDisplayTime;
        [NMS(Index = 1001)]
        /* 0x8CDC */ public float InteractionScanMinTime;
        [NMS(Index = 1000)]
        /* 0x8CE0 */ public float InteractionScanScanTime;
        [NMS(Index = 1005)]
        /* 0x8CE4 */ public float InteractionScanSlapOverallTime;
        [NMS(Index = 1004)]
        /* 0x8CE8 */ public float InteractionScanSlapScale;
        [NMS(Index = 1003)]
        /* 0x8CEC */ public float InteractionScanSlapTime;
        [NMS(Index = 1031)]
        /* 0x8CF0 */ public float InventoryFullMessageRepeatTime;
        [NMS(Index = 952)]
        /* 0x8CF4 */ public float InventoryIconTime;
        [NMS(Index = 83)]
        /* 0x8CF8 */ public float InvSlotGradientFactor;
        [NMS(Index = 82)]
        /* 0x8CFC */ public float InvSlotGradientFactorMin;
        [NMS(Index = 84)]
        /* 0x8D00 */ public float InvSlotGradientTime;
        [NMS(Index = 264)]
        /* 0x8D04 */ public float InWorldInteractionScreenScale;
        [NMS(Index = 158)]
        /* 0x8D08 */ public float InWorldInteractLabelFarDistance;
        [NMS(Index = 159)]
        /* 0x8D0C */ public float InWorldInteractLabelFarRange;
        [NMS(Index = 217)]
        /* 0x8D10 */ public int InWorldInteractLabelHeight;
        [NMS(Index = 155)]
        /* 0x8D14 */ public float InWorldInteractLabelMinHeadOffset;
        [NMS(Index = 156)]
        /* 0x8D18 */ public float InWorldInteractLabelNearDistance;
        [NMS(Index = 157)]
        /* 0x8D1C */ public float InWorldInteractLabelNearRange;
        [NMS(Index = 147)]
        /* 0x8D20 */ public float InWorldInteractLabelScale;
        [NMS(Index = 148)]
        /* 0x8D24 */ public float InWorldInteractLabelScaleV2;
        [NMS(Index = 216)]
        /* 0x8D28 */ public int InWorldInteractLabelWidth;
        [NMS(Index = 212)]
        /* 0x8D2C */ public float InWorldNGuiScreenScale;
        [NMS(Index = 265)]
        /* 0x8D30 */ public float InWorldNPCInteractionScreenScale;
        [NMS(Index = 211)]
        /* 0x8D34 */ public float InWorldScreenForwardOffset;
        [NMS(Index = 210)]
        /* 0x8D38 */ public float InWorldScreenMinScreenDistance;
        [NMS(Index = 149)]
        /* 0x8D3C */ public float InWorldScreenScaleDistance;
        [NMS(Index = 56)]
        /* 0x8D40 */ public float InWorldUIInteractionDistanceWithEyeTrackingEnabled;
        [NMS(Index = 955)]
        /* 0x8D44 */ public float ItemReceivedMessageTimeToAdd;
        [NMS(Index = 995)]
        /* 0x8D48 */ public float ItemSlotColourTechChargeRate;
        [NMS(Index = 1037)]
        /* 0x8D4C */ public float KeepHazardBarActiveTime;
        [NMS(Index = 1038)]
        /* 0x8D50 */ public float KeepSecondHazardBarActiveTime;
        [NMS(Index = 930)]
        /* 0x8D54 */ public float LandNotifyHeightThreshold;
        [NMS(Index = 929)]
        /* 0x8D58 */ public float LandNotifySpeedThreshold;
        [NMS(Index = 931)]
        /* 0x8D5C */ public float LandNotifyTimeThreshold;
        [NMS(Index = 743)]
        /* 0x8D60 */ public float LargeSpaceIconSize;
        [NMS(Index = 358)]
        /* 0x8D64 */ public float LoadFadeInDefaultTime;
        [NMS(Index = 142)]
        /* 0x8D68 */ public float LoadingScreenTime;
        [NMS(Index = 141)]
        /* 0x8D6C */ public float LoadingScreenTravelSpeed;
        [NMS(Index = 140)]
        /* 0x8D70 */ public float LoadingTravelDistance;
        [NMS(Index = 1375)]
        /* 0x8D74 */ public float LockOnMarkerSize;
        [NMS(Index = 1376)]
        /* 0x8D78 */ public float LockOnMarkerSizeLock;
        [NMS(Index = 208)]
        /* 0x8D7C */ public float LowerHelmetScreenPitch;
        [NMS(Index = 207)]
        /* 0x8D80 */ public float LowerHelmetScreenScale;
        [NMS(Index = 520)]
        /* 0x8D84 */ public float LowHealthShieldFactor;
        [NMS(Index = 519)]
        /* 0x8D88 */ public float LowHealthShieldMin;
        [NMS(Index = 473)]
        /* 0x8D8C */ public float MaintenanceIconFadeStart;
        [NMS(Index = 474)]
        /* 0x8D90 */ public float MaintenanceIconFadeTime;
        [NMS(Index = 950)]
        /* 0x8D94 */ public float ManualNotificationPauseTime;
        [NMS(Index = 1458)]
        /* 0x8D98 */ public float ManualScrollChangePerInputMax;
        [NMS(Index = 1457)]
        /* 0x8D9C */ public float ManualScrollChangePerInputMin;
        [NMS(Index = 471)]
        /* 0x8DA0 */ public float MarkerComponentOffset;
        [NMS(Index = 368)]
        /* 0x8DA4 */ public float MarkerHorizonApproachAngle;
        [NMS(Index = 367)]
        /* 0x8DA8 */ public float MarkerHorizonMinOffset;
        [NMS(Index = 374)]
        /* 0x8DAC */ public float MarkerHorizonOffPlanetLightBeamAngle;
        [NMS(Index = 366)]
        /* 0x8DB0 */ public float MarkerHorizonOffsetAngle;
        [NMS(Index = 375)]
        /* 0x8DB4 */ public float MarkerHorizonShipApproachOffset;
        [NMS(Index = 369)]
        /* 0x8DB8 */ public float MarkerOffsetTypeAngle;
        [NMS(Index = 373)]
        /* 0x8DBC */ public float MarkerOffsetTypeAngleAsteroid;
        [NMS(Index = 370)]
        /* 0x8DC0 */ public float MarkerOffsetTypeAngleBattle;
        [NMS(Index = 371)]
        /* 0x8DC4 */ public float MarkerOffsetTypeAngleBounty;
        [NMS(Index = 372)]
        /* 0x8DC8 */ public float MarkerOffsetTypeAnglePlayerShip;
        [NMS(Index = 456)]
        /* 0x8DCC */ public float MarkerRingInnerRadius;
        [NMS(Index = 457)]
        /* 0x8DD0 */ public float MarkerRingOuterRadius;
        [NMS(Index = 384)]
        /* 0x8DD4 */ public float MarkerTagAppearDelay;
        [NMS(Index = 523)]
        /* 0x8DD8 */ public int MaxDialogCharSizeIdeographic;
        [NMS(Index = 521)]
        /* 0x8DDC */ public int MaxDialogCharSizeRoman;
        [NMS(Index = 379)]
        /* 0x8DE0 */ public int MaxNumMessageBeaconIcons;
        [NMS(Index = 193)]
        /* 0x8DE4 */ public float MaxProjectorDistanceFromDefault;
        [NMS(Index = 196)]
        /* 0x8DE8 */ public float MaxProjectorGrabDistance;
        [NMS(Index = 2)]
        /* 0x8DEC */ public int MaxScannedAsteroidArrows;
        [NMS(Index = 97)]
        /* 0x8DF0 */ public int MaxSubstanceMaxAmountForAmountFraction;
        [NMS(Index = 1476)]
        /* 0x8DF4 */ public float MeltdownStartedOSDDuration;
        [NMS(Index = 1475)]
        /* 0x8DF8 */ public float MeltdownWarningOSDDuration;
        [NMS(Index = 953)]
        /* 0x8DFC */ public float MessageNotificationTime;
        [NMS(Index = 954)]
        /* 0x8E00 */ public float MessageTimeQuick;
        [NMS(Index = 121)]
        /* 0x8E04 */ public float MilestoneStingDisplayTime;
        [NMS(Index = 1451)]
        /* 0x8E08 */ public float MinimumHoldFill;
        [NMS(Index = 119)]
        /* 0x8E0C */ public float MinSeasonPlayTimeInDays;
        [NMS(Index = 756)]
        /* 0x8E10 */ public float MissileCentreOffset;
        [NMS(Index = 1381)]
        /* 0x8E14 */ public float MissileIconAttackPulseAmount;
        [NMS(Index = 1380)]
        /* 0x8E18 */ public float MissileIconAttackPulseTime;
        [NMS(Index = 737)]
        /* 0x8E1C */ public float MissionCompassIconScaler;
        [NMS(Index = 383)]
        /* 0x8E20 */ public float MissionDetailsPageBaseHeight;
        [NMS(Index = 549)]
        /* 0x8E24 */ public int MissionLoopCount;
        [NMS(Index = 550)]
        /* 0x8E28 */ public int MissionLoopCountPirate;
        [NMS(Index = 738)]
        /* 0x8E2C */ public float MissionMarkerSize;
        [NMS(Index = 380)]
        /* 0x8E30 */ public float MissionObjectiveBaseHeight;
        [NMS(Index = 381)]
        /* 0x8E34 */ public float MissionObjectiveDoneHeight;
        [NMS(Index = 382)]
        /* 0x8E38 */ public float MissionObjectiveScrollingExtra;
        [NMS(Index = 551)]
        /* 0x8E3C */ public int MissionSeedOffset;
        [NMS(Index = 548)]
        /* 0x8E40 */ public int MissionSpecificMissionPercent;
        [NMS(Index = 532)]
        /* 0x8E44 */ public float MissionStartEndOSDTime;
        [NMS(Index = 533)]
        /* 0x8E48 */ public float MissionStartEndOSDTimeProcedural;
        [NMS(Index = 531)]
        /* 0x8E4C */ public float MissionStartEndTime;
        [NMS(Index = 51)]
        /* 0x8E50 */ public float ModularCustomisationApplyTime;
        [NMS(Index = 1466)]
        /* 0x8E54 */ public float MouseRotateCameraSensitivity;
        [NMS(Index = 1436)]
        /* 0x8E58 */ public float MultiplayerTeleportEffectAppearTime;
        [NMS(Index = 1435)]
        /* 0x8E5C */ public float MultiplayerTeleportEffectDisappearTime;
        [NMS(Index = 1401)]
        /* 0x8E60 */ public float NGuiActiveAreaOffsetTime;
        [NMS(Index = 1392)]
        /* 0x8E64 */ public float NGuiAltPlacementDistanceScrollSpeed;
        [NMS(Index = 1400)]
        /* 0x8E68 */ public float NGuiCursorOffsetMultiplier;
        [NMS(Index = 306)]
        /* 0x8E6C */ public float NGuiHmdOffset;
        [NMS(Index = 1382)]
        /* 0x8E70 */ public float NGuiModelRotationDegreesX;
        [NMS(Index = 1383)]
        /* 0x8E74 */ public float NGuiModelRotationDegreesY;
        [NMS(Index = 1384)]
        /* 0x8E78 */ public float NGuiModelRotationDegreesZ;
        [NMS(Index = 1391)]
        /* 0x8E7C */ public float NGuiModelViewCdSmoothTime;
        [NMS(Index = 1389)]
        /* 0x8E80 */ public float NGuiModelViewDistanceDiscoveryPage;
        [NMS(Index = 1385)]
        /* 0x8E84 */ public float NGuiModelViewDistanceGlobal;
        [NMS(Index = 1388)]
        /* 0x8E88 */ public float NGuiModelViewDistanceShipPage;
        [NMS(Index = 1386)]
        /* 0x8E8C */ public float NGuiModelViewDistanceSuitPage;
        [NMS(Index = 1387)]
        /* 0x8E90 */ public float NGuiModelViewDistanceWeaponPage;
        [NMS(Index = 1409)]
        /* 0x8E94 */ public float NGuiModelViewFadeInAfterRenderTime;
        [NMS(Index = 1390)]
        /* 0x8E98 */ public float NGuiModelViewFov;
        [NMS(Index = 1394)]
        /* 0x8E9C */ public float NGuiModelViewFractionOfBBHeightAboveReflectivePlane;
        [NMS(Index = 1219)]
        /* 0x8EA0 */ public float NGuiMouseSensitivity;
        [NMS(Index = 1218)]
        /* 0x8EA4 */ public float NGuiPadSensitivity;
        [NMS(Index = 1393)]
        /* 0x8EA8 */ public float NGuiPlacementAngleScrollSpeed;
        [NMS(Index = 1398)]
        /* 0x8EAC */ public float NGuiThumbnailModelRotationDegreesY;
        [NMS(Index = 1399)]
        /* 0x8EB0 */ public float NGuiThumbnailModelViewDistance;
        [NMS(Index = 905)]
        /* 0x8EB4 */ public float NotificationBackgroundGradientAlphaInShip;
        [NMS(Index = 904)]
        /* 0x8EB8 */ public float NotificationBackgroundGradientEndOffsetPercentInShip;
        [NMS(Index = 938)]
        /* 0x8EBC */ public float NotificationBridgeReachDistance;
        [NMS(Index = 912)]
        /* 0x8EC0 */ public float NotificationBuildHintStartTime;
        [NMS(Index = 917)]
        /* 0x8EC4 */ public float NotificationCantFireTime;
        [NMS(Index = 918)]
        /* 0x8EC8 */ public float NotificationDangerTime;
        [NMS(Index = 943)]
        /* 0x8ECC */ public float NotificationDeviceIdleTime;
        [NMS(Index = 939)]
        /* 0x8ED0 */ public float NotificationDiscoveryIdleTime;
        [NMS(Index = 936)]
        /* 0x8ED4 */ public float NotificationFinalMissionWait;
        [NMS(Index = 934)]
        /* 0x8ED8 */ public float NotificationGoToSpaceStationWait;
        [NMS(Index = 357)]
        /* 0x8EDC */ public float NotificationHazardMinTimeAfterRecharge;
        [NMS(Index = 909)]
        /* 0x8EE0 */ public float NotificationHazardSafeThreshold;
        [NMS(Index = 910)]
        /* 0x8EE4 */ public float NotificationHazardTimer;
        [NMS(Index = 940)]
        /* 0x8EE8 */ public float NotificationInfoIdleTime;
        [NMS(Index = 911)]
        /* 0x8EEC */ public float NotificationInteractHintStartTime;
        [NMS(Index = 913)]
        /* 0x8EF0 */ public float NotificationJetpackTime;
        [NMS(Index = 922)]
        /* 0x8EF4 */ public float NotificationMaxPageHintTime;
        [NMS(Index = 921)]
        /* 0x8EF8 */ public float NotificationMessageCycleTime;
        [NMS(Index = 908)]
        /* 0x8EFC */ public float NotificationMinVisibleTime;
        [NMS(Index = 944)]
        /* 0x8F00 */ public float NotificationMissionHintTime;
        [NMS(Index = 945)]
        /* 0x8F04 */ public float NotificationMissionHintTimeCritical;
        [NMS(Index = 946)]
        /* 0x8F08 */ public float NotificationMissionHintTimeSecondary;
        [NMS(Index = 935)]
        /* 0x8F0C */ public float NotificationMonolithMissionWait;
        [NMS(Index = 941)]
        /* 0x8F10 */ public float NotificationNewTechIdleTime;
        [NMS(Index = 942)]
        /* 0x8F14 */ public float NotificationScanEventMissionIdleTime;
        [NMS(Index = 919)]
        /* 0x8F18 */ public float NotificationScanTime;
        [NMS(Index = 920)]
        /* 0x8F1C */ public float NotificationScanTimeCutoff;
        [NMS(Index = 914)]
        /* 0x8F20 */ public float NotificationShieldTime;
        [NMS(Index = 926)]
        /* 0x8F24 */ public float NotificationShipBoostMinTime;
        [NMS(Index = 927)]
        /* 0x8F28 */ public float NotificationShipBoostReminderTime;
        [NMS(Index = 928)]
        /* 0x8F2C */ public float NotificationShipBoostReminderTimeTutorial;
        [NMS(Index = 915)]
        /* 0x8F30 */ public float NotificationShipBoostTime;
        [NMS(Index = 916)]
        /* 0x8F34 */ public float NotificationShipBoostTimeVR;
        [NMS(Index = 923)]
        /* 0x8F38 */ public float NotificationShipJumpMinTime;
        [NMS(Index = 924)]
        /* 0x8F3C */ public float NotificationShipJumpReminderTime;
        [NMS(Index = 925)]
        /* 0x8F40 */ public float NotificationShipJumpReminderTutorial;
        [NMS(Index = 906)]
        /* 0x8F44 */ public int NotificationsResourceExtractHintCount;
        [NMS(Index = 907)]
        /* 0x8F48 */ public float NotificationStaminaHintDistanceWalked;
        [NMS(Index = 932)]
        /* 0x8F4C */ public float NotificationTimeBeforeHeridiumMarker;
        [NMS(Index = 933)]
        /* 0x8F50 */ public float NotificationUrgentMessageTime;
        [NMS(Index = 937)]
        /* 0x8F54 */ public float NotificationWaypointReachDistance;
        [NMS(Index = 826)]
        /* 0x8F58 */ public int NumDeathQuotes;
        [NMS(Index = 543)]
        /* 0x8F5C */ public float OnFootDamageDirectionIndicatorFadeRange;
        [NMS(Index = 542)]
        /* 0x8F60 */ public float OnFootDamageDirectionIndicatorRadius;
        [NMS(Index = 143)]
        /* 0x8F64 */ public float OSDMessagePauseOffscreenAngle;
        [NMS(Index = 346)]
        /* 0x8F68 */ public int OSDMessageQueueMax;
        [NMS(Index = 345)]
        /* 0x8F6C */ public int OSDMessageQueueMin;
        [NMS(Index = 344)]
        /* 0x8F70 */ public float OSDMessageQueueSpeedMultiplier;
        [NMS(Index = 11)]
        /* 0x8F74 */ public float OutpostPortalMarkerDistance;
        [NMS(Index = 1118)]
        /* 0x8F78 */ public float PadCursorAcceleration;
        [NMS(Index = 1119)]
        /* 0x8F7C */ public float PadCursorMaxSpeedModifier;
        [NMS(Index = 94)]
        /* 0x8F80 */ public float PadCursorUICurveStrength;
        [NMS(Index = 1465)]
        /* 0x8F84 */ public float PadRotateCameraSensitivity;
        [NMS(Index = 516)]
        /* 0x8F88 */ public float PageTurnTime;
        [NMS(Index = 110)]
        /* 0x8F8C */ public float ParagraphAutoScrollSpeed;
        [NMS(Index = 982)]
        /* 0x8F90 */ public float PauseMenuHoldTime;
        [NMS(Index = 165)]
        /* 0x8F94 */ public float PetBattleStatUnlockBounceTime;
        [NMS(Index = 167)]
        /* 0x8F98 */ public float PetBattleStatUnlockMessageTime;
        [NMS(Index = 166)]
        /* 0x8F9C */ public float PetBattleStatUrgentBounceTime;
        [NMS(Index = 7)]
        /* 0x8FA0 */ public float PetGeneIconGlowTimeNormal;
        [NMS(Index = 8)]
        /* 0x8FA4 */ public float PetGeneIconGlowTimeUrgent;
        [NMS(Index = 745)]
        /* 0x8FA8 */ public float PetHoverIconSize;
        [NMS(Index = 168)]
        /* 0x8FAC */ public float PetHUDMarkerExtraFollowInfoDistance;
        [NMS(Index = 169)]
        /* 0x8FB0 */ public float PetHUDMarkerHideDistance;
        [NMS(Index = 170)]
        /* 0x8FB4 */ public float PetHUDMarkerHideDistanceShort;
        [NMS(Index = 171)]
        /* 0x8FB8 */ public float PetHUDMarkerOffset;
        [NMS(Index = 746)]
        /* 0x8FBC */ public float PetIconSize;
        [NMS(Index = 172)]
        /* 0x8FC0 */ public float PetMoodMarkerOffset;
        [NMS(Index = 164)]
        /* 0x8FC4 */ public float PetSlotUnlockBounceTime;
        [NMS(Index = 646)]
        /* 0x8FC8 */ public float PhotoModeTimeofDayChange;
        [NMS(Index = 645)]
        /* 0x8FCC */ public float PhotoModeValueAlpha;
        [NMS(Index = 675)]
        /* 0x8FD0 */ public float PirateAttackIndicatorRadius;
        [NMS(Index = 674)]
        /* 0x8FD4 */ public float PirateAttackIndicatorWidth;
        [NMS(Index = 676)]
        /* 0x8FD8 */ public float PirateAttackProbeDisplayFinishFactor;
        [NMS(Index = 673)]
        /* 0x8FDC */ public float PirateCountdownTime;
        [NMS(Index = 658)]
        /* 0x8FE0 */ public float PirateFreighterSummonAtOffset;
        [NMS(Index = 656)]
        /* 0x8FE4 */ public float PirateFreighterSummonOffset;
        [NMS(Index = 657)]
        /* 0x8FE8 */ public float PirateFreighterSummonOffsetPulse;
        [NMS(Index = 139)]
        /* 0x8FEC */ public float PlacedMarkerFadeTime;
        [NMS(Index = 129)]
        /* 0x8FF0 */ public float PlanetDataExtraRadius;
        [NMS(Index = 989)]
        /* 0x8FF4 */ public float PlanetLabelAngle;
        [NMS(Index = 988)]
        /* 0x8FF8 */ public float PlanetLabelTime;
        [NMS(Index = 1233)]
        /* 0x8FFC */ public float PlanetPoleEastWestDistanceFromPlayer;
        [NMS(Index = 1232)]
        /* 0x9000 */ public float PlanetPoleMaxDotProduct;
        [NMS(Index = 514)]
        /* 0x9004 */ public float PlanetRaidMarkerOffset;
        [NMS(Index = 688)]
        /* 0x9008 */ public float PlanetScanDelayTime;
        [NMS(Index = 1143)]
        /* 0x900C */ public float PopupActivateTime;
        [NMS(Index = 1144)]
        /* 0x9010 */ public float PopupDeactivateTime;
        [NMS(Index = 1142)]
        /* 0x9014 */ public float PopupDebounceTime;
        [NMS(Index = 1131)]
        /* 0x9018 */ public float PopupSlotWidthOffset;
        [NMS(Index = 85)]
        /* 0x901C */ public float PopupTitleGradientFactor;
        [NMS(Index = 347)]
        /* 0x9020 */ public float PopupValueSectionBaseHeight;
        [NMS(Index = 348)]
        /* 0x9024 */ public float PopupValueSectionHeight;
        [NMS(Index = 1129)]
        /* 0x9028 */ public float PopupXClampOffset;
        [NMS(Index = 1130)]
        /* 0x902C */ public float PopupXClampOffsetRightAligned;
        [NMS(Index = 198)]
        /* 0x9030 */ public float ProjectorGrabBorderPercent;
        [NMS(Index = 197)]
        /* 0x9034 */ public float ProjectorGrabDistanceBias;
        [NMS(Index = 194)]
        /* 0x9038 */ public float ProjectorGrabResetTime;
        [NMS(Index = 192)]
        /* 0x903C */ public float ProjectorScale;
        [NMS(Index = 238)]
        /* 0x9040 */ public float QuickMenuAlpha;
        [NMS(Index = 144)]
        /* 0x9044 */ public float QuickMenuCentrePos;
        [NMS(Index = 146)]
        /* 0x9048 */ public float QuickMenuCentreSideOffset;
        [NMS(Index = 586)]
        /* 0x904C */ public float QuickMenuCloseTime;
        [NMS(Index = 237)]
        /* 0x9050 */ public float QuickMenuCursorScale;
        [NMS(Index = 587)]
        /* 0x9054 */ public float QuickMenuErrorTime;
        [NMS(Index = 277)]
        /* 0x9058 */ public float QuickMenuHighlightRate;
        [NMS(Index = 278)]
        /* 0x905C */ public float QuickMenuHoldNavTime;
        [NMS(Index = 273)]
        /* 0x9060 */ public float QuickMenuInteractAdjustX;
        [NMS(Index = 274)]
        /* 0x9064 */ public float QuickMenuInteractAdjustY;
        [NMS(Index = 276)]
        /* 0x9068 */ public int QuickMenuScreenHeight;
        [NMS(Index = 275)]
        /* 0x906C */ public int QuickMenuScreenWidth;
        [NMS(Index = 145)]
        /* 0x9070 */ public float QuickMenuSideOffset;
        [NMS(Index = 269)]
        /* 0x9074 */ public float QuickMenuSwipeHeightMax;
        [NMS(Index = 268)]
        /* 0x9078 */ public float QuickMenuSwipeHeightMin;
        [NMS(Index = 1198)]
        /* 0x907C */ public float RadialMenuInnerRadius;
        [NMS(Index = 1199)]
        /* 0x9080 */ public float RadialMenuInnerRadiusCursor;
        [NMS(Index = 1200)]
        /* 0x9084 */ public float RadialMenuWedgeOffset;
        [NMS(Index = 503)]
        /* 0x9088 */ public float RefinerAutoCloseTime;
        [NMS(Index = 491)]
        /* 0x908C */ public float RefinerBeginDialInnerRadius;
        [NMS(Index = 490)]
        /* 0x9090 */ public float RefinerPadStartDecayTime;
        [NMS(Index = 489)]
        /* 0x9094 */ public float RefinerPadStartTime;
        [NMS(Index = 492)]
        /* 0x9098 */ public float RefinerProgressDialInnerRadius;
        [NMS(Index = 472)]
        /* 0x909C */ public float RepairTechLabelOffset;
        [NMS(Index = 461)]
        /* 0x90A0 */ public float RepairTechRepairedMessageTime;
        [NMS(Index = 459)]
        /* 0x90A4 */ public float RepairTechRepairedWaitTime1;
        [NMS(Index = 460)]
        /* 0x90A8 */ public float RepairTechRepairedWaitTime2;
        [NMS(Index = 1426)]
        /* 0x90AC */ public float ReportBaseFlashDelay;
        [NMS(Index = 1425)]
        /* 0x90B0 */ public float ReportBaseFlashIntensity;
        [NMS(Index = 1424)]
        /* 0x90B4 */ public float ReportBaseFlashTime;
        [NMS(Index = 1427)]
        /* 0x90B8 */ public float ReportCameraSpeed;
        [NMS(Index = 138)]
        /* 0x90BC */ public float ROGAllyFrontendZoomFactor;
        [NMS(Index = 814)]
        /* 0x90C0 */ public float ScanEventArrowOffsetMultiplier;
        [NMS(Index = 816)]
        /* 0x90C4 */ public float ScanEventArrowOffsetMultiplierFresh;
        [NMS(Index = 817)]
        /* 0x90C8 */ public float ScanEventArrowOffsetMultiplierLerpTime;
        [NMS(Index = 815)]
        /* 0x90CC */ public float ScanEventArrowOffsetMultiplierOneEvent;
        [NMS(Index = 813)]
        /* 0x90D0 */ public float ScanEventArrowPlayerFadeDistance;
        [NMS(Index = 812)]
        /* 0x90D4 */ public float ScanEventArrowPlayerFadeRange;
        [NMS(Index = 818)]
        /* 0x90D8 */ public float ScanEventArrowSecondaryAlpha;
        [NMS(Index = 811)]
        /* 0x90DC */ public float ScanEventArrowShipFadeDistance;
        [NMS(Index = 810)]
        /* 0x90E0 */ public float ScanEventArrowShipFadeRange;
        [NMS(Index = 819)]
        /* 0x90E4 */ public GcAudioWwiseEvents ScanEventIconAudio;
        [NMS(Index = 377)]
        /* 0x90E8 */ public float ScannableIconMergeAngle;
        [NMS(Index = 1102)]
        /* 0x90EC */ public float ScanTime;
        [NMS(Index = 118)]
        /* 0x90F0 */ public float SeasonalRingChangeTime;
        [NMS(Index = 116)]
        /* 0x90F4 */ public float SeasonalRingMultiplier;
        [NMS(Index = 117)]
        /* 0x90F8 */ public float SeasonalRingPulseTime;
        [NMS(Index = 49)]
        /* 0x90FC */ public float SeasonEndAutoHighlightDuration;
        [NMS(Index = 50)]
        /* 0x9100 */ public float SeasonEndAutoHighlightDurationMilestone;
        [NMS(Index = 48)]
        /* 0x9104 */ public GcAudioWwiseEvents SeasonEndAutoHighlightSFX;
        [NMS(Index = 47)]
        /* 0x9108 */ public float SeasonEndRewardsMaxScrollRate;
        [NMS(Index = 46)]
        /* 0x910C */ public float SeasonEndRewardsPageOpenDelayTime;
        [NMS(Index = 902)]
        /* 0x9110 */ public float SeasonMessageDelayTime;
        [NMS(Index = 108)]
        /* 0x9114 */ public float SentinelsDisabledHUDMessageTime;
        [NMS(Index = 1441)]
        /* 0x9118 */ public float SettlementStatFlashSpeed;
        [NMS(Index = 1442)]
        /* 0x911C */ public float SettlementStatInnerRadius;
        [NMS(Index = 1443)]
        /* 0x9120 */ public float SettlementStatOuterRadius;
        [NMS(Index = 1047)]
        /* 0x9124 */ public float ShieldHazardPulseRate;
        [NMS(Index = 1049)]
        /* 0x9128 */ public float ShieldHazardPulseThreshold;
        [NMS(Index = 1046)]
        /* 0x912C */ public float ShieldPulseTime;
        [NMS(Index = 1045)]
        /* 0x9130 */ public float ShieldSpringTime;
        [NMS(Index = 15)]
        /* 0x9134 */ public float ShipBuilderBarTime;
        [NMS(Index = 22)]
        /* 0x9138 */ public float ShipBuilderEndCircleRadius;
        [NMS(Index = 26)]
        /* 0x913C */ public float ShipBuilderLineLengthFadeMax;
        [NMS(Index = 25)]
        /* 0x9140 */ public float ShipBuilderLineLengthFadeMin;
        [NMS(Index = 24)]
        /* 0x9144 */ public float ShipBuilderLineMinFade;
        [NMS(Index = 23)]
        /* 0x9148 */ public float ShipBuilderLineWidth;
        [NMS(Index = 20)]
        /* 0x914C */ public float ShipBuilderSlotDropLength;
        [NMS(Index = 16)]
        /* 0x9150 */ public float ShipBuilderSlotLineDefaultWidthFactor;
        [NMS(Index = 18)]
        /* 0x9154 */ public float ShipBuilderSlotLineMaxFactor;
        [NMS(Index = 17)]
        /* 0x9158 */ public float ShipBuilderSlotLineMinFactor;
        [NMS(Index = 19)]
        /* 0x915C */ public float ShipBuilderSlotStartOffset;
        [NMS(Index = 21)]
        /* 0x9160 */ public float ShipBuilderStartCircleRadius;
        [NMS(Index = 541)]
        /* 0x9164 */ public float ShipDamageDirectionIndicatorFadeRange;
        [NMS(Index = 540)]
        /* 0x9168 */ public float ShipDamageDirectionIndicatorRadius;
        [NMS(Index = 808)]
        /* 0x916C */ public float ShipDesatDamper;
        [NMS(Index = 807)]
        /* 0x9170 */ public float ShipFullscreenDamper;
        [NMS(Index = 806)]
        /* 0x9174 */ public float ShipFullscreenDamperMin;
        [NMS(Index = 698)]
        /* 0x9178 */ public float ShipHeadsUpDisplayDistance;
        [NMS(Index = 699)]
        /* 0x917C */ public float ShipHeadsUpLineFadeTime;
        [NMS(Index = 322)]
        /* 0x9180 */ public float ShipHologramInWorldUIHeightAdjust;
        [NMS(Index = 323)]
        /* 0x9184 */ public float ShipHologramInWorldUIHeightAdjustV2;
        [NMS(Index = 1027)]
        /* 0x9188 */ public float ShipHUDHitPointSize;
        [NMS(Index = 1026)]
        /* 0x918C */ public float ShipHUDHitPointTime;
        [NMS(Index = 160)]
        /* 0x9190 */ public float ShipHUDMarkerHideDistance;
        [NMS(Index = 161)]
        /* 0x9194 */ public float ShipHUDMarkerOffset;
        [NMS(Index = 1011)]
        /* 0x9198 */ public float ShipHUDMaxOffscreenTargetDist;
        [NMS(Index = 1008)]
        /* 0x919C */ public float ShipHUDMissileLockSizeMax;
        [NMS(Index = 1007)]
        /* 0x91A0 */ public float ShipHUDMissileLockSizeMin;
        [NMS(Index = 1010)]
        /* 0x91A4 */ public float ShipHUDMissileLockSpringFast;
        [NMS(Index = 1009)]
        /* 0x91A8 */ public float ShipHUDMissileLockSpringSlow;
        [NMS(Index = 1014)]
        /* 0x91AC */ public float ShipHUDTargetAlpha;
        [NMS(Index = 1015)]
        /* 0x91B0 */ public float ShipHUDTargetArrowLength;
        [NMS(Index = 1019)]
        /* 0x91B4 */ public float ShipHUDTargetArrowsRotationRate;
        [NMS(Index = 1016)]
        /* 0x91B8 */ public float ShipHUDTargetMinDist;
        [NMS(Index = 1012)]
        /* 0x91BC */ public float ShipHUDTargetRadius;
        [NMS(Index = 1017)]
        /* 0x91C0 */ public float ShipHUDTargetRange;
        [NMS(Index = 1018)]
        /* 0x91C4 */ public float ShipHUDTargetScale;
        [NMS(Index = 1013)]
        /* 0x91C8 */ public float ShipHUDTargetTriangleRadius;
        [NMS(Index = 526)]
        /* 0x91CC */ public float ShipOverheatSwitchMessageTime;
        [NMS(Index = 525)]
        /* 0x91D0 */ public float ShipOverheatSwitchMessageWait;
        [NMS(Index = 1434)]
        /* 0x91D4 */ public float ShipScreenTexScale;
        [NMS(Index = 260)]
        /* 0x91D8 */ public float ShipSideScreenHeight;
        [NMS(Index = 10)]
        /* 0x91DC */ public float ShipTeleportPadMarkerDistance;
        [NMS(Index = 9)]
        /* 0x91E0 */ public float ShipTeleportPadMinDistance;
        [NMS(Index = 324)]
        /* 0x91E4 */ public float ShopInteractionInWorldForcedOffset;
        [NMS(Index = 325)]
        /* 0x91E8 */ public float ShopInteractionInWorldForcedOffsetV2;
        [NMS(Index = 125)]
        /* 0x91EC */ public int ShowDaysIfLessThan;
        [NMS(Index = 124)]
        /* 0x91F0 */ public int ShowHoursIfLessThan;
        [NMS(Index = 126)]
        /* 0x91F4 */ public int ShowWeeksIfLessThan;
        [NMS(Index = 744)]
        /* 0x91F8 */ public float SmallSpaceIconSize;
        [NMS(Index = 262)]
        /* 0x91FC */ public float SolidPointerLengthScale;
        [NMS(Index = 263)]
        /* 0x9200 */ public float SolidPointerMaxLength;
        [NMS(Index = 261)]
        /* 0x9204 */ public float SolidPointerScale;
        [NMS(Index = 1267)]
        /* 0x9208 */ public float SpaceMapActionScale;
        [NMS(Index = 1263)]
        /* 0x920C */ public float SpaceMapAnomalyScale;
        [NMS(Index = 1253)]
        /* 0x9210 */ public float SpaceMapAspectRatio;
        [NMS(Index = 1279)]
        /* 0x9214 */ public float SpaceMapCamAngle;
        [NMS(Index = 1280)]
        /* 0x9218 */ public float SpaceMapCamDistance;
        [NMS(Index = 1278)]
        /* 0x921C */ public float SpaceMapCamHeight;
        [NMS(Index = 564)]
        /* 0x9220 */ public float SpaceMapCockpitAngle;
        [NMS(Index = 553)]
        /* 0x9224 */ public float SpaceMapCockpitScale;
        [NMS(Index = 560)]
        /* 0x9228 */ public float SpaceMapCockpitScaleAdjustAlien;
        [NMS(Index = 562)]
        /* 0x922C */ public float SpaceMapCockpitScaleAdjustCorvette;
        [NMS(Index = 554)]
        /* 0x9230 */ public float SpaceMapCockpitScaleAdjustDropShip;
        [NMS(Index = 555)]
        /* 0x9234 */ public float SpaceMapCockpitScaleAdjustFighter;
        [NMS(Index = 561)]
        /* 0x9238 */ public float SpaceMapCockpitScaleAdjustRobot;
        [NMS(Index = 558)]
        /* 0x923C */ public float SpaceMapCockpitScaleAdjustRoyal;
        [NMS(Index = 559)]
        /* 0x9240 */ public float SpaceMapCockpitScaleAdjustSail;
        [NMS(Index = 556)]
        /* 0x9244 */ public float SpaceMapCockpitScaleAdjustScientific;
        [NMS(Index = 557)]
        /* 0x9248 */ public float SpaceMapCockpitScaleAdjustShuttle;
        [NMS(Index = 563)]
        /* 0x924C */ public float SpaceMapCockpitScaleAdjustSwarmDrone;
        [NMS(Index = 1272)]
        /* 0x9250 */ public float SpaceMapDistance;
        [NMS(Index = 1255)]
        /* 0x9254 */ public float SpaceMapDistanceLogScaler;
        [NMS(Index = 1274)]
        /* 0x9258 */ public float SpaceMapDistanceMultiplier;
        [NMS(Index = 1254)]
        /* 0x925C */ public float SpaceMapDistanceScale;
        [NMS(Index = 1277)]
        /* 0x9260 */ public float SpaceMapFadeAngleMax;
        [NMS(Index = 1276)]
        /* 0x9264 */ public float SpaceMapFadeAngleMin;
        [NMS(Index = 1252)]
        /* 0x9268 */ public float SpaceMapFoV;
        [NMS(Index = 1261)]
        /* 0x926C */ public float SpaceMapFreighterScale;
        [NMS(Index = 1275)]
        /* 0x9270 */ public float SpaceMapHorizonThickness;
        [NMS(Index = 1282)]
        /* 0x9274 */ public float SpaceMapLightPitch;
        [NMS(Index = 1283)]
        /* 0x9278 */ public float SpaceMapLightYaw;
        [NMS(Index = 1236)]
        /* 0x927C */ public float SpaceMapLineBaseFade;
        [NMS(Index = 1235)]
        /* 0x9280 */ public float SpaceMapLineBaseScale;
        [NMS(Index = 1234)]
        /* 0x9284 */ public float SpaceMapLineWidth;
        [NMS(Index = 1271)]
        /* 0x9288 */ public float SpaceMapMarkerScale;
        [NMS(Index = 1273)]
        /* 0x928C */ public float SpaceMapMaxTraderDistance;
        [NMS(Index = 1266)]
        /* 0x9290 */ public float SpaceMapMoonScale;
        [NMS(Index = 1260)]
        /* 0x9294 */ public float SpaceMapObjectScale;
        [NMS(Index = 1270)]
        /* 0x9298 */ public float SpaceMapPirateFreighterScale;
        [NMS(Index = 1269)]
        /* 0x929C */ public float SpaceMapPirateFrigateScale;
        [NMS(Index = 1265)]
        /* 0x92A0 */ public float SpaceMapPlanetLineOffset;
        [NMS(Index = 1264)]
        /* 0x92A4 */ public float SpaceMapPlanetScale;
        [NMS(Index = 1257)]
        /* 0x92A8 */ public float SpaceMapScaleMin;
        [NMS(Index = 1259)]
        /* 0x92AC */ public float SpaceMapScaleRangeMax;
        [NMS(Index = 1258)]
        /* 0x92B0 */ public float SpaceMapScaleRangeMin;
        [NMS(Index = 1237)]
        /* 0x92B4 */ public float SpaceMapShipCombineDistance;
        [NMS(Index = 1268)]
        /* 0x92B8 */ public float SpaceMapShipScale;
        [NMS(Index = 1281)]
        /* 0x92BC */ public float SpaceMapShipScaleMin;
        [NMS(Index = 1262)]
        /* 0x92C0 */ public float SpaceMapStationScale;
        [NMS(Index = 742)]
        /* 0x92C4 */ public float SpaceMarkersBattleOffset;
        [NMS(Index = 741)]
        /* 0x92C8 */ public float SpaceMarkersOffset;
        [NMS(Index = 132)]
        /* 0x92CC */ public float StackSizeChangeMaxRate;
        [NMS(Index = 131)]
        /* 0x92D0 */ public float StackSizeChangeMinRate;
        [NMS(Index = 130)]
        /* 0x92D4 */ public float StackSizeRateChangeRate;
        [NMS(Index = 122)]
        /* 0x92D8 */ public float StageStingDisplayTime;
        [NMS(Index = 534)]
        /* 0x92DC */ public float StandingRewardOSDTime;
        [NMS(Index = 901)]
        /* 0x92E0 */ public float StatsMessageDelayTime;
        [NMS(Index = 137)]
        /* 0x92E4 */ public float SteamDeckFrontendZoomFactor;
        [NMS(Index = 1469)]
        /* 0x92E8 */ public float SteamDeckMinFontHeight;
        [NMS(Index = 36)]
        /* 0x92EC */ public float StoreDialDecayTime;
        [NMS(Index = 35)]
        /* 0x92F0 */ public float StoreDialHoldTime;
        [NMS(Index = 37)]
        /* 0x92F4 */ public float StoreDialInnerRadius;
        [NMS(Index = 38)]
        /* 0x92F8 */ public float StoreDialOuterRadius;
        [NMS(Index = 91)]
        /* 0x92FC */ public float SuperchargeGradientFactor;
        [NMS(Index = 90)]
        /* 0x9300 */ public float SuperchargeGradientFactorMin;
        [NMS(Index = 92)]
        /* 0x9304 */ public float SuperchargeGradientTime;
        [NMS(Index = 809)]
        /* 0x9308 */ public float SurveyObjectArrowOffsetMultiplier;
        [NMS(Index = 365)]
        /* 0x930C */ public float TakeoffFuelMessageTime;
        [NMS(Index = 595)]
        /* 0x9310 */ public float TalkBoxAlienTextSpeed;
        [NMS(Index = 597)]
        /* 0x9314 */ public float TalkBoxAlienTextTimeMax;
        [NMS(Index = 596)]
        /* 0x9318 */ public float TalkBoxAlienTextTimeMin;
        [NMS(Index = 570)]
        /* 0x931C */ public float TargetDisplayDamageFlashTime;
        [NMS(Index = 565)]
        /* 0x9320 */ public float TargetDisplayScale;
        [NMS(Index = 567)]
        /* 0x9324 */ public float TargetDisplayShipScale;
        [NMS(Index = 566)]
        /* 0x9328 */ public float TargetDisplayTorpedoScale;
        [NMS(Index = 1225)]
        /* 0x932C */ public float TargetMarkerFadeAngleMin;
        [NMS(Index = 1226)]
        /* 0x9330 */ public float TargetMarkerFadeAngleRange;
        [NMS(Index = 1224)]
        /* 0x9334 */ public float TargetMarkerScaleEnd;
        [NMS(Index = 1223)]
        /* 0x9338 */ public float TargetMarkerScaleStart;
        [NMS(Index = 1408)]
        /* 0x933C */ public float TargetParallaxMaintenancePageMultiplier;
        [NMS(Index = 1407)]
        /* 0x9340 */ public float TargetParallaxMouseMultiplier;
        [NMS(Index = 1029)]
        /* 0x9344 */ public float TargetScreenDistance;
        [NMS(Index = 1028)]
        /* 0x9348 */ public float TargetScreenFoV;
        [NMS(Index = 824)]
        /* 0x934C */ public float TechDisplayDelayTime;
        [NMS(Index = 464)]
        /* 0x9350 */ public float TechPopupBuildLayerHeight;
        [NMS(Index = 462)]
        /* 0x9354 */ public float TechPopupInstallLayerHeight;
        [NMS(Index = 463)]
        /* 0x9358 */ public float TechPopupRepairLayerHeight;
        [NMS(Index = 465)]
        /* 0x935C */ public float TechPopupRequirementHeight;
        [NMS(Index = 1431)]
        /* 0x9360 */ public float TextChatMaxDisplayTime;
        [NMS(Index = 1432)]
        /* 0x9364 */ public float TextChatStayBigAfterTextInput;
        [NMS(Index = 201)]
        /* 0x9368 */ public float TextPrintoutMultiplier;
        [NMS(Index = 202)]
        /* 0x936C */ public float TextPrintoutMultiplierAlien;
        [NMS(Index = 31)]
        /* 0x9370 */ public float TextTouchScrollCap;
        [NMS(Index = 787)]
        /* 0x9374 */ public float ThirdPersonCrosshairCircle1Distance;
        [NMS(Index = 788)]
        /* 0x9378 */ public float ThirdPersonCrosshairCircle2Distance;
        [NMS(Index = 786)]
        /* 0x937C */ public float ThirdPersonCrosshairDistance;
        [NMS(Index = 610)]
        /* 0x9380 */ public float TimedEventLookTime;
        [NMS(Index = 951)]
        /* 0x9384 */ public float TooltipTime;
        [NMS(Index = 32)]
        /* 0x9388 */ public float TouchScrollChangePageThreshold;
        [NMS(Index = 29)]
        /* 0x938C */ public float TouchScrollMaxDelta;
        [NMS(Index = 30)]
        /* 0x9390 */ public float TouchScrollSpeedMul;
        [NMS(Index = 693)]
        /* 0x9394 */ public float TrackArrowDistanceSpacePOI;
        [NMS(Index = 784)]
        /* 0x9398 */ public float TrackCriticalHitSize;
        [NMS(Index = 785)]
        /* 0x939C */ public float TrackCriticalPulseTime;
        [NMS(Index = 760)]
        /* 0x93A0 */ public float TrackLeadTargetInScale;
        [NMS(Index = 757)]
        /* 0x93A4 */ public float TrackMissileTargetPulseRate;
        [NMS(Index = 750)]
        /* 0x93A8 */ public float TrackPoliceFreighterCentreOffset;
        [NMS(Index = 749)]
        /* 0x93AC */ public float TrackPrimaryCentreOffset;
        [NMS(Index = 762)]
        /* 0x93B0 */ public float TrackReticuleAngle;
        [NMS(Index = 764)]
        /* 0x93B4 */ public float TrackReticuleInactiveTime;
        [NMS(Index = 763)]
        /* 0x93B8 */ public float TrackReticuleInTime;
        [NMS(Index = 766)]
        /* 0x93BC */ public float TrackReticuleRandomDelay;
        [NMS(Index = 765)]
        /* 0x93C0 */ public float TrackReticuleRandomTime;
        [NMS(Index = 761)]
        /* 0x93C4 */ public float TrackReticuleScale;
        [NMS(Index = 758)]
        /* 0x93C8 */ public float TrackScaleCritical;
        [NMS(Index = 759)]
        /* 0x93CC */ public float TrackScaleHit;
        [NMS(Index = 751)]
        /* 0x93D0 */ public float TrackTimerAlpha;
        [NMS(Index = 755)]
        /* 0x93D4 */ public float TrackTimerIconExclaimRadius;
        [NMS(Index = 754)]
        /* 0x93D8 */ public float TrackTimerIconInnerRadius;
        [NMS(Index = 753)]
        /* 0x93DC */ public float TrackTimerIconOuterRadius;
        [NMS(Index = 752)]
        /* 0x93E0 */ public float TrackTimerRadarPulseSize;
        [NMS(Index = 748)]
        /* 0x93E4 */ public float TrackTypeIconSize;
        [NMS(Index = 34)]
        /* 0x93E8 */ public float TradePageNotifyOffset;
        [NMS(Index = 376)]
        /* 0x93EC */ public float TransferPopupCursorOffsetFactor;
        [NMS(Index = 609)]
        /* 0x93F0 */ public float TransferSendOffscreenBorder;
        [NMS(Index = 515)]
        /* 0x93F4 */ public float TransitionOffset;
        [NMS(Index = 327)]
        /* 0x93F8 */ public float TravelLineThickness;
        [NMS(Index = 326)]
        /* 0x93FC */ public float TravelTargetRadius;
        [NMS(Index = 41)]
        /* 0x9400 */ public float TrialUpsellDeclineDecayTimeQuick;
        [NMS(Index = 43)]
        /* 0x9404 */ public float TrialUpsellDeclineDecayTimeSlow;
        [NMS(Index = 44)]
        /* 0x9408 */ public float TrialUpsellDeclineDialInnerRadius;
        [NMS(Index = 45)]
        /* 0x940C */ public float TrialUpsellDeclineDialOuterRadius;
        [NMS(Index = 40)]
        /* 0x9410 */ public float TrialUpsellDeclineHoldTimeQuick;
        [NMS(Index = 42)]
        /* 0x9414 */ public float TrialUpsellDeclineHoldTimeSlow;
        [NMS(Index = 106)]
        /* 0x9418 */ public int UnknownWordsToShowInCatalogue;
        [NMS(Index = 1471)]
        /* 0x941C */ public float UnlockableTreeDefaultGroupGap;
        [NMS(Index = 1473)]
        /* 0x9420 */ public float UnlockableTreeDefaultRowGap;
        [NMS(Index = 1472)]
        /* 0x9424 */ public float UnlockableTreeNarrowGroupGap;
        [NMS(Index = 1474)]
        /* 0x9428 */ public float UnlockableTreeNarrowRowGap;
        [NMS(Index = 109)]
        /* 0x942C */ public float UseZoomedOutBuildCamRadius;
        [NMS(Index = 222)]
        /* 0x9430 */ public int VRFaceLockedScreenHeight;
        [NMS(Index = 221)]
        /* 0x9434 */ public int VRFaceLockedScreenWidth;
        [NMS(Index = 363)]
        /* 0x9438 */ public float WantedDetectMessageTime;
        [NMS(Index = 364)]
        /* 0x943C */ public float WantedDetectMinTimeout;
        [NMS(Index = 897)]
        /* 0x9440 */ public float WantedLevelScanAlpha;
        [NMS(Index = 898)]
        /* 0x9444 */ public float WantedLevelScannedRate;
        [NMS(Index = 895)]
        /* 0x9448 */ public float WantedLevelTimeoutPulseRate;
        [NMS(Index = 896)]
        /* 0x944C */ public float WantedLevelWitnessAlpha;
        [NMS(Index = 894)]
        /* 0x9450 */ public float WantedLevelWitnessOffset;
        [NMS(Index = 893)]
        /* 0x9454 */ public float WantedLevelWitnessPulseRate;
        [NMS(Index = 1454)]
        /* 0x9458 */ public float WinGDKHandheldPopupScale;
        [NMS(Index = 135)]
        /* 0x945C */ public float ZoomFactorOverride;
        [NMS(Index = 963)]
        /* 0x9460 */ public float ZoomHUDElementsOffsetX;
        [NMS(Index = 964)]
        /* 0x9464 */ public float ZoomHUDElementsOffsetY;
        [NMS(Index = 965)]
        /* 0x9468 */ public float ZoomHUDElementTime;
        [NMS(Index = 1327)]
        /* 0x946C */ public NMSString0x100 HUDCircleAnimIcon;
        [NMS(Index = 1325)]
        /* 0x956C */ public NMSString0x100 HUDDeathPointIcon;
        [NMS(Index = 1326)]
        /* 0x966C */ public NMSString0x100 HUDHexAnimIcon;
        [NMS(Index = 1321)]
        /* 0x976C */ public NMSString0x100 HUDMarkerColourIcon;
        [NMS(Index = 1319)]
        /* 0x986C */ public NMSString0x100 HUDMarkerIcon;
        [NMS(Index = 1320)]
        /* 0x996C */ public NMSString0x100 HUDMarkerPrimaryIndicatorIcon;
        [NMS(Index = 1322)]
        /* 0x9A6C */ public NMSString0x100 HUDPointIcon;
        [NMS(Index = 1324)]
        /* 0x9B6C */ public NMSString0x100 HUDSaveIcon;
        [NMS(Index = 1323)]
        /* 0x9C6C */ public NMSString0x100 HUDSpaceshipIcon;
        [NMS(Index = 961)]
        /* 0x9D6C */ public NMSString0x20 DistanceUnitKM;
        [NMS(Index = 960)]
        /* 0x9D8C */ public NMSString0x20 DistanceUnitM;
        [NMS(Index = 962)]
        /* 0x9DAC */ public NMSString0x20 DistanceUnitMpS;
        [NMS(Index = 524)]
        /* 0x9DCC */ public NMSString0x20 MaxDialogCharSizeIdeographicString;
        [NMS(Index = 522)]
        /* 0x9DEC */ public NMSString0x20 MaxDialogCharSizeRomanString;
        [NMS(Index = 218)]
        /* 0x9E0C */ public NMSString0x20 VRDistanceWarningUIFile;
        [NMS(Index = 410, Size = 0x15, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x9E2C */ public bool[] BuildMenuUseSmallIconOnPad;
        [NMS(Index = 1467)]
        /* 0x9E41 */ public bool AllowInventorySorting;
        [NMS(Index = 204)]
        /* 0x9E42 */ public bool AllowInWorldDebugBorders;
        [NMS(Index = 195)]
        /* 0x9E43 */ public bool AllowProjectorRepositioning;
        [NMS(Index = 334)]
        /* 0x9E44 */ public bool AlwaysCloseQuickMenu;
        [NMS(Index = 687)]
        /* 0x9E45 */ public TkCurveType ArrowBounceLeftCurve;
        [NMS(Index = 683)]
        /* 0x9E46 */ public TkCurveType ArrowBounceRightCurve;
        [NMS(Index = 111)]
        /* 0x9E47 */ public bool AutoScrollParagraphs;
        [NMS(Index = 438)]
        /* 0x9E48 */ public bool BaseBuildingSmoothMenuWhileSnapped;
        [NMS(Index = 99)]
        /* 0x9E49 */ public bool BigPicking;
        [NMS(Index = 100)]
        /* 0x9E4A */ public bool BigPickingUsesNumbers;
        [NMS(Index = 179)]
        /* 0x9E4B */ public bool BinocularScanScreen;
        [NMS(Index = 399)]
        /* 0x9E4C */ public TkCurveType CompassCurve;
        [NMS(Index = 772)]
        /* 0x9E4D */ public bool CreatureInteractLabelUseBB;
        [NMS(Index = 771)]
        /* 0x9E4E */ public TkCurveType CreatureReticuleAlphaCurve;
        [NMS(Index = 770)]
        /* 0x9E4F */ public TkCurveType CreatureReticuleScaleCurve;
        [NMS(Index = 711)]
        /* 0x9E50 */ public TkCurveType CrosshairLeadScaleCurve;
        [NMS(Index = 729)]
        /* 0x9E51 */ public TkCurveType CrosshairTargetLockAlphaCurve;
        [NMS(Index = 728)]
        /* 0x9E52 */ public TkCurveType CrosshairTargetLockCurve;
        [NMS(Index = 638)]
        /* 0x9E53 */ public TkCurveType DamageNumberUpCurve;
        [NMS(Index = 340)]
        /* 0x9E54 */ public bool DebugInventoryIndices;
        [NMS(Index = 583)]
        /* 0x9E55 */ public bool DebugMarkerLabels;
        [NMS(Index = 337)]
        /* 0x9E56 */ public bool DebugMissionLogText;
        [NMS(Index = 339)]
        /* 0x9E57 */ public bool DebugPopupSizes;
        [NMS(Index = 338)]
        /* 0x9E58 */ public bool DebugShowMaintenanceScreenCentre;
        [NMS(Index = 1452)]
        /* 0x9E59 */ public bool EnableAccessibleUIOnSwitch;
        [NMS(Index = 468)]
        /* 0x9E5A */ public bool EnableBlackouts;
        [NMS(Index = 828)]
        /* 0x9E5B */ public bool EnableBuilderRobotGreekConversion;
        [NMS(Index = 266)]
        /* 0x9E5C */ public bool EnableCraftingTree;
        [NMS(Index = 203)]
        /* 0x9E5D */ public bool EnableHandMenuButtons;
        [NMS(Index = 235)]
        /* 0x9E5E */ public bool EnableHandMenuDebug;
        [NMS(Index = 829)]
        /* 0x9E5F */ public bool EnableKanaConversion;
        [NMS(Index = 104)]
        /* 0x9E60 */ public bool EnablePopupUses;
        [NMS(Index = 341)]
        /* 0x9E61 */ public bool FixedInventoryIconPositions;
        [NMS(Index = 1141)]
        /* 0x9E62 */ public TkCurveType FrontendBootBarCurve;
        [NMS(Index = 1126)]
        /* 0x9E63 */ public TkCurveType FrontendConfirmCurve;
        [NMS(Index = 1213)]
        /* 0x9E64 */ public TkCurveType FrontendDoFCurve;
        [NMS(Index = 903)]
        /* 0x9E65 */ public bool HideExtremePlanetNotifications;
        [NMS(Index = 1429)]
        /* 0x9E66 */ public bool HideQuickMenuControls;
        [NMS(Index = 1362)]
        /* 0x9E67 */ public TkCurveType HUDMarkerActiveCurve;
        [NMS(Index = 1332)]
        /* 0x9E68 */ public TkCurveType HUDMarkerAnimAlphaCurve;
        [NMS(Index = 1333)]
        /* 0x9E69 */ public TkCurveType HUDMarkerAnimCurve;
        [NMS(Index = 861)]
        /* 0x9E6A */ public TkCurveType HUDPlayerTrackArrowEnergyShieldDepletedCurve;
        [NMS(Index = 866)]
        /* 0x9E6B */ public TkCurveType HUDPlayerTrackArrowEnergyShieldStartChargeCurve;
        [NMS(Index = 316)]
        /* 0x9E6C */ public bool InteractionInWorldPlayerCamAlways;
        [NMS(Index = 1006)]
        /* 0x9E6D */ public TkCurveType InteractionScanSlapCurve;
        [NMS(Index = 527)]
        /* 0x9E6E */ public bool LeadTargetEnabled;
        [NMS(Index = 1033)]
        /* 0x9E6F */ public bool ModelRendererBGPass;
        [NMS(Index = 1034)]
        /* 0x9E70 */ public bool ModelRendererPass1;
        [NMS(Index = 1035)]
        /* 0x9E71 */ public bool ModelRendererPass2;
        [NMS(Index = 1410)]
        /* 0x9E72 */ public TkCurveType NGuiModelViewFadeInAfterRenderCurve;
        [NMS(Index = 1411)]
        /* 0x9E73 */ public bool NGuiUseSeparateLayersForModelAndReflection;
        [NMS(Index = 223)]
        /* 0x9E74 */ public bool OnlyShowEjectHandlesInVR;
        [NMS(Index = 79)]
        /* 0x9E75 */ public TkCurveType PadCursorUICurve;
        [NMS(Index = 517)]
        /* 0x9E76 */ public TkCurveType PageTurnCurve;
        [NMS(Index = 518)]
        /* 0x9E77 */ public TkCurveType PageTurnFadeCurve;
        [NMS(Index = 1145)]
        /* 0x9E78 */ public TkCurveType PopupActivateCurve1;
        [NMS(Index = 1146)]
        /* 0x9E79 */ public TkCurveType PopupActivateCurve2;
        [NMS(Index = 572)]
        /* 0x9E7A */ public bool ProgressiveDialogStyle;
        [NMS(Index = 1430)]
        /* 0x9E7B */ public bool QuickMenuAllowCycle;
        [NMS(Index = 267)]
        /* 0x9E7C */ public bool QuickMenuEnableSwipe;
        [NMS(Index = 336)]
        /* 0x9E7D */ public bool RepairTechUseTechIcon;
        [NMS(Index = 95)]
        /* 0x9E7E */ public bool ReplaceItemBarWithNumbers;
        [NMS(Index = 1048)]
        /* 0x9E7F */ public bool ShieldHUDAlwaysOn;
        [NMS(Index = 585)]
        /* 0x9E80 */ public bool ShowDamageNumbers;
        [NMS(Index = 64)]
        /* 0x9E81 */ public bool ShowDifficultyForBases;
        [NMS(Index = 900)]
        /* 0x9E82 */ public bool ShowJetpackNotificationForNonTerrain;
        [NMS(Index = 617)]
        /* 0x9E83 */ public bool ShowOnscreenPredatorMarkers;
        [NMS(Index = 65)]
        /* 0x9E84 */ public bool ShowPadlockForLockedSettings;
        [NMS(Index = 219)]
        /* 0x9E85 */ public bool ShowVRDistanceWarning;
        [NMS(Index = 134)]
        /* 0x9E86 */ public bool SkipShopIntro;
        [NMS(Index = 1256)]
        /* 0x9E87 */ public TkCurveType SpaceMapDistanceCurve;
        [NMS(Index = 1242)]
        /* 0x9E88 */ public bool SpaceMapShowAnomaly;
        [NMS(Index = 1243)]
        /* 0x9E89 */ public bool SpaceMapShowAnomalyLines;
        [NMS(Index = 1249)]
        /* 0x9E8A */ public bool SpaceMapShowFrieghterLines;
        [NMS(Index = 1248)]
        /* 0x9E8B */ public bool SpaceMapShowFrieghters;
        [NMS(Index = 1244)]
        /* 0x9E8C */ public bool SpaceMapShowNexus;
        [NMS(Index = 1245)]
        /* 0x9E8D */ public bool SpaceMapShowNexusLines;
        [NMS(Index = 1239)]
        /* 0x9E8E */ public bool SpaceMapShowPlanetLines;
        [NMS(Index = 1238)]
        /* 0x9E8F */ public bool SpaceMapShowPlanets;
        [NMS(Index = 1251)]
        /* 0x9E90 */ public bool SpaceMapShowPulseEncounterLines;
        [NMS(Index = 1250)]
        /* 0x9E91 */ public bool SpaceMapShowPulseEncounters;
        [NMS(Index = 1247)]
        /* 0x9E92 */ public bool SpaceMapShowShipLines;
        [NMS(Index = 1246)]
        /* 0x9E93 */ public bool SpaceMapShowShips;
        [NMS(Index = 1240)]
        /* 0x9E94 */ public bool SpaceMapShowStation;
        [NMS(Index = 1241)]
        /* 0x9E95 */ public bool SpaceMapShowStationLines;
        [NMS(Index = 528)]
        /* 0x9E96 */ public bool SpaceOnlyLeadTargetEnabled;
        [NMS(Index = 105)]
        /* 0x9E97 */ public bool TechBoxesCanStack;
        [NMS(Index = 782)]
        /* 0x9E98 */ public TkCurveType TrackCritCurve;
        [NMS(Index = 768)]
        /* 0x9E99 */ public TkCurveType TrackReticuleInAngleCurve;
        [NMS(Index = 767)]
        /* 0x9E9A */ public TkCurveType TrackReticuleInCurve;
        [NMS(Index = 1115)]
        /* 0x9E9B */ public bool UseCursorHoverSlowFixedValue;
        [NMS(Index = 107)]
        /* 0x9E9C */ public bool UseIntermediateMissionGiverOptions;
        [NMS(Index = 834)]
        /* 0x9E9D */ public bool UseNamesOnShipHUD;
        [NMS(Index = 98)]
        /* 0x9E9E */ public bool UseSquareSlots;
        [NMS(Index = 335)]
        /* 0x9E9F */ public bool UseWorldNodesForRepair;
    }
}
