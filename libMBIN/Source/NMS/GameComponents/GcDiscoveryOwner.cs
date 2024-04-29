namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x97A1410D057E6344, NameHash = 0x59B76FD6543E9F75)]
    public class GcDiscoveryOwner : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public int Timestamp;
        [NMS(Index = 0)]
        /* 0x04 */ public NMSString0x40 LocalID;
        [NMS(Index = 1)]
        /* 0x44 */ public NMSString0x40 OnlineID;
        [NMS(Index = 3)]
        /* 0x84 */ public NMSString0x40 Platform;
        [NMS(Index = 2)]
        /* 0xC4 */ public NMSString0x40 Username;
    }
}
