namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3F14B5FCAAEFF5F, NameHash = 0x427E5329)]
    public class GcMissionConditionIsSurveying : NMSTemplate
    {
        // size: 0x4
        public enum ForHotspotTypeEnum : uint {
            Any,
            Power,
            Gas,
            Minerals,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ForHotspotTypeEnum ForHotspotType;
        [NMS(Index = 1)]
        /* 0x4 */ public bool RequireAlreadyAnalysed;
    }
}
