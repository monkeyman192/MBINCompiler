using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkModelRendererData : NMSTemplate // 0x70 bytes
    {
        public TkModelRendererCameraData Camera;
        public float Fov;
        public float AspectRatio;
        public int ThumbnailMode;
        public string[] ThumbnailModeValues()
        {
            return new[] { "None", "HUD", "GUI" };
        }
        public int FocusType;
        public string[] FocusTypeValues()
        {
            return new[] { "ResourceBounds", "ResourceBoundingHeight", "NodeBoundingBox" };
        }

        public NMSString0x10 Anim;

        public float HeightOffset;

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding64;
    }
}
