namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x84)]
    public class GcFreighterBaseOption : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string BaseDataFile;
        public float ProbabilityWeighting;
    }
}
