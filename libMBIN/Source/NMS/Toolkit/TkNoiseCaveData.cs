using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x83D138AEF21BAE3E, NameHash = 0xCD648C11)]
    public class TkNoiseCaveData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkNoiseFeatureData Mouth;
        [NMS(Index = 1)]
        /* 0x40 */ public TkNoiseFeatureData Tunnel;
    }
}
