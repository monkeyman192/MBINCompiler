using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x20, GUID = 0x9808CBC171682435, NameHash = 0xD2657A8AE39E6E61)]
    public class TkProceduralModelList : NMSTemplate
    {
        public NMSString0x10 Id;
        public List<NMSString0x80> List;
    }
}