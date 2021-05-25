using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x5298DB0CDEA42330, NameHash = 0x769CBCB21A7D4913)]
    public class GcLegality : NMSTemplate
    {
        // size: 0x2
		public enum LegalityEnum { Legal, Illegal }
		public LegalityEnum Legality;
    }
}