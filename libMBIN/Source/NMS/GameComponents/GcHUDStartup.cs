using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0x2C3EFF4FE427F6D7, NameHash = 0x4B24756D3BA22E88)]
    public class GcHUDStartup : NMSTemplate
    {
        /* 0x00 */ public GcAudioWwiseEvents Audio;
        /* 0x04 */ public float Time;
    }
}
