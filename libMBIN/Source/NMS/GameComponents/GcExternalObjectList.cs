using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x957522356CFED454, NameHash = 0xA5E5246F)]
    public class GcExternalObjectList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcEnvironmentSpawnData Objects;
    }
}
