using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x28, GUID = 0x42889B52AB499583, NameHash = 0xC1A3BA40B3A88476)]
    public class TkActionButtonMap : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ActionId;
        /* 0x10 */ public bool ScaleToFitFont;
        /* 0x14 */ public TkInputEnum PadButtonId; 
        /* 0x18 */ public List<TkPlatformButtonPair> Platforms;
    }
}
