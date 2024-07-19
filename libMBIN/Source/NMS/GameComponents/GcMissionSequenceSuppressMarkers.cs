namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x76DE5B0C8C8C5A15, NameHash = 0xF2A93C95)]
    public class GcMissionSequenceSuppressMarkers : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public bool Suppressed;
        [NMS(Index = 1)]
        /* 0x1 */ public bool SuppressedAfterNextWarp;
    }
}
