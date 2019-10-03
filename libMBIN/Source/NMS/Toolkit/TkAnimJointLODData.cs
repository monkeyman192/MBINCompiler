using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x18, GUID = 0x24A2B59FBF13A1F7, NameHash = 0x6316491205B3FC32)]
    public class TkAnimJointLODData : NMSTemplate
    {
        /* 0x0 */ public int LOD;
        /* 0x8 */ public List<NMSString0x40> JointNames;
    }
}
