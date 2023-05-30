using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcCreatureFullBodyIKComponentData : NMSTemplate
    {
        public List<GcCreatureIkData> JointData;
        public int HeadUpAxis;
        public string[] HeadUpAxisValues()
        {
            return new[] { "X", "XNeg", "Y", "YNeg", "Z", "ZNeg" };
        }

        public bool UseFootGlue;

        [NMS(Size = 3, Ignore = true)]
        public byte[] Padding15;
    }
}
