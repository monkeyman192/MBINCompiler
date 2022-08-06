using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xF07A5559350356C7, NameHash = 0x0D5128E119194249)]
    public class GcAtlasGlobals : NMSTemplate
    {
        /* 0x0 */ public int ChanceOfDisconnect;
        /* 0x4 */ public int TimeoutSecNameResolution;
        /* 0x8 */ public int TimeoutSecConnection;
        /* 0xC */ public int TimeoutSecSendRecv;
    }
}
