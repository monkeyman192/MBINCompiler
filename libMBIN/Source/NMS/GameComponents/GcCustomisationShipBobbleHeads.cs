using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x90073A922E595FC, NameHash = 0x9822B1463FFAFC3F)]
    public class GcCustomisationShipBobbleHeads : NMSTemplate
    {
        public List<GcCustomisationBobbleHead> BobbleHeads;
    }
}
