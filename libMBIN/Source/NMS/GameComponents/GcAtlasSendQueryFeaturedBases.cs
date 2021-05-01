using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x85FDB191FE87E14A, NameHash = 0x6718916CBF783330)]
    public class GcAtlasSendQueryFeaturedBases : NMSTemplate
    {
        /* 0x00 */ public ulong ClientUserdata;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x08 */ public byte[] EndPadding;
    }
}
