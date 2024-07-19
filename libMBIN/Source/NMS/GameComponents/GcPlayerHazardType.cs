namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF8CE0E13EB01EA06, NameHash = 0xD76320A)]
    public class GcPlayerHazardType : NMSTemplate
    {
        // size: 0x6
        public enum HazardEnum : uint {
            None,
            NoOxygen,
            ExtremeHeat,
            ExtremeCold,
            ToxicGas,
            Radiation,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public HazardEnum Hazard;
    }
}
