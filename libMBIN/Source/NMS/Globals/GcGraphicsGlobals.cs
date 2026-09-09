using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xA2D6D0BE71744C3, NameHash = 0xEADD2E75)]
    public class GcGraphicsGlobals : NMSTemplate
    {
        [NMS(Index = 52)]
        /* 0x0000 */ public TkImGuiSettings ImGui;
        // size: 0x4
        public enum ShellsSettingsEnum {
            Low,
            Medium,
            High,
            Ultra,
        }
        [NMS(Index = 248, Size = 0x4, EnumType = typeof(ShellsSettingsEnum))]
        /* 0x0190 */ public Vector4f[] ShellsSettings;
        // size: 0x4
        public enum TessSettingsEnum {
            Low,
            Medium,
            High,
            Ultra,
        }
        [NMS(Index = 243, Size = 0x4, EnumType = typeof(TessSettingsEnum))]
        /* 0x01D0 */ public Vector4f[] TessSettings;
        [NMS(Index = 6)]
        /* 0x0210 */ public GcLightShaftProperties LightShaftProperties;
        [NMS(Index = 7)]
        /* 0x0240 */ public GcLightShaftProperties StormLightShaftProperties;
        [NMS(Index = 171)]
        /* 0x0270 */ public Vector4f LensParams;
        [NMS(Index = 170)]
        /* 0x0280 */ public Vector4f MipLevelDebug;
        [NMS(Index = 49)]
        /* 0x0290 */ public Colour ScanColour;
        [NMS(Index = 79)]
        /* 0x02A0 */ public Vector4f ShadowBias;
        [NMS(Index = 73)]
        /* 0x02B0 */ public Vector4f ShadowSplit;
        [NMS(Index = 78)]
        /* 0x02C0 */ public Vector4f ShadowSplitCameraView;
        [NMS(Index = 74)]
        /* 0x02D0 */ public Vector4f ShadowSplitShip;
        [NMS(Index = 75)]
        /* 0x02E0 */ public Vector4f ShadowSplitSpace;
        [NMS(Index = 76)]
        /* 0x02F0 */ public Vector4f ShadowSplitSpacePOI;
        [NMS(Index = 77)]
        /* 0x0300 */ public Vector4f ShadowSplitStation;
        [NMS(Index = 242)]
        /* 0x0310 */ public Vector4f TaaSettings;
        [NMS(Index = 246)]
        /* 0x0320 */ public Vector4f TerrainMipDistanceHigh;
        [NMS(Index = 244)]
        /* 0x0330 */ public Vector4f TerrainMipDistanceLow;
        [NMS(Index = 245)]
        /* 0x0340 */ public Vector4f TerrainMipDistanceMed;
        [NMS(Index = 247)]
        /* 0x0350 */ public Vector4f TerrainMipDistanceUlt;
        [NMS(Index = 53)]
        /* 0x0360 */ public Colour UIColour;
        [NMS(Index = 54)]
        /* 0x0370 */ public Colour UIShipColour;
        [NMS(Index = 173)]
        /* 0x0380 */ public Colour VerticalColourBottom;
        [NMS(Index = 172)]
        /* 0x0390 */ public Colour VerticalColourTop;
        [NMS(Index = 174)]
        /* 0x03A0 */ public Vector4f VerticalGradient;
        [NMS(Index = 279)]
        /* 0x03B0 */ public List<int> CascadeRenderSequence;
        // size: 0x4
        public enum GraphicsDetailPresetsPCEnum {
            Low,
            Medium,
            High,
            Ultra,
        }
        [NMS(Index = 298, Size = 0x4, EnumType = typeof(GraphicsDetailPresetsPCEnum))]
        /* 0x03C0 */ public TkGraphicsDetailPreset[] GraphicsDetailPresetsPC;
        [NMS(Index = 313)]
        /* 0x0610 */ public TkGraphicsDetailPreset GraphicsDetailPresetiOS;
        [NMS(Index = 312)]
        /* 0x06A4 */ public TkGraphicsDetailPreset GraphicsDetailPresetMacOS;
        [NMS(Index = 306)]
        /* 0x0738 */ public TkGraphicsDetailPreset GraphicsDetailPresetNX64Handheld;
        [NMS(Index = 305)]
        /* 0x07CC */ public TkGraphicsDetailPreset GraphicsDetailPresetOberon;
        [NMS(Index = 299)]
        /* 0x0860 */ public TkGraphicsDetailPreset GraphicsDetailPresetPS4;
        [NMS(Index = 301)]
        /* 0x08F4 */ public TkGraphicsDetailPreset GraphicsDetailPresetPS4Pro;
        [NMS(Index = 302)]
        /* 0x0988 */ public TkGraphicsDetailPreset GraphicsDetailPresetPS4ProVR;
        [NMS(Index = 300)]
        /* 0x0A1C */ public TkGraphicsDetailPreset GraphicsDetailPresetPS4VR;
        [NMS(Index = 308)]
        /* 0x0AB0 */ public TkGraphicsDetailPreset GraphicsDetailPresetPS5;
        [NMS(Index = 310)]
        /* 0x0B44 */ public TkGraphicsDetailPreset GraphicsDetailPresetPS5VR;
        [NMS(Index = 307)]
        /* 0x0BD8 */ public TkGraphicsDetailPreset GraphicsDetailPresetSwitch2Handheld;
        [NMS(Index = 309)]
        /* 0x0C6C */ public TkGraphicsDetailPreset GraphicsDetailPresetTrinity;
        [NMS(Index = 311)]
        /* 0x0D00 */ public TkGraphicsDetailPreset GraphicsDetailPresetTrinityVR;
        [NMS(Index = 303)]
        /* 0x0D94 */ public TkGraphicsDetailPreset GraphicsDetailPresetXB1;
        [NMS(Index = 304)]
        /* 0x0E28 */ public TkGraphicsDetailPreset GraphicsDetailPresetXB1X;
        [NMS(Index = 72, Size = 0x8, EnumType = typeof(GcShadowLengths.ShadowLengthsEnum))]
        /* 0x0EBC */ public float[] ShadowLengths;
        // size: 0x4
        public enum VariableUpdatePeriodModifersEnum {
            Low,
            Medium,
            High,
            Ultra,
        }
        [NMS(Index = 315, Size = 0x4, EnumType = typeof(VariableUpdatePeriodModifersEnum))]
        /* 0x0EDC */ public float[] VariableUpdatePeriodModifers;
        [NMS(Index = 196)]
        /* 0x0EEC */ public Vector2f WindDir1;
        [NMS(Index = 197)]
        /* 0x0EF4 */ public Vector2f WindDir2;
        [NMS(Index = 222)]
        /* 0x0EFC */ public float AlphaCutoutMax;
        [NMS(Index = 221)]
        /* 0x0F00 */ public float AlphaCutoutMin;
        [NMS(Index = 12)]
        /* 0x0F04 */ public float Brightness;
        [NMS(Index = 13)]
        /* 0x0F08 */ public float Contrast;
        [NMS(Index = 70)]
        /* 0x0F0C */ public float DirectionLightFOV;
        [NMS(Index = 69)]
        /* 0x0F10 */ public float DirectionLightRadius;
        [NMS(Index = 71)]
        /* 0x0F14 */ public float DirectionLightShadowBias;
        [NMS(Index = 108)]
        /* 0x0F18 */ public float DOFAmountManual;
        [NMS(Index = 112)]
        /* 0x0F1C */ public float DOFAmountManualFull;
        [NMS(Index = 110)]
        /* 0x0F20 */ public float DOFAmountManualFullIndoor;
        [NMS(Index = 111)]
        /* 0x0F24 */ public float DOFAmountManualLight;
        [NMS(Index = 109)]
        /* 0x0F28 */ public float DOFAmountManualLightIndoor;
        [NMS(Index = 126)]
        /* 0x0F2C */ public float DOFAutoFarAmount;
        [NMS(Index = 128)]
        /* 0x0F30 */ public float DOFAutoFarFarPlane;
        [NMS(Index = 127)]
        /* 0x0F34 */ public float DOFAutoFarFarPlaneFade;
        [NMS(Index = 129)]
        /* 0x0F38 */ public float DOFAutoFarNearPlane;
        [NMS(Index = 115)]
        /* 0x0F3C */ public float DOFFarFadeDistance;
        [NMS(Index = 117)]
        /* 0x0F40 */ public float DOFFarFadeDistanceCave;
        [NMS(Index = 133)]
        /* 0x0F44 */ public float DOFFarFadeDistanceInteraction;
        [NMS(Index = 125)]
        /* 0x0F48 */ public float DOFFarFadeDistanceManual;
        [NMS(Index = 124)]
        /* 0x0F4C */ public float DOFFarFadeDistanceManualIndoor;
        [NMS(Index = 119)]
        /* 0x0F50 */ public float DOFFarFadeDistanceSpace;
        [NMS(Index = 122)]
        /* 0x0F54 */ public float DOFFarFadeDistanceWater;
        [NMS(Index = 107)]
        /* 0x0F58 */ public float DOFFarPlane;
        [NMS(Index = 116)]
        /* 0x0F5C */ public float DOFFarPlaneCave;
        [NMS(Index = 132)]
        /* 0x0F60 */ public float DOFFarPlaneInteraction;
        [NMS(Index = 123)]
        /* 0x0F64 */ public float DOFFarPlaneManual;
        [NMS(Index = 118)]
        /* 0x0F68 */ public float DOFFarPlaneSpace;
        [NMS(Index = 121)]
        /* 0x0F6C */ public float DOFFarPlaneWater;
        [NMS(Index = 120)]
        /* 0x0F70 */ public float DOFFarStrengthWater;
        [NMS(Index = 131)]
        /* 0x0F74 */ public float DOFNearAdjustInteraction;
        [NMS(Index = 113)]
        /* 0x0F78 */ public float DOFNearFadeDistance;
        [NMS(Index = 114)]
        /* 0x0F7C */ public float DOFNearFadeDistanceManual;
        [NMS(Index = 130)]
        /* 0x0F80 */ public float DOFNearMinInteraction;
        [NMS(Index = 106)]
        /* 0x0F84 */ public float DOFNearPlane;
        [NMS(Index = 63)]
        /* 0x0F88 */ public float FarClipDistance;
        [NMS(Index = 205)]
        /* 0x0F8C */ public float FoliageSaturationMax;
        [NMS(Index = 204)]
        /* 0x0F90 */ public float FoliageSaturationMin;
        [NMS(Index = 207)]
        /* 0x0F94 */ public float FoliageValueMax;
        [NMS(Index = 206)]
        /* 0x0F98 */ public float FoliageValueMin;
        [NMS(Index = 233)]
        /* 0x0F9C */ public float FrustumJitterAmount;
        [NMS(Index = 234)]
        /* 0x0FA0 */ public float FrustumJitterAmountDLSS;
        [NMS(Index = 209)]
        /* 0x0FA4 */ public float GrassSaturationMax;
        [NMS(Index = 208)]
        /* 0x0FA8 */ public float GrassSaturationMin;
        [NMS(Index = 211)]
        /* 0x0FAC */ public float GrassValueMax;
        [NMS(Index = 210)]
        /* 0x0FB0 */ public float GrassValueMin;
        [NMS(Index = 3, MxmlName = "HBAO Bias")]
        /* 0x0FB4 */ public float HBAOBias;
        [NMS(Index = 5, MxmlName = "HBAO Intensity")]
        /* 0x0FB8 */ public float HBAOIntensity;
        [NMS(Index = 4, MxmlName = "HBAO Radius")]
        /* 0x0FBC */ public float HBAORadius;
        [NMS(Index = 87)]
        /* 0x0FC0 */ public float HDRExposure;
        [NMS(Index = 99)]
        /* 0x0FC4 */ public float HDRExposureCave;
        [NMS(Index = 88)]
        /* 0x0FC8 */ public float HDRGamma;
        [NMS(Index = 89)]
        /* 0x0FCC */ public float HDRLutExposure;
        [NMS(Index = 90)]
        /* 0x0FD0 */ public float HDRLutGamma;
        [NMS(Index = 91)]
        /* 0x0FD4 */ public float HDRLutToe;
        [NMS(Index = 93)]
        /* 0x0FD8 */ public float HDROffset;
        [NMS(Index = 101)]
        /* 0x0FDC */ public float HDROffsetCave;
        [NMS(Index = 92)]
        /* 0x0FE0 */ public float HDRThreshold;
        [NMS(Index = 100)]
        /* 0x0FE4 */ public float HDRThresholdCave;
        [NMS(Index = 61)]
        /* 0x0FE8 */ public float HUDDistance;
        [NMS(Index = 60)]
        /* 0x0FEC */ public float HUDMotionPos;
        [NMS(Index = 57)]
        /* 0x0FF0 */ public float HUDMotionPosSpring;
        [NMS(Index = 58)]
        /* 0x0FF4 */ public float HUDMotionX;
        [NMS(Index = 55)]
        /* 0x0FF8 */ public float HUDMotionXSpring;
        [NMS(Index = 59)]
        /* 0x0FFC */ public float HUDMotionY;
        [NMS(Index = 56)]
        /* 0x1000 */ public float HUDMotionYSpring;
        [NMS(Index = 201)]
        /* 0x1004 */ public float HueVariance;
        [NMS(Index = 97)]
        /* 0x1008 */ public float LensDirt;
        [NMS(Index = 105)]
        /* 0x100C */ public float LensDirtCave;
        [NMS(Index = 95)]
        /* 0x1010 */ public float LensOffset;
        [NMS(Index = 103)]
        /* 0x1014 */ public float LensOffsetCave;
        [NMS(Index = 96)]
        /* 0x1018 */ public float LensScale;
        [NMS(Index = 104)]
        /* 0x101C */ public float LensScaleCave;
        [NMS(Index = 94)]
        /* 0x1020 */ public float LensThreshold;
        [NMS(Index = 102)]
        /* 0x1024 */ public float LensThresholdCave;
        [NMS(Index = 158)]
        /* 0x1028 */ public float LowHealthDesaturationIntensityMax;
        [NMS(Index = 157)]
        /* 0x102C */ public float LowHealthDesaturationIntensityMin;
        [NMS(Index = 159)]
        /* 0x1030 */ public float LowHealthDesaturationIntensityTimeSinceHit;
        [NMS(Index = 161)]
        /* 0x1034 */ public float LowHealthFadeInTime;
        [NMS(Index = 162)]
        /* 0x1038 */ public float LowHealthFadeOutTime;
        [NMS(Index = 160)]
        /* 0x103C */ public float LowHealthOverlayIntensity;
        [NMS(Index = 164)]
        /* 0x1040 */ public float LowHealthPulseRateFullShield;
        [NMS(Index = 163)]
        /* 0x1044 */ public float LowHealthPulseRateLowShield;
        [NMS(Index = 166)]
        /* 0x1048 */ public float LowHealthStrengthFullShield;
        [NMS(Index = 165)]
        /* 0x104C */ public float LowHealthStrengthLowShield;
        [NMS(Index = 156)]
        /* 0x1050 */ public float LowHealthVignetteEnd;
        [NMS(Index = 155)]
        /* 0x1054 */ public float LowHealthVignetteStart;
        [NMS(Index = 0)]
        /* 0x1058 */ public float LUTDistanceFlightMultiplier;
        [NMS(Index = 226)]
        /* 0x105C */ public float MaxParticleRenderRange;
        [NMS(Index = 227)]
        /* 0x1060 */ public float MaxParticleRenderRangeSpace;
        [NMS(Index = 219)]
        /* 0x1064 */ public float MaxSpaceFogStrength;
        [NMS(Index = 277)]
        /* 0x1068 */ public float MinPixelSizeOfObjectsInShadowsCockpitOnPlanet;
        [NMS(Index = 276)]
        /* 0x106C */ public float MinPixelSizeOfObjectsInShadowsPlanet;
        [NMS(Index = 275)]
        /* 0x1070 */ public float MinPixelSizeOfObjectsInShadowsSpace;
        [NMS(Index = 43)]
        /* 0x1074 */ public float ModelRendererLightIntensity;
        [NMS(Index = 229)]
        /* 0x1078 */ public float MotionBlurShutterAngle;
        [NMS(Index = 228)]
        /* 0x107C */ public float MotionBlurShutterSpeed;
        [NMS(Index = 288)]
        /* 0x1080 */ public float MotionBlurThresholdDefault;
        [NMS(Index = 286)]
        /* 0x1084 */ public float MotionBlurThresholdInVehicle;
        [NMS(Index = 285)]
        /* 0x1088 */ public float MotionBlurThresholdOnFoot;
        [NMS(Index = 287)]
        /* 0x108C */ public float MotionBlurThresholdSpace;
        [NMS(Index = 62)]
        /* 0x1090 */ public float NearClipDistance;
        [NMS(Index = 21)]
        /* 0x1094 */ public float New_BounceLightIntensity;
        [NMS(Index = 20)]
        /* 0x1098 */ public float New_BounceLightPower;
        [NMS(Index = 19)]
        /* 0x109C */ public float New_BounceLightWarp;
        [NMS(Index = 26)]
        /* 0x10A0 */ public float New_SideRimColourMixer;
        [NMS(Index = 25)]
        /* 0x10A4 */ public float New_SideRimWarp;
        [NMS(Index = 24)]
        /* 0x10A8 */ public float New_SkyLightIntensity;
        [NMS(Index = 23)]
        /* 0x10AC */ public float New_SkyLightPower;
        [NMS(Index = 22)]
        /* 0x10B0 */ public float New_SkyLightWarp;
        [NMS(Index = 28)]
        /* 0x10B4 */ public float New_TopRimColourMixer;
        [NMS(Index = 30)]
        /* 0x10B8 */ public float New_TopRimIntensity;
        [NMS(Index = 29)]
        /* 0x10BC */ public float New_TopRimPower;
        [NMS(Index = 27)]
        /* 0x10C0 */ public float New_TopRimWarp;
        [NMS(Index = 291)]
        /* 0x10C4 */ public float NoFocusMaxFPS;
        [NMS(Index = 33)]
        /* 0x10C8 */ public float Old_BounceLightIntensity;
        [NMS(Index = 32)]
        /* 0x10CC */ public float Old_BounceLightPower;
        [NMS(Index = 31)]
        /* 0x10D0 */ public float Old_BounceLightWarp;
        [NMS(Index = 38)]
        /* 0x10D4 */ public float Old_SideRimColourMixer;
        [NMS(Index = 37)]
        /* 0x10D8 */ public float Old_SideRimWarp;
        [NMS(Index = 36)]
        /* 0x10DC */ public float Old_SkyLightIntensity;
        [NMS(Index = 35)]
        /* 0x10E0 */ public float Old_SkyLightPower;
        [NMS(Index = 34)]
        /* 0x10E4 */ public float Old_SkyLightWarp;
        [NMS(Index = 40)]
        /* 0x10E8 */ public float Old_TopRimColourMixer;
        [NMS(Index = 42)]
        /* 0x10EC */ public float Old_TopRimIntensity;
        [NMS(Index = 41)]
        /* 0x10F0 */ public float Old_TopRimPower;
        [NMS(Index = 39)]
        /* 0x10F4 */ public float Old_TopRimWarp;
        [NMS(Index = 44)]
        /* 0x10F8 */ public float PetModelRendererLightIntensity;
        [NMS(Index = 322)]
        /* 0x10FC */ public float PhotoModeBloomGainMax;
        [NMS(Index = 320)]
        /* 0x1100 */ public float PhotoModeBloomGainMedium;
        [NMS(Index = 316)]
        /* 0x1104 */ public float PhotoModeBloomGainMin;
        [NMS(Index = 323)]
        /* 0x1108 */ public float PhotoModeBloomThresholdMax;
        [NMS(Index = 321)]
        /* 0x110C */ public float PhotoModeBloomThresholdMedium;
        [NMS(Index = 317)]
        /* 0x1110 */ public float PhotoModeBloomThresholdMin;
        [NMS(Index = 318)]
        /* 0x1114 */ public float PhotoModeDefaultBloomValue;
        [NMS(Index = 319)]
        /* 0x1118 */ public float PhotoModeMediumValue;
        [NMS(Index = 82)]
        /* 0x111C */ public float QuantizeTime;
        [NMS(Index = 85)]
        /* 0x1120 */ public float QuantizeTimeCameraView;
        [NMS(Index = 83)]
        /* 0x1124 */ public float QuantizeTimeShip;
        [NMS(Index = 84)]
        /* 0x1128 */ public float QuantizeTimeSpace;
        [NMS(Index = 18)]
        /* 0x112C */ public float Redo_BounceIntensity;
        [NMS(Index = 16)]
        /* 0x1130 */ public float Redo_LightIntensity;
        [NMS(Index = 17)]
        /* 0x1134 */ public float Redo_SkyIntensity;
        [NMS(Index = 220)]
        /* 0x1138 */ public float ReflectionStrength;
        [NMS(Index = 200)]
        /* 0x113C */ public float RingAvoidanceSphereInterpTime;
        [NMS(Index = 199)]
        /* 0x1140 */ public float RingRadius;
        [NMS(Index = 198)]
        /* 0x1144 */ public float RingSize;
        [NMS(Index = 14)]
        /* 0x1148 */ public float Saturation;
        [NMS(Index = 202)]
        /* 0x114C */ public float SaturationVariance;
        [NMS(Index = 48)]
        /* 0x1150 */ public float ScanAlpha;
        [NMS(Index = 179)]
        /* 0x1154 */ public float ScanBandWidth;
        [NMS(Index = 47)]
        /* 0x1158 */ public float ScanClamp;
        [NMS(Index = 181)]
        /* 0x115C */ public float ScanDistance;
        [NMS(Index = 177)]
        /* 0x1160 */ public float ScanEffectSpeed;
        [NMS(Index = 175)]
        /* 0x1164 */ public float ScanFadeInTime;
        [NMS(Index = 176)]
        /* 0x1168 */ public float ScanFadeOutTime;
        [NMS(Index = 46)]
        /* 0x116C */ public float ScanFresnel;
        [NMS(Index = 180)]
        /* 0x1170 */ public float ScanHeightScale;
        [NMS(Index = 182)]
        /* 0x1174 */ public float ScanHorizontalScale;
        [NMS(Index = 178)]
        /* 0x1178 */ public float ScanObjectFade;
        [NMS(Index = 81)]
        /* 0x117C */ public float ShadowBillboardOffset;
        [NMS(Index = 68)]
        /* 0x1180 */ public int ShadowMapSize;
        [NMS(Index = 295)]
        /* 0x1184 */ public float SharpenFilterAmount;
        [NMS(Index = 297)]
        /* 0x1188 */ public float SharpenFilterDepthFactorEnd;
        [NMS(Index = 296)]
        /* 0x118C */ public float SharpenFilterDepthFactorStart;
        [NMS(Index = 167)]
        /* 0x1190 */ public float ShieldDownScanlineTime;
        [NMS(Index = 185)]
        /* 0x1194 */ public float Single1ScanBandWidth;
        [NMS(Index = 186)]
        /* 0x1198 */ public float Single1ScanEffectSpeed;
        [NMS(Index = 184)]
        /* 0x119C */ public float Single1ScanHeightScale;
        [NMS(Index = 188)]
        /* 0x11A0 */ public float Single1ScanHorizontalScale;
        [NMS(Index = 187)]
        /* 0x11A4 */ public float Single1ScanObjectFade;
        [NMS(Index = 183)]
        /* 0x11A8 */ public float Single1ScanTime;
        [NMS(Index = 191)]
        /* 0x11AC */ public float Single2ScanBandWidth;
        [NMS(Index = 192)]
        /* 0x11B0 */ public float Single2ScanEffectSpeed;
        [NMS(Index = 190)]
        /* 0x11B4 */ public float Single2ScanHeightScale;
        [NMS(Index = 194)]
        /* 0x11B8 */ public float Single2ScanHorizontalScale;
        [NMS(Index = 193)]
        /* 0x11BC */ public float Single2ScanObjectFade;
        [NMS(Index = 189)]
        /* 0x11C0 */ public float Single2ScanTime;
        [NMS(Index = 213)]
        /* 0x11C4 */ public float SkySaturationMax;
        [NMS(Index = 212)]
        /* 0x11C8 */ public float SkySaturationMin;
        [NMS(Index = 215)]
        /* 0x11CC */ public float SkyValueMax;
        [NMS(Index = 214)]
        /* 0x11D0 */ public float SkyValueMin;
        [NMS(Index = 290)]
        /* 0x11D4 */ public float SpaceIBLBlendDistance;
        [NMS(Index = 289)]
        /* 0x11D8 */ public float SpaceIBLBlendStart;
        [NMS(Index = 217)]
        /* 0x11DC */ public float SpaceMieFactor;
        [NMS(Index = 216)]
        /* 0x11E0 */ public float SpaceScale;
        [NMS(Index = 218)]
        /* 0x11E4 */ public float SpaceSunFactor;
        [NMS(Index = 2, MxmlName = "Sun Light Blend Time")]
        /* 0x11E8 */ public float SunLightBlendTime;
        [NMS(Index = 1, MxmlName = "Sun Light Intensity")]
        /* 0x11EC */ public float SunLightIntensity;
        [NMS(Index = 9)]
        /* 0x11F0 */ public float SunRayDecay;
        [NMS(Index = 8)]
        /* 0x11F4 */ public float SunRayDensity;
        [NMS(Index = 10)]
        /* 0x11F8 */ public float SunRayExposure;
        [NMS(Index = 11)]
        /* 0x11FC */ public float SunRayWeight;
        [NMS(Index = 280)]
        /* 0x1200 */ public int SupersamplingLevel;
        [NMS(Index = 232)]
        /* 0x1204 */ public float TaaAccumDelay;
        [NMS(Index = 231)]
        /* 0x1208 */ public float TaaHighFreqConstant;
        [NMS(Index = 230)]
        /* 0x120C */ public float TaaLowFreqConstant;
        [NMS(Index = 284)]
        /* 0x1210 */ public int TargetTextureMemUsageMB;
        [NMS(Index = 195)]
        /* 0x1214 */ public float TeleportFlashTime;
        [NMS(Index = 251)]
        /* 0x1218 */ public int TerrainAnisoHi;
        [NMS(Index = 249)]
        /* 0x121C */ public int TerrainAnisoLow;
        [NMS(Index = 250)]
        /* 0x1220 */ public int TerrainAnisoMed;
        [NMS(Index = 252)]
        /* 0x1224 */ public int TerrainAnisoUlt;
        [NMS(Index = 259)]
        /* 0x1228 */ public int TerrainBlocksPerFrameHi;
        [NMS(Index = 257)]
        /* 0x122C */ public int TerrainBlocksPerFrameLow;
        [NMS(Index = 258)]
        /* 0x1230 */ public int TerrainBlocksPerFrameMed;
        [NMS(Index = 265)]
        /* 0x1234 */ public int TerrainBlocksPerFrameOberon;
        [NMS(Index = 261)]
        /* 0x1238 */ public int TerrainBlocksPerFramePs430;
        [NMS(Index = 262)]
        /* 0x123C */ public int TerrainBlocksPerFramePs460;
        [NMS(Index = 260)]
        /* 0x1240 */ public int TerrainBlocksPerFrameUlt;
        [NMS(Index = 263)]
        /* 0x1244 */ public int TerrainBlocksPerFrameXb130;
        [NMS(Index = 264)]
        /* 0x1248 */ public int TerrainBlocksPerFrameXb160;
        [NMS(Index = 253)]
        /* 0x124C */ public int TerrainDroppedMipsLow;
        [NMS(Index = 254)]
        /* 0x1250 */ public int TerrainDroppedMipsMed;
        [NMS(Index = 255)]
        /* 0x1254 */ public float TerrainMipBiasLow;
        [NMS(Index = 256)]
        /* 0x1258 */ public float TerrainMipBiasMed;
        [NMS(Index = 86)]
        /* 0x125C */ public float ToneMapExposure;
        [NMS(Index = 98)]
        /* 0x1260 */ public float ToneMapExposureCave;
        [NMS(Index = 203)]
        /* 0x1264 */ public float ValueVariance;
        [NMS(Index = 136)]
        /* 0x1268 */ public float VignetteEnd;
        [NMS(Index = 140)]
        /* 0x126C */ public float VignetteEndMoveVR;
        [NMS(Index = 144)]
        /* 0x1270 */ public float VignetteEndMoveVRShip;
        [NMS(Index = 153)]
        /* 0x1274 */ public float VignetteEndRidingVR;
        [NMS(Index = 150)]
        /* 0x1278 */ public float VignetteEndTurnRidingVR;
        [NMS(Index = 138)]
        /* 0x127C */ public float VignetteEndTurnVR;
        [NMS(Index = 147)]
        /* 0x1280 */ public float VignetteEndTurnVRShip;
        [NMS(Index = 135)]
        /* 0x1284 */ public float VignetteStart;
        [NMS(Index = 139)]
        /* 0x1288 */ public float VignetteStartMoveVR;
        [NMS(Index = 143)]
        /* 0x128C */ public float VignetteStartMoveVRShip;
        [NMS(Index = 152)]
        /* 0x1290 */ public float VignetteStartRidingVR;
        [NMS(Index = 149)]
        /* 0x1294 */ public float VignetteStartTurnRidingVR;
        [NMS(Index = 137)]
        /* 0x1298 */ public float VignetteStartTurnVR;
        [NMS(Index = 146)]
        /* 0x129C */ public float VignetteStartTurnVRShip;
        [NMS(Index = 142)]
        /* 0x12A0 */ public float VignetteVRMoveInterpTime;
        [NMS(Index = 145)]
        /* 0x12A4 */ public float VignetteVRMoveInterpTimeShip;
        [NMS(Index = 154)]
        /* 0x12A8 */ public float VignetteVRRidingInterpTime;
        [NMS(Index = 141)]
        /* 0x12AC */ public float VignetteVRTurnInterpTime;
        [NMS(Index = 148)]
        /* 0x12B0 */ public float VignetteVRTurnInterpTimeShip;
        [NMS(Index = 151)]
        /* 0x12B4 */ public float VignetteVRTurnRidingInterpTime;
        [NMS(Index = 64)]
        /* 0x12B8 */ public float WarpK;
        [NMS(Index = 65)]
        /* 0x12BC */ public float WarpKCube;
        [NMS(Index = 67)]
        /* 0x12C0 */ public float WarpKDispersion;
        [NMS(Index = 66)]
        /* 0x12C4 */ public float WarpScale;
        [NMS(Index = 223)]
        /* 0x12C8 */ public float WaterHueShift;
        [NMS(Index = 224)]
        /* 0x12CC */ public float WaterSaturation;
        [NMS(Index = 225)]
        /* 0x12D0 */ public float WaterValue;
        [NMS(Index = 45)]
        /* 0x12D4 */ public float WonderModelRendererLightIntensity;
        [NMS(Index = 278)]
        /* 0x12D8 */ public bool AllowPartialCascadeRender;
        [NMS(Index = 236)]
        /* 0x12D9 */ public bool ApplyTaaTest;
        [NMS(Index = 51)]
        /* 0x12DA */ public bool CenterRenderSpaceOffset;
        [NMS(Index = 50)]
        /* 0x12DB */ public bool DebugLinesDepthTest;
        [NMS(Index = 134)]
        /* 0x12DC */ public bool DOFEnablePhysCamera;
        [NMS(Index = 292)]
        /* 0x12DD */ public bool EnableCrossPipeSharing;
        [NMS(Index = 293)]
        /* 0x12DE */ public bool EnableSSR;
        [NMS(Index = 266)]
        /* 0x12DF */ public bool EnableTerrainCachePs4Base;
        [NMS(Index = 267)]
        /* 0x12E0 */ public bool EnableTerrainCachePs4Pro;
        [NMS(Index = 268)]
        /* 0x12E1 */ public bool EnableTerrainCachePs5;
        [NMS(Index = 269)]
        /* 0x12E2 */ public bool EnableTerrainCacheXb1Base;
        [NMS(Index = 270)]
        /* 0x12E3 */ public bool EnableTerrainCacheXb1X;
        [NMS(Index = 272)]
        /* 0x12E4 */ public bool EnableTerrainCacheXboxSeriesS;
        [NMS(Index = 271)]
        /* 0x12E5 */ public bool EnableTerrainCacheXboxSeriesX;
        [NMS(Index = 281)]
        /* 0x12E6 */ public bool EnableTextureStreaming;
        [NMS(Index = 314)]
        /* 0x12E7 */ public bool EnableVariableUpdate;
        [NMS(Index = 273)]
        /* 0x12E8 */ public bool ForceCachedTerrain;
        [NMS(Index = 283)]
        /* 0x12E9 */ public bool ForceEvictAllTextures;
        [NMS(Index = 282)]
        /* 0x12EA */ public bool ForceStreamAllTextures;
        [NMS(Index = 274)]
        /* 0x12EB */ public bool ForceUncachedTerrain;
        [NMS(Index = 168)]
        /* 0x12EC */ public bool FullscreenScanEffect;
        [NMS(Index = 324)]
        /* 0x12ED */ public bool IBLReflections;
        [NMS(Index = 15)]
        /* 0x12EE */ public bool Redo_On;
        [NMS(Index = 80)]
        /* 0x12EF */ public bool ShadowQuantized;
        [NMS(Index = 294)]
        /* 0x12F0 */ public bool ShowReflectionProbes;
        [NMS(Index = 237)]
        /* 0x12F1 */ public bool ShowTaaBuf;
        [NMS(Index = 241)]
        /* 0x12F2 */ public bool ShowTaaCVarianceBuf;
        [NMS(Index = 240)]
        /* 0x12F3 */ public bool ShowTaaNVarianceBuf;
        [NMS(Index = 239)]
        /* 0x12F4 */ public bool ShowTaaVarianceBuf;
        [NMS(Index = 238)]
        /* 0x12F5 */ public bool TonemapInLuminance;
        [NMS(Index = 169)]
        /* 0x12F6 */ public bool UseImposters;
        [NMS(Index = 235)]
        /* 0x12F7 */ public bool UseTaaResolve;
    }
}
