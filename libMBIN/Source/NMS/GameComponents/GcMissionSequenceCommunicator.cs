using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x258, Alignment = 0x8, GUID = 0x846EFB7DEC4B2114, NameHash = 0xD14F8D38E31CAB20)]
    public class GcMissionSequenceCommunicator : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string VRMessage;
        [NMS(Size = 0x80)]
        /* 0x100 */ public string OSTMessage;
        /* 0x180 */ public GcPlayerCommunicatorMessage Comms;
        /* 0x1D0 */ public bool AutoOpen;
        [NMS(Size = 0x80)]
        /* 0x1D1 */ public string DebugText;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x251 */ public byte[] EndPadding;
    }
}
