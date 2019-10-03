using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x96327F793B9D8C29, NameHash = 0x58D4887623FE6FF5)]
    public class GcMissionConditionHasMoney : NMSTemplate
    {
        public int Amount;
		public GcCurrency TestCurrency;
    }
}
