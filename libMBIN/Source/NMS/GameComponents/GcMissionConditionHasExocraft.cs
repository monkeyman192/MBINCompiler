using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8450C72D9D635E78, NameHash = 0xF738BB4CB0090E06)]
    public class GcMissionConditionHasExocraft : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public GcVehicleType ExocraftType;
        [NMS(Index = 0)]
        /* 0x4 */ public bool SpecificExocraft;
    }
}
