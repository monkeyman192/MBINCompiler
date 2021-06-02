using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x98, GUID = 0x75324406CCCAAABD, NameHash = 0x5FB32B8921A7FE69)]
    public class TkLSystemLocatorEntry : NMSTemplate // 0x98 bytes
    {
        public NMSString0x80 Model;

        public float Probability;
        public List<TkLSystemRestrictionData> Restrictions;
    }
}