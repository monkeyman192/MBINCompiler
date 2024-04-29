namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBC16E59DDA16C1A0, NameHash = 0xCE185B81994AC0B)]
    public class GcStoryPageSeenData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int LastSeenEntryIdx;
        [NMS(Index = 0)]
        /* 0x4 */ public int PageIdx;
    }
}
