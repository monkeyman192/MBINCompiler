namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3479C5490B000372, NameHash = 0xE69F2F79)]
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
        [NMS(Index = 11)]
        /* 0x50 */ public VariableSizeString SpecificModel;
        [NMS(Index = 8)]
        /* 0x60 */ public float HoverHeight;
        [NMS(Index = 7)]
        /* 0x64 */ public float HoverTime;
        [NMS(Index = 5)]
        /* 0x68 */ public float IgnitionDelay;
        [NMS(Index = 4)]
        /* 0x6C */ public float Speed;
        [NMS(Index = 6)]
        /* 0x70 */ public float TakeOffDelay;
        [NMS(Index = 9)]
        /* 0x74 */ public float WarpOutTime;
        [NMS(Index = 10)]
        /* 0x78 */ public bool Wingman;
    }
}
