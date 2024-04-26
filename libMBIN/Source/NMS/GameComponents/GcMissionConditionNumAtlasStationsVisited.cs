using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFC8A3D56E7A276E7, NameHash = 0x4861EEE7B04EAB00)]
    public class GcMissionConditionNumAtlasStationsVisited : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int Count;
        [NMS(Index = 1)]
        /* 0x4 */ public TkEqualityEnum Test;
    }
}
