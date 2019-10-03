using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xDDEC312E0B5CEBC2, NameHash = 0x68651D6CBA2152DE)]
    public class GcNPCColourTable : NMSTemplate
    {
        public List<GcNPCColourGroup> Groups;
    }
}
