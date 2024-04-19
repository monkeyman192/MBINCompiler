namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7265157B9211E6C8, NameHash = 0x840B4D8139B48954)]
    public class GcBirdData : NMSTemplate
    {
        /* 0x00 */ public float FlapAccel;
        /* 0x04 */ public float FlapSpeed;
        /* 0x08 */ public float FlapSpeedForMaxScale;
        /* 0x0C */ public float FlapSpeedForMinScale;
        /* 0x10 */ public float FlapSpeedMax;
        /* 0x14 */ public float FlapSpeedMaxScale;
        /* 0x18 */ public float FlapSpeedMin;
        /* 0x1C */ public float FlapSpeedMinScale;
        /* 0x20 */ public float FlapTurn;
        /* 0x24 */ public NMSString0x80 CircleAttractor;
    }
}
