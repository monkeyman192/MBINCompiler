using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xDE75B6D1912D4ED8, Size = 0x68, NameHash = 0xB81D78F21EBE37)]
    public class GcAlienSpeechEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public NMSString0x20A Text;
        /* 0x30 */ public NMSString0x20A Group;
        /* 0x50 */ public GcWordCategoryTableEnum Category;
        /* 0x54 */ public int Frequency;
        public enum WordInteractEffectEnum { Pain, Heal };
        /* 0x58 */ public WordInteractEffectEnum WordInteractEffect;

        /* 0x5C */ public GcAlienRace AlienRace;
        /* 0x60 */ public int Level;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x64 */ public byte[] EndPadding;
    }
}
