namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEBD2B9A30628DD26, NameHash = 0xA2CE4FB30A13249B)]
    public class GcStatModifyType : NMSTemplate
    {
        // size: 0x3
        public enum ModifyTypeEnum : uint {
            Set,
            Add,
            Subtract,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ModifyTypeEnum ModifyType;
    }
}
