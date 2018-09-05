namespace libMBIN.Models.Structs
{
    [NMS(Size = 0xA0)]
    public class GcPassiveFrigateIncomeArray : NMSTemplate
    {
        [NMS(Size = 0x5, EnumValue = new string[] { "Combat", "Exploration", "Mining", "Diplomacy", "Support" })]
        public GcPassiveFrigateIncome[] Array;
    }
}
