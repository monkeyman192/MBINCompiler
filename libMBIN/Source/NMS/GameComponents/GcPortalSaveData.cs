namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9A4BE3B0AB0F3DDD, NameHash = 0x1B40C15E29F0E6FF)]
    public class GcPortalSaveData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcSeed PortalSeed;
        [NMS(Index = 1)]
        /* 0x10 */ public ulong LastPortalUA;
        [NMS(Index = 2)]
        /* 0x18 */ public bool IsStoryPortal;
    }
}
