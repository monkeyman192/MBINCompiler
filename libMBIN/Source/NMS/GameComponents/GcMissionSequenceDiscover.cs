namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEE9CFABE1CF4D7A, NameHash = 0x61016ED971A59B9A)]
    public class GcMissionSequenceDiscover : NMSTemplate
    {
        /* 0x000 */ public int AmountMax;
        /* 0x004 */ public int AmountMin;
        // size: 0x3
        public enum DiscoverTargetEnum : uint {
            Animal,
            Vegetable,
            Mineral,
        }
        /* 0x008 */ public DiscoverTargetEnum DiscoverTarget;
        /* 0x00C */ public NMSString0x80 DebugText;
        /* 0x08C */ public NMSString0x80 Message;
        /* 0x10C */ public bool PerPlanet;
        /* 0x10D */ public bool TakeAmountFromSeasonalData;
    }
}
