using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x108, GUID = 0xA3281CC03D95EE0E, NameHash = 0x839AE0F21C2F266C)]
    public class GcMissionSequenceCollectMoney : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Message;
        public int Amount;
		public GcCurrency CollectCurrency;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}
