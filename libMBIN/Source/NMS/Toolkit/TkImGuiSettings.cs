namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9D328C98F0BCF55D, NameHash = 0xDCEADB8A)]
    public class TkImGuiSettings : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x000 */ public Colour ActiveTextColour;
        [NMS(Index = 4)]
        /* 0x010 */ public Colour ActiveWindowBackgroundColour;
        [NMS(Index = 2)]
        /* 0x020 */ public Colour ActiveWindowTitleColour;
        [NMS(Index = 0)]
        /* 0x030 */ public Colour BackgroundColour;
        [NMS(Index = 10)]
        /* 0x040 */ public Colour ButtonColour;
        [NMS(Index = 11)]
        /* 0x050 */ public Colour ButtonHighlightColour;
        [NMS(Index = 12)]
        /* 0x060 */ public Colour ButtonPressedColour;
        [NMS(Index = 20)]
        /* 0x070 */ public Colour CloseButtonClickColour;
        [NMS(Index = 18)]
        /* 0x080 */ public Colour CloseButtonColour;
        [NMS(Index = 19)]
        /* 0x090 */ public Colour CloseButtonHighlightColour;
        [NMS(Index = 14)]
        /* 0x0A0 */ public Colour EditBoxActiveColour;
        [NMS(Index = 13)]
        /* 0x0B0 */ public Colour EditBoxColour;
        [NMS(Index = 15)]
        /* 0x0C0 */ public Colour EditBoxSelectedColour;
        [NMS(Index = 23)]
        /* 0x0D0 */ public Colour MinimiseButtonClickColour;
        [NMS(Index = 21)]
        /* 0x0E0 */ public Colour MinimiseButtonColour;
        [NMS(Index = 22)]
        /* 0x0F0 */ public Colour MinimiseButtonHighlightColour;
        [NMS(Index = 16)]
        /* 0x100 */ public Colour TaskBarColour;
        [NMS(Index = 17)]
        /* 0x110 */ public Colour TaskBarShadow;
        [NMS(Index = 6)]
        /* 0x120 */ public Colour TextColour;
        [NMS(Index = 9)]
        /* 0x130 */ public Colour TextDisabledColour;
        [NMS(Index = 8)]
        /* 0x140 */ public Colour TextShadowColour;
        [NMS(Index = 3)]
        /* 0x150 */ public Colour WindowBackgroundColour;
        [NMS(Index = 5)]
        /* 0x160 */ public Colour WindowHighlight;
        [NMS(Index = 1)]
        /* 0x170 */ public Colour WindowTitleColour;
        [NMS(Index = 25)]
        /* 0x180 */ public float AltPlacementDistanceScrollSpeed;
        [NMS(Index = 24)]
        /* 0x184 */ public float ScrollSpeed;
    }
}
