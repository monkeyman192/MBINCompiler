using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC27C66754E23328B, NameHash = 0xC597628B65E70FD4)]
    public class GcAtlasSendMarkFeaturedBase : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
        /* 0x10 */ public NMSString0x40 BaseID;
    }
}
