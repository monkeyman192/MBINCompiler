using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2BA3D391DF4EBCC5, NameHash = 0xC5A7760BFBE38FA1)]
    public class TkAnimPoseExampleData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkAnimPoseExampleElement> Elements;
    }
}
