namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x27012A46D9BE0F1C, NameHash = 0xC11BA0C4)]
    public class GcFreighterBaseOption : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public VariableSizeString BaseDataFile;
        [NMS(Index = 1)]
        /* 0x10 */ public float ProbabilityWeighting;
    }
}
