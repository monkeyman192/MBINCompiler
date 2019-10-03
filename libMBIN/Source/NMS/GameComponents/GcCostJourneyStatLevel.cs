using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x782E71276AD79AF2, NameHash = 0xAF9D6110E7E2E13E)]
    public class GcCostJourneyStatLevel : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string StatName;
        public int RequiredLevel;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
