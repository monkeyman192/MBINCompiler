namespace libMBIN.Models.Structs
{
    public class GcExpeditionDuration : NMSTemplate
    {
        public int ExpeditionDuration;
        public string[] ExpeditionDurationValues()
        {
            return new[] { "VeryShort", "Short", "Medium", "Long", "VeryLong"};
        }
    }
}
