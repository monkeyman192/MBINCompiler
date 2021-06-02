using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x40, GUID = 0x0D62EFD494BA66A8, NameHash = 0x6C44E36452D53CB2)]
    public class GcCreaturePetAccessory : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A RequiredDescriptor;
        /* 0x20 */ public List<GcCreaturePetAccessorySlot> Slots;
        /* 0x30 */ public List<NMSString0x20A> HideParts;
    }
}
