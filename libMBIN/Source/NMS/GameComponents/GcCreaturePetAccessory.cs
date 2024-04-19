using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4FE27D0C084491F4, NameHash = 0x6C44E36452D53CB2)]
    public class GcCreaturePetAccessory : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A RequiredDescriptor;
        /* 0x20 */ public List<NMSString0x20A> HideParts;
        /* 0x30 */ public List<GcCreaturePetAccessorySlot> Slots;
    }
}
