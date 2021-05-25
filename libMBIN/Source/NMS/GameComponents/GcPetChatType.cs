using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0xD9ADC095DB54F0D3, NameHash = 0x51175DF2E4A2F863)]
    public class GcPetChatType : NMSTemplate
    {
        // size: 0x15
        public enum PetChatTypeEnum {
            Adopted, Hatched, Summoned, Greeting, Hazard, Scanning, PositiveEmote, HungryEmote, LonelyEmote, Go_There,
            Come_Here, Planet, Mine, Attack, Chase, ReceivedTreat, Tickled, Ride, Egg_Laid, Customise,
            Unsummoned
        }
        public PetChatTypeEnum PetChatType;
    }
}
