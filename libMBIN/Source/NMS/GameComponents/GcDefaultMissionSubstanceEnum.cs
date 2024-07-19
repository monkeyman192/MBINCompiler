namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB51C8F9B01D93DC9, NameHash = 0xEF4406D)]
    public class GcDefaultMissionSubstanceEnum : NMSTemplate
    {
        // size: 0x3
        public enum DefaultSubstanceTypeEnum : uint {
            None,
            PrimarySubstance,
            SecondarySubstance,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public DefaultSubstanceTypeEnum DefaultSubstanceType;
    }
}
