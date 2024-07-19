using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x50690C9E38372126, NameHash = 0x873D6916)]
    public class GcBiomeFileListOption : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public VariableSizeString Filename;
        [NMS(Index = 3)]
        /* 0x10 */ public float PurpleSystemWeight;
        [NMS(Index = 0)]
        /* 0x14 */ public GcBiomeSubType SubType;
        [NMS(Index = 2)]
        /* 0x18 */ public float Weight;
    }
}
