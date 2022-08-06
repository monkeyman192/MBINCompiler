using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8549E593D90CF8A9, NameHash = 0xF53E6F170BCA9237)]
    public class GcHeavyAirSettingValues : NMSTemplate
    {
        /* 0x00 */ public float Thickness;
        /* 0x04 */ public float Speed;
        /* 0x08 */ public float Alpha1;
        /* 0x0C */ public float Alpha2;
        /* 0x10 */ public TkPaletteTexture Colour1;
        /* 0x18 */ public TkPaletteTexture Colour2;
    }
}
