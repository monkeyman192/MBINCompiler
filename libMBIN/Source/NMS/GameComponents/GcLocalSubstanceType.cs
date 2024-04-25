namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6ECC91CA241FAC30, NameHash = 0xE639CB6E87DF64B)]
    public class GcLocalSubstanceType : NMSTemplate
    {
        // size: 0x5
        public enum LocalSubstanceTypeEnum : uint {
            AnyDeposit,
            Common,
            Uncommon,
            Rare,
            Plant,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public LocalSubstanceTypeEnum LocalSubstanceType;
    }
}
