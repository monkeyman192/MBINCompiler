using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x50BDF4B763608D81, NameHash = 0x8B5246BFCB875531)]
    public class TkNGuiLayoutList : NMSTemplate
    {
        public List<TkNGuiLayoutListData> Layouts;
    }
}
