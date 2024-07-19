using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x70DFB5FB12AC261B, NameHash = 0x2088FF49)]
    public class GcCreaturePetData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreaturePetAccessory> AccessorySlots;
    }
}
