namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB012F23468B6487C, NameHash = 0xC217A4AF3130299A)]
    public class GcSolarSystemEventWarpOut : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public Vector2f WarpIntervalRange;
        [NMS(Index = 0)]
        /* 0x8 */ public float Time;
        [NMS(Index = 1)]
        /* 0xC */ public NMSString0x20 SquadName;
    }
}
