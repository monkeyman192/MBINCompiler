using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9B6B93F108A31AE, NameHash = 0xE85F02E30BDAB35D)]
    public class GcCreatureInfo : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A BiomeDesc;
        /* 0x020 */ public NMSString0x20A DietDesc;
        /* 0x040 */ public NMSString0x20A NotesDesc;
        /* 0x060 */ public NMSString0x20A TempermentDesc;
        // size: 0x2
        public enum AgeEnum : uint {
            Regular,
            Weird,
        }
        /* 0x080 */ public AgeEnum Age;
        /* 0x084 */ public float Height1;
        /* 0x088 */ public float Height2;
        /* 0x08C */ public GcRarity Rarity;
        /* 0x090 */ public float Weight1;
        /* 0x094 */ public float Weight2;
        /* 0x098 */ public NMSString0x80 Diet;
        /* 0x118 */ public NMSString0x80 Gender1;
        /* 0x198 */ public NMSString0x80 Gender2;
        /* 0x218 */ public NMSString0x80 Height1_NMSString0x80;
        /* 0x298 */ public NMSString0x80 Height2_NMSString0x80;
        /* 0x318 */ public NMSString0x80 Notes;
        /* 0x398 */ public NMSString0x80 Temperament;
        /* 0x418 */ public NMSString0x80 Weight1_NMSString0x80;
        /* 0x498 */ public NMSString0x80 Weight2_NMSString0x80;
    }
}
