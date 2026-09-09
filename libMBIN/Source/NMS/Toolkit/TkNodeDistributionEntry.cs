namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x93A7D474C6F53CEF, NameHash = 0x59323C78)]
    public class TkNodeDistributionEntry : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public HashedString Name;
        [NMS(Index = 2)]
        /* 0x18 */ public int MaxCount;
        [NMS(Index = 1)]
        /* 0x1C */ public int MinCount;
    }
}
