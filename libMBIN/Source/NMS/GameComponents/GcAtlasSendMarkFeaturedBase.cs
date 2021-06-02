using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x48, GUID = 0x0000000000000000, NameHash = 0xC597628B65E70FD4)]
    public class GcAtlasSendMarkFeaturedBase : NMSTemplate
    {
        /* 0x00 */ public ulong ClientUserdata;
        /* 0x08 */ public NMSString0x40 BaseID;
    }
}
