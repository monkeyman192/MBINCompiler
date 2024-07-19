using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x188252AC96AFA105, NameHash = 0xA2754EA0)]
    public class GcBaseDefenceStatusAction : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcBaseDefenceStatusType TryState;
    }
}
