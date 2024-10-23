using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x51A72B88066B36CB, NameHash = 0x6C3ADDF9)]
    public class GcMissionConditionHazardLevel : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int Level;
        [NMS(Index = 1)]
        /* 0x4 */ public TkEqualityEnum Test;
    }
}
