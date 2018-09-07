namespace libMBIN.Models.Structs
{
    public class GcMissionSequenceDiscover : NMSTemplate      // size: 0x110
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public bool PerPlanet;
		public enum DiscoverTargetEnum { Animal, Vegetable, Mineral }
		public DiscoverTargetEnum DiscoverTarget;
        /* 0x088 */ public int AmountMin;
        /* 0x08C */ public int AmountMax;
        [NMS(Size = 0x80)]
        /* 0x090 */ public string DebugText;
    }
}
