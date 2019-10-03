using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x641479B85F14BCE5, NameHash = 0xC5A7760BFBE38FA1)]
    public class TkAnimPoseExampleData : NMSTemplate // 0x10 bytes
    {
        public List<TkAnimPoseExampleElement> Elements;
    }
}
