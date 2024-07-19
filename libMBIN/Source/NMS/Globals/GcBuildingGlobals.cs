using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x79765E0C815DC0EA, NameHash = 0x1A517154)]
    public class GcBuildingGlobals : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public Vector3f BuildingPartPreviewOffset;
        [NMS(Index = 109)]
        /* 0x010 */ public Colour MarkerLineColour;
        [NMS(Index = 14, Size = 0x10, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x020 */ public GcBuildMenuIconSet[] Icons;
        [NMS(Index = 15, Size = 0x10, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x320 */ public GcBuildMenuIconSet[] IconsTouch;
        [NMS(Index = 13)]
        /* 0x620 */ public TkTextureResource ScreenSpaceRotationGlow;
        [NMS(Index = 12)]
        /* 0x638 */ public TkTextureResource ScreenSpaceRotationIcon;
        [NMS(Index = 189)]
        /* 0x650 */ public VariableSizeString FreighterBaseSpawnOverride;
        [NMS(Index = 10, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x660 */ public TkLODDistances[] ActiveLodDistances;
        [NMS(Index = 11, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x6B0 */ public TkLODDistances[] InactiveLodDistances;
        [NMS(Index = 177, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x700 */ public float[] TotalPlanetFrameTimeForComplexity;
        [NMS(Index = 178, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x710 */ public float[] TotalSpaceFrameTimeForComplexity;
        [NMS(Index = 168)]
        /* 0x720 */ public Vector2f BuildingPlacementScaleMinMax;
        [NMS(Index = 69)]
        /* 0x728 */ public float AddToRadius_DoNotPlaceClose;
        [NMS(Index = 110)]
        /* 0x72C */ public float AmountToMoveMarkerRoundSphere;
        [NMS(Index = 169)]
        /* 0x730 */ public GcBaseBuildingCameraMode BaseBuildingCamMode;
        [NMS(Index = 191)]
        /* 0x734 */ public float BaseBuildingTerrainEditBaseYOffset;
        [NMS(Index = 193)]
        /* 0x738 */ public float BaseBuildingTerrainEditBoundsScalar;
        [NMS(Index = 192)]
        /* 0x73C */ public float BaseBuildingTerrainEditTopYOffset;
        [NMS(Index = 194)]
        /* 0x740 */ public float BaseBuildingWiringSnappingScaleFactorEasy;
        [NMS(Index = 195)]
        /* 0x744 */ public float BaseBuildingWiringSnappingScaleFactorHard;
        [NMS(Index = 124)]
        /* 0x748 */ public float BaseRadiusExtension;
        [NMS(Index = 72)]
        /* 0x74C */ public float BuildingApproachDistance;
        [NMS(Index = 21)]
        /* 0x750 */ public float BuildingLineAlphaEnd0;
        [NMS(Index = 22)]
        /* 0x754 */ public float BuildingLineAlphaEnd1;
        [NMS(Index = 23)]
        /* 0x758 */ public float BuildingLineAlphaStart;
        [NMS(Index = 30)]
        /* 0x75C */ public int BuildingLineCount;
        [NMS(Index = 25)]
        /* 0x760 */ public float BuildingLineMoveSpeed;
        [NMS(Index = 27)]
        /* 0x764 */ public float BuildingLineOBBShrink;
        [NMS(Index = 29)]
        /* 0x768 */ public float BuildingLineProjectorLength;
        [NMS(Index = 28)]
        /* 0x76C */ public float BuildingLineProjectorWidth;
        [NMS(Index = 26)]
        /* 0x770 */ public float BuildingLineResetTime;
        [NMS(Index = 24)]
        /* 0x774 */ public float BuildingLineWidth;
        [NMS(Index = 84)]
        /* 0x778 */ public float BuildingNearArcDistance;
        [NMS(Index = 83)]
        /* 0x77C */ public float BuildingNearDistance;
        [NMS(Index = 8)]
        /* 0x780 */ public float BuildingPartPreviewPitch;
        [NMS(Index = 7)]
        /* 0x784 */ public float BuildingPartPreviewRadius;
        [NMS(Index = 9)]
        /* 0x788 */ public float BuildingPartPreviewRotateSpeed;
        [NMS(Index = 158)]
        /* 0x78C */ public float BuildingPlacementConeEndDistance;
        [NMS(Index = 161)]
        /* 0x790 */ public float BuildingPlacementConeEndDistanceIndoors;
        [NMS(Index = 157)]
        /* 0x794 */ public float BuildingPlacementConeEndRadius;
        [NMS(Index = 160)]
        /* 0x798 */ public float BuildingPlacementConeEndRadiusIndoors;
        [NMS(Index = 156)]
        /* 0x79C */ public float BuildingPlacementConeStartRadius;
        [NMS(Index = 159)]
        /* 0x7A0 */ public float BuildingPlacementConeStartRadiusIndoors;
        [NMS(Index = 135)]
        /* 0x7A4 */ public float BuildingPlacementCursorOffset;
        [NMS(Index = 139)]
        /* 0x7A8 */ public float BuildingPlacementDefaultMaxMinDistanceVR;
        [NMS(Index = 137)]
        /* 0x7AC */ public float BuildingPlacementDefaultMinDistance;
        [NMS(Index = 140)]
        /* 0x7B0 */ public float BuildingPlacementDefaultMinMinDistanceVR;
        [NMS(Index = 165)]
        /* 0x7B4 */ public float BuildingPlacementEffectCrossFadeTime;
        [NMS(Index = 163)]
        /* 0x7B8 */ public float BuildingPlacementEffectDissolveSpeed;
        [NMS(Index = 164)]
        /* 0x7BC */ public float BuildingPlacementEffectFadeWaitTime;
        [NMS(Index = 167)]
        /* 0x7C0 */ public float BuildingPlacementEffectHidePlaceholderDistance;
        [NMS(Index = 166)]
        /* 0x7C4 */ public float BuildingPlacementEffectHidePlaceholderFadeTime;
        [NMS(Index = 1)]
        /* 0x7C8 */ public float BuildingPlacementEffectInterpRate;
        [NMS(Index = 2)]
        /* 0x7CC */ public float BuildingPlacementEffectInterpRateSlow;
        [NMS(Index = 4)]
        /* 0x7D0 */ public float BuildingPlacementEffectPostPreviewInterpTime;
        [NMS(Index = 3)]
        /* 0x7D4 */ public float BuildingPlacementEffectPreviewInterpTime;
        [NMS(Index = 6)]
        /* 0x7D8 */ public float BuildingPlacementEffectSpringFast;
        [NMS(Index = 5)]
        /* 0x7DC */ public float BuildingPlacementEffectSpringSlow;
        [NMS(Index = 174)]
        /* 0x7E0 */ public float BuildingPlacementFocusModeAttachSnappingDistance;
        [NMS(Index = 172)]
        /* 0x7E4 */ public float BuildingPlacementFocusModeMaxDistanceScaling;
        [NMS(Index = 171)]
        /* 0x7E8 */ public float BuildingPlacementFocusModeMinDistance;
        [NMS(Index = 173)]
        /* 0x7EC */ public float BuildingPlacementFocusModeSurfaceSnappingDistance;
        [NMS(Index = 147)]
        /* 0x7F0 */ public float BuildingPlacementGhostHearScaleDistanceMod;
        [NMS(Index = 149)]
        /* 0x7F4 */ public float BuildingPlacementGhostHeartSizeScale;
        [NMS(Index = 148)]
        /* 0x7F8 */ public float BuildingPlacementGhostHeartSizeScaleMin;
        [NMS(Index = 150)]
        /* 0x7FC */ public float BuildingPlacementGhostHeartSizeSelected;
        [NMS(Index = 152)]
        /* 0x800 */ public float BuildingPlacementGhostHeartWiringSizeOtherSnapped;
        [NMS(Index = 154)]
        /* 0x804 */ public float BuildingPlacementGhostHeartWiringSizeScale;
        [NMS(Index = 153)]
        /* 0x808 */ public float BuildingPlacementGhostHeartWiringSizeScaleMin;
        [NMS(Index = 142)]
        /* 0x80C */ public float BuildingPlacementGhostReductionMaxSize;
        [NMS(Index = 128)]
        /* 0x810 */ public float BuildingPlacementMaxConnectionLength;
        [NMS(Index = 129)]
        /* 0x814 */ public float BuildingPlacementMaxDistance;
        [NMS(Index = 130)]
        /* 0x818 */ public float BuildingPlacementMaxDistanceNoHit;
        [NMS(Index = 131)]
        /* 0x81C */ public float BuildingPlacementMaxDistanceNoHitExtra;
        [NMS(Index = 134)]
        /* 0x820 */ public float BuildingPlacementMaxDistanceScaleExtra;
        [NMS(Index = 133)]
        /* 0x824 */ public float BuildingPlacementMaxDistanceScaleExtraMaxSize;
        [NMS(Index = 132)]
        /* 0x828 */ public float BuildingPlacementMaxDistanceScaleExtraMinSize;
        [NMS(Index = 138)]
        /* 0x82C */ public float BuildingPlacementMinDistanceScaleIncrease;
        [NMS(Index = 141)]
        /* 0x830 */ public float BuildingPlacementMinDistanceScaleIncreaseVR;
        [NMS(Index = 136)]
        /* 0x834 */ public float BuildingPlacementMinDotProductRequiredToSnap;
        [NMS(Index = 145)]
        /* 0x838 */ public float BuildingPlacementNumGhostsMinOffset;
        [NMS(Index = 146)]
        /* 0x83C */ public float BuildingPlacementNumGhostsVolume;
        [NMS(Index = 143)]
        /* 0x840 */ public float BuildingPlacementNumGhostsVRMultiplier;
        [NMS(Index = 144)]
        /* 0x844 */ public float BuildingPlacementNumGhostsVRMultiplierEyeTracking;
        [NMS(Index = 155)]
        /* 0x848 */ public float BuildingPlacementTwistScale;
        [NMS(Index = 170)]
        /* 0x84C */ public float BuildingSelectionFocusModeCursorRadius;
        [NMS(Index = 85)]
        /* 0x850 */ public float BuildingVisitDistance;
        [NMS(Index = 20)]
        /* 0x854 */ public float BuildingWaterMargin;
        [NMS(Index = 61)]
        /* 0x858 */ public float BuildingYOffset;
        [NMS(Index = 71)]
        /* 0x85C */ public float ChanceOfAddingShelter;
        [NMS(Index = 103)]
        /* 0x860 */ public float CompassIconSize;
        [NMS(Index = 184)]
        /* 0x864 */ public float ComplexityDensitySigmaSquared;
        [NMS(Index = 183)]
        /* 0x868 */ public float ComplexityDensityTestRange;
        [NMS(Index = 99)]
        /* 0x86C */ public float DistanceForTooltip;
        [NMS(Index = 98)]
        /* 0x870 */ public float DistanceForVisited;
        [NMS(Index = 96)]
        /* 0x874 */ public float DistanceTagXOffset;
        [NMS(Index = 95)]
        /* 0x878 */ public float DistanceTextXOffset;
        [NMS(Index = 79)]
        /* 0x87C */ public float FadeDistance;
        [NMS(Index = 78)]
        /* 0x880 */ public float FadeStart;
        [NMS(Index = 119)]
        /* 0x884 */ public float FlyingBuildingIconTime;
        [NMS(Index = 59)]
        /* 0x888 */ public float HeightDiffLineAdjustFactor;
        [NMS(Index = 58)]
        /* 0x88C */ public float HeightDiffLineAdjustMax;
        [NMS(Index = 57)]
        /* 0x890 */ public float HeightDiffLineAdjustMin;
        [NMS(Index = 17)]
        /* 0x894 */ public float HologramDistanceMultiplier;
        [NMS(Index = 18)]
        /* 0x898 */ public float HologramDistanceMultiplierAlt;
        [NMS(Index = 32)]
        /* 0x89C */ public float HoverFadeAlpha;
        [NMS(Index = 42)]
        /* 0x8A0 */ public float HoverFadeAlphaHmd;
        [NMS(Index = 35)]
        /* 0x8A4 */ public float HoverFadeTime;
        [NMS(Index = 45)]
        /* 0x8A8 */ public float HoverFadeTimeHmd;
        [NMS(Index = 41)]
        /* 0x8AC */ public float HoverInactiveSize;
        [NMS(Index = 51)]
        /* 0x8B0 */ public float HoverInactiveSizeHmd;
        [NMS(Index = 39)]
        /* 0x8B4 */ public float HoverLockedActiveTime;
        [NMS(Index = 49)]
        /* 0x8B8 */ public float HoverLockedActiveTimeHmd;
        [NMS(Index = 40)]
        /* 0x8BC */ public float HoverLockedIconScale;
        [NMS(Index = 50)]
        /* 0x8C0 */ public float HoverLockedIconScaleHmd;
        [NMS(Index = 38)]
        /* 0x8C4 */ public float HoverLockedInitTime;
        [NMS(Index = 48)]
        /* 0x8C8 */ public float HoverLockedInitTimeHmd;
        [NMS(Index = 36)]
        /* 0x8CC */ public float HoverMinToStayActiveTime;
        [NMS(Index = 46)]
        /* 0x8D0 */ public float HoverMinToStayActiveTimeHmd;
        [NMS(Index = 37)]
        /* 0x8D4 */ public float HoverStayActiveTime;
        [NMS(Index = 47)]
        /* 0x8D8 */ public float HoverStayActiveTimeHmd;
        [NMS(Index = 33)]
        /* 0x8DC */ public float HoverTime;
        [NMS(Index = 43)]
        /* 0x8E0 */ public float HoverTimeHmd;
        [NMS(Index = 34)]
        /* 0x8E4 */ public float HoverVisibilityTime;
        [NMS(Index = 44)]
        /* 0x8E8 */ public float HoverVisibilityTimeHmd;
        [NMS(Index = 31)]
        /* 0x8EC */ public float IconSpringTime;
        [NMS(Index = 175)]
        /* 0x8F0 */ public float InactiveVisibleComplexityFactor;
        [NMS(Index = 62)]
        /* 0x8F4 */ public float InteractMarkerYOffset;
        [NMS(Index = 102)]
        /* 0x8F8 */ public float LargeIconArrowOffset;
        [NMS(Index = 101)]
        /* 0x8FC */ public float LargeIconSize;
        [NMS(Index = 53)]
        /* 0x900 */ public float LineDistanceRange;
        [NMS(Index = 52)]
        /* 0x904 */ public float LineMinDistance;
        [NMS(Index = 82)]
        /* 0x908 */ public float LineScaleFactor;
        [NMS(Index = 108)]
        /* 0x90C */ public float MarkerLineWidth;
        [NMS(Index = 118)]
        /* 0x910 */ public float MarkerTimeIncrease;
        [NMS(Index = 111)]
        /* 0x914 */ public float MarkerTransitionDistance;
        [NMS(Index = 117)]
        /* 0x918 */ public float MaxIconRange;
        [NMS(Index = 182)]
        /* 0x91C */ public float MaximumComplexityDensity;
        [NMS(Index = 54)]
        /* 0x920 */ public float MaxLineLength;
        [NMS(Index = 90)]
        /* 0x924 */ public float MaxLowHeight;
        [NMS(Index = 125)]
        /* 0x928 */ public float MaxRadiusForPlanetBases;
        [NMS(Index = 126)]
        /* 0x92C */ public float MaxRadiusForSpaceBases;
        [NMS(Index = 121)]
        /* 0x930 */ public int MaxShipScanBuildings;
        [NMS(Index = 114)]
        /* 0x934 */ public float MaxTimeBetweenEvents;
        [NMS(Index = 81)]
        /* 0x938 */ public float MinAlpha;
        [NMS(Index = 89)]
        /* 0x93C */ public float MinElevatedHeight;
        [NMS(Index = 55)]
        /* 0x940 */ public float MinLineLength;
        [NMS(Index = 56)]
        /* 0x944 */ public float MinLineLengthShip;
        [NMS(Index = 180)]
        /* 0x948 */ public float MinLoadingPercentageNodesBufferFree;
        [NMS(Index = 179)]
        /* 0x94C */ public float MinPercentageNodesBufferFree;
        [NMS(Index = 63)]
        /* 0x950 */ public float MinRadius;
        [NMS(Index = 123)]
        /* 0x954 */ public float MinRadiusForBases;
        [NMS(Index = 127)]
        /* 0x958 */ public float MinRadiusFromFeaturedBases;
        [NMS(Index = 120)]
        /* 0x95C */ public int MinShipScanBuildings;
        [NMS(Index = 76)]
        /* 0x960 */ public float MinTimeBetweenBuildingEntryMessage;
        [NMS(Index = 77)]
        /* 0x964 */ public float MinTimeBetweenBuildingEntryMessageBase;
        [NMS(Index = 88)]
        /* 0x968 */ public float NearLineScaleFactor;
        [NMS(Index = 86)]
        /* 0x96C */ public float NearMaxLineLength;
        [NMS(Index = 80)]
        /* 0x970 */ public float NearMinAlpha;
        [NMS(Index = 87)]
        /* 0x974 */ public float NearMinLineLength;
        [NMS(Index = 68)]
        /* 0x978 */ public float ObjectFadeRadius;
        [NMS(Index = 181)]
        /* 0x97C */ public float PercentagePhysicsComponentsForComplexity;
        [NMS(Index = 16)]
        /* 0x980 */ public float PowerlineSnapDistance;
        [NMS(Index = 70)]
        /* 0x984 */ public float Radius_DoNotPlaceAnywhereNear;
        [NMS(Index = 64)]
        /* 0x988 */ public float RadiusMultiplier_DoNotPlace;
        [NMS(Index = 66)]
        /* 0x98C */ public float RadiusMultiplier_DoNotPlaceAnywhereNear;
        [NMS(Index = 65)]
        /* 0x990 */ public float RadiusMultiplier_DoNotPlaceClose;
        [NMS(Index = 67)]
        /* 0x994 */ public float RadiusMultiplier_OnlyPlaceAround;
        [NMS(Index = 74)]
        /* 0x998 */ public float SectorMessageCenterDistance;
        [NMS(Index = 75)]
        /* 0x99C */ public float SectorMessageMinTime;
        [NMS(Index = 73)]
        /* 0x9A0 */ public float SectorMessageReshowDistance;
        [NMS(Index = 115)]
        /* 0x9A4 */ public float ShowTimeNotDistance;
        [NMS(Index = 104)]
        /* 0x9A8 */ public float SmallIconArrowOffset;
        [NMS(Index = 100)]
        /* 0x9AC */ public float SmallIconSize;
        [NMS(Index = 113)]
        /* 0x9B0 */ public float SpaceMarkerMaxHeight;
        [NMS(Index = 112)]
        /* 0x9B4 */ public float SpaceMarkerMinHeight;
        [NMS(Index = 105)]
        /* 0x9B8 */ public float SpaceMarkerOffset;
        [NMS(Index = 106)]
        /* 0x9BC */ public float SpaceMarkerOffsetPlanet;
        [NMS(Index = 107)]
        /* 0x9C0 */ public float SpaceMarkerOffsetSamePlanet;
        [NMS(Index = 186)]
        /* 0x9C4 */ public float StartCrashSiteMaxDistance;
        [NMS(Index = 185)]
        /* 0x9C8 */ public float StartCrashSiteMinDistance;
        [NMS(Index = 188)]
        /* 0x9CC */ public float StartShelterMaxDistance;
        [NMS(Index = 187)]
        /* 0x9D0 */ public float StartShelterMinDistance;
        [NMS(Index = 122)]
        /* 0x9D4 */ public float TestDistanceForSettlementBaseBufferAlignment;
        [NMS(Index = 91)]
        /* 0x9D8 */ public float TextStringXOffset;
        [NMS(Index = 97)]
        /* 0x9DC */ public float TextTagLength;
        [NMS(Index = 94)]
        /* 0x9E0 */ public float TextTagWidthOffset;
        [NMS(Index = 92)]
        /* 0x9E4 */ public float TextTagXOffset;
        [NMS(Index = 93)]
        /* 0x9E8 */ public float TextTagYOffset;
        [NMS(Index = 116)]
        /* 0x9EC */ public float UnknownBuildingRange;
        [NMS(Index = 19)]
        /* 0x9F0 */ public bool AllowBuildingUsingIntermediates;
        [NMS(Index = 190)]
        /* 0x9F1 */ public bool BaseBuildingTerrainEditBoundsOverride;
        [NMS(Index = 162)]
        /* 0x9F2 */ public bool BuildingPlacementEffectEnabled;
        [NMS(Index = 151)]
        /* 0x9F3 */ public TkCurveType BuildingPlacementGhostHeartSizeCurve;
        [NMS(Index = 176)]
        /* 0x9F4 */ public bool DebugForceShowInactives;
        [NMS(Index = 60)]
        /* 0x9F5 */ public TkCurveType LineCurve;
    }
}
