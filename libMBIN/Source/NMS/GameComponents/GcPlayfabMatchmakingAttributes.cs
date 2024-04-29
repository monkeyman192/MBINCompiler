namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE672C95D132DBD43, NameHash = 0x49457F0F4ABEDEE6)]
    public class GcPlayfabMatchmakingAttributes : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x000 */ public int gameProgress;
        [NMS(Index = 2)]
        /* 0x004 */ public int isBackfilling;
        [NMS(Index = 3)]
        /* 0x008 */ public int needsSmallLobby;
        [NMS(Index = 7)]
        /* 0x00C */ public NMSString0x100 lobbyConnectionString;
        [NMS(Index = 6)]
        /* 0x10C */ public NMSString0x80 gamemode;
        [NMS(Index = 1)]
        /* 0x18C */ public NMSString0x80 matchmakingVersion;
        [NMS(Index = 5)]
        /* 0x20C */ public NMSString0x80 platform;
        [NMS(Index = 8)]
        /* 0x28C */ public NMSString0x40 seasonNumber;
        [NMS(Index = 0)]
        /* 0x2CC */ public NMSString0x40 UA;
    }
}
