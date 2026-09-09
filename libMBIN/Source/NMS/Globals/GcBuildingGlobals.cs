using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x31192943B023654D, NameHash = 0x1A517154)]
    public class GcBuildingGlobals : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public Vector3f BuildingPartPreviewOffset;
        [NMS(Index = 110)]
        /* 0x010 */ public Colour MarkerLineColour;
        [NMS(Index = 15, Size = 0x15, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x020 */ public GcBuildMenuIconSet[] Icons;
        [NMS(Index = 16, Size = 0x15, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x410 */ public GcBuildMenuIconSet[] IconsTouch;
        [NMS(Index = 10, Size = 0x15, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x800 */ public NMSString0x10[] ControlsIcons;
        [NMS(Index = 14)]
        /* 0x950 */ public TkTextureResource ScreenSpaceRotationGlow;
        [NMS(Index = 13)]
        /* 0x968 */ public TkTextureResource ScreenSpaceRotationIcon;
        [NMS(Index = 192)]
        /* 0x980 */ public GcFilename FreighterBaseSpawnOverride;
        // size: 0x4
        public enum ActiveLodDistancesEnum {
            Low,
            Medium,
            High,
            Ultra,
        }
        [NMS(Index = 11, Size = 0x4, EnumType = typeof(ActiveLodDistancesEnum))]
        /* 0x990 */ public TkLODDistances[] ActiveLodDistances;
        // size: 0x4
        public enum InactiveLodDistancesEnum {
            Low,
            Medium,
            High,
            Ultra,
        }
        [NMS(Index = 12, Size = 0x4, EnumType = typeof(InactiveLodDistancesEnum))]
        /* 0x9E0 */ public TkLODDistances[] InactiveLodDistances;
        // size: 0x4
        public enum TotalPlanetFrameTimeForComplexityEnum {
            Low,
            Medium,
            High,
            Ultra,
        }
        [NMS(Index = 180, Size = 0x4, EnumType = typeof(TotalPlanetFrameTimeForComplexityEnum))]
        /* 0xA30 */ public float[] TotalPlanetFrameTimeForComplexity;
        // size: 0x4
        public enum TotalSpaceFrameTimeForComplexityEnum {
            Low,
            Medium,
            High,
            Ultra,
        }
        [NMS(Index = 181, Size = 0x4, EnumType = typeof(TotalSpaceFrameTimeForComplexityEnum))]
        /* 0xA40 */ public float[] TotalSpaceFrameTimeForComplexity;
        [NMS(Index = 170)]
        /* 0xA50 */ public Vector2f BuildingPlacementScaleMinMax;
        [NMS(Index = 70)]
        /* 0xA58 */ public float AddToRadius_DoNotPlaceClose;
        [NMS(Index = 111)]
        /* 0xA5C */ public float AmountToMoveMarkerRoundSphere;
        [NMS(Index = 171)]
        /* 0xA60 */ public GcBaseBuildingCameraMode BaseBuildingCamMode;
        [NMS(Index = 194)]
        /* 0xA64 */ public float BaseBuildingTerrainEditBaseYOffset;
        [NMS(Index = 196)]
        /* 0xA68 */ public float BaseBuildingTerrainEditBoundsScalar;
        [NMS(Index = 195)]
        /* 0xA6C */ public float BaseBuildingTerrainEditTopYOffset;
        [NMS(Index = 197)]
        /* 0xA70 */ public float BaseBuildingWiringSnappingScaleFactorEasy;
        [NMS(Index = 198)]
        /* 0xA74 */ public float BaseBuildingWiringSnappingScaleFactorHard;
        [NMS(Index = 125)]
        /* 0xA78 */ public float BaseRadiusExtension;
        [NMS(Index = 73)]
        /* 0xA7C */ public float BuildingApproachDistance;
        [NMS(Index = 22)]
        /* 0xA80 */ public float BuildingLineAlphaEnd0;
        [NMS(Index = 23)]
        /* 0xA84 */ public float BuildingLineAlphaEnd1;
        [NMS(Index = 24)]
        /* 0xA88 */ public float BuildingLineAlphaStart;
        [NMS(Index = 31)]
        /* 0xA8C */ public int BuildingLineCount;
        [NMS(Index = 26)]
        /* 0xA90 */ public float BuildingLineMoveSpeed;
        [NMS(Index = 28)]
        /* 0xA94 */ public float BuildingLineOBBShrink;
        [NMS(Index = 30)]
        /* 0xA98 */ public float BuildingLineProjectorLength;
        [NMS(Index = 29)]
        /* 0xA9C */ public float BuildingLineProjectorWidth;
        [NMS(Index = 27)]
        /* 0xAA0 */ public float BuildingLineResetTime;
        [NMS(Index = 25)]
        /* 0xAA4 */ public float BuildingLineWidth;
        [NMS(Index = 85)]
        /* 0xAA8 */ public float BuildingNearArcDistance;
        [NMS(Index = 84)]
        /* 0xAAC */ public float BuildingNearDistance;
        [NMS(Index = 8)]
        /* 0xAB0 */ public float BuildingPartPreviewPitch;
        [NMS(Index = 7)]
        /* 0xAB4 */ public float BuildingPartPreviewRadius;
        [NMS(Index = 9)]
        /* 0xAB8 */ public float BuildingPartPreviewRotateSpeed;
        [NMS(Index = 160)]
        /* 0xABC */ public float BuildingPlacementConeEndDistance;
        [NMS(Index = 163)]
        /* 0xAC0 */ public float BuildingPlacementConeEndDistanceIndoors;
        [NMS(Index = 159)]
        /* 0xAC4 */ public float BuildingPlacementConeEndRadius;
        [NMS(Index = 162)]
        /* 0xAC8 */ public float BuildingPlacementConeEndRadiusIndoors;
        [NMS(Index = 158)]
        /* 0xACC */ public float BuildingPlacementConeStartRadius;
        [NMS(Index = 161)]
        /* 0xAD0 */ public float BuildingPlacementConeStartRadiusIndoors;
        [NMS(Index = 137)]
        /* 0xAD4 */ public float BuildingPlacementCursorOffset;
        [NMS(Index = 141)]
        /* 0xAD8 */ public float BuildingPlacementDefaultMaxMinDistanceVR;
        [NMS(Index = 139)]
        /* 0xADC */ public float BuildingPlacementDefaultMinDistance;
        [NMS(Index = 142)]
        /* 0xAE0 */ public float BuildingPlacementDefaultMinMinDistanceVR;
        [NMS(Index = 167)]
        /* 0xAE4 */ public float BuildingPlacementEffectCrossFadeTime;
        [NMS(Index = 165)]
        /* 0xAE8 */ public float BuildingPlacementEffectDissolveSpeed;
        [NMS(Index = 166)]
        /* 0xAEC */ public float BuildingPlacementEffectFadeWaitTime;
        [NMS(Index = 169)]
        /* 0xAF0 */ public float BuildingPlacementEffectHidePlaceholderDistance;
        [NMS(Index = 168)]
        /* 0xAF4 */ public float BuildingPlacementEffectHidePlaceholderFadeTime;
        [NMS(Index = 1)]
        /* 0xAF8 */ public float BuildingPlacementEffectInterpRate;
        [NMS(Index = 2)]
        /* 0xAFC */ public float BuildingPlacementEffectInterpRateSlow;
        [NMS(Index = 4)]
        /* 0xB00 */ public float BuildingPlacementEffectPostPreviewInterpTime;
        [NMS(Index = 3)]
        /* 0xB04 */ public float BuildingPlacementEffectPreviewInterpTime;
        [NMS(Index = 6)]
        /* 0xB08 */ public float BuildingPlacementEffectSpringFast;
        [NMS(Index = 5)]
        /* 0xB0C */ public float BuildingPlacementEffectSpringSlow;
        [NMS(Index = 177)]
        /* 0xB10 */ public float BuildingPlacementFocusModeAttachSnappingDistance;
        [NMS(Index = 174)]
        /* 0xB14 */ public float BuildingPlacementFocusModeMaxDistanceScaling;
        [NMS(Index = 173)]
        /* 0xB18 */ public float BuildingPlacementFocusModeMinDistance;
        [NMS(Index = 176)]
        /* 0xB1C */ public float BuildingPlacementFocusModeSurfaceSnappingDistance;
        [NMS(Index = 149)]
        /* 0xB20 */ public float BuildingPlacementGhostHearScaleDistanceMod;
        [NMS(Index = 151)]
        /* 0xB24 */ public float BuildingPlacementGhostHeartSizeScale;
        [NMS(Index = 150)]
        /* 0xB28 */ public float BuildingPlacementGhostHeartSizeScaleMin;
        [NMS(Index = 152)]
        /* 0xB2C */ public float BuildingPlacementGhostHeartSizeSelected;
        [NMS(Index = 154)]
        /* 0xB30 */ public float BuildingPlacementGhostHeartWiringSizeOtherSnapped;
        [NMS(Index = 156)]
        /* 0xB34 */ public float BuildingPlacementGhostHeartWiringSizeScale;
        [NMS(Index = 155)]
        /* 0xB38 */ public float BuildingPlacementGhostHeartWiringSizeScaleMin;
        [NMS(Index = 144)]
        /* 0xB3C */ public float BuildingPlacementGhostReductionMaxSize;
        [NMS(Index = 129)]
        /* 0xB40 */ public float BuildingPlacementMaxConnectionLength;
        [NMS(Index = 130)]
        /* 0xB44 */ public float BuildingPlacementMaxDistance;
        [NMS(Index = 131)]
        /* 0xB48 */ public float BuildingPlacementMaxDistanceNoHit;
        [NMS(Index = 132)]
        /* 0xB4C */ public float BuildingPlacementMaxDistanceNoHitExtra;
        [NMS(Index = 135)]
        /* 0xB50 */ public float BuildingPlacementMaxDistanceScaleExtra;
        [NMS(Index = 134)]
        /* 0xB54 */ public float BuildingPlacementMaxDistanceScaleExtraMaxSize;
        [NMS(Index = 133)]
        /* 0xB58 */ public float BuildingPlacementMaxDistanceScaleExtraMinSize;
        [NMS(Index = 136)]
        /* 0xB5C */ public float BuildingPlacementMaxShipBaseRadius;
        [NMS(Index = 140)]
        /* 0xB60 */ public float BuildingPlacementMinDistanceScaleIncrease;
        [NMS(Index = 143)]
        /* 0xB64 */ public float BuildingPlacementMinDistanceScaleIncreaseVR;
        [NMS(Index = 138)]
        /* 0xB68 */ public float BuildingPlacementMinDotProductRequiredToSnap;
        [NMS(Index = 147)]
        /* 0xB6C */ public float BuildingPlacementNumGhostsMinOffset;
        [NMS(Index = 148)]
        /* 0xB70 */ public float BuildingPlacementNumGhostsVolume;
        [NMS(Index = 145)]
        /* 0xB74 */ public float BuildingPlacementNumGhostsVRMultiplier;
        [NMS(Index = 146)]
        /* 0xB78 */ public float BuildingPlacementNumGhostsVRMultiplierEyeTracking;
        [NMS(Index = 175)]
        /* 0xB7C */ public float BuildingPlacementOrbitModeMaxDistanceScaling;
        [NMS(Index = 157)]
        /* 0xB80 */ public float BuildingPlacementTwistScale;
        [NMS(Index = 172)]
        /* 0xB84 */ public float BuildingSelectionFocusModeCursorRadius;
        [NMS(Index = 86)]
        /* 0xB88 */ public float BuildingVisitDistance;
        [NMS(Index = 21)]
        /* 0xB8C */ public float BuildingWaterMargin;
        [NMS(Index = 62)]
        /* 0xB90 */ public float BuildingYOffset;
        [NMS(Index = 72)]
        /* 0xB94 */ public float ChanceOfAddingShelter;
        [NMS(Index = 104)]
        /* 0xB98 */ public float CompassIconSize;
        [NMS(Index = 187)]
        /* 0xB9C */ public float ComplexityDensitySigmaSquared;
        [NMS(Index = 186)]
        /* 0xBA0 */ public float ComplexityDensityTestRange;
        [NMS(Index = 100)]
        /* 0xBA4 */ public float DistanceForTooltip;
        [NMS(Index = 99)]
        /* 0xBA8 */ public float DistanceForVisited;
        [NMS(Index = 97)]
        /* 0xBAC */ public float DistanceTagXOffset;
        [NMS(Index = 96)]
        /* 0xBB0 */ public float DistanceTextXOffset;
        [NMS(Index = 80)]
        /* 0xBB4 */ public float FadeDistance;
        [NMS(Index = 79)]
        /* 0xBB8 */ public float FadeStart;
        [NMS(Index = 120)]
        /* 0xBBC */ public float FlyingBuildingIconTime;
        [NMS(Index = 60)]
        /* 0xBC0 */ public float HeightDiffLineAdjustFactor;
        [NMS(Index = 59)]
        /* 0xBC4 */ public float HeightDiffLineAdjustMax;
        [NMS(Index = 58)]
        /* 0xBC8 */ public float HeightDiffLineAdjustMin;
        [NMS(Index = 18)]
        /* 0xBCC */ public float HologramDistanceMultiplier;
        [NMS(Index = 19)]
        /* 0xBD0 */ public float HologramDistanceMultiplierAlt;
        [NMS(Index = 33)]
        /* 0xBD4 */ public float HoverFadeAlpha;
        [NMS(Index = 43)]
        /* 0xBD8 */ public float HoverFadeAlphaHmd;
        [NMS(Index = 36)]
        /* 0xBDC */ public float HoverFadeTime;
        [NMS(Index = 46)]
        /* 0xBE0 */ public float HoverFadeTimeHmd;
        [NMS(Index = 42)]
        /* 0xBE4 */ public float HoverInactiveSize;
        [NMS(Index = 52)]
        /* 0xBE8 */ public float HoverInactiveSizeHmd;
        [NMS(Index = 40)]
        /* 0xBEC */ public float HoverLockedActiveTime;
        [NMS(Index = 50)]
        /* 0xBF0 */ public float HoverLockedActiveTimeHmd;
        [NMS(Index = 41)]
        /* 0xBF4 */ public float HoverLockedIconScale;
        [NMS(Index = 51)]
        /* 0xBF8 */ public float HoverLockedIconScaleHmd;
        [NMS(Index = 39)]
        /* 0xBFC */ public float HoverLockedInitTime;
        [NMS(Index = 49)]
        /* 0xC00 */ public float HoverLockedInitTimeHmd;
        [NMS(Index = 37)]
        /* 0xC04 */ public float HoverMinToStayActiveTime;
        [NMS(Index = 47)]
        /* 0xC08 */ public float HoverMinToStayActiveTimeHmd;
        [NMS(Index = 38)]
        /* 0xC0C */ public float HoverStayActiveTime;
        [NMS(Index = 48)]
        /* 0xC10 */ public float HoverStayActiveTimeHmd;
        [NMS(Index = 34)]
        /* 0xC14 */ public float HoverTime;
        [NMS(Index = 44)]
        /* 0xC18 */ public float HoverTimeHmd;
        [NMS(Index = 35)]
        /* 0xC1C */ public float HoverVisibilityTime;
        [NMS(Index = 45)]
        /* 0xC20 */ public float HoverVisibilityTimeHmd;
        [NMS(Index = 32)]
        /* 0xC24 */ public float IconSpringTime;
        [NMS(Index = 178)]
        /* 0xC28 */ public float InactiveVisibleComplexityFactor;
        [NMS(Index = 63)]
        /* 0xC2C */ public float InteractMarkerYOffset;
        [NMS(Index = 103)]
        /* 0xC30 */ public float LargeIconArrowOffset;
        [NMS(Index = 102)]
        /* 0xC34 */ public float LargeIconSize;
        [NMS(Index = 54)]
        /* 0xC38 */ public float LineDistanceRange;
        [NMS(Index = 53)]
        /* 0xC3C */ public float LineMinDistance;
        [NMS(Index = 83)]
        /* 0xC40 */ public float LineScaleFactor;
        [NMS(Index = 109)]
        /* 0xC44 */ public float MarkerLineWidth;
        [NMS(Index = 119)]
        /* 0xC48 */ public float MarkerTimeIncrease;
        [NMS(Index = 112)]
        /* 0xC4C */ public float MarkerTransitionDistance;
        [NMS(Index = 199)]
        /* 0xC50 */ public int MaxDownloadedBaseTerrainEditsToApply;
        [NMS(Index = 118)]
        /* 0xC54 */ public float MaxIconRange;
        [NMS(Index = 185)]
        /* 0xC58 */ public float MaximumComplexityDensity;
        [NMS(Index = 55)]
        /* 0xC5C */ public float MaxLineLength;
        [NMS(Index = 91)]
        /* 0xC60 */ public float MaxLowHeight;
        [NMS(Index = 126)]
        /* 0xC64 */ public float MaxRadiusForPlanetBases;
        [NMS(Index = 127)]
        /* 0xC68 */ public float MaxRadiusForSpaceBases;
        [NMS(Index = 122)]
        /* 0xC6C */ public int MaxShipScanBuildings;
        [NMS(Index = 115)]
        /* 0xC70 */ public float MaxTimeBetweenEvents;
        [NMS(Index = 82)]
        /* 0xC74 */ public float MinAlpha;
        [NMS(Index = 90)]
        /* 0xC78 */ public float MinElevatedHeight;
        [NMS(Index = 56)]
        /* 0xC7C */ public float MinLineLength;
        [NMS(Index = 57)]
        /* 0xC80 */ public float MinLineLengthShip;
        [NMS(Index = 183)]
        /* 0xC84 */ public float MinLoadingPercentageNodesBufferFree;
        [NMS(Index = 182)]
        /* 0xC88 */ public float MinPercentageNodesBufferFree;
        [NMS(Index = 64)]
        /* 0xC8C */ public float MinRadius;
        [NMS(Index = 124)]
        /* 0xC90 */ public float MinRadiusForBases;
        [NMS(Index = 128)]
        /* 0xC94 */ public float MinRadiusFromFeaturedBases;
        [NMS(Index = 121)]
        /* 0xC98 */ public int MinShipScanBuildings;
        [NMS(Index = 77)]
        /* 0xC9C */ public float MinTimeBetweenBuildingEntryMessage;
        [NMS(Index = 78)]
        /* 0xCA0 */ public float MinTimeBetweenBuildingEntryMessageBase;
        [NMS(Index = 89)]
        /* 0xCA4 */ public float NearLineScaleFactor;
        [NMS(Index = 87)]
        /* 0xCA8 */ public float NearMaxLineLength;
        [NMS(Index = 81)]
        /* 0xCAC */ public float NearMinAlpha;
        [NMS(Index = 88)]
        /* 0xCB0 */ public float NearMinLineLength;
        [NMS(Index = 69)]
        /* 0xCB4 */ public float ObjectFadeRadius;
        [NMS(Index = 184)]
        /* 0xCB8 */ public float PercentagePhysicsComponentsForComplexity;
        [NMS(Index = 17)]
        /* 0xCBC */ public float PowerlineSnapDistance;
        [NMS(Index = 65)]
        /* 0xCC0 */ public float RadiusMultiplier_DoNotPlace;
        [NMS(Index = 67)]
        /* 0xCC4 */ public float RadiusMultiplier_DoNotPlaceAnywhereNear;
        [NMS(Index = 66)]
        /* 0xCC8 */ public float RadiusMultiplier_DoNotPlaceClose;
        [NMS(Index = 68)]
        /* 0xCCC */ public float RadiusMultiplier_OnlyPlaceAround;
        [NMS(Index = 71)]
        /* 0xCD0 */ public float Radius_DoNotPlaceAnywhereNear;
        [NMS(Index = 75)]
        /* 0xCD4 */ public float SectorMessageCenterDistance;
        [NMS(Index = 76)]
        /* 0xCD8 */ public float SectorMessageMinTime;
        [NMS(Index = 74)]
        /* 0xCDC */ public float SectorMessageReshowDistance;
        [NMS(Index = 116)]
        /* 0xCE0 */ public float ShowTimeNotDistance;
        [NMS(Index = 105)]
        /* 0xCE4 */ public float SmallIconArrowOffset;
        [NMS(Index = 101)]
        /* 0xCE8 */ public float SmallIconSize;
        [NMS(Index = 114)]
        /* 0xCEC */ public float SpaceMarkerMaxHeight;
        [NMS(Index = 113)]
        /* 0xCF0 */ public float SpaceMarkerMinHeight;
        [NMS(Index = 106)]
        /* 0xCF4 */ public float SpaceMarkerOffset;
        [NMS(Index = 107)]
        /* 0xCF8 */ public float SpaceMarkerOffsetPlanet;
        [NMS(Index = 108)]
        /* 0xCFC */ public float SpaceMarkerOffsetSamePlanet;
        [NMS(Index = 189)]
        /* 0xD00 */ public float StartCrashSiteMaxDistance;
        [NMS(Index = 188)]
        /* 0xD04 */ public float StartCrashSiteMinDistance;
        [NMS(Index = 191)]
        /* 0xD08 */ public float StartShelterMaxDistance;
        [NMS(Index = 190)]
        /* 0xD0C */ public float StartShelterMinDistance;
        [NMS(Index = 123)]
        /* 0xD10 */ public float TestDistanceForSettlementBaseBufferAlignment;
        [NMS(Index = 92)]
        /* 0xD14 */ public float TextStringXOffset;
        [NMS(Index = 98)]
        /* 0xD18 */ public float TextTagLength;
        [NMS(Index = 95)]
        /* 0xD1C */ public float TextTagWidthOffset;
        [NMS(Index = 93)]
        /* 0xD20 */ public float TextTagXOffset;
        [NMS(Index = 94)]
        /* 0xD24 */ public float TextTagYOffset;
        [NMS(Index = 117)]
        /* 0xD28 */ public float UnknownBuildingRange;
        [NMS(Index = 20)]
        /* 0xD2C */ public bool AllowBuildingUsingIntermediates;
        [NMS(Index = 193)]
        /* 0xD2D */ public bool BaseBuildingTerrainEditBoundsOverride;
        [NMS(Index = 164)]
        /* 0xD2E */ public bool BuildingPlacementEffectEnabled;
        [NMS(Index = 153)]
        /* 0xD2F */ public TkCurveType BuildingPlacementGhostHeartSizeCurve;
        [NMS(Index = 179)]
        /* 0xD30 */ public bool DebugForceShowInactives;
        [NMS(Index = 61)]
        /* 0xD31 */ public TkCurveType LineCurve;
    }
}
