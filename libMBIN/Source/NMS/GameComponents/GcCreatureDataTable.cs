using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xAF797A9974247C34, NameHash = 0x53E5A2C89515A4E1)]
    public class GcCreatureDataTable : NMSTemplate
    {
        public List<GcCreatureData> Table;
    }
}
