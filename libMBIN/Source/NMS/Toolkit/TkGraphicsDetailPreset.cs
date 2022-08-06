using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x931A29826B925349, NameHash = 0x56E0EB96EB3713F0)]
    public class TkGraphicsDetailPreset : NMSTemplate
    {
        /* 0x00 */ public TkGraphicsDetailTypes TextureQuality;
        /* 0x04 */ public TkGraphicsDetailTypes AnimationQuality;
        /* 0x08 */ public TkGraphicsDetailTypes ShadowQuality;
        /* 0x0C */ public TkGraphicsDetailTypes PostProcessingEffects;
        /* 0x10 */ public TkGraphicsDetailTypes ReflectionsQuality;
        /* 0x14 */ public TkGraphicsDetailTypes VolumetricsQuality;
        /* 0x18 */ public TkGraphicsDetailTypes TerrainTessellation;
        /* 0x1C */ public TkGraphicsDetailTypes PlanetQuality;
        /* 0x20 */ public TkGraphicsDetailTypes BaseQuality;
        // size: 0x2
        public enum UIQualityEnum { Normal, _4K }
        /* 0x24 */ public UIQualityEnum UIQuality;
        // size: 0x5
        public enum DLSSQualityEnum { MaxPerformance, Balanced, MaxQuality, UltraPerformance, UltraQuality }
        /* 0x28 */ public DLSSQualityEnum DLSSQuality;
        // size: 0x5
        public enum FFXSRQualityEnum { Off, UltraQuality, Quality, Balanced, Performance }
        /* 0x2C */ public FFXSRQualityEnum FFXSRQuality;
        // size: 0x4
        public enum FFXSR2QualityEnum { UltraPerformance, Performance, Balanced, Quality }
        /* 0x30 */ public FFXSR2QualityEnum FFXSR2Quality;
        // size: 0x5
        public enum XESSQualityEnum { UltraPerformance, Performance, Balanced, MaxQuality, UltraQuality }
        /* 0x34 */ public XESSQualityEnum XESSQuality;
        // size: 0x7
        public enum AmbientOcclusionEnum { Off, GTAO_Low, GTAO_Medium, GTAO_High, GTAO_Ultra, HBAO_Low, HBAO_High }
        /* 0x38 */ public AmbientOcclusionEnum AmbientOcclusion;
        // size: 0x5
        public enum AnisotropyLevelEnum { _1, _2, _4, _8, _16 }
        /* 0x3C */ public AnisotropyLevelEnum AnisotropyLevel;
        // size: 0x8
        public enum AntiAliasingEnum { None, TAA_LOW, TAA, FXAA, FFXSR2, DLSS, DLAA, XESS }
        /* 0x40 */ public AntiAliasingEnum AntiAliasing;
    }
}
