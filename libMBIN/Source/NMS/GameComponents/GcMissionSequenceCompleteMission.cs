namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6AD8678FF75796A5, NameHash = 0xF582BA42)]
    public class GcMissionSequenceCompleteMission : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Mission;
        [NMS(Index = 1)]
        /* 0x20 */ public bool UseSeed;
    }
}
