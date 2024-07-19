using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCF6D438E5FDAD7B7, NameHash = 0xDB129F97)]
    public class GcMissionConditionCreatureTrust : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public TkEqualityEnum Test;
        [NMS(Index = 0)]
        /* 0x4 */ public float Trust;
    }
}
