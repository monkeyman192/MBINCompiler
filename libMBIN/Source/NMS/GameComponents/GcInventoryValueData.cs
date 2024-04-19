namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA08FF46B3C4DECBB, NameHash = 0x9118F575B23083D9)]
    public class GcInventoryValueData : NMSTemplate
    {
        /* 0x00 */ public float BaseCostPerSlot;
        /* 0x04 */ public float BaseMaxValue;
        /* 0x08 */ public float BaseMinValue;
        /* 0x0C */ public float ExponentialValue;
        /* 0x10 */ public float SlotExponentialValue;
        /* 0x14 */ public float SlotsPerLevel;
        /* 0x18 */ public float ValueToCost;
    }
}
