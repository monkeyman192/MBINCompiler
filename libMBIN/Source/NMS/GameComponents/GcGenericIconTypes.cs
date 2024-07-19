namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC364E4B5E5B16679, NameHash = 0x5E14813E)]
    public class GcGenericIconTypes : NMSTemplate
    {
        // size: 0x6
        public enum GenericIconTypeEnum : uint {
            None,
            Interaction,
            SpaceStation,
            SpaceAnomaly,
            SpaceAtlas,
            Nexus,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public GenericIconTypeEnum GenericIconType;
    }
}
