namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD6F53AAC13DAE4D, NameHash = 0x83E66770853FCA27)]
    public class GcAlienPuzzleTableIndex : NMSTemplate
    {
        // size: 0x3
        public enum IndexTypeEnum : uint {
            Regular,
            Seeded,
            Random,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public IndexTypeEnum IndexType;
    }
}
