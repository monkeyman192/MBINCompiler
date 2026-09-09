using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA5131EFFA407375, NameHash = 0x2D59643E)]
    public class TkGraphicsDetailPreset : NMSTemplate
    {
        [NMS(Index = 25)]
        /* 0x00 */ public TkDynamicResScalingSettings DynamicResScalingSettings;
        [NMS(Index = 1)]
        /* 0x0C */ public TkGraphicsDetailTypes AnimationQuality;
        [NMS(Index = 9)]
        /* 0x14 */ public TkGraphicsDetailTypes BaseQuality;
        [NMS(Index = 7)]
        /* 0x1C */ public TkGraphicsDetailTypes PlanetQuality;
        [NMS(Index = 3)]
        /* 0x24 */ public TkGraphicsDetailTypes PostProcessingEffects;
        [NMS(Index = 4)]
        /* 0x2C */ public TkGraphicsDetailTypes ReflectionsQuality;
        [NMS(Index = 2)]
        /* 0x34 */ public TkGraphicsDetailTypes ShadowQuality;
        [NMS(Index = 6)]
        /* 0x3C */ public TkGraphicsDetailTypes TerrainTessellation;
        [NMS(Index = 0)]
        /* 0x44 */ public TkGraphicsDetailTypes TextureQuality;
        [NMS(Index = 5)]
        /* 0x4C */ public TkGraphicsDetailTypes VolumetricsQuality;
        [NMS(Index = 8)]
        /* 0x54 */ public TkGraphicsDetailTypes WaterQuality;
        // size: 0x7
        public enum AmbientOcclusionEnum : uint {
            Off,
            GTAO_Low,
            GTAO_Medium,
            GTAO_High,
            GTAO_Ultra,
            HBAO_Low,
            HBAO_High,
        }
        [NMS(Index = 21)]
        /* 0x5C */ public AmbientOcclusionEnum AmbientOcclusion;
        // size: 0x5
        public enum AnisotropyLevelEnum : uint {
            _1,
            _2,
            _4,
            _8,
            _16,
        }
        [NMS(Index = 22)]
        /* 0x60 */ public AnisotropyLevelEnum AnisotropyLevel;
        // size: 0xB
        public enum AntiAliasingEnum : uint {
            None,
            TAA_LOW,
            TAA,
            FXAA,
            FFXSR2,
            DLSS,
            DLAA,
            XESS,
            MetalFXSpatial,
            MetalFXTemporal,
            PSSR,
        }
        [NMS(Index = 23)]
        /* 0x64 */ public AntiAliasingEnum AntiAliasing;
        [NMS(Index = 10)]
        /* 0x68 */ public int CorvetteComplexityLimit;
        // size: 0x6
        public enum DLSSFrameGenerationEnum : uint {
            On2X,
            Off,
            On3X,
            On4X,
            On5X,
            On6X,
        }
        [NMS(Index = 14)]
        /* 0x6C */ public DLSSFrameGenerationEnum DLSSFrameGeneration;
        // size: 0x5
        public enum DLSSQualityEnum : uint {
            MaxPerformance,
            Balanced,
            MaxQuality,
            UltraPerformance,
            UltraQuality,
        }
        [NMS(Index = 13)]
        /* 0x70 */ public DLSSQualityEnum DLSSQuality;
        // size: 0x5
        public enum FFXSR2QualityEnum : uint {
            UltraPerformance,
            Performance,
            Balanced,
            Quality,
            Native,
        }
        [NMS(Index = 17)]
        /* 0x74 */ public FFXSR2QualityEnum FFXSR2Quality;
        // size: 0x5
        public enum FFXSRQualityEnum : uint {
            Off,
            UltraQuality,
            Quality,
            Balanced,
            Performance,
        }
        [NMS(Index = 16)]
        /* 0x78 */ public FFXSRQualityEnum FFXSRQuality;
        // size: 0x3
        public enum MetalFXModeEnum : uint {
            Off,
            Spatial,
            Temporal,
        }
        [NMS(Index = 19)]
        /* 0x7C */ public MetalFXModeEnum MetalFXMode;
        // size: 0x4
        public enum MetalFXQualityEnum : uint {
            UltraQuality,
            Quality,
            Balanced,
            Performance,
        }
        [NMS(Index = 20)]
        /* 0x80 */ public MetalFXQualityEnum MetalFXQuality;
        // size: 0x3
        public enum NVIDIAReflexLowLatencyEnum : uint {
            On,
            Off,
            OnWithBoost,
        }
        [NMS(Index = 15)]
        /* 0x84 */ public NVIDIAReflexLowLatencyEnum NVIDIAReflexLowLatency;
        // size: 0x2
        public enum UIQualityEnum : uint {
            Normal,
            _4K,
        }
        [NMS(Index = 12)]
        /* 0x88 */ public UIQualityEnum UIQuality;
        // size: 0x7
        public enum XESSQualityEnum : uint {
            UltraPerformance,
            Performance,
            Balanced,
            Quality,
            UltraQuality,
            UltraQualityPlus,
            Native,
        }
        [NMS(Index = 18)]
        /* 0x8C */ public XESSQualityEnum XESSQuality;
        [NMS(Index = 24)]
        /* 0x90 */ public bool LegacyTAA;
        [NMS(Index = 11)]
        /* 0x91 */ public bool SettlementsEnabled;
    }
}
