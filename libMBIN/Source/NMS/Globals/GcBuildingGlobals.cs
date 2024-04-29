using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xE98BF65915D1D310, NameHash = 0xCFD86CFD7BD870B1)]
    public class GcBuildingGlobals : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0000 */ public Vector3f BuildingPartPreviewOffset;
        [NMS(Index = 107)]
        /* 0x0010 */ public Colour MarkerLineColour;
        [NMS(Index = 14, Size = 0x10, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x0020 */ public GcBuildMenuIconSet[] Icons;
        [NMS(Index = 13)]
        /* 0x10A0 */ public TkTextureResource ScreenSpaceRotationGlow;
        [NMS(Index = 12)]
        /* 0x1124 */ public TkTextureResource ScreenSpaceRotationIcon;
        [NMS(Index = 10, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x11A8 */ public TkLODDistances[] ActiveLodDistances;
        [NMS(Index = 11, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x11F8 */ public TkLODDistances[] InactiveLodDistances;
        [NMS(Index = 169, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x1248 */ public float[] TotalPlanetFrameTimeForComplexity;
        [NMS(Index = 170, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x1258 */ public float[] TotalSpaceFrameTimeForComplexity;
        [NMS(Index = 166)]
        /* 0x1268 */ public Vector2f BuildingPlacementScaleMinMax;
        [NMS(Index = 68)]
        /* 0x1270 */ public float AddToRadius_DoNotPlaceClose;
        [NMS(Index = 108)]
        /* 0x1274 */ public float AmountToMoveMarkerRoundSphere;
        [NMS(Index = 183)]
        /* 0x1278 */ public float BaseBuildingTerrainEditBaseYOffset;
        [NMS(Index = 185)]
        /* 0x127C */ public float BaseBuildingTerrainEditBoundsScalar;
        [NMS(Index = 184)]
        /* 0x1280 */ public float BaseBuildingTerrainEditTopYOffset;
        [NMS(Index = 187)]
        /* 0x1284 */ public float BaseBuildingWiringSnappingScaleFactorEasy;
        [NMS(Index = 188)]
        /* 0x1288 */ public float BaseBuildingWiringSnappingScaleFactorHard;
        [NMS(Index = 122)]
        /* 0x128C */ public float BaseRadiusExtension;
        [NMS(Index = 20)]
        /* 0x1290 */ public float BuildingLineAlphaEnd0;
        [NMS(Index = 21)]
        /* 0x1294 */ public float BuildingLineAlphaEnd1;
        [NMS(Index = 22)]
        /* 0x1298 */ public float BuildingLineAlphaStart;
        [NMS(Index = 29)]
        /* 0x129C */ public int BuildingLineCount;
        [NMS(Index = 24)]
        /* 0x12A0 */ public float BuildingLineMoveSpeed;
        [NMS(Index = 26)]
        /* 0x12A4 */ public float BuildingLineOBBShrink;
        [NMS(Index = 28)]
        /* 0x12A8 */ public float BuildingLineProjectorLength;
        [NMS(Index = 27)]
        /* 0x12AC */ public float BuildingLineProjectorWidth;
        [NMS(Index = 25)]
        /* 0x12B0 */ public float BuildingLineResetTime;
        [NMS(Index = 23)]
        /* 0x12B4 */ public float BuildingLineWidth;
        [NMS(Index = 82)]
        /* 0x12B8 */ public float BuildingNearArcDistance;
        [NMS(Index = 81)]
        /* 0x12BC */ public float BuildingNearDistance;
        [NMS(Index = 8)]
        /* 0x12C0 */ public float BuildingPartPreviewPitch;
        [NMS(Index = 7)]
        /* 0x12C4 */ public float BuildingPartPreviewRadius;
        [NMS(Index = 9)]
        /* 0x12C8 */ public float BuildingPartPreviewRotateSpeed;
        [NMS(Index = 156)]
        /* 0x12CC */ public float BuildingPlacementConeEndDistance;
        [NMS(Index = 159)]
        /* 0x12D0 */ public float BuildingPlacementConeEndDistanceIndoors;
        [NMS(Index = 155)]
        /* 0x12D4 */ public float BuildingPlacementConeEndRadius;
        [NMS(Index = 158)]
        /* 0x12D8 */ public float BuildingPlacementConeEndRadiusIndoors;
        [NMS(Index = 154)]
        /* 0x12DC */ public float BuildingPlacementConeStartRadius;
        [NMS(Index = 157)]
        /* 0x12E0 */ public float BuildingPlacementConeStartRadiusIndoors;
        [NMS(Index = 133)]
        /* 0x12E4 */ public float BuildingPlacementCursorOffset;
        [NMS(Index = 137)]
        /* 0x12E8 */ public float BuildingPlacementDefaultMaxMinDistanceVR;
        [NMS(Index = 135)]
        /* 0x12EC */ public float BuildingPlacementDefaultMinDistance;
        [NMS(Index = 138)]
        /* 0x12F0 */ public float BuildingPlacementDefaultMinMinDistanceVR;
        [NMS(Index = 163)]
        /* 0x12F4 */ public float BuildingPlacementEffectCrossFadeTime;
        [NMS(Index = 161)]
        /* 0x12F8 */ public float BuildingPlacementEffectDissolveSpeed;
        [NMS(Index = 162)]
        /* 0x12FC */ public float BuildingPlacementEffectFadeWaitTime;
        [NMS(Index = 165)]
        /* 0x1300 */ public float BuildingPlacementEffectHidePlaceholderDistance;
        [NMS(Index = 164)]
        /* 0x1304 */ public float BuildingPlacementEffectHidePlaceholderFadeTime;
        [NMS(Index = 1)]
        /* 0x1308 */ public float BuildingPlacementEffectInterpRate;
        [NMS(Index = 2)]
        /* 0x130C */ public float BuildingPlacementEffectInterpRateSlow;
        [NMS(Index = 4)]
        /* 0x1310 */ public float BuildingPlacementEffectPostPreviewInterpTime;
        [NMS(Index = 3)]
        /* 0x1314 */ public float BuildingPlacementEffectPreviewInterpTime;
        [NMS(Index = 6)]
        /* 0x1318 */ public float BuildingPlacementEffectSpringFast;
        [NMS(Index = 5)]
        /* 0x131C */ public float BuildingPlacementEffectSpringSlow;
        [NMS(Index = 145)]
        /* 0x1320 */ public float BuildingPlacementGhostHearScaleDistanceMod;
        [NMS(Index = 147)]
        /* 0x1324 */ public float BuildingPlacementGhostHeartSizeScale;
        [NMS(Index = 146)]
        /* 0x1328 */ public float BuildingPlacementGhostHeartSizeScaleMin;
        [NMS(Index = 148)]
        /* 0x132C */ public float BuildingPlacementGhostHeartSizeSelected;
        [NMS(Index = 150)]
        /* 0x1330 */ public float BuildingPlacementGhostHeartWiringSizeOtherSnapped;
        [NMS(Index = 152)]
        /* 0x1334 */ public float BuildingPlacementGhostHeartWiringSizeScale;
        [NMS(Index = 151)]
        /* 0x1338 */ public float BuildingPlacementGhostHeartWiringSizeScaleMin;
        [NMS(Index = 140)]
        /* 0x133C */ public float BuildingPlacementGhostReductionMaxSize;
        [NMS(Index = 126)]
        /* 0x1340 */ public float BuildingPlacementMaxConnectionLength;
        [NMS(Index = 127)]
        /* 0x1344 */ public float BuildingPlacementMaxDistance;
        [NMS(Index = 128)]
        /* 0x1348 */ public float BuildingPlacementMaxDistanceNoHit;
        [NMS(Index = 129)]
        /* 0x134C */ public float BuildingPlacementMaxDistanceNoHitExtra;
        [NMS(Index = 132)]
        /* 0x1350 */ public float BuildingPlacementMaxDistanceScaleExtra;
        [NMS(Index = 131)]
        /* 0x1354 */ public float BuildingPlacementMaxDistanceScaleExtraMaxSize;
        [NMS(Index = 130)]
        /* 0x1358 */ public float BuildingPlacementMaxDistanceScaleExtraMinSize;
        [NMS(Index = 136)]
        /* 0x135C */ public float BuildingPlacementMinDistanceScaleIncrease;
        [NMS(Index = 139)]
        /* 0x1360 */ public float BuildingPlacementMinDistanceScaleIncreaseVR;
        [NMS(Index = 134)]
        /* 0x1364 */ public float BuildingPlacementMinDotProductRequiredToSnap;
        [NMS(Index = 143)]
        /* 0x1368 */ public float BuildingPlacementNumGhostsMinOffset;
        [NMS(Index = 144)]
        /* 0x136C */ public float BuildingPlacementNumGhostsVolume;
        [NMS(Index = 141)]
        /* 0x1370 */ public float BuildingPlacementNumGhostsVRMultiplier;
        [NMS(Index = 142)]
        /* 0x1374 */ public float BuildingPlacementNumGhostsVRMultiplierEyeTracking;
        [NMS(Index = 153)]
        /* 0x1378 */ public float BuildingPlacementTwistScale;
        [NMS(Index = 83)]
        /* 0x137C */ public float BuildingVisitDistance;
        [NMS(Index = 19)]
        /* 0x1380 */ public float BuildingWaterMargin;
        [NMS(Index = 60)]
        /* 0x1384 */ public float BuildingYOffset;
        [NMS(Index = 70)]
        /* 0x1388 */ public float ChanceOfAddingShelter;
        [NMS(Index = 101)]
        /* 0x138C */ public float CompassIconSize;
        [NMS(Index = 176)]
        /* 0x1390 */ public float ComplexityDensitySigmaSquared;
        [NMS(Index = 175)]
        /* 0x1394 */ public float ComplexityDensityTestRange;
        [NMS(Index = 97)]
        /* 0x1398 */ public float DistanceForTooltip;
        [NMS(Index = 96)]
        /* 0x139C */ public float DistanceForVisited;
        [NMS(Index = 94)]
        /* 0x13A0 */ public float DistanceTagXOffset;
        [NMS(Index = 93)]
        /* 0x13A4 */ public float DistanceTextXOffset;
        [NMS(Index = 77)]
        /* 0x13A8 */ public float FadeDistance;
        [NMS(Index = 76)]
        /* 0x13AC */ public float FadeStart;
        [NMS(Index = 117)]
        /* 0x13B0 */ public float FlyingBuildingIconTime;
        [NMS(Index = 58)]
        /* 0x13B4 */ public float HeightDiffLineAdjustFactor;
        [NMS(Index = 57)]
        /* 0x13B8 */ public float HeightDiffLineAdjustMax;
        [NMS(Index = 56)]
        /* 0x13BC */ public float HeightDiffLineAdjustMin;
        [NMS(Index = 16)]
        /* 0x13C0 */ public float HologramDistanceMultiplier;
        [NMS(Index = 17)]
        /* 0x13C4 */ public float HologramDistanceMultiplierAlt;
        [NMS(Index = 31)]
        /* 0x13C8 */ public float HoverFadeAlpha;
        [NMS(Index = 41)]
        /* 0x13CC */ public float HoverFadeAlphaHmd;
        [NMS(Index = 34)]
        /* 0x13D0 */ public float HoverFadeTime;
        [NMS(Index = 44)]
        /* 0x13D4 */ public float HoverFadeTimeHmd;
        [NMS(Index = 40)]
        /* 0x13D8 */ public float HoverInactiveSize;
        [NMS(Index = 50)]
        /* 0x13DC */ public float HoverInactiveSizeHmd;
        [NMS(Index = 38)]
        /* 0x13E0 */ public float HoverLockedActiveTime;
        [NMS(Index = 48)]
        /* 0x13E4 */ public float HoverLockedActiveTimeHmd;
        [NMS(Index = 39)]
        /* 0x13E8 */ public float HoverLockedIconScale;
        [NMS(Index = 49)]
        /* 0x13EC */ public float HoverLockedIconScaleHmd;
        [NMS(Index = 37)]
        /* 0x13F0 */ public float HoverLockedInitTime;
        [NMS(Index = 47)]
        /* 0x13F4 */ public float HoverLockedInitTimeHmd;
        [NMS(Index = 35)]
        /* 0x13F8 */ public float HoverMinToStayActiveTime;
        [NMS(Index = 45)]
        /* 0x13FC */ public float HoverMinToStayActiveTimeHmd;
        [NMS(Index = 36)]
        /* 0x1400 */ public float HoverStayActiveTime;
        [NMS(Index = 46)]
        /* 0x1404 */ public float HoverStayActiveTimeHmd;
        [NMS(Index = 32)]
        /* 0x1408 */ public float HoverTime;
        [NMS(Index = 42)]
        /* 0x140C */ public float HoverTimeHmd;
        [NMS(Index = 33)]
        /* 0x1410 */ public float HoverVisibilityTime;
        [NMS(Index = 43)]
        /* 0x1414 */ public float HoverVisibilityTimeHmd;
        [NMS(Index = 30)]
        /* 0x1418 */ public float IconSpringTime;
        [NMS(Index = 167)]
        /* 0x141C */ public float InactiveVisibleComplexityFactor;
        [NMS(Index = 61)]
        /* 0x1420 */ public float InteractMarkerYOffset;
        [NMS(Index = 100)]
        /* 0x1424 */ public float LargeIconArrowOffset;
        [NMS(Index = 99)]
        /* 0x1428 */ public float LargeIconSize;
        [NMS(Index = 52)]
        /* 0x142C */ public float LineDistanceRange;
        [NMS(Index = 51)]
        /* 0x1430 */ public float LineMinDistance;
        [NMS(Index = 80)]
        /* 0x1434 */ public float LineScaleFactor;
        [NMS(Index = 106)]
        /* 0x1438 */ public float MarkerLineWidth;
        [NMS(Index = 116)]
        /* 0x143C */ public float MarkerTimeIncrease;
        [NMS(Index = 109)]
        /* 0x1440 */ public float MarkerTransitionDistance;
        [NMS(Index = 115)]
        /* 0x1444 */ public float MaxIconRange;
        [NMS(Index = 174)]
        /* 0x1448 */ public float MaximumComplexityDensity;
        [NMS(Index = 53)]
        /* 0x144C */ public float MaxLineLength;
        [NMS(Index = 88)]
        /* 0x1450 */ public float MaxLowHeight;
        [NMS(Index = 123)]
        /* 0x1454 */ public float MaxRadiusForPlanetBases;
        [NMS(Index = 124)]
        /* 0x1458 */ public float MaxRadiusForSpaceBases;
        [NMS(Index = 119)]
        /* 0x145C */ public int MaxShipScanBuildings;
        [NMS(Index = 112)]
        /* 0x1460 */ public float MaxTimeBetweenEvents;
        [NMS(Index = 79)]
        /* 0x1464 */ public float MinAlpha;
        [NMS(Index = 87)]
        /* 0x1468 */ public float MinElevatedHeight;
        [NMS(Index = 54)]
        /* 0x146C */ public float MinLineLength;
        [NMS(Index = 55)]
        /* 0x1470 */ public float MinLineLengthShip;
        [NMS(Index = 172)]
        /* 0x1474 */ public float MinLoadingPercentageNodesBufferFree;
        [NMS(Index = 171)]
        /* 0x1478 */ public float MinPercentageNodesBufferFree;
        [NMS(Index = 62)]
        /* 0x147C */ public float MinRadius;
        [NMS(Index = 121)]
        /* 0x1480 */ public float MinRadiusForBases;
        [NMS(Index = 125)]
        /* 0x1484 */ public float MinRadiusFromFeaturedBases;
        [NMS(Index = 118)]
        /* 0x1488 */ public int MinShipScanBuildings;
        [NMS(Index = 74)]
        /* 0x148C */ public float MinTimeBetweenBuildingEntryMessage;
        [NMS(Index = 75)]
        /* 0x1490 */ public float MinTimeBetweenBuildingEntryMessageBase;
        [NMS(Index = 86)]
        /* 0x1494 */ public float NearLineScaleFactor;
        [NMS(Index = 84)]
        /* 0x1498 */ public float NearMaxLineLength;
        [NMS(Index = 78)]
        /* 0x149C */ public float NearMinAlpha;
        [NMS(Index = 85)]
        /* 0x14A0 */ public float NearMinLineLength;
        [NMS(Index = 67)]
        /* 0x14A4 */ public float ObjectFadeRadius;
        [NMS(Index = 173)]
        /* 0x14A8 */ public float PercentagePhysicsComponentsForComplexity;
        [NMS(Index = 15)]
        /* 0x14AC */ public float PowerlineSnapDistance;
        [NMS(Index = 69)]
        /* 0x14B0 */ public float Radius_DoNotPlaceAnywhereNear;
        [NMS(Index = 63)]
        /* 0x14B4 */ public float RadiusMultiplier_DoNotPlace;
        [NMS(Index = 65)]
        /* 0x14B8 */ public float RadiusMultiplier_DoNotPlaceAnywhereNear;
        [NMS(Index = 64)]
        /* 0x14BC */ public float RadiusMultiplier_DoNotPlaceClose;
        [NMS(Index = 66)]
        /* 0x14C0 */ public float RadiusMultiplier_OnlyPlaceAround;
        [NMS(Index = 72)]
        /* 0x14C4 */ public float SectorMessageCenterDistance;
        [NMS(Index = 73)]
        /* 0x14C8 */ public float SectorMessageMinTime;
        [NMS(Index = 71)]
        /* 0x14CC */ public float SectorMessageReshowDistance;
        [NMS(Index = 113)]
        /* 0x14D0 */ public float ShowTimeNotDistance;
        [NMS(Index = 102)]
        /* 0x14D4 */ public float SmallIconArrowOffset;
        [NMS(Index = 98)]
        /* 0x14D8 */ public float SmallIconSize;
        [NMS(Index = 111)]
        /* 0x14DC */ public float SpaceMarkerMaxHeight;
        [NMS(Index = 110)]
        /* 0x14E0 */ public float SpaceMarkerMinHeight;
        [NMS(Index = 103)]
        /* 0x14E4 */ public float SpaceMarkerOffset;
        [NMS(Index = 104)]
        /* 0x14E8 */ public float SpaceMarkerOffsetPlanet;
        [NMS(Index = 105)]
        /* 0x14EC */ public float SpaceMarkerOffsetSamePlanet;
        [NMS(Index = 178)]
        /* 0x14F0 */ public float StartCrashSiteMaxDistance;
        [NMS(Index = 177)]
        /* 0x14F4 */ public float StartCrashSiteMinDistance;
        [NMS(Index = 180)]
        /* 0x14F8 */ public float StartShelterMaxDistance;
        [NMS(Index = 179)]
        /* 0x14FC */ public float StartShelterMinDistance;
        [NMS(Index = 120)]
        /* 0x1500 */ public float TestDistanceForSettlementBaseBufferAlignment;
        [NMS(Index = 89)]
        /* 0x1504 */ public float TextStringXOffset;
        [NMS(Index = 95)]
        /* 0x1508 */ public float TextTagLength;
        [NMS(Index = 92)]
        /* 0x150C */ public float TextTagWidthOffset;
        [NMS(Index = 90)]
        /* 0x1510 */ public float TextTagXOffset;
        [NMS(Index = 91)]
        /* 0x1514 */ public float TextTagYOffset;
        [NMS(Index = 114)]
        /* 0x1518 */ public float UnknownBuildingRange;
        [NMS(Index = 181)]
        /* 0x151C */ public NMSString0x80 FreighterBaseSpawnOverride;
        [NMS(Index = 18)]
        /* 0x159C */ public bool AllowBuildingUsingIntermediates;
        [NMS(Index = 186)]
        /* 0x159D */ public bool BaseBuildingCamEnabled;
        [NMS(Index = 182)]
        /* 0x159E */ public bool BaseBuildingTerrainEditBoundsOverride;
        [NMS(Index = 160)]
        /* 0x159F */ public bool BuildingPlacementEffectEnabled;
        [NMS(Index = 149)]
        /* 0x15A0 */ public TkCurveType BuildingPlacementGhostHeartSizeCurve;
        [NMS(Index = 168)]
        /* 0x15A1 */ public bool DebugForceShowInactives;
        [NMS(Index = 59)]
        /* 0x15A2 */ public TkCurveType LineCurve;
    }
}
