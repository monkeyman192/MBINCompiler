using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x342F98A7F9398C24, NameHash = 0x53EC68060BE631FB)]
    public class TkModelRendererData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkModelRendererCameraData Camera;
        [NMS(Index = 7)]
        /* 0x40 */ public Vector3f FocusOffset;
        [NMS(Index = 6)]
        /* 0x50 */ public NMSString0x20A FocusLocator;
        [NMS(Index = 11)]
        /* 0x70 */ public NMSString0x10 Anim;
        [NMS(Index = 2)]
        /* 0x80 */ public float AspectRatio;
        [NMS(Index = 10)]
        /* 0x84 */ public float BlendInOffset;
        [NMS(Index = 9)]
        /* 0x88 */ public float BlendInTime;
        [NMS(Index = 8)]
        /* 0x8C */ public float FocusInterpTime;
        // size: 0x4
        public enum FocusTypeEnum : uint {
            ResourceBounds,
            ResourceBoundingHeight,
            NodeBoundingBox,
            DiscoveryView,
        }
        [NMS(Index = 5)]
        /* 0x90 */ public FocusTypeEnum FocusType;
        [NMS(Index = 1)]
        /* 0x94 */ public float Fov;
        [NMS(Index = 12)]
        /* 0x98 */ public float HeightOffset;
        [NMS(Index = 3)]
        /* 0x9C */ public float LightIntensityMultiplier;
        // size: 0x3
        public enum ThumbnailModeEnum : uint {
            None,
            HUD,
            GUI,
        }
        [NMS(Index = 4)]
        /* 0xA0 */ public ThumbnailModeEnum ThumbnailMode;
        [NMS(Index = 14)]
        /* 0xA4 */ public bool AlignUIToCameraInHmd;
        [NMS(Index = 17)]
        /* 0xA5 */ public bool FlipRotationIfNecessary;
        [NMS(Index = 16)]
        /* 0xA6 */ public bool LookForFocusInMasterModel;
        [NMS(Index = 13)]
        /* 0xA7 */ public bool UsePlayerCameraInHmd;
        [NMS(Index = 15)]
        /* 0xA8 */ public bool UseSensibleCameraFocusNodeIsNowOffsetNode;
    }
}
