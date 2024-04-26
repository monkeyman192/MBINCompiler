using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2C0872F794AFE229, NameHash = 0xA14126BE226C6660)]
    public class GcActionSet : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public NMSString0x20A LocTag;
        [NMS(Index = 6)]
        /* 0x20 */ public List<GcActionSetAction> Actions;
        [NMS(Index = 7)]
        /* 0x30 */ public List<GcInputActions> BlockedActions;
        [NMS(Index = 1)]
        /* 0x40 */ public GcActionUseType Status;
        [NMS(Index = 0)]
        /* 0x44 */ public GcActionSetType Type;
        [NMS(Index = 2)]
        /* 0x48 */ public NMSString0x20 ExternalId;
        [NMS(Index = 3)]
        /* 0x68 */ public NMSString0x20 ExternalLoc;
        [NMS(Index = 5)]
        /* 0x88 */ public NMSString0x20 ParentExternalId;
    }
}
