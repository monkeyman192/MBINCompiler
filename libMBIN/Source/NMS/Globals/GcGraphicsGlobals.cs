using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    // loaded at 0x141624650
    public class GcGraphicsGlobals : NMSTemplate
    {
        /* 0x0 */ public float Unknown0; // [ethan] BounceLightPower?
        /* 0x4 */ public float Unknown4; // [ethan] BounceLightIntensity?
        /* 0x8 */ public float Unknown8; // [ethan] SkyLightPower?
        /* 0xC */ public float UnknownC; // [ethan] SkyLightIntensity?

        /* 0x10 */ public float Unknown10; // [ethan] SideRimWarp?
        /* 0x14 */ public float Unknown14; // [ethan] SideRimColourMixer?
        /* 0x18 */ public float TopRimWarp;
        /* 0x1C */ public float TopRimIntensity;

        /* 0x20 */ public float ModelRendererLightIntensity;
        /* 0x24 */ public float ScanFresnel;
        /* 0x28 */ public float ScanClamp;
        /* 0x2C */ public float ScanAlpha;

        /* 0x30 */ public Colour ScanColour;

        /* 0x40 */ public bool DebugLinesDepthTest; // unused? // [ethan]: this is a debug build feature
        /* 0x41 */ public bool CenterRenderSpaceOffset; // used
        /* 0x44 */ public float Unknown44; // [ethan] padding?
        /* 0x48 */ public float Unknown48;
        /* 0x4C */ public float Unknown4C;

        public TkImGuiSettings ImGuiSettings;

        /* 0x1E0 */ public Colour UIColour;

        /* 0x1F0 */ public Colour UIShipColour;

        /* 0x200 */ public float HUDMotionXSpring;
        /* 0x204 */ public float HUDMotionYSpring;
        /* 0x208 */ public float HUDMotionPosSpring;
        /* 0x20C */ public float HUDMotionX;

        /* 0x210 */ public float HUDMotionY;
        /* 0x214 */ public float HUDMotionPos;
        /* 0x218 */ public float HUDDistance;
        /* 0x21C */ public float NearClipDistance;

        /* 0x220 */ public float FarClipDistance;// [ethan] mm named it EngineRenderDistance
        /* 0x224 */ public float WarpK;
        /* 0x228 */ public float WarpKCube;
        /* 0x22C */ public float WarpScale;

        /* 0x230 */ public float WarpKDispersion;
        /* 0x234 */ public int ShadowMapSize; // unused?
        /* 0x238 */ public float DirectionLightRadius;
        /* 0x23C */ public float DirectionLightFOV;

        /* 0x240 */ public float DirectionLightShadowBias;
        /* 0x244 */ public float ShadowLength;
        /* 0x248 */ public float ShadowLengthShip;
        /* 0x24C */ public float ShadowLengthSpace;

        /* 0x250 */ public float ShadowLengthStation;
        /* 0x254 */ public float ShadowLengthCameraView;
        /* 0x258 */ public float Unknown258; // [ethan] padding?
        /* 0x25C */ public float Unknown25C;

        /* 0x260 */ public Vector4f ShadowSplit;

        /* 0x270 */ public Vector4f ShadowSplitShip;

        /* 0x280 */ public Vector4f ShadowSplitSpace;

        /* 0x290 */ public Vector4f ShadowSplitStation;

        /* 0x2A0 */ public Vector4f ShadowSplitCameraView;

        /* 0x2B0 */ public Vector4f ShadowBias;

        /* RC1 ONLY */

        // [ethan] I do not feel like offsetting all the offsets AGAIN
        //         so, the offsets used here are the actual ones in RC1;
        //         assume all offsets going forward for RC1 are +0x10.
        //         I have no idea what type these are :P

        /* 0x2C0 */ public bool UnknownRC1_2C0;
        /* 0x2C4 */ public bool UnknownRC1_2C4;
        /* 0x2C8 */ public int UnknownRC1_2C8;
        /* 0x2CC */ public int UnknownRC1_2CC;

        /* RC1 ONLY END */

        /* 0x2C0 */ public bool ShadowQuantized; // unused?
        /* 0x2C4 */ public float ShadowBillboardOffset;
        /* 0x2C8 */ public float QuantizeTime;
        /* 0x2CC */ public float QuantizeTimeShip;

        /* 0x2D0 */ public float QuantizeTimeSpace;
        /* 0x2D4 */ public float QuantizeTimeCameraView;
        /* 0x2D8 */ public float ToneMapExposure;
        /* 0x2DC */ public float HDRExposure;

        /* 0x2E0 */ public float HDRThreshold;
        /* 0x2E4 */ public float HDROffset; // [ethan] this value did not match, but everything else did, sooo
        /* 0x2E8 */ public float LensThreshold;
        /* 0x2EC */ public float LensOffset;

        /* 0x2F0 */ public float LensScale;
        /* 0x2F4 */ public float LensDirt;
        /* 0x2F8 */ public float ToneMapExposureCave;
        /* 0x2FC */ public float HDRExposureCave;

        /* 0x300 */ public float HDRThresholdCave;
        /* 0x304 */ public float HDROffsetCave; // [ethan] ...especially since this DOES match
        /* 0x308 */ public float LensThresholdCave;
        /* 0x30C */ public float LensOffsetCave;

        /* 0x310 */ public float LensScaleCave;
        /* 0x314 */ public float LensDirtCave;
        /* 0x318 */ public float DOFNearPlane;
        /* 0x31C */ public float DOFFarPlane;

        /* 0x320 */ public float DOFNearFadeDistance;
        /* 0x324 */ public float DOFFarFadeDistance;
        /* 0x328 */ public float DOFFarPlaneCave;
        /* 0x32C */ public float DOFFarFadeDistanceCave;

        /* 0x330 */ public float DOFFarPlaneSpace;
        /* 0x334 */ public float DOFFarFadeDistanceSpace;
        /* 0x338 */ public float DOFFarPlaneWater;
        /* 0x33C */ public float DOFFarFadeDistanceWater;

        /* 0x340 */ public float VignetteStart;
        /* 0x344 */ public float VignetteEnd;
        /* 0x348 */ public float LowHealthVignetteStart;
        /* 0x34C */ public float LowHealthVignetteEnd;

        /* 0x350 */ public float LowHealthDesaturationIntensity;
        /* 0x354 */ public float LowHealthOverlayIntensity;
        /* 0x358 */ public float LowHealthFadeInTime;
        /* 0x35C */ public float LowHealthFadeOutTime;

        /* 0x360 */ public float ShieldDownScanlineTime;
        
        /* 0x364 */ public bool FullscreenScanEffect; // unused?
        /* 0x365 */ public bool UseImposters; // used
        /* RC1: 0x366, don't know the type */ public int UnknownRC1_364;
        /* 0x368 */ public int Unknown368; // [ethan] padding?
        /* 0x36C */ public float Unknown36C;

        /* 0x370 */ public Vector4f MipLevelDebug;

        /* 0x380 */ public Vector4f LensParams;

        /* 0x390 */ public Vector4f VerticalColourTop;

        /* 0x3A0 */ public Vector4f VerticalColourBottom;

        /* 0x3B0 */ public Vector4f VerticalGradient;

        /* 0x3C0 */ public float ScanFadeInTime;
        /* 0x3C4 */ public float ScanFadeOutTime;
        /* 0x3C8 */ public float ScanEffectSpeed;
        /* 0x3CC */ public float ScanObjectFade;

        /* 0x3D0 */ public float ScanBandWidth;
        /* 0x3D4 */ public float ScanHeightScale;
        /* 0x3D8 */ public float ScanDistance;
        /* 0x3DC */ public float ScanHorizontalScale;

        /* 0x3E0 */ public float Single1ScanTime;
        /* 0x3E4 */ public float Single1ScanHeightScale;
        /* 0x3E8 */ public float Single1ScanBandWidth;
        /* 0x3EC */ public float Single1ScanEffectSpeed;

        /* 0x3F0 */ public float Single1ScanObjectFade;
        /* 0x3F4 */ public float Single1ScanHorizontalScale;
        /* 0x3F8 */ public float Single2ScanTime;
        /* 0x3FC */ public float Single2ScanHeightScale;

        /* 0x400 */ public float Single2ScanBandWidth;
        /* 0x404 */ public float Single2ScanEffectSpeed;
        /* 0x408 */ public float Single2ScanObjectFade;
        /* 0x40C */ public float Single2ScanHorizontalScale;

        /* 0x410 */ public float TeleportFlashTime;
        /* 0x414 */ public Vector2f WindDir1;
        /* 0x41C */ public Vector2f WindDir2;

        /* 0x424 */ public float AtmosphereSize;
        /* 0x428 */ public float Unknown428; // [ethan] ...huevariance?
        /* 0x42C */ public float Unknown42C; //         ...saturationvariance?

        /* 0x430 */ public float Unknown430; //         ...valuevariance? or all three padding?
        /* 0x434 */ public float FoliageSaturationMin;
        /* 0x438 */ public float FoliageSaturationMax;
        /* 0x43C */ public float FoliageValueMin;

        /* 0x440 */ public float FoliageValueMax;
        /* 0x444 */ public float GrassSaturationMin;
        /* 0x448 */ public float GrassSaturationMax;
        /* 0x44C */ public float GrassValueMin;

        /* 0x450 */ public float GrassValueMax;
        /* 0x454 */ public float SkySaturationMin;
        /* 0x458 */ public float SkySaturationMax;
        /* 0x45C */ public float SkyValueMin;

        /* 0x460 */ public float SkyValueMax;
        /* 0x464 */ public float SpaceScale;
        /* 0x468 */ public float SpaceMieFactor;
        /* 0x46C */ public float SpaceSunFactor;

        /* 0x470 */ public float MaxSpaceFogStrength;
        /* 0x474 */ public float ReflectionStrength;
        /* 0x478 */ public float AlphaCutoutMin; // [ethan] these are explicitly defined in ubershader
        /* 0x47C */ public float AlphaCutoutMax; // so are these values actually used?

        /* 0x480 */ public float WaterHueShift;
        /* 0x484 */ public float WaterSaturation;
        /* 0x488 */ public float WaterValue;
        /* 0x48C */ public float Unknown48C; // [ethan] padding?

        /* 0x490 */ public GcPlanetWaterData WaterDataMin;

        /* 0x640 */ public GcPlanetWaterData WaterDataMax;

        /* 0x7F0 */ public float Unknown7F0; // [ethan] padding?
        /* 0x7F4 */ public float MinPixelSizeOfObjectsInShadowsSpace;
        /* 0x7F8 */ public float MinPixelSizeOfObjectsInShadowsPlanet;
        /* 0x7FC */ public float MinPixelSizeOfObjectsInShadowsCockpitOnPlanet;

        /* RC1: NOT PRESENT

        /* 0x800 *//* public bool AllowPartialCascadeRender;

        [NMS(Size = 4)]
        /* 0x804 *//* public int[] CascadeRenderSequence;

        /* 0x814 *//* public int SupersamplingLevel;

        [NMS(Size = 8, Ignore = true)]
        public byte[] Padding818; */
    }
}
