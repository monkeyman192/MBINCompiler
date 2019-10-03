using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x518, GUID = 0x6D659BA90940078D, NameHash = 0xE85F02E30BDAB35D)]
    public class GcCreatureInfo : NMSTemplate
    {
		public enum AgeEnum { Regular, Weird }
		public AgeEnum Age;

        [NMS(Size = 0x80)]
        public string Gender1;
        [NMS(Size = 0x80)]
        public string Gender2;
        [NMS(Size = 0x80)]
        public string Temperament;
        [NMS(Size = 0x80)]
        public string Diet;
        [NMS(Size = 0x80)]
        public string Weight1;
        [NMS(Size = 0x80)]
        public string Height1;
        [NMS(Size = 0x80)]
        public string Weight2;
        [NMS(Size = 0x80)]
        public string Height2;

        public float Weight1Float;
        public float Height1Float;
        public float Weight2Float;
        public float Height2Float;

        [NMS(Size = 0x80)]
        public string Notes;

        public GcRarity Rarity;

        [NMS(Size = 0x20)]
        public string BiomeDesc;
        [NMS(Size = 0x20)]
        public string TempermentDesc;
        [NMS(Size = 0x20)]
        public string DietDesc;
        [NMS(Size = 0x20)]
        public string NotesDesc;
    }
}
