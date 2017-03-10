namespace MBINCompiler.Models.Structs
{
    public class GcInventoryValueData : NMSTemplate
    {
        /* 0x000 */ public float BaseMinValue;
        /* 0x004 */ public float BaseMaxValue;
        /* 0x008 */ public float ExponentialValue;
        /* 0x00C */ public float BaseCostPerSlot;
        /* 0x010 */ public float SlotExponentialValue;
        /* 0x014 */ public float ValueToCost;
        /* 0x018 */ public float SlotsPerLevel;
    }
}
