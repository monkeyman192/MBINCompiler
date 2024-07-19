using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9C5A66FDFE4F997D, NameHash = 0xEDDE585A)]
    public class TkAnimPoseComponentData : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public List<TkAnimPoseBabyModifier> BabyModifiers;
        [NMS(Index = 4)]
        /* 0x10 */ public List<float> CorrelationMat;
        [NMS(Index = 2)]
        /* 0x20 */ public List<TkAnimPoseCorrelationData> Correlations;
        [NMS(Index = 3)]
        /* 0x30 */ public List<TkAnimPoseExampleData> Examples;
        [NMS(Index = 1)]
        /* 0x40 */ public VariableSizeString Filename;
        [NMS(Index = 0)]
        /* 0x50 */ public List<TkAnimPoseData> PoseAnims;
        [NMS(Index = 5)]
        /* 0x60 */ public float AdultCorrelationValue;
        [NMS(Index = 7)]
        /* 0x64 */ public bool DisableForAnimOverrides;
        [NMS(Index = 8)]
        /* 0x65 */ public bool ShouldRandomise;
    }
}
