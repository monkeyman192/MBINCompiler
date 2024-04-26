using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x991BA66AB4945126, NameHash = 0x9822B1463FFAFC3F)]
    public class GcCustomisationShipBobbleHeads : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCustomisationBobbleHead> BobbleHeads;
    }
}
