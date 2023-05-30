using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcCustomInventoryComponentData : NMSTemplate
    {
        public NMSString0x10 Size;
        public List<GcInventoryTechProbability> DesiredTechs;

        public bool Cool;

        [NMS(Size = 7, Ignore = true)]
        public byte[] Padding21;
    }
}
