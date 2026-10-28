using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x6DE38517739201F9, NameHash = 0xA10A7EF5)]
    public class GcGalaxyGlobals : NMSTemplate
    {
        [NMS(Index = 124, Size = 0x11, EnumType = typeof(GcGalaxyMarkerTypes.GalaxyMarkerTypeEnum))]
        /* 0x0000 */ public GcGalaxyMarkerSettings[] MarkerSettings;
        [NMS(Index = 182)]
        /* 0x0BB0 */ public GcGalaxyRenderSetupData DefaultRenderSetup;
        [NMS(Index = 184)]
        /* 0x0EF0 */ public GcGalaxyRenderSetupData FinalAnimationRenderSetup;
        [NMS(Index = 183)]
        /* 0x1230 */ public GcGalaxyGenerationSetupData DefaultGeneration;
        [NMS(Index = 185)]
        /* 0x13B0 */ public GcGalaxyGenerationSetupData FinalAnimationGeneration;
        [NMS(Index = 112, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1530 */ public Colour[] RaceFilterDefaultColours;
        [NMS(Index = 114, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x15C0 */ public Colour[] RaceFilterDeuteranopiaColours;
        [NMS(Index = 113, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1650 */ public Colour[] RaceFilterProtanopiaColours;
        [NMS(Index = 115, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x16E0 */ public Colour[] RaceFilterTritanopiaColours;
        [NMS(Index = 116, Size = 0x7, EnumType = typeof(GcTradingClass.TradingClassEnum))]
        /* 0x1770 */ public Colour[] EconomyFilterDefaultColours;
        [NMS(Index = 118, Size = 0x7, EnumType = typeof(GcTradingClass.TradingClassEnum))]
        /* 0x17E0 */ public Colour[] EconomyFilterDeuteranopiaColours;
        [NMS(Index = 117, Size = 0x7, EnumType = typeof(GcTradingClass.TradingClassEnum))]
        /* 0x1850 */ public Colour[] EconomyFilterProtanopiaColours;
        [NMS(Index = 119, Size = 0x7, EnumType = typeof(GcTradingClass.TradingClassEnum))]
        /* 0x18C0 */ public Colour[] EconomyFilterTritanopiaColours;
        [NMS(Index = 108, Size = 0x7)]
        /* 0x1930 */ public Colour[] GalacticWaypointDefaultColours;
        [NMS(Index = 110, Size = 0x7)]
        /* 0x19A0 */ public Colour[] GalacticWaypointDeuteranopiaColours;
        [NMS(Index = 109, Size = 0x7)]
        /* 0x1A10 */ public Colour[] GalacticWaypointProtanopiaColours;
        [NMS(Index = 111, Size = 0x7)]
        /* 0x1A80 */ public Colour[] GalacticWaypointTritanopiaColours;
        [NMS(Index = 164)]
        /* 0x1AF0 */ public GcGalaxyStarColours BaseStarDefaultColours;
        [NMS(Index = 166)]
        /* 0x1B40 */ public GcGalaxyStarColours BaseStarDeuteranopiaColours;
        [NMS(Index = 165)]
        /* 0x1B90 */ public GcGalaxyStarColours BaseStarProtanopiaColours;
        [NMS(Index = 167)]
        /* 0x1BE0 */ public GcGalaxyStarColours BaseStarTritanopiaColours;
        [NMS(Index = 168)]
        /* 0x1C30 */ public GcGalaxyStarColours WarpTargetStarDefaultColours;
        [NMS(Index = 170)]
        /* 0x1C80 */ public GcGalaxyStarColours WarpTargetStarDeuteranopiaColours;
        [NMS(Index = 169)]
        /* 0x1CD0 */ public GcGalaxyStarColours WarpTargetStarProtanopiaColours;
        [NMS(Index = 171)]
        /* 0x1D20 */ public GcGalaxyStarColours WarpTargetStarTritanopiaColours;
        [NMS(Index = 120, Size = 0x4, EnumType = typeof(GcPlayerConflictData.ConflictLevelEnum))]
        /* 0x1D70 */ public Colour[] ConflictFilterDefaultColours;
        [NMS(Index = 122, Size = 0x4, EnumType = typeof(GcPlayerConflictData.ConflictLevelEnum))]
        /* 0x1DB0 */ public Colour[] ConflictFilterDeuteranopiaColours;
        [NMS(Index = 121, Size = 0x4, EnumType = typeof(GcPlayerConflictData.ConflictLevelEnum))]
        /* 0x1DF0 */ public Colour[] ConflictFilterProtanopiaColours;
        [NMS(Index = 123, Size = 0x4, EnumType = typeof(GcPlayerConflictData.ConflictLevelEnum))]
        /* 0x1E30 */ public Colour[] ConflictFilterTritanopiaColours;
        [NMS(Index = 159)]
        /* 0x1E70 */ public GcGalaxyRenderAnostreakData AnostreakAway;
        [NMS(Index = 160)]
        /* 0x1EA0 */ public GcGalaxyRenderAnostreakData AnostreakFacing;
        [NMS(Index = 68)]
        /* 0x1ED0 */ public GcInWorldUIScreenData HandMenuOffset;
        [NMS(Index = 58)]
        /* 0x1F00 */ public Colour HandGizmoColourAt;
        [NMS(Index = 67)]
        /* 0x1F10 */ public Colour HandGizmoColourInner;
        [NMS(Index = 59)]
        /* 0x1F20 */ public Colour HandGizmoColourRight;
        [NMS(Index = 60)]
        /* 0x1F30 */ public Colour HandGizmoColourUp;
        [NMS(Index = 61)]
        /* 0x1F40 */ public Vector3f HandGizmoHeadOffset;
        [NMS(Index = 162, MxmlName = "Selection Tree Colour")]
        /* 0x1F50 */ public Colour SelectionTreeColour;
        [NMS(Index = 17)]
        /* 0x1F60 */ public GcFilename MarkerDefaultHex;
        [NMS(Index = 175)]
        /* 0x1F70 */ public GcGalaxyCameraData Camera;
        [NMS(Index = 186)]
        /* 0x1FE0 */ public GcGalaxySolarSystemParams SolarSystemParameters;
        [NMS(Index = 176)]
        /* 0x203C */ public GcGalaxyAudioSetupData Audio;
        [NMS(Index = 2)]
        /* 0x2080 */ public Vector2f ClickToSelectIconOffset;
        [NMS(Index = 163, MxmlName = "Goal Distance Range")]
        /* 0x2088 */ public Vector2f GoalDistanceRange;
        [NMS(Index = 72)]
        /* 0x2090 */ public Vector2f SolarInfoPanelAlignment;
        [NMS(Index = 70)]
        /* 0x2098 */ public Vector2f SolarInfoPanelLineOffset;
        [NMS(Index = 69)]
        /* 0x20A0 */ public Vector2f SolarInfoPanelOffset;
        [NMS(Index = 71)]
        /* 0x20A8 */ public Vector2f SolarInfoPanelOffsetVR;
        [NMS(Index = 73)]
        /* 0x20B0 */ public Vector2f SolarMarkerAlignmentVR;
        [NMS(Index = 77)]
        /* 0x20B8 */ public Vector2f SolarMarkerOriginOffsetVR;
        [NMS(Index = 76)]
        /* 0x20C0 */ public Vector2f SolarMarkerOriginOffsetVRPS4;
        [NMS(Index = 75)]
        /* 0x20C8 */ public Vector2f SolarMarkerSizeVR;
        [NMS(Index = 74)]
        /* 0x20D0 */ public Vector2f SolarMarkerSizeVRPS4;
        [NMS(Index = 156, MxmlName = "Anostreak Alpha")]
        /* 0x20D8 */ public float AnostreakAlpha;
        [NMS(Index = 3)]
        /* 0x20DC */ public float ClickToSelectIconScale;
        [NMS(Index = 143, MxmlName = "Distance Computer Scale")]
        /* 0x20E0 */ public float DistanceComputerScale;
        [NMS(Index = 141, MxmlName = "Early Stage Multiplier")]
        /* 0x20E4 */ public float EarlyStageMultiplier;
        [NMS(Index = 180, MxmlName = "Fade Game In Time")]
        /* 0x20E8 */ public float FadeGameInTime;
        [NMS(Index = 177, MxmlName = "Fade Game Out Time")]
        /* 0x20EC */ public float FadeGameOutTime;
        [NMS(Index = 178, MxmlName = "Fade Map In Time")]
        /* 0x20F0 */ public float FadeMapInTime;
        [NMS(Index = 179, MxmlName = "Fade Map Out Time")]
        /* 0x20F4 */ public float FadeMapOutTime;
        [NMS(Index = 83)]
        /* 0x20F8 */ public float FadeGameOutTimeCentreJourney;
        [NMS(Index = 84)]
        /* 0x20FC */ public float FadeMapInTimeCentreJourney;
        [NMS(Index = 134)]
        /* 0x2100 */ public float FinalFadedTime;
        [NMS(Index = 136)]
        /* 0x2104 */ public float FinalFadeInRate;
        [NMS(Index = 137)]
        /* 0x2108 */ public float FinalFadeOutRate;
        [NMS(Index = 133)]
        /* 0x210C */ public float FinalHoldTime;
        [NMS(Index = 135)]
        /* 0x2110 */ public float FinalHoldTowardsCenterTime;
        [NMS(Index = 139)]
        /* 0x2114 */ public float FinalTransitionAcceleration;
        [NMS(Index = 140)]
        /* 0x2118 */ public float FinalTransitionInterpolationValue;
        [NMS(Index = 138)]
        /* 0x211C */ public float FinalTransitionMaxSpeed;
        [NMS(Index = 174)]
        /* 0x2120 */ public GcGalaxyStarTypes ForcedWarpTargetStarColour;
        [NMS(Index = 102)]
        /* 0x2124 */ public float GalacticPathMaximumJumpDistanceLightyears;
        [NMS(Index = 103)]
        /* 0x2128 */ public float GalacticPathPreferGuideStarsTillJump;
        [NMS(Index = 46)]
        /* 0x212C */ public float HandControlDefaultOffset;
        [NMS(Index = 45)]
        /* 0x2130 */ public float HandControlFreeMoveAngleOffset;
        [NMS(Index = 44)]
        /* 0x2134 */ public float HandControlFreeMoveMaxOffset;
        [NMS(Index = 40)]
        /* 0x2138 */ public float HandControlGizmoScale;
        [NMS(Index = 49)]
        /* 0x213C */ public float HandControlMaxLockDistance;
        [NMS(Index = 41)]
        /* 0x2140 */ public float HandControlMaxOffset;
        [NMS(Index = 48)]
        /* 0x2144 */ public float HandControlMinLockDistance;
        [NMS(Index = 42)]
        /* 0x2148 */ public float HandControlMoveBlendRate;
        [NMS(Index = 36)]
        /* 0x214C */ public float HandControlMoveSpeed;
        [NMS(Index = 37)]
        /* 0x2150 */ public float HandControlMoveSpeedTurbo;
        [NMS(Index = 35)]
        /* 0x2154 */ public float HandControlPitchSpeed;
        [NMS(Index = 38)]
        /* 0x2158 */ public float HandControlPointerLength;
        [NMS(Index = 39)]
        /* 0x215C */ public float HandControlPointerLengthMini;
        [NMS(Index = 43)]
        /* 0x2160 */ public float HandControlRotateBlendRate;
        [NMS(Index = 34)]
        /* 0x2164 */ public float HandControlRotateSpeed;
        [NMS(Index = 47)]
        /* 0x2168 */ public float HandControlWarpSelectAngle;
        [NMS(Index = 57)]
        /* 0x216C */ public float HandControlZoomSpeed;
        [NMS(Index = 65)]
        /* 0x2170 */ public float HandGizmoInnerRadius;
        [NMS(Index = 66)]
        /* 0x2174 */ public float HandGizmoInnerThickness;
        [NMS(Index = 64)]
        /* 0x2178 */ public float HandGizmoLineThickness;
        [NMS(Index = 62)]
        /* 0x217C */ public float HandGizmoMinAlpha;
        [NMS(Index = 63)]
        /* 0x2180 */ public float HandGizmoRadius;
        [NMS(Index = 52)]
        /* 0x2184 */ public float HandPitchFactorMin;
        [NMS(Index = 53)]
        /* 0x2188 */ public float HandPitchFactorRange;
        [NMS(Index = 54)]
        /* 0x218C */ public float HandPitchMaxDistance;
        [NMS(Index = 50)]
        /* 0x2190 */ public float HandTurnFactorMin;
        [NMS(Index = 51)]
        /* 0x2194 */ public float HandTurnFactorRange;
        [NMS(Index = 55)]
        /* 0x2198 */ public float HandZoomFactorMin;
        [NMS(Index = 56)]
        /* 0x219C */ public float HandZoomFactorRange;
        [NMS(Index = 16)]
        /* 0x21A0 */ public float HexMarkerOuterWidth;
        [NMS(Index = 14)]
        /* 0x21A4 */ public float HexMarkerRadius;
        [NMS(Index = 15)]
        /* 0x21A8 */ public float HexMarkerRotation;
        [NMS(Index = 13)]
        /* 0x21AC */ public float HexMarkerWidth;
        [NMS(Index = 10)]
        /* 0x21B0 */ public float HexStackOffsetX;
        [NMS(Index = 11)]
        /* 0x21B4 */ public float HexStackOffsetXOdd;
        [NMS(Index = 12)]
        /* 0x21B8 */ public float HexStackOffsetY;
        [NMS(Index = 129)]
        /* 0x21BC */ public float IntroCameraLookSmoothRate;
        [NMS(Index = 125)]
        /* 0x21C0 */ public float IntroFadeInRate;
        [NMS(Index = 128)]
        /* 0x21C4 */ public float IntroFadeOutRate;
        [NMS(Index = 126)]
        /* 0x21C8 */ public float IntroTitleFadeTrigger;
        [NMS(Index = 127)]
        /* 0x21CC */ public float IntroTitleHoldTime;
        [NMS(Index = 130)]
        /* 0x21D0 */ public float IntroTitleTextureScale;
        [NMS(Index = 181, MxmlName = "Large Area Colour Scale")]
        /* 0x21D4 */ public float LargeAreaColourScale;
        [NMS(Index = 144)]
        /* 0x21D8 */ public float LastSelectedPathAlphaMul;
        [NMS(Index = 97)]
        /* 0x21DC */ public float MarkerDropShadowMult;
        [NMS(Index = 96)]
        /* 0x21E0 */ public float MarkerDropShadowSize;
        [NMS(Index = 9)]
        /* 0x21E4 */ public float MenuCursorRadiusHmd;
        [NMS(Index = 6)]
        /* 0x21E8 */ public float MenuOffsetHmd;
        [NMS(Index = 5)]
        /* 0x21EC */ public float MenuRotateHmd;
        [NMS(Index = 8)]
        /* 0x21F0 */ public float MenuScaleHmd;
        [NMS(Index = 7)]
        /* 0x21F4 */ public float MenuSideOffsetHmd;
        [NMS(Index = 188)]
        /* 0x21F8 */ public float NearbySystemStarBrightness;
        [NMS(Index = 187)]
        /* 0x21FC */ public float NearbySystemStarSize;
        [NMS(Index = 142, MxmlName = "OffWorld Distance")]
        /* 0x2200 */ public float OffWorldDistance;
        [NMS(Index = 146, MxmlName = "Path Rendering Selected End Alpha")]
        /* 0x2204 */ public float PathRenderingSelectedEndAlpha;
        [NMS(Index = 145, MxmlName = "Path Rendering Selected Start Alpha")]
        /* 0x2208 */ public float PathRenderingSelectedStartAlpha;
        [NMS(Index = 147, MxmlName = "Path Rendering Selected Step Alpha")]
        /* 0x220C */ public float PathRenderingSelectedStepAlpha;
        [NMS(Index = 149, MxmlName = "Path Rendering Unselected End Alpha")]
        /* 0x2210 */ public float PathRenderingUnselectedEndAlpha;
        [NMS(Index = 148, MxmlName = "Path Rendering Unselected Start Alpha")]
        /* 0x2214 */ public float PathRenderingUnselectedStartAlpha;
        [NMS(Index = 150, MxmlName = "Path Rendering Unselected Step Alpha")]
        /* 0x2218 */ public float PathRenderingUnselectedStepAlpha;
        [NMS(Index = 19)]
        /* 0x221C */ public float PathToTargetIndicatorTimeFactor;
        [NMS(Index = 18)]
        /* 0x2220 */ public float PathToTargetLineTimeFactor;
        [NMS(Index = 85)]
        /* 0x2224 */ public float PathUIAlpha;
        [NMS(Index = 22)]
        /* 0x2228 */ public float PathUIConfirmSelectionMultiplier;
        [NMS(Index = 86)]
        /* 0x222C */ public float PathUIDotLength;
        [NMS(Index = 87)]
        /* 0x2230 */ public float PathUIGapLength;
        [NMS(Index = 88)]
        /* 0x2234 */ public float PathUIHeight;
        [NMS(Index = 24)]
        /* 0x2238 */ public float PathUISelectionGenerosity;
        [NMS(Index = 29)]
        /* 0x223C */ public float PathUISelectionHandInvalidLength;
        [NMS(Index = 27)]
        /* 0x2240 */ public float PathUISelectionHandLineSelectAngle;
        [NMS(Index = 28)]
        /* 0x2244 */ public float PathUISelectionHandSystemSelectAngle;
        [NMS(Index = 26)]
        /* 0x2248 */ public float PathUISelectionMouseDeadZone;
        [NMS(Index = 25)]
        /* 0x224C */ public float PathUISelectionMouseSmoothRate;
        [NMS(Index = 21)]
        /* 0x2250 */ public float PathUISelectionMultiplierMouse;
        [NMS(Index = 20)]
        /* 0x2254 */ public float PathUISelectionMultiplierPad;
        [NMS(Index = 23)]
        /* 0x2258 */ public float PathUISelectionMultiplierPushing;
        [NMS(Index = 92)]
        /* 0x225C */ public float PathUISlotRadiusInner;
        [NMS(Index = 93)]
        /* 0x2260 */ public float PathUISlotRadiusOuter;
        [NMS(Index = 94)]
        /* 0x2264 */ public float PathUISlotRadiusRing;
        [NMS(Index = 91)]
        /* 0x2268 */ public float PathUISlotSpacing;
        [NMS(Index = 95)]
        /* 0x226C */ public float PathUISlotWidthRing;
        [NMS(Index = 81)]
        /* 0x2270 */ public float PathUIWidth;
        [NMS(Index = 89)]
        /* 0x2274 */ public float PathUIXOffset;
        [NMS(Index = 90)]
        /* 0x2278 */ public float PathUIYOffset;
        [NMS(Index = 98)]
        /* 0x227C */ public float PlanetUIIconLargeScale;
        [NMS(Index = 99)]
        /* 0x2280 */ public float PlanetUIIconMediumScale;
        [NMS(Index = 100)]
        /* 0x2284 */ public float PlanetUIIconSmallScale;
        [NMS(Index = 32)]
        /* 0x2288 */ public float PurpleRevealFixedZoom;
        [NMS(Index = 33)]
        /* 0x228C */ public float PurpleStarRevealAnimTime;
        [NMS(Index = 161, MxmlName = "Selection Tree Alpha")]
        /* 0x2290 */ public float SelectionTreeAlpha;
        [NMS(Index = 101)]
        /* 0x2294 */ public float ShowPopupAtCameraMinDistance;
        [NMS(Index = 104)]
        /* 0x2298 */ public float ShowUIHelpDuration;
        [NMS(Index = 31)]
        /* 0x229C */ public int SolarInfoPanelHeight;
        [NMS(Index = 79)]
        /* 0x22A0 */ public float SolarInfoPanelScaleVR;
        [NMS(Index = 30)]
        /* 0x22A4 */ public int SolarInfoPanelWidth;
        [NMS(Index = 80)]
        /* 0x22A8 */ public float SolarLabelScaleDistanceVR;
        [NMS(Index = 78)]
        /* 0x22AC */ public float SolarMarkerPanelScaleVR;
        [NMS(Index = 155, MxmlName = "Star Blur Intro Multiplier")]
        /* 0x22B0 */ public float StarBlurIntroMultiplier;
        [NMS(Index = 154, MxmlName = "Star Blur Line Width")]
        /* 0x22B4 */ public float StarBlurLineWidth;
        [NMS(Index = 152, MxmlName = "Star Blur Max Blur Length")]
        /* 0x22B8 */ public float StarBlurMaxBlurLength;
        [NMS(Index = 151, MxmlName = "Star Blur Max Distance From Camera")]
        /* 0x22BC */ public float StarBlurMaxDistanceFromCamera;
        [NMS(Index = 153, MxmlName = "Star Blur Size Multiplier")]
        /* 0x22C0 */ public float StarBlurSizeMultiplier;
        [NMS(Index = 82)]
        /* 0x22C4 */ public float StarPathUIWidth;
        [NMS(Index = 105)]
        /* 0x22C8 */ public float SystemInfoPanelGeneralAlpha;
        [NMS(Index = 4)]
        /* 0x22CC */ public float TimeForGalmapAutoNavModeSelectionInSeconds;
        [NMS(Index = 131, MxmlName = "Transition Time")]
        /* 0x22D0 */ public float TransitionTime;
        [NMS(Index = 157, MxmlName = "Anostreak Alpha Curve")]
        /* 0x22D4 */ public TkCurveType AnostreakAlphaCurve;
        [NMS(Index = 158, MxmlName = "Anostreak Value Curve")]
        /* 0x22D5 */ public TkCurveType AnostreakValueCurve;
        [NMS(Index = 1)]
        /* 0x22D6 */ public bool GizmoOnHand;
        [NMS(Index = 172)]
        /* 0x22D7 */ public bool LiveEditWarpStarColours;
        [NMS(Index = 107)]
        /* 0x22D8 */ public TkCurveType MarkerPulseEndCurve;
        [NMS(Index = 106)]
        /* 0x22D9 */ public TkCurveType MarkerPulseStartCurve;
        [NMS(Index = 0)]
        /* 0x22DA */ public bool NewStyleLookAtCamera;
        [NMS(Index = 173)]
        /* 0x22DB */ public bool ShouldForceWarpTargetStarColour;
        [NMS(Index = 132)]
        /* 0x22DC */ public TkCurveType TransitionOutCurve;
    }
}
