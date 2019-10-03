using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xA8, GUID = 0x6CC1A1955A4F2E63, NameHash = 0xC8FD5EE28A99CF03)]
    public class GcCreatureHarvestSubstanceList : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string CreatureType;
        [NMS(Size = 0x10)]
        public string Item;
        [NMS(Size = 0x80)]
        public string Desc;
        public int MinBlobs;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
