using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x99E67FED2F474E36, NameHash = 0xE2442EEFEFEF9518)]
    public class TkNoiseCaveData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkNoiseFeatureData Mouth;
        [NMS(Index = 1)]
        /* 0x40 */ public TkNoiseFeatureData Tunnel;
    }
}
