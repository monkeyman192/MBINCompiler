namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB30EE05D0E36CFEC, NameHash = 0x9118F575B23083D9)]
    public class GcInventoryValueData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public float BaseCostPerSlot;
        [NMS(Index = 1)]
        /* 0x04 */ public float BaseMaxValue;
        [NMS(Index = 0)]
        /* 0x08 */ public float BaseMinValue;
        [NMS(Index = 2)]
        /* 0x0C */ public float ExponentialValue;
        [NMS(Index = 4)]
        /* 0x10 */ public float SlotExponentialValue;
        [NMS(Index = 6)]
        /* 0x14 */ public float SlotsPerLevel;
        [NMS(Index = 5)]
        /* 0x18 */ public float ValueToCost;
    }
}
