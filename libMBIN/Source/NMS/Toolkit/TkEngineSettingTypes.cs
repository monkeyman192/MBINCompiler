namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x4,  GUID = 0x7BABB618CE487C65, NameHash = 0x943946549DEC2216)]
    public class TkEngineSettingTypes : NMSTemplate
    {
        // size: 0x2E
        public enum EngineSettingEnum {
            FullScreen, Borderless, ResolutionWidth, ResolutionHeight, ResolutionScale, Monitor, FoVOnFoot, FoVInShip, VSync, TextureQuality,
            AnimationQuality, ShadowQuality, ReflectionsMultiplier, ReflectionProbesMultiplier, ReflectionProbes, ScreenSpaceReflections, ReflectionsQuality, PostProcessingEffects, VolumetricsQuality, TerrainTessellation,
            PlanetQuality, BaseQuality, UIQuality, DLSSQuality, EnableTessellation, AntiAliasing, AnisotropyLevel, Brightness, VignetteAndScanlines, AvailableMonitors,
            MaxFrameRate, NumLowThreads, NumHighThreads, NumGraphicsThreads, TextureStreaming, TexturePageSizeKb, MotionBlurStrength, ShowRequirementsWarnings, AmbientOcclusion, MaxTextureMemoryMb,
            FixedTextureMemory, UseArbSparseTexture, UseTerrainTextureCache, AdapterIndex, UseHDR, MinGPUMode
        }
        public EngineSettingEnum EngineSetting;
    }
}