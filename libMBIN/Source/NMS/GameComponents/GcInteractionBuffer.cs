using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1F893025804FBD28, NameHash = 0x7355BB5E5AC6EB4A)]
    public class GcInteractionBuffer : NMSTemplate
    {
        /* 0x00 */ public List<GcInteractionData> Interactions;
        /* 0x10 */ public int CurrentPos;
    }
}

