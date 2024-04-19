using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xDA0787E111B732ED, NameHash = 0x56E0EB96EB3713F0)]
    public class TkGraphicsDetailPreset : NMSTemplate
    {
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
        /* 0x08 */ public AmbientOcclusionEnum AmbientOcclusion;
        /* 0x0C */ public TkGraphicsDetailTypes AnimationQuality;
        // size: 0x5
        public enum AnisotropyLevelEnum : uint {
            _1,
            _2,
            _4,
            _8,
            _16,
        }
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
        /* 0x14 */ public AntiAliasingEnum AntiAliasing;
        /* 0x18 */ public TkGraphicsDetailTypes BaseQuality;
        // size: 0x5
        public enum DLSSQualityEnum : uint {
            MaxPerformance,
            Balanced,
            MaxQuality,
            UltraPerformance,
            UltraQuality,
        }
        /* 0x1C */ public DLSSQualityEnum DLSSQuality;
        // size: 0x4
        public enum FFXSR2QualityEnum : uint {
            UltraPerformance,
            Performance,
            Balanced,
            Quality,
        }
        /* 0x20 */ public FFXSR2QualityEnum FFXSR2Quality;
        // size: 0x5
        public enum FFXSRQualityEnum : uint {
            Off,
            UltraQuality,
            Quality,
            Balanced,
            Performance,
        }
        /* 0x24 */ public FFXSRQualityEnum FFXSRQuality;
        // size: 0x3
        public enum MetalFXModeEnum : uint {
            Off,
            Spatial,
            Temporal,
        }
        /* 0x28 */ public MetalFXModeEnum MetalFXMode;
        // size: 0x4
        public enum MetalFXQualityEnum : uint {
            UltraQuality,
            Quality,
            Balanced,
            Performance,
        }
        /* 0x2C */ public MetalFXQualityEnum MetalFXQuality;
        /* 0x30 */ public TkGraphicsDetailTypes PlanetQuality;
        /* 0x34 */ public TkGraphicsDetailTypes PostProcessingEffects;
        /* 0x38 */ public TkGraphicsDetailTypes ReflectionsQuality;
        /* 0x3C */ public TkGraphicsDetailTypes ShadowQuality;
        /* 0x40 */ public TkGraphicsDetailTypes TerrainTessellation;
        /* 0x44 */ public TkGraphicsDetailTypes TextureQuality;
        // size: 0x2
        public enum UIQualityEnum : uint {
            Normal,
            _4K,
        }
        /* 0x48 */ public UIQualityEnum UIQuality;
        /* 0x4C */ public TkGraphicsDetailTypes VolumetricsQuality;
        // size: 0x5
        public enum XESSQualityEnum : uint {
            UltraPerformance,
            Performance,
            Balanced,
            MaxQuality,
            UltraQuality,
        }
        /* 0x50 */ public XESSQualityEnum XESSQuality;
    }
}
