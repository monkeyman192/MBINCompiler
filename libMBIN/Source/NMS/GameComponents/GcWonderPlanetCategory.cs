namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x974FA15CCF1DC507, NameHash = 0x1496B0F5A0E7C1DE)]
    public class GcWonderPlanetCategory : NMSTemplate
    {
        // size: 0xB
        public enum WonderPlanetCategoryEnum : uint {
            TemperatureMax,
            TemperatureMin,
            ToxicityMax,
            RadiationMax,
            AnomalyMax,
            RadiusMax,
            RadiusMin,
            AltitudeReachedMax,
            AltitudeReachedMin,
            PerfectionMax,
            PerfectionMin,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WonderPlanetCategoryEnum WonderPlanetCategory;
    }
}
