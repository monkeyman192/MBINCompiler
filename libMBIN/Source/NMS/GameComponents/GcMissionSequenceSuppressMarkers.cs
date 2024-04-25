namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x76DE5B0C8C8C5A15, NameHash = 0x18AA3675C5404DBD)]
    public class GcMissionSequenceSuppressMarkers : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public bool Suppressed;
        [NMS(Index = 1)]
        /* 0x1 */ public bool SuppressedAfterNextWarp;
    }
}
