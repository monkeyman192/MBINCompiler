using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xCDFD5E6F07CD20D1, NameHash = 0xD1FA1B1C)]
    public class GcUIGlobals : NMSTemplate
    {
        [NMS(Index = 1109)]
        /* 0x0000 */ public GcModelViewCollection ModelViews;
        [NMS(Index = 0)]
        /* 0x27C0 */ public GcSolarSystemMapSettings SolarSystemMapSettings;
        [NMS(Index = 1108, Size = 0xC, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x3960 */ public TkModelRendererData[] ShipThumbnailRenderSettings;
        [NMS(Index = 1107)]
        /* 0x4260 */ public TkModelRendererData HoverShipThumbnailModelView;
        [NMS(Index = 1105)]
        /* 0x4320 */ public TkModelRendererData LargeMultitoolThumbnailModelView;
        [NMS(Index = 1104)]
        /* 0x43E0 */ public TkModelRendererData MultitoolThumbnailModelView;
        [NMS(Index = 1103)]
        /* 0x44A0 */ public TkModelRendererData PetThumbnailModelView;
        [NMS(Index = 477)]
        /* 0x4560 */ public TkModelRendererData RepairBackpackCamera;
        [NMS(Index = 475)]
        /* 0x4620 */ public TkModelRendererData RepairCamera;
        [NMS(Index = 478)]
        /* 0x46E0 */ public TkModelRendererData RepairShipCameraInWorld;
        [NMS(Index = 479)]
        /* 0x47A0 */ public TkModelRendererData RepairShipCameraModelView;
        [NMS(Index = 480)]
        /* 0x4860 */ public TkModelRendererData RepairShipCameraVR;
        [NMS(Index = 476)]
        /* 0x4920 */ public TkModelRendererData RepairWeaponCamera;
        [NMS(Index = 1106)]
        /* 0x49E0 */ public TkModelRendererData SpookShipThumbnailModelView;
        [NMS(Index = 1439)]
        /* 0x4AA0 */ public TkNGuiTreeViewTemplate FileBrowserTreeViewTemplate;
        [NMS(Index = 1438)]
        /* 0x4B20 */ public TkNGuiTreeViewTemplate SceneInfoTreeViewTemplate;
        [NMS(Index = 1440)]
        /* 0x4BA0 */ public TkNGuiTreeViewTemplate SkeletonToolsTreeViewTemplate;
        [NMS(Index = 584)]
        /* 0x4C20 */ public GcScanEffectData DebugEditorPreviewEffect;
        [NMS(Index = 670)]
        /* 0x4C70 */ public GcScanEffectData FreighterSummonScanEffect;
        [NMS(Index = 343)]
        /* 0x4CC0 */ public GcHUDEffectRewardData OSDEpicItemRewardEffect;
        [NMS(Index = 342)]
        /* 0x4D10 */ public GcHUDEffectRewardData OSDRareItemRewardEffect;
        [NMS(Index = 888, Size = 0x5, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x4D60 */ public Colour[] SystemHooverLEDColours;
        [NMS(Index = 889, Size = 0x5, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x4DB0 */ public Colour[] SystemHooverStatusBarColours;
        [NMS(Index = 571)]
        /* 0x4E00 */ public GcScanEffectData TargetDisplayScanEffect;
        [NMS(Index = 1297)]
        /* 0x4E50 */ public GcSpaceMapObjectData SpaceMapAtlasData;
        [NMS(Index = 1298)]
        /* 0x4E80 */ public GcSpaceMapObjectData SpaceMapBlackHoleData;
        [NMS(Index = 1300)]
        /* 0x4EB0 */ public GcSpaceMapObjectData SpaceMapFreighterData;
        [NMS(Index = 1293)]
        /* 0x4EE0 */ public GcSpaceMapObjectData SpaceMapMarkerData;
        [NMS(Index = 1296)]
        /* 0x4F10 */ public GcSpaceMapObjectData SpaceMapNexusData;
        [NMS(Index = 1294)]
        /* 0x4F40 */ public GcSpaceMapObjectData SpaceMapPlanetData;
        [NMS(Index = 1301)]
        /* 0x4F70 */ public GcSpaceMapObjectData SpaceMapPulseEncounterData;
        [NMS(Index = 1299)]
        /* 0x4FA0 */ public GcSpaceMapObjectData SpaceMapShipData;
        [NMS(Index = 1295)]
        /* 0x4FD0 */ public GcSpaceMapObjectData SpaceMapStationData;
        [NMS(Index = 1371)]
        /* 0x5000 */ public Colour AltimeterBandColour1;
        [NMS(Index = 1372)]
        /* 0x5010 */ public Colour AltimeterBandColour2;
        [NMS(Index = 1373)]
        /* 0x5020 */ public Colour AltimeterColour1;
        [NMS(Index = 1374)]
        /* 0x5030 */ public Colour AltimeterColour2;
        [NMS(Index = 405)]
        /* 0x5040 */ public Colour BaseComplexityDangerColour;
        [NMS(Index = 403)]
        /* 0x5050 */ public Colour BaseComplexityDefaultColour;
        [NMS(Index = 404)]
        /* 0x5060 */ public Colour BaseComplexityWarningColour;
        [NMS(Index = 189)]
        /* 0x5070 */ public Vector3f BinocularPanelLinePointOffset;
        [NMS(Index = 413)]
        /* 0x5080 */ public Colour BuildMenuErrorTextColour;
        [NMS(Index = 415)]
        /* 0x5090 */ public Colour BuildMenuErrorTextFlashColour;
        [NMS(Index = 414)]
        /* 0x50A0 */ public Colour BuildMenuErrorTextOutlineColour;
        [NMS(Index = 416)]
        /* 0x50B0 */ public Colour BuildMenuErrorTextOutlineFlashColour;
        [NMS(Index = 417)]
        /* 0x50C0 */ public Colour BuildMenuInfoTextColour;
        [NMS(Index = 418)]
        /* 0x50D0 */ public Colour BuildMenuInfoTextOutlineColour;
        [NMS(Index = 411)]
        /* 0x50E0 */ public Colour BuildMenuPassiveErrorTextColour;
        [NMS(Index = 412)]
        /* 0x50F0 */ public Colour BuildMenuPassiveErrorTextOutlineColour;
        [NMS(Index = 1158)]
        /* 0x5100 */ public Colour ByteBeatArpGridActiveColour;
        [NMS(Index = 1157)]
        /* 0x5110 */ public Colour ByteBeatArpGridInactiveColour;
        [NMS(Index = 1160)]
        /* 0x5120 */ public Colour ByteBeatArpPipActiveColour;
        [NMS(Index = 1159)]
        /* 0x5130 */ public Colour ByteBeatArpPipInactiveColour;
        [NMS(Index = 1176)]
        /* 0x5140 */ public Colour ByteBeatRhythmColour0Active;
        [NMS(Index = 1177)]
        /* 0x5150 */ public Colour ByteBeatRhythmColour0Inactive;
        [NMS(Index = 1178)]
        /* 0x5160 */ public Colour ByteBeatRhythmColour1Active;
        [NMS(Index = 1179)]
        /* 0x5170 */ public Colour ByteBeatRhythmColour1Inactive;
        [NMS(Index = 1180)]
        /* 0x5180 */ public Colour ByteBeatRhythmColour2Active;
        [NMS(Index = 1181)]
        /* 0x5190 */ public Colour ByteBeatRhythmColour2Inactive;
        [NMS(Index = 1172)]
        /* 0x51A0 */ public Colour ByteBeatSequencerBGColourActive;
        [NMS(Index = 1173)]
        /* 0x51B0 */ public Colour ByteBeatSequencerBGColourInactive;
        [NMS(Index = 1182)]
        /* 0x51C0 */ public Colour ByteBeatSequencerHighlightColour;
        [NMS(Index = 1174)]
        /* 0x51D0 */ public Colour ByteBeatSequencerRimColourActive;
        [NMS(Index = 1175)]
        /* 0x51E0 */ public Colour ByteBeatSequencerRimColourInactive;
        [NMS(Index = 1171)]
        /* 0x51F0 */ public Colour ByteBeatSequencerUnpoweredTint;
        [NMS(Index = 1187)]
        /* 0x5200 */ public Colour ByteBeatSliderFGColour;
        [NMS(Index = 1188)]
        /* 0x5210 */ public Colour ByteBeatSliderTextActiveColour;
        [NMS(Index = 1189)]
        /* 0x5220 */ public Colour ByteBeatSliderTextInactiveColour;
        [NMS(Index = 1148)]
        /* 0x5230 */ public Colour ByteBeatTreeLineColour;
        [NMS(Index = 1151)]
        /* 0x5240 */ public Colour ByteBeatVisGridColour;
        [NMS(Index = 1150)]
        /* 0x5250 */ public Colour ByteBeatVisLineColour;
        [NMS(Index = 574)]
        /* 0x5260 */ public Colour CommunicatorMessageColour;
        [NMS(Index = 730)]
        /* 0x5270 */ public Colour CrosshairColour;
        [NMS(Index = 719)]
        /* 0x5280 */ public Colour CrosshairLeadPassiveColour;
        [NMS(Index = 718)]
        /* 0x5290 */ public Colour CrosshairLeadThreatColour;
        [NMS(Index = 1110)]
        /* 0x52A0 */ public Colour CursorColour;
        [NMS(Index = 1111)]
        /* 0x52B0 */ public Colour CursorConfirmColour;
        [NMS(Index = 1113)]
        /* 0x52C0 */ public Colour CursorDeleteColour;
        [NMS(Index = 1112)]
        /* 0x52D0 */ public Colour CursorTransferUploadColour;
        [NMS(Index = 639)]
        /* 0x52E0 */ public Colour DamageNumberCriticalColour;
        [NMS(Index = 640)]
        /* 0x52F0 */ public Colour DamageNumberIneffectiveColour;
        [NMS(Index = 641)]
        /* 0x5300 */ public Colour DamageNumberIneffectiveWarningColour;
        [NMS(Index = 958)]
        /* 0x5310 */ public Colour DeathMessageColour;
        [NMS(Index = 302)]
        /* 0x5320 */ public Colour DebugEditorAxisColourAtActive;
        [NMS(Index = 301)]
        /* 0x5330 */ public Colour DebugEditorAxisColourAtInactive;
        [NMS(Index = 300)]
        /* 0x5340 */ public Colour DebugEditorAxisColourRightActive;
        [NMS(Index = 299)]
        /* 0x5350 */ public Colour DebugEditorAxisColourRightInactive;
        [NMS(Index = 298)]
        /* 0x5360 */ public Colour DebugEditorAxisColourUpActive;
        [NMS(Index = 297)]
        /* 0x5370 */ public Colour DebugEditorAxisColourUpInactive;
        [NMS(Index = 493)]
        /* 0x5380 */ public Vector3f DefaultRefinerOffsetIn;
        [NMS(Index = 494)]
        /* 0x5390 */ public Vector3f DefaultRefinerOffsetOut;
        [NMS(Index = 1076)]
        /* 0x53A0 */ public Colour EnergyBgColour;
        [NMS(Index = 1077)]
        /* 0x53B0 */ public Colour EnergyBgPulseColour;
        [NMS(Index = 220)]
        /* 0x53C0 */ public Vector3f FaceLockedScreenOffset;
        [NMS(Index = 671)]
        /* 0x53D0 */ public Colour FreighterSummonScanEffectColourBlocked;
        [NMS(Index = 672)]
        /* 0x53E0 */ public Colour FreighterSummonScanEffectColourHighlight;
        [NMS(Index = 305)]
        /* 0x53F0 */ public Colour FrontendCursorBackgroundColour;
        [NMS(Index = 644)]
        /* 0x5400 */ public Colour FuelBgColour;
        [NMS(Index = 511)]
        /* 0x5410 */ public Colour GridBackgroundNegativeColour;
        [NMS(Index = 509)]
        /* 0x5420 */ public Colour GridBackgroundNeutralColour;
        [NMS(Index = 510)]
        /* 0x5430 */ public Colour GridBackgroundPositiveColour;
        [NMS(Index = 506)]
        /* 0x5440 */ public Colour GridDisconnectedColour;
        [NMS(Index = 508)]
        /* 0x5450 */ public Colour GridOfflineColour;
        [NMS(Index = 507)]
        /* 0x5460 */ public Colour GridOnlineColour;
        [NMS(Index = 1078)]
        /* 0x5470 */ public Colour HazardBgPulseColour;
        [NMS(Index = 1079)]
        /* 0x5480 */ public Colour HazardDamagePulseColour;
        [NMS(Index = 308)]
        /* 0x5490 */ public Vector3f HmdFramerateScreenOffset;
        [NMS(Index = 1312)]
        /* 0x54A0 */ public Colour HUDMarkerColour;
        [NMS(Index = 885)]
        /* 0x54B0 */ public Colour HUDNotifyColour;
        [NMS(Index = 1316)]
        /* 0x54C0 */ public Colour HUDOutpostColour;
        [NMS(Index = 849)]
        /* 0x54D0 */ public Colour HUDPlayerTrackArrowDamageGlowHullHitMaxColour;
        [NMS(Index = 850)]
        /* 0x54E0 */ public Colour HUDPlayerTrackArrowDamageGlowHullHitMinColour;
        [NMS(Index = 853)]
        /* 0x54F0 */ public Colour HUDPlayerTrackArrowDamageGlowShieldHitMaxColour;
        [NMS(Index = 854)]
        /* 0x5500 */ public Colour HUDPlayerTrackArrowDamageGlowShieldHitMinColour;
        [NMS(Index = 880)]
        /* 0x5510 */ public Colour HUDPlayerTrackArrowDotColour;
        [NMS(Index = 882)]
        /* 0x5520 */ public Colour HUDPlayerTrackArrowDotColourPirate;
        [NMS(Index = 881)]
        /* 0x5530 */ public Colour HUDPlayerTrackArrowDotColourPolice;
        [NMS(Index = 883)]
        /* 0x5540 */ public Colour HUDPlayerTrackArrowDotColourTrader;
        [NMS(Index = 841)]
        /* 0x5550 */ public Colour HUDPlayerTrackArrowEnergyShieldColour;
        [NMS(Index = 862)]
        /* 0x5560 */ public Colour HUDPlayerTrackArrowEnergyShieldDepletedGlowMaxColour;
        [NMS(Index = 863)]
        /* 0x5570 */ public Colour HUDPlayerTrackArrowEnergyShieldDepletedGlowMinColour;
        [NMS(Index = 842)]
        /* 0x5580 */ public Colour HUDPlayerTrackArrowEnergyShieldLowColour;
        [NMS(Index = 867)]
        /* 0x5590 */ public Colour HUDPlayerTrackArrowEnergyShieldStartChargeGlowMaxColour;
        [NMS(Index = 868)]
        /* 0x55A0 */ public Colour HUDPlayerTrackArrowEnergyShieldStartChargeGlowMinColour;
        [NMS(Index = 838)]
        /* 0x55B0 */ public Colour HUDPlayerTrackArrowTextColour;
        [NMS(Index = 1314)]
        /* 0x55C0 */ public Colour HUDRelicMarkerColourDiscovered;
        [NMS(Index = 1315)]
        /* 0x55D0 */ public Colour HUDRelicMarkerColourUnknown;
        [NMS(Index = 1313)]
        /* 0x55E0 */ public Colour HUDSpaceshipColour;
        [NMS(Index = 884)]
        /* 0x55F0 */ public Colour HUDWarningColour;
        [NMS(Index = 424)]
        /* 0x5600 */ public Colour IconGlowColourActive;
        [NMS(Index = 423)]
        /* 0x5610 */ public Colour IconGlowColourError;
        [NMS(Index = 426)]
        /* 0x5620 */ public Colour IconGlowColourHighlight;
        [NMS(Index = 425)]
        /* 0x5630 */ public Colour IconGlowColourNeutral;
        [NMS(Index = 483)]
        /* 0x5640 */ public Colour InteractionLabelCostColour;
        [NMS(Index = 484)]
        /* 0x5650 */ public Colour InteractionLabelPickupColour;
        [NMS(Index = 485)]
        /* 0x5660 */ public Colour InteractionLabelPickupFillColour;
        [NMS(Index = 81)]
        /* 0x5670 */ public Colour InvSlotGradientBaseColour;
        [NMS(Index = 151)]
        /* 0x5680 */ public Vector3f InWorldInteractLabelCentreOffset;
        [NMS(Index = 153)]
        /* 0x5690 */ public Vector3f InWorldInteractLabelLineOffset;
        [NMS(Index = 152)]
        /* 0x56A0 */ public Vector3f InWorldInteractLabelTopOffset;
        [NMS(Index = 213)]
        /* 0x56B0 */ public Vector3f InWorldNGuiScreenRotation;
        [NMS(Index = 154)]
        /* 0x56C0 */ public Vector3f InWorldStaffBinocsScreenOffset;
        [NMS(Index = 994)]
        /* 0x56D0 */ public Colour ItemSlotColourPartiallyInstalled;
        [NMS(Index = 996)]
        /* 0x56E0 */ public Colour ItemSlotColourProduct;
        [NMS(Index = 990)]
        /* 0x56F0 */ public Colour ItemSlotColourSubstance;
        [NMS(Index = 991)]
        /* 0x5700 */ public Colour ItemSlotColourTech;
        [NMS(Index = 992)]
        /* 0x5710 */ public Colour ItemSlotColourTechCharge;
        [NMS(Index = 993)]
        /* 0x5720 */ public Colour ItemSlotColourTechDamage;
        [NMS(Index = 999)]
        /* 0x5730 */ public Colour ItemSlotTextColourProduct;
        [NMS(Index = 997)]
        /* 0x5740 */ public Colour ItemSlotTextColourSubstance;
        [NMS(Index = 998)]
        /* 0x5750 */ public Colour ItemSlotTextColourTech;
        [NMS(Index = 80)]
        /* 0x5760 */ public Colour JoaoBoxCompletedObjectiveColour;
        [NMS(Index = 1377)]
        /* 0x5770 */ public Colour LockOnMarkerActiveColour;
        [NMS(Index = 209)]
        /* 0x5780 */ public Vector3f LowerHelmetScreenOffset;
        [NMS(Index = 458)]
        /* 0x5790 */ public Colour MarkerRingBGColour;
        [NMS(Index = 535)]
        /* 0x57A0 */ public Colour MissionOSDMessageBarColour;
        [NMS(Index = 354)]
        /* 0x57B0 */ public Colour MultiplayerMissionParticipantsColour;
        [NMS(Index = 63)]
        /* 0x57C0 */ public Colour NetworkPopupTextDisabledColour;
        [NMS(Index = 62)]
        /* 0x57D0 */ public Colour NetworkPopupTextEnabledColour;
        [NMS(Index = 1395)]
        /* 0x57E0 */ public Vector3f NGuiModelTranslationFactors;
        [NMS(Index = 1396)]
        /* 0x57F0 */ public Vector3f NGuiModelTranslationFactorsInteraction;
        [NMS(Index = 1397)]
        /* 0x5800 */ public Vector3f NGuiThumbnailModelTranslationFactors;
        [NMS(Index = 537)]
        /* 0x5810 */ public Colour NotificationDangerColour;
        [NMS(Index = 536)]
        /* 0x5820 */ public Colour NotificationDefaultColour;
        [NMS(Index = 538)]
        /* 0x5830 */ public Colour NotificationInfoColour;
        [NMS(Index = 539)]
        /* 0x5840 */ public Colour NotificationUrgentColour;
        [NMS(Index = 13)]
        /* 0x5850 */ public Vector3f OutpostReturnMarkerOffset;
        [NMS(Index = 5)]
        /* 0x5860 */ public Colour PetGeneIconGlowColourDefault;
        [NMS(Index = 6)]
        /* 0x5870 */ public Colour PetGeneIconGlowColourHighlight;
        [NMS(Index = 3)]
        /* 0x5880 */ public Colour PetLevelProgressColour;
        [NMS(Index = 4)]
        /* 0x5890 */ public Colour PetPointProgresColour;
        [NMS(Index = 642)]
        /* 0x58A0 */ public Colour PhotoModeSelectedColour;
        [NMS(Index = 643)]
        /* 0x58B0 */ public Colour PhotoModeUnselectedColour;
        [NMS(Index = 353)]
        /* 0x58C0 */ public Colour PickedItemBorderColour;
        [NMS(Index = 959)]
        /* 0x58D0 */ public Colour PinnedRecipeBorder;
        [NMS(Index = 349)]
        /* 0x58E0 */ public Colour ProcProductColourCommon;
        [NMS(Index = 351)]
        /* 0x58F0 */ public Colour ProcProductColourRare;
        [NMS(Index = 350)]
        /* 0x5900 */ public Colour ProcProductColourUncommon;
        [NMS(Index = 823)]
        /* 0x5910 */ public Colour PulseAlertColour;
        [NMS(Index = 822)]
        /* 0x5920 */ public Colour PulseDamageColour;
        [NMS(Index = 303)]
        /* 0x5930 */ public Colour QuickMenuSelectedItemColour1;
        [NMS(Index = 304)]
        /* 0x5940 */ public Colour QuickMenuSelectedItemColour2;
        [NMS(Index = 1196)]
        /* 0x5950 */ public Colour RadialMenuInnerColourDisabled;
        [NMS(Index = 1192)]
        /* 0x5960 */ public Colour RadialMenuInnerColourSelected;
        [NMS(Index = 1194)]
        /* 0x5970 */ public Colour RadialMenuInnerColourUnselected;
        [NMS(Index = 1197)]
        /* 0x5980 */ public Colour RadialMenuOuterColourDisabled;
        [NMS(Index = 1193)]
        /* 0x5990 */ public Colour RadialMenuOuterColourSelected;
        [NMS(Index = 1195)]
        /* 0x59A0 */ public Colour RadialMenuOuterColourUnselected;
        [NMS(Index = 504)]
        /* 0x59B0 */ public Colour RefinerBackgroundColour;
        [NMS(Index = 505)]
        /* 0x59C0 */ public Colour RefinerErrorBackgroundColour;
        [NMS(Index = 736)]
        /* 0x59D0 */ public Colour RemappedControlColour;
        [NMS(Index = 735)]
        /* 0x59E0 */ public Colour SelectedControlColour;
        [NMS(Index = 1445)]
        /* 0x59F0 */ public Colour SettlementStatBackgroundColour;
        [NMS(Index = 1444)]
        /* 0x5A00 */ public Colour SettlementStatColour;
        [NMS(Index = 1082)]
        /* 0x5A10 */ public Colour ShieldBgColour;
        [NMS(Index = 1080)]
        /* 0x5A20 */ public Colour ShieldColour;
        [NMS(Index = 1083)]
        /* 0x5A30 */ public Colour ShieldDamageBgColour;
        [NMS(Index = 1081)]
        /* 0x5A40 */ public Colour ShieldDamageColour;
        [NMS(Index = 28)]
        /* 0x5A50 */ public Colour ShipBuilderLineColour;
        [NMS(Index = 27)]
        /* 0x5A60 */ public Colour ShipBuilderLineColourHologram;
        [NMS(Index = 1024)]
        /* 0x5A70 */ public Colour ShipHUDAimTargetColour;
        [NMS(Index = 1025)]
        /* 0x5A80 */ public Colour ShipHUDAimTargetCritColour;
        [NMS(Index = 1022)]
        /* 0x5A90 */ public Colour ShipHUDTargetArrowsColourLocal;
        [NMS(Index = 1020)]
        /* 0x5AA0 */ public Colour ShipHUDTargetArrowsColourOutOfRange;
        [NMS(Index = 1021)]
        /* 0x5AB0 */ public Colour ShipHUDTargetArrowsColourThreat;
        [NMS(Index = 12)]
        /* 0x5AC0 */ public Vector3f ShipTeleportPadMarkerOffset;
        [NMS(Index = 1285)]
        /* 0x5AD0 */ public Colour SpaceEnemyShipLineColour;
        [NMS(Index = 1284)]
        /* 0x5AE0 */ public Colour SpaceFriendlyShipLineColour;
        [NMS(Index = 1287)]
        /* 0x5AF0 */ public Colour SpaceMapAttackColour;
        [NMS(Index = 552)]
        /* 0x5B00 */ public Vector3f SpaceMapCockpitOffset;
        [NMS(Index = 1292)]
        /* 0x5B10 */ public Colour SpaceMapDeathPointColour;
        [NMS(Index = 1290)]
        /* 0x5B20 */ public Colour SpaceMapNeutralColour;
        [NMS(Index = 1288)]
        /* 0x5B30 */ public Colour SpaceMapOtherPlayerColour;
        [NMS(Index = 1286)]
        /* 0x5B40 */ public Vector3f SpaceMapPosScaler;
        [NMS(Index = 1291)]
        /* 0x5B50 */ public Colour SpaceMapSquadronColour;
        [NMS(Index = 1289)]
        /* 0x5B60 */ public Colour SpaceMapThreatColour;
        [NMS(Index = 1468)]
        /* 0x5B70 */ public Colour SpookMeterColour;
        [NMS(Index = 39)]
        /* 0x5B80 */ public Colour StoreDialFillColour;
        [NMS(Index = 87)]
        /* 0x5B90 */ public Colour SuperchargeGradientBaseColour;
        [NMS(Index = 88)]
        /* 0x5BA0 */ public Colour SuperchargeGradientBlendColour;
        [NMS(Index = 89)]
        /* 0x5BB0 */ public Colour SuperchargeGradientTechColour;
        [NMS(Index = 86)]
        /* 0x5BC0 */ public Colour SuperchargePopupColour;
        [NMS(Index = 568)]
        /* 0x5BD0 */ public Vector3f TargetDisplayShipOffset;
        [NMS(Index = 569)]
        /* 0x5BE0 */ public Vector3f TargetDisplayTorpedoOffset;
        [NMS(Index = 1221)]
        /* 0x5BF0 */ public Colour TargetMarkerColour;
        [NMS(Index = 1222)]
        /* 0x5C00 */ public Colour TargetMarkerHighlightColour;
        [NMS(Index = 33)]
        /* 0x5C10 */ public Colour TouchButtonChargeIndicatorColour;
        [NMS(Index = 512)]
        /* 0x5C20 */ public Colour TransferSendPopupColour;
        [NMS(Index = 328)]
        /* 0x5C30 */ public Colour TravelLineColour;
        [NMS(Index = 331)]
        /* 0x5C40 */ public Colour TravelLineInvalidColour;
        [NMS(Index = 332)]
        /* 0x5C50 */ public Colour TravelLineNotAllowedColour;
        [NMS(Index = 329)]
        /* 0x5C60 */ public Colour TravelLineTooFarColour;
        [NMS(Index = 330)]
        /* 0x5C70 */ public Colour TravelLineTooSteepColour;
        [NMS(Index = 333)]
        /* 0x5C80 */ public Colour TravelTargetColour;
        [NMS(Index = 1231)]
        /* 0x5C90 */ public Colour UnseenItemColour;
        [NMS(Index = 1230)]
        /* 0x5CA0 */ public Colour WantedColour;
        [NMS(Index = 54)]
        /* 0x5CB0 */ public Colour WristMenuDefaultBorderColour;
        [NMS(Index = 55)]
        /* 0x5CC0 */ public Colour WristMenuRepositionableBorderColour;
        [NMS(Index = 73, Size = 0xF, EnumType = typeof(GcWonderCreatureCategory.WonderCreatureCategoryEnum))]
        /* 0x5CD0 */ public GcWonderCategoryConfig[] WonderCreatureCategoryConfig;
        [NMS(Index = 76, Size = 0xD, EnumType = typeof(GcWonderTreasureCategory.WonderTreasureCategoryEnum))]
        /* 0x6018 */ public GcWonderCategoryConfig[] WonderTreasureCategoryConfig;
        [NMS(Index = 408, Size = 0x15, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x62F0 */ public NMSString0x20A[] BuildMenuOnActionDisabledLocIDs;
        [NMS(Index = 409, Size = 0x15, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x6590 */ public NMSString0x20A[] BuildMenuOnActionErrorLocIDs;
        [NMS(Index = 407, Size = 0x15, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x6830 */ public NMSString0x20A[] BuildMenuOnActionLocIDs;
        [NMS(Index = 78, Size = 0xC, EnumType = typeof(GcWonderCustomCategory.WonderCustomCategoryEnum))]
        /* 0x6AD0 */ public GcWonderCategoryConfig[] WonderCustomCategoryConfig;
        [NMS(Index = 72, Size = 0xB, EnumType = typeof(GcWonderPlanetCategory.WonderPlanetCategoryEnum))]
        /* 0x6D70 */ public GcWonderCategoryConfig[] WonderPlanetCategoryConfig;
        [NMS(Index = 77, Size = 0xB, EnumType = typeof(GcWonderWeirdBasePartCategory.WonderWeirdBasePartCategoryEnum))]
        /* 0x6FD8 */ public GcWonderCategoryConfig[] WonderWeirdBasePartCategoryConfig;
        [NMS(Index = 74, Size = 0x8, EnumType = typeof(GcWonderFloraCategory.WonderFloraCategoryEnum))]
        /* 0x7240 */ public GcWonderCategoryConfig[] WonderFloraCategoryConfig;
        [NMS(Index = 75, Size = 0x8, EnumType = typeof(GcWonderMineralCategory.WonderMineralCategoryEnum))]
        /* 0x7400 */ public GcWonderCategoryConfig[] WonderMineralCategoryConfig;
        [NMS(Index = 1413)]
        /* 0x75C0 */ public GcHUDStartupTable IntroTiming;
        [NMS(Index = 1414)]
        /* 0x7710 */ public GcHUDStartupTable IntroTimingFreighter;
        [NMS(Index = 1415)]
        /* 0x7860 */ public GcHUDStartupTable IntroTimingFreighterRepaired;
        [NMS(Index = 1447, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x79B0 */ public NMSString0x20A[] SettlementStatFormatLoc;
        [NMS(Index = 1446, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x7AB0 */ public NMSString0x20A[] SettlementStatLoc;
        [NMS(Index = 1448, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x7BB0 */ public TkTextureResource[] SettlementStatBasicImages;
        [NMS(Index = 1450, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x7C70 */ public TkTextureResource[] SettlementStatNegativeImages;
        [NMS(Index = 1449, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x7D30 */ public TkTextureResource[] SettlementStatPositiveImages;
        [NMS(Index = 67, Size = 0x7, EnumType = typeof(GcWonderType.WonderTypeEnum))]
        /* 0x7DF0 */ public TkTextureResource[] WonderTypeIcons;
        [NMS(Index = 453)]
        /* 0x7E98 */ public TkTextureResource BaseBuildingPartsGridExpandableIcon;
        [NMS(Index = 454)]
        /* 0x7EB0 */ public TkTextureResource BaseBuildingPartsGridExpandedIcon;
        [NMS(Index = 455)]
        /* 0x7EC8 */ public TkTextureResource BaseBuildingPartsGridRetractableIcon;
        [NMS(Index = 488)]
        /* 0x7EE0 */ public TkTextureResource RefinerPopupEmptyOutputIcon;
        [NMS(Index = 1074)]
        /* 0x7EF8 */ public GcFilename CamoNormalTexture;
        [NMS(Index = 1073)]
        /* 0x7F08 */ public GcFilename CamoTexture;
        [NMS(Index = 96)]
        /* 0x7F18 */ public NMSString0x10 DebugInventoryHint;
        [NMS(Index = 127)]
        /* 0x7F28 */ public NMSString0x10 ExplorationLogMissionID;
        [NMS(Index = 1072)]
        /* 0x7F38 */ public List<Vector4f> HazardDistortionParams;
        [NMS(Index = 1068)]
        /* 0x7F48 */ public List<GcFilename> HazardHeightmaps;
        [NMS(Index = 1071)]
        /* 0x7F58 */ public List<GcFilename> HazardHeightmapsVR;
        [NMS(Index = 1067)]
        /* 0x7F68 */ public List<GcFilename> HazardNormalMaps;
        [NMS(Index = 1070)]
        /* 0x7F78 */ public List<GcFilename> HazardNormalMapsVR;
        [NMS(Index = 1066)]
        /* 0x7F88 */ public List<GcFilename> HazardTextures;
        [NMS(Index = 1069)]
        /* 0x7F98 */ public List<GcFilename> HazardTexturesVR;
        [NMS(Index = 352)]
        /* 0x7FA8 */ public List<Vector2f> InventoryIconPositions;
        [NMS(Index = 356)]
        /* 0x7FB8 */ public NMSString0x10 MultiplayerMissionInteractEndTrigger;
        [NMS(Index = 355)]
        /* 0x7FC8 */ public NMSString0x10 MultiplayerMissionInteractStartTrigger;
        [NMS(Index = 115)]
        /* 0x7FD8 */ public List<GcSeasonalRingArray> SeasonalRingTable;
        [NMS(Index = 1023)]
        /* 0x7FE8 */ public List<Colour> ShipHUDTargetArrowsColour;
        [NMS(Index = 827)]
        /* 0x7FF8 */ public NMSString0x10 ShowStatWithDeathQuote;
        [NMS(Index = 899)]
        /* 0x8008 */ public List<GcFilename> StatIcons;
        [NMS(Index = 481)]
        /* 0x8018 */ public List<TkModelRendererData> VehicleTypeRepairCamera;
        [NMS(Index = 727, Size = 0x15, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x8028 */ public float[] CrosshairTargetLockSizeSpecific;
        [NMS(Index = 981)]
        /* 0x807C */ public GcWorldUISettings WorldUISettings;
        [NMS(Index = 69, Size = 0xF, EnumType = typeof(GcWonderCreatureCategory.WonderCreatureCategoryEnum))]
        /* 0x80D0 */ public float[] WonderValueModifiersCreature;
        [NMS(Index = 68, Size = 0xB, EnumType = typeof(GcWonderPlanetCategory.WonderPlanetCategoryEnum))]
        /* 0x810C */ public float[] WonderValueModifiersPlanet;
        [NMS(Index = 70, Size = 0x8, EnumType = typeof(GcWonderFloraCategory.WonderFloraCategoryEnum))]
        /* 0x8138 */ public float[] WonderValueModifiersFlora;
        [NMS(Index = 71, Size = 0x8, EnumType = typeof(GcWonderMineralCategory.WonderMineralCategoryEnum))]
        /* 0x8158 */ public float[] WonderValueModifiersMineral;
        [NMS(Index = 1417)]
        /* 0x8178 */ public GcInventorySlotActionData BuildProductSlotAction;
        [NMS(Index = 1418)]
        /* 0x8194 */ public GcInventorySlotActionData ChargeSlotAction;
        [NMS(Index = 1416)]
        /* 0x81B0 */ public GcInventorySlotActionData InstallTechSlotAction;
        [NMS(Index = 1422)]
        /* 0x81CC */ public GcInventorySlotActionData InventoryHintAction;
        [NMS(Index = 1423)]
        /* 0x81E8 */ public GcInventorySlotActionData InventoryHintActionNoGlow;
        [NMS(Index = 1421)]
        /* 0x8204 */ public GcInventorySlotActionData NewSlotPulseAction;
        [NMS(Index = 1420)]
        /* 0x8220 */ public GcInventorySlotActionData NewSlotRevealAction;
        [NMS(Index = 1419)]
        /* 0x823C */ public GcInventorySlotActionData RepairSlotAction;
        [NMS(Index = 1)]
        /* 0x8258 */ public GcInteractionDof InteractionDOFDisabled;
        [NMS(Index = 820)]
        /* 0x826C */ public TkNGuiRectanglePulseEffect PulseBarData;
        [NMS(Index = 821)]
        /* 0x827C */ public TkNGuiRectanglePulseEffect PulseIconData;
        [NMS(Index = 731)]
        /* 0x828C */ public TkHitCurveData CrosshairLeadHitCurve;
        [NMS(Index = 1412)]
        /* 0x8298 */ public GcDiscoveryHelperTimings DiscoveryHelperTimings;
        [NMS(Index = 732)]
        /* 0x82A4 */ public TkHitCurveData ShootableHitCurve;
        [NMS(Index = 174)]
        /* 0x82B0 */ public Vector2f BinocularEdgeFade;
        [NMS(Index = 482)]
        /* 0x82B8 */ public Vector2f BinocularsDiscoveryPos;
        [NMS(Index = 385)]
        /* 0x82C0 */ public Vector2f CompassCentre;
        [NMS(Index = 102)]
        /* 0x82C8 */ public Vector2f ControlsPageParallax;
        [NMS(Index = 547)]
        /* 0x82D0 */ public Vector2f CursorlessDialogPageCursorOffset;
        [NMS(Index = 634)]
        /* 0x82D8 */ public Vector2f DamageNumberSideSpeed;
        [NMS(Index = 545)]
        /* 0x82E0 */ public Vector2f DialogPageCursorOffset;
        [NMS(Index = 1318)]
        /* 0x82E8 */ public Vector2f HUDMarkerCompassPrimaryIndicatorOffset;
        [NMS(Index = 1317)]
        /* 0x82F0 */ public Vector2f HUDMarkerPrimaryIndicatorOffset;
        [NMS(Index = 497)]
        /* 0x82F8 */ public Vector2f HUDPlayerSentinelPulseFreq;
        [NMS(Index = 498)]
        /* 0x8300 */ public Vector2f HUDPlayerSentinelPulseSize;
        [NMS(Index = 856)]
        /* 0x8308 */ public Vector2f HUDPlayerTrackArrowDamageGlowSize;
        [NMS(Index = 858)]
        /* 0x8310 */ public Vector2f HUDPlayerTrackArrowEnergyShieldGlowSize;
        [NMS(Index = 845)]
        /* 0x8318 */ public Vector2f HUDPlayerTrackArrowEnergyShieldSize;
        [NMS(Index = 840)]
        /* 0x8320 */ public Vector2f HUDPlayerTrackArrowHealthSize;
        [NMS(Index = 793)]
        /* 0x8328 */ public Vector2f HUDPlayerTrackArrowIconPulseSize;
        [NMS(Index = 805)]
        /* 0x8330 */ public Vector2f HUDPlayerTrackIconOffset;
        [NMS(Index = 1304)]
        /* 0x8338 */ public Vector2f HUDTargetHealthIconOffset;
        [NMS(Index = 1302)]
        /* 0x8340 */ public Vector2f HUDTargetHealthOffset;
        [NMS(Index = 1303)]
        /* 0x8348 */ public Vector2f HUDTargetHealthSize;
        [NMS(Index = 1085)]
        /* 0x8350 */ public Vector2f InteractionLabelOffset;
        [NMS(Index = 1086)]
        /* 0x8358 */ public Vector2f InteractionLabelOffset_1;
        [NMS(Index = 1089)]
        /* 0x8360 */ public Vector2f InteractionLabelScreenMax;
        [NMS(Index = 1088)]
        /* 0x8368 */ public Vector2f InteractionLabelScreenMin;
        [NMS(Index = 1090)]
        /* 0x8370 */ public Vector2f InteractionLabelSize;
        [NMS(Index = 1092)]
        /* 0x8378 */ public Vector2f InteractionLabelTouchAreaMax;
        [NMS(Index = 1091)]
        /* 0x8380 */ public Vector2f InteractionLabelTouchAreaMin;
        [NMS(Index = 1406)]
        /* 0x8388 */ public Vector2f InteractionWorldParallax;
        [NMS(Index = 546)]
        /* 0x8390 */ public Vector2f IntermediateInteractionPageCursorOffset;
        [NMS(Index = 215)]
        /* 0x8398 */ public Vector2f InWorldGameGuiAlignment;
        [NMS(Index = 150)]
        /* 0x83A0 */ public Vector2f InWorldInteractLabelAlignment;
        [NMS(Index = 214)]
        /* 0x83A8 */ public Vector2f InWorldNGuiParallax;
        [NMS(Index = 530)]
        /* 0x83B0 */ public Vector2f MainMenuSaveIconPosition;
        [NMS(Index = 205)]
        /* 0x83B8 */ public Vector2f MarkerDistanceVRAlignment;
        [NMS(Index = 496)]
        /* 0x83C0 */ public Vector2f ModelViewWorldParallax;
        [NMS(Index = 1403)]
        /* 0x83C8 */ public Vector2f NGuiMax2DParallax;
        [NMS(Index = 1402)]
        /* 0x83D0 */ public Vector2f NGuiMin2DParallax;
        [NMS(Index = 1404)]
        /* 0x83D8 */ public Vector2f NGuiModelParallax;
        [NMS(Index = 1405)]
        /* 0x83E0 */ public Vector2f NGuiShipInteractParallax;
        [NMS(Index = 1220)]
        /* 0x83E8 */ public Vector2f NGuiTouchPadSensitivity;
        [NMS(Index = 947)]
        /* 0x83F0 */ public Vector2f NotificationMissionHintPauseTime;
        [NMS(Index = 948)]
        /* 0x83F8 */ public Vector2f NotificationMissionHintPauseTimeCritical;
        [NMS(Index = 949)]
        /* 0x8400 */ public Vector2f NotificationMissionHintPauseTimeSecondary;
        [NMS(Index = 486)]
        /* 0x8408 */ public Vector2f PersonalRefinerInputPos;
        [NMS(Index = 487)]
        /* 0x8410 */ public Vector2f PersonalRefinerOutputPos;
        [NMS(Index = 101)]
        /* 0x8418 */ public Vector2f PickingCursorOffset;
        [NMS(Index = 983)]
        /* 0x8420 */ public Vector2f PlanetLabelOffset;
        [NMS(Index = 987)]
        /* 0x8428 */ public Vector2f PlanetLineOffset;
        [NMS(Index = 984)]
        /* 0x8430 */ public Vector2f PlanetMeasureOffset;
        [NMS(Index = 985)]
        /* 0x8438 */ public Vector2f PlanetMeasureOffsetBigText;
        [NMS(Index = 986)]
        /* 0x8440 */ public Vector2f PlanetMeasureOffsetMoonExtra;
        [NMS(Index = 495)]
        /* 0x8448 */ public Vector2f RefinerParallax;
        [NMS(Index = 529)]
        /* 0x8450 */ public Vector2f SaveIconPosition;
        [NMS(Index = 1084)]
        /* 0x8458 */ public Vector2f ScanLabelOffset;
        [NMS(Index = 1030)]
        /* 0x8460 */ public Vector2f TargetScreenCamOffset;
        [NMS(Index = 783)]
        /* 0x8468 */ public Vector2f TrackCriticalHitOffset;
        [NMS(Index = 747)]
        /* 0x8470 */ public Vector2f TrackTypeIconOffset;
        [NMS(Index = 1437)]
        /* 0x8478 */ public int AbandonedFreighterAirlockRoomNumber;
        [NMS(Index = 1455)]
        /* 0x847C */ public float AccessibleUIHUDPopupScale;
        [NMS(Index = 1453)]
        /* 0x8480 */ public float AccessibleUIPopupScale;
        [NMS(Index = 188)]
        /* 0x8484 */ public float AlignmentRequiredToDisableFrostedGlass;
        [NMS(Index = 1365)]
        /* 0x8488 */ public float AltimeterLineSpacing;
        [NMS(Index = 1368)]
        /* 0x848C */ public float AltimeterMax;
        [NMS(Index = 1367)]
        /* 0x8490 */ public float AltimeterMin;
        [NMS(Index = 1370)]
        /* 0x8494 */ public float AltimeterMinValue;
        [NMS(Index = 1364)]
        /* 0x8498 */ public float AltimeterResolution;
        [NMS(Index = 1369)]
        /* 0x849C */ public float AltimeterTextSize;
        [NMS(Index = 1366)]
        /* 0x84A0 */ public float AltimeterWidth;
        [NMS(Index = 1059)]
        /* 0x84A4 */ public float AlwaysOnHazardMultiplierCold;
        [NMS(Index = 1057)]
        /* 0x84A8 */ public float AlwaysOnHazardMultiplierHeat;
        [NMS(Index = 1058)]
        /* 0x84AC */ public float AlwaysOnHazardMultiplierRad;
        [NMS(Index = 1064)]
        /* 0x84B0 */ public float AlwaysOnHazardMultiplierSpook;
        [NMS(Index = 1056)]
        /* 0x84B4 */ public float AlwaysOnHazardMultiplierTox;
        [NMS(Index = 1054)]
        /* 0x84B8 */ public float AlwaysOnHazardStrengthCold;
        [NMS(Index = 1052)]
        /* 0x84BC */ public float AlwaysOnHazardStrengthHeat;
        [NMS(Index = 1053)]
        /* 0x84C0 */ public float AlwaysOnHazardStrengthRad;
        [NMS(Index = 1055)]
        /* 0x84C4 */ public float AlwaysOnHazardStrengthSpook;
        [NMS(Index = 1051)]
        /* 0x84C8 */ public float AlwaysOnHazardStrengthTox;
        [NMS(Index = 1050)]
        /* 0x84CC */ public float AlwaysOnHazardThreshold;
        [NMS(Index = 689)]
        /* 0x84D0 */ public float AlwaysShowIconFadeDistance;
        [NMS(Index = 691)]
        /* 0x84D4 */ public float AlwaysShowIconFadeDistanceSpacePOI;
        [NMS(Index = 690)]
        /* 0x84D8 */ public float AlwaysShowIconFadeRange;
        [NMS(Index = 692)]
        /* 0x84DC */ public float AlwaysShowIconFadeRangeSpacePOI;
        [NMS(Index = 1428)]
        /* 0x84E0 */ public float AmbientModeFadeTime;
        [NMS(Index = 684)]
        /* 0x84E4 */ public float ArrowBounceLeftRate1;
        [NMS(Index = 685)]
        /* 0x84E8 */ public float ArrowBounceLeftRate2;
        [NMS(Index = 686)]
        /* 0x84EC */ public float ArrowBounceLeftRate3;
        [NMS(Index = 679)]
        /* 0x84F0 */ public float ArrowBounceLength;
        [NMS(Index = 680)]
        /* 0x84F4 */ public float ArrowBounceRate;
        [NMS(Index = 681)]
        /* 0x84F8 */ public float ArrowBounceRightRate1;
        [NMS(Index = 682)]
        /* 0x84FC */ public float ArrowBounceRightRate2;
        [NMS(Index = 1379)]
        /* 0x8500 */ public float AsteroidMarkerMinDisplayAngleDegrees;
        [NMS(Index = 1378)]
        /* 0x8504 */ public float AsteroidMarkerMinDisplayDistance;
        [NMS(Index = 437)]
        /* 0x8508 */ public float BaseBuildingFreeRotateDelayBeforeAudioStops;
        [NMS(Index = 436)]
        /* 0x850C */ public float BaseBuildingFreeRotateDelayBeforeReset;
        [NMS(Index = 435)]
        /* 0x8510 */ public float BaseBuildingFreeRotateSpeedPadMultiplier;
        [NMS(Index = 429)]
        /* 0x8514 */ public float BaseBuildingInputHighlightAlpha;
        [NMS(Index = 428)]
        /* 0x8518 */ public float BaseBuildingInputHighlightDuration;
        [NMS(Index = 432)]
        /* 0x851C */ public float BaseBuildingMaxFreeRotateSpeed;
        [NMS(Index = 431)]
        /* 0x8520 */ public float BaseBuildingMinFreeRotateSpeed;
        [NMS(Index = 448)]
        /* 0x8524 */ public float BaseBuildingPartsGridBreadcrumbFlashDuration;
        [NMS(Index = 447)]
        /* 0x8528 */ public float BaseBuildingPartsGridMaxCursorRestorationTime;
        [NMS(Index = 449)]
        /* 0x852C */ public float BaseBuildingPartsGridMinVisibilityForActive;
        [NMS(Index = 452)]
        /* 0x8530 */ public float BaseBuildingPartsGridPopupDelay;
        [NMS(Index = 450)]
        /* 0x8534 */ public float BaseBuildingPartsGridScrollSpeed;
        [NMS(Index = 451)]
        /* 0x8538 */ public float BaseBuildingPartsGridScrollSpeedPad;
        [NMS(Index = 427)]
        /* 0x853C */ public float BaseBuildingPinHighlightDuration;
        [NMS(Index = 434)]
        /* 0x8540 */ public float BaseBuildingRotationResetRate;
        [NMS(Index = 430)]
        /* 0x8544 */ public float BaseBuildingScaleSpeed;
        [NMS(Index = 433)]
        /* 0x8548 */ public float BaseBuildingTimeToMaxRotationSpeed;
        [NMS(Index = 446)]
        /* 0x854C */ public float BaseBuildingUIAdjustTime;
        [NMS(Index = 445)]
        /* 0x8550 */ public float BaseBuildingUIErrorFadeTime;
        [NMS(Index = 439)]
        /* 0x8554 */ public float BaseBuildingUIHorizontalSafeArea;
        [NMS(Index = 442)]
        /* 0x8558 */ public float BaseBuildingUIVerticalOffset;
        [NMS(Index = 443)]
        /* 0x855C */ public float BaseBuildingUIVerticalOffsetEdit;
        [NMS(Index = 444)]
        /* 0x8560 */ public float BaseBuildingUIVerticalOffsetFromBB;
        [NMS(Index = 441)]
        /* 0x8564 */ public float BaseBuildingUIVerticalPosWiring;
        [NMS(Index = 440)]
        /* 0x8568 */ public float BaseBuildingUIVerticalSafeArea;
        [NMS(Index = 401)]
        /* 0x856C */ public float BaseComplexityDangerFactor;
        [NMS(Index = 402)]
        /* 0x8570 */ public float BaseComplexityWarningFactor;
        [NMS(Index = 14)]
        /* 0x8574 */ public float BattleHUDBarInterpTime;
        [NMS(Index = 173)]
        /* 0x8578 */ public float BeaconHUDMarkerOffset;
        [NMS(Index = 177)]
        /* 0x857C */ public float BinocularMarkerSideAngle;
        [NMS(Index = 178)]
        /* 0x8580 */ public float BinocularMarkerUpAngle;
        [NMS(Index = 187)]
        /* 0x8584 */ public float BinocularsAltUIRescaleFactor;
        [NMS(Index = 175)]
        /* 0x8588 */ public float BinocularScreenOffset;
        [NMS(Index = 176)]
        /* 0x858C */ public float BinocularScreenScale;
        [NMS(Index = 185)]
        /* 0x8590 */ public float BinocularsFarIconDist;
        [NMS(Index = 186)]
        /* 0x8594 */ public float BinocularsFarIconFadeDist;
        [NMS(Index = 184)]
        /* 0x8598 */ public float BinocularsFarIconOpacity;
        [NMS(Index = 183)]
        /* 0x859C */ public float BinocularsMidIconOpacity;
        [NMS(Index = 181)]
        /* 0x85A0 */ public float BinocularsNearIconDist;
        [NMS(Index = 182)]
        /* 0x85A4 */ public float BinocularsNearIconFadeDist;
        [NMS(Index = 180)]
        /* 0x85A8 */ public float BinocularsNearIconOpacity;
        [NMS(Index = 513)]
        /* 0x85AC */ public float BountyMarkerOffset;
        [NMS(Index = 1433)]
        /* 0x85B0 */ public int BuildingShopMaxItems;
        [NMS(Index = 406)]
        /* 0x85B4 */ public float BuildMenuActionMessageDuration;
        [NMS(Index = 270)]
        /* 0x85B8 */ public float BuildMenuItemNavAnimTime;
        [NMS(Index = 271)]
        /* 0x85BC */ public float BuildMenuItemNextNavAnimTime;
        [NMS(Index = 272)]
        /* 0x85C0 */ public float BuildMenuItemNextNavAnimWait;
        [NMS(Index = 1154)]
        /* 0x85C4 */ public float ByteBeatArpLineWidth;
        [NMS(Index = 1156)]
        /* 0x85C8 */ public float ByteBeatArpPad;
        [NMS(Index = 1155)]
        /* 0x85CC */ public float ByteBeatArpRadius;
        [NMS(Index = 1152)]
        /* 0x85D0 */ public float ByteBeatIconLineWidth;
        [NMS(Index = 1153)]
        /* 0x85D4 */ public float ByteBeatIconPad;
        [NMS(Index = 1163)]
        /* 0x85D8 */ public float ByteBeatPartSequencerPad;
        [NMS(Index = 1165)]
        /* 0x85DC */ public float ByteBeatRhythmBeatPad;
        [NMS(Index = 1169)]
        /* 0x85E0 */ public float ByteBeatRhythmSequencerActiveSaturation;
        [NMS(Index = 1168)]
        /* 0x85E4 */ public float ByteBeatRhythmSequencerInactiveSaturation;
        [NMS(Index = 1167)]
        /* 0x85E8 */ public float ByteBeatSequencerActiveSaturation;
        [NMS(Index = 1164)]
        /* 0x85EC */ public float ByteBeatSequencerCornerRadius;
        [NMS(Index = 1183)]
        /* 0x85F0 */ public float ByteBeatSequencerHighlightLineWidth;
        [NMS(Index = 1166)]
        /* 0x85F4 */ public float ByteBeatSequencerInactiveSaturation;
        [NMS(Index = 1161)]
        /* 0x85F8 */ public float ByteBeatSequencerLineWidth;
        [NMS(Index = 1162)]
        /* 0x85FC */ public float ByteBeatSequencerPad;
        [NMS(Index = 1170)]
        /* 0x8600 */ public float ByteBeatSequencerUnpoweredTintStrength;
        [NMS(Index = 1186)]
        /* 0x8604 */ public float ByteBeatSliderCornerRadius;
        [NMS(Index = 1184)]
        /* 0x8608 */ public float ByteBeatSliderLineWidth;
        [NMS(Index = 1185)]
        /* 0x860C */ public float ByteBeatSliderPad;
        [NMS(Index = 1190)]
        /* 0x8610 */ public float ByteBeatSwitchPanelAlpha;
        [NMS(Index = 1191)]
        /* 0x8614 */ public float ByteBeatSwitchPanelSplit;
        [NMS(Index = 1147)]
        /* 0x8618 */ public float ByteBeatTreeLineWidth;
        [NMS(Index = 1149)]
        /* 0x861C */ public float ByteBeatVisLineWidth;
        [NMS(Index = 133)]
        /* 0x8620 */ public float ClosestDoorMarkerBuffer;
        [NMS(Index = 200)]
        /* 0x8624 */ public float CockpitGlassDefrostTime;
        [NMS(Index = 199)]
        /* 0x8628 */ public float CockpitGlassFrostTime;
        [NMS(Index = 573)]
        /* 0x862C */ public float CommunicatorMessageTime;
        [NMS(Index = 397)]
        /* 0x8630 */ public float CompassAngleClamp;
        [NMS(Index = 400)]
        /* 0x8634 */ public float CompassAngleClampSpace;
        [NMS(Index = 398)]
        /* 0x8638 */ public float CompassAngleFade;
        [NMS(Index = 394)]
        /* 0x863C */ public float CompassDistanceMarkerMinScale;
        [NMS(Index = 395)]
        /* 0x8640 */ public float CompassDistanceMaxAngle;
        [NMS(Index = 392)]
        /* 0x8644 */ public float CompassDistanceScale;
        [NMS(Index = 388)]
        /* 0x8648 */ public float CompassDistanceScaleMin;
        [NMS(Index = 389)]
        /* 0x864C */ public float CompassDistanceScaleRange;
        [NMS(Index = 393)]
        /* 0x8650 */ public float CompassDistanceShipMinScale;
        [NMS(Index = 390)]
        /* 0x8654 */ public float CompassDistanceSpaceScaleMin;
        [NMS(Index = 391)]
        /* 0x8658 */ public float CompassDistanceSpaceScaleRange;
        [NMS(Index = 396)]
        /* 0x865C */ public float CompassDistanceYOffset;
        [NMS(Index = 386)]
        /* 0x8660 */ public float CompassHeight;
        [NMS(Index = 206)]
        /* 0x8664 */ public float CompassIconOffsetVR;
        [NMS(Index = 227)]
        /* 0x8668 */ public float CompassLineContractionEndAngle;
        [NMS(Index = 226)]
        /* 0x866C */ public float CompassLineContractionStartAngle;
        [NMS(Index = 228)]
        /* 0x8670 */ public float CompassLineContractionTargetAngle;
        [NMS(Index = 232)]
        /* 0x8674 */ public float CompassLineNotchAngleRange;
        [NMS(Index = 234)]
        /* 0x8678 */ public float CompassLineNotchLength;
        [NMS(Index = 233)]
        /* 0x867C */ public float CompassLineNotchThickness;
        [NMS(Index = 229)]
        /* 0x8680 */ public int CompassLineNumNotches;
        [NMS(Index = 231)]
        /* 0x8684 */ public float CompassLineOffset;
        [NMS(Index = 230)]
        /* 0x8688 */ public float CompassLineThickness;
        [NMS(Index = 225)]
        /* 0x868C */ public int CompassScreenHeight;
        [NMS(Index = 224)]
        /* 0x8690 */ public int CompassScreenWidth;
        [NMS(Index = 387)]
        /* 0x8694 */ public float CompassWidth;
        [NMS(Index = 603)]
        /* 0x8698 */ public float ConsoleTextSpeed;
        [NMS(Index = 605)]
        /* 0x869C */ public float ConsoleTextTimeMax;
        [NMS(Index = 604)]
        /* 0x86A0 */ public float ConsoleTextTimeMin;
        [NMS(Index = 734)]
        /* 0x86A4 */ public float ControlScrollDistance;
        [NMS(Index = 733)]
        /* 0x86A8 */ public int ControlScrollSteps;
        [NMS(Index = 616)]
        /* 0x86AC */ public float CreatureDistanceAlpha;
        [NMS(Index = 614)]
        /* 0x86B0 */ public float CreatureDistanceDisplayAngle;
        [NMS(Index = 615)]
        /* 0x86B4 */ public float CreatureDistanceFadeTime;
        [NMS(Index = 612)]
        /* 0x86B8 */ public float CreatureDistanceOffsetY;
        [NMS(Index = 613)]
        /* 0x86BC */ public float CreatureDistanceShadowOffset;
        [NMS(Index = 611)]
        /* 0x86C0 */ public float CreatureDistanceSize;
        [NMS(Index = 378)]
        /* 0x86C4 */ public float CreatureIconMergeAngle;
        [NMS(Index = 648)]
        /* 0x86C8 */ public float CreatureIconOffset;
        [NMS(Index = 649)]
        /* 0x86CC */ public float CreatureIconOffsetPhysics;
        [NMS(Index = 773)]
        /* 0x86D0 */ public float CreatureInteractLabelOffsetY;
        [NMS(Index = 769)]
        /* 0x86D4 */ public float CreatureReticuleScale;
        [NMS(Index = 739)]
        /* 0x86D8 */ public float CreatureRoutineMarkerTime;
        [NMS(Index = 740)]
        /* 0x86DC */ public int CreatureRoutineRegionsPerFrame;
        [NMS(Index = 825)]
        /* 0x86E0 */ public float CriticalMessageTime;
        [NMS(Index = 701)]
        /* 0x86E4 */ public float CrosshairAimOffTime;
        [NMS(Index = 700)]
        /* 0x86E8 */ public float CrosshairAimTime;
        [NMS(Index = 702)]
        /* 0x86EC */ public float CrosshairInnerMinFade;
        [NMS(Index = 703)]
        /* 0x86F0 */ public float CrosshairInnerMinFadeRange;
        [NMS(Index = 724)]
        /* 0x86F4 */ public float CrosshairInterceptAlpha;
        [NMS(Index = 721)]
        /* 0x86F8 */ public float CrosshairInterceptBaseSize;
        [NMS(Index = 722)]
        /* 0x86FC */ public float CrosshairInterceptCentreBaseSize;
        [NMS(Index = 725)]
        /* 0x8700 */ public float CrosshairInterceptLockRange;
        [NMS(Index = 720)]
        /* 0x8704 */ public float CrosshairInterceptSize;
        [NMS(Index = 723)]
        /* 0x8708 */ public float CrosshairInterceptSpringTime;
        [NMS(Index = 707)]
        /* 0x870C */ public float CrosshairLeadCornerOffset;
        [NMS(Index = 716)]
        /* 0x8710 */ public float CrosshairLeadFadeRange;
        [NMS(Index = 717)]
        /* 0x8714 */ public float CrosshairLeadFadeSize;
        [NMS(Index = 705)]
        /* 0x8718 */ public float CrosshairLeadInDelay;
        [NMS(Index = 706)]
        /* 0x871C */ public float CrosshairLeadInTime;
        [NMS(Index = 710)]
        /* 0x8720 */ public float CrosshairLeadPulseSize;
        [NMS(Index = 704)]
        /* 0x8724 */ public float CrosshairLeadScaleIn;
        [NMS(Index = 714)]
        /* 0x8728 */ public float CrosshairLeadSpring;
        [NMS(Index = 715)]
        /* 0x872C */ public float CrosshairLeadSpringOff;
        [NMS(Index = 709)]
        /* 0x8730 */ public float CrosshairLeadTopLock;
        [NMS(Index = 708)]
        /* 0x8734 */ public float CrosshairLeadTopOffset;
        [NMS(Index = 310)]
        /* 0x8738 */ public float CrosshairOffsetHmd;
        [NMS(Index = 311)]
        /* 0x873C */ public float CrosshairOffsetHmdUp;
        [NMS(Index = 309)]
        /* 0x8740 */ public float CrosshairScaleHmd;
        [NMS(Index = 313)]
        /* 0x8744 */ public int CrosshairScreenHeight;
        [NMS(Index = 312)]
        /* 0x8748 */ public int CrosshairScreenWidth;
        [NMS(Index = 713)]
        /* 0x874C */ public float CrosshairSpringAimTime;
        [NMS(Index = 712)]
        /* 0x8750 */ public float CrosshairSpringTime;
        [NMS(Index = 726)]
        /* 0x8754 */ public float CrosshairTargetLockSize;
        [NMS(Index = 1116)]
        /* 0x8758 */ public float CursorHoverSlowFactor;
        [NMS(Index = 1117)]
        /* 0x875C */ public float CursorHoverSlowFactorMin;
        [NMS(Index = 1114)]
        /* 0x8760 */ public float CursorHoverSlowFixedValue;
        [NMS(Index = 544)]
        /* 0x8764 */ public float DamageDirectionIndicatorOnScreenRadiusMultiplier;
        [NMS(Index = 618)]
        /* 0x8768 */ public float DamageImpactMergeTime;
        [NMS(Index = 620)]
        /* 0x876C */ public float DamageImpactMinDistance;
        [NMS(Index = 619)]
        /* 0x8770 */ public float DamageImpactTimeBetweenNumbers;
        [NMS(Index = 629)]
        /* 0x8774 */ public float DamageNumberBlackAlpha;
        [NMS(Index = 635)]
        /* 0x8778 */ public float DamageNumberFadeIn;
        [NMS(Index = 636)]
        /* 0x877C */ public float DamageNumberFadeOut;
        [NMS(Index = 628)]
        /* 0x8780 */ public float DamageNumberLaserMaxDamage;
        [NMS(Index = 627)]
        /* 0x8784 */ public float DamageNumberLaserMinDamage;
        [NMS(Index = 632)]
        /* 0x8788 */ public float DamageNumberOffsetX;
        [NMS(Index = 633)]
        /* 0x878C */ public float DamageNumberOffsetY;
        [NMS(Index = 630)]
        /* 0x8790 */ public float DamageNumberOutline;
        [NMS(Index = 631)]
        /* 0x8794 */ public float DamageNumberOutline2;
        [NMS(Index = 624)]
        /* 0x8798 */ public float DamageNumberSize;
        [NMS(Index = 625)]
        /* 0x879C */ public float DamageNumberSizeCritMultiplier;
        [NMS(Index = 623)]
        /* 0x87A0 */ public float DamageNumberSizeInShip;
        [NMS(Index = 626)]
        /* 0x87A4 */ public float DamageNumberSizeLaserMultiplier;
        [NMS(Index = 622)]
        /* 0x87A8 */ public float DamageNumberTime;
        [NMS(Index = 637)]
        /* 0x87AC */ public float DamageNumberUpOffset;
        [NMS(Index = 621)]
        /* 0x87B0 */ public float DamagePerSecondSampleTime;
        [NMS(Index = 466)]
        /* 0x87B4 */ public float DamageScannableHighlightTime;
        [NMS(Index = 467)]
        /* 0x87B8 */ public float DamageTrackArrowTime;
        [NMS(Index = 956)]
        /* 0x87BC */ public float DeathMessageSwitchTime;
        [NMS(Index = 957)]
        /* 0x87C0 */ public float DeathMessageTotalTime;
        [NMS(Index = 66)]
        /* 0x87C4 */ public int DebugMedalRank;
        [NMS(Index = 1063)]
        /* 0x87C8 */ public float DeepSeaHazardMultiplierCold;
        [NMS(Index = 1061)]
        /* 0x87CC */ public float DeepSeaHazardMultiplierHeat;
        [NMS(Index = 1062)]
        /* 0x87D0 */ public float DeepSeaHazardMultiplierRad;
        [NMS(Index = 1060)]
        /* 0x87D4 */ public float DeepSeaHazardMultiplierTox;
        [NMS(Index = 650)]
        /* 0x87D8 */ public float DelayBeforeHidingHangarAfterGalaxyMap;
        [NMS(Index = 651)]
        /* 0x87DC */ public float DelayBeforeShowingHangarIntoGalaxyMap;
        [NMS(Index = 598)]
        /* 0x87E0 */ public float DescriptionTextDelay;
        [NMS(Index = 599)]
        /* 0x87E4 */ public float DescriptionTextSpeed;
        [NMS(Index = 600)]
        /* 0x87E8 */ public float DescriptionTextSpeedProgressive;
        [NMS(Index = 602)]
        /* 0x87EC */ public float DescriptionTextTimeMax;
        [NMS(Index = 601)]
        /* 0x87F0 */ public float DescriptionTextTimeMin;
        [NMS(Index = 1456)]
        /* 0x87F4 */ public float DetailMessageDismissTime;
        [NMS(Index = 360)]
        /* 0x87F8 */ public float DroneIndicatorCentreRadiusMax;
        [NMS(Index = 361)]
        /* 0x87FC */ public float DroneIndicatorCentreRadiusMin;
        [NMS(Index = 362)]
        /* 0x8800 */ public float DroneIndicatorFadeRange;
        [NMS(Index = 359)]
        /* 0x8804 */ public float DroneIndicatorRadius;
        [NMS(Index = 114)]
        /* 0x8808 */ public float EggModifiyAnimLoopTime;
        [NMS(Index = 113)]
        /* 0x880C */ public float EggModifiyAnimMaxSize;
        [NMS(Index = 123)]
        /* 0x8810 */ public float EndOfSeasonAlertDelay;
        [NMS(Index = 162)]
        /* 0x8814 */ public float ExocraftHUDMarkerHideDistance;
        [NMS(Index = 163)]
        /* 0x8818 */ public float ExocraftHUDMarkerOffset;
        [NMS(Index = 120)]
        /* 0x881C */ public float ExpeditionStageChangeTime;
        [NMS(Index = 60)]
        /* 0x8820 */ public float EyeTrackingCursorBlendRate;
        [NMS(Index = 59)]
        /* 0x8824 */ public float EyeTrackingCursorBlendRateGameModeSelect;
        [NMS(Index = 58)]
        /* 0x8828 */ public float EyeTrackingPopupLookAwayTime;
        [NMS(Index = 61)]
        /* 0x882C */ public float EyeTrackingStickyHoverTime;
        [NMS(Index = 57)]
        /* 0x8830 */ public float EyeTrackingTimeBeforePopupsActivate;
        [NMS(Index = 1464)]
        /* 0x8834 */ public float FeedFrigateAnimAlphaChange;
        [NMS(Index = 1462)]
        /* 0x8838 */ public int FeedFrigateAnimNumPeriods;
        [NMS(Index = 1461)]
        /* 0x883C */ public float FeedFrigateAnimPeriod;
        [NMS(Index = 1463)]
        /* 0x8840 */ public float FeedFrigateAnimScaleChange;
        [NMS(Index = 128)]
        /* 0x8844 */ public int ForceOpenHazardProtInventoryThreshold;
        [NMS(Index = 663)]
        /* 0x8848 */ public float FreighterCommanderMarkerMinDistance;
        [NMS(Index = 697)]
        /* 0x884C */ public float FreighterEntranceOffset;
        [NMS(Index = 669)]
        /* 0x8850 */ public float FreighterHighlightRange;
        [NMS(Index = 696)]
        /* 0x8854 */ public float FreighterLeaderIconDistance;
        [NMS(Index = 103)]
        /* 0x8858 */ public float FreighterMegaWarpTransitionTime;
        [NMS(Index = 659)]
        /* 0x885C */ public float FreighterSummonDelay;
        [NMS(Index = 662)]
        /* 0x8860 */ public float FreighterSummonGridSize;
        [NMS(Index = 668)]
        /* 0x8864 */ public float FreighterSummonLookTime;
        [NMS(Index = 654)]
        /* 0x8868 */ public float FreighterSummonOffset;
        [NMS(Index = 655)]
        /* 0x886C */ public float FreighterSummonOffsetPulse;
        [NMS(Index = 653)]
        /* 0x8870 */ public float FreighterSummonPitch;
        [NMS(Index = 667)]
        /* 0x8874 */ public float FreighterSummonPlanetOffset;
        [NMS(Index = 666)]
        /* 0x8878 */ public float FreighterSummonPulseFadeAmount;
        [NMS(Index = 665)]
        /* 0x887C */ public float FreighterSummonPulseRate;
        [NMS(Index = 652)]
        /* 0x8880 */ public float FreighterSummonTurn;
        [NMS(Index = 661)]
        /* 0x8884 */ public float FreighterSummonTurnAngleIncrement;
        [NMS(Index = 660)]
        /* 0x8888 */ public int FreighterSummonTurnNumTries;
        [NMS(Index = 664)]
        /* 0x888C */ public float FreighterSurfaceMinAngle;
        [NMS(Index = 695)]
        /* 0x8890 */ public float FrigateDamageIconVisibilityDistance;
        [NMS(Index = 647)]
        /* 0x8894 */ public float FrigateIconOffset;
        [NMS(Index = 694)]
        /* 0x8898 */ public float FrigatePurchaseNotificationResetDistanceMultiplier;
        [NMS(Index = 1136)]
        /* 0x889C */ public float FrontendActivateSplit;
        [NMS(Index = 1135)]
        /* 0x88A0 */ public float FrontendActivateTime;
        [NMS(Index = 1120)]
        /* 0x88A4 */ public float FrontendBGAlpha;
        [NMS(Index = 1140)]
        /* 0x88A8 */ public float FrontendBootBarTime;
        [NMS(Index = 1139)]
        /* 0x88AC */ public float FrontendBootTime;
        [NMS(Index = 1124)]
        /* 0x88B0 */ public float FrontendConfirmTime;
        [NMS(Index = 1122)]
        /* 0x88B4 */ public float FrontendConfirmTimeFast;
        [NMS(Index = 1121)]
        /* 0x88B8 */ public float FrontendConfirmTimeMouseMultiplier;
        [NMS(Index = 1125)]
        /* 0x88BC */ public float FrontendConfirmTimeSlow;
        [NMS(Index = 1128)]
        /* 0x88C0 */ public float FrontendCursorOffset;
        [NMS(Index = 1127)]
        /* 0x88C4 */ public float FrontendCursorSize;
        [NMS(Index = 1132)]
        /* 0x88C8 */ public float FrontendCursorWidth;
        [NMS(Index = 1134)]
        /* 0x88CC */ public float FrontendDeactivateSplit;
        [NMS(Index = 1133)]
        /* 0x88D0 */ public float FrontendDeactivateTime;
        [NMS(Index = 1212)]
        /* 0x88D4 */ public float FrontendDoFBlurMultiplier;
        [NMS(Index = 1210)]
        /* 0x88D8 */ public float FrontendDoFFarPlane;
        [NMS(Index = 1211)]
        /* 0x88DC */ public float FrontendDoFFarPlaneFade;
        [NMS(Index = 1209)]
        /* 0x88E0 */ public float FrontendDoFNearPlane;
        [NMS(Index = 191)]
        /* 0x88E4 */ public float FrontendOffsetVR;
        [NMS(Index = 1214)]
        /* 0x88E8 */ public float FrontendShineSpeed;
        [NMS(Index = 1137)]
        /* 0x88EC */ public float FrontendStatCircleWidth;
        [NMS(Index = 1138)]
        /* 0x88F0 */ public float FrontendStatCircleWidthExtra;
        [NMS(Index = 1217)]
        /* 0x88F4 */ public float FrontendTitleFontSpacing;
        [NMS(Index = 1215)]
        /* 0x88F8 */ public float FrontendToolbarTextHeight;
        [NMS(Index = 1216)]
        /* 0x88FC */ public float FrontendToolbarTextHeightSelected;
        [NMS(Index = 1123)]
        /* 0x8900 */ public float FrontendTouchConfirmTimeFastMultiplier;
        [NMS(Index = 593)]
        /* 0x8904 */ public float FrontendWaitFadeProgressiveDialogOut;
        [NMS(Index = 592)]
        /* 0x8908 */ public float FrontendWaitFadeTextFrameOut;
        [NMS(Index = 591)]
        /* 0x890C */ public float FrontendWaitFadeTextOut;
        [NMS(Index = 589)]
        /* 0x8910 */ public float FrontendWaitInitial;
        [NMS(Index = 590)]
        /* 0x8914 */ public float FrontendWaitInitialTerminal;
        [NMS(Index = 588)]
        /* 0x8918 */ public float FrontendWaitResponse;
        [NMS(Index = 594)]
        /* 0x891C */ public float FrontendWaitResponseOffset;
        [NMS(Index = 890)]
        /* 0x8920 */ public float GalaxyMapRadialBorder;
        [NMS(Index = 891)]
        /* 0x8924 */ public float GalaxyMapRadialTargetDist;
        [NMS(Index = 190)]
        /* 0x8928 */ public float GalmapDiscoveryOffsetVR;
        [NMS(Index = 112)]
        /* 0x892C */ public float GameModeSelectColourFadeTime;
        [NMS(Index = 1470)]
        /* 0x8930 */ public float GDKHandheldMinFontHeight;
        [NMS(Index = 93)]
        /* 0x8934 */ public float GridDecayRateSwitchValue;
        [NMS(Index = 577)]
        /* 0x8938 */ public float GridFlickerAmp;
        [NMS(Index = 575)]
        /* 0x893C */ public float GridFlickerBaseAlpha;
        [NMS(Index = 576)]
        /* 0x8940 */ public float GridFlickerFreq;
        [NMS(Index = 253)]
        /* 0x8944 */ public float HandButtonClickTime;
        [NMS(Index = 249)]
        /* 0x8948 */ public float HandButtonCursorScale;
        [NMS(Index = 257)]
        /* 0x894C */ public float HandButtonDotRadius;
        [NMS(Index = 255)]
        /* 0x8950 */ public float HandButtonFrontendCursorScale;
        [NMS(Index = 251)]
        /* 0x8954 */ public float HandButtonNearDistance;
        [NMS(Index = 246)]
        /* 0x8958 */ public float HandButtonPostClickTime;
        [NMS(Index = 258)]
        /* 0x895C */ public float HandButtonPulseRadius;
        [NMS(Index = 259)]
        /* 0x8960 */ public float HandButtonPulseThickness;
        [NMS(Index = 250)]
        /* 0x8964 */ public float HandButtonPushDistance;
        [NMS(Index = 242)]
        /* 0x8968 */ public float HandButtonRadius;
        [NMS(Index = 252)]
        /* 0x896C */ public float HandButtonRadiusClick;
        [NMS(Index = 243)]
        /* 0x8970 */ public float HandButtonRadiusTouch;
        [NMS(Index = 244)]
        /* 0x8974 */ public float HandButtonRadiusTouchNear;
        [NMS(Index = 245)]
        /* 0x8978 */ public float HandButtonRadiusTouchNearActive;
        [NMS(Index = 247)]
        /* 0x897C */ public float HandButtonReleaseThreshold;
        [NMS(Index = 248)]
        /* 0x8980 */ public float HandButtonReleaseThresholdInit;
        [NMS(Index = 256)]
        /* 0x8984 */ public float HandButtonThickness;
        [NMS(Index = 254)]
        /* 0x8988 */ public float HandButtonTouchReturnTime;
        [NMS(Index = 279)]
        /* 0x898C */ public float HandControlButtonSize;
        [NMS(Index = 286)]
        /* 0x8990 */ public float HandControlMenuAngle;
        [NMS(Index = 236)]
        /* 0x8994 */ public float HandControlMenuCursorScale;
        [NMS(Index = 292)]
        /* 0x8998 */ public float HandControlMenuDepth;
        [NMS(Index = 285)]
        /* 0x899C */ public float HandControlMenuMoveActionDistance;
        [NMS(Index = 282)]
        /* 0x89A0 */ public float HandControlMenuMoveDistance;
        [NMS(Index = 283)]
        /* 0x89A4 */ public float HandControlMenuMoveDistanceScroll;
        [NMS(Index = 284)]
        /* 0x89A8 */ public float HandControlMenuMoveDistanceVertical;
        [NMS(Index = 288)]
        /* 0x89AC */ public float HandControlMenuSelectRadius;
        [NMS(Index = 289)]
        /* 0x89B0 */ public float HandControlMenuSelectRadius1;
        [NMS(Index = 290)]
        /* 0x89B4 */ public float HandControlMenuSelectRadius2;
        [NMS(Index = 287)]
        /* 0x89B8 */ public float HandControlMenuSurfaceOffset;
        [NMS(Index = 281)]
        /* 0x89BC */ public float HandControlPointActiveMargin;
        [NMS(Index = 280)]
        /* 0x89C0 */ public float HandControlPointMargin;
        [NMS(Index = 291)]
        /* 0x89C4 */ public float HandControlTopMenuSelectRadius;
        [NMS(Index = 136)]
        /* 0x89C8 */ public float HandheldHUDZoomFactor;
        [NMS(Index = 240)]
        /* 0x89CC */ public float HandScreenGraphicsHeight;
        [NMS(Index = 239)]
        /* 0x89D0 */ public float HandScreenGraphicsWidth;
        [NMS(Index = 296)]
        /* 0x89D4 */ public int HandScreenHeight;
        [NMS(Index = 241)]
        /* 0x89D8 */ public float HandScreenNearActivateDistance;
        [NMS(Index = 294)]
        /* 0x89DC */ public int HandScreenWeaponHeight;
        [NMS(Index = 293)]
        /* 0x89E0 */ public int HandScreenWeaponWidth;
        [NMS(Index = 295)]
        /* 0x89E4 */ public int HandScreenWidth;
        [NMS(Index = 1207)]
        /* 0x89E8 */ public float HatchAlphaBase;
        [NMS(Index = 1208)]
        /* 0x89EC */ public float HatchAlphaCursor;
        [NMS(Index = 1206)]
        /* 0x89F0 */ public float HatchAlphaMain;
        [NMS(Index = 1204)]
        /* 0x89F4 */ public int HatchCount;
        [NMS(Index = 1205)]
        /* 0x89F8 */ public float HatchCursorRadius;
        [NMS(Index = 1203)]
        /* 0x89FC */ public float HatchPulsePauseTime;
        [NMS(Index = 1201)]
        /* 0x8A00 */ public float HatchPulseSpeed;
        [NMS(Index = 1202)]
        /* 0x8A04 */ public float HatchPulseWidth;
        [NMS(Index = 677)]
        /* 0x8A08 */ public float HazardArrowsLevel2Threshold;
        [NMS(Index = 678)]
        /* 0x8A0C */ public float HazardArrowsLevel3Threshold;
        [NMS(Index = 1039)]
        /* 0x8A10 */ public float HazardBarPulseTime;
        [NMS(Index = 1044)]
        /* 0x8A14 */ public float HazardPainPulseStrength;
        [NMS(Index = 1065)]
        /* 0x8A18 */ public float HazardPulseRate;
        [NMS(Index = 1036)]
        /* 0x8A1C */ public float HazardScreenEffectPulseRate;
        [NMS(Index = 1040)]
        /* 0x8A20 */ public float HazardScreenEffectPulseTime;
        [NMS(Index = 1041)]
        /* 0x8A24 */ public float HazardScreenEffectStrength;
        [NMS(Index = 1043)]
        /* 0x8A28 */ public float HazardWarningPulseStrength;
        [NMS(Index = 1042)]
        /* 0x8A2C */ public float HazardWarningPulseTime;
        [NMS(Index = 1227)]
        /* 0x8A30 */ public float HitMarkerPulseSize;
        [NMS(Index = 1228)]
        /* 0x8A34 */ public float HitMarkerPulseSizeStatic;
        [NMS(Index = 1229)]
        /* 0x8A38 */ public float HitMarkerPulseTime;
        [NMS(Index = 307)]
        /* 0x8A3C */ public float HmdFramerateScreenPitch;
        [NMS(Index = 1032)]
        /* 0x8A40 */ public float HoldTimerResetTime;
        [NMS(Index = 606)]
        /* 0x8A44 */ public float HoverOffscreenBorder;
        [NMS(Index = 607)]
        /* 0x8A48 */ public float HoverOffscreenBorderXVR;
        [NMS(Index = 608)]
        /* 0x8A4C */ public float HoverOffscreenBorderYAltUI;
        [NMS(Index = 53)]
        /* 0x8A50 */ public float HoverPopAnimDuration;
        [NMS(Index = 52)]
        /* 0x8A54 */ public float HoverPopScaleModification;
        [NMS(Index = 830)]
        /* 0x8A58 */ public float HUDDisplayTime;
        [NMS(Index = 776)]
        /* 0x8A5C */ public float HUDDroneCombatPulse;
        [NMS(Index = 774)]
        /* 0x8A60 */ public float HUDDroneHealingPulse;
        [NMS(Index = 775)]
        /* 0x8A64 */ public float HUDDroneSummoningPulse;
        [NMS(Index = 968)]
        /* 0x8A68 */ public float HUDElementsOffsetHMDBottom;
        [NMS(Index = 966)]
        /* 0x8A6C */ public float HUDElementsOffsetHMDSide;
        [NMS(Index = 967)]
        /* 0x8A70 */ public float HUDElementsOffsetHMDTop;
        [NMS(Index = 969)]
        /* 0x8A74 */ public float HUDElementsOffsetX_0;
        [NMS(Index = 971)]
        /* 0x8A78 */ public float HUDElementsOffsetX_1;
        [NMS(Index = 973)]
        /* 0x8A7C */ public float HUDElementsOffsetX_2;
        [NMS(Index = 975)]
        /* 0x8A80 */ public float HUDElementsOffsetX_3;
        [NMS(Index = 977)]
        /* 0x8A84 */ public float HUDElementsOffsetX_4;
        [NMS(Index = 979)]
        /* 0x8A88 */ public float HUDElementsOffsetX_5;
        [NMS(Index = 970)]
        /* 0x8A8C */ public float HUDElementsOffsetY_0;
        [NMS(Index = 972)]
        /* 0x8A90 */ public float HUDElementsOffsetY_1;
        [NMS(Index = 974)]
        /* 0x8A94 */ public float HUDElementsOffsetY_2;
        [NMS(Index = 976)]
        /* 0x8A98 */ public float HUDElementsOffsetY_3;
        [NMS(Index = 978)]
        /* 0x8A9C */ public float HUDElementsOffsetY_4;
        [NMS(Index = 980)]
        /* 0x8AA0 */ public float HUDElementsOffsetY_5;
        [NMS(Index = 1361)]
        /* 0x8AA4 */ public float HUDMarkerActiveTime;
        [NMS(Index = 1356)]
        /* 0x8AA8 */ public float HUDMarkerAlpha;
        [NMS(Index = 1331)]
        /* 0x8AAC */ public float HUDMarkerAnimLoopTime;
        [NMS(Index = 1330)]
        /* 0x8AB0 */ public float HUDMarkerAnimOffset;
        [NMS(Index = 1329)]
        /* 0x8AB4 */ public float HUDMarkerAnimScale;
        [NMS(Index = 1328)]
        /* 0x8AB8 */ public float HUDMarkerAnimSpeed;
        [NMS(Index = 470)]
        /* 0x8ABC */ public float HUDMarkerDistanceOrTimeDistance;
        [NMS(Index = 1349)]
        /* 0x8AC0 */ public float HUDMarkerFarDistance;
        [NMS(Index = 1350)]
        /* 0x8AC4 */ public float HUDMarkerFarFadeRange;
        [NMS(Index = 1355)]
        /* 0x8AC8 */ public float HUDMarkerHorizonBlendRange;
        [NMS(Index = 1337)]
        /* 0x8ACC */ public float HUDMarkerHoverAngleTestGround;
        [NMS(Index = 314)]
        /* 0x8AD0 */ public float HUDMarkerHoverAngleTestGroundHmd;
        [NMS(Index = 1341)]
        /* 0x8AD4 */ public float HUDMarkerHoverAngleTestShip;
        [NMS(Index = 1342)]
        /* 0x8AD8 */ public float HUDMarkerHoverShowLargeAngleTest;
        [NMS(Index = 1363)]
        /* 0x8ADC */ public float HUDMarkerIconHoverMinScale;
        [NMS(Index = 580)]
        /* 0x8AE0 */ public float HUDMarkerLabelArriveDistance;
        [NMS(Index = 579)]
        /* 0x8AE4 */ public float HUDMarkerLabelBaseWidth;
        [NMS(Index = 581)]
        /* 0x8AE8 */ public float HUDMarkerLabelDisplayDistance;
        [NMS(Index = 578)]
        /* 0x8AEC */ public float HUDMarkerLabelWidthMultiplier;
        [NMS(Index = 1358)]
        /* 0x8AF0 */ public float HUDMarkerModelFadeMinHeight;
        [NMS(Index = 1357)]
        /* 0x8AF4 */ public float HUDMarkerModelFadeRange;
        [NMS(Index = 1347)]
        /* 0x8AF8 */ public float HUDMarkerNearFadeDistance;
        [NMS(Index = 1348)]
        /* 0x8AFC */ public float HUDMarkerNearFadeRange;
        [NMS(Index = 582)]
        /* 0x8B00 */ public float HUDMarkerNonActiveMissionAlpha;
        [NMS(Index = 469)]
        /* 0x8B04 */ public float HUDMarkerObjectMinScreenDistance;
        [NMS(Index = 1311)]
        /* 0x8B08 */ public float HUDMarkerOffset;
        [NMS(Index = 1334)]
        /* 0x8B0C */ public float HUDMarkerPrimaryIndicatorSize;
        [NMS(Index = 1351)]
        /* 0x8B10 */ public float HUDMarkerScalerMin;
        [NMS(Index = 1352)]
        /* 0x8B14 */ public float HUDMarkerScalerRange;
        [NMS(Index = 1354)]
        /* 0x8B18 */ public float HUDMarkerScalerSizeMax;
        [NMS(Index = 1353)]
        /* 0x8B1C */ public float HUDMarkerScalerSizeMin;
        [NMS(Index = 1345)]
        /* 0x8B20 */ public float HUDMarkerShipOffsetMaxDist;
        [NMS(Index = 1346)]
        /* 0x8B24 */ public float HUDMarkerShipOffsetMinDist;
        [NMS(Index = 1359)]
        /* 0x8B28 */ public float HUDMarkerShowActualIconDistance;
        [NMS(Index = 1360)]
        /* 0x8B2C */ public float HUDMarkerShowActualSpaceIconDistance;
        [NMS(Index = 1340)]
        /* 0x8B30 */ public float HUDMarkerWideHoverAngleTest;
        [NMS(Index = 315)]
        /* 0x8B34 */ public float HUDMarkerWideHoverAngleTestHmd;
        [NMS(Index = 1339)]
        /* 0x8B38 */ public float HUDNetworkMarkerHoverAngleTestGround;
        [NMS(Index = 1344)]
        /* 0x8B3C */ public float HUDNetworkMarkerHoverAngleVRMul;
        [NMS(Index = 1343)]
        /* 0x8B40 */ public float HUDNetworkMarkerHoverShowLargeAngleTest;
        [NMS(Index = 1338)]
        /* 0x8B44 */ public float HUDPetCentreScreenAngle;
        [NMS(Index = 1335)]
        /* 0x8B48 */ public float HUDPetMarkerAngleTest;
        [NMS(Index = 1336)]
        /* 0x8B4C */ public float HUDPetMarkerAngleVRMul;
        [NMS(Index = 502)]
        /* 0x8B50 */ public float HUDPlayerPhonePulseScanFreq;
        [NMS(Index = 501)]
        /* 0x8B54 */ public float HUDPlayerSentinelPulseScanFreq;
        [NMS(Index = 499)]
        /* 0x8B58 */ public float HUDPlayerSentinelPulseWidth;
        [NMS(Index = 500)]
        /* 0x8B5C */ public float HUDPlayerSentinelRangeFactor;
        [NMS(Index = 878)]
        /* 0x8B60 */ public float HUDPlayerTrackArrowArrowSize;
        [NMS(Index = 847)]
        /* 0x8B64 */ public float HUDPlayerTrackArrowDamageGlowHullHitCriticalOpacityScale;
        [NMS(Index = 848)]
        /* 0x8B68 */ public float HUDPlayerTrackArrowDamageGlowHullHitOpacityScale;
        [NMS(Index = 855)]
        /* 0x8B6C */ public float HUDPlayerTrackArrowDamageGlowOffset;
        [NMS(Index = 851)]
        /* 0x8B70 */ public float HUDPlayerTrackArrowDamageGlowShieldHitCriticalOpacityScale;
        [NMS(Index = 852)]
        /* 0x8B74 */ public float HUDPlayerTrackArrowDamageGlowShieldHitOpacityScale;
        [NMS(Index = 879)]
        /* 0x8B78 */ public float HUDPlayerTrackArrowDotSize;
        [NMS(Index = 859)]
        /* 0x8B7C */ public float HUDPlayerTrackArrowEnergyShieldDepletedGlowOpacityScale;
        [NMS(Index = 860)]
        /* 0x8B80 */ public float HUDPlayerTrackArrowEnergyShieldDepletedTime;
        [NMS(Index = 857)]
        /* 0x8B84 */ public float HUDPlayerTrackArrowEnergyShieldGlowOffset;
        [NMS(Index = 843)]
        /* 0x8B88 */ public float HUDPlayerTrackArrowEnergyShieldLowThreshold;
        [NMS(Index = 844)]
        /* 0x8B8C */ public float HUDPlayerTrackArrowEnergyShieldOffset;
        [NMS(Index = 864)]
        /* 0x8B90 */ public float HUDPlayerTrackArrowEnergyShieldStartChargeGlowOpacityScale;
        [NMS(Index = 865)]
        /* 0x8B94 */ public float HUDPlayerTrackArrowEnergyShieldStartChargeTime;
        [NMS(Index = 887)]
        /* 0x8B98 */ public float HUDPlayerTrackArrowFadeRange;
        [NMS(Index = 846)]
        /* 0x8B9C */ public float HUDPlayerTrackArrowGlowBaseOpacity;
        [NMS(Index = 839)]
        /* 0x8BA0 */ public float HUDPlayerTrackArrowHealthOffset;
        [NMS(Index = 802)]
        /* 0x8BA4 */ public float HUDPlayerTrackArrowIconBorderReducerShip;
        [NMS(Index = 799)]
        /* 0x8BA8 */ public float HUDPlayerTrackArrowIconFadeDist;
        [NMS(Index = 798)]
        /* 0x8BAC */ public float HUDPlayerTrackArrowIconFadeDistDrone;
        [NMS(Index = 797)]
        /* 0x8BB0 */ public float HUDPlayerTrackArrowIconFadeDistShip;
        [NMS(Index = 800)]
        /* 0x8BB4 */ public float HUDPlayerTrackArrowIconFadeRange;
        [NMS(Index = 801)]
        /* 0x8BB8 */ public float HUDPlayerTrackArrowIconFadeRangeShip;
        [NMS(Index = 792)]
        /* 0x8BBC */ public float HUDPlayerTrackArrowIconFadeTime;
        [NMS(Index = 796)]
        /* 0x8BC0 */ public float HUDPlayerTrackArrowIconPulse2Alpha;
        [NMS(Index = 790)]
        /* 0x8BC4 */ public float HUDPlayerTrackArrowIconPulseTime;
        [NMS(Index = 794)]
        /* 0x8BC8 */ public float HUDPlayerTrackArrowIconPulseWidth1;
        [NMS(Index = 795)]
        /* 0x8BCC */ public float HUDPlayerTrackArrowIconPulseWidth2;
        [NMS(Index = 791)]
        /* 0x8BD0 */ public float HUDPlayerTrackArrowIconShowTime;
        [NMS(Index = 876)]
        /* 0x8BD4 */ public float HUDPlayerTrackArrowIconSize;
        [NMS(Index = 886)]
        /* 0x8BD8 */ public float HUDPlayerTrackArrowMinFadeDist;
        [NMS(Index = 871)]
        /* 0x8BDC */ public float HUDPlayerTrackArrowOffset;
        [NMS(Index = 803)]
        /* 0x8BE0 */ public float HUDPlayerTrackArrowPulseOffset;
        [NMS(Index = 804)]
        /* 0x8BE4 */ public float HUDPlayerTrackArrowPulseRate;
        [NMS(Index = 872)]
        /* 0x8BE8 */ public float HUDPlayerTrackArrowScreenBorder;
        [NMS(Index = 789)]
        /* 0x8BEC */ public float HUDPlayerTrackArrowShipLabelOffset;
        [NMS(Index = 873)]
        /* 0x8BF0 */ public float HUDPlayerTrackArrowSize;
        [NMS(Index = 875)]
        /* 0x8BF4 */ public float HUDPlayerTrackArrowSizeMax;
        [NMS(Index = 874)]
        /* 0x8BF8 */ public float HUDPlayerTrackArrowSizeMin;
        [NMS(Index = 877)]
        /* 0x8BFC */ public float HUDPlayerTrackArrowSmallIconSize;
        [NMS(Index = 870)]
        /* 0x8C00 */ public float HUDPlayerTrackArrowTargetDist;
        [NMS(Index = 869)]
        /* 0x8C04 */ public float HUDPlayerTrackArrowTargetDistShip;
        [NMS(Index = 835)]
        /* 0x8C08 */ public float HUDPlayerTrackArrowTextExtraHeight;
        [NMS(Index = 836)]
        /* 0x8C0C */ public float HUDPlayerTrackArrowTextExtraOffsetX;
        [NMS(Index = 837)]
        /* 0x8C10 */ public float HUDPlayerTrackArrowTextExtraOffsetY;
        [NMS(Index = 833)]
        /* 0x8C14 */ public float HUDPlayerTrackArrowTextHeight;
        [NMS(Index = 832)]
        /* 0x8C18 */ public float HUDPlayerTrackArrowTextOffset;
        [NMS(Index = 831)]
        /* 0x8C1C */ public float HUDPlayerTrackDangerPulse;
        [NMS(Index = 777)]
        /* 0x8C20 */ public float HUDPlayerTrackNoSightPulse;
        [NMS(Index = 780)]
        /* 0x8C24 */ public float HUDPlayerTrackTimerEnd;
        [NMS(Index = 781)]
        /* 0x8C28 */ public float HUDPlayerTrackTimerPulseRate;
        [NMS(Index = 778)]
        /* 0x8C2C */ public float HUDPlayerTrackTimerStart;
        [NMS(Index = 779)]
        /* 0x8C30 */ public float HUDPlayerTrackTimerStartFade;
        [NMS(Index = 1306)]
        /* 0x8C34 */ public float HUDTargetHealthDangerTime;
        [NMS(Index = 1305)]
        /* 0x8C38 */ public float HUDTargetHealthIconSize;
        [NMS(Index = 1309)]
        /* 0x8C3C */ public float HUDTargetIconOffset;
        [NMS(Index = 1310)]
        /* 0x8C40 */ public float HUDTargetIconSize;
        [NMS(Index = 1307)]
        /* 0x8C44 */ public float HUDTargetMarkerOffset;
        [NMS(Index = 1308)]
        /* 0x8C48 */ public float HUDTargetMarkerSize;
        [NMS(Index = 892)]
        /* 0x8C4C */ public float IconBackgroundAlpha;
        [NMS(Index = 420)]
        /* 0x8C50 */ public float IconGlowStrengthActive;
        [NMS(Index = 419)]
        /* 0x8C54 */ public float IconGlowStrengthError;
        [NMS(Index = 422)]
        /* 0x8C58 */ public float IconGlowStrengthHighlight;
        [NMS(Index = 421)]
        /* 0x8C5C */ public float IconGlowStrengthNeutral;
        [NMS(Index = 1075)]
        /* 0x8C60 */ public float IconPulseRate;
        [NMS(Index = 1459)]
        /* 0x8C64 */ public float InfoPortalGuideCycleTime;
        [NMS(Index = 1460)]
        /* 0x8C68 */ public float InfoPortalMilestonesCycleTime;
        [NMS(Index = 1096)]
        /* 0x8C6C */ public float InteractionIconInnerRadius;
        [NMS(Index = 1097)]
        /* 0x8C70 */ public float InteractionIconOuterRadius;
        [NMS(Index = 318)]
        /* 0x8C74 */ public float InteractionInWorldMinScreenDistance;
        [NMS(Index = 319)]
        /* 0x8C78 */ public float InteractionInWorldMinScreenDistanceV2;
        [NMS(Index = 317)]
        /* 0x8C7C */ public float InteractionInWorldPitchDistance;
        [NMS(Index = 320)]
        /* 0x8C80 */ public float InteractionInWorldSeatedNPCHeightAdjust;
        [NMS(Index = 321)]
        /* 0x8C84 */ public float InteractionInWorldSeatedNPCHeightAdjustV2;
        [NMS(Index = 1094)]
        /* 0x8C88 */ public float InteractionLabelHeight;
        [NMS(Index = 1087)]
        /* 0x8C8C */ public float InteractionLabelHorizontalLineLength;
        [NMS(Index = 1095)]
        /* 0x8C90 */ public float InteractionLabelLineAlpha;
        [NMS(Index = 1099)]
        /* 0x8C94 */ public float InteractionLabelPixelHeightMax;
        [NMS(Index = 1098)]
        /* 0x8C98 */ public float InteractionLabelPixelHeightMin;
        [NMS(Index = 1093)]
        /* 0x8C9C */ public float InteractionLabelRadiusScaler;
        [NMS(Index = 1101)]
        /* 0x8CA0 */ public float InteractionLabelSpeedClose;
        [NMS(Index = 1100)]
        /* 0x8CA4 */ public float InteractionLabelSpeedOpen;
        [NMS(Index = 1002)]
        /* 0x8CA8 */ public float InteractionScanDisplayTime;
        [NMS(Index = 1001)]
        /* 0x8CAC */ public float InteractionScanMinTime;
        [NMS(Index = 1000)]
        /* 0x8CB0 */ public float InteractionScanScanTime;
        [NMS(Index = 1005)]
        /* 0x8CB4 */ public float InteractionScanSlapOverallTime;
        [NMS(Index = 1004)]
        /* 0x8CB8 */ public float InteractionScanSlapScale;
        [NMS(Index = 1003)]
        /* 0x8CBC */ public float InteractionScanSlapTime;
        [NMS(Index = 1031)]
        /* 0x8CC0 */ public float InventoryFullMessageRepeatTime;
        [NMS(Index = 952)]
        /* 0x8CC4 */ public float InventoryIconTime;
        [NMS(Index = 83)]
        /* 0x8CC8 */ public float InvSlotGradientFactor;
        [NMS(Index = 82)]
        /* 0x8CCC */ public float InvSlotGradientFactorMin;
        [NMS(Index = 84)]
        /* 0x8CD0 */ public float InvSlotGradientTime;
        [NMS(Index = 264)]
        /* 0x8CD4 */ public float InWorldInteractionScreenScale;
        [NMS(Index = 158)]
        /* 0x8CD8 */ public float InWorldInteractLabelFarDistance;
        [NMS(Index = 159)]
        /* 0x8CDC */ public float InWorldInteractLabelFarRange;
        [NMS(Index = 217)]
        /* 0x8CE0 */ public int InWorldInteractLabelHeight;
        [NMS(Index = 155)]
        /* 0x8CE4 */ public float InWorldInteractLabelMinHeadOffset;
        [NMS(Index = 156)]
        /* 0x8CE8 */ public float InWorldInteractLabelNearDistance;
        [NMS(Index = 157)]
        /* 0x8CEC */ public float InWorldInteractLabelNearRange;
        [NMS(Index = 147)]
        /* 0x8CF0 */ public float InWorldInteractLabelScale;
        [NMS(Index = 148)]
        /* 0x8CF4 */ public float InWorldInteractLabelScaleV2;
        [NMS(Index = 216)]
        /* 0x8CF8 */ public int InWorldInteractLabelWidth;
        [NMS(Index = 212)]
        /* 0x8CFC */ public float InWorldNGuiScreenScale;
        [NMS(Index = 265)]
        /* 0x8D00 */ public float InWorldNPCInteractionScreenScale;
        [NMS(Index = 211)]
        /* 0x8D04 */ public float InWorldScreenForwardOffset;
        [NMS(Index = 210)]
        /* 0x8D08 */ public float InWorldScreenMinScreenDistance;
        [NMS(Index = 149)]
        /* 0x8D0C */ public float InWorldScreenScaleDistance;
        [NMS(Index = 56)]
        /* 0x8D10 */ public float InWorldUIInteractionDistanceWithEyeTrackingEnabled;
        [NMS(Index = 955)]
        /* 0x8D14 */ public float ItemReceivedMessageTimeToAdd;
        [NMS(Index = 995)]
        /* 0x8D18 */ public float ItemSlotColourTechChargeRate;
        [NMS(Index = 1037)]
        /* 0x8D1C */ public float KeepHazardBarActiveTime;
        [NMS(Index = 1038)]
        /* 0x8D20 */ public float KeepSecondHazardBarActiveTime;
        [NMS(Index = 930)]
        /* 0x8D24 */ public float LandNotifyHeightThreshold;
        [NMS(Index = 929)]
        /* 0x8D28 */ public float LandNotifySpeedThreshold;
        [NMS(Index = 931)]
        /* 0x8D2C */ public float LandNotifyTimeThreshold;
        [NMS(Index = 743)]
        /* 0x8D30 */ public float LargeSpaceIconSize;
        [NMS(Index = 358)]
        /* 0x8D34 */ public float LoadFadeInDefaultTime;
        [NMS(Index = 142)]
        /* 0x8D38 */ public float LoadingScreenTime;
        [NMS(Index = 141)]
        /* 0x8D3C */ public float LoadingScreenTravelSpeed;
        [NMS(Index = 140)]
        /* 0x8D40 */ public float LoadingTravelDistance;
        [NMS(Index = 1375)]
        /* 0x8D44 */ public float LockOnMarkerSize;
        [NMS(Index = 1376)]
        /* 0x8D48 */ public float LockOnMarkerSizeLock;
        [NMS(Index = 208)]
        /* 0x8D4C */ public float LowerHelmetScreenPitch;
        [NMS(Index = 207)]
        /* 0x8D50 */ public float LowerHelmetScreenScale;
        [NMS(Index = 520)]
        /* 0x8D54 */ public float LowHealthShieldFactor;
        [NMS(Index = 519)]
        /* 0x8D58 */ public float LowHealthShieldMin;
        [NMS(Index = 473)]
        /* 0x8D5C */ public float MaintenanceIconFadeStart;
        [NMS(Index = 474)]
        /* 0x8D60 */ public float MaintenanceIconFadeTime;
        [NMS(Index = 950)]
        /* 0x8D64 */ public float ManualNotificationPauseTime;
        [NMS(Index = 1458)]
        /* 0x8D68 */ public float ManualScrollChangePerInputMax;
        [NMS(Index = 1457)]
        /* 0x8D6C */ public float ManualScrollChangePerInputMin;
        [NMS(Index = 471)]
        /* 0x8D70 */ public float MarkerComponentOffset;
        [NMS(Index = 368)]
        /* 0x8D74 */ public float MarkerHorizonApproachAngle;
        [NMS(Index = 367)]
        /* 0x8D78 */ public float MarkerHorizonMinOffset;
        [NMS(Index = 374)]
        /* 0x8D7C */ public float MarkerHorizonOffPlanetLightBeamAngle;
        [NMS(Index = 366)]
        /* 0x8D80 */ public float MarkerHorizonOffsetAngle;
        [NMS(Index = 375)]
        /* 0x8D84 */ public float MarkerHorizonShipApproachOffset;
        [NMS(Index = 369)]
        /* 0x8D88 */ public float MarkerOffsetTypeAngle;
        [NMS(Index = 373)]
        /* 0x8D8C */ public float MarkerOffsetTypeAngleAsteroid;
        [NMS(Index = 370)]
        /* 0x8D90 */ public float MarkerOffsetTypeAngleBattle;
        [NMS(Index = 371)]
        /* 0x8D94 */ public float MarkerOffsetTypeAngleBounty;
        [NMS(Index = 372)]
        /* 0x8D98 */ public float MarkerOffsetTypeAnglePlayerShip;
        [NMS(Index = 456)]
        /* 0x8D9C */ public float MarkerRingInnerRadius;
        [NMS(Index = 457)]
        /* 0x8DA0 */ public float MarkerRingOuterRadius;
        [NMS(Index = 384)]
        /* 0x8DA4 */ public float MarkerTagAppearDelay;
        [NMS(Index = 523)]
        /* 0x8DA8 */ public int MaxDialogCharSizeIdeographic;
        [NMS(Index = 521)]
        /* 0x8DAC */ public int MaxDialogCharSizeRoman;
        [NMS(Index = 379)]
        /* 0x8DB0 */ public int MaxNumMessageBeaconIcons;
        [NMS(Index = 193)]
        /* 0x8DB4 */ public float MaxProjectorDistanceFromDefault;
        [NMS(Index = 196)]
        /* 0x8DB8 */ public float MaxProjectorGrabDistance;
        [NMS(Index = 2)]
        /* 0x8DBC */ public int MaxScannedAsteroidArrows;
        [NMS(Index = 97)]
        /* 0x8DC0 */ public int MaxSubstanceMaxAmountForAmountFraction;
        [NMS(Index = 1476)]
        /* 0x8DC4 */ public float MeltdownStartedOSDDuration;
        [NMS(Index = 1475)]
        /* 0x8DC8 */ public float MeltdownWarningOSDDuration;
        [NMS(Index = 953)]
        /* 0x8DCC */ public float MessageNotificationTime;
        [NMS(Index = 954)]
        /* 0x8DD0 */ public float MessageTimeQuick;
        [NMS(Index = 121)]
        /* 0x8DD4 */ public float MilestoneStingDisplayTime;
        [NMS(Index = 1451)]
        /* 0x8DD8 */ public float MinimumHoldFill;
        [NMS(Index = 119)]
        /* 0x8DDC */ public float MinSeasonPlayTimeInDays;
        [NMS(Index = 756)]
        /* 0x8DE0 */ public float MissileCentreOffset;
        [NMS(Index = 1381)]
        /* 0x8DE4 */ public float MissileIconAttackPulseAmount;
        [NMS(Index = 1380)]
        /* 0x8DE8 */ public float MissileIconAttackPulseTime;
        [NMS(Index = 737)]
        /* 0x8DEC */ public float MissionCompassIconScaler;
        [NMS(Index = 383)]
        /* 0x8DF0 */ public float MissionDetailsPageBaseHeight;
        [NMS(Index = 549)]
        /* 0x8DF4 */ public int MissionLoopCount;
        [NMS(Index = 550)]
        /* 0x8DF8 */ public int MissionLoopCountPirate;
        [NMS(Index = 738)]
        /* 0x8DFC */ public float MissionMarkerSize;
        [NMS(Index = 380)]
        /* 0x8E00 */ public float MissionObjectiveBaseHeight;
        [NMS(Index = 381)]
        /* 0x8E04 */ public float MissionObjectiveDoneHeight;
        [NMS(Index = 382)]
        /* 0x8E08 */ public float MissionObjectiveScrollingExtra;
        [NMS(Index = 551)]
        /* 0x8E0C */ public int MissionSeedOffset;
        [NMS(Index = 548)]
        /* 0x8E10 */ public int MissionSpecificMissionPercent;
        [NMS(Index = 532)]
        /* 0x8E14 */ public float MissionStartEndOSDTime;
        [NMS(Index = 533)]
        /* 0x8E18 */ public float MissionStartEndOSDTimeProcedural;
        [NMS(Index = 531)]
        /* 0x8E1C */ public float MissionStartEndTime;
        [NMS(Index = 51)]
        /* 0x8E20 */ public float ModularCustomisationApplyTime;
        [NMS(Index = 1466)]
        /* 0x8E24 */ public float MouseRotateCameraSensitivity;
        [NMS(Index = 1436)]
        /* 0x8E28 */ public float MultiplayerTeleportEffectAppearTime;
        [NMS(Index = 1435)]
        /* 0x8E2C */ public float MultiplayerTeleportEffectDisappearTime;
        [NMS(Index = 1401)]
        /* 0x8E30 */ public float NGuiActiveAreaOffsetTime;
        [NMS(Index = 1392)]
        /* 0x8E34 */ public float NGuiAltPlacementDistanceScrollSpeed;
        [NMS(Index = 1400)]
        /* 0x8E38 */ public float NGuiCursorOffsetMultiplier;
        [NMS(Index = 306)]
        /* 0x8E3C */ public float NGuiHmdOffset;
        [NMS(Index = 1382)]
        /* 0x8E40 */ public float NGuiModelRotationDegreesX;
        [NMS(Index = 1383)]
        /* 0x8E44 */ public float NGuiModelRotationDegreesY;
        [NMS(Index = 1384)]
        /* 0x8E48 */ public float NGuiModelRotationDegreesZ;
        [NMS(Index = 1391)]
        /* 0x8E4C */ public float NGuiModelViewCdSmoothTime;
        [NMS(Index = 1389)]
        /* 0x8E50 */ public float NGuiModelViewDistanceDiscoveryPage;
        [NMS(Index = 1385)]
        /* 0x8E54 */ public float NGuiModelViewDistanceGlobal;
        [NMS(Index = 1388)]
        /* 0x8E58 */ public float NGuiModelViewDistanceShipPage;
        [NMS(Index = 1386)]
        /* 0x8E5C */ public float NGuiModelViewDistanceSuitPage;
        [NMS(Index = 1387)]
        /* 0x8E60 */ public float NGuiModelViewDistanceWeaponPage;
        [NMS(Index = 1409)]
        /* 0x8E64 */ public float NGuiModelViewFadeInAfterRenderTime;
        [NMS(Index = 1390)]
        /* 0x8E68 */ public float NGuiModelViewFov;
        [NMS(Index = 1394)]
        /* 0x8E6C */ public float NGuiModelViewFractionOfBBHeightAboveReflectivePlane;
        [NMS(Index = 1219)]
        /* 0x8E70 */ public float NGuiMouseSensitivity;
        [NMS(Index = 1218)]
        /* 0x8E74 */ public float NGuiPadSensitivity;
        [NMS(Index = 1393)]
        /* 0x8E78 */ public float NGuiPlacementAngleScrollSpeed;
        [NMS(Index = 1398)]
        /* 0x8E7C */ public float NGuiThumbnailModelRotationDegreesY;
        [NMS(Index = 1399)]
        /* 0x8E80 */ public float NGuiThumbnailModelViewDistance;
        [NMS(Index = 905)]
        /* 0x8E84 */ public float NotificationBackgroundGradientAlphaInShip;
        [NMS(Index = 904)]
        /* 0x8E88 */ public float NotificationBackgroundGradientEndOffsetPercentInShip;
        [NMS(Index = 938)]
        /* 0x8E8C */ public float NotificationBridgeReachDistance;
        [NMS(Index = 912)]
        /* 0x8E90 */ public float NotificationBuildHintStartTime;
        [NMS(Index = 917)]
        /* 0x8E94 */ public float NotificationCantFireTime;
        [NMS(Index = 918)]
        /* 0x8E98 */ public float NotificationDangerTime;
        [NMS(Index = 943)]
        /* 0x8E9C */ public float NotificationDeviceIdleTime;
        [NMS(Index = 939)]
        /* 0x8EA0 */ public float NotificationDiscoveryIdleTime;
        [NMS(Index = 936)]
        /* 0x8EA4 */ public float NotificationFinalMissionWait;
        [NMS(Index = 934)]
        /* 0x8EA8 */ public float NotificationGoToSpaceStationWait;
        [NMS(Index = 357)]
        /* 0x8EAC */ public float NotificationHazardMinTimeAfterRecharge;
        [NMS(Index = 909)]
        /* 0x8EB0 */ public float NotificationHazardSafeThreshold;
        [NMS(Index = 910)]
        /* 0x8EB4 */ public float NotificationHazardTimer;
        [NMS(Index = 940)]
        /* 0x8EB8 */ public float NotificationInfoIdleTime;
        [NMS(Index = 911)]
        /* 0x8EBC */ public float NotificationInteractHintStartTime;
        [NMS(Index = 913)]
        /* 0x8EC0 */ public float NotificationJetpackTime;
        [NMS(Index = 922)]
        /* 0x8EC4 */ public float NotificationMaxPageHintTime;
        [NMS(Index = 921)]
        /* 0x8EC8 */ public float NotificationMessageCycleTime;
        [NMS(Index = 908)]
        /* 0x8ECC */ public float NotificationMinVisibleTime;
        [NMS(Index = 944)]
        /* 0x8ED0 */ public float NotificationMissionHintTime;
        [NMS(Index = 945)]
        /* 0x8ED4 */ public float NotificationMissionHintTimeCritical;
        [NMS(Index = 946)]
        /* 0x8ED8 */ public float NotificationMissionHintTimeSecondary;
        [NMS(Index = 935)]
        /* 0x8EDC */ public float NotificationMonolithMissionWait;
        [NMS(Index = 941)]
        /* 0x8EE0 */ public float NotificationNewTechIdleTime;
        [NMS(Index = 942)]
        /* 0x8EE4 */ public float NotificationScanEventMissionIdleTime;
        [NMS(Index = 919)]
        /* 0x8EE8 */ public float NotificationScanTime;
        [NMS(Index = 920)]
        /* 0x8EEC */ public float NotificationScanTimeCutoff;
        [NMS(Index = 914)]
        /* 0x8EF0 */ public float NotificationShieldTime;
        [NMS(Index = 926)]
        /* 0x8EF4 */ public float NotificationShipBoostMinTime;
        [NMS(Index = 927)]
        /* 0x8EF8 */ public float NotificationShipBoostReminderTime;
        [NMS(Index = 928)]
        /* 0x8EFC */ public float NotificationShipBoostReminderTimeTutorial;
        [NMS(Index = 915)]
        /* 0x8F00 */ public float NotificationShipBoostTime;
        [NMS(Index = 916)]
        /* 0x8F04 */ public float NotificationShipBoostTimeVR;
        [NMS(Index = 923)]
        /* 0x8F08 */ public float NotificationShipJumpMinTime;
        [NMS(Index = 924)]
        /* 0x8F0C */ public float NotificationShipJumpReminderTime;
        [NMS(Index = 925)]
        /* 0x8F10 */ public float NotificationShipJumpReminderTutorial;
        [NMS(Index = 906)]
        /* 0x8F14 */ public int NotificationsResourceExtractHintCount;
        [NMS(Index = 907)]
        /* 0x8F18 */ public float NotificationStaminaHintDistanceWalked;
        [NMS(Index = 932)]
        /* 0x8F1C */ public float NotificationTimeBeforeHeridiumMarker;
        [NMS(Index = 933)]
        /* 0x8F20 */ public float NotificationUrgentMessageTime;
        [NMS(Index = 937)]
        /* 0x8F24 */ public float NotificationWaypointReachDistance;
        [NMS(Index = 826)]
        /* 0x8F28 */ public int NumDeathQuotes;
        [NMS(Index = 543)]
        /* 0x8F2C */ public float OnFootDamageDirectionIndicatorFadeRange;
        [NMS(Index = 542)]
        /* 0x8F30 */ public float OnFootDamageDirectionIndicatorRadius;
        [NMS(Index = 143)]
        /* 0x8F34 */ public float OSDMessagePauseOffscreenAngle;
        [NMS(Index = 346)]
        /* 0x8F38 */ public int OSDMessageQueueMax;
        [NMS(Index = 345)]
        /* 0x8F3C */ public int OSDMessageQueueMin;
        [NMS(Index = 344)]
        /* 0x8F40 */ public float OSDMessageQueueSpeedMultiplier;
        [NMS(Index = 11)]
        /* 0x8F44 */ public float OutpostPortalMarkerDistance;
        [NMS(Index = 1118)]
        /* 0x8F48 */ public float PadCursorAcceleration;
        [NMS(Index = 1119)]
        /* 0x8F4C */ public float PadCursorMaxSpeedModifier;
        [NMS(Index = 94)]
        /* 0x8F50 */ public float PadCursorUICurveStrength;
        [NMS(Index = 1465)]
        /* 0x8F54 */ public float PadRotateCameraSensitivity;
        [NMS(Index = 516)]
        /* 0x8F58 */ public float PageTurnTime;
        [NMS(Index = 110)]
        /* 0x8F5C */ public float ParagraphAutoScrollSpeed;
        [NMS(Index = 982)]
        /* 0x8F60 */ public float PauseMenuHoldTime;
        [NMS(Index = 165)]
        /* 0x8F64 */ public float PetBattleStatUnlockBounceTime;
        [NMS(Index = 167)]
        /* 0x8F68 */ public float PetBattleStatUnlockMessageTime;
        [NMS(Index = 166)]
        /* 0x8F6C */ public float PetBattleStatUrgentBounceTime;
        [NMS(Index = 7)]
        /* 0x8F70 */ public float PetGeneIconGlowTimeNormal;
        [NMS(Index = 8)]
        /* 0x8F74 */ public float PetGeneIconGlowTimeUrgent;
        [NMS(Index = 745)]
        /* 0x8F78 */ public float PetHoverIconSize;
        [NMS(Index = 168)]
        /* 0x8F7C */ public float PetHUDMarkerExtraFollowInfoDistance;
        [NMS(Index = 169)]
        /* 0x8F80 */ public float PetHUDMarkerHideDistance;
        [NMS(Index = 170)]
        /* 0x8F84 */ public float PetHUDMarkerHideDistanceShort;
        [NMS(Index = 171)]
        /* 0x8F88 */ public float PetHUDMarkerOffset;
        [NMS(Index = 746)]
        /* 0x8F8C */ public float PetIconSize;
        [NMS(Index = 172)]
        /* 0x8F90 */ public float PetMoodMarkerOffset;
        [NMS(Index = 164)]
        /* 0x8F94 */ public float PetSlotUnlockBounceTime;
        [NMS(Index = 646)]
        /* 0x8F98 */ public float PhotoModeTimeofDayChange;
        [NMS(Index = 645)]
        /* 0x8F9C */ public float PhotoModeValueAlpha;
        [NMS(Index = 675)]
        /* 0x8FA0 */ public float PirateAttackIndicatorRadius;
        [NMS(Index = 674)]
        /* 0x8FA4 */ public float PirateAttackIndicatorWidth;
        [NMS(Index = 676)]
        /* 0x8FA8 */ public float PirateAttackProbeDisplayFinishFactor;
        [NMS(Index = 673)]
        /* 0x8FAC */ public float PirateCountdownTime;
        [NMS(Index = 658)]
        /* 0x8FB0 */ public float PirateFreighterSummonAtOffset;
        [NMS(Index = 656)]
        /* 0x8FB4 */ public float PirateFreighterSummonOffset;
        [NMS(Index = 657)]
        /* 0x8FB8 */ public float PirateFreighterSummonOffsetPulse;
        [NMS(Index = 139)]
        /* 0x8FBC */ public float PlacedMarkerFadeTime;
        [NMS(Index = 129)]
        /* 0x8FC0 */ public float PlanetDataExtraRadius;
        [NMS(Index = 989)]
        /* 0x8FC4 */ public float PlanetLabelAngle;
        [NMS(Index = 988)]
        /* 0x8FC8 */ public float PlanetLabelTime;
        [NMS(Index = 1233)]
        /* 0x8FCC */ public float PlanetPoleEastWestDistanceFromPlayer;
        [NMS(Index = 1232)]
        /* 0x8FD0 */ public float PlanetPoleMaxDotProduct;
        [NMS(Index = 514)]
        /* 0x8FD4 */ public float PlanetRaidMarkerOffset;
        [NMS(Index = 688)]
        /* 0x8FD8 */ public float PlanetScanDelayTime;
        [NMS(Index = 1143)]
        /* 0x8FDC */ public float PopupActivateTime;
        [NMS(Index = 1144)]
        /* 0x8FE0 */ public float PopupDeactivateTime;
        [NMS(Index = 1142)]
        /* 0x8FE4 */ public float PopupDebounceTime;
        [NMS(Index = 1131)]
        /* 0x8FE8 */ public float PopupSlotWidthOffset;
        [NMS(Index = 85)]
        /* 0x8FEC */ public float PopupTitleGradientFactor;
        [NMS(Index = 347)]
        /* 0x8FF0 */ public float PopupValueSectionBaseHeight;
        [NMS(Index = 348)]
        /* 0x8FF4 */ public float PopupValueSectionHeight;
        [NMS(Index = 1129)]
        /* 0x8FF8 */ public float PopupXClampOffset;
        [NMS(Index = 1130)]
        /* 0x8FFC */ public float PopupXClampOffsetRightAligned;
        [NMS(Index = 198)]
        /* 0x9000 */ public float ProjectorGrabBorderPercent;
        [NMS(Index = 197)]
        /* 0x9004 */ public float ProjectorGrabDistanceBias;
        [NMS(Index = 194)]
        /* 0x9008 */ public float ProjectorGrabResetTime;
        [NMS(Index = 192)]
        /* 0x900C */ public float ProjectorScale;
        [NMS(Index = 238)]
        /* 0x9010 */ public float QuickMenuAlpha;
        [NMS(Index = 144)]
        /* 0x9014 */ public float QuickMenuCentrePos;
        [NMS(Index = 146)]
        /* 0x9018 */ public float QuickMenuCentreSideOffset;
        [NMS(Index = 586)]
        /* 0x901C */ public float QuickMenuCloseTime;
        [NMS(Index = 237)]
        /* 0x9020 */ public float QuickMenuCursorScale;
        [NMS(Index = 587)]
        /* 0x9024 */ public float QuickMenuErrorTime;
        [NMS(Index = 277)]
        /* 0x9028 */ public float QuickMenuHighlightRate;
        [NMS(Index = 278)]
        /* 0x902C */ public float QuickMenuHoldNavTime;
        [NMS(Index = 273)]
        /* 0x9030 */ public float QuickMenuInteractAdjustX;
        [NMS(Index = 274)]
        /* 0x9034 */ public float QuickMenuInteractAdjustY;
        [NMS(Index = 276)]
        /* 0x9038 */ public int QuickMenuScreenHeight;
        [NMS(Index = 275)]
        /* 0x903C */ public int QuickMenuScreenWidth;
        [NMS(Index = 145)]
        /* 0x9040 */ public float QuickMenuSideOffset;
        [NMS(Index = 269)]
        /* 0x9044 */ public float QuickMenuSwipeHeightMax;
        [NMS(Index = 268)]
        /* 0x9048 */ public float QuickMenuSwipeHeightMin;
        [NMS(Index = 1198)]
        /* 0x904C */ public float RadialMenuInnerRadius;
        [NMS(Index = 1199)]
        /* 0x9050 */ public float RadialMenuInnerRadiusCursor;
        [NMS(Index = 1200)]
        /* 0x9054 */ public float RadialMenuWedgeOffset;
        [NMS(Index = 503)]
        /* 0x9058 */ public float RefinerAutoCloseTime;
        [NMS(Index = 491)]
        /* 0x905C */ public float RefinerBeginDialInnerRadius;
        [NMS(Index = 490)]
        /* 0x9060 */ public float RefinerPadStartDecayTime;
        [NMS(Index = 489)]
        /* 0x9064 */ public float RefinerPadStartTime;
        [NMS(Index = 492)]
        /* 0x9068 */ public float RefinerProgressDialInnerRadius;
        [NMS(Index = 472)]
        /* 0x906C */ public float RepairTechLabelOffset;
        [NMS(Index = 461)]
        /* 0x9070 */ public float RepairTechRepairedMessageTime;
        [NMS(Index = 459)]
        /* 0x9074 */ public float RepairTechRepairedWaitTime1;
        [NMS(Index = 460)]
        /* 0x9078 */ public float RepairTechRepairedWaitTime2;
        [NMS(Index = 1426)]
        /* 0x907C */ public float ReportBaseFlashDelay;
        [NMS(Index = 1425)]
        /* 0x9080 */ public float ReportBaseFlashIntensity;
        [NMS(Index = 1424)]
        /* 0x9084 */ public float ReportBaseFlashTime;
        [NMS(Index = 1427)]
        /* 0x9088 */ public float ReportCameraSpeed;
        [NMS(Index = 138)]
        /* 0x908C */ public float ROGAllyFrontendZoomFactor;
        [NMS(Index = 814)]
        /* 0x9090 */ public float ScanEventArrowOffsetMultiplier;
        [NMS(Index = 816)]
        /* 0x9094 */ public float ScanEventArrowOffsetMultiplierFresh;
        [NMS(Index = 817)]
        /* 0x9098 */ public float ScanEventArrowOffsetMultiplierLerpTime;
        [NMS(Index = 815)]
        /* 0x909C */ public float ScanEventArrowOffsetMultiplierOneEvent;
        [NMS(Index = 813)]
        /* 0x90A0 */ public float ScanEventArrowPlayerFadeDistance;
        [NMS(Index = 812)]
        /* 0x90A4 */ public float ScanEventArrowPlayerFadeRange;
        [NMS(Index = 818)]
        /* 0x90A8 */ public float ScanEventArrowSecondaryAlpha;
        [NMS(Index = 811)]
        /* 0x90AC */ public float ScanEventArrowShipFadeDistance;
        [NMS(Index = 810)]
        /* 0x90B0 */ public float ScanEventArrowShipFadeRange;
        [NMS(Index = 819)]
        /* 0x90B4 */ public GcAudioWwiseEvents ScanEventIconAudio;
        [NMS(Index = 377)]
        /* 0x90B8 */ public float ScannableIconMergeAngle;
        [NMS(Index = 1102)]
        /* 0x90BC */ public float ScanTime;
        [NMS(Index = 118)]
        /* 0x90C0 */ public float SeasonalRingChangeTime;
        [NMS(Index = 116)]
        /* 0x90C4 */ public float SeasonalRingMultiplier;
        [NMS(Index = 117)]
        /* 0x90C8 */ public float SeasonalRingPulseTime;
        [NMS(Index = 49)]
        /* 0x90CC */ public float SeasonEndAutoHighlightDuration;
        [NMS(Index = 50)]
        /* 0x90D0 */ public float SeasonEndAutoHighlightDurationMilestone;
        [NMS(Index = 48)]
        /* 0x90D4 */ public GcAudioWwiseEvents SeasonEndAutoHighlightSFX;
        [NMS(Index = 47)]
        /* 0x90D8 */ public float SeasonEndRewardsMaxScrollRate;
        [NMS(Index = 46)]
        /* 0x90DC */ public float SeasonEndRewardsPageOpenDelayTime;
        [NMS(Index = 902)]
        /* 0x90E0 */ public float SeasonMessageDelayTime;
        [NMS(Index = 108)]
        /* 0x90E4 */ public float SentinelsDisabledHUDMessageTime;
        [NMS(Index = 1441)]
        /* 0x90E8 */ public float SettlementStatFlashSpeed;
        [NMS(Index = 1442)]
        /* 0x90EC */ public float SettlementStatInnerRadius;
        [NMS(Index = 1443)]
        /* 0x90F0 */ public float SettlementStatOuterRadius;
        [NMS(Index = 1047)]
        /* 0x90F4 */ public float ShieldHazardPulseRate;
        [NMS(Index = 1049)]
        /* 0x90F8 */ public float ShieldHazardPulseThreshold;
        [NMS(Index = 1046)]
        /* 0x90FC */ public float ShieldPulseTime;
        [NMS(Index = 1045)]
        /* 0x9100 */ public float ShieldSpringTime;
        [NMS(Index = 15)]
        /* 0x9104 */ public float ShipBuilderBarTime;
        [NMS(Index = 22)]
        /* 0x9108 */ public float ShipBuilderEndCircleRadius;
        [NMS(Index = 26)]
        /* 0x910C */ public float ShipBuilderLineLengthFadeMax;
        [NMS(Index = 25)]
        /* 0x9110 */ public float ShipBuilderLineLengthFadeMin;
        [NMS(Index = 24)]
        /* 0x9114 */ public float ShipBuilderLineMinFade;
        [NMS(Index = 23)]
        /* 0x9118 */ public float ShipBuilderLineWidth;
        [NMS(Index = 20)]
        /* 0x911C */ public float ShipBuilderSlotDropLength;
        [NMS(Index = 16)]
        /* 0x9120 */ public float ShipBuilderSlotLineDefaultWidthFactor;
        [NMS(Index = 18)]
        /* 0x9124 */ public float ShipBuilderSlotLineMaxFactor;
        [NMS(Index = 17)]
        /* 0x9128 */ public float ShipBuilderSlotLineMinFactor;
        [NMS(Index = 19)]
        /* 0x912C */ public float ShipBuilderSlotStartOffset;
        [NMS(Index = 21)]
        /* 0x9130 */ public float ShipBuilderStartCircleRadius;
        [NMS(Index = 541)]
        /* 0x9134 */ public float ShipDamageDirectionIndicatorFadeRange;
        [NMS(Index = 540)]
        /* 0x9138 */ public float ShipDamageDirectionIndicatorRadius;
        [NMS(Index = 808)]
        /* 0x913C */ public float ShipDesatDamper;
        [NMS(Index = 807)]
        /* 0x9140 */ public float ShipFullscreenDamper;
        [NMS(Index = 806)]
        /* 0x9144 */ public float ShipFullscreenDamperMin;
        [NMS(Index = 698)]
        /* 0x9148 */ public float ShipHeadsUpDisplayDistance;
        [NMS(Index = 699)]
        /* 0x914C */ public float ShipHeadsUpLineFadeTime;
        [NMS(Index = 322)]
        /* 0x9150 */ public float ShipHologramInWorldUIHeightAdjust;
        [NMS(Index = 323)]
        /* 0x9154 */ public float ShipHologramInWorldUIHeightAdjustV2;
        [NMS(Index = 1027)]
        /* 0x9158 */ public float ShipHUDHitPointSize;
        [NMS(Index = 1026)]
        /* 0x915C */ public float ShipHUDHitPointTime;
        [NMS(Index = 160)]
        /* 0x9160 */ public float ShipHUDMarkerHideDistance;
        [NMS(Index = 161)]
        /* 0x9164 */ public float ShipHUDMarkerOffset;
        [NMS(Index = 1011)]
        /* 0x9168 */ public float ShipHUDMaxOffscreenTargetDist;
        [NMS(Index = 1008)]
        /* 0x916C */ public float ShipHUDMissileLockSizeMax;
        [NMS(Index = 1007)]
        /* 0x9170 */ public float ShipHUDMissileLockSizeMin;
        [NMS(Index = 1010)]
        /* 0x9174 */ public float ShipHUDMissileLockSpringFast;
        [NMS(Index = 1009)]
        /* 0x9178 */ public float ShipHUDMissileLockSpringSlow;
        [NMS(Index = 1014)]
        /* 0x917C */ public float ShipHUDTargetAlpha;
        [NMS(Index = 1015)]
        /* 0x9180 */ public float ShipHUDTargetArrowLength;
        [NMS(Index = 1019)]
        /* 0x9184 */ public float ShipHUDTargetArrowsRotationRate;
        [NMS(Index = 1016)]
        /* 0x9188 */ public float ShipHUDTargetMinDist;
        [NMS(Index = 1012)]
        /* 0x918C */ public float ShipHUDTargetRadius;
        [NMS(Index = 1017)]
        /* 0x9190 */ public float ShipHUDTargetRange;
        [NMS(Index = 1018)]
        /* 0x9194 */ public float ShipHUDTargetScale;
        [NMS(Index = 1013)]
        /* 0x9198 */ public float ShipHUDTargetTriangleRadius;
        [NMS(Index = 526)]
        /* 0x919C */ public float ShipOverheatSwitchMessageTime;
        [NMS(Index = 525)]
        /* 0x91A0 */ public float ShipOverheatSwitchMessageWait;
        [NMS(Index = 1434)]
        /* 0x91A4 */ public float ShipScreenTexScale;
        [NMS(Index = 260)]
        /* 0x91A8 */ public float ShipSideScreenHeight;
        [NMS(Index = 10)]
        /* 0x91AC */ public float ShipTeleportPadMarkerDistance;
        [NMS(Index = 9)]
        /* 0x91B0 */ public float ShipTeleportPadMinDistance;
        [NMS(Index = 324)]
        /* 0x91B4 */ public float ShopInteractionInWorldForcedOffset;
        [NMS(Index = 325)]
        /* 0x91B8 */ public float ShopInteractionInWorldForcedOffsetV2;
        [NMS(Index = 125)]
        /* 0x91BC */ public int ShowDaysIfLessThan;
        [NMS(Index = 124)]
        /* 0x91C0 */ public int ShowHoursIfLessThan;
        [NMS(Index = 126)]
        /* 0x91C4 */ public int ShowWeeksIfLessThan;
        [NMS(Index = 744)]
        /* 0x91C8 */ public float SmallSpaceIconSize;
        [NMS(Index = 262)]
        /* 0x91CC */ public float SolidPointerLengthScale;
        [NMS(Index = 263)]
        /* 0x91D0 */ public float SolidPointerMaxLength;
        [NMS(Index = 261)]
        /* 0x91D4 */ public float SolidPointerScale;
        [NMS(Index = 1267)]
        /* 0x91D8 */ public float SpaceMapActionScale;
        [NMS(Index = 1263)]
        /* 0x91DC */ public float SpaceMapAnomalyScale;
        [NMS(Index = 1253)]
        /* 0x91E0 */ public float SpaceMapAspectRatio;
        [NMS(Index = 1279)]
        /* 0x91E4 */ public float SpaceMapCamAngle;
        [NMS(Index = 1280)]
        /* 0x91E8 */ public float SpaceMapCamDistance;
        [NMS(Index = 1278)]
        /* 0x91EC */ public float SpaceMapCamHeight;
        [NMS(Index = 564)]
        /* 0x91F0 */ public float SpaceMapCockpitAngle;
        [NMS(Index = 553)]
        /* 0x91F4 */ public float SpaceMapCockpitScale;
        [NMS(Index = 560)]
        /* 0x91F8 */ public float SpaceMapCockpitScaleAdjustAlien;
        [NMS(Index = 562)]
        /* 0x91FC */ public float SpaceMapCockpitScaleAdjustCorvette;
        [NMS(Index = 554)]
        /* 0x9200 */ public float SpaceMapCockpitScaleAdjustDropShip;
        [NMS(Index = 555)]
        /* 0x9204 */ public float SpaceMapCockpitScaleAdjustFighter;
        [NMS(Index = 561)]
        /* 0x9208 */ public float SpaceMapCockpitScaleAdjustRobot;
        [NMS(Index = 558)]
        /* 0x920C */ public float SpaceMapCockpitScaleAdjustRoyal;
        [NMS(Index = 559)]
        /* 0x9210 */ public float SpaceMapCockpitScaleAdjustSail;
        [NMS(Index = 556)]
        /* 0x9214 */ public float SpaceMapCockpitScaleAdjustScientific;
        [NMS(Index = 557)]
        /* 0x9218 */ public float SpaceMapCockpitScaleAdjustShuttle;
        [NMS(Index = 563)]
        /* 0x921C */ public float SpaceMapCockpitScaleAdjustSwarmDrone;
        [NMS(Index = 1272)]
        /* 0x9220 */ public float SpaceMapDistance;
        [NMS(Index = 1255)]
        /* 0x9224 */ public float SpaceMapDistanceLogScaler;
        [NMS(Index = 1274)]
        /* 0x9228 */ public float SpaceMapDistanceMultiplier;
        [NMS(Index = 1254)]
        /* 0x922C */ public float SpaceMapDistanceScale;
        [NMS(Index = 1277)]
        /* 0x9230 */ public float SpaceMapFadeAngleMax;
        [NMS(Index = 1276)]
        /* 0x9234 */ public float SpaceMapFadeAngleMin;
        [NMS(Index = 1252)]
        /* 0x9238 */ public float SpaceMapFoV;
        [NMS(Index = 1261)]
        /* 0x923C */ public float SpaceMapFreighterScale;
        [NMS(Index = 1275)]
        /* 0x9240 */ public float SpaceMapHorizonThickness;
        [NMS(Index = 1282)]
        /* 0x9244 */ public float SpaceMapLightPitch;
        [NMS(Index = 1283)]
        /* 0x9248 */ public float SpaceMapLightYaw;
        [NMS(Index = 1236)]
        /* 0x924C */ public float SpaceMapLineBaseFade;
        [NMS(Index = 1235)]
        /* 0x9250 */ public float SpaceMapLineBaseScale;
        [NMS(Index = 1234)]
        /* 0x9254 */ public float SpaceMapLineWidth;
        [NMS(Index = 1271)]
        /* 0x9258 */ public float SpaceMapMarkerScale;
        [NMS(Index = 1273)]
        /* 0x925C */ public float SpaceMapMaxTraderDistance;
        [NMS(Index = 1266)]
        /* 0x9260 */ public float SpaceMapMoonScale;
        [NMS(Index = 1260)]
        /* 0x9264 */ public float SpaceMapObjectScale;
        [NMS(Index = 1270)]
        /* 0x9268 */ public float SpaceMapPirateFreighterScale;
        [NMS(Index = 1269)]
        /* 0x926C */ public float SpaceMapPirateFrigateScale;
        [NMS(Index = 1265)]
        /* 0x9270 */ public float SpaceMapPlanetLineOffset;
        [NMS(Index = 1264)]
        /* 0x9274 */ public float SpaceMapPlanetScale;
        [NMS(Index = 1257)]
        /* 0x9278 */ public float SpaceMapScaleMin;
        [NMS(Index = 1259)]
        /* 0x927C */ public float SpaceMapScaleRangeMax;
        [NMS(Index = 1258)]
        /* 0x9280 */ public float SpaceMapScaleRangeMin;
        [NMS(Index = 1237)]
        /* 0x9284 */ public float SpaceMapShipCombineDistance;
        [NMS(Index = 1268)]
        /* 0x9288 */ public float SpaceMapShipScale;
        [NMS(Index = 1281)]
        /* 0x928C */ public float SpaceMapShipScaleMin;
        [NMS(Index = 1262)]
        /* 0x9290 */ public float SpaceMapStationScale;
        [NMS(Index = 742)]
        /* 0x9294 */ public float SpaceMarkersBattleOffset;
        [NMS(Index = 741)]
        /* 0x9298 */ public float SpaceMarkersOffset;
        [NMS(Index = 132)]
        /* 0x929C */ public float StackSizeChangeMaxRate;
        [NMS(Index = 131)]
        /* 0x92A0 */ public float StackSizeChangeMinRate;
        [NMS(Index = 130)]
        /* 0x92A4 */ public float StackSizeRateChangeRate;
        [NMS(Index = 122)]
        /* 0x92A8 */ public float StageStingDisplayTime;
        [NMS(Index = 534)]
        /* 0x92AC */ public float StandingRewardOSDTime;
        [NMS(Index = 901)]
        /* 0x92B0 */ public float StatsMessageDelayTime;
        [NMS(Index = 137)]
        /* 0x92B4 */ public float SteamDeckFrontendZoomFactor;
        [NMS(Index = 1469)]
        /* 0x92B8 */ public float SteamDeckMinFontHeight;
        [NMS(Index = 36)]
        /* 0x92BC */ public float StoreDialDecayTime;
        [NMS(Index = 35)]
        /* 0x92C0 */ public float StoreDialHoldTime;
        [NMS(Index = 37)]
        /* 0x92C4 */ public float StoreDialInnerRadius;
        [NMS(Index = 38)]
        /* 0x92C8 */ public float StoreDialOuterRadius;
        [NMS(Index = 91)]
        /* 0x92CC */ public float SuperchargeGradientFactor;
        [NMS(Index = 90)]
        /* 0x92D0 */ public float SuperchargeGradientFactorMin;
        [NMS(Index = 92)]
        /* 0x92D4 */ public float SuperchargeGradientTime;
        [NMS(Index = 809)]
        /* 0x92D8 */ public float SurveyObjectArrowOffsetMultiplier;
        [NMS(Index = 365)]
        /* 0x92DC */ public float TakeoffFuelMessageTime;
        [NMS(Index = 595)]
        /* 0x92E0 */ public float TalkBoxAlienTextSpeed;
        [NMS(Index = 597)]
        /* 0x92E4 */ public float TalkBoxAlienTextTimeMax;
        [NMS(Index = 596)]
        /* 0x92E8 */ public float TalkBoxAlienTextTimeMin;
        [NMS(Index = 570)]
        /* 0x92EC */ public float TargetDisplayDamageFlashTime;
        [NMS(Index = 565)]
        /* 0x92F0 */ public float TargetDisplayScale;
        [NMS(Index = 567)]
        /* 0x92F4 */ public float TargetDisplayShipScale;
        [NMS(Index = 566)]
        /* 0x92F8 */ public float TargetDisplayTorpedoScale;
        [NMS(Index = 1225)]
        /* 0x92FC */ public float TargetMarkerFadeAngleMin;
        [NMS(Index = 1226)]
        /* 0x9300 */ public float TargetMarkerFadeAngleRange;
        [NMS(Index = 1224)]
        /* 0x9304 */ public float TargetMarkerScaleEnd;
        [NMS(Index = 1223)]
        /* 0x9308 */ public float TargetMarkerScaleStart;
        [NMS(Index = 1408)]
        /* 0x930C */ public float TargetParallaxMaintenancePageMultiplier;
        [NMS(Index = 1407)]
        /* 0x9310 */ public float TargetParallaxMouseMultiplier;
        [NMS(Index = 1029)]
        /* 0x9314 */ public float TargetScreenDistance;
        [NMS(Index = 1028)]
        /* 0x9318 */ public float TargetScreenFoV;
        [NMS(Index = 824)]
        /* 0x931C */ public float TechDisplayDelayTime;
        [NMS(Index = 464)]
        /* 0x9320 */ public float TechPopupBuildLayerHeight;
        [NMS(Index = 462)]
        /* 0x9324 */ public float TechPopupInstallLayerHeight;
        [NMS(Index = 463)]
        /* 0x9328 */ public float TechPopupRepairLayerHeight;
        [NMS(Index = 465)]
        /* 0x932C */ public float TechPopupRequirementHeight;
        [NMS(Index = 1431)]
        /* 0x9330 */ public float TextChatMaxDisplayTime;
        [NMS(Index = 1432)]
        /* 0x9334 */ public float TextChatStayBigAfterTextInput;
        [NMS(Index = 201)]
        /* 0x9338 */ public float TextPrintoutMultiplier;
        [NMS(Index = 202)]
        /* 0x933C */ public float TextPrintoutMultiplierAlien;
        [NMS(Index = 31)]
        /* 0x9340 */ public float TextTouchScrollCap;
        [NMS(Index = 787)]
        /* 0x9344 */ public float ThirdPersonCrosshairCircle1Distance;
        [NMS(Index = 788)]
        /* 0x9348 */ public float ThirdPersonCrosshairCircle2Distance;
        [NMS(Index = 786)]
        /* 0x934C */ public float ThirdPersonCrosshairDistance;
        [NMS(Index = 610)]
        /* 0x9350 */ public float TimedEventLookTime;
        [NMS(Index = 951)]
        /* 0x9354 */ public float TooltipTime;
        [NMS(Index = 32)]
        /* 0x9358 */ public float TouchScrollChangePageThreshold;
        [NMS(Index = 29)]
        /* 0x935C */ public float TouchScrollMaxDelta;
        [NMS(Index = 30)]
        /* 0x9360 */ public float TouchScrollSpeedMul;
        [NMS(Index = 693)]
        /* 0x9364 */ public float TrackArrowDistanceSpacePOI;
        [NMS(Index = 784)]
        /* 0x9368 */ public float TrackCriticalHitSize;
        [NMS(Index = 785)]
        /* 0x936C */ public float TrackCriticalPulseTime;
        [NMS(Index = 760)]
        /* 0x9370 */ public float TrackLeadTargetInScale;
        [NMS(Index = 757)]
        /* 0x9374 */ public float TrackMissileTargetPulseRate;
        [NMS(Index = 750)]
        /* 0x9378 */ public float TrackPoliceFreighterCentreOffset;
        [NMS(Index = 749)]
        /* 0x937C */ public float TrackPrimaryCentreOffset;
        [NMS(Index = 762)]
        /* 0x9380 */ public float TrackReticuleAngle;
        [NMS(Index = 764)]
        /* 0x9384 */ public float TrackReticuleInactiveTime;
        [NMS(Index = 763)]
        /* 0x9388 */ public float TrackReticuleInTime;
        [NMS(Index = 766)]
        /* 0x938C */ public float TrackReticuleRandomDelay;
        [NMS(Index = 765)]
        /* 0x9390 */ public float TrackReticuleRandomTime;
        [NMS(Index = 761)]
        /* 0x9394 */ public float TrackReticuleScale;
        [NMS(Index = 758)]
        /* 0x9398 */ public float TrackScaleCritical;
        [NMS(Index = 759)]
        /* 0x939C */ public float TrackScaleHit;
        [NMS(Index = 751)]
        /* 0x93A0 */ public float TrackTimerAlpha;
        [NMS(Index = 755)]
        /* 0x93A4 */ public float TrackTimerIconExclaimRadius;
        [NMS(Index = 754)]
        /* 0x93A8 */ public float TrackTimerIconInnerRadius;
        [NMS(Index = 753)]
        /* 0x93AC */ public float TrackTimerIconOuterRadius;
        [NMS(Index = 752)]
        /* 0x93B0 */ public float TrackTimerRadarPulseSize;
        [NMS(Index = 748)]
        /* 0x93B4 */ public float TrackTypeIconSize;
        [NMS(Index = 34)]
        /* 0x93B8 */ public float TradePageNotifyOffset;
        [NMS(Index = 376)]
        /* 0x93BC */ public float TransferPopupCursorOffsetFactor;
        [NMS(Index = 609)]
        /* 0x93C0 */ public float TransferSendOffscreenBorder;
        [NMS(Index = 515)]
        /* 0x93C4 */ public float TransitionOffset;
        [NMS(Index = 327)]
        /* 0x93C8 */ public float TravelLineThickness;
        [NMS(Index = 326)]
        /* 0x93CC */ public float TravelTargetRadius;
        [NMS(Index = 41)]
        /* 0x93D0 */ public float TrialUpsellDeclineDecayTimeQuick;
        [NMS(Index = 43)]
        /* 0x93D4 */ public float TrialUpsellDeclineDecayTimeSlow;
        [NMS(Index = 44)]
        /* 0x93D8 */ public float TrialUpsellDeclineDialInnerRadius;
        [NMS(Index = 45)]
        /* 0x93DC */ public float TrialUpsellDeclineDialOuterRadius;
        [NMS(Index = 40)]
        /* 0x93E0 */ public float TrialUpsellDeclineHoldTimeQuick;
        [NMS(Index = 42)]
        /* 0x93E4 */ public float TrialUpsellDeclineHoldTimeSlow;
        [NMS(Index = 106)]
        /* 0x93E8 */ public int UnknownWordsToShowInCatalogue;
        [NMS(Index = 1471)]
        /* 0x93EC */ public float UnlockableTreeDefaultGroupGap;
        [NMS(Index = 1473)]
        /* 0x93F0 */ public float UnlockableTreeDefaultRowGap;
        [NMS(Index = 1472)]
        /* 0x93F4 */ public float UnlockableTreeNarrowGroupGap;
        [NMS(Index = 1474)]
        /* 0x93F8 */ public float UnlockableTreeNarrowRowGap;
        [NMS(Index = 109)]
        /* 0x93FC */ public float UseZoomedOutBuildCamRadius;
        [NMS(Index = 222)]
        /* 0x9400 */ public int VRFaceLockedScreenHeight;
        [NMS(Index = 221)]
        /* 0x9404 */ public int VRFaceLockedScreenWidth;
        [NMS(Index = 363)]
        /* 0x9408 */ public float WantedDetectMessageTime;
        [NMS(Index = 364)]
        /* 0x940C */ public float WantedDetectMinTimeout;
        [NMS(Index = 897)]
        /* 0x9410 */ public float WantedLevelScanAlpha;
        [NMS(Index = 898)]
        /* 0x9414 */ public float WantedLevelScannedRate;
        [NMS(Index = 895)]
        /* 0x9418 */ public float WantedLevelTimeoutPulseRate;
        [NMS(Index = 896)]
        /* 0x941C */ public float WantedLevelWitnessAlpha;
        [NMS(Index = 894)]
        /* 0x9420 */ public float WantedLevelWitnessOffset;
        [NMS(Index = 893)]
        /* 0x9424 */ public float WantedLevelWitnessPulseRate;
        [NMS(Index = 1454)]
        /* 0x9428 */ public float WinGDKHandheldPopupScale;
        [NMS(Index = 135)]
        /* 0x942C */ public float ZoomFactorOverride;
        [NMS(Index = 963)]
        /* 0x9430 */ public float ZoomHUDElementsOffsetX;
        [NMS(Index = 964)]
        /* 0x9434 */ public float ZoomHUDElementsOffsetY;
        [NMS(Index = 965)]
        /* 0x9438 */ public float ZoomHUDElementTime;
        [NMS(Index = 1327)]
        /* 0x943C */ public NMSString0x100 HUDCircleAnimIcon;
        [NMS(Index = 1325)]
        /* 0x953C */ public NMSString0x100 HUDDeathPointIcon;
        [NMS(Index = 1326)]
        /* 0x963C */ public NMSString0x100 HUDHexAnimIcon;
        [NMS(Index = 1321)]
        /* 0x973C */ public NMSString0x100 HUDMarkerColourIcon;
        [NMS(Index = 1319)]
        /* 0x983C */ public NMSString0x100 HUDMarkerIcon;
        [NMS(Index = 1320)]
        /* 0x993C */ public NMSString0x100 HUDMarkerPrimaryIndicatorIcon;
        [NMS(Index = 1322)]
        /* 0x9A3C */ public NMSString0x100 HUDPointIcon;
        [NMS(Index = 1324)]
        /* 0x9B3C */ public NMSString0x100 HUDSaveIcon;
        [NMS(Index = 1323)]
        /* 0x9C3C */ public NMSString0x100 HUDSpaceshipIcon;
        [NMS(Index = 961)]
        /* 0x9D3C */ public NMSString0x20 DistanceUnitKM;
        [NMS(Index = 960)]
        /* 0x9D5C */ public NMSString0x20 DistanceUnitM;
        [NMS(Index = 962)]
        /* 0x9D7C */ public NMSString0x20 DistanceUnitMpS;
        [NMS(Index = 524)]
        /* 0x9D9C */ public NMSString0x20 MaxDialogCharSizeIdeographicString;
        [NMS(Index = 522)]
        /* 0x9DBC */ public NMSString0x20 MaxDialogCharSizeRomanString;
        [NMS(Index = 218)]
        /* 0x9DDC */ public NMSString0x20 VRDistanceWarningUIFile;
        [NMS(Index = 410, Size = 0x15, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x9DFC */ public bool[] BuildMenuUseSmallIconOnPad;
        [NMS(Index = 1467)]
        /* 0x9E11 */ public bool AllowInventorySorting;
        [NMS(Index = 204)]
        /* 0x9E12 */ public bool AllowInWorldDebugBorders;
        [NMS(Index = 195)]
        /* 0x9E13 */ public bool AllowProjectorRepositioning;
        [NMS(Index = 334)]
        /* 0x9E14 */ public bool AlwaysCloseQuickMenu;
        [NMS(Index = 687)]
        /* 0x9E15 */ public TkCurveType ArrowBounceLeftCurve;
        [NMS(Index = 683)]
        /* 0x9E16 */ public TkCurveType ArrowBounceRightCurve;
        [NMS(Index = 111)]
        /* 0x9E17 */ public bool AutoScrollParagraphs;
        [NMS(Index = 438)]
        /* 0x9E18 */ public bool BaseBuildingSmoothMenuWhileSnapped;
        [NMS(Index = 99)]
        /* 0x9E19 */ public bool BigPicking;
        [NMS(Index = 100)]
        /* 0x9E1A */ public bool BigPickingUsesNumbers;
        [NMS(Index = 179)]
        /* 0x9E1B */ public bool BinocularScanScreen;
        [NMS(Index = 399)]
        /* 0x9E1C */ public TkCurveType CompassCurve;
        [NMS(Index = 772)]
        /* 0x9E1D */ public bool CreatureInteractLabelUseBB;
        [NMS(Index = 771)]
        /* 0x9E1E */ public TkCurveType CreatureReticuleAlphaCurve;
        [NMS(Index = 770)]
        /* 0x9E1F */ public TkCurveType CreatureReticuleScaleCurve;
        [NMS(Index = 711)]
        /* 0x9E20 */ public TkCurveType CrosshairLeadScaleCurve;
        [NMS(Index = 729)]
        /* 0x9E21 */ public TkCurveType CrosshairTargetLockAlphaCurve;
        [NMS(Index = 728)]
        /* 0x9E22 */ public TkCurveType CrosshairTargetLockCurve;
        [NMS(Index = 638)]
        /* 0x9E23 */ public TkCurveType DamageNumberUpCurve;
        [NMS(Index = 340)]
        /* 0x9E24 */ public bool DebugInventoryIndices;
        [NMS(Index = 583)]
        /* 0x9E25 */ public bool DebugMarkerLabels;
        [NMS(Index = 337)]
        /* 0x9E26 */ public bool DebugMissionLogText;
        [NMS(Index = 339)]
        /* 0x9E27 */ public bool DebugPopupSizes;
        [NMS(Index = 338)]
        /* 0x9E28 */ public bool DebugShowMaintenanceScreenCentre;
        [NMS(Index = 1452)]
        /* 0x9E29 */ public bool EnableAccessibleUIOnSwitch;
        [NMS(Index = 468)]
        /* 0x9E2A */ public bool EnableBlackouts;
        [NMS(Index = 828)]
        /* 0x9E2B */ public bool EnableBuilderRobotGreekConversion;
        [NMS(Index = 266)]
        /* 0x9E2C */ public bool EnableCraftingTree;
        [NMS(Index = 203)]
        /* 0x9E2D */ public bool EnableHandMenuButtons;
        [NMS(Index = 235)]
        /* 0x9E2E */ public bool EnableHandMenuDebug;
        [NMS(Index = 829)]
        /* 0x9E2F */ public bool EnableKanaConversion;
        [NMS(Index = 104)]
        /* 0x9E30 */ public bool EnablePopupUses;
        [NMS(Index = 341)]
        /* 0x9E31 */ public bool FixedInventoryIconPositions;
        [NMS(Index = 1141)]
        /* 0x9E32 */ public TkCurveType FrontendBootBarCurve;
        [NMS(Index = 1126)]
        /* 0x9E33 */ public TkCurveType FrontendConfirmCurve;
        [NMS(Index = 1213)]
        /* 0x9E34 */ public TkCurveType FrontendDoFCurve;
        [NMS(Index = 903)]
        /* 0x9E35 */ public bool HideExtremePlanetNotifications;
        [NMS(Index = 1429)]
        /* 0x9E36 */ public bool HideQuickMenuControls;
        [NMS(Index = 1362)]
        /* 0x9E37 */ public TkCurveType HUDMarkerActiveCurve;
        [NMS(Index = 1332)]
        /* 0x9E38 */ public TkCurveType HUDMarkerAnimAlphaCurve;
        [NMS(Index = 1333)]
        /* 0x9E39 */ public TkCurveType HUDMarkerAnimCurve;
        [NMS(Index = 861)]
        /* 0x9E3A */ public TkCurveType HUDPlayerTrackArrowEnergyShieldDepletedCurve;
        [NMS(Index = 866)]
        /* 0x9E3B */ public TkCurveType HUDPlayerTrackArrowEnergyShieldStartChargeCurve;
        [NMS(Index = 316)]
        /* 0x9E3C */ public bool InteractionInWorldPlayerCamAlways;
        [NMS(Index = 1006)]
        /* 0x9E3D */ public TkCurveType InteractionScanSlapCurve;
        [NMS(Index = 527)]
        /* 0x9E3E */ public bool LeadTargetEnabled;
        [NMS(Index = 1033)]
        /* 0x9E3F */ public bool ModelRendererBGPass;
        [NMS(Index = 1034)]
        /* 0x9E40 */ public bool ModelRendererPass1;
        [NMS(Index = 1035)]
        /* 0x9E41 */ public bool ModelRendererPass2;
        [NMS(Index = 1410)]
        /* 0x9E42 */ public TkCurveType NGuiModelViewFadeInAfterRenderCurve;
        [NMS(Index = 1411)]
        /* 0x9E43 */ public bool NGuiUseSeparateLayersForModelAndReflection;
        [NMS(Index = 223)]
        /* 0x9E44 */ public bool OnlyShowEjectHandlesInVR;
        [NMS(Index = 79)]
        /* 0x9E45 */ public TkCurveType PadCursorUICurve;
        [NMS(Index = 517)]
        /* 0x9E46 */ public TkCurveType PageTurnCurve;
        [NMS(Index = 518)]
        /* 0x9E47 */ public TkCurveType PageTurnFadeCurve;
        [NMS(Index = 1145)]
        /* 0x9E48 */ public TkCurveType PopupActivateCurve1;
        [NMS(Index = 1146)]
        /* 0x9E49 */ public TkCurveType PopupActivateCurve2;
        [NMS(Index = 572)]
        /* 0x9E4A */ public bool ProgressiveDialogStyle;
        [NMS(Index = 1430)]
        /* 0x9E4B */ public bool QuickMenuAllowCycle;
        [NMS(Index = 267)]
        /* 0x9E4C */ public bool QuickMenuEnableSwipe;
        [NMS(Index = 336)]
        /* 0x9E4D */ public bool RepairTechUseTechIcon;
        [NMS(Index = 95)]
        /* 0x9E4E */ public bool ReplaceItemBarWithNumbers;
        [NMS(Index = 1048)]
        /* 0x9E4F */ public bool ShieldHUDAlwaysOn;
        [NMS(Index = 585)]
        /* 0x9E50 */ public bool ShowDamageNumbers;
        [NMS(Index = 64)]
        /* 0x9E51 */ public bool ShowDifficultyForBases;
        [NMS(Index = 900)]
        /* 0x9E52 */ public bool ShowJetpackNotificationForNonTerrain;
        [NMS(Index = 617)]
        /* 0x9E53 */ public bool ShowOnscreenPredatorMarkers;
        [NMS(Index = 65)]
        /* 0x9E54 */ public bool ShowPadlockForLockedSettings;
        [NMS(Index = 219)]
        /* 0x9E55 */ public bool ShowVRDistanceWarning;
        [NMS(Index = 134)]
        /* 0x9E56 */ public bool SkipShopIntro;
        [NMS(Index = 1256)]
        /* 0x9E57 */ public TkCurveType SpaceMapDistanceCurve;
        [NMS(Index = 1242)]
        /* 0x9E58 */ public bool SpaceMapShowAnomaly;
        [NMS(Index = 1243)]
        /* 0x9E59 */ public bool SpaceMapShowAnomalyLines;
        [NMS(Index = 1249)]
        /* 0x9E5A */ public bool SpaceMapShowFrieghterLines;
        [NMS(Index = 1248)]
        /* 0x9E5B */ public bool SpaceMapShowFrieghters;
        [NMS(Index = 1244)]
        /* 0x9E5C */ public bool SpaceMapShowNexus;
        [NMS(Index = 1245)]
        /* 0x9E5D */ public bool SpaceMapShowNexusLines;
        [NMS(Index = 1239)]
        /* 0x9E5E */ public bool SpaceMapShowPlanetLines;
        [NMS(Index = 1238)]
        /* 0x9E5F */ public bool SpaceMapShowPlanets;
        [NMS(Index = 1251)]
        /* 0x9E60 */ public bool SpaceMapShowPulseEncounterLines;
        [NMS(Index = 1250)]
        /* 0x9E61 */ public bool SpaceMapShowPulseEncounters;
        [NMS(Index = 1247)]
        /* 0x9E62 */ public bool SpaceMapShowShipLines;
        [NMS(Index = 1246)]
        /* 0x9E63 */ public bool SpaceMapShowShips;
        [NMS(Index = 1240)]
        /* 0x9E64 */ public bool SpaceMapShowStation;
        [NMS(Index = 1241)]
        /* 0x9E65 */ public bool SpaceMapShowStationLines;
        [NMS(Index = 528)]
        /* 0x9E66 */ public bool SpaceOnlyLeadTargetEnabled;
        [NMS(Index = 105)]
        /* 0x9E67 */ public bool TechBoxesCanStack;
        [NMS(Index = 782)]
        /* 0x9E68 */ public TkCurveType TrackCritCurve;
        [NMS(Index = 768)]
        /* 0x9E69 */ public TkCurveType TrackReticuleInAngleCurve;
        [NMS(Index = 767)]
        /* 0x9E6A */ public TkCurveType TrackReticuleInCurve;
        [NMS(Index = 1115)]
        /* 0x9E6B */ public bool UseCursorHoverSlowFixedValue;
        [NMS(Index = 107)]
        /* 0x9E6C */ public bool UseIntermediateMissionGiverOptions;
        [NMS(Index = 834)]
        /* 0x9E6D */ public bool UseNamesOnShipHUD;
        [NMS(Index = 98)]
        /* 0x9E6E */ public bool UseSquareSlots;
        [NMS(Index = 335)]
        /* 0x9E6F */ public bool UseWorldNodesForRepair;
    }
}
