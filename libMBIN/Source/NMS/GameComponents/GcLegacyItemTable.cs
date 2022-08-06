using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x728CF75D2EB011D5, NameHash = 0xB700CDCA231A2974)]
    public class GcLegacyItemTable : NMSTemplate
    {
		/* 0x00 */ public List<GcLegacyItem> Table;
    }
}
