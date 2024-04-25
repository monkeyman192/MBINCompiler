namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x12CAC40DB6314D79, NameHash = 0x51175DF2E4A2F863)]
    public class GcPetChatType : NMSTemplate
    {
        // size: 0x15
        public enum PetChatTypeEnum : uint {
            Adopted,
            Hatched,
            Summoned,
            Greeting,
            Hazard,
            Scanning,
            PositiveEmote,
            HungryEmote,
            LonelyEmote,
            Go_There,
            Come_Here,
            Planet,
            Mine,
            Attack,
            Chase,
            ReceivedTreat,
            Tickled,
            Ride,
            Egg_Laid,
            Customise,
            Unsummoned,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PetChatTypeEnum PetChatType;
    }
}
