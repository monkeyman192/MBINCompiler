using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x14, GUID = 0xE134690B3AB11AF1, NameHash = 0xE4D4852DEDEE280B)]
    public class GcInteractionDof : NMSTemplate     // in global?
    {
        /* 0x00 */ public bool IsEnabled;           // 101h     (ie. including next byte)
        /* 0x01 */ public bool UseGlobals;
        /* 0x04 */ public float NearPlaneMin;       // 40000000h
        /* 0x08 */ public float NearPlaneAdjust;    // 3F800000h
        /* 0x0C */ public float FarPlane;           // 40400000h
        /* 0x10 */ public float FarFadeDistance;    // 40000000h
    }
}
