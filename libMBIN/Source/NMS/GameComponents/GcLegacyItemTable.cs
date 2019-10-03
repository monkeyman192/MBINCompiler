using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x4F3FAE85B4AF62AF, NameHash = 0xB700CDCA231A2974)]
    public class GcLegacyItemTable : NMSTemplate
    {
		/* 0x00 */ public List<GcLegacyItem> Table;
    }
}
