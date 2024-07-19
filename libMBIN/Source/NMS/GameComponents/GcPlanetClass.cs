namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x69BD755CF9F65D66, NameHash = 0x7202A230)]
    public class GcPlanetClass : NMSTemplate
    {
        // size: 0x3
        public enum PlanetClassEnum : uint {
            Default,
            Initial,
            InInitialSystem,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PlanetClassEnum PlanetClass;
    }
}
