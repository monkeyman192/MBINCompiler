using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x62F988675336AF3F, NameHash = 0xB81D78F21EBE37)]
    public class GcAlienSpeechEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Group;
        /* 0x20 */ public NMSString0x20A Text;
        /* 0x40 */ public NMSString0x10 Id;
        /* 0x50 */ public GcWordCategoryTableEnum Category;
        /* 0x54 */ public int Frequency;
        /* 0x58 */ public int Level;
        /* 0x5C */ public GcAlienRace Race;
        // size: 0x2
        public enum WordInteractEffectEnum : uint {
            Pain,
            Heal,
        }
        /* 0x60 */ public WordInteractEffectEnum WordInteractEffect;
    }
}
