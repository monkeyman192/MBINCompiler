using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA4275B85714C6E7D, NameHash = 0x145940EF)]
    public class TkTriggerVolumeData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public TkVolumeTriggerType TriggerVolumeType;
    }
}
