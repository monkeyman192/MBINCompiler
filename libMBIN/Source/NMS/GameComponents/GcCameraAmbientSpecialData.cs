using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0x711D55B308F4783B, NameHash = 0xC266DA7C9BDD51E7)]
    public class GcCameraAmbientSpecialData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Animation;
        /* 0x10 */ public NMSString0x10 DroneAnimation;
		public enum CameraOriginEnum { ExternalBase }
		/* 0x20 */ public CameraOriginEnum CameraOrigin;
        /* 0x24 */ public bool UseLookAt;
        /* 0x25 */ public bool AvoidTerrain;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x26 */ public byte[] EndPadding;
    }
}
