using System;
using System.Collections.Generic;
using System.Text;

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x8)]
    public class SnGetPlanetColour : NMSTemplate
    {
        // The actual data types are unknown as this struct doesn't seem to be used currently.
        // The actual data types are probably enums though.
        public int Palette;
        public int Colour;
        // IONode: Src
    }
}
