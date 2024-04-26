namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x62D59DFE20DC13BC, NameHash = 0x2B44FF66E5B6FEC1)]
    public class TkNGuiTreeViewTemplate : NMSTemplate
    {
        [NMS(Index = 13)]
        /* 0x00 */ public Colour FilteredTextColour;
        [NMS(Index = 14)]
        /* 0x10 */ public Colour HighlightColour;
        [NMS(Index = 12)]
        /* 0x20 */ public Colour InactiveTextColour;
        [NMS(Index = 10)]
        /* 0x30 */ public Colour LineColour;
        [NMS(Index = 11)]
        /* 0x40 */ public Colour TextColour;
        [NMS(Index = 0)]
        /* 0x50 */ public float ElementHeight;
        [NMS(Index = 4)]
        /* 0x54 */ public float IconMargin;
        [NMS(Index = 3)]
        /* 0x58 */ public float IconPad;
        [NMS(Index = 5)]
        /* 0x5C */ public float IconWidth;
        [NMS(Index = 1)]
        /* 0x60 */ public float LineWidth;
        [NMS(Index = 2)]
        /* 0x64 */ public float NestIndent;
        [NMS(Index = 7)]
        /* 0x68 */ public float VerticalSplitPad;
        [NMS(Index = 6)]
        /* 0x6C */ public float VerticalSplitWidth;
        [NMS(Index = 9)]
        /* 0x70 */ public bool AllowVerticalSplit;
        [NMS(Index = 8)]
        /* 0x71 */ public bool FilteringHidesElements;
    }
}
