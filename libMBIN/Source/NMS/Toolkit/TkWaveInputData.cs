namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB261AAEF6338017A, NameHash = 0x654F0023)]
    public class TkWaveInputData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int Count;
        [NMS(Index = 1)]
        /* 0x4 */ public float Strength;
        [NMS(Index = 2)]
        /* 0x8 */ public float Variance;
    }
}
