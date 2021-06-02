using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x110, GUID = 0xC5D08CF2DC317399, NameHash = 0x61016ED971A59B9A)]
    public class GcMissionSequenceDiscover : NMSTemplate      // size: 0x110
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public bool PerPlanet;
		public enum DiscoverTargetEnum { Animal, Vegetable, Mineral }
		public DiscoverTargetEnum DiscoverTarget;
        /* 0x088 */ public int AmountMin;
        /* 0x08C */ public int AmountMax;
        /* 0x090 */ public NMSString0x80 DebugText;
    }
}