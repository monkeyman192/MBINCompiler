using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x5298DB0CDEA42330, NameHash = 0x769CBCB21A7D4913)]
    public class GcLegality : NMSTemplate
    {

		public enum LegalityEnum { Legal, Illegal, None }
		public LegalityEnum Legality;
    }
}
