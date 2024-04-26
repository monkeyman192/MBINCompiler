namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4FDA1EC6477A8B8C, NameHash = 0x3748852F6280E90F)]
    public class GcSpecialPetChatType : NMSTemplate
    {
        // size: 0x3
        public enum SpecialPetChatTypeEnum : uint {
            Monster,
            Quad,
            MiniRobo,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SpecialPetChatTypeEnum SpecialPetChatType;
    }
}
