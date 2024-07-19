using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6931347182C2BDC9, NameHash = 0x8DE7D82B)]
    public class GcMissionConditionNumAtlasStationsVisited : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int Count;
        [NMS(Index = 1)]
        /* 0x4 */ public TkEqualityEnum Test;
    }
}
