namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x30)]
    public class GcAtmosphereEntryComponentData : NMSTemplate
    {
        public bool AutEntry;
        public float EntryTime;
        public float EntryOffset;
        public float EditTerrainRadius;
        [NMS(Size = 0x10)]
        public string ImpactEffect;
        [NMS(Size = 0x10)]
        public string FlareEffect;
    }
}
