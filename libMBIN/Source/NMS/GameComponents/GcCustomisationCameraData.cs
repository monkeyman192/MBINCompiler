namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2B3F5FE940BDEAC6, NameHash = 0x50A80E365BD08E24)]
    public class GcCustomisationCameraData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public int InteractionCameraIndex;
        [NMS(Index = 3)]
        /* 0x04 */ public float MaxPitch;
        [NMS(Index = 5)]
        /* 0x08 */ public float MaxYaw;
        [NMS(Index = 2)]
        /* 0x0C */ public float MinPitch;
        [NMS(Index = 4)]
        /* 0x10 */ public float MinYaw;
        [NMS(Index = 1)]
        /* 0x14 */ public NMSString0x20 InteracttionCameraFocusJoint;
    }
}
