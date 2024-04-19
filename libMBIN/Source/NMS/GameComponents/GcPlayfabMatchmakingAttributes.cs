namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7CB74261EDC1603B, NameHash = 0x49457F0F4ABEDEE6)]
    public class GcPlayfabMatchmakingAttributes : NMSTemplate
    {
        /* 0x000 */ public int gameProgress;
        /* 0x004 */ public int isBackfilling;
        /* 0x008 */ public int needsSmallLobby;
        /* 0x00C */ public NMSString0x100 lobbyConnectionString;
        /* 0x10C */ public NMSString0x80 gamemode;
        /* 0x18C */ public NMSString0x80 matchmakingVersion;
        /* 0x20C */ public NMSString0x80 platform;
        /* 0x28C */ public NMSString0x40 seasonNumber;
        /* 0x2CC */ public NMSString0x40 UA;
    }
}
