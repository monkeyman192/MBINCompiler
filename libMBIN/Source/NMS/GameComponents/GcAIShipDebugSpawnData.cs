using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xF0, GUID = 0xC35F70F8B3C5471E, NameHash = 0xDFA8A7A9DD3ACC08)]
    public class GcAIShipDebugSpawnData : NMSTemplate
    {
        /* 0x00 */ public Vector3f Position;
        /* 0x10 */ public Vector3f Facing;
        /* 0x20 */ public Vector3f Up;
        /* 0x30 */ public Vector3f FlightDir;
        /* 0x40 */ public float Speed;
        /* 0x44 */ public float IgnitionDelay;
        /* 0x48 */ public float TakeOffDelay;
        /* 0x4C */ public float HoverTime;
        /* 0x50 */ public float HoverHeight;
        /* 0x54 */ public float WarpOutTime;
        /* 0x58 */ public bool Wingman;
        /* 0x59 */ public NMSString0x80 SpecificModel;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0xD9 */ public byte[] PaddingD9;
        /* 0xE0 */ public GcSeed Seed;
    }
}
