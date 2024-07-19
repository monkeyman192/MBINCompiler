namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9458BEB87AD22C4D, NameHash = 0x1829ECCC)]
    public class TkBlackboardCategory : NMSTemplate
    {
        // size: 0x3
        public enum BlackboardCategoryEnum : uint {
            Local,
            Archetype,
            PlayerControl,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BlackboardCategoryEnum BlackboardCategory;
    }
}
