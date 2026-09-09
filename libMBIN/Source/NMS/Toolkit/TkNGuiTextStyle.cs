using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB16125FFAE650E78, NameHash = 0x6D1FFAE5)]
    public class TkNGuiTextStyle : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public TkNGuiTextStyleData Active;
        [NMS(Index = 0)]
        /* 0x3C */ public TkNGuiTextStyleData Default;
        [NMS(Index = 1)]
        /* 0x78 */ public TkNGuiTextStyleData Highlight;
    }
}
