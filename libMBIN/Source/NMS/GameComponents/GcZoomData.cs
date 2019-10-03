using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1C, GUID = 0x783D27F11E2B1437, NameHash = 0x2E92A561CA97070C)]
    public class GcZoomData : NMSTemplate
    {
		public enum ZoomTypeEnum { None, Far, Mid, Close }
		public ZoomTypeEnum ZoomType;

        /* 0x04 */ public float EffectStrength;     // 3F800000h
        /* 0x08 */ public float MoveSpeed;          // 41200000h
        /* 0x0C */ public float FoV;                // 41200000h
        /* 0x10 */ public float MinScanDistance;
        /* 0x14 */ public float MaxScanDistance;    // 41200000h
        /* 0x18 */ public float WalkSpeed;          // 3F800000h
    }
}
