using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x935E6819AFDA899C, NameHash = 0xBEE7641A87849DA4)]
    public class GcGoToStateAction : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 State;
        [NMS(Index = 2)]
        /* 0x10 */ public GcBroadcastLevel BroadcastLevel;
        [NMS(Index = 1)]
        /* 0x14 */ public bool Broadcast;
    }
}
