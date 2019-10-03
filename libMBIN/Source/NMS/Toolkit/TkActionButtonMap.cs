using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x28, GUID = 0xDC71F21BAB762453, NameHash = 0xC1A3BA40B3A88476)]
    public class TkActionButtonMap : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string ActionId;
        /* 0x10 */ public bool ScaleToFitFont;
        /* 0x14 */ public TkInputEnum PadButtonId; 
        /* 0x18 */ public List<TkPlatformButtonPair> Platforms;
    }
}
