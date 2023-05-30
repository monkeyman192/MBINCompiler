using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkImGuiSettings : NMSTemplate // 0x190 bytes
    {
        public Colour BackgroundColour;
        public Colour WindowTitleColour;
        public Colour ActiveWindowTitleColour;
        public Colour WindowBackgroundColour;
        public Colour ActiveWindowBackgroundColour;
        public Colour WindowHighlight;
        public Colour TextColour;
        public Colour ActiveTextColour;
        public Colour TextShadowColour;
        public Colour TextDisabledColour;
        public Colour ButtonColour;
        public Colour ButtonHighlightColour;
        public Colour ButtonPressedColour;
        public Colour EditBoxColour;
        public Colour EditBoxActiveColour;
        public Colour EditBoxSelectedColour;
        public Colour TaskBarColour;
        public Colour TaskBarShadow;
        public Colour CloseButtonColour;
        public Colour CloseButtonHighlightColour;
        public Colour CloseButtonClickColour;
        public Colour MinimiseButtonColour;
        public Colour MinimiseButtonHighlightColour;
        public Colour MinimiseButtonClickColour;
        public float ScrollSpeed;
        public float AltPlacementDistanceScrollSpeed;

        [NMS(Size = 8, Ignore = true)]
        public byte[] Padding188;
    }
}
