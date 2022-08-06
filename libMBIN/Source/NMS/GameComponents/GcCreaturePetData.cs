using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8793BF5B5D82BD39, NameHash = 0x60B2A2CE8774967D)]
    public class GcCreaturePetData : NMSTemplate
    {
        public List<GcCreaturePetAccessory> AccessorySlots;
    }
}
