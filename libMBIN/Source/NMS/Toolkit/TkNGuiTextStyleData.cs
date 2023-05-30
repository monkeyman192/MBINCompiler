using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkNGuiTextStyleData : NMSTemplate
    {
        public Colour Colour;
        public float FontHeight;
        public float FontSpacing;

        public bool IsIndented;
        public bool HasDropShadow;

        [NMS(Size = 0x2, Ignore = true)]
        public byte[] Padding1;

        public float DropShadowOffset;
        public bool HasOutline;

        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding2;

        public float OutlineSize;
        public bool IsParagraph;
        public bool AllowScroll;
        public bool ForceUpperCase;
        public bool AutoAdjustHeight;
        public int FontIndex;
        public TkNGuiAlignment Align;

        [NMS(Size = 0x8, Ignore = true)]
        public byte[] Padding3;
    }
}
