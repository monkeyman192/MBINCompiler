namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB1EDCE8B90F846B4, NameHash = 0xCD8F8BFF2399836A)]
    public class GcResourceCollectEffect : NMSTemplate
    {
        [NMS(Index = 12)]
        /* 0x00 */ public float OffsetMax;
        [NMS(Index = 11)]
        /* 0x04 */ public float OffsetMin;
        [NMS(Index = 0)]
        /* 0x08 */ public float PlayerOffset;
        [NMS(Index = 4)]
        /* 0x0C */ public float RotateMax;
        [NMS(Index = 3)]
        /* 0x10 */ public float RotateMin;
        [NMS(Index = 2)]
        /* 0x14 */ public float SizeMax;
        [NMS(Index = 1)]
        /* 0x18 */ public float SizeMin;
        [NMS(Index = 6)]
        /* 0x1C */ public float StartOffsetMax;
        [NMS(Index = 5)]
        /* 0x20 */ public float StartOffsetMin;
        [NMS(Index = 10)]
        /* 0x24 */ public float StartSpeedMax;
        [NMS(Index = 9)]
        /* 0x28 */ public float StartSpeedMin;
        [NMS(Index = 8)]
        /* 0x2C */ public float TimeMax;
        [NMS(Index = 7)]
        /* 0x30 */ public float TimeMin;
    }
}
