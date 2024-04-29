using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA14B4E6B8287B33F, NameHash = 0xF738BB4CB0090E06)]
    public class GcMissionConditionHasExocraft : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public GcVehicleType ExocraftType;
        [NMS(Index = 0)]
        /* 0x4 */ public bool SpecificExocraft;
    }
}
