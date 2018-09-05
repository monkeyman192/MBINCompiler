namespace libMBIN.Models.Structs
{
    public class GcFrigateClassCost : NMSTemplate
    {
        [NMS(Size = 0x5, EnumValue = new string[] { "Combat", "Exploration", "Mining", "Diplomacy", "Support" })]
        public int[] Cost;
    }
}
