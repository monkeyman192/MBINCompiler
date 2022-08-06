using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xE1B108BEAEA9229C, NameHash = 0x52912F535A46A50C)]
    public class TkRagdollData : NMSTemplate
    {
        public float Density;
        public float Gravity;
        public List<NMSString0x20> ChainEnds;
        public List<NMSString0x20> ExcludeJoints;
    }
}