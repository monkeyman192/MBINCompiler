using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8441E6AA6DAFDE25, NameHash = 0xFA9A306017ED3640)]
    public class GcRewardFrigateDamageResponse : NMSTemplate
    {
		public enum ResponseEnum { StayOut, ReturnHome, CheckForMoreDamage, ShowDamagedCaptain, ShowExpeditionCaptian }
		public ResponseEnum Response;
    }
}
