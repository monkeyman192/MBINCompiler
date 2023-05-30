using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkNGuiGraphicStyle : NMSTemplate
    {
        public TkNGuiGraphicStyleData Default;
        public TkNGuiGraphicStyleData Highlight;
        public TkNGuiGraphicStyleData Active;
        public float HighlightTime;
        public float HighlightScale;

        public int Animate;
        public string[] AnimateValues()
        { return new string[] { "None", "WipeRightToLeft", "SimpleWipe", "CustomWipe"}; }


        public float AnimTime;
        public float AnimSplit;
        public TkCurveType AnimCurve1;
        public TkCurveType AnimCurve2;

        public Vector2f CustomMinStart;
        public Vector2f CustomMaxStart;

        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding;
    }
}
