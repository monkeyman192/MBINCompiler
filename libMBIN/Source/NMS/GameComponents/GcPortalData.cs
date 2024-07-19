namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x80367B434FD777CD, NameHash = 0xFFA3CA8F)]
    public class GcPortalData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float RuneRotateTime;
        [NMS(Index = 2)]
        /* 0x4 */ public bool KnowAllRunes;
        [NMS(Index = 1)]
        /* 0x5 */ public bool SkipRuneEntry;
    }
}
