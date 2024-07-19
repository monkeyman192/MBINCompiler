using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD232D9E91D59C8AB, NameHash = 0x6D1FFAE5)]
    public class TkNGuiTextStyle : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public TkNGuiTextStyleData Active;
        [NMS(Index = 0)]
        /* 0x60 */ public TkNGuiTextStyleData Default;
        [NMS(Index = 1)]
        /* 0xC0 */ public TkNGuiTextStyleData Highlight;
    }
}
