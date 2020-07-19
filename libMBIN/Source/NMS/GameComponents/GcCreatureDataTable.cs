using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xE0C61345978B2A, NameHash = 0x53E5A2C89515A4E1)]
    public class GcCreatureDataTable : NMSTemplate
    {
        public List<GcCreatureData> Table;
    }
}