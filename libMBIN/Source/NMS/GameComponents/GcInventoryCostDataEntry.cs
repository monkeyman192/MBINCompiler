using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x3D6C19C581BD238A, NameHash = 0xD9472E9B798FC3B5)]
    public class GcInventoryCostDataEntry : NMSTemplate     // size: 0x28        maybe in global??
    {
        /* 0x00 */ public int MinSlots;                 // 0Fh
        /* 0x04 */ public float MinValueInMillions;     // 41200000h
        /* 0x08 */ public int MaxSlots;                 // 30h
        /* 0x0C */ public float MaxValueInMillions;     // 42F00000h
        /* 0x10 */ public float CoolMultiplier;         // 41A00000h
        /* 0x14 */ public float TradeInMultiplier;      // 428C0000h
        [NMS(Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x18 */ public float[] ClassMultiplier;

    }
}