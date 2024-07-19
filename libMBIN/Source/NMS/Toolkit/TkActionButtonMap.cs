using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF092895F61D411C3, NameHash = 0xE30494B7)]
    public class TkActionButtonMap : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ActionId;
        [NMS(Index = 3)]
        /* 0x10 */ public List<TkPlatformButtonPair> Platforms;
        [NMS(Index = 2)]
        /* 0x20 */ public TkInputEnum PadButtonId;
        [NMS(Index = 1)]
        /* 0x24 */ public bool ScaleToFitFont;
    }
}
