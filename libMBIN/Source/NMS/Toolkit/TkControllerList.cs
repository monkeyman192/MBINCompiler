using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xD33AC9B9ADD17756, NameHash = 0x3542E107D9C3C98)]
    public class TkControllerList : NMSTemplate
    {
        public List<TkControllerButtonLookup> Controllers;
    }
}
