using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x1759D954934168BC, NameHash = 0x3BC94060600296E8)]
    public class GcGalaxyGlobals : NMSTemplate
    {
        [NMS(Index = 122, Size = 0x10, EnumType = typeof(GcGalaxyMarkerTypes.GalaxyMarkerTypeEnum))]
        /* 0x0000 */ public GcGalaxyMarkerSettings[] MarkerSettings;
        [NMS(Index = 173)]
        /* 0x1200 */ public GcGalaxyRenderSetupData DefaultRenderSetup;
        [NMS(Index = 175)]
        /* 0x1540 */ public GcGalaxyRenderSetupData FinalAnimationRenderSetup;
        [NMS(Index = 174)]
        /* 0x1880 */ public GcGalaxyGenerationSetupData DefaultGeneration;
        [NMS(Index = 176)]
        /* 0x1A00 */ public GcGalaxyGenerationSetupData FinalAnimationGeneration;
        [NMS(Index = 110, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1B80 */ public Colour[] RaceFilterDefaultColours;
        [NMS(Index = 112, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1C10 */ public Colour[] RaceFilterDeuteranopiaColours;
        [NMS(Index = 111, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1CA0 */ public Colour[] RaceFilterProtanopiaColours;
        [NMS(Index = 113, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1D30 */ public Colour[] RaceFilterTritanopiaColours;
        [NMS(Index = 114, Size = 0x7, EnumType = typeof(GcTradingClass.TradingClassEnum))]
        /* 0x1DC0 */ public Colour[] EconomyFilterDefaultColours;
        [NMS(Index = 116, Size = 0x7, EnumType = typeof(GcTradingClass.TradingClassEnum))]
        /* 0x1E30 */ public Colour[] EconomyFilterDeuteranopiaColours;
        [NMS(Index = 115, Size = 0x7, EnumType = typeof(GcTradingClass.TradingClassEnum))]
        /* 0x1EA0 */ public Colour[] EconomyFilterProtanopiaColours;
        [NMS(Index = 117, Size = 0x7, EnumType = typeof(GcTradingClass.TradingClassEnum))]
        /* 0x1F10 */ public Colour[] EconomyFilterTritanopiaColours;
        [NMS(Index = 106, Size = 0x7)]
        /* 0x1F80 */ public Colour[] GalacticWaypointDefaultColours;
        [NMS(Index = 108, Size = 0x7)]
        /* 0x1FF0 */ public Colour[] GalacticWaypointDeuteranopiaColours;
        [NMS(Index = 107, Size = 0x7)]
        /* 0x2060 */ public Colour[] GalacticWaypointProtanopiaColours;
        [NMS(Index = 109, Size = 0x7)]
        /* 0x20D0 */ public Colour[] GalacticWaypointTritanopiaColours;
        [NMS(Index = 162)]
        /* 0x2140 */ public GcGalaxyStarColours BaseStarDefaultColours;
        [NMS(Index = 164)]
        /* 0x2180 */ public GcGalaxyStarColours BaseStarDeuteranopiaColours;
        [NMS(Index = 163)]
        /* 0x21C0 */ public GcGalaxyStarColours BaseStarProtanopiaColours;
        [NMS(Index = 165)]
        /* 0x2200 */ public GcGalaxyStarColours BaseStarTritanopiaColours;
        [NMS(Index = 118, Size = 0x4, EnumType = typeof(GcPlayerConflictData.ConflictLevelEnum))]
        /* 0x2240 */ public Colour[] ConflictFilterDefaultColours;
        [NMS(Index = 120, Size = 0x4, EnumType = typeof(GcPlayerConflictData.ConflictLevelEnum))]
        /* 0x2280 */ public Colour[] ConflictFilterDeuteranopiaColours;
        [NMS(Index = 119, Size = 0x4, EnumType = typeof(GcPlayerConflictData.ConflictLevelEnum))]
        /* 0x22C0 */ public Colour[] ConflictFilterProtanopiaColours;
        [NMS(Index = 121, Size = 0x4, EnumType = typeof(GcPlayerConflictData.ConflictLevelEnum))]
        /* 0x2300 */ public Colour[] ConflictFilterTritanopiaColours;
        [NMS(Index = 157)]
        /* 0x2340 */ public GcGalaxyRenderAnostreakData AnostreakAway;
        [NMS(Index = 158)]
        /* 0x2370 */ public GcGalaxyRenderAnostreakData AnostreakFacing;
        [NMS(Index = 66)]
        /* 0x23A0 */ public GcInWorldUIScreenData HandMenuOffset;
        [NMS(Index = 56)]
        /* 0x23D0 */ public Colour HandGizmoColourAt;
        [NMS(Index = 65)]
        /* 0x23E0 */ public Colour HandGizmoColourInner;
        [NMS(Index = 57)]
        /* 0x23F0 */ public Colour HandGizmoColourRight;
        [NMS(Index = 58)]
        /* 0x2400 */ public Colour HandGizmoColourUp;
        [NMS(Index = 59)]
        /* 0x2410 */ public Vector3f HandGizmoHeadOffset;
        [NMS(Index = 160)]
        /* 0x2420 */ public Colour SelectionTreeColour;
        [NMS(Index = 166)]
        /* 0x2430 */ public GcGalaxyCameraData Camera;
        [NMS(Index = 177)]
        /* 0x249C */ public GcGalaxySolarSystemParams SolarSystemParameters;
        [NMS(Index = 167)]
        /* 0x24F4 */ public GcGalaxyAudioSetupData Audio;
        [NMS(Index = 2)]
        /* 0x2538 */ public Vector2f ClickToSelectIconOffset;
        [NMS(Index = 161)]
        /* 0x2540 */ public Vector2f GoalDistanceRange;
        [NMS(Index = 70)]
        /* 0x2548 */ public Vector2f SolarInfoPanelAlignment;
        [NMS(Index = 68)]
        /* 0x2550 */ public Vector2f SolarInfoPanelLineOffset;
        [NMS(Index = 67)]
        /* 0x2558 */ public Vector2f SolarInfoPanelOffset;
        [NMS(Index = 69)]
        /* 0x2560 */ public Vector2f SolarInfoPanelOffsetVR;
        [NMS(Index = 71)]
        /* 0x2568 */ public Vector2f SolarMarkerAlignmentVR;
        [NMS(Index = 75)]
        /* 0x2570 */ public Vector2f SolarMarkerOriginOffsetVR;
        [NMS(Index = 74)]
        /* 0x2578 */ public Vector2f SolarMarkerOriginOffsetVRPS4;
        [NMS(Index = 73)]
        /* 0x2580 */ public Vector2f SolarMarkerSizeVR;
        [NMS(Index = 72)]
        /* 0x2588 */ public Vector2f SolarMarkerSizeVRPS4;
        [NMS(Index = 154)]
        /* 0x2590 */ public float AnostreakAlpha;
        [NMS(Index = 3)]
        /* 0x2594 */ public float ClickToSelectIconScale;
        [NMS(Index = 141)]
        /* 0x2598 */ public float DistanceComputerScale;
        [NMS(Index = 139)]
        /* 0x259C */ public float EarlyStageMultiplier;
        [NMS(Index = 171)]
        /* 0x25A0 */ public float FadeGameInTime;
        [NMS(Index = 168)]
        /* 0x25A4 */ public float FadeGameOutTime;
        [NMS(Index = 169)]
        /* 0x25A8 */ public float FadeMapInTime;
        [NMS(Index = 170)]
        /* 0x25AC */ public float FadeMapOutTime;
        [NMS(Index = 81)]
        /* 0x25B0 */ public float FadeGameOutTimeCentreJourney;
        [NMS(Index = 82)]
        /* 0x25B4 */ public float FadeMapInTimeCentreJourney;
        [NMS(Index = 132)]
        /* 0x25B8 */ public float FinalFadedTime;
        [NMS(Index = 134)]
        /* 0x25BC */ public float FinalFadeInRate;
        [NMS(Index = 135)]
        /* 0x25C0 */ public float FinalFadeOutRate;
        [NMS(Index = 131)]
        /* 0x25C4 */ public float FinalHoldTime;
        [NMS(Index = 133)]
        /* 0x25C8 */ public float FinalHoldTowardsCenterTime;
        [NMS(Index = 137)]
        /* 0x25CC */ public float FinalTransitionAcceleration;
        [NMS(Index = 138)]
        /* 0x25D0 */ public float FinalTransitionInterpolationValue;
        [NMS(Index = 136)]
        /* 0x25D4 */ public float FinalTransitionMaxSpeed;
        [NMS(Index = 100)]
        /* 0x25D8 */ public float GalacticPathMaximumJumpDistanceLightyears;
        [NMS(Index = 101)]
        /* 0x25DC */ public float GalacticPathPreferGuideStarsTillJump;
        [NMS(Index = 44)]
        /* 0x25E0 */ public float HandControlDefaultOffset;
        [NMS(Index = 43)]
        /* 0x25E4 */ public float HandControlFreeMoveAngleOffset;
        [NMS(Index = 42)]
        /* 0x25E8 */ public float HandControlFreeMoveMaxOffset;
        [NMS(Index = 38)]
        /* 0x25EC */ public float HandControlGizmoScale;
        [NMS(Index = 47)]
        /* 0x25F0 */ public float HandControlMaxLockDistance;
        [NMS(Index = 39)]
        /* 0x25F4 */ public float HandControlMaxOffset;
        [NMS(Index = 46)]
        /* 0x25F8 */ public float HandControlMinLockDistance;
        [NMS(Index = 40)]
        /* 0x25FC */ public float HandControlMoveBlendRate;
        [NMS(Index = 34)]
        /* 0x2600 */ public float HandControlMoveSpeed;
        [NMS(Index = 35)]
        /* 0x2604 */ public float HandControlMoveSpeedTurbo;
        [NMS(Index = 33)]
        /* 0x2608 */ public float HandControlPitchSpeed;
        [NMS(Index = 36)]
        /* 0x260C */ public float HandControlPointerLength;
        [NMS(Index = 37)]
        /* 0x2610 */ public float HandControlPointerLengthMini;
        [NMS(Index = 41)]
        /* 0x2614 */ public float HandControlRotateBlendRate;
        [NMS(Index = 32)]
        /* 0x2618 */ public float HandControlRotateSpeed;
        [NMS(Index = 45)]
        /* 0x261C */ public float HandControlWarpSelectAngle;
        [NMS(Index = 55)]
        /* 0x2620 */ public float HandControlZoomSpeed;
        [NMS(Index = 63)]
        /* 0x2624 */ public float HandGizmoInnerRadius;
        [NMS(Index = 64)]
        /* 0x2628 */ public float HandGizmoInnerThickness;
        [NMS(Index = 62)]
        /* 0x262C */ public float HandGizmoLineThickness;
        [NMS(Index = 60)]
        /* 0x2630 */ public float HandGizmoMinAlpha;
        [NMS(Index = 61)]
        /* 0x2634 */ public float HandGizmoRadius;
        [NMS(Index = 50)]
        /* 0x2638 */ public float HandPitchFactorMin;
        [NMS(Index = 51)]
        /* 0x263C */ public float HandPitchFactorRange;
        [NMS(Index = 52)]
        /* 0x2640 */ public float HandPitchMaxDistance;
        [NMS(Index = 48)]
        /* 0x2644 */ public float HandTurnFactorMin;
        [NMS(Index = 49)]
        /* 0x2648 */ public float HandTurnFactorRange;
        [NMS(Index = 53)]
        /* 0x264C */ public float HandZoomFactorMin;
        [NMS(Index = 54)]
        /* 0x2650 */ public float HandZoomFactorRange;
        [NMS(Index = 16)]
        /* 0x2654 */ public float HexMarkerOuterWidth;
        [NMS(Index = 14)]
        /* 0x2658 */ public float HexMarkerRadius;
        [NMS(Index = 15)]
        /* 0x265C */ public float HexMarkerRotation;
        [NMS(Index = 13)]
        /* 0x2660 */ public float HexMarkerWidth;
        [NMS(Index = 10)]
        /* 0x2664 */ public float HexStackOffsetX;
        [NMS(Index = 11)]
        /* 0x2668 */ public float HexStackOffsetXOdd;
        [NMS(Index = 12)]
        /* 0x266C */ public float HexStackOffsetY;
        [NMS(Index = 127)]
        /* 0x2670 */ public float IntroCameraLookSmoothRate;
        [NMS(Index = 123)]
        /* 0x2674 */ public float IntroFadeInRate;
        [NMS(Index = 126)]
        /* 0x2678 */ public float IntroFadeOutRate;
        [NMS(Index = 124)]
        /* 0x267C */ public float IntroTitleFadeTrigger;
        [NMS(Index = 125)]
        /* 0x2680 */ public float IntroTitleHoldTime;
        [NMS(Index = 128)]
        /* 0x2684 */ public float IntroTitleTextureScale;
        [NMS(Index = 172)]
        /* 0x2688 */ public float LargeAreaColourScale;
        [NMS(Index = 142)]
        /* 0x268C */ public float LastSelectedPathAlphaMul;
        [NMS(Index = 95)]
        /* 0x2690 */ public float MarkerDropShadowMult;
        [NMS(Index = 94)]
        /* 0x2694 */ public float MarkerDropShadowSize;
        [NMS(Index = 9)]
        /* 0x2698 */ public float MenuCursorRadiusHmd;
        [NMS(Index = 6)]
        /* 0x269C */ public float MenuOffsetHmd;
        [NMS(Index = 5)]
        /* 0x26A0 */ public float MenuRotateHmd;
        [NMS(Index = 8)]
        /* 0x26A4 */ public float MenuScaleHmd;
        [NMS(Index = 7)]
        /* 0x26A8 */ public float MenuSideOffsetHmd;
        [NMS(Index = 140)]
        /* 0x26AC */ public float OffWorldDistance;
        [NMS(Index = 144)]
        /* 0x26B0 */ public float PathRenderingSelectedEndAlpha;
        [NMS(Index = 143)]
        /* 0x26B4 */ public float PathRenderingSelectedStartAlpha;
        [NMS(Index = 145)]
        /* 0x26B8 */ public float PathRenderingSelectedStepAlpha;
        [NMS(Index = 147)]
        /* 0x26BC */ public float PathRenderingUnselectedEndAlpha;
        [NMS(Index = 146)]
        /* 0x26C0 */ public float PathRenderingUnselectedStartAlpha;
        [NMS(Index = 148)]
        /* 0x26C4 */ public float PathRenderingUnselectedStepAlpha;
        [NMS(Index = 19)]
        /* 0x26C8 */ public float PathToTargetIndicatorTimeFactor;
        [NMS(Index = 18)]
        /* 0x26CC */ public float PathToTargetLineTimeFactor;
        [NMS(Index = 83)]
        /* 0x26D0 */ public float PathUIAlpha;
        [NMS(Index = 22)]
        /* 0x26D4 */ public float PathUIConfirmSelectionMultiplier;
        [NMS(Index = 84)]
        /* 0x26D8 */ public float PathUIDotLength;
        [NMS(Index = 85)]
        /* 0x26DC */ public float PathUIGapLength;
        [NMS(Index = 86)]
        /* 0x26E0 */ public float PathUIHeight;
        [NMS(Index = 24)]
        /* 0x26E4 */ public float PathUISelectionGenerosity;
        [NMS(Index = 29)]
        /* 0x26E8 */ public float PathUISelectionHandInvalidLength;
        [NMS(Index = 27)]
        /* 0x26EC */ public float PathUISelectionHandLineSelectAngle;
        [NMS(Index = 28)]
        /* 0x26F0 */ public float PathUISelectionHandSystemSelectAngle;
        [NMS(Index = 26)]
        /* 0x26F4 */ public float PathUISelectionMouseDeadZone;
        [NMS(Index = 25)]
        /* 0x26F8 */ public float PathUISelectionMouseSmoothRate;
        [NMS(Index = 21)]
        /* 0x26FC */ public float PathUISelectionMultiplierMouse;
        [NMS(Index = 20)]
        /* 0x2700 */ public float PathUISelectionMultiplierPad;
        [NMS(Index = 23)]
        /* 0x2704 */ public float PathUISelectionMultiplierPushing;
        [NMS(Index = 90)]
        /* 0x2708 */ public float PathUISlotRadiusInner;
        [NMS(Index = 91)]
        /* 0x270C */ public float PathUISlotRadiusOuter;
        [NMS(Index = 92)]
        /* 0x2710 */ public float PathUISlotRadiusRing;
        [NMS(Index = 89)]
        /* 0x2714 */ public float PathUISlotSpacing;
        [NMS(Index = 93)]
        /* 0x2718 */ public float PathUISlotWidthRing;
        [NMS(Index = 79)]
        /* 0x271C */ public float PathUIWidth;
        [NMS(Index = 87)]
        /* 0x2720 */ public float PathUIXOffset;
        [NMS(Index = 88)]
        /* 0x2724 */ public float PathUIYOffset;
        [NMS(Index = 96)]
        /* 0x2728 */ public float PlanetUIIconLargeScale;
        [NMS(Index = 97)]
        /* 0x272C */ public float PlanetUIIconMediumScale;
        [NMS(Index = 98)]
        /* 0x2730 */ public float PlanetUIIconSmallScale;
        [NMS(Index = 159)]
        /* 0x2734 */ public float SelectionTreeAlpha;
        [NMS(Index = 99)]
        /* 0x2738 */ public float ShowPopupAtCameraMinDistance;
        [NMS(Index = 102)]
        /* 0x273C */ public float ShowUIHelpDuration;
        [NMS(Index = 31)]
        /* 0x2740 */ public int SolarInfoPanelHeight;
        [NMS(Index = 77)]
        /* 0x2744 */ public float SolarInfoPanelScaleVR;
        [NMS(Index = 30)]
        /* 0x2748 */ public int SolarInfoPanelWidth;
        [NMS(Index = 78)]
        /* 0x274C */ public float SolarLabelScaleDistanceVR;
        [NMS(Index = 76)]
        /* 0x2750 */ public float SolarMarkerPanelScaleVR;
        [NMS(Index = 153)]
        /* 0x2754 */ public float StarBlurIntroMultiplier;
        [NMS(Index = 152)]
        /* 0x2758 */ public float StarBlurLineWidth;
        [NMS(Index = 150)]
        /* 0x275C */ public float StarBlurMaxBlurLength;
        [NMS(Index = 149)]
        /* 0x2760 */ public float StarBlurMaxDistanceFromCamera;
        [NMS(Index = 151)]
        /* 0x2764 */ public float StarBlurSizeMultiplier;
        [NMS(Index = 80)]
        /* 0x2768 */ public float StarPathUIWidth;
        [NMS(Index = 103)]
        /* 0x276C */ public float SystemInfoPanelGeneralAlpha;
        [NMS(Index = 4)]
        /* 0x2770 */ public float TimeForGalmapAutoNavModeSelectionInSeconds;
        [NMS(Index = 129)]
        /* 0x2774 */ public float TransitionTime;
        [NMS(Index = 17)]
        /* 0x2778 */ public NMSString0x80 MarkerDefaultHex;
        [NMS(Index = 155)]
        /* 0x27F8 */ public TkCurveType AnostreakAlphaCurve;
        [NMS(Index = 156)]
        /* 0x27F9 */ public TkCurveType AnostreakValueCurve;
        [NMS(Index = 1)]
        /* 0x27FA */ public bool GizmoOnHand;
        [NMS(Index = 105)]
        /* 0x27FB */ public TkCurveType MarkerPulseEndCurve;
        [NMS(Index = 104)]
        /* 0x27FC */ public TkCurveType MarkerPulseStartCurve;
        [NMS(Index = 0)]
        /* 0x27FD */ public bool NewStyleLookAtCamera;
        [NMS(Index = 130)]
        /* 0x27FE */ public TkCurveType TransitionOutCurve;
    }
}
