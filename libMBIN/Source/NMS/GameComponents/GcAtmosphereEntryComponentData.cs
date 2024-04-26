namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD817E4B7355FC77, NameHash = 0x90485A00D3954CE2)]
    public class GcAtmosphereEntryComponentData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public NMSString0x10 FlareEffect;
        [NMS(Index = 4)]
        /* 0x10 */ public NMSString0x10 ImpactEffect;
        [NMS(Index = 3)]
        /* 0x20 */ public float EditTerrainRadius;
        [NMS(Index = 2)]
        /* 0x24 */ public float EntryOffset;
        [NMS(Index = 1)]
        /* 0x28 */ public float EntryTime;
        [NMS(Index = 0)]
        /* 0x2C */ public bool AutoEntry;
    }
}
