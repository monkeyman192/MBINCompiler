using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkAnimPoseComponentData : NMSTemplate
    {
        public List<TkAnimPoseData> PoseAnims;

        public NMSString0x80 Filename;

        public List<TkAnimPoseCorrelationData> Correlations;
        public List<TkAnimPoseExampleData> Examples;
        public List<float> CorrelationMat;

        public float AdultCorrelationValue;

        [NMS(Size = 4, Ignore = true)]
        public byte[] PaddingC4;
    }
}
