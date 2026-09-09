using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x5ABD73F5B047B0AC, NameHash = 0xF1EAF1F0)]
    public class TkModelRendererCameraData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector3f Offset;
        [NMS(Index = 7)]
        /* 0x10 */ public TkCameraWanderData Wander;
        [NMS(Index = 0)]
        /* 0x24 */ public float Distance;
        [NMS(Index = 5)]
        /* 0x28 */ public float LightPitch;
        [NMS(Index = 6)]
        /* 0x2C */ public float LightRotate;
        [NMS(Index = 3)]
        /* 0x30 */ public float Pitch;
        [NMS(Index = 2)]
        /* 0x34 */ public float Roll;
        [NMS(Index = 4)]
        /* 0x38 */ public float Rotate;
    }
}
