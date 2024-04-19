namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD817E4B7355FC77, NameHash = 0x90485A00D3954CE2)]
    public class GcAtmosphereEntryComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 FlareEffect;
        /* 0x10 */ public NMSString0x10 ImpactEffect;
        /* 0x20 */ public float EditTerrainRadius;
        /* 0x24 */ public float EntryOffset;
        /* 0x28 */ public float EntryTime;
        /* 0x2C */ public bool AutoEntry;
    }
}
