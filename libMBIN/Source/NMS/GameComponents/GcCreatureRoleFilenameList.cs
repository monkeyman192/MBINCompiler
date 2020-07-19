using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x5A4C8E158976A977, NameHash = 0x963F45EDCB1413E2)]
    public class GcCreatureRoleFilenameList : NMSTemplate
    {
        public List<GcCreatureRoleFilename> Options;
    }
}