using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC073B9F61779E1C7, NameHash = 0x6DF806B869216436)]
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
        [NMS(Index = 0)]
        /* 0x40 */ public List<TkAnimPoseData> PoseAnims;
        [NMS(Index = 5)]
        /* 0x50 */ public float AdultCorrelationValue;
        [NMS(Index = 1)]
        /* 0x54 */ public NMSString0x80 Filename;
        [NMS(Index = 7)]
        /* 0xD4 */ public bool ShouldRandomise;
    }
}
