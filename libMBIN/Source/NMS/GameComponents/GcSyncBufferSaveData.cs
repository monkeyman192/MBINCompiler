namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x54FA1460A75D28A2, NameHash = 0xEFA8947B437770B8)]
    public class GcSyncBufferSaveData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public ulong SpaceAddress;
        [NMS(Index = 3)]
        /* 0x08 */ public uint BufferVersion;
        [NMS(Index = 4)]
        /* 0x0C */ public uint ItemsCount;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x40 OwnerOnlineId;
        [NMS(Index = 2)]
        /* 0x50 */ public NMSString0x20 OwnerPlatformId;
    }
}
