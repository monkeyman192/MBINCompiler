using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xA017550C35F2FA8F, NameHash = 0x53EC68060BE631FB)]
    public class TkModelRendererData : NMSTemplate
    {
        /* 0x00 */ public TkModelRendererCameraData Camera;
        /* 0x40 */ public float Fov;
        /* 0x44 */ public float AspectRatio;
		public enum ThumbnailModeEnum { None, HUD, GUI }
		/* 0x48 */ public ThumbnailModeEnum ThumbnailMode;
		public enum FocusTypeEnum { ResourceBounds, ResourceBoundingHeight, NodeBoundingBox, DiscoveryView }
		/* 0x4C */ public FocusTypeEnum FocusType;

        /* 0x50 */ public NMSString0x20A FocusLocator;
        /* 0x70 */ public Vector3f FocusOffset;
        /* 0x80 */ public float FocusInterpTime;
        /* 0x84 */ public float BlendInTime;
        /* 0x88 */ public float BlendInOffset;
        /* 0x90 */ public NMSString0x10 Anim;
        /* 0xA0 */ public float HeightOffset;
        /* 0xA4 */ public bool UsePlayerCameraInHmd;
        /* 0xA5 */ public bool UseSensibleCameraFocusNodeIsNowOffsetNode;
        /* 0xA6 */ public bool LookForFocusInMasterModel;
    }
}
