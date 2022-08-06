using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x70F15FEDCAE3687B, NameHash = 0x20F7F01AF38D19B2)]
    public class TkImGuiSettings : NMSTemplate
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
    }
}
