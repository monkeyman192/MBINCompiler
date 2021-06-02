using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x258, Alignment = 0x8, GUID = 0x846EFB7DEC4B2114, NameHash = 0xD14F8D38E31CAB20)]
    public class GcMissionSequenceCommunicator : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 VRMessage;
        /* 0x100 */ public NMSString0x80 OSTMessage;
        /* 0x180 */ public GcPlayerCommunicatorMessage Comms;
        /* 0x1D0 */ public bool AutoOpen;
        /* 0x1D1 */ public NMSString0x80 DebugText;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x251 */ public byte[] EndPadding;
    }
}
