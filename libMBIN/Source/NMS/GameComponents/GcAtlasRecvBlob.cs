using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x48, GUID = 0x9A0997EE9EC4E8D9, NameHash = 0xBC92C4FC7F1625E9)]
    public class GcAtlasRecvBlob : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
        [NMS(Size = 0x20)]
        /* 0x10 */ public string Name;
        /* 0x30 */ public int DataTimestamp;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x34 */ public byte[] Padding34;
        /* 0x38 */ public ulong BlobData;
        /* 0x40 */ public int BlobDataSize;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x44 */ public byte[] EndPadding;
    }
}
