using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x62F988675336AF3F, NameHash = 0xB81D78F21EBE37)]
    public class GcAlienSpeechEntry : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A Group;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x20A Text;
        [NMS(Index = 0)]
        /* 0x40 */ public NMSString0x10 Id;
        [NMS(Index = 3)]
        /* 0x50 */ public GcWordCategoryTableEnum Category;
        [NMS(Index = 4)]
        /* 0x54 */ public int Frequency;
        [NMS(Index = 7)]
        /* 0x58 */ public int Level;
        [NMS(Index = 6)]
        /* 0x5C */ public GcAlienRace Race;
        // size: 0x2
        public enum WordInteractEffectEnum : uint {
            Pain,
            Heal,
        }
        [NMS(Index = 5)]
        /* 0x60 */ public WordInteractEffectEnum WordInteractEffect;
    }
}
