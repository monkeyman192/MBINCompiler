using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x812F75C888BE75A6, NameHash = 0x80B003EE)]
    public class TkEngineSettingsMapping : NMSTemplate
    {
        // size: 0x4
        public enum CloudsMaxIterationsEnum {
            Low,
            Medium,
            High,
            Ultra,
        }
        [NMS(Index = 4, Size = 0x4, EnumType = typeof(CloudsMaxIterationsEnum))]
        /* 0x00 */ public int[] CloudsMaxIterations;
        // size: 0x4
        public enum CloudsResolutionScaleEnum {
            Low,
            Medium,
            High,
            Ultra,
        }
        [NMS(Index = 3, Size = 0x4, EnumType = typeof(CloudsResolutionScaleEnum))]
        /* 0x10 */ public float[] CloudsResolutionScale;
        // size: 0x4
        public enum IKFullBodyIterationsEnum {
            Low,
            Medium,
            High,
            Ultra,
        }
        [NMS(Index = 2, Size = 0x4, EnumType = typeof(IKFullBodyIterationsEnum))]
        /* 0x20 */ public float[] IKFullBodyIterations;
        // size: 0x4
        public enum ReflectionProbesMultiplierEnum {
            Low,
            Medium,
            High,
            Ultra,
        }
        [NMS(Index = 1, Size = 0x4, EnumType = typeof(ReflectionProbesMultiplierEnum))]
        /* 0x30 */ public float[] ReflectionProbesMultiplier;
        // size: 0x4
        public enum ShadowMultiplierEnum {
            Low,
            Medium,
            High,
            Ultra,
        }
        [NMS(Index = 0, Size = 0x4, EnumType = typeof(ShadowMultiplierEnum))]
        /* 0x40 */ public float[] ShadowMultiplier;
        [NMS(Index = 5, Size = 0x3A, EnumType = typeof(TkEngineSettingTypes.EngineSettingEnum))]
        /* 0x50 */ public bool[] NeedsGameRestart;
    }
}
