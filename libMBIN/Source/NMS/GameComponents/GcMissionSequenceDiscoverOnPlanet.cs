namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC36EF22C8FB1973C, NameHash = 0x368D06565D9CC1)]
    public class GcMissionSequenceDiscoverOnPlanet : NMSTemplate
    {
        // size: 0x3
        public enum DiscoverTargetOnThisPlanetEnum : uint {
            Animal,
            Vegetable,
            Mineral,
        }
        /* 0x00 */ public DiscoverTargetOnThisPlanetEnum DiscoverTargetOnThisPlanet;
        /* 0x04 */ public float PercentToDiscover;
        /* 0x08 */ public NMSString0x80 DebugText;
        /* 0x88 */ public NMSString0x80 Message;
    }
}
