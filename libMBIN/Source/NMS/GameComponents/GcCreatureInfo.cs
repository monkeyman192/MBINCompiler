using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x518, GUID = 0x6D659BA90940078D, NameHash = 0xE85F02E30BDAB35D)]
    public class GcCreatureInfo : NMSTemplate
    {
		public enum AgeEnum { Regular, Weird }
		public AgeEnum Age;

        public NMSString0x80 Gender1;
        public NMSString0x80 Gender2;
        public NMSString0x80 Temperament;
        public NMSString0x80 Diet;
        public NMSString0x80 Weight1;
        public NMSString0x80 Height1;
        public NMSString0x80 Weight2;
        public NMSString0x80 Height2;

        public float Weight1Float;
        public float Height1Float;
        public float Weight2Float;
        public float Height2Float;

        public NMSString0x80 Notes;

        public GcRarity Rarity;

        public NMSString0x20 BiomeDesc;
        public NMSString0x20 TempermentDesc;
        public NMSString0x20 DietDesc;
        public NMSString0x20 NotesDesc;
    }
}
