using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x983693477C16EC06, NameHash = 0xFB7EF63CCFF49839)]
    public class GcAreaDamageDataTable : NMSTemplate
    {
        /* 0x0 */ public List<GcAreaDamageData> Table;
    }
}
