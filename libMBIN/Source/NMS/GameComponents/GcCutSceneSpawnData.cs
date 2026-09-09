using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCA69E86CA2C41CE1, NameHash = 0xDAA4D8E3)]
    public class GcCutSceneSpawnData : NMSTemplate
    {
        [NMS(Index = 10)]
        /* 0x00 */ public Vector3f Facing;
        [NMS(Index = 9)]
        /* 0x10 */ public Vector3f Local;
        [NMS(Index = 8)]
        /* 0x20 */ public Vector3f Offset;
        [NMS(Index = 11)]
        /* 0x30 */ public Vector3f Up;
        [NMS(Index = 7)]
        /* 0x40 */ public GcResourceElement ResourceElement;
        [NMS(Index = 1)]
        /* 0x88 */ public NMSString0x10 Group;
        [NMS(Index = 2)]
        /* 0x98 */ public NMSString0x10 Id;
        [NMS(Index = 12)]
        /* 0xA8 */ public List<NMSTemplate> Modules;
        [NMS(Index = 6)]
        /* 0xB8 */ public GcSeed Seed;
        [NMS(Index = 3)]
        /* 0xC8 */ public GcFilename TrimmedPath;
        [NMS(Index = 0)]
        /* 0xD8 */ public int Guid;
        [NMS(Index = 4)]
        /* 0xDC */ public bool DebugDraw;
        [NMS(Index = 5)]
        /* 0xDD */ public bool EnableAI;
    }
}
