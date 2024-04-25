using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xE49AEAEF27F6C070, NameHash = 0xB24409E83457E875)]
    public class GcGraphicsGlobals : NMSTemplate
    {
        [NMS(Index = 52)]
        /* 0x000 */ public TkImGuiSettings ImGui;
        [NMS(Index = 256, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x190 */ public Vector4f[] ShellsSettings;
        [NMS(Index = 251, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x1D0 */ public Vector4f[] TessSettings;
        [NMS(Index = 6)]
        /* 0x210 */ public GcLightShaftProperties LightShaftProperties;
        [NMS(Index = 7)]
        /* 0x240 */ public GcLightShaftProperties StormLightShaftProperties;
        [NMS(Index = 178)]
        /* 0x270 */ public Vector4f LensParams;
        [NMS(Index = 177)]
        /* 0x280 */ public Vector4f MipLevelDebug;
        [NMS(Index = 49)]
        /* 0x290 */ public Colour ScanColour;
        [NMS(Index = 84)]
        /* 0x2A0 */ public Vector4f ShadowBias;
        [NMS(Index = 79)]
        /* 0x2B0 */ public Vector4f ShadowSplit;
        [NMS(Index = 83)]
        /* 0x2C0 */ public Vector4f ShadowSplitCameraView;
        [NMS(Index = 80)]
        /* 0x2D0 */ public Vector4f ShadowSplitShip;
        [NMS(Index = 81)]
        /* 0x2E0 */ public Vector4f ShadowSplitSpace;
        [NMS(Index = 82)]
        /* 0x2F0 */ public Vector4f ShadowSplitStation;
        [NMS(Index = 250)]
        /* 0x300 */ public Vector4f TaaSettings;
        [NMS(Index = 254)]
        /* 0x310 */ public Vector4f TerrainMipDistanceHigh;
        [NMS(Index = 252)]
        /* 0x320 */ public Vector4f TerrainMipDistanceLow;
        [NMS(Index = 253)]
        /* 0x330 */ public Vector4f TerrainMipDistanceMed;
        [NMS(Index = 255)]
        /* 0x340 */ public Vector4f TerrainMipDistanceUlt;
        [NMS(Index = 53)]
        /* 0x350 */ public Colour UIColour;
        [NMS(Index = 54)]
        /* 0x360 */ public Colour UIShipColour;
        [NMS(Index = 180)]
        /* 0x370 */ public Colour VerticalColourBottom;
        [NMS(Index = 179)]
        /* 0x380 */ public Colour VerticalColourTop;
        [NMS(Index = 181)]
        /* 0x390 */ public Vector4f VerticalGradient;
        [NMS(Index = 284)]
        /* 0x3A0 */ public List<int> CascadeRenderSequence;
        [NMS(Index = 303, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x3B0 */ public TkGraphicsDetailPreset[] GraphicsDetailPresetsPC;
        [NMS(Index = 315)]
        /* 0x500 */ public TkGraphicsDetailPreset GraphicsDetailPresetiOS;
        [NMS(Index = 314)]
        /* 0x554 */ public TkGraphicsDetailPreset GraphicsDetailPresetMacOS;
        [NMS(Index = 311)]
        /* 0x5A8 */ public TkGraphicsDetailPreset GraphicsDetailPresetNX64Handheld;
        [NMS(Index = 310)]
        /* 0x5FC */ public TkGraphicsDetailPreset GraphicsDetailPresetOberon;
        [NMS(Index = 304)]
        /* 0x650 */ public TkGraphicsDetailPreset GraphicsDetailPresetPS4;
        [NMS(Index = 306)]
        /* 0x6A4 */ public TkGraphicsDetailPreset GraphicsDetailPresetPS4Pro;
        [NMS(Index = 307)]
        /* 0x6F8 */ public TkGraphicsDetailPreset GraphicsDetailPresetPS4ProVR;
        [NMS(Index = 305)]
        /* 0x74C */ public TkGraphicsDetailPreset GraphicsDetailPresetPS4VR;
        [NMS(Index = 312)]
        /* 0x7A0 */ public TkGraphicsDetailPreset GraphicsDetailPresetPS5;
        [NMS(Index = 313)]
        /* 0x7F4 */ public TkGraphicsDetailPreset GraphicsDetailPresetPS5VR;
        [NMS(Index = 308)]
        /* 0x848 */ public TkGraphicsDetailPreset GraphicsDetailPresetXB1;
        [NMS(Index = 309)]
        /* 0x89C */ public TkGraphicsDetailPreset GraphicsDetailPresetXB1X;
        [NMS(Index = 317, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x8F0 */ public float[] VariableUpdatePeriodModifers;
        [NMS(Index = 203)]
        /* 0x900 */ public Vector2f WindDir1;
        [NMS(Index = 204)]
        /* 0x908 */ public Vector2f WindDir2;
        [NMS(Index = 230)]
        /* 0x910 */ public float AlphaCutoutMax;
        [NMS(Index = 229)]
        /* 0x914 */ public float AlphaCutoutMin;
        [NMS(Index = 205)]
        /* 0x918 */ public float AtmosphereSize;
        [NMS(Index = 12)]
        /* 0x91C */ public float Brightness;
        [NMS(Index = 13)]
        /* 0x920 */ public float Contrast;
        [NMS(Index = 70)]
        /* 0x924 */ public float DirectionLightFOV;
        [NMS(Index = 69)]
        /* 0x928 */ public float DirectionLightRadius;
        [NMS(Index = 71)]
        /* 0x92C */ public float DirectionLightShadowBias;
        [NMS(Index = 113)]
        /* 0x930 */ public float DOFAmountManual;
        [NMS(Index = 117)]
        /* 0x934 */ public float DOFAmountManualFull;
        [NMS(Index = 115)]
        /* 0x938 */ public float DOFAmountManualFullIndoor;
        [NMS(Index = 116)]
        /* 0x93C */ public float DOFAmountManualLight;
        [NMS(Index = 114)]
        /* 0x940 */ public float DOFAmountManualLightIndoor;
        [NMS(Index = 131)]
        /* 0x944 */ public float DOFAutoFarAmount;
        [NMS(Index = 133)]
        /* 0x948 */ public float DOFAutoFarFarPlane;
        [NMS(Index = 132)]
        /* 0x94C */ public float DOFAutoFarFarPlaneFade;
        [NMS(Index = 134)]
        /* 0x950 */ public float DOFAutoFarNearPlane;
        [NMS(Index = 120)]
        /* 0x954 */ public float DOFFarFadeDistance;
        [NMS(Index = 122)]
        /* 0x958 */ public float DOFFarFadeDistanceCave;
        [NMS(Index = 138)]
        /* 0x95C */ public float DOFFarFadeDistanceInteraction;
        [NMS(Index = 130)]
        /* 0x960 */ public float DOFFarFadeDistanceManual;
        [NMS(Index = 129)]
        /* 0x964 */ public float DOFFarFadeDistanceManualIndoor;
        [NMS(Index = 124)]
        /* 0x968 */ public float DOFFarFadeDistanceSpace;
        [NMS(Index = 127)]
        /* 0x96C */ public float DOFFarFadeDistanceWater;
        [NMS(Index = 112)]
        /* 0x970 */ public float DOFFarPlane;
        [NMS(Index = 121)]
        /* 0x974 */ public float DOFFarPlaneCave;
        [NMS(Index = 137)]
        /* 0x978 */ public float DOFFarPlaneInteraction;
        [NMS(Index = 128)]
        /* 0x97C */ public float DOFFarPlaneManual;
        [NMS(Index = 123)]
        /* 0x980 */ public float DOFFarPlaneSpace;
        [NMS(Index = 126)]
        /* 0x984 */ public float DOFFarPlaneWater;
        [NMS(Index = 125)]
        /* 0x988 */ public float DOFFarStrengthWater;
        [NMS(Index = 136)]
        /* 0x98C */ public float DOFNearAdjustInteraction;
        [NMS(Index = 118)]
        /* 0x990 */ public float DOFNearFadeDistance;
        [NMS(Index = 119)]
        /* 0x994 */ public float DOFNearFadeDistanceManual;
        [NMS(Index = 135)]
        /* 0x998 */ public float DOFNearMinInteraction;
        [NMS(Index = 111)]
        /* 0x99C */ public float DOFNearPlane;
        [NMS(Index = 63)]
        /* 0x9A0 */ public float FarClipDistance;
        [NMS(Index = 213)]
        /* 0x9A4 */ public float FoliageSaturationMax;
        [NMS(Index = 212)]
        /* 0x9A8 */ public float FoliageSaturationMin;
        [NMS(Index = 215)]
        /* 0x9AC */ public float FoliageValueMax;
        [NMS(Index = 214)]
        /* 0x9B0 */ public float FoliageValueMin;
        [NMS(Index = 241)]
        /* 0x9B4 */ public float FrustumJitterAmount;
        [NMS(Index = 242)]
        /* 0x9B8 */ public float FrustumJitterAmountDLSS;
        [NMS(Index = 217)]
        /* 0x9BC */ public float GrassSaturationMax;
        [NMS(Index = 216)]
        /* 0x9C0 */ public float GrassSaturationMin;
        [NMS(Index = 219)]
        /* 0x9C4 */ public float GrassValueMax;
        [NMS(Index = 218)]
        /* 0x9C8 */ public float GrassValueMin;
        [NMS(Index = 3)]
        /* 0x9CC */ public float HBAOBias;
        [NMS(Index = 5)]
        /* 0x9D0 */ public float HBAOIntensity;
        [NMS(Index = 4)]
        /* 0x9D4 */ public float HBAORadius;
        [NMS(Index = 92)]
        /* 0x9D8 */ public float HDRExposure;
        [NMS(Index = 104)]
        /* 0x9DC */ public float HDRExposureCave;
        [NMS(Index = 93)]
        /* 0x9E0 */ public float HDRGamma;
        [NMS(Index = 94)]
        /* 0x9E4 */ public float HDRLutExposure;
        [NMS(Index = 95)]
        /* 0x9E8 */ public float HDRLutGamma;
        [NMS(Index = 96)]
        /* 0x9EC */ public float HDRLutToe;
        [NMS(Index = 98)]
        /* 0x9F0 */ public float HDROffset;
        [NMS(Index = 106)]
        /* 0x9F4 */ public float HDROffsetCave;
        [NMS(Index = 97)]
        /* 0x9F8 */ public float HDRThreshold;
        [NMS(Index = 105)]
        /* 0x9FC */ public float HDRThresholdCave;
        [NMS(Index = 61)]
        /* 0xA00 */ public float HUDDistance;
        [NMS(Index = 60)]
        /* 0xA04 */ public float HUDMotionPos;
        [NMS(Index = 57)]
        /* 0xA08 */ public float HUDMotionPosSpring;
        [NMS(Index = 58)]
        /* 0xA0C */ public float HUDMotionX;
        [NMS(Index = 55)]
        /* 0xA10 */ public float HUDMotionXSpring;
        [NMS(Index = 59)]
        /* 0xA14 */ public float HUDMotionY;
        [NMS(Index = 56)]
        /* 0xA18 */ public float HUDMotionYSpring;
        [NMS(Index = 209)]
        /* 0xA1C */ public float HueVariance;
        [NMS(Index = 102)]
        /* 0xA20 */ public float LensDirt;
        [NMS(Index = 110)]
        /* 0xA24 */ public float LensDirtCave;
        [NMS(Index = 100)]
        /* 0xA28 */ public float LensOffset;
        [NMS(Index = 108)]
        /* 0xA2C */ public float LensOffsetCave;
        [NMS(Index = 101)]
        /* 0xA30 */ public float LensScale;
        [NMS(Index = 109)]
        /* 0xA34 */ public float LensScaleCave;
        [NMS(Index = 99)]
        /* 0xA38 */ public float LensThreshold;
        [NMS(Index = 107)]
        /* 0xA3C */ public float LensThresholdCave;
        [NMS(Index = 165)]
        /* 0xA40 */ public float LowHealthDesaturationIntensityMax;
        [NMS(Index = 164)]
        /* 0xA44 */ public float LowHealthDesaturationIntensityMin;
        [NMS(Index = 166)]
        /* 0xA48 */ public float LowHealthDesaturationIntensityTimeSinceHit;
        [NMS(Index = 168)]
        /* 0xA4C */ public float LowHealthFadeInTime;
        [NMS(Index = 169)]
        /* 0xA50 */ public float LowHealthFadeOutTime;
        [NMS(Index = 167)]
        /* 0xA54 */ public float LowHealthOverlayIntensity;
        [NMS(Index = 171)]
        /* 0xA58 */ public float LowHealthPulseRateFullShield;
        [NMS(Index = 170)]
        /* 0xA5C */ public float LowHealthPulseRateLowShield;
        [NMS(Index = 173)]
        /* 0xA60 */ public float LowHealthStrengthFullShield;
        [NMS(Index = 172)]
        /* 0xA64 */ public float LowHealthStrengthLowShield;
        [NMS(Index = 163)]
        /* 0xA68 */ public float LowHealthVignetteEnd;
        [NMS(Index = 162)]
        /* 0xA6C */ public float LowHealthVignetteStart;
        [NMS(Index = 0)]
        /* 0xA70 */ public float LUTDistanceFlightMultiplier;
        [NMS(Index = 234)]
        /* 0xA74 */ public float MaxParticleRenderRange;
        [NMS(Index = 235)]
        /* 0xA78 */ public float MaxParticleRenderRangeSpace;
        [NMS(Index = 227)]
        /* 0xA7C */ public float MaxSpaceFogStrength;
        [NMS(Index = 282)]
        /* 0xA80 */ public float MinPixelSizeOfObjectsInShadowsCockpitOnPlanet;
        [NMS(Index = 281)]
        /* 0xA84 */ public float MinPixelSizeOfObjectsInShadowsPlanet;
        [NMS(Index = 280)]
        /* 0xA88 */ public float MinPixelSizeOfObjectsInShadowsSpace;
        [NMS(Index = 43)]
        /* 0xA8C */ public float ModelRendererLightIntensity;
        [NMS(Index = 237)]
        /* 0xA90 */ public float MotionBlurShutterAngle;
        [NMS(Index = 236)]
        /* 0xA94 */ public float MotionBlurShutterSpeed;
        [NMS(Index = 293)]
        /* 0xA98 */ public float MotionBlurThresholdDefault;
        [NMS(Index = 291)]
        /* 0xA9C */ public float MotionBlurThresholdInVehicle;
        [NMS(Index = 290)]
        /* 0xAA0 */ public float MotionBlurThresholdOnFoot;
        [NMS(Index = 292)]
        /* 0xAA4 */ public float MotionBlurThresholdSpace;
        [NMS(Index = 62)]
        /* 0xAA8 */ public float NearClipDistance;
        [NMS(Index = 21)]
        /* 0xAAC */ public float New_BounceLightIntensity;
        [NMS(Index = 20)]
        /* 0xAB0 */ public float New_BounceLightPower;
        [NMS(Index = 19)]
        /* 0xAB4 */ public float New_BounceLightWarp;
        [NMS(Index = 26)]
        /* 0xAB8 */ public float New_SideRimColourMixer;
        [NMS(Index = 25)]
        /* 0xABC */ public float New_SideRimWarp;
        [NMS(Index = 24)]
        /* 0xAC0 */ public float New_SkyLightIntensity;
        [NMS(Index = 23)]
        /* 0xAC4 */ public float New_SkyLightPower;
        [NMS(Index = 22)]
        /* 0xAC8 */ public float New_SkyLightWarp;
        [NMS(Index = 28)]
        /* 0xACC */ public float New_TopRimColourMixer;
        [NMS(Index = 30)]
        /* 0xAD0 */ public float New_TopRimIntensity;
        [NMS(Index = 29)]
        /* 0xAD4 */ public float New_TopRimPower;
        [NMS(Index = 27)]
        /* 0xAD8 */ public float New_TopRimWarp;
        [NMS(Index = 296)]
        /* 0xADC */ public float NoFocusMaxFPS;
        [NMS(Index = 33)]
        /* 0xAE0 */ public float Old_BounceLightIntensity;
        [NMS(Index = 32)]
        /* 0xAE4 */ public float Old_BounceLightPower;
        [NMS(Index = 31)]
        /* 0xAE8 */ public float Old_BounceLightWarp;
        [NMS(Index = 38)]
        /* 0xAEC */ public float Old_SideRimColourMixer;
        [NMS(Index = 37)]
        /* 0xAF0 */ public float Old_SideRimWarp;
        [NMS(Index = 36)]
        /* 0xAF4 */ public float Old_SkyLightIntensity;
        [NMS(Index = 35)]
        /* 0xAF8 */ public float Old_SkyLightPower;
        [NMS(Index = 34)]
        /* 0xAFC */ public float Old_SkyLightWarp;
        [NMS(Index = 40)]
        /* 0xB00 */ public float Old_TopRimColourMixer;
        [NMS(Index = 42)]
        /* 0xB04 */ public float Old_TopRimIntensity;
        [NMS(Index = 41)]
        /* 0xB08 */ public float Old_TopRimPower;
        [NMS(Index = 39)]
        /* 0xB0C */ public float Old_TopRimWarp;
        [NMS(Index = 44)]
        /* 0xB10 */ public float PetModelRendererLightIntensity;
        [NMS(Index = 324)]
        /* 0xB14 */ public float PhotoModeBloomGainMax;
        [NMS(Index = 322)]
        /* 0xB18 */ public float PhotoModeBloomGainMedium;
        [NMS(Index = 318)]
        /* 0xB1C */ public float PhotoModeBloomGainMin;
        [NMS(Index = 325)]
        /* 0xB20 */ public float PhotoModeBloomThresholdMax;
        [NMS(Index = 323)]
        /* 0xB24 */ public float PhotoModeBloomThresholdMedium;
        [NMS(Index = 319)]
        /* 0xB28 */ public float PhotoModeBloomThresholdMin;
        [NMS(Index = 320)]
        /* 0xB2C */ public float PhotoModeDefaultBloomValue;
        [NMS(Index = 321)]
        /* 0xB30 */ public float PhotoModeMediumValue;
        [NMS(Index = 87)]
        /* 0xB34 */ public float QuantizeTime;
        [NMS(Index = 90)]
        /* 0xB38 */ public float QuantizeTimeCameraView;
        [NMS(Index = 88)]
        /* 0xB3C */ public float QuantizeTimeShip;
        [NMS(Index = 89)]
        /* 0xB40 */ public float QuantizeTimeSpace;
        [NMS(Index = 18)]
        /* 0xB44 */ public float Redo_BounceIntensity;
        [NMS(Index = 16)]
        /* 0xB48 */ public float Redo_LightIntensity;
        [NMS(Index = 17)]
        /* 0xB4C */ public float Redo_SkyIntensity;
        [NMS(Index = 228)]
        /* 0xB50 */ public float ReflectionStrength;
        [NMS(Index = 208)]
        /* 0xB54 */ public float RingAvoidanceSphereInterpTime;
        [NMS(Index = 207)]
        /* 0xB58 */ public float RingRadius;
        [NMS(Index = 206)]
        /* 0xB5C */ public float RingSize;
        [NMS(Index = 14)]
        /* 0xB60 */ public float Saturation;
        [NMS(Index = 210)]
        /* 0xB64 */ public float SaturationVariance;
        [NMS(Index = 48)]
        /* 0xB68 */ public float ScanAlpha;
        [NMS(Index = 186)]
        /* 0xB6C */ public float ScanBandWidth;
        [NMS(Index = 47)]
        /* 0xB70 */ public float ScanClamp;
        [NMS(Index = 188)]
        /* 0xB74 */ public float ScanDistance;
        [NMS(Index = 184)]
        /* 0xB78 */ public float ScanEffectSpeed;
        [NMS(Index = 182)]
        /* 0xB7C */ public float ScanFadeInTime;
        [NMS(Index = 183)]
        /* 0xB80 */ public float ScanFadeOutTime;
        [NMS(Index = 46)]
        /* 0xB84 */ public float ScanFresnel;
        [NMS(Index = 187)]
        /* 0xB88 */ public float ScanHeightScale;
        [NMS(Index = 189)]
        /* 0xB8C */ public float ScanHorizontalScale;
        [NMS(Index = 185)]
        /* 0xB90 */ public float ScanObjectFade;
        [NMS(Index = 86)]
        /* 0xB94 */ public float ShadowBillboardOffset;
        [NMS(Index = 72)]
        /* 0xB98 */ public float ShadowLength;
        [NMS(Index = 78)]
        /* 0xB9C */ public float ShadowLengthCameraView;
        [NMS(Index = 76)]
        /* 0xBA0 */ public float ShadowLengthFreighter;
        [NMS(Index = 77)]
        /* 0xBA4 */ public float ShadowLengthFreighterAbandoned;
        [NMS(Index = 73)]
        /* 0xBA8 */ public float ShadowLengthShip;
        [NMS(Index = 74)]
        /* 0xBAC */ public float ShadowLengthSpace;
        [NMS(Index = 75)]
        /* 0xBB0 */ public float ShadowLengthStation;
        [NMS(Index = 68)]
        /* 0xBB4 */ public int ShadowMapSize;
        [NMS(Index = 300)]
        /* 0xBB8 */ public float SharpenFilterAmount;
        [NMS(Index = 302)]
        /* 0xBBC */ public float SharpenFilterDepthFactorEnd;
        [NMS(Index = 301)]
        /* 0xBC0 */ public float SharpenFilterDepthFactorStart;
        [NMS(Index = 174)]
        /* 0xBC4 */ public float ShieldDownScanlineTime;
        [NMS(Index = 192)]
        /* 0xBC8 */ public float Single1ScanBandWidth;
        [NMS(Index = 193)]
        /* 0xBCC */ public float Single1ScanEffectSpeed;
        [NMS(Index = 191)]
        /* 0xBD0 */ public float Single1ScanHeightScale;
        [NMS(Index = 195)]
        /* 0xBD4 */ public float Single1ScanHorizontalScale;
        [NMS(Index = 194)]
        /* 0xBD8 */ public float Single1ScanObjectFade;
        [NMS(Index = 190)]
        /* 0xBDC */ public float Single1ScanTime;
        [NMS(Index = 198)]
        /* 0xBE0 */ public float Single2ScanBandWidth;
        [NMS(Index = 199)]
        /* 0xBE4 */ public float Single2ScanEffectSpeed;
        [NMS(Index = 197)]
        /* 0xBE8 */ public float Single2ScanHeightScale;
        [NMS(Index = 201)]
        /* 0xBEC */ public float Single2ScanHorizontalScale;
        [NMS(Index = 200)]
        /* 0xBF0 */ public float Single2ScanObjectFade;
        [NMS(Index = 196)]
        /* 0xBF4 */ public float Single2ScanTime;
        [NMS(Index = 221)]
        /* 0xBF8 */ public float SkySaturationMax;
        [NMS(Index = 220)]
        /* 0xBFC */ public float SkySaturationMin;
        [NMS(Index = 223)]
        /* 0xC00 */ public float SkyValueMax;
        [NMS(Index = 222)]
        /* 0xC04 */ public float SkyValueMin;
        [NMS(Index = 295)]
        /* 0xC08 */ public float SpaceIBLBlendDistance;
        [NMS(Index = 294)]
        /* 0xC0C */ public float SpaceIBLBlendStart;
        [NMS(Index = 225)]
        /* 0xC10 */ public float SpaceMieFactor;
        [NMS(Index = 224)]
        /* 0xC14 */ public float SpaceScale;
        [NMS(Index = 226)]
        /* 0xC18 */ public float SpaceSunFactor;
        [NMS(Index = 2)]
        /* 0xC1C */ public float SunLightBlendTime;
        [NMS(Index = 1)]
        /* 0xC20 */ public float SunLightIntensity;
        [NMS(Index = 9)]
        /* 0xC24 */ public float SunRayDecay;
        [NMS(Index = 8)]
        /* 0xC28 */ public float SunRayDensity;
        [NMS(Index = 10)]
        /* 0xC2C */ public float SunRayExposure;
        [NMS(Index = 11)]
        /* 0xC30 */ public float SunRayWeight;
        [NMS(Index = 285)]
        /* 0xC34 */ public int SupersamplingLevel;
        [NMS(Index = 240)]
        /* 0xC38 */ public float TaaAccumDelay;
        [NMS(Index = 239)]
        /* 0xC3C */ public float TaaHighFreqConstant;
        [NMS(Index = 238)]
        /* 0xC40 */ public float TaaLowFreqConstant;
        [NMS(Index = 289)]
        /* 0xC44 */ public int TargetTextureMemUsageMB;
        [NMS(Index = 202)]
        /* 0xC48 */ public float TeleportFlashTime;
        [NMS(Index = 259)]
        /* 0xC4C */ public int TerrainAnisoHi;
        [NMS(Index = 257)]
        /* 0xC50 */ public int TerrainAnisoLow;
        [NMS(Index = 258)]
        /* 0xC54 */ public int TerrainAnisoMed;
        [NMS(Index = 260)]
        /* 0xC58 */ public int TerrainAnisoUlt;
        [NMS(Index = 267)]
        /* 0xC5C */ public int TerrainBlocksPerFrameHi;
        [NMS(Index = 265)]
        /* 0xC60 */ public int TerrainBlocksPerFrameLow;
        [NMS(Index = 266)]
        /* 0xC64 */ public int TerrainBlocksPerFrameMed;
        [NMS(Index = 273)]
        /* 0xC68 */ public int TerrainBlocksPerFrameOberon;
        [NMS(Index = 269)]
        /* 0xC6C */ public int TerrainBlocksPerFramePs430;
        [NMS(Index = 270)]
        /* 0xC70 */ public int TerrainBlocksPerFramePs460;
        [NMS(Index = 268)]
        /* 0xC74 */ public int TerrainBlocksPerFrameUlt;
        [NMS(Index = 271)]
        /* 0xC78 */ public int TerrainBlocksPerFrameXb130;
        [NMS(Index = 272)]
        /* 0xC7C */ public int TerrainBlocksPerFrameXb160;
        [NMS(Index = 261)]
        /* 0xC80 */ public int TerrainDroppedMipsLow;
        [NMS(Index = 262)]
        /* 0xC84 */ public int TerrainDroppedMipsMed;
        [NMS(Index = 263)]
        /* 0xC88 */ public float TerrainMipBiasLow;
        [NMS(Index = 264)]
        /* 0xC8C */ public float TerrainMipBiasMed;
        [NMS(Index = 91)]
        /* 0xC90 */ public float ToneMapExposure;
        [NMS(Index = 103)]
        /* 0xC94 */ public float ToneMapExposureCave;
        [NMS(Index = 211)]
        /* 0xC98 */ public float ValueVariance;
        [NMS(Index = 143)]
        /* 0xC9C */ public float VignetteEnd;
        [NMS(Index = 147)]
        /* 0xCA0 */ public float VignetteEndMoveVR;
        [NMS(Index = 151)]
        /* 0xCA4 */ public float VignetteEndMoveVRShip;
        [NMS(Index = 160)]
        /* 0xCA8 */ public float VignetteEndRidingVR;
        [NMS(Index = 157)]
        /* 0xCAC */ public float VignetteEndTurnRidingVR;
        [NMS(Index = 145)]
        /* 0xCB0 */ public float VignetteEndTurnVR;
        [NMS(Index = 154)]
        /* 0xCB4 */ public float VignetteEndTurnVRShip;
        [NMS(Index = 142)]
        /* 0xCB8 */ public float VignetteStart;
        [NMS(Index = 146)]
        /* 0xCBC */ public float VignetteStartMoveVR;
        [NMS(Index = 150)]
        /* 0xCC0 */ public float VignetteStartMoveVRShip;
        [NMS(Index = 159)]
        /* 0xCC4 */ public float VignetteStartRidingVR;
        [NMS(Index = 156)]
        /* 0xCC8 */ public float VignetteStartTurnRidingVR;
        [NMS(Index = 144)]
        /* 0xCCC */ public float VignetteStartTurnVR;
        [NMS(Index = 153)]
        /* 0xCD0 */ public float VignetteStartTurnVRShip;
        [NMS(Index = 149)]
        /* 0xCD4 */ public float VignetteVRMoveInterpTime;
        [NMS(Index = 152)]
        /* 0xCD8 */ public float VignetteVRMoveInterpTimeShip;
        [NMS(Index = 161)]
        /* 0xCDC */ public float VignetteVRRidingInterpTime;
        [NMS(Index = 148)]
        /* 0xCE0 */ public float VignetteVRTurnInterpTime;
        [NMS(Index = 155)]
        /* 0xCE4 */ public float VignetteVRTurnInterpTimeShip;
        [NMS(Index = 158)]
        /* 0xCE8 */ public float VignetteVRTurnRidingInterpTime;
        [NMS(Index = 64)]
        /* 0xCEC */ public float WarpK;
        [NMS(Index = 65)]
        /* 0xCF0 */ public float WarpKCube;
        [NMS(Index = 67)]
        /* 0xCF4 */ public float WarpKDispersion;
        [NMS(Index = 66)]
        /* 0xCF8 */ public float WarpScale;
        [NMS(Index = 231)]
        /* 0xCFC */ public float WaterHueShift;
        [NMS(Index = 232)]
        /* 0xD00 */ public float WaterSaturation;
        [NMS(Index = 233)]
        /* 0xD04 */ public float WaterValue;
        [NMS(Index = 45)]
        /* 0xD08 */ public float WonderModelRendererLightIntensity;
        [NMS(Index = 283)]
        /* 0xD0C */ public bool AllowPartialCascadeRender;
        [NMS(Index = 244)]
        /* 0xD0D */ public bool ApplyTaaTest;
        [NMS(Index = 51)]
        /* 0xD0E */ public bool CenterRenderSpaceOffset;
        [NMS(Index = 50)]
        /* 0xD0F */ public bool DebugLinesDepthTest;
        [NMS(Index = 139)]
        /* 0xD10 */ public bool DOFEnableBokeh;
        [NMS(Index = 140)]
        /* 0xD11 */ public bool DOFEnableNewBokehShader;
        [NMS(Index = 141)]
        /* 0xD12 */ public bool DOFEnablePhysCamera;
        [NMS(Index = 297)]
        /* 0xD13 */ public bool EnableCrossPipeSharing;
        [NMS(Index = 298)]
        /* 0xD14 */ public bool EnableSSR;
        [NMS(Index = 274)]
        /* 0xD15 */ public bool EnableTerrainCachePs4Base;
        [NMS(Index = 275)]
        /* 0xD16 */ public bool EnableTerrainCachePs4Pro;
        [NMS(Index = 276)]
        /* 0xD17 */ public bool EnableTerrainCacheXb1Base;
        [NMS(Index = 277)]
        /* 0xD18 */ public bool EnableTerrainCacheXb1X;
        [NMS(Index = 286)]
        /* 0xD19 */ public bool EnableTextureStreaming;
        [NMS(Index = 316)]
        /* 0xD1A */ public bool EnableVariableUpdate;
        [NMS(Index = 278)]
        /* 0xD1B */ public bool ForceCachedTerrain;
        [NMS(Index = 288)]
        /* 0xD1C */ public bool ForceEvictAllTextures;
        [NMS(Index = 287)]
        /* 0xD1D */ public bool ForceStreamAllTextures;
        [NMS(Index = 279)]
        /* 0xD1E */ public bool ForceUncachedTerrain;
        [NMS(Index = 175)]
        /* 0xD1F */ public bool FullscreenScanEffect;
        [NMS(Index = 327)]
        /* 0xD20 */ public bool IBLReflections;
        [NMS(Index = 15)]
        /* 0xD21 */ public bool Redo_On;
        [NMS(Index = 85)]
        /* 0xD22 */ public bool ShadowQuantized;
        [NMS(Index = 299)]
        /* 0xD23 */ public bool ShowReflectionProbes;
        [NMS(Index = 245)]
        /* 0xD24 */ public bool ShowTaaBuf;
        [NMS(Index = 249)]
        /* 0xD25 */ public bool ShowTaaCVarianceBuf;
        [NMS(Index = 248)]
        /* 0xD26 */ public bool ShowTaaNVarianceBuf;
        [NMS(Index = 247)]
        /* 0xD27 */ public bool ShowTaaVarianceBuf;
        [NMS(Index = 246)]
        /* 0xD28 */ public bool TonemapInLuminance;
        [NMS(Index = 176)]
        /* 0xD29 */ public bool UseImposters;
        [NMS(Index = 243)]
        /* 0xD2A */ public bool UseTaaResolve;
        [NMS(Index = 326)]
        /* 0xD2B */ public bool WaterReflections;
    }
}
