namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x42BCA060447AA539, NameHash = 0xEFA8947B437770B8)]
    public class GcSyncBufferSaveData : NMSTemplate
    {
        /* 0x00 */ public ulong SpaceAddress;
        /* 0x08 */ public uint BufferVersion;
        /* 0x0C */ public uint ItemsCount;
        /* 0x10 */ public NMSString0x40 OwnerOnlineId;
        /* 0x50 */ public NMSString0x20 OwnerPlatformId;
    }
}
