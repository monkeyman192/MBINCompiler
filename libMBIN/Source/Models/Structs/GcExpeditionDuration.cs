namespace libMBIN.Models.Structs
{
    public class GcExpeditionDuration : NMSTemplate
    {
		public enum ExpeditionDurationEnum { VeryShort, Short, Medium, Long, VeryLong }
		public ExpeditionDurationEnum ExpeditionDuration;
    }
}
