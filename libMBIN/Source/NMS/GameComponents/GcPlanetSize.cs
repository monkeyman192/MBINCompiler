namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF0DADAF6E563CFD9, NameHash = 0xE198F55796BC6E2F)]
    public class GcPlanetSize : NMSTemplate
    {
        // size: 0x4
        public enum PlanetSizeEnum : uint {
            Large,
            Medium,
            Small,
            Moon,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PlanetSizeEnum PlanetSize;
    }
}
