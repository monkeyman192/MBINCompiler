using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB1921CAD8FFF23B5, NameHash = 0x7E7DCFD2B65C6AD6)]
    public class GcCustomisationColourGroup : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 GroupID;
        /* 0x10 */ public NMSString0x20A Title;
        /* 0x30 */ public TkPaletteTexture Palette;
    }
}
