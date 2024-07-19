namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x974FA15CCF1DC507, NameHash = 0x595F5E29)]
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
