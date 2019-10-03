using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1C, GUID = 0x2CE40353E3CAA625, NameHash = 0x3375DA42DA55F3B3)]
    public class GcPlayerStickData : NMSTemplate
    {
        /* 0x000 */ public float AcceleratorStickPoint;     // 3F733333h
        /* 0x004 */ public float AcceleratorMinTime;        // 3E4CCCCDh
        /* 0x008 */ public float Accelerate;                // 3BA3D70Ah
        /* 0x00C */ public float AccelerateAngle;           // 41700000h
        /* 0x010 */ public float Turn;                      // 3F800000h
        /* 0x014 */ public float TurnFast;                  // 40A00000h
        /* 0x018 */ public float StickyFactor;              // 3F800000h
    }
}
