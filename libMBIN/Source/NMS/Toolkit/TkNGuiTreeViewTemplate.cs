namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x62D59DFE20DC13BC, NameHash = 0x2B44FF66E5B6FEC1)]
    public class TkNGuiTreeViewTemplate : NMSTemplate
    {
        /* 0x00 */ public Colour FilteredTextColour;
        /* 0x10 */ public Colour HighlightColour;
        /* 0x20 */ public Colour InactiveTextColour;
        /* 0x30 */ public Colour LineColour;
        /* 0x40 */ public Colour TextColour;
        /* 0x50 */ public float ElementHeight;
        /* 0x54 */ public float IconMargin;
        /* 0x58 */ public float IconPad;
        /* 0x5C */ public float IconWidth;
        /* 0x60 */ public float LineWidth;
        /* 0x64 */ public float NestIndent;
        /* 0x68 */ public float VerticalSplitPad;
        /* 0x6C */ public float VerticalSplitWidth;
        /* 0x70 */ public bool AllowVerticalSplit;
        /* 0x71 */ public bool FilteringHidesElements;
    }
}
