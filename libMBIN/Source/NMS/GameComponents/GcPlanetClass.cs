namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x69BD755CF9F65D66, NameHash = 0x9EB26F87ECDE68DC)]
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
