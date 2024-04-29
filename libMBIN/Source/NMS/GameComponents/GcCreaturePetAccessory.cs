using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1840CD5FA8552067, NameHash = 0x6C44E36452D53CB2)]
    public class GcCreaturePetAccessory : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A RequiredDescriptor;
        [NMS(Index = 2)]
        /* 0x20 */ public List<NMSString0x20A> HideParts;
        [NMS(Index = 1)]
        /* 0x30 */ public List<GcCreaturePetAccessorySlot> Slots;
    }
}
