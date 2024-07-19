namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2F9589B5B3C4DAD5, NameHash = 0xC75CB36E)]
    public class TkAnimDetailSettingsData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float Distance;
        [NMS(Index = 2)]
        /* 0x4 */ public int NumCulledFrames;
        [NMS(Index = 1)]
        /* 0x8 */ public bool DisableAnim;
    }
}
