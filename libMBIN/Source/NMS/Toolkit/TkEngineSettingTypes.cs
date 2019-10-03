namespace libMBIN.NMS.Toolkit
{
    [NMS( GUID = 0x311FE8DB345C8B3F, NameHash = 0x943946549DEC2216)]
    public class TkEngineSettingTypes : NMSTemplate
    {
        // 0x27 entries
        public enum EngineSettingEnum { FullScreen, Borderless, ResolutionWidth, ResolutionHeight, Monitor, FoVOnFoot, FoVInShip, VSync, TextureQuality,
            AnimationQuality, ShadowQuality, ReflectionsMultiplier, PostProcessingEffects, VolumetricsQuality, TerrainTessellation, PlanetQuality,
            BaseQuality, EnableTessellation, AntiAliasing, AnisotropyLevel, Brightness, VignetteAndScanlines, AvailableMonitors, MaxFrameRate, NumLowThreads,
            NumHighThreads, NumGraphicsThreads, TextureStreaming, TexturePageSizeKb, MotionBlurStrength, ShowRequirementsWarnings, AmbientOcclusion, MaxTextureMemoryMb,
            FixedTextureMemory, UseArbSparseTexture, UseTerrainTextureCache, AdapterIndex, UseHDR, MinGPUMode }
        public EngineSettingEnum EngineSetting;
    }
}
