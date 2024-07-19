namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6236E8940B8E506B, NameHash = 0x1361A1E3)]
    public class GcRewardActivateEncounterSentinels : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A EncounterComponentScanEvent;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 EncounterOverride;
    }
}
