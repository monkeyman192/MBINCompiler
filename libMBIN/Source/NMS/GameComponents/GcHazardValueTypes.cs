namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDBE375351057547B, NameHash = 0x8B58B508)]
    public class GcHazardValueTypes : NMSTemplate
    {
        // size: 0x5
        public enum HazardValueEnum : uint {
            Ambient,
            Water,
            Cave,
            Storm,
            Night,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public HazardValueEnum HazardValue;
    }
}
