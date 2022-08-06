using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xF9C90D4C466ED78B, NameHash = 0xFB02F29777CB9D8B)]
    public class GcCameraAnomalySetupData : NMSTemplate
    {
        /* 0x00 */ public Vector4f CameraAt;
		/* 0x10 */ public Vector4f CameraUp;
        /* 0x20 */ public Vector4f CameraOffset;
		/* 0x30 */ public Vector4f SunDirection;
    }
}