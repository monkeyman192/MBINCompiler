namespace libMBIN.Models.Structs
{
    public class GcInventoryClassCostMultiplier : NMSTemplate
    {
        [NMS(Size = 4, EnumValue = new[] { "C", "B", "A", "S" })]
        public float[] Multiplier;
    }
}
