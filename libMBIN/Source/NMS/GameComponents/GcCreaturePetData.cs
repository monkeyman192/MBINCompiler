using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC349306CD2BACF9A, NameHash = 0x60B2A2CE8774967D)]
    public class GcCreaturePetData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreaturePetAccessory> AccessorySlots;
    }
}
