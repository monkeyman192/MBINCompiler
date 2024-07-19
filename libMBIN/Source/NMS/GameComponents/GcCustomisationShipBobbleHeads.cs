using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x37A5DFD064BBD41C, NameHash = 0x4F25D864)]
    public class GcCustomisationShipBobbleHeads : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCustomisationBobbleHead> BobbleHeads;
    }
}
