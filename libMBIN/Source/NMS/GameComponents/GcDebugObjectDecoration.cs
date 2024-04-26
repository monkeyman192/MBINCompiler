namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1021F746516C58DF, NameHash = 0x4E8FCD335520B579)]
    public class GcDebugObjectDecoration : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public Vector3f Facing;
        [NMS(Index = 4)]
        /* 0x10 */ public Vector3f Local;
        [NMS(Index = 3)]
        /* 0x20 */ public Vector3f Offset;
        [NMS(Index = 6)]
        /* 0x30 */ public Vector3f Up;
        [NMS(Index = 1)]
        /* 0x40 */ public GcSeed Seed;
        [NMS(Index = 2)]
        /* 0x50 */ public GcResource Resource;
        [NMS(Index = 0)]
        /* 0x54 */ public NMSString0x80 Filename;
    }
}
