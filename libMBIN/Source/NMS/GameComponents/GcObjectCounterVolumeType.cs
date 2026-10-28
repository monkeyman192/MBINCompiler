namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xADA1D9FEE1ED1C, NameHash = 0x5E967809)]
    public class GcObjectCounterVolumeType : NMSTemplate
    {
        // size: 0x4
        public enum CounterVolumeEnum : uint {
            Vehicle,
            ScrapYard,
            ScrapYardFullBounds,
            SpaceOutpostFullBounds,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CounterVolumeEnum CounterVolume;
    }
}
