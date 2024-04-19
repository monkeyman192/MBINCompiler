namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x43D52A16FFF4C492, NameHash = 0x59B76FD6543E9F75)]
    public class GcDiscoveryOwner : NMSTemplate
    {
        /* 0x00 */ public int Timestamp;
        /* 0x04 */ public NMSString0x40 LocalID;
        /* 0x44 */ public NMSString0x40 OnlineID;
        /* 0x84 */ public NMSString0x40 Platform;
        /* 0xC4 */ public NMSString0x40 Username;
    }
}
