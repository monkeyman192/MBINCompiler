namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2571CDF9D84BBB3D, NameHash = 0xA96B440A)]
    public class GcMissionConditionIsFirstPurpleSystemLocal : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public VariableSizeString DifferentGalaxyTeleporterMessage;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString SameGalaxyTeleporterMessage;
    }
}
