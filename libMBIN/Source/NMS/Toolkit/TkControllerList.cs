using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC58FEE8B73C5D76D, NameHash = 0x3542E107D9C3C98)]
    public class TkControllerList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkControllerButtonLookup> Controllers;
    }
}
