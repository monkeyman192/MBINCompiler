using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0xB87B58B8B1F76870, NameHash = 0x2E19620D3EC8F3AC)]
    public class GcNPCColourGroup : NMSTemplate
    {
        public float Rarity;
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding4;
        public Colour primary;
        public List<Colour> Secondary;
    }
}
