namespace libMBIN.Models.Structs
{
    public class GcGalaxyGlobals : NMSTemplate
    {
        /* 0x0 */ public float PathUIWidth;
        /* 0x4 */ public float StarPathUIWidth;
        /* 0x8 */ public float FadeGameOutTimeCentreJourney;
        /* 0xC */ public float FadeMapInTimeCentreJourney;
        /* 0x10 */ public float PathUIAlpha;
        /* 0x14 */ public float PathUIDotLength;
        /* 0x18 */ public float PathUIGapLength;
        /* 0x1C */ public float PathUISelectionMultiplierPad;
        /* 0x20 */ public float PathUISelectionMultiplierMouse;
        /* 0x24 */ public float PathUISelectionMultiplierPushing;
        /* 0x28 */ public float PathUISelectionGenerosity;
        /* 0x2C */ public float PathUISelectionMouseSmoothRate;
        /* 0x30 */ public float PathUISelectionMouseDeadZone;
        /* 0x34 */ public float PathUIHeight;
        /* 0x38 */ public float PathUIXOffset;
        /* 0x3C */ public float PathUIYOffset;
        /* 0x40 */ public float PathUISlotSpacing;
        /* 0x44 */ public float PathUISlotRadiusInner;
        /* 0x48 */ public float PathUISlotRadiusOuter;
        /* 0x4C */ public float PathUISlotRadiusRing;
        /* 0x50 */ public float PathUISlotWidthRing;
        /* 0x54 */ public float MarkerDropShadowSize;
        /* 0x58 */ public float MarkerDropShadowMult;
        /* 0x5C */ public float PlanetUIIconLargeScale;
        /* 0x60 */ public float PlanetUIIconMediumScale;
        /* 0x64 */ public float PlanetUIIconSmallScale;
        /* 0x68 */ public float ShowPopupAtCameraMinDistance;
        /* 0x6C */ public float GalacticPathMaximumJumpDistanceLightyears;
        /* 0x70 */ public float GalacticPathPreferGuideStarsTillJump;
        /* 0x74 */ public float ShowUIHelpDuration;
        /* 0x78 */ public float SystemInfoPanelGeneralAlpha;
        /* 0x7C */ public TkCurveType MarkerPulseStartCurve;
        /* 0x80 */ public TkCurveType MarkerPulseEndCurve;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x84 */ public byte[] Padding84;
        [NMS(Size = 0x6)]
        /* 0x90 */ public Colour[] GalacticWaypointColours;
        [NMS(Size = 0x7)]
        /* 0xF0 */ public Colour[] RaceFilterColours;
        [NMS(Size = 0x7)]
        /* 0x160 */ public Colour[] EconomyFilterColours;
        [NMS(Size = 0x3)]
        /* 0x1D0 */ public Colour[] ConflictFilterColours;
        [NMS(Size = 0xD)]
        /* 0x200 */ public GcGalaxyMarkerSettings[] MarkerSettings;
        /* 0x10A0 */ public float IntroFadeInRate;
        /* 0x10A4 */ public float IntroTitleFadeTrigger;
        /* 0x10A8 */ public float IntroTitleHoldTime;
        /* 0x10AC */ public float IntroFadeOutRate;
        /* 0x10B0 */ public float IntroCameraLookSmoothRate;
        /* 0x10B4 */ public float IntroTitleTextureScale;
        /* 0x10B8 */ public float TransitionTime;
        /* 0x10BC */ public float TransitionOutCurve;
        /* 0x10C0 */ public float FinalHoldTime;
        /* 0x10C4 */ public float FinalFadedTime;
        /* 0x10C8 */ public float FinalHoldTowardsCenterTime;
        /* 0x10CC */ public float FinalFadeInRate;
        /* 0x10D0 */ public float FinalFadeOutRate;
        /* 0x10D4 */ public float FinalTransitionMaxSpeed;
        /* 0x10D8 */ public float FinalTransitionAcceleration;
        /* 0x10DC */ public float FinalTransitionInterpolationValue;
        /* 0x10E0 */ public float EarlyStageMultiplier;
        /* 0x10E4 */ public float OffWorldDistance;
        /* 0x10E8 */ public float DistanceComputerScale;
        /* 0x10EC */ public float PathRenderingSelectedStartAlpha;
        /* 0x10F0 */ public float PathRenderingSelectedEndAlpha;
        /* 0x10F4 */ public float PathRenderingSelectedStepAlpha;
        /* 0x10F8 */ public float PathRenderingUnselectedStartAlpha;
        /* 0x10FC */ public float PathRenderingUnselectedEndAlpha;
        /* 0x1100 */ public float PathRenderingUnselectedStepAlpha;
        /* 0x1104 */ public float StarBlurMaxDistanceFromCamera;
        /* 0x1108 */ public float StarBlurMaxBlurLength;
        /* 0x110C */ public float StarBlurSizeMultiplier;
        /* 0x1110 */ public float StarBlurLineWidth;
        /* 0x1114 */ public float StarBlurIntroMultiplier;
        /* 0x1118 */ public float AnostreakAlpha;
        /* 0x111C */ public TkCurveType AnostreakAlphaCurve;
        /* 0x1120 */ public TkCurveType AnostreakValueCurve;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x1124 */ public byte[] Padding1124;
        /* 0x1130 */ public GcGalaxyRenderAnostreakData AnostreakAway;
        /* 0x1160 */ public GcGalaxyRenderAnostreakData AnostreakFacing;
        /* 0x1190 */ public float SelectionTreeAlpha;
        /* 0x11A0 */ public Colour SelectionTreeColour;
        /* 0x11B0 */ public Vector2f GoalDistanceRange;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x11B8 */ public byte[] Padding11B8;
        /* 0x11C0 */ public GcGalaxyStarColours BaseStarColours;
        /* 0x1200 */ public GcGalaxyCameraData Camera;
        /* 0x1264 */ public GcGalaxyAudioSetupData Audio;
        /* 0x12A8 */ public float FadeGameOutTime;
        /* 0x12AC */ public float FadeMapInTime;
        /* 0x12B0 */ public float FadeMapOutTime;
        /* 0x12B4 */ public float FadeGameInTime;
        /* 0x12B8 */ public float LargeAreaColourScale;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x12BC */ public byte[] Padding12BC;
        /* 0x12C0 */ public GcGalaxyRenderSetupData DefaultRenderSetup;
        /* 0x14D0 */ public GcGalaxyGenerationSetupData DefaultGeneration;
        /* 0x1650 */ public GcGalaxyRenderSetupData FinalAnimationRenderSetup;
        /* 0x1860 */ public GcGalaxyGenerationSetupData FinalAnimationGeneration;
        /* 0x19E0 */ public GcGalaxySolarSystemParams SolarSystemParameters;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x1A38 */ public byte[] EndPadding;
    }
}
