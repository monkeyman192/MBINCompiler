using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, GUID = 0xA7143BEA2E345BB0, NameHash = 0xBC92C4FC7F1625E9)]
    public class GcAtlasRecvBlob : NMSTemplate
    {
        public ulong ClientUserdata;
        [NMS(Size = 0x20)]
        public string Name;
        public int DataTimestamp;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding2C;
        public ulong BlobData;
        public int BlobDataSize;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
