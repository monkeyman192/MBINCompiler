using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x181752F0C2DF5722, NameHash = 0x9F0F26C55027F010)]
    public class GcCameraSpawnSetupData : NMSTemplate
    {
		/* 0x000 */ public float Distance;              // 41A00000h
		/* 0x004 */ public bool InFrontOfShip;          // 0
		/* 0x008 */ public float YawProportion;         // 3FE66666h
		/* 0x00C */ public float HorizontalProportion;  // 40C00000h
	}
}