using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFE60A713400C216D, NameHash = 0xAE176FE)]
    public class GcMissionConditionCheckScanEventMissionState : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Event;
        [NMS(Index = 1)]
        /* 0x20 */ public GcInteractionMissionState RequiredState;
        [NMS(Index = 2)]
        /* 0x24 */ public bool AlsoAcceptMaintenanceDone;
    }
}
