using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x38F7273563AB7213, NameHash = 0x6BE3C671)]
    public class TkModelResourceData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkModelResourceCameraData Camera;
        [NMS(Index = 9)]
        /* 0x70 */ public NMSString0x20A Anim;
        [NMS(Index = 3)]
        /* 0x90 */ public GcFilename HDRI;
        [NMS(Index = 0)]
        /* 0xA0 */ public NMSString0x10 Id;
        [NMS(Index = 2)]
        /* 0xB0 */ public float AspectRatio;
        [NMS(Index = 8)]
        /* 0xB4 */ public float BlendInOffset;
        [NMS(Index = 7)]
        /* 0xB8 */ public float BlendInTime;
        [NMS(Index = 10)]
        /* 0xBC */ public float HeightOffset;
        [NMS(Index = 5)]
        /* 0xC0 */ public float LightPitch;
        [NMS(Index = 6)]
        /* 0xC4 */ public float LightRotate;
        // size: 0x3
        public enum ResourceThumbnailModeEnum : uint {
            None,
            HUD,
            GUI,
        }
        [NMS(Index = 4)]
        /* 0xC8 */ public ResourceThumbnailModeEnum ResourceThumbnailMode;
        [NMS(Index = 11)]
        /* 0xCC */ public bool CanRotateWithInput;
    }
}
