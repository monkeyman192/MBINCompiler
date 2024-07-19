using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB1A12D34990B11ED, NameHash = 0x36328696)]
    public class GcFrigateClassCost : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xA, EnumType = typeof(GcFrigateClass.FrigateClassEnum))]
        /* 0x0 */ public int[] Cost;
    }
}
