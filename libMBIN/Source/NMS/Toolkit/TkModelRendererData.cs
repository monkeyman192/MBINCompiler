using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1FCAF1018AE24371, NameHash = 0x2E6D021B)]
    public class TkModelRendererData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkModelRendererCameraData Camera;
        [NMS(Index = 8)]
        /* 0x40 */ public Vector3f FocusOffset;
        [NMS(Index = 7)]
        /* 0x50 */ public NMSString0x20A FocusLocator;
        [NMS(Index = 12)]
        /* 0x70 */ public NMSString0x10 Anim;
        [NMS(Index = 4)]
        /* 0x80 */ public GcFilename HDRI;
        [NMS(Index = 2)]
        /* 0x90 */ public float AspectRatio;
        [NMS(Index = 11)]
        /* 0x94 */ public float BlendInOffset;
        [NMS(Index = 10)]
        /* 0x98 */ public float BlendInTime;
        [NMS(Index = 9)]
        /* 0x9C */ public float FocusInterpTime;
        // size: 0x4
        public enum FocusTypeEnum : uint {
            ResourceBounds,
            ResourceBoundingHeight,
            NodeBoundingBox,
            DiscoveryView,
        }
        [NMS(Index = 6)]
        /* 0xA0 */ public FocusTypeEnum FocusType;
        [NMS(Index = 1)]
        /* 0xA4 */ public float Fov;
        [NMS(Index = 13)]
        /* 0xA8 */ public float HeightOffset;
        [NMS(Index = 3)]
        /* 0xAC */ public float LightIntensityMultiplier;
        // size: 0x3
        public enum ThumbnailModeEnum : uint {
            None,
            HUD,
            GUI,
        }
        [NMS(Index = 5)]
        /* 0xB0 */ public ThumbnailModeEnum ThumbnailMode;
        [NMS(Index = 15)]
        /* 0xB4 */ public bool AlignUIToCameraInHmd;
        [NMS(Index = 18)]
        /* 0xB5 */ public bool FlipRotationIfNecessary;
        [NMS(Index = 17)]
        /* 0xB6 */ public bool LookForFocusInMasterModel;
        [NMS(Index = 14)]
        /* 0xB7 */ public bool UsePlayerCameraInHmd;
        [NMS(Index = 16)]
        /* 0xB8 */ public bool UseSensibleCameraFocusNodeIsNowOffsetNode;
    }
}
