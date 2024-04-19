using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xBF8A4BFFAC520664, NameHash = 0xC1A3BA40B3A88476)]
    public class TkActionButtonMap : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ActionId;
        /* 0x10 */ public List<TkPlatformButtonPair> Platforms;
        /* 0x20 */ public TkInputEnum PadButtonId;
        /* 0x24 */ public bool ScaleToFitFont;
    }
}
