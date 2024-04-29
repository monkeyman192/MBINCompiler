namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF6E44946691E091B, NameHash = 0x840B4D8139B48954)]
    public class GcBirdData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public float FlapAccel;
        [NMS(Index = 2)]
        /* 0x04 */ public float FlapSpeed;
        [NMS(Index = 8)]
        /* 0x08 */ public float FlapSpeedForMaxScale;
        [NMS(Index = 7)]
        /* 0x0C */ public float FlapSpeedForMinScale;
        [NMS(Index = 1)]
        /* 0x10 */ public float FlapSpeedMax;
        [NMS(Index = 6)]
        /* 0x14 */ public float FlapSpeedMaxScale;
        [NMS(Index = 0)]
        /* 0x18 */ public float FlapSpeedMin;
        [NMS(Index = 5)]
        /* 0x1C */ public float FlapSpeedMinScale;
        [NMS(Index = 4)]
        /* 0x20 */ public float FlapTurn;
        [NMS(Index = 9)]
        /* 0x24 */ public NMSString0x80 CircleAttractor;
    }
}
