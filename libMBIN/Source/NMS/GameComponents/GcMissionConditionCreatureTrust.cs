using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9FD7871984BA1631, NameHash = 0x28316096AAF55A2F)]
    public class GcMissionConditionCreatureTrust : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public TkEqualityEnum Test;
        [NMS(Index = 0)]
        /* 0x4 */ public float Trust;
    }
}
