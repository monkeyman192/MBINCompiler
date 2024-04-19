namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE1F0EFF18817E2E8, NameHash = 0x50A80E365BD08E24)]
    public class GcCustomisationCameraData : NMSTemplate
    {
        /* 0x00 */ public int InteractionCameraIndex;
        /* 0x04 */ public float MaxPitch;
        /* 0x08 */ public float MaxYaw;
        /* 0x0C */ public float MinPitch;
        /* 0x10 */ public float MinYaw;
        /* 0x14 */ public NMSString0x20 InteracttionCameraFocusJoint;
    }
}
