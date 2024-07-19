using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x10AA5823518E256E, NameHash = 0x524F0ABF)]
    public class GcCostGameMode : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A CostStringCantAfford;
        [NMS(Index = 1)]
        /* 0x20 */ public GcGameMode Mode;
        [NMS(Index = 0)]
        /* 0x24 */ public bool InvertMode;
    }
}
