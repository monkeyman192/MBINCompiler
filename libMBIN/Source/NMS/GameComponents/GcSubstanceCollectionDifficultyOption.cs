namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7356FAF37859706E, NameHash = 0x685F577065EC8459)]
    public class GcSubstanceCollectionDifficultyOption : NMSTemplate
    {
        // size: 0x3
        public enum SubstanceCollectionDifficultyEnum : uint {
            High,
            Normal,
            Low,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SubstanceCollectionDifficultyEnum SubstanceCollectionDifficulty;
    }
}
