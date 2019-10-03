using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x47D84B83FD15C299, NameHash = 0xFB4E1857BEC9174C)]
    public class GcConstructionPart : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Part;
        public int Amount;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
