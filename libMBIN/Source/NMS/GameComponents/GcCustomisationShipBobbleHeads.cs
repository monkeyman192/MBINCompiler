using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x30FC7216DED1D59E, NameHash = 0x9822B1463FFAFC3F)]
    public class GcCustomisationShipBobbleHeads : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCustomisationBobbleHead> BobbleHeads;
    }
}
