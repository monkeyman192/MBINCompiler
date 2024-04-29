using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x616E48F2037DCC39, NameHash = 0xF94F95509B2D4135)]
    public class GcExternalObjectList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcEnvironmentSpawnData Objects;
    }
}
