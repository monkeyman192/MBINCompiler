using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xAFDEF5840730C649, NameHash = 0xC02F1D19584B44D)]
    public class TkEngineSettingsMapping : NMSTemplate
    {
        [NMS(Index = 5, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x00 */ public int[] CloudsMaxIterations;
        [NMS(Index = 4, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x10 */ public float[] CloudsResolutionScale;
        [NMS(Index = 3, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x20 */ public float[] IKFullBodyIterations;
        [NMS(Index = 1, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x30 */ public float[] ReflectionMultiplier;
        [NMS(Index = 2, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x40 */ public float[] ReflectionProbesMultiplier;
        [NMS(Index = 0, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x50 */ public float[] ShadowMultiplier;
        [NMS(Index = 6, Size = 0x33, EnumType = typeof(TkEngineSettingTypes.EngineSettingEnum))]
        /* 0x60 */ public bool[] NeedsGameRestart;
    }
}
