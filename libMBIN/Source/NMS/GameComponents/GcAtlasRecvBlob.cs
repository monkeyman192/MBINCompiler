using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9A0997EE9EC4E8D9, NameHash = 0xBC92C4FC7F1625E9)]
    public class GcAtlasRecvBlob : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
        /* 0x10 */ public NMSString0x20 Name;
        /* 0x30 */ public int DataTimestamp;
        /* 0x38 */ public ulong BlobData;
        /* 0x40 */ public int BlobDataSize;
    }
}
