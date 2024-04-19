using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x53AA0C1A964B5E9F, NameHash = 0xE2B8850DAEBB8F74)]
    public class TkModelRendererCameraData : NMSTemplate
    {
        /* 0x00 */ public Vector3f Offset;
        /* 0x10 */ public TkCameraWanderData Wander;
        /* 0x1C */ public float Distance;
        /* 0x20 */ public float LightPitch;
        /* 0x24 */ public float LightRotate;
        /* 0x28 */ public float Pitch;
        /* 0x2C */ public float Roll;
        /* 0x30 */ public float Rotate;
    }
}
