using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB277459DBA8DF730, NameHash = 0xB8966761)]
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
