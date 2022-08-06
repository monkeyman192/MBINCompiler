using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB5451F053EE27AA, NameHash = 0x8047BE4D11BB54C8)]
    public class GcNPCPlacementComponentData : NMSTemplate
    {
        /* 0x00 */ public bool SearchPlacementFromMaster;
        /* 0x01 */ public bool PlaceInAbandonedSystems;
        /* 0x08 */ public List<NMSString0x10> PlacementInfosToApply;
        /* 0x18 */ public bool WaitToPlace;
    }
}
