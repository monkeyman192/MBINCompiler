using System;
using System.Collections.Generic;
using System.Text;

using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x40)]
    public class SnSetShaderValue : NMSTemplate
    {
        public enum ValueEnum { UserDataX, UserDataY, UserDataZ, UserDataW }
        /* 0x00 */ public ValueEnum Value;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;
        [NMS(Size = 0x10)]
        /* 0x08 */ public string Node;
        /* 0x18 */ public float Duration;
        /* 0x1C */ public SnCurve Curve;
    }
}
