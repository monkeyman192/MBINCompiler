using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x5071CD20D1705DFE, NameHash = 0xDDDD3B456E0993D3)]
    public class GcCostSubstance : NMSTemplate
    {
        public GcDefaultMissionSubstanceEnum Default; // maybe?
        public NMSString0x10 Id;
        public int Amount;
    }
}