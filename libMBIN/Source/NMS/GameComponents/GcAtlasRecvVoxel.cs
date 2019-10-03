using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x50, GUID = 0x35A289BA96E36B5, NameHash = 0xC62154F49D5EBD3E)]
    public class GcAtlasRecvVoxel : NMSTemplate
    {
        public ulong ClientUserdata;
        public int NumberOfThings;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] PaddingC;
        [NMS(Size = 0x8)]
        public ulong[] ThingsFound;
    }
}
