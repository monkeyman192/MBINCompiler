using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkRagdollData : NMSTemplate
    {
        public float Density;
        public float Gravity;
        public List<NMSString0x20> ChainEnds;
        public List<NMSString0x20> ExcludeJoints;
    }
}
