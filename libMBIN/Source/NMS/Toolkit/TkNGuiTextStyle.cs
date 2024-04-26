using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x424E9B3FF9745E24, NameHash = 0x55D8E71C0A29B511)]
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
