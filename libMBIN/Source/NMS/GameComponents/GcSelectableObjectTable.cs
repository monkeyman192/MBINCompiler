using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4619BA006C8DD078, NameHash = 0xCE1983E849879238)]
    public class GcSelectableObjectTable : NMSTemplate
    {
        public List<GcSelectableObjectList> Lists;
    }
}
