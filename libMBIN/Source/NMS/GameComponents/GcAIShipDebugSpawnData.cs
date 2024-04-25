namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD616A0433497617, NameHash = 0xDFA8A7A9DD3ACC08)]
    public class GcAIShipDebugSpawnData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector3f Facing;
        [NMS(Index = 3)]
        /* 0x10 */ public Vector3f FlightDir;
        [NMS(Index = 0)]
        /* 0x20 */ public Vector3f Position;
        [NMS(Index = 2)]
        /* 0x30 */ public Vector3f Up;
        [NMS(Index = 12)]
        /* 0x40 */ public GcSeed Seed;
        [NMS(Index = 8)]
        /* 0x50 */ public float HoverHeight;
        [NMS(Index = 7)]
        /* 0x54 */ public float HoverTime;
        [NMS(Index = 5)]
        /* 0x58 */ public float IgnitionDelay;
        [NMS(Index = 4)]
        /* 0x5C */ public float Speed;
        [NMS(Index = 6)]
        /* 0x60 */ public float TakeOffDelay;
        [NMS(Index = 9)]
        /* 0x64 */ public float WarpOutTime;
        [NMS(Index = 11)]
        /* 0x68 */ public NMSString0x80 SpecificModel;
        [NMS(Index = 10)]
        /* 0xE8 */ public bool Wingman;
    }
}
