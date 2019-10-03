using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1C, GUID = 0xBFBA97AD59322690, NameHash = 0x9118F575B23083D9)]
    public class GcInventoryValueData : NMSTemplate     // possibly in global?
    {
        /* 0x000 */ public float BaseMinValue;          // 41F00000h
        /* 0x004 */ public float BaseMaxValue;          // 42200000h
        /* 0x008 */ public float ExponentialValue;      // 3F800000h
        /* 0x00C */ public float BaseCostPerSlot;       // 40000000h
        /* 0x010 */ public float SlotExponentialValue;  // 3F99999Ah
        /* 0x014 */ public float ValueToCost;           // 43AF0000h
        /* 0x018 */ public float SlotsPerLevel;         // 3F800000h
    }
}
