using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA0852E5D7B7DEA84, NameHash = 0xA5E5246F)]
    public class GcExternalObjectList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcEnvironmentSpawnData Objects;
    }
}
