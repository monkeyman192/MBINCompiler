using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD6AFD3237FEEF275, NameHash = 0x84E26BAA3B367507)]
    public class GcMissionSequenceStartScanEvent : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A Event;
        [NMS(Index = 1)]
        /* 0x20 */ public GcPlayerMissionParticipantType Participant;
        [NMS(Index = 0)]
        /* 0x24 */ public GcScanEventTableType Table;
        [NMS(Index = 3)]
        /* 0x28 */ public float Time;
        [NMS(Index = 7)]
        /* 0x2C */ public NMSString0x80 DebugText;
        [NMS(Index = 5)]
        /* 0xAC */ public bool AllowOtherPlayersBase;
        [NMS(Index = 4)]
        /* 0xAD */ public bool DoAerialScan;
        [NMS(Index = 6)]
        /* 0xAE */ public bool IgnoreIfAlreadyActive;
    }
}
