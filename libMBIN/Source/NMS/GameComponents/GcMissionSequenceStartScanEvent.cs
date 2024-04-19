using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x267ABDC52CF84838, NameHash = 0x84E26BAA3B367507)]
    public class GcMissionSequenceStartScanEvent : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Event;
        /* 0x20 */ public GcPlayerMissionParticipantType Participant;
        /* 0x24 */ public GcScanEventTableType Table;
        /* 0x28 */ public float Time;
        /* 0x2C */ public NMSString0x80 DebugText;
        /* 0xAC */ public bool AllowOtherPlayersBase;
        /* 0xAD */ public bool DoAerialScan;
        /* 0xAE */ public bool IgnoreIfAlreadyActive;
    }
}
