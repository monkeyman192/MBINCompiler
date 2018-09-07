namespace libMBIN.Models.Structs
{
    public class GcRewardFrigateDamageResponse : NMSTemplate
    {
		public enum ResponseEnum { StayOut, ReturnHome, CheckForMoreDamage, ShowDamagedCaptain, ShowExpeditionCaptian }
		public ResponseEnum Response;
    }
}
