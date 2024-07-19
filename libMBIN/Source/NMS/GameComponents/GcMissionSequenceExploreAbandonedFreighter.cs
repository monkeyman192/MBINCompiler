namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8BAC29AD499C75D7, NameHash = 0x6CDF81A0)]
    public class GcMissionSequenceExploreAbandonedFreighter : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 3)]
        /* 0x20 */ public int Timer;
        [NMS(Index = 1)]
        /* 0x24 */ public bool RequireAllRoomsDone;
    }
}
