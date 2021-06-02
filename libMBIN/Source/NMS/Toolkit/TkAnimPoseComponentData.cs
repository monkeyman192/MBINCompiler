using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0xD8, GUID = 0xA3CCC64442F50323, NameHash = 0x6DF806B869216436)]
    public class TkAnimPoseComponentData : NMSTemplate
    {
        /* 0x00 */ public List<TkAnimPoseData> PoseAnims;
        /* 0x10 */ public NMSString0x80 Filename;
        /* 0x90 */ public List<TkAnimPoseCorrelationData> Correlations;
        /* 0xA0 */ public List<TkAnimPoseExampleData> Examples;
        /* 0xB0 */ public List<float> CorrelationMat;
        /* 0xC0 */ public float AdultCorrelationValue;
        [NMS(Size = 4, Ignore = true)]
        /* 0xC4 */ public byte[] PaddingC4;
        /* 0xC8 */ public List<TkAnimPoseBabyModifier> BabyModifiers;
    }
}
