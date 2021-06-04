using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x38, GUID = 0xDB5598A7AE4E6F4E, NameHash = 0x56E0EB96EB3713F0)]
    public class TkGraphicsDetailPreset : NMSTemplate
    {
        public TkGraphicsDetailTypes TextureQuality;
        public TkGraphicsDetailTypes AnimationQuality;
        public TkGraphicsDetailTypes ShadowQuality;
        public TkGraphicsDetailTypes PostProcessingEffects;
        public TkGraphicsDetailTypes ReflectionsQuality;
        public TkGraphicsDetailTypes VolumetricsQuality;
        public TkGraphicsDetailTypes TerrainTessellation;
        public TkGraphicsDetailTypes PlanetQuality;
        public TkGraphicsDetailTypes BaseQuality;
        public enum UIQualityEnum { Normal, _4K }
        public UIQualityEnum UIQuality;
        public enum DLSSQualityEnum { MaxPerformance, Balanced, MaxQuality, UltraPerformance, UltraQuality }
        public DLSSQualityEnum DLSSQuality;
        public enum AmbientOcclusionEnum { Off, GTAO_Low, GTAO_Medium, GTAO_High, GTAO_Ultra, HBAO_Low, HBAO_High }
        public AmbientOcclusionEnum AmbientOcclusion;
        public enum AnisotropyLevelEnum { _1, _2, _4, _8, _16 }
        public AnisotropyLevelEnum AnisotropyLevel;
        public enum AntiAliasingEnum { None, TAA_LOW, TAA, FXAA, TAA_FXAA, DLSS }
        public AntiAliasingEnum AntiAliasing;
    }
}
