namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2445DF4216BF353C, NameHash = 0x34759FCB)]
    public class GcMissionSequenceDiscover : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 4)]
        /* 0x20 */ public int AmountMax;
        [NMS(Index = 3)]
        /* 0x24 */ public int AmountMin;
        // size: 0x3
        public enum DiscoverTargetEnum : uint {
            Animal,
            Vegetable,
            Mineral,
        }
        [NMS(Index = 2)]
        /* 0x28 */ public DiscoverTargetEnum DiscoverTarget;
        [NMS(Index = 1)]
        /* 0x2C */ public bool PerPlanet;
        [NMS(Index = 5)]
        /* 0x2D */ public bool TakeAmountFromSeasonalData;
    }
}
