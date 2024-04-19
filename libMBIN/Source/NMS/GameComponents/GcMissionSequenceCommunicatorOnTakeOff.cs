using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE6B22A251D8FDA5D, NameHash = 0x8667E548FE078CD2)]
    public class GcMissionSequenceCommunicatorOnTakeOff : NMSTemplate
    {
        /* 0x00 */ public GcPlayerCommunicatorMessage Comms;
        /* 0x50 */ public NMSString0x80 DebugText;
        /* 0xD0 */ public NMSString0x80 Message;
    }
}
