using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0xA0, GUID = 0x4B3E272ACB25859F, NameHash = 0xC1032FBFB34EDA05)]
    public class TkAnimDetailSettingsTable : NMSTemplate
    {
        [NMS(Size = 0x4)]
        public TkAnimDetailSettings[] Table;
    }
}
