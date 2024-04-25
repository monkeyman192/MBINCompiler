namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB51C8F9B01D93DC9, NameHash = 0x1BAC8ECF2C7CC8FC)]
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
