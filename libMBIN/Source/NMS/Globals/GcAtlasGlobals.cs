namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x405F807A69628F3A, NameHash = 0x4FED5F3D)]
    public class GcAtlasGlobals : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int ChanceOfDisconnect;
        [NMS(Index = 2)]
        /* 0x4 */ public int TimeoutSecConnection;
        [NMS(Index = 1)]
        /* 0x8 */ public int TimeoutSecNameResolution;
        [NMS(Index = 3)]
        /* 0xC */ public int TimeoutSecSendRecv;
    }
}
