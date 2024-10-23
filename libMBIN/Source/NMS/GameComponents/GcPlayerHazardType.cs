namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB44DA798C0BB4F59, NameHash = 0xD76320A)]
    public class GcPlayerHazardType : NMSTemplate
    {
        // size: 0x7
        public enum HazardEnum : uint {
            None,
            NoOxygen,
            ExtremeHeat,
            ExtremeCold,
            ToxicGas,
            Radiation,
            Spook,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public HazardEnum Hazard;
    }
}
