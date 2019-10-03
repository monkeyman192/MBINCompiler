using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x34, GUID = 0xA762E30993D934E3, NameHash = 0xCD8F8BFF2399836A)]
    public class GcResourceCollectEffect : NMSTemplate      // in GcPlayerGlobals
    {
        /* 0x000 */ public float PlayerOffset;
        /* 0x004 */ public float SizeMin;
        /* 0x008 */ public float SizeMax;
        /* 0x00C */ public float RotateMin;
        /* 0x010 */ public float RotateMax;
        /* 0x014 */ public float StartOffsetMin;
        /* 0x018 */ public float StartOffsetMax;
        /* 0x01C */ public float TimeMin;
        /* 0x020 */ public float TimeMax;
        /* 0x024 */ public float StartSpeedMin;
        /* 0x028 */ public float StartSpeedMax;
        /* 0x02C */ public float OffsetMin;
        /* 0x030 */ public float OffsetMax;
    }
}
