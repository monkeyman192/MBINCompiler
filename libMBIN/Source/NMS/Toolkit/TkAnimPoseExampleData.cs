using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x58ED5CA631D51750, NameHash = 0x116750BC)]
    public class TkAnimPoseExampleData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkAnimPoseExampleElement> Elements;
    }
}
