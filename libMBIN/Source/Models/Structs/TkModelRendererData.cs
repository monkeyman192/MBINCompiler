namespace libMBIN.Models.Structs
{
    [NMS(Size = 0xB0)]
    public class TkModelRendererData : NMSTemplate
    {
        /* 0x00 */ public TkModelRendererCameraData Camera;
        /* 0x40 */ public float Fov;
        /* 0x44 */ public float AspectRatio;
        /* 0x48 */ public int ThumbnailMode;
        public string[] ThumbnailModeValues()
        {
            return new[] { "None", "HUD", "GUI" };
        }
        /* 0x4C */ public int FocusType;
        public string[] FocusTypeValues()
        {
            return new[] { "ResourceBounds", "ResourceBoundingHeight", "NodeBoundingBox" };
        }

        [NMS(Size = 0x20)]
        /* 0x50 */ public string FocusLocator;
        /* 0x70 */ public Vector4f FocusOffset;
        /* 0x80 */ public float FocusInterpTime;
        /* 0x84 */ public float BlendInTime;
        /* 0x88 */ public float BlendInOffset;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x8C */ public byte[] Padding8C;

        [NMS(Size = 0x10)]
        /* 0x90 */ public string Anim;

        /* 0xA0 */ public float HeightOffset;
        /* 0xA4 */ public bool UseSensibleCameraFocusNodeIsNowOffsetNode;

        [NMS(Size = 0xB, Ignore = true)]
        /* 0xA5 */ public byte[] EndPadding;
    }
}
