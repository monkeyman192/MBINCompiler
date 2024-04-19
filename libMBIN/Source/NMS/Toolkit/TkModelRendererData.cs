using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x342F98A7F9398C24, NameHash = 0x53EC68060BE631FB)]
    public class TkModelRendererData : NMSTemplate
    {
        /* 0x00 */ public TkModelRendererCameraData Camera;
        /* 0x40 */ public Vector3f FocusOffset;
        /* 0x50 */ public NMSString0x20A FocusLocator;
        /* 0x70 */ public NMSString0x10 Anim;
        /* 0x80 */ public float AspectRatio;
        /* 0x84 */ public float BlendInOffset;
        /* 0x88 */ public float BlendInTime;
        /* 0x8C */ public float FocusInterpTime;
        // size: 0x4
        public enum FocusTypeEnum : uint {
            ResourceBounds,
            ResourceBoundingHeight,
            NodeBoundingBox,
            DiscoveryView,
        }
        /* 0x90 */ public FocusTypeEnum FocusType;
        /* 0x94 */ public float Fov;
        /* 0x98 */ public float HeightOffset;
        /* 0x9C */ public float LightIntensityMultiplier;
        // size: 0x3
        public enum ThumbnailModeEnum : uint {
            None,
            HUD,
            GUI,
        }
        /* 0xA0 */ public ThumbnailModeEnum ThumbnailMode;
        /* 0xA4 */ public bool AlignUIToCameraInHmd;
        /* 0xA5 */ public bool FlipRotationIfNecessary;
        /* 0xA6 */ public bool LookForFocusInMasterModel;
        /* 0xA7 */ public bool UsePlayerCameraInHmd;
        /* 0xA8 */ public bool UseSensibleCameraFocusNodeIsNowOffsetNode;
    }
}
