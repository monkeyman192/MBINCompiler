namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDF027FC6EF251E3D, NameHash = 0x232C5143BAE4E2F9)]
    public class GcMissionSequenceShowSeasonTimeWarning : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public float TimeToShow;
        [NMS(Index = 2)]
        /* 0x04 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x84 */ public NMSString0x80 Message;
    }
}
