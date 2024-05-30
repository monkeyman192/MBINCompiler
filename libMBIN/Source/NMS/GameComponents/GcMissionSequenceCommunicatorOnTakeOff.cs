using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x62169164E75E15E7, NameHash = 0x8667E548FE078CD2)]
    public class GcMissionSequenceCommunicatorOnTakeOff : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcPlayerCommunicatorMessage Comms;
        [NMS(Index = 2)]
        /* 0x50 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0xD0 */ public NMSString0x80 Message;
    }
}
