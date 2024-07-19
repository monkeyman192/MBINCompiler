namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x18E65DC6E8DC9DAA, NameHash = 0xA200B6EB)]
    public class GcAISpaceshipRoles : NMSTemplate
    {
        // size: 0x7
        public enum AIShipRoleEnum : uint {
            Standard,
            PlayerSquadron,
            Freighter,
            CapitalFreighter,
            SmallFreighter,
            TinyFreighter,
            Frigate,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public AIShipRoleEnum AIShipRole;
    }
}
