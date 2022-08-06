using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEC5F0C21DD9275B0, NameHash = 0x6C0B3270B9591BB1)]
    public class GcConstraintsToCreateSpec : NMSTemplate
    {
        /* 0x00 */ public bool Horizontal_1x0;
        /* 0x04 */ public float PushingStrength_Horizontal_1x0;
        /* 0x08 */ public bool Vertical_1x0;
        /* 0x0C */ public float PushingStrength_Vertical_1x0;
        /* 0x10 */ public bool Diagonal_1x1_0011;
        /* 0x14 */ public float PushingStrength_Diagonal_1x1_0011;
        /* 0x18 */ public bool Diagonal_1x1_0110;
        /* 0x1C */ public float PushingStrength_Diagonal_1x1_0110;
        /* 0x20 */ public bool Horizontal_2x0;
        /* 0x24 */ public float PushingStrength_Horizontal_2x0;
        /* 0x28 */ public bool Vertical_2x0;
        /* 0x2C */ public float PushingStrength_Vertical_2x0;
        /* 0x30 */ public bool SkewedDiagonal_2x1_0021;
        /* 0x34 */ public float PushingStrength_SkewedDiagonal_2x1_0021;
        /* 0x38 */ public bool SkewedDiagonal_2x1_2001;
        /* 0x3C */ public float PushingStrength_SkewedDiagonal_2x1_2001;
        /* 0x40 */ public bool SkewedDiagonal_2x1_1002;
        /* 0x44 */ public float PushingStrength_SkewedDiagonal_2x1_1002;
        /* 0x48 */ public bool SkewedDiagonal_2x1_0012;
        /* 0x4C */ public float PushingStrength_SkewedDiagonal_2x1_0012;
    }
}
