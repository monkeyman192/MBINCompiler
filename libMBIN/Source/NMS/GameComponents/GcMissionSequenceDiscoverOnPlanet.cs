namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5FD2477653F6571A, NameHash = 0x1DF8AB15)]
    public class GcMissionSequenceDiscoverOnPlanet : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 1)]
        /* 0x10 */ public VariableSizeString Message;
        // size: 0x3
        public enum DiscoverTargetOnThisPlanetEnum : uint {
            Animal,
            Vegetable,
            Mineral,
        }
        [NMS(Index = 2)]
        /* 0x20 */ public DiscoverTargetOnThisPlanetEnum DiscoverTargetOnThisPlanet;
        [NMS(Index = 0)]
        /* 0x24 */ public float PercentToDiscover;
    }
}
