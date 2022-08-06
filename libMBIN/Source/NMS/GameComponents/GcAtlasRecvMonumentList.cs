using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xE7251104BD32F87E, NameHash = 0x59DA138E84E4EE4B)]
    public class GcAtlasRecvMonumentList : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
        /* 0x10 */ public int NumberOfThings;
        [NMS(Size = 0x1)]
        /* 0x20 */ public GcAtlasMonument[] Monuments;
    }
}
