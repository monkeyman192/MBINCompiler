using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, GUID = 0xDDBA207312F77137, NameHash = 0x79EA3335C4095B8E)]
    public class GcCustomisationBoneScales : NMSTemplate
    {
        public NMSString0x20 GroupTitle;
        public NMSString0x10 ScaleBoneName;
        public List<float> Positions;
    }
}
