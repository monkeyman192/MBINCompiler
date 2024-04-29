namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7A4968C8B9305AD4, NameHash = 0x3C3DF65980E5A451)]
    public class GcMissionSequenceWaitForAbandFreighterDoorOpen : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public float MinTime;
        [NMS(Index = 3)]
        /* 0x004 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x084 */ public NMSString0x80 Message;
        [NMS(Index = 1)]
        /* 0x104 */ public NMSString0x80 MessageOvertime;
    }
}
