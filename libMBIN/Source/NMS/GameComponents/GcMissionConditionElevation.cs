using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9A67E041241A2597, NameHash = 0xD66DAD0E4E6333FB)]
    public class GcMissionConditionElevation : NMSTemplate
    {
        /* 0x0 */ public float HeightAboveSeas;
        /* 0x4 */ public bool AllowInShip;
        /* 0x5 */ public bool TakeAmountFromSeasonData;
    }
}
