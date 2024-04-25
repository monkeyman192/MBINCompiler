namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7E1800728A66DF21, NameHash = 0xA3C86E46D2A8CA67)]
    public class GcFrigateClass : NMSTemplate
    {
        // size: 0x9
        public enum FrigateClassEnum : uint {
            Combat,
            Exploration,
            Mining,
            Diplomacy,
            Support,
            Normandy,
            DeepSpace,
            DeepSpaceCommon,
            Pirate,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FrigateClassEnum FrigateClass;
    }
}
