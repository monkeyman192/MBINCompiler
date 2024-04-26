namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7C2A568CBB89D1D5, NameHash = 0xCE185B81994AC0B)]
    public class GcStoryPageSeenData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int LastSeenEntryIdx;
        [NMS(Index = 0)]
        /* 0x4 */ public int PageIdx;
    }
}
