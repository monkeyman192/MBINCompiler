using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8C87BB8BC3D1D36, NameHash = 0x171B22BB)]
    public class GcFactionSelectOptions : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public GcMissionFaction Faction;
        // size: 0x3
        public enum FactionOptionEnum : uint {
            DataDefined,
            CurrentMission,
            CurrentSystem,
        }
        [NMS(Index = 0)]
        /* 0x4 */ public FactionOptionEnum FactionOption;
    }
}
