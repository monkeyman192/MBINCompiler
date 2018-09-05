using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0xC8)]
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
