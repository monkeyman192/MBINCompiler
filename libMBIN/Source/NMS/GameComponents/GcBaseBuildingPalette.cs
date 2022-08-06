using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD6070654B6235488, NameHash = 0xB499CC97C0515963)]
    public class GcBaseBuildingPalette : NMSTemplate
    {
        /* 0x00 */ public Colour PrimaryColour;
        /* 0x10 */ public Colour SecondaryColour;
        /* 0x20 */ public Colour TernaryColour;
        /* 0x30 */ public Colour QuaternaryColour;
        /* 0x40 */ public NMSString0x20A Name;
        /* 0x60 */ public NMSString0x20A Id;
        // size: 0x4
        public enum SwatchPrimaryColourEnum { Primary, Secondary, Ternary, Quaternary }
        /* 0x80 */ public SwatchPrimaryColourEnum SwatchPrimaryColour;
        // size: 0x4
        public enum SwatchSecondaryColourEnum { Primary, Secondary, Ternary, Quaternary }
        /* 0x84 */ public SwatchSecondaryColourEnum SwatchSecondaryColour;
    }
}
