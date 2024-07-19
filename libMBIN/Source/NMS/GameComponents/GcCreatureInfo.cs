using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7B3166274161CC4B, NameHash = 0xB274DC61)]
    public class GcCreatureInfo : NMSTemplate
    {
        [NMS(Index = 15)]
        /* 0x000 */ public NMSString0x20A BiomeDesc;
        [NMS(Index = 17)]
        /* 0x020 */ public NMSString0x20A DietDesc;
        [NMS(Index = 18)]
        /* 0x040 */ public NMSString0x20A NotesDesc;
        [NMS(Index = 16)]
        /* 0x060 */ public NMSString0x20A TempermentDesc;
        // size: 0x2
        public enum AgeEnum : uint {
            Regular,
            Weird,
        }
        [NMS(Index = 0)]
        /* 0x080 */ public AgeEnum Age;
        [NMS(Index = 10)]
        /* 0x084 */ public float Height1;
        [NMS(Index = 12)]
        /* 0x088 */ public float Height2;
        [NMS(Index = 14)]
        /* 0x08C */ public GcRarity Rarity;
        [NMS(Index = 9)]
        /* 0x090 */ public float Weight1;
        [NMS(Index = 11)]
        /* 0x094 */ public float Weight2;
        [NMS(Index = 4)]
        /* 0x098 */ public NMSString0x80 Diet;
        [NMS(Index = 1)]
        /* 0x118 */ public NMSString0x80 Gender1;
        [NMS(Index = 2)]
        /* 0x198 */ public NMSString0x80 Gender2;
        [NMS(Index = 6)]
        /* 0x218 */ public NMSString0x80 Height1_NMSString0x80;
        [NMS(Index = 8)]
        /* 0x298 */ public NMSString0x80 Height2_NMSString0x80;
        [NMS(Index = 13)]
        /* 0x318 */ public NMSString0x80 Notes;
        [NMS(Index = 3)]
        /* 0x398 */ public NMSString0x80 Temperament;
        [NMS(Index = 5)]
        /* 0x418 */ public NMSString0x80 Weight1_NMSString0x80;
        [NMS(Index = 7)]
        /* 0x498 */ public NMSString0x80 Weight2_NMSString0x80;
    }
}
