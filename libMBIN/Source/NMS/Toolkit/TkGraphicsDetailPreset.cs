using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x99A0028545F8D9E1, NameHash = 0x56E0EB96EB3713F0)]
    public class TkGraphicsDetailPreset : NMSTemplate
    {
        [NMS(Index = 19)]
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
        [NMS(Index = 16)]
        /* 0x08 */ public AmbientOcclusionEnum AmbientOcclusion;
        [NMS(Index = 1)]
        /* 0x0C */ public TkGraphicsDetailTypes AnimationQuality;
        // size: 0x5
        public enum AnisotropyLevelEnum : uint {
            _1,
            _2,
            _4,
            _8,
            _16,
        }
        [NMS(Index = 17)]
        /* 0x10 */ public AnisotropyLevelEnum AnisotropyLevel;
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
        [NMS(Index = 18)]
        /* 0x14 */ public AntiAliasingEnum AntiAliasing;
        [NMS(Index = 8)]
        /* 0x18 */ public TkGraphicsDetailTypes BaseQuality;
        // size: 0x5
        public enum DLSSQualityEnum : uint {
            MaxPerformance,
            Balanced,
            MaxQuality,
            UltraPerformance,
            UltraQuality,
        }
        [NMS(Index = 10)]
        /* 0x1C */ public DLSSQualityEnum DLSSQuality;
        // size: 0x4
        public enum FFXSR2QualityEnum : uint {
            UltraPerformance,
            Performance,
            Balanced,
            Quality,
        }
        [NMS(Index = 12)]
        /* 0x20 */ public FFXSR2QualityEnum FFXSR2Quality;
        // size: 0x5
        public enum FFXSRQualityEnum : uint {
            Off,
            UltraQuality,
            Quality,
            Balanced,
            Performance,
        }
        [NMS(Index = 11)]
        /* 0x24 */ public FFXSRQualityEnum FFXSRQuality;
        // size: 0x3
        public enum MetalFXModeEnum : uint {
            Off,
            Spatial,
            Temporal,
        }
        [NMS(Index = 14)]
        /* 0x28 */ public MetalFXModeEnum MetalFXMode;
        // size: 0x4
        public enum MetalFXQualityEnum : uint {
            UltraQuality,
            Quality,
            Balanced,
            Performance,
        }
        [NMS(Index = 15)]
        /* 0x2C */ public MetalFXQualityEnum MetalFXQuality;
        [NMS(Index = 7)]
        /* 0x30 */ public TkGraphicsDetailTypes PlanetQuality;
        [NMS(Index = 3)]
        /* 0x34 */ public TkGraphicsDetailTypes PostProcessingEffects;
        [NMS(Index = 4)]
        /* 0x38 */ public TkGraphicsDetailTypes ReflectionsQuality;
        [NMS(Index = 2)]
        /* 0x3C */ public TkGraphicsDetailTypes ShadowQuality;
        [NMS(Index = 6)]
        /* 0x40 */ public TkGraphicsDetailTypes TerrainTessellation;
        [NMS(Index = 0)]
        /* 0x44 */ public TkGraphicsDetailTypes TextureQuality;
        // size: 0x2
        public enum UIQualityEnum : uint {
            Normal,
            _4K,
        }
        [NMS(Index = 9)]
        /* 0x48 */ public UIQualityEnum UIQuality;
        [NMS(Index = 5)]
        /* 0x4C */ public TkGraphicsDetailTypes VolumetricsQuality;
        // size: 0x5
        public enum XESSQualityEnum : uint {
            UltraPerformance,
            Performance,
            Balanced,
            MaxQuality,
            UltraQuality,
        }
        [NMS(Index = 13)]
        /* 0x50 */ public XESSQualityEnum XESSQuality;
    }
}
