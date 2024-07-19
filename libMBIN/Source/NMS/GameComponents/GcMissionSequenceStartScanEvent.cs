using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3FA8E8689A41FFA5, NameHash = 0x89B31C13)]
    public class GcMissionSequenceStartScanEvent : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A Event;
        [NMS(Index = 7)]
        /* 0x20 */ public VariableSizeString DebugText;
        [NMS(Index = 1)]
        /* 0x30 */ public GcPlayerMissionParticipantType Participant;
        [NMS(Index = 0)]
        /* 0x34 */ public GcScanEventTableType Table;
        [NMS(Index = 3)]
        /* 0x38 */ public float Time;
        [NMS(Index = 5)]
        /* 0x3C */ public bool AllowOtherPlayersBase;
        [NMS(Index = 4)]
        /* 0x3D */ public bool DoAerialScan;
        [NMS(Index = 6)]
        /* 0x3E */ public bool IgnoreIfAlreadyActive;
    }
}
