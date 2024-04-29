using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x685A7DBD1CFBDF3E, NameHash = 0xA1666CAA6E88F270)]
    public class GcBiomeFileListOption : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcBiomeSubType SubType;
        [NMS(Index = 2)]
        /* 0x4 */ public float Weight;
        [NMS(Index = 1)]
        /* 0x8 */ public NMSString0x80 Filename;
    }
}
