using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xA8, GUID = 0x6CC1A1955A4F2E63, NameHash = 0xC8FD5EE28A99CF03)]
    public class GcCreatureHarvestSubstanceList : NMSTemplate
    {
        public NMSString0x10 CreatureType;
        public NMSString0x10 Item;
        public NMSString0x80 Desc;
        public int MinBlobs;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
