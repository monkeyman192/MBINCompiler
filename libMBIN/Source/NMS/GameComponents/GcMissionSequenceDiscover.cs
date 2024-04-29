namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3C49276F00AF6FE5, NameHash = 0x61016ED971A59B9A)]
    public class GcMissionSequenceDiscover : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x000 */ public int AmountMax;
        [NMS(Index = 3)]
        /* 0x004 */ public int AmountMin;
        // size: 0x3
        public enum DiscoverTargetEnum : uint {
            Animal,
            Vegetable,
            Mineral,
        }
        [NMS(Index = 2)]
        /* 0x008 */ public DiscoverTargetEnum DiscoverTarget;
        [NMS(Index = 6)]
        /* 0x00C */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x08C */ public NMSString0x80 Message;
        [NMS(Index = 1)]
        /* 0x10C */ public bool PerPlanet;
        [NMS(Index = 5)]
        /* 0x10D */ public bool TakeAmountFromSeasonalData;
    }
}
