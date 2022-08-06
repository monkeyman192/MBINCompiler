using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xE3FCFF5B621FA649, NameHash = 0x51FB1B6785B647F2)]
    public class GcRewardShipAssistance : NMSTemplate
    {
		public enum AssistanceTypeEnum { Police, Wingmen }
		public AssistanceTypeEnum AssistanceType;

        public float Time;
    }
}