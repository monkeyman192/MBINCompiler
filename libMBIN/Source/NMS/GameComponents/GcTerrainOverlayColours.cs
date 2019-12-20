using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x9FC4D65E7DF7EFBF, NameHash = 0x61E7123A54EFD252)]
    public class GcTerrainOverlayColours : NMSTemplate
    {
        /* 0x000 */ public float Cutoff;        // 3F000000h
        /* 0x004 */ public float Scale;         // 3DCCCCCDh
		/* 0x008 */ public float Strength;      // 3F800000h
		/* 0x00C */ public float FlightStrength;    // 3F800000h
		/* 0x010 */ public float PulseStrength;     // 3F800000h
		/* 0x014 */ public float PulsePeriod;       // 3F800000h
   }
}
