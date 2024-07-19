using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8E1BC1ABE633E3AE, NameHash = 0x2D59643E)]
    public class TkGraphicsDetailPreset : NMSTemplate
    {
        [NMS(Index = 22)]
        /* 0x00 */ public TkDynamicResScalingSettings DynamicResScalingSettings;
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
        [NMS(Index = 19)]
        /* 0x0C */ public AmbientOcclusionEnum AmbientOcclusion;
        [NMS(Index = 1)]
        /* 0x10 */ public TkGraphicsDetailTypes AnimationQuality;
        // size: 0x5
        public enum AnisotropyLevelEnum : uint {
            _1,
            _2,
            _4,
            _8,
            _16,
        }
        [NMS(Index = 20)]
        /* 0x14 */ public AnisotropyLevelEnum AnisotropyLevel;
        // size: 0xC
        public enum AntiAliasingEnum : uint {
            None,
            MSAA_2,
            MSAA_4,
            TAA_LOW,
            TAA,
            FXAA,
            FFXSR2,
            DLSS,
            DLAA,
            XESS,
            MetalFXSpatial,
            MetalFXTemporal,
        }
        [NMS(Index = 21)]
        /* 0x18 */ public AntiAliasingEnum AntiAliasing;
        [NMS(Index = 9)]
        /* 0x1C */ public TkGraphicsDetailTypes BaseQuality;
        // size: 0x2
        public enum DLSSFrameGenerationEnum : uint {
            On,
            Off,
        }
        [NMS(Index = 12)]
        /* 0x20 */ public DLSSFrameGenerationEnum DLSSFrameGeneration;
        // size: 0x5
        public enum DLSSQualityEnum : uint {
            MaxPerformance,
            Balanced,
            MaxQuality,
            UltraPerformance,
            UltraQuality,
        }
        [NMS(Index = 11)]
        /* 0x24 */ public DLSSQualityEnum DLSSQuality;
        // size: 0x5
        public enum FFXSR2QualityEnum : uint {
            UltraPerformance,
            Performance,
            Balanced,
            Quality,
            Native,
        }
        [NMS(Index = 15)]
        /* 0x28 */ public FFXSR2QualityEnum FFXSR2Quality;
        // size: 0x5
        public enum FFXSRQualityEnum : uint {
            Off,
            UltraQuality,
            Quality,
            Balanced,
            Performance,
        }
        [NMS(Index = 14)]
        /* 0x2C */ public FFXSRQualityEnum FFXSRQuality;
        // size: 0x3
        public enum MetalFXModeEnum : uint {
            Off,
            Spatial,
            Temporal,
        }
        [NMS(Index = 17)]
        /* 0x30 */ public MetalFXModeEnum MetalFXMode;
        // size: 0x4
        public enum MetalFXQualityEnum : uint {
            UltraQuality,
            Quality,
            Balanced,
            Performance,
        }
        [NMS(Index = 18)]
        /* 0x34 */ public MetalFXQualityEnum MetalFXQuality;
        // size: 0x2
        public enum NVIDIAReflexLowLatencyEnum : uint {
            On,
            Off,
        }
        [NMS(Index = 13)]
        /* 0x38 */ public NVIDIAReflexLowLatencyEnum NVIDIAReflexLowLatency;
        [NMS(Index = 7)]
        /* 0x3C */ public TkGraphicsDetailTypes PlanetQuality;
        [NMS(Index = 3)]
        /* 0x40 */ public TkGraphicsDetailTypes PostProcessingEffects;
        [NMS(Index = 4)]
        /* 0x44 */ public TkGraphicsDetailTypes ReflectionsQuality;
        [NMS(Index = 2)]
        /* 0x48 */ public TkGraphicsDetailTypes ShadowQuality;
        [NMS(Index = 6)]
        /* 0x4C */ public TkGraphicsDetailTypes TerrainTessellation;
        [NMS(Index = 0)]
        /* 0x50 */ public TkGraphicsDetailTypes TextureQuality;
        // size: 0x2
        public enum UIQualityEnum : uint {
            Normal,
            _4K,
        }
        [NMS(Index = 10)]
        /* 0x54 */ public UIQualityEnum UIQuality;
        [NMS(Index = 5)]
        /* 0x58 */ public TkGraphicsDetailTypes VolumetricsQuality;
        [NMS(Index = 8)]
        /* 0x5C */ public TkGraphicsDetailTypes WaterQuality;
        // size: 0x5
        public enum XESSQualityEnum : uint {
            UltraPerformance,
            Performance,
            Balanced,
            MaxQuality,
            UltraQuality,
        }
        [NMS(Index = 16)]
        /* 0x60 */ public XESSQualityEnum XESSQuality;
    }
}
