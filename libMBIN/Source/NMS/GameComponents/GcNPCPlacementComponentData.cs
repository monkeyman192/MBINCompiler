using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x126EC8A5580C79E9, NameHash = 0x8047BE4D11BB54C8)]
    public class GcNPCPlacementComponentData : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> PlacementInfosToApply;
        /* 0x10 */ public bool PlaceInAbandonedSystems;
        /* 0x11 */ public bool SearchPlacementFromMaster;
        /* 0x12 */ public bool WaitToPlace;
    }
}
