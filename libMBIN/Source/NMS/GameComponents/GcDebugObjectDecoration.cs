namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1021F746516C58DF, NameHash = 0x4E8FCD335520B579)]
    public class GcDebugObjectDecoration : NMSTemplate
    {
        /* 0x00 */ public Vector3f Facing;
        /* 0x10 */ public Vector3f Local;
        /* 0x20 */ public Vector3f Offset;
        /* 0x30 */ public Vector3f Up;
        /* 0x40 */ public GcSeed Seed;
        /* 0x50 */ public GcResource Resource;
        /* 0x54 */ public NMSString0x80 Filename;
    }
}
