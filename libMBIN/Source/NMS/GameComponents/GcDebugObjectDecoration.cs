namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDCE416001ECF6380, NameHash = 0xBC09F4D6)]
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
        [NMS(Index = 0)]
        /* 0x40 */ public VariableSizeString Filename;
        [NMS(Index = 1)]
        /* 0x50 */ public GcSeed Seed;
        [NMS(Index = 2)]
        /* 0x60 */ public GcResource Resource;
    }
}
