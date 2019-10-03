using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0xB0, GUID = 0x2015DA3261EF9DB2, NameHash = 0x53EC68060BE631FB)]
    public class TkModelRendererData : NMSTemplate
    {
        /* 0x00 */ public TkModelRendererCameraData Camera;
        /* 0x40 */ public float Fov;
        /* 0x44 */ public float AspectRatio;
		public enum ThumbnailModeEnum { None, HUD, GUI }
		/* 0x48 */ public ThumbnailModeEnum ThumbnailMode;
		public enum FocusTypeEnum { ResourceBounds, ResourceBoundingHeight, NodeBoundingBox, DiscoveryView }
		/* 0x4C */ public FocusTypeEnum FocusType;

        [NMS(Size = 0x20)]
        /* 0x50 */ public string FocusLocator;
        /* 0x70 */ public Vector3f FocusOffset;
        /* 0x80 */ public float FocusInterpTime;
        /* 0x84 */ public float BlendInTime;
        /* 0x88 */ public float BlendInOffset;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x8C */ public byte[] Padding8C;
        [NMS(Size = 0x10)]
        /* 0x90 */ public string Anim;
        /* 0xA0 */ public float HeightOffset;
        /* 0xA4 */ public bool UsePlayerCameraInHmd;
        /* 0xA5 */ public bool UseSensibleCameraFocusNodeIsNowOffsetNode;
        [NMS(Size = 0xA, Ignore = true)]
        /* 0xA6 */ public byte[] EndPadding;
    }
}
