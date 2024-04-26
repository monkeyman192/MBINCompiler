namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFDB46411B06AA1C, NameHash = 0x2A6BB71EAF092577)]
    public class GcNPCHabitationType : NMSTemplate
    {
        // size: 0x5
        public enum NPCHabitationTypeEnum : uint {
            WeaponsExpert,
            Farmer,
            Builder,
            Vehicles,
            Scientist,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NPCHabitationTypeEnum NPCHabitationType;
    }
}
