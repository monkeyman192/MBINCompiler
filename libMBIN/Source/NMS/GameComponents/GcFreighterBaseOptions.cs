using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xA2EEBA7E815E0DC4, NameHash = 0xB5E5441084DA383E)]
    public class GcFreighterBaseOptions : NMSTemplate
    {
        public List<GcFreighterBaseOption> FreighterBases;
    }
}
