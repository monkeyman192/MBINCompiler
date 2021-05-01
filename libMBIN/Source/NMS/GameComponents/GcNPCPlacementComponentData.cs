using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, Alignment = 0x8, GUID = 0xB5451F053EE27AA, NameHash = 0x8047BE4D11BB54C8)]
    public class GcNPCPlacementComponentData : NMSTemplate
    {
        /* 0x00 */ public bool SearchPlacementFromMaster;
        /* 0x01 */ public bool PlaceInAbandonedSystems;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x02 */ public byte[] Padding2;
        /* 0x08 */ public List<NMSString0x10> PlacementInfosToApply;
        /* 0x18 */ public bool WaitToPlace;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x19 */ public byte[] EndPadding;
    }
}
