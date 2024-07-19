namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x615F4B1CDBC0E40E, NameHash = 0xE95619A4)]
    public class GcMissionSequenceShowSeasonTimeWarning : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x20 */ public float TimeToShow;
    }
}
