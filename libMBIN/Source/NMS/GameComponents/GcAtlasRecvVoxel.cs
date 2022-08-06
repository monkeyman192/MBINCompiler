using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xAB31E38EB110A2EB, NameHash = 0xC62154F49D5EBD3E)]
    public class GcAtlasRecvVoxel : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
        /* 0x10 */ public int NumberOfThings;
        [NMS(Size = 0x8)]
        /* 0x18 */ public ulong[] ThingsFound;
    }
}
