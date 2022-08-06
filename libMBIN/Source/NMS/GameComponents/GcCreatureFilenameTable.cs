using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD3A2D6582C011CE1, NameHash = 0x5F5BF3F7E2ECA606)]
    public class GcCreatureFilenameTable : NMSTemplate
    {
        public List<GcCreatureFilename> Table;
    }
}