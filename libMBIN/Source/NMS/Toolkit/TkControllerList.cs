using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x164A45AA3E0834FB, NameHash = 0xCDF89FF7)]
    public class TkControllerList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkControllerButtonLookup> Controllers;
    }
}
