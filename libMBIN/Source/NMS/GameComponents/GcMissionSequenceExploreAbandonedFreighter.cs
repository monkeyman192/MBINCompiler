namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBDFEFFC68938C239, NameHash = 0xDBB793901A29BBD4)]
    public class GcMissionSequenceExploreAbandonedFreighter : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public int Timer;
        [NMS(Index = 2)]
        /* 0x004 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x084 */ public NMSString0x80 Message;
        [NMS(Index = 1)]
        /* 0x104 */ public bool RequireAllRoomsDone;
    }
}
