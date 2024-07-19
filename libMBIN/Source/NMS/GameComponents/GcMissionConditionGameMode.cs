using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9B1FAB5B33960EE5, NameHash = 0x5D36F975)]
    public class GcMissionConditionGameMode : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcGameMode Mode;
    }
}
