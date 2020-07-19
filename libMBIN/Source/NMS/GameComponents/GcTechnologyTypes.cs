using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x4D4F413160958847, NameHash = 0x324956CF456BD3E1)]
    public class GcTechnologyTypes : NMSTemplate
    {
        public List<GcTechnology> Technology;
    }
}
