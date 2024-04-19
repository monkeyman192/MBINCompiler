namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x46D744585C16A122, NameHash = 0xFCFEF60947A44802)]
    public class GcRewardMission : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A AlreadyActiveFailureMessage;
        /* 0x20 */ public NMSString0x10 Mission;
        /* 0x30 */ public bool FailRewardIfMissionActive;
        /* 0x31 */ public bool Restart;
        /* 0x32 */ public bool SetAsSelected;
    }
}
