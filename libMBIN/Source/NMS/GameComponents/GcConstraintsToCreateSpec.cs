namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2796FFF182A8F194, NameHash = 0x6C0B3270B9591BB1)]
    public class GcConstraintsToCreateSpec : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public float PushingStrength_Diagonal_1x1_0011;
        [NMS(Index = 7)]
        /* 0x04 */ public float PushingStrength_Diagonal_1x1_0110;
        [NMS(Index = 1)]
        /* 0x08 */ public float PushingStrength_Horizontal_1x0;
        [NMS(Index = 9)]
        /* 0x0C */ public float PushingStrength_Horizontal_2x0;
        [NMS(Index = 19)]
        /* 0x10 */ public float PushingStrength_SkewedDiagonal_2x1_0012;
        [NMS(Index = 13)]
        /* 0x14 */ public float PushingStrength_SkewedDiagonal_2x1_0021;
        [NMS(Index = 17)]
        /* 0x18 */ public float PushingStrength_SkewedDiagonal_2x1_1002;
        [NMS(Index = 15)]
        /* 0x1C */ public float PushingStrength_SkewedDiagonal_2x1_2001;
        [NMS(Index = 3)]
        /* 0x20 */ public float PushingStrength_Vertical_1x0;
        [NMS(Index = 11)]
        /* 0x24 */ public float PushingStrength_Vertical_2x0;
        [NMS(Index = 4)]
        /* 0x28 */ public bool Diagonal_1x1_0011;
        [NMS(Index = 6)]
        /* 0x29 */ public bool Diagonal_1x1_0110;
        [NMS(Index = 0)]
        /* 0x2A */ public bool Horizontal_1x0;
        [NMS(Index = 8)]
        /* 0x2B */ public bool Horizontal_2x0;
        [NMS(Index = 18)]
        /* 0x2C */ public bool SkewedDiagonal_2x1_0012;
        [NMS(Index = 12)]
        /* 0x2D */ public bool SkewedDiagonal_2x1_0021;
        [NMS(Index = 16)]
        /* 0x2E */ public bool SkewedDiagonal_2x1_1002;
        [NMS(Index = 14)]
        /* 0x2F */ public bool SkewedDiagonal_2x1_2001;
        [NMS(Index = 2)]
        /* 0x30 */ public bool Vertical_1x0;
        [NMS(Index = 10)]
        /* 0x31 */ public bool Vertical_2x0;
    }
}
