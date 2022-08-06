using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xDAC65296273E1B45, NameHash = 0x943946549DEC2216)]
    public class TkEngineSettingTypes : NMSTemplate
    {
        // size: 0x31
        public enum EngineSettingEnum { FullScreen, Borderless, ResolutionWidth, ResolutionHeight, ResolutionScale,
            Monitor, FoVOnFoot, FoVInShip, VSync, TextureQuality, AnimationQuality,
            ShadowQuality, ReflectionsMultiplier, ReflectionProbesMultiplier,
            ReflectionProbes, ScreenSpaceReflections, ReflectionsQuality, PostProcessingEffects,
            VolumetricsQuality, TerrainTessellation, PlanetQuality,
            BaseQuality, UIQuality, DLSSQuality, FFXSRQuality, FFXSR2Quality, XESSQuality,
            EnableTessellation, AntiAliasing, AnisotropyLevel, Brightness,
            VignetteAndScanlines, AvailableMonitors, MaxFrameRate, NumLowThreads,
            NumHighThreads, NumGraphicsThreads, TextureStreaming, TexturePageSizeKb,
            MotionBlurStrength, ShowRequirementsWarnings, AmbientOcclusion,
            MaxTextureMemoryMb, FixedTextureMemory, UseArbSparseTexture, UseTerrainTextureCache,
            AdapterIndex, UseHDR, MinGPUMode
        }
        /* 0x0 */ public EngineSettingEnum EngineSetting;
    }
}
