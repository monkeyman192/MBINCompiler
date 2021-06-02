using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x110, GUID = 0xC282A343C8EACBC7, NameHash = 0x7A3E98EFAB95FF53)]
    public class GcCreaturePetAccessorySlot : NMSTemplate
    {
        public NMSString0x100 AttachLocator;
        public NMSString0x10 AccessoryGroup;
    }
}
