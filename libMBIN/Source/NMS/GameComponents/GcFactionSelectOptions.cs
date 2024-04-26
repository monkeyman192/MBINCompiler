using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE0F3774C50B4F448, NameHash = 0x49D48E5A22491956)]
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
