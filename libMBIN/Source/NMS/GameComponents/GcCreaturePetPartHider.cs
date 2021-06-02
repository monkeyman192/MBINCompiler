using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x110, GUID = 0x5D1C6458F4076AD1, NameHash = 0xC7B26C36881B633D)]
    public class GcCreaturePetPartHider : NMSTemplate
    {
        public NMSString0x100 AccessorySlot;
        public List<NMSString0x20A> PartName;
    }
}
