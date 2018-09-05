namespace libMBIN.Models.Structs
{
    public class GcRewardFrigateDamageResponse : NMSTemplate
    {
        public int Response;
        public string[] ResponseValues()
        {
            return new[] { "StayOut", "ReturnHome", "CheckForMoreDamage", "ShowDamagedCaptain", "ShowExpeditionCaptian" };
        }
    }
}
