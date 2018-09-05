namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x64)]
    public class GcExpeditionEventOccurrenceRate : NMSTemplate
    {
        [NMS(Size = 0x5, EnumValue = new string[] { "Combat", "Exploration", "Mining", "Diplomacy", "Balanced" })]
        public GcExpeditionDurationValues[] ExpeditionCategory;
    }
}
