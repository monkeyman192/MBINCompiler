using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x50, GUID = 0x4C926B203874A03B, NameHash = 0x40F7E71C83A33DA0)]
    public class GcMessageNPCBehaviourEvent : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 BehaviourEvent;
        /* 0x10 */ public NMSString0x10 UserData;
        /* 0x20 */ public GcNPCTriggerTypes InteractionTrigger;
        /* 0x24 */ public int InteractionSubType;
        /* 0x30 */ public Vector3f Position;
        [NMS(Size = 0x10, Ignore = true)]
        /* 0x40 */ public byte[] EndPadding;  // this is really weird but there doesn't seem to be anything here and the size *is* 0x50...
    }
}
