using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xC758EE0D67375E80, NameHash = 0x50A80E365BD08E24)]
    public class GcCustomisationCameraData : NMSTemplate
    {
        /* 0x00*/ public int InteractionCameraIndex;
        /* 0x04*/ public NMSString0x20 InteractionCameraFocusJoint; // InteracttionCameraFocusJoint in exe
        /* 0x24*/ public float MinPitch;
        /* 0x28*/ public float MaxPitch;
        /* 0x2C*/ public float MinYaw;
        /* 0x30*/ public float MaxYaw;
    }
}
