using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x888689E0AFD2F84F, NameHash = 0x3D34159D)]
    public class GcCreaturePetPartHider : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<NMSString0x20A> PartName;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x100 AccessorySlot;
    }
}
