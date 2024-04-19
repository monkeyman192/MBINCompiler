namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD616A0433497617, NameHash = 0xDFA8A7A9DD3ACC08)]
    public class GcAIShipDebugSpawnData : NMSTemplate
    {
        /* 0x00 */ public Vector3f Facing;
        /* 0x10 */ public Vector3f FlightDir;
        /* 0x20 */ public Vector3f Position;
        /* 0x30 */ public Vector3f Up;
        /* 0x40 */ public GcSeed Seed;
        /* 0x50 */ public float HoverHeight;
        /* 0x54 */ public float HoverTime;
        /* 0x58 */ public float IgnitionDelay;
        /* 0x5C */ public float Speed;
        /* 0x60 */ public float TakeOffDelay;
        /* 0x64 */ public float WarpOutTime;
        /* 0x68 */ public NMSString0x80 SpecificModel;
        /* 0xE8 */ public bool Wingman;
    }
}
