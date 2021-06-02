using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0x9A9C381629097F2D, NameHash = 0xB16E966B1CE41461)]
    public class GcCustomInventoryComponentData : NMSTemplate
    {
        public NMSString0x10 Size;
        public List<GcInventoryTechProbability> DesiredTechs;

        public bool Cool;

        [NMS(Size = 7, Ignore = true)]
        public byte[] Padding21;
    }
}