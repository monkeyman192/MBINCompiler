using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC073B9F61779E1C7, NameHash = 0x6DF806B869216436)]
    public class TkAnimPoseComponentData : NMSTemplate
    {
        /* 0x00 */ public List<TkAnimPoseBabyModifier> BabyModifiers;
        /* 0x10 */ public List<float> CorrelationMat;
        /* 0x20 */ public List<TkAnimPoseCorrelationData> Correlations;
        /* 0x30 */ public List<TkAnimPoseExampleData> Examples;
        /* 0x40 */ public List<TkAnimPoseData> PoseAnims;
        /* 0x50 */ public float AdultCorrelationValue;
        /* 0x54 */ public NMSString0x80 Filename;
        /* 0xD4 */ public bool ShouldRandomise;
    }
}
