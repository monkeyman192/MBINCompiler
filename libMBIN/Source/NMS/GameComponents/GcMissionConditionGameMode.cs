using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5B2CCFCEF8A4B4BD, NameHash = 0xABD3E97536CBF8B1)]
    public class GcMissionConditionGameMode : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcGameMode Mode;
    }
}
