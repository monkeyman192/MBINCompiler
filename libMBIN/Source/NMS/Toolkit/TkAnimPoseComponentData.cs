using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0xC8, GUID = 0x285B1BD4142DF52, NameHash = 0x6DF806B869216436)]
    public class TkAnimPoseComponentData : NMSTemplate
    {
        /* 0x00 */ public List<TkAnimPoseData> PoseAnims;

        [NMS(Size = 0x80)]
        /* 0x10 */ public string Filename;

        /* 0x90 */ public List<TkAnimPoseCorrelationData> Correlations;
        /* 0xA0 */ public List<TkAnimPoseExampleData> Examples;
        /* 0xB0 */ public List<float> CorrelationMat;

        /* 0xC0 */ public float AdultCorrelationValue;

        [NMS(Size = 4, Ignore = true)]
        public byte[] PaddingC4;
    }
}
