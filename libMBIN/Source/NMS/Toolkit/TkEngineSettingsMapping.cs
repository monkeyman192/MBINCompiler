using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x748F1302B93289DF, NameHash = 0xC02F1D19584B44D)]
    public class TkEngineSettingsMapping : NMSTemplate
    {
        [NMS(Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x00 */ public int[] CloudsMaxIterations;
        [NMS(Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x10 */ public float[] CloudsResolutionScale;
        [NMS(Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x20 */ public float[] IKFullBodyIterations;
        [NMS(Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x30 */ public float[] ReflectionMultiplier;
        [NMS(Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x40 */ public float[] ReflectionProbesMultiplier;
        [NMS(Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x50 */ public float[] ShadowMultiplier;
        [NMS(Size = 0x33, EnumType = typeof(TkEngineSettingTypes.EngineSettingEnum))]
        /* 0x60 */ public bool[] NeedsGameRestart;
    }
}
