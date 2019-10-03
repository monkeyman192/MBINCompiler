using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1A0, GUID = 0x9CCDE1FF648EE1B7, NameHash = 0x59DA138E84E4EE4B)]
    public class GcAtlasRecvMonumentList : NMSTemplate
    {
        public ulong ClientUserdata;
        public int NumberOfThings;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] PaddingC;
        public GcAtlasMonument Mounments;
    }
}
