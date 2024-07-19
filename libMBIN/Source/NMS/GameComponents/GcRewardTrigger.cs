namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBED6BB0CFF772C81, NameHash = 0x52123420)]
    public class GcRewardTrigger : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Trigger;
        [NMS(Index = 1)]
        /* 0x10 */ public bool UseMasterModel;
    }
}
