using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xA4, GUID = 0xC20488715E8586D1, NameHash = 0x840B4D8139B48954)]
    public class GcBirdData : NMSTemplate
    {
        /* 0x00 */ public float FlapSpeedMin;
        /* 0x04 */ public float FlapSpeedMax;
        /* 0x08 */ public float FlapSpeed;
        /* 0x0C */ public float FlapAccel;
        /* 0x10 */ public float FlapTurn;
        /* 0x14 */ public float FlapSpeedMinScale;
        /* 0x18 */ public float FlapSpeedMaxScale;
        /* 0x1C */ public float FlapSpeedForMinScale;
        /* 0x20 */ public float FlapSpeedForMaxScale;
        /* 0x24 */ public NMSString0x80 CircleAttractor;
    }
}