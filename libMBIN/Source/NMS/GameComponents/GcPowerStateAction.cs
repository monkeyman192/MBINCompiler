namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4F97900670DEC029, NameHash = 0xAE81DAC6053A1B32)]
    public class GcPowerStateAction : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public bool SetConnectionEnabled;
        [NMS(Index = 0)]
        /* 0x1 */ public bool SetRateEnabled;
    }
}
