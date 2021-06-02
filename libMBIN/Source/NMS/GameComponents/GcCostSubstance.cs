using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x5071CD20D1705DFE, NameHash = 0xDDDD3B456E0993D3)]
    public class GcCostSubstance : NMSTemplate
    {
        public GcDefaultMissionSubstanceEnum Default; // maybe?
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;
        public NMSString0x10 Id;
        public int Amount;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}