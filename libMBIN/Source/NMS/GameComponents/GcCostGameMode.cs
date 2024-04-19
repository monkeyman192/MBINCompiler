using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x95757206A198C, NameHash = 0x5BD84E5380495165)]
    public class GcCostGameMode : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A CostStringCantAfford;
        /* 0x20 */ public GcGameMode Mode;
        /* 0x24 */ public bool InvertMode;
    }
}
