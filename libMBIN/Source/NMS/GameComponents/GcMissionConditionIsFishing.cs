namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFC563FDA40F64820, NameHash = 0xE5ADFDFC)]
    public class GcMissionConditionIsFishing : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float MinimumDepth;
        [NMS(Index = 1)]
        /* 0x4 */ public bool TakeDepthFromSeasonData;
    }
}
