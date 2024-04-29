using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC52AEB4046AE9D26, NameHash = 0xE2442EEFEFEF9518)]
    public class TkNoiseCaveData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkNoiseFeatureData Mouth;
        [NMS(Index = 1)]
        /* 0x40 */ public TkNoiseFeatureData Tunnel;
    }
}
