namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x158)]
    public class GcBiomeListPerStarType : NMSTemplate
    {
        [NMS(Size = 4, EnumValue = new[] { "Yellow", "Green", "Blue", "Red" })]
        /* 0x000 */ public GcBiomeList[] StarType;

        /* 0x0D0 */ public GcBiomeList LushYellow;
        /* 0x104 */ public GcBiomeList AbandonedYellow;

        [NMS(Size = 4, EnumValue = new[] { "Yellow", "Green", "Blue", "Red" })]
        /* 0x138 */ public float[] LifeChance;

        [NMS(Size = 4, EnumValue = new[] { "Yellow", "Green", "Blue", "Red" })]
        /* 0x148 */ public float[] AbandonedLifeChance;
    }
}
